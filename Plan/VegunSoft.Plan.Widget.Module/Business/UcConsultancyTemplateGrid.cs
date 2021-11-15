using System;
using System.Collections.Generic;
using System.Linq;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Services;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Layer.UcControl.Forms.Order.Consult;
using VegunSoft.Layer.UcControl.Models;
using VegunSoft.Layer.UcService.Provider.Any;
using VegunSoft.Message.Service.App;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Repository.Categories;
using VegunSoft.Session.Repository.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Consult
{
    public partial class UcConsultancyTemplateGrid : System.Windows.Forms.UserControl
    {
        private bool _isLoaded;
        private IIocService _dbIoc;
        private IIocService _guiIoc;
        private IIconService _iconService;
        private IAppMessage _messageService;
        private IRepositorySession _sessionRepository;
        private IRepositoryConsultancyTemplate _repositoryConsultancyTemplate;
        private List<MEntityConsultancyTemplate> _models;
        

        protected MUcConsultancyTemplateGrid Settings { get; private set; }
        public IUcConsultancyTemplateContent Content
        {
            get
            {
                return Settings?.Content;
            }
        }

        public MEntityConsultancyTemplate SelectedModel
        {
            get { return _view.GetFocusedRow() as MEntityConsultancyTemplate; }
        }

        public UcConsultancyTemplateGrid()
        {
            InitializeComponent();
        }

        public void CheckAndInit(MUcConsultancyTemplateGrid settings)
        {
            if (!_isLoaded)
            {
                Settings = settings;
                InitFields();
                SetIcons();
                ConfigControls();
                SetReadOnly(true);
                _isLoaded = true;
            }

            ReloadData();
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

        public void SetReadOnly(bool isReadOnly)
        {

        }

        private void SetIcons()
        {

        }

        private void ConfigControls()
        {
            _gcConsultNo.FieldName = nameof(MEntityConsultancyTemplate.No);
            _gcConsultCreatedDate.FieldName = nameof(MEntityConsultancyTemplate.StartDateTime);
            _gcConsultName.FieldName = nameof(MEntityConsultancyTemplate.Name);
            _gcConsultIsActive.FieldName = nameof(MEntityConsultancyTemplate.IsActive);
            _gcConsultDescription.FieldName = nameof(MEntityConsultancyTemplate.Description);
            _gcConsultTypeName.FieldName = nameof(MEntityConsultancyTemplate.ProductServiceTypeName);
            _gcConsultGroupName.FieldName = nameof(MEntityConsultancyTemplate.ProductServiceGroupName);
            _gcConsultGroupFinalName.FieldName = nameof(MEntityConsultancyTemplate.ProductServiceGroupFinalName);
            _gcConsultProductServiceName.FieldName = nameof(MEntityConsultancyTemplate.ProductServiceName);
            _gcConsultDoctor.FieldName = nameof(MEntityConsultancyTemplate.ConsultingDoctorFullName);
            _gcConsultAssistant.FieldName = nameof(MEntityConsultancyTemplate.ConsultingAssistantFullName);
        }


        public void ReloadData()
        {
            _models = _repositoryConsultancyTemplate.Where(nameof(MEntityConsultancyTemplate.IsDeleted), false).ToList();
            _grid.DataSource = _models;
            _view.RefreshData();
        }

        private void _lnkDelete_Click(object sender, EventArgs e)
        {
            var model = _view.GetFocusedRow() as MEntityConsultancyTemplate;
            if (_messageService.IsAgree(Class_Global._tbXoa))
            {
                var rs = _repositoryConsultancyTemplate.Delete(model);
                if (rs)
                {
                    var text = "Tư Vấn";
                    _messageService.ShowDeleteSuccessInfo(text, true);
                    ReloadData();
                }
                else
                {
                    _messageService.ShowError(Class_Global.ERROR_DELETE_DATA);
                }
            }
        }

        private void _lnkEdit_Click(object sender, EventArgs e)
        {
            var model = _view.GetFocusedRow() as MEntityConsultancyTemplate;
            Content?.StartEdit(model);
        }
    }
}
