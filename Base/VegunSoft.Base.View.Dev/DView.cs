using System.Collections.Generic;
using VegunSoft.Framework.Gui.Models.Bar;
using VegunSoft.Layer.Model.Provider.Module;

namespace VegunSoft.Base.View.Dev
{
    public class DView
    {
        public static List<MShowModule> Modules { get; set; } = new List<MShowModule>();

        public static List<MBarButtonItem> MenuItems { get; set; } = new List<MBarButtonItem>();

        //RibbonPages
        public static List<MRibbonPage> MenuGroups { get; set; } = new List<MRibbonPage>();
    }
}
