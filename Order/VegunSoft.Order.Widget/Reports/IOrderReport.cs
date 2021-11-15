using DevExpress.XtraReports;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;

namespace VegunSoft.Order.Widget.Reports
{
    public interface IOrderReport : IReport
    {
        object DataSource { get; set; }
        IOrderReport Init(MEntityOrder order, bool allowDraft = false);
    }
}
