using System.Collections.Generic;
using VegunSoft.Customer.Entity.Process;
using VegunSoft.Customer.Entity.Provider.Process;
using VegunSoft.Customer.Entity.Provider.Profile;

namespace VegunSoft.Layer.UcControl.UserControls.Customer
{
    public interface IUcReceiptCustomerQueue
    {
        IUcReceiptCustomerQueue Init(IUcReceiptCustomer masterControl);

        //void ApplyContextMenu(object contextMenu);

        bool IsLoaded { get; set; }

        IUcReceiptCustomerQueue LoadCustomers(List<MEntityCustomerStageMin> steps = null, bool isSilent = false);

        void FocusCustomer(string customerId = null);

        void FocusCustomer(MEntityCustomer customer);

        IUcReceiptCustomerQueue ChangeDepartment();

        //IUcReceiptCustomerQueue OnEndSave();

        bool EndCustomerProcess(bool isShowLoading);

        bool HasFocusedRow { get; }

        IEntityCustomerStageMin ActiveStage { get; }

        string SelectedCustomerStageNote { get; }

        IUcReceiptCustomerQueue ChangeFocusedRowById(string id);
        IUcReceiptCustomerQueue ReLoadFocusedRow();
        IUcReceiptCustomerQueue ApplyDirectConfigs(string startCustomerId, bool isStartDirect);
    }
}
