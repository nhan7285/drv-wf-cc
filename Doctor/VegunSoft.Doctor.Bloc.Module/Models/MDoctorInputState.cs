using VegunSoft.Company.Data.Enums;
using VegunSoft.Customer.Entity.Process;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Customer.Repository.Business;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;

namespace VegunSoft.Layer.UcControl.Models
{
    public class MDoctorInputState
    {
        #region Scope Level 1

        public EFunction Type { get; set; }

        public IEntityCustomerStageMin Step { get; set; }

        public MEntityCustomer Customer { get; set; }

        public string CustomerId => Customer?.Id;

        public string CustomerFullName => Customer?.FullName;

        public string CustomerPhoneNumber => Customer?.PhoneNumber;       

        public bool IsEmptyPhoneNumber => string.IsNullOrWhiteSpace(CustomerPhoneNumber);

        public string CustomerDisplayCode => Customer?.DisplayCode;

        public bool HasSelectedCustomer => Customer != null && !string.IsNullOrWhiteSpace(Customer.FullName) && Customer.IsSaved;

        public string FromDepartmentName => Step?.FromDepartmentName;

        public bool IsEmptyFromDepartment => string.IsNullOrWhiteSpace(FromDepartmentName);

        #endregion

        #region Scope Level 2

        public MEntityOrder Order { get; private set; }

        public MEntityOrderConsult Consult { get; private set; }


        #endregion


        public bool IsSelf => Step?.IsSelf ?? false;

        public bool IsInProcess => !IsSelf;

        public string OrderId => Order?.Id;

        public string ConsultId => Order?.ConsultingId;


        private IIocService _dbIoc;
        protected IIocService DbIoc => _dbIoc ?? (_dbIoc = XIoc.GetService(CDb.IocKey));


        private IRepositoryCustomer _repositoryCustomer;

        protected IRepositoryCustomer RepositoryCustomer => _repositoryCustomer ?? (_repositoryCustomer = DbIoc.GetInstance<IRepositoryCustomer>());

        public void Init(EFunction type, IEntityCustomerStageMin step)
        {
            Type = type;
            Step = step;
            Order = null;
            Consult = null;

            if(step?.CustomerId != CustomerId) Start(step?.CustomerId);
        }

        public MEntityCustomer Start(string customerId)
        {
            if (string.IsNullOrWhiteSpace(customerId))
            {
                Customer = null;
            }
            else
            {
                Customer = RepositoryCustomer.Find(customerId);
            }           
            return Customer;
        }

        public void Start(MEntityOrder order)
        {
            Order = order;
        }

        public void Focus(MEntityOrderConsult consult)
        {
            Consult = consult;
        }

        public void Reset()
        {
            Step = null;
            Customer = null;
            Order = null;
            Consult = null;
        }
    }
}
