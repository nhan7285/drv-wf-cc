using System;
using DevExpress.XtraGrid.Views.Grid;

namespace VegunSoft.Layer.UcService.Models.Base
{
    public class MCellStyle
    {
        //public string[] FocusRowFields { get; set; }

        public Action<GridView, RowCellStyleEventArgs, MCellStyle> BeginAction { get; set; }

        public Action<GridView, RowCellStyleEventArgs, MCellStyle> EndAction { get; set; }
    }
}
