using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports.UI;
using VegunSoft.App.Data.Business;
using VegunSoft.Customer.Entity.Provider.Image;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums.Image;
using VegunSoft.Framework.Gui.Services;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Layer.UcControl.Customer.Forms;
using VegunSoft.Layer.UcService.Provider.Models;
using VegunSoft.Message.Service.App;
using VegunSoft.Order.Repository.Business.Contract;
using VegunSoft.Session.Repository.Business;
using VegunSoft.Subclinical.Repository.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcCustomerSubclinical : System.Windows.Forms.UserControl
    {
        private bool _isLoaded;
        private IIocService _dbIoc;
        private IIocService _guiIoc;
        private IIconService _iconService;
        private IRepositoryOrder _repositoryOrder;
        private IAppMessage _messageService;
        private IRepositorySession _sessionRepository;
        private IRepositoryCustomerImage _subclinicalServiceImage;
        private IRepositoryCustomerImageFolder _subclinicalService;
        private string vIdCLS_ChidinhCLS_Hinhanh;
        protected MUcCustomerSubclinical Settings { get; private set; }
        private bool _isSubclinicalInited;
        private string _id_ChidinhCLS;

        public List<MEntityCustomerImage> SubclinicalImages { get; private set; }
        public byte[] SubclinicalImage { get; private set; }
        public UcCustomerSubclinical()
        {
            InitializeComponent();
        }

        public void CheckAndInit(MUcCustomerSubclinical settings)
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

        private void InitFields()
        {
            _dbIoc = XIoc.GetService(CDb.IocKey);
            _guiIoc = XIoc.GetService(CGui.IocKey);
            _messageService = _guiIoc.GetInstance<IAppMessage>();
            _iconService = _guiIoc.GetInstance<IIconService>();
            _sessionRepository = _dbIoc.GetInstance<IRepositorySession>();
            _repositoryOrder = _dbIoc.GetInstance<IRepositoryOrder>();
            _subclinicalServiceImage = _dbIoc.GetInstance<IRepositoryCustomerImage>();
            _subclinicalService = _dbIoc.GetInstance<IRepositoryCustomerImageFolder>();
        }

        public void InitSubclinicals()
        {
            if (!_isSubclinicalInited)
            {
                this.viewDanhSachCLS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnSubclinicalsMouseDown);
                _isSubclinicalInited = true;
            }
            Load_gridDanhSachCLS();
            ShowSelectedImage();
        }

        private void SetIcons()
        {
            lnkXemInCLS.Image = _iconService.GetIcon<EResourceImage, Image>(EResourceImage.Print16);
            lnkHinhAnhCLS.Image = _iconService.GetIcon<EResourceImage, Image>(EResourceImage.Image16);
            btnNext.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Status16);
            btnPrev.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Show16);
        }

        private void ConfigControls()
        {
            SetSubclinicalFields();
        }

        private void SetSubclinicalFields()
        {
            _gcSubclinicalId.FieldName = nameof(MEntityCustomerImageFolder.Id);
            _gcSubclinicalCreatedDate.FieldName = nameof(MEntityCustomerImageFolder.CreatedDate);
            _gcSubclinicalSpecifierFullName.FieldName = nameof(MEntityCustomerImageFolder.SpecifiedUserFullName);
            _gcSubclinicalPerformerFullName.FieldName = nameof(MEntityCustomerImageFolder.PerformedUserFullName);
            _gcSubclinicalDescription.FieldName = nameof(MEntityCustomerImageFolder.Description);

            _gcSubclinicalCategoryName.FieldName = nameof(MEntityCustomerImageFolder.SubclinicalCategoryName);
            _gcSubclinicalResultName.FieldName = nameof(MEntityCustomerImageFolder.SubclinicalFormResultName);
            _gcSubclinicalResult.FieldName = nameof(MEntityCustomerImageFolder.SubclinicalResult);
            _gcSubclinicalConclusion.FieldName = nameof(MEntityCustomerImageFolder.Conclusion);
            _gcSubclinicalSuggestion.FieldName = nameof(MEntityCustomerImageFolder.Suggestion);
            _gcSubclinicalNote.FieldName = nameof(MEntityCustomerImageFolder.Note);
            _gcSubclinicalTakePhotoDate.FieldName = nameof(MEntityCustomerImageFolder.TakePhotosDate);
        }

        private void OnSubclinicalsMouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Location);
            if (hitInfo.InRow && hitInfo.RowHandle >= 0)
            {
                var model = viewDanhSachCLS.GetRow(hitInfo.RowHandle) as MEntityCustomerImageFolder;
                if (model != null)
                {
                    ShowSelectedImage(model);
                }
            }
        }

        private void ShowSelectedImage(MEntityCustomerImageFolder model = null)
        {
           XLoading.ShowLoading();
            if (model == null) model = ((MEntityCustomerImageFolder)viewDanhSachCLS.GetFocusedRow());
            var designationId = model?.Id;
            if (string.IsNullOrWhiteSpace(designationId)) return;
            var images = _subclinicalServiceImage.GetSubclinicalFullImageByDesignationId(designationId, false);
            _id_ChidinhCLS = designationId;
            SubclinicalImages = images;

            if (images.Count > 0)
            {
                LoadImage(images, images[0]);
            }
            XLoading.CloseLoading();
        }

        private string GetNote(List<MEntityCustomerImage> images, MEntityCustomerImageFolder model, MEntityCustomerImage image)
        {

            var sb = new StringBuilder();
            if (model != null)
            {
                var date = model.TakePhotosDate != null ? model.TakePhotosDate.Value.ToString("dd/MM/yyyy HH:mm:ss") : string.Empty;
                sb.AppendLine($"Bác sĩ chỉ định: {model.SpecifiedUserFullName} - Chỉ định: {model.SubclinicalCategoryName} - Chẩn đoán: {model.Description}");
                sb.AppendLine($"Ngày chụp: {date} -  Đề nghị: {model.Suggestion} - Ghi chú: {model.Note}");
                if (images != null)
                {
                    var total = images.Count;
                    var idx = images.IndexOf(image) + 1;
                    sb.AppendLine($"Ảnh: {idx} / {total}");
                }
            }

            if (image != null)
            {
                if (!string.IsNullOrWhiteSpace(image.Note))
                {
                    sb.AppendLine(image.Note);
                }


            }
            return sb.ToString();
        }

        private void LoadImage(List<MEntityCustomerImage> images, MEntityCustomerImage img)
        {
            _subclinicalServiceImage.CheckAndDownloadImageBytes(img);
            SubclinicalImage = img.Image;
            vIdCLS_ChidinhCLS_Hinhanh = img.Id;

            pteImage.EditValue = SubclinicalImage;
            var cls = viewDanhSachCLS.GetFocusedRow() as MEntityCustomerImageFolder;
            _imgNote.Text = GetNote(images, cls, img);
        }

        public void ResetCustomerData()
        {
            ResetSubclinicalForm();
            ResetSubclinicalGrid();
        }

        public void ResetSubclinicalForm()
        {
            _imgNote.EditValue = null;
            pteImage.EditValue = null;
        }

        public void ResetSubclinicalGrid()
        {
            gridDanhSachCLS.DataSource = null;
            viewDanhSachCLS.RefreshData();
        }


        private void Load_gridDanhSachCLS()
        {
            gridDanhSachCLS.DataSource = null;
            if (SelectedCustomer != null)
            {
                gridDanhSachCLS.DataSource = _subclinicalService.Where(nameof(MEntityCustomerImageFolder.CustomerId), SelectedCustomer.Id).OrderByDescending(x => x.CreatedDate).ToList();
            }

            viewDanhSachCLS.RefreshData();
        }

        private void lnkHinhAnhCLS_Click(object sender, EventArgs e)
        {
            XLoading.ShowLoading();
            var cls = viewDanhSachCLS.GetFocusedRow() as MEntityCustomerImageFolder;
            var designationId = cls?.Id;
            var images = _subclinicalServiceImage.GetSubclinicalFullImageByDesignationId(designationId, false);
            var imagesform = _guiIoc.GetInstance<Form>(EFormMgmt.FormImage.ToString());
            var iForm = imagesform as IFormImage;
            iForm.Start(cls, images);


            XLoading.CloseLoading();
            imagesform.ShowDialog();
        }

        private void lnkXemInCLS_Click(object sender, EventArgs e)
        {
            if (viewDanhSachCLS.FocusedRowHandle >= 0)
            {
                var id = ((MEntityCustomerImageFolder)viewDanhSachCLS.GetFocusedRow()).Id;
                var rpt = _guiIoc.GetInstance<ICLSReport>().Init(id);
                ReportPrintTool printTool = new ReportPrintTool(rpt);
                printTool.ShowPreview();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            XLoading.ShowLoading();
            if (SubclinicalImages == null)
            {
                SubclinicalImages = _subclinicalServiceImage.GetSubclinicalFullImageByDesignationId(_id_ChidinhCLS, false);
            }

            if (SubclinicalImages.Count > 1)
            {
                int stt = 0;
                for (int i = 0; i < SubclinicalImages.Count; i++)
                {
                    stt++;
                    if (SubclinicalImages[i].Id == vIdCLS_ChidinhCLS_Hinhanh && stt != 1)
                    {
                        var image = SubclinicalImages[i - 1];
                        LoadImage(SubclinicalImages, image);
                        break;
                    }
                }
            }
            XLoading.CloseLoading();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            XLoading.ShowLoading();
            if (SubclinicalImages == null)
            {
                SubclinicalImages = _subclinicalServiceImage.GetSubclinicalFullImageByDesignationId(_id_ChidinhCLS, false);
            }

            if (SubclinicalImages.Count > 1)
            {
                int stt = 0;
                for (int i = 0; i < SubclinicalImages.Count; i++)
                {
                    stt++;
                    if (SubclinicalImages[i].Id == vIdCLS_ChidinhCLS_Hinhanh && stt != SubclinicalImages.Count)
                    {
                        var image = SubclinicalImages[i + 1];
                        LoadImage(SubclinicalImages, image);

                        break;
                    }
                }
            }
            XLoading.CloseLoading();
        }

        public MEntityCustomer SelectedCustomer
        {
            get { return Settings.GetSelectedCustomerFunc?.Invoke(); }
        }
    }
}
