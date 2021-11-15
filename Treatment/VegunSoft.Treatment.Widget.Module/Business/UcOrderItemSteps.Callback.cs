using System;
using VegunSoft.Acc.Entity.Acc;
using VegunSoft.Order.Entity.Provider.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemSteps
    {
        public Action<MEntityOrderItemStep> AddAction { get; set; }

        protected Func<IEntityUserAccountMin> GetDoctorFunc { get; set; }

        protected Func<IEntityUserAccountMin> GetAssistantFunc { get; set; }
    }
}
