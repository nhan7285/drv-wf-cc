using VegunSoft.Acc.View.Dev.UserControls;
using VegunSoft.Company.Data.Enums;
using VegunSoft.Company.Entity.Business.Structure;
using VegunSoft.Company.Repository.Structure;
using VegunSoft.Customer.Entity.Profile;
using VegunSoft.Customer.Entity.Provider.Process;
using VegunSoft.Customer.Repository.Business;
using VegunSoft.Receipt.Business.Customer;

namespace VegunSoft.Customer.View.Dev.UserControls
{
    public class UcBaseCustomer : UcBaseAcc
    {

        private IPortalCustomer _portalCustomer;

        protected IPortalCustomer PortalCustomer => _portalCustomer ?? (_portalCustomer = DbIoc.GetInstance<IPortalCustomer>());

        private IRepositoryCustomer _repositoryCustomer;

        protected IRepositoryCustomer RepositoryCustomer => _repositoryCustomer ?? (_repositoryCustomer = DbIoc.GetInstance<IRepositoryCustomer>());

        private IRepositoryCustomerStage _repositoryCustomerStage;
        protected IRepositoryCustomerStage RepositoryCustomerStage => _repositoryCustomerStage ?? (_repositoryCustomerStage = DbIoc.GetInstance<IRepositoryCustomerStage>());

        private IRepositoryCustomerNote _repositoryCustomerNote;

        protected IRepositoryCustomerNote RepositoryCustomerNote => _repositoryCustomerNote ?? (_repositoryCustomerNote = DbIoc.GetInstance<IRepositoryCustomerNote>());

        private IRepositoryFunction _repositoryFunction;
        protected IRepositoryFunction RepositorFunction => _repositoryFunction ?? (_repositoryFunction = DbIoc.GetInstance<IRepositoryFunction>());

        protected MEntityCustomerStageMin GetVirtualStep(IEntityCustomerMin customer, IEntityDepartmentMin department, EFunction queueType, bool isReadOnly)
        {
            return RepositoryCustomerStage.GetVirtualStep(customer, department, queueType, isReadOnly);
        }
    }
}
