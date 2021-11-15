using System;
using System.Windows.Forms;
using VegunSoft.App.Data.Business;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Provider.WindowsForms;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Framework.Methods;
using VegunSoft.Layer.UcService.Provider.Any;
using VegunSoft.Message.Service.App;
using VegunSoft.Product.Repository.Business;
using VegunSoft.Schedule.Form.Customer.Business;
using VegunSoft.Session.Service.User;

namespace VegunSoft.Layer.UcService.Provider.Services
{
    public class MasterViewService
    {
        private static Form _instance;

        
        public static Form Instance
        {
            get => _instance;
            set { _instance = value; }
        }

        #region DbIoc

        private static IIocService _dbIoc;

        private static IIocService DbIoc => _dbIoc ?? (_dbIoc = XIoc.GetService(CDb.IocKey));

        private static IIocService _guiIoc;
        protected static IIocService GuiIoc => _guiIoc ?? (_guiIoc = XIoc.GetService(CGui.IocKey));

        #endregion

        private static IAppMessage _msg;
        protected static IAppMessage Msg => _msg ?? (_msg = GuiIoc.GetInstance<IAppMessage>());

        #region Repository Product Service Local

        private static ILocalProductServices _localProductServices;

        private static ILocalProductServices LocalProductServices => _localProductServices ?? (_localProductServices = DbIoc.GetInstance<ILocalProductServices>());

        #endregion

        //public static bool ShowTreatmentAppointmentForm(bool isActive, MEntityCustomer customer = null, DateTime? targetDateTime = null)
        //{
        //    var guiIoc = XIoc.GetService(CGui.IocKey);
        //    var svc = guiIoc.GetInstance<ICheckRightsService>();
        //    var sessionCode = XForm.GetSessionCode(Instance);
        //    if (svc.CheckCanShow(sessionCode, EFormMgmt.BookAppointmentForm.GetFinalName()))
        //    {
        //        XLoading.ShowLoading();
        //        var f = guiIoc.GetInstance<Form>(EFormMgmt.BookAppointmentForm.ToString());
        //        var o = f as IFormCustomerCalendar;
        //        if (o != null && !o.IsNeedStart) o.ReStart();
        //        o?.Init(customer, targetDateTime);
        //        Class_Global._HienThiFormCon(Instance, f, false);
        //       if(isActive) f.Activate();
        //        XLoading.CloseLoading();
        //        return true;
        //    }
        //    else
        //    {
        //        Msg?.ShowInfo(EMsg.RightsTpl.GetDynamicText("Đặt hẹn"));
        //    }

        //    return false;
        //}
        //public static Form ShowTreatmentAppointmentFormWithGridCustomer(bool isActive, MEntityGridCustomer customer = null, DateTime? targetDateTime = null)
        //{
        //    var guiIoc = XIoc.GetService(CGui.IocKey);
        //    var svc = guiIoc.GetInstance<ICheckRightsService>();
        //    var sessionCode = XForm.GetSessionCode(Instance);
        //    if (svc.CheckCanShow(sessionCode, EFormMgmt.BookAppointmentForm.GetFinalName()))
        //    {
        //        var f = guiIoc.GetInstance<Form>(EFormMgmt.BookAppointmentForm.ToString());
        //        var o = f as IFormCustomerCalendar;
        //        //if (o != null && !o.IsNeedStart) o.ReStart();
        //        o?.InitWithGridCustomer(customer, targetDateTime);
        //        Class_Global._HienThiFormCon(Instance, f, false);
        //        if (isActive) f.Activate();
        //        return f;
        //    }

        //    return null;
        //}

        public static void OnLogOut()
        {
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var f = guiIoc.GetInstance<Form>(EFormMgmt.BookAppointmentForm.ToString());
            var o = f as IFormCustomerCalendar;
            o.IsNeedStart = true;

            LocalProductServices?.Restart();

        }
    }
}
