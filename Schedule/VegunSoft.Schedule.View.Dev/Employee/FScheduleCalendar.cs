using System;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraScheduler;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Framework.Methods;
using VegunSoft.Layer.Repository.App.Repositories.Acc;
using VegunSoft.Schedule.View.Model.Dicts;
using VegunSoft.Schedule.View.Model.Provider.Employee;

namespace VegunSoft.Schedule.View.Dev.Employee
{
    public partial class FScheduleCalendar : RibbonForm
    {
        private IIocService _dbIoc;
        protected IIocService DbIoc => _dbIoc ?? (_dbIoc = XIoc.GetService(CDb.IocKey));

        private IRepositoryUserAccount _repositoryUserAccount;
        protected IRepositoryUserAccount RepositoryUserAccount => _repositoryUserAccount ?? (_repositoryUserAccount = DbIoc.GetInstance<IRepositoryUserAccount>());

        public FScheduleCalendar()
        {
            InitializeComponent();
            BindingCustomerFields(schedulerControl.DataStorage);
            Init(new MViewSchedulePersonel());
        }

        private void FSchedule_Load(object sender, EventArgs e)
        {
            LoadOne();

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

                foreach(var a in scheduler.DataStorage.Appointments.Items)
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