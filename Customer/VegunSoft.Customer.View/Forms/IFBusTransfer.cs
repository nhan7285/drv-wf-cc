using System.Windows.Forms;
using VegunSoft.Layer.Entity.Customer.Transfer;

namespace VegunSoft.Layer.UcControl.Customer.Forms
{
    public interface IFBusTransfer
    {
        bool IsIn { get; set; }
        bool IsOut { get; set; }
        bool IsFinish { get; set; }
        bool IsMultiBranch { get; set; }
        void SelectTreatmentDepartment();

        IFBusTransfer Init(object sender, IEntityCustomerStepMin fromStep, bool ChiHienThi_CLS = false);

        DialogResult ShowDialog();

        bool IsMoved { get; set; }

        bool HasPrescriptions { get; set; }
    }
}
