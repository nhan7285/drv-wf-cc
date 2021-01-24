using System;
using System.Windows.Forms;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Layer.UcService.Base.Mgmt;
using VegunSoft.Session.Service.User;

namespace VegunSoft.Layer.UcService.Base.Provider.Mgmt
{
    public class UiServiceMgmt : IUiServiceMgmt
    {
        #region Init

        public string RightsCode { get; set; }

        public string SessionCode { get; set; }

        public object Uc { get; set; }

        protected Control Control => Uc as Control;

        #endregion

        private static IIocService _dbIoc;
        protected static IIocService DbIoc => _dbIoc ?? (_dbIoc = XIoc.GetService(CDb.IocKey));

        private static IIocService _guiIoc;
        protected static IIocService GuiIoc => _guiIoc ?? (_guiIoc = XIoc.GetService(CGui.IocKey));

        private ICheckRightsService _checkRightsService;
        protected ICheckRightsService CheckRightsService => _checkRightsService ?? (_checkRightsService = GuiIoc.GetInstance<ICheckRightsService>());

        #region Check

        public void Init(object uc, string rightsCode, string sessionCode)
        {
            Uc = uc;
            RightsCode = rightsCode;
            SessionCode = sessionCode;
        }

        public bool CanOpen(string rightsCode = null)
        {
            if (string.IsNullOrWhiteSpace(rightsCode)) rightsCode = RightsCode;
            return CheckRightsService.CheckCanShow(SessionCode, rightsCode, true);
        }

        public bool CanExport(string rightsCode = null)
        {
            if (string.IsNullOrWhiteSpace(rightsCode)) rightsCode = RightsCode;
            return CheckRightsService.CheckCanExport(SessionCode, rightsCode, true);
        }

        public bool CanPrint(string rightsCode = null)
        {
            if (string.IsNullOrWhiteSpace(rightsCode)) rightsCode = RightsCode;
            return CheckRightsService.CheckCanPrint(SessionCode, rightsCode, true);
        }

        #endregion

        #region Click

        public void ClickExport(Func<bool> func, string rightsCode = null)
        {
            if (CanExport(rightsCode))
            {
                func?.Invoke();
            }
        }

        public void ClickPrint(Func<bool> func, string rightsCode = null)
        {
            if (CanPrint(rightsCode))
            {
                func?.Invoke();
            }
        }
        #endregion

        #region Loading

        public T GetLoadingControl<T>(T uc = null) where T : class
        {
            if (uc == null)
            {
                if (Control.Controls.Count == 1) uc = Control.Controls[0] as T;
                else uc = Uc as T;
            }
            return uc;
        }

        public void ShowLoading<T>(T uc = null) where T : class
        {
            uc = GetLoadingControl(uc);
            if (uc != null && uc is Control control) control.Enabled = false;
        }

        public void CloseLoading<T>(T uc = null) where T : class
        {
            uc = GetLoadingControl<T>(uc);
            if (uc != null && uc is Control control) control.Enabled = true;
        }

        #endregion
    }
}
