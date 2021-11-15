using System;
using System.Linq;
using DevExpress.XtraEditors;
using VegunSoft.Company.Data.Enums;
using VegunSoft.Company.Entity.Business.Structure;
using VegunSoft.Customer.Entity.Profile;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Customer.MQuery.Business.CheckIn;
using VegunSoft.Customer.Repository.Business;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Ioc;
using VegunSoft.Layer.UcControl.Any.Provider.Filters;
using VegunSoft.Message.Service.App;
using VegunSoft.Session.Repository.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.Methods
{

    public static class TransferResultMethods
    {
        public static int Accept(this SFilterCustomer uc, string sessionCode, IEntityCustomerMin customer, IEntityDepartmentMin department,
            CheckEdit chbPrivate, CheckEdit chbReadOnly, EFunction type, bool isSelft,
            Action<ICustomerCheckInResult> addedAction, bool isOnline = false)
        {
           
            var dbIoc = XIoc.GetService(CDb.IocKey);
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var messageService = guiIoc.GetInstance<IAppMessage>();
            var sessionRepository = dbIoc.GetInstance<IRepositorySession>();
            var repositoryCustomerStage = dbIoc.GetInstance<IRepositoryCustomerStage>();
            try
            {
                if (customer == null)
                {
                    messageService.ShowError("Vui lòng nhập khách hàng");
                    uc.StartSearch();
                    return 0;
                }

                var isPrivate = chbPrivate.Checked;
                var isReadOnly = chbReadOnly.Checked;
               
              

                XLoading.ShowLoading();
               // var branch = sessionRepository.Branch;
                var branch = sessionRepository.Branches.FirstOrDefault(x=>x.Id== department.BranchId);
                if (branch == null) branch = sessionRepository.Branch;
                 var user = sessionRepository.User;
                var rs = repositoryCustomerStage.Accept(uc.ParentForm, sessionCode, branch, customer, department, user, type, isPrivate, isReadOnly, isSelft, isOnline, false);
                XLoading.CloseLoading();
                rs = rs.CheckAndShowConfirm(() =>
                {
                    XLoading.ShowLoading();
                    var r = repositoryCustomerStage.Accept(uc.ParentForm, sessionCode, branch, customer, department, user, type, isPrivate, isReadOnly, isSelft, isOnline, true);
                    XLoading.CloseLoading();
                    return r;
                });

                if (rs.IsCreated)
                {
                    XLoading.ShowLoading();
                    addedAction?.Invoke(rs);
                    XLoading.CloseLoading();
                }

                rs.CheckAndShowMessages();
                return rs.No;
            }
            catch (Exception e)
            {
                
                messageService.ShowError(e.Message);
            }
            return 0;
        }

        public static int Accept(this SFilterCustomer uc, string sessionCode, IEntityCustomerMin customer, GridLookUpEdit glkDMPhong, CheckEdit chbPrivate, CheckEdit chbReadOnly, EFunction type, bool isSelft, Action<ICustomerCheckInResult> addedAction)
        {
            var dbIoc = XIoc.GetService(CDb.IocKey);
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var messageService = guiIoc.GetInstance<IAppMessage>();
            var department = glkDMPhong.GetSelectedDataRow() as IEntityDepartmentMin;
            if (department == null)
            {
                messageService.ShowError("Vui lòng nhập phòng");
                glkDMPhong.Focus();
                return 0;
            }
            return uc.Accept(sessionCode, customer, department, chbPrivate, chbReadOnly, type, isSelft, addedAction);
        }

        public static int Accept(this SFilterCustomer uc, string sessionCode, GridLookUpEdit glkDMPhong, CheckEdit chbPrivate, CheckEdit chbReadOnly, EFunction type, bool isSelft, Action<ICustomerCheckInResult> addedAction)
        {
            var customer = uc.SelectedCustomer as MEntityCustomerMin;
            return uc.Accept(sessionCode, customer, glkDMPhong, chbPrivate, chbReadOnly, type, isSelft, addedAction);
        }

        public static ICustomerCheckInResult CheckAndShowConfirm(this ICustomerCheckInResult rs, Func<ICustomerCheckInResult> createFunc)
        {
            var messageService = XIoc.GetService(CGui.IocKey).GetInstance<IAppMessage>();
            if (rs.IsConfirm)
            {
                if (messageService.IsAgree(rs.Message))
                {
                    rs = createFunc?.Invoke() ?? rs;
                }
                else
                {
                    rs = rs.GetCancelledResult("Đã bỏ qua tiếp nhận!");
                }
            }
            return rs;
        }

        public static void CheckAndShowMessages(this ICustomerCheckInResult rs)
        {
            var messageService = XIoc.GetService(CGui.IocKey).GetInstance<IAppMessage>();
            if (!string.IsNullOrWhiteSpace(rs.Message))
            {
                if (rs.IsCancelled)
                {
                    messageService.ShowWarning(rs.Message);
                }
                else if (rs.IsError)
                {
                    messageService.ShowError(rs.Message);
                }
                else if (rs.IsWarning)
                {
                    messageService.ShowWarning(rs.Message);
                }
                else
                {
                    messageService.ShowInfo(rs.Message, true);
                }
            }

        }
    }
}
