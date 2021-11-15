using VegunSoft.Base.Model.Business;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;

namespace VegunSoft.Layer.UcControl.Customer.Models
{
    public class MSaveOrderResult: ISaveResult
    {
        public bool IsSuccess { get; set; }

        //public bool HasSaveConsult { get; set; }

        public bool IsSaveConsultSuccess { get; set; }

        public bool IsSaveOrderSuccess { get; set; }

        public bool IsUpdateCustomerSuccess { get; set; }

        public string Message { get; set; }

        public string ReturnName { get; set; }

        public MEntityOrder Entity { get; set; }

        public MEntityOrderConsult ConsultEntity { get; set; }
    }
}
