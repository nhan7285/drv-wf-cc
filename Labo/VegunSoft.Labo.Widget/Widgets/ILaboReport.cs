using DevExpress.XtraReports;
using VegunSoft.Order.Entity.Provider.Business.EntityLabo;

namespace VegunSoft.Layer.UcControl.Customer.Forms
{
    public interface ILaboReport: IReport
    {
        ILaboReport Init(MEntityLabo model);
    }
}
