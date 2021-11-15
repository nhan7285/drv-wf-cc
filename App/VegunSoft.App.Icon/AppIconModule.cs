using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Services;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Framework.Module.Modules;

namespace VegunSoft.App.Icon
{
    public class AppIconModule : LeafModule
    {
        private IIocService _guiIoc;

        protected IIocService GuiIoc => _guiIoc ?? (_guiIoc = XIoc.GetService(CGui.IocKey));

        public override void Init()
        {
            GuiIoc.RegisterSingleton<IIconService, IconService>();
        }

        public override void Run()
        {

        }

        public override void Exit()
        {

        }
    }
}
