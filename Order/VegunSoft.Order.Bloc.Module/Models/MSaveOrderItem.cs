using VegunSoft.Framework.Db.Enums.Data;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Layer.UcControl.Customer.Models
{
    public class MSaveOrderItem
    {
        public MEntityOrderItem Item { get; set; }

        public EMgmtCase Case { get; set; }
    }
}
