using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VegunSoft.Layer.Db.Connection.Provider;

namespace VegunSoft.Any.View.Dev.Forms
{
    public partial class frmKetnoi_SQLServer : XtraForm
    {
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
                XDbo.con.Open();

                if (XDbo.con.State == ConnectionState.Open)
                {
                    this.Close();
                }
            }
            catch (Exception)
            {
                i = 15;
                timer1.Start();
            }
        }

        public void ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}