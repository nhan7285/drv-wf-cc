using VegunSoft.Category.Repository.Categories;
using VegunSoft.Order.Repository.Business;
using VegunSoft.Order.Repository.Categories;
using VegunSoft.Product.Repository.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Consult
{
    public partial class UcOrderConsultForm
    {
        private IRepositoryTooth _repositoryTooth;
        protected IRepositoryTooth RepositoryTooth => _repositoryTooth ?? (_repositoryTooth = DbIoc.GetInstance<IRepositoryTooth>());

        private IRepositoryPdsv _repositoryPdsv;
        protected IRepositoryPdsv RepositoryPdsv => _repositoryPdsv ?? (_repositoryPdsv = DbIoc.GetInstance<IRepositoryPdsv>());


        private IRepositoryCustomerConsultancy _repositoryOrderConsult;
        protected IRepositoryCustomerConsultancy RepositoryOrderConsult => _repositoryOrderConsult ?? (_repositoryOrderConsult = DbIoc.GetInstance<IRepositoryCustomerConsultancy>());

        private IRepositoryConsultancyKeyword _repositoryOrderConsultKeyword;
        protected IRepositoryConsultancyKeyword RepositoryOrderConsultKeyword => _repositoryOrderConsultKeyword ?? (_repositoryOrderConsultKeyword = DbIoc.GetInstance<IRepositoryConsultancyKeyword>());
    }
}
