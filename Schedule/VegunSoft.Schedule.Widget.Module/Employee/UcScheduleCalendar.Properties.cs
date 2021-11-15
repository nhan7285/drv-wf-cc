using DevExpress.XtraScheduler;
using VegunSoft.Schedule.Repository.Calendar;
using VegunSoft.Schedule.View.Service.Provider.Storages;

namespace VegunSoft.Schedule.View.Dev.Employee
{
    public partial class UcScheduleCalendar
    {   

        private IRepositoryCalendarEvent _repositoryCalendarEvent;
        protected IRepositoryCalendarEvent RepositoryCalendarEvent => _repositoryCalendarEvent ?? (_repositoryCalendarEvent = DbIoc.GetInstance<IRepositoryCalendarEvent>());

        protected StorageCalendar Storage => _schedulerControl.DataStorage as StorageCalendar;

        protected AppointmentCollection Appointments => Storage.Appointments.Items;
    }
}
