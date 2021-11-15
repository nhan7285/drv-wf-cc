using VegunSoft.Base.Model.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;

namespace VegunSoft.Layer.UcControl.Customer.Models
{
    public class MSaveOrderConfig: MSaveConfig
    {
        public bool IsNeedReloadFolder { get; set; }

        public bool IsNeedAddConsult { get; set; }

        

        public MEntityOrder Entity { get; set; }
    }
}
