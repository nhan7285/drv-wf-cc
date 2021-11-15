using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VegunSoft.Company.Data.Enums;
using VegunSoft.Customer.Entity.Process;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Layer.UcControl.Customer.Models;
using VegunSoft.Layer.UcControl.Forms.Order.Consult;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;

namespace VegunSoft.Layer.UcService.Provider.Models
{
    public class MUcCustomerServiceClosingSale
    {
        public string FormName { get; set; }

        public Func<MEntityCustomer> GetSelectedCustomerFunc { get; set; }
        public Func<MEntityOrderConsult> GetSelectedConsult { get; set; }
        public Func<bool> IsReadOnlyFunc { get; set; }
        public Action<bool> OnSaleVisibleChangedAction { get; set; }

        public Func<Control> GetOrdersPanelFunc { get; set; }

        public Func<string, object[], bool> StartTransferAction { get; set; }

        public Action OnEndTransferAction { get; set; }

        public Action<bool> OnEndReadOnlyAction { get; set; }

        public Action<string, List<MEntityOrder>, bool> EndLoadOrdersAction { get; set; }

        public Func<IEntityCustomerStageMin> GetSelectedTransferFunc { get; set; }

        public Action<string, MSaveOrderItems> OnEndSaveOrderAction { get; set; }

        public Action<MSaveOrderItem> OnEndSaveOrderItemAction { get; set; }

        public Action<bool> ShowAllAction { get; set; }

        public Action<string> SelectOrderAction { get; set; }

        public Action<bool> OnShowFormAction { get; set; }

        public Func<IUcOrderConsultForm> GetFormFunc { get; set; }
        public EFunction TransferType { get; set; }

        public Action<object, EventArgs, MEntityOrder> TreatAction { get; set; }

        public Action<MEntityOrder> SelectedOrderChanged { get; set; }
    }
}
