using System;
using System.Drawing;
using System.Windows.Forms;
using VegunSoft.App.Service.Mgmt;
using VegunSoft.Base.Entity.Provider.Base;
using VegunSoft.Customer.Repository.Business;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums;
using VegunSoft.Framework.Gui.Enums.Image;
using VegunSoft.Framework.Gui.Provider.WindowsForms;
using VegunSoft.Framework.Gui.Services;
using VegunSoft.Framework.Ioc;
using VegunSoft.Message.Service.App;
using VegunSoft.Order.View.Forms;

namespace VegunSoft.Order.View.Service.Dev.Methods
{
    public static class ContextMenuStripMethods
    {
        private static ITreatmentHistoryForm _historyForm;
        private static Form FHistory => _historyForm as Form;
        private static void ShowHistoriesForm(this Control sender, EFormDisplayType type, Action<ITreatmentHistoryForm> beforeShowAction = null)
        {
            XLoading.ShowLoading();
            CheckCreateHistoriesForm();
            if (FHistory.Visible) FHistory.Hide();
            FHistory.BringToFront();
            beforeShowAction?.Invoke(_historyForm);
            XLoading.CloseLoading();
            var mgmt = XForm.GetInstance<IFormMgmt>(sender);
            mgmt.ShowForm<Form>(FHistory, type, false);
            //FHistory.ShowDialog();
        }

        private static void CheckCreateHistoriesForm()
        {
            if (_historyForm != null) return;
            var guiIoc = XIoc.GetService(CGui.IocKey);
            _historyForm = guiIoc.GetInstance<ITreatmentHistoryForm>();
            FHistory.FormClosing += (sender, args) =>
            {

                FHistory.Hide();
                //LoadData();
                args.Cancel = true;

            };
            FHistory.StartPosition = FormStartPosition.CenterScreen;
        }

        public static ToolStripItem AddCustomerShowHistoryMenuItem(this Control c, ContextMenuStrip menu, Func<MEntityDataAdapter> getCustomerFunc, EFormDisplayType type = EFormDisplayType.Dialog)
        {
            var dbIoc = XIoc.GetService(CDb.IocKey);
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var messageService = guiIoc.GetInstance<IAppMessage>();
            var iconService = guiIoc.GetInstance<IIconService>();
            var repositoryCustomer = dbIoc.GetInstance<IRepositoryCustomer>();
            var showHistoriesItem = menu.Items.Add("Xem lịch sử điều trị");
            showHistoriesItem.Image = iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.History16);
            showHistoriesItem.Click += (sender, args) =>
            {
                var row = getCustomerFunc?.Invoke();
                if (row == null)
                {
                    messageService.ShowInfo("Vui lòng chọn 1 dòng để xem lịch sử điều trị");
                    return;
                }
                var customerId = row?.Id;
                var customer = repositoryCustomer.Find(customerId);
                var customerNo = customer.No;
                var customerCode = customer.Code;
                var customerDisplayCode = customer.DisplayCode;
                var customerName = customer.FullName;
                ShowHistoriesForm(c, type, f => { f.Init(customerId, customerDisplayCode, customerName, row.AdvancedId, row.AdvancedId2, row.AdvancedId3, row.AdvancedId4); });
            };
            return showHistoriesItem;
        }
    }
}
