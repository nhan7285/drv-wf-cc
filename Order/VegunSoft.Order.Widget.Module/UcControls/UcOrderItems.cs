using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports.UI;
using VegunSoft.Acc.Data.Enums;
using VegunSoft.Acc.Entity.Provider.Acc;
using VegunSoft.Acc.Repository.Business;
using VegunSoft.App.Data.Business;
using VegunSoft.App.Repository.Business.Cfg;
using VegunSoft.App.Repository.Business.Log;
using VegunSoft.App.View.Service.Services;
using VegunSoft.Base.View.Service.Services;
using VegunSoft.Category.Entity.Provider.Category;
using VegunSoft.Category.Entity.Provider.Category.Body;
using VegunSoft.Customer.Entity.Process;
using VegunSoft.Customer.Entity.Provider.Process;
using VegunSoft.Customer.Entity.Provider.Rating.Setting;
using VegunSoft.Customer.Repository.Business.Rating.Setting;
using VegunSoft.Customer.View.Forms;
using VegunSoft.Framework.Db.Enums.Data;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums.Image;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Methods;
using VegunSoft.Framework.Ioc;
using VegunSoft.Layer.Gui.Forms;
using VegunSoft.Layer.UcControl.Category;
using VegunSoft.Layer.UcControl.Customer.Forms;
using VegunSoft.Layer.UcService.Provider.Methods;
using VegunSoft.Layer.UcService.Provider.Models;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;
using VegunSoft.Order.Repository.Business;
using VegunSoft.Product.Entity.Provider.Business;
using VegunSoft.Product.Repository.Business;
using MEntityCustomer = VegunSoft.Customer.Entity.Provider.Profile.MEntityCustomer;
namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItems : UcOrderItemsBase
    {


        private bool _isLoaded;
        private bool _isInRowCell;
      

        protected override GridView ViewOrderItems => _viewOrderItems;



        private IMgmtViewService _viewSerivce;

        protected bool IsUpdatingOrder { get; set; } = false;

        protected List<MEntityOrder> ScopedOrders { get; set; } = new List<MEntityOrder>();


        protected bool bHasChange_Hosodieutri_CT { get; set; } = false;


        private MEntityOrder _order { get; set; } = new MEntityOrder();
        private bool _cbbProductServiceLoading;

        public IEntityCustomerStageMin Transfer { get; private set; }
        public bool IsInProcess { get; private set; }
        protected MUcOrderItems Settings { get; private set; }

        protected List<GridColumn> AllowEditColumns { get; private set; }

        protected List<GridColumn> AllowContextGridColumns { get; private set; }

        protected List<GridColumn> AllowChangeTeethColumns { get; private set; }

        public List<MEntityTooth> ListTeeth
        {
            get
            {
                if (_glkTooth == null) return new List<MEntityTooth>();
                return _glkTooth.Properties.DataSource as List<MEntityTooth> ?? new List<MEntityTooth>();
            }
        }

        public IEntityCustomerStageMin SelectedTransfer =>
            Settings?.GetSelectedTransferFunc.Invoke() ?? new MEntityCustomerStageMin();

        public UcOrderItems()
        {
            InitializeComponent();
        }

        public void CheckAndInit(MUcOrderItems settings)
        {
            if (!_isLoaded)
            {
                Settings = settings;
                InitFields();
                SetIcons();
                ConfigControls();
                SetOrderDetailContextMenus();
                CreateDetailCellContextMenu();
                LoadTeeth();
                ApplyTooltip();
                _isLoaded = true;
            }

            InitWorkingTime();
        }

        private void ApplyTooltip()
        {
            _gridOrderItems.ApplyTooltipController<MEntityOrderItem>(new List<string>()
            {
                nameof(MEntityOrderItem.OrderId),
                nameof(MEntityOrderItem.ProductServiceName),
                nameof(MEntityOrderItem.ProductServiceTargetName),
            }, (entity) =>
            {
                //var hasConsultDoctorUserName = !string.IsNullOrWhiteSpace(entity.ConsultantUserName);
                //var hasConsultDoctorFullName = !string.IsNullOrWhiteSpace(entity.ConsultantFullName);
                //var hasConsultAssistantUserName = !string.IsNullOrWhiteSpace(entity.ConsultingAssistantUserName);
                //var hasConsultAssistantFullName = !string.IsNullOrWhiteSpace(entity.ConsultingAssistantFullName);
                //var hasProductServiceTypeName = !string.IsNullOrWhiteSpace(entity.ProductServiceTypeName);
                //var hasProductServiceGroupName = !string.IsNullOrWhiteSpace(entity.ProductServiceGroupName);
                //var hasProductServiceGroupFinalName = !string.IsNullOrWhiteSpace(entity.ProductServiceGroupFinalName);
                //var rs = hasConsultDoctorUserName || hasConsultDoctorFullName || hasConsultAssistantUserName || hasConsultAssistantFullName;
                return true;
            }, (entity) =>
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Loại: {entity.ProductServiceTypeName}");
                sb.AppendLine($"Nhóm: {entity.ProductServiceGroupName}");
                sb.AppendLine($"Phân nhóm: {entity.ProductServiceGroupFinalName}");
                sb.AppendLine($"--------------------------------------------------");
                sb.AppendLine($"BSTV: {entity.ConsultConsultantUserName} -  {entity.ConsultConsultantFullName}");
                sb.AppendLine($"TLBS: {entity.ConsultAssistantUserName} -  {entity.ConsultAssistantFullName}");
                sb.AppendLine($"BSĐT: {entity.WorkerUsername} -  {entity.WorkerFullName}");
                sb.AppendLine($"PT: {entity.WorkerAssistantUsername} -  {entity.WorkerAssistantFullName}");
                sb.AppendLine($"--------------------------------------------------");
                sb.AppendLine($"Người tạo: {entity.CreatedUsername} -  {entity.CreatedUserFullName}");
                sb.AppendLine($"Ngày tạo: {entity.CreatedDate?.ToString("dd/MM/yyyy HH:mm:ss")}");
                sb.AppendLine($"Người cập nhật: {entity.UpdatedUsername} -  {entity.UpdatedUserFullName}");
                sb.AppendLine($"Ngày cập nhật: {entity.UpdatedDate?.ToString("dd/MM/yyyy HH:mm:ss")}");
                return sb.ToString();
            });
        }

        private void InitFields()
        {


            _repositorySystemException = DbIoc.GetInstance<IRepositorySystemException>();
            _userAccountRepository = DbIoc.GetInstance<IRepositoryUserAccount>();
            _dentistryServiceRepository = DbIoc.GetInstance<IRepositoryPdsv>();
            _repositoryProductServiceSetting = DbIoc.GetInstance<IRepositoryPdsvSetting>();


            _configRepository = DbIoc.GetInstance<IRepositoryConfig>();
            _viewSerivce = XIoc.GetService(CGui.IocKey).GetInstance<IMgmtViewService>();
            _ratingServiceTask = DbIoc.GetInstance<IRepositoryRatingServiceTask>();
            _repositoryCustomerConsultancy = DbIoc.GetInstance<IRepositoryCustomerConsultancy>();
        }

        private void SetIcons()
        {
            var refreshImage = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Refresh16);

            //btnDieutri.Image = _iconService.GetIcon<EResourceImage, Image>(EResourceImage.Tooth16);
            //btnInHoSo.Image = _iconService.GetIcon<EResourceImage, Image>(EResourceImage.Print16);
            //btnLuuVaChuyen.Image = _iconService.GetIcon<EResourceImage, Image>(EResourceImage.Refresh16);
            //btnDatLichHen.Image = _iconService.GetIcon<EResourceImage, Image>(EResourceImage.Apt16);
            //btnChiDinhCLS.Image = _iconService.GetIcon<EResourceImage, Image>(EResourceImage.CLS16);
            //lnkXoaDieuTriCT.Image = _iconService.GetIcon<EResourceImage, Image>(EResourceImage.Delete16);
            //lnkDieuTri.Image = _iconService.GetIcon<EResourceImage, Image>(EResourceImage.Tooth16);

            //this._btnSelectTeeth.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Select16);
            //this._btnAddProductServiceToOrder.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Select16);
            //this._btnAddProductService.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Add16);
            //this.btnThemMoi.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.BookNew16);
            //this.btnLuuDieuTri.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Status16);
            //this._lnkCompare.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Status16);

            var serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this._cbbProductService.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, refreshImage, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});

            var serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this._glkTooth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, refreshImage, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});

        }

        private void ConfigControls()
        {
            ConfigOrderItemColumns();
            ConfigProductServiceBox();
            ConfigFolderBox();
            _glkTooth.Properties.ValueMember = nameof(MEntityTooth.ID);
            _glkTooth.Properties.DisplayMember = nameof(MEntityTooth.TEN);

            _cbbSelectAssistant.Scope = EUserAccountScope.Assistant;
            _cbbSelectTLTV.Scope = EUserAccountScope.ActiveUsing;
            _cbbSelectTelesalesUser.Scope = EUserAccountScope.ActiveUsing;

            _cbbSelectBSTV.Scope = EUserAccountScope.ActiveUsing;
            _cbbSelectFollower.Scope = EUserAccountScope.ActiveUsing;
            _viewOrderItems.ApplyOrderItemStyle();
            DictDetailColumns = _viewOrderItems.CacheColumnIndexes();

            _txtConsultDate.Properties.NullDate = DateTime.MinValue;
            _txtConsultDate.Properties.NullText = String.Empty;
            r_dtNgayHoanTat.NullDate = DateTime.MinValue;
            r_dtNgayHoanTat.NullText = String.Empty;

            _cbbSelectBSTV.ReloadData();
            _cbbSelectTLTV.ReloadData();
            _cbbSelectFollower.ReloadData();


        }



        private void ConfigFolderBox()
        {
            _glkFolder.Properties.ValueMember = nameof(MEntityOrder.Id);
            _glkFolder.Properties.DisplayMember = nameof(MEntityOrder.Name);
            _gcFolderName.FieldName = nameof(MEntityOrder.Name);
        }

        private void ConfigProductServiceBox()
        {
            _gcProductServiceId.FieldName = nameof(MEntityPdsv.Code);
            _gcProductServiceName.FieldName = nameof(MEntityPdsv.Name);
            _gcProductServicePrice.FieldName = nameof(MEntityPdsv.DisplayPrice);
            _gcProductServiceGroupDisplayName.FieldName = nameof(MEntityPdsv.GroupDisplayName);
            _gcProductServiceUnsignKeyword.FieldName = nameof(MEntityPdsv.UnsignKeywords);
            _gcProductServiceCompactKeywords.FieldName = nameof(MEntityPdsv.CompactKeywords);
            _cbbProductService.Properties.ValueMember = nameof(MEntityPdsv.Id);
            _cbbProductService.Properties.DisplayMember = nameof(MEntityPdsv.Name);

            var searchColumnFields = new string[]
            {
                nameof(MEntityPdsv.Code),
                nameof(MEntityPdsv.Name),
                nameof(MEntityPdsv.DisplayPrice),
                nameof(MEntityPdsv.GroupDisplayName),
                nameof(MEntityPdsv.UnsignKeywords),
                nameof(MEntityPdsv.CompactKeywords)
            };
            _viewProductService.ApplyContainsSearch(searchColumnFields);
        }

        public void AddProductService()
        {
            _btnAddProductServiceToOrder.PerformClick();
        }

        private void ShowMinMaxPrice(bool isReset)
        {
            _cbbProductService.ShowMinMaxPrice(_lblDynamicPrice, _txtDynamicPrice, _lblMinPrice, _txtMinPrice, _lblMaxPrice, _txtMaxPrice, isReset);
        }

        public void ResetCustomerTreatmentData()
        {
            this.Order = GetNewOrder();
            //_chkIsFolder.Checked = false;
            _gridOrderItems.DataSource = null;
            txtIdRang.EditValue = 0;
            _txtOrderItemId.EditValue = null;
            _glkTooth.EditValue = 0;
            _cbbProductService.EditValue = null;
            _cbbSelectAssistant.EditValue = null;
            lblListRangChon.Text = "";
            ShowMinMaxPrice(true);
            AllowConsultEditors(false);
        }

        private void _btnAddProductService_Click(object sender, EventArgs e)
        {
            var f = GuiIoc.GetInstance<Form>(EFormCategory.FMgmtService.ToString());
            f.WindowState = FormWindowState.Maximized;
            var fi = f as IFMgmtProductService;
            fi.IsSimpleAddMode = true;
            //var f = new FMgmtService
            //{
            //    WindowState = FormWindowState.Maximized,
            //    IsSimpleAddMode = true
            //};
            f.ShowDialog();
            LoadProductServices();
            if (f.Tag is MEntityPdsv model)
            {
                _cbbProductService.EditValue = model.Id;
            }
        }

        private void _txtOrderCreatedDate_DoubleClick(object sender, EventArgs e)
        {
            if (IsDoubleClickEdit)
            {
                _txtConsultDate.Properties.ReadOnly = false;
                _txtConsultDate.Enabled = true;
            }

        }

        private void _cbbSelectFollower_DoubleClick(object sender, EventArgs e)
        {
            if (IsDoubleClickEdit)
            {
                _cbbSelectFollower.Properties.ReadOnly = false;
                _cbbSelectFollower.Enabled = true;
            }
        }

        private void _cbbSelectBSTV_DoubleClick(object sender, EventArgs e)
        {
            if (IsDoubleClickEdit)
            {
                _cbbSelectBSTV.Properties.ReadOnly = false;
                _cbbSelectBSTV.Enabled = true;
            }
        }

        private void _cbbSelectTeleSale_DoubleClick(object sender, EventArgs e)
        {
            if (IsDoubleClickEdit)
            {
                _cbbSelectTelesalesUser.Properties.ReadOnly = false;
                _cbbSelectTelesalesUser.Enabled = true;
            }
        }

        private void _cbbSelectTLTV_DoubleClick(object sender, EventArgs e)
        {
            if (IsDoubleClickEdit)
            {
                _cbbSelectTLTV.Properties.ReadOnly = false;
                _cbbSelectTLTV.Enabled = true;
            }
        }





        private void btnLuuVaChuyen_Click(object sender, EventArgs e)
        {
            try
            {
                CheckAndSave();
                Settings?.StartTransferAction?.Invoke(string.Empty, new object[] { Order, SelectedOrderItem });
            }
            catch (Exception ex)
            {
                _repositorySystemException.SaveException("TreatmentDoctor.OnSaveAndTransfer", "BSĐT: Lưu và chuyển", ex);
                MessageBox.Show(ex.Message);
            }

        }

        private bool IsValidPrice()
        {
            var isValid = true;
            var sb = new System.Text.StringBuilder();
            if (_cbbProductService.GetSelectedDataRow() is MEntityPdsv model && model.IsApplyMinMaxPrice && !string.IsNullOrWhiteSpace(model.Id))
            {
                var price = _txtDynamicPrice.GetDecimalValue();
                var minPrice = model.MinPrice;
                var maxPrice = model.MaxPrice;
                if (minPrice < maxPrice)
                {
                    if (price < minPrice)
                    {
                        isValid = false;
                        sb.AppendLine($"Giá phải >= {minPrice.ToString("#,##0")}");
                    }
                    if (price > maxPrice)
                    {
                        isValid = false;
                        sb.AppendLine($"Giá phải <= {maxPrice.ToString("#,##0")}");
                    }
                }
                else if (minPrice > maxPrice && maxPrice == 0)
                {
                    if (price < minPrice)
                    {
                        isValid = false;
                        sb.AppendLine($"Giá phải >= {minPrice.ToString("#,##0")}");
                    }
                }
                else if (minPrice == maxPrice && minPrice != 0)
                {
                    if (price != minPrice)
                    {
                        isValid = false;
                        sb.AppendLine($"Giá phải = {minPrice.ToString("#,##0")}");
                    }
                }
                else if (minPrice == maxPrice && minPrice == 0)
                {
                    if (price != minPrice)
                    {
                        isValid = false;
                        sb.AppendLine($"Giá phải = {minPrice.ToString("#,##0")}");
                    }
                }
            }
            if (!isValid)
            {
                Msg.ShowError(sb.ToString());
            }
            return isValid;
        }

        private void _cbbProductService_EditValueChanged(object sender, EventArgs e)
        {
            if (_cbbProductServiceLoading) return;
            ShowMinMaxPrice(false);
        }

        private void _btnAddProductServiceToOrder_Click(object sender, EventArgs e)
        {
            if (ReadOnly)
            {
                Msg.ShowError("Bạn chỉ có quyền xem!");
                return;
            }
            var isAdded = false;
            if (_glkTooth.EditValue.ToString() + "" == "" && SelectedTeeth.Count == 0)
            {
                Msg.ShowError("Chưa chọn răng để thêm. Vui lòng xem lại!");
                txtIdRang.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(_cbbProductService.Text))
            {
                Msg.ShowError("Chưa chọn dịch vụ để thêm. Vui lòng xem lại!");
                _cbbProductService.Focus();
                return;
            }

            var teeth = new List<MEntityTooth>();
            MEntityPdsv pdsv;

            if (HasManyTeeth)
            {

                if (IsValidPrice())
                {
                    pdsv = (MEntityPdsv)_cbbProductService.GetSelectedDataRow();
                    if (IsSplitTeeth)
                    {
                        foreach (MEntityTooth tooth in SelectedTeeth)
                        {
                            teeth.Add(tooth);
                        }
                    }
                    else
                    {
                        teeth.Add(GetToothFromTeeth(SelectedTeeth));
                    }
                    AddTeethToOrderItems(pdsv, teeth, 1);
                    isAdded = true;
                }
            }
            else
            {
                MEntityTooth ob = _glkTooth.GetSelectedDataRow() as MEntityTooth;
                if (IsValidPrice())
                {
                    pdsv = (MEntityPdsv)_cbbProductService.GetSelectedDataRow();
                    if (ob != null)
                    {
                        teeth.Add(ob);
                        AddTeethToOrderItems(pdsv, teeth, 1);
                        isAdded = true;
                    }
                }
            }
            if (isAdded)
            {
                LoadOrderItems();
                StartNewOrderItem();

            }

        }



        private void _viewOrderItems_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            var view = sender as GridView;
            if (e.Info is GridGroupRowInfo info && info.Column == _gcOrderItemIsArisingService)
            {
                bool v = view != null && Convert.ToBoolean(view.GetGroupRowValue(e.RowHandle, info.Column));
                info.GroupText = v ? "Dịch vụ phát sinh" : "Dịch vụ theo kế hoạch";
            }
        }

        private void _viewOrderItems_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;
            MEntityOrderItem ob = (MEntityOrderItem)_viewOrderItems.GetRow(_viewOrderItems.FocusedRowHandle);
            if (ob != null)
            {
                if (e.Column == _gcOrderItemDiscountRate && e.Value.ToString() != "")
                {
                    if (Convert.ToDouble(e.Value) > 100)
                        _viewOrderItems.SetFocusedRowCellValue(_gcOrderItemDiscountRate, 100);
                    else
                        ob.DiscountMoney = ob.TotalPrice * Convert.ToDecimal(e.Value) / 100;
                }

                if (e.Column == _gcOrderItemDiscountValue && e.Value.ToString() != "")
                {
                    ob.DiscountRate = ob.TotalPrice > 0 ? Convert.ToDecimal(e.Value) * 100 / ob.TotalPrice : 0;
                }

                if (e.Column == _gcOrderItemAmount)
                {
                    ob.Amount = Convert.ToInt32(e.Value);
                }

                ob.CalculateMoney();

                _viewOrderItems.RefreshData();
                LoadSumValues();
            }
        }

        private void _viewOrderDetails_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;
            MEntityOrderItem ob = (MEntityOrderItem)_viewOrderItems.GetRow(_viewOrderItems.FocusedRowHandle);
            if (ob != null)
            {
                if (e.Column == _gcOrderItemDiscountValue || e.Column == _gcOrderItemAmount || e.Column == _gcOrderItemDiscountRate)
                {
                    ob.CalculateMoney();
                }
            }

            LoadSumValues();
        }

        private void btnChiDinhCLS_Click(object sender, EventArgs e)
        {
            var transfer = SelectedTransfer;
            if (transfer != null)
            {
                var model = _userAccountRepository.FindT<MEntityUserAccountMin>(RepositorySession.Username);
                var fTransfer = GuiIoc.GetInstance<Form>(EFormMgmt.FMoveCustomerStage.ToString());
                var oTransfer = fTransfer as IFormCustomerStage;
                oTransfer.Init(this.ParentForm, transfer, true, Order, SelectedOrderItem);
                fTransfer.ShowDialog();

                if (oTransfer.IsMoved)
                {
                    var frm = GuiIoc.GetInstance<Form>(EFormMgmt.FBusCLS.ToString());
                    var fCls = frm as IFBusCLS;
                    fCls.Init(SelectedCustomer, model);
                    frm.ShowDialog();
                    Settings?.OnEndTransferAction?.Invoke();
                }
            }
        }

        private void OnSaveOrdersAndItems()
        {
            RunSaveDbSesion(GetSaveOrderConfig, SaveOrderAsync, DisplaySaveOrderResults, Settings.RootParent);

            return;
        }






        private void LoadTeeth()
        {
            _glkTooth.Properties.DataSource = RepositoryTooth.GetActiveTeeth();
            txtIdRang.EditValue = 0;
        }



        private void CheckAndInsertRating(List<MRatingServiceTask> tasks)
        {
            var thread = new Thread(() =>
            {
                try
                {
                    _ratingServiceTask.CheckAndInsert(tasks);
                }
                catch (Exception e)
                {
                    Msg.ShowError(e.Message + Environment.NewLine + e.ToString());
                }


            });
            thread.Start();
        }

        private MRatingServiceTask GetTask(MEntityOrderItem ob, List<MEntityOrderItemStep> histories)
        {
            MRatingServiceTask task = null;

            if (histories == null || histories.Count < 1) return task;
            var listRatingHistory = histories.Where(o => o.IsWaitingForRating).OrderBy(o => o.CreatedDate).ToList();

            var isAutoCreateRatingTasks = _configRepository.IsAutoCreateRatingTasks();
            var isAutoCreateRatingQuestions = _configRepository.IsAutoCreateRatingQuestions() && _cbbSendRating.Checked;

            if (listRatingHistory.Count > 0)
            {
                if (isAutoCreateRatingTasks)
                {
                    try
                    {
                        var order = Order;
                        task = new MRatingServiceTask()
                        {
                            TreatmentRecordsNo = Convert.ToInt32(order.Id),
                            TreatmentRecordsDate = order.ConsultingDate,
                            TreatmentRecordsItemNo = Convert.ToInt32(ob.Id),
                            CustomerId = order.CustomerId,
                            CustomerCode = order.CustomerCode,
                            CustomerNo = order.CustomerNo,
                            CustomerFullName = order.CustomerFullName,
                            CustomerPhoneNumber = order.CustomerPhoneNumber,
                            CustomerPrivateInfo = order.CustomerPrivateInfo,
                            TreatmentServiceId = ob.ProductServiceId,
                            IsGenerateQuestions = isAutoCreateRatingQuestions
                        };
                        _viewSerivce.PrepareBeforeSave<MRatingServiceTask>(task);
                    }
                    catch (Exception e)
                    {
                        Msg.ShowError(e.Message + Environment.NewLine + e.ToString());
                    }
                }
                // _objBSDT_Hosodieutri_CT.ID_DMDICHVU
                foreach (var history in listRatingHistory)
                {
                    history.IsWaitingForRating = false;
                }
            }
            return task;
        }

        private void btnInHoSo_Click(object sender, EventArgs e)
        {
            var order = Order;
            if (order?.IsSaved ?? false)
            {
                if (CheckRightsService.CheckCanPrint(SessionCode, Settings?.FormName, true))
                {
                    var model = SelectedCustomer;
                    List<MEntityCustomer> list = new List<MEntityCustomer>();
                    list.Add(model);
                    var rpt = GuiIoc.GetInstance<IOrderReport>().Init(Order);
                    rpt.DataSource = list;
                    ReportPrintTool printTool = new ReportPrintTool(rpt);
                    printTool.ShowPreview();
                }
            }
        }

        private decimal GetFinalPrice(MEntityPdsv obDichvu)
        {
            if (obDichvu != null)
            {
                if (obDichvu.IsApplyMinMaxPrice)
                {
                    return _txtDynamicPrice.GetDecimalValue();
                }
                return obDichvu.Price;
            }
            return 0;
        }

        private void _viewOrderItems_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            bHasChange_Hosodieutri_CT = true;
        }

        private void _glkTooth_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)
            {
                LoadTeeth();
            }
        }

        private void _cbbProductService_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Delete)
            {
                _cbbProductService.EditValue = null;
            }
            if (e.Button.Kind == ButtonPredefines.Glyph)
            {
                LoadProductServices();
            }
        }

        private void txtIdRang_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIdRang.EditValue?.ToString()))
            {
                MEntityTooth ob = ListTeeth?.Find(o => o.ID == txtIdRang.EditValue?.ToString());
                if (ob != null)
                {
                    _glkTooth.EditValue = ob.ID;
                }
            }
        }

        private void txtIdRang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtIdRang.SelectAll();
            }
        }

        private void txtIdDichVu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                _txtOrderItemId.SelectAll();
            }
        }

        private void txtIdDichVu_EditValueChanged(object sender, EventArgs e)
        {
            if (txtIdRang.Text.Trim() != "")
            {
                MEntityTooth ob = ListTeeth.Find(o => o.ID == txtIdRang.EditValue?.ToString());
                if (ob != null)
                {
                    _glkTooth.EditValue = ob.ID;
                }
            }
        }


        private void _btnSelectTeeth_Click(object sender, EventArgs e)
        {
            OnSelectTeeth();

        }

        private void _viewProductService_CustomColumnSort(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs e)
        {
            var textFilter = _cbbProductService.Text;
            if (e.Column == _gcProductServiceName && !string.IsNullOrEmpty(textFilter))
            {
                e.Handled = true;
                var name1 = e.Value1 as string;
                var indexOfTextFilterInName1 = name1.IndexOf(textFilter, StringComparison.CurrentCultureIgnoreCase);
                var name2 = e.Value2 as string;
                var indexOfTextFilterInName2 = name2.IndexOf(textFilter, StringComparison.CurrentCultureIgnoreCase);
                if (indexOfTextFilterInName1 < indexOfTextFilterInName2)
                {
                    e.Result = -1;
                }
                else if (indexOfTextFilterInName1 > indexOfTextFilterInName2)
                {
                    e.Result = 1;
                }
                else
                {
                    e.Result = string.Compare(name1, name2, StringComparison.CurrentCultureIgnoreCase);
                }
            }
        }



        private void _viewOrderItems_ShowingEditor(object sender, CancelEventArgs e)
        {
            var view = sender as GridView;
            view.OnOrderItemShowingEditor(e, _gcOrderItemDiscountValue, _gcOrderItemDiscountRate, _gcOrderItemAmount);
        }

        //private void AfterCloseHistories()
        //{
        //    var v = false;
        //    foreach (var orderItem in OrderItemStepsDict.Keys)
        //    {
        //        v = v || AfterHistoriesClose(orderItem);
        //    }

        //    _cbbSendRating.Enabled = v;
        //}

        //public bool AfterHistoriesClose(MEntityOrderItem orderItem)
        //{
        //    //_configRepository
        //    var v = false;
        //    var Dict = OrderItemStepsDict;
        //    var steps = Dict[orderItem];
        //    orderItem.IsInProgress = steps.Count > 0;
        //    v = v || steps.Any(l => l.IsWaitingForRating);
        //    RepositoryOrderItemStep.SyncValues(orderItem, steps);

        //    return v;

        //}


        private void OnDeleteOrderItem(object sender, EventArgs e)
        {
            _viewOrderItems.DeleteOrderItem(ReadOnly, OrderItemStepsDict, Settings?.FormName, AfterDeleteAction);
        }

        private void AfterDeleteAction(MEntityOrderItem obj)
        {
            LoadOrderItems();
        }



        private void _btnAddOrder_Click(object sender, EventArgs e)
        {
            StartNewOrder();
        }

        public void CheckAndSave()
        {
            if (bHasChange_Hosodieutri_CT
                || ((OrderItemStepsDict.Where(o => o.Key.Action == EMgmtCase.Delete).ToList().Count > 0
                     || OrderItemStepsDict.Where(o => o.Key.Action == EMgmtCase.Insert).ToList().Count > 0) && _viewOrderItems.OptionsBehavior.Editable == true))
            {
                if (Msg.IsAgree("Dữ liệu chưa được Lưu. Bạn có muốn Lưu không?\nChọn YES để Lưu. NO để Hủy!"))
                {
                    OnSaveOrdersAndItems();
                }
            }
            bHasChange_Hosodieutri_CT = false;
        }



        private void _viewOrderItems_RowClick(object sender, RowClickEventArgs e)
        {
            _allowShowContextMenu = true;
            //SelectedOrderItem = null;
            if (e.HitInfo != null)
            {

                _isInRowCell = e.HitInfo.InRowCell;
            }

            if (SelectedOrderItem != null && e.HitInfo.InRowCell)
            {
                if (e.Button == MouseButtons.Left && AllowContextGridColumns.Contains(e.HitInfo?.Column))
                {
                    ShowContextMenu();
                }
                if (e.Button == MouseButtons.Left && AllowChangeTeethColumns.Contains(e.HitInfo?.Column))
                {
                    if (!IsShowAll && IsAllowEditItem) ChangeTeeth();
                }
            }
        }

        public void LoadOrders()
        {
            ScopedOrders = RepositoryOrder.GetOrders<MEntityOrder>(SelectedCustomer?.Id).Where(x => !x.IsDraft).ToList();
            Settings?.EndLoadOrdersAction?.Invoke(SelectedCustomer?.Id, ScopedOrders, true);

        }




        public void SelectOrder(string orderId)
        {
            _chkIsFolder.Checked = false;
            IsShowAllOrderItems = false;
            _btnSaveOrderItem.Visible = false;
            StartNone();
            IsUpdatingOrder = true;
            var order = RepositoryOrder.Find(orderId);
            this.Order = order;

            var list = RepositoryOrderItem.GetOrderRows(order?.Id.ToString()).ToList();
            OrderItemStepsDict = new Dictionary<MEntityOrderItem, List<MEntityOrderItemStep>>();
            foreach (var item in list)
            {
                item.Action = EMgmtCase.Update;
                var h = RepositoryOrderItemStep.GetServiceHistories(item.Id).ToList();
                item.IsInProgress = h.Count > 0;
                OrderItemStepsDict.Add(item, h);
            }
            AllowTreatColumn(true);
            LoadOrderItems();

            UpdateControlsStatus();
            AllowCreateConsult(string.IsNullOrWhiteSpace(order?.ConsultingId));
            Settings?.FocusOrderAction?.Invoke(orderId);
            ApplyReadOnlyConsultEditors();
        }

        public void ShowAll()
        {
            StartNone();
            var customerId = SelectedCustomer?.Id;
            if (!string.IsNullOrWhiteSpace(customerId))
            {
                var list = RepositoryOrderItem.GetOrderItems<MEntityOrderItem>(customerId).ToList();
                _gridOrderItems.DataSource = null;
                _gridOrderItems.DataSource = list.Where(o => o.PlanNamePrefix != "Chỉ định CLS").ToList();
                _viewOrderItems.RefreshData();
            }
        }

        public void ResetShowAll()
        {
            StartNone();
            _gridOrderItems.DataSource = null;
        }

        private void _chbIsShowAll_CheckedChanged(object sender, EventArgs e)
        {
            var isShowAll = _chbIsShowAll.Checked;
            Settings?.ShowAllAction?.Invoke(isShowAll);

        }

        private void btnLuuDieuTri_Click(object sender, EventArgs e)
        {
            OnSaveOrdersAndItems();
        }

        protected MEntityOrderItem SelectedOrderItem =>
            _viewOrderItems.GetRow(_viewOrderItems.FocusedRowHandle) as MEntityOrderItem;

        public MEntityOrderItem WorkingOrderItem => SelectedOrderItem;



        private void _riceIsTemporary_CheckedChanged(object sender, EventArgs e)
        {
            var editor = sender as CheckEdit;
            if (editor != null)
            {
                var row = _viewOrderItems.GetRow(_viewOrderItems.FocusedRowHandle) as MEntityOrderItem;
                ChangeToTempStatus(row, editor.Checked);
            }
        }



        //public MEntityOrderItem SelectedOrderItem => _viewOrderItems.GetRow(_viewOrderItems.FocusedRowHandle) as 

        private void _lnkDieuTri_Click(object sender, EventArgs e)
        {
            var orderItem = (MEntityOrderItem)_viewOrderItems.GetRow(_viewOrderItems.FocusedRowHandle);
            if (orderItem != null)
            {
                if (orderItem.IsTemporary)
                {
                    if (Msg.IsAgree("Bạn có muốn chuyển dịch vụ sang trạng thái sử dụng?"))
                    {
                        ChangeToTempStatus(orderItem, false);
                        StartProcessOrderItem(orderItem, IsInProcess);
                    }
                }
                else
                {
                    StartProcessOrderItem(orderItem, IsInProcess);
                }
            }
        }

        public void SetIsShowAll(bool v)
        {
            IsShowAllOrderItems = v;
        }

        public void SetIsInProcess(bool v)
        {
            IsInProcess = v;
        }

        protected bool IsShowAllOrderItems
        {
            get
            {
                return _chbIsShowAll.Checked;
            }
            set
            {
                _chbIsShowAll.Checked = value;

                _gcOrderItemDelete.Visible = !value;
                _gcOrderItemProcess.Visible = !value;
            }
        }



        private void _viewOrderItems_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.RowHandle >= 0)
            {

                if (e.Column == _gcOrderItemProcess)
                {
                    var isChanged = Convert.ToBoolean(_viewOrderItems.GetRowCellValue(e.RowHandle, nameof(MEntityOrderItem.IsChanged)));
                    if (isChanged)
                    {
                        e.RepositoryItem = _lnkCompare;
                    }
                    else
                    {
                        e.RepositoryItem = _lnkDieuTri;
                    }
                }

                //_gcOrderItemProcess
            }
        }

        private void _lnkCompare_Click(object sender, EventArgs e)
        {
            var row = _viewOrderItems.GetRow(_viewOrderItems.FocusedRowHandle) as MEntityOrderItem;
            CompareNewOrderItem(row);
        }


        private void ApplyData(List<MEntityOrderItemStep> insertHistories, string profileId, string serviceId)
        {
            if (insertHistories == null || insertHistories.Count == 0) return;
            foreach (var h in insertHistories)
            {
                h.OrderId = profileId.ToString();
                h.OrderItemId = serviceId.ToString();

                h.IsService = true;

                var o = Order;
                h.TelesalesId = o?.TelesalesId;
                h.TelesalesNo = o?.TelesalesNo ?? 0;
                h.TelesalesCode = o?.TelesalesCode;
                h.TelesalesFullName = o?.TelesalesFullName;
                h.TelesalesUsername = o?.TelesalesUsername;

                h.ConnectorId = o?.ConnectorId;
                h.ConnectorNo = o?.ConnectorNo ?? 0;
                h.ConnectorCode = o?.ConnectorCode;
                h.ConnectorFullName = o?.ConnectorFullName;
                h.ConnectorUsername = o?.ConnectorUsername;

                h.CustomerId = o?.CustomerId;
                h.CustomerNo = o?.CustomerNo ?? 0;
                h.CustomerCode = o?.CustomerCode;
                h.CustomerFullName = o?.CustomerFullName;
                h.CustomerPhoneNumber = o?.CustomerPhoneNumber;
                h.CustomerPrivateInfo = o?.CustomerPrivateInfo;
            }
        }

        public void ApplyOrder(string vID)
        {

            this.Order = RepositoryOrder.Find(vID);
            OrderItemStepsDict = new Dictionary<MEntityOrderItem, List<MEntityOrderItemStep>>();
            var list = RepositoryOrderItem.GetOrderRows(vID).ToList();
            foreach (var item in list)
            {
                item.Action = EMgmtCase.Update;
                OrderItemStepsDict.Add(item, RepositoryOrderItemStep.GetServiceHistories(item.Id.ToString()).ToList());
            }

            LoadOrderItems();

            ApplyReadOnlyFollower();
            ApplyReadOnlyConsultEditors();
        }


        public void ResetCustomerData()
        {
            ScopedOrders = null;
            EndChangeOrderItem();
            AllowConsultEditors(false);
        }

        private void InitWorkingTime()
        {
            _dateWorkingTime.DateTime = RepositoryOrder.GetDateTime();
            _dateWorkingTime.Properties.ReadOnly = !CheckRightsService.CheckCanChangeWorkingDateTime(SessionCode, Settings?.FormName);
        }

        private void LoadProductServices()
        {
            _cbbProductServiceLoading = true;
            var productServices = _dentistryServiceRepository.Where(nameof(MEntityPdsv.IsService), true).OrderBy(x => x.GroupDisplayPriority)
                .Where(x => x.IsActive).ToList();
            var dateTime = _dateWorkingTime.DateTime;
            _cbbProductService.Properties.DataSource = _repositoryProductServiceSetting.GetProductServices(productServices, dateTime);
            _cbbProductServiceLoading = false;
        }

        private void _dateWorkingTime_EditValueChanged(object sender, EventArgs e)
        {
            LoadProductServices();
        }


        public void SelectCustomer(IEntityCustomerStageMin transfer)
        {
            this.Transfer = transfer;
            LoadFolders(transfer?.CustomerId);

        }

        private void ReloadFolders()
        {
            LoadFolders(Transfer?.CustomerId);
        }

        private void LoadFolders(string customerId)
        {
            var ds = string.IsNullOrWhiteSpace(customerId) ? null : RepositoryOrder.GetFolders(customerId);
            _glkFolder.Properties.DataSource = ds;
        }

        private void _lblFolder_Click(object sender, EventArgs e)
        {
            var folder = _glkFolder.GetSelectedDataRow() as MEntityOrder;
            if (folder != null)
            {
                SelectOrder(folder.Id);
            }
            else
            {
                Msg.ShowInfo("Vui lòng chọn đợt điều trị để chỉnh sửa!");
            }
        }

        private void _chkIsFolder_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControlsStatus();
        }

        private void UpdateControlsStatus()
        {
            new Thread(() =>
            {
                Thread.Sleep(200);
                this.Invoke(new Action(() =>
                {
                    var v = _chkIsFolder.Checked;
                    _glkFolder.Properties.ReadOnly = v;
                    _gridOrderItems.Enabled = !v;
                    _groupControlForm.Enabled = !v;
                    if (v) _glkFolder.EditValue = null;
                }));
            }).Start();

        }

        private void _glkFolder_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Delete)
            {
                _glkFolder.EditValue = null;
            }
        }

        private void _btnDelete_Click(object sender, EventArgs e)
        {
            var model = this.Order;
            if (model.IsSaved)
            {
                var allowDelete = false;
                if (model.IsFolder)
                {
                    var orders = RepositoryOrder.GetFolderOrders(model.Id);
                    if (orders.Count > 0)
                    {
                        Msg.ShowInfo("Vui lòng xóa hoặc di chuyển các hồ sơ trong đợt điều trị này trước khi xóa!");
                    }
                    else
                    {
                        allowDelete = true;
                    }
                }
                else
                {
                    var orderItems = RepositoryOrderItem.GetOrderRows(model.Id);
                    if (orderItems.Count > 0)
                    {
                        Msg.ShowInfo("Vui lòng xóa các dịch vụ trước!");
                    }
                    else
                    {
                        allowDelete = true;
                    }
                }

                if (allowDelete)
                {
                    if (CheckRightsService.CheckCanDelete(SessionCode, Settings?.FormName))
                    {
                        var name = model.IsFolder ? "đợt điều trị" : "hồ sơ";
                        var msg = $"Bạn có chắc chắn muốn xóa {name} này không?";
                        if (Msg.IsAgree(msg))
                        {
                            var rs = RepositoryOrder.Delete(model);
                            if (rs)
                            {
                                Msg.ShowDeleteSuccessInfo($"Xóa {name} thành công!", true);
                                _btnAddOrder.PerformClick();
                                LoadOrders();
                            }
                            else
                            {
                                Msg.ShowDeleteErrorInfo($"Xóa {name} thất bại, vui lòng thử lại!");
                            }
                        }
                    }
                    else
                    {
                        Msg.ShowInfo("Bạn không có quyền thực hiện thao tác này, vui lòng liên hệ quản trị viên!");
                    }
                }
            }
            else
            {
                _btnAddOrder.PerformClick();
            }
        }

        private void _glkFolder_Click(object sender, EventArgs e)
        {
            //if(_chkIsFolder.Checked && !_glkFolder.Properties.ReadOnly) UpdateControlsStatus();

        }

        private void StartProcessSavedOrderItem(MEntityOrderItem orderItem, bool isInProcess)
        {
            Settings.OnStartSavedTreatmentAction?.Invoke(orderItem, isInProcess);
        }

        private void StartProcessOrderItem(MEntityOrderItem orderItem, bool isInProcess)
        {

            if (orderItem != null)
            {
                if (orderItem.Action == EMgmtCase.Insert)
                {
                    Msg.ShowInfo("Vui lòng lưu hồ sơ trước!");
                }
                else
                {
                    StartProcessSavedOrderItem(orderItem, isInProcess);
                }

            }
        }

        private void AllowCreateConsult(bool b)
        {
            _chkCreateConsult.Enabled = b;
            _chkCreateConsult.Checked = b;
            _btnShowConsult.Enabled = !b;
        }

        private void _btnShowConsult_Click(object sender, EventArgs e)
        {
            var consultId = Order.ConsultingId;
            if (string.IsNullOrWhiteSpace(consultId))
            {
                Msg.ShowInfo("Không tìm thấy hồ sơ tư vấn!");
                return;
            }

            var model = _repositoryCustomerConsultancy.Find(consultId);
            var f = GuiIoc.GetInstance<IFConsultContent>();
            f.Apply(model);
            if (f is Form form)
            {
                form.StartPosition = FormStartPosition.CenterScreen;
                form.WindowState = FormWindowState.Maximized;
                form.Show();

            }
        }

        private MEntityOrderConsult CheckAndAddConsultancy(MEntityOrder order)
        {
            if (order == null) return null;
            var model = new MEntityOrderConsult();
            ApplyDefaultValues(model, order);
            var id = _repositoryCustomerConsultancy.InsertGetGuid(model);
            if (!string.IsNullOrWhiteSpace(id))
            {
                var consult = _repositoryCustomerConsultancy.Find(id);
                if (consult != null)
                {
                    order.ConsultingId = consult.Id;
                    order.ConsultingCode = consult.Code;
                    order.ConsultingName = consult.Name;
                    order.ConsultingNo = consult.No;

                    return consult;
                }
            }
            return null;
        }

        public void ApplyDefaultValues(MEntityOrderConsult model, MEntityOrder order)
        {
            var dateTime = _repositoryCustomerConsultancy.GetDateTime();

            model.Name = _txtName.Text;

            //var tooth = _glkTooth.GetSelectedDataRow() as MEntityTooth;
            //model.ServiceTargetId = tooth?.ID;
            //model.ServiceTargetName = tooth?.TEN;
            //model.ServiceTargetInfo = _btnSelectTeeth.Tag?.ToString();


            var consultingDoctor = _cbbSelectBSTV.SelectedUserAccount;
            model.ConsultingDoctorId = consultingDoctor?.Id;
            model.ConsultingDoctorNo = consultingDoctor?.No ?? 0;
            model.ConsultingDoctorCode = consultingDoctor?.Code;
            model.ConsultingDoctorUsername = consultingDoctor?.Username;
            model.ConsultingDoctorFullName = consultingDoctor?.FullName;

            var consultingAssistant = _cbbSelectTLTV.SelectedUserAccount;
            model.ConsultingAssistantId = consultingAssistant?.Id;
            model.ConsultingAssistantNo = consultingAssistant?.No ?? 0;
            model.ConsultingAssistantCode = consultingAssistant?.Code;
            model.ConsultingAssistantUsername = consultingAssistant?.Username;
            model.ConsultingAssistantFullName = consultingAssistant?.FullName;

            model.StartDateTime = model.CreatedDate;
            model.EndDateTime = dateTime;
            model.CreatedDate = model.CreatedDate;
            model.UpdatedDate = model.CreatedDate;

            var customer = SelectedCustomer;
            model.CustomerId = customer?.Id;
            model.CustomerNo = customer?.No ?? 0;
            model.CustomerCode = customer?.Code;
            model.CustomerPhoneNumber = customer?.PhoneNumber;
            model.CustomerFullName = customer?.FullName;
            model.CustomerPrivateInfo = customer?.PrivateInfo;

            RepositorySession.ApplyCreatedBasicFields(model, _repositoryCustomerConsultancy.GetDateTime());
        }

        private void _linkConsult_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var order = Order;
            var consultingId = order?.ConsultingId;
            if (!string.IsNullOrWhiteSpace(consultingId))
            {
                Settings?.ShowConsultAction?.Invoke(consultingId);
            }
            else
            {
                Msg.ShowInfo("Không tìm thấy hồ sơ tư vấn, vui lòng tạo!");
            }
        }

        private void _cbbSelectBSTV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_cbbSelectBSTV.EditValue?.ToString())) _cbbSelectBSTV.EditValue = RepositorySession.Username;
        }

        private void _cbbSelectTLTV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_cbbSelectTLTV.EditValue?.ToString())) _cbbSelectTLTV.EditValue = RepositorySession.Username;
        }

        private void _btnSaveOrderItem_Click(object sender, EventArgs e)
        {

            SaveUpdateOrderItem();
        }

        private void _glkTooth_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
