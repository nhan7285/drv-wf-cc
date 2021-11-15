using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using VegunSoft.Framework.Db.Enums.Data;
using VegunSoft.Framework.Gui.Enums.Image;
using VegunSoft.Framework.Methods;
using VegunSoft.Layer.EValue.App;
using VegunSoft.Layer.UcService.Provider.Methods;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;
using VegunSoft.Order.Func.Provider.Methods.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemsBase
    {
        protected bool IsShowDetailAdvancedColumns { get; set; }

        protected ToolStripItem MniShowDetailAdvancedColumns { get; set; }

        protected ToolStripItem MniShowDetailAdvancedColumnsLeft { get; set; }

        protected Dictionary<GridColumn, int> DictDetailColumns { get; set; }

        protected GridColumn[] OrderItemsAdvancedColumns { get; set; }

        protected bool CanUse(MEntityOrderItem o)
        {
            return o.Action != EMgmtCase.Delete && o.PlanNamePrefix != "Chỉ định CLS" && !o.IsDeleted;
        }

        protected void LoadSumValues()
        {
            var list = OrderItemsDs?.Where(o => CanUse(o)).ToList();
            LoadSumValues(list);
        }

        protected void LoadSumValues(List<MEntityOrderItem> list)
        {
            var realList = list?.GetValidOrderItems(true) ?? new List<MEntityOrderItem>();
            TotalDiscount = realList.GetOrderDiscountValue(false);
            MustPayMoney = realList.GetOrderMoney(false, true);
            TotalPrices = realList.GetOrderTotalPrice(false);
            ArisingMustPayMoney = realList.Where(o => !o.IsArisingService).ToList().Sum(o => o.MustPayMoney);
        }

        protected List<MEntityOrderItem> GetFinalDataSourceItems()
        {
            var list = ActiveOrderItems.Where(o => CanUse(o)).ToList();
            LoadSumValues(list);
            return list;
        }

        protected void LoadOrderItems()
        {
            //ShowMinMaxPrice(null);
            Grid.DataSource = null;
            Grid.DataSource = GetFinalDataSourceItems();
            View.RefreshData();
        }

        protected void ChangeToTempStatus(MEntityOrderItem item, bool isTemp)
        {
            if (item != null)
            {
                var user = RepositorySession.User;
                if (isTemp)
                {
                    item.OnChangeToTemporaryStatus();
                    if (!IsShowDetailAdvancedColumns)
                    {
                        OnShowHideAdvancedItemColumns();
                    }
                }
                else
                {
                    item.OnChangeToUsingStatus();
                }

                item.UsedUserId = user.Id;
                item.UsedUserNo = user.No;
                item.UsedUsername = user.Username;
                item.UsedUserFullName = user.FullName;
                item.UsedUserCode = user.Code;
                item.UsedDateTime = RepositoryOrderItem.GetDateTime();
                View.RefreshData();
                LoadSumValues();
            }

        }

        public void OnShowHideAdvancedItemColumns()
        {
            var items = new[] { MniShowDetailAdvancedColumns, MniShowDetailAdvancedColumnsLeft };
            if (IsShowDetailAdvancedColumns)
            {
                IsShowDetailAdvancedColumns = false;

                foreach (var item in items)
                {
                    item.Text = EMenuItem.ShowAdvancedOrderItemColumns.GetLanguageText();
                    item.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Show16);
                }

                DictDetailColumns.ShowHideColumns(IsShowDetailAdvancedColumns, OrderItemsAdvancedColumns);

            }
            else
            {
                IsShowDetailAdvancedColumns = true;
                foreach (var item in items)
                {
                    item.Text = EMenuItem.HideAdvancedOrderItemColumns.GetLanguageText();
                    item.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Hide16);
                }

                DictDetailColumns.ShowHideColumns(IsShowDetailAdvancedColumns, OrderItemsAdvancedColumns);
            }
        }
    }
}
