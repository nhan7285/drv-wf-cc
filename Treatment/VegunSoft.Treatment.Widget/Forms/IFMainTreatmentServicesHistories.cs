using System.Collections.Generic;
using VegunSoft.Acc.Entity.Provider.Acc;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Treatment.Widget.Forms
{
    public interface IFMainTreatmentServicesHistories
    {
        #region Config
        /// <summary>
        /// Gets or sets a value indicating whether this instance is read only.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is read only; otherwise, <c>false</c>.
        /// </value>
        bool IsReadOnly { get; set; }

        #endregion

        #region Order

        /// <summary>
        /// Gets or sets the orders.
        /// </summary>
        /// <value>
        /// The orders.
        /// </value>
        List<MEntityOrder> Orders { get; set; }

        /// <summary>
        /// Gets or sets the order items.
        /// </summary>
        /// <value>
        /// The order items.
        /// </value>
        List<MEntityOrderItem> OrderItems { get; set; }

        /// <summary>
        /// Gets or sets the order items steps.
        /// </summary>
        /// <value>
        /// The order items steps.
        /// </value>
        Dictionary<MEntityOrderItem, List<MEntityOrderItemStep>> OrderItemsSteps { get; set; }

        #endregion

        #region Persons

        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        /// <value>
        /// The customer.
        /// </value>
        MEntityCustomer Customer { get; set; }

        /// <summary>
        /// Gets or sets the assistants.
        /// </summary>
        /// <value>
        /// The assistants.
        /// </value>
        List<MEntityUserAccountMin> Assistants { get; set; }

        /// <summary>
        /// Gets or sets the selected assistant.
        /// </summary>
        /// <value>
        /// The selected assistant.
        /// </value>
        MEntityUserAccountMin SelectedAssistant { get; set; }

        #endregion

    }
}
