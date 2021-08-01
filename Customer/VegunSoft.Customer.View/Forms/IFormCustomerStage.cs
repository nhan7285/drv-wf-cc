using System.Windows.Forms;
using VegunSoft.Customer.Entity.Process;

namespace VegunSoft.Customer.View.Forms
{
    public interface IFormCustomerStage
    {
        bool IsIn { get; set; }
        bool IsOut { get; set; }
        bool IsFinish { get; set; }
        bool IsMultiBranch { get; set; }
        void SelectTreatmentDepartment();

        IFormCustomerStage Init(object sender, IEntityCustomerStageMin fromStep, bool ChiHienThi_CLS = false);

        DialogResult ShowDialog();

        bool IsMoved { get; set; }

        bool HasPrescriptions { get; set; }
    }
}
