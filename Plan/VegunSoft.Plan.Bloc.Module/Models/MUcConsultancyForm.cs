using System;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Layer.UcControl.Forms.Order.Consult;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;

namespace VegunSoft.Layer.UcControl.Models
{
    public class MUcConsultancyForm
    {
        public string FormName { get; set; }

        public Func<MEntityCustomer> GetSelectedCustomerFunc { get; set; }

        public Func<bool> IsReadOnlyFunc { get; set; }

        public Func<IUcOrderConsultBody> GetContentFunc { get; set; }

        public Func<MEntityOrder> GetSelectedOrderFunc { get; set; }
    }
}
