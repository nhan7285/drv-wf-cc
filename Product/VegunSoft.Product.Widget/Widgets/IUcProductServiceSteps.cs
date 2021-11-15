using System;
using System.Collections.Generic;
using VegunSoft.Acc.Entity.Acc;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;
using VegunSoft.Product.Entity.Provider.Business;

namespace VegunSoft.Layer.UcControl.Customer.Orders
{
    public interface IUcProductServiceSteps
    {
        List<MEntityPdsvStep> DataSource { get; }

        IUcProductServiceSteps Init(string rightsCode, Func<IEntityUserAccountMin> getDoctorFunc, Func<IEntityUserAccountMin> getAssistantFunc, Action<MEntityOrderItemStep> addAction);

        //IUcProductServiceSteps LockEdit();

        IUcProductServiceSteps LoadData(Func<List<MEntityOrderItemStep>> getOrderItemStepsFunc, MEntityOrderItem orderItem, bool isReadOnly);

        IUcProductServiceSteps RefreshStatus();

        IUcProductServiceSteps ReloadCommissions();
    }
}
