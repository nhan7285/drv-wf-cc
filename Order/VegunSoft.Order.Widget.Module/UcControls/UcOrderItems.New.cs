using System;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItems
    {
        protected MEntityOrder GetNewOrder()
        {
            return new MEntityOrder()
            {
                BranchId = RepositorySession.BranchId
            };
        }

        protected DateTime ApplyNewProperties(MEntityOrder order)
        {
            var dateTime = RepositoryOrderItem.GetDateTime();
            order.BranchId = RepositorySession.BranchId;
            RepositorySession.ApplyCreatedBasicFields(order, dateTime);
            return dateTime;
        }

        private void CopyInfo(MEntityOrderItem item)
        {
            var o = Order;
            item.TelesalesId = o?.TelesalesId;
            item.TelesalesNo = o?.TelesalesNo ?? 0;
            item.TelesalesCode = o?.TelesalesCode;
            item.TelesalesFullName = o?.TelesalesFullName;
            item.TelesalesUsername = o?.TelesalesUsername;

            item.ConnectorId = o?.ConnectorId;
            item.ConnectorNo = o?.ConnectorNo ?? 0;
            item.ConnectorCode = o?.ConnectorCode;
            item.ConnectorFullName = o?.ConnectorFullName;
            item.ConnectorUsername = o?.ConnectorUsername;
        }
    }
}
