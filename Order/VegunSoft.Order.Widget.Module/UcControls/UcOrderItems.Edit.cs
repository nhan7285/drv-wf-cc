using System.Collections.Generic;
using System.Linq;
using VegunSoft.Category.Entity.Provider.Category;
using VegunSoft.Category.Entity.Provider.Category.Body;
using VegunSoft.Framework.Db.Enums.Data;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItems
    {
        public MEntityOrderItem EditingItem { get; private set; }

        private void SaveUpdateOrderItem()
        {
            var item = EditingItem;
            if (item == null) return;
            if(item.Action != EMgmtCase.Insert && item.Action != EMgmtCase.Delete)
            {
                item.Action = EMgmtCase.Update;
            }

            _btnSaveOrderItem.Visible = false;
            EditingItem = null;

            _viewOrderItems.RefreshData();
            StartNewOrderItem();
        }

        private void StartNewOrderItem()
        {
          
            SelectedTeeth = new List<MEntityTooth>();
            txtIdRang.Focus();
            txtIdRang.SelectAll();
            _glkTooth.EditValue = 0;
            _cbbProductService.EditValue = null;
            _txtOrderItemId.EditValue = null;
            lblListRangChon.Text = "";
        }

        private void ChangeTeeth()
        {
            OnReselectTeeth(SelectedOrderItem);         
        }

        private void StartEditOrderItem(MEntityOrderItem item)
        {
            if (item == null) return;
            this.EditingItem = item;
            _btnSaveOrderItem.Visible = true;
            var ids = item.ProductServiceTargetFinalIds;
            if (!string.IsNullOrWhiteSpace(ids))
            {
                LoadTeethToView(ids);
            }
            _txtOrderItemId.EditValue = item.Id;
            _cbbProductService.EditValue = item.ProductServiceId;
            _calcAmount.EditValue = item.Amount;
            _txtDynamicPrice.EditValue = item.UnitPrice;
            _cbbSelectBSTV.EditValue = item.ConsultConsultantUserName;
            _cbbSelectTLTV.EditValue = item.ConsultAssistantUserName;
            _cheIsTemporary.Checked = item.IsTemporary;
            _cheIsChange.Checked = false;
            //_cheIsChange.Action =  EMgmtCase.Update;
        }

        private void LoadTeethToView(string ids)
        {
            if (string.IsNullOrWhiteSpace(ids)) return;
            if (ids.Contains(","))
            {
                var list = ids.Split(',').Select(x => x.Trim()).ToList();
                var teeth = ListTeeth.Where(x => list.Contains(x.ID)).ToList();
                SelectTeeth(teeth);
            }
            else //if(int.TryParse(ids, out int id))
            {
                var teeth = ListTeeth.Find(x => ids == x.ID);
                //_glkTooth.Text = teeth?.TEN;
                _glkTooth.EditValue = teeth?.ID;            
                _glkTooth.Refresh();
                gridView4.RefreshData();
                //_glkTooth.RefreshEditValue();
            }
        }
    }
}
