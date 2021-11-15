using System.Collections.Generic;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItems
    {
        public Dictionary<MEntityOrderItem, List<MEntityOrderItemStep>> OrderItemStepsDict { get; private set; } = new Dictionary<MEntityOrderItem, List<MEntityOrderItemStep>>();


    }
}
