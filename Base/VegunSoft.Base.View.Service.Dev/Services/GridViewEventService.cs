using System.Drawing;
using System.Linq;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using VegunSoft.Framework.Db.Enums.Data;
using VegunSoft.Framework.Db.Models;
using VegunSoft.Layer.UcService.Models.Base;
using VegunSoft.Layer.UcService.Services;

namespace VegunSoft.Layer.UcService.Provider.Any
{
    public class GridViewEventService: IGridViewEventService
    {
        protected GridView View { get; set; }

        public string[] FocusRowFields { get; set; }

        private int _workingFocusedRowHandle;
        private int _workingTopRowIndex;

        public int FocusedRowHandle
        {
            get
            {
                return View.FocusedRowHandle;
            }
            set
            {
                View.FocusedRowHandle = value;
            }
        }

        public int TopRowIndex
        {
            get
            {
                return View.TopRowIndex;
            }
            set
            {
                View.TopRowIndex = value;
            }
        }

        public IGridViewEventService Init(GridView view, params string[] focusRowFields)
        {
            View = view;
            FocusRowFields = focusRowFields;
            return this;
        }

        public IGridViewEventService ApplyEvents<T>(MCellStyle style, MCellClick click) where T : IMgmtAction
        {
            ApplyRowCellStyleEvent<T>(style);
            ApplyRowCellClickEvent<T>(click);
            return this;
        }

        public IGridViewEventService ApplyRowCellStyleEvent<T>(MCellStyle style) where T : IMgmtAction
        {
            View.RowCellStyle += (s, e) =>
            {
                ApplyMgmtCellStyle<T>(e, style);
            };
            return this;
        }

        public void ApplyRowCellClickEvent<T>(MCellClick click) where T : IMgmtAction
        {
            View.RowCellClick += (s, e) =>
            {
                ApplyMgmtCellClick<T>(e, click);
            };
        }

        public IGridViewEventService ApplyMgmtCellClick<T>(RowCellClickEventArgs e, MCellClick click) where T : IMgmtAction
        {
            click?.BeginAction?.Invoke(View, e, click);

            var focusRowFields = FocusRowFields;
            if (focusRowFields.Contains(e.Column.FieldName))
            {
                if (View.GetRow(e.RowHandle) is T model)
                {
                    var filterValue = View.GetRowCellValue(GridControl.AutoFilterRowHandle, e.Column)?.ToString();
                    if (string.IsNullOrWhiteSpace(filterValue))
                    {
                        _workingFocusedRowHandle = FocusedRowHandle;
                        _workingTopRowIndex = TopRowIndex;
                        var v = View.GetRowCellValue(e.RowHandle, e.Column)?.ToString();
                        View.SetRowCellValue(GridControl.AutoFilterRowHandle, e.Column, v);
                    }
                    else
                    {
                        View.SetRowCellValue(GridControl.AutoFilterRowHandle, e.Column, null);
                        FocusedRowHandle = _workingFocusedRowHandle;
                        TopRowIndex = _workingTopRowIndex;
                    }
                }
            }

            click?.EndAction?.Invoke(View, e, click);
            return this;
        }

        public IGridViewEventService ApplyMgmtCellStyle<T>(RowCellStyleEventArgs e, MCellStyle style) where T : IMgmtAction
        {
            style?.BeginAction?.Invoke(View, e, style);

            var focusRowFields = FocusRowFields;
            if (focusRowFields?.Contains(e.Column.FieldName) ?? false)
            {
                e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Underline);
            }

            if (View.GetRow(e.RowHandle) is T model)
            {
                if (model.Action == EMgmtCase.Insert)
                {
                    e.Appearance.ForeColor = Color.Green;
                }

                if (model.Action == EMgmtCase.Update)
                {
                    e.Appearance.ForeColor = Color.Blue;
                }

            }

            style?.EndAction?.Invoke(View, e, style);

            return this;
        }
    }
}
