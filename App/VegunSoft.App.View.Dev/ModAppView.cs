using System;
using System.Collections.Generic;
using System.Linq;
using VegunSoft.App.Model.Business;
using VegunSoft.App.Model.Category;
using VegunSoft.Base.View.Dev;
using VegunSoft.Framework.Gui.Enums;
using VegunSoft.Framework.Gui.Models.Bar;

namespace VegunSoft.App.View.Dev
{
    public class ModAppView : GuiModule
    {
        protected virtual IEnumerable<IShowModule> Modules { get; }

        protected virtual IEnumerable<MRibbonPage> MenuGroups { get; }

        protected virtual IEnumerable<MBarButtonItem> MenuItems { get; }

        protected override IDictionary<Type, Type> RawSingletonForms { get; } = new Dictionary<Type, Type>()
        {
            
        };

        public override void InitViews()
        {
            InitModules(Modules);
            InitMenuGroups(MenuGroups);
            InitMenuItems(MenuItems);
        }

        protected void InitModules(IEnumerable<IShowModule> items)
        {
            if (items == null) return;
            if (((items?.Count()) ?? 0) <= 0) return;
            var list = DView.Modules;
            foreach (var item in items)
            {
                if (!list.Any(x => x.Key == item.Key)) list.Add(item);
            }
        }

        protected void InitMenuItems(IEnumerable<MBarButtonItem> items)
        {
            if (items == null) return;
            if (items?.Count() <= 0) return;
            var imgSvc = EGuiService.SizedImageService.ToString();
            var list = DView.MenuItems;
            foreach (var item in items)
            {
                if (item is IAutoBarButtonItem autoItem)
                {
                    autoItem.ServiceKey = imgSvc;
                    autoItem.Init();
                }

                list.Add(item);
            }
        }

        protected void InitMenuGroups(IEnumerable<MRibbonPage> items)
        {
            if (items == null) return;
            if (items.Count() <= 0) return;
            var list = DView.MenuGroups;
            foreach (var item in items)
            {
                if (!list.Any(x => x.Name == item.Name)) list.Add(item);
            }
        }
    }
}
// 