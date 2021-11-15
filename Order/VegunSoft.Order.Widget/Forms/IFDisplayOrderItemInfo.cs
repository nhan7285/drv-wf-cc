using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Order.Widget.Forms
{
    public interface IFDisplayOrderItemInfo
    {
        IFDisplayOrderItemInfo Apply(MEntityOrderItem item);

        IFDisplayOrderItemInfo ShowPopup(object owner);
    }

}
