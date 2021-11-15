namespace VegunSoft.Layer.UcService.Provider.Services.App
{
    public interface IVegunUpdaterDownloader
    {
        IVegunUpdaterDownloader Init();

        void UpdateUpdater(string localFolderPath, string serverFileName, bool isAsync);
    }
}
