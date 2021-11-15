using System.Collections.Generic;
using VegunSoft.Framework.Gui.Services;

namespace VegunSoft.Layer.UcService.Provider.Services.App
{
    public class ControlService: IControlService
    {
        public static Dictionary<string, object> ControlsDict { get; set; }

        public object Get(string id)
        {
            return ControlsDict[id];
        }
    }
}
