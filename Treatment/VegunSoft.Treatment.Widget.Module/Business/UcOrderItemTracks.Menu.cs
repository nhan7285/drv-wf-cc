using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using VegunSoft.App.Data.Business;
using VegunSoft.Category.Entity.Provider.Category;
using VegunSoft.Category.Entity.Provider.Category.Body;
using VegunSoft.Framework.Db.Enums.Data;
using VegunSoft.Framework.Gui.Enums.Image;
using VegunSoft.Layer.UcControl.Customer.Forms;
using VegunSoft.Order.Entity.Business.EntityOrderItem;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemTracks
    {

        public GridColumn CurrentColumn { get; private set; }

        private Image GetIcon(EResourceImage16 icon)
        {
            return IconService.GetIcon16<EResourceImage16, Image>(icon);
        }

        private void SetContextMenus()
        {
            var menu = MenuService.Init();
            MenuService.AddItem("Đồng bộ cho các răng khác cùng SP/DV...", IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.ShowDetail16), InsertOtherTeethOnClick, (item) => AllowCloneAddSteps() && IsAllowEdit());
            MenuService.AddItem("Đồng bộ cho tất cả các răng khác cùng SP/DV", IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Write16), InsertAllTeethOnClick, (item) => AllowCloneAddSteps() && IsAllowEdit());

            /*MenuService.AddSeparator();

            MenuService.AddItem("Sửa cho các răng khác cùng SP/DV...", IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.ShowDetail16), UpdateOtherTeethOnClick, () => AllowCloneUpdateSteps() && IsAllowEdit());
            MenuService.AddItem("Sửa cho tất cả các răng khác cùng SP/DV", IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Write16), UpdateAllTeethOnClick, () => AllowCloneUpdateSteps() && IsAllowEdit());
*/
            MenuService.AddSeparator();

            MenuService.AddItem("Xóa cho các răng khác cùng SP/DV...", IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Delete16), DeleteOtherTeethOnClick, (item) => AllowCloneDeleteSteps() && IsAllowEdit());
            MenuService.AddItem("Xóa cho tất cả các răng khác cùng SP/DV", IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.DeleteAll16), DeleteAllTeethOnClick, (item) => AllowCloneDeleteSteps() && IsAllowEdit());

            MenuService.AddSeparator();

            MenuService.AddItem("Cố định / bỏ cố định trái cột", GetIcon(EResourceImage16.Devide16), (s, e) => ApplyFixOrUnFixLeft(), (x) => HasSelectedRowOrEmpty);
            MenuService.AddItem("Cố định / bỏ cố định phải cột", GetIcon(EResourceImage16.Devide16), (s, e) => ApplyFixOrUnFixRight(), (x) => HasSelectedRowOrEmpty);
        }

        private void ApplyFixOrUnFixLeft()
        {
            var c = this.View.FocusedColumn;
            c.Fixed = (c.Fixed == FixedStyle.Left) ? FixedStyle.None : FixedStyle.Left;
        }

        private void ApplyFixOrUnFixRight()
        {
            var c = this.View.FocusedColumn;
            c.Fixed = (c.Fixed == FixedStyle.Right) ? FixedStyle.None : FixedStyle.Right;
        }

        private void ShowContextMenu()
        {
            MenuService.Show();
        }
        //OnApplyAllOthersTeeth
        private void InsertOtherTeethOnClick(object arg1, EventArgs arg2)
        {
            OnApplyToOthersTeeth(XOrderItem, EMgmtCase.Insert);
        }
        private void InsertAllTeethOnClick(object arg1, EventArgs arg2)
        {
            OnApplyAllOthersTeeth(XOrderItem, EMgmtCase.Insert);
        }

        private void UpdateOtherTeethOnClick(object arg1, EventArgs arg2)
        {
            OnApplyToOthersTeeth(XOrderItem, EMgmtCase.Update);
        }
        private void UpdateAllTeethOnClick(object arg1, EventArgs arg2)
        {
            OnApplyAllOthersTeeth(XOrderItem, EMgmtCase.Update);
        }

        private void DeleteOtherTeethOnClick(object arg1, EventArgs arg2)
        {
            OnApplyToOthersTeeth(XOrderItem, EMgmtCase.Delete);
        }

        private void DeleteAllTeethOnClick(object arg1, EventArgs arg2)
        {
            OnApplyAllOthersTeeth(XOrderItem, EMgmtCase.Delete);
        }

        private bool AllowCloneAddSteps()
        {
            return SelectedOrderItemStep != null && WorkingOrderItems != null && WorkingOrderItems.Count > 1 && SelectedOrderItemStep.IsSaved && XOrderItem!=null && !string.IsNullOrWhiteSpace(XOrderItem.ProductServiceTargetName) && CurrentColumn == _gcOrderItemStepTeethName;
        }

        private bool AllowCloneUpdateSteps()
        {
            return SelectedOrderItemStep != null && WorkingOrderItems != null && WorkingOrderItems.Count > 1 && SelectedOrderItemStep.IsSaved && XOrderItem != null && !string.IsNullOrWhiteSpace(XOrderItem.ProductServiceTargetName) && CurrentColumn == _gcOrderItemStepTeethName;
        }

        private bool AllowCloneDeleteSteps()
        {
            return SelectedOrderItemStep != null && WorkingOrderItems != null && WorkingOrderItems.Count > 1 && SelectedOrderItemStep.IsSaved && XOrderItem != null && !string.IsNullOrWhiteSpace(XOrderItem.ProductServiceTargetName) && CurrentColumn == _gcOrderItemStepTeethName;
        }

        private bool IsAllowEdit()
        {
            return AllowSave;
        }

        protected string GetCloneStepId(IEntityOrderItemBusiness item, MEntityOrderItemStep rootStep)
        {
            var steps = WorkingOrderItemSteps;
            var id = steps.FirstOrDefault(x => x.ReferenceCode == rootStep.ReferenceCode && x.OrderId == rootStep.OrderId && x.OrderItemId == item.Id && x.PdsvStepId == rootStep.PdsvStepId)?.Id;
            return id;
        }


        protected MEntityOrderItemStep GetCloneStep(IEntityOrderItemBusiness item, MEntityOrderItemStep rootStep, EMgmtCase mgmtCase)
        {
            var id = GetCloneStepId(item, rootStep);
            var isInsert = mgmtCase == EMgmtCase.Insert;
            

            var isUpdate = mgmtCase == EMgmtCase.Update;
            var isDelete = mgmtCase == EMgmtCase.Delete;
           
            if (isUpdate || isDelete)
            {
                if (string.IsNullOrWhiteSpace(id)) return null;
            }
           
            var step = new MEntityOrderItemStep
            {
                Id = id,
                IsService = rootStep.IsService,
                IsProduct = rootStep.IsProduct,
                IsOther = rootStep.IsOther,

                OrderItemId = item.Id,
                OrderItemName = item.Name,
                BranchId = item.BranchId,
                CustomerId = rootStep.CustomerId,
                CustomerNo = rootStep.CustomerNo,
                CustomerCode = rootStep.CustomerCode,
                CustomerFullName = rootStep.CustomerFullName,
                CustomerPhoneNumber = rootStep.CustomerPhoneNumber,
                CustomerPrivateInfo = rootStep.CustomerPrivateInfo,
                OrderId = rootStep.OrderId,
                IsTemp = rootStep.IsTemp,
               
                IsFinishStage = rootStep.IsFinishStage,
                FinishStageDate = rootStep.FinishStageDate,
                IsWaitingForRating = rootStep.IsWaitingForRating,
                IsNextContent = rootStep.IsNextContent,
                CreatedDate = rootStep.CreatedDate,
                DisplayPriority = rootStep.DisplayPriority,
                RawStepName = rootStep.RawStepName,
                IsFinishProcess = rootStep.IsFinishProcess,
                IsNoTreatment = rootStep.IsNoTreatment,
                DoctorUsername = rootStep.DoctorUsername,
                DoctorFullName = rootStep.DoctorFullName,
                AssistantUsername = rootStep.AssistantUsername,
                AssistantFullName = rootStep.AssistantFullName,
                IsOutOfConfigReExamination = rootStep.IsOutOfConfigReExamination,
                Action = mgmtCase,
                StepDescription = rootStep.StepDescription,
                RawStepId = rootStep.RawStepId,
                FeeRate = rootStep.FeeRate,
                PdsvStepId = rootStep.PdsvStepId,
                PdsvStepParentId = rootStep.PdsvStepParentId,
                TeethId = item.ProductServiceTargetFinalIds,
                TeethName = item.ProductServiceTargetName,
                Dateline = rootStep.Dateline,
                PreviousNextDateTime = rootStep.PreviousNextDateTime,
                IsApproved = rootStep.IsApproved,
                ApprovedDate = rootStep.ApprovedDate,
                Note = rootStep.Note,
                HasPrescription = rootStep.HasPrescription,
                HasSubclinical = rootStep.HasSubclinical,
                PrescriptionId = rootStep.PrescriptionId,
                SubclinicalId = rootStep.SubclinicalId,
                TelesalesId = rootStep.TelesalesId,
                TelesalesNo = rootStep.TelesalesNo,
                TelesalesCode = rootStep.TelesalesCode,
                TelesalesUsername = rootStep.TelesalesUsername,
                TelesalesFullName = rootStep.TelesalesFullName,
                ConnectorId = rootStep.ConnectorId,
                ConnectorNo = rootStep.ConnectorNo,
                ConnectorCode = rootStep.ConnectorCode,
                ConnectorUsername = rootStep.ConnectorUsername,
                ConnectorFullName = rootStep.ConnectorFullName,
                IsAssistantMain = rootStep.IsAssistantMain,
                IsPreventCommission = rootStep.IsPreventCommission,
                PreventCommissionNote = rootStep.PreventCommissionNote,
                ReferenceCode = rootStep.ReferenceCode
            };
            RepositoryOrderItemStep.CopyInfo(step, item);
            if (isInsert)
            {
                if (!string.IsNullOrWhiteSpace(step.Id)) step.Action = EMgmtCase.Update;
            }
            /* if(step.Action == EMgmtCase.Insert)
             {
                 Session.ApplyCreatedBasicFields(step, step.CreatedDate.Value);
             } else
             if (step.Action == EMgmtCase.Update)
             {
                 Session.ApplyUpdatedBasicFields(step, step.CreatedDate.Value);
             }*/

            return step;
        }

        protected string GetCaseName(EMgmtCase mgmtCase)
        {
            switch (mgmtCase)
            {
                case EMgmtCase.Insert:
                    return "thêm";
                case EMgmtCase.Update:
                    return "sửa";
                case EMgmtCase.Delete:
                    return "xóa";
            }
            return string.Empty;
        }

        private void UpdateRootItem(MEntityOrderItem item)
        {
            var rootStep = SelectedOrderItemStep;
            Msg.ShowInfo($"Đang lưu răng {item.ProductServiceTargetName}...", true);
            if (string.IsNullOrWhiteSpace(rootStep.ReferenceCode))
            {
                rootStep.ReferenceCode = Guid.NewGuid().ToString();
            }
            rootStep.Action = EMgmtCase.Update;
            var v = Save(item?.Id, new List<MEntityOrderItemStep>() {
            rootStep
            }, false);
            if(v) Msg.ShowInfo($"Đã lưu răng {item.ProductServiceTargetName}", true);
        }

        private void OnApplyAllOthersTeeth(MEntityOrderItem item, EMgmtCase mgmtCase)
        {
            var orderId = item.OrderId;
            var items = WorkingOrderItems;
            var rootStep = SelectedOrderItemStep;
            if (string.IsNullOrWhiteSpace(rootStep.ReferenceCode))
            {
                rootStep.ReferenceCode = Guid.NewGuid().ToString();
            }
             var targetItems = items.Where(x => x.OrderId == item.OrderId && x.ProductServiceId == item.ProductServiceId && x.ProductServiceTargetFinalIds != item.ProductServiceTargetFinalIds).ToList();
            var caseName = GetCaseName(mgmtCase);
            var list = targetItems.Select(x=>x.ProductServiceTargetName).Distinct().ToList();
            var names = string.Join(", ", list);
            if (Msg.IsAgree($"Bạn có muốn {caseName} nội dung cho các răng {names} cho giống răng {item?.ProductServiceTargetName}"))
            {
                ShowLoading();
                var isPass = true;
                foreach (var targetItem in targetItems)
                {
                    Msg.ShowInfo($"Đang {caseName} răng {targetItem.ProductServiceTargetName}...", true);
                    var listSteps = new List<MEntityOrderItemStep>();
                    var step = GetCloneStep(targetItem, rootStep, mgmtCase);
                    if(step!=null) listSteps.Add(step);
                    if (listSteps.Count > 0)
                    {
                        var v = Save(targetItem?.Id, listSteps, true);
                        if (!v) isPass = false;
                    }
                    Msg.ShowInfo($"Đã {caseName} răng {targetItem.ProductServiceTargetName}", true);
                }
                if (isPass)
                {
                    UpdateRootItem(item);
                    Msg.ShowInfo($"Đang tải lại danh sách...", true);
                    EndSave();
                    Msg.ShowInfo($"Hoàn thành!", true);
                }
               
                CloseLoading();
            }
        }

        private void OnApplyToOthersTeeth(MEntityOrderItem item, EMgmtCase mgmtCase)
        {
            var orderId = item.OrderId;
            var items = WorkingOrderItems;
            var rootStep = SelectedOrderItemStep;
            if (string.IsNullOrWhiteSpace(rootStep.ReferenceCode))
            {
                rootStep.ReferenceCode = Guid.NewGuid().ToString();
            }
            var targetItems = items.Where(x => x.ProductServiceId == item.ProductServiceId && x.ProductServiceTargetFinalIds != item.ProductServiceTargetFinalIds).ToList();
            if (items != null) {
                var teeths = ListTeeth.Where(t=> targetItems.Any(i=> i.ProductServiceTargetFinalIds==t.Id)).ToList();
                ShowTeethForm(teeths, (rs) => {
                    var caseName = GetCaseName(mgmtCase);
                    var names = GetToothFromTeeth(rs)?.Name;
                    if (Msg.IsAgree($"Bạn có muốn {caseName} nội dung cho các răng {names} cho giống răng {item?.ProductServiceTargetName}"))
                    {
                        ShowLoading();
                        var isPass = true;
                        foreach (var tooth in rs)
                        {
                            if(tooth.Id!= item.ProductServiceTargetFinalIds)
                            {
                                targetItems = items.Where(x => x.ProductServiceId == item.ProductServiceId && x.ProductServiceTargetFinalIds == tooth.Id).ToList();
                                foreach (var targetItem in targetItems)
                                {
                                    Msg.ShowInfo($"Đang {caseName} răng {tooth.Name}...", true);
                                    var listSteps = new List<MEntityOrderItemStep>();
                                    var step = GetCloneStep(targetItem, rootStep, mgmtCase);
                                    if (step != null) listSteps.Add(step);
                                    if (listSteps.Count > 0)
                                    {
                                      
                                        var v = Save(targetItem?.Id, listSteps, true);
                                        if (!v) isPass = false;
                                    }
                                    Msg.ShowInfo($"Đã {caseName} răng {tooth.Name}!", true);
                                }
                            }
                           
                        }
                        if (isPass)
                        {
                            UpdateRootItem(item);
                            Msg.ShowInfo($"Đang tải lại danh sách...", true);
                            EndSave();
                            Msg.ShowInfo($"Hoàn thành!", true);
                        }
                      
                        CloseLoading();
                    }
                  
                });
            }
        }

        private void ShowTeethForm(List<MEntityTooth> teeth, Action<List<MEntityTooth>> act)
        {
            var oTeeth = GuiIoc.GetInstance<Form>(EFormMgmt.FShowTeeth.ToString());
            var iTeeth = oTeeth as IFShowTeeth;
            if (iTeeth != null)
            {
                iTeeth.IsDisableOthersTeeth = true;
                iTeeth.SelectedTeeth = teeth;
                oTeeth.ShowDialog();
                act?.Invoke(iTeeth.SelectedTeeth);
            }
        }

        private MEntityTooth GetToothFromTeeth(List<MEntityTooth> teeth)
        {
            teeth = teeth.Where(x => !string.IsNullOrWhiteSpace(x.ID) && !string.IsNullOrWhiteSpace(x.Name)).ToList();
            return new MEntityTooth()
            {
                ID = string.Join(", ", teeth.Select(x => x.Id).ToList()),
                Name = string.Join(", ", teeth.Select(x => x.Name).ToList()),
                IsActive = true
            };
        }
    }
}
