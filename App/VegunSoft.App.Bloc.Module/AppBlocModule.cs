using DevExpress.XtraEditors;
using VegunSoft.App.View.Service.Dev.Services;
using VegunSoft.App.View.Service.Services;
using VegunSoft.Base.Module.Provider;
using VegunSoft.Framework.Gui.Enums;
using VegunSoft.Framework.Gui.Services;
using VegunSoft.Framework.Gui.Services.Events;
using VegunSoft.Layer.UcService.Provider.App;
using VegunSoft.Layer.UcService.Provider.Services.App;
using VegunSoft.Layer.UcService.Services.App;

namespace VegunSoft.App.Bloc.Module
{
    public class AppBlocModule : ModUcServiceBase
    {

        public override void Init()
        {
            GuiIoc.Register<IItemClickService, ItemClickService>(EGuiService.MainItemClickService.ToString());
            GuiIoc.Register<IImageService, ImageService>(EGuiService.MainImageService.ToString());
            GuiIoc.Register<IImageService, SizedImageService>(EGuiService.SizedImageService.ToString());
            GuiIoc.RegisterSingleton<IAppService<XtraForm>, AppService>();
            GuiIoc.Register<IMgmtViewService, MgmtViewService>();
            GuiIoc.Register<IControlService, ControlService>(EGuiService.MainControlService.ToString());
        }



    }
}
