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
using VegunSoft.Layer.Gui.Customer.Receipt;
using VegunSoft.Receipt.Entity.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.Methods
{
    public static class MethodsMenuReceiptRpt
    {

        public static ToolStripItem AddShowReceiptRptFormMenuItem(this Control sender, IContextMenuService svc, string rightName, Func<IEntityReceiptItemMin> getOrderItemFunc, Func<ToolStripItem, bool> checkVisibleFunc, Func<bool> checkIsReadOnlyFunc,
            EFormDisplayType type = EFormDisplayType.Dialog)
        {
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var iconService = guiIoc.GetInstance<IIconService>();
            return svc.AddItem("Xem báo cáo phiếu thu", iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Day16), (s, e) => OnShowReceiptRptForm(sender, rightName, getOrderItemFunc, checkIsReadOnlyFunc, type), checkVisibleFunc);
        }

        private static void OnShowReceiptRptForm(Control sender, string rightName, Func<IEntityReceiptItemMin> getOrderItemFunc, Func<bool> checkIsReadOnlyFunc, EFormDisplayType type)
        {
            XLoading.ShowLoading();
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var orderItem = getOrderItemFunc.Invoke();
            var f = guiIoc.GetInstance<Form>(EFormMgmt.FRptReceiptReport.ToString());
            var rpt = f as IFReceiptsReport;
            if (rpt != null)
            {
                rpt.Focus(orderItem);
            }
            var mgmt = XForm.GetInstance<IFormMgmt>(sender);
            mgmt.ShowForm<Form>(f, type, false);
            XLoading.CloseLoading();
        }

    }
}
