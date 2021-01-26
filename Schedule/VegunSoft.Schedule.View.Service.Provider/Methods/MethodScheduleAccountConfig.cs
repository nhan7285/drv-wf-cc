using DevExpress.XtraScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegunSoft.Framework.Methods;
using VegunSoft.Schedule.Entity.Provider.Configurations;
using VegunSoft.Schedule.View.Model.Enums;

namespace VegunSoft.Schedule.View.Service.Provider.Methods
{
    public static class MethodScheduleAccountConfig
    {
        public static MEntityScheduleAccountConfig GetEntity(this Appointment appointment)
        {
            var entity = new MEntityScheduleAccountConfig()
            {
                Code = appointment.ResourceId?.ToString(),
                Name = appointment.CustomFields[EScheduleCustomFields.Name.GetCode()]?.ToString(),
                ApproverId = appointment.CustomFields[EScheduleCustomFields.ApproverId.GetCode()]?.ToString(),
                ApproverName = appointment.CustomFields[EScheduleCustomFields.ApproverName.GetCode()]?.ToString(),
            };
            return entity;
        }

       
    }
}
