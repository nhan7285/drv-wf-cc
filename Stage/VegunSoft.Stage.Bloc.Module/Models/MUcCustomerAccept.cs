using System;
using VegunSoft.Company.Data.Enums;

namespace VegunSoft.Layer.UcService.Provider.Models
{
    public class MUcCustomerAccept
    {
        public ECompanyPart Part { get; set; }

        public string DepartmentId { get; set; }

        public string FormName { get; set; }

        public Action<EFunction> OnAcceptAction { get; set; }

        public Action<EFunction, string> OnSearch { get; set; }

        public string StartCustomerId { get; set; }

        public bool IsStartDirect { get; set; }

        public EFunction StartQueueType { get; set; }
    }
}
