using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using VegunSoft.App.Data.Business;
using VegunSoft.App.Repository.Business.Log;
using VegunSoft.Base.View.Dev.UserControls;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Framework.Gui.Models;
using VegunSoft.Framework.Methods;
using VegunSoft.Layer.EValue.Customer.Advice;
using VegunSoft.Layer.UcControl.Forms.Order.Consult;
using VegunSoft.Layer.UcControl.Models;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;
using VegunSoft.Order.Repository.Business;
using VegunSoft.Order.Repository.Business.Contract;
using VegunSoft.Order.Repository.Categories;
using VegunSoft.Session.Service.User;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Consult
{
    public partial class UcOrderConsultBody : UcBase, IUcOrderConsultBody
    {
        private bool _isLoaded;
       
        private IRepositoryOrder RepositoryOrder { get; set; }
        private IRepositoryCustomerConsultancy _repositoryCustomerConsultancy;
        private IRepositoryConsultancyTemplate _repositoryConsultancyTemplate;
        private IRepositorySystemException _repositorySystemException;
        private ICheckRightsService _checkRightsService;
        
        protected MUcConsultancyContent Settings { get; private set; }
        private bool _isReadOnly => Settings.IsReadOnlyFunc?.Invoke() ?? false;
        public MEntityCustomer SelectedCustomer
        {
            get { return Settings?.GetSelectedCustomerFunc?.Invoke(); }
        }
        public MEntityOrder Order
        {
            get { return Settings.GetSelectedOrderFunc?.Invoke(); }
        }

        public IUcOrderConsultForm Form
        {
            get
            {
                return Settings?.GetFormFunc?.Invoke();
            }
        }

        public UcOrderConsultBody()
        {
            InitializeComponent();
        }

        public void CheckAndInit(MUcConsultancyContent settings)
        {
            if (!_isLoaded)
            {
                Settings = settings;
                InitFields();
                SetIcons();
                ConfigControls();
                ReloadTemplates();
                _ucConsultancyGrid.CheckAndInit(new MUcConsultancyGrid()
                {
                    FormName = settings?.FormName,
                    GetSelectedCustomerFunc = () => SelectedCustomer,
                    IsReadOnlyFunc = () => _isReadOnly,
                    StartEditAction = StartEdit,
                    ContractConsultAction = settings?.ContractConsultAction,
                    SelectedConsultChanged = settings?.SelectedConsultChanged,
                });
               
                 _isLoaded = true;
            }
            StartNone();
            _btnCreateNewConsultItem.Enabled = false;
        }

        

        private void InitFields()
        {
            
            _repositorySystemException = DbIoc.GetInstance<IRepositorySystemException>();
            _repositoryCustomerConsultancy = DbIoc.GetInstance<IRepositoryCustomerConsultancy>();
            RepositoryOrder = DbIoc.GetInstance<IRepositoryOrder>();
            _repositoryConsultancyTemplate = DbIoc.GetInstance<IRepositoryConsultancyTemplate>();
            _checkRightsService = GuiIoc.GetInstance<ICheckRightsService>();
        }

        private void SetIcons()
        {

        }

        private void ConfigControls()
        {
            _gcTemplateNo.FieldName = nameof(MEntityConsultancyTemplate.No);
            _gcTemplateName.FieldName = nameof(MEntityConsultancyTemplate.Name);
            _gcTemplateCode.FieldName = nameof(MEntityConsultancyTemplate.Code);
            _gcTemplateGroupName.FieldName = nameof(MEntityConsultancyTemplate.ProductServiceGroupName);
            _gcTemplateGroupFinalName.FieldName = nameof(MEntityConsultancyTemplate.ProductServiceGroupFinalName);
            _gcTemplateType.FieldName = nameof(MEntityConsultancyTemplate.ProductServiceTypeName);
            _gcTemplateDescription.FieldName = nameof(MEntityConsultancyTemplate.Description);

            _glkTemplates.Properties.DisplayMember = nameof(MEntityConsultancyTemplate.Name);
            _glkTemplates.Properties.ValueMember = nameof(MEntityConsultancyTemplate.Id);

            _ucRichContent.NewAction = StartCreate;
            _ucRichContent.SaveAction = StartSave;
          
        }

        private void StartSave()
        {
            var isForNew = string.IsNullOrWhiteSpace(Model.Id);
            Save(isForNew);
        }

       

        private void _btnCreateNewConsultItem_Click(object sender, EventArgs e)
        {
            StartCreate();
        }

       

        private void SetDisplayName(string v)
        {
            if (string.IsNullOrWhiteSpace(v)) _ucRichContent.DisplayName = "";
             _ucRichContent.DisplayName = $"TV: {v}";
        }

        private void SetDisplayDateTime(string v)
        {
            if (string.IsNullOrWhiteSpace(v)) _ucRichContent.DisplayDateTime = "";
            _ucRichContent.DisplayDateTime = $"Ngày: {v}";
        }


        private void LoadDefaultValues(bool isUpdate = false)
        {
            Form?.LoadDefaultValues();
        }

        private void CreateNewModel()
        {
            var model = new MEntityOrderConsult();
            Form?.ApplyDefaultValues(model);
            Model = model;
        }

        private void LoadSavedModel(MEntityOrderConsult model)
        {
            //Form?.ApplyDefaultValues(model);
            Model = model;
        }


        private MEntityOrderConsult _model = new MEntityOrderConsult();
        private List<MEntityConsultancyTemplate> _templates;
      
        private string _beginText = string.Empty;

        public MEntityOrderConsult Model
        {
            get
            {
                _model.Content = _ucRichContent.SaveText;
                Form?.ApplyEditingValues(_model);
                return _model;
            }
            set
            {
                _model = value;
                _ucRichContent.SaveText = _model.Content;
                Form?.LoadValuesToEditors(_model);
            }
        }

        public void InsertText(EConsultancyText type, string text)
        {
            var preFix = type.GetText();
           
            _ucRichContent.InsertPartText($"[{preFix}: {text}]: ");
            
        }

       

        private void _btnSave_Click(object sender, EventArgs e)
        {
            Save(false);
        }

        private void _btnSaveNew_Click(object sender, EventArgs e)
        {
            Save(true);
        }

        
        private void Save(bool isForNew)
        {
            ShowLoading();
            var text = "Tư Vấn";
            var model = Model;
            var isNeedReload = false;
            
            if (isForNew)
            {
                model.Id = null;
                var isCanSave = Form.CheckCanSave(model, true, true);
                if (isCanSave)
                {
                    var dateTime = _repositoryCustomerConsultancy.GetDateTime();
                    RepositorySession.ApplyCreatedBasicFields(model, dateTime);
                    var rs = _repositoryCustomerConsultancy.InsertGetGuid(model);
                    if (!string.IsNullOrWhiteSpace(rs))
                    {
                        model.Id = rs;
                        Msg.ShowInsertSuccessInfo(text, true);
                        isNeedReload = true;
                        _beginText = _ucRichContent.SaveText;
                       
                    }
                }
                
            }
            else
            {
                var isCanSave = Form.CheckCanSave(model, false, true);
                if (isCanSave)
                {
                    var dateTime = _repositoryCustomerConsultancy.GetDateTime();
                    RepositorySession.ApplyUpdatedBasicFields(model, dateTime);
                    var rs = _repositoryCustomerConsultancy.Update(model);
                    if (rs > 0)
                    {
                        Msg.ShowUpdateSuccessInfo(text, true);
                        isNeedReload = true;
                        _beginText = _ucRichContent.SaveText;
                    }
                }
            }
            var id = model?.Id;
            if (!string.IsNullOrWhiteSpace(id))
            {
                var consult = _repositoryCustomerConsultancy.Find(id);
                if (consult != null)
                {
                    var orders = RepositoryOrder.Where(nameof(MEntityOrder.ConsultingId), id).ToList();
                    if (orders.Count > 0)
                    {
                        foreach (var order in orders)
                        {
                            order.ConsultantUserName = consult?.ConsultingDoctorUsername;
                            order.ConsultantFullName = consult?.ConsultingDoctorFullName;
                            order.ConsultingAssistantUserName = consult?.ConsultingAssistantUsername;
                            order.ConsultingAssistantFullName = consult?.ConsultingAssistantFullName;
                        }
                        var count = RepositoryOrder.UpdateMany(orders);
                        if(count > 0)
                        {
                            Msg.ShowUpdateSuccessInfo("hồ sơ", true);
                        }
                        else
                        {
                            Msg.ShowUpdateErrorInfo("hồ sơ");
                        }
                    }
                }
             
            }
            if (isNeedReload)
            {
                _ucConsultancyGrid.ReloadData();
                
                var m = _repositoryCustomerConsultancy.Find(model?.Id);
                StartEdit(m);
                Settings?.EndSaveConsultancyAction?.Invoke(m);
            }

            CloseLoading();
        }

      
        public void SelectOrder(string orderId)
        {
            _ucConsultancyGrid.SelectOrder(orderId);
        }

        private void _chkIsExpandMode_CheckedChanged(object sender, EventArgs e)
        {
            //_splitContainer.Panel2.Visible = !_chkIsExpandMode.Checked;

            _splitContainer.Panel2Collapsed = _chkIsExpandMode.Checked;
        }

        private void ReloadTemplates()
        {
            var userName = RepositorySession.Username;
            _templates = _repositoryConsultancyTemplate.Where(nameof(MEntityConsultancyTemplate.IsActive), true).Where(x=>IsValidTemplate(x, userName))
                .ToList();
            _glkTemplates.Properties.DataSource = _templates;
            _viewTemplates.RefreshData();
        }

        private bool IsValidTemplate(MEntityConsultancyTemplate template, string userName)
        {
            if (template == null) return false;
            var rs = string.IsNullOrWhiteSpace(template.ConsultingDoctorUsername) &&
                     string.IsNullOrWhiteSpace(template.ConsultingAssistantUsername) || !string.IsNullOrWhiteSpace(template.ConsultingDoctorUsername) &&
                     template.ConsultingDoctorUsername?.ToLower() == userName?.ToLower() || !string.IsNullOrWhiteSpace(template.ConsultingAssistantUsername) &&
                     template.ConsultingAssistantUsername?.ToLower() == userName?.ToLower();
            return rs;
        }

      

        private void _btnInsertTemplate_Click(object sender, EventArgs e)
        {
            if (_glkTemplates.GetSelectedDataRow() is MEntityConsultancyTemplate model && !string.IsNullOrWhiteSpace(model?.Content))
            {
                _ucRichContent.InsertSaveText(model.Content);
            }
            else
            {
                Msg.ShowError("Vui lòng chọn mẫu có nội dung!");
            }
        }

        public void LoadSuggestions(List<MSuggestText> suggestions)
        {
            _ucRichContent.LoadSuggestions(suggestions);
        }
        //public bool IsFinishSaleMode => _chkSale.Checked;
        private void _chkSale_CheckedChanged(object sender, EventArgs e)
        {
            var isEditing = Model?.IsSaved ?? false;
            Settings?.IsFinishSaleModeChangedAction?.Invoke(false, isEditing);
        }

        public void SetIsFinishSaleMode(bool isFinishSale)
        {
             // _chkSale.Checked = isFinishSale;
        }

        public void Reset()
        {
            LoadDefaultValues();
            CreateNewModel();
            StartNone();
            _ucConsultancyGrid.SelectCustomer(null);
            SetDisplayName(string.Empty);
            SetDisplayDateTime(string.Empty);
        }

        public void SelectCustomer(string customerId)
        {
            _btnCreateNewConsultItem.Enabled = !string.IsNullOrWhiteSpace(customerId);
            _ucConsultancyGrid.SelectCustomer(customerId);
            if(_btnCreateNewConsultItem.Enabled) StartCreate();
        }


        private void _btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                Settings?.CheckAndSaveAction?.Invoke();
                CheckAndSave();
                var isMoved = Settings?.StartTransferAction?.Invoke(string.Empty, new object[] { Order, SelectedCustomer}) ??true;
                if (isMoved)
                {
                    Reset();
                    _btnCreateNewConsultItem.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                _repositorySystemException.SaveException("TreatmentDoctor.OnSaveAndTransfer", "BSĐT: Lưu và chuyển", ex);
                MessageBox.Show(ex.Message);
            }
        }

        public void CheckAndSave()
        {
            if (_beginText != _ucRichContent.SaveText || Form.IsChanged)
            {
                if (Msg.IsAgree("Dữ liệu tư vấn chưa được Lưu. Bạn có muốn Lưu không?\nChọn YES để Lưu. NO để Hủy!"))
                {
                    var isForNew = string.IsNullOrWhiteSpace(Model.Id);
                    Save(isForNew);
                }
                
            }
           
        }

        private void _glkTemplates_EditValueChanged(object sender, EventArgs e)
        {
            var content = _ucRichContent.RawText;
            if (string.IsNullOrWhiteSpace(content))
            {
                _btnInsertTemplate.PerformClick();
            }
            else if (Msg.IsAgree("Bạn có muốn áp dụng nội dung của mẫu vừa chọn không? \r\nChú ý: nội dung hiện tại sẽ bị mất!"))
            {
                _btnInsertTemplate.PerformClick();
            }
        }

        private void _glkTemplates_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Ellipsis)
            {

                if (_checkRightsService.CheckCanShow(SessionCode, EFormMgmt.FMgmtConsultingTemplate.GetFinalName(), true))
                {
                    var form = GuiIoc.GetInstance<Form>(EFormMgmt.FMgmtConsultingTemplate.GetFinalName());
                    if (form != null)
                    {
                        form.ShowDialog();
                        ReloadTemplates();
                        var model = form.Tag as MEntityConsultancyTemplate;
                        _glkTemplates.EditValue = model?.Id;
                    }
                }

            }
            else if (e.Button.Kind == ButtonPredefines.Glyph)
            {
                ReloadTemplates();
            }
        }

        public void CheckAndSelectFinalItem()
        {
            _ucConsultancyGrid.CheckAndSelectFinalItem();
        }

        public void SwitchToReadOnlyMode()
        {
            _splitContainer.Panel2Collapsed = true;
            _panelButtons.Visible = false;
        }

        public void SelectConsult(string consultId)
        {
            _ucConsultancyGrid.SelectById(consultId);
        }

        public MEntityOrderConsult GetSelectedConsult()
        {
           return _ucConsultancyGrid.SelectedRow;
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            StartNone();
        }
    }
}
