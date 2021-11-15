using System;
using VegunSoft.Customer.Entity.Profile;
using VegunSoft.Customer.Entity.Provider.Categories;
using VegunSoft.Customer.Entity.Provider.Profile;

namespace VegunSoft.Customer.View.Forms
{
    public interface IFCustomerNote
    {
        IFCustomerNote ShowDialog(string customerId, Action<string> onDoneAction);

        IFCustomerNote ShowDialog(MEntityCustomer customer, Action<string> onDoneAction);

        IFCustomerNote ShowDialog<T>(T transfer, Action<T, string> act,
            MEntityCustomerCategoryNote caregory) where T : class, ICustomerNotes, new();
    }
}
