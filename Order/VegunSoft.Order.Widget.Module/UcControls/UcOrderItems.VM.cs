using System;
using System.Collections.Generic;
using System.Linq;
using VegunSoft.Acc.Data.Enums;
using VegunSoft.Category.Entity.Provider.Category;
using VegunSoft.Category.Entity.Provider.Category.Body;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Methods;
using VegunSoft.Layer.EValue.Basic;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItems
    {

        #region Value

        protected bool IsCheckedIsForOld
        {
            get => _chkIsForOld.Checked;
            set => _chkIsForOld.Checked = value;
        }

        protected bool IsFocusConsultDate
        {
            set { if (value) _txtConsultDate.Focus(); }
        }

        protected DateTime OrderConsultDate
        {
            get => _txtConsultDate.DateTime;
            set => _txtConsultDate.DateTime = value;
        }

        protected string OrderConsultDateText
        {
            get => _txtConsultDate.Text;
            set => _txtConsultDate.Text = value;
        }

        protected bool IsCheckedConsultDoctor
        {
            get => _chkConsultDoctor.Checked;
            set => _chkConsultDoctor.Checked = value;
        }

        protected bool IsCheckedConsultAssistant
        {
            get => _chkConsultAssistant.Checked;
            set => _chkConsultAssistant.Checked = value;
        }
        #endregion

        #region Enable

        protected bool IsEnableSave
        {
            get => _btnSave.Enabled;
            set => _btnSave.Enabled = value;
        }

        protected bool IsEnableIndicate
        {
            get => btnChiDinhCLS.Enabled;
            set => btnChiDinhCLS.Enabled = value;
        }

        protected bool IsEnableSelectTeeth
        {
            get => _btnSelectTeeth.Enabled;
            set => _btnSelectTeeth.Enabled = value;
        }

        protected bool IsEnableAddItems
        {
            get => _btnAddProductServiceToOrder.Enabled;
            set => _btnAddProductServiceToOrder.Enabled = value;
        }

        protected bool IsEnableShowPdsv
        {
            get => _btnShowPdsv.Enabled;
            set => _btnShowPdsv.Enabled = value;
        }

        protected bool IsEnablePrintOrder
        {
            get => btnInHoSo.Enabled;
            set => btnInHoSo.Enabled = value;
        }       

        protected bool IsEnableSendRating
        {
            get => _cbbSendRating.Enabled;
            set => _cbbSendRating.Enabled = value;
        }

        protected bool IsEnableIsForOld
        {
            get => _chkIsForOld.Enabled;
            set => _chkIsForOld.Enabled = value;
        }

        #endregion

        #region ReadOnly

        protected bool IsReadOnlyName
        {
            get => _txtName.Properties.ReadOnly;
            set => _txtName.Properties.ReadOnly = value;
        }

        protected bool IsReadOnlyDescription
        {
            get => _txtDescription.Properties.ReadOnly;
            set => _txtDescription.Properties.ReadOnly = value;
        }

        protected bool IsReadOnlyIsFolder
        {
            get => _chkIsFolder.Properties.ReadOnly;
            set => _chkIsFolder.Properties.ReadOnly = value;
        }

        protected bool IsReadOnlyFolder
        {
            get => _glkFolder.Properties.ReadOnly;
            set => _glkFolder.Properties.ReadOnly = value;
        }

        protected bool IsReadOnlyIsTemporary
        {
            get => _cheIsTemporary.Properties.ReadOnly;
            set => _cheIsTemporary.Properties.ReadOnly = value;
        }

        protected bool IsReadOnlyIsForOld
        {
            get => _chkIsForOld.Properties.ReadOnly;
            set => _chkIsForOld.Properties.ReadOnly = value;
        }

        protected bool IsReadOnlyConsultDate
        {
            get => _txtConsultDate.Properties.ReadOnly;
            set => _txtConsultDate.Properties.ReadOnly = value;
        }

        protected bool IsReadOnlyToothId
        {
            get => txtIdRang.Properties.ReadOnly;
            set => txtIdRang.Properties.ReadOnly = value;
        }

        protected bool IsReadOnlyTooth
        {
            get => _glkTooth.Properties.ReadOnly;
            set => _glkTooth.Properties.ReadOnly = value;
        }

        protected bool IsReadOnlyOrderItemId
        {
            get => _txtOrderItemId.Properties.ReadOnly;
            set => _txtOrderItemId.Properties.ReadOnly = value;
        }

        protected bool IsReadOnlyPdsv
        {
            get => _cbbProductService.Properties.ReadOnly;
            set => _cbbProductService.Properties.ReadOnly = value;
        }

        protected bool IsReadOnlySendRating
        {
            get => _cbbSendRating.Properties.ReadOnly;
            set => _cbbSendRating.Properties.ReadOnly = value;
        }

        protected bool IsReadOnlyAssistant
        {
            get => _cbbSelectAssistant.Properties.ReadOnly;
            set => _cbbSelectAssistant.Properties.ReadOnly = value;
        }

        protected bool IsReadOnlyFollower
        {
            get => _cbbSelectFollower.Properties.ReadOnly;
            set => _cbbSelectFollower.Properties.ReadOnly = value;
        }

        #endregion

        #region Visible

        protected bool IsVisibleIsForOld
        {
            get => _chkIsForOld.Visible;
            set => _chkIsForOld.Visible = value;
        }

        #endregion

       
        #region Settings

        protected bool CanChangeTime => CheckRightsService?.CheckCanChangeWorkingDateTime(SessionCode, Settings?.FormName) ?? false;

        protected bool CanSave => InputCase == EInputCase.Adding || InputCase == EInputCase.Editing;

        protected DateTime Now => RepositoryOrder.GetDateTime();

        #endregion

        #region UI Status

        protected bool IsReadOnlyUserFields => InputCase == EInputCase.None;

        protected bool IsReadOnlyCreatedFields => IsReadOnlyUserFields || (InputCase == EInputCase.Editing && !CanChangeTime);

        protected bool CanSaveOrderItems(DateTime now)
        {
            foreach (var orderItem in ActiveOrderItems)
            {
                if (orderItem.IsForOld && orderItem.CreatedDate != null && orderItem.CreatedDate.Value.Date == now.Date)
                {
                    Msg.ShowError($"Bạn đang nhập dịch vụ cũ, vui lòng chọn ngày tư vấn cũ hơn!");
                    _viewOrderItems.FocusRow<MEntityOrderItem>(orderItem.Id, (x) => x.Id);
                    return false;
                }
            }
            return true;
        }

        private EInputCase _inputCase;
        public EInputCase InputCase
        {
            get => _inputCase;
            set
            {
                _inputCase = value;
                ApplyReadOnly();
            }
        } 
        #endregion

        protected List<MEntityTooth> SelectedTeeth { get; set; } = new List<MEntityTooth>();
        public List<MEntityTooth> WorkingTeeth => SelectedTeeth;

        protected bool HasManyTeeth => SelectedTeeth.Count > 0;
        public bool IsShowAll => _chbIsShowAll.Checked;

        public bool IsSplitTeeth
        {
            get { return _chkIsSplitTeeth.Checked; }
            set { _chkIsSplitTeeth.Checked = true; }
        }

        public bool HasSelectedOrderItem => SelectedOrderItem != null;

        //public bool IsAllowEditItem => _viewOrderItems.OptionsBehavior.Editable;
        public bool IsAllowEditItem => AllowEditColumns != null && AllowEditColumns.Any(c => c.OptionsColumn.AllowEdit);


        protected bool ReadOnly => Settings?.IsReadOnlyFunc?.Invoke() ?? false;

        

        public MEntityOrder WorkingOrder => Order;

        protected MEntityOrder Order
        {
            get
            {
                if (_order == null) _order = new MEntityOrder();
                LoadSumValues();
                ApplyCustomerValues(_order);

                var folder = _glkFolder.GetSelectedDataRow() as MEntityOrder;              
                

                _order.FollowersUserName = _cbbSelectFollower.GetStringValue();
                _order.FollowersFullName = _cbbSelectFollower.Text;


                _order.Name = _txtName.Text;
                _order.Description = _txtDescription.Text;
                _order.IsFolder = _chkIsFolder.Checked;
                _order.FolderId = folder?.Id;
                _order.FolderNo = folder?.No ?? 0;
                _order.FolderCode = folder?.Code;
                _order.FolderName = folder?.Name;

                _order.ConsultingDate = _txtConsultDate.DateTime;
                if (RepositorySession.CheckIsGroup(EUserAccountScope.BSĐT) || RepositorySession.IsAdmin)
                {
                    if (string.IsNullOrWhiteSpace(_order?.FollowersUserName))
                    {
                        _order.FollowersUserName = RepositorySession.Username;
                        _order.FollowersFullName = RepositorySession.UserFullName;
                    }
                }

                _order.IsCanceled = chkDaHuy.Checked;
                _order.IsClosed = chkDaDongHoSo.Checked;
               
                _order.IsService = true;
              
               
                _order.IsForOld = IsCheckedIsForOld;

                if (IsCheckedConsultDoctor) ApplyConsultDoctorValues(_order);
                if (IsCheckedConsultAssistant) ApplyConsultAssistantValues(_order);
                ApplyOrderItemValues(_order);
                ApplyTotalValues(_order);
                return _order;
            }
            set
            {
                _order = value;
                _txtName.EditValue = value?.Name;
                _txtDescription.EditValue = value?.Description;
                _chkIsFolder.Checked = value?.IsFolder ?? false;
                _glkFolder.EditValue = value?.FolderId;

                _txtConsultDate.EditValue = value?.ConsultingDate;
                _cbbSelectTLTV.EditValue = value?.ConsultingAssistantUserName;
                _cbbSelectBSTV.EditValue = value?.ConsultantUserName;
                _cbbSelectTelesalesUser.EditValue = value?.TelesalesUsername;
                chkDaHuy.Checked = value?.IsCanceled ?? false;
                chkDaDongHoSo.Checked = value?.IsClosed ?? false;
                TotalPrices = value?.TotalPrices ?? 0;
                TotalDiscount = value?.TotalDiscountMoneys ?? 0;

                ///TODO
                MustPayMoney = value?.MustPayMoney ?? 0;

                ArisingMustPayMoney = value?.MustPayBeforeArisingMoney ?? 0;
                _cbbSelectFollower.EditValue = value?.FollowersUserName;
                IsCheckedIsForOld = value?.IsForOld ?? false;
            }
        }

    }
}
