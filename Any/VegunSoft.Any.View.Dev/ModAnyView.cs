using System;
using System.Collections.Generic;
using VegunSoft.Framework.Gui.Services;
using VegunSoft.Layer.Gui.Any.Provider.Forms;
using VegunSoft.Layer.Gui.Base.Provider;

namespace VegunSoft.Layer.Gui.Any.Provider
{
    public class ModAnyView : GuiModule
    {
        protected override IDictionary<Type, Type> RawSingletonForms { get; } = new Dictionary<Type, Type>()
        {
             {typeof(IFormError), typeof(FDisplayError)},
             {typeof(IFormInfo), typeof(FDisplayInfo)},

        };
    }
}
// 