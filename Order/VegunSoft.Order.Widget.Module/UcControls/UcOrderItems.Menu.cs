using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using VegunSoft.Acc.Entity.Acc;
using VegunSoft.Framework.Db.Enums.Data;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums.Image;
using VegunSoft.Framework.Gui.Provider.WindowsForms.Methods;
using VegunSoft.Framework.Methods;
using VegunSoft.Layer.EValue.App;
using VegunSoft.Layer.UcControl.Customer.Forms;
using VegunSoft.Layer.UcControl.Customer.Models;
using VegunSoft.Layer.UcService.Provider.Models;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItems
    {
        private bool _allowShowContextMenu;

       

        protected ContextMenuStrip CmnOrderItems { get; set; }

        protected ToolStripItem MniSelectOrderItem { get; set; }

        protected ToolStripItem MniSelectOrderItemSteps { get; set; }

        private ToolStripItem _mniAssignConsultant;
        private ToolStripItem _mniAssignConsultantAssistant;

        protected ToolStripItem MniCancelChangeOrderItem { get; set; }

        protected ToolStripItem MniCancelChangeOrderItemSteps { get; set; }

        private ToolStripItem _mniReuseOrderItem;

        protected ToolStripItem MniChangeOrderItem { get; set; }

        protected ToolStripItem MniChangeOrderItemSteps { get; set; }

        private ToolStripItem _mniEditOrderItem;
        protected ToolStripItem MniBookLabo { get; set; }
        private ToolStripItem _mniShowOldOrderItem;
        private ToolStripItem _mniCompareNewOrderItem;
        private ToolStripItem _mniCompareOldOrderItem;
        private ToolStripItem _mniShowNewOrderItem;
        private ToolStripItem _mniChangeToUseStatus;
        private ToolStripItem _mniChangeToTemporaryStatus;
        private ToolStripItem _mniShowHideUsingColumns;
        private ToolStripItem _mniShowHideOldColumns;
        private ToolStripItem _mniShowHideNewColumns;
        private ToolStripItem _mniShowHideTemporaryColumns;
        private ToolStripItem _mniRefrensOrderItems;
        private ToolStripItem _mniDisplayOrderItemInfo;

        private ToolStripSeparator _viewOrCompareItemSep;
        private ToolStripSeparator _changeOrCancelSep;
        private ToolStripSeparator _changeStatusSep;
        private ToolStripSeparator _finalItemsSep;

        private McChangeItem<MEntityOrderItem> _mcChangeItem;
       
        private ToolStripItem _mniShowHideMgmtForm;
        private ToolStripItem _mniShowHideMgmtFormLeft;
        private ToolStripItem _mniSelectOrderFromItem;
        private ToolStripItem _mniShowAllOrdersItem;
        //private ToolStripSeparator _sepOrders;

        protected McChangeItem<MEntityOrderItem> McChangeItem
        {
            get
            {
                if (_mcChangeItem == null)
                {
                    _mcChangeItem = new McChangeItem<MEntityOrderItem>();
                    _mcChangeItem.Init(this.ApplyChangeAction);
                }
                return _mcChangeItem;
            }
            set => _mcChangeItem = value;
        }

       

        private void OnShowHideMgmtForm()
        {
            var items = new[] { _mniShowHideMgmtForm, _mniShowHideMgmtFormLeft };
            if (OrdersPanel.Visible)
            {
                foreach (var item in items)
                {
                    item.Text = EMenuItem.ShowOrdersPanel.GetLanguageText();
                    item.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Show16);
                }

                OrdersPanel.Hide();
            }
            else
            {
                foreach (var item in items)
                {
                    item.Text = EMenuItem.HideOrdersPanel.GetLanguageText();
                    item.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Hide16);
                }

                OrdersPanel.Show();
            }
        }


        


        private void SetOrderDetailContextMenus()
        {
            IsShowDetailAdvancedColumns = true;
            OrderItemsAdvancedColumns = new GridColumn[]
            {
                _gcOrderItemTemporaryMoney,
                _gcOrderItemWithTemporaryMoney,
                _gcOrderItemIsTemporary,
                _gcOrderItemOldId,
                _gcOrderItemNewId

            };
            var mainGridMenu = new ContextMenuStrip();
            _mniShowHideMgmtForm = mainGridMenu.Items.Add(EMenuItem.HideOrdersPanel.GetLanguageText());
            _mniShowHideMgmtForm.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Hide16);
            _mniShowHideMgmtForm.Click += (sender, args) => { OnShowHideMgmtForm(); };

            MniShowDetailAdvancedColumns = mainGridMenu.Items.Add(EMenuItem.HideAdvancedOrderItemColumns.GetLanguageText());
            MniShowDetailAdvancedColumns.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Hide16);
            MniShowDetailAdvancedColumns.Click += (sender, args) =>
            {
                OnShowHideAdvancedItemColumns();

            };
            // mniShowDetailAdvancedColumns.Click += ShowHideOrderPanelOnClick;



            OrdersPanel.ContextMenuStrip = mainGridMenu;
            _gridOrderItems.ContextMenuStrip = mainGridMenu;
            // _gridOrderDetails.ContextMenuStrip = mainGridMenu;
        }

        protected Control OrdersPanel => Settings?.GetOrdersPanelFunc?.Invoke() ?? new Panel();

        private ToolStripItem AssignConsultantMenuItem(ContextMenuStrip menu)
        {
            var item = menu.Items.Add("Gán BSTV");
            item.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Apply16);
            item.Click += OnAssignConsultantMenuItemClick;
            return item;
        }

        private ToolStripItem AssignConsultantAssistantMenuItem(ContextMenuStrip menu)
        {
            var item = menu.Items.Add("Gán TLBS");
            item.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Apply16);
            item.Click += OnAssignConsultantAssistantMenuItemClick;
            return item;
        }

        private void CreateDetailCellContextMenu()
        {
            CmnOrderItems = new ContextMenuStrip();
            var mn = CmnOrderItems;

            MniSelectOrderItem = mn.Items.Add("@ Chọn đổi");
            MniSelectOrderItem.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Select16);
            MniSelectOrderItem.Click += SelectOrderItemOnClick;
            MniSelectOrderItem.Visible = false;

            MniCancelChangeOrderItem = mn.Items.Add("@ Hủy đổi");
            MniCancelChangeOrderItem.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Cancel16);
            MniCancelChangeOrderItem.Click += CancelChangeOrderItemOnClick;
            MniCancelChangeOrderItem.Visible = false;

            MniSelectOrderItemSteps = mn.Items.Add("@ Chọn di chuyển");
            MniSelectOrderItemSteps.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Select16);
            MniSelectOrderItemSteps.Click += SelectOrderItemStepsOnClick;
            MniSelectOrderItemSteps.Visible = false;

            MniCancelChangeOrderItemSteps = mn.Items.Add("@ Hủy di chuyển");
            MniCancelChangeOrderItemSteps.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Cancel16);
            MniCancelChangeOrderItemSteps.Click += CancelChangeOrderItemStepsOnClick;
            MniCancelChangeOrderItemSteps.Visible = false;

            _mniReuseOrderItem = mn.Items.Add("Sử dụng lại");
            _mniReuseOrderItem.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Apply16);
            _mniReuseOrderItem.Click += ReuseOrderItemOnClick;
            _mniReuseOrderItem.Visible = false;

            _mniAssignConsultant = AssignConsultantMenuItem(mn);
            _mniAssignConsultant.Visible = false;
            _mniAssignConsultantAssistant = AssignConsultantAssistantMenuItem(mn);
            _mniAssignConsultantAssistant.Visible = false;

            //OK          
            MniChangeOrderItem = mn.Items.Add("Đổi dịch vụ");
            MniChangeOrderItem.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Change16);
            MniChangeOrderItem.Click += ChangeOrderItemOnClick;

            //OK
            MniChangeOrderItemSteps = mn.Items.Add("Di chuyển lịch sử điều trị");
            MniChangeOrderItemSteps.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Variable16);
            MniChangeOrderItemSteps.Click += ChangeOrderItemStepsOnClick;

            _mniSelectOrderFromItem = mn.Items.Add("Sửa hồ sơ");
            _mniSelectOrderFromItem.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Edit16);
            _mniSelectOrderFromItem.Click += OnSelectOrderFromItemClick;

            _mniShowAllOrdersItem = mn.Items.Add("Xem tất cả");
            _mniShowAllOrdersItem.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Expand16);
            _mniShowAllOrdersItem.Click += OnShowAllOrdersItemClick;


            _changeOrCancelSep = new ToolStripSeparator();

            mn.Items.Add(_changeOrCancelSep);
            MniBookLabo = mn.Items.Add("Đặt Labo");
            MniBookLabo.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.BookNew16);
            MniBookLabo.Click += BookLaboOnClick;

            _mniEditOrderItem = mn.Items.Add("Sửa dịch vụ");
            _mniEditOrderItem.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Rebook16);
            _mniEditOrderItem.Click += EditOrderItemOnClick;

            _mniShowOldOrderItem = mn.Items.Add("Chọn xem dịch vụ cũ");
            _mniShowOldOrderItem.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Show16);
            _mniShowOldOrderItem.Click += ShowOldOrderItemOnClick;

            _mniShowNewOrderItem = mn.Items.Add("Chọn xem dịch vụ mới");
            _mniShowNewOrderItem.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Show16);
            _mniShowNewOrderItem.Click += ShowNewOrderItemOnClick;

            _mniCompareNewOrderItem = mn.Items.Add("So sánh với dịch vụ mới");
            _mniCompareNewOrderItem.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Today16);
            _mniCompareNewOrderItem.Click += CompareNewOrderItemOnClick;
            _mniCompareNewOrderItem.Visible = false;

            _mniCompareOldOrderItem = mn.Items.Add("So sánh với dịch vụ cũ");
            _mniCompareOldOrderItem.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Search16);
            _mniCompareOldOrderItem.Click += CompareOldOrderItemOnClick;
            _mniCompareOldOrderItem.Visible = false;

            _viewOrCompareItemSep = new ToolStripSeparator();
            mn.Items.Add(_viewOrCompareItemSep);

            _mniChangeToTemporaryStatus = mn.Items.Add("Chuyển sang trạng thái tạm");
            _mniChangeToTemporaryStatus.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Status16);
            _mniChangeToTemporaryStatus.Click += ChangeToTemporaryStatusOnClick;

            _mniChangeToUseStatus = mn.Items.Add("Chuyển sang trạng thái sử dụng");
            _mniChangeToUseStatus.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Status16);
            _mniChangeToUseStatus.Click += ChangeToUseStatusOnClick;

            _changeStatusSep = new ToolStripSeparator();
            mn.Items.Add(_changeStatusSep);
            _changeStatusSep.Visible = false;

            _mniShowHideOldColumns = mn.Items.Add("Ẩn / hiện dịch vụ cũ");
            _mniShowHideOldColumns.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Show16);
            _mniShowHideOldColumns.Click += ShowHideOldColumnsOnClick;
            _mniShowHideOldColumns.Visible = false;

            _mniShowHideNewColumns = mn.Items.Add("Ẩn / hiện dịch vụ mới");
            _mniShowHideNewColumns.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Show16);
            _mniShowHideNewColumns.Click += ShowHideNewColumnsOnClick;
            _mniShowHideNewColumns.Visible = false;

            _mniShowHideUsingColumns = mn.Items.Add("Ẩn / hiện dịch vụ đang sử dụng");
            _mniShowHideUsingColumns.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Show16);
            _mniShowHideUsingColumns.Click += ShowHideUsingColumnsOnClick;
            _mniShowHideUsingColumns.Visible = false;

            _mniShowHideTemporaryColumns = mn.Items.Add("Ẩn / hiện dịch vụ tạm");
            _mniShowHideTemporaryColumns.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Show16);
            _mniShowHideTemporaryColumns.Click += ShowHideTemporaryColumnsOnClick;
            _mniShowHideTemporaryColumns.Visible = false;

            _finalItemsSep = new ToolStripSeparator();
            mn.Items.Add(_finalItemsSep);
            _finalItemsSep.Visible = false;

            _mniDisplayOrderItemInfo = mn.Items.Add("Xem");
            _mniDisplayOrderItemInfo.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Display16);
            _mniDisplayOrderItemInfo.Click += DisplayOrderItemInfoClick;

            _mniRefrensOrderItems = mn.Items.Add("Làm mới");
            _mniRefrensOrderItems.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Refresh16);
            _mniRefrensOrderItems.Click += RefrensOrderItemsOnClick;

            _mniShowHideMgmtFormLeft = mn.Items.Add(EMenuItem.HideOrdersPanel.GetLanguageText());
            _mniShowHideMgmtFormLeft.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Hide16);
            _mniShowHideMgmtFormLeft.Click += (sender, args) => { OnShowHideMgmtForm(); };

            MniShowDetailAdvancedColumnsLeft = mn.Items.Add(EMenuItem.HideOrdersPanel.GetLanguageText());
            MniShowDetailAdvancedColumnsLeft.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Hide16);
            MniShowDetailAdvancedColumnsLeft.Click += (sender, args) => { OnShowHideAdvancedItemColumns(); };

            //_sepOrders = new ToolStripSeparator();

        }



        private void DisplayOrderItemInfoClick(object sender, EventArgs e)
        {
            var f = GuiIoc.GetInstance<IFDisplayOrderItemInfo>();
            f.Apply(SelectedOrderItem).ShowPopup(this);
        }

        private void ShowHideTemporaryColumnsOnClick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void ShowHideUsingColumnsOnClick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void ShowHideNewColumnsOnClick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void ShowHideOldColumnsOnClick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void ChangeToUseStatusOnClick(object sender, EventArgs e)
        {
            ChangeToTempStatus(SelectedOrderItem, false);
        }

        private void ChangeToTemporaryStatusOnClick(object sender, EventArgs e)
        {
            ChangeToTempStatus(SelectedOrderItem, true);
        }


        private void ChangeOrderItemOnClick(object sender, EventArgs e)
        {
            StartChangeOrderItem();
        }

        private void ChangeOrderItemStepsOnClick(object sender, EventArgs e)
        {
            StartChangeOrderItemSteps();
        }

        private void EditOrderItemOnClick(object sender, EventArgs e)
        {
            StartEditOrderItem(SelectedOrderItem);
        }

        private void BookLaboOnClick(object sender, EventArgs e)
        {
            StartBookLabo();
        }

      

        private void StartChangeOrderItem()
        {
            if (SelectedOrderItem == null) return;
            SelectedOrderItem.IsChanging = true;
            McChangeItem.StartChange(SelectedOrderItem);
            UpdateChangingControls();
            _viewOrderItems.RefreshData();
        }

        private void StartChangeOrderItemSteps()
        {
            if (SelectedOrderItem == null) return;
            SelectedOrderItem.IsChangingSteps = true;
            McChangeItemSteps.StartChange(SelectedOrderItem);
            UpdateChangingControls();
            _viewOrderItems.RefreshData();
        }

        private void UpdateChangingControls()
        {
            var isChanging = McChangeItem.IsChanging;
            if (isChanging)
            {
                _cheIsChange.Visible = true;
                _cheIsChange.Checked = true;
                _cheIsChange.Properties.ReadOnly = false;
                // _btnAddProductServiceToOrder.Text = _changingAddProductServiceText;
            }
            else
            {
                _cheIsChange.Visible = false;
                _cheIsChange.Checked = false;
                _cheIsChange.Properties.ReadOnly = true;
                //_btnAddProductServiceToOrder.Text = _defaultAddProductServiceText;
            }
        }

        public bool RefreshItem(MEntityOrderItem orderItem)
        {
            var found = false;
            var ds = _gridOrderItems.DataSource as IList<MEntityOrderItem>;
            if (ds == null) return false;
            var inViewModel = ds != null ? ds.FirstOrDefault(x => x.Id == orderItem.Id): null;
           if(inViewModel!=null)
            {
                orderItem.Copy(inViewModel);
                _viewOrderItems.RefreshData();
                found = true;
            }
            return found;
        }

        public bool AddItem(MEntityOrderItem orderItem)
        {
            var added = false;
            var ds = _gridOrderItems.DataSource as IList<MEntityOrderItem>;
            if (ds == null) return false;
            var inViewModel = ds != null ? ds.FirstOrDefault(x => x.Id == orderItem.Id) : null;
            if (inViewModel == null)
            {
                if (IsFocusingOrder(orderItem?.OrderId))
                {
                    ds.Add(orderItem);
                    _viewOrderItems.RefreshData();
                    added = true;
                }
                   
            }
            return added;
        }

        public bool IsFocusingOrder(string id)
        {
            return this.Order?.Id == id;
        }

        public bool DeleteItem(string orderItemId)
        {
            var deleted = false;
            var ds = _gridOrderItems.DataSource as IList<MEntityOrderItem>;
            if (ds == null) return false;
            var inViewModel = ds != null ? ds.FirstOrDefault(x => x.Id == orderItemId) : null;
            if (inViewModel != null)
            {
                ds.Remove(inViewModel);
                _viewOrderItems.RefreshData();
                deleted = true;
            }
            return deleted;
        }

        public void RefreshItems(MSaveOrderItems orderItems)
        {
         
            if(orderItems.AddedItems!=null && orderItems.AddedItems.Count > 0)
            {
                foreach (var item in orderItems.AddedItems)
                {
                   var found = RefreshItem(item);
                    if (!found) AddItem(item);
                }
            }
            if (orderItems.UpdatedItems != null && orderItems.UpdatedItems.Count > 0)
            {
                foreach (var item in orderItems.UpdatedItems)
                {
                    var found = RefreshItem(item);
                    if (!found) AddItem(item);
                }
            }
            if (orderItems.DeletedItems != null && orderItems.DeletedItems.Count > 0)
            {
                foreach (var item in orderItems.DeletedItems)
                {
                    var found = DeleteItem(item);
                }
            }
           
        }

        public void RefreshItem(MSaveOrderItem saveResult)
        {
            if (saveResult == null || saveResult == null) return;
            var item = saveResult.Item;
            if (saveResult.Case == EMgmtCase.Insert)
            {
                var found = RefreshItem(item);
                if (!found) AddItem(item);
            } else if (saveResult.Case == EMgmtCase.Update)
            {
                var found = RefreshItem(item);
                if (!found) AddItem(item);
            }
            else if (saveResult.Case == EMgmtCase.Delete)
            {
                var found = DeleteItem(item?.Id);
            }
        }

        public void EndChangeOrderItem()
        {
            var oldModel = McChangeItem.EndChange();
            UpdateChangingControls();
            if (oldModel != null) oldModel.IsChanging = false;

            _viewOrderItems.RefreshData();
        }


        

        private void ReuseOrderItemOnClick(object sender, EventArgs e)
        {
            SelectedOrderItem.IsChanged = false;
            _viewOrderItems.RefreshData();
        }

        private void CancelChangeOrderItemOnClick(object sender, EventArgs e)
        {
            EndChangeOrderItem();
        }

        private void CancelChangeOrderItemStepsOnClick(object sender, EventArgs e)
        {
            EndChangeOrderItemSteps();
        }

        private void SelectOrderItemOnClick(object sender, EventArgs e)
        {
            OnSelectChangeToItem(SelectedOrderItem);
        }

        private void SelectOrderItemStepsOnClick(object sender, EventArgs e)
        {
            OnSelectChangeToItemSteps(SelectedOrderItem);
        }

        private void OnSelectChangeToItem(MEntityOrderItem newItem)
        {
            var oldModel = McChangeItem.ApplyChange(newItem);
            if (oldModel != null) oldModel.IsChanging = false;
            _viewOrderItems.RefreshData();
        }

        private void OnSelectChangeToItemSteps(MEntityOrderItem newItem)
        {
            var oldModel = McChangeItemSteps.ApplyChange(newItem);
            if (oldModel != null) oldModel.IsChangingSteps = false;
            _viewOrderItems.RefreshData();
        }

        private void ShowContextMenu()
        {
            if (_allowShowContextMenu)
            {
                UpdateCellContextMenu(_isInRowCell);
                CmnOrderItems.DisplayAtCursor();
                // _detailCellContextMenu.Refresh();
            }

            _allowShowContextMenu = false;
        }



        protected bool IsShowRefrensOrderItems
        {
            get
            {
                //if (SelectedOrderItem == null) return false;
                //var isVisible = HasSelectedOrderItem && IsAllowEditItem && IsUpdatingOrder
                //                && SelectedOrderItem.IsSaved
                //                && !SelectedOrderItem.IsDeleted
                //                && !SelectedOrderItem.IsChanged
                //                && !McChangeItem.CheckIsChanging(SelectedOrderItem);
                return true;
            }
        }

        protected bool IsShowReuseOrderItemOrderItem
        {
            get
            {
                if (SelectedOrderItem == null) return false;
                var isVisible = HasSelectedOrderItem && IsAllowEditItem
                                && !SelectedOrderItem.IsDeleted
                                && SelectedOrderItem.IsChanged;
                return isVisible;
            }
        }

        protected bool IsShowCancelChangeOrderItem
        {
            get
            {
                if (SelectedOrderItem == null) return false;
                var isVisible = HasSelectedOrderItem && IsAllowEditItem
                                && !SelectedOrderItem.IsDeleted
                                && McChangeItem.IsChanging;
                return isVisible;
            }
        }

        protected bool IsShowCancelChangeOrderItemSteps
        {
            get
            {
                if (SelectedOrderItem == null) return false;
                var isVisible = HasSelectedOrderItem && McChangeItemSteps.IsChanging;
                return isVisible;
            }
        }

        protected bool IsShowOldOrderItem
        {
            get
            {
                if (SelectedOrderItem == null) return false;
                var isVisible = HasSelectedOrderItem
                                && !SelectedOrderItem.IsChanged
                                && !SelectedOrderItem.IsDeleted
                                && !string.IsNullOrWhiteSpace(SelectedOrderItem.OldOrderItemId);
                return isVisible;
            }
        }

        protected bool IsShowCompareOldOrderItem
        {
            get
            {
                if (SelectedOrderItem == null) return false;
                var isVisible = HasSelectedOrderItem
                                                     && !SelectedOrderItem.IsChanged
                                                     && !SelectedOrderItem.IsDeleted

                                                     && !string.IsNullOrWhiteSpace(SelectedOrderItem.OldOrderItemId);
                return isVisible;
            }
        }

        protected bool IsShowNewOrderItem
        {
            get
            {
                if (SelectedOrderItem == null) return false;
                var isVisible = HasSelectedOrderItem
                                                     && !SelectedOrderItem.IsDeleted
                                                     && SelectedOrderItem.IsChanged
                                                     && !string.IsNullOrWhiteSpace(SelectedOrderItem.ChangedToOrderItemId);
                return isVisible;
            }
        }

        protected bool IsShowCompareNewOrderItem
        {
            get
            {
                if (SelectedOrderItem == null) return false;
                var isVisible = HasSelectedOrderItem
                                && !SelectedOrderItem.IsDeleted
                                && SelectedOrderItem.IsChanged
                                && !string.IsNullOrWhiteSpace(SelectedOrderItem.ChangedToOrderItemId);
                return isVisible;
            }
        }

        protected bool IsShowMniSelectOrderItem
        {
            get
            {
                if (SelectedOrderItem == null) return false;
                var isVisible = HasSelectedOrderItem && IsAllowEditItem
                                && !SelectedOrderItem.IsDeleted
                                && !McChangeItem.CheckIsChanging(SelectedOrderItem)
                    && McChangeItem.IsChanging;
                return isVisible;
            }
        }

        protected bool IsShowMniSelectOrderItemSteps
        {
            get
            {
                if (SelectedOrderItem == null) return false;
                var isVisible = HasSelectedOrderItem 
                                && !McChangeItemSteps.CheckIsChanging(SelectedOrderItem)
                    && McChangeItemSteps.IsChanging;
                return isVisible;
            }
        }

        protected bool IsShowMniChangeOrderItem
        {
            get
            {
                if (SelectedOrderItem == null) return false;
                var isVisible = HasSelectedOrderItem && IsAllowEditItem
                                && !SelectedOrderItem.IsChanged
                                //&& SelectedOrderItem.IsSaved
                                && !SelectedOrderItem.IsDeleted
                                && !SelectedOrderItem.IsFinish
                                && !McChangeItem.CheckIsChanging(SelectedOrderItem);
                return isVisible;
            }
        }

        protected bool IsShowMniChangeOrderItemSteps
        {
            get
            {
                if (SelectedOrderItem == null) return false;
                var isVisible = HasSelectedOrderItem 
                                && !McChangeItemSteps.CheckIsChanging(SelectedOrderItem);
                return isVisible;
            }
        }

        protected bool IsShowMniBookLabo
        {
            get
            {
                if (SelectedOrderItem == null) return false;
                var isVisible = HasSelectedOrderItem //&& IsAllowEditItem
                                && SelectedOrderItem.IsSaved
                                && !SelectedOrderItem.IsChanged
                                && !SelectedOrderItem.IsDeleted;
                return isVisible;
              
            }
        }
        protected bool IsShowMniEditOrderItem
        {
            get
            {
                if (SelectedOrderItem == null) return false;
                var isVisible = HasSelectedOrderItem && IsAllowEditItem
                                && !SelectedOrderItem.IsChanged
                                //&& SelectedOrderItem.IsSaved
                                && !SelectedOrderItem.IsDeleted
                                && !SelectedOrderItem.IsFinish;
                //return isVisible;
                //TODO: Select Teeth not work
                return false;
            }
        }

        protected bool IsShowMniChangeToTemporaryStatus
        {
            get
            {
                var isVisible = HasSelectedOrderItem && IsAllowEditItem;
                isVisible = isVisible && !(SelectedOrderItem?.IsTemporary ?? true) && !(SelectedOrderItem?.IsFinish ?? true) && !(SelectedOrderItem?.IsInProgress ?? true);
                return isVisible;
            }
        }

        protected bool IsShowMniChangeToUseStatus
        {
            get
            {
                var isVisible = HasSelectedOrderItem && IsAllowEditItem;
                isVisible = isVisible && (SelectedOrderItem?.IsTemporary ?? false);
                return isVisible;
            }
        }

        private void ShowOldOrderItemOnClick(object sender, EventArgs e)
        {
            var oldId = SelectedOrderItem?.OldOrderItemHiddenId;
            if (!string.IsNullOrWhiteSpace(oldId))
            {
                var oldModel = ActiveOrderItems.FirstOrDefault(x => x.HiddenId == oldId);
                if (oldModel != null)
                {
                    oldModel.IsLinkingOld = true;
                    var f = GuiIoc.GetInstance<IFDisplayOrderItemInfo>();
                    f.Apply(oldModel).ShowPopup(this);
                    _viewOrderItems.RefreshData();
                }

            }
        }
        private void ShowNewOrderItemOnClick(object sender, EventArgs e)
        {
            var newId = SelectedOrderItem?.ChangedToOrderItemHiddenId;
            if (!string.IsNullOrWhiteSpace(newId))
            {
                var newModel = ActiveOrderItems.FirstOrDefault(x => x.HiddenId == newId);
                if (newModel != null)
                {
                    newModel.IsLinkingNew = true;
                    var f = GuiIoc.GetInstance<IFDisplayOrderItemInfo>();
                    f.Apply(newModel).ShowPopup(this);
                    _viewOrderItems.RefreshData();
                }

            }
        }

        private void CompareOldOrderItemOnClick(object sender, EventArgs e)
        {
            var oldId = SelectedOrderItem?.OldOrderItemHiddenId;
            if (!string.IsNullOrWhiteSpace(oldId))
            {
                var oldModel = ActiveOrderItems.FirstOrDefault(x => x.HiddenId == oldId);
                if (oldModel != null)
                {
                    oldModel.IsLinkingOld = true;
                    var f = GuiIoc.GetInstance<IFCompareOrderItemsInfo>();
                    f.Compare(oldModel, SelectedOrderItem, true).ShowPopup(this);
                    _viewOrderItems.RefreshData();
                }

            }
        }


        private void CompareNewOrderItemOnClick(object sender, EventArgs e)
        {
            CompareNewOrderItem(SelectedOrderItem);
        }


        private void CompareNewOrderItem(MEntityOrderItem item)
        {
            var newId = item?.ChangedToOrderItemHiddenId;
            if (!string.IsNullOrWhiteSpace(newId))
            {
                var newModel = ActiveOrderItems.FirstOrDefault(x => x.HiddenId == newId);
                if (newModel != null)
                {
                    newModel.IsLinkingNew = true;
                    var f = GuiIoc.GetInstance<IFCompareOrderItemsInfo>();
                    f.Compare(item, newModel, false).ShowPopup(this);
                    _viewOrderItems.RefreshData();
                }

            }
        }

        

        private void ApplyChangeAction(MEntityOrderItem oldModel, MEntityOrderItem newModel)
        {
            var isTemp = oldModel.IsTemporary;
            var amount = oldModel.Amount;
            var discountRate = oldModel.DiscountRate;
            var discountValue = oldModel.DiscountMoney;

            var user = RepositorySession.User;

            oldModel.IsChanged = true;
    
            oldModel.Amount = oldModel.Amount;
            oldModel.BackupPrice = oldModel.UnitPrice;
            oldModel.BackupDiscountedRate = oldModel.DiscountRate;
            oldModel.BackupDiscountedValue = oldModel.DiscountMoney;
            oldModel.BackupMustPayMoney = oldModel.MustPayMoney;

            oldModel.Amount = 0;
            oldModel.DiscountMoney = 0;
            oldModel.DiscountRate = 0;
            oldModel.CalculateMoney();

            oldModel.ChangedToOrderItemId = newModel.Id;
            oldModel.ChangedToOrderItemHiddenId = newModel.HiddenId;
            oldModel.ChangedToOrderItemNo = newModel.ChangedToOrderItemNo;
            oldModel.ChangedToOrderItemCode = newModel.ChangedToOrderItemCode;
            oldModel.ChangedToOrderItemName = newModel.ChangedToOrderItemName;
            oldModel.OldOrderItemId = null;
            oldModel.OldOrderItemHiddenId = null;
            oldModel.OldOrderItemNo = 0;
            oldModel.OldOrderItemCode = null;
            oldModel.OldOrderItemName = null;
            oldModel.OldOrderItemMoney = 0;

            oldModel.ChangedUserId = user.Id;
            oldModel.ChangedUserNo = user.No;
            oldModel.ChangedUserCode = user.Code;
            oldModel.ChangedUsername = user.Username;
            oldModel.ChangedUserFullName = user.FullName;
            oldModel.ChangedDateTime = RepositoryOrderItem.GetDateTime();
            if (oldModel.Action == EMgmtCase.None)
            {
                oldModel.Action = oldModel.IsSaved ? EMgmtCase.Update : EMgmtCase.Insert;
            }

            var isNewModelChanged = newModel.IsChanged;
            newModel.IsChanged = false;

            newModel.ChangedToOrderItemId = null;
            newModel.ChangedToOrderItemHiddenId = null;
            newModel.ChangedToOrderItemNo = 0;
            newModel.ChangedToOrderItemCode = null;
            newModel.ChangedToOrderItemName = null;
            newModel.Amount = 1;
            newModel.BackupPrice = 0;
            newModel.BackupDiscountedRate = 0;
            newModel.BackupDiscountedValue = 0;
            newModel.BackupMustPayMoney = 0;

            newModel.OldOrderItemId = oldModel.Id;
            newModel.OldOrderItemHiddenId = oldModel.HiddenId;
            newModel.OldOrderItemNo = oldModel.No;
            newModel.OldOrderItemCode = oldModel.Code;
            newModel.OldOrderItemName = oldModel.Name;
            newModel.OldOrderItemMoney = oldModel.MustPayMoney;

            if (isNewModelChanged)
            {
                newModel.Amount = amount;
                newModel.DiscountRate = discountRate;
                newModel.DiscountMoney = discountValue;
            }


            newModel.CalculateMoney();
            if (isTemp != newModel.IsTemporary)
            {
                ChangeToTempStatus(newModel, isTemp);
            }
            if (newModel.Action == EMgmtCase.None)
            {
                newModel.Action = newModel.IsSaved ? EMgmtCase.Update : EMgmtCase.Insert;
            }

            _viewOrderItems.RefreshData();

            EndChangeOrderItem();
        }

        private void RefrensOrderItemsOnClick(object sender, EventArgs e)
        {
            foreach (var item in ActiveOrderItems)
            {
                item.IsLinkingOld = false;
                item.IsLinkingNew = false;
            }
            _viewOrderItems.RefreshData();
        }

        private void OnSelectOrderFromItemClick(object sender, EventArgs e)
        {
            var orderId = SelectedOrderItem?.OrderId;
            Settings?.SelectOrderAction?.Invoke(orderId);
        }

        private void OnShowAllOrdersItemClick(object sender, EventArgs e)
        {
            IsShowAllOrderItems = true;
        }


        protected bool IsShowSelectOrderFromItem
        {
            get
            {
                if (SelectedOrderItem == null) return false;
                var isVisible = HasSelectedOrderItem && !IsAllowEditItem;
                return isVisible;
            }
        }

        protected bool IsShowShowAllOrdersItem
        {
            get
            {
                return !_chbIsShowAll.Checked;
            }
        }

        private void UpdateCellContextMenu(bool isInRowCell)
        {
            MniSelectOrderItem.Visible = IsShowMniSelectOrderItem;
            MniSelectOrderItemSteps.Visible = IsShowMniSelectOrderItemSteps;


            MniCancelChangeOrderItem.Visible = IsShowCancelChangeOrderItem;

            MniCancelChangeOrderItemSteps.Visible = IsShowCancelChangeOrderItemSteps;

            _mniReuseOrderItem.Visible = IsShowReuseOrderItemOrderItem;
           
            MniChangeOrderItem.Visible = IsShowMniChangeOrderItem;
            MniChangeOrderItemSteps.Visible = IsShowMniChangeOrderItemSteps;

            _mniEditOrderItem.Visible = IsShowMniEditOrderItem;
            MniBookLabo.Visible = IsShowMniBookLabo;
            _changeOrCancelSep.Visible = IsShowMniChangeOrderItem || IsShowMniChangeOrderItemSteps || IsShowMniSelectOrderItem || IsShowMniSelectOrderItemSteps || IsShowCancelChangeOrderItem || IsShowCancelChangeOrderItemSteps || IsShowSelectOrderFromItem || IsShowShowAllOrdersItem;

            _mniShowOldOrderItem.Visible = IsShowOldOrderItem;
            _mniShowNewOrderItem.Visible = IsShowNewOrderItem;
            _mniCompareNewOrderItem.Visible = IsShowCompareNewOrderItem;
            _mniCompareOldOrderItem.Visible = IsShowCompareOldOrderItem;
            _viewOrCompareItemSep.Visible = IsShowOldOrderItem || IsShowNewOrderItem || IsShowCompareNewOrderItem || IsShowCompareOldOrderItem || IsShowMniEditOrderItem || IsShowMniBookLabo;

            _mniChangeToTemporaryStatus.Visible = IsShowMniChangeToTemporaryStatus;
            _mniChangeToUseStatus.Visible = IsShowMniChangeToUseStatus;
            _changeStatusSep.Visible = IsShowMniChangeToTemporaryStatus || IsShowMniChangeToUseStatus;

            _mniRefrensOrderItems.Visible = IsShowRefrensOrderItems;

            _mniSelectOrderFromItem.Visible = IsShowSelectOrderFromItem;
            _mniShowAllOrdersItem.Visible = IsShowShowAllOrdersItem;

            _mniAssignConsultant.Visible = IsShowAssignConsultantItem;
            _mniAssignConsultantAssistant.Visible = IsShowAssignConsultantAssistantItem;

          
        }

        protected bool IsShowAssignConsultantItem
        {
            get
            {
                if (SelectedOrderItem == null) return false;
                var isVisible = HasSelectedOrderItem && IsAllowEditItem
                                && !SelectedOrderItem.IsDeleted
                                && (string.IsNullOrWhiteSpace(SelectedOrderItem.ConsultConsultantUserName) || RepositorySession.IsAdmin);
                if (isVisible)
                {
                    if (string.IsNullOrWhiteSpace(SelectedOrderItem.ConsultConsultantUserName))
                    {
                        _mniAssignConsultant.Text = "Gán BSTV";
                        _mniAssignConsultant.Tag = 1;
                    }
                    else
                    {
                        _mniAssignConsultant.Text = "Gán lại BSTV";
                        _mniAssignConsultant.Tag = 2;
                    }
                   
                }
                return isVisible;
            }
        }

        protected bool IsShowAssignConsultantAssistantItem
        {
            get
            {
                if (SelectedOrderItem == null) return false;
                var isVisible = HasSelectedOrderItem && IsAllowEditItem
                                && !SelectedOrderItem.IsDeleted
                                && (string.IsNullOrWhiteSpace(SelectedOrderItem.ConsultAssistantUserName) || RepositorySession.IsAdmin);
                if (isVisible)
                {
                    if (string.IsNullOrWhiteSpace(SelectedOrderItem.ConsultAssistantUserName))
                    {
                        _mniAssignConsultantAssistant.Text = "Gán TLBS";
                        _mniAssignConsultantAssistant.Tag = 1;
                    }
                    else
                    {
                        _mniAssignConsultantAssistant.Text = "Gán lại TLBS";
                        _mniAssignConsultantAssistant.Tag = 2;
                    }
                }
                return isVisible;
            }
        }

        private void OnAssignConsultantMenuItemClick(object sender, EventArgs e)
        {
            var consultant = _cbbSelectBSTV.SelectedUserAccount;
            if (consultant != null)
            {
                var item = SelectedOrderItem;
                if (item != null)
                {
                    XLoading.ShowLoading();
                    ApplyConsultantValues(item, consultant);
                    UpdateItem(item);
                    XLoading.CloseLoading();
                }
                else
                {
                    Msg.ShowInfo("Vui lòng dịch vụ!");
                }
            }
            else
            {
                Msg.ShowInfo("Vui lòng chọn Bác sĩ TV!");
            }
        }

        private void OnAssignConsultantAssistantMenuItemClick(object sender, EventArgs e)
        {
            var assistant = _cbbSelectTLTV.SelectedUserAccount;
            if (assistant != null)
            {
                var item = SelectedOrderItem;
              
                if (item != null)
                {
                    XLoading.ShowLoading();
                    ApplyConsultantAssistantValues(item, assistant);
                    UpdateItem(item);
                    XLoading.CloseLoading();
                }
                else
                {
                    Msg.ShowInfo("Vui lòng dịch vụ!");
                }               
            }
            else
            {
                Msg.ShowInfo("Vui lòng chọn Trợ lý TV!");
            }
        }

        private void ApplyConsultantValues(MEntityOrderItem item, IEntityUserAccountMin consultant)
        {
            item.ConsultConsultantUserName = consultant?.Username;
            item.ConsultConsultantFullName = consultant?.FullName;           
        }

        private void ApplyConsultantAssistantValues(MEntityOrderItem item, IEntityUserAccountMin assistant)
        {
            item.ConsultAssistantUserName = assistant?.Username;
            item.ConsultAssistantFullName = assistant?.FullName;
        }

        private void UpdateItem(MEntityOrderItem item)
        {
            var isUpdate = item.IsSaved;
            var dateTime = RepositoryOrderItem.GetDateTime();
            if (isUpdate)
            {
                RepositorySession.ApplyUpdatedBasicFields(item, dateTime);
                var rs = RepositoryOrderItem.Update(item);
                if (rs > 0)
                {
                    Msg.ShowUpdateSuccessInfo("dịch vụ", true);
                    Settings?.OnEndSaveOrderItemAction?.Invoke(new MSaveOrderItem()
                    {
                        Item = item,
                        Case = EMgmtCase.Update
                    });
                }
                else
                {
                    Msg.ShowUpdateErrorInfo("dịch vụ");
                }
            }
            else
            {
               
            }
            _viewOrderItems.RefreshData();
        }

    }
}
