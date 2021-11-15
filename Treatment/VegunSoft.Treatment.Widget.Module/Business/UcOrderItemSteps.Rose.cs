using System.Collections.Generic;
using System.Linq;
using VegunSoft.Framework.Methods;
using VegunSoft.Layer.UcControl.Customer.Orders;
using VegunSoft.Layer.UcService.Provider;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;
using VegunSoft.Product.Entity.Provider.Business;
using VegunSoft.Rose.Data.Enums;
using VegunSoft.Rose.Entity.Provider.Business.Setting;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemSteps
    {
        //private IRepositoryCommissionSettingAcc _repositoryCommissionSettingAcc;
        //protected IRepositoryCommissionSettingAcc RepositoryCommissionSettingAcc => _repositoryCommissionSettingAcc ?? (_repositoryCommissionSettingAcc = DbIoc.GetInstance<IRepositoryCommissionSettingAcc>());

        private List<string> _commissionCases;

        protected List<string> CommissionCases => _commissionCases ?? (_commissionCases = new List<string>() {
            ECommissionCase.Worker.GetId(),
            ECommissionCase.WorkerAssistant.GetId(),
        });

        protected void ApplyCommissions(MEntityOrderItem orderItem, List<MEntityPdsvStep> configs)
        {
            if (orderItem == null || configs == null || configs.Count == 0) return;

            var userName = GetDoctorFunc?.Invoke()?.Username;
            var isEmpty = string.IsNullOrWhiteSpace(userName);

            var accCommissionSettings = DEmployee.GetUserCommissionSettings(SessionCode, userName, isEmpty);
            foreach (var config in configs)
            {
                var commissionConfigs = accCommissionSettings.Where(x => IsInRange(x, config, orderItem, userName, isEmpty)).ToList();
                config.HasRose = commissionConfigs.Count > 0;
                var cfg = commissionConfigs.FirstOrDefault();
                if (cfg != null)
                {
                    config.CommissionRate = cfg.CommissionRate;
                    config.CommissionValue = cfg.CommissionValue;
                }
            }
            _view.RefreshData();
        }

        private bool IsInRange(MEntityRoseSettingMin x, MEntityPdsvStep config, MEntityOrderItem orderItem, string userName, bool isEmpty)
        {
            var rs = x.PdsvId == orderItem.ProductServiceId && (isEmpty || x.UserOrGroupId == userName) && CommissionCases.Contains(x.CommissionCaseId) && x.RawStepId == config.RawStepId;
            rs = rs && (string.IsNullOrWhiteSpace(x.PdsvStepId) || x.PdsvStepId == config.Id);
            return rs;
        }

        public IUcProductServiceSteps ReloadCommissions()
        {
            var ds = DataSource;
            if (ds == null || ds.Count == 0) return this;
            if (OrderItem == null) return this;
            ApplyCommissions(OrderItem, ds);
            return this;
        }
    }
}
