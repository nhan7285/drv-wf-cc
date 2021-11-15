namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    partial class UcTreatmentTurns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcTreatmentTurns));
            this._grid = new DevExpress.XtraGrid.GridControl();
            this._view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gcOrderId = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcOrderName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcOrderDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcOrderConsultingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.r_dtNgay = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this._gcOrderIsClosed = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcOrderIsCancelled = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcIsForOld = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcTreatment = new DevExpress.XtraGrid.Columns.GridColumn();
            this._lnkTreatment = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this._gcOrderEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this._lnkTurnsEdit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this._gcOrderDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this._lnkTurnsDelete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this._gcFolderName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._panelFooter = new System.Windows.Forms.Panel();
            this._chkIsAll = new DevExpress.XtraEditors.CheckEdit();
            this._chkIsOrder = new DevExpress.XtraEditors.CheckEdit();
            this._chkIsFolder = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_dtNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_dtNgay.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lnkTreatment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lnkTurnsEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lnkTurnsDelete)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this._panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._chkIsAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkIsOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkIsFolder.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // _grid
            // 
            this._grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gridLevelNode1.RelationName = "Level1";
            this._grid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this._grid.Location = new System.Drawing.Point(4, 3);
            this._grid.MainView = this._view;
            this._grid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._grid.Name = "_grid";
            this._grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this._lnkTurnsEdit,
            this.r_dtNgay,
            this._lnkTurnsDelete,
            this._lnkTreatment});
            this._grid.Size = new System.Drawing.Size(792, 280);
            this._grid.TabIndex = 12;
            this._grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._view});
            // 
            // _view
            // 
            this._view.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            this._view.Appearance.FocusedRow.Options.UseBackColor = true;
            this._view.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this._view.Appearance.HeaderPanel.Options.UseFont = true;
            this._view.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this._view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._view.Appearance.Row.Font = new System.Drawing.Font("Verdana", 9F);
            this._view.Appearance.Row.Options.UseFont = true;
            this._view.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._gcOrderId,
            this._gcOrderName,
            this._gcOrderDescription,
            this._gcOrderConsultingDate,
            this._gcOrderIsClosed,
            this._gcOrderIsCancelled,
            this._gcIsForOld,
            this._gcTreatment,
            this._gcOrderEdit,
            this._gcOrderDelete,
            this._gcFolderName});
            this._view.GridControl = this._grid;
            this._view.GroupCount = 1;
            this._view.Name = "_view";
            this._view.OptionsBehavior.AutoExpandAllGroups = true;
            this._view.OptionsBehavior.ReadOnly = true;
            this._view.OptionsView.RowAutoHeight = true;
            this._view.OptionsView.ShowDetailButtons = false;
            this._view.OptionsView.ShowGroupPanel = false;
            this._view.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this._gcFolderName, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this._gcOrderConsultingDate, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this._gcOrderId, DevExpress.Data.ColumnSortOrder.Descending)});
            this._view.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this._view_CustomRowCellEdit);
            this._view.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this._view_FocusedRowChanged);
            // 
            // _gcOrderId
            // 
            this._gcOrderId.Caption = "ID";
            this._gcOrderId.DisplayFormat.FormatString = "n0";
            this._gcOrderId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._gcOrderId.FieldName = "ID";
            this._gcOrderId.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this._gcOrderId.Name = "_gcOrderId";
            this._gcOrderId.OptionsColumn.AllowEdit = false;
            this._gcOrderId.OptionsColumn.ReadOnly = true;
            this._gcOrderId.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this._gcOrderId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this._gcOrderId.Visible = true;
            this._gcOrderId.VisibleIndex = 0;
            this._gcOrderId.Width = 60;
            // 
            // _gcOrderName
            // 
            this._gcOrderName.Caption = "Tên";
            this._gcOrderName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this._gcOrderName.MinWidth = 120;
            this._gcOrderName.Name = "_gcOrderName";
            this._gcOrderName.OptionsColumn.AllowEdit = false;
            this._gcOrderName.OptionsColumn.ReadOnly = true;
            this._gcOrderName.Width = 120;
            // 
            // _gcOrderDescription
            // 
            this._gcOrderDescription.Caption = "Ghi chú";
            this._gcOrderDescription.MinWidth = 200;
            this._gcOrderDescription.Name = "_gcOrderDescription";
            this._gcOrderDescription.OptionsColumn.AllowEdit = false;
            this._gcOrderDescription.OptionsColumn.ReadOnly = true;
            this._gcOrderDescription.Width = 200;
            // 
            // _gcOrderConsultingDate
            // 
            this._gcOrderConsultingDate.Caption = "Ngày";
            this._gcOrderConsultingDate.ColumnEdit = this.r_dtNgay;
            this._gcOrderConsultingDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this._gcOrderConsultingDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._gcOrderConsultingDate.FieldName = "NGAYTUVAN";
            this._gcOrderConsultingDate.MaxWidth = 140;
            this._gcOrderConsultingDate.MinWidth = 140;
            this._gcOrderConsultingDate.Name = "_gcOrderConsultingDate";
            this._gcOrderConsultingDate.OptionsColumn.AllowEdit = false;
            this._gcOrderConsultingDate.OptionsColumn.ReadOnly = true;
            this._gcOrderConsultingDate.Visible = true;
            this._gcOrderConsultingDate.VisibleIndex = 1;
            this._gcOrderConsultingDate.Width = 140;
            // 
            // r_dtNgay
            // 
            this.r_dtNgay.AutoHeight = false;
            this.r_dtNgay.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.r_dtNgay.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.r_dtNgay.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.r_dtNgay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.r_dtNgay.EditFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.r_dtNgay.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.r_dtNgay.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this.r_dtNgay.Name = "r_dtNgay";
            this.r_dtNgay.NullDate = "";
            // 
            // _gcOrderIsClosed
            // 
            this._gcOrderIsClosed.Caption = "Đóng";
            this._gcOrderIsClosed.FieldName = "DADONGHOSO";
            this._gcOrderIsClosed.MinWidth = 60;
            this._gcOrderIsClosed.Name = "_gcOrderIsClosed";
            this._gcOrderIsClosed.ToolTip = "Đã đóng HS";
            this._gcOrderIsClosed.Visible = true;
            this._gcOrderIsClosed.VisibleIndex = 2;
            this._gcOrderIsClosed.Width = 64;
            // 
            // _gcOrderIsCancelled
            // 
            this._gcOrderIsCancelled.Caption = "Đã hủy";
            this._gcOrderIsCancelled.FieldName = "DAHUY";
            this._gcOrderIsCancelled.Name = "_gcOrderIsCancelled";
            this._gcOrderIsCancelled.Visible = true;
            this._gcOrderIsCancelled.VisibleIndex = 3;
            this._gcOrderIsCancelled.Width = 22;
            // 
            // _gcIsForOld
            // 
            this._gcIsForOld.Caption = "Cũ";
            this._gcIsForOld.MaxWidth = 40;
            this._gcIsForOld.MinWidth = 40;
            this._gcIsForOld.Name = "_gcIsForOld";
            this._gcIsForOld.Width = 40;
            this._gcIsForOld.Visible = false;
            // 
            // _gcTreatment
            // 
            this._gcTreatment.Caption = "Đ.Trị";
            this._gcTreatment.ColumnEdit = this._lnkTreatment;
            this._gcTreatment.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcTreatment.MaxWidth = 50;
            this._gcTreatment.MinWidth = 50;
            this._gcTreatment.Name = "_gcTreatment";
            this._gcTreatment.Visible = true;
            this._gcTreatment.VisibleIndex = 4;
            this._gcTreatment.Width = 50;
            // 
            // _lnkTreatment
            // 
            this._lnkTreatment.AutoHeight = false;
            this._lnkTreatment.Image = ((System.Drawing.Image)(resources.GetObject("_lnkTreatment.Image")));
            this._lnkTreatment.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._lnkTreatment.Name = "_lnkTreatment";
            this._lnkTreatment.Click += new System.EventHandler(this._lnkTreatment_Click);
            // 
            // _gcOrderEdit
            // 
            this._gcOrderEdit.Caption = "Sửa";
            this._gcOrderEdit.ColumnEdit = this._lnkTurnsEdit;
            this._gcOrderEdit.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcOrderEdit.MinWidth = 60;
            this._gcOrderEdit.Name = "_gcOrderEdit";
            this._gcOrderEdit.Visible = true;
            this._gcOrderEdit.VisibleIndex = 5;
            this._gcOrderEdit.Width = 60;
            // 
            // _lnkTurnsEdit
            // 
            this._lnkTurnsEdit.AutoHeight = false;
            this._lnkTurnsEdit.Image = ((System.Drawing.Image)(resources.GetObject("_lnkTurnsEdit.Image")));
            this._lnkTurnsEdit.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._lnkTurnsEdit.Name = "_lnkTurnsEdit";
            // 
            // _gcOrderDelete
            // 
            this._gcOrderDelete.Caption = "Xóa";
            this._gcOrderDelete.ColumnEdit = this._lnkTurnsDelete;
            this._gcOrderDelete.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcOrderDelete.Name = "_gcOrderDelete";
            this._gcOrderDelete.Width = 32;
            // 
            // _lnkTurnsDelete
            // 
            this._lnkTurnsDelete.AutoHeight = false;
            this._lnkTurnsDelete.Image = ((System.Drawing.Image)(resources.GetObject("_lnkTurnsDelete.Image")));
            this._lnkTurnsDelete.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._lnkTurnsDelete.Name = "_lnkTurnsDelete";
            // 
            // _gcFolderName
            // 
            this._gcFolderName.Caption = "Đợt";
            this._gcFolderName.Name = "_gcFolderName";
            this._gcFolderName.OptionsColumn.ReadOnly = true;
            this._gcFolderName.Visible = true;
            this._gcFolderName.VisibleIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._grid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._panelFooter, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 319);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // _panelFooter
            // 
            this._panelFooter.Controls.Add(this._chkIsAll);
            this._panelFooter.Controls.Add(this._chkIsOrder);
            this._panelFooter.Controls.Add(this._chkIsFolder);
            this._panelFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelFooter.Location = new System.Drawing.Point(3, 289);
            this._panelFooter.Name = "_panelFooter";
            this._panelFooter.Size = new System.Drawing.Size(794, 27);
            this._panelFooter.TabIndex = 13;
            // 
            // _chkIsAll
            // 
            this._chkIsAll.Location = new System.Drawing.Point(4, 4);
            this._chkIsAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._chkIsAll.Name = "_chkIsAll";
            this._chkIsAll.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkIsAll.Properties.Appearance.Options.UseFont = true;
            this._chkIsAll.Properties.Caption = "Tất cả";
            this._chkIsAll.Size = new System.Drawing.Size(98, 20);
            this._chkIsAll.TabIndex = 132;
            this._chkIsAll.CheckedChanged += new System.EventHandler(this._chkIsAll_CheckedChanged);
            // 
            // _chkIsOrder
            // 
            this._chkIsOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._chkIsOrder.EditValue = true;
            this._chkIsOrder.Location = new System.Drawing.Point(681, 4);
            this._chkIsOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._chkIsOrder.Name = "_chkIsOrder";
            this._chkIsOrder.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkIsOrder.Properties.Appearance.Options.UseFont = true;
            this._chkIsOrder.Properties.Caption = "Hồ sơ điều trị";
            this._chkIsOrder.Size = new System.Drawing.Size(109, 20);
            this._chkIsOrder.TabIndex = 131;
            this._chkIsOrder.CheckedChanged += new System.EventHandler(this._chkIsOrder_CheckedChanged);
            // 
            // _chkIsFolder
            // 
            this._chkIsFolder.Location = new System.Drawing.Point(138, 4);
            this._chkIsFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._chkIsFolder.Name = "_chkIsFolder";
            this._chkIsFolder.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkIsFolder.Properties.Appearance.Options.UseFont = true;
            this._chkIsFolder.Properties.Caption = "Đợt điều trị";
            this._chkIsFolder.Size = new System.Drawing.Size(98, 20);
            this._chkIsFolder.TabIndex = 130;
            this._chkIsFolder.CheckedChanged += new System.EventHandler(this._chkIsFolder_CheckedChanged);
            // 
            // UcTreatmentTurns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UcTreatmentTurns";
            this.Size = new System.Drawing.Size(800, 319);
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_dtNgay.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_dtNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lnkTreatment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lnkTurnsEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lnkTurnsDelete)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this._panelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._chkIsAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkIsOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkIsFolder.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl _grid;
        private DevExpress.XtraGrid.Views.Grid.GridView _view;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderId;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderConsultingDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit r_dtNgay;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit _lnkTurnsEdit;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit _lnkTurnsDelete;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderIsClosed;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderIsCancelled;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderName;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel _panelFooter;
        private DevExpress.XtraEditors.CheckEdit _chkIsOrder;
        private DevExpress.XtraEditors.CheckEdit _chkIsFolder;
        private DevExpress.XtraGrid.Columns.GridColumn _gcFolderName;
        private DevExpress.XtraEditors.CheckEdit _chkIsAll;
        private DevExpress.XtraGrid.Columns.GridColumn _gcTreatment;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit _lnkTreatment;
        private DevExpress.XtraGrid.Columns.GridColumn _gcIsForOld;
    }
}
