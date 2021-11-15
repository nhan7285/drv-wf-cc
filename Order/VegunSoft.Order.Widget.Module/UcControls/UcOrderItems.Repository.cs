using VegunSoft.Acc.Repository.Business;
using VegunSoft.App.Repository.Business.Cfg;
using VegunSoft.App.Repository.Business.Log;
using VegunSoft.Customer.Repository.Business.Rating.Setting;
using VegunSoft.Order.Repository.Business;
using VegunSoft.Product.Repository.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItems
    {
        private IRepositoryUserAccount _userAccountRepository;

        private IRepositoryRatingServiceTask _ratingServiceTask;
        private IRepositoryConfig _configRepository;
        private IRepositoryCustomerConsultancy _repositoryCustomerConsultancy;

        private IRepositorySystemException _repositorySystemException;
        private IRepositoryPdsv _dentistryServiceRepository;
        private IRepositoryPdsvSetting _repositoryProductServiceSetting;


       
    }
}
