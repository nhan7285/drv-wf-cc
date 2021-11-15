using System.Collections.Generic;
using System.Linq;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;
using VegunSoft.Order.Repository.Business.Contract;
using VegunSoft.Product.Entity.Provider.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemSteps
	{
		private IRepositoryOrderItem _repositoryOrderItem;
		protected IRepositoryOrderItem RepositoryOrderItem => _repositoryOrderItem ?? (_repositoryOrderItem = DbIoc.GetInstance<IRepositoryOrderItem>());


		private void SaveCurrentOrderItem()
        {
			_btnSave.Enabled = false;
			var entity = OrderItem;
			if (entity == null || !entity.IsSaved) return;
			var dateTime = RepositoryOrderItem.GetDateTime();
			RepositorySession.ApplyUpdatedBasicFields(entity, dateTime);
			entity.PreventStepIds = GetLocInfo();
			var count = RepositoryOrderItem.Update(entity);
			if (count > 0) Msg.ShowUpdateSuccessInfo("cấu hình dịch vụ", true);
			else Msg.ShowUpdateErrorInfo("cấu hình dịch vụ");
			_btnSave.Enabled = true;
		}

		private string GetLocInfo()
        {
			var ds = DataSource;
			if (ds == null || ds.Count == 0) return string.Empty;
			var ids = ds.Where(x => x.IsLock).Select(x => x.Id).Distinct().ToList();
			if (ids == null || ids.Count == 0) return string.Empty;
			return string.Join("|", ids);
		}

		private void ApplyLockInfo(MEntityOrderItem entity, List<MEntityPdsvStep> ds)
		{
			if (entity == null || !entity.IsSaved) return;
			if (ds == null || ds.Count == 0) return;
			var idStr = entity.PreventStepIds;
			foreach(var item in ds)
            {
				item.IsLock = false;
			}
            if (string.IsNullOrWhiteSpace(idStr))
            {
				return;
            }
			var ids = idStr.Split('|').ToList();
			if (ids == null || ids.Count == 0) return;
			foreach (var item in ds)
			{
				item.IsLock = ids.Contains(item.Id);
			}
		}
	}
}
