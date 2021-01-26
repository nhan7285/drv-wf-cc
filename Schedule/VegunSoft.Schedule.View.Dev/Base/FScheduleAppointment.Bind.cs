using DevExpress.XtraScheduler;
using VegunSoft.Framework.Methods;
using VegunSoft.Schedule.Entity.Provider.Configurations;
using VegunSoft.Schedule.View.Model.Enums;
using VegunSoft.Schedule.View.Service.Provider.Methods;

namespace VegunSoft.Schedule.View.Dev.Base
{
    public partial class FScheduleAppointment
    {
        public virtual void LoadCustomData(Appointment appointment)
        {
            _cbbUserAccount.EditValue = appointment.ResourceId?.ToString();
            _cbbApprover.EditValue = appointment.CustomFields[EScheduleCustomFields.ApproverId.GetCode()]?.ToString();
        }

        public virtual bool SaveCustomData(Appointment appointment)
        {
            var approver = ValApprover;

            appointment.CustomFields[EScheduleCustomFields.ApproverId.GetCode()] = approver?.Username;
            appointment.CustomFields[EScheduleCustomFields.ApproverName.GetCode()] = approver?.FullName;

            var entity = appointment.GetEntity();
            return true;
        }

       
    }
}
