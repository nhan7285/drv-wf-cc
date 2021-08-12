using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Db.Services;

namespace VegunSoft.Any.View.Dev.Forms
{
    public partial class frmKetnoi_SQLServer : XtraForm
    {
        protected static IServiceDataSession Dbs => GDb.Dbs;
        protected IServiceConnection Cnn => Dbs.GetConnection(Dbs.SessionCode);
        public frmKetnoi_SQLServer()
        {
            InitializeComponent();
        }

        int i = 15;
        private void timer1_Tick(object sender, EventArgs e)
        {
            btnThulai.Text = "Kết nối lại (" + i.ToString() +")";
            if (i == 0)
            {
                btnThulai.PerformClick();
            }
            i--;
        }

        private void frmKetnoi_SQLServer_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                Application.Exit();
            }
            catch
            {

            }
        }

        private void btnThulai_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            try
            {
                var date = Cnn.GetDate();

              
            }
            catch (Exception)
            {
                i = 15;
                timer1.Start();
            }
        }

     
    }
}