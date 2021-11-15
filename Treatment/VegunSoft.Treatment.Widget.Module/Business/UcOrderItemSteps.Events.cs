using VegunSoft.Product.Entity.Provider.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemSteps
    {
        private void OnAddStep(bool isFinal)
        {
            if (IsReadOnly)
            {
                Msg.ShowReadOnlyError();
                return;
            }
            var config = (MEntityPdsvStep)_view.GetRow(_view.FocusedRowHandle);
            if (config != null)
            {
                if (config.IsLock)
                {
                    Msg.ShowInfo("Bước này đã bị khóa!");
                    return;
                }
                var step = GetNewOrderItemStep(config, isFinal);
                AddAction?.Invoke(step);
                //RefreshStatus();

            }
        }
    }
}
