using System.Collections.Generic;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Layer.Repository.App.Repositories.Acc;
using VegunSoft.Schedule.Entity.Provider.Categories;
using VegunSoft.Schedule.Repository.Categories;

namespace VegunSoft.Schedule.View.Service.Provider.Storages
{
    public partial class StorageCalendar
    {

        #region Ioc

        private IIocService _dbIoc;
        protected IIocService DbIoc => _dbIoc ?? (_dbIoc = XIoc.GetService(CDb.IocKey)); 

        #endregion

        #region Repositories

        private IRepositoryScheduleAccountStatus _repositoryScheduleAccountStatus;
        protected IRepositoryScheduleAccountStatus RepositoryScheduleAccountStatus => _repositoryScheduleAccountStatus ?? (_repositoryScheduleAccountStatus = DbIoc.GetInstance<IRepositoryScheduleAccountStatus>());

        private IRepositoryScheduleAccountReason _repositoryScheduleAccountReason;
        protected IRepositoryScheduleAccountReason RepositoryScheduleAccountReason => _repositoryScheduleAccountReason ?? (_repositoryScheduleAccountReason = DbIoc.GetInstance<IRepositoryScheduleAccountReason>());

        private IRepositoryUserAccount _repositoryUserAccount;
        protected IRepositoryUserAccount RepositoryUserAccount => _repositoryUserAccount ?? (_repositoryUserAccount = DbIoc.GetInstance<IRepositoryUserAccount>());

        #endregion

        #region Dictionaries

        private IDictionary<object, MEntityScheduleAccountReason> _dictStatusEntity;
        protected IDictionary<object, MEntityScheduleAccountReason> DictStatusEntity => _dictStatusEntity ?? (_dictStatusEntity = new Dictionary<object, MEntityScheduleAccountReason>());

        private IDictionary<object, MEntityScheduleAccountStatus> _dictLabelEntity;
        protected IDictionary<object, MEntityScheduleAccountStatus> DictLabelEntity => _dictLabelEntity ?? (_dictLabelEntity = new Dictionary<object, MEntityScheduleAccountStatus>());

        private IDictionary<string, object> _dictEntityIdStatus;
        protected IDictionary<string, object> DictEntityIdStatus => _dictEntityIdStatus ?? (_dictEntityIdStatus = new Dictionary<string, object>());

        private IDictionary<string, object> _dictEntityIdLabel;
        protected IDictionary<string, object> DictEntityIdLabel => _dictEntityIdLabel ?? (_dictEntityIdLabel = new Dictionary<string, object>());

        #endregion

    }
}
