using VegunSoft.Layer.EValue.Basic;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Consult
{
    public partial class UcOrderConsultBody
    {

        #region UI Status

        protected bool IsReadOnlyUserFields => InputCase == EInputCase.None;

        protected bool IsEnableSave => InputCase == EInputCase.Editing;

        protected bool IsEnableSaveNew => InputCase == EInputCase.Adding || InputCase == EInputCase.Editing;

        public EInputCase InputCase
        {
            get => Form.InputCase;
            set
            {
                Form.InputCase = value;
                ApplyReadOnly();
            }
        }

        #endregion


    }
}
