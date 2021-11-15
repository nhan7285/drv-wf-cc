using DevExpress.XtraEditors;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Db.Services;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Provider.WindowsForms;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Framework.Methods;

using VegunSoft.Layer.UcService.Services.App;
using VegunSoft.Session.Repository.Business;

namespace VegunSoft.Layer.UcService.Provider.Services.App
{
    public class AppService : IAppService<XtraForm>
    {
        private XtraForm _form;

        protected string SessionCode => XForm.GetSessionCode(_form);

        protected static IServiceDataSession Dbs => GDb.Dbs;

        public IRepositorySession Session { get; set; }

        private static IIocService _guiIoc;
        protected static IIocService GuiIoc => _guiIoc ?? (_guiIoc = XIoc.GetService(CGui.IocKey));
        protected IAppUpdateService UpdateService { get; set; }
        public IAppService<XtraForm> Init(XtraForm instance)
        {
            _form = instance as XtraForm;
            Session = XIoc.GetService(CDb.IocKey).GetInstance<IRepositorySession>();
            UpdateService = GuiIoc.GetInstance<IAppUpdateService>();
            return this;
        }



        public IAppService<XtraForm> SwitchMode()
        {
            Dbs.SwitchMode(SessionCode);
            UpdateTitle();
            return this;
        }

        public IAppService<XtraForm> UpdateTitle()
        {
            // sender.bstiServer.Caption = $"Máy chủ: {server?.Name}";
            if (_form == null) return this;
            var dbGoal = Dbs.GetDbGoal(SessionCode);
            var desc = dbGoal.GetDescription().ToUpper();
            var txt = $"PHẦN MỀM QUẢN LÝ NHA KHOA DR. VƯƠNG / {desc}";

            if (UpdateService.IsBeta)
            {
                txt = txt + " / BETA " + UpdateService.BetaCurrentVersion;
            }
            else if (UpdateService.IsOld)
            {
                txt = txt + " / OLD " + UpdateService.OldCurrentVersion;
            }
            else if (UpdateService.IsDev)
            {
                txt = txt + " / DEV " + UpdateService.DevCurrentVersion;
            }
            var serverName = Dbs.GetServer(SessionCode)?.Name;
            if (!string.IsNullOrWhiteSpace(serverName))
            {
                txt = txt + $" / {serverName}";
            }

            var branchName = Session?.Branch?.Code;
            if (!string.IsNullOrWhiteSpace(branchName))
            {
                txt = txt + $" / {branchName}";
            }

            var acc = Session.Username;
            if (!string.IsNullOrWhiteSpace(acc))
            {
                txt = txt + $" / { Session.Username} - {Session.UserFullName}";
            }
            _form.Text = txt.ToUpper();


            return this;
        }

    }
}
