using DevExpress.XtraEditors;
using VegunSoft.Customer.Entity.Provider.Profile;

namespace VegunSoft.Customer.View.Filters
{
    public interface IFilterCustomer
    {
        string SelectedCustomerId { get; }

        MEntityCustomerMin SelectedCustomer { get; }

        GridLookUpEdit Editor { get; }

        void StartSearch();

        IFilterCustomer SelectCustomer(string id);
    }
}
