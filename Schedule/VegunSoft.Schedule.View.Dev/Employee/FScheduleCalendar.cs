using System;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraScheduler;
using VegunSoft.Framework.Methods;
using VegunSoft.Schedule.View.Model.Dicts;
using VegunSoft.Schedule.View.Model.Provider.Employee;

namespace VegunSoft.Schedule.View.Dev.Employee
{
    public partial class FScheduleCalendar : RibbonForm
    {
       

        public FScheduleCalendar()
        {
            InitializeComponent();
            BindingCustomerFields(Storage);
            Init(new MViewSchedulePersonel());
        }

        private void FSchedule_Load(object sender, EventArgs e)
        {
            LoadOne();
            LoadData();
           // var accounts = RepositoryUserAccount.All().ToList();
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

        private void schedulerControl_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            var scheduler = (SchedulerControl)(sender);
            var form = new FScheduleCalendarEvent(scheduler, e.Appointment, e.OpenRecurrenceForm);
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
                var appointments = Appointments;
                foreach (var a in appointments)
                {
                    if (string.IsNullOrWhiteSpace(a.Id?.ToString()))
                    {
                        var resourceId = a.CustomFields["ApproverId"];
                        //var resourceIds = a.ResourceIds;
                        //a.CustomFields.Add(new DevExpress.XtraScheduler.Native.CustomField("1", "2"));
                        //a.SetId("NHAN@@");
                    }
                }
            }
            finally
            {
                form.Dispose();
            }

        }
    }
}