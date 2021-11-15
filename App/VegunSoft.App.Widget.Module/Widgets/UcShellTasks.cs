using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Tile;
using VegunSoft.App.Model.Provider.Business;
using VegunSoft.App.Widget.Widgets;
using VegunSoft.Base.View.Dev.UserControls;
using VegunSoft.Framework.Subscribe;

namespace VegunSoft.Layer.UcControl.Provider.App
{
    public partial class UcShellTasks : UcBase, IUcShellTasks
    {
        public Action ItemsChanged { get; set; }
        public Form ShellForm { get; private set; }

        public UcShellTasks()
        {
            InitializeComponent();
        }

        public IUcShellTasks Init(object shellForm)
        {
            ShellForm = shellForm as Form;
            InitColumns();
            InitGrid();
            InitEvents();
            return this;
        }

        private void InitEvents()
        {
            XEvent.Subscribe<MShellTask>(OnAddShellTask);
            XEvent.Subscribe<List<MShellTask>>(OnAddShellTasks);
        }

        private void OnAddShellTask(MShellTask task)
        {
            Add(task);
        }

        private void OnAddShellTasks(List<MShellTask> tasks)
        {
            Add(tasks);
        }

        private void _view_ContextButtonClick(object sender, DevExpress.Utils.ContextItemClickEventArgs e)
        {
            var model = e.DataItem as TileViewItem;
            var rowIdx = model?.RowHandle??-1;
            if (rowIdx >= 0)
            {
                var row = DS[rowIdx];
                if (e.Item?.Tag?.ToString() == "E")
                {
                    Edit(row);
                }
                else if (e.Item?.Tag?.ToString() == "D")
                {
                    Remove(row);
                }
            }

        }

        private void _view_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //var rowIdx = e.FocusedRowHandle;
        }

        private void _view_ItemClick(object sender, TileViewItemClickEventArgs e)
        {
            var model = e.Item;
            var rowIdx = model?.RowHandle ?? -1;
            if (rowIdx >= 0)
            {
                var row = DS[rowIdx];
                Edit(row);
            }
        }
    }
}
