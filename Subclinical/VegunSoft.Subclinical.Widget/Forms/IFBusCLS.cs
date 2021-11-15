using System.Windows.Forms;
using VegunSoft.Acc.Entity.Acc;
using VegunSoft.Customer.Entity.Provider.Profile;

namespace VegunSoft.Layer.UcControl.Customer.Forms
{
    public interface IFBusCLS
    {
        DialogResult ShowDialog();

        IFBusCLS Init(MEntityCustomer customer, IEntityUserAccountMin userAccount);
    }
}
