using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VegunSoft.Customer.Entity.Process;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Layer.UcControl.Customer.Models;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Layer.UcService.Provider.Models
{
    public class MUcOrderItems
    {
        public string FormName { get; set; }

        public Func<MEntityCustomer> GetSelectedCustomerFunc { get; set; }
        public Func<bool> IsReadOnlyFunc { get; set; }

        public Func<Control> GetOrdersPanelFunc { get; set; }

        public Func<string, object[], bool> StartTransferAction { get; set; }

        public Action<string> ShowConsultAction { get; set; }

        public Action<string> UpdateCaptionAction { get; set; }

        public Action OnEndTransferAction { get; set; }

        public Action<bool> OnEndReadOnlyAction { get; set; }

        public Action<MEntityOrderConsult> OnAddConsultDoneAction { get; set; }

        public Action<MEntityOrderItem, bool> OnStartSavedTreatmentAction { get; set; }

        public Action<string, List<MEntityOrder>, bool> EndLoadOrdersAction { get; set; }

        public Func<IEntityCustomerStageMin> GetSelectedTransferFunc { get; set; }

        public Action<MEntityOrder> OnEndSaveOrderAction { get; set; }

        public Action<MSaveOrderItem> OnEndSaveOrderItemAction { get; set; }

       // public Action<string> OnEnSaveOrderAction { get; set; }

        public Action<bool> ShowAllAction { get; set; }

        public Action<string> SelectOrderAction { get; set; }
        public Action<string> FocusOrderAction { get; set; }

        public object RootParent { get; set; }

        
    }
}
