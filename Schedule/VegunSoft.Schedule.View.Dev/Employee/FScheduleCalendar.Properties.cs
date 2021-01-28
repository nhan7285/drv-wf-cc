using VegunSoft.Framework.Db;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Layer.Repository.App.Repositories.Acc;
using VegunSoft.Schedule.Repository.Calendar;

namespace VegunSoft.Schedule.View.Dev.Employee
{
    public partial class FScheduleCalendar
    {
        private IIocService _dbIoc;
        protected IIocService DbIoc => _dbIoc ?? (_dbIoc = XIoc.GetService(CDb.IocKey));

        private IRepositoryUserAccount _repositoryUserAccount;
        protected IRepositoryUserAccount RepositoryUserAccount => _repositoryUserAccount ?? (_repositoryUserAccount = DbIoc.GetInstance<IRepositoryUserAccount>());

        private IRepositoryCalendarEvent _repositoryCalendarEvent;
        protected IRepositoryCalendarEvent RepositoryCalendarEvent => _repositoryCalendarEvent ?? (_repositoryCalendarEvent = DbIoc.GetInstance<IRepositoryCalendarEvent>());
    }
}
