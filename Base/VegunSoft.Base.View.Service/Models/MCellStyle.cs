using System;
using DevExpress.XtraGrid.Views.Grid;

namespace VegunSoft.Base.View.Service.Models
{
    public class MCellStyle
    {
        //public string[] FocusRowFields { get; set; }

        public Action<GridView, RowCellStyleEventArgs, MCellStyle> BeginAction { get; set; }

        public Action<GridView, RowCellStyleEventArgs, MCellStyle> EndAction { get; set; }
    }
}
