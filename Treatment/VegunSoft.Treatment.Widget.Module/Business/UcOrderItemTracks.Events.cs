using System;
using DevExpress.XtraGrid.Columns;
using VegunSoft.Framework.Gui;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemTracks
    {
        protected DateTime RosePaidDate { get; set; } = DateTime.Now;
        private void OnIsPaidRoseCheckedChanged()
        {
            var entity = SelectedOrderItemStep;
            if (entity != null)
            {              
                entity.RoseFinishedDate = !entity.IsRoseFinished ? RosePaidDate : (DateTime?)null;
                RefreshData(false, false, true);
            }
        }

        protected void OnIsMainDoctorCheckedChanged(bool isDoctorMain)
        {
            Msg.ClearMessages();
            var entity = SelectedOrderItemStep;
            if (entity != null && entity.IsAssistantMain && isDoctorMain)
            {
                if (IsSingleMode(entity))
                {
                    entity.IsAssistantMain = false;
                    RefreshData(false, true, true);
                    Msg.ShowInfo("Bước này chỉ được chọn 1 người làm chính!", true);
                }
              
            }
        }

        protected void OnIsMainAssistantCheckedChanged(bool isAssistantMain)
        {
            Msg.ClearMessages();
            var entity = SelectedOrderItemStep;
            if (entity != null && entity.IsDoctorMain && isAssistantMain)
            {
                entity.IsDoctorMain = false;
                RefreshData(false, true, true);

                if (IsSingleMode(entity))
                {
                    Msg.ShowInfo("Bước này chỉ được chọn 1 người làm chính!", true);
                }
                else
                {
                    Msg.ShowInfo("Vui lòng check chọn BSC nếu bác sĩ cũng làm chính ca này!", true);
                }
            }
        }

        private void OnRosePaidDateEditValueChanging(DateTime? newValue)
        {
            if (newValue != null) RosePaidDate = newValue.Value;
        }

        private void OnSelectPdsv()
        {
            if (_isDataSourceLoading) return;
            var item = XOrderItem;
            if (!string.IsNullOrWhiteSpace(item?.OrderId))
            {
                _chbIsShowAllHistoriesOfCustomers.Checked = false;
                var order = RepositoryOrder.Find(item.OrderId);
                LoadOrderItemsSteps(order, item.Id);
            }

        }

        private void OnReloadList()
        {
            XLoading.ShowLoading();
            Reload();
            if (_chbIsShowAllHistoriesOfOrders.Checked)
            {
                var oderItemId = XOrderItemId;
                LoadOrderItemsSteps(_currentOrder, null);
                XOrderItemId = oderItemId;
                _chbIsShowAllHistoriesOfOrders.Enabled = true;
            }else if (_chbIsShowAllHistoriesOfCustomers.Checked)
            {
                LoadAllHistories();
            }
            else
            {
                LoadOrderItemsSteps(_currentOrder, XOrderItemId);
            }
            XLoading.CloseLoading();
        }


        private void _chkIsGroupByOrder_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGroupColumns();
        }

        private void _chkIsGroupByOrderItem_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGroupColumns();
        }

        private void UpdateGroupColumns()
        {
            var count = 0;
            var li = this.View.SortInfo;
            li.Clear();
            if (IsGroupByOrder)
            {
                _gcOrderItemStepOrderId.Visible = true;
                li.Add(new GridColumnSortInfo(_gcOrderItemStepOrderId, DevExpress.Data.ColumnSortOrder.Ascending));
                count++;
            }
            else
            {
                _gcOrderItemStepOrderId.Visible = false;
            }
            if (IsGroupByOrderItem)
            {
                _gcOrderItemStepOrderItemPdsvName.Visible = true;
                li.Add(new GridColumnSortInfo(_gcOrderItemStepOrderItemPdsvName, DevExpress.Data.ColumnSortOrder.Ascending));
                count++;
            }
            else
            {
                _gcOrderItemStepOrderItemPdsvName.Visible = false;
            }
            if(count == 0)
            {
                _gcOrderItemStepGroupName.Visible = true;
                li.Add(new GridColumnSortInfo(_gcOrderItemStepGroupName, DevExpress.Data.ColumnSortOrder.Ascending));
                count++;
            }
            else
            {
                _gcOrderItemStepGroupName.Visible = false;
            }
            View.GroupCount = count;
            //RefreshIndexes();
        }
    }
}
