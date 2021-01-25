using DevExpress.XtraScheduler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Layer.Entity.Provider.User;
using VegunSoft.Layer.Entity.User;
using VegunSoft.Layer.Repository.App.Repositories.Acc;
using VegunSoft.Schedule.Entity.Provider.Categories;
using VegunSoft.Schedule.MService.Provider.Methods;
using VegunSoft.Schedule.Repository.Categories;

namespace VegunSoft.Schedule.View.Dev.Base
{
    public class StorageSchedule: SchedulerDataStorage
    {

        private IIocService _dbIoc;
        protected IIocService DbIoc => _dbIoc ?? (_dbIoc = XIoc.GetService(CDb.IocKey));

        private IRepositoryScheduleAccountStatus _repositoryStatus;
        protected IRepositoryScheduleAccountStatus RepositoryStatus => _repositoryStatus ?? (_repositoryStatus = DbIoc.GetInstance<IRepositoryScheduleAccountStatus>());

        private IRepositoryUserAccount _repositoryUserAccount;
        protected IRepositoryUserAccount RepositoryUserAccount => _repositoryUserAccount ?? (_repositoryUserAccount = DbIoc.GetInstance<IRepositoryUserAccount>());

        public StorageSchedule(IContainer components): base(components)
        {
            LoadStatus();
            LoadResource();
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
                var ds = RepositoryStatus.All().Where(x => x.IsActive && !x.IsDeleted).ToList();
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
