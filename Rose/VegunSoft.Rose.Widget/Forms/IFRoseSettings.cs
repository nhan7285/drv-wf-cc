using VegunSoft.Rose.Entity.Business.Setting;
using VegunSoft.Rose.Widget.Forms;

namespace VegunSoft.Layer.Gui.Employee.Rose
{
    public interface IFRoseSettings: IFRoseDialog
    {
        void Focus(IEntityRoseSettingMin setting);
    }
}
