using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using VegunSoft.Acc.Entity.Provider.Acc;
using VegunSoft.Framework.Db.Enums.Data;
using VegunSoft.Layer.UcControl.Customer.Orders;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;
using VegunSoft.Product.Entity.Provider.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemTracks
    {
        protected GridView View => _view;

        protected GridControl Grid => _grid;

        protected int FocusedRowHandle => View.FocusedRowHandle;

        public MEntityOrderItemStep SelectedOrderItemStep => View.GetRow(FocusedRowHandle) as MEntityOrderItemStep;

        protected bool HasDataSource => DataSource != null && DataSource.Count() > 0;

        protected List<MEntityOrderItemStep> DataSource
        {
            get => Grid.DataSource as List<MEntityOrderItemStep>;
            set
            {
                //if (value != null) ShowLoading();
                Grid.DataSource = value;
                RefreshData();
                //if (value != null) CloseLoading();
            }
        }

        protected string StepNotes
        {
            get
            {
                return GetCustomerNotes(XCustomerId);
            }
        }

        public string GetCustomerNotes(string customerId)
        {
            var stepId = State?.Step?.Id;
            var startDate = BeginCustomerDateTime;
            var endate = Now;
            var isCompareDateOnly = !string.IsNullOrWhiteSpace(stepId);
            if (!isCompareDateOnly) startDate = startDate.AddHours(-1);
             var steps = RepositoryOrderItemStep.FindHistories<MEntityOrderItemStepMin>(stepId, startDate, endate, customerId, isCompareDateOnly);
            if (steps != null && steps.Any())
            {
                var notes = steps.Where(x => !string.IsNullOrWhiteSpace(x.Description)).OrderBy(x => x.CreatedDate).Select(x => $"{x.Description}").Distinct().ToList();
                if (notes.Any())
                {
                    var txt = string.Join(". ", notes);
                    return txt;
                }
            }
            return string.Empty;
        }


        protected bool HasNextContent
        {
            get 
            {
                if (HasDataSource)
                {
                    var ds = DataSource;
                    return DataSource.Any(x => x.IsNextContent);
                }
                return false;
            }
        }


        #region Column Visible

        protected bool IsShowNextContentColumn
        {
            get => _gcOrderItemStepIsNextContent.Visible;
            set => _gcOrderItemStepIsNextContent.Visible = value;
        } 
        #endregion

        #region Value

        protected string ExtraContent
        {
            get => _txtExtraContent.Text;
            set => _txtExtraContent.Text = value;
        }

        protected bool IsCheckedIsForOld
        {
            get => _chkIsForOld.Checked;
            set => _chkIsForOld.Checked = value;
        }

        protected bool IsNextContent
        {
            get => _chbIsNextContent.Checked;
            set => _chbIsNextContent.Checked = value;
        }

        protected bool IsNoTreatment
        {
            get { return _chkIsNoTreatment.Checked; }
            set { _chkIsNoTreatment.Checked = value; }
        }

        protected bool IsDoctor
        {
            get { return _chkIsDoctor.Checked; }
            set { _chkIsDoctor.Checked = value; }
        }

        protected bool IsSelectedAssistant => !string.IsNullOrWhiteSpace(_cbbSelectAssistant.EditValue?.ToString());

        protected MEntityUserAccountMin SelectedAssistant => _cbbSelectAssistant.SelectedUserAccount;

        protected bool IsSelectedDoctor => !string.IsNullOrWhiteSpace(_cbbSelectDoctor.EditValue?.ToString());

        protected MEntityUserAccountMin SelectedDoctor => _cbbSelectDoctor.SelectedUserAccount;

        protected List<MEntityOrderItem> DsOrderItems => _gridOrderItems.DataSource as List<MEntityOrderItem>;

        protected MEntityOrderItemStep NewNextContent
        {
            get
            {
                var step = new MEntityOrderItemStep
                {                    
                    DisplayPriority = 0,
                    RawStepName = "Tái khám",
                    IsFinishProcess = false,                   
                    StepDescription = ExtraContent,
                    IsOutOfConfigReExamination = true,                   
                };
                return step;
            }
        }
        #endregion

        #region AllowEdit

        protected bool AllowEditCreatedDate
        {
            get => _gcOrderItemStepCreatedDate.OptionsColumn.AllowEdit;
            set => _gcOrderItemStepCreatedDate.OptionsColumn.AllowEdit = value;
        } 
        #endregion

        #region Enable

        protected bool IsEnableIsForOld
        {
            get => _chkIsForOld.Enabled;
            set => _chkIsForOld.Enabled = value;
        }
        //_gcOrderItemStepCreatedDate
        #endregion

        #region ReadOnly

        protected bool IsReadOnlyIsDoctor
        {
            get => _chkIsDoctor.Properties.ReadOnly;
            set => _chkIsDoctor.Properties.ReadOnly = value;
        }

        protected bool IsReadOnlySelectDoctor
        {
            get => _cbbSelectDoctor.Properties.ReadOnly;
            set => _cbbSelectDoctor.Properties.ReadOnly = value;
        }

        protected bool IsReadOnlyIsForOld
        {
            get => _chkIsForOld.Properties.ReadOnly;
            set => _chkIsForOld.Properties.ReadOnly = value;
        }

        #endregion

        protected bool CanChangeTime => CheckRightsService?.CheckCanChangeWorkingDateTime(SessionCode, FormName) ?? false;


       


        protected List<MEntityPdsvStep> StepConfigs => UcProductServiceSteps?.DataSource;



        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Func<string, object[], bool> StartTransferAction { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Action<MEntityOrder> AfterSaveAction { get; set; }

        public bool IsReduce
        {
            get => _chkReduce.Checked;
            set { _chkReduce.Checked = value; }
        }

        public bool IsHideList
        {
            get => _chkIsHideList.Checked;
            set { _chkIsHideList.Checked = value; }
        }

        public bool IsMinColumn
        {
            get => _chkIsMinColumn.Checked;
            set { _chkIsMinColumn.Checked = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsAssistantMainProcess
        {
            get => _chkIsMainProcess.Checked && _chkIsMainProcess.Enabled;
            set
            {
                _chkIsMainProcess.Checked = value;
            }
        }

        private bool _canAddTreamentHistory;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool CanAddTreamentHistory
        {
            get => _canAddTreamentHistory;
            set
            {
                _canAddTreamentHistory = value;
                CheckAndUpdateUI();
            }
        }


        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsEnableNoTreatment
        {
            get { return _chkIsNoTreatment.Enabled; }
            set { _chkIsNoTreatment.Enabled = value; }
        }


        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsGroupByOrder
        {
            get { return _chkIsGroupByOrder.Checked; }
            set { _chkIsGroupByOrder.Checked = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsGroupByOrderItem
        {
            get { return _chkIsGroupByOrderItem.Checked; }
            set { _chkIsGroupByOrderItem.Checked = value; }
        }

        public MEntityOrderItemStep SelectedRow => (View.GetFocusedRow() as MEntityOrderItemStep) ?? View.GetRow(View.FocusedRowHandle) as MEntityOrderItemStep;

        public MEntityOrderItemStep EditingRow => View.GetRow(View.FocusedRowHandle) as MEntityOrderItemStep;

      
        private bool HasSelectedRow => SelectedRow != null;

        protected bool HasSelectedRowOrEmpty => HasSelectedRow || !HasDataSource;

        protected DateTime Now => RepositoryOrderItemStep.GetDateTime();

        protected IUcProductServiceSteps UcProductServiceSteps => _ucProductServiceSteps;

        protected MEntityOrder SelectedOrder => _viewOrders.GetRow(_viewOrders.FocusedRowHandle) as MEntityOrder;

        protected int XOrderItemIndex => _vieOrderItems.FocusedRowHandle;

        public MEntityOrderItem XOrderItem => _vieOrderItems.GetRow(XOrderItemIndex) as MEntityOrderItem;

        protected string XCustomerId { get; set; }

        private string XOrderId { get; set; }

        protected string XOrderItemId { get; set; }

        protected string XBranchId => RepositorySession?.BranchId;

        protected bool NeedSave
        {
            get
            {
                var steps = DataSource;
                return steps != null && steps.Any(step => step.Action == EMgmtCase.Insert || step.Action == EMgmtCase.Update || step.Action == EMgmtCase.Delete) || (DeleteSteps != null && DeleteSteps.Count > 0);
            }
        }


    }
}
