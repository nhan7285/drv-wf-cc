using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VegunSoft.Framework.Gui.Services;

namespace VegunSoft.Any.View.Dev.Forms
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
            _txtMessage.Text = string.IsNullOrWhiteSpace(description) ? string.Empty : message;
            _txtDescription.Text = string.IsNullOrWhiteSpace(description) ? message : description;
            _txtMessage.Visible = !string.IsNullOrWhiteSpace(_txtMessage.Text);
            _txtDescription.Visible = !string.IsNullOrWhiteSpace(_txtDescription.Text);
            //_txtMessage.DeselectAll();
            //_txtDescription.DeselectAll();
            if (this.Visible || this.Modal)
            {
                this.Visible = false;
                this.Close();
            }
            //try
            //{
                this.ShowDialog((IWin32Window)owner);
            //}catch(Exception ex)
            //{

            //}
           
        }

        private void _btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
