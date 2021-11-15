using VegunSoft.Framework.Db;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Schedule.Repository.Calendar;
using VegunSoft.Schedule.View.Service.Storages;
using VegunSoft.Session.Repository.Business;

namespace VegunSoft.Schedule.View.Dev.Employee
{
    public partial class FScheduleCalendarEvent
    {
        private static IIocService _dbIoc;
        protected static IIocService DbIoc => _dbIoc ?? (_dbIoc = XIoc.GetService(CDb.IocKey));


        private IRepositorySession _repositorySession;
        protected IRepositorySession RepositorySession => _repositorySession ?? (_repositorySession = DbIoc.GetInstance<IRepositorySession>());


        private IRepositoryCalendarEvent _repositoryCalendarEvent;
        protected IRepositoryCalendarEvent RepositoryCalendarEvent => _repositoryCalendarEvent ?? (_repositoryCalendarEvent = DbIoc.GetInstance<IRepositoryCalendarEvent>());

        protected IStorageCalendar StorageCalendar => this.storage as IStorageCalendar;

    }
}
