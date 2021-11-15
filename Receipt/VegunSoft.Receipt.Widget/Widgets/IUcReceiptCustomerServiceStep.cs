using VegunSoft.Customer.Entity.Provider.Profile;

namespace VegunSoft.Layer.UcControl.UserControls.Customer
{
    public interface IUcReceiptCustomerServiceStep
    {
        IUcReceiptCustomerServiceStep Init(IUcReceiptCustomer masterControl);

        IUcReceiptCustomerServiceStep ApplyCustomer(MEntityCustomer customer);


    }
}
