using System;
using VegunSoft.Company.Data.Enums;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Layer.UcControl.Forms.Order.Consult;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;

namespace VegunSoft.Layer.UcControl.Models
{
    public class MUcConsultancyContent
    {
        public string FormName { get; set; }

        public Func<MEntityCustomer> GetSelectedCustomerFunc { get; set; }

        public Func<MEntityOrder> GetSelectedOrderFunc { get; set; }

        public Func<bool> IsReadOnlyFunc { get; set; }

        public Func<IUcOrderConsultForm> GetFormFunc { get; set; }

        public Action CheckAndSaveAction { get; set; }

        public Action<bool, bool> IsFinishSaleModeChangedAction { get; set; }

        public Func<string, object[], bool> StartTransferAction { get; set; }
        public bool IsDefaultClosingSale { get; set; }

        public Action<MEntityOrderConsult> EndStartCreateConsultancyAction { get; set; }

        public Action<MEntityOrderConsult> EndSaveConsultancyAction { get; set; }

        public Action<MEntityOrderConsult> EndStartEditConsultancyAction { get; set; }

        public EFunction TransferType { get; set; }

        public Action<MEntityOrderConsult> ContractConsultAction { get; set; }

        public Action<MEntityOrderConsult> SelectedConsultChanged { get; set; }
    }

    

}
