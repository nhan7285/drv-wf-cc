using System;
using System.Drawing;
using System.Windows.Forms;
using VegunSoft.App.Data.Business;
using VegunSoft.App.Service.Mgmt;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums;
using VegunSoft.Framework.Gui.Enums.Image;
using VegunSoft.Framework.Gui.Provider.WindowsForms;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Services;
using VegunSoft.Framework.Gui.Services;
using VegunSoft.Framework.Ioc;
using VegunSoft.Layer.Gui.Custome.Receipt;

namespace VegunSoft.Layer.UcControl.Customer.Provider.Methods
{
    public static class MethodsMenuReceipt
    {
        public static ToolStripItem AddShowReceiptMenuItem(this Control sender, IContextMenuService svc, Func<string> getCustomerIdFunc, Func<ToolStripItem, bool> checkVisibleFunc, Func<bool> checkIsReadOnlyFunc,
            EFormDisplayType type = EFormDisplayType.Dialog, bool isDirectMode = true)
        {
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var iconService = guiIoc.GetInstance<IIconService>();
            return svc.AddItem("Xem giao diện PHIẾU THU", iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Devide16), (s, e) => OnShowReceipt(sender, getCustomerIdFunc, checkIsReadOnlyFunc, type, isDirectMode), checkVisibleFunc);
        }

        private static void OnShowReceipt(Control sender, Func<string> getCustomerIdFunc, Func<bool> checkIsReadOnlyFunc, EFormDisplayType type, bool isDirectMode = true)
        {
            XLoading.ShowLoading();
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var customerId = getCustomerIdFunc.Invoke();
            var f = guiIoc.GetInstance<Form>(EFormMgmt.FMainReceipts.ToString());

            if (f != null && f is IFReceipts form)
            {
                form.StartCustomerId = customerId;
                form.IsStartDirect = isDirectMode;

                var mgmt = XForm.GetInstance<IFormMgmt>(sender);
                mgmt.ShowForm<Form>(f, type, false);

            }
            XLoading.CloseLoading();
        }
    }
}
