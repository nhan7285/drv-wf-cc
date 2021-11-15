using VegunSoft.Framework.Gui.Provider.WindowsForms.Views;

namespace VegunSoft.Updater.Bloc.Services
{
    public interface IAppUpdateService
    {
        int AppType { get; }

        bool IsBeta { get; set; }

        bool IsDev { get; set; }

        bool IsOld { get; set; }

        string RealCurrentVersion { get; set; }

        string BetaCurrentVersion { get; set; }
        string DevCurrentVersion { get; set; }
        string OldCurrentVersion { get; set; }

        string RealNewVersion { get; set; }

        string RealNewBetaVersion { get; set; }

        string RealNewDevVersion { get; set; }

        string RealUpdateFolder { get; }

        string OldVersion { get; set; }

        string OldVersionFilePath { get; }

        string CoreVersion { get; set; }

        string BetaVersion { get; set; }


        string DevVersion { get; set; }

        string BetaVersionFilePath { get; }

        string DevVersionFilePath { get; }

        string RealVersionFilePath { get; }

        IAppUpdateService Init(IForm form);
        void CallUpdate();

        void CallUpdateBeta();

        void CallUpdateDev();


        void CallUpdateOld();

        bool IsNeedRestart { get; }

        void DownloadUpdatersAsync();
    }


}
