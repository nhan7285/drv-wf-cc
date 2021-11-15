using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegunSoft.Customer.Widget.Forms
{
    public interface IFormChangeStatus
    {
        void SetText(string caption, string label);

        void RevertText();

        void ShowPopup(object owner, string message, string status, string oldNote, string newNote);

        string Note { get; }

        bool IsSave { get; }

    }
}
