using System.Collections.Generic;
using VegunSoft.Acc.Entity.Provider.Acc;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Treatment.Widget.Forms
{
    public interface IFMainTreatmentServiceHistories
    {

        MEntityOrderItem OrderItem { get; set; }

        List<MEntityUserAccountMin> Assistants { get; set; }

        List<MEntityOrderItem> OrderItems { get; set; }

        Dictionary<MEntityOrderItem, List<MEntityOrderItemStep>> OrderItemsSteps { get; set; }

        bool IsReadOnly { get; set; }

        List<MEntityOrderItemStep> Histories { get; set; }

        MEntityUserAccountMin SelectedAssistant { get; set; }

        bool IsInProcess { get; set; }

        bool AfterHistoriesClose(MEntityOrderItem orderItem);

        List<MEntityOrderItemStep> PrepareBeforeShowHistories(
            Dictionary<MEntityOrderItem, List<MEntityOrderItemStep>> dict, MEntityOrderItem orderItem,
            MEntityCustomer customer, List<MEntityOrder> orders);
    }
}
