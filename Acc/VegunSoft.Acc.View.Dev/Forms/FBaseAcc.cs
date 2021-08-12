using System.Linq;
using VegunSoft.Acc.Entity.Rights;
using VegunSoft.Acc.Repository;
using VegunSoft.Acc.Repository.Business;
using VegunSoft.App.View.Dev.Forms;

namespace VegunSoft.Any.View.Dev.Forms
{
    public class FBaseAcc: FBaseApp
    {
        private IFacRepositoryAcc _facRepositoryAcc;
        protected IFacRepositoryAcc FacRepositoryAcc => _facRepositoryAcc ?? (_facRepositoryAcc = DbIoc.GetInstance<IFacRepositoryAcc>());

        protected IRepositoryUserAccount RepositoryUserAccount => FacRepositoryAcc.RepositoryUserAccount;

        private IUserConfigRepository _repositoryUserConfig;
        protected IUserConfigRepository RepositoryUserConfig => _repositoryUserConfig ?? (_repositoryUserConfig = DbIoc.GetInstance<IUserConfigRepository>());

        private IRangeModel _rangeModel;
        protected IRangeModel RangeModel => _rangeModel ?? (_rangeModel = CheckRightsService.GetDateRange(SessionCode, RightsCode));

        protected IRightsModel GetConfig(string rightsCode)
        {
            return CheckRightsService.GetConfig(SessionCode, rightsCode);
        }
        protected string GetFinalCaption(string rightsCode, string defaultTitle)
        {
            var isValidCode = !string.IsNullOrWhiteSpace(rightsCode);
            var canChangeCaption = isValidCode &&
                Sys.PrivateCaptions.Keys.Contains(rightsCode);
            if (canChangeCaption)
            {
                var isShow = CheckRightsService.CheckCanShow(SessionCode, rightsCode);
                defaultTitle = isShow ? defaultTitle : Sys.PrivateCaptions[rightsCode];
            }

            var cfg = isValidCode ? GetConfig(rightsCode) : null;
            if (!string.IsNullOrWhiteSpace(cfg?.Name)) defaultTitle = cfg?.Name;

            return defaultTitle;
        }
    }
}
