using System;
using DevExpress.XtraGrid.Views.Grid;

namespace VegunSoft.Layer.UcService.Models.Base
{
    public class MCellClick
    {
        //public string[] FocusRowFields { get; set; }

        public Action<GridView, RowCellClickEventArgs, MCellClick> BeginAction { get; set; }
        public Action<GridView, RowCellClickEventArgs, MCellClick> EndAction { get; set; }
    }
}
