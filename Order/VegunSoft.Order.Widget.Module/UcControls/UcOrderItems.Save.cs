using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VegunSoft.App.Data.Business;
using VegunSoft.Customer.Entity.Provider.Rating.Setting;
using VegunSoft.Framework.Db.Enums.Data;
using VegunSoft.Framework.Methods;
using VegunSoft.Layer.UcControl.Customer.Models;
using VegunSoft.Layer.UcService.Provider.Any;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItems
    {
        protected MSaveOrderConfig GetSaveOrderConfig()
        {
           
            if (ReadOnly && !IsSupperAdmin)
            {
                Msg.ShowError("Bạn chỉ có quyền xem!");
                return null;
            }

            if (string.IsNullOrWhiteSpace(OrderConsultDateText))
            {
                Msg.ShowError(Class_Global._TBRangBuocRong("Ngày tư vấn"));
                IsFocusConsultDate = true;
                return null;
            }
           
            var now = Now;
            if (IsCheckedIsForOld && now.Date == OrderConsultDate.Date)
            {
                Msg.ShowError($"Bạn đang nhập hỗ sơ cũ, vui lòng chọn ngày tư vấn cũ hơn!");
                IsFocusConsultDate = true;
                return null;
            }
            if (!CanSaveOrderItems(now))
            {
                return null;
            }
            var m = Order;
            if (m == null) return null;
            return new MSaveOrderConfig()
            {
                Name = "hồ sơ",
                IsNew = !IsUpdatingOrder,
                IsNeedReloadFolder = _chkIsFolder.Checked,
                IsNeedAddConsult = _chkCreateConsult.Checked && _chkCreateConsult.Enabled,
               
                Entity = m
            };
        }

        protected MSaveOrderResult SaveOrderAsync(MSaveOrderConfig config)
        {
            var rs = new MSaveOrderResult();
            var sb = new StringBuilder();
            var m = config.Entity;
            var returnName = string.Empty;
            var isSaveOrderSuccess = false;
            var isUpdateCustomerSuccess = false;

           
            if (config.IsNeedAddConsult)
            {
                rs.ConsultEntity = CheckAndAddConsultancy(m);
                rs.IsSaveConsultSuccess = rs.ConsultEntity != null && rs.ConsultEntity.IsSaved;
            }
            if (!config.IsNeedAddConsult || rs.IsSaveConsultSuccess)
            {
                if (config.IsNew)
                {
                    var error = SaveNewOrder(m);
                    // mLog.ACTION = ERights.THEM.ToString();
                    if (!string.IsNullOrWhiteSpace(error))
                    {
                        sb.AppendLine(error);
                        isSaveOrderSuccess = false;
                    }
                    else
                    {
                        returnName = $"Id = {m.Id}";
                        isSaveOrderSuccess = true;
                    }
                }
                else
                {
                    var error = SaveUpdatingOrder(m);
                    if (!string.IsNullOrWhiteSpace(error))
                    {

                        Msg.ShowError(error);
                        isSaveOrderSuccess = false;
                    }
                    else
                    {
                        returnName = $"Id = {m.Id}";
                        isSaveOrderSuccess = true;
                    }
                }

                var saveCustomerError = UpdateCustomerAfterSaveOrder();
                if (!string.IsNullOrWhiteSpace(saveCustomerError))
                {

                    Msg.ShowError(saveCustomerError);
                    isUpdateCustomerSuccess = false;
                }
                else
                {
                    isUpdateCustomerSuccess = true;
                }
            }
            else if (config.IsNeedAddConsult && !rs.IsSaveConsultSuccess)
            {
                sb.AppendLine(string.Format(EMsg.InsertFailTpl.GetText(), "tư vấn"));
            }
            rs.Entity = m;
            rs.IsSaveOrderSuccess = isSaveOrderSuccess;
            rs.IsUpdateCustomerSuccess = isUpdateCustomerSuccess;
            rs.IsSuccess = isSaveOrderSuccess && isUpdateCustomerSuccess;
            rs.ReturnName = returnName;
            return rs;
        }

        protected void DisplaySaveOrderResults(MSaveOrderConfig config, MSaveOrderResult result)
        {
            if (result?.IsSaveConsultSuccess??false)
            {
                Settings?.OnAddConsultDoneAction?.Invoke(result?.ConsultEntity);
            }
            if (result?.IsSuccess ?? false)
            {
                var isNeedReloadFolder = _chkIsFolder.Checked;
                if (isNeedReloadFolder)
                {
                    ReloadFolders();
                }

                Settings?.OnEndSaveOrderAction?.Invoke(config.Entity);
                //ReadOnlyDieuTri(true, _gcOrderItemProcess);
                LoadOrders();
                //SelectOrder(result?.Entity?.Id); 
                Settings?.SelectOrderAction?.Invoke(result?.Entity?.Id);
            }
            
        }

        protected string SaveNewOrder(MEntityOrder m)
        {
            var sb = new StringBuilder();
            var dateTime = ApplyNewProperties(m);

            var id = RepositoryOrder.InsertGetInt(m).ToString();
            var isSuccess = !string.IsNullOrWhiteSpace(id) && !string.IsNullOrWhiteSpace(id) && id != "0";
            if (isSuccess)
            {
                m.Id = id;
                SaveOrderItems(sb, id, dateTime);
                IsUpdatingOrder = false;

            }
            else
            {
                sb.AppendLine("Thêm mới hồ sơ điều trị không thành công");
            }
            return sb.ToString();
        }

        protected string SaveUpdatingOrder(MEntityOrder m)
        {
            var sb = new StringBuilder();
            var dateTime = RepositoryOrderItem.GetDateTime();
            var id = Order.Id;

            RepositorySession.ApplyUpdatedBasicFields(m, dateTime);
            if (RepositoryOrder.Update(m) > 0)
            {
                SaveOrderItems(sb, id, dateTime);
                IsUpdatingOrder = false;
            }
            else
            {
                sb.AppendLine($"Cập nhật hồ sơ điều trị {id} không thành công");
            }
            return sb.ToString();
        }

        private void SaveOrderItems(StringBuilder sb, string orderId, DateTime dateTime)
        {
            var tasks = new List<MRatingServiceTask>();
            foreach (var kv in OrderItemStepsDict)
            {
                var ob = kv.Key;
                var task = GetTask(ob, kv.Value);
                if (task != null)
                {
                    tasks.Add(task);
                }

            }
            CheckAndInsertRating(tasks);
            var listUpdateServices = new List<MEntityOrderItem>();
            var listNewHistoryModels = new List<MEntityOrderItemStep>();
            var listDeleteServices = new List<string>();
            var order = Order;
            foreach (var kv in OrderItemStepsDict)
            {
                var orderItem = kv.Key;
                CopyInfo(orderItem);
                orderItem.IsInProgress = kv.Value != null && kv.Value.Count > 0;
                orderItem.OrderId = orderId;
                orderItem.BranchId = order.BranchId;
                orderItem.CustomerId = order.CustomerId;
                orderItem.CustomerNo = order.CustomerNo;
                orderItem.CustomerCode = order.CustomerCode;
                orderItem.CustomerFullName = order.CustomerFullName;
                orderItem.CustomerPrivateInfo = order.CustomerPrivateInfo;
                orderItem.CustomerPhoneNumber = order.CustomerPhoneNumber;
                orderItem.IsDraft = order.IsDraft;
                if (orderItem.FinishDate == DateTime.MinValue) orderItem.FinishDate = Class_Global._dtNull;
                if (orderItem.ApprovedDate == DateTime.MinValue) orderItem.ApprovedDate = Class_Global._dtNull;
                string treatmentServiceId = "0";


                // set treatment history isTemp = true;
                kv.Value?.ForEach(x =>
                {
                    x.IsTemp = false;
                });

                if (orderItem.Action == EMgmtCase.Insert)
                {
                    var m = orderItem;
                    RepositorySession.ApplyCreatedBasicFields(m, dateTime);
                    treatmentServiceId = RepositoryOrderItem.InsertGetInt(m).ToString();
                    if (string.IsNullOrWhiteSpace(treatmentServiceId) || treatmentServiceId == "0")
                    {
                        sb.AppendLine($"Thêm dịch vụ thấy bại: {m.ProductServiceName}");
                    }
                    if (kv.Value != null && kv.Value.Count > 0)
                    {
                        //ApplyData(kv.Value, ob);
                        ApplyData(kv.Value, orderId, treatmentServiceId);
                        listNewHistoryModels.AddRange(kv.Value.ToList());
                    }

                    if (!string.IsNullOrWhiteSpace(m.OldOrderItemId) && m.OldOrderItemId != "0")
                    {
                        var oldModel = ActiveOrderItems.FirstOrDefault(x => x.Id == m.OldOrderItemId && x.IsChanged);
                        if (oldModel != null)
                        {
                            var newModel = RepositoryOrderItem.Find(treatmentServiceId);
                            if (newModel != null)
                            {
                                oldModel.ChangedToOrderItemId = newModel.Id;
                                oldModel.ChangedToOrderItemNo = newModel.ChangedToOrderItemNo;
                                oldModel.ChangedToOrderItemCode = newModel.ChangedToOrderItemCode;
                                oldModel.ChangedToOrderItemName = newModel.ChangedToOrderItemName;
                            }


                        }
                    }

                }
                else if (orderItem.Action == EMgmtCase.Update)
                {
                    treatmentServiceId = orderItem.Id;
                    var m = orderItem;
                    RepositorySession.ApplyUpdatedBasicFields(m, dateTime);
                    listUpdateServices.Add(m);

                    if (kv.Value != null && kv.Value.Count > 0)
                    {

                        var insertHistories = kv.Value.Where(v => string.IsNullOrWhiteSpace(v.Id)).Select(x =>
                        {
                            var model = x;
                            RepositorySession.ApplyCreatedBasicFields(model, dateTime);
                            return model;
                        }).ToList();
                        ApplyData(insertHistories, orderId, treatmentServiceId);
                        listNewHistoryModels.AddRange(insertHistories);
                    }

                }
                else if (orderItem.Action == EMgmtCase.Delete && !string.IsNullOrWhiteSpace(orderItem.Id))
                {
                    listDeleteServices.Add(orderItem.Id.ToString());

                }


                orderItem.Action = EMgmtCase.Update;
            }

            if (listNewHistoryModels.Count > 0)
            {
                var requestInsertCount = listNewHistoryModels.Count;
                var insertCount = RepositoryOrderItemStep.InsertMany(listNewHistoryModels.ToArray());
                if (insertCount != requestInsertCount)
                {
                    sb.AppendLine($"Thêm lịch sử thấy bại: {requestInsertCount} => {insertCount}");
                }
            }

            if (listUpdateServices.Count > 0)
            {
                var requestUpdateCount = listUpdateServices.Count;
                var updatedCount = RepositoryOrderItem.UpdateMany(listUpdateServices.ToArray());
                if (updatedCount != requestUpdateCount)
                {
                    sb.AppendLine($"Cập nhật dịch vụ thấy bại: {requestUpdateCount} => {updatedCount}");
                }
            }

            if (listDeleteServices.Count > 0)
            {
                // var requestDeleteCount = listUpdateServices.Count;
                RepositoryOrderItem.DeleteMany(listDeleteServices.ToArray());
                var isDeleteSuccess = RepositoryOrderItemStep.DeleteMany(nameof(MEntityOrderItemStep.OrderItemId), listDeleteServices.Select(x => x as object).ToArray());
                if (!isDeleteSuccess)
                {
                    sb.AppendLine($"Xóa nhật dịch vụ thấy bại!");
                }
            }

            bHasChange_Hosodieutri_CT = false;
        }

        protected string UpdateCustomerAfterSaveOrder()
        {
            var sb = new StringBuilder();
            var c = SelectedCustomer;
            if (c.DoctorUsername == "")
            {
                c.DoctorUsername = RepositorySession.Username;
                c.DoctorFullName = RepositorySession.UserFullName;
            }
            c.CurrentDoctorUserName = RepositorySession.Username;
            c.CurrentDoctorFullName = RepositorySession.UserFullName;
            PortalCustomer.SetTotalValues(c);
            var isSuccess = RepositoryCustomer.Update(c) > 0;
            if (!isSuccess)
            {
                sb.AppendLine(string.Format(EMsg.UpdateSuccessTpl.GetText(), $"khách hàng - {c.DisplayCode} - {c.FullName}"));
            }
            return sb.ToString();
        }

    }
}
