using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Order.Widget.Forms
{
    public interface IFCompareOrderItemsInfo
    {
        IFCompareOrderItemsInfo Compare(MEntityOrderItem oldItem, MEntityOrderItem newItem, bool isFromNew);

        IFCompareOrderItemsInfo ShowPopup(object owner);
    }
}
