using System;
using System.Drawing;
using System.Windows.Forms;
using VegunSoft.App.Data.Business;
using VegunSoft.App.Service.Mgmt;
using VegunSoft.Company.Data.Enums;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums;
using VegunSoft.Framework.Gui.Enums.Image;
using VegunSoft.Framework.Gui.Provider.WindowsForms;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Services;
using VegunSoft.Framework.Gui.Services;
using VegunSoft.Framework.Ioc;
using VegunSoft.Layer.Gui.Custome.Order;

namespace VegunSoft.Layer.UcControl.Customer.Provider.Methods
{
    public static class MethodsMenuOrder
    {
        public static ToolStripItem AddShowOrderMenuItem(this Control sender, IContextMenuService svc, Func<string> getCustomerIdFunc, Func<ToolStripItem, bool> checkVisibleFunc, Func<bool> checkIsReadOnlyFunc,
            EFormDisplayType type = EFormDisplayType.Dialog, bool isDirectMode = true)
        {
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var iconService = guiIoc.GetInstance<IIconService>();
            return svc.AddItem("Xem giao diện BSĐT", iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Treatment16), (s, e) => OnShowTreatment(sender, getCustomerIdFunc, checkIsReadOnlyFunc, type, isDirectMode), checkVisibleFunc);
        }

        private static void OnShowTreatment(Control sender, Func<string> getCustomerIdFunc, Func<bool> checkIsReadOnlyFunc, EFormDisplayType type, bool isDirectMode = true)
        {
            XLoading.ShowLoading();
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var customerId = getCustomerIdFunc.Invoke();
            var f = guiIoc.GetInstance<Form>(EFormMgmt.FWorkflowTreatment.ToString());

            // var isSuccess = uc.CheckAndInit(rightName, step, checkIsReadOnlyFunc.Invoke(), step?.AssistantUsername);
            if (f != null && f is IFWorkflowTreatment form)
            {
                form.StartCustomerId = customerId;
                form.IsStartDirect = isDirectMode;
                form.QueueType = EFunction.WaitingForTreatment;

                var mgmt = XForm.GetInstance<IFormMgmt>(sender);
                mgmt.ShowForm<Form>(f, type, false);

            }
            XLoading.CloseLoading();
        }

    }
}
