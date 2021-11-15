using System;
using System.Drawing;
using System.Windows.Forms;
using VegunSoft.Any.View.Dev.Forms;
using VegunSoft.App.Service.Mgmt;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums;
using VegunSoft.Framework.Gui.Enums.Image;
using VegunSoft.Framework.Gui.Provider.WindowsForms;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Services;
using VegunSoft.Framework.Gui.Services;
using VegunSoft.Framework.Ioc;
using VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order;
using VegunSoft.Order.Entity.Business.EntityOrder;

namespace VegunSoft.Layer.UcControl.Customer.Provider.Methods
{
    public static class MethodsMenuLabo
    {
        public static ToolStripItem AddShowLaboFormMenuItem(this Control sender, IContextMenuService svc, string rightName, Func<IEntityOrderItemStepMin> getStepFunc, Func<ToolStripItem, bool> checkVisibleFunc, Func<bool> checkIsReadOnlyFunc,
            EFormDisplayType type = EFormDisplayType.Dialog)
        {
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var iconService = guiIoc.GetInstance<IIconService>();
            return svc.AddItem("Xem danh sách labo", iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Labo16), (s, e) => OnShowLabo(sender, rightName, getStepFunc, checkIsReadOnlyFunc, type), checkVisibleFunc);
        }

        private static void OnShowLabo(Control sender, string rightName, Func<IEntityOrderItemStepMin> getStepFunc, Func<bool> checkIsReadOnlyFunc, EFormDisplayType type)
        {
            XLoading.ShowLoading();
            var step = getStepFunc.Invoke();
            var f = new FAny();
            var uc = new UcOrderItemLabos()
            {
                Text = "Đặt Labo"
            };
            var isSuccess = uc.CheckAndInit(rightName, step, checkIsReadOnlyFunc.Invoke(), step?.AssistantUsername);
            if (isSuccess)
            {
                f.Init(uc, true);
                var mgmt = XForm.GetInstance<IFormMgmt>(sender);
                mgmt.ShowForm<Form>(f, type, false);
            }
            XLoading.CloseLoading();
        }

    }
}
