using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using VegunSoft.Doctor.Bloc.Business;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Ioc;
using VegunSoft.Layer.Gui.Provider.Forms.Treatment;
using VegunSoft.Layer.UcService.Provider.Methods;
using VegunSoft.Order.Entity.Business.EntityOrder;
using VegunSoft.Order.View.Reports;
using VegunSoft.Subclinical.Repository.Business;

namespace VegunSoft.Doctor.Bloc.Module.Business
{
    public class BusinessAdapter : IBusinessAdapter
    {
        public void ShowPrescriptionPrintView(string id)
        {
            XLoading.ShowLoading();
            var report = XIoc.GetService(CGui.IocKey).GetInstance<IReportPrescription>().Init(id);
            ReportPrintTool tool = new ReportPrintTool(report);
            XLoading.CloseLoading();
            tool.ShowPreview();
        }

        public void ShowImageForm(string id)
        {
            XLoading.ShowLoading();
            var ioc = XIoc.GetService(CDb.IocKey);
            var subclinicalService = ioc.GetInstance<IRepositoryCustomerImageFolder>();
            var subclinicalServiceImage = ioc.GetInstance<IRepositoryCustomerImage>();
            var cls = subclinicalService.Find(id);
            var images = subclinicalServiceImage.GetSubclinicalFullImageByDesignationId(id, false);
            frmDialogCLS_ChidinhCLS_Hinhanh imagesform = new frmDialogCLS_ChidinhCLS_Hinhanh();
            imagesform.Start(cls, images);
            XLoading.CloseLoading();
            imagesform.ShowDialog();
        }

        public void ApplyOrderStyle(GridView gridView)
        {
            gridView.ApplyOrderStyle();
        }

        public void ApplyOrderItemStyle(GridView gridView)
        {
            gridView.ApplyOrderItemStyle();
        }

        public void ApplyOrderItemProcessingStyle<T>(GridView gridView) where T : IEntityOrderItemStepMin
        {
            gridView.ApplyOrderItemStepStyle<T>();
        }
    }
}
