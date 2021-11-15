using System.IO;
using System.Threading;
using System.Windows.Forms;
using VegunSoft.Framework;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Provider.WindowsForms.Views;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Framework.Methods;
using VegunSoft.Layer.EValue.App;
using VegunSoft.Message.Service.App;

namespace VegunSoft.Layer.UcService.Provider.Services.App
{
    public class VegunUpdater: IVegunUpdater
    {
        private static IIocService _guiIoc;
        protected static IIocService GuiIoc => _guiIoc ?? (_guiIoc = XIoc.GetService(CGui.IocKey));

        private IAppMessage _msg;
        protected IAppMessage Msg => _msg ?? (_msg = GuiIoc.GetInstance<IAppMessage>());
       

        private static IVegunUpdaterDownloader _downloader;
        protected static IVegunUpdaterDownloader Downloader => _downloader ?? (_downloader = new VegunUpdaterDownloader().Init());

        protected IForm Form { get; private set; }

        public string LocalFolderName { get; set; }

        public string UpdateFileName { get; set; } = "VegunSoftUpdater.exe";       

        public string ServerFileName { get; set; }

        public string LocalFolderPath
        {
            get { return Path.Combine(Application.StartupPath, LocalFolderName); }
        }

        public string UpdateFile
        {
            get { return Path.Combine(LocalFolderPath, UpdateFileName); }
        }

        public bool CanExecute => File.Exists(UpdateFile);

        public bool CanDownloadUpdater => !string.IsNullOrWhiteSpace(ServerFileName);

        public IVegunUpdater Execute()
        {
            var updateFile = UpdateFile;
            if (!CanExecute && CanDownloadUpdater)
            {
                XLoading.ShowLoading();
                DownloadUpdater(false);
                XLoading.CloseLoading();
            }
            if (File.Exists(updateFile))
            {
                System.Diagnostics.Process.Start(updateFile);
                Form?.Close();
                return this;
            }

            Msg.ShowInfo(EShellError.UpdateFileNotFound.GetLanguageText());
            return this;
        }

        public IVegunUpdater Init(IForm form, string localFolderName, string serverFileName = null)
        {
            Form = form;
            LocalFolderName = localFolderName;
            ServerFileName = serverFileName;
            return this;
        }

        public IVegunUpdater CheckAndDownloadUpdaterAsync()
        {
            if(!CanDownloadUpdater) return this;
            var t = new Thread(() => DownloadUpdater(true));
            t.IsBackground = true;
            t.Start();
            return this;
        }

        public IVegunUpdater DownloadUpdater(bool isAsync)
        {

            if (XCode.IsDebug)
            {
                if (isAsync) Msg.ShowAsyncInfo(Form, $"Đang tải file cài đặt {ServerFileName}...");
                else Msg.ShowInfo($"Đang tải file cài đặt {ServerFileName}...", true);
            }

            Downloader.UpdateUpdater(LocalFolderPath, ServerFileName, isAsync);

            if (XCode.IsDebug)
            {
                if (isAsync) Msg.ShowAsyncInfo(Form, $"Đã tải file cài đặt {ServerFileName} => {LocalFolderPath}");
                else Msg.ShowInfo($"Đã tải file cài đặt {ServerFileName} => {LocalFolderPath}", true);
            }
               
            return this;
        }
    }
}
