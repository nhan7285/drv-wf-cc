using System.Collections.Generic;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Layer.UcControl.Customer.Models
{
    public class MSaveOrderItems
    {
        public IList<MEntityOrderItem> AddedItems { get; set; }

        public IList<MEntityOrderItem> UpdatedItems { get; set; }

        public IList<string> DeletedItems { get; set; }
    }
}
