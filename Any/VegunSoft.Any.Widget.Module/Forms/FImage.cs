using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace VegunSoft.Any.View.Dev.Forms
{
    public partial class FImage : XtraForm
    {
        public FImage()
        {
            InitializeComponent();
        }

        public void ShowImage(string title, string fullPath)
        {
            this.Text = title;
            if (string.IsNullOrWhiteSpace(fullPath))
            {
                _pbCustomerImage.SizeMode = PictureBoxSizeMode.StretchImage;
                _pbCustomerImage.Image = null;
                return;
            }

            _pbCustomerImage.SizeMode = PictureBoxSizeMode.StretchImage;
            _pbCustomerImage.ImageLocation = fullPath;
        }
    }
}
