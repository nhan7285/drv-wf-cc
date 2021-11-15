using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using DevExpress.XtraEditors;
using VegunSoft.Acc.Data.Enums;
using VegunSoft.Category.Entity.Provider.Category;
using VegunSoft.Category.Entity.Provider.Category.Body;
using VegunSoft.Category.Repository.Categories;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums.Image;
using VegunSoft.Framework.Gui.Models;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Methods;
using VegunSoft.Framework.Gui.Services;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Framework.Methods;
using VegunSoft.Layer.EValue.Customer.Advice;
using VegunSoft.Layer.UcControl.Forms.Order.Consult;
using VegunSoft.Layer.UcControl.Models;
using VegunSoft.Message.Service.App;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Repository.Categories;
using VegunSoft.Product.Entity.Provider.Business;
using VegunSoft.Product.Entity.Provider.Category;
using VegunSoft.Product.Repository.Business;
using VegunSoft.Session.Repository.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Consult
{
    public partial class UcConsultancyTemplateForm : System.Windows.Forms.UserControl, IUcConsultancyTemplateForm
    {
        private bool _isLoaded;
        private IIocService _dbIoc;
        private IIocService _guiIoc;
        private IIconService _iconService;
        private IAppMessage _messageService;
        private IRepositorySession _sessionRepository;
        private IRepositoryConsultancyTemplate _repositoryConsultancyTemplate;
        private IRepositoryPdsv _dentistryServiceRepository;
        private IRepositoryConsultancyKeyword _repositoryConsultancyKeyword;
        private List<MSuggestText> _suggestions;
        protected MUcConsultancyTemplateForm Settings { get; private set; }

        private IRepositoryTooth _repositoryTooth;
        private List<MEntityTooth> SelectedTeeth { get; set; } = new List<MEntityTooth>();
        

        public MEntityTooth SelectedTooth
        {
            get { return _glkTooth.GetSelectedDataRow() as MEntityTooth; }
        }

        public IUcConsultancyTemplateContent Content
        {
            get
            {
                return Settings?.Content;
            }
        }

        public UcConsultancyTemplateForm()
        {
            InitializeComponent();
        }

        public void CheckAndInit(MUcConsultancyTemplateForm settings)
        {
            if (!_isLoaded)
            {
                Settings = settings;
                InitFields();
                SetIcons();
                ConfigControls();
                LoadDataSources();
                SetReadOnly(true);
                Content.LoadSuggestions(Suggestions);
                _isLoaded = true;
            }
        }

        private void InitFields()
        {
            _dbIoc = XIoc.GetService(CDb.IocKey);
            _guiIoc = XIoc.GetService(CGui.IocKey);
            _messageService = _guiIoc.GetInstance<IAppMessage>();
            _iconService = _guiIoc.GetInstance<IIconService>();
            _repositoryTooth = _dbIoc.GetInstance<IRepositoryTooth>();
            _sessionRepository = _dbIoc.GetInstance<IRepositorySession>();
            _repositoryConsultancyTemplate = _dbIoc.GetInstance<IRepositoryConsultancyTemplate>();
            _dentistryServiceRepository = _dbIoc.GetInstance<IRepositoryPdsv>();
            _repositoryConsultancyKeyword = _dbIoc.GetInstance<IRepositoryConsultancyKeyword>();
        }

        private void SetIcons()
        {
            var refreshImage = _iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Refresh16);

            var serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this._glkTooth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, refreshImage, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
        }

        private void ConfigControls()
        {
            _gcToothName.FieldName = nameof(MEntityTooth.TEN);
            _glkTooth.Properties.ValueMember = nameof(MEntityTooth.ID);
            _glkTooth.Properties.DisplayMember = nameof(MEntityTooth.TEN);

            _cbbConsultingDoctor.Scope = EUserAccountScope.ActiveUsing;
            _cbbConsultingAssistant.Scope = EUserAccountScope.Assistant;
            _cbbCreatedUsername.Scope = EUserAccountScope.ActiveUsing;
            _cbbUpdatedUsername.Scope = EUserAccountScope.ActiveUsing;

            //_glkProductServiceType.IsService = true;
            //_glkProductServiceGroupFinal.IsService = true;
            //_glkProductServiceType.IsProduct = true;
            //_glkProductServiceGroupFinal.IsProduct = true;
            //_glkProductServiceType.IsOther = true;

        }

        public void SetReadOnly(bool isReadOnly)
        {
            _txtName.Properties.ReadOnly = isReadOnly;
            _txtCode.Properties.ReadOnly = isReadOnly;
            _txtDescription.Properties.ReadOnly = isReadOnly;
            _chkIsActive.Properties.ReadOnly = isReadOnly;
            _glkTooth.Properties.ReadOnly = isReadOnly;
            _glkProductServiceType.Properties.ReadOnly = isReadOnly;
            _glkProductServiceGroup.Properties.ReadOnly = isReadOnly;
            _glkProductServiceGroupFinal.Properties.ReadOnly = isReadOnly;
          
            _cbbConsultingDoctor.Properties.ReadOnly = isReadOnly;//_cbbSelectFollower
            _cbbConsultingAssistant.Properties.ReadOnly = isReadOnly;
            _txtBeginDate.Properties.ReadOnly = isReadOnly;
            _txtEndDate.Properties.ReadOnly = isReadOnly;
            _txtCreatedDate.Properties.ReadOnly = isReadOnly;
            _cbbCreatedUsername.Properties.ReadOnly = isReadOnly;
            _txtUpdatedDate.Properties.ReadOnly = isReadOnly;
            _cbbUpdatedUsername.Properties.ReadOnly = isReadOnly;
            _chkIsAutoInsertToContent.Properties.ReadOnly = isReadOnly;

            _btnSelectTeeth.Enabled = !isReadOnly;
        }

        public void ResetData()
        {
            _glkTooth.EditValue = 0;
            _btnSelectTeeth.Tag = null;
            _chkIsAutoInsertToContent.Checked = false;
        }

        public void ResetCustomerData()
        {

        }

        public bool IsAutoInsertToContent
        {
            get { return _chkIsAutoInsertToContent.Checked; }
        }

       
        private void _chkIsAutoInsertToContent_CheckedChanged(object sender, EventArgs e)
        {

        }


        public void ApplyDefaultValues(MEntityConsultancyTemplate model)
        {
            LoadDefaultValues();
            ApplyEditingValues(model);
            var d = _repositoryConsultancyTemplate.GetDateTime();
            var dateString = d.ToString("dd/MM/yyyy HH:mm:ss");
            var name = $"Mẫu tư vấn ngày: {dateString}";
            model.Name = name;
            model.IsActive = true;
        }

        public void LoadDefaultValues(bool isUpdate = false)
        {
            var d = _repositoryConsultancyTemplate.GetDateTime();
            _cbbConsultingDoctor.EditValue = _sessionRepository.Username;
            _cbbConsultingAssistant.EditValue = _sessionRepository.Username;
            _cbbCreatedUsername.EditValue = _sessionRepository.Username;
            _cbbUpdatedUsername.EditValue = _sessionRepository.Username;
            _txtBeginDate.DateTime = d;
            _txtEndDate.DateTime = DateTime.MaxValue;
            _txtCreatedDate.DateTime = d;
            _txtUpdatedDate.DateTime = d;
            _btnSelectTeeth.Tag = null;
            _chkIsAutoInsertToContent.Checked = false;
            _chkIsActive.Checked = true;
        }

        public void ApplyEditingValues(MEntityConsultancyTemplate model)
        {
            var dateTime = _repositoryConsultancyTemplate.GetDateTime();

            model.Name = _txtName.Text;
            model.Code = _txtCode.Text;
            model.Description = _txtDescription.Text;
            model.IsActive = _chkIsActive.Checked;

            var tooth = _glkTooth.GetSelectedDataRow() as MEntityTooth;
            model.ServiceTargetId = tooth?.ID;
            model.ServiceTargetName = tooth?.TEN;
            model.ServiceTargetInfo = _btnSelectTeeth.Tag?.ToString();

            var type = _glkProductServiceType.GetSelectedDataRow() as MEntityPdsvType;
            model.ProductServiceTypeId = type?.Id;
            model.ProductServiceTypeNo = type?.No??0;
            model.ProductServiceTypeCode = type?.Code;
            model.ProductServiceTypeName = type?.Name;

            var group = _glkProductServiceGroup.GetSelectedDataRow() as MEntityPdsvGroup;
            model.ProductServiceGroupId = group?.Id;
            model.ProductServiceGroupNo = group?.No ?? 0;
            model.ProductServiceGroupCode = group?.Code;
            model.ProductServiceGroupName = group?.Name;

            var groupFinal = _glkProductServiceGroupFinal.GetSelectedDataRow() as MEntityPdsvBag;
            model.ProductServiceGroupFinalId = groupFinal?.Id;
            model.ProductServiceGroupFinalNo = groupFinal?.No ?? 0;
            model.ProductServiceGroupFinalCode = groupFinal?.Code;
            model.ProductServiceGroupFinalName = groupFinal?.Name;

            var consultingDoctor = _cbbConsultingDoctor.SelectedUserAccount;
            model.ConsultingDoctorId = consultingDoctor?.Id;
            model.ConsultingDoctorNo = consultingDoctor?.No ?? 0;
            model.ConsultingDoctorCode = consultingDoctor?.Code;
            model.ConsultingDoctorUsername = consultingDoctor?.Username;
            model.ConsultingDoctorFullName = consultingDoctor?.FullName;

            var consultingAssistant = _cbbConsultingAssistant.SelectedUserAccount;
            model.ConsultingAssistantId = consultingAssistant?.Id;
            model.ConsultingAssistantNo = consultingAssistant?.No ?? 0;
            model.ConsultingAssistantCode = consultingAssistant?.Code;
            model.ConsultingAssistantUsername = consultingAssistant?.Username;
            model.ConsultingAssistantFullName = consultingAssistant?.FullName;

            model.StartDateTime = _txtBeginDate.DateTime;
            model.EndDateTime = _txtEndDate.DateTime;
            model.EndDateTime = dateTime;
            model.CreatedDate = _txtCreatedDate.DateTime;
            model.UpdatedDate = _txtUpdatedDate.DateTime;
            model.CreatedUsername = _cbbCreatedUsername.EditValue?.ToString();
            model.UpdatedUsername = _cbbUpdatedUsername.EditValue?.ToString();
        }

        public void LoadValuesToEditors(MEntityConsultancyTemplate model)
        {
            var c = _chkIsAutoInsertToContent.Checked;
            _chkIsAutoInsertToContent.Checked = false;
            _txtName.EditValue = model.Name;
            _txtCode.EditValue = model.Code;
            _txtDescription.EditValue = model.Description;
            _chkIsActive.EditValue = model.IsActive;
            _glkTooth.EditValue = model.ServiceTargetId;

            _btnSelectTeeth.Text = model.ServiceTargetInfo;
            _btnSelectTeeth.Tag = model.ServiceTargetInfo;

            _glkProductServiceType.EditValue = model.ProductServiceTypeId;
            _glkProductServiceGroup.EditValue = model.ProductServiceGroupId;
            _glkProductServiceGroupFinal.EditValue = model.ProductServiceGroupFinalId;
           

            _cbbConsultingDoctor.EditValue = model.ConsultingDoctorId;
            _cbbConsultingAssistant.EditValue = model.ConsultingAssistantId;
            _txtBeginDate.EditValue = model.StartDateTime;
            _txtEndDate.EditValue = model.EndDateTime;
            _txtCreatedDate.EditValue = model.CreatedDate;
            _cbbCreatedUsername.EditValue = model.CreatedUsername;
            _txtUpdatedDate.EditValue = model.UpdatedDate;
            _cbbUpdatedUsername.EditValue = model.UpdatedUsername;

            _chkIsAutoInsertToContent.Checked = c;
        }

        public bool CheckCanSave(MEntityConsultancyTemplate model, bool isForInsert, bool isShowMessage)
        {
            var isCanSave = !string.IsNullOrWhiteSpace(model.Name);
            if (!isCanSave)
            {
                _messageService.ShowEmptyInputError($"Vui lòng nhập {_txtName.ToolTip}");
                _txtName.Focus();
                return isCanSave;
            }
           
            return true;
        }

        private void InsertText(GridLookUpEdit editor, EConsultancyTemplateText type, bool isAuto = false)
        {
            if (isAuto && !IsAutoInsertToContent) return;
            if (!string.IsNullOrWhiteSpace(editor.GetStringValue()))
            {
                Content?.InsertText(type, editor.Text);
            }
        }

        private void InsertText(SimpleButton button, EConsultancyTemplateText type, bool isAuto = false)
        {
            if (isAuto && !IsAutoInsertToContent) return;
            if (!string.IsNullOrWhiteSpace(button.Tag?.ToString()))
            {
                Content?.InsertText(type, button.Tag?.ToString());
            }
        }

        private void InsertText(DateEdit editor, EConsultancyTemplateText type, bool isAuto = false)
        {
            if (isAuto && !IsAutoInsertToContent) return;
            if (!string.IsNullOrWhiteSpace(editor.EditValue?.ToString()))
            {
                Content?.InsertText(type, editor.DateTime.ToString(editor.Properties.DisplayFormat.FormatString));
            }
        }

        private void InsertText(TextEdit editor, EConsultancyTemplateText type, bool isAuto = false)
        {
            if (isAuto && !IsAutoInsertToContent) return;
            if (!string.IsNullOrWhiteSpace(editor?.Text))
            {
                Content?.InsertText(type, editor?.Text);
            }
        }

        private void InsertText(MemoEdit editor, EConsultancyTemplateText type, bool isAuto = false)
        {
            if (isAuto && !IsAutoInsertToContent) return;
            if (!string.IsNullOrWhiteSpace(editor?.Text))
            {
                Content?.InsertText(type, editor?.Text);
            }
        }


        protected List<MSuggestText> Suggestions
        {
            get
            {
                if (_suggestions == null)
                {
                    _suggestions = new List<MSuggestText>();
                    AddTeethToSuggestion(_suggestions);
                    AddProductServiceTypeToSuggestion(_suggestions);
                    AddProductServiceGroupToSuggestion(_suggestions);
                    AddProductServiceGroupFinalToSuggestion(_suggestions);
                    AddProductServiceToSuggestion(_suggestions);
                    AddUsersToSuggestion(_suggestions);
                    AddKeywordsToSuggestion(_suggestions);
                }

                return _suggestions;
            }
        }

        private string GetKeyword(string txt)
        {
            return txt?.GetFullKeyword(); ;
        }

        private void AddTeethToSuggestion(List<MSuggestText> suggestions)
        {
            var group = "Răng";
            var models = ListTeeth;
            if (models != null && models.Count > 0)
            {
                foreach (var model in models)
                {
                    if (!string.IsNullOrWhiteSpace(model?.TEN))
                    {
                        suggestions.Add(new MSuggestText()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = model.TEN,
                            Group = group,
                            Key = model.ID,
                            IsActive = model.SUDUNG,
                            Keywords = GetKeyword(model.TEN)
                        });
                    }

                }
            }
        }

        private void AddProductServiceTypeToSuggestion(List<MSuggestText> suggestions)
        {
            var group = "Loại SP/DV";
            var models = ListProductServiceType;
            if (models != null && models.Count > 0)
            {
                foreach (var model in models)
                {
                    if (!string.IsNullOrWhiteSpace(model?.Name))
                    {
                        suggestions.Add(new MSuggestText()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = model.Name,
                            Group = group,
                            Key = model.Id,
                            IsActive = model.IsActive,
                            Keywords = GetKeyword(model.Name)
                        });
                    }

                }
            }

        }

        private void AddProductServiceGroupToSuggestion(List<MSuggestText> suggestions)
        {
            var group = "Nhóm SP/DV";
            var models = ListProductServiceGroup;
            if (models != null && models.Count > 0)
            {
                foreach (var model in models)
                {
                    if (!string.IsNullOrWhiteSpace(model?.Name))
                    {
                        suggestions.Add(new MSuggestText()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = model.Name,
                            Group = group,
                            Key = model.Id,
                            IsActive = model.IsActive,
                            Keywords = GetKeyword(model.Name)
                        });
                    }

                }
            }

        }

        private void AddProductServiceGroupFinalToSuggestion(List<MSuggestText> suggestions)
        {
            var group = "Phân nhóm SP/DV";
            var models = ListProductServiceGroupFinal;
            if (models != null && models.Count > 0)
            {
                foreach (var model in models)
                {
                    if (!string.IsNullOrWhiteSpace(model?.Name))
                    {
                        suggestions.Add(new MSuggestText()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = model.Name,
                            Group = group,
                            Key = model.Id,
                            IsActive = model.IsActive,
                            Keywords = GetKeyword(model.Name)
                        });
                    }

                }
            }

        }

        private void AddProductServiceToSuggestion(List<MSuggestText> suggestions)
        {
            var group = "Sản phẩm / dịch vụ";
            var models = _dentistryServiceRepository.Where(nameof(MEntityPdsv.IsActive), true).OrderBy(x => x.GroupDisplayPriority).ToList();
            if (models != null && models.Count > 0)
            {
                foreach (var model in models)
                {
                    if (!string.IsNullOrWhiteSpace(model?.Name))
                    {
                        suggestions.Add(new MSuggestText()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = model.Name,
                            Group = group,
                            Key = model.Id,
                            IsActive = model.IsActive,
                            Keywords = GetKeyword(model.Name)
                        });
                    }

                }
            }

        }

        private void AddUsersToSuggestion(List<MSuggestText> suggestions)
        {
            var group = "Người dùng";
            var models = ListUsers;
            if (models != null && models.Count > 0)
            {
                foreach (var model in models)
                {
                    if (!string.IsNullOrWhiteSpace(model?.FullName))
                    {
                        suggestions.Add(new MSuggestText()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = model.FullName,
                            Group = group,
                            Key = model.Username,
                            IsActive = model.IsActive,
                            Keywords = GetKeyword(model.FullName + "/" + model.Username)
                        });
                    }

                }
            }

        }

        private void AddKeywordsToSuggestion(List<MSuggestText> suggestions)
        {
            var group = "Từ khóa";
            var models = _repositoryConsultancyKeyword.Where(nameof(MEntityConsultancyKeyword.IsActive), true).ToList();
            if (models.Count > 0)
            {
                foreach (var model in models)
                {
                    if (!string.IsNullOrWhiteSpace(model?.Name))
                    {
                        suggestions.Add(new MSuggestText()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = model.Name,
                            Group = group,
                            Key = model.Id,
                            IsActive = model.IsActive,
                            Keywords = GetKeyword(model.Code + "/" + model.Name + "/" + model.Description)
                        });
                    }

                }
            }

        }
    }
}
