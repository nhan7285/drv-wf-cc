using VegunSoft.Order.Entity.Provider.Business;

namespace VegunSoft.Layer.UcControl.Forms.Order.Consult
{
    public interface IUcConsultancyTemplateForm
    {
        void SetReadOnly(bool isReadOnly);

        void ApplyDefaultValues(MEntityConsultancyTemplate model);

        void LoadDefaultValues(bool isUpdate = false);

        bool IsAutoInsertToContent { get; }
        
        void ApplyEditingValues(MEntityConsultancyTemplate model);

        void LoadValuesToEditors(MEntityConsultancyTemplate model);

        bool CheckCanSave(MEntityConsultancyTemplate model, bool isForInsert, bool isShowMessage);
    }
}
