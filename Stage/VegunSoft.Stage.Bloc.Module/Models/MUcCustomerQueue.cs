using System;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using VegunSoft.Company.Data.Enums;
using VegunSoft.Customer.Entity.Process;

namespace VegunSoft.Layer.UcService.Provider.Models
{
    public class MUcCustomerQueue
    {
        public EFunction QueueType { get; set; }

        public string FormName { get; set; }

        public string Caption { get; set; }

        public Func<bool> IsReadOnlyFunc { get; set; }

        public CheckEdit ChangeToEditControl { get; set; }

        //public Func<MEntityCustomer> GetSelectedCustomerFunc { get; set; }

        public Action<GridView, EFunction, IEntityCustomerStageMin> OnSelectItem { get; set; }

        public Action<GridView, EFunction, IEntityCustomerStageMin> OnFinishProcess { get; set; }

        //public Func<MEntityCompanyDepartment> GetSelectedDepartmentFunc { get; set; }

        //public bool IsAllowFinishFullProcess { get; set; }

        public string MainColumnCaption { get; set; }

        public bool ShowInfoColumn { get; set; } = true;

        public bool HideBusinessMenu { get; set; } 

        public bool ShowMainActionColumn { get; set; } = true;

        public string FollowerCaption { get; set; } = "BS. Theo dõi";

        public string FollowerFieldName { get; set; } = nameof(IEntityCustomerStageMin.DoctorTreatmentLastName);

        public string StartCustomerId { get; set; }

        public bool IsStartDirect { get; set; }
    }
}
