using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraScheduler;
using VegunSoft.Layer.Repository.App.Repositories.Acc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Db;

namespace VegunSoft.Schedule.View.Dev.Base
{
    public partial class FSchedule : RibbonForm
    {
        private IIocService _dbIoc;
        protected IIocService DbIoc => _dbIoc ?? (_dbIoc = XIoc.GetService(CDb.IocKey));

        private IRepositoryUserAccount _repositoryUserAccount;
        protected IRepositoryUserAccount RepositoryUserAccount => _repositoryUserAccount ?? (_repositoryUserAccount = DbIoc.GetInstance<IRepositoryUserAccount>());

        public FSchedule()
        {
            InitializeComponent();
            
        }

        private void FSchedule_Load(object sender, EventArgs e)
        {
            LoadOne();

           // var accounts = RepositoryUserAccount.All().ToList();
        }

        private void schedulerControl_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            var scheduler = (SchedulerControl)(sender);
            var form = new FScheduleAppointment(scheduler, e.Appointment, e.OpenRecurrenceForm);
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;

                foreach(var a in scheduler.DataStorage.Appointments.Items)
                {
                    if (string.IsNullOrWhiteSpace(a.Id?.ToString()))
                    {
                        var resourceId = a.ResourceId;
                        var resourceIds = a.ResourceIds;
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