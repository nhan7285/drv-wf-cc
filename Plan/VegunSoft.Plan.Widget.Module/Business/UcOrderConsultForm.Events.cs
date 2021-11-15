using System;
using System.Windows.Forms;
using VegunSoft.App.Data.Business;
using VegunSoft.Layer.EValue.Customer.Advice;
using VegunSoft.Layer.UcControl.Customer.Forms;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Consult
{
    public partial class UcOrderConsultForm
    {
        private void _glkProductServiceType_EditValueChanged(object sender, EventArgs e)
        {
            InsertText(_glkProductServiceType, EConsultancyText.ProductServiceType, true);
        }

        private void _glkProductServiceType_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_glkProductServiceType, EConsultancyText.ProductServiceType, false);
        }

        private void _lblProductServiceType_Click(object sender, EventArgs e)
        {
            InsertText(_glkProductServiceType, EConsultancyText.ProductServiceType, false);
        }

        private void _glkProductServiceGroup_EditValueChanged(object sender, EventArgs e)
        {
            InsertText(_glkProductServiceGroup, EConsultancyText.ProductServiceGroup, true);
        }

        private void _glkProductServiceGroup_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_glkProductServiceGroup, EConsultancyText.ProductServiceGroup, false);
        }

        private void _lblProductServiceGroup_Click(object sender, EventArgs e)
        {
            InsertText(_glkProductServiceGroup, EConsultancyText.ProductServiceGroup, false);
        }

        private void _glkProductServiceGroupFinal_EditValueChanged(object sender, EventArgs e)
        {
            InsertText(_glkProductServiceGroupFinal, EConsultancyText.ProductServiceGroupFinal, true);

        }
        private void _glkProductServiceGroupFinal_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_glkProductServiceGroupFinal, EConsultancyText.ProductServiceGroupFinal, false);
        }

        private void _lblProductServiceGroupFinal_Click(object sender, EventArgs e)
        {
            InsertText(_glkProductServiceGroupFinal, EConsultancyText.ProductServiceGroupFinal, false);
        }

        private void _glkTooth_EditValueChanged(object sender, EventArgs e)
        {
            InsertText(_glkTooth, EConsultancyText.Tooth, true);
        }

        private void _glkTooth_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_glkTooth, EConsultancyText.Tooth, false);
        }

        private void _lblTooth_Click(object sender, EventArgs e)
        {
            InsertText(_glkTooth, EConsultancyText.Tooth, false);
        }

        private void _btnSelectTeeth_Click(object sender, EventArgs e)
        {
            ResetTeeth();
           
            var oTeeth = GuiIoc.GetInstance<Form>(EFormMgmt.FShowTeeth.ToString());
            var iTeeth = oTeeth as IFShowTeeth;
            if (iTeeth != null)
            {
                iTeeth.SelectedTeeth = SelectedTeeth;
                oTeeth.ShowDialog();
                _glkTooth.EditValue = 0;
                SelectedTeeth = iTeeth.SelectedTeeth;
            }

            if (SelectedTeeth.Count > 0)
            {
                foreach (var ob in SelectedTeeth)
                {
                    _btnSelectTeeth.Tag += ob.TEN + "; ";
                }
            }

            _btnSelectTeeth.Text = _btnSelectTeeth.Tag?.ToString() ?? "Chọn...";
            InsertText(_btnSelectTeeth, EConsultancyText.Teeth, true);

        }

        private void _btnSelectTeeth_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_btnSelectTeeth, EConsultancyText.Teeth, false);
        }

        private void _lblSelectTeeth_Click(object sender, EventArgs e)
        {
            InsertText(_btnSelectTeeth, EConsultancyText.Teeth, false);
        }

        private void _cbbConsultingDoctor_EditValueChanged(object sender, EventArgs e)
        {
            InsertText(_cbbConsultingDoctor, EConsultancyText.ConsultingDoctor, true);
        }

        private void _cbbConsultingDoctor_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_cbbConsultingDoctor, EConsultancyText.ConsultingDoctor, false);
        }

        private void _lblConsultingDoctor_Click(object sender, EventArgs e)
        {
            InsertText(_cbbConsultingDoctor, EConsultancyText.ConsultingDoctor, false);
        }

        private void _cbbConsultingAssistant_EditValueChanged(object sender, EventArgs e)
        {
            InsertText(_cbbConsultingAssistant, EConsultancyText.ConsultingAssistant, true);
        }

        private void _cbbConsultingAssistant_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_cbbConsultingAssistant, EConsultancyText.ConsultingAssistant, false);
        }

        private void _lblConsultingAssistant_Click(object sender, EventArgs e)
        {
            InsertText(_cbbConsultingAssistant, EConsultancyText.ConsultingAssistant, false);
        }

        private void _txtConsultDate_EditValueChanged(object sender, EventArgs e)
        {
            InsertText(_txtConsultDate, EConsultancyText.ConsultingDateTime, true);
        }

        private void _txtConsultDate_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_txtConsultDate, EConsultancyText.ConsultingDateTime, false);
        }

        private void _lblConsultDate_Click(object sender, EventArgs e)
        {
            InsertText(_txtConsultDate, EConsultancyText.ConsultingDateTime, false);
        }

        private void _txtCreatedDate_EditValueChanged(object sender, EventArgs e)
        {
            InsertText(_txtCreatedDate, EConsultancyText.CreatedDateTime, true);
        }

        private void _txtCreatedDate_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_txtCreatedDate, EConsultancyText.CreatedDateTime, false);
        }

        private void _lblCreatedDate_Click(object sender, EventArgs e)
        {
            InsertText(_txtCreatedDate, EConsultancyText.CreatedDateTime, false);
        }

        private void _txtUpdatedDate_EditValueChanged(object sender, EventArgs e)
        {
            InsertText(_txtUpdatedDate, EConsultancyText.UpdatedDateTime, true);
        }

        private void _txtUpdatedDate_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_txtUpdatedDate, EConsultancyText.UpdatedDateTime, false);
        }

        private void _lblUpdatedDate_Click(object sender, EventArgs e)
        {
            InsertText(_txtUpdatedDate, EConsultancyText.UpdatedDateTime, false);
        }

        private void _cbbCreatedUsername_EditValueChanged(object sender, EventArgs e)
        {
            InsertText(_cbbCreatedUsername, EConsultancyText.CreatedUsername, true);
        }

        private void _cbbCreatedUsername_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_cbbCreatedUsername, EConsultancyText.CreatedUsername, false);
        }

        private void _lblCreatedUsername_Click(object sender, EventArgs e)
        {
            InsertText(_cbbCreatedUsername, EConsultancyText.CreatedUsername, false);
        }

        private void _cbbUpdatedUsername_EditValueChanged(object sender, EventArgs e)
        {
            InsertText(_cbbUpdatedUsername, EConsultancyText.UpdatedUsername, true);

        }

        private void _cbbUpdatedUsername_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_cbbUpdatedUsername, EConsultancyText.UpdatedUsername, false);
        }

        private void _lblUpdatedUsername_Click(object sender, EventArgs e)
        {
            InsertText(_cbbUpdatedUsername, EConsultancyText.UpdatedUsername, false);
        }

        private void _txtName_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_txtName, EConsultancyText.Name, false);
        }

        private void _lblName_Click(object sender, EventArgs e)
        {
            InsertText(_txtName, EConsultancyText.Name, false);
        }

        private void _btnClearTeeth_Click(object sender, EventArgs e)
        {
            ResetTeeth();
        }
    }
}
