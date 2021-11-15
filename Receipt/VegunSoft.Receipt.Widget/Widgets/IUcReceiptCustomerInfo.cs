using System;
using VegunSoft.Customer.Entity.Provider.Profile;

namespace VegunSoft.Layer.UcControl.UserControls.Customer
{
    public interface IUcReceiptCustomerInfo
    {
        IUcReceiptCustomerInfo Init(IUcReceiptCustomer masterControl);

        IUcReceiptCustomerInfo ShowAptForm(string formName, DateTime dateTime);

        MEntityCustomer CurrentCustomer { get; set; }

        decimal CustomerDebit { get; set; }
    }
}
