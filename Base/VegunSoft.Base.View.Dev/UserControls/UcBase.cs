using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using VegunSoft.Acc.Entity.Rights;
using VegunSoft.Acc.Repository.Business;
using VegunSoft.App.Service.Mgmt;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Db.Enums.Data;
using VegunSoft.Framework.Db.Models;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums;
using VegunSoft.Framework.Gui.Provider.WindowsForms;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Services;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Services.Filter;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Services.Mgmt;
using VegunSoft.Framework.Gui.Services;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Framework.Methods;
using VegunSoft.Layer.EValue.Message;
using VegunSoft.Layer.Model.Basic;
using VegunSoft.Message.Service.App;
using VegunSoft.Session.Repository.Business;
using VegunSoft.Session.Service.User;

namespace VegunSoft.Base.View.Dev.UserControls
{
    public partial class UcBase : UserControl
    {
        private static IIocService _dbIoc;
        protected static IIocService DbIoc => _dbIoc ?? (_dbIoc = XIoc.GetService(CDb.IocKey));

        private static IIocService _guiIoc;
        protected static IIocService GuiIoc => _guiIoc ?? (_guiIoc = XIoc.GetService(CGui.IocKey));

        private IRepositorySession _repositorySession;
        protected IRepositorySession RepositorySession => _repositorySession ?? (_repositorySession = DbIoc.GetInstance<IRepositorySession>());

        private string _sessionCode;
        protected string SessionCode => _sessionCode ?? (_sessionCode = XForm.GetSessionCode(this));

        private IAppMessage _msg;
        protected IAppMessage Msg => _msg ?? (_msg = GuiIoc.GetInstance<IAppMessage>());

        private IIconService _iconService;
        protected IIconService IconService => _iconService ?? (_iconService = GuiIoc.GetInstance<IIconService>());

        private static ICheckRightsService _checkRightsService;
        protected static ICheckRightsService CheckRightsService => _checkRightsService ?? (_checkRightsService = GuiIoc.GetInstance<ICheckRightsService>());

        private IRepositoryUserAccount _repositoryUserAccount;
        protected IRepositoryUserAccount RepositoryUserAccount => _repositoryUserAccount ?? (_repositoryUserAccount = DbIoc.GetInstance<IRepositoryUserAccount>());

        private IColumnIndexer _columnIndexer;
        protected IColumnIndexer ColumnIndexer => _columnIndexer ?? (_columnIndexer = GuiIoc.GetInstance<IColumnIndexer>(EGui.WindowsFormsDevExpress));

        private IContextMenuService _menuService;
        protected IContextMenuService MenuService => _menuService ?? (_menuService = GuiIoc.GetInstance<IContextMenuService>(EGui.WindowsFormsDevExpress));

        private IDateTimesService _dc;
        protected IDateTimesService Dc => _dc ?? (_dc = GuiIoc.GetInstance<IDateTimesService>(EGui.WindowsFormsDevExpress).Init(OnShowDateTimeMessage));

        public virtual string RightsCode { get; set; }

        private IRangeModel _rangeModel;
        protected IRangeModel RangeModel => _rangeModel ?? (_rangeModel = CheckRightsService.GetDateRange(SessionCode, RightsCode));

        protected virtual string DataName { get; } = "thông tin";
        private void OnShowDateTimeMessage(string mesage)
        {
            Msg?.ShowInfo(mesage, true);
        }

        protected RepositoryItemHyperLinkEdit DisableRepositoryItem { get; set; } = new RepositoryItemHyperLinkEdit()
        {
            Enabled = false
        };

        private IFormMgmt _formMgmt;
        protected IFormMgmt FormMgmt
        {
            get
            {
                if (_formMgmt == null) _formMgmt = XForm.GetInstance<IFormMgmt>(this);
                return _formMgmt;
            }
        }


        protected Control FindParent(object rootParent)
        {
            if (rootParent != null && rootParent is Control) return rootParent as Control;
            return this;
        }

        protected void SaveAsync<T>(T entity, GridView view, Action<T> beforeSaveAcion, Action<T, List<string>, List<string>> saveAsyncAcion, Action<T> endUIAcion)
        {
            var focusedRowHandle = view.FocusedRowHandle;
            beforeSaveAcion?.Invoke(entity);
            view.RefreshRow(focusedRowHandle);
            Msg.ClearMessages();
            Msg.ShowInfo($"Đang lưu dòng {focusedRowHandle}...", true);
            var t = new Thread(() => {
                
                var listMesages = new List<string>();
                var listErrors = new List<string>();
                saveAsyncAcion?.Invoke(entity, listMesages, listErrors);
                var msgText = listMesages.Count > 0 ? string.Join(Environment.NewLine, listMesages): string.Empty;
                var msgErrors = listErrors.Count > 0 ? string.Join(Environment.NewLine, listErrors) : string.Empty;
                this.Invoke(new Action(() =>
                {
                    endUIAcion?.Invoke(entity);
                    view.RefreshRow(focusedRowHandle);
                    if(!string.IsNullOrWhiteSpace(msgText)) Msg.ShowInfo(msgText, true);
                    if(!string.IsNullOrWhiteSpace(msgErrors)) Msg.ShowError(msgText);
                }));


            });
            t.IsBackground = true;
            t.Start();
        }

        protected void RunAsyncDbSesion(Func<object> asyncAction, object rootParent, Action<object> uiAction = null)
        {
            Msg?.ClearMessages();
            var p = FindParent(rootParent);
            p.Enabled = false;
            var canRequestDb = FormMgmt.CanRequestDb();
            if (canRequestDb)
            {
                new Thread(() =>
                {
                    var ds = asyncAction?.Invoke();

                    Invoke(new Action(() =>
                    {
                        if (uiAction != null) uiAction.Invoke(ds);
                        p.Enabled = true;
                    }));
                }).Start(); ;
               
            }
            else
            {
                Msg.ShowNetworkError();
            }
            p.Enabled = true;
        }

        protected void RunSaveDbSesion(Action action, object rootParent)
        {
            Msg?.ClearMessages();
            var p = FindParent(rootParent);
            p.Enabled = false;
            var canRequestDb = FormMgmt.CanRequestDb();
            if (canRequestDb)
            {
                action?.Invoke();
                p.Enabled = true;
            }
            else
            {
                p.Enabled = true;
                Msg.ShowNetworkError();
            }
           
        }

        protected void RunSaveDbSesion<TConfig, TResult>(Func<TConfig> uiCheckAction, Func<TConfig, TResult> asyncAction, Action<TConfig, TResult> uiAction, object rootParent)
            where TConfig : class, ISaveConfig
            where TResult : class, ISaveResult
        {
            Msg?.ClearMessages();
            var config = uiCheckAction.Invoke();
            if (config == null) return;
            var name = config?.Name;
            var isNew = config?.IsNew ?? false;
            FormMgmt.StartDbSesion();
            Msg.ShowInfo(string.Format(EMsg.StartSaveTpl.GetText(), name), true);
            var p = FindParent(rootParent);
            p.Enabled = false;
            new Thread(() =>
            {
                TResult result = null;
                var canRequestDb = FormMgmt.CanRequestDb();
                if (canRequestDb)
                {
                    Msg.ShowAsyncInfo(this, string.Format(EMsg.SavingTpl.GetText(), name));
                    result = asyncAction?.Invoke(config) ?? default;
                }
                else
                {
                    Invoke(new Action(() =>
                    {
                        Msg.ShowNetworkError();
                        p.Enabled = true;
                    }));
                   
                    return;
                }
                Invoke(new Action(() =>
                {
                    var isSaveSuccess = result?.IsSuccess ?? false;
                    var isSuccess = FormMgmt.EndDbSesion() && isSaveSuccess;
                    try
                    {
                        Msg.ShowAsyncInfo(this, "Đang hiển thị dữ liệu...");
                        uiAction?.Invoke(config, result);
                    }
                    catch (Exception e)
                    {
                        Msg.ShowException(e);
                    }
                    p.Enabled = true;
                    var msg = result?.Message ?? string.Empty;
                    if (!string.IsNullOrWhiteSpace(msg))
                    {
                        if (isSaveSuccess)
                        {
                            Msg.ShowInfo(msg);
                        }
                        else
                        {
                            Msg.ShowError(msg);
                        }
                    }
                    if (isSuccess)
                    {
                        var returnName = result?.ReturnName ?? string.Empty;
                        var successTpl = isNew? EMsg.SavingNewSuccessTpl : EMsg.SavingSuccessTpl;
                        Msg.ShowInfo(string.Format(successTpl.GetText(), name, returnName), true); ;
                    }
                    else
                    {
                        FormMgmt.CheckConnections();
                    }
                }));
            }).Start();

        }

        protected void RunGetDbSesion<T>(T oldDataSource, Func<T, T> asyncAction, Action<T> uiAction) where T : class
        {
            FormMgmt.StartDbSesion();
            Msg.ShowInfo("Loading...", true);
            Enabled = false;
            new Thread(() =>
            {
                T ds = oldDataSource;
                var canRequestDb = FormMgmt.CanRequestDb();
                if (canRequestDb)
                {
                    Msg.ShowAsyncInfo(this, "Đang lấy dữ liệu...");
                    ds = asyncAction?.Invoke(oldDataSource) ?? default;
                    Msg.ShowAsyncInfo(this, "Sẽ hiển thị dữ liệu mới...");
                }
                else
                {
                    Invoke(new Action(() =>
                    {
                        Msg.ShowNetworkError();
                    }));

                    Msg.ShowAsyncInfo(this, "Sẽ hiển thị dữ liệu cũ...");
                }
                Invoke(new Action(() =>
                {
                    var isSuccess = FormMgmt.EndDbSesion();
                    try
                    {
                        Msg.ShowAsyncInfo(this, "Đang hiển thị dữ liệu...");
                        uiAction?.Invoke(ds);
                        Msg.ShowInfo("Hoàn thành!", true);
                    }
                    catch (Exception e)
                    {
                        Msg.ShowException(e);
                    }
                    Enabled = true;
                    if (isSuccess)
                    {
                        Msg.ShowHelpMessage(this);
                    }
                    else
                    {
                        FormMgmt.CheckConnections();
                    }
                }));
            }).Start();

        }

        protected bool CanPrint(string rightsCode)
        {
            return CheckRightsService.CheckCanPrint(SessionCode, rightsCode, true);
        }

        protected void ClickPrint(Func<bool> func, string rightsCode)
        {
            if (CanPrint(rightsCode))
            {
                func?.Invoke();
            }
        }

        protected static Control FindParent<T>(Control theControl) where T: Control
        {
            Control rControl = null;

            if (theControl.Parent != null)
            {
                if (theControl.Parent.GetType() == typeof(T))
                {
                    rControl = theControl.Parent;
                }
                else

                {
                    rControl = FindParent<T>(theControl.Parent);
                }
            }
            else
            {
                rControl = null;
            }
            return rControl;
        }

        protected void ApplyCrudFormat(GridView view, RowCellStyleEventArgs e)
        {
            if (view.GetRow(e.RowHandle) is IModelBasic model)
            {
                if (model.Action == EMgmtCase.Insert || model.Action == EMgmtCase.InsertMany)
                {
                    e.Appearance.ForeColor = Color.FromArgb(0, 128, 43);
                }
                else if (model.Action == EMgmtCase.Update || model.Action == EMgmtCase.UpdateMany)
                {
                    e.Appearance.ForeColor = Color.FromArgb(0, 0, 230);
                }
                else if (model.Action == EMgmtCase.Delete || model.Action == EMgmtCase.DeleteMany)
                {
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Strikeout);
                }
                else if (model.Action == EMgmtCase.Refresh)
                {
                    e.Appearance.ForeColor = Color.FromArgb(153, 0, 204);
                }
                else if (model.Action == EMgmtCase.Value)
                {
                    e.Appearance.ForeColor = Color.FromArgb(230, 0, 0);
                }
            }
        }

        protected Control GetLoadingControl()
        {
            if (Controls.Count == 1) return Controls[0];
            return this;
        }

        protected Control ShowLoading(Control uc = null)
        {
            if (uc == null) uc = GetLoadingControl();
            uc.Enabled = false;
            return uc;
        }

        protected void CloseLoading(Control uc = null)
        {
            if (uc == null) uc = GetLoadingControl();
            uc.Enabled = true;
        }

        protected void ApplyAddingColumnStatus(GridColumn c, bool canChangeTime)
        {
            c.Visible = canChangeTime;
            c.OptionsColumn.ReadOnly = !canChangeTime;
            if (!canChangeTime) c.Fixed = FixedStyle.None;
            //c.OptionsColumn.AllowShowHide = canChangeTime;
        }

        protected virtual bool IsReadOnlyMultiDate => false;
    }
}
