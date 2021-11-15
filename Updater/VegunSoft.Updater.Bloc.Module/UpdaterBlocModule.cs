using VegunSoft.Base.Module.Provider;
using VegunSoft.Updater.Bloc.Module.Services;
using VegunSoft.Updater.Bloc.Services;

namespace VegunSoft.Updater.Bloc.Module
{
    public class UpdaterBlocModule : ModUcServiceBase
    {

        public override void Init()
        {

            GuiIoc.RegisterSingleton<IAppUpdateService, AppUpdateService>();
        }



    }
}
