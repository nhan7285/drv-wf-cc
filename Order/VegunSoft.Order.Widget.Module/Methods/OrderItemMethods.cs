using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using VegunSoft.Framework.Db.Enums.Data;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Provider.WindowsForms;
using VegunSoft.Framework.Ioc;
using VegunSoft.Message.Service.App;
using VegunSoft.Order.Entity.Business.EntityOrderItem;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;
using VegunSoft.Session.Service.User;

namespace VegunSoft.Layer.UcService.Provider.Methods
{
    public static class OrderItemMethods
    {
        public static void ApplyOrderItemStyle(this GridView gridView)
        {
            gridView.RowCellStyle += (sender, e) =>
            {
                if (gridView.GetRow(e.RowHandle) is IEntityOrderItemBusiness item)
                {
                    if (item.IsTemporary)
                    {
                        e.Appearance.ForeColor = Color.ForestGreen;
                    }
                    if (item.IsChanged)
                    {
                        if (item.IsLinkingOld)
                        {
                            e.Appearance.ForeColor = Color.Red;
                        }

                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Strikeout);
                    }
                    else if (item.IsLinkingNew)
                    {
                        e.Appearance.ForeColor = Color.Red;
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Underline);
                    }

                    if (item.IsChanging)
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Italic);
                        e.Appearance.ForeColor = Color.Purple;
                    }
                    if (item.IsChangingSteps)
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Italic);
                        e.Appearance.ForeColor = Color.Chartreuse;
                    }
                    if (item.IsFinish)
                    {
                        //e.Appearance.ForeColor = Color.DarkGray;
                        // e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.);
                    }
                    if (!item.IsFinish && !item.IsTemporary && !item.IsChanged)
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        // e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.);
                    }
                    if (item.HasCommission)
                    {
                        e.Appearance.BackColor = Color.FromArgb(255, 230, 255);
                        // e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.);
                    }
                    if (item.IsDeleted)
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Strikeout);
                        if (!item.IsTemporary)
                        {
                            e.Appearance.ForeColor = Color.LightGray;
                        }
                    }
                }
            };
        }

        public static void OnOrderItemShowingEditor(this GridView view, CancelEventArgs e, Dictionary<MEntityOrderItem, List<MEntityOrderItemStep>> dict, params GridColumn[] columns)
        {
            var isTarget = columns != null && columns.Length > 0 && columns.Contains(view.FocusedColumn);
            if (view.GetRow(view.FocusedRowHandle) is MEntityOrderItem model && model.Action!=EMgmtCase.Insert)
            {
                var kv = dict.FirstOrDefault(k => k.Key == model);
                var hasSteps = kv.Value != null && kv.Value.Count > 0;
                if (model.IsArisingService == false || model.IsFinish || hasSteps) e.Cancel = isTarget;
            }
        }

        public static void OnOrderItemShowingEditorService(this GridView view, CancelEventArgs e, params GridColumn[] columns)
        {
            var isTarget = columns != null && columns.Length > 0 && columns.Contains(view.FocusedColumn);
            if (view.GetRow(view.FocusedRowHandle) is MEntityOrderItem model && (model.IsFinish || model.IsInProgress))
            {
                e.Cancel = isTarget;
                return;

            }
            e.Cancel = false;
        }

        public static void OnOrderItemShowingEditor(this GridView view, CancelEventArgs e, params GridColumn[] columns)
        {
            //var isTarget = columns != null && columns.Length > 0 && columns.Contains(view.FocusedColumn);
            //var model = view.GetRow(view.FocusedRowHandle) as MEntityOrderItem;
            //if (model != null && (model.IsArisingService == false || model.IsFinish))
            //{
            //    if (model.Action == EMgmtCase.Insert || model.Action == EMgmtCase.Update)
            //        e.Cancel = false;
            //    else if (isTarget)
            //        e.Cancel = true;
            //    else
            //        e.Cancel = false;
            //    return;

            //}

            //var kv = dict.FirstOrDefault(k => k.Key == model);
            //if (kv.Value == null || kv.Value.Count <= 0) return;
            //if (model != null && (model.Action == EMgmtCase.Insert || model.Action == EMgmtCase.Update))
            //    e.Cancel = false;
            //e.Cancel = isTarget;
            var isTarget = columns != null && columns.Length > 0 && columns.Contains(view.FocusedColumn);
            if (!isTarget) //if the columns is not
            {
                e.Cancel = false;
                return;
            }
            var model = view.GetRow(view.FocusedRowHandle) as MEntityOrderItem;
            //model can be null or not, if model == null => e.Cancel =true; return;
            if (model.Action != EMgmtCase.Insert && model.Action != EMgmtCase.Update)
            {
                e.Cancel = true;
                return;
            }
            //if (model.IsArisingService || model.IsFinish)){e.Cancel=true; return;}
            //if (model.IsFinish){ e.Cancel = true; return; }

            e.Cancel = false;
           
            
        }

        public static void DeleteOrderItem(this GridView view, bool isReadOnly, string formName, Action<MEntityOrderItem> afterDeleteAction)
        {
            var checkRightsService = XIoc.GetService(CGui.IocKey).GetInstance<ICheckRightsService>();
            var messageService = XIoc.GetService(CGui.IocKey).GetInstance<IAppMessage>();
            if (isReadOnly)
            {
                messageService.ShowError("Bạn chỉ có quyền xem!");
                return;
            }
            var item = view.GetFocusedRow() as MEntityOrderItem;
            var sessionCode = XForm.GetSessionCode(view?.GridControl);
            if (item == null || (item.IsSaved && !checkRightsService.CheckCanDelete(sessionCode, formName, true))) return;
            if (messageService.IsAgree("Bạn có chắc chắn muốn xóa thông tin này không?"))
            {
                item.Action = EMgmtCase.Delete;
                afterDeleteAction?.Invoke(item);
            }
        }

        public static void DeleteOrderItem(this GridView view, bool isReadOnly,
            Dictionary<MEntityOrderItem, List<MEntityOrderItemStep>> dict, string formName, Action<MEntityOrderItem> afterDeleteAction)
        {
            var checkRightsService = XIoc.GetService(CGui.IocKey).GetInstance<ICheckRightsService>();
            var messageService = XIoc.GetService(CGui.IocKey).GetInstance<IAppMessage>();
            if (isReadOnly)
            {
                messageService.ShowError("Bạn chỉ có quyền xem!");
                return;
            }
            var item = view.GetFocusedRow() as MEntityOrderItem;
            var sessionCode = XForm.GetSessionCode(view?.GridControl);
            if (item == null || (item.IsSaved && !checkRightsService.CheckCanDelete(sessionCode, formName, true))) return;
            if (item.IsArisingService)
            {
                var kv = dict.FirstOrDefault(k => k.Key == item);
                if (kv.Value != null && kv.Value.Count == 0 || kv.Value == null)
                {
                    if (messageService.IsAgree("Bạn có chắc chắn muốn xóa thông tin này không?"))
                    {
                        item.Action = EMgmtCase.Delete;
                        afterDeleteAction?.Invoke(item);
                    }
                }
                else
                {
                    messageService.ShowWarning("Không thể xóa dòng dữ liệu này!");
                }

            }
            else
            {
                messageService.ShowWarning("Không thể xóa dòng dữ liệu này, vui lòng qua giao diện Chốt Sale!");
            }
        }
    }
}
