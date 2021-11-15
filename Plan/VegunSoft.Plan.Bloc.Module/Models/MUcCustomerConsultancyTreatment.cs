using VegunSoft.Company.Data.Enums;

namespace VegunSoft.Layer.UcService.Provider.Models
{
    public class MUcCustomerConsultancyTreatment
    {
        public string FormName { get; set; }
       

        public EFunction Type { get; set; }

        public ECompanyPart Part { get; set; }

        public string DepartmentId { get; set; }

        public System.Windows.Forms.Form Parent { get; set; }

        public bool IsHideTreatmentCustomers { get; set; }

        public bool IsHideConsultancyCustomers { get; set; }

        public bool IsHideClosingSaleCustomers { get; set; }

        public string StartCustomerId { get; set; }

        public bool IsStartDirect { get; set; }

        public EFunction StartQueueType { get; set; }
    }

}
