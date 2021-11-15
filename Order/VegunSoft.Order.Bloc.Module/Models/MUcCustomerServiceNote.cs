using System;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;

namespace VegunSoft.Layer.UcService.Provider.Models
{
    public class MUcCustomerServiceNote
    {
        public string FormName { get; set; }

        public Func<MEntityCustomer> GetSelectedCustomerFunc { get; set; }

        public Func<MEntityOrder> GetSelectedOrderFunc { get; set; }

        public Func<bool> IsReadOnlyFunc { get; set; }

        public Action<string> UpdateTitleFunc { get; set; }
    }
}
