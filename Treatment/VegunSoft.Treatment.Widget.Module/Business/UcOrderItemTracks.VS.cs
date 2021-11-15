using VegunSoft.Acc.Data.Enums;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Methods;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemTracks
    {
        private void RefreshData(bool isRefreshIndexes = true, bool isFormatHasRosesSteps = true, bool isUpdateSaveButton = true, bool isFocusEndRow = false)
        {
            //ShowLoading();
            if(isRefreshIndexes) RefreshIndexes();
            if(isFormatHasRosesSteps) FormatHasRosesSteps();
            View.RefreshData();
            if (isFocusEndRow) FocusEndRow();
            if (isUpdateSaveButton) UpdateSaveButton();
            IsShowNextContentColumn = HasNextContent;
            //CloseLoading();
        }

        private void RefreshIndexes()
        {
            var ds = DataSource;
            if (ds != null)
            {
                var idx = 0;
                foreach (var h in ds)
                {
                    idx++;
                    h.LocalDisplayPriority = idx;
                }
                //View.RefreshData();
            }

        }


        private void FocusEndRow()
        {
            View.FocusEndRow<MEntityOrderItemStep>();
        }

        private void ApplyDoctorValues(MEntityOrderItemStep step)
        {
            if (IsSelectedDoctor)
            {
                var doctor = SelectedDoctor;
                step.DoctorUsername = doctor.Username;
                step.DoctorFullName = doctor.FullName;

            } else if (RepositorySession.CheckIsGroup(EUserAccountScope.BSĐT))
            {
                step.DoctorUsername = RepositorySession.Username;
                step.DoctorFullName = RepositorySession.UserFullName;
            }
        }

        private void ApplyAssistantValues(MEntityOrderItemStep step)
        {
            if (IsSelectedAssistant)
            {
                var assistant = SelectedAssistant;
                step.AssistantUsername = assistant.Username;
                step.AssistantFullName = assistant.FullName;
            }
            else if (RepositorySession.CheckIsGroup(EUserAccountScope.Assistant))
            {
                step.AssistantUsername = RepositorySession.Username;
                step.AssistantFullName = RepositorySession.UserFullName;
            }
        }

        protected void CheckAndUpdateUI()
        {
            var v = CanAddTreamentHistory;
            IsNoTreatment = !v;
            IsEnableNoTreatment = v;
            IsEnableIsForOld = v && CanChangeTime;
            UpdateColumnsStatus();
            UpdateAddingColumnsStatus();

            AllowEditCreatedDate =  v && CanChangeTime;

            IsReadOnlySelectDoctor = !CanApprove;
            IsReadOnlyIsDoctor = !CanApprove;
        }

        private void ConfigDoctorControls()
        {
            _cbbSelectDoctor.IsAutoLoadData = false;
            _cbbSelectDoctor.Scope = EUserAccountScope.BSĐT;          

            _repoSelectDoctor.IsAutoLoadData = false;
            _repoSelectDoctor.Scope = EUserAccountScope.BSĐT;
            var ds = _repoSelectDoctor.ReloadData();

            _cbbSelectDoctor.ReloadData(ds);
            _cbbSelectDoctor.EditValue = RepositorySession.Username;
        }

        private void ReloadDoctors()
        {
            _cbbSelectDoctor.Scope = IsDoctor ? EUserAccountScope.BSĐT : EUserAccountScope.ActiveUsingAll;
            _cbbSelectDoctor.ReloadData();
        }


        private void ConfigAssistantControls()
        {
            _cbbSelectAssistant.IsAutoLoadData = false;
            _cbbSelectAssistant.Scope = EUserAccountScope.Assistant;

            _repoSelectAssistant.IsAutoLoadData = false;
            _repoSelectAssistant.Scope = EUserAccountScope.Assistant;

            var ds = _cbbSelectAssistant.Config.GetDataSourceFunc.Invoke();
            _cbbSelectAssistant.ReloadData(ds);
            _repoSelectAssistant.DataSource = ds;
        }

        private void ConfigValues()
        {
            _cbbSelectDoctor.EditValue = RepositorySession.CheckIsGroup(EUserAccountScope.BSĐT) ? RepositorySession.Username: null;
        }


        private void LoadGridServices(string customerId, string orderId = null)
        {
            _isDataSourceLoading = true;
            var orderItems = string.IsNullOrWhiteSpace(orderId) ? RepositoryOrderItem.GetOrderItems<MEntityOrderItem>(customerId) : RepositoryOrderItem.GetOrderRows(orderId);

            if (!string.IsNullOrWhiteSpace(orderId)) XOrderId = orderId;
            _gridOrderItems.DataSource = null;
            _gridOrderItems.DataSource = orderItems;
            _vieOrderItems.RefreshData();
            _isDataSourceLoading = false;
            ConfigValues();
            ReloadRoses();
        }

        public void ApplyTargetDoctor(string targetDoctor)
        {
            if(!string.IsNullOrWhiteSpace(targetDoctor))  _cbbSelectDoctor.EditValue = targetDoctor;
        }

        private void UpdateButtonStatus()
        {
            _btnTransfer.Enabled = (StartTransferAction != null);
        }

    }
}
