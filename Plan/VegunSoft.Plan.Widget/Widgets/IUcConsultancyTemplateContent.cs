using System.Collections.Generic;
using VegunSoft.Framework.Gui.Models;
using VegunSoft.Layer.EValue.Customer.Advice;
using VegunSoft.Order.Entity.Provider.Business;

namespace VegunSoft.Layer.UcControl.Forms.Order.Consult
{
    public interface IUcConsultancyTemplateContent
    {
        void InsertText(EConsultancyTemplateText type, string text);
        void StartEdit(MEntityConsultancyTemplate model);
        void LoadSuggestions(List<MSuggestText> suggestions);
    }
}
