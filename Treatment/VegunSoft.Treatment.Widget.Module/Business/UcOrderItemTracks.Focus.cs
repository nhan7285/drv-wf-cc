using System;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Methods;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemTracks
    {
        private void ApplyFocus()
        {
            if (!string.IsNullOrWhiteSpace(OrderId))
            {
                FocusOrder(OrderId, true);
            }

            if (!string.IsNullOrWhiteSpace(OrderItemId))
            {
                FocusOrderItem(OrderItemId, true);
            }

            if (!string.IsNullOrWhiteSpace(OrderItemStepId))
            {
                FocusOrderItemStep(OrderItemStepId);
            }

        }

        public void FocusOrder(string id, bool isApplyGroup)
        {
            if(isApplyGroup) IsGroupByOrder = true;
            FocusOrder(id, x => x.Id);
            FocusStepItem(id, x => x.OrderId);         
        }

        public void FocusOrderItem(string id, bool isApplyGroup)
        {
            if (isApplyGroup) IsGroupByOrderItem = true;
            FocusOrderItem(id, x => x.Id);
            FocusStepItem(id, x => x.OrderItemId);
         
        }

        public void FocusOrderItemStep(string id)
        {
            FocusStepItem(id, x => x.Id);
        }

        public void FocusStepItem(string id, Func<MEntityOrderItemStep, string> getFieldValFunc)
        {
            View.FocusRow(id, getFieldValFunc);
        }

        public void FocusOrderItem(string id, Func<MEntityOrderItem, string> getFieldValFunc)
        {
            _vieOrderItems.FocusRow(id, getFieldValFunc);           
        }

        public void FocusOrder(string id, Func<MEntityOrder, string> getFieldValFunc)
        {
            _viewOrders.FocusRow(id, getFieldValFunc);           
        }

       

    }
}
