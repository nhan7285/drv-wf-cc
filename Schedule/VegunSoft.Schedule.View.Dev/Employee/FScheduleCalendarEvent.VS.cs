using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using VegunSoft.Framework.Methods;
using VegunSoft.Schedule.View.Service.Provider.Methods;
using EFields = VegunSoft.Schedule.View.Model.Enums.EScheduleCustomFields;
namespace VegunSoft.Schedule.View.Dev.Employee
{
    public partial class FScheduleCalendarEvent
    {
        public virtual void LoadCustomData(Appointment appointment)
        {
            var a = appointment;
            var cFields = a.CustomFields;
            var id = cFields[EFields.Id.GetCode()]?.ToString();
            var isNew = string.IsNullOrWhiteSpace(id);
            if (isNew) ApplyDefaultValues(a);
            BindForLoad(appointment);
        }

        public virtual bool SaveCustomData(Appointment appointment)
        {
            var a = appointment;
            BindForSave(appointment);
            var entity = a?.GetEntity();
            entity = entity != null? Save(entity) : null;
            if(entity !=null) a?.UpdateFromEntity(entity, StorageCalendar);
            return true;
        }

        private void ApplyFormat()
        {
            ApplyFormat(_txtStartDate);
            ApplyFormat(_txtEndDate);
        }
        private void ApplyFormat(DateEdit txt)
        {
            var isAllDay = IsAllDay;
            var format = isAllDay ? "dd/MM/yyyy" : "dd/MM/yyyy HH:mm";
            txt.Properties.UseMaskAsDisplayFormat = true;
            txt.Properties.EditFormat.FormatString = format;
            txt.Properties.DisplayFormat.FormatString = format;
            txt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;

            txt.Properties.Mask.EditMask = format;

        }
    }
}
