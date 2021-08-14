using VegunSoft.App.View.Service.Dev.Services;
using VegunSoft.App.View.Service.Services;
using VegunSoft.Base.Module.Provider;

namespace VegunSoft.Base.View.Service.Dev
{
    public class ModAppViewService : ModUcServiceBase
    {

        public override void Init()
        {
            GuiIoc.Register<IMgmtViewService, MgmtViewService>();
          
        }

       

    }
}
