using System;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using VegunSoft.Framework.Method.Person;
using VegunSoft.Framework.Methods;
using EFields = VegunSoft.Schedule.View.Model.Enums.EScheduleCustomFields;

namespace VegunSoft.Schedule.View.Dev.Employee
{
    public partial class FScheduleCalendarEvent
    {
        private void ApplyDefaultValues(Appointment appointment)
        {
            var a = appointment;
           
            if (a == null) return;
            a.AllDay = true;
            a.Start = DateTime.Now;
            a.End = new DateTime(DateTime.Now.Year, 12, 31);
            var fullName = StartUserFullName;

            var cFields = a.CustomFields;

            cFields[EFields.Code.GetCode()] = StartUsername;
            cFields[EFields.Name.GetCode()] = fullName;
            cFields[EFields.Caption.GetCode()] = GetAutoCaption(fullName);

            cFields[EFields.BranchId.GetCode()] = StartBranchId;
            cFields[EFields.BranchName.GetCode()] = StartBranchName;

            cFields[EFields.IsActive.GetCode()] = true;
        }

        private void SyncFullNameToSubject()
        {
            ValCaption = GetAutoCaption(@FullName);
        }

        private string GetAutoCaption(string fullName)
        {
           return fullName.GetNameFromFullName();
        }

        public virtual void BindForLoad(Appointment appointment)
        {
            var a = appointment;
            var cFields = a.CustomFields;

            @Username = cFields[EFields.Code.GetCode()]?.ToString();

            ValCaption = cFields[EFields.Caption.GetCode()]?.ToString();

            @StatusId = cFields[EFields.StatusId.GetCode()]?.ToString();
            //@StatusName = cFields[EFields.StatusName.GetCode()]?.ToString();

            @ReasonId = cFields[EFields.ReasonId.GetCode()]?.ToString();
            //@ReasonName = cFields[EFields.ReasonName.GetCode()]?.ToString();

            @ApproverId = cFields[EFields.ApproverId.GetCode()]?.ToString();
            @ApproverName = cFields[EFields.ApproverName.GetCode()]?.ToString();

            @IsActiveConfig = Convert.ToBoolean(cFields[EFields.IsActive.GetCode()]);

            @ApproveStateId = cFields[EFields.ApproveStateId.GetCode()]?.ToString();
            @ApproveStateName = cFields[EFields.ApproveStateName.GetCode()]?.ToString();

            @BranchId = cFields[EFields.BranchId.GetCode()]?.ToString();
            @BranchName = cFields[EFields.BranchName.GetCode()]?.ToString();

            StateStartDate = a.Start;
            StateEndDate = a.End;
        }

        public virtual void BindForSave(Appointment appointment)
        {
            var a = appointment;
            var cFields = a.CustomFields;

            var approver = @Approver;
            var targetUser = @UserAccount;

            //appointment.ResourceId = @Username;

          
            cFields[EFields.Code.GetCode()] = targetUser?.Username;
            cFields[EFields.Name.GetCode()] = targetUser?.FullName;

            cFields[EFields.Caption.GetCode()] = ValCaption;

            cFields[EFields.StatusId.GetCode()] = @StatusId;
            cFields[EFields.StatusName.GetCode()] = @StatusName;

            cFields[EFields.ReasonId.GetCode()] = @ReasonId;
            cFields[EFields.ReasonName.GetCode()] = @ReasonName;

            cFields[EFields.IsActive.GetCode()] = @IsActiveConfig;

            cFields[EFields.ApproveStateId.GetCode()] = @ApproveStateId;
            cFields[EFields.ApproveStateName.GetCode()] = @ApproveStateName;

            cFields[EFields.ApproverId.GetCode()] = approver?.Username;
            cFields[EFields.ApproverName.GetCode()] = approver?.FullName;

            cFields[EFields.BranchId.GetCode()] = @BranchId;
            cFields[EFields.BranchName.GetCode()] = @BranchName;

            var sc = StorageCalendar;

            a.StatusKey = sc.GetStatusKey(@StatusId);

            a.LabelKey = sc.GetLabelKey(@ReasonId);

            a.Subject = @StatusName;

            a.Start = StateStartDate;
            a.End = StateEndDate;
        }

        protected virtual void BindControllerToControls()
        {
           

            BindControllerToIcon();
            //BindProperties(this._cbbStatus, "Text", "Subject");
            BindProperties(this._cbbBranch, "Text", "Location");
            BindProperties(this.tbDescription, "Text", "Description");
            //BindProperties(this._cbbStatus, "Status", "Status");
            //BindProperties(this._txtStartDate, "EditValue", "DisplayStartDate");
            BindProperties(this._txtStartDate, "Enabled", "IsDateTimeEditable");
           
           
            //BindProperties(this._txtEndDate, "EditValue", "DisplayEndDate", DataSourceUpdateMode.Never);
            BindProperties(this._txtEndDate, "Enabled", "IsDateTimeEditable", DataSourceUpdateMode.Never);
           
            BindProperties(this._chkAllDay, "Checked", "AllDay");
            BindProperties(this._chkAllDay, "Enabled", "IsDateTimeEditable");

            //BindProperties(this._cbbApprover, "UserAccountId", "CustomFields.ApproverId");
            //BindProperties(this._cbbUserAccount, "UserAccountId", "ResourceId", DataSourceUpdateMode.OnPropertyChanged);
            BindProperties(this._cbbUserAccount, "Enabled", "CanEditResource");
            BindToBoolPropertyAndInvert(this._cbbUserAccount, "Visible", "ResourceSharing");

            BindProperties(this.edtResources, "ResourceIds", "ResourceIds");
            BindProperties(this.edtResources, "Visible", "ResourceSharing");
            BindProperties(this.edtResources, "Enabled", "CanEditResource");
            BindProperties(this._lblResource, "Enabled", "CanEditResource");

            //BindProperties(this._cbbReason, "Label", "Label");
            //BindProperties(this.chkReminder, "Enabled", "ReminderVisible");
            //BindProperties(this.chkReminder, "Visible", "ReminderVisible");
            //BindProperties(this.chkReminder, "Checked", "HasReminder");
            //BindProperties(this.cbReminder, "Enabled", "HasReminder");
            //BindProperties(this.cbReminder, "Visible", "ReminderVisible");
            //BindProperties(this.cbReminder, "Duration", "ReminderTimeBeforeStart");

            //BindProperties(this.tbProgress, "Value", "PercentComplete");
            //BindProperties(this.lblPercentCompleteValue, "Text", "PercentComplete", ObjectToStringConverter);
            //BindProperties(this.progressPanel, "Visible", "ShouldEditTaskProgress");
            BindToBoolPropertyAndInvert(this._btnOk, "Enabled", "ReadOnly");
            BindToBoolPropertyAndInvert(this._btnRecurrence, "Enabled", "ReadOnly");
            BindProperties(this._btnDelete, "Enabled", "CanDeleteAppointment");
            BindProperties(this._btnRecurrence, "Visible", "ShouldShowRecurrenceButton");
        }
    }
}
