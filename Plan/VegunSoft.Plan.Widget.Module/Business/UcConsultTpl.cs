using System;
using System.Collections.Generic;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Models;
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
using VegunSoft.Session.Repository.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Consult
{
    public partial class UcConsultTpl : System.Windows.Forms.UserControl, IUcConsultancyTemplateContent
    {
        private bool _isLoaded;
        private IIocService _dbIoc;
        private IIocService _guiIoc;
        private IIconService _iconService;
        private IAppMessage _messageService;
        private IRepositorySession _sessionRepository;
        private IRepositoryConsultancyTemplate _repositoryConsultancyTemplate;
        protected MUcConsultancyTemplateContent Settings { get; private set; }
        

        public IUcConsultancyTemplateForm Form
        {
            get
            {
                return _ucConsultancyTemplateForm;
            }
        }

        public UcConsultTpl()
        {
            InitializeComponent();
        }

        public void CheckAndInit(MUcConsultancyTemplateContent settings)
        {
            if (!_isLoaded)
            {
                Settings = settings;
                InitFields();
                SetIcons();
                ConfigControls();
                _ucConsultancyTemplateForm.CheckAndInit(new MUcConsultancyTemplateForm()
                {
                    FormName = settings?.FormName,
                   
                    Content = this
                });
                _ucConsultancyGrid.CheckAndInit(new MUcConsultancyTemplateGrid()
                {
                    FormName = settings?.FormName,
                   
                    Content = this
                });

                _isLoaded = true;
            }
            SetReadOnly(true);
            StartCreate();
        }

        public void ResetData()
        {
            _ucConsultancyTemplateForm.ResetData();
        }

        private void InitFields()
        {
            _dbIoc = XIoc.GetService(CDb.IocKey);
            _guiIoc = XIoc.GetService(CGui.IocKey);
            _messageService = _guiIoc.GetInstance<IAppMessage>();
            _iconService = _guiIoc.GetInstance<IIconService>();
            _sessionRepository = _dbIoc.GetInstance<IRepositorySession>();
            _repositoryConsultancyTemplate = _dbIoc.GetInstance<IRepositoryConsultancyTemplate>();
        }

        private void SetIcons()
        {

        }

        private void ConfigControls()
        {
            _ucRichContent.NewAction = StartCreate;
            _ucRichContent.SaveAction = StartSave;
          
        }

        private void StartSave()
        {
            var isForNew = string.IsNullOrWhiteSpace(Model.Id);
            Save(isForNew);
        }

        private void SetReadOnly(bool isReadOnly)
        {
            _ucRichContent.SetReadOnly(isReadOnly);

          
            _btnSave.Enabled = !isReadOnly;
            _btnSaveNew.Enabled = !isReadOnly;
            //_btnInsertTemplate.Enabled = !isReadOnly;
            Form?.SetReadOnly(isReadOnly);
        }

        private void _btnCreateNewConsultItem_Click(object sender, EventArgs e)
        {
            StartCreate();
        }

        private void StartCreate()
        {
            ResetData();
            SetReadOnly(false);
            LoadDefaultValues();
            CreateNewModel();
            _btnSave.Enabled = false;
            _btnSaveNew.Enabled = true;
            _ucRichContent.FileName = string.Empty;
            _ucRichContent.StartEdit();
        }

        public void StartEdit(MEntityConsultancyTemplate model)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                _messageService.ShowError("Vui lòng chọn tư vấn để xem!");
                return;
            }
            ResetData();
            SetReadOnly(false);
            LoadSavedModel(model);
            _btnSave.Enabled = true;
            _btnSaveNew.Enabled = true;
            _ucRichContent.FileName = string.Empty;
            _ucRichContent.StartEdit();
        }

        private void LoadDefaultValues(bool isUpdate = false)
        {
            Form?.LoadDefaultValues();
        }

        private void CreateNewModel()
        {
            var model = new MEntityConsultancyTemplate();
            Form?.ApplyDefaultValues(model);
            Model = model;
        }

        private void LoadSavedModel(MEntityConsultancyTemplate model)
        {
            //Form?.ApplyDefaultValues(model);
            Model = model;
        }

        public MEntityConsultancyTemplate SelectedModel
        {
            get { return _ucConsultancyGrid.SelectedModel; }
        }

        private MEntityConsultancyTemplate _model = new MEntityConsultancyTemplate();
        protected MEntityConsultancyTemplate Model
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

        public void InsertText(EConsultancyTemplateText type, string text)
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
            XLoading.ShowLoading();
            var text = "Tư Vấn";
            var model = Model;
            var isNeedReload = false;
            if (isForNew)
            {
                model.Id = null;
                var isCanSave = Form.CheckCanSave(model, true, true);
                if (isCanSave)
                {
                    var dateTime = _repositoryConsultancyTemplate.GetDateTime();
                    _sessionRepository.ApplyCreatedBasicFields(model, dateTime);
                    var rs = _repositoryConsultancyTemplate.InsertGetGuid(model);
                    if (!string.IsNullOrWhiteSpace(rs))
                    {
                        model.Id = rs;
                        _messageService.ShowInsertSuccessInfo(text, true);
                        isNeedReload = true;
                    }
                }
                
            }
            else
            {
                var isCanSave = Form.CheckCanSave(model, false, true);
                if (isCanSave)
                {
                    var dateTime = _repositoryConsultancyTemplate.GetDateTime();
                    _sessionRepository.ApplyUpdatedBasicFields(model, dateTime);
                    var rs = _repositoryConsultancyTemplate.Update(model);
                    if (rs > 0)
                    {
                        _messageService.ShowUpdateSuccessInfo(text, true);
                        isNeedReload = true;
                    }
                }
            }

            if (isNeedReload)
            {
                _ucConsultancyGrid.ReloadData();
                
                var m = _repositoryConsultancyTemplate.Find(model?.Id);
                StartEdit(m);
            }
            XLoading.CloseLoading();
        }

        

        private void _chkIsExpandMode_CheckedChanged(object sender, EventArgs e)
        {
            //_splitContainer.Panel2.Visible = !_chkIsExpandMode.Checked;

            _splitContainer.Panel2Collapsed = _chkIsExpandMode.Checked;
        }

        public void LoadSuggestions(List<MSuggestText> suggestions)
        {
            _ucRichContent.LoadSuggestions(suggestions);
        }

    }
}
