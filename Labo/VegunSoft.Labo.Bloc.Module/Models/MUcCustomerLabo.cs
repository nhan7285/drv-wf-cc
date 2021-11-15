using System;
using System.Collections.Generic;
using VegunSoft.Category.Entity.Provider.Category.Body;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Layer.UcService.Provider.Models
{
    public class MUcCustomerLabo
    {
        public string FormName { get; set; }

        public bool IsAutoCreate { get; set; }

        public Func<string> GetSelectedAssistantFunc { get; set; }

        public Func<MEntityCustomer> GetSelectedCustomerFunc { get; set; }

        public Func<MEntityOrder> GetSelectedOrderFunc { get; set; }

        public Func<MEntityOrderItem> GetSelectedOrderItemFunc { get; set; }

        public Func<bool> IsReadOnlyFunc { get; set; }

        public Func<List<MEntityTooth>> GetTeethFunc { get; set; }

        public Func<List<MEntityTooth>> GetSelectedTeethFunc { get; set; }
    }
}
