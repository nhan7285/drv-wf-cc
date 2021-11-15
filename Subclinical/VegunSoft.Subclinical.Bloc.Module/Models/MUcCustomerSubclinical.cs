using System;
using VegunSoft.Customer.Entity.Provider.Profile;

namespace VegunSoft.Layer.UcService.Provider.Models
{
    public class MUcCustomerSubclinical
    {
        public string FormName { get; set; }

        public Func<MEntityCustomer> GetSelectedCustomerFunc { get; set; }

        public Func<bool> IsReadOnlyFunc { get; set; }
    }
}
