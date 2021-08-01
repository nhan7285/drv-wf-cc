using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;
using VegunSoft.Any.View.Dev.Forms;
using VegunSoft.Framework.Db.Provider.SQLServer.Services.Builders;
using VegunSoft.Framework.Db.Services.Builders;
using VegunSoft.Layer.Db.Connection.Provider;

namespace VegunSoft.Any.View.Dev
{
    public class Connect
    {
        //static Multi m = new Multi();
        //public static string ConnectionString = ConfigurationManager.AppSettings["Database"]?.ToString();


        public static SqlConnection conn()
        {
            try
            {
                return XDbo.conn();


            }
            catch (Exception ex)
            {

                bool check = true;
                frmKetnoi_SQLServer _frm = new frmKetnoi_SQLServer();
                foreach (Form f in Application.OpenForms)
                {
                    if (f == _frm)
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    _frm.ShowDialog();
                }
            }

            return XDbo.con;
        }

        public static SqlConnection MasterConn()
        {
            try
            {
                XDbo.MasterConn();
            }
            catch (Exception)
            {
                // throw;
                bool check = true;
                frmKetnoi_SQLServer _frm = new frmKetnoi_SQLServer();
                foreach (Form f in Application.OpenForms)
                {
                    if (f == _frm)
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    _frm.ShowDialog();
                }
            }

            return XDbo.mastercon;
        }

        public static void Open()
        {
            try
            {

                //var key = Environment.MachineName;
                //if (ConfigurationManager.ConnectionStrings.Cast<ConnectionStringSettings>().Any(x=>x.Name.Equals(key)))
                //{
                //    ConnectionString = ConfigurationManager.ConnectionStrings[key].ConnectionString;
                //}
                //else
                //{
                //    ConnectionString = m.ReadLineFrom64bit(Application.StartupPath + @"\Data\Connect.property");
                //}
                //  var cs = XConfig.GetConnectionSetting(DSession.ser, role);
                IConnectionStringBuilder builder = new ConnectionStringBuilder();
                var cString = builder.Build(DbSession.ConnectionSetting);
                using (SqlConnection connection = new SqlConnection(cString))
                {
                    connection.Open();
                }
                XDbo.mastercon.ConnectionString = cString;
            }
            catch (Exception)
            {
                throw;
                //frmConnectDB f = new frmConnectDB();
                //f.FormClosing += new FormClosingEventHandler(f_FormClosing);
                //f.ShowDialog();
            }

        }

        static void f_FormClosing(object sender, FormClosingEventArgs e)
        {
            // ConnectionString = m.ReadLineFrom64bit(Application.StartupPath + @"\Data\\Connect.property");
        }

        //public static void Close()
        //{
        //    IConnectionStringBuilder builder = new ConnectionStringBuilder();
        //    var cString = builder.Build(DSession.ConnectionSetting);
        //    using (SqlConnection connection = new SqlConnection(XConfig.GetConnectionString()))
        //    {
        //        if(connection.State == System.Data.ConnectionState.Open)
        //            connection.Close();
        //    }
        //}
    }
}
