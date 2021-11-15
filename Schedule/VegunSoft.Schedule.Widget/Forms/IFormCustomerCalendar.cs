using System;
using VegunSoft.Customer.Entity.Provider.Profile;

namespace VegunSoft.Schedule.Form.Customer.Business
{
    public interface IFormCustomerCalendar
    {
        bool IsNeedStart { get; set; }

        IFormCustomerCalendar ReStart();

        IFormCustomerCalendar Init(MEntityCustomer customer, DateTime? startDate = null);
        IFormCustomerCalendar InitWithGridCustomer(MEntityGridCustomer customer, DateTime? startDate = null);
    }
}
