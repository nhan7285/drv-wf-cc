using System.Collections.Generic;
using VegunSoft.Framework.Gui.Models;
using VegunSoft.Layer.EValue.Customer.Advice;
using VegunSoft.Order.Entity.Provider.Business;

namespace VegunSoft.Layer.UcControl.Forms.Order.Consult
{
    public interface IUcOrderConsultBody
    {
        void SelectCustomer(string customerId);

        void SelectOrder(string orderId);

        void InsertText(EConsultancyText productServiceType, string text);

        void StartEdit(MEntityOrderConsult model); 

        void LoadSuggestions(List<MSuggestText> suggestions);

        MEntityOrderConsult Model { get; set; }
    }
}
