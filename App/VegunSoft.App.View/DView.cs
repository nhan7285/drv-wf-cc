using System.Collections.Generic;
using VegunSoft.App.Model.Business;
using VegunSoft.Framework.Gui.Models.Bar;

namespace VegunSoft.Base.View.Dev
{
    public class DView
    {
        public static List<IShowModule> Modules { get; set; } = new List<IShowModule>();

        public static List<MBarButtonItem> MenuItems { get; set; } = new List<MBarButtonItem>();

        //RibbonPages
        public static List<MRibbonPage> MenuGroups { get; set; } = new List<MRibbonPage>();
    }
}
