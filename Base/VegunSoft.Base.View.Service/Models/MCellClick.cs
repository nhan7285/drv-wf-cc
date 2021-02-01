using System;
using DevExpress.XtraGrid.Views.Grid;

namespace VegunSoft.Base.View.Service.Models
{
    public class MCellClick
    {
        //public string[] FocusRowFields { get; set; }

        public Action<GridView, RowCellClickEventArgs, MCellClick> BeginAction { get; set; }
        public Action<GridView, RowCellClickEventArgs, MCellClick> EndAction { get; set; }
    }
}
