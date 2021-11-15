using System.Collections.Generic;
using VegunSoft.Acc.Entity.Provider.Acc;
using VegunSoft.Category.Entity.Provider.Category.Body;
using VegunSoft.Product.Entity.Provider.Category;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Consult
{
    public partial class UcConsultancyTemplateForm
    {
        private bool _cbbProductServiceLoading;

        public List<MEntityTooth> ListTeeth
        {
            get
            {
                if (_glkTooth == null) return new List<MEntityTooth>();
                return _glkTooth.Properties.DataSource as List<MEntityTooth> ?? new List<MEntityTooth>();
            }
        }

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


        private void LoadTeeth()
        {
            _glkTooth.Properties.DataSource = _repositoryTooth.GetActiveTeeth();
            //txtIdRang.EditValue = 0;
        }



        private void LoadDataSources()
        {
            LoadTeeth();
  
            _glkProductServiceType.ReloadData();
            _glkProductServiceGroup.ReloadData();
            _glkProductServiceGroupFinal.ReloadData();
            _cbbCreatedUsername.ReloadData();
        }

        private void ResetTeeth()
        {
            _btnSelectTeeth.Tag = "";
            _btnSelectTeeth.Text = "Chọn...";
        }
    }
}
