using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using VegunSoft.Acc.Data.Enums;
using VegunSoft.Acc.Editor.Dev.Acc;
using VegunSoft.Acc.Entity.Acc;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Methods;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemsBase
    {
        protected virtual GridView View { get; }

        protected virtual GridControl Grid { get; }

        protected virtual SBoxUserAccount EditorConsultDoctor { get; }

        protected virtual SBoxUserAccount EditorConsultAssistant { get; }

        protected virtual List<MEntityOrderItem> ActiveOrderItems { get; }

        protected List<MEntityOrderItem> OrderItemsDs => Grid.DataSource as List<MEntityOrderItem>;

        protected virtual MEntityCustomer SelectedCustomer { get; }

        #region Members

        protected IEntityUserAccountMin OrderConsultDoctor
        {
            get => EditorConsultDoctor.SelectedUserAccount;
        }

        protected string OrderConsultDoctorUserName
        {
            get => EditorConsultDoctor.EditValue?.ToString();
            set => EditorConsultDoctor.EditValue = value;
        }

        protected EUserAccountScope OrderConsultDoctorScope
        {
            set => EditorConsultDoctor.Scope = value;
        }

        protected IEntityUserAccountMin OrderConsultAssistant
        {
            get => EditorConsultAssistant.SelectedUserAccount;
        }

        protected string OrderConsultAssistantUserName
        {
            get => EditorConsultAssistant.EditValue?.ToString();
            set => EditorConsultAssistant.EditValue = value;
        }

        protected EUserAccountScope OrderConsultAssistantScope
        {
            set => EditorConsultAssistant.Scope = value;
        }

        #endregion
        #region TotalPrices

        protected virtual CalcEdit CalcTotalPrices { get; }

        public decimal TotalPrices
        {
            get
            {
                return CalcTotalPrices.GetDecimalValue();
            }
            set
            {
                CalcTotalPrices.EditValue = value;
            }
        }

        #endregion

        #region TotalDiscount

        protected virtual CalcEdit CalcTotalDiscount { get; }

        public decimal TotalDiscount
        {
            get
            {
                return CalcTotalDiscount.GetDecimalValue();
            }
            set
            {
                CalcTotalDiscount.EditValue = value;
            }
        }

        #endregion

        #region MustPayMoney

        protected virtual CalcEdit CalcMustPayMoney { get; }

        public decimal MustPayMoney
        {
            get
            {
                return CalcMustPayMoney.GetDecimalValue();
            }
            set
            {
                CalcMustPayMoney.EditValue = value;
            }
        }
        #endregion

        #region ArisingMustPayMoney

        protected virtual CalcEdit CalcArisingMustPayMoney { get; }

        public decimal ArisingMustPayMoney
        {
            get
            {
                return CalcArisingMustPayMoney.GetDecimalValue();
            }
            set
            {
                CalcArisingMustPayMoney.EditValue = value;
            }
        }
        #endregion

        protected void ApplyCustomerValues(MEntityOrder order)
        {
            if (order == null) return;
            var customer = SelectedCustomer;

            order.CustomerId = customer?.Id;
            order.CustomerNo = customer?.No ?? 0;
            order.CustomerCode = customer?.Code;
            order.CustomerPhoneNumber = customer?.PhoneNumber;
            order.CustomerFullName = customer?.FullName;
            order.CustomerPrivateInfo = customer?.PrivateInfo;

            order.TelesalesId = customer?.TelesalesId;
            order.TelesalesNo = customer?.TelesalesNo ?? 0;
            order.TelesalesCode = customer?.TelesalesCode;
            order.TelesalesFullName = customer?.TelesalesFullName;
            order.TelesalesUsername = customer?.TelesalesUsername;

            order.ConnectorId = customer?.ConnectorId;
            order.ConnectorNo = customer?.ConnectorNo ?? 0;
            order.ConnectorCode = customer?.ConnectorCode;
            order.ConnectorFullName = customer?.ConnectorFullName;
            order.ConnectorUsername = customer?.ConnectorUsername;
        }

        protected void ApplyOrderItemValues(MEntityOrder order)
        {
            var orderItems = OrderItemsDs ?? new List<MEntityOrderItem>();
            order.IsTemporary = orderItems.Count == 0 || orderItems.All(x => x.IsTemporary);
            order.HasTemporary = orderItems.Count != 0 && orderItems.Any(x => x.IsTemporary);
            order.HasWorkingItems = orderItems.Count != 0 && orderItems.Any(x => !x.IsTemporary && !x.IsFinish);
            order.IsFinish = orderItems.Count != 0 && orderItems.Where(x => !x.IsTemporary && !x.IsDeleted && !x.IsDraft).All(x => x.IsFinish);
        }

        protected void ApplyTotalValues(MEntityOrder order)
        {
            order.MustPayMoney = MustPayMoney;
            order.MustPayBeforeArisingMoney = ArisingMustPayMoney;
            order.TotalPrices = TotalPrices;
            order.TotalDiscountMoneys = TotalDiscount;
        }

        protected void ApplyConsultDoctorValues(MEntityOrder order)
        {
            var consultant = OrderConsultDoctor;
            order.ConsultantUserName = consultant?.Username;
            order.ConsultantFullName = consultant?.FullName;
        }

        protected void ApplyConsultAssistantValues(MEntityOrder order)
        {          

            var assistant = OrderConsultAssistant;
            order.ConsultingAssistantUserName = assistant?.Username;
            order.ConsultingAssistantFullName = assistant?.FullName;
        }

       
    }
}
