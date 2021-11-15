using VegunSoft.Customer.Entity.Provider.Profile;

namespace VegunSoft.Layer.UcControl.UserControls.Customer
{
    public interface IUcReceiptCustomer
    {
       

        IUcReceiptCustomer ApplyCustomer(MEntityCustomer customer);

        //IUcReceiptCustomer UpdateUIValues(MEntityCustomerTransfer model);

        void LoadCustomerReceipts();

        IUcReceiptCustomer FocusUIReceiptTab();

        bool _isSetting { get; set; }

    }
}
