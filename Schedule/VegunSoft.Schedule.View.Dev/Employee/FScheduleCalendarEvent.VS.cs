using DevExpress.XtraScheduler;
using VegunSoft.Framework.Method.Person;
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
    }
}
