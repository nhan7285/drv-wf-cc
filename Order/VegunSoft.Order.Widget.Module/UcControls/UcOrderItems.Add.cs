using System;
using System.Collections.Generic;
using System.Linq;
using VegunSoft.Category.Entity.Provider.Category;
using VegunSoft.Category.Entity.Provider.Category.Body;
using VegunSoft.Framework.Db.Enums.Data;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;
using VegunSoft.Product.Entity.Provider.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItems
    {
        private void StartNewOrder()
        {
            if (SelectedCustomer == null || string.IsNullOrWhiteSpace(SelectedCustomer.Id))
            {
                Msg.ShowError("Vui lòng chọn khách hàng!");
                return;
            }
            
            _chkIsFolder.Checked = false;
            _btnSaveOrderItem.Visible = false;
            IsShowAllOrderItems = false;
            ShowMinMaxPrice(true);
            IsUpdatingOrder = false;
            ResetCustomerTreatmentData();
            _txtConsultDate.DateTime = RepositoryOrder.GetDateTime();
            OrderItemStepsDict = new Dictionary<MEntityOrderItem, List<MEntityOrderItemStep>>();
            txtIdRang.Focus();
            _glkTooth.EditValue = 0;
            LoadOrderItems();
            AllowTreatColumn(false);
            StartAdd();
            _cbbSelectFollower.EditValue = RepositorySession.Username;
            _cbbSelectTelesalesUser.EditValue = SelectedCustomer.TelesalesId;
            
            ApplyReadOnlyConsultEditors();
            UpdateControlsStatus();
            AllowCreateConsult(true);
            LoadDefaultValues();
            Settings?.UpdateCaptionAction?.Invoke("Hồ sơ mới");
        }

        private void AddTeethToOrderItems(MEntityPdsv cargo, List<MEntityTooth> teeth, int no)
        {
            var ammount = Convert.ToInt32(_calcAmount.Value);
            var isTemporary = _cheIsTemporary.Checked;
            var isChange = _cheIsChange.Checked;
            var isSingle = teeth != null && teeth.Count == 1;
            var li = new List<MEntityOrderItem>();
            var consultant = _cbbSelectBSTV.SelectedUserAccount;
            var assistant = _cbbSelectTLTV.SelectedUserAccount;
            var isCheckedForOld = IsCheckedIsForOld;
            if (teeth != null)
            {
                foreach (var tooth in teeth)
                {
                    var item = new MEntityOrderItem
                    {
                        IsActive = true,
                        PlanNo = no,
                        PlanNamePrefix = "Phương án " + no,
                        ProductServiceId = cargo.Id,
                        ProductServiceName = cargo.Name,

                        ProductServiceGroupFinalId = cargo.GroupFinalId,
                        ProductServiceGroupFinalName = cargo.GroupFinalName,
                        UnitId = cargo.UnitId,
                        UnitName = cargo.UnitName,
                       
                        Amount = ammount,
                        UnitPrice = GetFinalPrice(cargo),
                        DiscountMoney = 0,

                        IsTemporary = isTemporary,

                        IsApproved = false,
                        IsArisingService = true,
                        IsService = true,
                        ConsultConsultantUserName = consultant?.Username,
                        ConsultConsultantFullName = consultant?.FullName,
                        ConsultAssistantUserName = assistant?.Username,
                        ConsultAssistantFullName = assistant?.FullName,
                        IsForOld = isCheckedForOld,
                        Action = EMgmtCase.Insert
                    };
                    if (item.IsForOld) item.CreatedDate = OrderConsultDate;
                    ApplyToothValues(item, tooth);
                    item.CalculateMoney();
                    li.Add(item);
                }
            }
            foreach (var item in li)
            {
                OrderItemStepsDict.Add(item, new List<MEntityOrderItemStep>());
            }
            if (isChange)
            {
                MEntityOrderItem newModel = null;
                if (isSingle)
                {
                    newModel = li.FirstOrDefault();
                }
                else
                {
                    var oldModel = McChangeItem.OldModel;
                    if (oldModel != null)
                    {
                        var productServiceTargetId = oldModel.ProductServiceTargetFinalIds;
                        var newModels = OrderItemStepsDict.Keys.Where(x => x.ProductServiceTargetFinalIds == productServiceTargetId).ToList();
                        if (newModels.Count == 1)
                        {
                            newModel = newModels.FirstOrDefault();
                        }
                    }
                }
                if (newModel != null)
                {
                    OnSelectChangeToItem(newModel);
                }
                else
                {
                    Msg.ShowInfo("Không tìm thấy dịch vụ phù hợp để đổi, vui lòng đổi lại sau!");
                    EndChangeOrderItem();
                }
            }
        }

    }
}
