using System;
using System.Linq;
using VegunSoft.Category.Data.Category;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Methods;
using VegunSoft.Order.Entity.Business.EntityOrder;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityLabo;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemLabos
    {
        private bool _isSetting;

        protected bool IsShowPrintOptions
        {
            get
            {
                return _cbbAutoPrintMode.ItemIndex == (int)EPrintModes.Config;
            }
        }

        protected bool IsShowPrintPreviews
        {
            get
            {
                return _cbbAutoPrintMode.ItemIndex == (int)EPrintModes.Preview;
            }
        }

        public MEntityCustomer SelectedCustomer
        {
            get
            {
                return Settings?.GetSelectedCustomerFunc?.Invoke();
            }
        }

        public MEntityOrder SelectedOrder
        {
            get
            {
                var model = Settings?.GetSelectedOrderFunc?.Invoke();
                if (model != null && model.IsSaved) return model;
                var customerId = SelectedCustomer?.Id;
                if (!string.IsNullOrWhiteSpace(customerId))
                {
                    var models = RepositoryOrder.GetOrders<MEntityOrder>(customerId).OrderByDescending(x=>x.CreatedDate).ToList();
                    model = models.Any()?models.FirstOrDefault(): null;
                    if (model != null && model.IsSaved) return model;
                }

                return null;
            }
        }

        public MEntityOrderItem SelectedOrderItem
        {
            get
            {
                var model = Settings?.GetSelectedOrderItemFunc?.Invoke();
                if (model != null && model.IsSaved) return model;
                var orderId = SelectedOrder?.Id;
                if (!string.IsNullOrWhiteSpace(orderId))
                {
                    var models = RepositoryOrderItem.GetOrderRows(orderId).OrderByDescending(x => x.CreatedDate).ToList();
                    model = models.Any() ? models.FirstOrDefault() : null;
                    if (model != null && model.IsSaved) return model;
                }
                var customerId = SelectedCustomer?.Id;
                if (!string.IsNullOrWhiteSpace(customerId))
                {
                    var models = RepositoryOrderItem.GetOrderItems<MEntityOrderItem>(customerId).OrderByDescending(x => x.CreatedDate).ToList();
                    model = models.Any() ? models.FirstOrDefault() : null;
                    if (model != null && model.IsSaved) return model;
                }
                return null;
            }
        }

        public IEntityOrderItemStepMin SelectedOrderItemStep
        {
            get
            {
                IEntityOrderItemStepMin model = null;
                var orderItemId = SelectedOrderItem?.Id;
                if (!string.IsNullOrWhiteSpace(orderItemId))
                {
                    var models = _repositoryOrderItemProcessing.GetServiceHistories(orderItemId).OrderByDescending(x=>x.CreatedDate).ToList();
                    model = models.Any() ? models.FirstOrDefault() : null;
                    if (model != null && model.IsSaved) return model;
                }
                var orderId = SelectedOrder?.Id;
                if (!string.IsNullOrWhiteSpace(orderId))
                {
                    var models = _repositoryOrderItemProcessing.GetPlanHistories(orderId).OrderByDescending(x => x.CreatedDate).ToList();
                    model = models.Any() ? models.FirstOrDefault() : null;
                    if (model != null && model.IsSaved) return model;
                }
                var customerId = SelectedCustomer?.Id;
                if (!string.IsNullOrWhiteSpace(customerId))
                {
                    var models = _repositoryOrderItemProcessing.GetHistories<MEntityOrderItemStepMin>(customerId).OrderByDescending(x => x.CreatedDate).ToList();
                    model = models.Any() ? models.FirstOrDefault() : null;
                    if (model != null && model.IsSaved) return model;
                }
                return model;
            }
        }

        protected MEntityLabo Entity
        {
            get
            {
                var order = SelectedOrder;
                var orderItem = _cbbSelectOrderItem.GetSelectedDataRow() as MEntityOrderItem;
                var orderItemStep = _glkOrderItemStep.GetSelectedDataRow() as MEntityOrderItemStep;
                var orderId = order?.Id;
                _entity.DoctorUsername = _cbbSelectLaboCreatorDoctor.EditValue?.ToString();
                _entity.DoctorUserFullName = _cbbSelectLaboCreatorDoctor.Text?.Trim();
                _entity.ProviderId = _glkProvider.EditValue?.ToString();
                _entity.ProviderName = _glkProvider.Text?.Trim();

                _entity.OrderId = order?.Id;
                if (string.IsNullOrWhiteSpace(_entity.OrderId)) _entity.OrderId = orderItem?.OrderId;
                _entity.OrderCode = order?.Code;
                _entity.OrderName = order?.Name;
                _entity.OrderNo = order?.No ?? 0;

                _entity.OrderItemId = orderItem?.Id;
                _entity.OrderItemNo = orderItem?.No ?? 0;
                _entity.OrderItemCode = orderItem?.Code;
                _entity.OrderItemName = orderItem?.ProductServiceName;
                _entity.OrderItemTarget = orderItem?.ProductServiceTargetName;
                _entity.OrderItemStepId = orderItemStep?.Id;
                _entity.OrderItemStepNo = orderItemStep?.No ?? 0;
                _entity.OrderItemStepCode = orderItemStep?.Code;
                _entity.OrderItemStepName = orderItemStep?.Name;
                _entity.OrderItemStepContent = orderItemStep?.StepDisplayText;

                _entity.MaterialId = glkDMVatlieu.EditValue?.ToString();
                _entity.MaterialName = glkDMVatlieu.Text?.Trim();
                _entity.PorcelainColor = txtMauSu.Text?.Trim();
                _entity.ToothCodes = _cbbLaboRang.Text?.Trim();
                _entity.ToothId = _cbbLaboRang.GetStringValue();
                _entity.Amount = Convert.ToDouble(_calcAmount.EditValue ?? 0);

                if (dtNgayDat.DateTime == DateTime.MinValue)
                    _entity.RequestDateTime = DateTime.MinValue.AddDays(1);
                else
                    _entity.RequestDateTime = dtNgayDat.DateTime;

                if (dtNgayGiao.DateTime == DateTime.MinValue)
                    _entity.ResponseDateTime = DateTime.MinValue.AddDays(1);
                else
                    _entity.ResponseDateTime = dtNgayGiao.DateTime;

                if (dtNgayHen.DateTime == DateTime.MinValue)
                    _entity.UsingDateTime = DateTime.MinValue.AddDays(1);
                else
                    _entity.UsingDateTime = dtNgayHen.DateTime;

                _entity.WarrantyCard = txtTheBH.Text?.Trim();

                if (!string.IsNullOrWhiteSpace(dtNamBH.Text))
                    _entity.WarrantyYear = dtNamBH.DateTime.Year.ToString();
                else
                    _entity.WarrantyYear = "";

                _entity.CustomerId = SelectedCustomer?.Id;
                _entity.CustomerNo = SelectedCustomer?.No ?? 0;
                _entity.CustomerCode = SelectedCustomer?.Code;
                _entity.CustomerFullName = SelectedCustomer?.FullName;
                _entity.CustomerPhoneNumber = SelectedCustomer?.PhoneNumber;
                _entity.CustomerPrivateInfo = SelectedCustomer?.PrivateInfo;

                _entity.Price = Convert.ToDecimal(_calcUnitPrice.EditValue ?? 0);
                _entity.TotalMoney = Convert.ToDecimal(_calcStartFee.EditValue ?? 0);
                _entity.TotalMoneyFinal = Convert.ToDecimal(_calcEndFee.EditValue ?? 0);
                _entity.Note = _txtNotes.Text?.Trim();

                _entity.StatusId = glkTrangThai.EditValue?.ToString();
                _entity.StatusName = glkTrangThai.Text?.Trim();
                _entity.AssistantId = _cbbSelectLaboAssistant.GetStringValue();
                _entity.AssistantFullName = _cbbSelectLaboAssistant.Text;
                _entity.BookingTypeId = _cbbLaboPhanLoai.GetStringValue();
                _entity.BookingTypeName = _cbbLaboPhanLoai.Text;

                return _entity;
            }
            set
            {
                _isSetting = true;
                _entity = value;
                _cbbSelectLaboCreatorDoctor.EditValue = value.DoctorUsername;
                _glkProvider.EditValue = value.ProviderId;
                glkDMVatlieu.EditValue = value.MaterialId;
                LoadOrderItems(value.CustomerId, null);
                LoadOrderItemSteps(value.CustomerId, value.OrderId, value.OrderItemId);

                _cbbSelectOrderItem.EditValue = value.OrderItemId;
                _glkOrderItemStep.EditValue = value.OrderItemStepId;
                txtMauSu.EditValue = value.PorcelainColor;
                _cbbLaboRang.EditValue = GetRangId(value.ToothCodes);
                if (_cbbLaboRang.EditValue != null && _cbbLaboRang.GetIntValue() == 0) _cbbLaboRang.Text = value.ToothCodes;
                _calcAmount.EditValue = value.Amount;
                dtNgayGiao.EditValue = value.ResponseDateTime;
                dtNgayHen.EditValue = value.UsingDateTime;
                dtNgayDat.EditValue = value.RequestDateTime;
                txtTheBH.EditValue = value.WarrantyCard;

                if (!string.IsNullOrWhiteSpace(value.WarrantyYear))
                    dtNamBH.EditValue = new DateTime(Convert.ToInt32(value.WarrantyYear), 1, 1);
                else dtNamBH.EditValue = null;

                _calcUnitPrice.EditValue = value.Price;
                _calcStartFee.EditValue = value.TotalMoney;
                _calcEndFee.EditValue = value.TotalMoneyFinal;
                _txtNotes.Text = value.Note;
                glkTrangThai.EditValue = value.StatusId;
                _cbbSelectLaboAssistant.EditValue = value.AssistantId;
                _cbbLaboPhanLoai.EditValue = value.BookingTypeId;


                _isSetting = false;
                UpdateEnables();
            }
        }

        protected void UpdateEnables()
        {
            _btnPrint.Enabled = !string.IsNullOrWhiteSpace(Entity?.Id);
        }

    }
}
