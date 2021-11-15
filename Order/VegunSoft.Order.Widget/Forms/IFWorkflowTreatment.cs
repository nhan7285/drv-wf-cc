using VegunSoft.Company.Data.Enums;

namespace VegunSoft.Layer.Gui.Custome.Order
{
    public interface IFWorkflowTreatment
    {
        string StartCustomerId { get; set; }

        bool IsStartDirect { get; set; }

        EFunction QueueType { get; set; }
    }
}
