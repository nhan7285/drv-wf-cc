using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraScheduler;
using VegunSoft.Layer.Entity.Provider.User;
using VegunSoft.Layer.Entity.User;
using VegunSoft.Schedule.Entity.Provider.Categories;
using VegunSoft.Schedule.MService.Provider.Methods;
using VegunSoft.Schedule.View.Service.Storages;

namespace VegunSoft.Schedule.View.Service.Provider.Storages
{
    public partial class StorageCalendar: SchedulerDataStorage, IStorageCalendar
    {

       

        public StorageCalendar(IContainer components): base(components)
        {
            if (!DbIoc.IsRegistered) return;
            LoadStatus();
            LoadResource();
            LoadLabels();
        }

        private void LoadLabels()
        {
            var storage = Labels;
            storage.Clear();
            var ds = DsLabels;
            foreach (var s in ds)
            {
                var color = s.GetBgColor();
                var displayName = s.Name;
                var menuCaption = s.Name;
                var model = storage.Add(color, displayName, menuCaption);

            }
        }

        private void LoadStatus()
        {
            var storage = Statuses;
            storage.Clear();
            var ds = DsStatus;
            DictStatusEntity.Clear();
            DictEntityIdStatus.Clear();
            foreach (var s in ds)
            {
                var color = s.GetBodyBackgroundColor();
                var displayName = s.Name;
                var menuCaption = s.Name;
                var model = storage.Add(color, displayName, menuCaption);
                DictStatusEntity.Add(model.Id, s);
                DictEntityIdStatus.Add(s.Id, model.Id);
            }
        }
       
        private void LoadResource()
        {
            var storage = Resources;
            storage.Clear();
            var ds = DsAccounts;
            foreach (var s in ds)
            {
                //var color = s.GetBodyBackgroundColor();
                var displayName = s.Username;
                var menuCaption = s.Username;
                var model = storage.Add(displayName, menuCaption);

            }
        }

        private IEnumerable<MEntityScheduleAccountStatus> DsStatus
        {
            get
            {
                var ds = RepositoryScheduleAccountStatus.All().Where(x => x.IsActive && !x.IsDeleted)
                    .OrderBy(x => x.DisplayPriority).ThenBy(x => x.No).ToList();
                return ds;
            }
        }

        private IEnumerable<MEntityScheduleAccountReason> DsLabels
        {
            get
            {
                var ds = RepositoryScheduleAccountReason.All().Where(x => x.IsActive && !x.IsDeleted)
                    .OrderBy(x => x.DisplayPriority).ThenBy(x => x.No).ToList();
                return ds;
            }
        }

        private IEnumerable<IEntityUserAccountMin> DsAccounts
        {
            get
            {
                var ds = RepositoryUserAccount.GetActiveScheduleUsers<MEntityUserAccountMin>(string.Empty).ToList();
                return ds;
            }
        }
    }
}
