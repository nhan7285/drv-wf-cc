namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Consult
{
    partial class UcConsultancyTemplateGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcConsultancyTemplateGrid));
            this._grid = new DevExpress.XtraGrid.GridControl();
            this._view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gcConsultNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcConsultCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcConsultName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcConsultTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcConsultGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcConsultGroupFinalName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcConsultProductServiceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcConsultDoctor = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcConsultAssistant = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcConsultEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this._lnkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this._gcConsultDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this._lnkDelete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this._gcConsultDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcConsultIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lnkEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lnkDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // _grid
            // 
            this._grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gridLevelNode1.RelationName = "Level1";
            this._grid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this._grid.Location = new System.Drawing.Point(0, 0);
            this._grid.MainView = this._view;
            this._grid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._grid.Name = "_grid";
            this._grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this._lnkEdit,
            this._lnkDelete});
            this._grid.Size = new System.Drawing.Size(1000, 96);
            this._grid.TabIndex = 22;
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
            this._gcConsultNo,
            this._gcConsultName,
            this._gcConsultDescription,
            this._gcConsultIsActive,
            this._gcConsultTypeName,
            this._gcConsultGroupName,
            this._gcConsultGroupFinalName,
            this._gcConsultProductServiceName,
            this._gcConsultDoctor,
            this._gcConsultAssistant,
            this._gcConsultCreatedDate,
            this._gcConsultEdit,
            this._gcConsultDelete});
            this._view.GridControl = this._grid;
            this._view.Name = "_view";
            this._view.OptionsBehavior.AutoExpandAllGroups = true;
            this._view.OptionsBehavior.ReadOnly = true;
            this._view.OptionsView.RowAutoHeight = true;
            this._view.OptionsView.ShowDetailButtons = false;
            this._view.OptionsView.ShowGroupPanel = false;
            this._view.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this._gcConsultDoctor, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // _gcConsultNo
            // 
            this._gcConsultNo.Caption = "STT";
            this._gcConsultNo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this._gcConsultNo.MinWidth = 60;
            this._gcConsultNo.Name = "_gcConsultNo";
            this._gcConsultNo.Visible = true;
            this._gcConsultNo.VisibleIndex = 0;
            this._gcConsultNo.Width = 62;
            // 
            // _gcConsultCreatedDate
            // 
            this._gcConsultCreatedDate.Caption = "Ngày tạo";
            this._gcConsultCreatedDate.FieldName = "CreatedDate";
            this._gcConsultCreatedDate.MinWidth = 120;
            this._gcConsultCreatedDate.Name = "_gcConsultCreatedDate";
            this._gcConsultCreatedDate.OptionsColumn.AllowEdit = false;
            this._gcConsultCreatedDate.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this._gcConsultCreatedDate.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this._gcConsultCreatedDate.Visible = true;
            this._gcConsultCreatedDate.VisibleIndex = 4;
            this._gcConsultCreatedDate.Width = 120;
            // 
            // _gcConsultName
            // 
            this._gcConsultName.Caption = "Tên";
            this._gcConsultName.MinWidth = 120;
            this._gcConsultName.Name = "_gcConsultName";
            this._gcConsultName.OptionsColumn.AllowEdit = false;
            this._gcConsultName.Visible = true;
            this._gcConsultName.VisibleIndex = 1;
            this._gcConsultName.Width = 192;
            // 
            // _gcConsultTypeName
            // 
            this._gcConsultTypeName.Caption = "Loại";
            this._gcConsultTypeName.MinWidth = 120;
            this._gcConsultTypeName.Name = "_gcConsultTypeName";
            this._gcConsultTypeName.OptionsColumn.AllowEdit = false;
            this._gcConsultTypeName.Width = 120;
            // 
            // _gcConsultGroupName
            // 
            this._gcConsultGroupName.Caption = "Nhóm";
            this._gcConsultGroupName.MinWidth = 120;
            this._gcConsultGroupName.Name = "_gcConsultGroupName";
            this._gcConsultGroupName.OptionsColumn.AllowEdit = false;
            this._gcConsultGroupName.Width = 120;
            // 
            // _gcConsultGroupFinalName
            // 
            this._gcConsultGroupFinalName.Caption = "Phân nhóm";
            this._gcConsultGroupFinalName.MinWidth = 120;
            this._gcConsultGroupFinalName.Name = "_gcConsultGroupFinalName";
            this._gcConsultGroupFinalName.OptionsColumn.AllowEdit = false;
            this._gcConsultGroupFinalName.Width = 120;
            // 
            // _gcConsultProductServiceName
            // 
            this._gcConsultProductServiceName.Caption = "SP/DV";
            this._gcConsultProductServiceName.MinWidth = 120;
            this._gcConsultProductServiceName.Name = "_gcConsultProductServiceName";
            this._gcConsultProductServiceName.OptionsColumn.AllowEdit = false;
            this._gcConsultProductServiceName.Width = 120;
            // 
            // _gcConsultDoctor
            // 
            this._gcConsultDoctor.Caption = "Bác sĩ";
            this._gcConsultDoctor.FieldName = "Content";
            this._gcConsultDoctor.Name = "_gcConsultDoctor";
            this._gcConsultDoctor.OptionsColumn.AllowEdit = false;
            this._gcConsultDoctor.Width = 247;
            // 
            // _gcConsultAssistant
            // 
            this._gcConsultAssistant.Caption = "Phụ tá";
            this._gcConsultAssistant.Name = "_gcConsultAssistant";
            this._gcConsultAssistant.OptionsColumn.AllowEdit = false;
            this._gcConsultAssistant.Width = 252;
            // 
            // _gcConsultEdit
            // 
            this._gcConsultEdit.Caption = "Sửa";
            this._gcConsultEdit.ColumnEdit = this._lnkEdit;
            this._gcConsultEdit.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcConsultEdit.MaxWidth = 60;
            this._gcConsultEdit.MinWidth = 60;
            this._gcConsultEdit.Name = "_gcConsultEdit";
            this._gcConsultEdit.Visible = true;
            this._gcConsultEdit.VisibleIndex = 5;
            this._gcConsultEdit.Width = 60;
            // 
            // _lnkEdit
            // 
            this._lnkEdit.AutoHeight = false;
            this._lnkEdit.Image = ((System.Drawing.Image)(resources.GetObject("_lnkEdit.Image")));
            this._lnkEdit.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._lnkEdit.Name = "_lnkEdit";
            this._lnkEdit.Click += new System.EventHandler(this._lnkEdit_Click);
            // 
            // _gcConsultDelete
            // 
            this._gcConsultDelete.Caption = "Xóa";
            this._gcConsultDelete.ColumnEdit = this._lnkDelete;
            this._gcConsultDelete.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcConsultDelete.MaxWidth = 60;
            this._gcConsultDelete.MinWidth = 60;
            this._gcConsultDelete.Name = "_gcConsultDelete";
            this._gcConsultDelete.Visible = true;
            this._gcConsultDelete.VisibleIndex = 6;
            this._gcConsultDelete.Width = 60;
            // 
            // _lnkDelete
            // 
            this._lnkDelete.AutoHeight = false;
            this._lnkDelete.Image = ((System.Drawing.Image)(resources.GetObject("_lnkDelete.Image")));
            this._lnkDelete.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._lnkDelete.Name = "_lnkDelete";
            this._lnkDelete.Click += new System.EventHandler(this._lnkDelete_Click);
            // 
            // _gcConsultDescription
            // 
            this._gcConsultDescription.Caption = "Mô tả";
            this._gcConsultDescription.MinWidth = 200;
            this._gcConsultDescription.Name = "_gcConsultDescription";
            this._gcConsultDescription.Visible = true;
            this._gcConsultDescription.VisibleIndex = 2;
            this._gcConsultDescription.Width = 300;
            // 
            // _gcConsultIsActive
            // 
            this._gcConsultIsActive.Caption = "Sử dụng";
            this._gcConsultIsActive.MinWidth = 75;
            this._gcConsultIsActive.Name = "_gcConsultIsActive";
            this._gcConsultIsActive.Visible = true;
            this._gcConsultIsActive.VisibleIndex = 3;
            this._gcConsultIsActive.Width = 128;
            // 
            // UcConsultancyTemplateGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._grid);
            this.Name = "UcConsultancyTemplateGrid";
            this.Size = new System.Drawing.Size(1000, 96);
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lnkEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lnkDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl _grid;
        private DevExpress.XtraGrid.Views.Grid.GridView _view;
        private DevExpress.XtraGrid.Columns.GridColumn _gcConsultCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn _gcConsultName;
        private DevExpress.XtraGrid.Columns.GridColumn _gcConsultTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn _gcConsultGroupName;
        private DevExpress.XtraGrid.Columns.GridColumn _gcConsultGroupFinalName;
        private DevExpress.XtraGrid.Columns.GridColumn _gcConsultProductServiceName;
        private DevExpress.XtraGrid.Columns.GridColumn _gcConsultDoctor;
        private DevExpress.XtraGrid.Columns.GridColumn _gcConsultAssistant;
        private DevExpress.XtraGrid.Columns.GridColumn _gcConsultDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit _lnkEdit;
        private DevExpress.XtraGrid.Columns.GridColumn _gcConsultNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit _lnkDelete;
        private DevExpress.XtraGrid.Columns.GridColumn _gcConsultEdit;
        private DevExpress.XtraGrid.Columns.GridColumn _gcConsultDescription;
        private DevExpress.XtraGrid.Columns.GridColumn _gcConsultIsActive;
    }
}
