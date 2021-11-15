using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports.UI;
using VegunSoft.Acc.Data.Enums;
using VegunSoft.App.Data.Business;
using VegunSoft.Base.View.Dev.UserControls;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Drug.Entity.Provider.Business;
using VegunSoft.Drug.Repository.Business;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums.Image;
using VegunSoft.Framework.Gui.Enums.Message;
using VegunSoft.Framework.Gui.Models.Message;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Methods;
using VegunSoft.Framework.Methods;
using VegunSoft.Framework.Subscribe;
using VegunSoft.Layer.UcControl.Any.Provider.Boxes.GridLookup;
using VegunSoft.Layer.UcControl.Category;
using VegunSoft.Layer.UcControl.Customer.Forms;
using VegunSoft.Layer.UcService.Provider.Any;
using VegunSoft.Layer.UcService.Provider.Models;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Repository.Business;
using VegunSoft.Order.Repository.Business.Contract;
using VegunSoft.Order.View.Reports;
using VegunSoft.Prescription.Entity.Provider.Business;
using VegunSoft.Prescription.Repository.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcCustomerPrescription : UcBase
    {
        private bool _isLoaded;
       

        private IRepositoryOrder _repositoryOrder;
      
        private int vIdToaThuoc;
        private bool bIsUpdateToaThuoc = false;
        private List<MEntityOrderPrescription> _listPrescriptions;
        private Form _prescriptionTemplatesForm;
        private MEntityOrderPrescription _mObjBSDT_Toathuoc = new MEntityOrderPrescription();
        private List<MEntityOrderPrescriptionItem> listBSDT_Toathuoc_CT = new List<MEntityOrderPrescriptionItem>();
        private MEntityOrderPrescriptionItem _customerTreatmentPrescriptionDrug;
        private bool _isPrescriptionInited;
        private IRepositoryCustomerPrescription _prescriptionRepository;
        private IRepositoryCategoryDrug _repositoryCategoryDrug;
        private IPrescriptionTemplatesForm FMgmtPrescriptionTemplates => _prescriptionTemplatesForm as IPrescriptionTemplatesForm;
        private bool _isReadOnly => Settings.IsReadOnlyFunc?.Invoke() ?? false;
      
        private IRepositoryCustomerPrescriptionDetail _drugRepository;
        private IRepositoryPrescriptionTemplateDrug _repositoryPrescriptionTemplateDrug;
        private IRepositoryPrescriptionTemplate _repositoryPrescriptionTemplate;
        protected MUcCustomerPrescription Settings { get; private set; }
        public UcCustomerPrescription()
        {
            InitializeComponent();
        }

        #region Public Methods

        public void CheckAndInit(MUcCustomerPrescription settings)
        {
            if (!_isLoaded)
            {
                Settings = settings;
                InitFields();
                SetIcons();
                ConfigControls();
                _isLoaded = true;
            }
        }

        public void InitPrescriptions(string selectedCustomerId)
        {
            if (!_isPrescriptionInited)
            {

                LoadDataForControls();

                ReadOnlyToathuoc(true);
                _isPrescriptionInited = true;
            }
            _cbbSelectPrescriptionDoctor.Scope = EUserAccountScope.BSĐT;
            _cbbSelectPrescriptionDoctor.ReloadData();
            _cbbSelectPrescriptionDoctor.EditValue = RepositorySession.Username;
            Load_BSDT_Toathuoc(selectedCustomerId);
        }

        #endregion
     

        private void InitFields()
        {
      
            _repositoryOrder = DbIoc.GetInstance<IRepositoryOrder>();
            _prescriptionRepository = DbIoc.GetInstance<IRepositoryCustomerPrescription>();
            _repositoryCategoryDrug = DbIoc.GetInstance<IRepositoryCategoryDrug>();
            _drugRepository = DbIoc.GetInstance<IRepositoryCustomerPrescriptionDetail>();
            _repositoryPrescriptionTemplateDrug = DbIoc.GetInstance<IRepositoryPrescriptionTemplateDrug>();
            _repositoryPrescriptionTemplate = DbIoc.GetInstance<IRepositoryPrescriptionTemplate>();
        }

        private void SetIcons()
        {
            var refreshImage = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Refresh16);
            //this.lnkXoaToaCT.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Delete16);
            //this.btnUp.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Show16);
            //this.btnDown.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Show16);

            //this._btnResetDrugForm.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Refresh16);
            //this._btnShowPrescriptionTemplates.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Show16);
            //this._btnSaveDrugs.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Status16);
            //this._btnDeleteSelectedDrugs.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Delete16);
            //this._btnSelectPrescriptionTemplate.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Prescription16);
            //this._btnAddDrugs.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Add16);
            //this.btnInToathuoc.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Print16);
            //this.btnThemMoiToaThuoc.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Add16);
            //this.btnLuuToaThuoc.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Status16);
            //this.lnkSuaToaThuoc.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Edit16);
            //this.lnkXoaToaThuoc.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Delete16);

            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            this._cbbPrescriptionTemplate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
                new DevExpress.XtraEditors.Controls.EditorButton(),
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, refreshImage, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});

            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            this._cbbDrugs.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
                new DevExpress.XtraEditors.Controls.EditorButton(),
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, refreshImage, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", null, null, true)});
        }

        private void ConfigControls()
        {
            SetPrescriptionDrugFields();
            SetPrescriptionColumnFields();
            SetPrescriptionTemplateColumnsField();
            SetCategoryDrugColumnsField();
            var unitControls = new SBoxObjectUnit[]
            {
                _cbbCategoryUnit,
                _cbbMorningCategoryUnit,
                _cbbNoonCategoryUnit,
                _cbbAfternoonCategoryUnit,
                _cbbNightCategoryUnit
            };
            ConfigCategoryUnitBox(_cbbCategoryUnit, unitControls);
            ConfigCategoryUnitBox(_cbbMorningCategoryUnit, unitControls);
            ConfigCategoryUnitBox(_cbbNoonCategoryUnit, unitControls);
            ConfigCategoryUnitBox(_cbbAfternoonCategoryUnit, unitControls);
            ConfigCategoryUnitBox(_cbbNightCategoryUnit, unitControls);
            ConfigCategoryDrugUsingBox(_cbbCategoryDrugUsing);
            _cbbSelectPrescriptionDoctor.Scope = EUserAccountScope.BSĐT;
            _btnShowPrescriptionTemplates.Click+=BtnShowPrescriptionTemplatesOnClick;
            gridBSDT_Toathuoc_CT.MouseDown+=GridBsdtToathuocCtOnMouseDown;
            
        }

        private void SetPrescriptionColumnFields()
        {
            _gcPrescriptionId.FieldName = nameof(MEntityOrderPrescription.Id);
            _gcPrescriptionCreatedDate.FieldName = nameof(MEntityOrderPrescription.CreatedDate);
        }

        private void SetPrescriptionDrugFields()
        {
            _gcPrescriptionDrugIndex.FieldName = nameof(MEntityOrderPrescriptionItem.DisplayPriority);
            _gcPrescriptionDrugName.FieldName = nameof(MEntityOrderPrescriptionItem.DrugName);
            _gcPrescriptionDrugQuantity.FieldName = nameof(MEntityOrderPrescriptionItem.Quantity);
            _gcPrescriptionDrugUsing.FieldName = nameof(MEntityOrderPrescriptionItem.Description);
            _gcPrescriptionDrugIsFromTemplate.FieldName = nameof(MEntityOrderPrescriptionItem.IsFromTemplate);
        }

        private void SetPrescriptionTemplateColumnsField()
        {
            _cbbPrescriptionTemplate.Properties.DisplayMember = nameof(MEntityPrescriptionTemplate.Name);
            _cbbPrescriptionTemplate.Properties.ValueMember = nameof(MEntityPrescriptionTemplate.Id);
            _gccPrescriptionTemplateId.FieldName = nameof(MEntityPrescriptionTemplate.Id);
            _gccPrescriptionTemplateName.FieldName = nameof(MEntityPrescriptionTemplate.Name);
        }

        private void SetCategoryDrugColumnsField()
        {
            _gccCategoryDrugName.FieldName = nameof(MEntityCategoryDrug.Name);
            _gccCategoryDrugUnitName.FieldName = nameof(MEntityCategoryDrug.CategoryUnitName);
            _gccCategoryDrugUsingName.FieldName = nameof(MEntityCategoryDrug.CategoryDrugUsingName);

            _cbbDrugs.Properties.DisplayMember = nameof(MEntityCategoryDrug.Name);
            _cbbDrugs.Properties.ValueMember = nameof(MEntityCategoryDrug.Id);
        }

        private void CheckEnableSaveDrugsButton(bool isCheck = false, bool isEnable = false)
        {
            var b = _cbbDrugs.EditValue != null && !string.IsNullOrWhiteSpace(_cbbDrugs.Text);
            if (b)
            {
                if (isCheck)
                {
                    b = isEnable;
                }
            }

            _btnSaveDrugs.Enabled = b && _customerTreatmentPrescriptionDrug != null;
        }

        public void ResetPrescriptionForm()
        {
            _cbbSelectPrescriptionDoctor.EditValue = null;
            memoChuanDoanToaThuoc.EditValue = null;
            dtNgayToaThuoc.EditValue = null;

            ResetValueToathuocCT();
            ReadOnlyToathuoc(true);
        }

        private void ResetValueToathuocCT()
        {
            _txtDrugQuanttity.EditValue = null;
            _cbbPrescriptionTemplate.EditValue = null;
            _cbbCategoryUnit.EditValue = null;
            _cbbDrugs.EditValue = null;
            _txtCategoryDrugUsingTimes.Text = null;
            _cbbCategoryDrugUsing.EditValue = null;
            _txtDrugNote.EditValue = null;
            _cbbMorningCategoryUnit.EditValue = null;
            _cbbNoonCategoryUnit.EditValue = null;
            _cbbAfternoonCategoryUnit.EditValue = null;
            _cbbNightCategoryUnit.EditValue = null;
            _txtDrugQuanttityMorning.Text = null;
            _txtDrugQuanttityNoon.Text = null;
            _txtDrugQuanttityAfternoon.Text = null;
            _txtDrugQuanttityNight.Text = null;
            _customerTreatmentPrescriptionDrug = null;

            Msg?.ClearMessages();
            CheckEnableSaveDrugsButton();
        }

        private void ReadOnlyToathuoc(bool isAcpt)
        {
            _cbbSelectPrescriptionDoctor.Properties.ReadOnly = isAcpt;
            memoChuanDoanToaThuoc.ReadOnly = isAcpt;
            dtNgayToaThuoc.ReadOnly = isAcpt;
            //if (Session.IsAdmin)
            //{
            //    dtNgayToaThuoc.ReadOnly = false;
            //    _cbbSelectPrescriptionDoctor.Properties.ReadOnly = false;
            //}
            _cbbDrugs.ReadOnly = isAcpt;
            _cbbPrescriptionTemplate.ReadOnly = isAcpt;

            _cbbCategoryDrugUsing.ReadOnly = isAcpt;
            _txtDrugNote.ReadOnly = isAcpt;
            _cbbMorningCategoryUnit.ReadOnly = isAcpt;
            _cbbNoonCategoryUnit.ReadOnly = isAcpt;
            _cbbAfternoonCategoryUnit.ReadOnly = isAcpt;
            _cbbNightCategoryUnit.ReadOnly = isAcpt;
            _txtDrugQuanttityMorning.ReadOnly = isAcpt;
            _txtDrugQuanttityNoon.ReadOnly = isAcpt;
            _txtDrugQuanttityAfternoon.ReadOnly = isAcpt;
            _txtDrugQuanttityNight.ReadOnly = isAcpt;
            _txtCategoryDrugUsingTimes.ReadOnly = isAcpt;
            _txtDrugQuanttity.ReadOnly = isAcpt;
            _cbbCategoryUnit.ReadOnly = isAcpt;

            //_btnSelectPrescriptionTemplate.Enabled = !isAcpt;
            btnLuuToaThuoc.Enabled = !isAcpt;
            _btnAddDrugs.Enabled = !isAcpt;
            viewBSDT_Toathuoc_CT.OptionsBehavior.Editable = !isAcpt;

            CheckEnableApplyPrescriptionTemplateButton(true, !isAcpt);
            CheckEnableDeleteSelectedDrugsButton(true, !isAcpt);
            CheckEnableAddDrugsButton(true, !isAcpt);
            CheckEnableSaveDrugsButton(true, !isAcpt);
            CheckEnableUpButton(true, !isAcpt);
            CheckEnableDownButton(true, !isAcpt);
        }

        private void GridBsdtToathuocCtOnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                var view = viewBSDT_Toathuoc_CT;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Location);
                if (hitInfo.InRow)
                {
                    var rowHandle = hitInfo.RowHandle;
                    var m = view.GetRow(rowHandle) as MEntityOrderPrescriptionItem;
                    OnSelectDrugFromGrid(m);
                }
                else
                {

                }
            }
        }

        private void OnSelectDrugFromGrid(MEntityOrderPrescriptionItem model)
        {
            _customerTreatmentPrescriptionDrug = model;
            LoadDrugData(model);
            CheckEnableSaveDrugsButton();
            CheckEnableUpButton();
            CheckEnableDownButton();

        }

        private void LoadDrugData(MEntityOrderPrescriptionItem drug)
        {
            _cbbDrugs.EditValue = !string.IsNullOrWhiteSpace(drug.DrugId) && drug.DrugId != "0" ? drug.DrugId : drug.DrugName;

            _txtCategoryDrugUsingTimes.EditValue = drug.CategoryDrugUsingTimes;
            _cbbCategoryDrugUsing.EditValue = !string.IsNullOrWhiteSpace(drug.CategoryDrugUsingId) && drug.CategoryDrugUsingId != "0" ? drug.CategoryDrugUsingId : drug.CategoryDrugUsingName;

            _txtDrugQuanttity.EditValue = drug.Quantity;

            _cbbCategoryUnit.EditValue = !string.IsNullOrWhiteSpace(drug.CategoryUnitId) && drug.CategoryUnitId != "0" ? drug.CategoryUnitId : drug.CategoryUnitName;

            _txtDrugQuanttityMorning.EditValue = drug.MorningQuantity;

            _cbbMorningCategoryUnit.EditValue = !string.IsNullOrWhiteSpace(drug.MorningCategoryUnitId) && drug.MorningCategoryUnitId != "0" ? drug.MorningCategoryUnitId : drug.MorningCategoryUnitName;

            _txtDrugQuanttityNoon.EditValue = drug.NoonQuantity;

            _cbbNoonCategoryUnit.EditValue = !string.IsNullOrWhiteSpace(drug.NoonCategoryUnitId) && drug.NoonCategoryUnitId != "0" ? drug.NoonCategoryUnitId : drug.NoonCategoryUnitName;

            _txtDrugQuanttityAfternoon.EditValue = drug.AfternoonQuantity;

            _cbbAfternoonCategoryUnit.EditValue = !string.IsNullOrWhiteSpace(drug.AfternoonCategoryUnitId) && drug.AfternoonCategoryUnitId != "0" ? drug.AfternoonCategoryUnitId : drug.AfternoonCategoryUnitName;

            _txtDrugQuanttityNight.EditValue = drug.NightQuantity;
            _cbbNightCategoryUnit.EditValue = !string.IsNullOrWhiteSpace(drug.NightCategoryUnitId) && drug.NightCategoryUnitId != "0" ? drug.NightCategoryUnitId : drug.NightCategoryUnitName;

            drug.Note = _txtDrugNote.EditValue?.ToString();

        }


        private void BtnShowPrescriptionTemplatesOnClick(object sender, EventArgs e)
        {

            ShowPrescriptionTemplatesForm();
        }

        private void ShowPrescriptionTemplatesForm()
        {
            if (_prescriptionTemplatesForm == null)
            {
                _prescriptionTemplatesForm = GuiIoc.GetInstance<Form>(EFormMgmt.PrescriptionTemplatesForm.ToString());
                _prescriptionTemplatesForm.FormClosing += (sender, args) =>
                {
                    var model = _prescriptionTemplatesForm.Tag as MEntityPrescriptionTemplate;
                    if (model != null)
                    {
                        _cbbPrescriptionTemplate.EditValue = model?.Id;
                    }

                    _prescriptionTemplatesForm.Hide();
                    args.Cancel = true;

                };
                _prescriptionTemplatesForm.StartPosition = FormStartPosition.CenterScreen;
            }

            FMgmtPrescriptionTemplates.Init(_cbbPrescriptionTemplate.EditValue?.ToString());
            _prescriptionTemplatesForm.ShowDialog();
        }

        private void ConfigCategoryUnitBox(SBoxObjectUnit control, params SBoxObjectUnit[] relatedControls)
        {
            control.SameDataSourceControls = relatedControls;
        }

        private void ConfigCategoryDrugUsingBox(SBoxDrugUsing control)
        {

        }

        public MEntityCustomer SelectedCustomer
        {
            get { return Settings.GetSelectedCustomerFunc?.Invoke(); }
        }

        private void btnThemMoiToaThuoc_Click(object sender, EventArgs e)
        {
            
            if (SelectedCustomer == null || SelectedCustomer.Id == "")
            {
                Msg.ShowError("Vui lòng chọn khách hàng!");
                return;
            }
            else
            {

                listBSDT_Toathuoc_CT = new List<MEntityOrderPrescriptionItem>();
                Load_BSDT_Toathuoc_CT();
                ResetPrescriptionForm();

                ReadOnlyToathuoc(false);
                bIsUpdateToaThuoc = false;
                _cbbSelectPrescriptionDoctor.EditValue = RepositorySession.Username;
                dtNgayToaThuoc.DateTime = _prescriptionRepository.GetDateTime();
            }
        }

        private void _btnAddDrugs_Click(object sender, EventArgs e)
        {
            MEntityOrderPrescriptionItem ob = new MEntityOrderPrescriptionItem();
            if (_cbbDrugs.Text.Trim() != "")
            {
                ApplyDrugData(ob, true, false);

                MEntityCategoryDrug _obj = _repositoryCategoryDrug.Find(ob.DrugId);

                ob.CategoryUnitId = _obj.CategoryUnitId.ToString();
                ob.CategoryUnitName = _obj.CategoryUnitName;
                ob.DrugId = _obj.Id.ToString();
                if (_txtDrugQuanttity.Text != "")
                    ob.Quantity = Convert.ToInt32(_txtDrugQuanttity.Text);

                ob.DrugName = _obj.Name;
                ob.Pharmaceutical = _obj.Pharmaceutical;


                if (listBSDT_Toathuoc_CT.Any(o => o.DrugId == ob.DrugId) == false)
                {
                    listBSDT_Toathuoc_CT.Add(ob);
                    Load_BSDT_Toathuoc_CT();
                }
                else
                {
                    Msg.ShowError("tên thuốc này đã tồn tại!!");
                }
            }
            else
                Msg.ShowError("Vui lòng chọn hàng hóa!!");

            ResetValueToathuocCT();
        }

        private void btnLuuToaThuoc_Click(object sender, EventArgs e)
        {
            if (_isReadOnly)
            {
                Msg.ShowError("Bạn chỉ có quyền xem!");
                return;
            }
            if (listBSDT_Toathuoc_CT.Count <= 0)
            {
                Msg.ShowInfo("Phải có ít nhất 1 loại thuốc");
                return;
            }
            if (_cbbSelectPrescriptionDoctor.Text != "")
            {
                //var mLog = new ObQTHT_System_Log()
                //{
                //    ID_FORM = _objQTHT_Form.ID,
                //    TEN_FORM = _objQTHT_Form.TEN,
                //    DOITUONG = "Toa thuốc"
                //};
                var name = "toa thuốc";
                XLoading.ShowLoading();
                try
                {
                    if (!bIsUpdateToaThuoc)
                    {
                        //mLog.ACTION = ERights.THEM.ToString();
                        this._ObBSDT_Toathuoc.BranchId = RepositorySession.BranchId;
                        vIdToaThuoc = _prescriptionRepository.InsertGetInt(this._ObBSDT_Toathuoc);
                        if (vIdToaThuoc > 0)
                        {
                            foreach (var _ObToathuocCT in listBSDT_Toathuoc_CT)
                            {
                                _ObToathuocCT.PrescriptionId = vIdToaThuoc.ToString();
                                _ObToathuocCT.BranchId = this._ObBSDT_Toathuoc.BranchId;
                                _drugRepository.Insert(_ObToathuocCT);
                            }
                            XLoading.CloseLoading();
                            Msg.ShowInfo(Class_Global._tbThemMoiThanhCong, true);
                            bIsUpdateToaThuoc = true;

                        }
                        else
                        {
                            XLoading.CloseLoading();
                            Msg.ShowInsertErrorInfo(name);
                        }
                    }
                    else
                    {
                        // mLog.ACTION = ERights.SUA.ToString();

                        _drugRepository.DeleteMany(nameof(MEntityOrderPrescriptionItem.PrescriptionId), this._ObBSDT_Toathuoc.Id);


                        if (_prescriptionRepository.Update(_ObBSDT_Toathuoc) > 0)
                        {
                            foreach (var _ObToathuocCT in listBSDT_Toathuoc_CT)
                            {
                                vIdToaThuoc = Convert.ToInt32(this._ObBSDT_Toathuoc.Id);
                                _ObToathuocCT.PrescriptionId = this._ObBSDT_Toathuoc.Id;
                                _ObToathuocCT.BranchId = this._ObBSDT_Toathuoc.BranchId;
                                _drugRepository.Insert(_ObToathuocCT);

                            }
                            XLoading.CloseLoading();
                            Msg.ShowInfo(Class_Global._tbCapNhapThanhCong, true);
                        }
                        else
                        {
                            XLoading.CloseLoading();
                            Msg.ShowUpdateErrorInfo(name);
                        }
                    }
                }
                catch(Exception ex)
                {
                    XLoading.CloseLoading();
                    Msg.ShowException(ex);
                }
                
                // mLog.ID_DOITUONG = vIdToaThuoc.ToString();
                //_crudLog.Save(mLog);
            }
            else
            {
                Msg.ShowError(Class_Global._TBRangBuocChon("Bác sĩ ra toa"));
                _cbbSelectPrescriptionDoctor.Focus();
                return;
            }
            XLoading.ShowLoading();
            //int vIdTiepNhan = -1;
            //if (vGrid == 1)
            //    vIdTiepNhan = ((ObTiepnhan)viewDanhSachKhachHang.GetRow(viewDanhSachKhachHang.FocusedRowHandle)).ID;
            //else if (vGrid == 2)
            //    vIdTiepNhan = ((ObTiepnhan)viewDanhSachKhachHangCLS.GetRow(viewDanhSachKhachHangCLS.FocusedRowHandle)).ID;

            gridBSDT_Toathuoc_CT.DataSource = null;

            //Load_gridDanhSachKhachHang();

            //if (vGrid == 1)
            //    viewDanhSachKhachHang.FocusedRowHandle = viewDanhSachKhachHang.LocateByValue("ID", vIdTiepNhan);
            //else if (vGrid == 2)
            //    viewDanhSachKhachHangCLS.FocusedRowHandle = viewDanhSachKhachHangCLS.LocateByValue("ID", vIdTiepNhan);
            ReadOnlyToathuoc(true);
            Load_BSDT_Toathuoc(this._ObBSDT_Toathuoc.CustomerId);
            Load_BSDT_Toathuoc_CT(vIdToaThuoc);
            // FocusPrescriptionRow(vIdToaThuoc);
            viewDSToathuoc.FocusedRowHandle = viewDSToathuoc.LocateByValue(nameof(MEntityOrderPrescriptionItem.Id), vIdToaThuoc.ToString());
            XLoading.CloseLoading();
        }


        private void btnInToathuoc_Click(object sender, EventArgs e)
        {
            if (CheckRightsService.CheckCanPrint(SessionCode, Settings?.FormName, true))
            {
                if (viewDSToathuoc.FocusedRowHandle >= 0)
                {
                    var report = GuiIoc.GetInstance<IReportPrescription>().Init(_ObBSDT_Toathuoc.Id);
                    //var report = new rptToathuoc(_ObBSDT_Toathuoc.Id);
                    ReportPrintTool tool = new ReportPrintTool(report);
                    tool.ShowPreviewDialog();
                }
                else
                {
                    MessageBox.Show("Bạn vui lòng chọn toa thuốc để in.");
                }
            }
            else
            {
                MessageBox.Show("Bạn không đủ quyền để in toa thuốc.");
            }
        }

        private void viewDSToathuoc_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gridBSDT_Toathuoc_CT.DataSource = null;
            if (e.FocusedRowHandle >= 0)
            {
                int vId = Convert.ToInt32(((MEntityOrderPrescription)viewDSToathuoc.GetFocusedRow()).Id);
                this._ObBSDT_Toathuoc = _prescriptionRepository.Find(vId);
                Load_BSDT_Toathuoc_CT(vId);
            }
            else
            {
                this._ObBSDT_Toathuoc = new MEntityOrderPrescription();
                ResetValueToathuocCT();
            }
            ReadOnlyToathuoc(true);
        }



        private void _btnSelectPrescriptionTemplate_Click(object sender, EventArgs e)
        {
            if (_cbbPrescriptionTemplate.Text.Trim() != "")
            {
                var id = _cbbPrescriptionTemplate.EditValue;
                List<MEntityPrescriptionTemplateDrug> listToamau_Hanghoa = _repositoryPrescriptionTemplateDrug.Where(nameof(MEntityPrescriptionTemplateDrug.PrescriptionTemplateId), id).ToList();
                if (listToamau_Hanghoa != null)
                {
                    var isAdded = false;
                    foreach (MEntityPrescriptionTemplateDrug ob in listToamau_Hanghoa)
                    {
                        MEntityCategoryDrug _ObjHanghoa = _repositoryCategoryDrug.Find(ob.PrescriptionItemId);
                        if (_ObjHanghoa != null)
                        {
                            MEntityOrderPrescriptionItem obToathuocCT = GetNewCustomerDrug(ob, _ObjHanghoa.Name);
                            //ApplyDrugData(obToathuocCT, true, true);
                            if (!listBSDT_Toathuoc_CT.Any(o => o.DrugId == ob.PrescriptionItemId.ToString()))
                            {
                                listBSDT_Toathuoc_CT.Add(obToathuocCT);
                                isAdded = true;

                            }
                            else
                            {
                                //_messageService.ShowError("Hàng hóa này đã tồn tại!!");

                            }
                        }
                    }

                    if (isAdded)
                    {
                        Load_BSDT_Toathuoc_CT();
                    }
                }

                CheckEnableDeleteSelectedDrugsButton();
            }
        }

        private void _cbbPrescriptionTemplate_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {

                if (CheckRightsService.CheckCanShow(SessionCode, EFormMgmt.FMgmtSamplePrescriptions.GetFinalName(), true))
                {
                    var _frm = GuiIoc.GetInstance<Form>(EFormMgmt.FMgmtSamplePrescriptions.ToString());
                    var fo = _frm as IFMgmtSamplePrescriptions;
                    _frm.ShowDialog();
                    Load_glkDMToamau();
                    _cbbDrugs.EditValue = fo._objDMToamau.Id;
                }
            }
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)
            {
                Load_glkDMToamau();
            }
        }

        private void lnkXoaToaCT_Click(object sender, EventArgs e)
        {
            if (Msg.IsAgree(Class_Global._tbXoa))
            {
                MEntityOrderPrescriptionItem _obj = ((MEntityOrderPrescriptionItem)viewBSDT_Toathuoc_CT.GetFocusedRow());
                if (_obj.Id == "0" || string.IsNullOrWhiteSpace(_obj.Id) || CheckRightsService.CheckCanDelete(SessionCode, Settings?.FormName, true))
                {
                    //s vId = _obj.DrugId;
                    listBSDT_Toathuoc_CT.Remove(_obj);
                    Load_BSDT_Toathuoc_CT();
                }
            }
        }

        private void lnkSuaToaThuoc_Click(object sender, EventArgs e)
        {
            if (CheckRightsService.CheckCanEdit(SessionCode, Settings?.FormName, true))
            {
                bIsUpdateToaThuoc = true;
                var _id = ((MEntityOrderPrescription)viewDSToathuoc.GetFocusedRow()).Id;
                this._ObBSDT_Toathuoc = _prescriptionRepository.Find(_id);
                ReadOnlyToathuoc(false);
            }
        }

        private void lnkXoaToaThuoc_Click(object sender, EventArgs e)
        {
            if (CheckRightsService.CheckCanDelete(SessionCode, Settings?.FormName, true))
            {
                if (Msg.IsAgree(Class_Global._tbXoa))
                {
                    MEntityOrderPrescription _obj = ((MEntityOrderPrescription)viewDSToathuoc.GetFocusedRow());
                    var id = _obj.Id;
                    _drugRepository.DeleteMany(nameof(MEntityOrderPrescriptionItem.PrescriptionId), id);
                    _prescriptionRepository.Delete(id);


                    //var mLog = new ObQTHT_System_Log()
                    //{
                    //    ID_FORM = _objQTHT_Form.ID,
                    //    TEN_FORM = _objQTHT_Form.TEN,
                    //    DOITUONG = "Toa thuốc",
                    //    ACTION = ERights.XOA.ToString(),
                    //    ID_DOITUONG = id.ToString()
                    //};
                    // _crudLog.Save(mLog);
                    Load_BSDT_Toathuoc(SelectedCustomer.Id);
                }
            }
        }

        private void _cbbDrugs_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                if (CheckRightsService.CheckCanShow(SessionCode, EFormCategory.FMgmtCategoryDrugs.GetFinalName(), true))
                {
                    var _frm = GuiIoc.GetInstance<Form>(EFormCategory.FMgmtCategoryDrugs.ToString());
                    var fo = _frm as IFMgmtCategoryDrugs;
                    _frm.ShowDialog();
                    Load_glkDMHanghoa();
                    _cbbDrugs.EditValue = fo._objDMHanghoa.Id;
                }

            }
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)
            {
                Load_glkDMHanghoa();
            }

        }



        protected MEntityOrderPrescription _ObBSDT_Toathuoc
        {
            get
            {
                try
                {
                    _mObjBSDT_Toathuoc.CustomerId = SelectedCustomer.Id;
                    _mObjBSDT_Toathuoc.CustomerNo = SelectedCustomer.No;
                    _mObjBSDT_Toathuoc.CustomerCode = SelectedCustomer.Code;
                    _mObjBSDT_Toathuoc.CustomerFullName = SelectedCustomer.FullName;
                    _mObjBSDT_Toathuoc.CustomerPhoneNumber = SelectedCustomer.PhoneNumber;
                    _mObjBSDT_Toathuoc.CustomerPrivateInfo = SelectedCustomer.PrivateInfo;

                    _mObjBSDT_Toathuoc.CreatedDate = dtNgayToaThuoc.DateTime;
                    _mObjBSDT_Toathuoc.Description = memoChuanDoanToaThuoc.Text;
                    _mObjBSDT_Toathuoc.CreatedUsername = _cbbSelectPrescriptionDoctor.EditValue.ToString();
                    _mObjBSDT_Toathuoc.CreatedUserFullName = _cbbSelectPrescriptionDoctor.Text;
                }
                catch (Exception e)
                {
                    //TODO
                }

                return _mObjBSDT_Toathuoc;
            }
            set
            {
                try
                {
                    _mObjBSDT_Toathuoc = value;
                    dtNgayToaThuoc.DateTime = value.CreatedDate != null ? value.CreatedDate.Value : DateTime.MinValue;
                    memoChuanDoanToaThuoc.Text = value.Description;
                    _cbbSelectPrescriptionDoctor.EditValue = value.CreatedUsername;
                }
                catch (Exception e)
                {
                    //TODO
                }

            }
        }

        private void _cbbDrugs_EditValueChanged(object sender, EventArgs e)
        {
            if (_cbbDrugs.Text.Trim() != "")
            {
                MEntityCategoryDrug _obj = (MEntityCategoryDrug)_cbbDrugs.GetSelectedDataRow();

                _cbbCategoryUnit.EditValue = !string.IsNullOrWhiteSpace(_obj.CategoryUnitId) && _obj.CategoryUnitId != "0" ? _obj.CategoryUnitId : _obj.CategoryUnitName;

                _cbbCategoryDrugUsing.EditValue = !string.IsNullOrWhiteSpace(_obj.CategoryDrugUsingId) && _obj.CategoryDrugUsingId != "0" ? _obj.CategoryDrugUsingId : _obj.CategoryDrugUsingName;

                var usingUnitId = !string.IsNullOrWhiteSpace(_obj.UsingCategoryUnitId) && _obj.UsingCategoryUnitId != "0"
                    ? _obj.UsingCategoryUnitId
                    : _obj.CategoryUnitId;
                var usingUnitName = !string.IsNullOrWhiteSpace(_obj.UsingCategoryUnitName)
                    ? _obj.UsingCategoryUnitName
                    : _obj.CategoryUnitName;

                _cbbMorningCategoryUnit.EditValue = !string.IsNullOrWhiteSpace(usingUnitId) && usingUnitId != "0" ? usingUnitId : usingUnitName;
                _cbbNoonCategoryUnit.Text = !string.IsNullOrWhiteSpace(usingUnitId) && usingUnitId != "0" ? usingUnitId : usingUnitName;
                _cbbAfternoonCategoryUnit.Text = !string.IsNullOrWhiteSpace(usingUnitId) && usingUnitId != "0" ? usingUnitId : usingUnitName;


                _cbbNightCategoryUnit.Text = !string.IsNullOrWhiteSpace(usingUnitId) && usingUnitId != "0" ? usingUnitId : usingUnitName;
            }

            CheckEnableAddDrugsButton();
        }


        public void ResetPrescriptionGrid()
        {
            //_hasPrescriptions = false;
            gridDSToathuoc.DataSource = null;
            viewDSToathuoc.RefreshData();

        }

        private void Load_BSDT_Toathuoc(string vIdKhachHang)
        {
            gridDSToathuoc.DataSource = null;
            //_hasPrescriptions = false;
            if (!string.IsNullOrWhiteSpace(vIdKhachHang))
            {
                _listPrescriptions = _prescriptionRepository.Where(nameof(MEntityOrderPrescription.CustomerId), vIdKhachHang).ToList();
                gridDSToathuoc.DataSource = _listPrescriptions;
                //_hasPrescriptions = list.Count > 0;
            }
            else
            {
                _listPrescriptions = null;
            }

            viewDSToathuoc.RefreshData();
        }

        private void Load_BSDT_Toathuoc_CT()
        {
            _customerTreatmentPrescriptionDrug = null;
            gridBSDT_Toathuoc_CT.DataSource = listBSDT_Toathuoc_CT;
            viewBSDT_Toathuoc_CT.RefreshData();
            CheckEnableDeleteSelectedDrugsButton();
            CheckEnableUpButton();
            CheckEnableDownButton();
        }

        private void Load_BSDT_Toathuoc_CT(int vIdToaThuoc)
        {
            listBSDT_Toathuoc_CT = _drugRepository.Where(nameof(MEntityOrderPrescriptionItem.PrescriptionId), vIdToaThuoc).ToList();
            listBSDT_Toathuoc_CT = listBSDT_Toathuoc_CT.OrderBy(o => o.DisplayPriority).ToList();
            gridBSDT_Toathuoc_CT.DataSource = null;
            gridBSDT_Toathuoc_CT.DataSource = listBSDT_Toathuoc_CT;
            CheckEnableDeleteSelectedDrugsButton();
            CheckEnableUpButton();
            CheckEnableDownButton();
        }


        //Load danh sách hàng hóa GridLookUpEdit hàng hóa
        private void Load_glkDMHanghoa()
        {
            _cbbDrugs.Properties.DataSource = _repositoryCategoryDrug.Where(nameof(MEntityCategoryDrug.IsActive), true).ToList();
        }

        //Load danh sách hàng hóa GridLookUpEdit hàng hóa
        private void Load_glkDMToamau()
        {
            _cbbPrescriptionTemplate.Properties.DataSource = _repositoryPrescriptionTemplate.Where(nameof(MEntityPrescriptionTemplate.IsActive), true).ToList();
        }



        private void _btnResetDrugForm_Click(object sender, EventArgs e)
        {
            ResetValueToathuocCT();
        }

        private void _btnDeleteSelectedDrugs_Click(object sender, EventArgs e)
        {
            var isDeleteTemplateDrugsOnly = this._cbxIsDeleteTemplateDrugsOnly.Checked;
            var msg = "Bạn có muốn xóa các thuốc đã chọn?";
            if (isDeleteTemplateDrugsOnly) msg = "Bạn có muốn xóa các thuốc đã chọn thuộc toan mẫu?";
            if (Msg.IsAgree(msg))
            {
                //var drug = viewBSDT_Toathuoc_CT.GetFocusedRow() as MEntityCustomerPrescriptionDetail;
                if (listBSDT_Toathuoc_CT != null && listBSDT_Toathuoc_CT.Count > 0)
                {
                    if (isDeleteTemplateDrugsOnly)
                    {
                        listBSDT_Toathuoc_CT = listBSDT_Toathuoc_CT.Where(item =>
                             !item.IsFromTemplate).ToList();

                    }
                    else
                    {
                        listBSDT_Toathuoc_CT = listBSDT_Toathuoc_CT.Where(item =>
                            item.Id != "0" && !string.IsNullOrWhiteSpace(item.Id)).ToList();
                        if (CheckRightsService.CheckCanDelete(SessionCode, Settings?.FormName, false))
                        {
                            listBSDT_Toathuoc_CT.Clear();
                        }


                    }
                    Load_BSDT_Toathuoc_CT();
                }

            }
        }

        private void _cbbPrescriptionTemplate_EditValueChanged(object sender, EventArgs e)
        {
            CheckEnableApplyPrescriptionTemplateButton();
        }

        private void CheckEnableApplyPrescriptionTemplateButton(bool isCheck = false, bool isEnable = false)
        {
            var b = _cbbPrescriptionTemplate.EditValue != null && !string.IsNullOrWhiteSpace(_cbbPrescriptionTemplate.Text);
            if (b)
            {
                if (isCheck)
                {
                    b = isEnable;
                }
            }

            _btnSelectPrescriptionTemplate.Enabled = b;
        }

        private void CheckEnableDeleteSelectedDrugsButton(bool isCheck = false, bool isEnable = false)
        {
            var b = listBSDT_Toathuoc_CT != null && listBSDT_Toathuoc_CT.Count > 0;
            if (b)
            {
                if (isCheck)
                {
                    b = isEnable;
                }
            }

            _btnDeleteSelectedDrugs.Enabled = b;
        }

        private void CheckEnableAddDrugsButton(bool isCheck = false, bool isEnable = false)
        {
            var b = _cbbDrugs.EditValue != null && !string.IsNullOrWhiteSpace(_cbbDrugs.Text);
            if (b)
            {
                if (isCheck)
                {
                    b = isEnable;
                }
            }

            _btnAddDrugs.Enabled = b;
        }





        private MEntityOrderPrescriptionItem GetNewCustomerDrug(MEntityPrescriptionTemplateDrug ob, string name)
        {
            return new MEntityOrderPrescriptionItem
            {
                CategoryUnitId = ob.CategoryUnitId.ToString(),
                CategoryUnitName = ob.CategoryUnitName,
                DrugId = ob.PrescriptionItemId.ToString(),
                Quantity = Convert.ToInt32(ob.Quantity),
                DisplayPriority = ob.DisplayPriority,
                DrugName = name,
                Pharmaceutical = ob.Pharmaceutical,
                Description = ob.Description,
                IsFromTemplate = true,
                TemplId = System.Guid.NewGuid().ToString(),
                CategoryDrugUsingTimes = ob.CategoryDrugUsingTimes,
                CategoryDrugUsingId = ob.CategoryDrugUsingId,
                CategoryDrugUsingName = ob.CategoryDrugUsingName,
                MorningQuantity = ob.MorningQuantity,
                MorningCategoryUnitId = ob.MorningCategoryUnitId,
                MorningCategoryUnitName = ob.MorningCategoryUnitName,
                NoonQuantity = ob.NoonQuantity,
                NoonCategoryUnitId = ob.NoonCategoryUnitId,
                NoonCategoryUnitName = ob.NoonCategoryUnitName,
                AfternoonQuantity = ob.AfternoonQuantity,
                AfternoonCategoryUnitId = ob.AfternoonCategoryUnitId,
                AfternoonCategoryUnitName = ob.AfternoonCategoryUnitName,
                NightQuantity = ob.NightQuantity,
                NightCategoryUnitId = ob.NightCategoryUnitId,
                NightCategoryUnitName = ob.NightCategoryUnitName,
                Note = ob.Note,

            };
        }

        private void ApplyDrugData(MEntityOrderPrescriptionItem drug, bool isAdd, bool isFromTemplate)
        {
            if (isAdd)
            {
                drug.TemplId = System.Guid.NewGuid().ToString();
                drug.DisplayPriority = listBSDT_Toathuoc_CT.Count + 1;
                drug.IsFromTemplate = isFromTemplate;
            }
            else
            {
                drug.IsFromTemplate = false;
            }

            drug.DrugId = _cbbDrugs.EditValue?.ToString();
            drug.DrugName = _cbbDrugs.Text;

            drug.CategoryDrugUsingTimes = _txtCategoryDrugUsingTimes.GetIntValue();
            drug.CategoryDrugUsingId = _cbbCategoryDrugUsing.EditValue?.ToString();
            drug.CategoryDrugUsingName = _cbbCategoryDrugUsing.Text;

            drug.Quantity = _txtDrugQuanttity.GetIntValue();
            drug.CategoryUnitId = _cbbCategoryUnit.EditValue?.ToString();
            drug.CategoryUnitName = _cbbCategoryUnit.Text;

            drug.MorningQuantity = _txtDrugQuanttityMorning.GetIntValue();
            drug.MorningCategoryUnitId = _cbbMorningCategoryUnit.EditValue?.ToString();
            drug.MorningCategoryUnitName = _cbbMorningCategoryUnit.Text;

            drug.NoonQuantity = _txtDrugQuanttityNoon.GetIntValue();
            drug.NoonCategoryUnitId = _cbbNoonCategoryUnit.EditValue?.ToString();
            drug.NoonCategoryUnitName = _cbbNoonCategoryUnit.Text;

            drug.AfternoonQuantity = _txtDrugQuanttityAfternoon.GetIntValue();
            drug.AfternoonCategoryUnitId = _cbbAfternoonCategoryUnit.EditValue?.ToString();
            drug.AfternoonCategoryUnitName = _cbbAfternoonCategoryUnit.Text;

            drug.NightQuantity = _txtDrugQuanttityNight.GetIntValue();
            drug.NightCategoryUnitId = _cbbNightCategoryUnit.EditValue?.ToString();
            drug.NightCategoryUnitName = _cbbNightCategoryUnit.Text;

            drug.Note = _txtDrugNote.EditValue?.ToString();

            string cachdung = "Ngày " + _cbbCategoryDrugUsing.Text + " " + _txtCategoryDrugUsingTimes.Text + " lần, ";

            if (_txtDrugQuanttityMorning.Text != "")
                cachdung = cachdung + "sáng " + _txtDrugQuanttityMorning.Text + " " + _cbbMorningCategoryUnit.Text + ", ";

            if (_txtDrugQuanttityNoon.Text != "")
                cachdung = cachdung + "trưa " + _txtDrugQuanttityNoon.Text + " " + _cbbNoonCategoryUnit.Text + ", ";

            if (_txtDrugQuanttityAfternoon.Text != "")
                cachdung = cachdung + "chiều " + _txtDrugQuanttityAfternoon.Text + " " + _cbbAfternoonCategoryUnit.Text + ", ";

            if (_txtDrugQuanttityNight.Text != "")
                cachdung = cachdung + "tối " + _txtDrugQuanttityNight.Text + " " + _cbbNightCategoryUnit.Text + ", ";

            if (_txtDrugNote.Text != "")
                cachdung = cachdung + "( " + _txtDrugNote.Text + " )";

            drug.Description = cachdung;
        }


        private void _btnSaveDrugs_Click(object sender, EventArgs e)
        {
            Msg?.ClearMessages();
            if (_customerTreatmentPrescriptionDrug != null)
            {
                ApplyDrugData(_customerTreatmentPrescriptionDrug, false, false);
                viewBSDT_Toathuoc_CT.RefreshData();
                XEvent.Publish(new MQuickMessage
                {
                    Type = EMessage.Info,
                    Title = "Thuốc đã được cập nhật"
                });
            }
        }

        private void CheckEnableUpButton(bool isCheck = false, bool isEnable = false)
        {
            var b = isCheck ? isEnable : true;
            var view = viewBSDT_Toathuoc_CT;
            var ob = view.GetRow(view.FocusedRowHandle) as MEntityOrderPrescriptionItem;
            btnUp.Enabled = b && ob != null;
        }

        private void CheckEnableDownButton(bool isCheck = false, bool isEnable = false)
        {
            var b = isCheck ? isEnable : true;
            var view = viewBSDT_Toathuoc_CT;
            var ob = view.GetRow(view.FocusedRowHandle) as MEntityOrderPrescriptionItem;
            btnDown.Enabled = b && ob != null;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            var view = viewBSDT_Toathuoc_CT;
            var list = listBSDT_Toathuoc_CT;
            var ob = view.GetRow(view.FocusedRowHandle) as MEntityOrderPrescriptionItem;
            if (ob == null)
                return;
            else
            {
                int idex = list.FindIndex(o => o.DisplayPriority == ob.DisplayPriority);
                if (idex != 0)
                {
                    int newidex = idex - 1;
                    list.RemoveAt(idex);
                    list.Insert(newidex, ob);
                    int stt = 0;
                    if (list.Count > 0)
                    {
                        foreach (MEntityOrderPrescriptionItem obj in list)
                        {
                            obj.DisplayPriority = ++stt;
                        }
                    }
                    view.RefreshData();
                    view.FocusedRowHandle = newidex;
                }
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            var view = viewBSDT_Toathuoc_CT;
            var list = listBSDT_Toathuoc_CT;
            var ob = view.GetRow(view.FocusedRowHandle) as MEntityOrderPrescriptionItem;
            if (ob == null)
                return;
            else
            {

                int idex = list.FindIndex(o => o.DisplayPriority == ob.DisplayPriority);
                if (idex < list.Count - 1)
                {
                    int newidex = idex + 1;
                    list.RemoveAt(idex);
                    list.Insert(newidex, ob);
                    int stt = 0;
                    if (list.Count > 0)
                    {
                        foreach (MEntityOrderPrescriptionItem obj in list)
                        {
                            obj.DisplayPriority = ++stt;
                        }
                    }
                    view.RefreshData();
                    view.FocusedRowHandle = newidex;
                }

            }
        }

        private void LoadDataForControls()
        {

            Load_glkDMHanghoa();
            Load_glkDMToamau();

        }

    }
}
