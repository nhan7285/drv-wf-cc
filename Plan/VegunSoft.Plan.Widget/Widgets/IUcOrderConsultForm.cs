using VegunSoft.Layer.EValue.Basic;
using VegunSoft.Order.Entity.Provider.Business;

namespace VegunSoft.Layer.UcControl.Forms.Order.Consult
{
    public interface IUcOrderConsultForm
    {
        EInputCase InputCase { get; set; }

        bool IsChanged { get; }

        void ApplyDefaultValues(MEntityOrderConsult model);

        void LoadDefaultValues(bool isUpdate = false);

        bool IsAutoInsertToContent { get; }
       

        void ApplyEditingValues(MEntityOrderConsult model);

        void LoadValuesToEditors(MEntityOrderConsult model);

        bool CheckCanSave(MEntityOrderConsult model, bool isForInsert, bool isShowMessage);

        void OnEndStartCreate();

        void OnEndStartEdit();
    }
}
