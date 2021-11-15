using System.Collections.Generic;
using System.Drawing;
using System.Text;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using VegunSoft.Customer.Entity.Process;
using VegunSoft.Customer.Entity.Provider.Process;
using VegunSoft.Framework.Db.Enums.Data;
using VegunSoft.Order.Entity.Business.EntityOrder;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;
using VegunSoft.Product.Entity.Provider.Business;

namespace VegunSoft.Layer.UcService.Provider.Methods
{
    public static class GridViewMethods
    {

        public static void ApplyCustomerTooltip(this GridView gridView, System.ComponentModel.IContainer components)
        {
            if (components == null) return;

            var grid = gridView.GridControl;
            var tooltipController = new ToolTipController(components);
            tooltipController.SuperTipMaxWidth = 350;
            grid.ToolTipController = tooltipController;
            tooltipController.GetActiveObjectInfo += (s, e) =>
            {
                if (e.Info == null && e.SelectedControl == grid)
                {
                    GridView view = grid.FocusedView as GridView;
                    GridHitInfo info = view.CalcHitInfo(e.ControlMousePosition);
                    if (info.InRowCell)
                    {
                        var m = view.GetRow(info.RowHandle) as MEntityCustomerStageMin;
                        if (m != null)
                        {
                            var sb = new StringBuilder();
                            var isAdded = false;
                            if (!string.IsNullOrWhiteSpace(m.Note))
                            {
                                sb.AppendLine("--- Ghi chú chuyển ---");
                                sb.AppendLine(m.Note);
                                isAdded = true;
                            }
                            if (!string.IsNullOrWhiteSpace(m.CustomerNotes))
                            {
                                if (isAdded) sb.AppendLine();
                                sb.AppendLine("--- Ghi chú khách ---");
                                sb.AppendLine(m.CustomerNotes);
                            }
                            string cellKey = info.RowHandle.ToString() + " - " + info.Column.ToString();
                            e.Info = new ToolTipControlInfo(cellKey, sb.ToString())
                            {
                                // AllowHtmlText = DefaultBoolean.True
                            };
                            return;
                        }


                    }
                }
            };
        }


        public static Dictionary<GridColumn, int> CacheColumnIndexes(this GridView gridView)
        {
            var d = new Dictionary<GridColumn, int>();
            var columns = gridView.Columns;
            foreach (GridColumn c in columns)
            {
                d.Add(c, c.VisibleIndex);
            }

            return d;
        }

        public static void ShowHideColumns(this Dictionary<GridColumn, int> dict, bool isVisible, params GridColumn[] columns)
        {
            foreach (var kv in dict)
            {
                kv.Key.VisibleIndex = kv.Value;
            }

            if (columns != null)
            {
                foreach (var c in columns)
                {
                    if (isVisible != c.Visible) c.Visible = isVisible;
                }
            }

        }

        public static void ApplySelectModeCheckBox(this GridView gridView, CheckEdit checkEdit)
        {
            checkEdit.CheckedChanged += (sender, args) =>
            {
                var isEdit = checkEdit.Checked;
                var columns = gridView.Columns;
                foreach (GridColumn c in columns)
                {
                    if (c.ColumnEdit == null)
                    {
                        c.OptionsColumn.AllowEdit = isEdit;
                    }
                }
            };
        }

       
        public static void ApplySelectIDMode(this GridView gridView, GridControl g, GridColumn col)
        {
            g.DoubleClick += (sender, args) =>
            {
                var isEdit = !col.OptionsColumn.AllowEdit;
                var columns = gridView.Columns;
                GridColumn c = columns[1];
                if (c.ColumnEdit == null)
                {
                    c.OptionsColumn.AllowEdit = isEdit;
                }

            };

        }
       
        public static void ApplyTransferStyle(this GridView gridView)
        {
            gridView.RowCellStyle += (sender, e) =>
            {
                if (e.RowHandle >= 0)
                {
                    if (gridView.GetRow(e.RowHandle) is IEntityCustomerStageMin item)
                    {
                        if (item.IsInProgress || item.IsAccepted)
                        {
                            e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Underline | e.Appearance.Font.Style);
                        }
                        if (item.IsSelected)
                        {
                            e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold | e.Appearance.Font.Style);
                        }
                        //if (item.IsSavedData)
                        //{
                        //    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Strikeout | e.Appearance.Font.Style);
                        //}

                        if (item.IsSelf)
                        {
                            e.Appearance.ForeColor = Color.Green;
                        }

                        if (!string.IsNullOrWhiteSpace(item.Note))
                        {
                            e.Appearance.ForeColor = Color.DarkRed;
                        }

                        if (!string.IsNullOrWhiteSpace(item.CustomerNotes))
                        {
                            e.Appearance.BackColor = Color.LightYellow;
                        }

                        if (!item.IsSaved)
                        {
                            e.Appearance.ForeColor = Color.Red;
                        }
                    }
                }
            };


        }

        public static void ApplyOrderStyle(this GridView gridView)
        {
            gridView.RowCellStyle += (sender, e) =>
            {
                if (gridView.GetRow(e.RowHandle) is MEntityOrder item)
                {
                    if (item.IsTemporary)
                    {
                        e.Appearance.ForeColor = Color.ForestGreen;
                    }
                    else if (item.HasTemporary)
                    {
                        e.Appearance.ForeColor = Color.Blue;
                    }

                    if (item.IsChanged)
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Strikeout | e.Appearance.Font.Style);
                    }

                    if (item.HasWorkingItems)
                    {
                        e.Appearance.BackColor = Color.FromArgb(230, 255, 247);//Linen
                    }

                    if (item.IsFolder)
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold | e.Appearance.Font.Style);
                    }

                    if (item.IsForOld)
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Italic | e.Appearance.Font.Style);
                    }
                }
                if (e.RowHandle == gridView.FocusedRowHandle)
                {
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Underline | e.Appearance.Font.Style);
                }
            };
        }

        public static int HoveredRowHandle = GridControl.InvalidRowHandle;

        public static void ApplyPdsvStepStyle(this GridView gridView)
        {
            gridView.MouseMove += (sender, e) =>
            {
                var view = sender as GridView;
                var hitInfo = view.CalcHitInfo(e.Location);
                if (hitInfo.RowHandle != HoveredRowHandle)
                {
                    view.RefreshRow(HoveredRowHandle);
                    HoveredRowHandle = hitInfo.RowHandle;
                    view.RefreshRow(HoveredRowHandle);
                }
            };

            gridView.RowCellStyle += (sender, e) =>
            {
                var isFocused = e.RowHandle == gridView.FocusedRowHandle;
                var isOver = e.RowHandle == HoveredRowHandle;
                if (gridView.GetRow(e.RowHandle) is MEntityPdsvStep item)
                {
                    if (item.HasRose)
                    {
                        e.Appearance.BackColor = Rose.Data.DColor.RoseBackColor;
                    }
              
                    if (item.IsFinished)
                    {
                        e.Appearance.ForeColor = isOver ? Color.Black : Color.Gray;

                    }
                    else if (item.IsInProgress)
                    {
                        e.Appearance.ForeColor = isOver ? Color.DarkRed : Color.Red;
                    }

                    if (!item.IsFinished)
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        e.Appearance.ForeColor = isOver ? Color.Brown : Color.Black;
                    }
                    if (item.IsLock)
                    {
                        e.Appearance.ForeColor = isOver ? Color.Black : Color.LightGray;
                    }
                }
                if (isFocused)
                {
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Underline | e.Appearance.Font.Style);
                }
            };
        }

        public static void ApplyOrderItemStepStyle<T>(this GridView view) where T : IEntityOrderItemStepMin
        {
            view.RowCellStyle += (sender, e) =>
            {
                if (view.GetRow(e.RowHandle) is T step)
                {
                    if (step.IsNextContent)
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font, e.Appearance.Font.Style | FontStyle.Italic);

                        if (e.Column.Tag?.ToString() == "STT")
                        {
                            e.Appearance.TextOptions.HAlignment = HorzAlignment.Near;
                        }
                    }
                }
            };

            view.RowStyle += (sender, e) =>
            {
                if (view.GetRow(e.RowHandle) is T step && step != null)
                {
                    if (step.IsFinishStage)
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font, e.Appearance.Font.Style | FontStyle.Underline);
                    }
                    if (step.IsFinishProcess)
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font, e.Appearance.Font.Style | FontStyle.Bold);
                    }

                    if (step.HasRose)
                    {
                        e.Appearance.BackColor = Rose.Data.DColor.RoseBackColor;
                    }
                    if (step.Action == EMgmtCase.Insert)
                    {
                        e.Appearance.ForeColor = Color.Green;
                    }
                    if (step.Action == EMgmtCase.Update)
                    {
                        e.Appearance.ForeColor = Color.Blue;
                    }
                    if (step.IsNoTreatment)
                    {
                        e.Appearance.ForeColor = Color.Red;
                    }
                }

            };
        }

    }
}
