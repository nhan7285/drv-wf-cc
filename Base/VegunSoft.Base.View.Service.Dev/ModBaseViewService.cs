using VegunSoft.Base.Module.Provider;
using VegunSoft.Base.View.Service.Dev.Services;
using VegunSoft.Base.View.Service.Services;
using VegunSoft.Layer.UcService.Provider.App;
using VegunSoft.Layer.UcService.Services.App;

namespace VegunSoft.Base.View.Service.Dev
{
    public class ModBaseViewService : ModUcServiceBase
    {

        public override void Init()
        {
            GuiIoc.Register<IMgmtViewService, MgmtViewService>();
            GuiIoc.Register<IUiServiceMgmt, UiServiceMgmt>();
            GuiIoc.Register<IGridViewEventService, GridViewEventService>();
        }

       

    }
}
