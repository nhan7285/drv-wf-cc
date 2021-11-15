using System;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Order.Entity.Provider.Business;

namespace VegunSoft.Layer.UcControl.Models
{
    public class MUcConsultancyGrid
    {
        public string FormName { get; set; }

        public Func<MEntityCustomer> GetSelectedCustomerFunc { get; set; }

        public Func<bool> IsReadOnlyFunc { get; set; }

        public Action<MEntityOrderConsult> StartEditAction { get; set; }

        public bool IsHideDeleteColumn { get; set; }
        public bool IsHideIsForAllColumn { get; set; }

        public bool IsHideAssistantColumn { get; set; }
        public bool IsHideStartDateColumn { get; set; }
        public bool IsHideContractColumn { get; set; }
        public Action<string> ShowConsultAction { get; set; }

        public Action<MEntityOrderConsult> ContractConsultAction { get; set; }

        public Action<MEntityOrderConsult> SelectedConsultChanged { get; set; }

    }
}
