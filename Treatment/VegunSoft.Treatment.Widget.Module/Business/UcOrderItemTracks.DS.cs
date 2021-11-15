using System.Collections.Generic;
using System.Linq;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemTracks
    {
        private void LoadOrderItemsSteps(MEntityOrder order, string oderItemId = null)
        {
            CheckAndEnableEditors(order, oderItemId);
            DeleteSteps.Clear();
            IsLoadingHistories = true;
            var list = new List<MEntityOrderItemStep>();
            if (order != null) _currentOrder = order;
            if (order != null) XOrderItemId = oderItemId;
            if (!string.IsNullOrWhiteSpace(oderItemId))
            {
                _chbIsShowAllHistoriesOfOrders.Enabled = true;
                _chbIsShowAllHistoriesOfOrders.Checked = false;
            }
            else
            {
                _chbIsShowAllHistoriesOfOrders.Enabled = false;
                _chbIsShowAllHistoriesOfOrders.Checked = true;
            }
            var orderItems = order != null ? OrderItems.Where(x => x.OrderId == order.Id).ToList() : OrderItems;

            foreach (var planService in orderItems)
            {
                var histories = OrderItemSteps.Where(o => o.OrderItemId.ToString() == planService.Id).ToList();
                foreach (var h in histories)
                {
                    if (h.CreatedDate != null) h.CreatedDate = h.CreatedDate.Value.Date;
                    RepositoryOrderItemStep.CopyInfo(h, planService);
                    if (string.IsNullOrWhiteSpace(oderItemId) || h.OrderItemId == oderItemId) list.Add(h);
                }
            }

            var prescriptions = order != null ? listBSDT_Toathuoc.Where(o => o.CreatedDate != null && order.ConsultingDate != null && o.CreatedDate.Value.Date == order.ConsultingDate.Value.Date).ToList() : listBSDT_Toathuoc;

            foreach (var prescription in prescriptions)
            {
                var h = RepositoryOrderItemStep.GetNewHistory(prescription);
                if (string.IsNullOrWhiteSpace(oderItemId) || h.OrderItemId == oderItemId) list.Add(h);
            }

            var folders = order != null ? list_CLS_ChidinhCLS.Where(o => o.CreatedDate != null && order.ConsultingDate != null && o.CreatedDate.Value.Date == order.ConsultingDate.Value.Date).ToList() : list_CLS_ChidinhCLS;
            foreach (var subclinical in folders)
            {
                var h = RepositoryOrderItemStep.GetNewHistory(subclinical);
                if (string.IsNullOrWhiteSpace(oderItemId) || h.OrderItemId == oderItemId) list.Add(h);
            }

            DataSource = list.OrderBy(x => x.CreatedDate).ThenBy(x => x.TeethId).ToList();
            FocusEndRow();
            IsLoadingHistories = false;
        }
    }
}
