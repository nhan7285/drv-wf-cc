using System;
using System.Collections.Generic;
using System.Linq;
using VegunSoft.Acc.Entity.Acc;
using VegunSoft.App.Data.Business;
using VegunSoft.Base.View.Dev.UserControls;
using VegunSoft.Framework.Methods;
using VegunSoft.Layer.UcControl.Customer.Orders;
using VegunSoft.Layer.UcService.Provider.Methods;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;
using VegunSoft.Product.Entity.Provider.Business;
using VegunSoft.Product.Repository.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemSteps : UcBase, IUcProductServiceSteps
    {
   
        protected bool IsLoaded { get; set; }

        protected bool IsReadOnly { get; set; }

        //protected override string RightsCode { get; set; }

        protected IRepositoryPdsvStep SvcConfigs { get; set; }
        public Func<List<MEntityOrderItemStep>> GetOrderItemStepsFunc { get; private set; }
        public MEntityOrderItem OrderItem { get; private set; }

        public UcOrderItemSteps()
        {
            InitializeComponent();
        }

        public IUcProductServiceSteps Init(string rightsCode, Func<IEntityUserAccountMin> getDoctorFunc, Func<IEntityUserAccountMin> getAssistantFunc, Action<MEntityOrderItemStep> addAction)
        {
            RightsCode = rightsCode;
            GetDoctorFunc = getDoctorFunc;
            GetAssistantFunc = getAssistantFunc;
            AddAction = addAction;
            if (!IsLoaded)
            {
                InitFields();
                ConfigConfigColumn();
                _view.ApplyPdsvStepStyle();
                IsLoaded = true;
            }

            var allowSaveHistory = CheckRightsService.CheckCanApprove(SessionCode, EFormMgmt.FMainTreatmentServiceHistories.GetFinalName());
            var allowSaveMain = CheckRightsService.CheckCanApprove(SessionCode, RightsCode);
            var allowSave = allowSaveMain || allowSaveHistory;
            _gcIsLock.Visible = allowSave;
            _pnSave.Visible = allowSave;
            return this;
        }

        private void InitFields()
        {           
            SvcConfigs = DbIoc.GetInstance<IRepositoryPdsvStep>();
        }

       

        private void ConfigConfigColumn()
        {
            _gcConfigName.FieldName = nameof(MEntityPdsvStep.DisplayName);
            _gcConfigIsEnd.FieldName = nameof(MEntityPdsvStep.IsFinishProcess);
            _gcConfigNo.FieldName = nameof(MEntityPdsvStep.SequenceNumber);
            _gcIsLock.FieldName = nameof(MEntityPdsvStep.IsLock);
        }

        public IUcProductServiceSteps LoadData(Func<List<MEntityOrderItemStep>> getOrderItemStepsFunc, MEntityOrderItem orderItem, bool isReadOnly)
        {
            var productServiceId = orderItem.ProductServiceId;
            var steps = SvcConfigs.GetSteps(productServiceId);
            GetOrderItemStepsFunc = getOrderItemStepsFunc;
            OrderItem = orderItem;
            ApplyStatus(orderItem, getOrderItemStepsFunc, steps);

            IsReadOnly = isReadOnly;
            ApplyLockInfo(OrderItem, steps);
            _grid.DataSource = null;
            _grid.DataSource = steps;
            _view.RefreshData();
            _view.OptionsBehavior.Editable = !orderItem.IsApproved;
            ApplyCommissions(orderItem, steps);
            return this;
        }

        


       
        private void lnkThemDT_Click(object sender, EventArgs e)
        {
            OnAddStep(false);
        }

        private void _lnkAddFinishContent_Click(object sender, EventArgs e)
        {
            OnAddStep(true);
        }

        public IUcProductServiceSteps RefreshStatus()
        {
            ApplyStatus(OrderItem, GetOrderItemStepsFunc, _grid.DataSource as List<MEntityPdsvStep>);
            _view.RefreshData();
            return this;
        }

        public IUcProductServiceSteps ApplyStatus(MEntityOrderItem orderItem, Func<List<MEntityOrderItemStep>> getOrderItemStepsFunc, List<MEntityPdsvStep> steps)
        {
            var orderItemSteps = getOrderItemStepsFunc?.Invoke();
            if (orderItem!=null && steps != null && steps.Count > 0 && orderItemSteps!=null && orderItemSteps.Count > 0)
            {
                var oiId = orderItem.Id;
                var oiSteps = orderItemSteps.Where(x => x.OrderItemId == oiId).ToList();
                steps.ForEach(s =>
                {
                    s.TotalInProgessSteps = oiSteps.Count(x => x.PdsvStepId == s.Id && !x.IsFinishStage);
                    s.TotalFinishSteps = oiSteps.Count(x => x.PdsvStepId == s.Id && x.IsFinishStage);
                });
            }
            return this;
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            SaveCurrentOrderItem();        
        }

        private void _ricLock_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            var config = (MEntityPdsvStep)_view.GetRow(_view.FocusedRowHandle);
            if (config != null)
            {
                config.IsLock = Convert.ToBoolean(e.NewValue);
            }
        }
    }
}
