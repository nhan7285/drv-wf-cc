using VegunSoft.Framework.Gui.Provider.WindowsForms.Views;

namespace VegunSoft.Care.Widget.Forms
{
    public interface IFCustomerCare : IForm
    {
        int BackDays { get; set; }

        string TargetCustomerId { get; set; }

        bool IsHidePhoneNumber { get; set; }

        bool IsFullDate { get; set; }

        bool IsMerge { get; set; }

        void ResetDataSource();
    }
}
