using DevExpress.XtraScheduler;
using System;
using VegunSoft.Framework.Methods;
using EFields = VegunSoft.Schedule.View.Model.Enums.EScheduleCustomFields;
using MEntity = VegunSoft.Schedule.Entity.Provider.Configurations.MEntityScheduleAccountConfig;

namespace VegunSoft.Schedule.View.Service.Provider.Methods
{
    public static class MethodScheduleAccountConfig
    {
        public static MEntity GetEntity(this Appointment appointment)
        {
            var a = appointment;
            var cFields = a.CustomFields;
            var entity = new MEntity()
            {
                Caption = a.Subject,
                Description = a.Description,

                Code = cFields[EFields.Code.GetCode()]?.ToString(),
                Name = cFields[EFields.Name.GetCode()]?.ToString(),

                StatusId = cFields[EFields.StatusId.GetCode()]?.ToString(),
                StatusName = cFields[EFields.StatusName.GetCode()]?.ToString(),

                ReasonId = cFields[EFields.ReasonId.GetCode()]?.ToString(),
                ReasonName = cFields[EFields.ReasonName.GetCode()]?.ToString(),               
               
                StartDate = a.Start,
                EndDate = a.End,

                IsAllDay = a.AllDay,
                IsActive = Convert.ToBoolean(cFields[EFields.IsActive.GetCode()]),

                ApproveStateId = cFields[EFields.ApproveStateId.GetCode()]?.ToString(),
                ApproveStateName = cFields[EFields.ApproveStateName.GetCode()]?.ToString(),

                ApproverId = cFields[EFields.ApproverId.GetCode()]?.ToString(),
                ApproverName = cFields[EFields.ApproverName.GetCode()]?.ToString(),

                BranchId = cFields[EFields.BranchId.GetCode()]?.ToString(),
                BranchName = cFields[EFields.BranchName.GetCode()]?.ToString(),
            };
            return entity;
        }

       
    }
}
