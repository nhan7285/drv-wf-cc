using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VegunSoft.Schedule.View.Dev.Personnel;
using VegunSoft.App.Service.Provider;
using VegunSoft.Session.Service.Provider;
using VegunSoft.Startup.Service;
using VegunSoft.Startup.Service.Provider;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Db;
using VegunSoft.Session.Service.User;
using VegunSoft.Session.Service.Model.Provider.User;
using VegunSoft.Layer.EValue.App;
using VegunSoft.Layer.Db.Meta.Enums;

namespace VegunSoft.Schedule.App
{
    static class Program
    {
        private static IIocService _dbIoc;
        static IIocService DbIoc => _dbIoc ?? (_dbIoc = XIoc.GetService(CDb.IocKey));

        private static IServiceStartup _serviceStartup;
        static IServiceStartup ServiceStartup => _serviceStartup ?? (_serviceStartup = new ServiceStartup());

        private static IServiceLogin _serviceLogin;
        static IServiceLogin ServiceLogin => _serviceLogin ?? (_serviceLogin = DbIoc.GetInstance<IServiceLogin>());

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ServiceStartup.Start().LoadModules(new List<Type>
            {
                typeof(Framework.Gui.Provider.WindowsForms.DevExp.XModule),
                typeof(ModAppService),
           
                typeof(ModSessionService),
           
            });
            ServiceLogin.SetState(new MLoginState()
            {
                BranchId = "DRV1",
                DbGoal = EDbGoal.Real,
                DbServer = EDbServer.Dev,
                Username = "dev7285"
            });

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();

            Application.Run(new FSchedulePersonel());
        }
    }
}