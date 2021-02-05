using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VegunSoft.Acc.Entity.Rights;
using VegunSoft.Acc.Repository;
using VegunSoft.Acc.Repository.Business;
using VegunSoft.App.Service.Mgmt;
using VegunSoft.Base.View.Service.Services;
using VegunSoft.Company.Repository.Structure;
using VegunSoft.Framework.Db;
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
using VegunSoft.Framework.Methods;
using VegunSoft.Layer.Config.Provider;
using VegunSoft.Layer.Entity.Provider.App;
using VegunSoft.Layer.Repository.App.Repositories;
using VegunSoft.Layer.Repository.App.Repositories.App;
using VegunSoft.Layer.Repository.App.Repositories.Category;
using VegunSoft.Message.Service.App;
using VegunSoft.Session.Repository.Business;
using VegunSoft.Session.Service.User;

namespace VegunSoft.Base.View.Dev.Forms
{
    public class FBase : XtraForm
    {
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

        private static IIocService _dbIoc;
        protected static IIocService DbIoc => _dbIoc ?? (_dbIoc = XIoc.GetService(CDb.IocKey));

        private static IIocService _guiIoc;
        protected static IIocService GuiIoc => _guiIoc ?? (_guiIoc = XIoc.GetService(CGui.IocKey));

        private IRepositorySession _repositorySession;
        protected IRepositorySession RepositorySession => _repositorySession ?? (_repositorySession = DbIoc.GetInstance<IRepositorySession>());

        private string _sessionCode;
        protected virtual string SessionCode => _sessionCode ?? (_sessionCode = XForm.GetSessionCode(this));

        private IAppMessage _msg;
        protected IAppMessage Msg => _msg ?? (_msg = GuiIoc.GetInstance<IAppMessage>());

        private IIconService _iconService;
        protected IIconService IconService => _iconService ?? (_iconService = GuiIoc.GetInstance<IIconService>());

        private IRepositoryForm _repositoryForm;
        protected IRepositoryForm RepositoryForm => _repositoryForm ?? (_repositoryForm = DbIoc.GetInstance<IRepositoryForm>());

        private static IRepositoryBranch _repositoryBranch;
        protected static IRepositoryBranch RepositoryBranch => _repositoryBranch ?? (_repositoryBranch = DbIoc.GetInstance<IRepositoryBranch>());

        private static IRepositorySystemConfig _repositorySystemConfig;
        protected static IRepositorySystemConfig RepositorySystemConfig => _repositorySystemConfig ?? (_repositorySystemConfig = DbIoc.GetInstance<IRepositorySystemConfig>());

        private MForm _fModel;
        protected MForm FModel => _fModel ?? (_fModel = RepositoryForm.Find(RightsCode));

        private IFacRepositoryAcc _facRepositoryAcc;
        protected IFacRepositoryAcc FacRepositoryAcc => _facRepositoryAcc ?? (_facRepositoryAcc = DbIoc.GetInstance<IFacRepositoryAcc>());

        private IRepositorySystemLog _logRepository;
        protected IRepositorySystemLog LogRepository => _logRepository ?? (_logRepository = DbIoc.GetInstance<IRepositorySystemLog>());

        protected IRepositoryUserAccount RepositoryUserAccount => FacRepositoryAcc.RepositoryUserAccount;

        private IUserConfigRepository _repositoryUserConfig;
        protected IUserConfigRepository RepositoryUserConfig => _repositoryUserConfig ?? (_repositoryUserConfig = DbIoc.GetInstance<IUserConfigRepository>());

        private static ICheckRightsService _checkRightsService;
        protected static ICheckRightsService CheckRightsService => _checkRightsService ?? (_checkRightsService = GuiIoc.GetInstance<ICheckRightsService>());

        private IContextMenuService _menuService;
        protected IContextMenuService MenuService => _menuService ?? (_menuService = GuiIoc.GetInstance<IContextMenuService>(EGui.WindowsFormsDevExpress));

        private IColumnIndexer _columnIndexer;
        protected IColumnIndexer ColumnIndexer => _columnIndexer ?? (_columnIndexer = GuiIoc.GetInstance<IColumnIndexer>(EGui.WindowsFormsDevExpress));

        private IDateTimesService _dc;
        protected IDateTimesService Dc => _dc ?? (_dc = GuiIoc.GetInstance<IDateTimesService>(EGui.WindowsFormsDevExpress).Init(OnShowDateTimeMessage));

        private IRangeModel _rangeModel;
        protected IRangeModel RangeModel => _rangeModel ?? (_rangeModel = CheckRightsService.GetDateRange(SessionCode, RightsCode));



        private void OnShowDateTimeMessage(string mesage)
        {
            Msg?.ShowInfo(mesage, true);
        }

        private IFormMgmt _formMgmt;
        protected virtual IFormMgmt FormMgmt
        {
            get
            {
                if (_formMgmt == null) _formMgmt = XForm.GetInstance<IFormMgmt>(this);
                return _formMgmt;
            }
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

        protected string GetFinalCaption(object key, string defaultTitle = "")
        {
            if (string.IsNullOrWhiteSpace(defaultTitle)) defaultTitle = key?.GetLanguageText();

            var rightsCode = (key is string) ? key?.ToString() : key?.GetFinalName();
            return GetFinalCaption(rightsCode, defaultTitle);           
        }

        protected string GetFinalCaption(string rightsCode, string defaultTitle) 
        {
            var isValidCode = !string.IsNullOrWhiteSpace(rightsCode);
            var canChangeCaption = isValidCode && 
                DApp.PrivateCaptions.Keys.Contains(rightsCode);
            if (canChangeCaption)
            {
                var isShow = CheckRightsService.CheckCanShow(SessionCode, rightsCode);
                defaultTitle = isShow ? defaultTitle : DApp.PrivateCaptions[rightsCode];
            }

            var cfg = isValidCode? GetConfig(rightsCode): null;
            if (!string.IsNullOrWhiteSpace(cfg?.Name)) defaultTitle = cfg?.Name;

            return defaultTitle;
        }

        protected IRightsModel GetConfig(string rightsCode)
        {
            return CheckRightsService.GetConfig(SessionCode, rightsCode);
        }

        protected virtual bool IsReadOnlyMultiDate => false;

        protected void RunSaveDbSesion(Control p, Action action)
        {
            Msg?.ClearMessages();
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

    }
}
