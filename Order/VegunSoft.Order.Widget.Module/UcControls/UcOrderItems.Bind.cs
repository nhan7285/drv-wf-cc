using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using VegunSoft.Acc.Editor.Dev.Acc;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItems
    {
        protected override GridView View => _viewOrderItems;

        protected override GridControl Grid => _gridOrderItems;

        protected override List<MEntityOrderItem> ActiveOrderItems => OrderItemStepsDict.Keys.ToList();

        protected override MEntityCustomer SelectedCustomer => Settings?.GetSelectedCustomerFunc?.Invoke();

        protected override SBoxUserAccount EditorConsultDoctor => _cbbSelectBSTV;

        protected override SBoxUserAccount EditorConsultAssistant => _cbbSelectTLTV;

        #region CalcEdit

        protected override CalcEdit CalcTotalPrices => cdtTongTien;

        protected override CalcEdit CalcTotalDiscount => cdtGiamGia;

        protected override CalcEdit CalcMustPayMoney => cdtThanhTien;

        protected override CalcEdit CalcArisingMustPayMoney => cdtThanhTien_TruocPS;

        #endregion
    }
}
