using System.Drawing;
using VegunSoft.Care.Entity.Provider.Business;
using VegunSoft.Framework.Gui.Provider.WindowsForms.Views;

namespace VegunSoft.Care.Widget.Forms
{
    public interface IFCrudTakeCareTaskFormat : IForm
    {
        bool IsChanged { get; set; }

        void SetInfo(MEntityCustomerCare model, Font defaultAppFont);
    }
}
