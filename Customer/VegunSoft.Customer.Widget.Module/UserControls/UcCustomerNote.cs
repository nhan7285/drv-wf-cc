using System;
using System.Drawing;
using System.Linq;
using VegunSoft.Acc.Repository.Business;
using VegunSoft.Base.View.Dev.UserControls;
using VegunSoft.Customer.Entity.Provider.Business;
using VegunSoft.Customer.Entity.Provider.Categories;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Customer.Repository.Business;
using VegunSoft.Customer.Repository.Categories;
using VegunSoft.Framework.Gui.Enums.Image;
using VegunSoft.Layer.UcService.Provider.Any;
using VegunSoft.Layer.UcService.Provider.Models;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Notes
{
    public partial class UcCustomerNote : UcBase
    {
        private bool _isLoaded;
       
        private IRepositoryUserAccount _userAccountRepository;
        protected IRepositoryCustomerCategoryNote RepositoryCustomerCategoryNote { get; private set; }
        protected IRepositoryCustomerNote RepositoryCustomerNote { get; private set; }

        protected MUcCustomerNote Settings { get; private set; }

        public MEntityCustomer SelectedCustomer
        {
            get { return Settings.GetSelectedCustomerFunc?.Invoke(); }
        }
        public UcCustomerNote()
        {
            InitializeComponent();
        }

        public void CheckAndInit(MUcCustomerNote settings)
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
           
            _userAccountRepository = DbIoc.GetInstance<IRepositoryUserAccount>();
            RepositoryCustomerNote = DbIoc.GetInstance<IRepositoryCustomerNote>();
            RepositoryCustomerCategoryNote = DbIoc.GetInstance<IRepositoryCustomerCategoryNote>();
        }

        private void SetIcons()
        {
            this.repositoryItemHyperLinkEdit3.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.ShowDetail16);
            this._repoCustomerNoteDelete.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Delete16);
            //this._btnCancelCustomerNote.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Cancel16);
            //this._btnSaveNewCustomerNotes.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Status16);
            //this._btnSaveCustomerNotes.Image = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Status16);
        }

        public void StartEdit(MEntityCustomerCategoryNote caregory)
        {
            IsCahanged = false;
            ShowNotes(SelectedCustomer?.Id);
            _btnCancelCustomerNote.PerformClick();
            if (caregory != null)
            {
                _glkCategory.EditValue = caregory?.Id;
            }
            else
            {
                _glkCategory.EditValue = null;
            }
        }

        private void ConfigControls()
        {
            ConfigCustomerNoteColumns();
            ConfigCategoryBox();
            LoadCategories();
        }

        private void LoadCategories()
        {
            var list = RepositoryCustomerCategoryNote.Where(nameof(MEntityCustomerCategoryNote.IsActive), true).ToList();
            _glkCategory.Properties.DataSource = list;
            _gvCategory.RefreshData();
        }

        private void ConfigCategoryBox()
        {
            _glkCategory.Properties.ValueMember = nameof(MEntityCustomerCategoryNote.Id);
            _glkCategory.Properties.DisplayMember = nameof(MEntityCustomerCategoryNote.Name);

            _gcCategoryNo.FieldName = nameof(MEntityCustomerCategoryNote.No);
            _gcCategoryName.FieldName = nameof(MEntityCustomerCategoryNote.Name);
        }

        private void ConfigCustomerNoteColumns()
        {
            _gcCustomerNoteCreatedDate.FieldName = nameof(MEntityCustomerNote.CreatedDate);
            _gcCustomerNoteDescription.FieldName = nameof(MEntityCustomerNote.Description);
        }

        private MEntityCustomerNote _customerNote;
        protected MEntityCustomerNote CustomerNote
        {
            get
            {

                var category = _glkCategory.GetSelectedDataRow() as MEntityCustomerCategoryNote;
                if (_customerNote == null) _customerNote = new MEntityCustomerNote();
                _customerNote.Description = _txtCustomerNote.Text;
                _customerNote.CustomerId = SelectedCustomer?.Id;
                _customerNote.CustomerNo = SelectedCustomer?.No ?? 0;
                _customerNote.CustomerCode = SelectedCustomer?.Code;
                _customerNote.CustomerFullName = SelectedCustomer?.FullName;
                _customerNote.CustomerPhoneNumber = SelectedCustomer?.PhoneNumber;
                _customerNote.CustomerPrivateInfo = SelectedCustomer?.PrivateInfo;
                _customerNote.CategoryId = category?.Id;
                _customerNote.CategoryNo = category?.No??0;
                _customerNote.CategoryCode = category?.Code;
                _customerNote.CategoryName = category?.Name;
                return _customerNote;
            }
            set
            {
                _btnSaveCustomerNotes.Enabled = false;
                if (value != null)
                {
                    _txtCustomerNote.Text = value.Description;
                    _txtNoteCreatedDate.DateTime = value.CreatedDate != null ? value.CreatedDate.Value : DateTime.Now;
                    _btnSaveCustomerNotes.Enabled = !string.IsNullOrWhiteSpace(value.Id);
                    _glkCategory.EditValue = value.CategoryId;
                   // _glkCategory.Text = value.CategoryName;
                    _customerNote = value;
                }
                else
                {
                    CustomerNote = new MEntityCustomerNote();
                }

            }
        }

        public bool IsCahanged { get; private set; }

        private void _btnSaveNewCustomerNotes_Click(object sender, EventArgs e)
        {
            if (_customerNote != null)
            {
                var dateTime = _userAccountRepository.GetDateTime();

                var model = CustomerNote;
                RepositorySession.ApplyCreatedBasicFields(model, dateTime);
                model.CreatedDate = RepositoryCustomerNote.GetDateTime();
                if (string.IsNullOrWhiteSpace(model.Description))
                {
                    Msg.ShowError(Class_Global._TBRangBuocRong("Nội dung"));
                    _txtCustomerNote.Focus();
                    return;
                }

                if (RepositoryCustomerNote.Insert(model) > 0)
                {
                    IsCahanged = true;
                    // _messageService.ShowInfo("Thêm ghi chú khách hàng thành công!");
                    ShowNotes(SelectedCustomer?.Id);
                }
                else
                {
                    Msg.ShowInfo(Class_Global._tbThemMoiLoi);
                }
            }
        }

        public void ShowNotes(string customerId)
        {
            ReadOnlyCustomerNotes(false);
            CustomerNote = RepositoryCustomerNote.GetFinal(customerId);
            _gridCustomerNote.DataSource = RepositoryCustomerNote
                .Where(nameof(MEntityCustomerNote.CustomerId), customerId).OrderByDescending(x => x.CreatedDate)
                .ToList();

        }

       
        public void ReadOnlyCustomerNotes(bool isAccpt)
        {
            _btnCancelCustomerNote.Enabled = !isAccpt;
            _btnSaveCustomerNotes.Enabled = !isAccpt;
            _btnSaveNewCustomerNotes.Enabled = !isAccpt;
            _txtCustomerNote.Properties.ReadOnly = isAccpt;
            _glkCategory.Properties.ReadOnly = isAccpt;
        }

        private void _txtCustomerNote_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_txtCustomerNote.Text))
            {
                Settings?.UpdateTitleFunc?.Invoke("Ghi chú");
            }
            else
            {
                Settings?.UpdateTitleFunc?.Invoke("Ghi chú (*)");
            }
        }

        private void _btnSaveCustomerNotes_Click(object sender, EventArgs e)
        {
            if (_customerNote != null)
            {
                var dateTime = _userAccountRepository.GetDateTime();
                var model = CustomerNote;
                RepositorySession.ApplyUpdatedBasicFields(model, dateTime);
                model.UpdatedDate = RepositoryCustomerNote.GetDateTime();
                if (string.IsNullOrWhiteSpace(model.Description))
                {
                    Msg.ShowError(Class_Global._TBRangBuocRong("Nội dung"));
                    _txtCustomerNote.Focus();
                    return;
                }

                if (RepositoryCustomerNote.Update(model) > 0)
                {
                    IsCahanged = true;
                    // _messageService.ShowInfo("Lưu ghi chú khách hàng thành công!");
                    ShowNotes(SelectedCustomer?.Id);
                }
                else
                {
                    Msg.ShowInfo(Class_Global._tbCapNhapLoi);
                }
            }
        }

        private void _btnCancelCustomerNote_Click(object sender, EventArgs e)
        {
            NewNote(SelectedCustomer?.Id);
        }

        private void _repoCustomerNoteDelete_Click(object sender, EventArgs e)
        {
            if (CheckRightsService.CheckCanDelete(SessionCode, Settings?.FormName, true))
            {
                var model = _viewCustomerNote.GetRow(_viewCustomerNote.FocusedRowHandle) as MEntityCustomerNote;
                if (model != null)
                {
                    if (Msg.IsAgree(Class_Global._tbXoa))
                    {
                       
                        var rs = RepositoryCustomerNote.Delete(model?.Id);
                        if (rs)
                        {
                            IsCahanged = true;
                            ShowNotes(SelectedCustomer?.Id);
                        }
                        else
                        {
                            Msg.ShowInfo(Class_Global.ERROR_DELETE_DATA);
                        }
                    }
                }
            }

        }

        private void _viewCustomerNote_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var model = _viewCustomerNote.GetRow(_viewCustomerNote.FocusedRowHandle) as MEntityCustomerNote;
            CustomerNote = model;
        }

        public void NewNote(string customerId)
        {
            _txtCustomerNote.EditValue = null;
            _txtNoteCreatedDate.DateTime = DateTime.Now;           
           // _glkType.EditValue = DateTime.Now;           
            ReadOnlyCustomerNotes(false);
            _btnSaveCustomerNotes.Enabled = false;
        }
    }
}
