using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Threading.Tasks;
using VegunSoft.Category.Repository.Categories;
using VegunSoft.Customer.View.Dev.UserControls;
using VegunSoft.Layer.UcService.Provider.Models;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;
using VegunSoft.Order.Repository.Business.Contract;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemsBase : UcBaseCustomer
    {
        private IRepositoryTooth _repositoryTooth;
        protected IRepositoryTooth RepositoryTooth => _repositoryTooth ?? (_repositoryTooth = DbIoc.GetInstance<IRepositoryTooth>());

        private IRepositoryOrder _repositoryOrder;
        protected IRepositoryOrder RepositoryOrder => _repositoryOrder ?? (_repositoryOrder = DbIoc.GetInstance<IRepositoryOrder>());

        private IRepositoryOrderItem _repositoryOrderItem;
        protected IRepositoryOrderItem RepositoryOrderItem => _repositoryOrderItem ?? (_repositoryOrderItem = DbIoc.GetInstance<IRepositoryOrderItem>());

        private IRepositoryOrderItemStep _repositoryOrderItemStep;
        protected IRepositoryOrderItemStep RepositoryOrderItemStep => _repositoryOrderItemStep ?? (_repositoryOrderItemStep = DbIoc.GetInstance<IRepositoryOrderItemStep>());

        protected virtual GridView ViewOrderItems { get;}

        private McChangeItem<MEntityOrderItem> _mcChangeItemSteps;
        protected McChangeItem<MEntityOrderItem> McChangeItemSteps
        {
            get
            {
                if (_mcChangeItemSteps == null)
                {
                    _mcChangeItemSteps = new McChangeItem<MEntityOrderItem>();
                    _mcChangeItemSteps.Init(this.ApplyChangeStepsAction);
                }
                return _mcChangeItemSteps;
            }
            set => _mcChangeItemSteps = value;
        }

        protected void ApplyChangeStepsAction(MEntityOrderItem oldModel, MEntityOrderItem newModel)
        {
            if (oldModel == null)
            {
                Msg.ShowInfo("Vui lòng chọn dịch vụ nguồn!");
                return;
            }
            if (newModel == null)
            {
                Msg.ShowInfo("Vui lòng chọn dịch vụ đích!");
                return;
            }
            var fromId = oldModel?.Id;
            var fromSteps = RepositoryOrderItemStep.GetServiceHistories(fromId);
            var fromCount = fromSteps?.Count ?? 0;
            if (fromCount == 0)
            {
                Msg.ShowInfo("Không có lịch sử điều trị nào đề di chuyển!");
                return;
            }

            var toId = newModel?.Id;
            var toSteps = RepositoryOrderItemStep.GetServiceHistories(toId);
            var toCount = toSteps?.Count ?? 0;

            var fromName = $"{oldModel.Id} / {oldModel.ProductServiceName}";
            var toName = $"{newModel.Id} / {newModel.ProductServiceName}";
            if (Msg.IsAgree($"Bạn có chắc muốn di chuyển {fromCount} lịch sử điều trị từ dịch vụ [{fromName}] sang [{toName}] (đang có {toCount} dòng) ? "))
            {
                var isDeleteTo = toCount == 0 || Msg.IsAgree($"Bạn có muốn xóa tắt cả ({toCount}) các lịch sử điều trị hiện tại của dịch vụ đích [{toName}] sau khi di chuyển thành công?");
                Task.Run(() => {

                    var rs = RepositoryOrderItemStep.MoveSteps(oldModel, newModel, fromSteps, toSteps, isDeleteTo);
                    this.BeginInvoke(new Action(() =>
                    {
                        var isSuccess = rs.Item1 > 0;
                        var numDeletedTo = rs.Item2;
                        var isDeletedTo = numDeletedTo == toCount;
                        var deletedToName = isDeletedTo? $"thành công: {numDeletedTo} dòng!": $"Thất bại: {numDeletedTo}/{toCount} dòng!";
                        var toTxt = isDeleteTo ? $" - Xóa lịch sử cũ: {deletedToName}" : "";
                        if (isSuccess) Msg.ShowInfo($"Di chuyển thành công {rs.Item1} dòng{toTxt}", true);
                        else Msg.ShowError($"Di chuyển không thành công {rs.Item1}/{fromCount} dòng{toTxt}");
                    }));
                });
               
            }
            else
            {
                EndChangeOrderItemSteps();
            }


          
        }

        public void EndChangeOrderItemSteps()
        {
            var oldModel = McChangeItemSteps.EndChange();
            //UpdateChangingControls();
            if (oldModel != null) oldModel.IsChangingSteps = false;

            ViewOrderItems?.RefreshData();
        }
    }
}
