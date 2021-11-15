using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using VegunSoft.App.Service.Mgmt;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums;
using VegunSoft.Framework.Gui.Provider.WindowsForms;
using VegunSoft.Framework.Ioc;
using VegunSoft.Message.Service.App;

namespace VegunSoft.Layer.UcService.Provider.Any
{
    public class Class_Global
    {
        #region BIẾN XỬ LÝ
        /// <summary>
        /// Biến MinDate để lưu null Datetime vào database
        /// </summary>
        public static DateTime _dtNull = DateTime.MinValue.AddDays(1);

        #endregion

        #region THÔNG BÁO
        public static string _tbXoaFormat = "Bạn có chắc chắn muốn xóa {0} này không?";
        public static string _tbXoa = "Bạn có chắc chắn muốn xóa thông tin này không?";
        public static string _tbXoaAll = "Bạn có chắc chắn muốn xóa hết {0} không?";
        public static string _tbCancel = "Bạn có chắc chắn muốn hủy thông tin này không?";
        public static string _tbThemMoiThanhCong = "Thêm mới dữ liệu thành công";
        public static string _tbThemMoiLoi = "Thêm mới dữ liệu không thành công";
        public static string _tbCapNhapThanhCong = "Cập nhật dữ liệu thành công";
        public static string _tbCapNhapLoi = "Cập nhật dữ liệu không thành công";
        public static string ERROR_DELETE_DATA = "Xóa dữ liệu thất bại";
        public static string ERROR_CANCEL_DATA = "Hủy dữ liệu thất bại";
        public static string _tbKiemTraLai = "Vui lòng kiểm tra lại";
        public static string _tbLienHeIT = "Vui lòng liên hệ IT để biết thêm thông tin";
        public static string _tbDuLieuKhongTonTai = "Dữ liệu không tồn tại hoặc đã bị xóa";
        public static string _tbUpgradeCustomerId = "Bạn có chắc chắn sửa toàn bộ Id của khách hàng này không?";
        public static string MsgTransfered = "Khách hàng này được được chuyển lên trước đó";
        /// <summary>
        /// Thông báo đối đối tượng không được rỗng
        /// </summary>
        /// <param name="DoiTuong">Tên đối tượng như: Họ tên, địa chỉ....</param>
        /// <returns>Trả về kiểu chuỗi</returns>
        public static string _TBRangBuocRong(string DoiTuong)
        {
            return string.Format("Vui lòng nhập {0}", DoiTuong);
        }

        /// <summary>
        /// Thông báo chọn đối tượng trên combobox
        /// </summary>
        /// <param name="DoiTuong">Tên đối tượng như: Loại địa bàn, địa bàn....</param>
        /// <returns>Trả về kiểu chuỗi</returns>
        public static string _TBRangBuocChon(string label)
        {
            return string.Format("Vui lòng chọn {0}", label.TrimEnd(':').Replace("(*)", "").ToLower().Trim());
        }

        /// <summary>
        /// Thông báo trùng ID
        /// </summary>
        /// <param name="DoiTuong">Tên đối tương như: Ma khoa phòng, mã phường xã</param>
        /// <returns>Trả về kiểu chuỗi</returns>
        public static string _TBTrungID(string DoiTuong)
        {
            return string.Format("{0} đã tồn tại. Vui lòng kiểm tra lại", DoiTuong);
        }

        /// <summary>
        /// Thông báo đối tượng không đúng định dạng yêu cầu
        /// </summary>
        /// <param name="DoiTuong">Tên đối tượng như: Họ tên, địa chỉ....</param>
        /// <returns>Trả về kiểu chuỗi</returns>
        public static string _TBKhongdungdinhdang(string DoiTuong)
        {
            return string.Format("Vui lòng nhập đúng định dạng {0}", DoiTuong);
        }

        //public static void msg_baoLoi(string error)
        //{
        //    DevExpress.XtraEditors.XtraMessageBox.Show(error, "Báo lỗi", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        //}

        //public static void msg_thongTin(string info)
        //{
        //    DevExpress.XtraEditors.XtraMessageBox.Show(info, "Thông báo", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        //}

        //public static void msg_canhBao(string warning)
        //{
        //    DevExpress.XtraEditors.XtraMessageBox.Show(warning, "Chú ý", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
        //}

        //public static DialogResult msg_HoiYesNo(string question)
        //{
            
        //    return XtraMessageBox.Show(question, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //}

        #endregion

        #region ĐƯỜNG DẪN TĨNH
        public static string path_DataDir = Application.StartupPath + @"\Data\";

        #endregion

        #region DS Các thủ tục
        public static string spQLTH_ABCDEF = "QLTH_ABCDEF";

       
        #endregion

        #region MỘT SỐ HÀM XỬ LÝ

        public static Form GetForm<T>(Form FrmCha, string name) where T:Form
        {
            if (FrmCha != null)
            {
                foreach (Form _frm in FrmCha.MdiChildren)
                {
                    if (_frm.Name == name)
                    {
                        return _frm;
                    }
                }
            }

            return Activator.CreateInstance<T>() as Form;
        }

        //public static void RemoveForms(Form instance)
        //{
        //    if (instance.MdiChildren != null) instance.MdiChildren = null;
        //}

        /// <summary>
        /// Hiển thị form con
        /// </summary>
        /// <param name="shell">Form cha là Form Main</param>
        /// <param name="FrmCon">Form con cần hiển thị</param>
        /// <param name="isShowDialog">Nếu là true thì form con sẽ được hiển thị dưới dạng dialog ngược lại thì cha con</param>

        public static Form _HienThiFormCon(Form shell, object subForm, bool isShowDialog, bool isShowLoading = true)
        {
            var mgmt = XForm.GetInstance<IFormMgmt>(shell);
            var type = isShowDialog ? (shell != null ? EFormDisplayType.Dialog : EFormDisplayType.Floating) : (EFormDisplayType.MdiSingle);
            return mgmt.ShowForm<Form>(subForm, type, isShowLoading);
        }


        /// <summary>
        /// Lấy identity hiện tại của bảng
        /// </summary>
        /// <param name="Connnect">Connection: Kết nối đến database</param>
        /// <param name="TableName">TableName: Tên bảng trong database</param>
        /// <returns>int: Giá trị identity hiện tại của bảng</returns>
        //public static int _GetIdentity(SqlConnection Connnect, string TableName)
        //{
        //    SqlCommand _command = new SqlCommand("PRO_GetIdentityTable", Connnect);
        //    _command.CommandType = System.Data.CommandType.StoredProcedure;
        //    _command.Parameters.Add(new SqlParameter("@table", System.Data.SqlDbType.NVarChar)).Value = TableName;
        //    if (Connnect.State == System.Data.ConnectionState.Closed)
        //    {
        //        Connnect.Open();
        //    }
        //    int _identity = Convert.ToInt32(_command.ExecuteScalar());
        //    Connnect.Close();
        //    return _identity;
        //}

        /// <summary>
        /// Cắt chuỗi Họ tên lấy tên
        /// Tham số vào : Họ tên đầy đủ
        /// </summary>
        /// <param name="Hoten"></param>
        /// <returns></returns>
        public string _LayTen(string Hoten)
        {
            if (Hoten != "")
            {
                string[] HT = Hoten.Split(new char[] { ' ' });
                return HT[HT.Length - 1].ToString();
            }
            else
                return "";
        }

        /// <summary>
        /// Ghép ngày tháng năm từ các chuỗi
        /// Tham số : string ngày, tháng, năm
        /// </summary>
        /// <param name="Ngay"></param>
        /// <param name="Thang"></param>
        /// <param name="Nam"></param>
        /// <returns></returns>
        public string _GhepNgayThangNam(string Ngay, string Thang, string Nam)
        {
            string ngaythangnam = "";
            if (Ngay.Trim() != "" && Thang.Trim() != "" && Nam.Trim() != "")
                ngaythangnam = Ngay + "/" + Thang + "/" + Nam;
            return ngaythangnam;
        }


        #endregion

        #region CÁC HÀM SQL

       
        /// <summary>
        /// Hàm trả về DataSet thông qua SQL tham số chuỗi sql và connect
        /// </summary>
        /// <param name="SQL"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        //public static DataSet _SQLTraveDataSet(string SQL, SqlConnection conn)
        //{
        //    SqlDataAdapter da = new SqlDataAdapter(SQL, conn);
        //    DataSet dt = new DataSet();
        //    da.Fill(dt);
        //    return dt;
        //}

       

        /// <summary>
        /// Hàm trả về DataTable thông qua tên của procedure, mảng tham số và connect
        /// </summary>
        /// <param name="sp_Name"></param>
        /// <param name="ArrayParameter"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        //public static DataTable _dataTable(string sp_Name, SqlParameter[] ArrayParameter, SqlConnection conn)
        //{
        //    if (conn.ConnectionString == "") return null;
        //    conn.Open();

        //    DataSet ds = new DataSet();
        //    //Command
        //    SqlCommand cmd = new SqlCommand(sp_Name, conn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddRange(ArrayParameter);

        //    SqlDataAdapter da = new SqlDataAdapter();
        //    DataTable dt = new DataTable("DataTable");
        //    da.SelectCommand = cmd;
        //    da.Fill(dt);
        //    return dt;

        //}

        /// <summary>
        /// Hàm trả về DataTable thông qua tên của view và connect
        /// </summary>
        /// <param name="view_Name"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        //public static DataTable _dataTableFromView(string view_Name, SqlConnection conn)
        //{
        //    if (conn.ConnectionString == "") return null;
        //    conn.Open();

        //    DataSet ds = new DataSet();
        //    //Command
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = conn;
        //    cmd.CommandText = "Select * from " + view_Name;
        //    cmd.CommandType = CommandType.Text;

        //    SqlDataAdapter da = new SqlDataAdapter();
        //    DataTable dt = new DataTable("DataTable");
        //    da.SelectCommand = cmd;
        //    da.Fill(dt);
        //    return dt;

        //}

        #endregion        

       

        #region Save RichEdit ra MS Word
        //Chỉnh font văn bản theo quy định
        public static void Chinhfont(RichEditControl richedit)
        {
            DevExpress.XtraRichEdit.API.Native.Document doc = richedit.Document;
            DocumentRange range = richedit.Document.Range;
            CharacterProperties cp = doc.BeginUpdateCharacters(range);
            cp.FontName = "Times New Roman";
            cp.FontSize = 12;
            //cp.ForeColor = Color.Black;
            //cp.BackColor = Color.Transparent;
            //cp.Underline = UnderlineType.DoubleWave;
            //cp.UnderlineColor = Color.White;
            doc.EndUpdateCharacters(cp);
            richedit.Refresh();
        }


        public static void SaveRichEditToWord(DevExpress.XtraRichEdit.RichEditControl richedit)
        {
            // Create a SaveFileDialog to request a path and file name to save to.
            SaveFileDialog saveFile1 = new SaveFileDialog();

            // Initialize the SaveFileDialog to specify the RTF extension for the file.
            saveFile1.DefaultExt = "*.doc";
            saveFile1.Filter = "Document Files|*.doc";

            // Determine if the user selected a file name from the saveFileDialog.
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                richedit.SaveDocument(saveFile1.FileName, DevExpress.XtraRichEdit.DocumentFormat.Doc);
                System.IO.FileInfo fi = new System.IO.FileInfo("Document.doc");
                XIoc.GetService(CGui.IocKey)?.GetInstance<IAppMessage>()?.ShowInfo("Save file thành công!");
            }
        }
        #endregion


        public static void DeleteDirectory(string path)
        {
            foreach (string directory in Directory.GetDirectories(path))
            {
                DeleteDirectory(directory);
            }

            try
            {
                Directory.Delete(path, true);
            }
            catch (IOException)
            {
                Directory.Delete(path, true);
            }
            catch (UnauthorizedAccessException)
            {
                Directory.Delete(path, true);
            }
        }
    }
}
