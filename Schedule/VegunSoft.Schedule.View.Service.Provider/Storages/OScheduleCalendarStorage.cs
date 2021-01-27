using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraScheduler;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Layer.Entity.Provider.User;
using VegunSoft.Layer.Entity.User;
using VegunSoft.Layer.Repository.App.Repositories.Acc;
using VegunSoft.Schedule.Entity.Provider.Categories;
using VegunSoft.Schedule.MService.Provider.Methods;
using VegunSoft.Schedule.Repository.Categories;

namespace VegunSoft.Schedule.View.Service.Provider.Storages
{
    public class OScheduleCalendarStorage: SchedulerDataStorage
    {

        private IIocService _dbIoc;
        protected IIocService DbIoc => _dbIoc ?? (_dbIoc = XIoc.GetService(CDb.IocKey));

        private IRepositoryScheduleAccountStatus _repositoryScheduleAccountStatus;
        protected IRepositoryScheduleAccountStatus RepositoryScheduleAccountStatus => _repositoryScheduleAccountStatus ?? (_repositoryScheduleAccountStatus = DbIoc.GetInstance<IRepositoryScheduleAccountStatus>());

        private IRepositoryScheduleAccountReason _repositoryScheduleAccountReason;
        protected IRepositoryScheduleAccountReason RepositoryScheduleAccountReason => _repositoryScheduleAccountReason ?? (_repositoryScheduleAccountReason = DbIoc.GetInstance<IRepositoryScheduleAccountReason>());

        private IRepositoryUserAccount _repositoryUserAccount;
        protected IRepositoryUserAccount RepositoryUserAccount => _repositoryUserAccount ?? (_repositoryUserAccount = DbIoc.GetInstance<IRepositoryUserAccount>());

        public OScheduleCalendarStorage(IContainer components): base(components)
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
            foreach(var s in ds)
            {
                var color = s.GetBodyBackgroundColor();
                var displayName = s.Name;
                var menuCaption = s.Name;
                var model = storage.Add(color, displayName, menuCaption);
                
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
