using VegunSoft.Acc.Data.Enums;
using VegunSoft.Acc.Editor.Dev.Acc;
using VegunSoft.Layer.EValue.App;
using VegunSoft.Layer.UcControl.Any.Provider.Boxes.GridLookup;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    partial class UcCustomerPrescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcCustomerPrescription));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridBSDT_Toathuoc_CT = new DevExpress.XtraGrid.GridControl();
            this.viewBSDT_Toathuoc_CT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gcPrescriptionDrugIndex = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcPrescriptionDrugName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcPrescriptionDrugQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcPrescriptionDrugUsing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.memoCachDungDayDu = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this._gcPrescriptionDrugIsFromTemplate = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcPrescriptionDrugDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lnkXoaToaCT = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayToaThuoc = new DevExpress.XtraEditors.DateEdit();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.memoChuanDoanToaThuoc = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this._cbbSelectPrescriptionDoctor = new SBoxUserAccount();
            this.btnInToathuoc = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoiToaThuoc = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuuToaThuoc = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.btnUp = new DevExpress.XtraEditors.SimpleButton();
            this.btnDown = new DevExpress.XtraEditors.SimpleButton();
            this._btnResetDrugForm = new DevExpress.XtraEditors.SimpleButton();
            this._btnShowPrescriptionTemplates = new DevExpress.XtraEditors.SimpleButton();
            this._btnSaveDrugs = new DevExpress.XtraEditors.SimpleButton();
            this._cbxIsDeleteTemplateDrugsOnly = new DevExpress.XtraEditors.CheckEdit();
            this._btnDeleteSelectedDrugs = new DevExpress.XtraEditors.SimpleButton();
            this._cbbNightCategoryUnit = new SBoxObjectUnit();
            this._cbbAfternoonCategoryUnit = new SBoxObjectUnit();
            this._cbbNoonCategoryUnit = new SBoxObjectUnit();
            this._cbbMorningCategoryUnit = new SBoxObjectUnit();
            this._cbbCategoryUnit = new SBoxObjectUnit();
            this._cbbCategoryDrugUsing = new SBoxDrugUsing();
            this._btnSelectPrescriptionTemplate = new DevExpress.XtraEditors.SimpleButton();
            this._cbbPrescriptionTemplate = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gccPrescriptionTemplateId = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gccPrescriptionTemplateName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl47 = new DevExpress.XtraEditors.LabelControl();
            this._btnAddDrugs = new DevExpress.XtraEditors.SimpleButton();
            this._txtDrugNote = new DevExpress.XtraEditors.TextEdit();
            this.labelControl37 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl36 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl38 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl35 = new DevExpress.XtraEditors.LabelControl();
            this._txtDrugQuanttity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl34 = new DevExpress.XtraEditors.LabelControl();
            this._txtDrugQuanttityNight = new DevExpress.XtraEditors.TextEdit();
            this._txtDrugQuanttityAfternoon = new DevExpress.XtraEditors.TextEdit();
            this._txtDrugQuanttityNoon = new DevExpress.XtraEditors.TextEdit();
            this._txtDrugQuanttityMorning = new DevExpress.XtraEditors.TextEdit();
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this._txtCategoryDrugUsingTimes = new DevExpress.XtraEditors.TextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this._cbbDrugs = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gccCategoryDrugName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gccCategoryDrugUnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gccCategoryDrugUsingName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl9 = new DevExpress.XtraEditors.GroupControl();
            this.gridDSToathuoc = new DevExpress.XtraGrid.GridControl();
            this.viewDSToathuoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gcPrescriptionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcPrescriptionCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcPrescriptionEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lnkSuaToaThuoc = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this._gcPrescriptionDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lnkXoaToaThuoc = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBSDT_Toathuoc_CT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBSDT_Toathuoc_CT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoCachDungDayDu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkXoaToaCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayToaThuoc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayToaThuoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoChuanDoanToaThuoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbSelectPrescriptionDoctor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cbxIsDeleteTemplateDrugsOnly.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbNightCategoryUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbAfternoonCategoryUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbNoonCategoryUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbMorningCategoryUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbCategoryUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbCategoryDrugUsing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbPrescriptionTemplate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtDrugNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtDrugQuanttity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtDrugQuanttityNight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtDrugQuanttityAfternoon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtDrugQuanttityNoon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtDrugQuanttityMorning.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtCategoryDrugUsingTimes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbDrugs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).BeginInit();
            this.groupControl9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSToathuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDSToathuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkSuaToaThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkXoaToaThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridBSDT_Toathuoc_CT, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelControl5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelControl6, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1297, 729);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gridBSDT_Toathuoc_CT
            // 
            this.gridBSDT_Toathuoc_CT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBSDT_Toathuoc_CT.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBSDT_Toathuoc_CT.Location = new System.Drawing.Point(3, 277);
            this.gridBSDT_Toathuoc_CT.MainView = this.viewBSDT_Toathuoc_CT;
            this.gridBSDT_Toathuoc_CT.Name = "gridBSDT_Toathuoc_CT";
            this.gridBSDT_Toathuoc_CT.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lnkXoaToaCT,
            this.memoCachDungDayDu});
            this.gridBSDT_Toathuoc_CT.Size = new System.Drawing.Size(1291, 449);
            this.gridBSDT_Toathuoc_CT.TabIndex = 10;
            this.gridBSDT_Toathuoc_CT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewBSDT_Toathuoc_CT});
            // 
            // viewBSDT_Toathuoc_CT
            // 
            this.viewBSDT_Toathuoc_CT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._gcPrescriptionDrugIndex,
            this._gcPrescriptionDrugName,
            this._gcPrescriptionDrugQuantity,
            this._gcPrescriptionDrugUsing,
            this._gcPrescriptionDrugIsFromTemplate,
            this._gcPrescriptionDrugDelete});
            this.viewBSDT_Toathuoc_CT.GridControl = this.gridBSDT_Toathuoc_CT;
            this.viewBSDT_Toathuoc_CT.Name = "viewBSDT_Toathuoc_CT";
            this.viewBSDT_Toathuoc_CT.OptionsView.RowAutoHeight = true;
            this.viewBSDT_Toathuoc_CT.OptionsView.ShowGroupPanel = false;
            // 
            // _gcPrescriptionDrugIndex
            // 
            this._gcPrescriptionDrugIndex.AppearanceCell.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gcPrescriptionDrugIndex.AppearanceCell.Options.UseFont = true;
            this._gcPrescriptionDrugIndex.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gcPrescriptionDrugIndex.AppearanceHeader.Options.UseFont = true;
            this._gcPrescriptionDrugIndex.Caption = "STT";
            this._gcPrescriptionDrugIndex.FieldName = "STT";
            this._gcPrescriptionDrugIndex.Name = "_gcPrescriptionDrugIndex";
            this._gcPrescriptionDrugIndex.OptionsColumn.AllowEdit = false;
            this._gcPrescriptionDrugIndex.Visible = true;
            this._gcPrescriptionDrugIndex.VisibleIndex = 0;
            this._gcPrescriptionDrugIndex.Width = 45;
            // 
            // _gcPrescriptionDrugName
            // 
            this._gcPrescriptionDrugName.AppearanceCell.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gcPrescriptionDrugName.AppearanceCell.Options.UseFont = true;
            this._gcPrescriptionDrugName.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gcPrescriptionDrugName.AppearanceHeader.Options.UseFont = true;
            this._gcPrescriptionDrugName.Caption = "Thuốc";
            this._gcPrescriptionDrugName.FieldName = "TEN_DMHANGHOA";
            this._gcPrescriptionDrugName.Name = "_gcPrescriptionDrugName";
            this._gcPrescriptionDrugName.OptionsColumn.AllowEdit = false;
            this._gcPrescriptionDrugName.Visible = true;
            this._gcPrescriptionDrugName.VisibleIndex = 1;
            this._gcPrescriptionDrugName.Width = 218;
            // 
            // _gcPrescriptionDrugQuantity
            // 
            this._gcPrescriptionDrugQuantity.AppearanceCell.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gcPrescriptionDrugQuantity.AppearanceCell.Options.UseFont = true;
            this._gcPrescriptionDrugQuantity.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gcPrescriptionDrugQuantity.AppearanceHeader.Options.UseFont = true;
            this._gcPrescriptionDrugQuantity.Caption = "SL";
            this._gcPrescriptionDrugQuantity.FieldName = "SOLUONG";
            this._gcPrescriptionDrugQuantity.Name = "_gcPrescriptionDrugQuantity";
            this._gcPrescriptionDrugQuantity.Visible = true;
            this._gcPrescriptionDrugQuantity.VisibleIndex = 2;
            this._gcPrescriptionDrugQuantity.Width = 39;
            // 
            // _gcPrescriptionDrugUsing
            // 
            this._gcPrescriptionDrugUsing.AppearanceCell.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gcPrescriptionDrugUsing.AppearanceCell.Options.UseFont = true;
            this._gcPrescriptionDrugUsing.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gcPrescriptionDrugUsing.AppearanceHeader.Options.UseFont = true;
            this._gcPrescriptionDrugUsing.Caption = "Cách dùng";
            this._gcPrescriptionDrugUsing.ColumnEdit = this.memoCachDungDayDu;
            this._gcPrescriptionDrugUsing.FieldName = "CACHDUNGDAYDU";
            this._gcPrescriptionDrugUsing.Name = "_gcPrescriptionDrugUsing";
            this._gcPrescriptionDrugUsing.Visible = true;
            this._gcPrescriptionDrugUsing.VisibleIndex = 3;
            this._gcPrescriptionDrugUsing.Width = 320;
            // 
            // memoCachDungDayDu
            // 
            this.memoCachDungDayDu.Name = "memoCachDungDayDu";
            // 
            // _gcPrescriptionDrugIsFromTemplate
            // 
            this._gcPrescriptionDrugIsFromTemplate.AppearanceCell.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gcPrescriptionDrugIsFromTemplate.AppearanceCell.Options.UseFont = true;
            this._gcPrescriptionDrugIsFromTemplate.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gcPrescriptionDrugIsFromTemplate.AppearanceHeader.Options.UseFont = true;
            this._gcPrescriptionDrugIsFromTemplate.Caption = "Toa mẫu";
            this._gcPrescriptionDrugIsFromTemplate.Name = "_gcPrescriptionDrugIsFromTemplate";
            this._gcPrescriptionDrugIsFromTemplate.Visible = true;
            this._gcPrescriptionDrugIsFromTemplate.VisibleIndex = 4;
            // 
            // _gcPrescriptionDrugDelete
            // 
            this._gcPrescriptionDrugDelete.AppearanceCell.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gcPrescriptionDrugDelete.AppearanceCell.Options.UseFont = true;
            this._gcPrescriptionDrugDelete.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gcPrescriptionDrugDelete.AppearanceHeader.Options.UseFont = true;
            this._gcPrescriptionDrugDelete.AppearanceHeader.Options.UseTextOptions = true;
            this._gcPrescriptionDrugDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._gcPrescriptionDrugDelete.Caption = "Xóa";
            this._gcPrescriptionDrugDelete.ColumnEdit = this.lnkXoaToaCT;
            this._gcPrescriptionDrugDelete.Name = "_gcPrescriptionDrugDelete";
            this._gcPrescriptionDrugDelete.Visible = true;
            this._gcPrescriptionDrugDelete.VisibleIndex = 5;
            this._gcPrescriptionDrugDelete.Width = 54;
            // 
            // lnkXoaToaCT
            // 
            this.lnkXoaToaCT.AutoHeight = false;
            this.lnkXoaToaCT.Image = ((System.Drawing.Image)(resources.GetObject("lnkXoaToaCT.Image")));
            this.lnkXoaToaCT.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lnkXoaToaCT.Name = "lnkXoaToaCT";
            this.lnkXoaToaCT.Click += new System.EventHandler(this.lnkXoaToaCT_Click);
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.tableLayoutPanel7);
            this.panelControl5.Controls.Add(this.btnInToathuoc);
            this.panelControl5.Controls.Add(this.btnThemMoiToaThuoc);
            this.panelControl5.Controls.Add(this.btnLuuToaThuoc);
            this.panelControl5.Location = new System.Drawing.Point(3, 3);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(1270, 106);
            this.panelControl5.TabIndex = 8;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.labelControl28, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.dtNgayToaThuoc, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.labelControl29, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.memoChuanDoanToaThuoc, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.labelControl30, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this._cbbSelectPrescriptionDoctor, 1, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1266, 57);
            this.tableLayoutPanel7.TabIndex = 26;
            // 
            // labelControl28
            // 
            this.labelControl28.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl28.Appearance.Options.UseFont = true;
            this.labelControl28.Location = new System.Drawing.Point(3, 3);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(60, 14);
            this.labelControl28.TabIndex = 3;
            this.labelControl28.Text = "Ngày giờ:";
            // 
            // dtNgayToaThuoc
            // 
            this.dtNgayToaThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtNgayToaThuoc.EditValue = null;
            this.dtNgayToaThuoc.Location = new System.Drawing.Point(90, 1);
            this.dtNgayToaThuoc.Margin = new System.Windows.Forms.Padding(1);
            this.dtNgayToaThuoc.Name = "dtNgayToaThuoc";
            this.dtNgayToaThuoc.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayToaThuoc.Properties.Appearance.Options.UseFont = true;
            this.dtNgayToaThuoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayToaThuoc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayToaThuoc.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.dtNgayToaThuoc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayToaThuoc.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.dtNgayToaThuoc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayToaThuoc.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this.dtNgayToaThuoc.Size = new System.Drawing.Size(546, 20);
            this.dtNgayToaThuoc.TabIndex = 4;
            // 
            // labelControl29
            // 
            this.labelControl29.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl29.Appearance.Options.UseFont = true;
            this.labelControl29.Location = new System.Drawing.Point(3, 25);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(83, 14);
            this.labelControl29.TabIndex = 5;
            this.labelControl29.Text = "Người ra toa:";
            // 
            // memoChuanDoanToaThuoc
            // 
            this.memoChuanDoanToaThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoChuanDoanToaThuoc.Location = new System.Drawing.Point(719, 1);
            this.memoChuanDoanToaThuoc.Margin = new System.Windows.Forms.Padding(1);
            this.memoChuanDoanToaThuoc.Name = "memoChuanDoanToaThuoc";
            this.memoChuanDoanToaThuoc.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoChuanDoanToaThuoc.Properties.Appearance.Options.UseFont = true;
            this.tableLayoutPanel7.SetRowSpan(this.memoChuanDoanToaThuoc, 2);
            this.memoChuanDoanToaThuoc.Size = new System.Drawing.Size(546, 52);
            this.memoChuanDoanToaThuoc.TabIndex = 8;
            // 
            // labelControl30
            // 
            this.labelControl30.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl30.Appearance.Options.UseFont = true;
            this.labelControl30.Location = new System.Drawing.Point(640, 3);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(74, 14);
            this.labelControl30.TabIndex = 7;
            this.labelControl30.Text = "Chẩn đoán:";
            // 
            // _cbbSelectPrescriptionDoctor
            // 
            this._cbbSelectPrescriptionDoctor.BranchId = null;
            this._cbbSelectPrescriptionDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cbbSelectPrescriptionDoctor.FilterModelFunc = null;
            this._cbbSelectPrescriptionDoctor.IsAutoLoadData = true;
            this._cbbSelectPrescriptionDoctor.IsHideDeleteButton = false;
            this._cbbSelectPrescriptionDoctor.IsIgnoreAdmin = false;
            this._cbbSelectPrescriptionDoctor.IsUseValueAsDisplayName = false;
            this._cbbSelectPrescriptionDoctor.Location = new System.Drawing.Point(90, 23);
            this._cbbSelectPrescriptionDoctor.Margin = new System.Windows.Forms.Padding(1);
            this._cbbSelectPrescriptionDoctor.Name = "_cbbSelectPrescriptionDoctor";
            this._cbbSelectPrescriptionDoctor.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbbSelectPrescriptionDoctor.Properties.Appearance.Options.UseFont = true;
            this._cbbSelectPrescriptionDoctor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this._cbbSelectPrescriptionDoctor.Properties.DisplayMember = "FullName";
            this._cbbSelectPrescriptionDoctor.Properties.NullText = "--- Chọn ---";
            this._cbbSelectPrescriptionDoctor.SameDataSourceControls = null;
            this._cbbSelectPrescriptionDoctor.Scope = EUserAccountScope.Default;
            this._cbbSelectPrescriptionDoctor.Size = new System.Drawing.Size(546, 20);
            this._cbbSelectPrescriptionDoctor.TabIndex = 37;
            // 
            // btnInToathuoc
            // 
            this.btnInToathuoc.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnInToathuoc.Appearance.Options.UseFont = true;
            this.btnInToathuoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInToathuoc.ImageOptions.Image")));
            this.btnInToathuoc.ImageOptions.ImageIndex = 1;
            this.btnInToathuoc.Location = new System.Drawing.Point(255, 65);
            this.btnInToathuoc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInToathuoc.Name = "btnInToathuoc";
            this.btnInToathuoc.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnInToathuoc.Size = new System.Drawing.Size(111, 35);
            this.btnInToathuoc.TabIndex = 25;
            this.btnInToathuoc.Text = "In";
            this.btnInToathuoc.Click += new System.EventHandler(this.btnInToathuoc_Click);
            // 
            // btnThemMoiToaThuoc
            // 
            this.btnThemMoiToaThuoc.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnThemMoiToaThuoc.Appearance.ForeColor = System.Drawing.Color.Green;
            this.btnThemMoiToaThuoc.Appearance.Options.UseFont = true;
            this.btnThemMoiToaThuoc.Appearance.Options.UseForeColor = true;
            this.btnThemMoiToaThuoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoiToaThuoc.ImageOptions.Image")));
            this.btnThemMoiToaThuoc.ImageOptions.ImageIndex = 2;
            this.btnThemMoiToaThuoc.Location = new System.Drawing.Point(15, 65);
            this.btnThemMoiToaThuoc.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnThemMoiToaThuoc.Name = "btnThemMoiToaThuoc";
            this.btnThemMoiToaThuoc.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.btnThemMoiToaThuoc.Size = new System.Drawing.Size(111, 35);
            this.btnThemMoiToaThuoc.TabIndex = 24;
            this.btnThemMoiToaThuoc.Text = "Tạo mới";
            this.btnThemMoiToaThuoc.Click += new System.EventHandler(this.btnThemMoiToaThuoc_Click);
            // 
            // btnLuuToaThuoc
            // 
            this.btnLuuToaThuoc.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnLuuToaThuoc.Appearance.Options.UseFont = true;
            this.btnLuuToaThuoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuToaThuoc.ImageOptions.Image")));
            this.btnLuuToaThuoc.ImageOptions.ImageIndex = 1;
            this.btnLuuToaThuoc.Location = new System.Drawing.Point(136, 65);
            this.btnLuuToaThuoc.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnLuuToaThuoc.Name = "btnLuuToaThuoc";
            this.btnLuuToaThuoc.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.btnLuuToaThuoc.Size = new System.Drawing.Size(111, 35);
            this.btnLuuToaThuoc.TabIndex = 23;
            this.btnLuuToaThuoc.Text = "Lưu";
            this.btnLuuToaThuoc.Click += new System.EventHandler(this.btnLuuToaThuoc_Click);
            // 
            // panelControl6
            // 
            this.panelControl6.Controls.Add(this.btnUp);
            this.panelControl6.Controls.Add(this.btnDown);
            this.panelControl6.Controls.Add(this._btnResetDrugForm);
            this.panelControl6.Controls.Add(this._btnShowPrescriptionTemplates);
            this.panelControl6.Controls.Add(this._btnSaveDrugs);
            this.panelControl6.Controls.Add(this._cbxIsDeleteTemplateDrugsOnly);
            this.panelControl6.Controls.Add(this._btnDeleteSelectedDrugs);
            this.panelControl6.Controls.Add(this._cbbNightCategoryUnit);
            this.panelControl6.Controls.Add(this._cbbAfternoonCategoryUnit);
            this.panelControl6.Controls.Add(this._cbbNoonCategoryUnit);
            this.panelControl6.Controls.Add(this._cbbMorningCategoryUnit);
            this.panelControl6.Controls.Add(this._cbbCategoryUnit);
            this.panelControl6.Controls.Add(this._cbbCategoryDrugUsing);
            this.panelControl6.Controls.Add(this._btnSelectPrescriptionTemplate);
            this.panelControl6.Controls.Add(this._cbbPrescriptionTemplate);
            this.panelControl6.Controls.Add(this.labelControl47);
            this.panelControl6.Controls.Add(this._btnAddDrugs);
            this.panelControl6.Controls.Add(this._txtDrugNote);
            this.panelControl6.Controls.Add(this.labelControl37);
            this.panelControl6.Controls.Add(this.labelControl36);
            this.panelControl6.Controls.Add(this.labelControl38);
            this.panelControl6.Controls.Add(this.labelControl35);
            this.panelControl6.Controls.Add(this._txtDrugQuanttity);
            this.panelControl6.Controls.Add(this.labelControl34);
            this.panelControl6.Controls.Add(this._txtDrugQuanttityNight);
            this.panelControl6.Controls.Add(this._txtDrugQuanttityAfternoon);
            this.panelControl6.Controls.Add(this._txtDrugQuanttityNoon);
            this.panelControl6.Controls.Add(this._txtDrugQuanttityMorning);
            this.panelControl6.Controls.Add(this.labelControl33);
            this.panelControl6.Controls.Add(this._txtCategoryDrugUsingTimes);
            this.panelControl6.Controls.Add(this.labelControl19);
            this.panelControl6.Controls.Add(this.labelControl31);
            this.panelControl6.Controls.Add(this.labelControl32);
            this.panelControl6.Controls.Add(this._cbbDrugs);
            this.panelControl6.Location = new System.Drawing.Point(3, 115);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(1270, 156);
            this.panelControl6.TabIndex = 9;
            // 
            // btnUp
            // 
            this.btnUp.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Appearance.Options.UseFont = true;
            this.btnUp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.ImageOptions.Image")));
            this.btnUp.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnUp.Location = new System.Drawing.Point(847, 47);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(112, 28);
            this.btnUp.TabIndex = 145;
            this.btnUp.Text = "Lên";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Appearance.Options.UseFont = true;
            this.btnDown.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.ImageOptions.Image")));
            this.btnDown.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnDown.Location = new System.Drawing.Point(961, 47);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(112, 28);
            this.btnDown.TabIndex = 146;
            this.btnDown.Text = "Xuống";
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // _btnResetDrugForm
            // 
            this._btnResetDrugForm.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnResetDrugForm.Appearance.Options.UseFont = true;
            this._btnResetDrugForm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnResetDrugForm.ImageOptions.Image")));
            this._btnResetDrugForm.ImageOptions.ImageIndex = 2;
            this._btnResetDrugForm.Location = new System.Drawing.Point(656, 44);
            this._btnResetDrugForm.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this._btnResetDrugForm.Name = "_btnResetDrugForm";
            this._btnResetDrugForm.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this._btnResetDrugForm.Size = new System.Drawing.Size(175, 30);
            this._btnResetDrugForm.TabIndex = 144;
            this._btnResetDrugForm.Text = "Hủy chọn";
            this._btnResetDrugForm.Click += new System.EventHandler(this._btnResetDrugForm_Click);
            // 
            // _btnShowPrescriptionTemplates
            // 
            this._btnShowPrescriptionTemplates.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnShowPrescriptionTemplates.Appearance.Options.UseFont = true;
            this._btnShowPrescriptionTemplates.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnShowPrescriptionTemplates.ImageOptions.Image")));
            this._btnShowPrescriptionTemplates.ImageOptions.ImageIndex = 2;
            this._btnShowPrescriptionTemplates.Location = new System.Drawing.Point(491, 9);
            this._btnShowPrescriptionTemplates.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this._btnShowPrescriptionTemplates.Name = "_btnShowPrescriptionTemplates";
            this._btnShowPrescriptionTemplates.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this._btnShowPrescriptionTemplates.Size = new System.Drawing.Size(120, 30);
            this._btnShowPrescriptionTemplates.TabIndex = 143;
            this._btnShowPrescriptionTemplates.Text = "Chi tiết...";
            // 
            // _btnSaveDrugs
            // 
            this._btnSaveDrugs.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnSaveDrugs.Appearance.Options.UseFont = true;
            this._btnSaveDrugs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnSaveDrugs.ImageOptions.Image")));
            this._btnSaveDrugs.ImageOptions.ImageIndex = 2;
            this._btnSaveDrugs.Location = new System.Drawing.Point(847, 79);
            this._btnSaveDrugs.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this._btnSaveDrugs.Name = "_btnSaveDrugs";
            this._btnSaveDrugs.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this._btnSaveDrugs.Size = new System.Drawing.Size(226, 30);
            this._btnSaveDrugs.TabIndex = 142;
            this._btnSaveDrugs.Text = "Lưu thuốc";
            this._btnSaveDrugs.Click += new System.EventHandler(this._btnSaveDrugs_Click);
            // 
            // _cbxIsDeleteTemplateDrugsOnly
            // 
            this._cbxIsDeleteTemplateDrugsOnly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._cbxIsDeleteTemplateDrugsOnly.EditValue = true;
            this._cbxIsDeleteTemplateDrugsOnly.Location = new System.Drawing.Point(847, 15);
            this._cbxIsDeleteTemplateDrugsOnly.Margin = new System.Windows.Forms.Padding(2);
            this._cbxIsDeleteTemplateDrugsOnly.Name = "_cbxIsDeleteTemplateDrugsOnly";
            this._cbxIsDeleteTemplateDrugsOnly.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbxIsDeleteTemplateDrugsOnly.Properties.Appearance.Options.UseFont = true;
            this._cbxIsDeleteTemplateDrugsOnly.Properties.Caption = "Chỉ xóa thuốc mới trong toa mẫu";
            this._cbxIsDeleteTemplateDrugsOnly.Properties.ReadOnly = true;
            this._cbxIsDeleteTemplateDrugsOnly.Size = new System.Drawing.Size(226, 20);
            this._cbxIsDeleteTemplateDrugsOnly.TabIndex = 141;
            // 
            // _btnDeleteSelectedDrugs
            // 
            this._btnDeleteSelectedDrugs.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnDeleteSelectedDrugs.Appearance.Options.UseFont = true;
            this._btnDeleteSelectedDrugs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnDeleteSelectedDrugs.ImageOptions.Image")));
            this._btnDeleteSelectedDrugs.ImageOptions.ImageIndex = 2;
            this._btnDeleteSelectedDrugs.Location = new System.Drawing.Point(656, 9);
            this._btnDeleteSelectedDrugs.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this._btnDeleteSelectedDrugs.Name = "_btnDeleteSelectedDrugs";
            this._btnDeleteSelectedDrugs.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this._btnDeleteSelectedDrugs.Size = new System.Drawing.Size(175, 30);
            this._btnDeleteSelectedDrugs.TabIndex = 48;
            this._btnDeleteSelectedDrugs.Text = "Xóa thuốc";
            this._btnDeleteSelectedDrugs.Click += new System.EventHandler(this._btnDeleteSelectedDrugs_Click);
            // 
            // _cbbNightCategoryUnit
            // 
            this._cbbNightCategoryUnit.IsAutoLoadData = true;
            this._cbbNightCategoryUnit.IsHideDeleteButton = false;
            this._cbbNightCategoryUnit.Location = new System.Drawing.Point(711, 121);
            this._cbbNightCategoryUnit.Name = "_cbbNightCategoryUnit";
            this._cbbNightCategoryUnit.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbbNightCategoryUnit.Properties.Appearance.Options.UseFont = true;
            this._cbbNightCategoryUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this._cbbNightCategoryUnit.Properties.NullText = "--- Chọn ---";
            this._cbbNightCategoryUnit.SameDataSourceControls = null;
            this._cbbNightCategoryUnit.Size = new System.Drawing.Size(120, 20);
            this._cbbNightCategoryUnit.TabIndex = 47;
            this._cbbNightCategoryUnit.ToolTip = "Double click để mở form quản lý, khi mở form quản lý, double click vào đầu dòng /" +
    " dòng để chọn và đóng form\r\n";
            // 
            // _cbbAfternoonCategoryUnit
            // 
            this._cbbAfternoonCategoryUnit.IsAutoLoadData = true;
            this._cbbAfternoonCategoryUnit.IsHideDeleteButton = false;
            this._cbbAfternoonCategoryUnit.Location = new System.Drawing.Point(491, 121);
            this._cbbAfternoonCategoryUnit.Name = "_cbbAfternoonCategoryUnit";
            this._cbbAfternoonCategoryUnit.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbbAfternoonCategoryUnit.Properties.Appearance.Options.UseFont = true;
            this._cbbAfternoonCategoryUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this._cbbAfternoonCategoryUnit.Properties.NullText = "--- Chọn ---";
            this._cbbAfternoonCategoryUnit.SameDataSourceControls = null;
            this._cbbAfternoonCategoryUnit.Size = new System.Drawing.Size(120, 20);
            this._cbbAfternoonCategoryUnit.TabIndex = 46;
            this._cbbAfternoonCategoryUnit.ToolTip = "Double click để mở form quản lý, khi mở form quản lý, double click vào đầu dòng /" +
    " dòng để chọn và đóng form\r\n";
            // 
            // _cbbNoonCategoryUnit
            // 
            this._cbbNoonCategoryUnit.IsAutoLoadData = true;
            this._cbbNoonCategoryUnit.IsHideDeleteButton = false;
            this._cbbNoonCategoryUnit.Location = new System.Drawing.Point(711, 84);
            this._cbbNoonCategoryUnit.Name = "_cbbNoonCategoryUnit";
            this._cbbNoonCategoryUnit.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbbNoonCategoryUnit.Properties.Appearance.Options.UseFont = true;
            this._cbbNoonCategoryUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this._cbbNoonCategoryUnit.Properties.NullText = "--- Chọn ---";
            this._cbbNoonCategoryUnit.SameDataSourceControls = null;
            this._cbbNoonCategoryUnit.Size = new System.Drawing.Size(120, 20);
            this._cbbNoonCategoryUnit.TabIndex = 45;
            this._cbbNoonCategoryUnit.ToolTip = "Double click để mở form quản lý, khi mở form quản lý, double click vào đầu dòng /" +
    " dòng để chọn và đóng form\r\n";
            // 
            // _cbbMorningCategoryUnit
            // 
            this._cbbMorningCategoryUnit.IsAutoLoadData = true;
            this._cbbMorningCategoryUnit.IsHideDeleteButton = false;
            this._cbbMorningCategoryUnit.Location = new System.Drawing.Point(491, 84);
            this._cbbMorningCategoryUnit.Name = "_cbbMorningCategoryUnit";
            this._cbbMorningCategoryUnit.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbbMorningCategoryUnit.Properties.Appearance.Options.UseFont = true;
            this._cbbMorningCategoryUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this._cbbMorningCategoryUnit.Properties.NullText = "--- Chọn ---";
            this._cbbMorningCategoryUnit.SameDataSourceControls = null;
            this._cbbMorningCategoryUnit.Size = new System.Drawing.Size(120, 20);
            this._cbbMorningCategoryUnit.TabIndex = 44;
            this._cbbMorningCategoryUnit.ToolTip = "Double click để mở form quản lý, khi mở form quản lý, double click vào đầu dòng /" +
    " dòng để chọn và đóng form\r\n";
            // 
            // _cbbCategoryUnit
            // 
            this._cbbCategoryUnit.IsAutoLoadData = true;
            this._cbbCategoryUnit.IsHideDeleteButton = false;
            this._cbbCategoryUnit.Location = new System.Drawing.Point(491, 49);
            this._cbbCategoryUnit.Name = "_cbbCategoryUnit";
            this._cbbCategoryUnit.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbbCategoryUnit.Properties.Appearance.Options.UseFont = true;
            this._cbbCategoryUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this._cbbCategoryUnit.Properties.NullText = "--- Chọn ---";
            this._cbbCategoryUnit.SameDataSourceControls = null;
            this._cbbCategoryUnit.Size = new System.Drawing.Size(120, 20);
            this._cbbCategoryUnit.TabIndex = 43;
            this._cbbCategoryUnit.ToolTip = "Double click để mở form quản lý, khi mở form quản lý, double click vào đầu dòng /" +
    " dòng để chọn và đóng form\r\n";
            // 
            // _cbbCategoryDrugUsing
            // 
            this._cbbCategoryDrugUsing.IsAutoLoadData = true;
            this._cbbCategoryDrugUsing.IsHideDeleteButton = false;
            this._cbbCategoryDrugUsing.Location = new System.Drawing.Point(84, 84);
            this._cbbCategoryDrugUsing.Name = "_cbbCategoryDrugUsing";
            this._cbbCategoryDrugUsing.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbbCategoryDrugUsing.Properties.Appearance.Options.UseFont = true;
            this._cbbCategoryDrugUsing.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this._cbbCategoryDrugUsing.Properties.NullText = "--- Chọn ---";
            this._cbbCategoryDrugUsing.SameDataSourceControls = null;
            this._cbbCategoryDrugUsing.Size = new System.Drawing.Size(186, 20);
            this._cbbCategoryDrugUsing.TabIndex = 42;
            this._cbbCategoryDrugUsing.ToolTip = "Double click để mở form quản lý, khi mở form quản lý, double click vào đầu dòng /" +
    " dòng để chọn và đóng form\r\n";
            // 
            // _btnSelectPrescriptionTemplate
            // 
            this._btnSelectPrescriptionTemplate.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnSelectPrescriptionTemplate.Appearance.Options.UseFont = true;
            this._btnSelectPrescriptionTemplate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnSelectPrescriptionTemplate.ImageOptions.Image")));
            this._btnSelectPrescriptionTemplate.ImageOptions.ImageIndex = 2;
            this._btnSelectPrescriptionTemplate.Location = new System.Drawing.Point(370, 9);
            this._btnSelectPrescriptionTemplate.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this._btnSelectPrescriptionTemplate.Name = "_btnSelectPrescriptionTemplate";
            this._btnSelectPrescriptionTemplate.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this._btnSelectPrescriptionTemplate.Size = new System.Drawing.Size(120, 30);
            this._btnSelectPrescriptionTemplate.TabIndex = 31;
            this._btnSelectPrescriptionTemplate.Text = "Áp dụng";
            this._btnSelectPrescriptionTemplate.Click += new System.EventHandler(this._btnSelectPrescriptionTemplate_Click);
            // 
            // _cbbPrescriptionTemplate
            // 
            this._cbbPrescriptionTemplate.EditValue = "";
            this._cbbPrescriptionTemplate.Location = new System.Drawing.Point(84, 13);
            this._cbbPrescriptionTemplate.Name = "_cbbPrescriptionTemplate";
            this._cbbPrescriptionTemplate.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbbPrescriptionTemplate.Properties.Appearance.Options.UseFont = true;
            this._cbbPrescriptionTemplate.Properties.DisplayMember = "TEN";
            this._cbbPrescriptionTemplate.Properties.NullText = "";
            this._cbbPrescriptionTemplate.Properties.PopupFormMinSize = new System.Drawing.Size(500, 200);
            this._cbbPrescriptionTemplate.Properties.PopupView = this.gridView8;
            this._cbbPrescriptionTemplate.Properties.ValueMember = "ID";
            this._cbbPrescriptionTemplate.Size = new System.Drawing.Size(273, 20);
            this._cbbPrescriptionTemplate.TabIndex = 30;
            this._cbbPrescriptionTemplate.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this._cbbPrescriptionTemplate_ButtonClick);
            this._cbbPrescriptionTemplate.EditValueChanged += new System.EventHandler(this._cbbPrescriptionTemplate_EditValueChanged);
            // 
            // gridView8
            // 
            this.gridView8.Appearance.HeaderPanel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView8.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView8.Appearance.Row.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView8.Appearance.Row.Options.UseFont = true;
            this.gridView8.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._gccPrescriptionTemplateId,
            this._gccPrescriptionTemplateName});
            this.gridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView8.Name = "gridView8";
            this.gridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView8.OptionsView.ShowGroupPanel = false;
            // 
            // _gccPrescriptionTemplateId
            // 
            this._gccPrescriptionTemplateId.Caption = "ID";
            this._gccPrescriptionTemplateId.FieldName = "ID";
            this._gccPrescriptionTemplateId.Name = "_gccPrescriptionTemplateId";
            this._gccPrescriptionTemplateId.Visible = true;
            this._gccPrescriptionTemplateId.VisibleIndex = 0;
            this._gccPrescriptionTemplateId.Width = 202;
            // 
            // _gccPrescriptionTemplateName
            // 
            this._gccPrescriptionTemplateName.Caption = "Tên";
            this._gccPrescriptionTemplateName.FieldName = "TEN";
            this._gccPrescriptionTemplateName.Name = "_gccPrescriptionTemplateName";
            this._gccPrescriptionTemplateName.Visible = true;
            this._gccPrescriptionTemplateName.VisibleIndex = 1;
            this._gccPrescriptionTemplateName.Width = 873;
            // 
            // labelControl47
            // 
            this.labelControl47.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl47.Appearance.Options.UseFont = true;
            this.labelControl47.Location = new System.Drawing.Point(13, 17);
            this.labelControl47.Name = "labelControl47";
            this.labelControl47.Size = new System.Drawing.Size(58, 14);
            this.labelControl47.TabIndex = 29;
            this.labelControl47.Text = "Toa mẫu:";
            // 
            // _btnAddDrugs
            // 
            this._btnAddDrugs.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnAddDrugs.Appearance.Options.UseFont = true;
            this._btnAddDrugs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnAddDrugs.ImageOptions.Image")));
            this._btnAddDrugs.ImageOptions.ImageIndex = 2;
            this._btnAddDrugs.Location = new System.Drawing.Point(847, 114);
            this._btnAddDrugs.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this._btnAddDrugs.Name = "_btnAddDrugs";
            this._btnAddDrugs.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this._btnAddDrugs.Size = new System.Drawing.Size(226, 30);
            this._btnAddDrugs.TabIndex = 22;
            this._btnAddDrugs.Text = "Chọn thuốc";
            this._btnAddDrugs.Click += new System.EventHandler(this._btnAddDrugs_Click);
            // 
            // _txtDrugNote
            // 
            this._txtDrugNote.Location = new System.Drawing.Point(84, 119);
            this._txtDrugNote.Name = "_txtDrugNote";
            this._txtDrugNote.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtDrugNote.Properties.Appearance.Options.UseFont = true;
            this._txtDrugNote.Size = new System.Drawing.Size(273, 20);
            this._txtDrugNote.TabIndex = 18;
            // 
            // labelControl37
            // 
            this.labelControl37.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl37.Appearance.Options.UseFont = true;
            this.labelControl37.Location = new System.Drawing.Point(13, 122);
            this.labelControl37.Name = "labelControl37";
            this.labelControl37.Size = new System.Drawing.Size(51, 14);
            this.labelControl37.TabIndex = 17;
            this.labelControl37.Text = "Ghi chú:";
            // 
            // labelControl36
            // 
            this.labelControl36.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl36.Appearance.Options.UseFont = true;
            this.labelControl36.Location = new System.Drawing.Point(13, 87);
            this.labelControl36.Name = "labelControl36";
            this.labelControl36.Size = new System.Drawing.Size(61, 14);
            this.labelControl36.TabIndex = 16;
            this.labelControl36.Text = "Mỗi ngày:";
            // 
            // labelControl38
            // 
            this.labelControl38.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl38.Appearance.Options.UseFont = true;
            this.labelControl38.Location = new System.Drawing.Point(372, 52);
            this.labelControl38.Name = "labelControl38";
            this.labelControl38.Size = new System.Drawing.Size(60, 14);
            this.labelControl38.TabIndex = 15;
            this.labelControl38.Text = "Số lượng:";
            // 
            // labelControl35
            // 
            this.labelControl35.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl35.Appearance.Options.UseFont = true;
            this.labelControl35.Location = new System.Drawing.Point(629, 124);
            this.labelControl35.Name = "labelControl35";
            this.labelControl35.Size = new System.Drawing.Size(23, 14);
            this.labelControl35.TabIndex = 15;
            this.labelControl35.Text = "Tối:";
            // 
            // _txtDrugQuanttity
            // 
            this._txtDrugQuanttity.Location = new System.Drawing.Point(436, 49);
            this._txtDrugQuanttity.Name = "_txtDrugQuanttity";
            this._txtDrugQuanttity.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtDrugQuanttity.Properties.Appearance.Options.UseFont = true;
            this._txtDrugQuanttity.Properties.DisplayFormat.FormatString = "n0";
            this._txtDrugQuanttity.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._txtDrugQuanttity.Properties.EditFormat.FormatString = "n0";
            this._txtDrugQuanttity.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._txtDrugQuanttity.Properties.Mask.EditMask = "n0";
            this._txtDrugQuanttity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._txtDrugQuanttity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._txtDrugQuanttity.Size = new System.Drawing.Size(54, 20);
            this._txtDrugQuanttity.TabIndex = 13;
            // 
            // labelControl34
            // 
            this.labelControl34.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl34.Appearance.Options.UseFont = true;
            this.labelControl34.Location = new System.Drawing.Point(391, 124);
            this.labelControl34.Name = "labelControl34";
            this.labelControl34.Size = new System.Drawing.Size(41, 14);
            this.labelControl34.TabIndex = 14;
            this.labelControl34.Text = "Chiều:";
            // 
            // _txtDrugQuanttityNight
            // 
            this._txtDrugQuanttityNight.Location = new System.Drawing.Point(656, 121);
            this._txtDrugQuanttityNight.Name = "_txtDrugQuanttityNight";
            this._txtDrugQuanttityNight.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtDrugQuanttityNight.Properties.Appearance.Options.UseFont = true;
            this._txtDrugQuanttityNight.Properties.DisplayFormat.FormatString = "n0";
            this._txtDrugQuanttityNight.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._txtDrugQuanttityNight.Properties.EditFormat.FormatString = "n0";
            this._txtDrugQuanttityNight.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._txtDrugQuanttityNight.Properties.Mask.EditMask = "n0";
            this._txtDrugQuanttityNight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._txtDrugQuanttityNight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._txtDrugQuanttityNight.Size = new System.Drawing.Size(54, 20);
            this._txtDrugQuanttityNight.TabIndex = 13;
            // 
            // _txtDrugQuanttityAfternoon
            // 
            this._txtDrugQuanttityAfternoon.Location = new System.Drawing.Point(436, 121);
            this._txtDrugQuanttityAfternoon.Name = "_txtDrugQuanttityAfternoon";
            this._txtDrugQuanttityAfternoon.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtDrugQuanttityAfternoon.Properties.Appearance.Options.UseFont = true;
            this._txtDrugQuanttityAfternoon.Properties.DisplayFormat.FormatString = "n0";
            this._txtDrugQuanttityAfternoon.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._txtDrugQuanttityAfternoon.Properties.EditFormat.FormatString = "n0";
            this._txtDrugQuanttityAfternoon.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._txtDrugQuanttityAfternoon.Properties.Mask.EditMask = "n0";
            this._txtDrugQuanttityAfternoon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._txtDrugQuanttityAfternoon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._txtDrugQuanttityAfternoon.Size = new System.Drawing.Size(54, 20);
            this._txtDrugQuanttityAfternoon.TabIndex = 12;
            // 
            // _txtDrugQuanttityNoon
            // 
            this._txtDrugQuanttityNoon.Location = new System.Drawing.Point(656, 84);
            this._txtDrugQuanttityNoon.Name = "_txtDrugQuanttityNoon";
            this._txtDrugQuanttityNoon.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtDrugQuanttityNoon.Properties.Appearance.Options.UseFont = true;
            this._txtDrugQuanttityNoon.Properties.DisplayFormat.FormatString = "n0";
            this._txtDrugQuanttityNoon.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._txtDrugQuanttityNoon.Properties.EditFormat.FormatString = "n0";
            this._txtDrugQuanttityNoon.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._txtDrugQuanttityNoon.Properties.Mask.EditMask = "n0";
            this._txtDrugQuanttityNoon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._txtDrugQuanttityNoon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._txtDrugQuanttityNoon.Size = new System.Drawing.Size(54, 20);
            this._txtDrugQuanttityNoon.TabIndex = 11;
            // 
            // _txtDrugQuanttityMorning
            // 
            this._txtDrugQuanttityMorning.Location = new System.Drawing.Point(436, 84);
            this._txtDrugQuanttityMorning.Name = "_txtDrugQuanttityMorning";
            this._txtDrugQuanttityMorning.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtDrugQuanttityMorning.Properties.Appearance.Options.UseFont = true;
            this._txtDrugQuanttityMorning.Properties.DisplayFormat.FormatString = "n0";
            this._txtDrugQuanttityMorning.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._txtDrugQuanttityMorning.Properties.EditFormat.FormatString = "n0";
            this._txtDrugQuanttityMorning.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._txtDrugQuanttityMorning.Properties.Mask.EditMask = "n0";
            this._txtDrugQuanttityMorning.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._txtDrugQuanttityMorning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._txtDrugQuanttityMorning.Size = new System.Drawing.Size(54, 20);
            this._txtDrugQuanttityMorning.TabIndex = 11;
            // 
            // labelControl33
            // 
            this.labelControl33.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl33.Appearance.Options.UseFont = true;
            this.labelControl33.Location = new System.Drawing.Point(334, 87);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(23, 14);
            this.labelControl33.TabIndex = 10;
            this.labelControl33.Text = "Lần";
            // 
            // _txtCategoryDrugUsingTimes
            // 
            this._txtCategoryDrugUsingTimes.Location = new System.Drawing.Point(276, 84);
            this._txtCategoryDrugUsingTimes.Name = "_txtCategoryDrugUsingTimes";
            this._txtCategoryDrugUsingTimes.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtCategoryDrugUsingTimes.Properties.Appearance.Options.UseFont = true;
            this._txtCategoryDrugUsingTimes.Properties.DisplayFormat.FormatString = "n0";
            this._txtCategoryDrugUsingTimes.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._txtCategoryDrugUsingTimes.Properties.EditFormat.FormatString = "n0";
            this._txtCategoryDrugUsingTimes.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._txtCategoryDrugUsingTimes.Properties.Mask.EditMask = "n0";
            this._txtCategoryDrugUsingTimes.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._txtCategoryDrugUsingTimes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._txtCategoryDrugUsingTimes.Size = new System.Drawing.Size(54, 20);
            this._txtCategoryDrugUsingTimes.TabIndex = 9;
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Location = new System.Drawing.Point(619, 87);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(33, 14);
            this.labelControl19.TabIndex = 7;
            this.labelControl19.Text = "Trưa:";
            // 
            // labelControl31
            // 
            this.labelControl31.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl31.Appearance.Options.UseFont = true;
            this.labelControl31.Location = new System.Drawing.Point(395, 87);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(37, 14);
            this.labelControl31.TabIndex = 7;
            this.labelControl31.Text = "Sáng:";
            // 
            // labelControl32
            // 
            this.labelControl32.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl32.Appearance.Options.UseFont = true;
            this.labelControl32.Location = new System.Drawing.Point(13, 52);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(67, 14);
            this.labelControl32.TabIndex = 6;
            this.labelControl32.Text = "Tên thuốc:";
            // 
            // _cbbDrugs
            // 
            this._cbbDrugs.EditValue = "";
            this._cbbDrugs.Location = new System.Drawing.Point(84, 48);
            this._cbbDrugs.Name = "_cbbDrugs";
            this._cbbDrugs.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbbDrugs.Properties.Appearance.Options.UseFont = true;
            this._cbbDrugs.Properties.DisplayMember = "TEN";
            this._cbbDrugs.Properties.NullText = "";
            this._cbbDrugs.Properties.PopupFormSize = new System.Drawing.Size(700, 300);
            this._cbbDrugs.Properties.PopupView = this.gridLookUpEdit1View;
            this._cbbDrugs.Properties.ValueMember = "ID";
            this._cbbDrugs.Size = new System.Drawing.Size(273, 20);
            this._cbbDrugs.TabIndex = 0;
            this._cbbDrugs.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this._cbbDrugs_ButtonClick);
            this._cbbDrugs.EditValueChanged += new System.EventHandler(this._cbbDrugs_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._gccCategoryDrugName,
            this._gccCategoryDrugUnitName,
            this._gccCategoryDrugUsingName});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // _gccCategoryDrugName
            // 
            this._gccCategoryDrugName.Caption = "Tên hàng hóa";
            this._gccCategoryDrugName.FieldName = "TEN";
            this._gccCategoryDrugName.Name = "_gccCategoryDrugName";
            this._gccCategoryDrugName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Like;
            this._gccCategoryDrugName.Visible = true;
            this._gccCategoryDrugName.VisibleIndex = 0;
            this._gccCategoryDrugName.Width = 226;
            // 
            // _gccCategoryDrugUnitName
            // 
            this._gccCategoryDrugUnitName.Caption = "Đơn vị";
            this._gccCategoryDrugUnitName.FieldName = "TEN_DMDONVI";
            this._gccCategoryDrugUnitName.Name = "_gccCategoryDrugUnitName";
            this._gccCategoryDrugUnitName.Visible = true;
            this._gccCategoryDrugUnitName.VisibleIndex = 1;
            this._gccCategoryDrugUnitName.Width = 69;
            // 
            // _gccCategoryDrugUsingName
            // 
            this._gccCategoryDrugUsingName.Caption = "Cách dùng";
            this._gccCategoryDrugUsingName.FieldName = "TEN_DMDUONGDUNGTHUOC";
            this._gccCategoryDrugUsingName.Name = "_gccCategoryDrugUsingName";
            this._gccCategoryDrugUsingName.Visible = true;
            this._gccCategoryDrugUsingName.VisibleIndex = 2;
            this._gccCategoryDrugUsingName.Width = 357;
            // 
            // groupControl9
            // 
            this.groupControl9.AppearanceCaption.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl9.AppearanceCaption.Options.UseFont = true;
            this.groupControl9.Controls.Add(this.gridDSToathuoc);
            this.groupControl9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl9.Location = new System.Drawing.Point(0, 0);
            this.groupControl9.Name = "groupControl9";
            this.groupControl9.Size = new System.Drawing.Size(299, 729);
            this.groupControl9.TabIndex = 7;
            this.groupControl9.Text = "Danh sách toa";
            // 
            // gridDSToathuoc
            // 
            this.gridDSToathuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDSToathuoc.Location = new System.Drawing.Point(2, 23);
            this.gridDSToathuoc.MainView = this.viewDSToathuoc;
            this.gridDSToathuoc.Name = "gridDSToathuoc";
            this.gridDSToathuoc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lnkSuaToaThuoc,
            this.lnkXoaToaThuoc});
            this.gridDSToathuoc.Size = new System.Drawing.Size(295, 704);
            this.gridDSToathuoc.TabIndex = 3;
            this.gridDSToathuoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewDSToathuoc,
            this.gridView5});
            // 
            // viewDSToathuoc
            // 
            this.viewDSToathuoc.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            this.viewDSToathuoc.Appearance.FocusedRow.Options.UseBackColor = true;
            this.viewDSToathuoc.Appearance.HeaderPanel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.viewDSToathuoc.Appearance.HeaderPanel.Options.UseFont = true;
            this.viewDSToathuoc.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.viewDSToathuoc.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.viewDSToathuoc.Appearance.Row.Font = new System.Drawing.Font("Verdana", 9F);
            this.viewDSToathuoc.Appearance.Row.Options.UseFont = true;
            this.viewDSToathuoc.ColumnPanelRowHeight = 30;
            this.viewDSToathuoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._gcPrescriptionId,
            this._gcPrescriptionCreatedDate,
            this._gcPrescriptionEdit,
            this._gcPrescriptionDelete});
            this.viewDSToathuoc.GridControl = this.gridDSToathuoc;
            this.viewDSToathuoc.IndicatorWidth = 30;
            this.viewDSToathuoc.Name = "viewDSToathuoc";
            this.viewDSToathuoc.OptionsBehavior.ReadOnly = true;
            this.viewDSToathuoc.OptionsView.ShowAutoFilterRow = true;
            this.viewDSToathuoc.OptionsView.ShowGroupPanel = false;
            this.viewDSToathuoc.ViewCaptionHeight = 30;
            this.viewDSToathuoc.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.viewDSToathuoc_FocusedRowChanged);
            // 
            // _gcPrescriptionId
            // 
            this._gcPrescriptionId.Caption = "Mã";
            this._gcPrescriptionId.FieldName = "ID";
            this._gcPrescriptionId.MinWidth = 60;
            this._gcPrescriptionId.Name = "_gcPrescriptionId";
            this._gcPrescriptionId.Visible = true;
            this._gcPrescriptionId.VisibleIndex = 0;
            this._gcPrescriptionId.Width = 72;
            // 
            // _gcPrescriptionCreatedDate
            // 
            this._gcPrescriptionCreatedDate.Caption = "Ngày tạo";
            this._gcPrescriptionCreatedDate.FieldName = "NGAYGIO";
            this._gcPrescriptionCreatedDate.MinWidth = 80;
            this._gcPrescriptionCreatedDate.Name = "_gcPrescriptionCreatedDate";
            this._gcPrescriptionCreatedDate.Visible = true;
            this._gcPrescriptionCreatedDate.VisibleIndex = 1;
            this._gcPrescriptionCreatedDate.Width = 120;
            // 
            // _gcPrescriptionEdit
            // 
            this._gcPrescriptionEdit.Caption = "Sửa";
            this._gcPrescriptionEdit.ColumnEdit = this.lnkSuaToaThuoc;
            this._gcPrescriptionEdit.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcPrescriptionEdit.MaxWidth = 40;
            this._gcPrescriptionEdit.MinWidth = 40;
            this._gcPrescriptionEdit.Name = "_gcPrescriptionEdit";
            this._gcPrescriptionEdit.Visible = true;
            this._gcPrescriptionEdit.VisibleIndex = 2;
            this._gcPrescriptionEdit.Width = 40;
            // 
            // lnkSuaToaThuoc
            // 
            this.lnkSuaToaThuoc.AutoHeight = false;
            this.lnkSuaToaThuoc.Image = ((System.Drawing.Image)(resources.GetObject("lnkSuaToaThuoc.Image")));
            this.lnkSuaToaThuoc.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lnkSuaToaThuoc.Name = "lnkSuaToaThuoc";
            this.lnkSuaToaThuoc.Click += new System.EventHandler(this.lnkSuaToaThuoc_Click);
            // 
            // _gcPrescriptionDelete
            // 
            this._gcPrescriptionDelete.Caption = "Xóa";
            this._gcPrescriptionDelete.ColumnEdit = this.lnkXoaToaThuoc;
            this._gcPrescriptionDelete.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcPrescriptionDelete.MaxWidth = 40;
            this._gcPrescriptionDelete.MinWidth = 40;
            this._gcPrescriptionDelete.Name = "_gcPrescriptionDelete";
            this._gcPrescriptionDelete.Visible = true;
            this._gcPrescriptionDelete.VisibleIndex = 3;
            this._gcPrescriptionDelete.Width = 40;
            // 
            // lnkXoaToaThuoc
            // 
            this.lnkXoaToaThuoc.AutoHeight = false;
            this.lnkXoaToaThuoc.Image = ((System.Drawing.Image)(resources.GetObject("lnkXoaToaThuoc.Image")));
            this.lnkXoaToaThuoc.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lnkXoaToaThuoc.Name = "lnkXoaToaThuoc";
            this.lnkXoaToaThuoc.Click += new System.EventHandler(this.lnkXoaToaThuoc_Click);
            // 
            // gridView5
            // 
            this.gridView5.GridControl = this.gridDSToathuoc;
            this.gridView5.Name = "gridView5";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupControl9);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1600, 729);
            this.splitContainer1.SplitterDistance = 299;
            this.splitContainer1.TabIndex = 1;
            // 
            // UcCustomerPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UcCustomerPrescription";
            this.Size = new System.Drawing.Size(1600, 729);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBSDT_Toathuoc_CT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBSDT_Toathuoc_CT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoCachDungDayDu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkXoaToaCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayToaThuoc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayToaThuoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoChuanDoanToaThuoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbSelectPrescriptionDoctor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            this.panelControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cbxIsDeleteTemplateDrugsOnly.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbNightCategoryUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbAfternoonCategoryUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbNoonCategoryUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbMorningCategoryUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbCategoryUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbCategoryDrugUsing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbPrescriptionTemplate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtDrugNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtDrugQuanttity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtDrugQuanttityNight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtDrugQuanttityAfternoon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtDrugQuanttityNoon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtDrugQuanttityMorning.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtCategoryDrugUsingTimes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbDrugs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).EndInit();
            this.groupControl9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDSToathuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDSToathuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkSuaToaThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkXoaToaThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl9;
        private DevExpress.XtraGrid.GridControl gridDSToathuoc;
        private DevExpress.XtraGrid.Views.Grid.GridView viewDSToathuoc;
        private DevExpress.XtraGrid.Columns.GridColumn _gcPrescriptionId;
        private DevExpress.XtraGrid.Columns.GridColumn _gcPrescriptionCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn _gcPrescriptionEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit lnkSuaToaThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn _gcPrescriptionDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit lnkXoaToaThuoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraEditors.DateEdit dtNgayToaThuoc;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private DevExpress.XtraEditors.MemoEdit memoChuanDoanToaThuoc;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private SBoxUserAccount _cbbSelectPrescriptionDoctor;
        private DevExpress.XtraEditors.SimpleButton btnInToathuoc;
        private DevExpress.XtraEditors.SimpleButton btnThemMoiToaThuoc;
        private DevExpress.XtraEditors.SimpleButton btnLuuToaThuoc;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.SimpleButton btnUp;
        private DevExpress.XtraEditors.SimpleButton btnDown;
        private DevExpress.XtraEditors.SimpleButton _btnResetDrugForm;
        private DevExpress.XtraEditors.SimpleButton _btnShowPrescriptionTemplates;
        private DevExpress.XtraEditors.SimpleButton _btnSaveDrugs;
        private DevExpress.XtraEditors.CheckEdit _cbxIsDeleteTemplateDrugsOnly;
        private DevExpress.XtraEditors.SimpleButton _btnDeleteSelectedDrugs;
        private SBoxObjectUnit _cbbNightCategoryUnit;
        private SBoxObjectUnit _cbbAfternoonCategoryUnit;
        private SBoxObjectUnit _cbbNoonCategoryUnit;
        private SBoxObjectUnit _cbbMorningCategoryUnit;
        private SBoxObjectUnit _cbbCategoryUnit;
        private SBoxDrugUsing _cbbCategoryDrugUsing;
        private DevExpress.XtraEditors.SimpleButton _btnSelectPrescriptionTemplate;
        private DevExpress.XtraEditors.GridLookUpEdit _cbbPrescriptionTemplate;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraGrid.Columns.GridColumn _gccPrescriptionTemplateId;
        private DevExpress.XtraGrid.Columns.GridColumn _gccPrescriptionTemplateName;
        private DevExpress.XtraEditors.LabelControl labelControl47;
        private DevExpress.XtraEditors.SimpleButton _btnAddDrugs;
        private DevExpress.XtraEditors.TextEdit _txtDrugNote;
        private DevExpress.XtraEditors.LabelControl labelControl37;
        private DevExpress.XtraEditors.LabelControl labelControl36;
        private DevExpress.XtraEditors.LabelControl labelControl38;
        private DevExpress.XtraEditors.LabelControl labelControl35;
        private DevExpress.XtraEditors.TextEdit _txtDrugQuanttity;
        private DevExpress.XtraEditors.LabelControl labelControl34;
        private DevExpress.XtraEditors.TextEdit _txtDrugQuanttityNight;
        private DevExpress.XtraEditors.TextEdit _txtDrugQuanttityAfternoon;
        private DevExpress.XtraEditors.TextEdit _txtDrugQuanttityNoon;
        private DevExpress.XtraEditors.TextEdit _txtDrugQuanttityMorning;
        private DevExpress.XtraEditors.LabelControl labelControl33;
        private DevExpress.XtraEditors.TextEdit _txtCategoryDrugUsingTimes;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl31;
        private DevExpress.XtraEditors.LabelControl labelControl32;
        private DevExpress.XtraEditors.GridLookUpEdit _cbbDrugs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn _gccCategoryDrugName;
        private DevExpress.XtraGrid.Columns.GridColumn _gccCategoryDrugUnitName;
        private DevExpress.XtraGrid.Columns.GridColumn _gccCategoryDrugUsingName;
        private DevExpress.XtraGrid.GridControl gridBSDT_Toathuoc_CT;
        private DevExpress.XtraGrid.Views.Grid.GridView viewBSDT_Toathuoc_CT;
        private DevExpress.XtraGrid.Columns.GridColumn _gcPrescriptionDrugIndex;
        private DevExpress.XtraGrid.Columns.GridColumn _gcPrescriptionDrugName;
        private DevExpress.XtraGrid.Columns.GridColumn _gcPrescriptionDrugQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn _gcPrescriptionDrugUsing;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit memoCachDungDayDu;
        private DevExpress.XtraGrid.Columns.GridColumn _gcPrescriptionDrugIsFromTemplate;
        private DevExpress.XtraGrid.Columns.GridColumn _gcPrescriptionDrugDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit lnkXoaToaCT;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
