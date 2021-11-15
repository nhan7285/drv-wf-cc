namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    partial class UcOrderItemSteps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcOrderItemSteps));
            this._grid = new DevExpress.XtraGrid.GridControl();
            this._view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gcConfigName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._riMemoEditName = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this._gcConfigIsEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcConfigNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcConfigAddContent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lnkThemDT = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this._gcConfigAddFinishContent = new DevExpress.XtraGrid.Columns.GridColumn();
            this._lnkAddFinishContent = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this._gcIsLock = new DevExpress.XtraGrid.Columns.GridColumn();
            this._ricLock = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._pnSave = new DevExpress.XtraEditors.PanelControl();
            this._btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._riMemoEditName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkThemDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lnkAddFinishContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ricLock)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnSave)).BeginInit();
            this._pnSave.SuspendLayout();
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
            this._grid.Margin = new System.Windows.Forms.Padding(0);
            this._grid.Name = "_grid";
            this._grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lnkThemDT,
            this._lnkAddFinishContent,
            this._ricLock,
            this._riMemoEditName});
            this._grid.Size = new System.Drawing.Size(444, 424);
            this._grid.TabIndex = 8;
            this._grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._view});
            // 
            // _view
            // 
            this._view.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._view.Appearance.HeaderPanel.Options.UseFont = true;
            this._view.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this._view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._view.Appearance.Row.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._view.Appearance.Row.Options.UseFont = true;
            this._view.ColumnPanelRowHeight = 30;
            this._view.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._gcConfigName,
            this._gcConfigIsEnd,
            this._gcConfigNo,
            this._gcConfigAddContent,
            this._gcConfigAddFinishContent,
            this._gcIsLock});
            this._view.GridControl = this._grid;
            this._view.IndicatorWidth = 15;
            this._view.Name = "_view";
            this._view.OptionsView.RowAutoHeight = true;
            this._view.OptionsView.ShowAutoFilterRow = true;
            this._view.OptionsView.ShowGroupPanel = false;
            this._view.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this._gcConfigNo, DevExpress.Data.ColumnSortOrder.Ascending)});
            this._view.ViewCaptionHeight = 30;
            // 
            // _gcConfigName
            // 
            this._gcConfigName.Caption = "Tên bước";
            this._gcConfigName.ColumnEdit = this._riMemoEditName;
            this._gcConfigName.FieldName = "TEN_DMNOIDUNGDIEUTRI";
            this._gcConfigName.Name = "_gcConfigName";
            this._gcConfigName.OptionsColumn.AllowEdit = false;
            this._gcConfigName.Visible = true;
            this._gcConfigName.VisibleIndex = 1;
            this._gcConfigName.Width = 262;
            // 
            // _riMemoEditName
            // 
            this._riMemoEditName.Name = "_riMemoEditName";
            // 
            // _gcConfigIsEnd
            // 
            this._gcConfigIsEnd.Caption = "X";
            this._gcConfigIsEnd.FieldName = "KETTHUC_DIEUTRI";
            this._gcConfigIsEnd.MaxWidth = 25;
            this._gcConfigIsEnd.MinWidth = 25;
            this._gcConfigIsEnd.Name = "_gcConfigIsEnd";
            this._gcConfigIsEnd.OptionsColumn.AllowEdit = false;
            this._gcConfigIsEnd.ToolTip = "Xong / Kết thúc điều trị";
            this._gcConfigIsEnd.Visible = true;
            this._gcConfigIsEnd.VisibleIndex = 2;
            this._gcConfigIsEnd.Width = 25;
            // 
            // _gcConfigNo
            // 
            this._gcConfigNo.Caption = "No";
            this._gcConfigNo.FieldName = "STT";
            this._gcConfigNo.MaxWidth = 30;
            this._gcConfigNo.MinWidth = 30;
            this._gcConfigNo.Name = "_gcConfigNo";
            this._gcConfigNo.OptionsColumn.AllowEdit = false;
            this._gcConfigNo.Visible = true;
            this._gcConfigNo.VisibleIndex = 0;
            this._gcConfigNo.Width = 30;
            // 
            // _gcConfigAddContent
            // 
            this._gcConfigAddContent.Caption = "TH";
            this._gcConfigAddContent.ColumnEdit = this.lnkThemDT;
            this._gcConfigAddContent.MaxWidth = 30;
            this._gcConfigAddContent.MinWidth = 30;
            this._gcConfigAddContent.Name = "_gcConfigAddContent";
            this._gcConfigAddContent.ToolTip = "Thêm tiến hành điều trị";
            this._gcConfigAddContent.Visible = true;
            this._gcConfigAddContent.VisibleIndex = 3;
            this._gcConfigAddContent.Width = 30;
            // 
            // lnkThemDT
            // 
            this.lnkThemDT.AutoHeight = false;
            this.lnkThemDT.Image = ((System.Drawing.Image)(resources.GetObject("lnkThemDT.Image")));
            this.lnkThemDT.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lnkThemDT.Name = "lnkThemDT";
            this.lnkThemDT.Click += new System.EventHandler(this.lnkThemDT_Click);
            // 
            // _gcConfigAddFinishContent
            // 
            this._gcConfigAddFinishContent.Caption = "HT";
            this._gcConfigAddFinishContent.ColumnEdit = this._lnkAddFinishContent;
            this._gcConfigAddFinishContent.MaxWidth = 30;
            this._gcConfigAddFinishContent.MinWidth = 30;
            this._gcConfigAddFinishContent.Name = "_gcConfigAddFinishContent";
            this._gcConfigAddFinishContent.ToolTip = "Thêm điều trị (hoàn thành)";
            this._gcConfigAddFinishContent.Visible = true;
            this._gcConfigAddFinishContent.VisibleIndex = 4;
            this._gcConfigAddFinishContent.Width = 30;
            // 
            // _lnkAddFinishContent
            // 
            this._lnkAddFinishContent.AutoHeight = false;
            this._lnkAddFinishContent.Image = ((System.Drawing.Image)(resources.GetObject("_lnkAddFinishContent.Image")));
            this._lnkAddFinishContent.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._lnkAddFinishContent.Name = "_lnkAddFinishContent";
            this._lnkAddFinishContent.Click += new System.EventHandler(this._lnkAddFinishContent_Click);
            // 
            // _gcIsLock
            // 
            this._gcIsLock.Caption = "KB";
            this._gcIsLock.ColumnEdit = this._ricLock;
            this._gcIsLock.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcIsLock.MaxWidth = 30;
            this._gcIsLock.MinWidth = 30;
            this._gcIsLock.Name = "_gcIsLock";
            this._gcIsLock.ToolTip = "Khóa bước";
            this._gcIsLock.Visible = true;
            this._gcIsLock.VisibleIndex = 5;
            this._gcIsLock.Width = 30;
            // 
            // _ricLock
            // 
            this._ricLock.AutoHeight = false;
            this._ricLock.Name = "_ricLock";
            this._ricLock.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this._ricLock_EditValueChanging);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._grid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._pnSave, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(444, 464);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // _pnSave
            // 
            this._pnSave.Controls.Add(this._btnSave);
            this._pnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnSave.Location = new System.Drawing.Point(3, 427);
            this._pnSave.Name = "_pnSave";
            this._pnSave.Size = new System.Drawing.Size(438, 34);
            this._pnSave.TabIndex = 9;
            // 
            // _btnSave
            // 
            this._btnSave.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnSave.Appearance.Options.UseFont = true;
            this._btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnSave.ImageOptions.Image")));
            this._btnSave.ImageOptions.ImageIndex = 1;
            this._btnSave.Location = new System.Drawing.Point(2, 2);
            this._btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this._btnSave.Size = new System.Drawing.Size(434, 30);
            this._btnSave.TabIndex = 3;
            this._btnSave.Text = "Lưu";
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // UcOrderItemSteps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UcOrderItemSteps";
            this.Size = new System.Drawing.Size(444, 464);
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._riMemoEditName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkThemDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lnkAddFinishContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ricLock)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnSave)).EndInit();
            this._pnSave.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl _grid;
        private DevExpress.XtraGrid.Views.Grid.GridView _view;
        private DevExpress.XtraGrid.Columns.GridColumn _gcConfigName;
        private DevExpress.XtraGrid.Columns.GridColumn _gcConfigIsEnd;
        private DevExpress.XtraGrid.Columns.GridColumn _gcConfigNo;
        private DevExpress.XtraGrid.Columns.GridColumn _gcConfigAddContent;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit lnkThemDT;
        private DevExpress.XtraGrid.Columns.GridColumn _gcConfigAddFinishContent;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit _lnkAddFinishContent;
        private DevExpress.XtraGrid.Columns.GridColumn _gcIsLock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl _pnSave;
        private DevExpress.XtraEditors.SimpleButton _btnSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit _ricLock;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit _riMemoEditName;
    }
}
