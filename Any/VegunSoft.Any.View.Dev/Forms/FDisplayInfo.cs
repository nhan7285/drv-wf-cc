using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VegunSoft.Framework.Gui.Services;

namespace VegunSoft.Layer.Gui.Any.Provider.Forms
{
    public partial class FDisplayInfo : XtraForm, IFormInfo
    {
        private int _width;
        private int _height;

        public FDisplayInfo()
        {
            InitializeComponent();
            _width = this.Width;
            _height = this.Height;
        }

        public IFormInfo SetCaption(string caption)
        {
            this.Text = caption;
            return this;
        }

        public IFormInfo SetDescription(string description)
        {
            _txtDescription.Text = description;
            _txtDescription.Visible = !string.IsNullOrWhiteSpace(description);
            _txtDescription.Select(0, 0);
            _txtDescription.ReadOnly = true;
            return this;
        }

        public void ShowPopup(object owner, string description, float widthRate = 1, float heightRate = 1)
        {
            SetSizeRate(widthRate, heightRate);
            SetDescription(description);

            //_txtDescription.DeselectAll();
            this.ShowDialog((IWin32Window)owner);
        }

        private void _btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void FDisplayInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Text = "Thông báo:";
            if (this.Owner is Form f)
            {
                f?.Focus();
                f?.Activate();
            }
        }

        public IFormInfo SetSizeRate(float widthRate = 1, float heightRate = 1)
        {
            if (widthRate > 0 && _width > 0) this.Width = (int)Math.Round(_width * widthRate);
            if (heightRate > 0 && _height > 0) this.Height = (int)Math.Round(_height * heightRate);
            return this;
        }
    }
}
