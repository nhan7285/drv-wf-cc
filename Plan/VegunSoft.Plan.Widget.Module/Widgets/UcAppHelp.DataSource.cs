using System;
using System.Collections.Generic;
using VegunSoft.Acc.Entity.Provider.Acc;
using VegunSoft.Layer.EValue.Customer.Advice;
using VegunSoft.Product.Entity.Provider.Category;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Consult
{
    public partial class UcAppHelpForm
    {
        private bool _cbbProductServiceLoading;

        public List<MEntityUserAccountMin> ListUsers
        {
            get
            {
                if (_cbbCreatedUsername == null) return new List<MEntityUserAccountMin>();
                return _cbbCreatedUsername.Properties.DataSource as List<MEntityUserAccountMin> ?? new List<MEntityUserAccountMin>();
            }
        }

        public List<MEntityPdsvType> ListProductServiceType
        {
            get
            {
                if (_glkProductServiceType == null) return new List<MEntityPdsvType>();
                return _glkProductServiceType.Properties.DataSource as List<MEntityPdsvType> ?? new List<MEntityPdsvType>();
            }
        }

        public List<MEntityPdsvGroup> ListProductServiceGroup
        {
            get
            {
                if (_glkProductServiceGroup == null) return new List<MEntityPdsvGroup>();
                return _glkProductServiceGroup.Properties.DataSource as List<MEntityPdsvGroup> ?? new List<MEntityPdsvGroup>();
            }
        }

        public List<MEntityPdsvBag> ListProductServiceGroupFinal
        {
            get
            {
                if (_glkProductServiceGroupFinal == null) return new List<MEntityPdsvBag>();
                return _glkProductServiceGroupFinal.Properties.DataSource as List<MEntityPdsvBag> ?? new List<MEntityPdsvBag>();
            }
        }

        //public List<MEntityProductService> ListProductService
        //{
        //    get
        //    {
        //        if (_cbbProductService == null) return new List<MEntityProductService>();
        //        return _cbbProductService.Properties.DataSource as List<MEntityProductService> ?? new List<MEntityProductService>();
        //    }
        //}


        private void LoadTeeth()
        {
          
            //txtIdRang.EditValue = 0;
        }

        private void InitWorkingTime()
        {
            _dateWorkingTime.DateTime = _repositoryTooth.GetDateTime();
            _dateWorkingTime.Properties.ReadOnly = !_checkRightsService.CheckCanChangeWorkingDateTime(SessionCode, Settings?.FormName);
        }

        //private void LoadProductServices()
        //{
        //    _cbbProductServiceLoading = true;
        //    var productServices = _dentistryServiceRepository.Where(nameof(MEntityProductService.IsService), true).OrderBy(x => x.GroupDisplayPriority)
        //        .Where(x => x.IsActive).ToList();
        //    var dateTime = _dateWorkingTime.DateTime;
        //    _cbbProductService.Properties.DataSource = _repositoryProductServiceSetting.GetProductServices(productServices, dateTime);
        //    _cbbProductServiceLoading = false;
        //}

        private void _txtCreatedDate_EditValueChanged(object sender, EventArgs e)
        {
            InsertText(_dateWorkingTime, EConsultancyTemplateText.CreatedDateTime, true);
            //LoadProductServices();
        }

        private void LoadDataSources()
        {
            LoadTeeth();
            //LoadProductServices();
            _glkProductServiceType.ReloadData();
            _glkProductServiceGroup.ReloadData();
            _glkProductServiceGroupFinal.ReloadData();
            _cbbCreatedUsername.ReloadData();
        }



        private void ResetTeeth()
        {
           
        }
    }
}
