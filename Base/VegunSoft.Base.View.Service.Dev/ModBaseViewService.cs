using VegunSoft.Base.Module.Provider;
using VegunSoft.Base.View.Service.Dev.Services;
using VegunSoft.Base.View.Service.Services;

namespace VegunSoft.Base.View.Service.Dev
{
    public class ModBaseViewService : ModUcServiceBase
    {

        public override void Init()
        {
            GuiIoc.Register<IUiServiceMgmt, UiServiceMgmt>();
            GuiIoc.Register<IGridViewEventService, GridViewEventService>();
        }

       

    }
}
