using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using VegunSoft.Acc.Entity.Acc;
using VegunSoft.Category.Repository.Categories;
using VegunSoft.Customer.Entity.Provider.Image;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Framework.Db.Enums.Data;
using VegunSoft.Layer.UcControl.Any.Provider.UserControls;
using VegunSoft.Layer.UcControl.Models;
using VegunSoft.Layer.UcService.Forms;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;
using VegunSoft.Order.Repository.Business;
using VegunSoft.Order.Repository.Business.Contract;
using VegunSoft.Subclinical.Repository.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemTracks : UcBaseOrder
    {     

        protected string OrderId { get; set; }

        protected string OrderItemId { get; set; }

        protected string OrderItemStepId { get; set; }       

        private IRepositoryOrder RepositoryOrder { get; set; }
      
        protected IRepositoryTooth RepositoryTooth { get; set; }

        private IRepositoryOrderItem RepositoryOrderItem { get; set; }

        //Repository = DbIoc.GetInstance<IRepositoryOrderItemStep>();

        private IRepositoryOrderItemStep _repositoryOrderItemStep;
        protected IRepositoryOrderItemStep RepositoryOrderItemStep => _repositoryOrderItemStep ?? (_repositoryOrderItemStep = DbIoc.GetInstance<IRepositoryOrderItemStep>());


        private IRepositoryCustomerImage _subclinicalServiceImage;

        protected IRepositoryCustomerImageFolder RepositoryCustomerImageFolder { get; private set; }

        protected IRepositoryCustomerPrescription RepositoryCustomerPrescription { get; private set; }

        //DataTable dtLichSuDieuTri_CT = new DataTable();
        protected List<MEntityOrder> Orders { get; private set; }

        private IBusinessAdapter _businessAdapter;

        protected IBusinessAdapter BusinessAdapter => _businessAdapter ?? (_businessAdapter = GuiIoc.GetInstance<IBusinessAdapter>());



        protected List<MEntityOrderItemStep> OrderItemSteps { get; private set; }
        //List<MEntityOrder> listBSDT_Hosodieutri = new List<MEntityOrder>();
        List<MEntityOrderPrescription> listBSDT_Toathuoc = new List<MEntityOrderPrescription>();
        List<MEntityCustomerImageFolder> list_CLS_ChidinhCLS = new List<MEntityCustomerImageFolder>();
       
       

        protected string CustomerFullName { get; private set; }

        protected string CustomerDisplayCode { get; private set; }

        private bool _isLoaded;
        private bool _isDataSourceLoading;
        private MEntityOrder _currentOrder;

        

        public bool IsInProcess { get; private set; }        

        public UcOrderItemTracks()
        {
            InitializeComponent();
        }

        public void OnLoad()
        {
            CheckAndInit();
        }

        public void ResetGridData()
        {
            _gridOrders.DataSource = null;
            _viewOrders.RefreshData();
        }

        private void CheckAndInit()
        {
            if (!_isLoaded)
            {
                InitFields();
                ConfigControls();
                SetOrderColumnsField();
                SetDetailColumnsField();
                SetProductServiceColumnsField();
                SetMasterColumnsField();
                ApplyEvents();
                BusinessAdapter.ApplyOrderStyle(_viewOrders);
                BusinessAdapter.ApplyOrderItemStyle(_vieOrderItems);
                BusinessAdapter.ApplyOrderItemProcessingStyle<MEntityOrderItemStep>(View);
                UcProductServiceSteps.Init(FormRoleName, () => SelectedDoctor, () => SelectedAssistant, StartAddHistory);
                SetContextMenus();
                _isLoaded = true;
            }
            CheckAndUpdateUI();
        }

        private void ApplyEvents()
        {
            this.VisibleChanged += OnVisibleChanged;
        }

        private void OnVisibleChanged(object sender, EventArgs e)
        {
            _tabControlProductServicesSteps.SelectedTab = _tabPageServivces;
            //if (!this.Visible)
            //{
            //    _btnSave.Enabled = false;
            //}
        }


        private void InitFields()
        {           
            
            RepositoryTooth = DbIoc.GetInstance<IRepositoryTooth>();
            RepositoryOrder = DbIoc.GetInstance<IRepositoryOrder>();
           
            RepositoryCustomerPrescription = DbIoc.GetInstance<IRepositoryCustomerPrescription>();
            RepositoryCustomerImageFolder = DbIoc.GetInstance<IRepositoryCustomerImageFolder>();
            _subclinicalServiceImage = DbIoc.GetInstance<IRepositoryCustomerImage>();
            RepositoryOrderItem = DbIoc.GetInstance<IRepositoryOrderItem>();
            
            this._viewOrders.FocusedRowChanged += this._viewOrders_FocusedRowChanged;

        }

      

       

        public static string Header { get; set; } = "Lịch sử điều trị";

        public void Init(MDoctorInputState state, bool isInProcess, MEntityCustomer customer, string orderId = "", string orderItemId = "", string orderItemHistoryId = "")
        {
            var id = customer?.Id;          
            var displayCode = customer?.DisplayCode;
            var fullName = customer?.FullName;
            Init(state, isInProcess, id, displayCode, fullName, orderId, orderItemId, orderItemHistoryId);
        }

        public void Init(MDoctorInputState state, bool isInProcess, string customerId, string customerDisplayCode, string customerFullName, string treatmentId = "", string treatmentServiceId = "", string treatmentHistoryId = "")
        {
           
            Cursor.Current = Cursors.WaitCursor;
            State = state;
            _chbIsShowAllHistoriesOfCustomers.Checked = false;
            CheckAndInit();
            IsInProcess = isInProcess;
            //this.Text = !string.IsNullOrWhiteSpace(customerFullName)? $"{Header}: {customerDisplayCode} - {customerFullName}": $"{Header}";
            XOrderId = null;
            _chbIsShowAllItems.Checked = false;
            XCustomerId = customerId;
            OrderId = treatmentId;
            OrderItemId = treatmentServiceId;
            OrderItemStepId = treatmentHistoryId;
            //_customerNo = customerNo;
            //_customerCode = customerCode;
            CustomerDisplayCode = customerDisplayCode;
            CustomerFullName = customerFullName;
            //_treatmentId = treatmentId;
            //_treatmentServiceId = treatmentServiceId;
            //_treatmentHistoryId = treatmentHistoryId;
            var form = this.FindForm();
            if (form != null) form.Text = $"Lịch sử điều trị của khách hàng: {CustomerDisplayCode} - {customerFullName}";
            Reload();


            Load_BSDT_Toathuoc(XCustomerId);
            Load_gridDanhSachCLS(XCustomerId);
            _chbIsShowAllItems.Checked = true;
            LoadGridOrders(XCustomerId);
            LoadOrderItemsHistories();
            _chbIsShowAllHistoriesOfCustomers.Checked = true;
            ApplyFocus();
            Cursor.Current = Cursors.Default;
            UpdateSaveButton();
            BeginCustomerDateTime = Now;
        }



        protected void Reload()
        {
            Orders = RepositoryOrder.GetOrders<MEntityOrder>(XCustomerId).Where(x => !x.IsDraft).ToList();
            OrderIds = Orders.Select(x => x.Id).ToList();
            OrderItems = RepositoryOrderItem.GetByOrderIds<MEntityOrderItemBusiness>(OrderIds).Where(x => !x.IsDraft).ToList();
            OrderItemIds = OrderItems.Select(x => x.Id).ToList();
            OrderItemSteps = RepositoryOrderItemStep.GetHistories<MEntityOrderItemStep>(OrderItemIds);
            UpdateButtonStatus();
        }

        private void Load_gridDanhSachCLS(string customerId)
        {
            list_CLS_ChidinhCLS = RepositoryCustomerImageFolder.Where(nameof(MEntityCustomerImageFolder.CustomerId), customerId).ToList();
        }

        private void Load_BSDT_Toathuoc(string customerId)
        {
            listBSDT_Toathuoc = RepositoryCustomerPrescription.Where(nameof(MEntityOrderPrescription.CustomerId), customerId).ToList();
        }

        private void _viewOrders_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (_isDataSourceLoading) return;
            if (e.FocusedRowHandle >= 0)
            {
                _chbIsShowAllHistoriesOfCustomers.Checked = false;
                LoadOrderItemsHistories();

            }
        }


        private void r_lnkXemCLS_Click(object sender, EventArgs e)
        {
            var idx = FocusedRowHandle;
            if (idx >= 0)
            {
                var designationId = View.GetRowCellValue(idx, nameof(MEntityOrderItemStep.SubclinicalId))?.ToString();
                BusinessAdapter.ShowImageForm(designationId);
            }
        }


     


        private void r_lnkInToaThuoc_Click(object sender, EventArgs e)
        {
            var idx = FocusedRowHandle;
            if (idx >= 0)
            {
                var id = View.GetRowCellValue(idx, nameof(MEntityOrderItemStep.PrescriptionId))?.ToString();
                BusinessAdapter?.ShowPrescriptionPrintView(id);
            }
        }


        private void LoadGridOrders(string customerId)
        {
            _isDataSourceLoading = true;
            var orders = RepositoryOrder.GetOrders<MEntityOrder>(customerId);
            _gridOrders.DataSource = null;
            _gridOrders.DataSource = orders;
            _viewOrders.RefreshData();
            _isDataSourceLoading = false;
        }

        private void _viewProductServices_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            OnSelectPdsv();

        }

        private void _lblShowOrders_CheckedChanged(object sender, EventArgs e)
        {
            _grbOrders.Visible = _lblShowOrders.Checked;
        }

      
        private void LoadAllHistories()
        {
            IsGroupByOrderItem = true;
            LoadOrderItemsSteps(null);
        }

        private void CheckAndEnableEditors(MEntityOrder plan, string oderItemId)
        {
            _btnSave.Enabled = plan != null && !string.IsNullOrWhiteSpace(oderItemId);
            _btnSaveExtraHistory.Enabled = plan != null && !string.IsNullOrWhiteSpace(oderItemId);
        }


        private void LoadOrderItemsHistories()
        {
            DataSource = null;
            var order = SelectedOrder;
            if (order != null)
            {
                LoadOrderItemsSteps(order);

                if (!_chbIsShowAllItems.Checked)
                {
                    LoadGridServices(XCustomerId, order.Id);
                }
                else
                {
                    XOrderId = order.Id;
                }

            }
            else if (!string.IsNullOrWhiteSpace(XCustomerId))
            {
                if (!_chbIsShowAllHistoriesOfCustomers.Checked)
                {
                    _chbIsShowAllHistoriesOfCustomers.Checked = true;
                }
                else
                {
                    LoadAllHistories();
                }
               
            }

        }



        private void _chbIsShowAllItems_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(XCustomerId))
            {
                var v = _chbIsShowAllItems.Checked;
                if (v)
                {
                    LoadGridServices(XCustomerId);
                }
                else if (!string.IsNullOrWhiteSpace(XOrderId))
                {
                    LoadGridServices(XCustomerId, XOrderId);
                }
                else
                {
                   
                }

            }


        }

        private void _gridProductServices_DoubleClick(object sender, EventArgs e)
        {
            var view = _vieOrderItems;
            var pt = view.GridControl.PointToClient(Control.MousePosition);
            var info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                StartOrderItem();
            }
        }

        
        // public Dictionary<MEntityOrderItem, List<MEntityOrderItemStep>> OrderItemStepsDict { get; set; }


        private void _btnSaveExtraHistory_Click(object sender, EventArgs e)
        {
            if (!AllowAdd)
            {
                Msg.ShowPreventAddError();
                return;
            }
            if (IsAnyReadOnly)
            {
                Msg.ShowReadOnlyError();
                return;
            }

           
            StartAddHistory(NewNextContent);
            ExtraContent = string.Empty;
        }

   
        private void ConfigControls()
        {
            ConfigDoctorControls();
            ConfigAssistantControls();
        }

       

        private void LnkXoa_Click(object sender, EventArgs e)
        {
            OnDelete(SelectedOrderItemStep);
        }

        protected bool IsAlwasyAllowEdit(GridView view, bool defaultVal)
        {
            var c = view.FocusedColumn;
            var v = view.FocusedValue;
            if (AllowEditIfNullTextColumns.Contains(c))
            {
                if (string.IsNullOrWhiteSpace(v?.ToString()))
                {
                    return true;
                }
                return defaultVal;
            }
            if (AllowEditIfNullCheckColumns.ContainsKey(c))
            {
                if (AllowEditIfNullCheckColumns[c].ToString().ToLower() == v?.ToString().ToLower())
                {
                    return true;
                }
                return defaultVal;
            }
            return defaultVal;
        }



    
        private void _btnTransfer_Click(object sender, EventArgs e)
        {
            StartTransferAction?.Invoke(StepNotes, new object[] { SelectedRow, SelectedOrder, XOrderItem });
        }

        private void _viewOrderItemProcessing_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {

            OnRowUpdated(e.RowHandle);
           
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            if (!AllowSave)
            {
                Msg.ShowReadOnlyError();
                return;
            }
            ShowLoading();
            var v = Save(XOrderItemId, DataSource);
            if(v) EndSave();
            CloseLoading();
        }

        protected void EndSave()
        {
            Reload();
            LoadOrderItemsSteps(_currentOrder, XOrderItemId);
            AfterSaveAction?.Invoke(_currentOrder);
            FocusEndRow();
        }

        protected List<MEntityOrderItemStep> DeleteSteps { get; set; } = new List<MEntityOrderItemStep>();
       

        private void _btnShowHideNotes_Click(object sender, EventArgs e)
        {
            ShowHideExtraNote(false);
        }

        private void _btnShowExtraNote_Click(object sender, EventArgs e)
        {
            ShowHideExtraNote(true);
        }

        private void ShowHideExtraNote(bool v)
        {
            //ShowRow(1, v, 150);
            splitContainer2.PanelVisibility = v? SplitPanelVisibility.Both: SplitPanelVisibility.Panel1;
            _btnShowHideNotes.Visible = v;
            _btnShowExtraNote.Visible = !v;

            //if (v)
            //{
            //    HideRow(0);
            //    ShowPercentRow(0);
            //}
        }

        private void ApplyShowHideLists()
        {
            splitContainer1.PanelVisibility = IsHideList ? SplitPanelVisibility.Panel2 : SplitPanelVisibility.Both;
        }

        private void ShowRow(int index, bool v, int height)
        {
            if (v)
            {
                _tlbBody.RowStyles[index].SizeType = SizeType.AutoSize;
                _tlbBody.RowStyles[index].Height = height;
            }
            else
            {
                _tlbBody.RowStyles[index].SizeType = SizeType.Absolute;
                _tlbBody.RowStyles[index].Height = 0;
            }
           
        }

        private void HideRow(int index)
        {
            _tlbBody.RowStyles[index].SizeType = SizeType.Absolute;
            _tlbBody.RowStyles[index].Height = 0;
        }

        private void ShowPercentRow(int index)
        {
            _tlbBody.RowStyles[index].SizeType = SizeType.Percent;
        }

        

        private void _chkReduce_CheckedChanged(object sender, EventArgs e)
        {
           
            ShowHideExtraNote(!IsReduce);
            _tblHistoryFunctions.Visible = !IsReduce;
        }

        private void _rChkIsFinishStep_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is CheckEdit chk)) return;
            OnFinishStepCheckedChanged(chk.Checked);
        }

        private void _repoSelectAssistant_EditValueChanged(object sender, EventArgs e)
        {
            if (sender is GridLookUpEdit glk)
            {
                OnSelectAssistant(glk.GetSelectedDataRow() as IEntityUserAccountMin);
            }
        }

        private void _gridOrderItemProcessing_Click(object sender, EventArgs e)
        {

        }

        private void _gridOrderItemProcessing_DataSourceChanged(object sender, EventArgs e)
        {
           // RefreshIndexes();
        }

        private void _repoSelectDoctor_EditValueChanged(object sender, EventArgs e)
        {
            if (sender is GridLookUpEdit glk)
            {
                OnSelectDoctor(glk.GetSelectedDataRow() as IEntityUserAccountMin);
            }
        }

        private void _cbbSelectAssistant_EditValueChanged(object sender, EventArgs e)
        {
            _chkIsMainProcess.Enabled = IsSelectedAssistant;
            if (!_chkIsMainProcess.Enabled) IsAssistantMainProcess = false;
        }

        private void _lnkBookLabo_Click(object sender, EventArgs e)
        {
            StartBookLabo();
        }

        private void _viewOrderItemSteps_RowCountChanged(object sender, EventArgs e)
        {
            UpdateSaveButton();
        }

        protected void UpdateSaveButton()
        {
            _btnSave.Enabled = NeedSave;
            UcProductServiceSteps.RefreshStatus();
        }

        private void _chbIsShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (_isDataSourceLoading) return;
            if (string.IsNullOrWhiteSpace(XCustomerId)) return;

            if (_chbIsShowAllHistoriesOfCustomers.Checked)
            {
                LoadAllHistories();
            }
            else
            {
                LoadOrderItemsSteps(_currentOrder, XOrderItemId);
            }

        }

        private void _chbIsShowAllHistoriesOfOrders_CheckedChanged(object sender, EventArgs e)
        {
            if (!IsLoadingHistories)
            {
                if (_chbIsShowAllHistoriesOfOrders.Checked)
                {
                    var oderItemId = XOrderItemId;
                    LoadOrderItemsSteps(_currentOrder, null);
                    XOrderItemId = oderItemId;
                    _chbIsShowAllHistoriesOfOrders.Enabled = true;
                }
                else
                {
                    LoadOrderItemsSteps(_currentOrder, XOrderItemId);
                }
            }
        }

        private void _btnCancelChanges_Click(object sender, EventArgs e)
        {
            if(!_btnSave.Enabled || Msg.IsAgree("Các thay đổi sẽ bị hủy, bạn có đồng ý không?"))
            {
                OnReloadList();
            }
        }

        private void _viewOrderItemSteps_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.HitInfo != null && e.HitInfo.InRowCell)
            {
                CurrentColumn = e.HitInfo.Column;
                
                if (e.Button == MouseButtons.Left && e.HitInfo.Column != _gcOrderItemStepCreatedDate && e.HitInfo.Column != _gcOrderItemStepDelete && e.HitInfo.Column != _gcOrderItemStepBookLabo) ShowContextMenu();
            }
        }

        private void _viewOrderItemSteps_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            OnRowUpdated(e.RowHandle);
        }


        private void _viewOrderItemSteps_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void _btnWidthRight_Click(object sender, EventArgs e)
        {
            this.splitContainer1.SplitterPosition += 50;
        }

        private void _btnWidthLeft_Click(object sender, EventArgs e)
        {
            if(this.splitContainer1.SplitterPosition > 50)
            {
                this.splitContainer1.SplitterPosition -= 50;
            }
           
        }

        private void _rChkIsPaidRose_CheckedChanged(object sender, EventArgs e)
        {
            OnIsPaidRoseCheckedChanged();
        }

        private void _rDateRosePaidDate_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            OnRosePaidDateEditValueChanging(e.NewValue as DateTime?);
        }

        private void _rChkIsMainAssistant_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is CheckEdit editor) OnIsMainAssistantCheckedChanged(editor.Checked);
        }

        private void _rChkIsMainDoctor_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckEdit editor) OnIsMainDoctorCheckedChanged(editor.Checked);
        }

        private void _rChkIsFinishStep_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue is bool v && v && !CanFinishStep()) e.Cancel = true;
        }

        private void _chkIsHideList_CheckedChanged(object sender, EventArgs e)
        {
            ApplyShowHideLists();
        }

        private void _chkIsMinColumn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAdvancedColumns();
        }

        private void _cbbSelectDoctor_EditValueChanged(object sender, EventArgs e)
        {
            ReloadRoses();
            UcProductServiceSteps?.ReloadCommissions();
            RefreshData(false, true, false, false);
        }

        private void _chkIsDoctor_CheckedChanged(object sender, EventArgs e)
        {
            ReloadDoctors();
        }

        private void _txtMultiRows_CheckedChanged(object sender, EventArgs e)
        {
            var isMulti = _txtMultiRows.Checked;
            _vieOrderItems.OptionsView.RowAutoHeight = isMulti;
            _ucProductServiceSteps.UpdateRowAutoHeight(isMulti);
        }



        private void _viewOrderItemProcessing_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //var vNgayHienTai = RepositoryOrderItemStep.GetDateTime();
            GridView view = sender as GridView;
            var row = view.GetRow(view.FocusedRowHandle) as MEntityOrderItemStep;

            if (row.IsApproved)
            {
                e.Cancel = true;
            }
            else
            {
                if (row.Action == EMgmtCase.Insert)
                {
                    e.Cancel = !CanAdd;
                }
                else
                if (row.Action == EMgmtCase.Update)
                {
                    e.Cancel = !CanEdit;
                }
                else
                if (row.Action == EMgmtCase.Delete)
                {
                    e.Cancel = !CanDelete;
                }
                else
                {
                    e.Cancel = !IsAlwasyAllowEdit(view, CanEdit);
                }
                if (!e.Cancel)
                {
                    if(view.FocusedColumn == _gcOrderItemStepContent)
                    {
                        if (row.IsOutOfConfigReExamination)
                        {

                        }
                    }
                }

            }
        }

        private void _view_HiddenEditor(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            if (view.FocusedColumn == _gcOrderItemStepNote || view.FocusedColumn == _gcOrderItemStepContent || view.FocusedColumn == _gcOrderItemStepDescription)
            {
                //AllowShowMemoEditor = false;
                //EditingStep = null;
                //LockApplyGridViewCellEditor = false;
                //view.RefreshRowCell(view.FocusedRowHandle, view.FocusedColumn);
            }
               
        }

        private void _viewOrderItemSteps_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            var view = sender as GridView;
            var rowHandle = e.RowHandle;
            if (rowHandle >= 0)
            {
                var row = view.GetRow(rowHandle) as MEntityOrderItemStep;
                ApplyGridViewCellEditor(view, row, e);
            }
        }

        private void _view_CustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e)
        {
            //var gv = sender as GridView;
            // var rowHandle = e.RowHandle;
            if (e.Column == _gcOrderItemStepNote)
            {
                e.RepositoryItem = _riNoteEx;
                return;
            }
            if (e.Column == _gcOrderItemStepContent)
            {
                e.RepositoryItem = _riTreatmentContentEx;
                return;
            }
            if (e.Column == _gcOrderItemStepDescription)
            {
                e.RepositoryItem = _riExplanationEx;
                return;
            }
        }

        private void _view_ShownEditor(object sender, EventArgs e)
        {
            var view = sender as GridView;
            var editor = view.ActiveEditor;
            if(editor is MemoExEdit me)
            {
                me.CloseUp -= OnCloseUpMemoExEdit;
                me.CloseUp += OnCloseUpMemoExEdit;
                
            }
        }

        private void OnCloseUpMemoExEdit(object sender, CloseUpEventArgs e)
        {
            var row = _view.GetRow(_view.FocusedRowHandle) as MEntityOrderItemStep;
            // _view.RefreshRowCell(_view.FocusedRowHandle, _view.FocusedColumn);
            _view.SetRowCellValue(_view.FocusedRowHandle, _view.FocusedColumn, e.Value);
            //_view.PostEditor();
            //_view.UpdateCurrentRow();
            _view.CloseEditor();
        }
    }
}
