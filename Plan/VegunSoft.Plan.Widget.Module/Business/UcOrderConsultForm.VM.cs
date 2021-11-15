using System;
using System.Collections.Generic;
using VegunSoft.Category.Entity.Provider.Category;
using VegunSoft.Category.Entity.Provider.Category.Body;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Layer.EValue.Basic;
using VegunSoft.Layer.UcControl.Forms.Order.Consult;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Consult
{
    public partial class UcOrderConsultForm
    {
        

        #region Value

        protected string ConsultName
        {
            get => _txtName.Text;
            set => _txtName.Text = value;
        }

        protected bool IsApplySafeName
        {
            set => ConsultName = (value && string.IsNullOrWhiteSpace(ConsultName)) ? DefaultName : ConsultName;
        }

        protected string ConsultNameTip
        {
            get => _txtName.ToolTip;
            set => _txtName.ToolTip = value;
        }

        protected bool IsCheckedIsForOld
        {
            get => _chkIsForOld.Checked;
            set => _chkIsForOld.Checked = value;
        }

        protected bool IsFocusConsultDate
        {
            set { if (value) _txtConsultDate.Focus(); }
        }

        protected DateTime ConsultDate
        {
            get => _txtConsultDate.DateTime;
            set => _txtConsultDate.DateTime = value;
        }

        protected object ConsultDateValue
        {
            get => _txtConsultDate.EditValue;
            set => _txtConsultDate.EditValue = value;
        }

        protected DateTime CreatedDate
        {
            get => _txtCreatedDate.DateTime;
        }

        protected object CreatedDateValue
        {
            get => _txtCreatedDate.EditValue;
            set => _txtCreatedDate.EditValue = value;
        }

        protected DateTime UpdatedDate
        {
            get => _txtUpdatedDate.DateTime;
        }

        protected object UpdatedDateValue
        {
            get => _txtUpdatedDate.EditValue;
            set => _txtUpdatedDate.EditValue = value;
        }

        protected MEntityCustomer SelectedCustomer
        {
            get { return Settings?.GetSelectedCustomerFunc?.Invoke(); }
        }

        protected MEntityOrder Order
        {
            get { return Settings.GetSelectedOrderFunc?.Invoke(); }
        }

        protected MEntityTooth SelectedTooth
        {
            get { return _glkTooth.GetSelectedDataRow() as MEntityTooth; }
        }

        protected IUcOrderConsultBody Content
        {
            get { return Settings?.GetContentFunc?.Invoke(); }
        }

        protected List<MEntityTooth> SelectedTeeth { get; set; } = new List<MEntityTooth>();

        #endregion

        #region ReadOnly

        protected bool IsReadOnlyName
        {
            get => _txtName.Properties.ReadOnly;
            set => _txtName.Properties.ReadOnly = value;
        }

        protected bool IsReadOnlyIsForOld
        {
            get => _chkIsForOld.Properties.ReadOnly;
            set => _chkIsForOld.Properties.ReadOnly = value;
        }

        protected bool IsReadOnlyConsultDate
        {
            get => _txtConsultDate.Properties.ReadOnly;
            set => _txtConsultDate.Properties.ReadOnly = value;
        }

        protected bool IsReadOnlyCreatedDate
        {
            get => _txtCreatedDate.Properties.ReadOnly;
            set => _txtCreatedDate.Properties.ReadOnly = value;
        }

        protected bool IsReadOnlyConsultDoctor
        {
            get => _cbbConsultingDoctor.Properties.ReadOnly;
            set => _cbbConsultingDoctor.Properties.ReadOnly = value;
        }

        protected bool IsReadOnlyConsultAssistant
        {
            get => _cbbConsultingAssistant.Properties.ReadOnly;
            set => _cbbConsultingAssistant.Properties.ReadOnly = value;
        }
        #endregion

        #region Visible

        protected bool IsVisibleIsForOld
        {
            get => _chkIsForOld.Visible;
            set => _chkIsForOld.Visible = value;
        }

        #endregion

        #region Settings

        protected bool CanChangeTime => CheckRightsService?.CheckCanChangeWorkingDateTime(SessionCode, Settings?.FormName) ?? false;
        protected bool CanApprove => CheckRightsService?.CheckCanApprove(SessionCode, Settings?.FormName) ?? false;

        protected DateTime Now => RepositoryOrderConsult.GetDateTime();
        protected string DefaultName
        {
            get
            {
                var d = ConsultDate;
                var dateString = d.ToString("dd/MM/yyyy HH:mm:ss");
                var name = $"Tư vấn ngày: {dateString}";
                return name;
            }
        }

        #endregion

        #region UI Status

        protected bool IsReadOnlyUserFields => InputCase == EInputCase.None;

        protected bool IsReadOnlyCreatedFields => IsReadOnlyUserFields || (InputCase == EInputCase.Editing && !CanChangeTime);

        protected bool IsReadOnlySystemFields => true;

        protected bool IsEnableSave => InputCase == EInputCase.Editing;

        protected bool IsEnableSaveNew => InputCase == EInputCase.Adding || InputCase == EInputCase.Editing;

        private EInputCase _inputCase;
        public EInputCase InputCase
        {
            get => _inputCase;
            set
            {
                _inputCase = value;
                ApplyReadOnly();
            }
        }
        #endregion

    }
}
