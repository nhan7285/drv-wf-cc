using System.Linq;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemTracks
    {
        private void OnFinishStepCheckedChanged(bool isChecked)
        {
            var step = EditingRow;

            if (step == null) return;

            step.IsFinishStage = isChecked;

            if (isChecked)
                step.FinishStageDate = RepositoryOrderItem.GetDateTime();
            else
                step.FinishStageDate = null;

            RefreshData();
        }

        private bool CanFinishStep()
        {
            var step = EditingRow;
            if (step == null) return false;
            if (!HasDataSource) return false;
            if(DataSource.Any(x => !IsCustomStep(x) && IsExistFinishStep(step, x)))
            {
                Msg.ShowInfo($"Không thể check chọn hoàn thành bước {step.RawStepName} tới 2 lần!");
                return false;
            }
            return true;
        }

     
    }
}
