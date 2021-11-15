namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Customer
{
    partial class UcGridCustomers
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcGridCustomers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this._chbIsShowColors = new System.Windows.Forms.CheckBox();
            this._chbColorViaCustomerNote = new System.Windows.Forms.CheckBox();
            this._chbColorViaNeedsStatus = new System.Windows.Forms.CheckBox();
            this._chbColorViaCustomerStatus = new System.Windows.Forms.CheckBox();
            this._btnExportToExcel = new DevExpress.XtraEditors.SimpleButton();
            this._gridCustomers = new DevExpress.XtraGrid.GridControl();
            this._viewCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gcCustomerNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcCustomerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcCustomerFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcCustomerPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcCustomerBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcCustomerBirthYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcCustomerGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcCustomerEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcCustomerFaceBook = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcCustomerAdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcCustomerCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcCustomerCareer = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcCustomerDebt = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcCustomerBranchId = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcCustomerNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcCustomerIntroducer = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcCustomerSource = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcCustomerDoctorFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcTakeCareCustomerStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcTakeCareCustomerStatusNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcTakeCareCustomerServiceStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcTakeCareCustomerServiceNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcTakeCareHasNeeds = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcTakeCareHasNeedsNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lnkLichSu = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._viewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 400);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._gridCustomers, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 400);
            this.tableLayoutPanel1.TabIndex = 53;
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 4);
            this.panel2.Controls.Add(this._chbIsShowColors);
            this.panel2.Controls.Add(this._chbColorViaCustomerNote);
            this.panel2.Controls.Add(this._chbColorViaNeedsStatus);
            this.panel2.Controls.Add(this._chbColorViaCustomerStatus);
            this.panel2.Controls.Add(this._btnExportToExcel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 362);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1274, 35);
            this.panel2.TabIndex = 274;
            // 
            // _chbIsShowColors
            // 
            this._chbIsShowColors.AutoSize = true;
            this._chbIsShowColors.Checked = true;
            this._chbIsShowColors.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chbIsShowColors.Font = new System.Drawing.Font("Verdana", 9F);
            this._chbIsShowColors.Location = new System.Drawing.Point(8, 8);
            this._chbIsShowColors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._chbIsShowColors.Name = "_chbIsShowColors";
            this._chbIsShowColors.Size = new System.Drawing.Size(90, 18);
            this._chbIsShowColors.TabIndex = 278;
            this._chbIsShowColors.Text = "Màu theo:";
            this._chbIsShowColors.UseVisualStyleBackColor = true;
            this._chbIsShowColors.CheckedChanged += new System.EventHandler(this._chbIsShowColors_CheckedChanged);
            // 
            // _chbColorViaCustomerNote
            // 
            this._chbColorViaCustomerNote.AutoSize = true;
            this._chbColorViaCustomerNote.Enabled = false;
            this._chbColorViaCustomerNote.Font = new System.Drawing.Font("Verdana", 9F);
            this._chbColorViaCustomerNote.Location = new System.Drawing.Point(410, 8);
            this._chbColorViaCustomerNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._chbColorViaCustomerNote.Name = "_chbColorViaCustomerNote";
            this._chbColorViaCustomerNote.Size = new System.Drawing.Size(72, 18);
            this._chbColorViaCustomerNote.TabIndex = 276;
            this._chbColorViaCustomerNote.Text = "Ghi chú";
            this._chbColorViaCustomerNote.UseVisualStyleBackColor = true;
            this._chbColorViaCustomerNote.CheckedChanged += new System.EventHandler(this._chbColorViaCustomerNote_CheckedChanged);
            // 
            // _chbColorViaNeedsStatus
            // 
            this._chbColorViaNeedsStatus.AutoSize = true;
            this._chbColorViaNeedsStatus.Font = new System.Drawing.Font("Verdana", 9F);
            this._chbColorViaNeedsStatus.Location = new System.Drawing.Point(270, 8);
            this._chbColorViaNeedsStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._chbColorViaNeedsStatus.Name = "_chbColorViaNeedsStatus";
            this._chbColorViaNeedsStatus.Size = new System.Drawing.Size(119, 18);
            this._chbColorViaNeedsStatus.TabIndex = 275;
            this._chbColorViaNeedsStatus.Text = "Nhu cầu SP/DV";
            this._chbColorViaNeedsStatus.UseVisualStyleBackColor = true;
            this._chbColorViaNeedsStatus.CheckedChanged += new System.EventHandler(this._chbColorViaNeedsStatus_CheckedChanged);
            // 
            // _chbColorViaCustomerStatus
            // 
            this._chbColorViaCustomerStatus.AutoSize = true;
            this._chbColorViaCustomerStatus.Checked = true;
            this._chbColorViaCustomerStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chbColorViaCustomerStatus.Font = new System.Drawing.Font("Verdana", 9F);
            this._chbColorViaCustomerStatus.Location = new System.Drawing.Point(119, 8);
            this._chbColorViaCustomerStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._chbColorViaCustomerStatus.Name = "_chbColorViaCustomerStatus";
            this._chbColorViaCustomerStatus.Size = new System.Drawing.Size(130, 18);
            this._chbColorViaCustomerStatus.TabIndex = 273;
            this._chbColorViaCustomerStatus.Text = "Trạng thái khách";
            this._chbColorViaCustomerStatus.UseVisualStyleBackColor = true;
            this._chbColorViaCustomerStatus.CheckedChanged += new System.EventHandler(this._chbColorViaCustomerStatus_CheckedChanged);
            // 
            // _btnExportToExcel
            // 
            this._btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnExportToExcel.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnExportToExcel.Appearance.ForeColor = System.Drawing.Color.Black;
            this._btnExportToExcel.Appearance.Options.UseFont = true;
            this._btnExportToExcel.Appearance.Options.UseForeColor = true;
            this._btnExportToExcel.Image = ((System.Drawing.Image)(resources.GetObject("_btnExportToExcel.Image")));
            this._btnExportToExcel.Location = new System.Drawing.Point(1117, 4);
            this._btnExportToExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._btnExportToExcel.Name = "_btnExportToExcel";
            this._btnExportToExcel.Size = new System.Drawing.Size(153, 27);
            this._btnExportToExcel.TabIndex = 62;
            this._btnExportToExcel.Text = "Xuất Excel";
            this._btnExportToExcel.Click += new System.EventHandler(this._btnExportToExcel_Click);
            // 
            // _gridCustomers
            // 
            this._gridCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gridCustomers.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this._gridCustomers.Location = new System.Drawing.Point(0, 0);
            this._gridCustomers.MainView = this._viewCustomers;
            this._gridCustomers.Margin = new System.Windows.Forms.Padding(0);
            this._gridCustomers.Name = "_gridCustomers";
            this._gridCustomers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lnkLichSu});
            this._gridCustomers.Size = new System.Drawing.Size(1280, 359);
            this._gridCustomers.TabIndex = 52;
            this._gridCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._viewCustomers});
            // 
            // _viewCustomers
            // 
            this._viewCustomers.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this._viewCustomers.Appearance.HeaderPanel.Options.UseFont = true;
            this._viewCustomers.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this._viewCustomers.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._viewCustomers.Appearance.Row.Font = new System.Drawing.Font("Verdana", 9F);
            this._viewCustomers.Appearance.Row.Options.UseFont = true;
            this._viewCustomers.ColumnPanelRowHeight = 30;
            this._viewCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._gcCustomerNo,
            this._gcCustomerCode,
            this._gcCustomerFullName,
            this._gcCustomerPhoneNumber,
            this._gcCustomerBirthDate,
            this._gcCustomerBirthYear,
            this._gcCustomerGender,
            this._gcCustomerEmail,
            this._gcCustomerFaceBook,
            this._gcCustomerAdress,
            this._gcCustomerCreatedDate,
            this._gcCustomerCareer,
            this._gcCustomerDebt,
            this._gcCustomerBranchId,
            this._gcCustomerNote,
            this._gcCustomerIntroducer,
            this._gcCustomerSource,
            this._gcCustomerDoctorFullName,
            this._gcTakeCareCustomerStatus,
            this._gcTakeCareCustomerStatusNote,
            this._gcTakeCareCustomerServiceStatus,
            this._gcTakeCareCustomerServiceNote,
            this._gcTakeCareHasNeeds,
            this._gcTakeCareHasNeedsNote});
            this._viewCustomers.GridControl = this._gridCustomers;
            this._viewCustomers.IndicatorWidth = 30;
            this._viewCustomers.Name = "_viewCustomers";
            this._viewCustomers.OptionsBehavior.AutoExpandAllGroups = true;
            this._viewCustomers.OptionsView.AllowCellMerge = true;
            this._viewCustomers.OptionsView.ColumnAutoWidth = false;
            this._viewCustomers.OptionsView.ShowAutoFilterRow = true;
            this._viewCustomers.OptionsView.ShowFooter = true;
            this._viewCustomers.OptionsView.ShowGroupPanel = false;
            this._viewCustomers.ViewCaptionHeight = 30;
            // 
            // _gcCustomerNo
            // 
            this._gcCustomerNo.Caption = "STT";
            this._gcCustomerNo.Name = "_gcCustomerNo";
            // 
            // _gcCustomerCode
            // 
            this._gcCustomerCode.Caption = "Mã KH";
            this._gcCustomerCode.FieldName = "ID";
            this._gcCustomerCode.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this._gcCustomerCode.Name = "_gcCustomerCode";
            this._gcCustomerCode.OptionsColumn.AllowEdit = false;
            this._gcCustomerCode.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this._gcCustomerCode.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID", "{0:n0}")});
            this._gcCustomerCode.Visible = true;
            this._gcCustomerCode.VisibleIndex = 0;
            this._gcCustomerCode.Width = 145;
            // 
            // _gcCustomerFullName
            // 
            this._gcCustomerFullName.Caption = "Họ tên";
            this._gcCustomerFullName.FieldName = "HOTEN";
            this._gcCustomerFullName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this._gcCustomerFullName.Name = "_gcCustomerFullName";
            this._gcCustomerFullName.OptionsColumn.AllowEdit = false;
            this._gcCustomerFullName.Visible = true;
            this._gcCustomerFullName.VisibleIndex = 1;
            this._gcCustomerFullName.Width = 195;
            // 
            // _gcCustomerPhoneNumber
            // 
            this._gcCustomerPhoneNumber.Caption = "Điện thoại";
            this._gcCustomerPhoneNumber.FieldName = "DIENTHOAI";
            this._gcCustomerPhoneNumber.Name = "_gcCustomerPhoneNumber";
            this._gcCustomerPhoneNumber.OptionsColumn.AllowEdit = false;
            this._gcCustomerPhoneNumber.Visible = true;
            this._gcCustomerPhoneNumber.VisibleIndex = 5;
            this._gcCustomerPhoneNumber.Width = 112;
            // 
            // _gcCustomerBirthDate
            // 
            this._gcCustomerBirthDate.Caption = "Ngày sinh";
            this._gcCustomerBirthDate.FieldName = "NGAYTHANGNS";
            this._gcCustomerBirthDate.Name = "_gcCustomerBirthDate";
            this._gcCustomerBirthDate.OptionsColumn.AllowEdit = false;
            this._gcCustomerBirthDate.Visible = true;
            this._gcCustomerBirthDate.VisibleIndex = 3;
            this._gcCustomerBirthDate.Width = 100;
            // 
            // _gcCustomerBirthYear
            // 
            this._gcCustomerBirthYear.Caption = "Năm sinh";
            this._gcCustomerBirthYear.FieldName = "NAMSINH";
            this._gcCustomerBirthYear.Name = "_gcCustomerBirthYear";
            this._gcCustomerBirthYear.OptionsColumn.AllowEdit = false;
            this._gcCustomerBirthYear.Visible = true;
            this._gcCustomerBirthYear.VisibleIndex = 4;
            // 
            // _gcCustomerGender
            // 
            this._gcCustomerGender.Caption = "Giới tính";
            this._gcCustomerGender.FieldName = "GIOITINH";
            this._gcCustomerGender.Name = "_gcCustomerGender";
            this._gcCustomerGender.OptionsColumn.AllowEdit = false;
            this._gcCustomerGender.Visible = true;
            this._gcCustomerGender.VisibleIndex = 2;
            this._gcCustomerGender.Width = 66;
            // 
            // _gcCustomerEmail
            // 
            this._gcCustomerEmail.Caption = "Email";
            this._gcCustomerEmail.FieldName = "EMAIL";
            this._gcCustomerEmail.Name = "_gcCustomerEmail";
            this._gcCustomerEmail.OptionsColumn.AllowEdit = false;
            this._gcCustomerEmail.Visible = true;
            this._gcCustomerEmail.VisibleIndex = 6;
            this._gcCustomerEmail.Width = 137;
            // 
            // _gcCustomerFaceBook
            // 
            this._gcCustomerFaceBook.Caption = "Facebook";
            this._gcCustomerFaceBook.FieldName = "FACEBOOK";
            this._gcCustomerFaceBook.Name = "_gcCustomerFaceBook";
            this._gcCustomerFaceBook.OptionsColumn.AllowEdit = false;
            this._gcCustomerFaceBook.Visible = true;
            this._gcCustomerFaceBook.VisibleIndex = 7;
            this._gcCustomerFaceBook.Width = 168;
            // 
            // _gcCustomerAdress
            // 
            this._gcCustomerAdress.Caption = "Địa chỉ";
            this._gcCustomerAdress.FieldName = "DIACHI";
            this._gcCustomerAdress.Name = "_gcCustomerAdress";
            this._gcCustomerAdress.OptionsColumn.AllowEdit = false;
            this._gcCustomerAdress.Visible = true;
            this._gcCustomerAdress.VisibleIndex = 9;
            this._gcCustomerAdress.Width = 321;
            // 
            // _gcCustomerCreatedDate
            // 
            this._gcCustomerCreatedDate.Caption = "Ngày tạo";
            this._gcCustomerCreatedDate.FieldName = "NGAYTAOHS";
            this._gcCustomerCreatedDate.Name = "_gcCustomerCreatedDate";
            this._gcCustomerCreatedDate.OptionsColumn.AllowEdit = false;
            this._gcCustomerCreatedDate.Visible = true;
            this._gcCustomerCreatedDate.VisibleIndex = 10;
            this._gcCustomerCreatedDate.Width = 95;
            // 
            // _gcCustomerCareer
            // 
            this._gcCustomerCareer.Caption = "Nghề nghiệp";
            this._gcCustomerCareer.FieldName = "NGHENGHIEP";
            this._gcCustomerCareer.Name = "_gcCustomerCareer";
            this._gcCustomerCareer.OptionsColumn.AllowEdit = false;
            this._gcCustomerCareer.Visible = true;
            this._gcCustomerCareer.VisibleIndex = 8;
            this._gcCustomerCareer.Width = 111;
            // 
            // _gcCustomerDebt
            // 
            this._gcCustomerDebt.Caption = "Công nợ";
            this._gcCustomerDebt.DisplayFormat.FormatString = "n0";
            this._gcCustomerDebt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._gcCustomerDebt.FieldName = "CONGNO";
            this._gcCustomerDebt.Name = "_gcCustomerDebt";
            this._gcCustomerDebt.OptionsColumn.AllowEdit = false;
            this._gcCustomerDebt.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CONGNO", "{0:n0}")});
            this._gcCustomerDebt.Visible = true;
            this._gcCustomerDebt.VisibleIndex = 11;
            this._gcCustomerDebt.Width = 129;
            // 
            // _gcCustomerBranchId
            // 
            this._gcCustomerBranchId.Caption = "Cơ sở";
            this._gcCustomerBranchId.FieldName = "ID_DMCOSO";
            this._gcCustomerBranchId.Name = "_gcCustomerBranchId";
            this._gcCustomerBranchId.OptionsColumn.AllowEdit = false;
            this._gcCustomerBranchId.Visible = true;
            this._gcCustomerBranchId.VisibleIndex = 16;
            // 
            // _gcCustomerNote
            // 
            this._gcCustomerNote.Caption = "Ghi chú";
            this._gcCustomerNote.FieldName = "GHICHU";
            this._gcCustomerNote.Name = "_gcCustomerNote";
            this._gcCustomerNote.OptionsColumn.AllowEdit = false;
            this._gcCustomerNote.Visible = true;
            this._gcCustomerNote.VisibleIndex = 14;
            this._gcCustomerNote.Width = 186;
            // 
            // _gcCustomerIntroducer
            // 
            this._gcCustomerIntroducer.Caption = "Người giới thiệu";
            this._gcCustomerIntroducer.FieldName = "NGUOIGIOITHIEU";
            this._gcCustomerIntroducer.Name = "_gcCustomerIntroducer";
            this._gcCustomerIntroducer.OptionsColumn.AllowEdit = false;
            this._gcCustomerIntroducer.Visible = true;
            this._gcCustomerIntroducer.VisibleIndex = 13;
            this._gcCustomerIntroducer.Width = 148;
            // 
            // _gcCustomerSource
            // 
            this._gcCustomerSource.Caption = "Nguồn khách hàng";
            this._gcCustomerSource.FieldName = "NGUONKHACHHANG";
            this._gcCustomerSource.Name = "_gcCustomerSource";
            this._gcCustomerSource.OptionsColumn.AllowEdit = false;
            this._gcCustomerSource.Visible = true;
            this._gcCustomerSource.VisibleIndex = 12;
            this._gcCustomerSource.Width = 130;
            // 
            // _gcCustomerDoctorFullName
            // 
            this._gcCustomerDoctorFullName.Caption = "Bác sĩ điều trị";
            this._gcCustomerDoctorFullName.FieldName = "HOTEN_TAIKHOAN_BSDT";
            this._gcCustomerDoctorFullName.Name = "_gcCustomerDoctorFullName";
            this._gcCustomerDoctorFullName.OptionsColumn.AllowEdit = false;
            this._gcCustomerDoctorFullName.Visible = true;
            this._gcCustomerDoctorFullName.VisibleIndex = 15;
            this._gcCustomerDoctorFullName.Width = 169;
            // 
            // _gcTakeCareCustomerStatus
            // 
            this._gcTakeCareCustomerStatus.Caption = "Trạng thái khách";
            this._gcTakeCareCustomerStatus.MinWidth = 120;
            this._gcTakeCareCustomerStatus.Name = "_gcTakeCareCustomerStatus";
            this._gcTakeCareCustomerStatus.ToolTip = "Trạng thái khách";
            this._gcTakeCareCustomerStatus.Visible = true;
            this._gcTakeCareCustomerStatus.VisibleIndex = 17;
            this._gcTakeCareCustomerStatus.Width = 120;
            // 
            // _gcTakeCareCustomerStatusNote
            // 
            this._gcTakeCareCustomerStatusNote.Caption = "Ghi chú";
            this._gcTakeCareCustomerStatusNote.MinWidth = 120;
            this._gcTakeCareCustomerStatusNote.Name = "_gcTakeCareCustomerStatusNote";
            this._gcTakeCareCustomerStatusNote.Visible = true;
            this._gcTakeCareCustomerStatusNote.VisibleIndex = 18;
            this._gcTakeCareCustomerStatusNote.Width = 120;
            // 
            // _gcTakeCareCustomerServiceStatus
            // 
            this._gcTakeCareCustomerServiceStatus.Caption = "Trạng thái SP/DV điều trị";
            this._gcTakeCareCustomerServiceStatus.MinWidth = 120;
            this._gcTakeCareCustomerServiceStatus.Name = "_gcTakeCareCustomerServiceStatus";
            this._gcTakeCareCustomerServiceStatus.ToolTip = "Trạng thái SP/DV điều trị";
            this._gcTakeCareCustomerServiceStatus.Visible = true;
            this._gcTakeCareCustomerServiceStatus.VisibleIndex = 19;
            this._gcTakeCareCustomerServiceStatus.Width = 120;
            // 
            // _gcTakeCareCustomerServiceNote
            // 
            this._gcTakeCareCustomerServiceNote.Caption = "Ghi chú";
            this._gcTakeCareCustomerServiceNote.MinWidth = 120;
            this._gcTakeCareCustomerServiceNote.Name = "_gcTakeCareCustomerServiceNote";
            this._gcTakeCareCustomerServiceNote.ToolTip = "Ghi chú trạng thái SP/DV điều trị";
            this._gcTakeCareCustomerServiceNote.Visible = true;
            this._gcTakeCareCustomerServiceNote.VisibleIndex = 20;
            this._gcTakeCareCustomerServiceNote.Width = 120;
            // 
            // _gcTakeCareHasNeeds
            // 
            this._gcTakeCareHasNeeds.Caption = "Có nhu cầu";
            this._gcTakeCareHasNeeds.MinWidth = 60;
            this._gcTakeCareHasNeeds.Name = "_gcTakeCareHasNeeds";
            this._gcTakeCareHasNeeds.ToolTip = "Có nhu cầu điều trị / sử dụng SP/DV";
            this._gcTakeCareHasNeeds.Visible = true;
            this._gcTakeCareHasNeeds.VisibleIndex = 21;
            this._gcTakeCareHasNeeds.Width = 60;
            // 
            // _gcTakeCareHasNeedsNote
            // 
            this._gcTakeCareHasNeedsNote.Caption = "Ghi chú";
            this._gcTakeCareHasNeedsNote.MinWidth = 120;
            this._gcTakeCareHasNeedsNote.Name = "_gcTakeCareHasNeedsNote";
            this._gcTakeCareHasNeedsNote.ToolTip = "Ghi chú nhu cầu điều trị";
            this._gcTakeCareHasNeedsNote.Visible = true;
            this._gcTakeCareHasNeedsNote.VisibleIndex = 22;
            this._gcTakeCareHasNeedsNote.Width = 120;
            // 
            // lnkLichSu
            // 
            this.lnkLichSu.AutoHeight = false;
            this.lnkLichSu.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lnkLichSu.Name = "lnkLichSu";
            // 
            // UcGridCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcGridCustomers";
            this.Size = new System.Drawing.Size(1280, 400);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._viewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkLichSu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl _gridCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView _viewCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerNo;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerCode;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerFullName;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerBirthYear;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerGender;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerEmail;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerFaceBook;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerAdress;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerCareer;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerDebt;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerBranchId;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerNote;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerIntroducer;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerSource;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerDoctorFullName;
        private DevExpress.XtraGrid.Columns.GridColumn _gcTakeCareCustomerStatus;
        private DevExpress.XtraGrid.Columns.GridColumn _gcTakeCareCustomerStatusNote;
        private DevExpress.XtraGrid.Columns.GridColumn _gcTakeCareCustomerServiceStatus;
        private DevExpress.XtraGrid.Columns.GridColumn _gcTakeCareCustomerServiceNote;
        private DevExpress.XtraGrid.Columns.GridColumn _gcTakeCareHasNeeds;
        private DevExpress.XtraGrid.Columns.GridColumn _gcTakeCareHasNeedsNote;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit lnkLichSu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox _chbIsShowColors;
        private System.Windows.Forms.CheckBox _chbColorViaCustomerNote;
        private System.Windows.Forms.CheckBox _chbColorViaNeedsStatus;
        private System.Windows.Forms.CheckBox _chbColorViaCustomerStatus;
        private DevExpress.XtraEditors.SimpleButton _btnExportToExcel;
    }
}
