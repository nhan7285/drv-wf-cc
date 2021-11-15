using System;
using System.IO;
using System.Windows.Forms;
using VegunSoft.App.Config.App;
using VegunSoft.App.Config.Provider;
using VegunSoft.Framework;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums.App;
using VegunSoft.Framework.Gui.Provider.WindowsForms.Views;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Framework.Methods;
using VegunSoft.Layer.EValue.App;
using VegunSoft.Layer.UcService.Provider.Services.App;
using VegunSoft.Message.Service.App;
using VegunSoft.Updater.Bloc.Services;

namespace VegunSoft.Updater.Bloc.Module.Services
{
    public partial class AppUpdateService : IAppUpdateService
    {
        public bool IsBeta { get; set; }

        public bool IsDev { get; set; }

        public bool IsOld { get; set; }

        public int AppType
        {
            get
            {
                if (IsOld) return 0;
                if (IsBeta) return 2;
                if (IsDev) return 3;
                return 1;
            }
        }

        public string OldVersion { get; set; } = string.Empty;

        public string RealCurrentVersion { get; set; } = string.Empty;

        public string BetaCurrentVersion { get; set; } = string.Empty;

        public string DevCurrentVersion { get; set; } = string.Empty;

        public string OldCurrentVersion { get; set; } = string.Empty;

        public string RealNewVersion { get; set; } = string.Empty;

        public string RealNewBetaVersion { get; set; } = string.Empty;

        public string RealNewDevVersion { get; set; } = string.Empty;

        public string OldVersionFilePath => Application.StartupPath + @"\Data\version_old.property";

        public string CoreVersion { get; set; } = string.Empty;

        public bool IsNeedUpdateCores => CoreVersion != SApp.AppCoreVersion;

        public string BetaVersion { get; set; } = string.Empty;

        public string DevVersion { get; set; } = string.Empty;

        public string BetaVersionFilePath => Application.StartupPath + @"\Data\version_beta.property";

        public string DevVersionFilePath => Application.StartupPath + @"\Data\version_dev.property";

        public string RealVersionFilePath => Application.StartupPath + @"\Data\version.property";

        public string UpdateFolder002
        {
            get { return Path.Combine(Application.StartupPath, "UpdaterNew"); }
        }


        public string RealUpdateFolder
        {
            get
            {
                if (Directory.Exists(UpdateFolder002))
                {
                    return UpdateFolder002;
                }
                else
                {
                    return Application.StartupPath;
                }
            }
        }



        public string UpdateFolderBeta
        {
            get { return Path.Combine(Application.StartupPath, "UpdaterBeta"); }
        }



        public string UpdateFolderOld
        {
            get { return Path.Combine(Application.StartupPath, "UpdaterOld"); }
        }

        private static IIocService _guiIoc;
        protected static IIocService GuiIoc => _guiIoc ?? (_guiIoc = XIoc.GetService(CGui.IocKey));

        private IAppMessage _msg;
        protected IAppMessage Msg => _msg ?? (_msg = GuiIoc.GetInstance<IAppMessage>());
        private IAppSetting _appSetting;
        private EUiProvider _uiProvider;
        private bool _isStarted;
        private IForm _form;

        public IAppUpdateService Init(IForm form)
        {
            _form = form;
            if (_isStarted) return this;
            _appSetting = GuiIoc.GetInstance<IAppSetting>();
            _uiProvider = _appSetting.UiProvider;
            InitDevUpdater();
            InitMinUpdater();
            _isStarted = true;
            return this;
        }




        public void CallUpdateBeta()
        {
            var updateFile = Path.Combine(UpdateFolderBeta, "VegunSoftUpdater.exe");
            if (File.Exists(updateFile))
            {
                System.Diagnostics.Process.Start(updateFile);
                _form.Close();
            }
            else
            {
                Msg.ShowInfo(EShellError.UpdateFileNotFound.GetLanguageText());
            }
        }



        public void CallUpdateOld()
        {
            var updateFile = Path.Combine(UpdateFolderOld, "VegunSoftUpdater.exe");
            if (File.Exists(updateFile))
            {
                System.Diagnostics.Process.Start(updateFile);
                _form.Close();
            }
            else
            {
                Msg.ShowInfo(EShellError.UpdateFileNotFound.GetLanguageText());
            }
        }

        public bool IsNeedRestart
        {
            get
            {
                // var statusFile001 = Path.Combine(_updateFolder001, "ICSharpCode.SharpZipLib.txt");
                var statusFile002 = Path.Combine(UpdateFolder002, "ICSharpCode.SharpZipLib.txt");
                var isExistFile002 = File.Exists(statusFile002);
                // var dllFile001 = Path.Combine(_updateFolder001, "ICSharpCode.SharpZipLib.dll");
                var dllFile002 = Path.Combine(UpdateFolder002, "ICSharpCode.SharpZipLib.dll");
                // nếu khác phiên bản thì tắt QlyNhansu.exe và bật Autoupdate.exe
                var needRestart = false;
                var txt = isExistFile002 ? File.ReadAllText(statusFile002)?.Trim()?.Trim(Environment.NewLine.ToCharArray())?.Trim() ?? string.Empty : string.Empty;

                if (XCode.IsDebug) txt = "1";

                if (txt == "0")
                {
                    try
                    {
                        File.Copy(dllFile002, Path.Combine(Application.StartupPath, "ICSharpCode.SharpZipLib.dll"), true);
                        File.WriteAllText(statusFile002, "1");
                    }
                    catch (Exception e)
                    {
                        Msg.ShowInfo("Để bước cập nhật lần này thành công, bạn cần mở lại phần mềm nhé.");
                        needRestart = true;

                    }

                }

                return needRestart;
            }
        }

        #region Dev

        protected IVegunUpdater DevUpdater { get; private set; }

        public string DevUpdaterLocalFolderName { get; set; } = "UpdaterDev";

        public string DevUpdaterServerFileName { get; set; } = "updater_dev.zip";

        private IAppUpdateService InitDevUpdater()
        {
            DevUpdater = new VegunUpdater().Init(_form, DevUpdaterLocalFolderName, DevUpdaterServerFileName);
            return this;
        }

        public void CallUpdateDev()
        {
            DevUpdater.Execute();
        }

        #endregion

        #region Min

        protected IVegunUpdater MinUpdater { get; private set; }

        public string MinUpdaterLocalFolderName { get; set; } = "UpdaterMin";

        public string MinUpdaterServerFileName { get; set; } = "updater_min.zip";

        private IAppUpdateService InitMinUpdater()
        {
            MinUpdater = new VegunUpdater().Init(_form, MinUpdaterLocalFolderName, MinUpdaterServerFileName);
            return this;
        }


        public void CallUpdateMin()
        {
            MinUpdater.Execute();
        }
        #endregion

        public void DownloadUpdatersAsync()
        {
            if (!DevUpdater.CanExecute) DevUpdater.CheckAndDownloadUpdaterAsync();
            if (!MinUpdater.CanExecute) MinUpdater.CheckAndDownloadUpdaterAsync();
        }

        public void CallUpdate()
        {
            if (MinUpdater.CanExecute)
            {
                MinUpdater.Execute();
                return;
            }

            var updateFile002 = Path.Combine(UpdateFolder002, "VegunSoftUpdater.exe");
            if (File.Exists(updateFile002))
            {
                System.Diagnostics.Process.Start(updateFile002);
                _form.Close();
            }
            else if (File.Exists(Application.StartupPath + @"\AutoUpdate.exe"))
            {
                System.Diagnostics.Process.Start(Application.StartupPath + @"\AutoUpdate.exe");
                _form.Close();
            }
            else Msg.ShowInfo(EShellError.UpdateFileNotFound.GetLanguageText());
        }
    }
}
