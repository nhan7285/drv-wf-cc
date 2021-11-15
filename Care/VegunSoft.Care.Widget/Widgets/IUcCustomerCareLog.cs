using VegunSoft.Care.Entity.Provider.Business;

namespace VegunSoft.Care.Widget.Widgets
{
    public interface IUcCustomerCareLog
    {
        void StartCreate(MEntityCustomerCareLog log, bool isApplyDefaultValues = true);

        void DoSaveLog();

        void LoadLogs(MEntityCustomerCare task);

        void ApplyInitInfo(MEntityCustomerCareLog log);

        void ApplyBasicInfo(MEntityCustomerCareLog log, MEntityCustomerCare task);
        void ApplyAdvInfo(MEntityCustomerCareLog log, MEntityCustomerCare task);
    }
}
