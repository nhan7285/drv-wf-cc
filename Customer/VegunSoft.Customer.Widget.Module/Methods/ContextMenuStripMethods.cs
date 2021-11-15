using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using VegunSoft.Acc.Entity.Acc;
using VegunSoft.Any.Data.Enums.Msg;
using VegunSoft.App.Data.Business;
using VegunSoft.App.Service.Mgmt;
using VegunSoft.Base.Entity.Provider.Base;
using VegunSoft.Base.Entity.Provider.Format;
using VegunSoft.Customer.Data.Enums.Status;
using VegunSoft.Customer.Entity.Business;
using VegunSoft.Customer.Entity.Profile;
using VegunSoft.Customer.Entity.Provider.Categories;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Customer.Repository.Business;
using VegunSoft.Customer.Repository.Categories;
using VegunSoft.Customer.View.Forms;
using VegunSoft.Customer.Widget.Forms;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Db.Models;
using VegunSoft.Framework.Db.Services;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums;
using VegunSoft.Framework.Gui.Enums.Image;
using VegunSoft.Framework.Gui.Provider.WindowsForms;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Services;
using VegunSoft.Framework.Gui.Services;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Framework.Methods;
using VegunSoft.Labo.Entity.Category;
using VegunSoft.Layer.Gui.Forms;
using VegunSoft.Layer.UcService.Provider.Any;
using VegunSoft.Layer.UcService.Provider.Services;
using VegunSoft.Message.Service.App;
using VegunSoft.Order.Entity.Business.EntityLabo;
using VegunSoft.Order.Repository.Business.Contract;
using VegunSoft.Schedule.Entity.Provider.Cards;
using VegunSoft.Schedule.Repository.Business;
using VegunSoft.Session.Repository.Business;

namespace VegunSoft.Layer.UcService.Provider.Methods
{
    public static class ContextMenuStripMethods
    {
       
        private static IIocService DbIoc => XIoc.GetService(CDb.IocKey);
        private static IRepositoryCustomerCategoryNote RepositoryCustomerCategoryNote => DbIoc.GetInstance<IRepositoryCustomerCategoryNote>();

       

        public static void UpdateItemText(this ToolStripItem menuItem, Func<MEntityDataAdapter> getCustomerFunc)
        {
            var dbIoc = XIoc.GetService(CDb.IocKey);
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var messageService = guiIoc.GetInstance<IAppMessage>();
            var iconService = guiIoc.GetInstance<IIconService>();
            //var repositoryCustomer = dbIoc.GetInstance<IRepositoryCustomer>();

            var row = getCustomerFunc?.Invoke();
            if (row == null)
            {
                messageService.ShowInfo("Vui lòng chọn 1 dòng để xem lịch sử điều trị");
                menuItem.Text = "Xem lịch lịch hẹn";
                return;
            }
            var repositoryApmt = dbIoc.GetInstance<IRepositoryAppointment>();
            var customerId = row?.Id;

            var nowDateTime = repositoryApmt.GetDateTime();
            var nowDate = nowDateTime.Date;

            var appointments = repositoryApmt.FindWaitingCheckingBookings<MEntityAppointment>(customerId);
            var currentAppointments = appointments
               .Where(a => a.BeginDateTime.HasValue && a.BeginDateTime.Value.Date == nowDate && a.BeginDateTime.Value.Date < nowDate.AddDays(1)).ToList();
            var featureAppointments = appointments
               .Where(a => a.BeginDateTime.HasValue && a.BeginDateTime.Value.Date >= nowDate.AddDays(1)).ToList();
            menuItem.Text = $"Xem lịch lịch hẹn của {row.DisplayKey}: {currentAppointments.Count} / {featureAppointments.Count}";
            //var apt = featureAppointments.FirstOrDefault() ?? currentAppointments.FirstOrDefault();
        }

        public static ToolStripItem AddCustomerShowApmtMenuItem(this Control c, ContextMenuStrip menu, Func<MEntityDataAdapter> getCustomerFunc, EFormDisplayType type = EFormDisplayType.Dialog)
        {
            var dbIoc = XIoc.GetService(CDb.IocKey);
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var messageService = guiIoc.GetInstance<IAppMessage>();
            var iconService = guiIoc.GetInstance<IIconService>();
            var repositoryCustomer = dbIoc.GetInstance<IRepositoryCustomer>();

            var minItem = menu.Items.Add("Xem lịch lịch hẹn");
            minItem.Image = iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Status16);
            minItem.Click += (sender, args) =>
            {
                var row = getCustomerFunc?.Invoke();
                if (row == null)
                {
                    messageService.ShowInfo("Vui lòng chọn 1 dòng để xem lịch hẹn");
                    return;
                }
                var repositoryApmt = dbIoc.GetInstance<IRepositoryAppointment>();
                var customerId = row?.Id;
                var customer = repositoryCustomer.Find(customerId);
                var customerNo = customer.No;
                var customerCode = customer.Code;
                var customerDisplayCode = customer.DisplayCode;
                var customerName = customer.FullName;
                var nowDateTime = repositoryApmt.GetDateTime();
                var nowDate = nowDateTime.Date;

                var appointments = repositoryApmt.FindWaitingCheckingBookings<MEntityAppointment>(customerId);
                var currentAppointments = appointments
                   .Where(a => a.BeginDateTime.HasValue && a.BeginDateTime.Value.Date == nowDate).ToList();
                var featureAppointments = appointments
                   .Where(a => a.BeginDateTime.HasValue && a.BeginDateTime.Value.Date >= nowDate.AddDays(1)).ToList();

                var apt = featureAppointments.FirstOrDefault() ?? currentAppointments.FirstOrDefault();
                ApmtWidgetsService.ShowTreatmentAppointmentFormWithGridCustomer(true, new MEntityGridCustomer(customer), apt?.BeginDateTime ?? nowDateTime);
                //ShowHistoriesForm(c, type, f => { f.Init(customerId, customerDisplayCode, customerName, row.AdvancedId, row.AdvancedId2, row.AdvancedId3, row.AdvancedId4); });
            };
            return minItem;
        }

      

        public static List<ToolStripItem> AddCustomerNotesItems<T, TRepo>(this ContextMenuStrip menu,
            Func<GridView> getGridViewFunc, Func<T> getModelFunc, ITableRepository<TRepo> repo = null)
            where T : class, ICustomerNotes, new()
            where TRepo : class, ICustomerNotes, new()
        {
            Action<T, string> act = repo != null ? ((transfer, noteContent) =>
            {
                var s = repo.Find(transfer?.Id);
                if (s != null)
                {
                    s.CustomerNotes = noteContent;
                    var rs = repo.Update(s);
                    if (rs > 0)
                    {
                        getGridViewFunc?.Invoke()?.RefreshData();
                    }
                    else
                    {
                        XIoc.GetService(CGui.IocKey).GetInstance<IAppMessage>().ShowWarning("Có lỗi khi lưu ghi chú, vui lòng thử lại!");
                    }
                }

            }) : null as Action<T, string>;
            var li = new List<ToolStripItem>();
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var iconService = XIoc.GetService(CGui.IocKey).GetInstance<IIconService>();
            var addMni = menu.Items.Add("Viết ghi chú khách hàng");
            addMni.Image = iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Add16);
            addMni.Click += (s, e) => guiIoc.GetInstance<IFCustomerNote>()?.ShowDialog(getModelFunc.Invoke(), act, null);
            li.Add(addMni);
            var notes = RepositoryCustomerCategoryNote.Where(nameof(MEntityCustomerCategoryNote.IsActive), true).Where(x => !x.IsDeleted).ToList();
            foreach (var note in notes)
            {
                var mniAddNote = menu.Items.Add($"{note.Name}");
                mniAddNote.Image = iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Add16);
                //mniAddNote.Click += (s, e) => guiIoc.GetInstance<IFCustomerNote>()?.ShowDialog(getModelFunc.Invoke(), getGridViewFunc, repo, note);
                mniAddNote.Click += (s, e) => guiIoc.GetInstance<IFCustomerNote>()?.ShowDialog(getModelFunc.Invoke(), act, note);
                li.Add(mniAddNote);

            }
            return li;
        }

        public static void UpdateCustomerNotesItemsVisibility<T>(this List<ToolStripItem> items,
           Func<T> getModelFunc) where T : class, ICustomerNotes, new()
        {
            var hasCustomer = !string.IsNullOrWhiteSpace(getModelFunc?.Invoke()?.CustomerId);
            foreach (var item in items)
            {
                item.Visible = hasCustomer;
            }
        }

      
       

       



       


        public static List<ToolStripItem> AddStatusMenuItems<TStatusEntity, TTargetEntity>(this ContextMenuStrip menu, AddStatusMenuItemsArgs<TStatusEntity, TTargetEntity> a)
            where TStatusEntity : MEntityFormatFontColor
            where TTargetEntity : class, IModelBasic, ICanTakeCareModel, new()
        {
            var name = a.Name?.ToLower() ?? string.Empty;
            var caption = a.Caption ?? string.Empty;
            var label = a.Label ?? "Mục tiêu";
            var isResetNotes = a.IsResetNotes;
            var li = new List<ToolStripItem>();
            foreach (var status in a.Categories.OrderBy(x => x.DisplayPriority).ThenBy(x => x.No).ToList())
            {
                var menuItem = menu.Items.Add(status.Caption);
                menuItem.Tag = status;
                if (a.Icon != null)
                {
                    menuItem.Image = a.Icon;
                }
                menuItem.Click += (sender, args) =>
                {
                    var mni = sender as ToolStripItem;
                    var dbIoc = XIoc.GetService(CDb.IocKey);
                    var guiIoc = XIoc.GetService(CGui.IocKey);
                    var messageService = guiIoc.GetInstance<IAppMessage>();
                    var repository = a.Repository;
                    var sessionRepository = dbIoc.GetInstance<IRepositorySession>();
                    var row = a.GetDataAdapterFunc?.Invoke();
                    if (mni == null) return;
                    var item = mni.Tag as MEntityFormatFontColor;
                    if (row == null)
                    {
                        messageService.ShowInfo(EMessageError.GridPleaseSelectRow.GetLanguageText());
                        return;
                    }
                    var itemId = row?.Id;
                    var displayVal = row?.DisplayKey ?? string.Empty;
                    if (!string.IsNullOrWhiteSpace(itemId))
                    {
                        var entity = repository.Find(itemId);
                        if (entity != null)
                        {
                            sessionRepository.ApplyUpdatedBasicFields(entity, repository.GetDateTime());
                            var f = guiIoc.GetInstance<IFormChangeStatus>();
                            if (f != null)
                            {
                                f.SetText(caption, label);
                                var oldNote = entity.TakeCareStatusNote;
                                var newNote = isResetNotes ? (item?.Id == entity.TakeCareStatusId ? oldNote : string.Empty) : oldNote;
                                if (!string.IsNullOrWhiteSpace(newNote))
                                {
                                    newNote = newNote + Environment.NewLine + GetNewNoteFooter(sessionRepository.User) +
                                              Environment.NewLine;
                                }
                                else
                                {
                                    newNote = GetNewNoteFooter(sessionRepository.User) + Environment.NewLine;
                                }
                                f.ShowPopup(a.Owner, entity.FullDisplayName, item?.Caption, oldNote, newNote);
                                f.RevertText();
                                if (f.IsSave)
                                {
                                    XLoading.ShowLoading();

                                    entity.TakeCareStatusId = item?.Id;
                                    entity.TakeCareStatusName = item?.Name;
                                    entity.TakeCareStatusNote = f.Note;


                                    var rs = repository.Update(entity);
                                    if (rs > 0)
                                    {

                                        messageService.ShowUpdateSuccessInfo(name, true);
                                        a.SaveSuccessAction?.Invoke(entity, item);
                                        a.GridView?.RefreshData();
                                    }
                                    else
                                    {
                                        messageService.ShowUpdateErrorInfo(name);
                                        a.SaveFailAction?.Invoke(entity, item);
                                    }
                                    XLoading.CloseLoading();
                                }

                            }
                        }
                        else
                        {
                            messageService.ShowError($"Không tìm thấy {name}: {displayVal}");

                        }

                    }
                    else
                    {
                        messageService.ShowError($"Không tìm thấy {name}: {displayVal}");
                    }

                };
                li.Add(menuItem);
            }

            return li;
        }

        private static string GetNewNoteFooter(IEntityUserAccountMin acc)
        {
            var d = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            return $"--- Ngày: {d} - TK: {acc.Username} / {acc.FullName} ---";
        }

        public static List<ToolStripItem> AddMaterialStatusMenuItems<T>(this ContextMenuStrip menu,
            GridView gridView,
            Func<MEntityDataAdapter> getLaboFunc,
            Form owner, List<T> items,
            Action<ILaboStatus,
                MEntityFormatFontColor> setLaboStatusAction,
            Func<ILaboStatus, string> getNoteFunc,
            Action<ILaboStatus, string> setNoteFunc, Func<bool> checkAddNoteFunc, Func<bool> checkAutoSaveFunc) where T : MEntityFormatFontColor
        {

            var iconService = XIoc.GetService(CGui.IocKey).GetInstance<IIconService>();

            var li = new List<ToolStripItem>();

            foreach (var item in items.OrderBy(x => x.DisplayPriority).ThenBy(x => x.No).ToList())
            {

                var image = EResourceImage16.Status16;
                var menuItem = menu.Items.Add(item.Caption);
                menuItem.Tag = item;
                menuItem.Image = iconService.GetIcon16<EResourceImage16, Image>(image);
                menuItem.Click += (sender, args) =>
                {
                    MaterialStatusOnClick(sender, gridView, getLaboFunc, owner, setLaboStatusAction, getNoteFunc, setNoteFunc, checkAddNoteFunc, checkAutoSaveFunc);

                };
                li.Add(menuItem);
            }

            return li;
        }

        private static void MaterialStatusOnClick(object sender, GridView gridView,
       Func<MEntityDataAdapter> getLaboFunc,
       Form owner, Action<ILaboStatus,
           MEntityFormatFontColor> setLaboStatusAction,
       Func<ILaboStatus, string> getNoteFunc,
       Action<ILaboStatus, string> setNoteFunc, Func<bool> checkAddNoteFunc, Func<bool> checkAutoSaveFunc)
        {
            var autoSave = checkAutoSaveFunc?.Invoke() ?? true;
            var addNote = checkAddNoteFunc?.Invoke() ?? true;
            var dbIoc = XIoc.GetService(CDb.IocKey);
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var messageService = guiIoc.GetInstance<IAppMessage>();
            var laboRepository = dbIoc.GetInstance<IRepositoryOrderItemStepLabo>();
            var sessionRepository = dbIoc.GetInstance<IRepositorySession>();
            var row = getLaboFunc?.Invoke();
            var mni = sender as ToolStripItem;
            if (mni == null) return;
            var item = mni.Tag as MEntityFormatFontColor;

            if (row == null)
            {
                messageService.ShowInfo(EMessageError.GridPleaseSelectRow.GetLanguageText());
                return;
            }



            var laboId = row?.Id;
            var code = row?.DisplayKey ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(laboId))
            {
                var labo = laboRepository.Find(laboId);
                if (labo != null)
                {
                    if (autoSave) sessionRepository.ApplyUpdatedBasicFields(labo, laboRepository.GetDateTime());
                    if (addNote)
                    {
                        var f = guiIoc.GetInstance<IFormChangeStatus>();
                        if (f != null)
                        {
                            var oldNote = getNoteFunc.Invoke(labo);
                            //var newNote = item?.Id == labo.StatusId ? oldNote : string.Empty;
                            var newNote = oldNote;
                            f.ShowPopup(owner, labo.TreatmentDisplayContent, item?.Caption, oldNote, newNote);
                            if (f.IsSave)
                            {
                                if (autoSave) XLoading.ShowLoading();
                                setNoteFunc?.Invoke(labo, f.Note);

                                setLaboStatusAction?.Invoke(labo, item);
                                if (autoSave)
                                {
                                    var rs = laboRepository.Update(labo);
                                    if (rs > 0)
                                    {
                                        if (row.FromModel is ILaboStatus c) setLaboStatusAction?.Invoke(c, item);
                                        gridView?.RefreshData();
                                    }
                                }
                                else
                                {
                                    if (row.FromModel is ILaboStatus c) setLaboStatusAction?.Invoke(c, item);
                                    gridView?.RefreshData();
                                }


                                if (autoSave) XLoading.CloseLoading();
                            }

                        }
                    }
                    else
                    {
                        if (autoSave) XLoading.ShowLoading();
                        setLaboStatusAction?.Invoke(labo, item);
                        if (autoSave)
                        {
                            var rs = laboRepository.Update(labo);
                            if (rs > 0)
                            {
                                if (row.FromModel is ILaboStatus c) setLaboStatusAction?.Invoke(c, item);
                                gridView?.RefreshData();
                            }
                        }
                        else
                        {
                            if (row.FromModel is ILaboStatus c) setLaboStatusAction?.Invoke(c, item);
                            gridView?.RefreshData();
                        }

                        if (autoSave) XLoading.CloseLoading();
                    }

                }
                else
                {
                    messageService.ShowError($"Không tìm thấy labo: {code}");
                }

            }
            else
            {
                messageService.ShowError($"Không tìm thấy labo: {code}");
            }


        }

        public static void CheckShowStatusFormatItems(this List<ToolStripItem> items, bool hasSelectedRow, string key)
        {
            foreach (var item in items)
            {
                var v = hasSelectedRow;
                if (v)
                {
                    if (item.Tag is MEntityFormatFontColor ec)
                    {
                        var statusId = ec.Id;
                        if (statusId == key)
                        {
                            item.Font = new Font(item.Font, FontStyle.Underline);
                        }
                        else
                        {
                            item.Font = new Font(item.Font, FontStyle.Regular);
                        }
                    }

                }

                item.Visible = v;
            }
        }


        public static void CheckShowCustomerBatchStatusItems(this List<ToolStripItem> items, bool hasSelectedRow, string key)
        {
            foreach (var item in items)
            {
                var v = hasSelectedRow;
                if (v)
                {
                    if (item.Tag is MEntityFormatFontColor ec)
                    {
                        var statusId = ec.Id;
                        if (statusId == key)
                        {
                            item.Font = new Font(item.Font, FontStyle.Underline);
                        }
                        else
                        {
                            item.Font = new Font(item.Font, FontStyle.Regular);
                        }
                    }
                    else
                    {
                        var status = item.Tag is ECustomerStatusBatch ? (ECustomerStatusBatch)item.Tag : ECustomerStatusBatch.Unknown;
                        var statusId = status.GetId();
                        if (statusId == key)
                        {
                            item.Font = new Font(item.Font, FontStyle.Underline);
                        }
                        else
                        {
                            item.Font = new Font(item.Font, FontStyle.Regular);
                        }
                    }

                }

                item.Visible = v;
            }
        }

        public static ToolStripItem AddShowSendLaboMenuItem(this Control sender, IContextMenuService svc, Func<List<IResultOrderItemStepLabo>> getLaboFunc, Func<ToolStripItem, bool> checkVisibleFunc, Func<bool> checkIsReadOnlyFunc,
           EFormDisplayType type = EFormDisplayType.Dialog)
        {
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var iconService = guiIoc.GetInstance<IIconService>();
            return svc.AddItem("Xem danh sách GỬI LABO", iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Labo16), (s, e) => OnShowLabo(sender, getLaboFunc, checkIsReadOnlyFunc, type, EFormMgmt.FWorkflowSendLabo.ToString()), checkVisibleFunc);
        }


        public static ToolStripItem AddShowReceiveLaboMenuItem(this Control sender, IContextMenuService svc, Func<List<IResultOrderItemStepLabo>> getLaboFunc, Func<ToolStripItem, bool> checkVisibleFunc, Func<bool> checkIsReadOnlyFunc,
              EFormDisplayType type = EFormDisplayType.Dialog)
        {
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var iconService = guiIoc.GetInstance<IIconService>();
            return svc.AddItem("Xem danh sách NHẬN LABO", iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Labo16), (s, e) => OnShowLabo(sender, getLaboFunc, checkIsReadOnlyFunc, type, EFormMgmt.FWorkflowReceiveLabo.ToString()), checkVisibleFunc);
        }


        private static void OnShowLabo(Control sender, Func<List<IResultOrderItemStepLabo>> getLaboFunc, Func<bool> checkIsReadOnlyFunc, EFormDisplayType type, string formKey)
        {
            XLoading.ShowLoading();
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var labo = getLaboFunc.Invoke();
            var f = guiIoc.GetInstance<Form>(formKey);

            if (f is IFLabo fLabo)
            {
                fLabo.Init(labo, true);
                var mgmt = XForm.GetInstance<IFormMgmt>(sender);
                mgmt.ShowForm<Form>(f, type, false);
            }
            XLoading.CloseLoading();
        }
    }
}
