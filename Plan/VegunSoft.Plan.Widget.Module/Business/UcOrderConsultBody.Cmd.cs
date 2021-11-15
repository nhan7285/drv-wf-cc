using VegunSoft.Layer.EValue.Basic;
using VegunSoft.Order.Entity.Provider.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Consult
{
    public partial class UcOrderConsultBody
    {
        public void StartNone()
        {
            StartCreate();
            InputCase = EInputCase.None;
        }

        public void StartCreate()
        {
            InputCase = EInputCase.Adding;
            LoadDefaultValues();
            CreateNewModel();
            _btnSave.Enabled = false;
            _btnSaveNew.Enabled = true;
            _ucRichContent.FileName = string.Empty;
            _ucRichContent.StartEdit();

            //_chkSale.Enabled = false;
            //_chkSale.Checked = false;
            Settings?.EndStartCreateConsultancyAction?.Invoke(Model);
            _beginText = _ucRichContent.SaveText;
            Form?.OnEndStartCreate();
            SetDisplayName("*");
            SetDisplayDateTime(_repositoryCustomerConsultancy.GetDateTime().ToString("dd/MM/yyyy hh:mm"));
        }

        public void StartEdit(MEntityOrderConsult model)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                Msg.ShowError("Vui lòng chọn tư vấn để xem!");
                return;
            }
            InputCase = EInputCase.Editing;         
            LoadSavedModel(model);
            _btnSave.Enabled = true;
            _btnSaveNew.Enabled = true;
            _ucRichContent.FileName = string.Empty;
            _ucRichContent.StartEdit();
            //if (!_chkSale.Enabled)
            //{
            //    _chkSale.Enabled = true;
            //    _chkSale.Checked = (Settings?.IsDefaultClosingSale ?? false);
            //}

            Settings?.EndStartEditConsultancyAction?.Invoke(model);
            _beginText = _ucRichContent.SaveText;
            Form?.OnEndStartEdit();

            SetDisplayName(model.No.ToString());
            SetDisplayDateTime(model.StartDateTime != null ? model.StartDateTime.Value.ToString("dd/MM/yyyy hh:mm") : string.Empty);
        }
    }
}
