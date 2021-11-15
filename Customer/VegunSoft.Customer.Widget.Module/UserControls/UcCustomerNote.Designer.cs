namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Notes
{
    partial class UcCustomerNote
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcCustomerNote));
            this._tlpCustomerNotes = new System.Windows.Forms.TableLayoutPanel();
            this._gridCustomerNote = new DevExpress.XtraGrid.GridControl();
            this._viewCustomerNote = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gcCustomerNoteCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcCustomerNoteDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcCustomerNoteEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this._gcCustomerNoteDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this._repoCustomerNoteDelete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemDateEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this._btnCancelCustomerNote = new DevExpress.XtraEditors.SimpleButton();
            this._btnSaveNewCustomerNotes = new DevExpress.XtraEditors.SimpleButton();
            this._btnSaveCustomerNotes = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.labelControl43 = new DevExpress.XtraEditors.LabelControl();
            this._txtNoteCreatedDate = new DevExpress.XtraEditors.DateEdit();
            this._txtCustomerNote = new DevExpress.XtraEditors.MemoEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this._glkCategory = new DevExpress.XtraEditors.GridLookUpEdit();
            this._gvCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gcCategoryNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this._tlpCustomerNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridCustomerNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._viewCustomerNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._repoCustomerNoteDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtNoteCreatedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtNoteCreatedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtCustomerNote.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._glkCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // _tlpCustomerNotes
            // 
            this._tlpCustomerNotes.ColumnCount = 1;
            this._tlpCustomerNotes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlpCustomerNotes.Controls.Add(this._gridCustomerNote, 0, 3);
            this._tlpCustomerNotes.Controls.Add(this.panel1, 0, 2);
            this._tlpCustomerNotes.Controls.Add(this.panel3, 0, 1);
            this._tlpCustomerNotes.Controls.Add(this.panel2, 0, 0);
            this._tlpCustomerNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tlpCustomerNotes.Location = new System.Drawing.Point(0, 0);
            this._tlpCustomerNotes.Margin = new System.Windows.Forms.Padding(0);
            this._tlpCustomerNotes.Name = "_tlpCustomerNotes";
            this._tlpCustomerNotes.RowCount = 5;
            this._tlpCustomerNotes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tlpCustomerNotes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tlpCustomerNotes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tlpCustomerNotes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tlpCustomerNotes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tlpCustomerNotes.Size = new System.Drawing.Size(400, 350);
            this._tlpCustomerNotes.TabIndex = 3;
            // 
            // _gridCustomerNote
            // 
            this._gridCustomerNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gridCustomerNote.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gridLevelNode2.RelationName = "Level1";
            this._gridCustomerNote.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this._gridCustomerNote.Location = new System.Drawing.Point(0, 204);
            this._gridCustomerNote.MainView = this._viewCustomerNote;
            this._gridCustomerNote.Margin = new System.Windows.Forms.Padding(0);
            this._gridCustomerNote.Name = "_gridCustomerNote";
            this._gridCustomerNote.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit3,
            this.repositoryItemDateEdit3,
            this._repoCustomerNoteDelete});
            this._gridCustomerNote.Size = new System.Drawing.Size(400, 146);
            this._gridCustomerNote.TabIndex = 20;
            this._gridCustomerNote.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._viewCustomerNote});
            // 
            // _viewCustomerNote
            // 
            this._viewCustomerNote.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            this._viewCustomerNote.Appearance.FocusedRow.Options.UseBackColor = true;
            this._viewCustomerNote.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this._viewCustomerNote.Appearance.HeaderPanel.Options.UseFont = true;
            this._viewCustomerNote.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this._viewCustomerNote.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._viewCustomerNote.Appearance.Row.Font = new System.Drawing.Font("Verdana", 9F);
            this._viewCustomerNote.Appearance.Row.Options.UseFont = true;
            this._viewCustomerNote.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._gcCustomerNoteCreatedDate,
            this._gcCustomerNoteDescription,
            this._gcCustomerNoteEdit,
            this._gcCustomerNoteDelete});
            this._viewCustomerNote.GridControl = this._gridCustomerNote;
            this._viewCustomerNote.Name = "_viewCustomerNote";
            this._viewCustomerNote.OptionsBehavior.ReadOnly = true;
            this._viewCustomerNote.OptionsView.RowAutoHeight = true;
            this._viewCustomerNote.OptionsView.ShowDetailButtons = false;
            this._viewCustomerNote.OptionsView.ShowGroupPanel = false;
            this._viewCustomerNote.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this._gcCustomerNoteDescription, DevExpress.Data.ColumnSortOrder.Descending)});
            this._viewCustomerNote.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this._viewCustomerNote_RowClick);
            // 
            // _gcCustomerNoteCreatedDate
            // 
            this._gcCustomerNoteCreatedDate.Caption = "Ngày";
            this._gcCustomerNoteCreatedDate.FieldName = "CreatedDate";
            this._gcCustomerNoteCreatedDate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this._gcCustomerNoteCreatedDate.Name = "_gcCustomerNoteCreatedDate";
            this._gcCustomerNoteCreatedDate.OptionsColumn.AllowEdit = false;
            this._gcCustomerNoteCreatedDate.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this._gcCustomerNoteCreatedDate.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this._gcCustomerNoteCreatedDate.Visible = true;
            this._gcCustomerNoteCreatedDate.VisibleIndex = 0;
            this._gcCustomerNoteCreatedDate.Width = 120;
            // 
            // _gcCustomerNoteDescription
            // 
            this._gcCustomerNoteDescription.Caption = "Ghi chú";
            this._gcCustomerNoteDescription.FieldName = "Content";
            this._gcCustomerNoteDescription.Name = "_gcCustomerNoteDescription";
            this._gcCustomerNoteDescription.OptionsColumn.AllowEdit = false;
            this._gcCustomerNoteDescription.Visible = true;
            this._gcCustomerNoteDescription.VisibleIndex = 1;
            this._gcCustomerNoteDescription.Width = 174;
            // 
            // _gcCustomerNoteEdit
            // 
            this._gcCustomerNoteEdit.Caption = "Sửa";
            this._gcCustomerNoteEdit.ColumnEdit = this.repositoryItemHyperLinkEdit3;
            this._gcCustomerNoteEdit.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcCustomerNoteEdit.Name = "_gcCustomerNoteEdit";
            this._gcCustomerNoteEdit.Width = 34;
            // 
            // repositoryItemHyperLinkEdit3
            // 
            this.repositoryItemHyperLinkEdit3.AutoHeight = false;
            this.repositoryItemHyperLinkEdit3.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemHyperLinkEdit3.Name = "repositoryItemHyperLinkEdit3";
            // 
            // _gcCustomerNoteDelete
            // 
            this._gcCustomerNoteDelete.Caption = "Xóa";
            this._gcCustomerNoteDelete.ColumnEdit = this._repoCustomerNoteDelete;
            this._gcCustomerNoteDelete.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcCustomerNoteDelete.MaxWidth = 40;
            this._gcCustomerNoteDelete.MinWidth = 40;
            this._gcCustomerNoteDelete.Name = "_gcCustomerNoteDelete";
            this._gcCustomerNoteDelete.Visible = true;
            this._gcCustomerNoteDelete.VisibleIndex = 2;
            this._gcCustomerNoteDelete.Width = 40;
            // 
            // _repoCustomerNoteDelete
            // 
            this._repoCustomerNoteDelete.AutoHeight = false;
            this._repoCustomerNoteDelete.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._repoCustomerNoteDelete.Name = "_repoCustomerNoteDelete";
            this._repoCustomerNoteDelete.Click += new System.EventHandler(this._repoCustomerNoteDelete_Click);
            // 
            // repositoryItemDateEdit3
            // 
            this.repositoryItemDateEdit3.AutoHeight = false;
            this.repositoryItemDateEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit3.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.repositoryItemDateEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit3.EditFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.repositoryItemDateEdit3.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit3.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this.repositoryItemDateEdit3.Name = "repositoryItemDateEdit3";
            this.repositoryItemDateEdit3.NullDate = "";
            this.repositoryItemDateEdit3.NullValuePromptShowForEmptyValue = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._btnCancelCustomerNote);
            this.panel1.Controls.Add(this._btnSaveNewCustomerNotes);
            this.panel1.Controls.Add(this._btnSaveCustomerNotes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 169);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 35);
            this.panel1.TabIndex = 17;
            // 
            // _btnCancelCustomerNote
            // 
            this._btnCancelCustomerNote.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnCancelCustomerNote.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this._btnCancelCustomerNote.Appearance.Options.UseFont = true;
            this._btnCancelCustomerNote.Appearance.Options.UseForeColor = true;
            this._btnCancelCustomerNote.Image = ((System.Drawing.Image)(resources.GetObject("_btnCancelCustomerNote.Image")));
            this._btnCancelCustomerNote.Location = new System.Drawing.Point(0, 2);
            this._btnCancelCustomerNote.Margin = new System.Windows.Forms.Padding(0);
            this._btnCancelCustomerNote.Name = "_btnCancelCustomerNote";
            this._btnCancelCustomerNote.Size = new System.Drawing.Size(101, 30);
            this._btnCancelCustomerNote.TabIndex = 53;
            this._btnCancelCustomerNote.Text = "Tạo mới";
            this._btnCancelCustomerNote.Click += new System.EventHandler(this._btnCancelCustomerNote_Click);
            // 
            // _btnSaveNewCustomerNotes
            // 
            this._btnSaveNewCustomerNotes.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnSaveNewCustomerNotes.Appearance.ForeColor = System.Drawing.Color.Black;
            this._btnSaveNewCustomerNotes.Appearance.Options.UseFont = true;
            this._btnSaveNewCustomerNotes.Appearance.Options.UseForeColor = true;
            this._btnSaveNewCustomerNotes.Image = ((System.Drawing.Image)(resources.GetObject("_btnSaveNewCustomerNotes.Image")));
            this._btnSaveNewCustomerNotes.Location = new System.Drawing.Point(224, 2);
            this._btnSaveNewCustomerNotes.Margin = new System.Windows.Forms.Padding(0);
            this._btnSaveNewCustomerNotes.Name = "_btnSaveNewCustomerNotes";
            this._btnSaveNewCustomerNotes.Size = new System.Drawing.Size(121, 30);
            this._btnSaveNewCustomerNotes.TabIndex = 52;
            this._btnSaveNewCustomerNotes.Text = "Lưu mới";
            this._btnSaveNewCustomerNotes.Click += new System.EventHandler(this._btnSaveNewCustomerNotes_Click);
            // 
            // _btnSaveCustomerNotes
            // 
            this._btnSaveCustomerNotes.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnSaveCustomerNotes.Appearance.ForeColor = System.Drawing.Color.Black;
            this._btnSaveCustomerNotes.Appearance.Options.UseFont = true;
            this._btnSaveCustomerNotes.Appearance.Options.UseForeColor = true;
            this._btnSaveCustomerNotes.Image = ((System.Drawing.Image)(resources.GetObject("_btnSaveCustomerNotes.Image")));
            this._btnSaveCustomerNotes.Location = new System.Drawing.Point(102, 2);
            this._btnSaveCustomerNotes.Margin = new System.Windows.Forms.Padding(0);
            this._btnSaveCustomerNotes.Name = "_btnSaveCustomerNotes";
            this._btnSaveCustomerNotes.Size = new System.Drawing.Size(121, 30);
            this._btnSaveCustomerNotes.TabIndex = 51;
            this._btnSaveCustomerNotes.Text = "Lưu";
            this._btnSaveCustomerNotes.Click += new System.EventHandler(this._btnSaveCustomerNotes_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this._txtCustomerNote);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 23);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 146);
            this.panel3.TabIndex = 19;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.labelControl43);
            this.panel9.Controls.Add(this._txtNoteCreatedDate);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(400, 23);
            this.panel9.TabIndex = 18;
            // 
            // labelControl43
            // 
            this.labelControl43.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl43.Location = new System.Drawing.Point(5, 4);
            this.labelControl43.Name = "labelControl43";
            this.labelControl43.Size = new System.Drawing.Size(62, 14);
            this.labelControl43.TabIndex = 2;
            this.labelControl43.Text = "Ngày tạo:";
            // 
            // _txtNoteCreatedDate
            // 
            this._txtNoteCreatedDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtNoteCreatedDate.EditValue = null;
            this._txtNoteCreatedDate.Enabled = false;
            this._txtNoteCreatedDate.Location = new System.Drawing.Point(71, 1);
            this._txtNoteCreatedDate.Margin = new System.Windows.Forms.Padding(1);
            this._txtNoteCreatedDate.Name = "_txtNoteCreatedDate";
            this._txtNoteCreatedDate.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtNoteCreatedDate.Properties.Appearance.Options.UseFont = true;
            this._txtNoteCreatedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._txtNoteCreatedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._txtNoteCreatedDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this._txtNoteCreatedDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._txtNoteCreatedDate.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this._txtNoteCreatedDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._txtNoteCreatedDate.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this._txtNoteCreatedDate.Properties.ReadOnly = true;
            this._txtNoteCreatedDate.Size = new System.Drawing.Size(327, 20);
            this._txtNoteCreatedDate.TabIndex = 1;
            this._txtNoteCreatedDate.TabStop = false;
            // 
            // _txtCustomerNote
            // 
            this._txtCustomerNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtCustomerNote.Location = new System.Drawing.Point(0, 25);
            this._txtCustomerNote.Margin = new System.Windows.Forms.Padding(0);
            this._txtCustomerNote.Name = "_txtCustomerNote";
            this._txtCustomerNote.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtCustomerNote.Properties.Appearance.Options.UseFont = true;
            this._txtCustomerNote.Properties.ReadOnly = true;
            this._txtCustomerNote.Size = new System.Drawing.Size(400, 121);
            this._txtCustomerNote.TabIndex = 17;
            this._txtCustomerNote.EditValueChanged += new System.EventHandler(this._txtCustomerNote_EditValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._glkCategory);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 23);
            this.panel2.TabIndex = 21;
            // 
            // _glkCategory
            // 
            this._glkCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._glkCategory.EditValue = "";
            this._glkCategory.Location = new System.Drawing.Point(71, 1);
            this._glkCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._glkCategory.Name = "_glkCategory";
            this._glkCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this._glkCategory.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._glkCategory.Properties.Appearance.Options.UseFont = true;
            this._glkCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this._glkCategory.Properties.DisplayMember = "FullName";
            this._glkCategory.Properties.NullText = "";
            this._glkCategory.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this._glkCategory.Properties.PopupFormSize = new System.Drawing.Size(350, 200);
            this._glkCategory.Properties.ReadOnly = true;
            this._glkCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this._glkCategory.Properties.ValueMember = "Id";
            this._glkCategory.Properties.View = this._gvCategory;
            this._glkCategory.Size = new System.Drawing.Size(327, 20);
            this._glkCategory.TabIndex = 8;
            // 
            // _gvCategory
            // 
            this._gvCategory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._gcCategoryNo,
            this._gcCategoryName});
            this._gvCategory.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this._gvCategory.Name = "_gvCategory";
            this._gvCategory.OptionsSelection.EnableAppearanceFocusedCell = false;
            this._gvCategory.OptionsView.ShowAutoFilterRow = true;
            this._gvCategory.OptionsView.ShowGroupPanel = false;
            // 
            // _gcCategoryNo
            // 
            this._gcCategoryNo.Caption = "Id";
            this._gcCategoryNo.FieldName = "Id";
            this._gcCategoryNo.Name = "_gcCategoryNo";
            this._gcCategoryNo.Visible = true;
            this._gcCategoryNo.VisibleIndex = 0;
            this._gcCategoryNo.Width = 50;
            // 
            // _gcCategoryName
            // 
            this._gcCategoryName.Caption = "Tên";
            this._gcCategoryName.FieldName = "FullName";
            this._gcCategoryName.Name = "_gcCategoryName";
            this._gcCategoryName.Visible = true;
            this._gcCategoryName.VisibleIndex = 1;
            this._gcCategoryName.Width = 150;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(5, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Loại:";
            // 
            // UcCustomerNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._tlpCustomerNotes);
            this.Name = "UcCustomerNote";
            this.Size = new System.Drawing.Size(400, 350);
            this._tlpCustomerNotes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gridCustomerNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._viewCustomerNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._repoCustomerNoteDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtNoteCreatedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtNoteCreatedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtCustomerNote.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._glkCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gvCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tlpCustomerNotes;
        private DevExpress.XtraGrid.GridControl _gridCustomerNote;
        private DevExpress.XtraGrid.Views.Grid.GridView _viewCustomerNote;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerNoteCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerNoteDescription;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerNoteEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCustomerNoteDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit _repoCustomerNoteDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit3;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton _btnCancelCustomerNote;
        private DevExpress.XtraEditors.SimpleButton _btnSaveNewCustomerNotes;
        private DevExpress.XtraEditors.SimpleButton _btnSaveCustomerNotes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private DevExpress.XtraEditors.LabelControl labelControl43;
        private DevExpress.XtraEditors.DateEdit _txtNoteCreatedDate;
        private DevExpress.XtraEditors.MemoEdit _txtCustomerNote;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit _glkCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView _gvCategory;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCategoryNo;
        private DevExpress.XtraGrid.Columns.GridColumn _gcCategoryName;
    }
}
