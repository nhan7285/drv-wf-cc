﻿using DevExpress.XtraScheduler;
using System;
using VegunSoft.Framework.Methods;
using VegunSoft.Schedule.View.Service.Storages;
using EFields = VegunSoft.Schedule.View.Model.Enums.EScheduleCustomFields;
using MEntity = VegunSoft.Schedule.Entity.Provider.Calendar.MEntityCalendarEvent;

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
               
                Description = a.Description,

                Id = cFields[EFields.Id.GetCode()]?.ToString(),
                Code = cFields[EFields.Code.GetCode()]?.ToString(),
                Name = cFields[EFields.Name.GetCode()]?.ToString(),

                Caption = cFields[EFields.Caption.GetCode()]?.ToString(),

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

        public static void UpdateFromEntity(this Appointment appointment, MEntity entity, IStorageCalendar storageCalendar)
        {
            var a = appointment;
            a.HasReminder = false;

            var cFields = a.CustomFields;
            
            //a.ResourceId = entity.Code;
          
            //a.LabelKey = entity.ReasonId;
            //a.StatusKey = entity.StatusId;

            a.Subject = entity.StatusName;
            a.Description = entity.Description;
            a.AllDay = entity.IsAllDay;
            a.Start = entity.StartDate != null ? entity.StartDate.Value: DateTime.MinValue;
            a.End = entity.EndDate != null ? entity.EndDate.Value : DateTime.MaxValue;

            cFields[EFields.Id.GetCode()] = entity.Id;

            cFields[EFields.Code.GetCode()] = entity.Code;
            cFields[EFields.Name.GetCode()] = entity.Name;
            cFields[EFields.Caption.GetCode()] = entity.Caption;

            cFields[EFields.StatusId.GetCode()] = entity.StatusId;
            cFields[EFields.StatusName.GetCode()] = entity.StatusName;

            cFields[EFields.ReasonId.GetCode()] = entity.ReasonId;
            cFields[EFields.ReasonName.GetCode()] = entity.ReasonName;

            cFields[EFields.IsActive.GetCode()] = entity.IsActive;

            cFields[EFields.ApproverId.GetCode()] = entity.ApproverId;
            cFields[EFields.ApproverName.GetCode()] = entity.ApproverName;

            cFields[EFields.ApproveStateId.GetCode()] = entity.ApproveStateId;
            cFields[EFields.ApproveStateName.GetCode()] = entity.ApproveStateName;

            cFields[EFields.BranchId.GetCode()] = entity.BranchId;
            cFields[EFields.BranchName.GetCode()] = entity.BranchName;

            var sc = storageCalendar;
            

            a.StatusKey = sc.GetStatusKey(entity.ReasonId);//ReasonId
            //a.StatusId = 1;
            a.LabelKey = sc.GetLabelKey(entity.StatusId);

            a.Location = entity.BranchId;
        }
    }
}
