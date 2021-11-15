namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Notes
{
    partial class UcCustomerServiceNote
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
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this._gridOrderPrepare = new DevExpress.XtraGrid.GridControl();
            this._viewOrderPrepare = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gcOrderPrepareCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcOrderPrepareDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcOrderPrepareEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this._gcOrderPrepareDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this._repoOrderPrepareDelete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemDateEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this._btnCancelNextNote = new DevExpress.XtraEditors.SimpleButton();
            this._btnSaveNewNextNotes = new DevExpress.XtraEditors.SimpleButton();
            this._btnSaveNextNotes = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.labelControl44 = new DevExpress.XtraEditors.LabelControl();
            this._txtPrepareCreatedDate = new DevExpress.XtraEditors.DateEdit();
            this._txtNextNote = new DevExpress.XtraEditors.MemoEdit();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridOrderPrepare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._viewOrderPrepare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._repoOrderPrepareDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit5.CalendarTimeProperties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtPrepareCreatedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtPrepareCreatedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtNextNote.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this._gridOrderPrepare, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(356, 291);
            this.tableLayoutPanel9.TabIndex = 4;
            // 
            // _gridOrderPrepare
            // 
            this._gridOrderPrepare.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gridOrderPrepare.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gridLevelNode1.RelationName = "Level1";
            this._gridOrderPrepare.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this._gridOrderPrepare.Location = new System.Drawing.Point(4, 169);
            this._gridOrderPrepare.MainView = this._viewOrderPrepare;
            this._gridOrderPrepare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._gridOrderPrepare.Name = "_gridOrderPrepare";
            this._gridOrderPrepare.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit5,
            this.repositoryItemDateEdit5,
            this._repoOrderPrepareDelete});
            this._gridOrderPrepare.Size = new System.Drawing.Size(348, 119);
            this._gridOrderPrepare.TabIndex = 21;
            this._gridOrderPrepare.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._viewOrderPrepare});
            // 
            // _viewOrderPrepare
            // 
            this._viewOrderPrepare.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            this._viewOrderPrepare.Appearance.FocusedRow.Options.UseBackColor = true;
            this._viewOrderPrepare.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this._viewOrderPrepare.Appearance.HeaderPanel.Options.UseFont = true;
            this._viewOrderPrepare.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this._viewOrderPrepare.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._viewOrderPrepare.Appearance.Row.Font = new System.Drawing.Font("Verdana", 9F);
            this._viewOrderPrepare.Appearance.Row.Options.UseFont = true;
            this._viewOrderPrepare.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._gcOrderPrepareCreatedDate,
            this._gcOrderPrepareDescription,
            this._gcOrderPrepareEdit,
            this._gcOrderPrepareDelete});
            this._viewOrderPrepare.GridControl = this._gridOrderPrepare;
            this._viewOrderPrepare.Name = "_viewOrderPrepare";
            this._viewOrderPrepare.OptionsBehavior.ReadOnly = true;
            this._viewOrderPrepare.OptionsView.ColumnAutoWidth = false;
            this._viewOrderPrepare.OptionsView.RowAutoHeight = true;
            this._viewOrderPrepare.OptionsView.ShowDetailButtons = false;
            this._viewOrderPrepare.OptionsView.ShowGroupPanel = false;
            this._viewOrderPrepare.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this._gcOrderPrepareDescription, DevExpress.Data.ColumnSortOrder.Descending)});
            this._viewOrderPrepare.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this._viewOrderPrepare_RowClick);
            // 
            // _gcOrderPrepareCreatedDate
            // 
            this._gcOrderPrepareCreatedDate.Caption = "Ngày";
            this._gcOrderPrepareCreatedDate.FieldName = "CreatedDate";
            this._gcOrderPrepareCreatedDate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this._gcOrderPrepareCreatedDate.Name = "_gcOrderPrepareCreatedDate";
            this._gcOrderPrepareCreatedDate.OptionsColumn.AllowEdit = false;
            this._gcOrderPrepareCreatedDate.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this._gcOrderPrepareCreatedDate.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this._gcOrderPrepareCreatedDate.Visible = true;
            this._gcOrderPrepareCreatedDate.VisibleIndex = 0;
            this._gcOrderPrepareCreatedDate.Width = 120;
            // 
            // _gcOrderPrepareDescription
            // 
            this._gcOrderPrepareDescription.Caption = "Ghi chú";
            this._gcOrderPrepareDescription.FieldName = "Content";
            this._gcOrderPrepareDescription.Name = "_gcOrderPrepareDescription";
            this._gcOrderPrepareDescription.OptionsColumn.AllowEdit = false;
            this._gcOrderPrepareDescription.Visible = true;
            this._gcOrderPrepareDescription.VisibleIndex = 1;
            this._gcOrderPrepareDescription.Width = 184;
            // 
            // _gcOrderPrepareEdit
            // 
            this._gcOrderPrepareEdit.Caption = "Sửa";
            this._gcOrderPrepareEdit.ColumnEdit = this.repositoryItemHyperLinkEdit5;
            this._gcOrderPrepareEdit.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcOrderPrepareEdit.Name = "_gcOrderPrepareEdit";
            this._gcOrderPrepareEdit.Width = 34;
            // 
            // repositoryItemHyperLinkEdit5
            // 
            this.repositoryItemHyperLinkEdit5.AutoHeight = false;
            this.repositoryItemHyperLinkEdit5.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemHyperLinkEdit5.Name = "repositoryItemHyperLinkEdit5";
            // 
            // _gcOrderPrepareDelete
            // 
            this._gcOrderPrepareDelete.Caption = "Xóa";
            this._gcOrderPrepareDelete.ColumnEdit = this._repoOrderPrepareDelete;
            this._gcOrderPrepareDelete.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcOrderPrepareDelete.Name = "_gcOrderPrepareDelete";
            this._gcOrderPrepareDelete.Visible = true;
            this._gcOrderPrepareDelete.VisibleIndex = 2;
            this._gcOrderPrepareDelete.Width = 32;
            // 
            // _repoOrderPrepareDelete
            // 
            this._repoOrderPrepareDelete.AutoHeight = false;
            this._repoOrderPrepareDelete.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._repoOrderPrepareDelete.Name = "_repoOrderPrepareDelete";
            this._repoOrderPrepareDelete.Click += new System.EventHandler(this._repoOrderPrepareDelete_Click);
            // 
            // repositoryItemDateEdit5
            // 
            this.repositoryItemDateEdit5.AutoHeight = false;
            this.repositoryItemDateEdit5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit5.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit5.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.repositoryItemDateEdit5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit5.EditFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.repositoryItemDateEdit5.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit5.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this.repositoryItemDateEdit5.Name = "repositoryItemDateEdit5";
            this.repositoryItemDateEdit5.NullDate = "";
            this.repositoryItemDateEdit5.NullValuePromptShowForEmptyValue = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._btnCancelNextNote);
            this.panel2.Controls.Add(this._btnSaveNewNextNotes);
            this.panel2.Controls.Add(this._btnSaveNextNotes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 127);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 37);
            this.panel2.TabIndex = 17;
            // 
            // _btnCancelNextNote
            // 
            this._btnCancelNextNote.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnCancelNextNote.Appearance.ForeColor = System.Drawing.Color.Black;
            this._btnCancelNextNote.Appearance.Options.UseFont = true;
            this._btnCancelNextNote.Appearance.Options.UseForeColor = true;
            this._btnCancelNextNote.Location = new System.Drawing.Point(0, 2);
            this._btnCancelNextNote.Margin = new System.Windows.Forms.Padding(0);
            this._btnCancelNextNote.Name = "_btnCancelNextNote";
            this._btnCancelNextNote.Size = new System.Drawing.Size(99, 35);
            this._btnCancelNextNote.TabIndex = 53;
            this._btnCancelNextNote.Text = "Hủy";
            this._btnCancelNextNote.Click += new System.EventHandler(this._btnCancelNextNote_Click);
            // 
            // _btnSaveNewNextNotes
            // 
            this._btnSaveNewNextNotes.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnSaveNewNextNotes.Appearance.ForeColor = System.Drawing.Color.Black;
            this._btnSaveNewNextNotes.Appearance.Options.UseFont = true;
            this._btnSaveNewNextNotes.Appearance.Options.UseForeColor = true;
            this._btnSaveNewNextNotes.Location = new System.Drawing.Point(226, 2);
            this._btnSaveNewNextNotes.Margin = new System.Windows.Forms.Padding(0);
            this._btnSaveNewNextNotes.Name = "_btnSaveNewNextNotes";
            this._btnSaveNewNextNotes.Size = new System.Drawing.Size(121, 35);
            this._btnSaveNewNextNotes.TabIndex = 52;
            this._btnSaveNewNextNotes.Text = "Lưu mới";
            this._btnSaveNewNextNotes.Click += new System.EventHandler(this._btnSaveNewNextNotes_Click);
            // 
            // _btnSaveNextNotes
            // 
            this._btnSaveNextNotes.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnSaveNextNotes.Appearance.ForeColor = System.Drawing.Color.Black;
            this._btnSaveNextNotes.Appearance.Options.UseFont = true;
            this._btnSaveNextNotes.Appearance.Options.UseForeColor = true;
            this._btnSaveNextNotes.Location = new System.Drawing.Point(102, 2);
            this._btnSaveNextNotes.Margin = new System.Windows.Forms.Padding(0);
            this._btnSaveNextNotes.Name = "_btnSaveNextNotes";
            this._btnSaveNextNotes.Size = new System.Drawing.Size(121, 35);
            this._btnSaveNextNotes.TabIndex = 51;
            this._btnSaveNextNotes.Text = "Lưu";
            this._btnSaveNextNotes.Click += new System.EventHandler(this._btnSaveNextNotes_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this._txtNextNote);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 119);
            this.panel4.TabIndex = 19;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.labelControl44);
            this.panel10.Controls.Add(this._txtPrepareCreatedDate);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(350, 23);
            this.panel10.TabIndex = 19;
            // 
            // labelControl44
            // 
            this.labelControl44.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl44.Location = new System.Drawing.Point(5, 4);
            this.labelControl44.Name = "labelControl44";
            this.labelControl44.Size = new System.Drawing.Size(62, 14);
            this.labelControl44.TabIndex = 4;
            this.labelControl44.Text = "Ngày tạo:";
            // 
            // _txtPrepareCreatedDate
            // 
            this._txtPrepareCreatedDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtPrepareCreatedDate.EditValue = null;
            this._txtPrepareCreatedDate.Enabled = false;
            this._txtPrepareCreatedDate.Location = new System.Drawing.Point(71, 1);
            this._txtPrepareCreatedDate.Margin = new System.Windows.Forms.Padding(1);
            this._txtPrepareCreatedDate.Name = "_txtPrepareCreatedDate";
            this._txtPrepareCreatedDate.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtPrepareCreatedDate.Properties.Appearance.Options.UseFont = true;
            this._txtPrepareCreatedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._txtPrepareCreatedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._txtPrepareCreatedDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this._txtPrepareCreatedDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._txtPrepareCreatedDate.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this._txtPrepareCreatedDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._txtPrepareCreatedDate.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this._txtPrepareCreatedDate.Properties.ReadOnly = true;
            this._txtPrepareCreatedDate.Size = new System.Drawing.Size(276, 20);
            this._txtPrepareCreatedDate.TabIndex = 3;
            this._txtPrepareCreatedDate.TabStop = false;
            // 
            // _txtNextNote
            // 
            this._txtNextNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtNextNote.Location = new System.Drawing.Point(0, 24);
            this._txtNextNote.Name = "_txtNextNote";
            this._txtNextNote.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtNextNote.Properties.Appearance.Options.UseFont = true;
            this._txtNextNote.Properties.ReadOnly = true;
            this._txtNextNote.Size = new System.Drawing.Size(350, 95);
            this._txtNextNote.TabIndex = 17;
            this._txtNextNote.EditValueChanged += new System.EventHandler(this._txtNextNote_EditValueChanged);
            // 
            // UcCustomerServiceNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel9);
            this.Name = "UcCustomerServiceNote";
            this.Size = new System.Drawing.Size(356, 291);
            this.tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gridOrderPrepare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._viewOrderPrepare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._repoOrderPrepareDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit5.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtPrepareCreatedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtPrepareCreatedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtNextNote.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private DevExpress.XtraGrid.GridControl _gridOrderPrepare;
        private DevExpress.XtraGrid.Views.Grid.GridView _viewOrderPrepare;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderPrepareCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderPrepareDescription;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderPrepareEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit5;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderPrepareDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit _repoOrderPrepareDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit5;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton _btnCancelNextNote;
        private DevExpress.XtraEditors.SimpleButton _btnSaveNewNextNotes;
        private DevExpress.XtraEditors.SimpleButton _btnSaveNextNotes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel10;
        private DevExpress.XtraEditors.LabelControl labelControl44;
        private DevExpress.XtraEditors.DateEdit _txtPrepareCreatedDate;
        private DevExpress.XtraEditors.MemoEdit _txtNextNote;
    }
}
