using System;
using System.Collections.Generic;
using System.Linq;
using VegunSoft.Framework.Db.Enums.Data;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Methods;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemTracks
    {
        protected List<string> SaveResults { get; set; } = new List<string>();
        private bool Save(string orderItemId, List<MEntityOrderItemStep> steps, bool isOther = false)
        {


            SaveResults.Clear();
          
            var dateTime = RepositoryOrderItemStep.GetDateTime();

            var listInserts = new List<MEntityOrderItemStep>();

            var listUpdates = new List<MEntityOrderItemStep>();

            var listSync = new List<MEntityOrderItemStep>();

            //MEntityOrderItemStep infoStep = null;

            var isUpdateItem = false;

            // var ỏderItemSteps = !string.IsNullOrWhiteSpace(XOrderItem?.Id) ? steps.Where(x => x.OrderId == XOrderItem?.Id) : null;
            var now = Now;

            foreach (var step in steps)
            {
                if(step.IsForOld && step.CreatedDate != null && step.CreatedDate.Value.Date == now.Date)
                {
                    Msg.ShowError($"Bạn đang nhập điều trị cũ, vui lòng chọn ngày tạo cũ hơn!");
                    View.FocusRow<MEntityOrderItemStep>(step.Id, (x) => x.Id);
                    UpdateSaveButton();
                    return false;
                }
                if (step.Action == EMgmtCase.Insert)
                {
                    if (step.OrderItemId == orderItemId)
                    {
                        listSync.Add(step);
                        isUpdateItem = true;
                    }
                    if(!isOther) ApplySelectedValues(step);
                    listInserts.Add(step);
                    RepositorySession.ApplyCreatedBasicFields(step, dateTime);
                    //if (infoStep == null) infoStep = step;
                }
                else if (step.Action == EMgmtCase.Update)
                {
                    if (step.OrderItemId == orderItemId)
                    {
                        listSync.Add(step);
                        isUpdateItem = true;
                    }
                    listUpdates.Add(step);
                    RepositorySession.ApplyUpdatedBasicFields(step, dateTime);
                    //if (infoStep == null) infoStep = step;
                }
                else if (step.Action == EMgmtCase.Delete)
                {
                    if (step.OrderItemId == orderItemId) isUpdateItem = true;
                }
            }

            var countInsert = listInserts.Count;

            var isInsertSuccess = false;

            if (countInsert > 0)
            {
                var countInsertResult = RepositoryOrderItemStep.InsertMany(listInserts);
                isInsertSuccess = countInsertResult == countInsert;
                var txt = isInsertSuccess ? "Thành công" : "Thất bại";
                SaveResults.Add($"Đã thêm: {countInsertResult} / {countInsert} mục => {txt}");
            }

            var countUpdate = listUpdates.Count;

            var isUpdateSuccess = false;

            if (countUpdate > 0)
            {
                var countUpdateResult = RepositoryOrderItemStep.UpdateMany(listUpdates);
                isUpdateSuccess = countUpdateResult == countUpdate;
                var txt = isUpdateSuccess ? "Thành công" : "Thất bại";
                SaveResults.Add($"Đã sửa: {countUpdateResult} / {countUpdate} mục => {txt}");
            }
            //if(!isOther)
            var deleteItems = !isOther? DeleteSteps: steps.Where(x=> x.Action == EMgmtCase.Delete).ToList();
            var countDelete = deleteItems.Count;

            var isDeleteSuccess = false;

            if (countDelete > 0)
            {
                if (deleteItems.Any(x => x.OrderItemId == orderItemId)) isUpdateItem = true;
                var countDeleteResult = RepositoryOrderItemStep.DeleteMany(deleteItems);
                isDeleteSuccess = countDeleteResult == countDelete;
                if(isDeleteSuccess) deleteItems.Clear();

                var txt = isDeleteSuccess ? "Thành công" : "Thất bại";
                SaveResults.Add($"Đã xóa: {countDeleteResult} / {countDelete} mục => {txt}");
            }
            
            //if (infoStep != null)
            //{
            //    UpdateCurrentProductService(orderItem, infoStep);
            //}

            if (isUpdateItem)
            {
                var orderItem = !string.IsNullOrWhiteSpace(orderItemId) ? RepositoryOrderItem.Find(orderItemId) : null;
                if (orderItem != null)
                {
                    RepositoryOrderItemStep.SyncValues<MEntityOrderItem, MEntityOrderItemStepMin>(orderItem);
                    RepositorySession.ApplyUpdatedBasicFields(orderItem, dateTime);
                    var rs = RepositoryOrderItem.Update(orderItem);
                    if (rs > 0)
                    {
                        Msg.ShowUpdateSuccessInfo("dịch vụ điều trị", true);
                    }
                    else
                    {
                        Msg.ShowUpdateErrorInfo("dịch vụ điều trị");
                    }
                    AfterSaveOrderItemAction?.Invoke(orderItem);
                }
            }

            Msg.ShowInfo(string.Join(Environment.NewLine, SaveResults), true);
            return true;
        }
    }
}
