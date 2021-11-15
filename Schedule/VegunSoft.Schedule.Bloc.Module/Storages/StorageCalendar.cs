using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraScheduler;
using VegunSoft.Acc.Entity.Acc;
using VegunSoft.Acc.Entity.Provider.Acc;
using VegunSoft.Base.MService.Provider.Methods;
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
            
            this.EnableReminders = false;
            LoadStatus();
            LoadResource();
            LoadLabels();
        }

        private void LoadLabels()
        {
            var storage = Labels;
            storage.Clear();
            var ds = DsLabels;
            DictLabelEntity.Clear();
            DictEntityIdLabel.Clear();
            foreach (var s in ds)
            {
                var color = s.GetHeaderBackgroundColor();
                var displayName = s.Name;
                var menuCaption = s.Name;
                var model = storage.Add(color, displayName, menuCaption);
                DictLabelEntity.Add(model.Id, s);
                DictEntityIdLabel.Add(s.Id, model.Id);
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
                var color = s.GetBgColor();//GetBgColor
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

        //DsStatus
        private IEnumerable<MEntityScheduleAccountStatus> DsLabels
        {
            get
            {
                var ds = RepositoryScheduleAccountStatus.All().Where(x => x.IsActive && !x.IsDeleted)
                    .OrderBy(x => x.DisplayPriority).ThenBy(x => x.No).ToList();
                return ds;
            }
        }

        private IEnumerable<MEntityScheduleAccountReason> DsStatus
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
