using DevExpress.XtraGrid.Columns;
using VegunSoft.Acc.Data.Enums;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Methods;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItems
    {
        public void ApplyReadOnly(params GridColumn[] ingoreColumns)
        {
            var isReadOnly = IsReadOnlyUserFields;
            IsEnableSave = CanSave;
            IsReadOnlyName = isReadOnly;
            IsReadOnlyDescription = isReadOnly;
            IsReadOnlyIsFolder = isReadOnly;
            IsReadOnlyFolder = false;
            IsReadOnlyIsTemporary = isReadOnly;
            IsReadOnlyToothId = isReadOnly;
            IsReadOnlyTooth = isReadOnly;
            IsReadOnlyOrderItemId = isReadOnly;
            IsReadOnlyPdsv = isReadOnly;
            IsReadOnlySendRating = isReadOnly;
            IsReadOnlyAssistant = isReadOnly;

            IsEnableIndicate = !isReadOnly;
            IsEnableSelectTeeth = !isReadOnly;
            IsEnableAddItems = !isReadOnly;

            IsEnableShowPdsv = !isReadOnly;
            IsEnablePrintOrder = !isReadOnly;
            //IsEnableProcess = !isReadOnly;

            IsEnableSendRating = false;
            //_viewOrderItems.OptionsBehavior.Editable = !isReadOnly;
            LockAllowEditColumns(isReadOnly, ingoreColumns);

            var isReadOnlyCreatedFields = IsReadOnlyCreatedFields;
            IsReadOnlyIsForOld = isReadOnlyCreatedFields;
            IsReadOnlyConsultDate = isReadOnlyCreatedFields;

            Settings?.OnEndReadOnlyAction?.Invoke(isReadOnly);

            ApplyReadOnlyFollower();

            IsEnableIsForOld = CanChangeTime;
        }

        public void ResetData()
        {
            StartNone();
            this.Order = new MEntityOrder();
            SelectedTeeth.Clear();
            EndChangeOrderItem();
        }

        private void LoadDefaultValues()
        {
            if (RepositorySession.CheckIsGroup(EUserAccountScope.BSĐT) || RepositorySession.CheckIsGroup(EUserAccountScope.BSTV))
            {
                _cbbSelectFollower.EditValue = RepositorySession.Username;
                _cbbSelectBSTV.EditValue = RepositorySession.Username;
            }

            if (RepositorySession.CheckIsGroup(EUserAccountScope.TLTV))
            {
                _cbbSelectTLTV.EditValue = RepositorySession.Username;
            }
        }

        private void AllowConsultEditors(bool isAllow)
        {
            _cbbSelectBSTV.Properties.ReadOnly = !isAllow;
            _cbbSelectTLTV.Properties.ReadOnly = !isAllow;
        }

        private void ApplyReadOnlyFollower()
        {
            if (!CanSave)
            {
                IsReadOnlyFollower = true;
                return;
            }
            var order = this.Order;
            var isSaved = order?.IsSaved ?? false;
            var canEdit = order == null || !isSaved || string.IsNullOrWhiteSpace(order.FollowersUserName) || string.IsNullOrWhiteSpace(_cbbSelectFollower.GetStringValue()) || RepositorySession.IsAdmin;
            IsReadOnlyFollower = !canEdit;
        }

        private void ApplyReadOnlyConsultEditors()
        {
            if (!CanSave)
            {
                _chkConsultDoctor.Properties.ReadOnly = true;
                _cbbSelectBSTV.Properties.ReadOnly = true;
                _chkConsultAssistant.Properties.ReadOnly = true;
                _cbbSelectTLTV.Properties.ReadOnly = true;
                if (_chkConsultDoctor.Properties.ReadOnly) _chkConsultDoctor.Checked = false;
                if (_chkConsultAssistant.Properties.ReadOnly) _chkConsultAssistant.Checked = false;
                return;
            }
            var order = this.Order;
            var isSaved = order?.IsSaved ?? false;
            var canEdit = order == null || !isSaved || string.IsNullOrWhiteSpace(order.ConsultantUserName) || string.IsNullOrWhiteSpace(_cbbSelectBSTV.GetStringValue()) || RepositorySession.IsAdmin;
            _chkConsultDoctor.Properties.ReadOnly = !canEdit;
            _cbbSelectBSTV.Properties.ReadOnly = false;
            if (_chkConsultDoctor.Properties.ReadOnly) _chkConsultDoctor.Checked = false;
     

             canEdit = order == null || !isSaved || string.IsNullOrWhiteSpace(order.ConsultingAssistantUserName) || string.IsNullOrWhiteSpace(_cbbSelectTLTV.GetStringValue()) || RepositorySession.IsAdmin;
            _chkConsultAssistant.Properties.ReadOnly = !canEdit;
            _cbbSelectTLTV.Properties.ReadOnly = false;
            if (_chkConsultAssistant.Properties.ReadOnly) _chkConsultAssistant.Checked = false;
        }
    }
}
