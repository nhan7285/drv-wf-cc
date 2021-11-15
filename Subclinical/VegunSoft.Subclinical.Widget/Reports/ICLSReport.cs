using DevExpress.XtraReports;

namespace VegunSoft.Layer.UcControl.Customer.Forms
{
    public interface ICLSReport : IReport
    {
        ICLSReport Init(string idCLS_ChidinhCLS);
    }
}
