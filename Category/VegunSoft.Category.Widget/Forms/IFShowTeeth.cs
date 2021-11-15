using System.Collections.Generic;
using VegunSoft.Category.Entity.Provider.Category.Body;

namespace VegunSoft.Layer.UcControl.Customer.Forms
{
    public interface IFShowTeeth
    {
        List<MEntityTooth> SelectedTeeth { get; set; }
        bool IsDisableOthersTeeth { get; set; }
    }
}
