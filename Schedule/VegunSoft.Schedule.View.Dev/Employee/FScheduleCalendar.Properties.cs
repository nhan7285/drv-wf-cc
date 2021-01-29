using DevExpress.XtraScheduler;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Layer.Repository.App.Repositories.Acc;
using VegunSoft.Message.Service.App;
using VegunSoft.Schedule.Repository.Calendar;
using VegunSoft.Schedule.View.Service.Provider.Storages;

namespace VegunSoft.Schedule.View.Dev.Employee
{
    public partial class FScheduleCalendar
    {

        private static IIocService _guiIoc;
        protected static IIocService GuiIoc => _guiIoc ?? (_guiIoc = XIoc.GetService(CGui.IocKey));

        private IAppMessage _msg;
        protected IAppMessage Msg => _msg ?? (_msg = GuiIoc.GetInstance<IAppMessage>());

        private IIocService _dbIoc;
        protected IIocService DbIoc => _dbIoc ?? (_dbIoc = XIoc.GetService(CDb.IocKey));

        private IRepositoryUserAccount _repositoryUserAccount;
        protected IRepositoryUserAccount RepositoryUserAccount => _repositoryUserAccount ?? (_repositoryUserAccount = DbIoc.GetInstance<IRepositoryUserAccount>());

        private IRepositoryCalendarEvent _repositoryCalendarEvent;
        protected IRepositoryCalendarEvent RepositoryCalendarEvent => _repositoryCalendarEvent ?? (_repositoryCalendarEvent = DbIoc.GetInstance<IRepositoryCalendarEvent>());

        protected StorageCalendar Storage => _schedulerControl.DataStorage as StorageCalendar;

        protected AppointmentCollection Appointments => Storage.Appointments.Items;
    }
}
