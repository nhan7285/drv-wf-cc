using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Tile;
using VegunSoft.App.Widget.Widgets;
using VegunSoft.Base.View.Dev.UserControls;

namespace VegunSoft.Layer.UcControl.Provider.App
{
    public partial class UcShellEvents : UcBase, IUcShellEvents
    {
        public Action ItemsChanged { get; set; }
        public Form ShellForm { get; private set; }
        public UcShellEvents()
        {
            InitializeComponent();
        }

        public IUcShellEvents Init(object shellForm)
        {
            ShellForm = shellForm as Form;
            InitColumns();
            InitGrid();
            return this;
        }

        private void _view_ContextButtonClick(object sender, DevExpress.Utils.ContextItemClickEventArgs e)
        {
            var model = e.DataItem as TileViewItem;
            var rowIdx = model.RowHandle;
            if (rowIdx >= 0)
            {
                var row = DS[rowIdx];               
                if (e.Item?.Tag?.ToString() == "D")
                {
                    Remove(row);
                }
            }
        }
    }
}
