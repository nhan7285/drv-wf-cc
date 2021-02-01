using DevExpress.XtraGrid.Views.Grid;
using VegunSoft.Framework.Db.Models;
using VegunSoft.Layer.UcService.Models.Base;

namespace VegunSoft.Layer.UcService.Services
{
    public interface IGridViewEventService
    {
        int TopRowIndex { get; set; }

        int FocusedRowHandle { get; set; }

        IGridViewEventService Init(GridView view, params string[] focusRowFields);

        IGridViewEventService ApplyEvents<T>(MCellStyle style, MCellClick click) where T : IMgmtAction;

        IGridViewEventService ApplyMgmtCellStyle<T>(RowCellStyleEventArgs e, MCellStyle style) where T : IMgmtAction;

        IGridViewEventService ApplyMgmtCellClick<T>(RowCellClickEventArgs e, MCellClick click) where T : IMgmtAction;
    }
}
