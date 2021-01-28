using DevExpress.XtraScheduler;
using System.Linq;
using VegunSoft.Schedule.View.Service.Provider.Methods;
using VegunSoft.Schedule.View.Service.Provider.Storages;

namespace VegunSoft.Schedule.View.Dev.Employee
{
    public partial class FScheduleCalendar
    {
        protected StorageCalendar Storage => schedulerControl.DataStorage as StorageCalendar;

        protected AppointmentCollection Appointments => Storage.Appointments.Items;

        private void LoadData()
        {
            var ds = RepositoryCalendarEvent.All().ToList();
            var appointments = Appointments;
            foreach (var entity in ds)
            {
                var a = Storage.CreateAppointment(AppointmentType.Normal);
                if (entity != null) a?.UpdateFromEntity(entity);
                appointments.Add(a);
            }
        }
    }
}
