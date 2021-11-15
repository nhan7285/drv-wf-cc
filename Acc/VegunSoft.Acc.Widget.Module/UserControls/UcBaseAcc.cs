using VegunSoft.Acc.Repository.Business;
using VegunSoft.App.View.Dev.UserControls;
using VegunSoft.Base.Entity.Base;

namespace VegunSoft.Acc.View.Dev.UserControls
{
    public class UcBaseAcc: UcBaseMgmt
    {
        private IRepositoryUserAccount _repositoryUserAccount;
        protected IRepositoryUserAccount RepositoryUserAccount => _repositoryUserAccount ?? (_repositoryUserAccount = DbIoc.GetInstance<IRepositoryUserAccount>());

        private IRangeModel _rangeModel;
        protected IRangeModel RangeModel => _rangeModel ?? (_rangeModel = CheckRightsService.GetDateRange(SessionCode, RightsCode));
    }
}
