using VegunSoft.Framework.Gui.Provider.WindowsForms.Views;

namespace VegunSoft.Prescription.Widget.Forms
{
    public interface ITreatmentPrescriptionForm : IForm
    {
        void Init(string customerId, int customerNo, string customerCode, string customerDisplayCode, string customerFullName, string treatmentId = "", string prescriptionId = "");
    }
}
