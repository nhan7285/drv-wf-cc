using VegunSoft.App.Model.Provider.Business;
using VegunSoft.Framework.Gui.Provider.WindowsForms.Views;

namespace VegunSoft.Any.Widget.Forms
{
    public interface ITaskForm : IForm
    {
        ITaskForm InitForEdit(MShellTask task);
    }
}
