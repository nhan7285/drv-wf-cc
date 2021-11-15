using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using VegunSoft.Acc.Data.Enums;
using VegunSoft.App.Data.Business;
using VegunSoft.Base.View.Dev.UserControls;
using VegunSoft.Category.Entity.Provider.Category.Act;
using VegunSoft.Category.Entity.Provider.Category.Body;
using VegunSoft.Category.Repository.Categories;
using VegunSoft.Customer.Repository.Business;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums.Image;
using VegunSoft.Framework.Gui.Provider.WindowsForms;
using VegunSoft.Framework.Methods;
using VegunSoft.Labo.Model.Provider.Category;
using VegunSoft.Layer.EValue.Basic;
using VegunSoft.Layer.UcControl.Customer.Forms;
using VegunSoft.Layer.UcService.Provider.Any;
using VegunSoft.Layer.UcService.Provider.Models;
using VegunSoft.Order.Entity.Business.EntityOrder;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityLabo;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;
using VegunSoft.Order.Func.Provider.Methods.Business;
using VegunSoft.Order.Repository.Business;
using VegunSoft.Order.Repository.Business.Contract;
using VegunSoft.Product.Repository.Business.Material;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemLabos : UcBase
    {
        private bool _isLoaded;
  
        protected IRepositoryOrder RepositoryOrder { get; private set; }
        protected IRepositoryCustomer RepositoryCustomer { get; set; }
        protected IRepositoryOrderItem RepositoryOrderItem { get; private set; }
        private IRepositoryOrderItemStep _repositoryOrderItemProcessing;
        private IRepositoryOrderItemStepLabo _laboRepository;
        private bool _isLabosInited;
        protected IRepositoryTooth RepositoryTooth { get; private set; }
        private IRepositoryMaterialProvider _repositoryMaterialProvider;
        private IRepositoryMaterialProviderSetting _repositoryMaterialProviderSetting;

        private McMaterialRequest _vm = new McMaterialRequest();
        private IRepositoryMaterial _repositoryMaterial;
        private IRepositoryOrderItemStepLaboStatus _repositoryOrderItemStepMaterialStatus;
        private MEntityLabo _entity = new MEntityLabo();
        private bool bIsUpdateDatLabo = false;
        private int vIdDatLabo = 0;
        protected MUcCustomerLabo Settings { get; private set; }
        private bool _isReadOnly => Settings.IsReadOnlyFunc?.Invoke() ?? false;
        private List<OLaboBookingType> _laboBookingTypes = new List<OLaboBookingType>()
        {
            new OLaboBookingType()
            {
                Id = "c03ab4f9-10da-4af9-80f6-4924d5515d9e",
                No = 1,
                Name = "Làm mới"
            },
            new OLaboBookingType()
            {
                Id = "f5857b84-a050-45d4-a2fc-cfb4da6fe948",
                No = 2,
                Name = "Làm lại"
            },
            new OLaboBookingType()
            {
                Id = "074b5f2c-693d-459a-9721-38ad471ea2cf",
                No = 3,
                Name = "Bảo hành"
            }
        };


        public UcOrderItemLabos()
        {
            components = new System.ComponentModel.Container();
            InitializeComponent();
            CacheConfigs();
        }

      

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, Keys keyData)
        {
            if (keyData == XFromKey.ShowInfoForm)
            {
                ShowHidePrice();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        

        public void CheckAndInit(MUcCustomerLabo settings)
        {
            Settings = settings;
            CheckAndInit();
          
        }

        private void CheckAndInit()
        {
            if (!_isLoaded)
            {
                InitFields();
                SetIcons();
                ConfigControls();
                ShowHidePrice();
                Load_LoboTypes();
                _vm.Init(this.ParentForm, components, _grid, _view, _gcLaboMaterialName, null, null, null);
                _isLoaded = true;
                LoadPrintModes();

            }
          
        }

        private List<MEntityTooth> _listTeeth;
        public List<MEntityTooth> ListTeeth
        {
            get
            {
                if (_listTeeth == null)
                {
                    _listTeeth = RepositoryTooth.GetActiveTeeth();
                }
                return _listTeeth;
            }
        }

        public bool CheckAndInit(string formName,
            IEntityOrderItemStepMin step, bool isAnyReadOnly, string assistantId = "", bool isAutoCreate = true)
        {
            CheckAndInit();
            var item = !string.IsNullOrWhiteSpace(step?.OrderItemId) ? RepositoryOrderItem.Find(step?.OrderItemId) : null;

            if (item == null)
            {
                Msg.ShowError($"Không tìm thấy dịch vụ {step?.OrderItemId} - {step?.OrderItemName}");
                return false;
            }

            var customer = !string.IsNullOrWhiteSpace(step?.CustomerId) ? RepositoryCustomer.Find(step?.CustomerId) : null;
            if (customer == null)
            {
                Msg.ShowError($"Không tìm thấy khách hàng {step?.CustomerDisplayCode} - {step?.CustomerFullName}");
                return false;
            }

            var order = !string.IsNullOrWhiteSpace(item?.OrderId) ? RepositoryOrder.Find(item.OrderId): null;
            if (order == null)
            {
                Msg.ShowError($"Không tìm thấy đơn hàng {item?.OrderId}");
                return false;
            }

            var teeth = item.GetTeeth(ListTeeth);
            CheckAndInit(new MUcCustomerLabo()
            {
                FormName = formName,
                GetSelectedAssistantFunc = () => assistantId,
                GetSelectedCustomerFunc = () => customer,
                GetSelectedOrderFunc = () => order,
                GetSelectedOrderItemFunc = () => item,
                IsReadOnlyFunc = () => isAnyReadOnly,
                GetTeethFunc = () => ListTeeth,
                GetSelectedTeethFunc = () => teeth,
                IsAutoCreate = isAutoCreate
            });
            return true;
        }


        public void InitLabos()
        {
            if (!_isLabosInited)
            {
                SetLaboIcons();
                Load_glkDMLabo();
                ConfigControls();

                Load_glkDMVatlieu();
                Load_glkTrangThai();
                ReadOnlyDatLabo(true);
                LoadLaboTooth();

                _isLabosInited = true;
            }
            LoadOrderItems();
            LoadOrderItemSteps();
            ResetLaboGrid();
            Load_gridDanhSachDatLabo();
            UpdateEnables();
        }

        private void Load_LoboTypes()
        {
            _cbbLaboPhanLoai.Properties.DataSource = _laboBookingTypes;
        }


        public void ResetLaboForm()
        {
            ResetValueDatLabo();
            ReadOnlyDatLabo(true);
        }

        private void SetLaboIcons()
        {
            var refreshImage = IconService.GetIcon<EResourceImage, Image>(EResourceImage.Refresh16);
            var serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            this._glkProvider.Properties.Buttons.AddRange(new EditorButton[] {
                new EditorButton(ButtonPredefines.Combo),
                new EditorButton(ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, refreshImage, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject6, "", null, null, true)});

            var serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            this._cbbLaboRang.Properties.Buttons.AddRange(new EditorButton[] {
                new EditorButton(ButtonPredefines.Combo),
                new EditorButton(ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, refreshImage, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject9, "", null, null, true)});

            var serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            this.glkDMVatlieu.Properties.Buttons.AddRange(new EditorButton[] {
                new EditorButton(ButtonPredefines.Combo),
                new EditorButton(ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, refreshImage, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject7, "", null, null, true)});

            var serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.glkTrangThai.Properties.Buttons.AddRange(new EditorButton[] {
                new EditorButton(ButtonPredefines.Combo),
                new EditorButton(ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, refreshImage, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject8, "", null, null, true)});

        }

        private void InitFields()
        {
            
            RepositoryTooth = DbIoc.GetInstance<IRepositoryTooth>();
            RepositoryOrder = DbIoc.GetInstance<IRepositoryOrder>();
            RepositoryCustomer = DbIoc.GetInstance<IRepositoryCustomer>();
            RepositoryOrderItem = DbIoc.GetInstance<IRepositoryOrderItem>();
            _repositoryOrderItemProcessing = DbIoc.GetInstance<IRepositoryOrderItemStep>();
            _repositoryMaterialProviderSetting = DbIoc.GetInstance<IRepositoryMaterialProviderSetting>();
            _laboRepository = DbIoc.GetInstance<IRepositoryOrderItemStepLabo>();
            _repositoryMaterial = DbIoc.GetInstance<IRepositoryMaterial>();
            _repositoryMaterialProvider = DbIoc.GetInstance<IRepositoryMaterialProvider>();
            _repositoryOrderItemStepMaterialStatus = DbIoc.GetInstance<IRepositoryOrderItemStepLaboStatus>();
        }

        private void SetIcons()
        {
            this.lnkSuaDatLabo.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Edit16);
            this.lnkXoaDatLabo.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Delete16);

            //this._btnLaboSelectMultiTeeth.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Treatment16);

        }

        private void ConfigControls()
        {
           
            _cbbSelectLaboCreatorDoctor.Scope = EUserAccountScope.BSĐT;
            _cbbSelectLaboCreatorDoctor.ReloadData();

            _cbbSelectLaboAssistant.Scope = EUserAccountScope.Assistant;
            _cbbSelectLaboAssistant.ReloadData();

            _cbbSelectOrderItem.Properties.ValueMember = nameof(MEntityOrderItem.Id);
            _glkOrderItemStep.Properties.ValueMember = nameof(MEntityOrderItemStep.Id);

            _cbbSelectOrderItem.Properties.DisplayMember = nameof(MEntityOrderItem.DisplayName);
            _glkOrderItemStep.Properties.DisplayMember = nameof(MEntityOrderItemStep.StepDisplayText);

           
            _view.OptionsSelection.CheckBoxSelectorField = nameof(MEntityOrderItemStep.IsSelected);
            //_gcSelect.FieldName = nameof(MEntityOrderItemStep.IsSelected);
            _gcStepId.FieldName = nameof(MEntityOrderItemStep.Id);
            _gcStepNo.FieldName = nameof(MEntityOrderItemStep.DisplayPriority);
            _gcStepDoctorFullName.FieldName = nameof(MEntityOrderItemStep.DoctorFullName);
            _gcStepAssistantFullName.FieldName = nameof(MEntityOrderItemStep.AssistantFullName);
            _gcStepContent.FieldName = nameof(MEntityOrderItemStep.StepDisplayText);

            glkTrangThai.Properties.ValueMember = nameof(MEntityOrderItemStepLaboStatus.Id);
            glkTrangThai.Properties.DisplayMember = nameof(MEntityOrderItemStepLaboStatus.Name);
            _gcLaboName.FieldName = nameof(MEntityOrderItemStepLaboStatus.Name);
            ConfigLaboColumns();
        }

        private void ConfigLaboColumns()
        {
            _gcLaboId.FieldName = nameof(MEntityLabo.Id);
            _gcLaboCategoryName.FieldName = nameof(MEntityLabo.ProviderName);
            _gcLaboGoal.FieldName = nameof(MEntityLabo.BookingTypeName);
            _gcLaboMaterialName.FieldName = nameof(MEntityLabo.MaterialName);
            _gcLaboColor.FieldName = nameof(MEntityLabo.PorcelainColor);
            _gcLaboTeeth.FieldName = nameof(MEntityLabo.ToothCodes);
            _gcLaboAmount.FieldName = nameof(MEntityLabo.Amount);
            _gcLaboRequestDate.FieldName = nameof(MEntityLabo.RequestDateTime);
            _gcLaboResponseDate.FieldName = nameof(MEntityLabo.ResponseDateTime);
            _gcLaboUsingDate.FieldName = nameof(MEntityLabo.UsingDateTime);
            _gcLaboWarrantyCard.FieldName = nameof(MEntityLabo.WarrantyCard);
            _gcLaboWarrantyYear.FieldName = nameof(MEntityLabo.WarrantyYear);
            _gcLaboPrice.FieldName = nameof(MEntityLabo.Price);
            _gcLaboTotalMoney.FieldName = nameof(MEntityLabo.TotalMoney);
            _gcLaboAssistantFullName.FieldName = nameof(MEntityLabo.AssistantFullName);
            _gcLaboNote.FieldName = nameof(MEntityLabo.Note);
            _gcLaboStatus.FieldName = nameof(MEntityLabo.StatusName);
            _gcLaboDoctorUserFullName.FieldName = nameof(MEntityLabo.DoctorUserFullName);
            _gcLaboOrderId.FieldName = nameof(MEntityLabo.OrderId);
            _gcLaboOrderItemName.FieldName = nameof(MEntityLabo.OrderItemName);
            _gcLaboOrderItemStepContent.FieldName = nameof(MEntityLabo.OrderItemStepContent);
            _gcLaboRootFee.FieldName = nameof(MEntityLabo.TotalMoney);
            _gcLaboFeeFinal.FieldName = nameof(MEntityLabo.TotalMoneyFinal);
        }

        public void ResetLaboGrid()
        {
            _grid.DataSource = null;
            _view.RefreshData();
        }

        private void Load_gridDanhSachDatLabo()
        {

            _grid.DataSource = null;
            if (SelectedCustomer != null)
            {
                var customerId = SelectedCustomer.Id;
                _grid.DataSource = _laboRepository.Where(nameof(MEntityLabo.CustomerId), customerId).ToList();
            }

            _view.RefreshData();
        }

        private string GetRangId(string valueRang)
        {
            var listDMRang = Settings?.GetTeethFunc?.Invoke() ?? new List<MEntityTooth>();
            var r = listDMRang.FirstOrDefault(i => i.ID.ToString() == valueRang);
            if (r == null)
            {
                r = listDMRang.FirstOrDefault(i =>
                    i.TEN != null && valueRang != null && i.TEN.ToUpper().Equals(valueRang.ToUpper()));
            }
            if (r != null) return r.ID;
            return "0";
        }




        private void Save(bool isUpdate)
        {
            if (_isReadOnly)
            {
                Msg.ShowError("Bạn chỉ có quyền xem!");
                return;
            }
            if (_cbbSelectLaboCreatorDoctor.Text.Trim() == "")
            {
                Msg.ShowError(Class_Global._TBRangBuocChon("Bác sĩ"));
                _cbbSelectLaboCreatorDoctor.Focus();
                return;
            }
            else if (_glkProvider.Text.Trim() == "")
            {
                Msg.ShowError(Class_Global._TBRangBuocChon("Labo"));
                _glkProvider.Focus();
                return;
            }
            else if (glkDMVatlieu.Text.Trim() == "")
            {
                Msg.ShowError(Class_Global._TBRangBuocChon("vật liệu"));
                glkDMVatlieu.Focus();
                return;
            }
            else if (Convert.ToInt32(_calcAmount.EditValue) <= 0)
            {
                Msg.ShowError(Class_Global._TBRangBuocRong("số lượng"));
                _calcAmount.Focus();
                return;
            }
            else if (dtNgayDat.DateTime == DateTime.MinValue)
            {
                Msg.ShowError(Class_Global._TBRangBuocRong("ngày đặt"));
                dtNgayDat.Focus();
                return;
            }
            else if (glkTrangThai.Text.Trim() == "")
            {
                Msg.ShowError(Class_Global._TBRangBuocRong("trạng thái"));
                glkTrangThai.Focus();
                return;
            }
            else
            {
                var isClosedLoading = false;
                XLoading.ShowLoading();
                string vIdDatLabo = "0";

                //var mLog = new ObQTHT_System_Log()
                //{
                //    ID_FORM = _objQTHT_Form.ID,
                //    TEN_FORM = _objQTHT_Form.TEN,
                //    DOITUONG = "Đặt Labo"
                //};
                var m = Entity;
                if (isUpdate)
                {
                    //mLog.ACTION = ERights.SUA.ToString();
                    vIdDatLabo = m.Id;
                    RepositorySession.ApplyUpdatedBasicFields(m, _laboRepository.GetDateTime());
                    var rs = _laboRepository.Update(m);
                    if (rs > 0)
                    {
                        Msg.ShowInfo(Class_Global._tbCapNhapThanhCong, true);
                        //bIsUpdateDatLabo = false;
                    }
                    else
                    {
                        if (!isClosedLoading) XLoading.CloseLoading();
                        isClosedLoading = true;
                        Msg.ShowInfo(Class_Global._tbCapNhapLoi);

                    }
                }
                else
                {
                    // mLog.ACTION = ERights.THEM.ToString().ToString();
                    m.BranchId = RepositorySession.BranchId;
                    RepositorySession.ApplyCreatedBasicFields(m, _laboRepository.GetDateTime());
                    vIdDatLabo = _laboRepository.InsertGetInt(m).ToString();

                    if (!string.IsNullOrWhiteSpace(vIdDatLabo) && vIdDatLabo != "0")
                    {
                        m.Id = vIdDatLabo;
                        UpdateEnables();
                        // _messageService.ShowInfo(Class_Global._tbThemMoiThanhCong);
                        if (_cbAutoPrint.Checked)
                        {
                            if (!isClosedLoading) XLoading.CloseLoading();
                            AutoPrintLabo();
                            XLoading.ShowLoading();
                        }
                    }
                    else
                    {
                        if (!isClosedLoading) XLoading.CloseLoading();
                        isClosedLoading = true;
                        Msg.ShowInfo(Class_Global._tbThemMoiLoi);
                    }
                }

                ReadOnlyDatLabo(true);
                Load_gridDanhSachDatLabo();
                _view.FocusedRowHandle = _view.LocateByValue(nameof(MEntityLabo.Id), vIdDatLabo);
                _btnSave.Enabled = true;
                _btnSaveNew.Enabled = true;
                if (!isClosedLoading) XLoading.CloseLoading();
                isClosedLoading = true;
                _btnAdd.PerformClick();
                UpdateEnables();
            }
        }

        private void btnLuu_DatLabo_Click(object sender, EventArgs e)
        {
            Save(bIsUpdateDatLabo);
        }

        private void lnkXoaDatLabo_Click(object sender, EventArgs e)
        {
            if (CheckRightsService.CheckCanDelete(SessionCode, Settings?.FormName, true))
            {
                if (Msg.IsAgree(Class_Global._tbXoa) )
                {

                    XLoading.ShowLoading();
                    MEntityLabo _obj = ((MEntityLabo)_view.GetFocusedRow());
                    var isSuccess = _laboRepository.Delete(_obj.Id);
                    if (!isSuccess)
                    {

                        XLoading.CloseLoading();
                        Msg.ShowInfo(Class_Global._tbThemMoiLoi);
                    }
                    else
                    {

                        Load_gridDanhSachDatLabo();
                        XLoading.CloseLoading();
                    }


                }
            }
        }

        protected void ShowPrintPreview(IReport rpt)
        {
            new ReportPrintTool(rpt).ShowPreview();
        }

        protected void PrintLabo(IReport rpt)
        {
            if (IsShowPrintOptions)
            {
                new ReportPrintTool(rpt).PrintDialog();
            }
            else if (IsShowPrintPreviews)
            {
                ShowPrintPreview(rpt);
            }
            else
            {
                try
                {
                    new ReportPrintTool(rpt).Print();
                }
                catch (Exception ex)
                {
                    new ReportPrintTool(rpt).PrintDialog();
                }

            }
        }

        private void AutoPrintLabo()
        {
            var entity = Entity;
            if (!string.IsNullOrWhiteSpace(entity?.Id))
            {
                var report = GuiIoc.GetInstance<ILaboReport>().Init(Entity);
                var rpt = report as XtraReport;
                rpt.PrintingSystem.StartPrint += (sender, e) =>
                {
                    e.PrintDocument.PrinterSettings.Copies = 2;
                };
                rpt.PrintingSystem.ShowMarginsWarning = false;
                rpt.ShowPrintMarginsWarning = false;
                try
                {
                    PrintLabo(rpt);
                    //report.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tự động in labo!.");
                }
            }
            else
            {
                Msg.ShowError("Vui lòng chọn labo để in!");
            }
        }


        private void _btnPrintLabo_Click(object sender, EventArgs e)
        {
            if (CheckRightsService.CheckCanPrint(SessionCode, Settings?.FormName, true))
            {
                if (_view.FocusedRowHandle >= 0)
                {
                    var entity = Entity;
                    if (!string.IsNullOrWhiteSpace(entity?.Id))
                    {
                       
                        //XLoading.ShowLoading();
                        var report = GuiIoc.GetInstance<ILaboReport>().Init(entity);
                        PrintLabo(report);
                        //ReportPrintTool tool = new ReportPrintTool(report);
                        //XLoading.CloseLoading();
                        //tool.ShowPreviewDialog();
                    }
                    else
                    {
                        Msg.ShowError("Vui lòng chọn labo để in!");
                    }
                  
                }
                else
                {
                    MessageBox.Show("Bạn vui lòng chọn phiếu labo để in.");
                }
            }
            else
            {
                MessageBox.Show("Bạn không đủ quyền để in phiếu labo.");
            }
        }

        private void _btnAdd_DatLabo_Click(object sender, EventArgs e)
        {
            if (CheckRightsService.CheckCanAdd(SessionCode, Settings?.FormName, true))
            {
                if (SelectedCustomer == null || SelectedCustomer.Id == "")
                {
                    Msg.ShowError("Vui lòng chọn khách hàng!");
                    return;
                }
                else
                {
                    _btnSave.Enabled = false;
                    _btnSaveNew.Enabled = true;
                    ReadOnlyDatLabo(false);
                    bIsUpdateDatLabo = false;
                    ResetValueDatLabo();

                    var d = _repositoryMaterial.GetDateTime().Date;
                    dtNgayDat.DateTime = d;
                    dtNgayGiao.DateTime = d.AddDays(1);
                    dtNgayHen.DateTime = d.AddDays(2);
                    _cbbSelectLaboCreatorDoctor.EditValue = RepositorySession.Username;
                    _cbbLaboPhanLoai.EditValue = "c03ab4f9-10da-4af9-80f6-4924d5515d9e";


                    _cbbSelectOrderItem.EditValue = SelectedOrderItem?.Id;
                    _glkOrderItemStep.EditValue = SelectedOrderItemStep?.Id;
                    _cbbSelectLaboAssistant.EditValue = Settings?.GetSelectedAssistantFunc?.Invoke();
                    if (_cbbSelectLaboAssistant.EditValue == null)
                    {
                        _cbbSelectLaboAssistant.Focus();
                    }
                    else
                    {
                        _glkProvider.Focus();
                    }
                }
            }
        }

        private void _cbbLaboRang_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Glyph)
            {
                LoadLaboTooth();
            }
        }






        private void glkDMVatlieu_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Glyph)
            {
                Load_glkDMVatlieu();
            }
        }

        private void glkDMLabo_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Glyph)
            {
                Load_glkDMLabo();
            }
        }

        private void glkTrangThai_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Glyph)
            {
                Load_glkTrangThai();
            }
        }



        private void ResetValueDatLabo()
        {

            this.Entity = new MEntityLabo();
        }

        private void _cbbLaboRang_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.DisplayText))
            {
                e.DisplayText = e.Value?.ToString();
            }

        }

        
        private void LoadLaboTooth()
        {
            var tooth = RepositoryTooth.GetActiveTeeth();
            _cbbLaboRang.Properties.DataSource = tooth;
        }


        private void _cbbSelectOrder_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Delete)
            {
                _cbbSelectOrderItem.EditValue = null;
            }
            else if (e.Button.Kind == ButtonPredefines.Glyph)
            {
                LoadOrderItems();
            }
        }

        private void _glkOrderItemStep_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Delete)
            {
                _glkOrderItemStep.EditValue = null;
            }
            else if (e.Button.Kind == ButtonPredefines.Glyph)
            {
                LoadOrderItemSteps();
            }
        }

        private void cdtDonGia_EditValueChanged(object sender, EventArgs e)
        {
            if (_isSetting) return;
            CalcFees();
        }

        private void cdtSoLuong_EditValueChanged(object sender, EventArgs e)
        {
            if (_isSetting) return;
            CalcFees();
        }

        private void glkDMVatlieu_EditValueChanged(object sender, EventArgs e)
        {
            if (_isSetting) return;
            _calcUnitPrice.EditValue = GetPrice();
        }

        private void _glkProvider_EditValueChanged(object sender, EventArgs e)
        {
            if (_isSetting) return;
            _calcUnitPrice.EditValue = GetPrice();
        }

        private void ReadOnlyDatLabo(bool isAccpt)
        {
            var isAdmin = RepositorySession.IsAdmin;

            _cbbSelectLaboAssistant.Properties.ReadOnly = isAccpt;
            _cbbLaboPhanLoai.Properties.ReadOnly = isAccpt;

            _glkProvider.Properties.ReadOnly = isAccpt;

            _cbbSelectOrderItem.Properties.ReadOnly = isAccpt;
            glkDMVatlieu.Properties.ReadOnly = isAccpt;
            txtMauSu.Properties.ReadOnly = isAccpt;
            _cbbLaboRang.Properties.ReadOnly = isAccpt;
            _calcUnitPrice.Properties.ReadOnly = isAccpt;
            _calcAmount.Properties.ReadOnly = isAccpt;
            dtNgayDat.Properties.ReadOnly = isAccpt;
            dtNgayGiao.Properties.ReadOnly = isAccpt;
            dtNgayHen.Properties.ReadOnly = isAccpt;
            txtTheBH.Properties.ReadOnly = isAccpt;
            dtNamBH.Properties.ReadOnly = isAccpt;
            _txtNotes.Properties.ReadOnly = isAccpt;
            glkTrangThai.Properties.ReadOnly = isAccpt;
            _btnSave.Enabled = !isAccpt;


            _cbbSelectLaboCreatorDoctor.Properties.ReadOnly = !isAdmin || isAccpt;
        }

        private void _btnSaveNew_Click(object sender, EventArgs e)
        {
            Save(false);
        }

        private void _cbbSelectOrderItem_EditValueChanged(object sender, EventArgs e)
        {
            if (_isSetting) return;
            var orderItem = _cbbSelectOrderItem.GetSelectedDataRow() as MEntityOrderItem;
            LoadOrderItemSteps(SelectedCustomer?.Id, orderItem?.OrderId, orderItem?.Id);
            _glkOrderItemStep.EditValue = SelectedOrderItemStep?.Id;
            SelectTeeth(orderItem);

        }

        private void SelectTeeth(MEntityOrderItem orderItem)
        {
            if (orderItem == null)
            {
                _cbbLaboRang.EditValue = null;
                _cbbLaboRang.Text = null;
                return;
            }
            if (!string.IsNullOrWhiteSpace(orderItem.ProductServiceTargetId))
            {
                _cbbLaboRang.EditValue = orderItem.ProductServiceTargetId;
            }
            else if (!string.IsNullOrWhiteSpace(orderItem.ProductServiceTargetName))
            {
                _cbbLaboRang.Text = orderItem.ProductServiceTargetName;
            }
        }


        private void _btnLaboSelectMultiTeeth_Click(object sender, EventArgs e)
        {
            var selectedTeeth = Settings?.GetSelectedTeethFunc?.Invoke() ?? new List<MEntityTooth>();
            var oTeeth = GuiIoc.GetInstance<Form>(EFormMgmt.FShowTeeth.ToString());
            var iTeeth = oTeeth as IFShowTeeth;
            iTeeth.SelectedTeeth = selectedTeeth;
            oTeeth.ShowDialog();
            selectedTeeth = iTeeth.SelectedTeeth;
            var names = selectedTeeth.Select(x => x.TEN).ToList();
            _cbbLaboRang.Text = string.Join("; ", names);
        }

        private void viewDanhSachDatLabo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void lnkSuaDatLabo_Click(object sender, EventArgs e)
        {

            if (CheckRightsService.CheckCanEdit(SessionCode, Settings?.FormName, true))
            {
                XLoading.ShowLoading();
                ReadOnlyDatLabo(true);
                _btnSave.Enabled = true;
                _btnSaveNew.Enabled = true;
                bIsUpdateDatLabo = true;
                var id = ((MEntityLabo)_view.GetFocusedRow()).Id;
                this.Entity = _laboRepository.Find(id);
                ReadOnlyDatLabo(false);
                XLoading.CloseLoading();
            }
            else
            {
                XLoading.ShowLoading();
                _btnSave.Enabled = false;
                _btnSaveNew.Enabled = false;
                ReadOnlyDatLabo(true);
                var id = ((MEntityLabo)_view.GetFocusedRow()).Id;
                this.Entity = _laboRepository.Find(id);
                XLoading.CloseLoading();
            }
        }

        private void UcBookLabo_Load(object sender, EventArgs e)
        {
            if (Settings?.IsAutoCreate ?? false)
            {
                InitLabos();
                _btnAdd.PerformClick();
            }
        }

        private List<MEntityPrintMode> _printModes;
        protected List<MEntityPrintMode> PrintModes => _printModes ?? (_printModes = GetPrintModes());

        private List<MEntityPrintMode> GetPrintModes()
        {
            var rs = new List<MEntityPrintMode>();
            foreach (EPrintModes m in (EPrintModes[])Enum.GetValues(typeof(EPrintModes)))
            {
                rs.Add(new MEntityPrintMode()
                {
                    Id = m.ToString(),
                    Name = m.GetText(),
                });
            }
            return rs;
        }

        private void LoadPrintModes()
        {
            _cbbAutoPrintMode.Properties.ValueMember = nameof(MEntityPrintMode.Id);
            _cbbAutoPrintMode.Properties.DisplayMember = nameof(MEntityPrintMode.Name);

            _cbbAutoPrintMode.Properties.DataSource = PrintModes;
            _cbbAutoPrintMode.ItemIndex = 2;
        }
    }
}
