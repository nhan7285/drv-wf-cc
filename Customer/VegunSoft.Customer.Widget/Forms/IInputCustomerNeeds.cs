using VegunSoft.Customer.Entity.Provider.Profile;

namespace VegunSoft.Customer.Widget.Forms
{
    public interface IInputCustomerNeeds
    {
        void ShowPopup(object owner, MEntityCustomer customer, string status, string oldNote, string newNote, bool isSaveCustomer);

        string Note { get; }

        bool IsSave { get; }

        void Init(string formName);
    }
}
