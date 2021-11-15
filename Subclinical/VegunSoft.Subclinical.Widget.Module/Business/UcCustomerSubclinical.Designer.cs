namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    partial class UcCustomerSubclinical
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridDanhSachCLS = new DevExpress.XtraGrid.GridControl();
            this.viewDanhSachCLS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gcSubclinicalId = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcSubclinicalCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.r_dtNgayChiDinh = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this._gcSubclinicalSpecifierFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcSubclinicalPerformerFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcSubclinicalDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.r_mmeText = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this._gcSubclinicalCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcSubclinicalResultName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcSubclinicalResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.r_rtfText = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this._gcSubclinicalConclusion = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcSubclinicalSuggestion = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcSubclinicalNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcSubclinicalPrint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lnkXemInCLS = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this._gcSubclinicalImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lnkHinhAnhCLS = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this._gcSubclinicalTakePhotoDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView19 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
            this.pteImage = new DevExpress.XtraEditors.PictureEdit();
            this.panel8 = new System.Windows.Forms.Panel();
            this._imgNote = new DevExpress.XtraEditors.MemoEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachCLS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDanhSachCLS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_dtNgayChiDinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_dtNgayChiDinh.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_mmeText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_rtfText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkXemInCLS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkHinhAnhCLS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView19)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pteImage.Properties)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._imgNote.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridDanhSachCLS, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gridDanhSachCLS
            // 
            this.gridDanhSachCLS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDanhSachCLS.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gridLevelNode1.RelationName = "Level1";
            this.gridDanhSachCLS.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridDanhSachCLS.Location = new System.Drawing.Point(0, 400);
            this.gridDanhSachCLS.MainView = this.viewDanhSachCLS;
            this.gridDanhSachCLS.Margin = new System.Windows.Forms.Padding(0);
            this.gridDanhSachCLS.Name = "gridDanhSachCLS";
            this.gridDanhSachCLS.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.r_dtNgayChiDinh,
            this.r_rtfText,
            this.r_mmeText,
            this.lnkXemInCLS,
            this.lnkHinhAnhCLS});
            this.gridDanhSachCLS.Size = new System.Drawing.Size(1024, 200);
            this.gridDanhSachCLS.TabIndex = 20;
            this.gridDanhSachCLS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewDanhSachCLS,
            this.gridView19});
            // 
            // viewDanhSachCLS
            // 
            this.viewDanhSachCLS.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            this.viewDanhSachCLS.Appearance.FocusedRow.Options.UseBackColor = true;
            this.viewDanhSachCLS.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.viewDanhSachCLS.Appearance.HeaderPanel.Options.UseFont = true;
            this.viewDanhSachCLS.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.viewDanhSachCLS.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.viewDanhSachCLS.Appearance.Row.Font = new System.Drawing.Font("Verdana", 9F);
            this.viewDanhSachCLS.Appearance.Row.Options.UseFont = true;
            this.viewDanhSachCLS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._gcSubclinicalId,
            this._gcSubclinicalCreatedDate,
            this._gcSubclinicalSpecifierFullName,
            this._gcSubclinicalPerformerFullName,
            this._gcSubclinicalDescription,
            this._gcSubclinicalCategoryName,
            this._gcSubclinicalResultName,
            this._gcSubclinicalResult,
            this._gcSubclinicalConclusion,
            this._gcSubclinicalSuggestion,
            this._gcSubclinicalNote,
            this._gcSubclinicalPrint,
            this._gcSubclinicalImage,
            this._gcSubclinicalTakePhotoDate});
            this.viewDanhSachCLS.GridControl = this.gridDanhSachCLS;
            this.viewDanhSachCLS.Name = "viewDanhSachCLS";
            this.viewDanhSachCLS.OptionsBehavior.ReadOnly = true;
            this.viewDanhSachCLS.OptionsView.ColumnAutoWidth = false;
            this.viewDanhSachCLS.OptionsView.RowAutoHeight = true;
            this.viewDanhSachCLS.OptionsView.ShowDetailButtons = false;
            this.viewDanhSachCLS.OptionsView.ShowGroupPanel = false;
            this.viewDanhSachCLS.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this._gcSubclinicalId, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this._gcSubclinicalCreatedDate, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // _gcSubclinicalId
            // 
            this._gcSubclinicalId.Caption = "ID";
            this._gcSubclinicalId.FieldName = "ID";
            this._gcSubclinicalId.Name = "_gcSubclinicalId";
            this._gcSubclinicalId.OptionsColumn.AllowEdit = false;
            this._gcSubclinicalId.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this._gcSubclinicalId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this._gcSubclinicalId.Visible = true;
            this._gcSubclinicalId.VisibleIndex = 0;
            this._gcSubclinicalId.Width = 42;
            // 
            // _gcSubclinicalCreatedDate
            // 
            this._gcSubclinicalCreatedDate.Caption = "Ngày";
            this._gcSubclinicalCreatedDate.ColumnEdit = this.r_dtNgayChiDinh;
            this._gcSubclinicalCreatedDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this._gcSubclinicalCreatedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._gcSubclinicalCreatedDate.FieldName = "NGAYGIO";
            this._gcSubclinicalCreatedDate.Name = "_gcSubclinicalCreatedDate";
            this._gcSubclinicalCreatedDate.OptionsColumn.AllowEdit = false;
            this._gcSubclinicalCreatedDate.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this._gcSubclinicalCreatedDate.Visible = true;
            this._gcSubclinicalCreatedDate.VisibleIndex = 1;
            this._gcSubclinicalCreatedDate.Width = 119;
            // 
            // r_dtNgayChiDinh
            // 
            this.r_dtNgayChiDinh.AutoHeight = false;
            this.r_dtNgayChiDinh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.r_dtNgayChiDinh.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.r_dtNgayChiDinh.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.r_dtNgayChiDinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.r_dtNgayChiDinh.EditFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.r_dtNgayChiDinh.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.r_dtNgayChiDinh.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this.r_dtNgayChiDinh.Name = "r_dtNgayChiDinh";
            this.r_dtNgayChiDinh.NullDate = "";
            this.r_dtNgayChiDinh.NullValuePromptShowForEmptyValue = true;
            // 
            // _gcSubclinicalSpecifierFullName
            // 
            this._gcSubclinicalSpecifierFullName.Caption = "Bác sĩ chỉ định";
            this._gcSubclinicalSpecifierFullName.FieldName = "HOTEN_TAIKHOAN_CHIDINH";
            this._gcSubclinicalSpecifierFullName.Name = "_gcSubclinicalSpecifierFullName";
            this._gcSubclinicalSpecifierFullName.Visible = true;
            this._gcSubclinicalSpecifierFullName.VisibleIndex = 2;
            this._gcSubclinicalSpecifierFullName.Width = 145;
            // 
            // _gcSubclinicalPerformerFullName
            // 
            this._gcSubclinicalPerformerFullName.Caption = "Người thực hiện";
            this._gcSubclinicalPerformerFullName.FieldName = "HOTEN_TAIKHOAN_THUCHIEN";
            this._gcSubclinicalPerformerFullName.Name = "_gcSubclinicalPerformerFullName";
            this._gcSubclinicalPerformerFullName.Visible = true;
            this._gcSubclinicalPerformerFullName.VisibleIndex = 5;
            this._gcSubclinicalPerformerFullName.Width = 150;
            // 
            // _gcSubclinicalDescription
            // 
            this._gcSubclinicalDescription.AppearanceCell.Options.UseTextOptions = true;
            this._gcSubclinicalDescription.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this._gcSubclinicalDescription.Caption = "Chẩn đoán";
            this._gcSubclinicalDescription.ColumnEdit = this.r_mmeText;
            this._gcSubclinicalDescription.FieldName = "CHANDOAN";
            this._gcSubclinicalDescription.Name = "_gcSubclinicalDescription";
            this._gcSubclinicalDescription.Visible = true;
            this._gcSubclinicalDescription.VisibleIndex = 3;
            this._gcSubclinicalDescription.Width = 141;
            // 
            // r_mmeText
            // 
            this.r_mmeText.Name = "r_mmeText";
            // 
            // _gcSubclinicalCategoryName
            // 
            this._gcSubclinicalCategoryName.AppearanceCell.Options.UseTextOptions = true;
            this._gcSubclinicalCategoryName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this._gcSubclinicalCategoryName.Caption = "Chỉ định";
            this._gcSubclinicalCategoryName.FieldName = "TEN_DMCHIDINHCLS";
            this._gcSubclinicalCategoryName.Name = "_gcSubclinicalCategoryName";
            this._gcSubclinicalCategoryName.Visible = true;
            this._gcSubclinicalCategoryName.VisibleIndex = 4;
            this._gcSubclinicalCategoryName.Width = 165;
            // 
            // _gcSubclinicalResultName
            // 
            this._gcSubclinicalResultName.Caption = "Mẫu kết quả";
            this._gcSubclinicalResultName.FieldName = "TEN_DMMAUKETQUACLS";
            this._gcSubclinicalResultName.Name = "_gcSubclinicalResultName";
            this._gcSubclinicalResultName.Visible = true;
            this._gcSubclinicalResultName.VisibleIndex = 6;
            this._gcSubclinicalResultName.Width = 157;
            // 
            // _gcSubclinicalResult
            // 
            this._gcSubclinicalResult.Caption = "Kết quả";
            this._gcSubclinicalResult.ColumnEdit = this.r_rtfText;
            this._gcSubclinicalResult.FieldName = "KETQUACLS";
            this._gcSubclinicalResult.Name = "_gcSubclinicalResult";
            this._gcSubclinicalResult.Visible = true;
            this._gcSubclinicalResult.VisibleIndex = 7;
            this._gcSubclinicalResult.Width = 389;
            // 
            // r_rtfText
            // 
            this.r_rtfText.MaxHeight = 150;
            this.r_rtfText.Name = "r_rtfText";
            this.r_rtfText.ShowCaretInReadOnly = false;
            // 
            // _gcSubclinicalConclusion
            // 
            this._gcSubclinicalConclusion.Caption = "Kết luận";
            this._gcSubclinicalConclusion.ColumnEdit = this.r_rtfText;
            this._gcSubclinicalConclusion.FieldName = "KETLUAN";
            this._gcSubclinicalConclusion.Name = "_gcSubclinicalConclusion";
            this._gcSubclinicalConclusion.Visible = true;
            this._gcSubclinicalConclusion.VisibleIndex = 8;
            this._gcSubclinicalConclusion.Width = 247;
            // 
            // _gcSubclinicalSuggestion
            // 
            this._gcSubclinicalSuggestion.Caption = "Đề nghị";
            this._gcSubclinicalSuggestion.ColumnEdit = this.r_mmeText;
            this._gcSubclinicalSuggestion.FieldName = "DENGHI";
            this._gcSubclinicalSuggestion.Name = "_gcSubclinicalSuggestion";
            this._gcSubclinicalSuggestion.Visible = true;
            this._gcSubclinicalSuggestion.VisibleIndex = 9;
            this._gcSubclinicalSuggestion.Width = 153;
            // 
            // _gcSubclinicalNote
            // 
            this._gcSubclinicalNote.Caption = "Ghi chú";
            this._gcSubclinicalNote.ColumnEdit = this.r_mmeText;
            this._gcSubclinicalNote.FieldName = "GHICHU";
            this._gcSubclinicalNote.Name = "_gcSubclinicalNote";
            this._gcSubclinicalNote.Visible = true;
            this._gcSubclinicalNote.VisibleIndex = 10;
            this._gcSubclinicalNote.Width = 153;
            // 
            // _gcSubclinicalPrint
            // 
            this._gcSubclinicalPrint.Caption = "Xem in";
            this._gcSubclinicalPrint.ColumnEdit = this.lnkXemInCLS;
            this._gcSubclinicalPrint.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcSubclinicalPrint.Name = "_gcSubclinicalPrint";
            this._gcSubclinicalPrint.Width = 51;
            // 
            // lnkXemInCLS
            // 
            this.lnkXemInCLS.AutoHeight = false;
            this.lnkXemInCLS.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lnkXemInCLS.Name = "lnkXemInCLS";
            this.lnkXemInCLS.Click += new System.EventHandler(this.lnkXemInCLS_Click);
            // 
            // _gcSubclinicalImage
            // 
            this._gcSubclinicalImage.Caption = "Hình ảnh";
            this._gcSubclinicalImage.ColumnEdit = this.lnkHinhAnhCLS;
            this._gcSubclinicalImage.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcSubclinicalImage.Name = "_gcSubclinicalImage";
            this._gcSubclinicalImage.Visible = true;
            this._gcSubclinicalImage.VisibleIndex = 12;
            this._gcSubclinicalImage.Width = 63;
            // 
            // lnkHinhAnhCLS
            // 
            this.lnkHinhAnhCLS.AutoHeight = false;
            this.lnkHinhAnhCLS.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lnkHinhAnhCLS.Name = "lnkHinhAnhCLS";
            this.lnkHinhAnhCLS.Click += new System.EventHandler(this.lnkHinhAnhCLS_Click);
            // 
            // _gcSubclinicalTakePhotoDate
            // 
            this._gcSubclinicalTakePhotoDate.Caption = "Ngày chụp";
            this._gcSubclinicalTakePhotoDate.FieldName = "TakePhotosDate";
            this._gcSubclinicalTakePhotoDate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcSubclinicalTakePhotoDate.Name = "_gcSubclinicalTakePhotoDate";
            this._gcSubclinicalTakePhotoDate.Visible = true;
            this._gcSubclinicalTakePhotoDate.VisibleIndex = 11;
            this._gcSubclinicalTakePhotoDate.Width = 124;
            // 
            // gridView19
            // 
            this.gridView19.GridControl = this.gridDanhSachCLS;
            this.gridView19.Name = "gridView19";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnNext);
            this.panel7.Controls.Add(this.btnPrev);
            this.panel7.Controls.Add(this.pteImage);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 55);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1024, 345);
            this.panel7.TabIndex = 19;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNext.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnNext.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnNext.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnNext.Appearance.Options.UseBackColor = true;
            this.btnNext.Appearance.Options.UseBorderColor = true;
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnNext.ImageIndex = 1;
            this.btnNext.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.btnNext.Location = new System.Drawing.Point(500, 5);
            this.btnNext.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnNext.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnNext.Size = new System.Drawing.Size(25, 22);
            this.btnNext.TabIndex = 159;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrev.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnPrev.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnPrev.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnPrev.Appearance.Options.UseBackColor = true;
            this.btnPrev.Appearance.Options.UseBorderColor = true;
            this.btnPrev.Appearance.Options.UseFont = true;
            this.btnPrev.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnPrev.ImageIndex = 2;
            this.btnPrev.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.btnPrev.Location = new System.Drawing.Point(470, 5);
            this.btnPrev.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnPrev.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnPrev.Size = new System.Drawing.Size(26, 22);
            this.btnPrev.TabIndex = 158;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // pteImage
            // 
            this.pteImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pteImage.Location = new System.Drawing.Point(0, 0);
            this.pteImage.Margin = new System.Windows.Forms.Padding(0);
            this.pteImage.Name = "pteImage";
            this.pteImage.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.pteImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pteImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pteImage.Size = new System.Drawing.Size(1024, 345);
            this.pteImage.TabIndex = 156;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this._imgNote);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1024, 55);
            this.panel8.TabIndex = 18;
            // 
            // _imgNote
            // 
            this._imgNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this._imgNote.Location = new System.Drawing.Point(0, 0);
            this._imgNote.Margin = new System.Windows.Forms.Padding(0);
            this._imgNote.Name = "_imgNote";
            this._imgNote.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._imgNote.Properties.Appearance.Options.UseFont = true;
            this._imgNote.Properties.Appearance.Options.UseTextOptions = true;
            this._imgNote.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this._imgNote.Size = new System.Drawing.Size(1024, 55);
            this._imgNote.TabIndex = 158;
            // 
            // UcCustomerSubclinical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UcCustomerSubclinical";
            this.Size = new System.Drawing.Size(1024, 600);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachCLS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDanhSachCLS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_dtNgayChiDinh.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_dtNgayChiDinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_mmeText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_rtfText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkXemInCLS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkHinhAnhCLS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView19)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pteImage.Properties)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._imgNote.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel8;
        private DevExpress.XtraEditors.MemoEdit _imgNote;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnPrev;
        private DevExpress.XtraEditors.PictureEdit pteImage;
        private DevExpress.XtraGrid.GridControl gridDanhSachCLS;
        private DevExpress.XtraGrid.Views.Grid.GridView viewDanhSachCLS;
        private DevExpress.XtraGrid.Columns.GridColumn _gcSubclinicalId;
        private DevExpress.XtraGrid.Columns.GridColumn _gcSubclinicalCreatedDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit r_dtNgayChiDinh;
        private DevExpress.XtraGrid.Columns.GridColumn _gcSubclinicalSpecifierFullName;
        private DevExpress.XtraGrid.Columns.GridColumn _gcSubclinicalPerformerFullName;
        private DevExpress.XtraGrid.Columns.GridColumn _gcSubclinicalDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit r_mmeText;
        private DevExpress.XtraGrid.Columns.GridColumn _gcSubclinicalCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn _gcSubclinicalResultName;
        private DevExpress.XtraGrid.Columns.GridColumn _gcSubclinicalResult;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit r_rtfText;
        private DevExpress.XtraGrid.Columns.GridColumn _gcSubclinicalConclusion;
        private DevExpress.XtraGrid.Columns.GridColumn _gcSubclinicalSuggestion;
        private DevExpress.XtraGrid.Columns.GridColumn _gcSubclinicalNote;
        private DevExpress.XtraGrid.Columns.GridColumn _gcSubclinicalPrint;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit lnkXemInCLS;
        private DevExpress.XtraGrid.Columns.GridColumn _gcSubclinicalImage;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit lnkHinhAnhCLS;
        private DevExpress.XtraGrid.Columns.GridColumn _gcSubclinicalTakePhotoDate;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView19;
    }
}
