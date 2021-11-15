using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VegunSoft.Any.Data.Enums.Msg;
using VegunSoft.Base.Entity.Provider.Base;
using VegunSoft.Base.Entity.Provider.Format;
using VegunSoft.Customer.Data.Enums.Status;
using VegunSoft.Customer.Entity.Profile;
using VegunSoft.Customer.Repository.Business;
using VegunSoft.Customer.Widget.Forms;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums.Image;
using VegunSoft.Framework.Gui.Services;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Methods;
using VegunSoft.Message.Service.App;
using VegunSoft.Session.Repository.Business;

namespace VegunSoft.Customer.View.Service.Methods
{
    public static class ContextMenuStripMethods
    {
        public static List<ToolStripItem> AddStatusMenuItems<T>(this ContextMenuStrip menu,
          GridView gridView, Func<MEntityDataAdapter> getCustomerFunc, Form owner, List<T> items, Action<ICustomerItem, MEntityFormatFontColor> setCustomerStatusAction, Func<ICustomerItem, string> getNoteFunc, Action<ICustomerItem, string> setNoteFunc) where T : MEntityFormatFontColor
        {

            var iconService = XIoc.GetService(CGui.IocKey).GetInstance<IIconService>();

            var li = new List<ToolStripItem>();

            foreach (var item in items.OrderBy(x => x.DisplayPriority).ThenBy(x => x.No).ToList())
            {
                //var image = CustomerStatusFromOrdersMenuItemImages.ContainsKey(item)
                //    ? CustomerStatusFromOrdersMenuItemImages[item]
                //    : EResourceImage16.Status16;
                var image = EResourceImage16.Status16;
                var menuItem = menu.Items.Add(item.Caption);
                menuItem.Tag = item;
                menuItem.Image = iconService.GetIcon16<EResourceImage16, Image>(image);
                menuItem.Click += (sender, args) =>
                {
                    CustomerStatusFromOrdersMenuItemOnClick(sender, gridView, getCustomerFunc, owner, setCustomerStatusAction, getNoteFunc, setNoteFunc);

                };
                li.Add(menuItem);
            }

            return li;
        }

        public static List<ToolStripItem> AddStatusMenuItems<T>(this ContextMenuStrip menu,
          Func<GridView> getRridViewFunc, Func<MEntityDataAdapter> getCustomerFunc, Form owner, List<T> items, Action<ICustomerItem, MEntityFormatFontColor> setCustomerStatusAction, Func<ICustomerItem, string> getNoteFunc, Action<ICustomerItem, string> setNoteFunc) where T : MEntityFormatFontColor
        {

            var iconService = XIoc.GetService(CGui.IocKey).GetInstance<IIconService>();

            var li = new List<ToolStripItem>();
            if (items != null)
                foreach (var item in items.OrderBy(x => x.DisplayPriority).ThenBy(x => x.No).ToList())
                {
                    //var image = CustomerStatusFromOrdersMenuItemImages.ContainsKey(item)
                    //    ? CustomerStatusFromOrdersMenuItemImages[item]
                    //    : EResourceImage16.Status16;
                    var image = EResourceImage16.Status16;
                    var menuItem = menu.Items.Add(item.Caption);
                    menuItem.Tag = item;
                    menuItem.Image = iconService.GetIcon16<EResourceImage16, Image>(image);
                    menuItem.Click += (sender, args) =>
                    {
                        CustomerStatusFromOrdersMenuItemOnClick(sender, getRridViewFunc, getCustomerFunc, owner, setCustomerStatusAction, getNoteFunc, setNoteFunc);

                    };
                    li.Add(menuItem);
                }

            return li;
        }

        private static void CustomerStatusFromOrdersMenuItemOnClick(object sender, Func<GridView> getViewFunc,
    Func<MEntityDataAdapter> getCustomerFunc, Form owner, Action<ICustomerItem, MEntityFormatFontColor> setCustomerStatusAction, Func<ICustomerItem, string> getNoteFunc, Action<ICustomerItem, string> setNoteFunc)
        {
            var dbIoc = XIoc.GetService(CDb.IocKey);
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var messageService = guiIoc.GetInstance<IAppMessage>();
            var repositoryCustomer = dbIoc.GetInstance<IRepositoryCustomer>();
            var sessionRepository = dbIoc.GetInstance<IRepositorySession>();
            var row = getCustomerFunc?.Invoke();
            var mni = sender as ToolStripItem;
            if (mni == null) return;
            var item = mni.Tag as MEntityFormatFontColor;

            if (row == null)
            {
                messageService.ShowInfo(EMessageError.GridPleaseSelectRow.GetLanguageText());
                return;
            }



            var customerId = row?.Id;
            var customerCode = row?.DisplayKey ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(customerId))
            {
                var customer = repositoryCustomer.Find(customerId);
                if (customer != null)
                {
                    sessionRepository.ApplyUpdatedBasicFields(customer, repositoryCustomer.GetDateTime());
                    var f = guiIoc.GetInstance<IFormChangeStatus>();
                    if (f != null)
                    {
                        var oldNote = getNoteFunc.Invoke(customer);
                        var newNote = item?.Id == customer.CustomerStatusId ? oldNote : string.Empty;
                        f.ShowPopup(owner, customer.DisplayName, item?.Caption, oldNote, newNote);
                        if (f.IsSave)
                        {
                            XLoading.ShowLoading();
                            setNoteFunc?.Invoke(customer, f.Note);

                            setCustomerStatusAction?.Invoke(customer, item);
                            var rs = repositoryCustomer.Update(customer);
                            if (rs > 0)
                            {
                                var view = getViewFunc?.Invoke();
                                if (row.FromModel is ICustomerItem c) setCustomerStatusAction?.Invoke(c, item);
                                view?.RefreshData();
                            }
                            XLoading.CloseLoading();
                        }

                    }
                }
                else
                {
                    messageService.ShowError($"Không tìm thấy khách hàng nào có mã: {customerCode}");
                }

            }
            else
            {
                messageService.ShowError($"Không tìm thấy khách hàng có mã: {customerCode}");
            }


        }

        private static void CustomerStatusFromOrdersMenuItemOnClick(object sender, GridView gridView,
     Func<MEntityDataAdapter> getCustomerFunc, Form owner, Action<ICustomerItem, MEntityFormatFontColor> setCustomerStatusAction, Func<ICustomerItem, string> getNoteFunc, Action<ICustomerItem, string> setNoteFunc)
        {
            var dbIoc = XIoc.GetService(CDb.IocKey);
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var messageService = guiIoc.GetInstance<IAppMessage>();
            var repositoryCustomer = dbIoc.GetInstance<IRepositoryCustomer>();
            var sessionRepository = dbIoc.GetInstance<IRepositorySession>();
            var row = getCustomerFunc?.Invoke();
            var mni = sender as ToolStripItem;
            if (mni == null) return;
            var item = mni.Tag as MEntityFormatFontColor;

            if (row == null)
            {
                messageService.ShowInfo(EMessageError.GridPleaseSelectRow.GetLanguageText());
                return;
            }



            var customerId = row?.Id;
            var customerCode = row?.DisplayKey ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(customerId))
            {
                var customer = repositoryCustomer.Find(customerId);
                if (customer != null)
                {
                    sessionRepository.ApplyUpdatedBasicFields(customer, repositoryCustomer.GetDateTime());
                    var f = guiIoc.GetInstance<IFormChangeStatus>();
                    if (f != null)
                    {
                        var oldNote = getNoteFunc.Invoke(customer);
                        var newNote = item?.Id == customer.CustomerStatusId ? oldNote : string.Empty;
                        f.ShowPopup(owner, customer.DisplayName, item?.Caption, oldNote, newNote);
                        if (f.IsSave)
                        {
                            XLoading.ShowLoading();
                            setNoteFunc?.Invoke(customer, f.Note);

                            setCustomerStatusAction?.Invoke(customer, item);
                            var rs = repositoryCustomer.Update(customer);
                            if (rs > 0)
                            {
                                if (row.FromModel is ICustomerItem c) setCustomerStatusAction?.Invoke(c, item);
                                gridView?.RefreshData();
                            }
                            XLoading.CloseLoading();
                        }

                    }
                }
                else
                {
                    messageService.ShowError($"Không tìm thấy khách hàng nào có mã: {customerCode}");
                }

            }
            else
            {
                messageService.ShowError($"Không tìm thấy khách hàng có mã: {customerCode}");
            }


        }

        public static ToolStripItem AddHasNeedStatusMenuItem<T>(this ContextMenuStrip menu,
          GridView gridView, Func<MEntityDataAdapter> getCustomerFunc, Form owner, T item, Action<ICustomerItem, MEntityFormatFontColor> setCustomerStatusAction, string formName) where T : MEntityFormatFontColor
        {

            var iconService = XIoc.GetService(CGui.IocKey).GetInstance<IIconService>();

            var li = new List<ToolStripItem>();
            var image = EResourceImage16.Status16;
            var menuItem = menu.Items.Add(item.Caption);
            menuItem.Tag = item;
            menuItem.Image = iconService.GetIcon16<EResourceImage16, Image>(image);
            menuItem.Click += (sender, args) =>
            {
                CustomerHasNeedMenuItemOnClick(sender, gridView, getCustomerFunc, owner, setCustomerStatusAction, formName);

            };

            return menuItem;
        }

        private static void CustomerHasNeedMenuItemOnClick(object sender, GridView gridView,
     Func<MEntityDataAdapter> getCustomerFunc, Form owner, Action<ICustomerItem, MEntityFormatFontColor> setCustomerStatusAction, string formName)
        {
            var dbIoc = XIoc.GetService(CDb.IocKey);
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var messageService = guiIoc.GetInstance<IAppMessage>();
            var repositoryCustomer = dbIoc.GetInstance<IRepositoryCustomer>();
            var sessionRepository = dbIoc.GetInstance<IRepositorySession>();
            var row = getCustomerFunc?.Invoke();
            var mni = sender as ToolStripItem;
            if (mni == null) return;
            var item = mni.Tag as MEntityFormatFontColor;

            if (row == null)
            {
                messageService.ShowInfo(EMessageError.GridPleaseSelectRow.GetLanguageText());
                return;
            }



            var customerId = row?.Id;
            var customerCode = row?.DisplayKey ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(customerId))
            {
                var customer = repositoryCustomer.Find(customerId);
                if (customer != null)
                {
                    var f = guiIoc.GetInstance<IInputCustomerNeeds>();
                    if (f != null)
                    {
                        f.Init(formName);
                        var oldNote = customer.NeedNote;
                        var newNote = oldNote ?? string.Empty;
                        f.ShowPopup(owner, customer, item?.Caption, oldNote, newNote, false);
                        if (f.IsSave)
                        {
                            XLoading.ShowLoading();
                            sessionRepository.ApplyUpdatedBasicFields(customer, repositoryCustomer.GetDateTime());
                            customer.NeedNote = f.Note;
                            setCustomerStatusAction?.Invoke(customer, item);
                            var rs = repositoryCustomer.Update(customer);
                            if (rs > 0)
                            {
                                if (row.FromModel is ICustomerItem c) setCustomerStatusAction?.Invoke(c, item);
                                gridView?.RefreshData();
                            }
                            XLoading.CloseLoading();
                        }

                    }
                }
                else
                {
                    messageService.ShowError($"Không tìm thấy khách hàng nào có mã: {customerCode}");
                }

            }
            else
            {
                messageService.ShowError($"Không tìm thấy khách hàng có mã: {customerCode}");
            }


        }

        public static ToolStripItem AddNoNeedStatusMenuItem<T>(this ContextMenuStrip menu,
            GridView gridView, Func<MEntityDataAdapter> getCustomerFunc, Form owner, T item, Action<ICustomerItem, MEntityFormatFontColor> setCustomerStatusAction) where T : MEntityFormatFontColor
        {

            var iconService = XIoc.GetService(CGui.IocKey).GetInstance<IIconService>();

            var li = new List<ToolStripItem>();
            var image = EResourceImage16.Status16;
            var menuItem = menu.Items.Add(item.Caption);
            menuItem.Tag = item;
            menuItem.Image = iconService.GetIcon16<EResourceImage16, Image>(image);
            menuItem.Click += (sender, args) =>
            {
                CustomerNoNeedMenuItemOnClick(sender, gridView, getCustomerFunc, owner, setCustomerStatusAction);

            };

            return menuItem;
        }

        private static void CustomerNoNeedMenuItemOnClick(object sender, GridView gridView,
        Func<MEntityDataAdapter> getCustomerFunc, Form owner, Action<ICustomerItem, MEntityFormatFontColor> setCustomerStatusAction)
        {
            var dbIoc = XIoc.GetService(CDb.IocKey);
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var messageService = guiIoc.GetInstance<IAppMessage>();
            var repositoryCustomer = dbIoc.GetInstance<IRepositoryCustomer>();
            var sessionRepository = dbIoc.GetInstance<IRepositorySession>();
            var row = getCustomerFunc?.Invoke();
            var mni = sender as ToolStripItem;
            if (mni == null) return;
            var item = mni.Tag as MEntityFormatFontColor;

            if (row == null)
            {
                messageService.ShowInfo(EMessageError.GridPleaseSelectRow.GetLanguageText());
                return;
            }



            var customerId = row?.Id;
            var customerCode = row?.DisplayKey ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(customerId))
            {
                var customer = repositoryCustomer.Find(customerId);
                if (customer != null)
                {


                    sessionRepository.ApplyUpdatedBasicFields(customer, repositoryCustomer.GetDateTime());
                    var f = guiIoc.GetInstance<IFormChangeStatus>();
                    if (f != null)
                    {
                        var oldNote = customer.NeedNote;
                        var newNote = oldNote ?? string.Empty;
                        f.ShowPopup(owner, customer.DisplayName, item?.Caption, oldNote, newNote);
                        if (f.IsSave)
                        {
                            XLoading.ShowLoading();
                            customer.NeedNote = f.Note;
                            setCustomerStatusAction?.Invoke(customer, item);
                            var rs = repositoryCustomer.Update(customer);
                            if (rs > 0)
                            {
                                if (row.FromModel is ICustomerItem c) setCustomerStatusAction?.Invoke(c, item);
                                gridView?.RefreshData();
                            }
                            XLoading.CloseLoading();
                        }

                    }
                }
                else
                {
                    messageService.ShowError($"Không tìm thấy khách hàng nào có mã: {customerCode}");
                }

            }
            else
            {
                messageService.ShowError($"Không tìm thấy khách hàng có mã: {customerCode}");
            }


        }

        public static void CheckShowCustomerGlobalStatusItems(this ToolStripItem item, string key, bool hasSelectedRow)
        {
            if (!hasSelectedRow) return;
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
                var status = item.Tag is ECustomerStatusGlobal ? (ECustomerStatusGlobal)item.Tag : ECustomerStatusGlobal.Unknown;
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
        public static void CheckShowCustomerGlobalStatusItems(this List<ToolStripItem> items, bool hasSelectedRow, string key)
        {
            foreach (var item in items)
            {
                var v = hasSelectedRow;
                if (v) item.CheckShowCustomerGlobalStatusItems(key, hasSelectedRow);
                item.Visible = v;
            }
        }
    }
}
