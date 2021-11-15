using DevExpress.XtraGrid.Views.Grid;
using VegunSoft.Order.Entity.Business.EntityOrder;

namespace VegunSoft.Doctor.Bloc.Business
{
    public interface IBusinessAdapter
    {
        void ShowPrescriptionPrintView(string id);
        void ShowImageForm(string id);
        void ApplyOrderStyle(GridView gridView);
        void ApplyOrderItemStyle(GridView gridView);
        void ApplyOrderItemProcessingStyle<T>(GridView gridView) where T : IEntityOrderItemStepMin;
    }
}
