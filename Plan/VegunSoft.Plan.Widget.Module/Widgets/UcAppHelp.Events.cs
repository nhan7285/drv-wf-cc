using System;
using VegunSoft.Layer.EValue.Customer.Advice;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Consult
{
    public partial class UcAppHelpForm
    {
        private void _glkProductServiceType_EditValueChanged(object sender, EventArgs e)
        {
            InsertText(_glkProductServiceType, EConsultancyTemplateText.ProductServiceType, true);

        }

        private void _glkProductServiceType_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_glkProductServiceType, EConsultancyTemplateText.ProductServiceType, false);
        }

        private void _lblProductServiceType_Click(object sender, EventArgs e)
        {
            InsertText(_glkProductServiceType, EConsultancyTemplateText.ProductServiceType, false);
        }

        private void _glkProductServiceGroup_EditValueChanged(object sender, EventArgs e)
        {
            InsertText(_glkProductServiceGroup, EConsultancyTemplateText.ProductServiceGroup, true);
        }

        private void _glkProductServiceGroup_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_glkProductServiceGroup, EConsultancyTemplateText.ProductServiceGroup, false);
        }

        private void _lblProductServiceGroup_Click(object sender, EventArgs e)
        {
            InsertText(_glkProductServiceGroup, EConsultancyTemplateText.ProductServiceGroup, false);
        }

        private void _glkProductServiceGroupFinal_EditValueChanged(object sender, EventArgs e)
        {
            InsertText(_glkProductServiceGroupFinal, EConsultancyTemplateText.ProductServiceGroupFinal, true);

        }
        private void _glkProductServiceGroupFinal_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_glkProductServiceGroupFinal, EConsultancyTemplateText.ProductServiceGroupFinal, false);
        }

        private void _lblProductServiceGroupFinal_Click(object sender, EventArgs e)
        {
            InsertText(_glkProductServiceGroupFinal, EConsultancyTemplateText.ProductServiceGroupFinal, false);
        }

     
        private void _cbbConsultingDoctor_EditValueChanged(object sender, EventArgs e)
        {
            InsertText(_cbbConsultingDoctor, EConsultancyTemplateText.ConsultingDoctor, true);
        }

        private void _cbbConsultingDoctor_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_cbbConsultingDoctor, EConsultancyTemplateText.ConsultingDoctor, false);
        }

        private void _lblConsultingDoctor_Click(object sender, EventArgs e)
        {
            InsertText(_cbbConsultingDoctor, EConsultancyTemplateText.ConsultingDoctor, false);
        }

        private void _cbbConsultingAssistant_EditValueChanged(object sender, EventArgs e)
        {
            InsertText(_cbbConsultingAssistant, EConsultancyTemplateText.ConsultingAssistant, true);

        }

        private void _cbbConsultingAssistant_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_cbbConsultingAssistant, EConsultancyTemplateText.ConsultingAssistant, false);
        }

        private void _lblConsultingAssistant_Click(object sender, EventArgs e)
        {
            InsertText(_cbbConsultingAssistant, EConsultancyTemplateText.ConsultingAssistant, false);
        }

        private void _txtBeginDate_EditValueChanged(object sender, EventArgs e)
        {
            InsertText(_txtBeginDate, EConsultancyTemplateText.BeginDateTime, true);

        }

        private void _txtBeginDate_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_txtBeginDate, EConsultancyTemplateText.BeginDateTime, false);
        }
        private void _lblBeginDate_Click(object sender, EventArgs e)
        {
            InsertText(_txtBeginDate, EConsultancyTemplateText.BeginDateTime, false);

        }


        private void _txtEndDate_EditValueChanged(object sender, EventArgs e)
        {
            InsertText(_txtEndDate, EConsultancyTemplateText.EndDateTime, true);
        }

        private void _txtEndDate_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_txtEndDate, EConsultancyTemplateText.EndDateTime, false);
        }

        private void _lblEndDate_Click(object sender, EventArgs e)
        {
            InsertText(_txtEndDate, EConsultancyTemplateText.EndDateTime, false);
        }

       

        private void _txtCreatedDate_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_dateWorkingTime, EConsultancyTemplateText.CreatedDateTime, false);
        }

        private void _lblCreatedDate_Click(object sender, EventArgs e)
        {
            InsertText(_dateWorkingTime, EConsultancyTemplateText.CreatedDateTime, false);
        }

        private void _txtUpdatedDate_EditValueChanged(object sender, EventArgs e)
        {
            InsertText(_txtUpdatedDate, EConsultancyTemplateText.UpdatedDateTime, true);

        }

        private void _txtUpdatedDate_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_txtUpdatedDate, EConsultancyTemplateText.UpdatedDateTime, false);
        }

        private void _lblUpdatedDate_Click(object sender, EventArgs e)
        {
            InsertText(_txtUpdatedDate, EConsultancyTemplateText.UpdatedDateTime, false);
        }

        private void _cbbCreatedUsername_EditValueChanged(object sender, EventArgs e)
        {
            InsertText(_cbbCreatedUsername, EConsultancyTemplateText.CreatedUsername, true);

        }

        private void _cbbCreatedUsername_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_cbbCreatedUsername, EConsultancyTemplateText.CreatedUsername, false);
        }

        private void _lblCreatedUsername_Click(object sender, EventArgs e)
        {
            InsertText(_cbbCreatedUsername, EConsultancyTemplateText.CreatedUsername, false);
        }

        private void _cbbUpdatedUsername_EditValueChanged(object sender, EventArgs e)
        {
            InsertText(_cbbUpdatedUsername, EConsultancyTemplateText.UpdatedUsername, true);
        }

        private void _cbbUpdatedUsername_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_cbbUpdatedUsername, EConsultancyTemplateText.UpdatedUsername, false);
        }

        private void _lblUpdatedUsername_Click(object sender, EventArgs e)
        {
            InsertText(_cbbUpdatedUsername, EConsultancyTemplateText.UpdatedUsername, false);
        }

        private void _txtName_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_txtName, EConsultancyTemplateText.Name, false);
        }

        private void _lblName_Click(object sender, EventArgs e)
        {
            InsertText(_txtName, EConsultancyTemplateText.Name, false);
        }

        private void _txtCode_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_txtCode, EConsultancyTemplateText.Code, false);
        }

        private void _lblCode_Click(object sender, EventArgs e)
        {
            InsertText(_txtCode, EConsultancyTemplateText.Code, false);
        }

        private void _txtDescription_DoubleClick(object sender, EventArgs e)
        {
            InsertText(_txtDescription, EConsultancyTemplateText.Description, false);
        }

        private void _lblDescription_Click(object sender, EventArgs e)
        {
            InsertText(_txtDescription, EConsultancyTemplateText.Description, false);
        }

        private void _btnClearTeeth_Click(object sender, EventArgs e)
        {
            ResetTeeth();
        }
    }
}
