using VegunSoft.Base.View.Service.Dev.Services;
using VegunSoft.Base.View.Service.Services;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Framework.Module.Modules;

namespace VegunSoft.Base.View.Service.Dev
{
    public class ModBaseViewService : LeafModule
    {
        private IIocService _guiIoc;

        protected IIocService GuiIoc => _guiIoc ?? (_guiIoc = XIoc.GetService(CGui.IocKey));

        
        public override void Init()
        {
            GuiIoc.Register<IUiServiceMgmt, UiServiceMgmt>();
        }

        public override void Run()
        {
        }

        public override void Exit()
        {
        }

    }
}
