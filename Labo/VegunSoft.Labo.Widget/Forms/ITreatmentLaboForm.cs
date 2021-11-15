using System;
using VegunSoft.Framework.Gui.Provider.WindowsForms.Views;

namespace VegunSoft.Labo.Widget.Forms
{
    public interface ITreatmentLaboForm : IForm
    {
        void Init(string customerId, int customerNo, string customerCode, string customerDisplayCode, string customerFullName, DateTime createdDate);
    }
}
