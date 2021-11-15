namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Consult
{
    public partial class UcOrderConsultBody
    {
        private void ApplyReadOnly()
        {
            var isReadOnlyUserFields = IsReadOnlyUserFields;
            _ucRichContent.SetReadOnly(isReadOnlyUserFields);
            _glkTemplates.Properties.ReadOnly = isReadOnlyUserFields;
            _btnInsertTemplate.Enabled = !isReadOnlyUserFields;

            _btnSave.Enabled = IsEnableSave;
            _btnSaveNew.Enabled = IsEnableSaveNew;
            _btnCancel.Enabled = !isReadOnlyUserFields;

        }

    }
}
