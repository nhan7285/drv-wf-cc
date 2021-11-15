using VegunSoft.Acc.Editor.Dev.Acc;
using VegunSoft.Layer.EValue.App;
using VegunSoft.Layer.UcControl.Any.Provider.Boxes.GridLookup;
using VegunSoft.Order.Editor.Dev.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    partial class UcOrderItemLabos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcOrderItemLabos));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._grid = new DevExpress.XtraGrid.GridControl();
            this._view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gcLaboId = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcLaboCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcLaboMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcLaboDoctorUserFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcLaboGoal = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcLaboColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcLaboTeeth = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcLaboAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcLaboRequestDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this._gcLaboResponseDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcLaboUsingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcLaboWarrantyCard = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcLaboWarrantyYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcLaboPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this._gcLaboTotalMoney = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcLaboAssistantFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcLaboNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcLaboStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcLaboOrderId = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcLaboOrderItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcLaboOrderItemStepContent = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcLaboRootFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcLaboFeeFinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcLaboEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lnkSuaDatLabo = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this._gcLaboDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lnkXoaDatLabo = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this._rCheckSelect = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this._cbbAutoPrintMode = new DevExpress.XtraEditors.LookUpEdit();
            this._lblUnitPrice = new DevExpress.XtraEditors.LabelControl();
            this._btnSaveNew = new DevExpress.XtraEditors.SimpleButton();
            this._cbAutoPrint = new DevExpress.XtraEditors.CheckEdit();
            this._btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this._btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._glkProvider = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView10 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn55 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.glkDMVatlieu = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView11 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn56 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtMauSu = new DevExpress.XtraEditors.TextEdit();
            this._calcAmount = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.glkTrangThai = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView12 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gcLaboName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this._cbbSelectLaboCreatorDoctor = new VegunSoft.Acc.Editor.Dev.Acc.SBoxUserAccount();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.dtNamBH = new DevExpress.XtraEditors.DateEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtTheBH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayHen = new DevExpress.XtraEditors.DateEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayGiao = new DevExpress.XtraEditors.DateEdit();
            this.labelControl39 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayDat = new DevExpress.XtraEditors.DateEdit();
            this.labelControl41 = new DevExpress.XtraEditors.LabelControl();
            this._cbbSelectLaboAssistant = new VegunSoft.Acc.Editor.Dev.Acc.SBoxUserAccount();
            this.labelControl42 = new DevExpress.XtraEditors.LabelControl();
            this._cbbLaboPhanLoai = new DevExpress.XtraEditors.LookUpEdit();
            this._lblNote = new DevExpress.XtraEditors.LabelControl();
            this._txtNotes = new DevExpress.XtraEditors.MemoEdit();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._btnLaboSelectMultiTeeth = new DevExpress.XtraEditors.SimpleButton();
            this._cbbLaboRang = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView17 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn102 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this._cbbSelectOrderItem = new VegunSoft.Order.Editor.Dev.Business.SBoxOrderItem();
            this._glkOrderItemStep = new DevExpress.XtraEditors.GridLookUpEdit();
            this._viewOrderItemStep = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gcStepNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcStepDoctorFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcStepAssistantFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcStepContent = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcStepId = new DevExpress.XtraGrid.Columns.GridColumn();
            this._tblPrices = new System.Windows.Forms.TableLayoutPanel();
            this._calcEndFee = new DevExpress.XtraEditors.CalcEdit();
            this._calcStartFee = new DevExpress.XtraEditors.CalcEdit();
            this._lblPrices = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this._btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this._calcUnitPrice = new DevExpress.XtraEditors.CalcEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkSuaDatLabo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkXoaDatLabo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._rCheckSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cbbAutoPrintMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbAutoPrint.Properties)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._glkProvider.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkDMVatlieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMauSu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._calcAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbSelectLaboCreatorDoctor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNamBH.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNamBH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTheBH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayHen.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayHen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayGiao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayGiao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayDat.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayDat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbSelectLaboAssistant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbLaboPhanLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtNotes.Properties)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cbbLaboRang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbSelectOrderItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._glkOrderItemStep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._viewOrderItemStep)).BeginInit();
            this._tblPrices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._calcEndFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._calcStartFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._calcUnitPrice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._grid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _grid
            // 
            this._grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gridLevelNode1.RelationName = "Level1";
            this._grid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this._grid.Location = new System.Drawing.Point(4, 239);
            this._grid.MainView = this._view;
            this._grid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._grid.Name = "_grid";
            this._grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lnkSuaDatLabo,
            this.repositoryItemDateEdit1,
            this.lnkXoaDatLabo,
            this.repositoryItemCalcEdit1,
            this._rCheckSelect});
            this._grid.Size = new System.Drawing.Size(1016, 358);
            this._grid.TabIndex = 15;
            this._grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._view});
            // 
            // _view
            // 
            this._view.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this._view.Appearance.FocusedRow.Options.UseBackColor = true;
            this._view.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this._view.Appearance.HeaderPanel.Options.UseFont = true;
            this._view.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this._view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._view.Appearance.Row.Font = new System.Drawing.Font("Verdana", 9F);
            this._view.Appearance.Row.Options.UseFont = true;
            this._view.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._gcLaboId,
            this._gcLaboCategoryName,
            this._gcLaboMaterialName,
            this._gcLaboDoctorUserFullName,
            this._gcLaboGoal,
            this._gcLaboColor,
            this._gcLaboTeeth,
            this._gcLaboAmount,
            this._gcLaboRequestDate,
            this._gcLaboResponseDate,
            this._gcLaboUsingDate,
            this._gcLaboWarrantyCard,
            this._gcLaboWarrantyYear,
            this._gcLaboPrice,
            this._gcLaboTotalMoney,
            this._gcLaboAssistantFullName,
            this._gcLaboNote,
            this._gcLaboStatus,
            this._gcLaboOrderId,
            this._gcLaboOrderItemName,
            this._gcLaboOrderItemStepContent,
            this._gcLaboRootFee,
            this._gcLaboFeeFinal,
            this._gcLaboEdit,
            this._gcLaboDelete});
            this._view.DetailHeight = 182;
            this._view.FixedLineWidth = 1;
            this._view.GridControl = this._grid;
            this._view.GroupCount = 2;
            this._view.LevelIndent = 0;
            this._view.Name = "_view";
            this._view.OptionsBehavior.AutoExpandAllGroups = true;
            this._view.OptionsSelection.CheckBoxSelectorColumnWidth = 40;
            this._view.OptionsSelection.MultiSelect = true;
            this._view.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this._view.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this._view.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.True;
            this._view.OptionsView.RowAutoHeight = true;
            this._view.OptionsView.ShowAutoFilterRow = true;
            this._view.OptionsView.ShowGroupPanel = false;
            this._view.PreviewIndent = 0;
            this._view.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this._gcLaboOrderId, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this._gcLaboOrderItemName, DevExpress.Data.ColumnSortOrder.Ascending)});
            this._view.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.viewDanhSachDatLabo_FocusedRowChanged);
            // 
            // _gcLaboId
            // 
            this._gcLaboId.Caption = "ID";
            this._gcLaboId.FieldName = "ID";
            this._gcLaboId.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this._gcLaboId.MinWidth = 10;
            this._gcLaboId.Name = "_gcLaboId";
            this._gcLaboId.OptionsColumn.AllowEdit = false;
            this._gcLaboId.OptionsColumn.ReadOnly = true;
            this._gcLaboId.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this._gcLaboId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this._gcLaboId.Visible = true;
            this._gcLaboId.VisibleIndex = 0;
            this._gcLaboId.Width = 44;
            // 
            // _gcLaboCategoryName
            // 
            this._gcLaboCategoryName.Caption = "Labo";
            this._gcLaboCategoryName.FieldName = "TEN_DMLABO";
            this._gcLaboCategoryName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this._gcLaboCategoryName.MinWidth = 10;
            this._gcLaboCategoryName.Name = "_gcLaboCategoryName";
            this._gcLaboCategoryName.OptionsColumn.ReadOnly = true;
            this._gcLaboCategoryName.Visible = true;
            this._gcLaboCategoryName.VisibleIndex = 2;
            this._gcLaboCategoryName.Width = 73;
            // 
            // _gcLaboMaterialName
            // 
            this._gcLaboMaterialName.Caption = "Vật liệu";
            this._gcLaboMaterialName.FieldName = "TEN_DMVATLIEU";
            this._gcLaboMaterialName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this._gcLaboMaterialName.MinWidth = 10;
            this._gcLaboMaterialName.Name = "_gcLaboMaterialName";
            this._gcLaboMaterialName.OptionsColumn.ReadOnly = true;
            this._gcLaboMaterialName.Visible = true;
            this._gcLaboMaterialName.VisibleIndex = 3;
            this._gcLaboMaterialName.Width = 90;
            // 
            // _gcLaboDoctorUserFullName
            // 
            this._gcLaboDoctorUserFullName.Caption = "Bác sĩ";
            this._gcLaboDoctorUserFullName.FieldName = "HOTEN_TAIKHOAN";
            this._gcLaboDoctorUserFullName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this._gcLaboDoctorUserFullName.MinWidth = 10;
            this._gcLaboDoctorUserFullName.Name = "_gcLaboDoctorUserFullName";
            this._gcLaboDoctorUserFullName.OptionsColumn.ReadOnly = true;
            this._gcLaboDoctorUserFullName.Visible = true;
            this._gcLaboDoctorUserFullName.VisibleIndex = 1;
            this._gcLaboDoctorUserFullName.Width = 72;
            // 
            // _gcLaboGoal
            // 
            this._gcLaboGoal.Caption = "Mục đích";
            this._gcLaboGoal.FieldName = "BookingTypeName";
            this._gcLaboGoal.MinWidth = 10;
            this._gcLaboGoal.Name = "_gcLaboGoal";
            this._gcLaboGoal.OptionsColumn.ReadOnly = true;
            this._gcLaboGoal.Visible = true;
            this._gcLaboGoal.VisibleIndex = 4;
            this._gcLaboGoal.Width = 42;
            // 
            // _gcLaboColor
            // 
            this._gcLaboColor.Caption = "Màu sứ";
            this._gcLaboColor.FieldName = "MAUSU";
            this._gcLaboColor.MinWidth = 10;
            this._gcLaboColor.Name = "_gcLaboColor";
            this._gcLaboColor.OptionsColumn.ReadOnly = true;
            this._gcLaboColor.Visible = true;
            this._gcLaboColor.VisibleIndex = 6;
            this._gcLaboColor.Width = 31;
            // 
            // _gcLaboTeeth
            // 
            this._gcLaboTeeth.Caption = "Răng";
            this._gcLaboTeeth.FieldName = "RANG";
            this._gcLaboTeeth.MinWidth = 10;
            this._gcLaboTeeth.Name = "_gcLaboTeeth";
            this._gcLaboTeeth.OptionsColumn.ReadOnly = true;
            this._gcLaboTeeth.Visible = true;
            this._gcLaboTeeth.VisibleIndex = 5;
            this._gcLaboTeeth.Width = 48;
            // 
            // _gcLaboAmount
            // 
            this._gcLaboAmount.Caption = "SL";
            this._gcLaboAmount.DisplayFormat.FormatString = "n0";
            this._gcLaboAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._gcLaboAmount.FieldName = "SOLUONG";
            this._gcLaboAmount.MinWidth = 10;
            this._gcLaboAmount.Name = "_gcLaboAmount";
            this._gcLaboAmount.OptionsColumn.ReadOnly = true;
            this._gcLaboAmount.Visible = true;
            this._gcLaboAmount.VisibleIndex = 7;
            this._gcLaboAmount.Width = 23;
            // 
            // _gcLaboRequestDate
            // 
            this._gcLaboRequestDate.Caption = "Ngày đặt";
            this._gcLaboRequestDate.ColumnEdit = this.repositoryItemDateEdit1;
            this._gcLaboRequestDate.FieldName = "NGAYDAT";
            this._gcLaboRequestDate.MinWidth = 10;
            this._gcLaboRequestDate.Name = "_gcLaboRequestDate";
            this._gcLaboRequestDate.OptionsColumn.ReadOnly = true;
            this._gcLaboRequestDate.Visible = true;
            this._gcLaboRequestDate.VisibleIndex = 8;
            this._gcLaboRequestDate.Width = 56;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Mask.EditMask = "dd/MM/yyyy HH:mm";
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.NullDate = "";
            // 
            // _gcLaboResponseDate
            // 
            this._gcLaboResponseDate.Caption = "Ngày giao";
            this._gcLaboResponseDate.ColumnEdit = this.repositoryItemDateEdit1;
            this._gcLaboResponseDate.FieldName = "NGAYGIAO";
            this._gcLaboResponseDate.MinWidth = 10;
            this._gcLaboResponseDate.Name = "_gcLaboResponseDate";
            this._gcLaboResponseDate.OptionsColumn.ReadOnly = true;
            this._gcLaboResponseDate.Visible = true;
            this._gcLaboResponseDate.VisibleIndex = 9;
            this._gcLaboResponseDate.Width = 56;
            // 
            // _gcLaboUsingDate
            // 
            this._gcLaboUsingDate.Caption = "Ngày hẹn BN";
            this._gcLaboUsingDate.ColumnEdit = this.repositoryItemDateEdit1;
            this._gcLaboUsingDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this._gcLaboUsingDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._gcLaboUsingDate.FieldName = "NGAYHEN_BN";
            this._gcLaboUsingDate.MinWidth = 10;
            this._gcLaboUsingDate.Name = "_gcLaboUsingDate";
            this._gcLaboUsingDate.OptionsColumn.AllowEdit = false;
            this._gcLaboUsingDate.OptionsColumn.ReadOnly = true;
            this._gcLaboUsingDate.Visible = true;
            this._gcLaboUsingDate.VisibleIndex = 10;
            this._gcLaboUsingDate.Width = 61;
            // 
            // _gcLaboWarrantyCard
            // 
            this._gcLaboWarrantyCard.Caption = "Thẻ bảo hành";
            this._gcLaboWarrantyCard.FieldName = "THE_BAOHANH";
            this._gcLaboWarrantyCard.MinWidth = 10;
            this._gcLaboWarrantyCard.Name = "_gcLaboWarrantyCard";
            this._gcLaboWarrantyCard.OptionsColumn.ReadOnly = true;
            this._gcLaboWarrantyCard.Visible = true;
            this._gcLaboWarrantyCard.VisibleIndex = 11;
            this._gcLaboWarrantyCard.Width = 42;
            // 
            // _gcLaboWarrantyYear
            // 
            this._gcLaboWarrantyYear.Caption = "Năm BH";
            this._gcLaboWarrantyYear.FieldName = "NAM_BAOHANH";
            this._gcLaboWarrantyYear.MinWidth = 10;
            this._gcLaboWarrantyYear.Name = "_gcLaboWarrantyYear";
            this._gcLaboWarrantyYear.OptionsColumn.ReadOnly = true;
            this._gcLaboWarrantyYear.Visible = true;
            this._gcLaboWarrantyYear.VisibleIndex = 12;
            this._gcLaboWarrantyYear.Width = 31;
            // 
            // _gcLaboPrice
            // 
            this._gcLaboPrice.Caption = "Đơn giá";
            this._gcLaboPrice.ColumnEdit = this.repositoryItemCalcEdit1;
            this._gcLaboPrice.FieldName = "DONGIA";
            this._gcLaboPrice.MinWidth = 10;
            this._gcLaboPrice.Name = "_gcLaboPrice";
            this._gcLaboPrice.OptionsColumn.ReadOnly = true;
            this._gcLaboPrice.Width = 46;
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.DisplayFormat.FormatString = "n0";
            this.repositoryItemCalcEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEdit1.EditFormat.FormatString = "n0";
            this.repositoryItemCalcEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEdit1.Mask.EditMask = "n0";
            this.repositoryItemCalcEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // _gcLaboTotalMoney
            // 
            this._gcLaboTotalMoney.Caption = "Thành tiền";
            this._gcLaboTotalMoney.ColumnEdit = this.repositoryItemCalcEdit1;
            this._gcLaboTotalMoney.FieldName = "THANHTIEN";
            this._gcLaboTotalMoney.MinWidth = 10;
            this._gcLaboTotalMoney.Name = "_gcLaboTotalMoney";
            this._gcLaboTotalMoney.OptionsColumn.ReadOnly = true;
            this._gcLaboTotalMoney.Width = 51;
            // 
            // _gcLaboAssistantFullName
            // 
            this._gcLaboAssistantFullName.Caption = "Phụ tá";
            this._gcLaboAssistantFullName.FieldName = "AssistantFullName";
            this._gcLaboAssistantFullName.MinWidth = 10;
            this._gcLaboAssistantFullName.Name = "_gcLaboAssistantFullName";
            this._gcLaboAssistantFullName.OptionsColumn.ReadOnly = true;
            this._gcLaboAssistantFullName.Visible = true;
            this._gcLaboAssistantFullName.VisibleIndex = 13;
            this._gcLaboAssistantFullName.Width = 51;
            // 
            // _gcLaboNote
            // 
            this._gcLaboNote.Caption = "Ghi chú";
            this._gcLaboNote.FieldName = "GHICHU";
            this._gcLaboNote.MinWidth = 10;
            this._gcLaboNote.Name = "_gcLaboNote";
            this._gcLaboNote.OptionsColumn.ReadOnly = true;
            this._gcLaboNote.Visible = true;
            this._gcLaboNote.VisibleIndex = 14;
            this._gcLaboNote.Width = 66;
            // 
            // _gcLaboStatus
            // 
            this._gcLaboStatus.Caption = "Trạng thái";
            this._gcLaboStatus.FieldName = "DIENGIAI_DMTRANGTHAI_GUILABO";
            this._gcLaboStatus.MinWidth = 10;
            this._gcLaboStatus.Name = "_gcLaboStatus";
            this._gcLaboStatus.OptionsColumn.ReadOnly = true;
            this._gcLaboStatus.Visible = true;
            this._gcLaboStatus.VisibleIndex = 15;
            this._gcLaboStatus.Width = 30;
            // 
            // _gcLaboOrderId
            // 
            this._gcLaboOrderId.Caption = "Hồ sơ";
            this._gcLaboOrderId.MinWidth = 40;
            this._gcLaboOrderId.Name = "_gcLaboOrderId";
            this._gcLaboOrderId.OptionsColumn.ReadOnly = true;
            this._gcLaboOrderId.Visible = true;
            this._gcLaboOrderId.VisibleIndex = 19;
            this._gcLaboOrderId.Width = 40;
            // 
            // _gcLaboOrderItemName
            // 
            this._gcLaboOrderItemName.Caption = "Dịch vụ";
            this._gcLaboOrderItemName.MinWidth = 60;
            this._gcLaboOrderItemName.Name = "_gcLaboOrderItemName";
            this._gcLaboOrderItemName.OptionsColumn.ReadOnly = true;
            this._gcLaboOrderItemName.Visible = true;
            this._gcLaboOrderItemName.VisibleIndex = 20;
            this._gcLaboOrderItemName.Width = 60;
            // 
            // _gcLaboOrderItemStepContent
            // 
            this._gcLaboOrderItemStepContent.Caption = "Nội dung điều trị";
            this._gcLaboOrderItemStepContent.MinWidth = 60;
            this._gcLaboOrderItemStepContent.Name = "_gcLaboOrderItemStepContent";
            this._gcLaboOrderItemStepContent.OptionsColumn.ReadOnly = true;
            this._gcLaboOrderItemStepContent.Visible = true;
            this._gcLaboOrderItemStepContent.VisibleIndex = 16;
            this._gcLaboOrderItemStepContent.Width = 60;
            // 
            // _gcLaboRootFee
            // 
            this._gcLaboRootFee.Caption = "Phí gốc";
            this._gcLaboRootFee.DisplayFormat.FormatString = "n0";
            this._gcLaboRootFee.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._gcLaboRootFee.MinWidth = 40;
            this._gcLaboRootFee.Name = "_gcLaboRootFee";
            this._gcLaboRootFee.OptionsColumn.ReadOnly = true;
            this._gcLaboRootFee.Visible = true;
            this._gcLaboRootFee.VisibleIndex = 18;
            this._gcLaboRootFee.Width = 40;
            // 
            // _gcLaboFeeFinal
            // 
            this._gcLaboFeeFinal.Caption = "Phí thực tế";
            this._gcLaboFeeFinal.DisplayFormat.FormatString = "n0";
            this._gcLaboFeeFinal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._gcLaboFeeFinal.MinWidth = 40;
            this._gcLaboFeeFinal.Name = "_gcLaboFeeFinal";
            this._gcLaboFeeFinal.OptionsColumn.ReadOnly = true;
            this._gcLaboFeeFinal.Visible = true;
            this._gcLaboFeeFinal.VisibleIndex = 17;
            this._gcLaboFeeFinal.Width = 40;
            // 
            // _gcLaboEdit
            // 
            this._gcLaboEdit.Caption = "Sửa";
            this._gcLaboEdit.ColumnEdit = this.lnkSuaDatLabo;
            this._gcLaboEdit.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcLaboEdit.MaxWidth = 40;
            this._gcLaboEdit.MinWidth = 40;
            this._gcLaboEdit.Name = "_gcLaboEdit";
            this._gcLaboEdit.Visible = true;
            this._gcLaboEdit.VisibleIndex = 19;
            this._gcLaboEdit.Width = 40;
            // 
            // lnkSuaDatLabo
            // 
            this.lnkSuaDatLabo.AutoHeight = false;
            this.lnkSuaDatLabo.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lnkSuaDatLabo.Name = "lnkSuaDatLabo";
            this.lnkSuaDatLabo.Click += new System.EventHandler(this.lnkSuaDatLabo_Click);
            // 
            // _gcLaboDelete
            // 
            this._gcLaboDelete.Caption = "Xóa";
            this._gcLaboDelete.ColumnEdit = this.lnkXoaDatLabo;
            this._gcLaboDelete.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcLaboDelete.MaxWidth = 40;
            this._gcLaboDelete.MinWidth = 40;
            this._gcLaboDelete.Name = "_gcLaboDelete";
            this._gcLaboDelete.Visible = true;
            this._gcLaboDelete.VisibleIndex = 20;
            this._gcLaboDelete.Width = 40;
            // 
            // lnkXoaDatLabo
            // 
            this.lnkXoaDatLabo.AutoHeight = false;
            this.lnkXoaDatLabo.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lnkXoaDatLabo.Name = "lnkXoaDatLabo";
            this.lnkXoaDatLabo.Click += new System.EventHandler(this.lnkXoaDatLabo_Click);
            // 
            // _rCheckSelect
            // 
            this._rCheckSelect.AutoHeight = false;
            this._rCheckSelect.Name = "_rCheckSelect";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this._cbbAutoPrintMode);
            this.groupControl2.Controls.Add(this._lblUnitPrice);
            this.groupControl2.Controls.Add(this._btnSaveNew);
            this.groupControl2.Controls.Add(this._cbAutoPrint);
            this.groupControl2.Controls.Add(this._btnPrint);
            this.groupControl2.Controls.Add(this._btnSave);
            this.groupControl2.Controls.Add(this.tableLayoutPanel2);
            this.groupControl2.Controls.Add(this._btnAdd);
            this.groupControl2.Controls.Add(this.labelControl22);
            this.groupControl2.Controls.Add(this._calcUnitPrice);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(4, 3);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1016, 230);
            this.groupControl2.TabIndex = 14;
            this.groupControl2.Text = "Thông tin đặt Labo";
            // 
            // _cbbAutoPrintMode
            // 
            this._cbbAutoPrintMode.Location = new System.Drawing.Point(671, 189);
            this._cbbAutoPrintMode.Margin = new System.Windows.Forms.Padding(1);
            this._cbbAutoPrintMode.MaximumSize = new System.Drawing.Size(128, 28);
            this._cbbAutoPrintMode.MinimumSize = new System.Drawing.Size(128, 28);
            this._cbbAutoPrintMode.Name = "_cbbAutoPrintMode";
            this._cbbAutoPrintMode.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._cbbAutoPrintMode.Properties.Appearance.Options.UseFont = true;
            this._cbbAutoPrintMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._cbbAutoPrintMode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Kiểu In", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this._cbbAutoPrintMode.Properties.DisplayMember = "Name";
            this._cbbAutoPrintMode.Properties.NullText = "--- Chọn ---";
            this._cbbAutoPrintMode.Properties.ShowHeader = false;
            this._cbbAutoPrintMode.Properties.ValueMember = "Id";
            this._cbbAutoPrintMode.Size = new System.Drawing.Size(128, 20);
            this._cbbAutoPrintMode.TabIndex = 168;
            // 
            // _lblUnitPrice
            // 
            this._lblUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lblUnitPrice.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._lblUnitPrice.Appearance.Options.UseFont = true;
            this._lblUnitPrice.Location = new System.Drawing.Point(832, 196);
            this._lblUnitPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._lblUnitPrice.Name = "_lblUnitPrice";
            this._lblUnitPrice.Size = new System.Drawing.Size(53, 14);
            this._lblUnitPrice.TabIndex = 133;
            this._lblUnitPrice.Text = "Đơn giá:";
            // 
            // _btnSaveNew
            // 
            this._btnSaveNew.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnSaveNew.Appearance.Options.UseFont = true;
            this._btnSaveNew.Enabled = false;
            this._btnSaveNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnSaveNew.ImageOptions.Image")));
            this._btnSaveNew.ImageOptions.ImageIndex = 1;
            this._btnSaveNew.Location = new System.Drawing.Point(349, 186);
            this._btnSaveNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._btnSaveNew.Name = "_btnSaveNew";
            this._btnSaveNew.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this._btnSaveNew.Size = new System.Drawing.Size(113, 35);
            this._btnSaveNew.TabIndex = 126;
            this._btnSaveNew.Text = "Lưu mới";
            this._btnSaveNew.Click += new System.EventHandler(this._btnSaveNew_Click);
            // 
            // _cbAutoPrint
            // 
            this._cbAutoPrint.EditValue = true;
            this._cbAutoPrint.Location = new System.Drawing.Point(469, 193);
            this._cbAutoPrint.Margin = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this._cbAutoPrint.Name = "_cbAutoPrint";
            this._cbAutoPrint.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbAutoPrint.Properties.Appearance.Options.UseFont = true;
            this._cbAutoPrint.Properties.Caption = "Tự động in 2 Phiếu khi Lưu";
            this._cbAutoPrint.Size = new System.Drawing.Size(200, 20);
            this._cbAutoPrint.TabIndex = 125;
            this._cbAutoPrint.TabStop = false;
            // 
            // _btnPrint
            // 
            this._btnPrint.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnPrint.Appearance.Options.UseFont = true;
            this._btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnPrint.ImageOptions.Image")));
            this._btnPrint.ImageOptions.ImageIndex = 1;
            this._btnPrint.Location = new System.Drawing.Point(234, 186);
            this._btnPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._btnPrint.Name = "_btnPrint";
            this._btnPrint.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this._btnPrint.Size = new System.Drawing.Size(107, 35);
            this._btnPrint.TabIndex = 26;
            this._btnPrint.Text = "In";
            this._btnPrint.Click += new System.EventHandler(this._btnPrintLabo_Click);
            // 
            // _btnSave
            // 
            this._btnSave.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnSave.Appearance.Options.UseFont = true;
            this._btnSave.Enabled = false;
            this._btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnSave.ImageOptions.Image")));
            this._btnSave.ImageOptions.ImageIndex = 1;
            this._btnSave.Location = new System.Drawing.Point(119, 186);
            this._btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this._btnSave.Size = new System.Drawing.Size(107, 35);
            this._btnSave.TabIndex = 3;
            this._btnSave.Text = "Lưu";
            this._btnSave.Click += new System.EventHandler(this.btnLuu_DatLabo_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel2.Controls.Add(this._glkProvider, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.glkDMVatlieu, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtMauSu, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this._calcAmount, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelControl8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelControl9, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelControl10, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelControl20, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.glkTrangThai, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.labelControl27, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this._cbbSelectLaboCreatorDoctor, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl23, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelControl26, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.labelControl18, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.dtNamBH, 3, 6);
            this.tableLayoutPanel2.Controls.Add(this.labelControl17, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtTheBH, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelControl15, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.dtNgayHen, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelControl14, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.dtNgayGiao, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelControl39, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.dtNgayDat, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelControl41, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this._cbbSelectLaboAssistant, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl42, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this._cbbLaboPhanLoai, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this._lblNote, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this._txtNotes, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelControl1, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl2, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this._cbbSelectOrderItem, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this._glkOrderItemStep, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this._tblPrices, 5, 6);
            this.tableLayoutPanel2.Controls.Add(this._lblPrices, 4, 6);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 7);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 19);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1013, 159);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // _glkProvider
            // 
            this._glkProvider.Dock = System.Windows.Forms.DockStyle.Fill;
            this._glkProvider.Location = new System.Drawing.Point(83, 23);
            this._glkProvider.Margin = new System.Windows.Forms.Padding(1);
            this._glkProvider.Name = "_glkProvider";
            this._glkProvider.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._glkProvider.Properties.Appearance.Options.UseFont = true;
            this._glkProvider.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._glkProvider.Properties.AppearanceDropDown.Options.UseFont = true;
            this._glkProvider.Properties.DisplayMember = "TEN";
            this._glkProvider.Properties.NullText = "";
            this._glkProvider.Properties.PopupView = this.gridView10;
            this._glkProvider.Properties.ValueMember = "ID";
            this._glkProvider.Size = new System.Drawing.Size(242, 20);
            this._glkProvider.TabIndex = 402;
            this._glkProvider.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.glkDMLabo_ButtonClick);
            this._glkProvider.EditValueChanged += new System.EventHandler(this._glkProvider_EditValueChanged);
            // 
            // gridView10
            // 
            this.gridView10.Appearance.Row.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView10.Appearance.Row.Options.UseFont = true;
            this.gridView10.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn55});
            this.gridView10.DetailHeight = 182;
            this.gridView10.FixedLineWidth = 1;
            this.gridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView10.LevelIndent = 0;
            this.gridView10.Name = "gridView10";
            this.gridView10.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView10.OptionsView.ShowAutoFilterRow = true;
            this.gridView10.OptionsView.ShowGroupPanel = false;
            this.gridView10.PreviewIndent = 0;
            // 
            // gridColumn55
            // 
            this.gridColumn55.Caption = "Tên";
            this.gridColumn55.FieldName = "TEN";
            this.gridColumn55.MinWidth = 10;
            this.gridColumn55.Name = "gridColumn55";
            this.gridColumn55.Visible = true;
            this.gridColumn55.VisibleIndex = 0;
            this.gridColumn55.Width = 37;
            // 
            // glkDMVatlieu
            // 
            this.glkDMVatlieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glkDMVatlieu.Location = new System.Drawing.Point(83, 46);
            this.glkDMVatlieu.Margin = new System.Windows.Forms.Padding(1);
            this.glkDMVatlieu.Name = "glkDMVatlieu";
            this.glkDMVatlieu.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glkDMVatlieu.Properties.Appearance.Options.UseFont = true;
            this.glkDMVatlieu.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glkDMVatlieu.Properties.AppearanceDropDown.Options.UseFont = true;
            this.glkDMVatlieu.Properties.DisplayMember = "TEN";
            this.glkDMVatlieu.Properties.NullText = "";
            this.glkDMVatlieu.Properties.PopupView = this.gridView11;
            this.glkDMVatlieu.Properties.ValueMember = "ID";
            this.glkDMVatlieu.Size = new System.Drawing.Size(242, 20);
            this.glkDMVatlieu.TabIndex = 404;
            this.glkDMVatlieu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.glkDMVatlieu_ButtonClick);
            this.glkDMVatlieu.EditValueChanged += new System.EventHandler(this.glkDMVatlieu_EditValueChanged);
            // 
            // gridView11
            // 
            this.gridView11.Appearance.Row.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView11.Appearance.Row.Options.UseFont = true;
            this.gridView11.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn56});
            this.gridView11.DetailHeight = 182;
            this.gridView11.FixedLineWidth = 1;
            this.gridView11.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView11.LevelIndent = 0;
            this.gridView11.Name = "gridView11";
            this.gridView11.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView11.OptionsView.ShowAutoFilterRow = true;
            this.gridView11.OptionsView.ShowGroupPanel = false;
            this.gridView11.PreviewIndent = 0;
            // 
            // gridColumn56
            // 
            this.gridColumn56.Caption = "Tên đơn vị";
            this.gridColumn56.FieldName = "TEN";
            this.gridColumn56.MinWidth = 10;
            this.gridColumn56.Name = "gridColumn56";
            this.gridColumn56.Visible = true;
            this.gridColumn56.VisibleIndex = 0;
            this.gridColumn56.Width = 37;
            // 
            // txtMauSu
            // 
            this.txtMauSu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMauSu.Location = new System.Drawing.Point(83, 69);
            this.txtMauSu.Margin = new System.Windows.Forms.Padding(1);
            this.txtMauSu.Name = "txtMauSu";
            this.txtMauSu.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMauSu.Properties.Appearance.Options.UseFont = true;
            this.txtMauSu.Size = new System.Drawing.Size(242, 20);
            this.txtMauSu.TabIndex = 406;
            // 
            // _calcAmount
            // 
            this._calcAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this._calcAmount.Location = new System.Drawing.Point(83, 113);
            this._calcAmount.Margin = new System.Windows.Forms.Padding(1);
            this._calcAmount.Name = "_calcAmount";
            this._calcAmount.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._calcAmount.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this._calcAmount.Properties.Appearance.Options.UseFont = true;
            this._calcAmount.Properties.Appearance.Options.UseForeColor = true;
            this._calcAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._calcAmount.Properties.DisplayFormat.FormatString = "n0";
            this._calcAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._calcAmount.Properties.EditFormat.FormatString = "n0";
            this._calcAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._calcAmount.Properties.Mask.EditMask = "n0";
            this._calcAmount.Size = new System.Drawing.Size(242, 20);
            this._calcAmount.TabIndex = 410;
            this._calcAmount.EditValueChanged += new System.EventHandler(this.cdtSoLuong_EditValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(4, 25);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(36, 14);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "Labo:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(4, 48);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(52, 14);
            this.labelControl9.TabIndex = 40;
            this.labelControl9.Text = "Vật liệu:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(4, 71);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(50, 14);
            this.labelControl10.TabIndex = 104;
            this.labelControl10.Text = "Màu sứ:";
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.labelControl20.Appearance.Options.UseFont = true;
            this.labelControl20.Location = new System.Drawing.Point(4, 93);
            this.labelControl20.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(37, 14);
            this.labelControl20.TabIndex = 68;
            this.labelControl20.Text = "Răng:";
            // 
            // glkTrangThai
            // 
            this.glkTrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glkTrangThai.Location = new System.Drawing.Point(83, 135);
            this.glkTrangThai.Margin = new System.Windows.Forms.Padding(1);
            this.glkTrangThai.Name = "glkTrangThai";
            this.glkTrangThai.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glkTrangThai.Properties.Appearance.Options.UseFont = true;
            this.glkTrangThai.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glkTrangThai.Properties.AppearanceDropDown.Options.UseFont = true;
            this.glkTrangThai.Properties.DisplayMember = "DIENGIAI";
            this.glkTrangThai.Properties.NullText = "";
            this.glkTrangThai.Properties.PopupView = this.gridView12;
            this.glkTrangThai.Properties.ValueMember = "ID";
            this.glkTrangThai.Size = new System.Drawing.Size(242, 20);
            this.glkTrangThai.TabIndex = 412;
            this.glkTrangThai.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.glkTrangThai_ButtonClick);
            // 
            // gridView12
            // 
            this.gridView12.Appearance.Row.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView12.Appearance.Row.Options.UseFont = true;
            this.gridView12.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._gcLaboName});
            this.gridView12.DetailHeight = 182;
            this.gridView12.FixedLineWidth = 1;
            this.gridView12.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView12.LevelIndent = 0;
            this.gridView12.Name = "gridView12";
            this.gridView12.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView12.OptionsView.ShowAutoFilterRow = true;
            this.gridView12.OptionsView.ShowGroupPanel = false;
            this.gridView12.PreviewIndent = 0;
            // 
            // _gcLaboName
            // 
            this._gcLaboName.Caption = "Diễn giải";
            this._gcLaboName.FieldName = "DIENGIAI";
            this._gcLaboName.MinWidth = 10;
            this._gcLaboName.Name = "_gcLaboName";
            this._gcLaboName.Visible = true;
            this._gcLaboName.VisibleIndex = 0;
            this._gcLaboName.Width = 37;
            // 
            // labelControl27
            // 
            this.labelControl27.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.labelControl27.Appearance.Options.UseFont = true;
            this.labelControl27.Location = new System.Drawing.Point(4, 3);
            this.labelControl27.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(41, 14);
            this.labelControl27.TabIndex = 108;
            this.labelControl27.Text = "Bác sĩ:";
            // 
            // _cbbSelectLaboCreatorDoctor
            // 
            this._cbbSelectLaboCreatorDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cbbSelectLaboCreatorDoctor.FilterModelFunc = null;
            this._cbbSelectLaboCreatorDoctor.IsAutoLoadData = true;
            this._cbbSelectLaboCreatorDoctor.IsHideDeleteButton = false;
            this._cbbSelectLaboCreatorDoctor.IsIgnoreAdmin = false;
            this._cbbSelectLaboCreatorDoctor.IsUseValueAsDisplayName = false;
            this._cbbSelectLaboCreatorDoctor.Location = new System.Drawing.Point(83, 1);
            this._cbbSelectLaboCreatorDoctor.Margin = new System.Windows.Forms.Padding(1);
            this._cbbSelectLaboCreatorDoctor.Name = "_cbbSelectLaboCreatorDoctor";
            this._cbbSelectLaboCreatorDoctor.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbbSelectLaboCreatorDoctor.Properties.Appearance.Options.UseFont = true;
            this._cbbSelectLaboCreatorDoctor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, false, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this._cbbSelectLaboCreatorDoctor.Properties.DisplayMember = "Username";
            this._cbbSelectLaboCreatorDoctor.Properties.NullText = "--- Chọn ---";
            this._cbbSelectLaboCreatorDoctor.Properties.ReadOnly = true;
            this._cbbSelectLaboCreatorDoctor.SameDataSourceControls = null;
            this._cbbSelectLaboCreatorDoctor.Size = new System.Drawing.Size(242, 20);
            this._cbbSelectLaboCreatorDoctor.TabIndex = 400;
            // 
            // labelControl23
            // 
            this.labelControl23.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.labelControl23.Appearance.Options.UseFont = true;
            this.labelControl23.Location = new System.Drawing.Point(4, 115);
            this.labelControl23.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(60, 14);
            this.labelControl23.TabIndex = 106;
            this.labelControl23.Text = "Số lượng:";
            // 
            // labelControl26
            // 
            this.labelControl26.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.labelControl26.Appearance.Options.UseFont = true;
            this.labelControl26.Location = new System.Drawing.Point(4, 137);
            this.labelControl26.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(63, 14);
            this.labelControl26.TabIndex = 130;
            this.labelControl26.Text = "Trạng thái";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Location = new System.Drawing.Point(330, 137);
            this.labelControl18.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(54, 14);
            this.labelControl18.TabIndex = 115;
            this.labelControl18.Text = "Năm BH:";
            // 
            // dtNamBH
            // 
            this.dtNamBH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtNamBH.EditValue = null;
            this.dtNamBH.Location = new System.Drawing.Point(442, 135);
            this.dtNamBH.Margin = new System.Windows.Forms.Padding(1);
            this.dtNamBH.Name = "dtNamBH";
            this.dtNamBH.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNamBH.Properties.Appearance.Options.UseFont = true;
            this.dtNamBH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNamBH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNamBH.Properties.DisplayFormat.FormatString = "yyyy";
            this.dtNamBH.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNamBH.Properties.EditFormat.FormatString = "yyyy";
            this.dtNamBH.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNamBH.Properties.Mask.EditMask = "yyyy";
            this.dtNamBH.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearsGroupView;
            this.dtNamBH.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView;
            this.dtNamBH.Size = new System.Drawing.Size(242, 20);
            this.dtNamBH.TabIndex = 413;
            this.dtNamBH.TabStop = false;
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(330, 115);
            this.labelControl17.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(49, 14);
            this.labelControl17.TabIndex = 114;
            this.labelControl17.Text = "Thẻ BH:";
            // 
            // txtTheBH
            // 
            this.txtTheBH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTheBH.Location = new System.Drawing.Point(442, 113);
            this.txtTheBH.Margin = new System.Windows.Forms.Padding(1);
            this.txtTheBH.Name = "txtTheBH";
            this.txtTheBH.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTheBH.Properties.Appearance.Options.UseFont = true;
            this.txtTheBH.Size = new System.Drawing.Size(242, 20);
            this.txtTheBH.TabIndex = 411;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(330, 93);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(86, 14);
            this.labelControl15.TabIndex = 112;
            this.labelControl15.Text = "Ngày hẹn BN:";
            // 
            // dtNgayHen
            // 
            this.dtNgayHen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtNgayHen.EditValue = null;
            this.dtNgayHen.Location = new System.Drawing.Point(442, 91);
            this.dtNgayHen.Margin = new System.Windows.Forms.Padding(1);
            this.dtNgayHen.Name = "dtNgayHen";
            this.dtNgayHen.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayHen.Properties.Appearance.Options.UseFont = true;
            this.dtNgayHen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayHen.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayHen.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.dtNgayHen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayHen.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.dtNgayHen.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayHen.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm";
            this.dtNgayHen.Size = new System.Drawing.Size(242, 20);
            this.dtNgayHen.TabIndex = 409;
            this.dtNgayHen.TabStop = false;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(330, 71);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(109, 14);
            this.labelControl14.TabIndex = 111;
            this.labelControl14.Text = "Ngày nhận hàng:";
            // 
            // dtNgayGiao
            // 
            this.dtNgayGiao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtNgayGiao.EditValue = null;
            this.dtNgayGiao.Location = new System.Drawing.Point(442, 69);
            this.dtNgayGiao.Margin = new System.Windows.Forms.Padding(1);
            this.dtNgayGiao.Name = "dtNgayGiao";
            this.dtNgayGiao.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayGiao.Properties.Appearance.Options.UseFont = true;
            this.dtNgayGiao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayGiao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayGiao.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.dtNgayGiao.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayGiao.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.dtNgayGiao.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayGiao.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm";
            this.dtNgayGiao.Size = new System.Drawing.Size(242, 20);
            this.dtNgayGiao.TabIndex = 407;
            this.dtNgayGiao.TabStop = false;
            // 
            // labelControl39
            // 
            this.labelControl39.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.labelControl39.Appearance.Options.UseFont = true;
            this.labelControl39.Location = new System.Drawing.Point(330, 48);
            this.labelControl39.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl39.Name = "labelControl39";
            this.labelControl39.Size = new System.Drawing.Size(98, 14);
            this.labelControl39.TabIndex = 131;
            this.labelControl39.Text = "Ngày đặt hàng:";
            // 
            // dtNgayDat
            // 
            this.dtNgayDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtNgayDat.EditValue = null;
            this.dtNgayDat.Location = new System.Drawing.Point(442, 46);
            this.dtNgayDat.Margin = new System.Windows.Forms.Padding(1);
            this.dtNgayDat.Name = "dtNgayDat";
            this.dtNgayDat.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayDat.Properties.Appearance.Options.UseFont = true;
            this.dtNgayDat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayDat.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayDat.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.dtNgayDat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayDat.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.dtNgayDat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayDat.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm";
            this.dtNgayDat.Properties.ReadOnly = true;
            this.dtNgayDat.Size = new System.Drawing.Size(242, 20);
            this.dtNgayDat.TabIndex = 405;
            this.dtNgayDat.TabStop = false;
            // 
            // labelControl41
            // 
            this.labelControl41.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.labelControl41.Appearance.Options.UseFont = true;
            this.labelControl41.Location = new System.Drawing.Point(330, 3);
            this.labelControl41.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl41.Name = "labelControl41";
            this.labelControl41.Size = new System.Drawing.Size(46, 14);
            this.labelControl41.TabIndex = 123;
            this.labelControl41.Text = "Phụ tá:";
            // 
            // _cbbSelectLaboAssistant
            // 
            this._cbbSelectLaboAssistant.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cbbSelectLaboAssistant.FilterModelFunc = null;
            this._cbbSelectLaboAssistant.IsAutoLoadData = true;
            this._cbbSelectLaboAssistant.IsHideDeleteButton = false;
            this._cbbSelectLaboAssistant.IsIgnoreAdmin = false;
            this._cbbSelectLaboAssistant.IsUseValueAsDisplayName = false;
            this._cbbSelectLaboAssistant.Location = new System.Drawing.Point(442, 1);
            this._cbbSelectLaboAssistant.Margin = new System.Windows.Forms.Padding(1);
            this._cbbSelectLaboAssistant.Name = "_cbbSelectLaboAssistant";
            this._cbbSelectLaboAssistant.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbbSelectLaboAssistant.Properties.Appearance.Options.UseFont = true;
            this._cbbSelectLaboAssistant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this._cbbSelectLaboAssistant.Properties.DisplayMember = "Username";
            this._cbbSelectLaboAssistant.Properties.NullText = "--- Chọn ---";
            this._cbbSelectLaboAssistant.SameDataSourceControls = null;
            this._cbbSelectLaboAssistant.Size = new System.Drawing.Size(242, 20);
            this._cbbSelectLaboAssistant.TabIndex = 401;
            // 
            // labelControl42
            // 
            this.labelControl42.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.labelControl42.Appearance.Options.UseFont = true;
            this.labelControl42.Location = new System.Drawing.Point(330, 25);
            this.labelControl42.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl42.Name = "labelControl42";
            this.labelControl42.Size = new System.Drawing.Size(58, 14);
            this.labelControl42.TabIndex = 135;
            this.labelControl42.Text = "Mục đích:";
            // 
            // _cbbLaboPhanLoai
            // 
            this._cbbLaboPhanLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cbbLaboPhanLoai.EditValue = "Id";
            this._cbbLaboPhanLoai.Location = new System.Drawing.Point(443, 24);
            this._cbbLaboPhanLoai.Margin = new System.Windows.Forms.Padding(2);
            this._cbbLaboPhanLoai.Name = "_cbbLaboPhanLoai";
            this._cbbLaboPhanLoai.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._cbbLaboPhanLoai.Properties.Appearance.Options.UseFont = true;
            this._cbbLaboPhanLoai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._cbbLaboPhanLoai.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("No", "STT"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this._cbbLaboPhanLoai.Properties.DisplayMember = "Name";
            this._cbbLaboPhanLoai.Properties.NullText = "";
            this._cbbLaboPhanLoai.Properties.ShowHeader = false;
            this._cbbLaboPhanLoai.Properties.ValueMember = "Id";
            this._cbbLaboPhanLoai.Size = new System.Drawing.Size(240, 20);
            this._cbbLaboPhanLoai.TabIndex = 403;
            this._cbbLaboPhanLoai.ToolTip = "Trạng thái";
            // 
            // _lblNote
            // 
            this._lblNote.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._lblNote.Appearance.Options.UseFont = true;
            this._lblNote.Location = new System.Drawing.Point(689, 48);
            this._lblNote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._lblNote.Name = "_lblNote";
            this._lblNote.Size = new System.Drawing.Size(51, 14);
            this._lblNote.TabIndex = 126;
            this._lblNote.Text = "Ghi chú:";
            // 
            // _txtNotes
            // 
            this._txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtNotes.Location = new System.Drawing.Point(768, 46);
            this._txtNotes.Margin = new System.Windows.Forms.Padding(1);
            this._txtNotes.Name = "_txtNotes";
            this._txtNotes.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtNotes.Properties.Appearance.Options.UseFont = true;
            this.tableLayoutPanel2.SetRowSpan(this._txtNotes, 4);
            this._txtNotes.Size = new System.Drawing.Size(244, 87);
            this._txtNotes.TabIndex = 414;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this._btnLaboSelectMultiTeeth, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this._cbbLaboRang, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(82, 90);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(244, 22);
            this.tableLayoutPanel3.TabIndex = 415;
            // 
            // _btnLaboSelectMultiTeeth
            // 
            this._btnLaboSelectMultiTeeth.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnLaboSelectMultiTeeth.Appearance.Options.UseFont = true;
            this._btnLaboSelectMultiTeeth.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnLaboSelectMultiTeeth.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnLaboSelectMultiTeeth.ImageOptions.Image")));
            this._btnLaboSelectMultiTeeth.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this._btnLaboSelectMultiTeeth.Location = new System.Drawing.Point(225, 1);
            this._btnLaboSelectMultiTeeth.Margin = new System.Windows.Forms.Padding(1);
            this._btnLaboSelectMultiTeeth.Name = "_btnLaboSelectMultiTeeth";
            this._btnLaboSelectMultiTeeth.Size = new System.Drawing.Size(18, 20);
            this._btnLaboSelectMultiTeeth.TabIndex = 410;
            this._btnLaboSelectMultiTeeth.TabStop = false;
            this._btnLaboSelectMultiTeeth.Click += new System.EventHandler(this._btnLaboSelectMultiTeeth_Click);
            // 
            // _cbbLaboRang
            // 
            this._cbbLaboRang.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cbbLaboRang.Location = new System.Drawing.Point(1, 1);
            this._cbbLaboRang.Margin = new System.Windows.Forms.Padding(1);
            this._cbbLaboRang.Name = "_cbbLaboRang";
            this._cbbLaboRang.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this._cbbLaboRang.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbbLaboRang.Properties.Appearance.Options.UseFont = true;
            this._cbbLaboRang.Properties.DisplayMember = "TEN";
            this._cbbLaboRang.Properties.NullText = "";
            this._cbbLaboRang.Properties.PopupFormSize = new System.Drawing.Size(350, 156);
            this._cbbLaboRang.Properties.PopupView = this.gridView17;
            this._cbbLaboRang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this._cbbLaboRang.Properties.ValueMember = "ID";
            this._cbbLaboRang.Size = new System.Drawing.Size(222, 20);
            this._cbbLaboRang.TabIndex = 409;
            this._cbbLaboRang.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this._cbbLaboRang_ButtonClick);
            this._cbbLaboRang.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this._cbbLaboRang_CustomDisplayText);
            // 
            // gridView17
            // 
            this.gridView17.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn102});
            this.gridView17.DetailHeight = 182;
            this.gridView17.FixedLineWidth = 1;
            this.gridView17.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView17.LevelIndent = 0;
            this.gridView17.Name = "gridView17";
            this.gridView17.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView17.OptionsView.ShowAutoFilterRow = true;
            this.gridView17.OptionsView.ShowGroupPanel = false;
            this.gridView17.PreviewIndent = 0;
            // 
            // gridColumn102
            // 
            this.gridColumn102.Caption = "Tên";
            this.gridColumn102.FieldName = "TEN";
            this.gridColumn102.MinWidth = 10;
            this.gridColumn102.Name = "gridColumn102";
            this.gridColumn102.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Like;
            this.gridColumn102.Visible = true;
            this.gridColumn102.VisibleIndex = 0;
            this.gridColumn102.Width = 121;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(689, 3);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 14);
            this.labelControl1.TabIndex = 416;
            this.labelControl1.Text = "Dịch vụ:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(689, 25);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 14);
            this.labelControl2.TabIndex = 417;
            this.labelControl2.Text = "Bước:";
            // 
            // _cbbSelectOrderItem
            // 
            this._cbbSelectOrderItem.CustomerId = null;
            this._cbbSelectOrderItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cbbSelectOrderItem.IsAutoLoadData = true;
            this._cbbSelectOrderItem.IsHideDeleteButton = false;
            this._cbbSelectOrderItem.Location = new System.Drawing.Point(768, 1);
            this._cbbSelectOrderItem.Margin = new System.Windows.Forms.Padding(1);
            this._cbbSelectOrderItem.Name = "_cbbSelectOrderItem";
            this._cbbSelectOrderItem.OrderId = null;
            this._cbbSelectOrderItem.OrderItemId = null;
            this._cbbSelectOrderItem.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this._cbbSelectOrderItem.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbbSelectOrderItem.Properties.Appearance.Options.UseFont = true;
            this._cbbSelectOrderItem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this._cbbSelectOrderItem.Properties.DisplayMember = "ID_HOSODIEUTRI";
            this._cbbSelectOrderItem.Properties.NullText = "";
            this._cbbSelectOrderItem.Properties.PopupFormSize = new System.Drawing.Size(450, 260);
            this._cbbSelectOrderItem.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this._cbbSelectOrderItem.Properties.ValueMember = "ID_HOSODIEUTRI";
            this._cbbSelectOrderItem.SameDataSourceControls = null;
            this._cbbSelectOrderItem.Size = new System.Drawing.Size(244, 20);
            this._cbbSelectOrderItem.TabIndex = 419;
            this._cbbSelectOrderItem.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this._cbbSelectOrder_ButtonClick);
            this._cbbSelectOrderItem.EditValueChanged += new System.EventHandler(this._cbbSelectOrderItem_EditValueChanged);
            // 
            // _glkOrderItemStep
            // 
            this._glkOrderItemStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this._glkOrderItemStep.Location = new System.Drawing.Point(768, 23);
            this._glkOrderItemStep.Margin = new System.Windows.Forms.Padding(1);
            this._glkOrderItemStep.Name = "_glkOrderItemStep";
            this._glkOrderItemStep.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this._glkOrderItemStep.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._glkOrderItemStep.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this._glkOrderItemStep.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this._glkOrderItemStep.Properties.DisplayMember = "ID_HOSODIEUTRI";
            this._glkOrderItemStep.Properties.NullText = "";
            this._glkOrderItemStep.Properties.PopupFormSize = new System.Drawing.Size(450, 260);
            this._glkOrderItemStep.Properties.PopupView = this._viewOrderItemStep;
            this._glkOrderItemStep.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this._glkOrderItemStep.Properties.ValueMember = "ID_HOSODIEUTRI";
            this._glkOrderItemStep.Size = new System.Drawing.Size(244, 24);
            this._glkOrderItemStep.TabIndex = 420;
            this._glkOrderItemStep.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this._glkOrderItemStep_ButtonClick);
            // 
            // _viewOrderItemStep
            // 
            this._viewOrderItemStep.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._gcStepNo,
            this._gcStepDoctorFullName,
            this._gcStepAssistantFullName,
            this._gcStepContent,
            this._gcStepId});
            this._viewOrderItemStep.DetailHeight = 182;
            this._viewOrderItemStep.FixedLineWidth = 1;
            this._viewOrderItemStep.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this._viewOrderItemStep.LevelIndent = 0;
            this._viewOrderItemStep.Name = "_viewOrderItemStep";
            this._viewOrderItemStep.OptionsBehavior.AutoExpandAllGroups = true;
            this._viewOrderItemStep.OptionsSelection.EnableAppearanceFocusedCell = false;
            this._viewOrderItemStep.OptionsView.ShowAutoFilterRow = true;
            this._viewOrderItemStep.OptionsView.ShowGroupPanel = false;
            this._viewOrderItemStep.PreviewIndent = 0;
            // 
            // _gcStepNo
            // 
            this._gcStepNo.Caption = "STT";
            this._gcStepNo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this._gcStepNo.MinWidth = 37;
            this._gcStepNo.Name = "_gcStepNo";
            this._gcStepNo.Visible = true;
            this._gcStepNo.VisibleIndex = 0;
            this._gcStepNo.Width = 37;
            // 
            // _gcStepDoctorFullName
            // 
            this._gcStepDoctorFullName.Caption = "Bác sĩ";
            this._gcStepDoctorFullName.MinWidth = 60;
            this._gcStepDoctorFullName.Name = "_gcStepDoctorFullName";
            this._gcStepDoctorFullName.Visible = true;
            this._gcStepDoctorFullName.VisibleIndex = 1;
            this._gcStepDoctorFullName.Width = 60;
            // 
            // _gcStepAssistantFullName
            // 
            this._gcStepAssistantFullName.Caption = "Phụ tá";
            this._gcStepAssistantFullName.MinWidth = 10;
            this._gcStepAssistantFullName.Name = "_gcStepAssistantFullName";
            this._gcStepAssistantFullName.Visible = true;
            this._gcStepAssistantFullName.VisibleIndex = 2;
            this._gcStepAssistantFullName.Width = 37;
            // 
            // _gcStepContent
            // 
            this._gcStepContent.Caption = "Nội dung";
            this._gcStepContent.FieldName = "Name";
            this._gcStepContent.MinWidth = 100;
            this._gcStepContent.Name = "_gcStepContent";
            this._gcStepContent.Visible = true;
            this._gcStepContent.VisibleIndex = 3;
            this._gcStepContent.Width = 100;
            // 
            // _gcStepId
            // 
            this._gcStepId.Caption = "Mã";
            this._gcStepId.FieldName = "Id";
            this._gcStepId.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcStepId.MinWidth = 37;
            this._gcStepId.Name = "_gcStepId";
            this._gcStepId.Visible = true;
            this._gcStepId.VisibleIndex = 4;
            this._gcStepId.Width = 37;
            // 
            // _tblPrices
            // 
            this._tblPrices.ColumnCount = 2;
            this._tblPrices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tblPrices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tblPrices.Controls.Add(this._calcEndFee, 0, 0);
            this._tblPrices.Controls.Add(this._calcStartFee, 0, 0);
            this._tblPrices.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tblPrices.Location = new System.Drawing.Point(767, 134);
            this._tblPrices.Margin = new System.Windows.Forms.Padding(0);
            this._tblPrices.Name = "_tblPrices";
            this._tblPrices.RowCount = 1;
            this._tblPrices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tblPrices.Size = new System.Drawing.Size(246, 22);
            this._tblPrices.TabIndex = 421;
            // 
            // _calcEndFee
            // 
            this._calcEndFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this._calcEndFee.Location = new System.Drawing.Point(124, 1);
            this._calcEndFee.Margin = new System.Windows.Forms.Padding(1);
            this._calcEndFee.Name = "_calcEndFee";
            this._calcEndFee.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._calcEndFee.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this._calcEndFee.Properties.Appearance.Options.UseFont = true;
            this._calcEndFee.Properties.Appearance.Options.UseForeColor = true;
            this._calcEndFee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._calcEndFee.Properties.DisplayFormat.FormatString = "n0";
            this._calcEndFee.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._calcEndFee.Properties.EditFormat.FormatString = "n0";
            this._calcEndFee.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._calcEndFee.Properties.Mask.EditMask = "n0";
            this._calcEndFee.Properties.ReadOnly = true;
            this._calcEndFee.Size = new System.Drawing.Size(121, 20);
            this._calcEndFee.TabIndex = 8;
            // 
            // _calcStartFee
            // 
            this._calcStartFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this._calcStartFee.Location = new System.Drawing.Point(1, 1);
            this._calcStartFee.Margin = new System.Windows.Forms.Padding(1);
            this._calcStartFee.Name = "_calcStartFee";
            this._calcStartFee.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._calcStartFee.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this._calcStartFee.Properties.Appearance.Options.UseFont = true;
            this._calcStartFee.Properties.Appearance.Options.UseForeColor = true;
            this._calcStartFee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._calcStartFee.Properties.DisplayFormat.FormatString = "n0";
            this._calcStartFee.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._calcStartFee.Properties.EditFormat.FormatString = "n0";
            this._calcStartFee.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._calcStartFee.Properties.Mask.EditMask = "n0";
            this._calcStartFee.Properties.ReadOnly = true;
            this._calcStartFee.Size = new System.Drawing.Size(121, 20);
            this._calcStartFee.TabIndex = 7;
            // 
            // _lblPrices
            // 
            this._lblPrices.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._lblPrices.Appearance.Options.UseFont = true;
            this._lblPrices.Location = new System.Drawing.Point(689, 137);
            this._lblPrices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._lblPrices.Name = "_lblPrices";
            this._lblPrices.Size = new System.Drawing.Size(24, 14);
            this._lblPrices.TabIndex = 422;
            this._lblPrices.Text = "Phí:";
            // 
            // panel1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel1, 6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 156);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 22);
            this.panel1.TabIndex = 423;
            // 
            // _btnAdd
            // 
            this._btnAdd.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnAdd.Appearance.ForeColor = System.Drawing.Color.Green;
            this._btnAdd.Appearance.Options.UseFont = true;
            this._btnAdd.Appearance.Options.UseForeColor = true;
            this._btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnAdd.ImageOptions.Image")));
            this._btnAdd.ImageOptions.ImageIndex = 2;
            this._btnAdd.Location = new System.Drawing.Point(4, 186);
            this._btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this._btnAdd.Size = new System.Drawing.Size(107, 35);
            this._btnAdd.TabIndex = 4;
            this._btnAdd.Text = "Tạo mới";
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_DatLabo_Click);
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.labelControl22.Appearance.Options.UseFont = true;
            this.labelControl22.Location = new System.Drawing.Point(1148, 195);
            this.labelControl22.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(53, 14);
            this.labelControl22.TabIndex = 122;
            this.labelControl22.Text = "Đơn giá:";
            this.labelControl22.Visible = false;
            // 
            // _calcUnitPrice
            // 
            this._calcUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._calcUnitPrice.Location = new System.Drawing.Point(890, 193);
            this._calcUnitPrice.Margin = new System.Windows.Forms.Padding(1);
            this._calcUnitPrice.Name = "_calcUnitPrice";
            this._calcUnitPrice.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._calcUnitPrice.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this._calcUnitPrice.Properties.Appearance.Options.UseFont = true;
            this._calcUnitPrice.Properties.Appearance.Options.UseForeColor = true;
            this._calcUnitPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._calcUnitPrice.Properties.DisplayFormat.FormatString = "n0";
            this._calcUnitPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._calcUnitPrice.Properties.EditFormat.FormatString = "n0";
            this._calcUnitPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._calcUnitPrice.Properties.Mask.EditMask = "n0";
            this._calcUnitPrice.Properties.ReadOnly = true;
            this._calcUnitPrice.Size = new System.Drawing.Size(120, 20);
            this._calcUnitPrice.TabIndex = 5;
            this._calcUnitPrice.EditValueChanged += new System.EventHandler(this.cdtDonGia_EditValueChanged);
            // 
            // UcOrderItemLabos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UcOrderItemLabos";
            this.Size = new System.Drawing.Size(1024, 600);
            this.Load += new System.EventHandler(this.UcBookLabo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkSuaDatLabo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkXoaDatLabo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._rCheckSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cbbAutoPrintMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbAutoPrint.Properties)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._glkProvider.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkDMVatlieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMauSu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._calcAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbSelectLaboCreatorDoctor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNamBH.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNamBH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTheBH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayHen.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayHen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayGiao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayGiao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayDat.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayDat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbSelectLaboAssistant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbLaboPhanLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtNotes.Properties)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._cbbLaboRang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbSelectOrderItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._glkOrderItemStep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._viewOrderItemStep)).EndInit();
            this._tblPrices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._calcEndFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._calcStartFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._calcUnitPrice.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.CheckEdit _cbAutoPrint;
        private DevExpress.XtraEditors.SimpleButton _btnPrint;
        private DevExpress.XtraEditors.SimpleButton _btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl _lblUnitPrice;
        private DevExpress.XtraEditors.GridLookUpEdit _glkProvider;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn55;
        private DevExpress.XtraEditors.GridLookUpEdit glkDMVatlieu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn56;
        private DevExpress.XtraEditors.TextEdit txtMauSu;
        private DevExpress.XtraEditors.CalcEdit _calcAmount;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.CalcEdit _calcStartFee;
        private DevExpress.XtraEditors.GridLookUpEdit glkTrangThai;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView12;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboName;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private SBoxUserAccount _cbbSelectLaboCreatorDoctor;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.DateEdit dtNamBH;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.TextEdit txtTheBH;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.DateEdit dtNgayHen;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.DateEdit dtNgayGiao;
        private DevExpress.XtraEditors.LabelControl labelControl39;
        private DevExpress.XtraEditors.DateEdit dtNgayDat;
        private DevExpress.XtraEditors.LabelControl labelControl41;
        private SBoxUserAccount _cbbSelectLaboAssistant;
        private DevExpress.XtraEditors.LabelControl labelControl42;
        private DevExpress.XtraEditors.LookUpEdit _cbbLaboPhanLoai;
        private DevExpress.XtraEditors.LabelControl _lblNote;
        private DevExpress.XtraEditors.MemoEdit _txtNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.SimpleButton _btnLaboSelectMultiTeeth;
        private DevExpress.XtraEditors.GridLookUpEdit _cbbLaboRang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn102;
        private DevExpress.XtraEditors.SimpleButton _btnAdd;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.CalcEdit _calcUnitPrice;
        private DevExpress.XtraGrid.GridControl _grid;
        private DevExpress.XtraGrid.Views.Grid.GridView _view;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboId;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit lnkSuaDatLabo;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit lnkXoaDatLabo;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboGoal;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboMaterialName;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboColor;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboTeeth;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboAmount;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboRequestDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboResponseDate;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboUsingDate;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboWarrantyCard;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboWarrantyYear;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboTotalMoney;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboAssistantFullName;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboNote;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboStatus;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboDoctorUserFullName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private SBoxOrderItem _cbbSelectOrderItem;
      
        private DevExpress.XtraEditors.GridLookUpEdit _glkOrderItemStep;
        private DevExpress.XtraGrid.Views.Grid.GridView _viewOrderItemStep;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.TableLayoutPanel _tblPrices;
       
        private DevExpress.XtraEditors.LabelControl _lblPrices;
        private DevExpress.XtraEditors.CalcEdit _calcEndFee;
        private DevExpress.XtraGrid.Columns.GridColumn _gcStepId;
        private DevExpress.XtraGrid.Columns.GridColumn _gcStepContent;
        private DevExpress.XtraGrid.Columns.GridColumn _gcStepNo;
        private DevExpress.XtraGrid.Columns.GridColumn _gcStepDoctorFullName;
        private DevExpress.XtraGrid.Columns.GridColumn _gcStepAssistantFullName;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboOrderId;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboOrderItemName;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboOrderItemStepContent;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboRootFee;
        private DevExpress.XtraGrid.Columns.GridColumn _gcLaboFeeFinal;
        private DevExpress.XtraEditors.SimpleButton _btnSaveNew;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LookUpEdit _cbbAutoPrintMode;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit _rCheckSelect;
    }
}
