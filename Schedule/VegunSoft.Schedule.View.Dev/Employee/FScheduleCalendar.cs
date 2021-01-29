using System;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Internal.Implementations;
using VegunSoft.Framework.Methods;
using VegunSoft.Schedule.View.Model.Dicts;
using VegunSoft.Schedule.View.Model.Provider.Employee;
using EFields = VegunSoft.Schedule.View.Model.Enums.EScheduleCustomFields;
namespace VegunSoft.Schedule.View.Dev.Employee
{
    public partial class FScheduleCalendar : RibbonForm
    {
       

        public FScheduleCalendar()
        {
            InitializeComponent();

            var sc = _ucScheduleCalendar.SchedulerControl;
            this.dateNavigator.SchedulerControl = sc;
            this.calendarToolsRibbonPageCategory1.Control = sc;
            this.schedulerBarController1.Control = sc;
            Init(new MViewSchedulePersonel());
        }

        private void FSchedule_Load(object sender, EventArgs e)
        {
            _ucScheduleCalendar.OnFormLoad();
        }

        private void BindingCustomerFields(ISchedulerStorage storage)
        {
            foreach(var kv in DScheduleStructure.AppointmentCustomFields)
            {
                var fieldName = kv.Key.GetCode();
                var fielType = kv.Value;
                storage.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping(fieldName, fieldName, fielType));
            }
        }

      

        private void schedulerStorage_AppointmentDeleting(object sender, PersistentObjectCancelEventArgs e)
        {
            var a = e.Object as AppointmentItem;
            if(a != null)
            {
                var id = a.CustomFields[EFields.Id.GetCode()]?.ToString();
                if (string.IsNullOrWhiteSpace(id)) e.Cancel = true;
                var isSuccess = RepositoryCalendarEvent.Delete(id);
                if (!isSuccess)
                {
                    Msg?.ShowDeleteErrorInfo("sự kiện");
                    e.Cancel = true;
                }
            }
        }

        private void schedulerStorage_AppointmentCollectionAutoReloading(object sender, CancelListChangedEventArgs e)
        {

        }

        private void schedulerStorage_AppointmentChanging(object sender, PersistentObjectCancelEventArgs e)
        {

        }

        private void schedulerStorage_AppointmentCollectionCleared(object sender, EventArgs e)
        {

        }

        private void schedulerStorage_AppointmentCollectionLoaded(object sender, EventArgs e)
        {

        }

   
    }
}