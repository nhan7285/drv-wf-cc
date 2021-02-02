using System.ComponentModel;
using DevExpress.XtraEditors;

namespace VegunSoft.App.Icon
{
    public partial class IconExplorerForm : XtraForm
    {
        public ComponentResourceManager Resources { get; set; } = new ComponentResourceManager(typeof(IconExplorerForm));
        public IconExplorerForm()
        {
            InitializeComponent();
        }
    }
}
