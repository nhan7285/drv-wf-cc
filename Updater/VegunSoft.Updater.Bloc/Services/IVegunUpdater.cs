using VegunSoft.Framework.Gui.Provider.WindowsForms.Views;

namespace VegunSoft.Layer.UcService.Provider.Services.App
{
    public interface IVegunUpdater
    {
        IVegunUpdater Init(IForm form, string localFolderName, string serverFileName = null);

        IVegunUpdater CheckAndDownloadUpdaterAsync();

        IVegunUpdater Execute();

        bool CanExecute { get; }
    }
}
