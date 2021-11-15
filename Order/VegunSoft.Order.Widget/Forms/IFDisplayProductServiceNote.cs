using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Order.Widget.Forms
{
    public interface IFDisplayProductServiceNote
    {
        void ShowPopup(object owner, MEntityOrderItem model);
    }
}
