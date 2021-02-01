using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Internal.Implementations;
using VegunSoft.Acc.Entity.Acc;
using VegunSoft.Base.View.Dev.UserControls;
using VegunSoft.Framework.Methods;
using VegunSoft.Schedule.View.Model.Dicts;
using VegunSoft.Schedule.View.Model.Provider.Employee;
using EFields = VegunSoft.Schedule.View.Model.Enums.EScheduleCustomFields;
namespace VegunSoft.Schedule.View.Dev.Employee
{
    public partial class UcScheduleCalendar : UcBase
    {
        public SchedulerControl SchedulerControl => _schedulerControl;

        public UcScheduleCalendar()
        {
            InitializeComponent();
            BindingCustomerFields(Storage);
            Init(new MViewSchedulePersonel());
        }

        public void OnFormLoad()
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

        public UcScheduleCalendar SetState(IEnumerable<IEntityUserAccountMin> accs, bool isActive)
        {
            if(accs == null || accs.Count() == 0)
            {
                StateUsers.Clear();
                return this;
            }
            if (isActive)
            {
                foreach(var acc in accs)
                {
                    if (!StateUsers.Any(x=> x.Username == acc.Username)) StateUsers.Add(acc);
                }
               
            }
            else
            {
                var listRemove = new List<IEntityUserAccountMin>();
                foreach (var acc in accs)
                {
                    var users = StateUsers.Where(x => x.Username == acc.Username);
                    if (users.Count() > 0) listRemove.AddRange(users);
                }
                if(listRemove.Count > 0)
                {
                    foreach (var acc in listRemove) StateUsers.Remove(acc);
                }
            }
            UpdateUIState();
          


            return this;
        }

       private IEntityUserAccountMin GetDefaultAccount()
        {
            var acc = StateUsers.FirstOrDefault(x => x.Username == RepositorySession.Username);
            if (acc != null) return acc;
            return StateUsers.LastOrDefault() ?? RepositorySession.User;
        }

        private void schedulerControl_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            var scheduler = (SchedulerControl)(sender);
            var form = new FScheduleCalendarEvent(scheduler, e.Appointment, e.OpenRecurrenceForm);
            var acc = GetDefaultAccount();
            form.StartUsername = acc?.Username;
            form.StartUserFullName = acc?.FullName;
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
                LoadData();
                //var appointments = Appointments;
                //foreach (var a in appointments)
                //{
                //    if (string.IsNullOrWhiteSpace(a.Id?.ToString()))
                //    {
                //        var resourceId = a.CustomFields["ApproverId"];
                //        //var resourceIds = a.ResourceIds;
                //        //a.CustomFields.Add(new DevExpress.XtraScheduler.Native.CustomField("1", "2"));
                //        //a.SetId("NHAN@@");
                //    }
                //}
            }
            finally
            {
                form.Dispose();
            }

        }

        private void schedulerControl_AllowAppointmentDelete(object sender, AppointmentOperationEventArgs e)
        {

        }

        private void schedulerControl_DeleteRecurrentAppointmentFormShowing(object sender, DeleteRecurrentAppointmentFormEventArgs e)
        {

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

        private void schedulerControl_VisibleIntervalChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void _schedulerControl_AppointmentViewInfoCustomizing(object sender, AppointmentViewInfoCustomizingEventArgs e)
        {
           
        }

        private void _schedulerControl_CustomizeAppointmentFlyout(object sender, CustomizeAppointmentFlyoutEventArgs e)
        {
            e.ShowReminder = false;
            e.ShowLocation = true;
        }

        private void _btnClearUsers_Click(object sender, EventArgs e)
        {
            StateUsers?.Clear();
            UpdateUIState();
            LoadData();
        }
    }
}