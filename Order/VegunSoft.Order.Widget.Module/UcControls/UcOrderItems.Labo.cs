using VegunSoft.Any.View.Dev.Forms;
using VegunSoft.Layer.UcService.Provider.Models;
using VegunSoft.Order.Func.Provider.Methods.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItems
    {
        private void StartBookLabo()
        {
            var f = new FAny();
            var uc = new UcOrderItemLabos()
            {
                Text = "Đặt Labo"
            };
            var item = SelectedOrderItem;
            var assistant = _cbbSelectAssistant?.SelectedUserAccount?.Username;
            if (string.IsNullOrWhiteSpace(assistant))
            {
                assistant = item?.WorkerAssistantUsername;
            }
            //_cbbSelectAssistant
            var customer = SelectedCustomer;
            var order = ScopedOrders.Find(x => x.Id == item.OrderId);
            var teeth = item.GetTeeth(ListTeeth);
            uc.CheckAndInit(new MUcCustomerLabo()
            {
                FormName = Settings?.FormName,
                GetSelectedCustomerFunc = () => customer,
                GetSelectedOrderFunc = () => order,
                GetSelectedOrderItemFunc = () => item,
                IsReadOnlyFunc = () => ReadOnly,
                GetTeethFunc = () => ListTeeth,
                GetSelectedTeethFunc = () => teeth,
                IsAutoCreate = true
            }); 
            f.Init(uc, true);
            f.ShowDialog(ParentForm);
        }
    }
}
