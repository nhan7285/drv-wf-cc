namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Notes
{
    partial class UcCustomerNeed
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
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this._gridCustomerNeed = new DevExpress.XtraGrid.GridControl();
            this._viewCustomerNeed = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gcCustomerNeedCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcCustomerNeedDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcCustomerNeedEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit7 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this._gcCustomerNeedDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this._repoCustomerNeedDelete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemDateEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.panel5 = new System.Windows.Forms.Panel();
            this._btnAdvancedNeed = new DevExpress.XtraEditors.SimpleButton();
            this._btnCancelNeedsNote = new DevExpress.XtraEditors.SimpleButton();
            this._btnSaveNewNeedsNotes = new DevExpress.XtraEditors.SimpleButton();
            this._btnSaveNeedsNotes = new DevExpress.XtraEditors.SimpleButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.labelControl45 = new DevExpress.XtraEditors.LabelControl();
            this._txtNeedCreatedDate = new DevExpress.XtraEditors.DateEdit();
            this._txtNeedNotes = new DevExpress.XtraEditors.MemoEdit();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridCustomerNeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._viewCustomerNeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._repoCustomerNeedDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit6.CalendarTimeProperties)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtNeedCreatedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtNeedCreatedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtNeedNotes.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this._gridCustomerNeed, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 3;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(356, 291);
            this.tableLayoutPanel10.TabIndex = 4;
            // 
            // _gridCustomerNeed
            // 
            this._gridCustomerNeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gridCustomerNeed.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gridLevelNode1.RelationName = "Level1";
            this._gridCustomerNeed.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this._gridCustomerNeed.Location = new System.Drawing.Point(4, 169);
            this._gridCustomerNeed.MainView = this._viewCustomerNeed;
            this._gridCustomerNeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._gridCustomerNeed.Name = "_gridCustomerNeed";
            this._gridCustomerNeed.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit7,
            this.repositoryItemDateEdit6,
            this._repoCustomerNeedDelete});
            this._gridCustomerNeed.Size = new System.Drawing.Size(348, 119);
            this._gridCustomerNeed.TabIndex = 22;
            this._gridCustomerNeed.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._viewCustomerNeed});
            // 
            // _viewCustomerNeed
            // 
            this._viewCustomerNeed.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            this._viewCustomerNeed.Appearance.FocusedRow.Options.UseBackColor = true;
            this._viewCustomerNeed.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this._viewCustomerNeed.Appearance.HeaderPanel.Options.UseFont = true;
            this._viewCustomerNeed.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this._viewCustomerNeed.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._viewCustomerNeed.Appearance.Row.Font = new System.Drawing.Font("Verdana", 9F);
            this._viewCustomerNeed.Appearance.Row.Options.UseFont = true;
            this._viewCustomerNeed.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._gcCustomerNeedCreatedDate,
            this._gcCustomerNeedDescription,
            this._gcCustomerNeedEdit,
            this._gcCustomerNeedDelete});
            this._viewCustomerNeed.GridControl = this._gridCustomerNeed;
            this._viewCustomerNeed.Name = "_viewCustomerNeed";
            this._viewCustomerNeed.OptionsBehavior.ReadOnly = true;
            this._viewCustomerNeed.OptionsView.ColumnAutoWidth = false;
            this._viewCustomerNeed.OptionsView.RowAutoHeight = true;
            this._viewCustomerNeed.OptionsView.ShowDetailButtons = false;
            this._viewCustomerNeed.OptionsView.ShowGroupPanel = false;
            this._viewCustomerNeed.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this._gcCustomerNeedDescription, DevExpress.Data.ColumnSortOrder.Descending)});
            this._viewCustomerNeed.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this._viewCustomerNeed_RowClick);
            // 
            // _gcCustomerNeedCreatedDate
            // 
            this._gcCustomerNeedCreatedDate.Caption = "Ngày";
            this._gcCustomerNeedCreatedDate.FieldName = "CreatedDate";
            this._gcCustomerNeedCreatedDate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this._gcCustomerNeedCreatedDate.Name = "_gcCustomerNeedCreatedDate";
            this._gcCustomerNeedCreatedDate.OptionsColumn.AllowEdit = false;
            this._gcCustomerNeedCreatedDate.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this._gcCustomerNeedCreatedDate.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this._gcCustomerNeedCreatedDate.Visible = true;
            this._gcCustomerNeedCreatedDate.VisibleIndex = 0;
            this._gcCustomerNeedCreatedDate.Width = 120;
            // 
            // _gcCustomerNeedDescription
            // 
            this._gcCustomerNeedDescription.Caption = "Ghi chú";
            this._gcCustomerNeedDescription.FieldName = "Content";
            this._gcCustomerNeedDescription.Name = "_gcCustomerNeedDescription";
            this._gcCustomerNeedDescription.OptionsColumn.AllowEdit = false;
            this._gcCustomerNeedDescription.Visible = true;
            this._gcCustomerNeedDescription.VisibleIndex = 1;
            this._gcCustomerNeedDescription.Width = 184;
            // 
            // _gcCustomerNeedEdit
            // 
            this._gcCustomerNeedEdit.Caption = "Sửa";
            this._gcCustomerNeedEdit.ColumnEdit = this.repositoryItemHyperLinkEdit7;
            this._gcCustomerNeedEdit.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcCustomerNeedEdit.Name = "_gcCustomerNeedEdit";
            this._gcCustomerNeedEdit.Width = 34;
            // 
            // repositoryItemHyperLinkEdit7
            // 
            this.repositoryItemHyperLinkEdit7.AutoHeight = false;
            this.repositoryItemHyperLinkEdit7.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemHyperLinkEdit7.Name = "repositoryItemHyperLinkEdit7";
            // 
            // _gcCustomerNeedDelete
            // 
            this._gcCustomerNeedDelete.Caption = "Xóa";
            this._gcCustomerNeedDelete.ColumnEdit = this._repoCustomerNeedDelete;
            this._gcCustomerNeedDelete.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcCustomerNeedDelete.Name = "_gcCustomerNeedDelete";
            this._gcCustomerNeedDelete.Visible = true;
            this._gcCustomerNeedDelete.VisibleIndex = 2;
            this._gcCustomerNeedDelete.Width = 32;
            // 
            // _repoCustomerNeedDelete
            // 
            this._repoCustomerNeedDelete.AutoHeight = false;
            this._repoCustomerNeedDelete.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._repoCustomerNeedDelete.Name = "_repoCustomerNeedDelete";
            this._repoCustomerNeedDelete.Click += new System.EventHandler(this._repoCustomerNeedDelete_Click);
            // 
            // repositoryItemDateEdit6
            // 
            this.repositoryItemDateEdit6.AutoHeight = false;
            this.repositoryItemDateEdit6.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit6.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit6.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.repositoryItemDateEdit6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit6.EditFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.repositoryItemDateEdit6.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit6.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this.repositoryItemDateEdit6.Name = "repositoryItemDateEdit6";
            this.repositoryItemDateEdit6.NullDate = "";
            this.repositoryItemDateEdit6.NullValuePromptShowForEmptyValue = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this._btnAdvancedNeed);
            this.panel5.Controls.Add(this._btnCancelNeedsNote);
            this.panel5.Controls.Add(this._btnSaveNewNeedsNotes);
            this.panel5.Controls.Add(this._btnSaveNeedsNotes);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 127);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(350, 37);
            this.panel5.TabIndex = 17;
            // 
            // _btnAdvancedNeed
            // 
            this._btnAdvancedNeed.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnAdvancedNeed.Appearance.ForeColor = System.Drawing.Color.Black;
            this._btnAdvancedNeed.Appearance.Options.UseFont = true;
            this._btnAdvancedNeed.Appearance.Options.UseForeColor = true;
            this._btnAdvancedNeed.Location = new System.Drawing.Point(253, 2);
            this._btnAdvancedNeed.Margin = new System.Windows.Forms.Padding(0);
            this._btnAdvancedNeed.Name = "_btnAdvancedNeed";
            this._btnAdvancedNeed.Size = new System.Drawing.Size(93, 35);
            this._btnAdvancedNeed.TabIndex = 54;
            this._btnAdvancedNeed.Text = "Nâng cao";
            this._btnAdvancedNeed.Click += new System.EventHandler(this._btnAdvancedNeed_Click);
            // 
            // _btnCancelNeedsNote
            // 
            this._btnCancelNeedsNote.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnCancelNeedsNote.Appearance.ForeColor = System.Drawing.Color.Black;
            this._btnCancelNeedsNote.Appearance.Options.UseFont = true;
            this._btnCancelNeedsNote.Appearance.Options.UseForeColor = true;
            this._btnCancelNeedsNote.Location = new System.Drawing.Point(0, 2);
            this._btnCancelNeedsNote.Margin = new System.Windows.Forms.Padding(0);
            this._btnCancelNeedsNote.Name = "_btnCancelNeedsNote";
            this._btnCancelNeedsNote.Size = new System.Drawing.Size(67, 35);
            this._btnCancelNeedsNote.TabIndex = 53;
            this._btnCancelNeedsNote.Text = "Hủy";
            this._btnCancelNeedsNote.Click += new System.EventHandler(this._btnCancelNeedsNote_Click);
            // 
            // _btnSaveNewNeedsNotes
            // 
            this._btnSaveNewNeedsNotes.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnSaveNewNeedsNotes.Appearance.ForeColor = System.Drawing.Color.Black;
            this._btnSaveNewNeedsNotes.Appearance.Options.UseFont = true;
            this._btnSaveNewNeedsNotes.Appearance.Options.UseForeColor = true;
            this._btnSaveNewNeedsNotes.Location = new System.Drawing.Point(162, 2);
            this._btnSaveNewNeedsNotes.Margin = new System.Windows.Forms.Padding(0);
            this._btnSaveNewNeedsNotes.Name = "_btnSaveNewNeedsNotes";
            this._btnSaveNewNeedsNotes.Size = new System.Drawing.Size(89, 35);
            this._btnSaveNewNeedsNotes.TabIndex = 52;
            this._btnSaveNewNeedsNotes.Text = "Lưu mới";
            this._btnSaveNewNeedsNotes.Click += new System.EventHandler(this._btnSaveNewNeedsNotes_Click);
            // 
            // _btnSaveNeedsNotes
            // 
            this._btnSaveNeedsNotes.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnSaveNeedsNotes.Appearance.ForeColor = System.Drawing.Color.Black;
            this._btnSaveNeedsNotes.Appearance.Options.UseFont = true;
            this._btnSaveNeedsNotes.Appearance.Options.UseForeColor = true;
            this._btnSaveNeedsNotes.Location = new System.Drawing.Point(69, 2);
            this._btnSaveNeedsNotes.Margin = new System.Windows.Forms.Padding(0);
            this._btnSaveNeedsNotes.Name = "_btnSaveNeedsNotes";
            this._btnSaveNeedsNotes.Size = new System.Drawing.Size(91, 35);
            this._btnSaveNeedsNotes.TabIndex = 51;
            this._btnSaveNeedsNotes.Text = "Lưu";
            this._btnSaveNeedsNotes.Click += new System.EventHandler(this._btnSaveNeedsNotes_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel11);
            this.panel6.Controls.Add(this._txtNeedNotes);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(350, 119);
            this.panel6.TabIndex = 19;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.labelControl45);
            this.panel11.Controls.Add(this._txtNeedCreatedDate);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(350, 23);
            this.panel11.TabIndex = 19;
            // 
            // labelControl45
            // 
            this.labelControl45.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl45.Location = new System.Drawing.Point(5, 4);
            this.labelControl45.Name = "labelControl45";
            this.labelControl45.Size = new System.Drawing.Size(62, 14);
            this.labelControl45.TabIndex = 4;
            this.labelControl45.Text = "Ngày tạo:";
            // 
            // _txtNeedCreatedDate
            // 
            this._txtNeedCreatedDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtNeedCreatedDate.EditValue = null;
            this._txtNeedCreatedDate.Enabled = false;
            this._txtNeedCreatedDate.Location = new System.Drawing.Point(71, 1);
            this._txtNeedCreatedDate.Margin = new System.Windows.Forms.Padding(1);
            this._txtNeedCreatedDate.Name = "_txtNeedCreatedDate";
            this._txtNeedCreatedDate.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtNeedCreatedDate.Properties.Appearance.Options.UseFont = true;
            this._txtNeedCreatedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._txtNeedCreatedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._txtNeedCreatedDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this._txtNeedCreatedDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._txtNeedCreatedDate.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this._txtNeedCreatedDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._txtNeedCreatedDate.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this._txtNeedCreatedDate.Properties.ReadOnly = true;
            this._txtNeedCreatedDate.Size = new System.Drawing.Size(276, 20);
            this._txtNeedCreatedDate.TabIndex = 3;
            this._txtNeedCreatedDate.TabStop = false;
            // 
            // _txtNeedNotes
            // 
            this._txtNeedNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtNeedNotes.Location = new System.Drawing.Point(0, 24);
            this._txtNeedNotes.Name = "_txtNeedNotes";
            this._txtNeedNotes.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtNeedNotes.Properties.Appearance.Options.UseFont = true;
            this._txtNeedNotes.Properties.ReadOnly = true;
            this._txtNeedNotes.Size = new System.Drawing.Size(350, 95);
            this._txtNeedNotes.TabIndex = 17;
            this._txtNeedNotes.EditValueChanged += new System.EventHandler(this._txtNeedNotes_EditValueChanged);
            // 
            // UcCustomerNeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel10);
            this.Name = "UcCustomerNeed";
            this.Size = new System.Drawing.Size(356, 291);
            this.tableLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gridCustomerNeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._viewCustomerNeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._repoCustomerNeedDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit6.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit6)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtNeedCreatedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtNeedCreatedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtNeedNotes.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private DevExpress.XtraGrid.GridControl _gridCustomerNeed;
        private DevExpress.XtraGrid.Views.Grid.GridView _viewCustomerNeed;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerNeedCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerNeedDescription;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerNeedEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit7;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerNeedDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit _repoCustomerNeedDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit6;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton _btnAdvancedNeed;
        private DevExpress.XtraEditors.SimpleButton _btnCancelNeedsNote;
        private DevExpress.XtraEditors.SimpleButton _btnSaveNewNeedsNotes;
        private DevExpress.XtraEditors.SimpleButton _btnSaveNeedsNotes;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel11;
        private DevExpress.XtraEditors.LabelControl labelControl45;
        private DevExpress.XtraEditors.DateEdit _txtNeedCreatedDate;
        private DevExpress.XtraEditors.MemoEdit _txtNeedNotes;
    }
}
