using System.Collections.Generic;
using DevExpress.XtraGrid.Columns;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemTracks
    {
        private IList<GridColumn> _commissionsColumns;
        protected IList<GridColumn> CommissionsColumns
        {
            get
            {
                if (_commissionsColumns == null)
                {
                    _commissionsColumns = new List<GridColumn>()
                    {
                       _gcIsPaidRose,
                       _gcRosePaidDate,
                    };
                }
                return _commissionsColumns;
            }
        }

        private IList<GridColumn> _addingColumns;
        protected IList<GridColumn> AddingColumns
        {
            get
            {
                if (_addingColumns == null)
                {
                    _addingColumns = new List<GridColumn>()
                    {
                       _gcIsForOld,
                       
                    };
                }
                return _addingColumns;
            }
        }

        private IList<GridColumn> _advColumns;
        protected IList<GridColumn> AdvancedColumns
        {
            get
            {
                if (_advColumns == null)
                {
                    _advColumns = new List<GridColumn>()
                    {
                       _gcOrderItemStepAssistantFullName,
                       _gcOrderItemStepIsFinishStep,
                       _gcOrderItemStepFinishDate,
                       _gcOrderItemStepIsFinishTreatment,
                       _gcOrderItemStepIsNoTreatment,

                        _gcOrderItemStepDelete,
                       _gcOrderItemStepBookLabo,
                       _gcOrderItemStepIsAssistantMain,
                       _gcOrderItemStepIsDoctorMain,
                      
                    };
                }
                return _advColumns;
            }
        }

        private void UpdateAdvancedColumns()
        {
            var isShow = !IsMinColumn;
            foreach (var c in AdvancedColumns)
            {
                c.Visible = isShow;
            }
        }

        private void UpdateColumnsStatus()
        {
            var isShow = CanApprove;
            var canEdit = CanEdit;
            foreach (var c in CommissionsColumns)
            {
                c.Visible = isShow;
                c.OptionsColumn.ReadOnly = !canEdit;
                if (!isShow) c.OptionsColumn.AllowShowHide = false;
            }
        }

        private void UpdateAddingColumnsStatus()
        {
            var isShow = CanChangeTime;
            var canEdit = CanEdit;
            foreach (var c in AddingColumns)
            {
                c.Visible = isShow;
                //c.OptionsColumn.ReadOnly = !canEdit;
                if (!isShow) c.OptionsColumn.AllowShowHide = false;
            }

            //_gcOrderItemStepCreatedDate,
        }

        private void SetProductServiceColumnsField()
        {
            _gcOrderItemId.FieldName = nameof(MEntityOrderItem.Id);
            _gcPdsvTargetName.FieldName = nameof(MEntityOrderItem.ProductServiceTargetName);
            _gcProductServiceName.FieldName = nameof(MEntityOrderItem.ProductServiceTeethName);
            _gcProductServiceOrderDisplayName.FieldName = nameof(MEntityOrderItem.OrderId);
            _gcProductServiceDoctor.FieldName = nameof(MEntityOrderItem.WorkerUsername);
        }

        private void SetOrderColumnsField()
        {
            _gccTreatmentId.FieldName = nameof(MEntityOrder.Id);
            _gccTreatmentCreatedDate.FieldName = nameof(MEntityOrder.ConsultingDate);
            _gccTreatmentIsClosed.FieldName = nameof(MEntityOrder.IsClosed);
            _gccTreatmentIsCancelled.FieldName = nameof(MEntityOrder.IsCanceled);
        }

        private void SetDetailColumnsField()
        {
            //AssistantUsername
            _gcId.FieldName = nameof(MEntityOrderItemStep.Id);
            _gcOrderItemStepContent.FieldName = nameof(MEntityOrderItemStep.StepDisplayText);
            _gcOrderItemStepCreatedDate.FieldName = nameof(MEntityOrderItemStep.CreatedDate);
            _gcOrderItemStepDoctorFullName.FieldName = nameof(MEntityOrderItemStep.DoctorFullName);
            _gcOrderItemStepTeethName.FieldName = nameof(MEntityOrderItemStep.TeethName);
            //_gccHistoryAssistantUsername.FieldName = nameof(MEntityOrderItemStep.AssistantUsername);
            _gcOrderItemStepDescription.FieldName = nameof(MEntityOrderItemStep.Note);
            _gcOrderItemStepNote.FieldName = nameof(MEntityOrderItemStep.Description);
            _gcOrderItemStepHasPrescription.FieldName = nameof(MEntityOrderItemStep.HasPrescription);
            _gcOrderItemStepHasSubclinicals.FieldName = nameof(MEntityOrderItemStep.HasSubclinical);
            _gcOrderItemStepPrescriptionId.FieldName = nameof(MEntityOrderItemStep.PrescriptionId);
            _gcOrderItemStepSubclinicalId.FieldName = nameof(MEntityOrderItemStep.SubclinicalId);
            _gcOrderItemStepIsFinishStep.FieldName = nameof(MEntityOrderItemStep.IsFinishStage);
            _gcOrderItemStepFinishDate.FieldName = nameof(MEntityOrderItemStep.FinishStageDate);
            _gcOrderItemStepIsFinishTreatment.FieldName = nameof(MEntityOrderItemStep.IsFinishProcess);
            _gcOrderItemStepIsNoTreatment.FieldName = nameof(MEntityOrderItemStep.IsNoTreatment);
            _gcOrderItemStepIsNoCommission.FieldName = nameof(MEntityOrderItemStep.IsPreventCommission);
            _gcOrderItemStepIsNextContent.FieldName = nameof(MEntityOrderItemStep.IsNextContent);
            _gcOrderItemStepIsAssistantMain.FieldName = nameof(MEntityOrderItemStep.IsAssistantMain);
            _gcOrderItemStepIsDoctorMain.FieldName = nameof(MEntityOrderItemStep.IsDoctorMain);
            _gcOrderItemStepAssistantFullName.FieldName = nameof(MEntityOrderItemStep.AssistantFullName);

            _gcOrderItemStepGroupName.FieldName = nameof(MEntityOrderItemStep.GroupName);
            _gcOrderItemStepGroupName.OptionsColumn.AllowEdit = false;
            _gcOrderItemStepGroupName.OptionsColumn.ReadOnly = true;

            _gcIsPaidRose.FieldName = nameof(MEntityOrderItemStep.IsRoseFinished);
            _gcRosePaidDate.FieldName = nameof(MEntityOrderItemStep.RoseFinishedDate);
            _gcIsForOld.FieldName = nameof(MEntityOrderItemStep.IsForOld);
        }

        private void SetMasterColumnsField()
        {
            _gcOrderItemStepOrderId.FieldName = nameof(MEntityOrderItemStep.OrderId);
            _gcOrderItemStepOrderItemPdsvName.FieldName = nameof(MEntityOrderItemStep.ProductServiceName);
            _gcOrderItemStepOrderItemStepId.FieldName = nameof(MEntityOrderItemStep.LocalDisplayPriority);
        }
    }
}
