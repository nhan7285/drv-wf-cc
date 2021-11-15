using DevExpress.XtraReports;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;

namespace VegunSoft.Order.Widget.Reports
{
    public interface IOrderReportDraft : IReport
    {
        object DataSource { get; set; }
        IOrderReportDraft Init(MEntityOrder order, bool allowDraft = false);
    }
}
