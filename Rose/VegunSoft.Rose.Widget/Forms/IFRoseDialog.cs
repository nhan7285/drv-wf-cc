using VegunSoft.Framework.Gui.Provider.WindowsForms.Views;
using VegunSoft.Rose.Entity.Provider.Business.Result;

namespace VegunSoft.Rose.Widget.Forms
{
    public interface IFRoseDialog : IForm
    {
        bool IsChanged { get; }

        IForm Init(MEntityRose entity);
    }
}
