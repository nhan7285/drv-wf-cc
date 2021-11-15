using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid.Columns;
using VegunSoft.Order.Entity.Business.EntityOrderItem;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItems
    {
        protected void AllowTreatColumn(bool isAllow)
        {
            _gcOrderItemProcess.Visible = isAllow;
        }

        protected void LockAllowEditColumns(bool isLock, params GridColumn[] ingoreColumns)
        {
            if (AllowEditColumns != null)
            {
                foreach(var c in AllowEditColumns)
                {
                    if(ingoreColumns==null || !ingoreColumns.Contains(c))
                    {
                        c.OptionsColumn.AllowEdit = !isLock;
                    }                   
                }
            }
        }

        protected void ApplyAllowEditColumns()
        {
            AllowEditColumns = _viewOrderItems.Columns.Where(x => x.OptionsColumn.AllowEdit).ToList();
        }

        private void ConfigOrderItemColumns()
        {
            ApplyAllowEditColumns();
            AllowContextGridColumns = new List<GridColumn>()
            {
               /* _gcOrderDisplayName,
                _gcOrderItemTeethId,
                _gcOrderItemTeethName,*/
                _gcOrderItemProductServiceName,
               // _gcOrderItemPrice,
            }; 
            AllowChangeTeethColumns = new List<GridColumn>()
            {
              _gcOrderItemTeethId,
                _gcOrderItemTeethName
            };

            _gcOrderItemIsForOld.FieldName = nameof(IEntityOrderItemBusiness.IsForOld);
            _gcOrderItemCreatedDate.FieldName = nameof(IEntityOrderItemBusiness.CreatedDate);

            #region Categories

            _gcOrderItemId.FieldName = nameof(IEntityOrderItemBusiness.Id);
            _gcOrderDisplayName.FieldName = nameof(IEntityOrderItemBusiness.OrderId);
            _gcOrderItemTeethId.FieldName = nameof(IEntityOrderItemBusiness.ProductServiceTargetId);
            _gcOrderItemTeethName.FieldName = nameof(IEntityOrderItemBusiness.ProductServiceTargetName);
            _gcOrderItemProductServiceName.FieldName = nameof(IEntityOrderItemBusiness.ProductServiceName);

            #endregion

            #region Numbers

            _gcOrderItemPrice.FieldName = nameof(IEntityOrderItemBusiness.UnitPrice);
            _gcOrderItemAmount.FieldName = nameof(IEntityOrderItemBusiness.Amount);

            _gcOrderItemDiscountRate.FieldName = nameof(IEntityOrderItemBusiness.DiscountRate);
            _gcOrderItemDiscountValue.FieldName = nameof(IEntityOrderItemBusiness.DiscountMoney);

            _gcOrderItemMoney.FieldName = nameof(IEntityOrderItemBusiness.MustPayMoney);

            _gcOrderItemTemporaryMoney.FieldName = nameof(IEntityOrderItemBusiness.TemporaryMustPayMoney);
            _gcOrderItemWithTemporaryMoney.FieldName = nameof(IEntityOrderItemBusiness.SumAllMustPayMoneys);

            #endregion

            #region Advanced
            _gcOrderItemIsTemporary.FieldName = nameof(IEntityOrderItemBusiness.IsTemporary);
            _gcOrderItemIsFinish.FieldName = nameof(IEntityOrderItemBusiness.IsFinish);
            _gcOrderItemFinishDate.FieldName = nameof(IEntityOrderItemBusiness.FinishDate);
            _gcOrderItemIsApproved.FieldName = nameof(IEntityOrderItemBusiness.IsApproved);
            _gcOrderItemOldId.FieldName = nameof(IEntityOrderItemBusiness.OldOrderItemId);
            _gcOrderItemNewId.FieldName = nameof(IEntityOrderItemBusiness.ChangedToOrderItemId);
            _gcOrderItemApprovedDate.FieldName = nameof(IEntityOrderItemBusiness.ApprovedDate);
            _gcOrderItemIsArisingService.FieldName = nameof(IEntityOrderItemBusiness.IsArisingService);
            #endregion

            #region Tracking

            _gcOrderItemConductorUsername.FieldName = nameof(IEntityOrderItemBusiness.WorkerUsername);
            _gcOrderItemConductorFullName.FieldName = nameof(IEntityOrderItemBusiness.WorkerFullName);

            #endregion


            _gcOrderItemDiscountValue.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
                new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum,  nameof(IEntityOrderItemBusiness.DiscountMoney), "{0:n0}")});

            this._gcOrderItemMoney.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
                new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum,  nameof(IEntityOrderItemBusiness.MustPayMoney), "{0:n0}")});

            this._gcOrderItemTemporaryMoney.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
                new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum,  nameof(IEntityOrderItemBusiness.TemporaryMustPayMoney), "{0:n0}")});

            this._gcOrderItemWithTemporaryMoney.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
                new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum,  nameof(IEntityOrderItemBusiness.SumAllMustPayMoneys), "{0:n0}")});

            var canChangeTime = CanChangeTime;
            ApplyAddingColumnStatus(_gcOrderItemIsForOld, canChangeTime);
            ApplyAddingColumnStatus(_gcOrderItemCreatedDate, canChangeTime);
        }
    }
}
