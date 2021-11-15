using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;

namespace VegunSoft.Stage.ViewBloc.Services
{
    public interface ICustomerQueueVS
    {
        ICustomerQueueVS Init(GridControl grid, GridColumn column, params GridColumn[] columns);

        ICustomerQueueVS ChangeSelectMode();

        ICustomerQueueVS ApplyContextMenus(object contextMenu = null, params UserControl[] controls);
    }
}
