using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VegunSoft.App.Data.Business;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Provider.WindowsForms;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Framework.Methods;
using VegunSoft.Message.Service.App;
using VegunSoft.Schedule.Form.Customer.Business;
using VegunSoft.Session.Service.User;

namespace VegunSoft.Schedule.Widget.Module.Services
{
    public class ApmtWidgetsService
    {
        private static IIocService _guiIoc;
        protected static IIocService GuiIoc => _guiIoc ?? (_guiIoc = XIoc.GetService(CGui.IocKey));

        private static IAppMessage _msg;
        protected static IAppMessage Msg => _msg ?? (_msg = GuiIoc.GetInstance<IAppMessage>());

        public static System.Windows.Forms.Form Instance => MasterViewService.Instance;
        public static bool ShowTreatmentAppointmentForm(bool isActive, MEntityCustomer customer = null, DateTime? targetDateTime = null)
        {
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var svc = guiIoc.GetInstance<ICheckRightsService>();
            var sessionCode = XForm.GetSessionCode(Instance);
            if (svc.CheckCanShow(sessionCode, EFormMgmt.BookAppointmentForm.GetFinalName()))
            {
                XLoading.ShowLoading();
                var f = guiIoc.GetInstance<System.Windows.Forms.Form>(EFormMgmt.BookAppointmentForm.ToString());
                var o = f as IFormCustomerCalendar;
                if (o != null && !o.IsNeedStart) o.ReStart();
                o?.Init(customer, targetDateTime);
                Class_Global._HienThiFormCon(Instance, f, false);
                if (isActive) f.Activate();
                XLoading.CloseLoading();
                return true;
            }
            else
            {
                Msg?.ShowInfo(EMsg.RightsTpl.GetDynamicText("Đặt hẹn"));
            }

            return false;
        }
        public static System.Windows.Forms.Form ShowTreatmentAppointmentFormWithGridCustomer(bool isActive, MEntityGridCustomer customer = null, DateTime? targetDateTime = null)
        {
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var svc = guiIoc.GetInstance<ICheckRightsService>();
            var sessionCode = XForm.GetSessionCode(Instance);
            if (svc.CheckCanShow(sessionCode, EFormMgmt.BookAppointmentForm.GetFinalName()))
            {
                var f = guiIoc.GetInstance<System.Windows.Forms.Form>(EFormMgmt.BookAppointmentForm.ToString());
                var o = f as IFormCustomerCalendar;
                //if (o != null && !o.IsNeedStart) o.ReStart();
                o?.InitWithGridCustomer(customer, targetDateTime);
                Class_Global._HienThiFormCon(Instance, f, false);
                if (isActive) f.Activate();
                return f;
            }

            return null;
        }
    }
}
