using VegunSoft.Category.Data.Category;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItems
    {
        public void StartNone()
        {
            InputCase = EInputCase.None;
        }

        public void StartAdd()
        {
            InputCase = EInputCase.Adding;
        }

        public void StartEdit()
        {
            InputCase = EInputCase.Editing;
        }
    }
}
