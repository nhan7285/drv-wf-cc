using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums.Image;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Methods;
using VegunSoft.Framework.Gui.Provider.WindowsForms.Methods;
using VegunSoft.Framework.Gui.Services;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Layer.UcService.Provider.Methods;
using VegunSoft.Layer.UcService.Provider.Models;
using VegunSoft.Order.Entity.Business.EntityOrder;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcTreatmentTurns : System.Windows.Forms.UserControl
    {
        private bool _isLoaded;
        private IIocService _dbIoc;
        private IIocService _guiIoc;
        private IIconService _iconService;
        protected MUcTreatmentTurns Settings { get; private set; }
        protected bool IsDataSourceLoading { get; private set; }
        protected List<MEntityOrder> DataSource { get; private set; }

        public UcTreatmentTurns()
        {
            InitializeComponent(); 
        }

        #region Public Methods

        public void CheckAndInit(MUcTreatmentTurns settings)
        {
            if (!_isLoaded)
            {
                Settings = settings;
                InitFields();
                SetIcons();
                ConfigOrderColumns();
                ConfigGridView();
                //CreateContextMenu();
                _isLoaded = true;
            }

            ShowColumns();
        }


        public void Reset()
        {
            _grid.DataSource = null;
        }

        private List<MEntityOrder> GetFinalDataSource()
        {
            var ds = DataSource;
            if (ds != null)
            {
                if (!_chkIsFolder.Checked) ds = ds.Where(x => !x.IsFolder).ToList();
                if (!_chkIsOrder.Checked) ds = ds.Where(x => x.IsFolder).ToList();
            }
            return ds;
        }

        public List<MEntityOrder> LoadDataSource(List<MEntityOrder> dataSource, bool isBackup)
        {
            DataSource = dataSource;
            if (isBackup)
            {
                FullDataSource = DataSource;
            }
            else
            {
                FilteredDataSource = DataSource;
            }
            RefreshDataSource();
            ShowColumns();
            return DataSource;
        }

        public List<MEntityOrder> FullDataSource { get; set; }
        public List<MEntityOrder> FilteredDataSource { get; set; }


        public void RefreshDataSource()
        {
            IsDataSourceLoading = true;
            _grid.DataSource = null;
            _grid.DataSource = GetFinalDataSource();
            _view.RefreshData();
            IsDataSourceLoading = false;
        }

        public void Select(string orderId)
        {
            _view.FocusedRowHandle = _view.LocateByValue(nameof(MEntityOrder.Id), orderId);
        }

        public MEntityOrder SelectedEntity
        {
            get
            {
                var model = _view.GetFocusedRow() as MEntityOrder;
                return model;
            }
        }

        #endregion

        private void InitFields()
        {
            _dbIoc = XIoc.GetService(CDb.IocKey);
            _guiIoc = XIoc.GetService(CGui.IocKey);           
            _iconService = _guiIoc.GetInstance<IIconService>();
       
            AllowContextGridColumns = new List<string>()
            {
                nameof(MEntityOrder.Id),
                nameof(MEntityOrder.ConsultingDate),
                nameof(MEntityOrder.Name),
                nameof(MEntityOrder.Description),
                nameof(MEntityOrder.FolderName),
            };
        }

        private void SetIcons()
        {
            //this._lnkTurnsEdit.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Treatment16);
            //this._lnkTurnsDelete.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Delete16);
        }

       
        private void ConfigGridView()
        {
            _view.ApplyOrderStyle();
            //_view.FocusedRowChanged += ViewTreatmentOrdersOnFocusedRowChanged; 
            _lnkTurnsEdit.Click+=LnkTurnsEditOnClick;
        }

        private void LnkTurnsEditOnClick(object sender, EventArgs e)
        {
            Settings?.MainClickEditAction?.Invoke(this, e, SelectedEntity);
        }

       

        public void FocusOrder(string orderId)
        {
            var idx = _view.LocateByValue(nameof(IEntityOrderBusiness.Id), orderId);
            _view.FocusRow(idx);
        }

       

        private void _chkIsFolder_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDataSource();
        }

        private void _chkIsOrder_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDataSource();
        }

        private void CreateContextMenu()
        {
            if (Settings==null || !Settings.AllowConsult) return;
            _contextMenu = new ContextMenuStrip();
            _mniConsult = _contextMenu.Items.Add("Tư vấn");
            _mniConsult.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Came16);
            _mniConsult.Click += OnMniConsultClick;
            _mniConsult.Visible = false;
        }

        private void OnMniConsultClick(object sender, EventArgs e)
        {
           
        }

        private ContextMenuStrip _contextMenu;
        private ToolStripItem _mniConsult;
        protected List<string> AllowContextGridColumns { get; private set; }
        public bool IsPreventCheckAllEvent { get; private set; }

        private void _view_RowClick(object sender, RowClickEventArgs e)
        {
            if (Settings == null || !Settings.AllowConsult || AllowContextGridColumns==null) return;
            if (SelectedEntity != null)
            {
                if (e.Button == MouseButtons.Left && AllowContextGridColumns.Contains(e.HitInfo?.Column?.FieldName))
                {
                    ShowContextMenu();
                }
            }
        }

        private void ShowContextMenu()
        {
            _contextMenu.DisplayAtCursor();
        }

        private void _chkIsAll_CheckedChanged(object sender, EventArgs e)
        {
            if (IsPreventCheckAllEvent) return;
            if (_chkIsAll.Checked) 
            {
                LoadDataSource(FullDataSource, true);
            }
            else
            {
                LoadDataSource(FilteredDataSource, false);
            }
           
        }

        private void _lnkTreatment_Click(object sender, EventArgs e)
        {
            Settings?.TreatAction?.Invoke(this, e, SelectedEntity);
        }

        private void _view_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (IsDataSourceLoading) return;


            if (_view.FocusedColumn == _gcOrderEdit)
            {
                Settings?.MainClickEditAction?.Invoke(this, e, SelectedEntity);
                return;
            }
            Settings?.FocusedRowChangedAction?.Invoke(this, e, SelectedEntity);
            Settings?.SelectedOrderChanged?.Invoke(SelectedEntity);
        }

      
        public void CheckAll(bool v, bool isPreventCheckAllEvent)
        {
            IsPreventCheckAllEvent = isPreventCheckAllEvent;
            _chkIsAll.Checked = v;
            IsPreventCheckAllEvent = false;
        }

        private void _view_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {

        }

        public void HideFooter()
        {
            _panelFooter.Visible = false;
        }
    }
}
