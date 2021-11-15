using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Product.Entity.Provider.Business.Material;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemLabos
    {
        private void Load_glkDMLabo()
        {
            _glkProvider.Properties.DataSource = _repositoryMaterialProvider.Where(nameof(MEntityMaterialProvider.IsActive), true).ToList();
        }

        private void Load_glkDMVatlieu()
        {
            glkDMVatlieu.Properties.DataSource = _repositoryMaterial.Where(nameof(MEntityMaterial.IsActive), true).ToList();
        }

        private void Load_glkTrangThai()
        {
            glkTrangThai.Properties.DataSource = _repositoryOrderItemStepMaterialStatus.GetActiveModels();
        }

        private void LoadOrderItems(string customerId = null, string orderId = null)
        {
           
            customerId = customerId == null ? SelectedCustomer?.Id : customerId;
            orderId = orderId == null ? SelectedOrder?.Id : orderId;
            

            _cbbSelectOrderItem.CustomerId = customerId;
            _cbbSelectOrderItem.OrderId = orderId;
            _cbbSelectOrderItem.OrderItemId = SelectedOrderItem?.Id;
            _cbbSelectOrderItem.ReloadData();

            _cbbSelectOrderItem.EditValue = SelectedOrderItem?.Id;
        }

        private void LoadOrderItemSteps(string customerId = null, string orderId = null, string orderItemId = null)
        {
            List<MEntityOrderItemStep> dataSource = null;
            customerId = customerId == null ? SelectedCustomer?.Id : customerId;
            orderId = orderId == null ? SelectedOrder?.Id : orderId;
            orderItemId = orderItemId == null ? SelectedOrderItem?.Id : orderItemId;
            if (!string.IsNullOrWhiteSpace(orderItemId))
            {
                dataSource = _repositoryOrderItemProcessing.GetServiceHistories(orderItemId).OrderBy(x => x.CreatedDate).ToList();
            } else if (!string.IsNullOrWhiteSpace(orderId))
            {
                dataSource = _repositoryOrderItemProcessing.GetPlanHistories(orderId).OrderBy(x => x.CreatedDate).ToList();
            }
            else if (!string.IsNullOrWhiteSpace(customerId))
            {
                dataSource = _repositoryOrderItemProcessing.GetHistories<MEntityOrderItemStep>(customerId).OrderBy(x => x.CreatedDate).ToList();
            }
            _glkOrderItemStep.Properties.DataSource = dataSource;
            _viewOrderItemStep.RefreshData();
            _glkOrderItemStep.EditValue = SelectedOrderItemStep?.Id;
        }

        private double GetPrice()
        {
            var d = Entity?.RequestDateTime??_repositoryMaterial.GetDateTime();
            if (d < SqlDateTime.MinValue.Value) d = _repositoryMaterial.GetDateTime();
            
            var providerId = Entity?.ProviderId;
            var materialId = Entity?.MaterialId;
            var configs = _repositoryMaterialProviderSetting.GetConfigs(d, d).Where(x=>x.MaterialProviderId== providerId && x.MaterialId== materialId && x.IsApplyCommission && x.IsActive && !x.IsDeleted).OrderByDescending(x=>x.CreatedDate).ToList();
            var config = configs.Count > 0 ? configs.FirstOrDefault() : null;
            if (config != null) return config.Price;
            var ob = glkDMVatlieu.GetSelectedDataRow() as MEntityMaterial;
            return ob?.Price??0;
        }

        private void CalcFees()
        {
            _calcStartFee.EditValue = Convert.ToDouble(_calcUnitPrice.EditValue) * Convert.ToDouble(_calcAmount.EditValue);
            _calcEndFee.EditValue = Convert.ToDouble(_calcUnitPrice.EditValue) * Convert.ToDouble(_calcAmount.EditValue);
        }
    }
}
