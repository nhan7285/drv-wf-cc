using System;
using System.Collections.Generic;
using VegunSoft.Any.View.Dev.Forms;
using VegunSoft.Base.View.Dev;
using VegunSoft.Framework.Gui.Services;

namespace VegunSoft.Any.Widget.Module
{
    public class AnyWidgetModule : GuiModule
    {
        protected override IDictionary<Type, Type> RawSingletonForms { get; } = new Dictionary<Type, Type>()
        {
             {typeof(IFormError), typeof(FDisplayError)},
             {typeof(IFormInfo), typeof(FDisplayInfo)},

        };
    }
}
// 