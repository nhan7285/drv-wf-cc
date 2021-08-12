using System;
using System.Threading;
using VegunSoft.App.Data;
using VegunSoft.App.Data.Business;
using VegunSoft.App.Service.Mgmt;
using VegunSoft.Base.Model.Business;
using VegunSoft.Base.View.Dev.UserControls;
using VegunSoft.Framework.Gui.Provider.WindowsForms;
using VegunSoft.Framework.Methods;

namespace VegunSoft.App.View.Dev.UserControls
{
    public class UcBaseApp: UcBase
    {
        protected bool IsDoubleClickEdit => VApp.IsDoubleClickEdit;

        private IFormMgmt _formMgmt;
        protected IFormMgmt FormMgmt
        {
            get
            {
                if (_formMgmt == null) _formMgmt = XForm.GetInstance<IFormMgmt>(this);
                return _formMgmt;
            }
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
                        var successTpl = isNew ? EMsg.SavingNewSuccessTpl : EMsg.SavingSuccessTpl;
                        Msg.ShowInfo(string.Format(successTpl.GetText(), name, returnName), true); ;
                    }
                    else
                    {
                        FormMgmt.CheckConnections();
                    }
                }));
            }).Start();

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

    }
}
