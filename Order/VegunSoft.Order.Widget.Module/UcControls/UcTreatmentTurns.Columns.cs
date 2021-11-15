using VegunSoft.Order.Entity.Business.EntityOrder;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcTreatmentTurns
    {
        private void ShowColumns()
        {
            _gcOrderName.Visible = Settings?.IsShowNameColumn ?? false;
            _gcTreatment.Visible = Settings?.IsShowTreatmentColumn ?? false;
            _gcOrderDescription.Visible = Settings?.IsShowDescriptionColumn ?? false;
            _gcOrderConsultingDate.Visible = Settings?.IsShowConsultingDateColumn ?? false;
            _gcIsForOld.Visible = Settings?.IsShowIsForOldColumn ?? false;
        }

        private void ConfigOrderColumns() 
        {
            _gcOrderId.FieldName = nameof(IEntityOrderBusiness.Id);
            _gcOrderConsultingDate.FieldName = nameof(IEntityOrderBusiness.ConsultingDate);
            _gcOrderIsClosed.FieldName = nameof(IEntityOrderBusiness.IsClosed);
            _gcOrderIsCancelled.FieldName = nameof(IEntityOrderBusiness.IsCanceled);
            _gcOrderName.FieldName = nameof(IEntityOrderBusiness.Name);
            _gcOrderDescription.FieldName = nameof(IEntityOrderBusiness.Description);
            _gcFolderName.FieldName = nameof(IEntityOrderBusiness.FolderName);
            _gcIsForOld.FieldName = nameof(IEntityOrderBusiness.IsForOld);
        }

    }
}
