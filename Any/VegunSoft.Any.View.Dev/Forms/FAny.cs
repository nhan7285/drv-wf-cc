using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace VegunSoft.Layer.Gui.Any.Provider.Forms
{
    public partial class FAny : XtraForm
    {
        public FAny()
        {
            InitializeComponent();        }

        public FAny Init(Control uc, bool isFullScreen, int deltaHeight = 20)
        {
            this.Text = uc.Text;
            this.Size = new Size(uc.Size.Width, uc.Size.Height + deltaHeight);

            uc.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(uc);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Padding = new Padding(10);

            if (isFullScreen)
            {
                this.WindowState = FormWindowState.Maximized;
            }
           
            return this;
        }

    }
}
