#region Main
//  Filename    :  ViewImage.cs
//  Purpose		:  Xem hình ảnh 
//  Create date :  29/06/2017
//  Author		:  Nguyễn Thị Vân An
//  Version		:  v1.0
//  Copyright	:  vegunsoft.vn
#endregion

#region Edit
//  Edit  		:  <Người chỉnh sửa>
//  Edit date	:  <Ngày chỉnh sửa>
//  Content		:  <Nội dung chỉnh sửa>
#endregion

namespace VegunSoft.Any.View.Dev.Forms
{
    public partial class frmViewImage : DevExpress.XtraEditors.XtraForm
    {
        public frmViewImage()
        {
            InitializeComponent();
        }

        public frmViewImage(byte[] img, string ghichu)
            : this()
        {
            this.Text = ghichu;
            pictureEdit1.EditValue = img;
        }
    }
}