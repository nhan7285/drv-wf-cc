using DevExpress.XtraReports;

namespace VegunSoft.Order.View.Reports
{
    public interface IReportPrescription : IReport
    {
        IReportPrescription Init(string idToathuoc);
    }
}
