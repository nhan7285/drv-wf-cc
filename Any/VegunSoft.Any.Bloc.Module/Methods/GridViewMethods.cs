using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums.Image;
using VegunSoft.Framework.Gui.Services;
using VegunSoft.Framework.Ioc;

namespace VegunSoft.Any.View.Service.Dev.Methods
{
    public static class GridViewMethods
    {
        public static void ChangeMode(this GridView gridView, GridControl gridControl,
               GridColumn gridColumn, ToolStripItem mniChangeMode)
        {
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var iconService = guiIoc.GetInstance<IIconService>();
            var isEdit = gridView.ChangeSelectMode(gridControl, gridColumn);
            mniChangeMode.Image = iconService.GetIcon16<EResourceImage16, Image>(isEdit ? EResourceImage16.Select16 : EResourceImage16.Edit16);
            mniChangeMode.Text = isEdit ? "Chọn theo dòng" : "Chọn theo ô";
        }

        public static bool ChangeSelectMode(this GridView gridView, GridControl g, GridColumn col)
        {
            var isEdit = !col.OptionsColumn.AllowEdit;
            var columns = gridView.Columns;
            foreach (GridColumn c in columns)
            {
                if (c.ColumnEdit == null)
                {
                    c.OptionsColumn.AllowEdit = isEdit;
                }
            }
            return isEdit;
        }


        public static void ApplySelectMode(this GridView gridView, GridControl g, GridColumn col, params GridColumn[] ignoreColumns)
        {
            g.DoubleClick += (sender, args) =>
            {
                var isEdit = !col.OptionsColumn.AllowEdit;
                var columns = gridView.Columns;
                foreach (GridColumn c in columns)
                {
                    if (ignoreColumns == null || !ignoreColumns.Contains(c))
                    {
                        if (c.ColumnEdit == null)
                        {
                            c.OptionsColumn.AllowEdit = isEdit;
                        }
                    }

                }
            };

        }
    }
}
