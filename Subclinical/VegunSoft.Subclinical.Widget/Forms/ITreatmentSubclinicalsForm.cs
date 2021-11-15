using VegunSoft.Framework.Gui.Provider.WindowsForms.Views;

namespace VegunSoft.Subclinical.Widget.Forms
{
    public interface ITreatmentSubclinicalsForm : IForm
    {
        void Init(string customerId, int customerNo, string customerCode, string customerDisplayCode, string customerFullName, string treatmentId = "", string subclinicalId = "");
    }
}
