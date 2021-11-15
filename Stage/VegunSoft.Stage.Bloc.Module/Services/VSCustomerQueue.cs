using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using VegunSoft.Any.View.Service.Dev.Methods;
using VegunSoft.Base.Entity.Provider.Base;
using VegunSoft.Customer.Entity.Provider.Process;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Provider.WindowsForms.Methods;
using VegunSoft.Framework.Gui.Services;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Layer.UcService.Provider.Methods;
using VegunSoft.Order.View.Service.Dev.Methods;
using VegunSoft.Stage.ViewBloc.Services;

namespace VegunSoft.Stage.ViewBloc.Provider.Services
{
    public class VSCustomerQueue : ICustomerQueueVS
    {
        protected GridControl Grid { get; set; }

        public GridView View { get; set; }

        public bool CanRun => Grid != null && View != null && Column != null;

        public GridColumn Column { get; set; }

        public GridColumn[] Columns { get; set; }

        public bool IsApplied { get; set; }

        public ToolStripSeparator ShowDetailSep { get; set; }

        public ToolStripItem MniShowHistories { get; set; }

        protected ToolStripItem MniChangeMode { get; set; }

        protected IIocService DbIoc { get; private set; }
        protected IIocService GuiIoc { get; private set; }

        protected IIconService IconService { get; private set; }

        public List<ToolStripItem> MniAddNotes { get; set; }

        protected ContextMenuStrip ContextMenu { get; set; }

        private Dictionary<ToolStripItem, Func<bool>> CheckVisibilityDict { get; } = new Dictionary<ToolStripItem, Func<bool>>();
        private Dictionary<ToolStripSeparator, List<ToolStripItem>> ContextMenuItemsDict { get; set; }

        public MEntityCustomerStageMin SelectedRow => View.GetFocusedRow() as MEntityCustomerStageMin ?? View.GetRow(View.FocusedRowHandle) as MEntityCustomerStageMin;

        public VSCustomerQueue()
        {

        }

        public ICustomerQueueVS Init(GridControl grid, GridColumn column, params GridColumn[] columns)
        {
            DbIoc = XIoc.GetService(CDb.IocKey);
            GuiIoc = XIoc.GetService(CGui.IocKey);
            IconService = GuiIoc.GetInstance<IIconService>();

            Grid = grid;
            View = grid.MainView as GridView;
            Column = column;
            Columns = columns;
            return this;
        }

        public ICustomerQueueVS ChangeSelectMode()
        {
            if (!CanRun) return this;
            View.ChangeSelectMode(Grid, Column);
            return this;
        }

        public ICustomerQueueVS ApplyContextMenus(object contextMenu = null, params UserControl[] controls)
        {
            if (!CanRun) return this;
            if (IsApplied) return this;
            //View.ApplySelectMode(Grid, Column);
            View.ApplySelectIDMode(Grid, Column);
            Grid.MouseUp += new MouseEventHandler(_gridCustomers_MouseUp);
            var rs = ApplyContextMenu(contextMenu, controls);

            IsApplied = true;
            return this;
        }

        private void InitContextMenuItemsDicts()
        {
            ContextMenuItemsDict = new Dictionary<ToolStripSeparator, List<ToolStripItem>>();
        }

        public MEntityCustomerStageMin SelectedTransfer =>
            View.GetRow(View.FocusedRowHandle) as MEntityCustomerStageMin;



        public bool HasSelectedCustomer
        {
            get { return !string.IsNullOrWhiteSpace(SelectedTransfer?.CustomerId); }
        }

        private ContextMenuStrip ApplyContextMenu(object contextMenu = null, params UserControl[] controls)
        {
            if (contextMenu == null)
            {
                contextMenu = new ContextMenuStrip();
            }
            //Grid.ContextMenuStrip = contextMenu as ContextMenuStrip;
            //if (!CanRun) return Grid?.ContextMenuStrip;

            Grid.ContextMenuStrip = contextMenu as ContextMenuStrip;
            if (!CanRun) return Grid?.ContextMenuStrip;
            ContextMenu = Grid.ContextMenuStrip;
            if (controls != null)
            {
                foreach (var c in controls)
                {
                    c.ContextMenuStrip = contextMenu as ContextMenuStrip;
                }
            }


            //_mainGridMenu = new ContextMenuStrip();
            MniAddNotes = ContextMenu.AddCustomerNotesItems<MEntityCustomerStageMin, MEntityCustomerStage>(() => View, () => SelectedRow);
            foreach (var mniAddNotes in MniAddNotes)
            {
                CheckAndCacheMenuItem(mniAddNotes, IsShowAddCustomerNote);
            }
            ShowDetailSep = new ToolStripSeparator();
            ContextMenu.Items.Add(ShowDetailSep);
            MniShowHistories = Grid.AddCustomerShowHistoryMenuItem(ContextMenu, GetAdapterModelFunc);
            CheckAndCacheMenuItem(MniShowHistories, IsShowShowHistoriesItem);

            MniChangeMode = ContextMenu.AddChangeSelectModeMenuItem(View, Grid, Column);
            CheckAndCacheMenuItem(MniChangeMode, IsShowChangeModeItem);
            InitContextMenuItemsDicts();
            return Grid?.ContextMenuStrip;
        }

        private bool IsShowChangeModeItem()
        {
            return true;
        }


        private MEntityDataAdapter GetAdapterModelFunc()
        {
            var row = SelectedRow;
            if (row == null) return null;
            return new MEntityDataAdapter()
            {
                Id = row.CustomerId,
                DisplayKey = row.CustomerDisplayCode,
                FromModel = row
            };
        }



        private bool IsShowAddCustomerNote()
        {
            return HasSelectedCustomer;
        }

        public bool IsShowShowHistoriesItem()
        {
            return HasSelectedCustomer;
        }


        private void _gridCustomers_MouseUp(object sender, MouseEventArgs e)
        {
            if (!CanRun) return;
            var rowHandle = View.FocusedRowHandle;
            if (rowHandle < -1) return;
            var allowEdit = Column.OptionsColumn.AllowEdit;
            if (e.Button == MouseButtons.Right && !allowEdit)
            {
                var view = View;
                var pt = view.GridControl.PointToClient(Control.MousePosition);
                var info = view.CalcHitInfo(pt);
                if (info.InRow || info.InRowCell)
                {
                    if (info.Column == Column || (Columns?.Contains(info.Column) ?? false))
                    {
                        ShowContextMenu();
                    }
                }
            }
        }

        private void ShowContextMenu()
        {
            if (!CanRun) return;
            var row = SelectedRow;
            //var hasCustomer = !string.IsNullOrWhiteSpace(row?.Id);
            //_customerStatusItems?.CheckShowCustomerGlobalStatusItems(hasCustomer, row?.CustomerStatusId);

            UpdateContextMenu();
            ContextMenu.DisplayAtCursor();
        }

        private void UpdateContextMenu()
        {

            CheckAndShowMenuItems();
            CheckAndShowMenuSeparators();
        }

        private void CheckAndShowMenuItems()
        {
            foreach (var kv in CheckVisibilityDict)
            {
                var item = kv.Key;
                var val = kv.Value.Invoke();
                item.Visible = val;
            }
        }

        private void CheckAndShowMenuSeparators()
        {
            foreach (var kv in ContextMenuItemsDict)
            {
                var separator = kv.Key;
                var isVisible = false;
                foreach (var item in kv.Value)
                {
                    if (CheckVisibilityDict.ContainsKey(item))
                    {
                        var b = CheckVisibilityDict[item].Invoke();
                        isVisible = isVisible || b;
                    }
                }
                separator.Visible = isVisible;
            }
        }

        private void CheckAndCacheMenuItem(ToolStripItem item, Func<bool> func)
        {
            if (CheckVisibilityDict.ContainsKey(item))
            {
                CheckVisibilityDict[item] = func;
            }
            else
            {
                CheckVisibilityDict.Add(item, func);
            }
        }
    }
}
