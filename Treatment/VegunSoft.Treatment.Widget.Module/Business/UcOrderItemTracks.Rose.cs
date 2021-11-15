using System.Collections.Generic;
using System.Linq;
using VegunSoft.Framework.Methods;
using VegunSoft.Layer.UcService.Provider;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;
using VegunSoft.Rose.Data.Enums;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemTracks
    {

        private List<string> _commissionCases;

        protected List<string> CommissionCases => _commissionCases ?? (_commissionCases = new List<string>() {
            ECommissionCase.Worker.GetId(),
            ECommissionCase.WorkerAssistant.GetId(),
        });

        protected void ApplyRoses(List<MEntityOrderItem> items)
        {
            if (items == null || items.Count == 0) return;

            var userName = SelectedDoctor?.Username;
            var isEmpty = string.IsNullOrWhiteSpace(userName);

            var accCommissionSettings = DEmployee.GetUserCommissionSettings(SessionCode, userName, isEmpty);
            foreach (var item in items)
            {
                var configs = accCommissionSettings.Where(x => x.PdsvId == item.ProductServiceId &&
                (isEmpty || (x.UserOrGroupId == userName)) && CommissionCases.Contains(x.CommissionCaseId)).ToList();
                item.HasCommission = configs.Count > 0;
            }
            _vieOrderItems.RefreshData();
        }

        protected void ReloadRoses()
        {
            var orderItems = DsOrderItems;
            if (orderItems == null || orderItems.Count == 0) return;
            ApplyRoses(orderItems);
        }


        protected void FormatHasRosesSteps()
        {
            var items = DataSource;
            if (items == null || items.Count == 0) return;

            var userName = SelectedDoctor?.Username;
            var isEmpty = string.IsNullOrWhiteSpace(userName);

            var users = new List<string>();

            if (isEmpty)
            {
                var doctors = items.Select(x => x.DoctorUsername).Distinct().ToList();
                if (doctors.Count > 0) users.AddRange(doctors);

                var asistants = items.Select(x => x.AssistantUsername).Distinct().ToList();
                if (asistants.Count > 0) users.AddRange(asistants);
            }
            else
            {
                users.Add(userName);
            }
            users = users.Where(x => !string.IsNullOrWhiteSpace(x)).Distinct().ToList();


            foreach (var user in users)
            {
                var userSteps = items.Where(x => IsIsInRange(user, x)).ToList();
                FormatHasRosesSteps(userName, user, userSteps, isEmpty);
            }
        }

        protected void FormatHasRosesSteps(string rootUsername, string userName, List<MEntityOrderItemStep> items, bool isEmpty)
        {
            var roseSettings = DEmployee.GetUserCommissionSettings(SessionCode, userName, false);
            var isAllow = (rootUsername == userName) || CanApprove;

            foreach (var item in items)
            {
                item.HasRose = false;
                if (item.IsFinishStage && item.IsAllowTreatmentRose && isAllow)
                {
                    var configs = roseSettings.Where(x => (x.PdsvId == item.ProductServiceId) && (x.RawStepId == item.RawStepId) && (x.UserOrGroupId == userName) && CommissionCases.Contains(x.CommissionCaseId)).ToList();

                    item.HasRose = configs.Count > 0;
                }
                
            }
        }

        protected bool IsIsInRange(string user, MEntityOrderItemStep step)
        {
            return (step.DoctorUsername == user && step.IsAllowDoctorRose) ||
                (step.AssistantUsername == user && step.IsAllowAssistantRose);
        }
    }
}
