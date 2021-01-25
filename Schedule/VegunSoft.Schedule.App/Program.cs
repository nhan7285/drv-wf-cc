using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VegunSoft.Schedule.View.Dev.Personnel;
using VegunSoft.App.Service.Provider;
using VegunSoft.Session.Service.Provider;
using VegunSoft.Startup.Service;
using VegunSoft.Startup.Service.Provider;

namespace VegunSoft.Schedule.App
{
    static class Program
    {

        static IServiceStartup _serviceStartup;
        static IServiceStartup ServiceStartup => _serviceStartup ?? (_serviceStartup = new ServiceStartup());

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


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();

            Application.Run(new FSchedulePersonel());
        }
    }
}