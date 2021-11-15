using System;
using System.Linq;
using VegunSoft.Framework.Db.Enums.Data;
using VegunSoft.Order.Entity.Provider.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemTracks
    {
       

        private bool IsAddedFinalStep(MEntityOrderItemStep step)
        {
            return DataSource.Any(x => IsExistFinalStep(step, x));
        }

        private bool IsExistFinalStep(MEntityOrderItemStep step, MEntityOrderItemStep x)
        {
            return x.PdsvStepId == step.PdsvStepId && x.OrderItemId == step.OrderItemId && step.IsFinishStage && x.IsFinishStage;
        }

        private bool IsExistFinishStep(MEntityOrderItemStep step, MEntityOrderItemStep x)
        {
            return x.PdsvStepId == step.PdsvStepId && x.OrderItemId == step.OrderItemId && x.IsFinishStage;
        }

        private bool IsCustomStep(MEntityOrderItemStep step)
        {
            return string.IsNullOrWhiteSpace(step.PdsvStepId);
        }

        private void ApplySelectedValues(MEntityOrderItemStep step)
        {
            step.CustomerId = XCustomerId;
            step.OrderId = XOrderId;
            step.OrderItemId = XOrderItemId;
            step.BranchId = XBranchId;
            RepositoryOrderItemStep.CopyInfo(step, XOrderItem);
            var orderItem = !string.IsNullOrWhiteSpace(XOrderItemId) ? RepositoryOrderItem.Find(XOrderItemId) : null;
            if (orderItem != null)
            {
                step.OrderItemId = orderItem.Id;
                step.OrderItemName = orderItem.Name;
            }
        }

        private void StartAddHistory(MEntityOrderItemStep step)
        {
            var now = Now;
            var stepId = State?.Step?.Id;

            step.Action = EMgmtCase.Insert;
            step.IsTemp = true;
            step.IsWaitingForRating = true;
            step.CustomerStageId = stepId ?? Guid.NewGuid().ToString();


            step.IsNextContent = IsNextContent;
            step.IsForOld = IsCheckedIsForOld;
            step.IsPreventCommission = !IsInProcess;
            if (step.IsPreventCommission) step.PreventCommissionNote = "Không theo quy trình";
            
            step.IsNoTreatment = IsNoTreatment;
            step.IsAssistantMain = IsAssistantMainProcess;
            
            if (step.IsNoTreatment)
            {
                step.IsPreventCommission = true;
                step.PreventCommissionNote = "Không điều trị";
            }

            step.SysInsertId = Guid.NewGuid().ToString();
            ApplySelectedValues(step);
            ApplyDoctorValues(step);
            ApplyAssistantValues(step);
            RepositorySession.ApplyCreatedBasicFields(step, now);

            if (step.IsFinishStage) step.FinishStageDate = now;
            if (!step.IsFinishStage || IsCustomStep(step) || !IsAddedFinalStep(step))
            {
                DataSource.Add(step);
            }
            else
            {
                Msg.ShowInfo("Bước này đã được thêm vào trước đó!");
            }
          
           

            FocusEndRow();

            RefreshData();
        }

        
    }
}
