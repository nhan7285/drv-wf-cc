using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VegunSoft.App.Config.Provider;
using VegunSoft.Base.View.Service.Services;
using VegunSoft.Company.Repository.Structure;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Db.Services;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums;
using VegunSoft.Framework.Gui.Forms;
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

namespace VegunSoft.Base.View.Dev.Forms
{
    public class FBase : XtraForm
    {

        protected static ISystemState Sys => SApp.Sys;
        protected static IServiceDataSources Dbc => GDb.Dbc;

        protected static IServiceDataSession Dbs => GDb.Dbs;
        protected IServiceConnection Cnn => Dbs.GetConnection(Dbs.SessionCode);

      

        protected Form ShellForm => Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ISessionForm);

        protected virtual string RightsCode { get; }

        private IUiServiceMgmt _uiService;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IUiServiceMgmt UiService => _uiService ?? (_uiService = ViewService);

        protected IUiServiceMgmt ViewService
        {
            get
            {
                var service = GuiIoc.GetInstance<IUiServiceMgmt>();
                service.Uc = this;
                service.RightsCode = RightsCode;
                service.SessionCode = SessionCode;
                return service;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string RememberFilePath => Path.Combine(Application.StartupPath, "Data", "XLTdyEn.dll");

        protected virtual bool IsUpdating { get; set; } = false;

        protected virtual string DataName { get; } = "thông tin";

        private IIocService _dbIoc;
        protected IIocService DbIoc => _dbIoc ?? (_dbIoc = XIoc.GetService(CDb.IocKey));

        private IIocService _guiIoc;
        protected IIocService GuiIoc => _guiIoc ?? (_guiIoc = XIoc.GetService(CGui.IocKey));

        private IRepositorySession _repositorySession;
        protected IRepositorySession RepositorySession => _repositorySession ?? (_repositorySession = DbIoc.GetInstance<IRepositorySession>());

        protected ILogin Login => RepositorySession?.GetLogin(SessionCode);

        protected bool IsSupperAdmin => (Login?.IsSupperAdmin ?? false);

        private string _sessionCode;
        protected virtual string SessionCode => _sessionCode ?? (_sessionCode = XForm.GetSessionCode(this));

        private IAppMessage _msg;
        protected IAppMessage Msg => _msg ?? (_msg = GuiIoc.GetInstance<IAppMessage>());

        private IIconService _iconService;
        protected IIconService IconService => _iconService ?? (_iconService = GuiIoc.GetInstance<IIconService>());

       

        private IRepositoryBranch _repositoryBranch;
        protected IRepositoryBranch RepositoryBranch => _repositoryBranch ?? (_repositoryBranch = DbIoc.GetInstance<IRepositoryBranch>());



        private ICheckRightsService _checkRightsService;
        protected ICheckRightsService CheckRightsService => _checkRightsService ?? (_checkRightsService = GuiIoc.GetInstance<ICheckRightsService>());

        private IContextMenuService _menuService;
        protected IContextMenuService MenuService => _menuService ?? (_menuService = GuiIoc.GetInstance<IContextMenuService>(EGui.WindowsFormsDevExpress));

        private IColumnIndexer _columnIndexer;
        protected IColumnIndexer ColumnIndexer => _columnIndexer ?? (_columnIndexer = GuiIoc.GetInstance<IColumnIndexer>(EGui.WindowsFormsDevExpress));

        private IDateTimesService _dc;
        protected IDateTimesService Dc => _dc ?? (_dc = GuiIoc.GetInstance<IDateTimesService>(EGui.WindowsFormsDevExpress).Init(OnShowDateTimeMessage));

      



        private void OnShowDateTimeMessage(string mesage)
        {
            Msg?.ShowInfo(mesage, true);
        }

      

        protected Form GetForm<TEnum>(TEnum formEnum) where TEnum : Enum
        {
            var f = GuiIoc.GetInstance<Form>(formEnum.ToString());
            return f;
        }

        protected TForm GetForm<TEnum, TForm>(TEnum formEnum) 
            where TEnum : Enum
            where TForm : Form
        {
            var f = GuiIoc.GetInstance<Form>(formEnum.ToString());
            return f as TForm;
        }

        #region Mgmt

        protected bool CanOpen(string rightsCode = null)
        {
            return UiService.CanOpen(rightsCode);
        }

        protected bool CanExport(string rightsCode = null)
        {
            return UiService.CanExport(rightsCode);
        }

        protected bool CanPrint(string rightsCode = null)
        {
            return UiService.CanPrint(rightsCode);
        }

        #endregion

        #region Click

        protected void ClickExport(Func<bool> func, string rightsCode = null)
        {
            UiService.ClickExport(func, rightsCode);
        }

        protected void ClickPrint(Func<bool> func, string rightsCode = null)
        {
            UiService.ClickPrint(func, rightsCode);
        }
        #endregion


        #region Loading

        protected Control GetLoadingControl(Control uc = null)
        {
            return UiService.GetLoadingControl(uc);
        }

        protected void ShowLoading(Control uc = null)
        {
            UiService.ShowLoading(uc);
        }

        protected void CloseLoading(Control uc = null)
        {
            UiService.CloseLoading(uc);
        }

        #endregion



        protected void CheckAndCreateFolder()
        {
            var folder = Path.GetDirectoryName(RememberFilePath);
            if (!Directory.Exists(folder) && !string.IsNullOrWhiteSpace(folder)) Directory.CreateDirectory(folder);
        }

      

      


        protected virtual bool IsReadOnlyMultiDate => false;

     

    }
}
