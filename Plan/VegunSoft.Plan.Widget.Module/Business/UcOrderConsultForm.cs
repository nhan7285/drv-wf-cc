using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using DevExpress.XtraEditors;
using VegunSoft.Base.View.Dev.UserControls;
using VegunSoft.Category.Entity.Provider.Category;
using VegunSoft.Category.Entity.Provider.Category.Body;
using VegunSoft.Framework.Gui.Enums.Image;
using VegunSoft.Framework.Gui.Models;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Methods;
using VegunSoft.Framework.Methods;
using VegunSoft.Layer.EValue.Customer.Advice;
using VegunSoft.Layer.UcControl.Forms.Order.Consult;
using VegunSoft.Layer.UcControl.Models;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Product.Entity.Provider.Business;
using VegunSoft.Product.Entity.Provider.Category;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Consult
{
    public partial class UcOrderConsultForm : UcBase, IUcOrderConsultForm
    {
        private bool _isLoaded;
        private Dictionary<string, string> _dict = new Dictionary<string, string>();
        protected MUcConsultancyForm Settings { get; private set; }
        private bool _isReadOnly => Settings.IsReadOnlyFunc?.Invoke() ?? false;
        private List<MSuggestText> _suggestions;

        public UcOrderConsultForm()
        {
            InitializeComponent();
        }

        public void CheckAndInit(MUcConsultancyForm settings)
        {
            if (!_isLoaded)
            {
                Settings = settings;
                InitFields();
                SetIcons();
                ConfigControls();
                LoadDataSources();
                StartNone();
                Content.LoadSuggestions(Suggestions);
                _isLoaded = true;
            }
        }

        private void InitFields()
        {
           
        }

        private void SetIcons()
        {
            var refreshImage = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Refresh16);

            var serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
           

            var serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this._glkTooth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[]
            {
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines
                    .Combo),
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph,
                    "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, refreshImage,
                    new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "",
                    null, null, true)
            });
        }

        

       

        public void ResetCustomerTreatmentData()
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

        private void InsertText(GridLookUpEdit editor, EConsultancyText type, bool isAuto = false)
        {
            if (isAuto && !IsAutoInsertToContent) return;
            if (!string.IsNullOrWhiteSpace(editor.GetStringValue()))
            {
                Content?.InsertText(type, editor.Text);
            }
        }

        private void InsertText(TextEdit editor, EConsultancyText type, bool isAuto = false)
        {
            if (isAuto && !IsAutoInsertToContent) return;
            if (!string.IsNullOrWhiteSpace(editor?.Text))
            {
                Content?.InsertText(type, editor?.Text);
            }
        }

        private void InsertText(MemoEdit editor, EConsultancyText type, bool isAuto = false)
        {
            if (isAuto && !IsAutoInsertToContent) return;
            if (!string.IsNullOrWhiteSpace(editor?.Text))
            {
                Content?.InsertText(type, editor?.Text);
            }
        }

        private void InsertText(SimpleButton button, EConsultancyText type, bool isAuto = false)
        {
            if (isAuto && !IsAutoInsertToContent) return;
            if (!string.IsNullOrWhiteSpace(button.Tag?.ToString()))
            {
                Content?.InsertText(type, button.Tag?.ToString());
            }
        }

        private void InsertText(DateEdit editor, EConsultancyText type, bool isAuto = false)
        {
            if (isAuto && !IsAutoInsertToContent) return;
            if (!string.IsNullOrWhiteSpace(editor.EditValue?.ToString()))
            {
                Content?.InsertText(type, editor.DateTime.ToString(editor.Properties.DisplayFormat.FormatString));
            }
        }

        public void ApplyDefaultValues(MEntityOrderConsult model)
        {
            LoadDefaultValues();
            ApplyEditingValues(model);           
            model.Name = DefaultName;
        }

        public void LoadDefaultValues(bool isUpdate = false)
        {
            var d = RepositoryOrderConsult.GetDateTime();
            _cbbConsultingDoctor.EditValue = RepositorySession.Username;
            _cbbConsultingAssistant.EditValue = RepositorySession.Username;
            _cbbCreatedUsername.EditValue = RepositorySession.Username;
            _cbbUpdatedUsername.EditValue = RepositorySession.Username;
            ConsultDate = d;
            CreatedDateValue = d;
            //IsForOld = false;
            _txtUpdatedDate.DateTime = d;
            _btnSelectTeeth.Tag = null;
            _chkIsAutoInsertToContent.Checked = false;
        }

        public void ApplyEditingValues(MEntityOrderConsult model)
        {
            var dateTime = RepositoryOrderConsult.GetDateTime();

            model.Name = ConsultName;

            var tooth = _glkTooth.GetSelectedDataRow() as MEntityTooth;
            model.ServiceTargetId = tooth?.ID;
            model.ServiceTargetName = tooth?.TEN;
            model.ServiceTargetInfo = _btnSelectTeeth.Tag?.ToString();

            var type = _glkProductServiceType.GetSelectedDataRow() as MEntityPdsvType;
            model.ProductServiceTypeId = type?.Id;
            model.ProductServiceTypeNo = type?.No ?? 0;
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

            //var productService = _cbbProductService.GetSelectedDataRow() as MEntityProductService;
            //model.ProductServiceId = productService?.Id;
            //model.ProductServiceNo = productService?.No ?? 0;
            //model.ProductServiceCode = productService?.Code;
            //model.ProductServiceName = productService?.Name;

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

            model.StartDateTime = _txtConsultDate.DateTime;
            model.EndDateTime = dateTime;
            model.CreatedDate = CreatedDate;
            model.UpdatedDate = UpdatedDate;
            model.CreatedUsername = _cbbCreatedUsername.EditValue?.ToString();
            model.UpdatedUsername = _cbbUpdatedUsername.EditValue?.ToString();

            var customer = SelectedCustomer;
            model.CustomerId = customer?.Id;
            model.CustomerNo = customer?.No ?? 0;
            model.CustomerCode = customer?.Code;
            model.CustomerPhoneNumber = customer?.PhoneNumber;
            model.CustomerFullName = customer?.FullName;
            model.CustomerPrivateInfo = customer?.PrivateInfo;

            var order = Order;
            model.OrderId = order?.Id;
            model.OrderNo = order?.No ?? 0;
            model.OrderCode = order?.Code;
            model.OrderName = order?.Name;

            model.IsForOld = IsCheckedIsForOld;
        }

        public void LoadValuesToEditors(MEntityOrderConsult model)
        {
            var c = _chkIsAutoInsertToContent.Checked;
            _chkIsAutoInsertToContent.Checked = false;

            ConsultName = model.Name;
            _glkTooth.EditValue = model.ServiceTargetId;

            _btnSelectTeeth.Text = model.ServiceTargetInfo;
            _btnSelectTeeth.Tag = model.ServiceTargetInfo;

            _glkProductServiceType.EditValue = model.ProductServiceTypeId;
            _glkProductServiceGroup.EditValue = model.ProductServiceGroupId;
            _glkProductServiceGroupFinal.EditValue = model.ProductServiceGroupFinalId;
           // _cbbProductService.EditValue = model.ProductServiceId;

            _cbbConsultingDoctor.EditValue = model.ConsultingDoctorId;
            _cbbConsultingAssistant.EditValue = model.ConsultingAssistantId;
            ConsultDateValue = model.StartDateTime;
            CreatedDateValue = model.CreatedDate ;
            _cbbCreatedUsername.EditValue = model.CreatedUsername;
            UpdatedDateValue = model.UpdatedDate;
            _cbbUpdatedUsername.EditValue = model.UpdatedUsername;

            _chkIsAutoInsertToContent.Checked = c;

            IsCheckedIsForOld = model.IsForOld;

            IsApplySafeName = true;
        }

       
        public Dictionary<string, string> GetDictValues()
        {
            var dict = new Dictionary<string, string>
            {
                {nameof(MEntityOrderConsult.Name), ConsultName},
                {nameof(MEntityOrderConsult.ServiceTargetId), _glkTooth.EditValue?.ToString()},
                {nameof(MEntityOrderConsult.ServiceTargetInfo), _btnSelectTeeth.Tag?.ToString()},
                {
                    nameof(MEntityOrderConsult.ProductServiceTypeId),
                    _glkProductServiceType.EditValue?.ToString()
                },
                {
                    nameof(MEntityOrderConsult.ProductServiceGroupId),
                    _glkProductServiceGroup.EditValue?.ToString()
                },
                {
                    nameof(MEntityOrderConsult.ProductServiceGroupFinalId),
                    _glkProductServiceGroupFinal.EditValue?.ToString()
                },
                //{nameof(MEntityCustomerConsultancy.ProductServiceId), _cbbProductService.EditValue?.ToString()},
                {nameof(MEntityOrderConsult.ConsultingDoctorId), _cbbConsultingDoctor.EditValue?.ToString()},
                {
                    nameof(MEntityOrderConsult.ConsultingAssistantId),
                    _cbbConsultingAssistant.EditValue?.ToString()
                },
                {nameof(MEntityOrderConsult.StartDateTime), _txtConsultDate.EditValue?.ToString()},
                {nameof(MEntityOrderConsult.CreatedDate), CreatedDateValue?.ToString()},
                {nameof(MEntityOrderConsult.CreatedUsername), _cbbCreatedUsername.EditValue?.ToString()},
                {nameof(MEntityOrderConsult.UpdatedDate), UpdatedDateValue?.ToString()},
                {nameof(MEntityOrderConsult.UpdatedUsername), _cbbUpdatedUsername.EditValue?.ToString()},
                {nameof(MEntityOrderConsult.IsForOld), IsCheckedIsForOld.ToString()},
            };
            return dict;
        }

        public void RememberOldValues()
        {
            _dict = GetDictValues();
        }

        public bool CheckCanSave(MEntityOrderConsult model, bool isForInsert, bool isShowMessage)
        {
            var isCanSave = !string.IsNullOrWhiteSpace(model.Name);
            if (!isCanSave)
            {
                Msg.ShowEmptyInputError($"Vui lòng nhập {ConsultNameTip}");
                _txtName.Focus();
                return isCanSave;
            }
            var now = Now;
            if (IsCheckedIsForOld && now.Date == ConsultDate.Date)
            {
                Msg.ShowError($"Bạn đang nhập tư vấn cũ, vui lòng chọn ngày tư vấn cũ hơn!");
                IsFocusConsultDate = true;
                return false;
            }
            return true;
        }

        public void OnEndStartCreate()
        {
            RememberOldValues();
        }

        public void OnEndStartEdit()
        {
            RememberOldValues();
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
            return txt?.GetFullKeyword();
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
            var models = RepositoryPdsv.Where(nameof(MEntityPdsv.IsActive), true).OrderBy(x => x.GroupDisplayPriority).ToList();
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
            var models = RepositoryOrderConsultKeyword.Where(nameof(MEntityConsultancyKeyword.IsActive), true).ToList();
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

        public bool IsChanged
        {
            get
            {
                var isChanged = false;
                var newDict = GetDictValues();
                foreach (var kv in _dict)
                {
                    if (newDict.ContainsKey(kv.Key))
                    {
                        var oldVal = kv.Value;
                        var newVal = newDict[kv.Key];
                        if (oldVal != newVal)
                        {
                            isChanged = true;
                            break;
                        }
                    }
                }

                return isChanged;
            }
        }
    }
}
