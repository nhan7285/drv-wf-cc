using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using VegunSoft.Any.View.Forms;
using VegunSoft.Any.View.Service.Dev.Methods;
using VegunSoft.Base.Entity.Provider.Base;
using VegunSoft.Base.Entity.Provider.Format;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Db.Enums.Data;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Methods;
using VegunSoft.Framework.Gui.Provider.WindowsForms.Methods;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Labo.Entity.Category;
using VegunSoft.Layer.UcService.Provider.Methods;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityLabo;
using VegunSoft.Order.Repository.Business;
using VegunSoft.Order.View.Service.Dev.Methods;

namespace VegunSoft.Layer.UcService.Provider.Models
{
    public class McMaterialRequest
    {
        private IIocService _dbIoc;
        private IIocService _guiIoc;
        private ContextMenuStrip _mainGridMenu;
        private ToolStripItem _mniChangeMode;
        private ToolStripItem _showHistoriesItem;

        public ToolStripSeparator StatusSeparator { get; private set; }

        private List<ToolStripItem> _laboStatusItems;
        private ToolStripItem _showHelpStatusItem;
        private Form _helpStatusForm;
        private GridView _view;
        private GridControl _grid;
        private Form _owner;
        private IEnumerable<MEntityOrderItemStepLaboStatus> _allLaboStatus;
        private List<MEntityOrderItemStepLaboStatus> _listActiveLaboStatus;
        private IRepositoryOrderItemStepLaboStatus _repositoryOrderItemStepMaterialStatus;
        private GridColumn _column;

        public IContainer Components { get; private set; }

        protected bool NeedChangeMode { get; private set; }
        public Func<bool> CheckAutoSaveFunc { get; private set; }
        public Func<bool> CheckAddNoteFunc { get; private set; }
        public Action<bool> AfterChangeStatusAction { get; private set; }

        public MEntityLabo SelectedRow => (_view.GetFocusedRow() as MEntityLabo) ?? _view.GetRow(_view.FocusedRowHandle) as MEntityLabo;

        public ToolTipController Tooltip { get; private set; }
        public GridColumn CurrentColumn { get; private set; }

        public void Init(Form owner, IContainer components, GridControl grid, GridView view, GridColumn column, Func<bool> checkAddNoteFunc, Func<bool> checkAutoSaveFunc, Action<bool> afterChangeStatusAction, bool needChangeMode = true)
        {
            _owner = owner;
            _grid = grid;
            _view = view;
            _column = column;
            Components = components;
            NeedChangeMode = needChangeMode;
            CheckAutoSaveFunc = checkAutoSaveFunc;
            CheckAddNoteFunc = checkAddNoteFunc;
            AfterChangeStatusAction = afterChangeStatusAction;
              _dbIoc = XIoc.GetService(CDb.IocKey);
            _guiIoc = XIoc.GetService(CGui.IocKey);

            _repositoryOrderItemStepMaterialStatus = _dbIoc.GetInstance<IRepositoryOrderItemStepLaboStatus>();
            _view.RowClick += new RowClickEventHandler(this._view_RowClick);
            this._view.RowCellStyle += new RowCellStyleEventHandler(this._view_RowCellStyle);
            LoadDataSources();

            SetContextMenus();
            ApplyTooltip();
        }

        private void LoadDataSources()
        {
            _allLaboStatus = _repositoryOrderItemStepMaterialStatus.All().ToList();
            _listActiveLaboStatus = _allLaboStatus.Where(x => x.IsActive && !x.IsDeleted).ToList();
            _helpStatusForm = InitHelpStatusForm();
        }

        private void SetContextMenus()
        {
            _mainGridMenu = new ContextMenuStrip();
            _mniChangeMode = _mainGridMenu.AddChangeSelectModeMenuItem(_view, _grid, _column);
            _showHistoriesItem = _owner.AddCustomerShowHistoryMenuItem(_mainGridMenu, GetHistoryAdapterModelFunc);
            StatusSeparator = new ToolStripSeparator();
            _mainGridMenu.Items.Add(StatusSeparator);
            _laboStatusItems = _mainGridMenu.AddMaterialStatusMenuItems(_view, GetStatusAdapterModelFunc, _owner, _listActiveLaboStatus, OnSetLaboStatus, OnGetLaboStatusNote, OnSetLaboStatusNote, CheckAddNoteFunc, CheckAutoSaveFunc);
            _mainGridMenu.Items.Add(new ToolStripSeparator());
            _showHelpStatusItem = _mainGridMenu.AddColorMenuItem(_view, _grid, _helpStatusForm);
            _grid.ContextMenuStrip = _mainGridMenu;

            if(NeedChangeMode) _view.ChangeMode(_grid, _column, _mniChangeMode);
        }

        private void OnSetLaboStatus(ILaboStatus c, MEntityFormatFontColor s)
        {
            if (!(c is ILaboStatus model) || s == null) return;
            model.StatusId = s.Id;
            model.StatusName = s.Caption;
            model.Action = EMgmtCase.Update;
            var autoSave = CheckAutoSaveFunc?.Invoke() ?? true;
            AfterChangeStatusAction?.Invoke(autoSave);
        }

        private string OnGetLaboStatusNote(ILaboStatus c)
        {
            return c.StatusNote;
        }

        private void OnSetLaboStatusNote(ILaboStatus c, string note)
        {
            var autoSave = CheckAutoSaveFunc?.Invoke() ?? true;
            c.StatusNote = note;
            if (_view.GetRow(_view.FocusedRowHandle) is MEntityLabo item)
            {
                item.StatusNote = note;
                if (!autoSave && (item.Action!= EMgmtCase.Insert && item.Action != EMgmtCase.Delete))
                {
                    item.Action = EMgmtCase.Update;
                }
                _view.RefreshData();

            }
            
            AfterChangeStatusAction?.Invoke(autoSave);
        }

        private MEntityDataAdapter GetStatusAdapterModelFunc()
        {
            var row = SelectedRow;
            if (row == null) return null;
            return new MEntityDataAdapter()
            {
                Id = row.Id,
                DisplayKey = row.TreatmentDisplayContent,
                FromModel = row
            };
        }

        private MEntityDataAdapter GetHistoryAdapterModelFunc()
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

        private Form InitHelpStatusForm()
        {
            var helpForm = _guiIoc.GetInstance<IDisplayHelpColorsForm>();
            
            var models = _listActiveLaboStatus;
            helpForm?.Apply("Bảng màu trạng thái đặt labo", models);

            var f = helpForm as Form;
            if (f != null) f.TopMost = true;
            return f;
        }

        private void ShowContextMenu()
        {
            var row = SelectedRow;
            var hasCustomer = !string.IsNullOrWhiteSpace(row?.Id);
            var isStatusColumn = CurrentColumn?.FieldName == nameof(MEntityLabo.StatusName);
            var isShowStatusItems = hasCustomer && isStatusColumn;
            _laboStatusItems?.CheckShowStatusFormatItems(isShowStatusItems, row?.StatusId);
            _showHistoriesItem.Visible = hasCustomer;
            StatusSeparator.Visible = isShowStatusItems;
            _mainGridMenu.DisplayAtCursor();
        }

        private void _view_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.HitInfo != null && e.HitInfo.InRowCell)
            {
                CurrentColumn = e.HitInfo.Column;
                if (CurrentColumn != null && (!CurrentColumn.OptionsColumn.AllowEdit || CurrentColumn.OptionsColumn.ReadOnly))
                {
                    if (e.Button == MouseButtons.Left) ShowContextMenu();
                }
                
            }
        }

        private bool IsInSelectedRows(int idx)
        {
            var indexes = _view.GetSelectedRows();
            if (indexes == null || indexes.Length == 0) return false;
            return indexes.Any(x => x == idx);
        }

        private void _view_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.RowHandle < 0) return;
            if (_allLaboStatus == null) _allLaboStatus = new List<MEntityOrderItemStepLaboStatus>();
            if (IsInSelectedRows(e.RowHandle) && e.Column == _view.FocusedColumn) return;
            if (_view.GetRow(e.RowHandle) is MEntityLabo item)
            {
                var statusId = item.StatusId;
                if (!string.IsNullOrWhiteSpace(statusId))
                {
                    var model = _allLaboStatus.FirstOrDefault(x => x.Id?.ToLower() == statusId?.ToLower());
                    if (model != null)
                    {
                        e.Appearance.ApplyStyle(model);
                        // return;
                    }
                }
            }
        }

        private void ApplyTooltip()
        {
            Tooltip = _grid.ApplyTooltipController<MEntityLabo>(new List<string>()
            {
                nameof(MEntityLabo.StatusName),
            }, (entity) =>
            {
                //var hasConsultDoctorUserName = !string.IsNullOrWhiteSpace(entity.ConsultantUserName);
                //var hasConsultDoctorFullName = !string.IsNullOrWhiteSpace(entity.ConsultantFullName);
                //var hasConsultAssistantUserName = !string.IsNullOrWhiteSpace(entity.ConsultingAssistantUserName);
                //var hasConsultAssistantFullName = !string.IsNullOrWhiteSpace(entity.ConsultingAssistantFullName);
                //var hasProductServiceTypeName = !string.IsNullOrWhiteSpace(entity.ProductServiceTypeName);
                //var hasProductServiceGroupName = !string.IsNullOrWhiteSpace(entity.ProductServiceGroupName);
                //var hasProductServiceGroupFinalName = !string.IsNullOrWhiteSpace(entity.ProductServiceGroupFinalName);
                //var rs = hasConsultDoctorUserName || hasConsultDoctorFullName || hasConsultAssistantUserName || hasConsultAssistantFullName;
                return true;
            }, (entity) =>
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Ghi chú: {entity.StatusNote}");
                return sb.ToString();
            }, Components);
        }

    }
}
