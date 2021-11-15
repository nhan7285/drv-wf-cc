using System;
using System.Drawing;
using System.Linq;
using VegunSoft.Acc.Repository.Business;
using VegunSoft.App.Data.Business.View;
using VegunSoft.Base.View.Dev.UserControls;
using VegunSoft.Customer.Entity.Provider.Business;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Customer.Widget.Forms;
using VegunSoft.Framework.Gui.Enums.Image;
using VegunSoft.Framework.Methods;
using VegunSoft.Layer.EValue.App;
using VegunSoft.Layer.Repository.Customer.Repositories.Basic;
using VegunSoft.Layer.UcService.Provider.Any;
using VegunSoft.Layer.UcService.Provider.Models;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Notes
{
    public partial class UcCustomerNeed : UcBase
    {
        private bool _isLoaded;
        
        private IRepositoryUserAccount _userAccountRepository;
        private IRepositoryCustomerNeed _needNoteRepository;
        protected MUcCustomerNeed Settings { get; private set; }
        public MEntityCustomer SelectedCustomer
        {
            get { return Settings.GetSelectedCustomerFunc?.Invoke(); }
        }

        public UcCustomerNeed()
        {
            InitializeComponent();
        }

        public void CheckAndInit(MUcCustomerNeed settings)
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
            _needNoteRepository = DbIoc.GetInstance<IRepositoryCustomerNeed>();
        }

        private void SetIcons()
        {
            this.repositoryItemHyperLinkEdit7.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Status16);
            this._repoCustomerNeedDelete.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Delete16);
            this._btnAdvancedNeed.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Status16);
            this._btnCancelNeedsNote.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Cancel16);
            this._btnSaveNewNeedsNotes.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Status16);
            this._btnSaveNeedsNotes.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Status16);
        }

        private void ConfigControls()
        {
            ConfigCustomerNeedColumns();
        }

        public void ShowNeedNotes(string customerId)
        {
            ReadOnlyNeedNotes(false);
            NeedNote = _needNoteRepository.GetFinal(customerId);
            _gridCustomerNeed.DataSource = _needNoteRepository
                .Where(nameof(MEntityCustomerNeed.CustomerId), customerId).OrderByDescending(x => x.CreatedDate)
                .ToList();
        }

        private void _viewCustomerNeed_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var model = _viewCustomerNeed.GetRow(_viewCustomerNeed.FocusedRowHandle) as MEntityCustomerNeed;
            NeedNote = model;
        }

        private void _repoCustomerNeedDelete_Click(object sender, EventArgs e)
        {
            if (CheckRightsService.CheckCanDelete(SessionCode, Settings?.FormName, true))
            {
                var model = _viewCustomerNeed.GetRow(_viewCustomerNeed.FocusedRowHandle) as MEntityCustomerNeed;
                if (model != null)
                {
                    if (Msg.IsAgree(Class_Global._tbXoa))
                    {
                        _needNoteRepository.Delete(model?.Id);
                        ShowNeedNotes(SelectedCustomer?.Id);
                    }
                }
            }
            else
            {
                Msg.ShowWarning("Bạn không có quyền xóa nội dung này!");
            }
        }

        private void ConfigCustomerNeedColumns()
        {
            _gcCustomerNeedCreatedDate.FieldName = nameof(MEntityCustomerNeed.CreatedDate);
            _gcCustomerNeedDescription.FieldName = nameof(MEntityCustomerNeed.Description);
        }

        private MEntityCustomerNeed _needNote;
        protected MEntityCustomerNeed NeedNote
        {
            get
            {
                if (_needNote != null)
                {
                    _needNote.Description = _txtNeedNotes.Text;
                    _needNote.CustomerId = SelectedCustomer?.Id;
                    _needNote.CustomerNo = SelectedCustomer?.No ?? 0;
                    _needNote.CustomerCode = SelectedCustomer?.Code;
                    _needNote.CustomerFullName = SelectedCustomer?.FullName;
                    _needNote.CustomerPhoneNumber = SelectedCustomer?.PhoneNumber;
                    _needNote.CustomerPrivateInfo = SelectedCustomer?.PrivateInfo;
                }

                return _needNote;
            }
            set
            {
                _btnSaveNeedsNotes.Enabled = false;
                if (value != null)
                {
                    _txtNeedNotes.Text = value.Description;
                    _txtNeedCreatedDate.DateTime = value.CreatedDate != null ? value.CreatedDate.Value : DateTime.Now;
                    _btnSaveNeedsNotes.Enabled = !string.IsNullOrWhiteSpace(value.Id);
                    _needNote = value;
                }
                else
                {
                    NeedNote = new MEntityCustomerNeed();
                }

            }
        }

        private void _btnCancelNeedsNote_Click(object sender, EventArgs e)
        {
            ShowNeedNotes(SelectedCustomer?.Id);
        }

        private void _btnSaveNewNeedsNotes_Click(object sender, EventArgs e)
        {
            if (_needNote != null)
            {
                var dateTime = _userAccountRepository.GetDateTime();

                var model = NeedNote;
                RepositorySession.ApplyCreatedBasicFields(model, dateTime);
                model.CreatedDate = _needNoteRepository.GetDateTime();
                if (string.IsNullOrWhiteSpace(model.Description))
                {
                    Msg.ShowError(Class_Global._TBRangBuocRong("Nội dung"));
                    _txtNeedNotes.Focus();
                    return;
                }

                if (_needNoteRepository.Insert(model) > 0)
                {

                    // _messageService.ShowInfo("Thêm nhu cầu điều trị thành công!");
                    ShowNeedNotes(SelectedCustomer?.Id);
                }
                else
                {
                    Msg.ShowInfo(Class_Global._tbThemMoiLoi);
                }
            }

        }


        private void _btnSaveNeedsNotes_Click(object sender, EventArgs e)
        {
            if (_needNote != null)
            {
                var dateTime = _userAccountRepository.GetDateTime();
                var model = NeedNote;
                RepositorySession.ApplyUpdatedBasicFields(model, dateTime);
                model.UpdatedDate = _needNoteRepository.GetDateTime();
                if (string.IsNullOrWhiteSpace(model.Description))
                {
                    Msg.ShowError(Class_Global._TBRangBuocRong("Nội dung"));
                    _txtNeedNotes.Focus();
                    return;
                }

                if (_needNoteRepository.Update(model) > 0)
                {
                    // _messageService.ShowInfo("Lưu nhu cầu điều trị thành công!");
                    ShowNeedNotes(SelectedCustomer?.Id);
                }
                else
                {
                    Msg.ShowInfo(Class_Global._tbCapNhapLoi);
                }
            }
        }

        private void _txtNeedNotes_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_txtNeedNotes.Text))
            {
                Settings?.UpdateTitleFunc?.Invoke("Nhu cầu điều trị");
            }
            else
            {
                Settings?.UpdateTitleFunc?.Invoke("Nhu cầu điều trị (*)");
            }
        }

        public void ReadOnlyNeedNotes(bool isAccpt)
        {
            _btnCancelNeedsNote.Enabled = !isAccpt;
            _btnSaveNeedsNotes.Enabled = !isAccpt;
            _btnSaveNewNeedsNotes.Enabled = !isAccpt;
            _txtNeedNotes.Properties.ReadOnly = isAccpt;
        }

        private void _btnAdvancedNeed_Click(object sender, EventArgs e)
        {
            var customer = this.SelectedCustomer;
            if (customer != null)
            {
                var f = GuiIoc.GetInstance<IInputCustomerNeeds>();
                if (f != null)
                {
                    f.Init(Settings?.FormName);
                    var oldNote = customer.NeedNote;
                    var newNote = oldNote ?? string.Empty;
                    f.ShowPopup(this, customer, EDataRowFormat.CustomerHasPotentialProductServices.GetText(), oldNote, newNote, true);
                    if (f.IsSave)
                    {
                        ShowNeedNotes(customer?.Id);
                    }

                }
            }
            else
            {
                Msg.ShowError("Vui lòng chọn khách hàng!");
            }
        }

    }
}
