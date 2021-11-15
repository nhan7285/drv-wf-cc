using System.Collections.Generic;
using VegunSoft.Base.Entity.Provider.Format;
using VegunSoft.Framework.Gui.Models;

namespace VegunSoft.Any.Widget.Forms
{
    public interface IDisplayHelpColorsForm
    {
        IDisplayHelpColorsForm Apply(string title, List<MRowFormat> models);

        IDisplayHelpColorsForm Apply<T>(string title, List<T> models) where T : MEntityFormatFontColorCustomable;
    }
}
