
using VegunSoft.Framework.Gui.Provider.WindowsForms.Views;

namespace VegunSoft.Customer.View.Forms
{
    public interface ITreatmentHistoryForm: IForm
    {
        void Init(string customerId, string customerDisplayCode,
            string customerFullName, string treatmentId = "", string treatmentServiceId = "",
            string treatmentHistoryId = "", string targetDoctor = "");

    }
}
