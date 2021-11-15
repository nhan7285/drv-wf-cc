using VegunSoft.Acc.Entity.Acc;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemTracks
    {
        private void OnSelectAssistant(IEntityUserAccountMin acc)
        {
            if (acc == null) return;
            var step = SelectedOrderItemStep;
            if (step == null) return;
            step.AssistantUsername = acc.Username;
            step.AssistantFullName = acc.FullName;
        }

        private void OnSelectDoctor(IEntityUserAccountMin acc)
        {
            if (acc == null) return;
            var step = SelectedOrderItemStep;
            if (step == null) return;
            step.DoctorUsername = acc.Username;
            step.DoctorFullName = acc.FullName;
        }
    }
}
