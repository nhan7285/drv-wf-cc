using System;
using VegunSoft.Customer.Entity.Provider.Profile;

namespace VegunSoft.Layer.UcService.Provider.Models
{
    public class MUcCustomerNote
    {
        public string FormName { get; set; }

        public Func<MEntityCustomer> GetSelectedCustomerFunc { get; set; }

        public Func<bool> IsReadOnlyFunc { get; set; }

        public Action<string> UpdateTitleFunc { get; set; }
    }
}
