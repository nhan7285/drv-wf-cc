using System.Collections.Generic;
using System.Windows.Forms;
using VegunSoft.Acc.Entity.Acc;
using VegunSoft.Acc.Entity.Provider.Rights;
using VegunSoft.Company.Entity.Provider.Organization;

namespace VegunSoft.Acc.Widget.Forms
{
    public interface IFormLoginForPrivate
    {
        void ShowWindow(object parent);

        IFormLoginForPrivate Init(Form parent, string username);

        MEntityBranch SelectedBranch { get; set; }

        IEntityUserAccountMin SelectedAccount { get; set; }

        IList<MEntityUserRightAcc> Rights { get; }

        void Login();
    }
}
