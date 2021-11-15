using System;
using System.Drawing;
using System.Linq;
using VegunSoft.Acc.Repository.Business;
using VegunSoft.Base.View.Dev.UserControls;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Framework.Gui.Enums.Image;
using VegunSoft.Layer.UcService.Provider.Any;
using VegunSoft.Layer.UcService.Provider.Models;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;
using VegunSoft.Order.Repository.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Notes
{
    public partial class UcCustomerServiceNote : UcBase
    {
        private bool _isLoaded;
      
        private IRepositoryUserAccount _userAccountRepository;
        private IRepositoryOrderNote _treatmentNoteRepository;
        protected MUcCustomerServiceNote Settings { get; private set; }
        public MEntityCustomer SelectedCustomer
        {
            get { return Settings.GetSelectedCustomerFunc?.Invoke(); }
        }
        public MEntityOrder Order
        {
            get { return Settings.GetSelectedOrderFunc?.Invoke(); }
        }
        public UcCustomerServiceNote()
        {
            InitializeComponent();
        }
        public void CheckAndInit(MUcCustomerServiceNote settings)
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
            _treatmentNoteRepository = DbIoc.GetInstance<IRepositoryOrderNote>();
        }

        private void SetIcons()
        {
            this.repositoryItemHyperLinkEdit5.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Status16);
            this._repoOrderPrepareDelete.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Delete16);
            this._btnCancelNextNote.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Cancel16);
            this._btnSaveNewNextNotes.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Status16);
            this._btnSaveNextNotes.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Status16);
        }

        private void ConfigControls()
        {
            ConfigOrderPrepareColumns();
        }

        public void ShowProfileNotes(string profileId)
        {
            ReadOnlyNextNotes(false);
            NextNote = _treatmentNoteRepository.GetFinal(profileId);
            _gridOrderPrepare.DataSource = _treatmentNoteRepository
                .Where(nameof(MEntityOrderNote.OrderId), profileId).OrderByDescending(x => x.CreatedDate)
                .ToList();
        }

        private void _viewOrderPrepare_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var model = _viewOrderPrepare.GetRow(_viewOrderPrepare.FocusedRowHandle) as MEntityOrderNote;
            NextNote = model;
        }

        private void _repoOrderPrepareDelete_Click(object sender, EventArgs e)
        {
            if (CheckRightsService.CheckCanDelete(SessionCode, Settings?.FormName, true))
            {
                var model = _viewOrderPrepare.GetRow(_viewOrderPrepare.FocusedRowHandle) as MEntityOrderNote;
                if (model != null)
                {
                    if (Msg.IsAgree(Class_Global._tbXoa) )
                    {
                        _treatmentNoteRepository.Delete(model.Id);
                        ShowProfileNotes(Order.Id);
                    }
                }
            }
            else
            {
                Msg.ShowWarning("Bạn không có quyền xóa nội dung này!");
            }
        }

        private void ConfigOrderPrepareColumns()
        {
            _gcOrderPrepareCreatedDate.FieldName = nameof(MEntityOrderNote.CreatedDate);
            _gcOrderPrepareDescription.FieldName = nameof(MEntityOrderNote.Description);
        }

        private MEntityOrderNote _nextNote;
        protected MEntityOrderNote NextNote
        {
            get
            {
                if (_nextNote != null)
                {
                    _nextNote.Description = _txtNextNote.Text;
                    _nextNote.CustomerId = SelectedCustomer?.Id;
                    _nextNote.CustomerNo = SelectedCustomer?.No ?? 0;
                    _nextNote.CustomerCode = SelectedCustomer?.Code;
                    _nextNote.CustomerFullName = SelectedCustomer?.FullName;
                    _nextNote.CustomerPhoneNumber = SelectedCustomer?.PhoneNumber;
                    _nextNote.CustomerPrivateInfo = SelectedCustomer?.PrivateInfo;
                    _nextNote.OrderId = Order?.Id.ToString();

                }

                return _nextNote;
            }
            set
            {
                _btnSaveNextNotes.Enabled = false;
                if (value != null)
                {
                    _txtNextNote.Text = value.Description;
                    _txtPrepareCreatedDate.DateTime = value.CreatedDate != null ? value.CreatedDate.Value : DateTime.Now;
                    _btnSaveNextNotes.Enabled = !string.IsNullOrWhiteSpace(value.Id);
                    _nextNote = value;
                }
                else
                {
                    NextNote = new MEntityOrderNote();
                }

            }
        }

        public void ReadOnlyNextNotes(bool isAccpt)
        {
            _btnCancelNextNote.Enabled = !isAccpt;
            _btnSaveNextNotes.Enabled = !isAccpt;
            _btnSaveNewNextNotes.Enabled = !isAccpt;
            _txtNextNote.Properties.ReadOnly = isAccpt;
        }

        private void _txtNextNote_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_txtNextNote.Text))
            {
                Settings?.UpdateTitleFunc?.Invoke("Chuẩn bị");
            }
            else
            {
                Settings?.UpdateTitleFunc?.Invoke("Chuẩn bị (*)");
            }
        }

        private void _btnSaveNextNotes_Click(object sender, EventArgs e)
        {
            if (_nextNote != null)
            {
                var dateTime = _userAccountRepository.GetDateTime();
                var model = NextNote;
                RepositorySession.ApplyUpdatedBasicFields(model, dateTime);
                model.UpdatedDate = _treatmentNoteRepository.GetDateTime();
                if (string.IsNullOrWhiteSpace(model.Description))
                {
                    Msg.ShowError(Class_Global._TBRangBuocRong("Nội dung"));
                    _txtNextNote.Focus();
                    return;
                }

                if (_treatmentNoteRepository.Update(model) > 0)
                {
                    //_messageService.ShowInfo("Lưu ghi chú hồ sơ thành công!");
                    ShowProfileNotes(Order.Id);
                }
                else
                {
                    Msg.ShowInfo(Class_Global._tbCapNhapLoi);
                }
            }
        }

        private void _btnSaveNewNextNotes_Click(object sender, EventArgs e)
        {
            if (_nextNote != null)
            {
                var dateTime = _userAccountRepository.GetDateTime();

                var model = NextNote;
                RepositorySession.ApplyCreatedBasicFields(model, dateTime);
                model.CreatedDate = _treatmentNoteRepository.GetDateTime();
                if (string.IsNullOrWhiteSpace(model.Description))
                {
                    Msg.ShowError(Class_Global._TBRangBuocRong("Nội dung"));
                    _txtNextNote.Focus();
                    return;
                }

                if (_treatmentNoteRepository.Insert(model) > 0)
                {

                    // _messageService.ShowInfo("Thêm ghi chú hồ sơ thành công!");
                    ShowProfileNotes(Order.Id);
                }
                else
                {
                    Msg.ShowInfo(Class_Global._tbThemMoiLoi);
                }
            }
        }

        private void _btnCancelNextNote_Click(object sender, EventArgs e)
        {
            ShowProfileNotes(Order.Id);
        }

    }
}
