using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using VegunSoft.Acc.Entity.Provider.Acc;
using VegunSoft.Framework.Db.Enums.Data;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Methods;
using VegunSoft.Layer.UcControl.Models;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemTracks
    {
        public bool IsSingleMode(MEntityOrderItemStep entity)
        {
            var cfg = StepConfigs?.FirstOrDefault(x => x.Id == entity.PdsvStepId);
            if (cfg == null) return false;
            return cfg.IsSingleRose;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Action<MEntityOrderItem> AfterSaveOrderItemAction { get; set; }
        private void StartOrderItem()
        {
            _tabControlProductServicesSteps.SelectedTab = _tabPageSteps;
            var orderItem = XOrderItem;
            XOrderItemId = orderItem?.Id;
            UcProductServiceSteps.LoadData(() => DataSource, orderItem, IsReadOnly);
            WorkingOrderItem = orderItem;
            
            FocusEndRow();

        }


        //private void SyncDict(MEntityOrderItemStep step = null)
        //{
        //    var id = WorkingOrderItem.Id;
        //    var key = OrderItemStepsDict.Keys.FirstOrDefault(x => x.Id == id);
        //    if (key != null)
        //    {
        //        var list = OrderItemStepsDict[key];
        //        if (step != null)
        //        {
        //            list.Add(step);
        //            return;
        //        }
        //        var newItems = DataSource
        //            .Where(x => x.Action == EMgmtCase.Insert && list.All(v => v.SysInsertId != x.SysInsertId)).ToList();
        //        if (newItems.Count > 0)
        //        {
        //            list.AddRange(newItems);
        //        }


        //    }
        //}

        //private void Remove(MEntityOrderItemStep step = null)
        //{
        //    if (step != null)
        //    {
        //        list.Remove(step);

        //    }

        //    var id = WorkingOrderItem.Id;
        //    var key = OrderItemStepsDict.Keys.FirstOrDefault(x => x.Id == id);
        //    if (key != null)
        //    {
        //        var list = OrderItemStepsDict[key];


        //    }
        //}


        private void OnDelete(MEntityOrderItemStep selectedOrderItemStep)
        {
            if (selectedOrderItemStep != null)
            {
                var allow = !string.IsNullOrWhiteSpace(FormName) && CheckRightsService.CheckCanDelete(SessionCode, FormName);
                if (selectedOrderItemStep.Action == EMgmtCase.Insert || RepositorySession.IsAdmin || allow || selectedOrderItemStep.IsNextContent)
                {
                    DeleteSteps.Add(selectedOrderItemStep);
                    DataSource.Remove(selectedOrderItemStep);

                    RefreshData(true, false, true, true);
                  
                }
                else
                {
                    Msg.ShowError("Bạn không có quyền xóa dòng này, vui lòng liên hệ quản trị");
                }
            }
            else
            {
                Msg.ShowError("Vui lòng chọn 1 dòng để xóa");
            }
           
        }

        public void StartProcessOrderItem(MDoctorInputState state, MEntityOrder order, MEntityOrderItem item, bool isInProcess)
        {
            if (order == null) return;
           Init(state, isInProcess, order.CustomerId, order.CustomerDisplayCode, order.CustomerFullName);
            UcProductServiceSteps.LoadData(() => DataSource, item, IsReadOnly);
            LoadOrderItemsSteps(order, item?.Id);
            WorkingOrderItem = item;
            _tabControlProductServicesSteps.SelectedTab = _tabPageSteps;
            _viewOrders.FocusRow<MEntityOrder>(order.Id, (x) => x.Id);
            _vieOrderItems.FocusRow<MEntityOrderItem>(item.Id, (x) => x.Id);
        }

        protected void OnRowUpdated(int rowHandle)
        {
            var gv = View;
            var model = gv.GetRow(rowHandle) as MEntityOrderItemStep;
            var hId = model?.Id;
            if (!string.IsNullOrWhiteSpace(hId) && model.Action != EMgmtCase.Insert)
            {
                model.Action = EMgmtCase.Update;
                // var hId = h?.Id;
                if (!string.IsNullOrWhiteSpace(hId))
                {
                    var dateTime = RepositoryOrderItemStep.GetDateTime();
                    var dbModel = RepositoryOrderItemStep.Find(hId);
                    if (dbModel.IsNextContent && !model.IsNextContent)
                    {
                        model.PreviousNextDateTime = model.CreatedDate ?? DateTime.MinValue;
                        model.CreatedDate = dateTime;

                    }
                }
                FixValues(model);
               
            }
            RefreshData(false, true, true);
        }

        private void FixValues(MEntityOrderItemStep model)
        {
            if (_repoSelectAssistant.DataSource != null)
            {
                var ds = _repoSelectAssistant.DataSource as List<MEntityUserAccountMin>;
                if (ds != null)
                {
                    var acc = ds.FirstOrDefault(x => x.Id == model.AssistantUsername);
                    if (acc != null) model.AssistantFullName = acc.FullName;
                }
            }

            if (_repoSelectDoctor.DataSource != null)
            {
                var ds = _repoSelectDoctor.DataSource as List<MEntityUserAccountMin>;
                if (ds != null)
                {
                    var acc = ds.FirstOrDefault(x => x.Id == model.DoctorUsername);
                    if (acc != null) model.DoctorFullName = acc.FullName;
                }
            }
        }

    }
}
