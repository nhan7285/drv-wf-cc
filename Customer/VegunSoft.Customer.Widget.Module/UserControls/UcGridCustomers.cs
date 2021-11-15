using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Spreadsheet;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSpreadsheet;
using VegunSoft.App.Data.Business.View;
using VegunSoft.App.Entity.Provider.Business.Gui;
using VegunSoft.App.Repository.Business.Gui;
using VegunSoft.Base.View.Dev.UserControls;
using VegunSoft.Customer.Entity.Provider.Categories;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Customer.Repository.Business;
using VegunSoft.Customer.Repository.Categories.Status;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Methods;
using VegunSoft.Framework.Methods;
using VegunSoft.Layer.UcService.Provider.Methods;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Customer
{
    public partial class UcGridCustomers : UcBase
    {
        private List<MEntityGridCustomer> _customers = new List<MEntityGridCustomer>();
        private string _formName;
        public bool IsLoaded { get; set; }
   
        private IRepositoryDataRowFormat _repositoryDataRowFormat;
        private IRepositoryCustomerStatusGlobal _repositoryCustomerStatusGlobal;
        private IRepositoryCustomer _repositoryCustomer;
        private SpreadsheetControl _spreadsheetControl;
        public MEntityCustomer SelectedRow => (_viewCustomers.GetFocusedRow() as MEntityCustomer) ?? _viewCustomers.GetRow(_viewCustomers.FocusedRowHandle) as MEntityCustomer;

        public UcGridCustomers()
        {
            InitializeComponent();
        }

        public void Init(string formName)
        {
            if (!IsLoaded)
            {
                _formName = formName;
                InitFields();
                ApplyColumns();
                LoadDataSources();
                ApplyEvents();
                SetContextMenus();
                IsLoaded = true;
            }
        }

        public void LoadData(List<string> customerIds)
        {
            var customers = _repositoryCustomer.GetCustomers(customerIds).ToList();
            LoadData(customers);
        }
        public void LoadGridData(List<string> customerIds)
        {
            _customers = _repositoryCustomer.GetGridCustomers(SessionCode, customerIds).ToList();
            LoadGridData(_customers);
        }
        public void FilterGridData(List<string> customerIds)
        {
            //var customers = GetFilteredData<MGridCustomer>(_gridCustomers.MainView as ColumnView).ToList();
            
            _gridCustomers.DataSource = _customers.Where(x=> customerIds.Contains(x.Id)).OrderBy(x => x.BranchId).ThenBy(x => x.CreatedDate).ToList();
            _viewCustomers.RefreshData();
            
        }
        public static List<T> GetFilteredData<T>(ColumnView view)
        {
            List<T> resp = new List<T>();
            for (int i = 0; i < view.DataRowCount; i++)
                resp.Add((T)view.GetRow(i));

            return resp;
        }

        public void LoadData(List<MEntityCustomer> customers)
        {
            _gridCustomers.DataSource = customers.OrderBy(x => x.BranchId).ThenBy(x => x.CreatedDate).ToList();
            _viewCustomers.RefreshData();
        }
        public void LoadGridData(List<MEntityGridCustomer> customers)
        {
            _gridCustomers.DataSource = customers.OrderBy(x => x.BranchId).ThenBy(x => x.CreatedDate).ToList();
            _viewCustomers.RefreshData();
        }
        private void InitFields()
        {
            
            _repositoryCustomer = DbIoc.GetInstance<IRepositoryCustomer>();
            _repositoryDataRowFormat = DbIoc.GetInstance<IRepositoryDataRowFormat>();
            _repositoryCustomerStatusGlobal = DbIoc.GetInstance<IRepositoryCustomerStatusGlobal>();
            _hasNeedProductServiceStatus = _repositoryDataRowFormat.Find(nameof(MEntityDataRowFormat.Code),
                EDataRowFormat.CustomerHasPotentialProductServices.GetCode());
            _noNeedProductServiceStatus = _repositoryDataRowFormat.Find(nameof(MEntityDataRowFormat.Code),
                EDataRowFormat.CustomerNoPotentialProductServices.GetCode());
            _helpGlobalStatusForm = InitHelpGlobalForm();
        }

        private void ApplyColumns()
        {
            _gcCustomerNo.FieldName = nameof(MEntityCustomer.No);
            _gcCustomerCode.FieldName = nameof(MEntityCustomer.Code);
            _gcCustomerFullName.FieldName = nameof(MEntityCustomer.FullName);
            _gcCustomerPhoneNumber.FieldName = nameof(MEntityCustomer.PhoneNumber);
            _gcCustomerBirthDate.FieldName = nameof(MEntityCustomer.BirthDate);
            _gcCustomerBirthYear.FieldName = nameof(MEntityCustomer.BirthYear);
            _gcCustomerGender.FieldName = nameof(MEntityCustomer.Gender);
            _gcCustomerEmail.FieldName = nameof(MEntityCustomer.Email);
            _gcCustomerFaceBook.FieldName = nameof(MEntityCustomer.Facebook);
            _gcCustomerAdress.FieldName = nameof(MEntityCustomer.FullAddress);
            _gcCustomerCreatedDate.FieldName = nameof(MEntityCustomer.CreatedDate);
            _gcCustomerCareer.FieldName = nameof(MEntityCustomer.Career);
            _gcCustomerDebt.FieldName = nameof(MEntityCustomer.CustomerDebit);
            _gcCustomerBranchId.FieldName = nameof(MEntityCustomer.BranchId);
            _gcCustomerNote.FieldName = nameof(MEntityCustomer.Note);
            _gcCustomerIntroducer.FieldName = nameof(MEntityCustomer.Introducer);
            _gcCustomerSource.FieldName = nameof(MEntityCustomer.CustomerSource);
            _gcCustomerDoctorFullName.FieldName = nameof(MEntityCustomer.DoctorFullName);
            _gcTakeCareCustomerStatus.FieldName = nameof(MEntityCustomer.CustomerStatusName);
            _gcTakeCareCustomerStatusNote.FieldName = nameof(MEntityCustomer.CustomerStatusNote);
            _gcTakeCareCustomerServiceStatus.FieldName = nameof(MEntityCustomer.ItemStatusName);
            _gcTakeCareCustomerServiceNote.FieldName = nameof(MEntityCustomer.ItemStatusNote);
            _gcTakeCareHasNeeds.FieldName = nameof(MEntityCustomer.HasNeed);
            _gcTakeCareHasNeedsNote.FieldName = nameof(MEntityCustomer.NeedNote);
        }
        private void ApplySelectCustomerColumns()
        {
            _gcCustomerNo.FieldName = nameof(MEntityCustomer.No);
            _gcCustomerCode.FieldName = nameof(MEntityCustomer.Code);
            _gcCustomerFullName.FieldName = nameof(MEntityCustomer.FullName);
            _gcCustomerPhoneNumber.FieldName = nameof(MEntityCustomer.PhoneNumber);
            _gcCustomerBirthDate.FieldName = nameof(MEntityCustomer.BirthDate);
            _gcCustomerBirthYear.FieldName = nameof(MEntityCustomer.BirthYear);
            _gcCustomerGender.FieldName = nameof(MEntityCustomer.Gender);
            _gcCustomerEmail.FieldName = nameof(MEntityCustomer.Email);
            _gcCustomerFaceBook.FieldName = nameof(MEntityCustomer.Facebook);
            _gcCustomerAdress.FieldName = nameof(MEntityCustomer.FullAddress);
            _gcCustomerCreatedDate.FieldName = nameof(MEntityCustomer.CreatedDate);
            _gcCustomerCareer.FieldName = nameof(MEntityCustomer.Career);
            _gcCustomerDebt.FieldName = nameof(MEntityCustomer.CustomerDebit);
            _gcCustomerBranchId.FieldName = nameof(MEntityCustomer.BranchId);
            _gcCustomerNote.FieldName = nameof(MEntityCustomer.Note);
            _gcCustomerIntroducer.FieldName = nameof(MEntityCustomer.Introducer);
            _gcCustomerSource.FieldName = nameof(MEntityCustomer.CustomerSource);
            _gcCustomerDoctorFullName.FieldName = nameof(MEntityCustomer.DoctorFullName);
            _gcTakeCareCustomerStatus.FieldName = nameof(MEntityCustomer.CustomerStatusName);
            _gcTakeCareCustomerStatusNote.FieldName = nameof(MEntityCustomer.CustomerStatusNote);
            _gcTakeCareCustomerServiceStatus.FieldName = nameof(MEntityCustomer.ItemStatusName);
            _gcTakeCareCustomerServiceNote.FieldName = nameof(MEntityCustomer.ItemStatusNote);
            _gcTakeCareHasNeeds.FieldName = nameof(MEntityCustomer.HasNeed);
            _gcTakeCareHasNeedsNote.FieldName = nameof(MEntityCustomer.NeedNote);
        }
        private void ApplyEvents()
        {
            _viewCustomers.RowClick += ViewCustomersOnRowClick;
            _viewCustomers.RowCellStyle += GridViewOnRowCellStyle;
        }

        private bool IsInSelectedRows(int idx)
        {
            var indexes = _viewCustomers.GetSelectedRows();
            if (indexes == null || indexes.Length == 0) return false;
            return indexes.Any(x => x == idx);
        }

        private void GridViewOnRowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            //return;
            if (e.RowHandle < 0) return;
            if (_allCustomerStatus == null) _allCustomerStatus = new List<MEntityCustomerStatusGlobal>();
            if (IsInSelectedRows(e.RowHandle) && e.Column == _viewCustomers.FocusedColumn) return;
            if (_viewCustomers.GetRow(e.RowHandle) is MEntityCustomer item)
            {

                if (_chbColorViaCustomerStatus.Checked)
                {
                    var statusId = item.CustomerStatusId;
                    if (!string.IsNullOrWhiteSpace(statusId))
                    {
                        var model = _allCustomerStatus.FirstOrDefault(x => x.Id?.ToLower() == statusId?.ToLower());
                        if (model != null)
                        {
                            e.Appearance.ApplyStyle(model);
                            // return;
                        }
                    }
                }

                if (_chbColorViaNeedsStatus.Checked)
                {
                    if (item.HasNeed && _hasNeedProductServiceStatus != null)
                    {
                        e.Appearance.ApplyStyle(_hasNeedProductServiceStatus);
                    }
                    else if (!item.HasNeed && _noNeedProductServiceStatus != null)
                    {
                        e.Appearance.ApplyStyle(_noNeedProductServiceStatus);
                    }
                }

            }
        }

        private void ViewCustomersOnRowClick(object sender, RowClickEventArgs e)
        {
            if (e.HitInfo != null && e.HitInfo.InRowCell)
            {
                if (e.Button == MouseButtons.Left) ShowContextMenu();
            }
        }

        private void LoadDataSources()
        {
            _allCustomerStatus = _repositoryCustomerStatusGlobal.All().ToList();
            _listActiveCustomerStatusGlobal = _allCustomerStatus.Where(x => x.IsActive && !x.IsDeleted).ToList();
        }

        private void _btnExportToExcel_Click(object sender, System.EventArgs e)
        {
            if (CheckRightsService.CheckCanExport(SessionCode, _formName, true))
            {
                var msg = "Danh sách khách hàng ";//_message
                string file = _viewCustomers.ToExcelSilent(msg);
                if (!string.IsNullOrWhiteSpace(file))
                {
                    var rs = CreateAndExportExcel(file);
                    if (rs)
                    {
                        if (XtraMessageBox.Show("Đã xuất ra Excel thành công, Bạn có muốn mở nó ngay?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            System.Diagnostics.Process.Start(file);
                    }
                }
                //_viewReportReceipts.ToExcelOpen("Báo cáo phiếu thu " + _message);
            }
        }

        private void CheckAndAddSpreadsheetControl()
        {
            if (_spreadsheetControl != null) return;
            _spreadsheetControl = new SpreadsheetControl();
            // 
            // spreadsheetControl1
            // 
            this._spreadsheetControl.Location = new System.Drawing.Point(209, 316);
            this._spreadsheetControl.Name = "_spreadsheetControl";
            this._spreadsheetControl.Size = new System.Drawing.Size(358, 113);
            this._spreadsheetControl.TabIndex = 12;
            this._spreadsheetControl.Text = "_spreadsheetControl";
            this._spreadsheetControl.Visible = false;
            this.Controls.Add(_spreadsheetControl);
        }

        private bool CreateAndExportExcel(string sourceFile)
        {
            try
            {
                CheckAndAddSpreadsheetControl();
                using (FileStream fs =
                    new FileStream(sourceFile,
                        FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    string extension = Path.GetExtension(sourceFile).ToString();
                    if (extension == ".xls")
                        _spreadsheetControl.LoadDocument(fs, DocumentFormat.Xls);
                    if (Path.GetExtension(sourceFile) == ".xlsx")
                        _spreadsheetControl.LoadDocument(fs, DocumentFormat.Xlsx);

                    fs.Close();
                }
                _spreadsheetControl.Document.Styles[BuiltInStyleId.Normal].Font.Name = "Times New Roman";
                DevExpress.Spreadsheet.Worksheet worksheet = _spreadsheetControl.ActiveWorksheet;
                var range = worksheet.GetUsedRange();
                range.Font.Name = "Times New Roman";
                range.Font.Size = 12;
                using (FileStream stream = new FileStream(sourceFile, FileMode.Create, FileAccess.ReadWrite))
                {
                    _spreadsheetControl.SaveDocument(stream, DocumentFormat.OpenXml);
                    stream.Close();
                }
                return true;
            }
            catch (Exception e)
            {
                return XtraMessageBox.Show("Lỗi, bạn có muốn tìm đóng các file đang mở và thử lại?", "Thông báo",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes && CreateAndExportExcel(sourceFile);
            }

        }

        private void _chbColorViaCustomerStatus_CheckedChanged(object sender, EventArgs e)
        {
            _viewCustomers.RefreshData();
        }

        private void _chbColorViaNeedsStatus_CheckedChanged(object sender, EventArgs e)
        {
            _viewCustomers.RefreshData();
        }

        private void _chbColorViaCustomerNote_CheckedChanged(object sender, EventArgs e)
        {
            _viewCustomers.RefreshData();
        }

        private void _chbIsShowColors_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = _chbIsShowColors.Checked;
            _chbColorViaCustomerStatus.Checked = isChecked;
            _chbColorViaNeedsStatus.Checked = isChecked;
            _chbColorViaCustomerNote.Checked = isChecked;
        }
    }
}
