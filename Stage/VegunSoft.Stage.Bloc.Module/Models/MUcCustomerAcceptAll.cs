using System;
using VegunSoft.Company.Data.Enums;

namespace VegunSoft.Layer.UcService.Provider.Models
{
    public class MUcCustomerAcceptAll
    {
      
        public string FormName { get; set; }

        public System.Windows.Forms.Form Parent { get; set; }

        public Action<EFunction, bool> OnAcceptAction { get; set; }

        public Action<EFunction, string> OnSearch { get; set; }
    }
}
