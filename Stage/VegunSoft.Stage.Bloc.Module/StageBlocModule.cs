using VegunSoft.Base.Module.Provider;
using VegunSoft.Stage.ViewBloc.Provider.Services;
using VegunSoft.Stage.ViewBloc.Services;

namespace VegunSoft.Stage.ViewBloc.Provider
{
    public class StageBlocModule : ModUcServiceBase
    {

        public override void Init()
        {
            GuiIoc.Register<ICustomerQueueVS, VSCustomerQueue>();
            //GuiIoc.Register<IUiServiceMgmt, UiServiceMgmt>();
            //GuiIoc.Register<IGridViewEventService, GridViewEventService>();
        }



    }
}
