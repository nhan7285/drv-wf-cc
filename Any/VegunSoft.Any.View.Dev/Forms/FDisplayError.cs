using System.Windows.Forms;
using DevExpress.XtraEditors;
using VegunSoft.Framework.Gui.Services;

namespace VegunSoft.Layer.Gui.Any.Provider.Forms
{
    public partial class FDisplayError : XtraForm, IFormError
    {
        public FDisplayError()
        {
            InitializeComponent();
        }

        public void ShowPopup(object owner, string message, string description)
        {
            //Text = title;
            _txtMessage.Text = string.IsNullOrWhiteSpace(description)? string.Empty: message;
            _txtDescription.Text = string.IsNullOrWhiteSpace(description)? message: description;
            _txtMessage.Visible = !string.IsNullOrWhiteSpace(_txtMessage.Text);
            _txtDescription.Visible = !string.IsNullOrWhiteSpace(_txtDescription.Text);
            //_txtMessage.DeselectAll();
            //_txtDescription.DeselectAll();
            this.ShowDialog((IWin32Window) owner);
        }

        private void _btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
