using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Db.Enums.Data;
using VegunSoft.Framework.Db.Models;
using VegunSoft.Framework.Db.Services;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums;
using VegunSoft.Framework.Gui.Provider.WindowsForms;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Services;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Services.Filter;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Services.Mgmt;
using VegunSoft.Framework.Gui.Services;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Message.Service.App;
using VegunSoft.Session.Model.Business;
using VegunSoft.Session.Repository.Business;
using VegunSoft.Session.Service.User;

namespace VegunSoft.Base.View.Dev.UserControls
{
    public partial class UcBase : UserControl
    {
        protected static IServiceDataSession Dbs => GDb.Dbs;

      

        private static IIocService _dbIoc;
        protected static IIocService DbIoc => _dbIoc ?? (_dbIoc = XIoc.GetService(CDb.IocKey));

        private static IIocService _guiIoc;
        protected static IIocService GuiIoc => _guiIoc ?? (_guiIoc = XIoc.GetService(CGui.IocKey));

        private IRepositorySession _repositorySession;
        protected IRepositorySession RepositorySession => _repositorySession ?? (_repositorySession = DbIoc.GetInstance<IRepositorySession>());

        protected ILogin Login => RepositorySession?.GetLogin(SessionCode);

        protected bool IsSupperAdmin => (Login?.IsSupperAdmin ?? false);

        private string _sessionCode;
        protected string SessionCode => _sessionCode ?? (_sessionCode = XForm.GetSessionCode(this));

        private IAppMessage _msg;
        protected IAppMessage Msg => _msg ?? (_msg = GuiIoc.GetInstance<IAppMessage>());

        private IIconService _iconService;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        protected IIconService IconService => _iconService ?? (_iconService = GuiIoc.GetInstance<IIconService>());

        private static ICheckRightsService _checkRightsService;
        protected static ICheckRightsService CheckRightsService => _checkRightsService ?? (_checkRightsService = GuiIoc.GetInstance<ICheckRightsService>());

        

        private IColumnIndexer _columnIndexer;
        protected IColumnIndexer ColumnIndexer => _columnIndexer ?? (_columnIndexer = GuiIoc.GetInstance<IColumnIndexer>(EGui.WindowsFormsDevExpress));

        private IContextMenuService _menuService;
        protected IContextMenuService MenuService => _menuService ?? (_menuService = GuiIoc.GetInstance<IContextMenuService>(EGui.WindowsFormsDevExpress));

        private IDateTimesService _dc;
        protected IDateTimesService Dc => _dc ?? (_dc = GuiIoc.GetInstance<IDateTimesService>(EGui.WindowsFormsDevExpress).Init(OnShowDateTimeMessage));

        public virtual string RightsCode { get; set; }

      

        protected virtual string DataName { get; } = "thông tin";
        private void OnShowDateTimeMessage(string mesage)
        {
            Msg?.ShowInfo(mesage, true);
        }

        protected RepositoryItemHyperLinkEdit DisableRepositoryItem { get; set; } = new RepositoryItemHyperLinkEdit()
        {
            Enabled = false
        };

      


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
