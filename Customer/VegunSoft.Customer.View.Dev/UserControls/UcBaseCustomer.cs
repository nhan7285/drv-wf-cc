using VegunSoft.Acc.View.Dev.UserControls;
using VegunSoft.Company.Entity.Business.Structure;
using VegunSoft.Customer.Data.Enums.Process;
using VegunSoft.Customer.Entity.Profile;
using VegunSoft.Customer.Entity.Provider.Process;
using VegunSoft.Customer.Repository.Business;
using VegunSoft.Layer.Calc.Customer;
using VegunSoft.Layer.EValue;

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

        protected MEntityCustomerStageMin GetVirtualStep(IEntityCustomerMin customer, IEntityDepartmentMin department, ETransferType queueType, bool isReadOnly)
        {
            var type = StringEnum.GetStringValue(queueType);
            var user = RepositorySession.GetSessionUser(SessionCode);
            var branch = RepositorySession.GetSessionBranch(SessionCode);
            var customerNote = RepositoryCustomerNote.GetCustomerNotes(customer?.Id);
            var rs = new MEntityCustomerStageMin()
            {

                CreatedDate = RepositoryCustomer.GetDateTime(),
                CustomerNotes = customerNote,
                CustomerId = customer?.Id,
                CustomerNo = customer?.No ?? 0,
                CustomerCode = customer?.Code,
                CustomerFullName = customer?.FullName,
                CustomerPhoneNumber = customer?.PhoneNumber,
                CustomerPrivateInfo = customer?.PrivateInfo,

                DoctorUsername = customer?.DoctorUsername,
                DoctorFullName = customer?.DoctorFullName,
                CreatedUsername = user?.Username,
                CreatedUserFullName = user?.FullName,

                FromDepartmentId = department?.Id,
                FromDepartmentName = department?.Name,
                FromPartId = department?.PartId,
                FromPartName = department?.PartName,

                IsProcessed = false,
                IsNewProcess = true,
                BranchId = branch?.Id,
                FromBranchId = branch?.Id,
                FromBranchName = branch?.Name,
                ToBranchId = branch?.Id,
                ToBranchName = branch?.Name,
                Type = type,
                IsPrivate = true,
                IsReadOnly = isReadOnly,
                IsSelf = true,

                TelesalesId = customer?.TelesalesId,
                TelesalesNo = customer?.TelesalesNo ?? 0,
                TelesalesCode = customer?.TelesalesCode,
                TelesalesUsername = customer?.TelesalesUsername,
                TelesalesFullName = customer?.TelesalesFullName,

                ConnectorId = customer?.ConnectorId,
                ConnectorNo = customer?.ConnectorNo ?? 0,
                ConnectorCode = customer?.ConnectorCode,
                ConnectorUsername = customer?.ConnectorUsername,
                ConnectorFullName = customer?.ConnectorFullName,

            };
            return rs;
        }
    }
}
