using DevExpress.XtraGrid.Columns;
using VegunSoft.Acc.Data.Enums;
using VegunSoft.Acc.Editor.Dev.Acc;
using VegunSoft.Base.Editor.Dev.Repositories;
using VegunSoft.Layer.EValue.App;
using VegunSoft.Layer.UcControl.Any.Provider.Boxes.GridLookup;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    partial class UcOrderItemTracks
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcOrderItemTracks));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            this.panel2 = new System.Windows.Forms.Panel();
            this._chkIsHideList = new DevExpress.XtraEditors.CheckEdit();
            this._chkIsMinColumn = new DevExpress.XtraEditors.CheckEdit();
            this._btnWidthLeft = new DevExpress.XtraEditors.SimpleButton();
            this._chkIsGroupByOrderItem = new DevExpress.XtraEditors.CheckEdit();
            this._btnWidthRight = new DevExpress.XtraEditors.SimpleButton();
            this._chkIsGroupByOrder = new DevExpress.XtraEditors.CheckEdit();
            this._chkReduce = new DevExpress.XtraEditors.CheckEdit();
            this._chbIsShowAllHistoriesOfOrders = new DevExpress.XtraEditors.CheckEdit();
            this._chbIsShowAllHistoriesOfCustomers = new DevExpress.XtraEditors.CheckEdit();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._tlbBody = new System.Windows.Forms.TableLayoutPanel();
            this._tblHistoryFunctions = new System.Windows.Forms.TableLayoutPanel();
            this._chkIsForOld = new DevExpress.XtraEditors.CheckEdit();
            this._btnCancelChanges = new DevExpress.XtraEditors.SimpleButton();
            this._chkIsMainProcess = new DevExpress.XtraEditors.CheckEdit();
            this._chkIsNoTreatment = new DevExpress.XtraEditors.CheckEdit();
            this._btnTransfer = new DevExpress.XtraEditors.SimpleButton();
            this._btnSave = new DevExpress.XtraEditors.SimpleButton();
            this._chbIsNextContent = new DevExpress.XtraEditors.CheckEdit();
            this._btnSaveExtraHistory = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this._btnShowExtraNote = new DevExpress.XtraEditors.SimpleButton();
            this._btnShowHideNotes = new DevExpress.XtraEditors.SimpleButton();
            this.lblPhuTa = new DevExpress.XtraEditors.LabelControl();
            this._cbbSelectAssistant = new VegunSoft.Acc.Editor.Dev.Acc.SBoxUserAccount();
            this.splitContainer2 = new DevExpress.XtraEditors.SplitContainerControl();
            this._grid = new DevExpress.XtraGrid.GridControl();
            this._view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gcOrderItemStepOrderItemStepId = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcOrderItemStepGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcOrderItemStepCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.r_dtNgayThang = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this._gcOrderItemStepTeethName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcOrderItemStepContent = new DevExpress.XtraGrid.Columns.GridColumn();
            this._riTreatmentContent = new VegunSoft.Base.Editor.Dev.Repositories.RepositoryEditorMemo();
            this._gcOrderItemStepDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this._riExplanation = new VegunSoft.Base.Editor.Dev.Repositories.RepositoryEditorMemo();
            this._gcOrderItemStepNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this._riNote = new VegunSoft.Base.Editor.Dev.Repositories.RepositoryEditorMemo();
            this._gcOrderItemStepDoctorFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._repoSelectDoctor = new VegunSoft.Acc.Editor.Dev.Acc.SRepUserAccount();
            this._gcOrderItemStepAssistantFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._repoSelectAssistant = new VegunSoft.Acc.Editor.Dev.Acc.SRepUserAccount();
            this._gcOrderItemStepIsNoTreatment = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcOrderItemStepIsNoCommission = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcOrderItemStepIsFinishStep = new DevExpress.XtraGrid.Columns.GridColumn();
            this._rChkIsFinishStep = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this._gcOrderItemStepFinishDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this._rdeFinishedDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this._gcOrderItemStepIsFinishTreatment = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcOrderItemStepPrescriptionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcOrderItemStepSubclinicalId = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcOrderItemStepOrderId = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcOrderItemStepOrderItemPdsvName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcOrderItemStepIsNextContent = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcOrderItemStepHasPrescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcOrderItemStepHasSubclinicals = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcOrderItemStepIsDoctorMain = new DevExpress.XtraGrid.Columns.GridColumn();
            this._rChkIsMainDoctor = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this._gcOrderItemStepIsAssistantMain = new DevExpress.XtraGrid.Columns.GridColumn();
            this._rChkIsMainAssistant = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this._gcOrderItemStepBookLabo = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcIsPaidRose = new DevExpress.XtraGrid.Columns.GridColumn();
            this._rChkIsPaidRose = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this._gcRosePaidDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this._rDateRosePaidDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this._gcIsForOld = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcOrderItemStepDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lnkXoa = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this._gcId = new DevExpress.XtraGrid.Columns.GridColumn();
            this._riTreatmentContentEx = new VegunSoft.Base.Editor.Dev.Repositories.RepositoryEditorMemoEx();
            this.repositoryItemDateEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.r_lnkInToaThuoc = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.r_lnkXemCLS = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this._riExplanationEx = new VegunSoft.Base.Editor.Dev.Repositories.RepositoryEditorMemoEx();
            this._lnkBookLabo = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this._riNoteEx = new VegunSoft.Base.Editor.Dev.Repositories.RepositoryEditorMemoEx();
            this._txtExtraContent = new DevExpress.XtraEditors.MemoEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this._txtMultiRows = new DevExpress.XtraEditors.CheckEdit();
            this._chbIsShowAllItems = new DevExpress.XtraEditors.CheckEdit();
            this._lblShowOrders = new DevExpress.XtraEditors.CheckEdit();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._grbOrders = new System.Windows.Forms.GroupBox();
            this._gridOrders = new DevExpress.XtraGrid.GridControl();
            this._viewOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gccTreatmentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gccTreatmentCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this._gccTreatmentIsClosed = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gccTreatmentIsCancelled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemHyperLinkEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this._tabControlProductServicesSteps = new System.Windows.Forms.TabControl();
            this._tabPageServivces = new System.Windows.Forms.TabPage();
            this._gridOrderItems = new DevExpress.XtraGrid.GridControl();
            this._vieOrderItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gcPdsvTargetName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcProductServiceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._riProductServiceName = new VegunSoft.Base.Editor.Dev.Repositories.RepositoryEditorMemo();
            this._gcProductServiceDoctor = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcProductServiceOrderDisplayName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcOrderItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemHyperLinkEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this._tabPageSteps = new System.Windows.Forms.TabPage();
            this._ucProductServiceSteps = new VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order.UcOrderItemSteps();
            this.panel3 = new System.Windows.Forms.Panel();
            this._chkIsDoctor = new DevExpress.XtraEditors.CheckEdit();
            this._cbbSelectDoctor = new VegunSoft.Acc.Editor.Dev.Acc.SBoxUserAccount();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainer1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._chkIsHideList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkIsMinColumn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkIsGroupByOrderItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkIsGroupByOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkReduce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._chbIsShowAllHistoriesOfOrders.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._chbIsShowAllHistoriesOfCustomers.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            this._tlbBody.SuspendLayout();
            this._tblHistoryFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._chkIsForOld.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkIsMainProcess.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkIsNoTreatment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._chbIsNextContent.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cbbSelectAssistant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2.Panel1)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2.Panel2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_dtNgayThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_dtNgayThang.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._riTreatmentContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._riExplanation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._riNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._repoSelectDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._repoSelectAssistant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._rChkIsFinishStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._rdeFinishedDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._rdeFinishedDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._rChkIsMainDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._rChkIsMainAssistant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._rChkIsPaidRose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._rDateRosePaidDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._rDateRosePaidDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._riTreatmentContentEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_lnkInToaThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_lnkXemCLS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._riExplanationEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lnkBookLabo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._riNoteEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtExtraContent.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtMultiRows.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._chbIsShowAllItems.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lblShowOrders.Properties)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this._grbOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._viewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).BeginInit();
            this._tabControlProductServicesSteps.SuspendLayout();
            this._tabPageServivces.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._vieOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._riProductServiceName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit4)).BeginInit();
            this._tabPageSteps.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._chkIsDoctor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbSelectDoctor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1.Panel1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1.Panel2)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._chkIsHideList);
            this.panel2.Controls.Add(this._chkIsMinColumn);
            this.panel2.Controls.Add(this._btnWidthLeft);
            this.panel2.Controls.Add(this._chkIsGroupByOrderItem);
            this.panel2.Controls.Add(this._btnWidthRight);
            this.panel2.Controls.Add(this._chkIsGroupByOrder);
            this.panel2.Controls.Add(this._chkReduce);
            this.panel2.Controls.Add(this._chbIsShowAllHistoriesOfOrders);
            this.panel2.Controls.Add(this._chbIsShowAllHistoriesOfCustomers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 683);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 25);
            this.panel2.TabIndex = 19;
            // 
            // _chkIsHideList
            // 
            this._chkIsHideList.Location = new System.Drawing.Point(3, 3);
            this._chkIsHideList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._chkIsHideList.Name = "_chkIsHideList";
            this._chkIsHideList.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkIsHideList.Properties.Appearance.Options.UseFont = true;
            this._chkIsHideList.Properties.Caption = "Ẩn danh sách";
            this._chkIsHideList.Size = new System.Drawing.Size(114, 20);
            this._chkIsHideList.TabIndex = 328;
            this._chkIsHideList.CheckedChanged += new System.EventHandler(this._chkIsHideList_CheckedChanged);
            // 
            // _chkIsMinColumn
            // 
            this._chkIsMinColumn.Location = new System.Drawing.Point(131, 3);
            this._chkIsMinColumn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._chkIsMinColumn.Name = "_chkIsMinColumn";
            this._chkIsMinColumn.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkIsMinColumn.Properties.Appearance.Options.UseFont = true;
            this._chkIsMinColumn.Properties.Caption = "Ít cột";
            this._chkIsMinColumn.Size = new System.Drawing.Size(60, 20);
            this._chkIsMinColumn.TabIndex = 327;
            this._chkIsMinColumn.CheckedChanged += new System.EventHandler(this._chkIsMinColumn_CheckedChanged);
            // 
            // _btnWidthLeft
            // 
            this._btnWidthLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnWidthLeft.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnWidthLeft.Appearance.Options.UseFont = true;
            this._btnWidthLeft.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnWidthLeft.ImageOptions.Image")));
            this._btnWidthLeft.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this._btnWidthLeft.Location = new System.Drawing.Point(894, 3);
            this._btnWidthLeft.Margin = new System.Windows.Forms.Padding(0);
            this._btnWidthLeft.Name = "_btnWidthLeft";
            this._btnWidthLeft.Size = new System.Drawing.Size(29, 20);
            this._btnWidthLeft.TabIndex = 326;
            this._btnWidthLeft.Click += new System.EventHandler(this._btnWidthLeft_Click);
            // 
            // _chkIsGroupByOrderItem
            // 
            this._chkIsGroupByOrderItem.Location = new System.Drawing.Point(429, 3);
            this._chkIsGroupByOrderItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._chkIsGroupByOrderItem.Name = "_chkIsGroupByOrderItem";
            this._chkIsGroupByOrderItem.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkIsGroupByOrderItem.Properties.Appearance.Options.UseFont = true;
            this._chkIsGroupByOrderItem.Properties.Caption = "Nhóm theo SP/DV";
            this._chkIsGroupByOrderItem.Size = new System.Drawing.Size(139, 20);
            this._chkIsGroupByOrderItem.TabIndex = 325;
            this._chkIsGroupByOrderItem.CheckedChanged += new System.EventHandler(this._chkIsGroupByOrderItem_CheckedChanged);
            // 
            // _btnWidthRight
            // 
            this._btnWidthRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnWidthRight.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnWidthRight.Appearance.Options.UseFont = true;
            this._btnWidthRight.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnWidthRight.ImageOptions.Image")));
            this._btnWidthRight.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this._btnWidthRight.Location = new System.Drawing.Point(925, 3);
            this._btnWidthRight.Margin = new System.Windows.Forms.Padding(0);
            this._btnWidthRight.Name = "_btnWidthRight";
            this._btnWidthRight.Size = new System.Drawing.Size(29, 20);
            this._btnWidthRight.TabIndex = 325;
            this._btnWidthRight.Click += new System.EventHandler(this._btnWidthRight_Click);
            // 
            // _chkIsGroupByOrder
            // 
            this._chkIsGroupByOrder.Location = new System.Drawing.Point(299, 3);
            this._chkIsGroupByOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._chkIsGroupByOrder.Name = "_chkIsGroupByOrder";
            this._chkIsGroupByOrder.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkIsGroupByOrder.Properties.Appearance.Options.UseFont = true;
            this._chkIsGroupByOrder.Properties.Caption = "Nhóm theo HS";
            this._chkIsGroupByOrder.Size = new System.Drawing.Size(116, 20);
            this._chkIsGroupByOrder.TabIndex = 324;
            this._chkIsGroupByOrder.CheckedChanged += new System.EventHandler(this._chkIsGroupByOrder_CheckedChanged);
            // 
            // _chkReduce
            // 
            this._chkReduce.Location = new System.Drawing.Point(205, 3);
            this._chkReduce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._chkReduce.Name = "_chkReduce";
            this._chkReduce.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkReduce.Properties.Appearance.Options.UseFont = true;
            this._chkReduce.Properties.Caption = "Thu gọn";
            this._chkReduce.Size = new System.Drawing.Size(80, 20);
            this._chkReduce.TabIndex = 323;
            this._chkReduce.CheckedChanged += new System.EventHandler(this._chkReduce_CheckedChanged);
            // 
            // _chbIsShowAllHistoriesOfOrders
            // 
            this._chbIsShowAllHistoriesOfOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._chbIsShowAllHistoriesOfOrders.EditValue = true;
            this._chbIsShowAllHistoriesOfOrders.Location = new System.Drawing.Point(579, 3);
            this._chbIsShowAllHistoriesOfOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._chbIsShowAllHistoriesOfOrders.Name = "_chbIsShowAllHistoriesOfOrders";
            this._chbIsShowAllHistoriesOfOrders.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chbIsShowAllHistoriesOfOrders.Properties.Appearance.Options.UseFont = true;
            this._chbIsShowAllHistoriesOfOrders.Properties.Caption = "Hiện tất cả theo HS";
            this._chbIsShowAllHistoriesOfOrders.Size = new System.Drawing.Size(154, 20);
            this._chbIsShowAllHistoriesOfOrders.TabIndex = 322;
            this._chbIsShowAllHistoriesOfOrders.CheckedChanged += new System.EventHandler(this._chbIsShowAllHistoriesOfOrders_CheckedChanged);
            // 
            // _chbIsShowAllHistoriesOfCustomers
            // 
            this._chbIsShowAllHistoriesOfCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._chbIsShowAllHistoriesOfCustomers.EditValue = true;
            this._chbIsShowAllHistoriesOfCustomers.Location = new System.Drawing.Point(737, 3);
            this._chbIsShowAllHistoriesOfCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._chbIsShowAllHistoriesOfCustomers.Name = "_chbIsShowAllHistoriesOfCustomers";
            this._chbIsShowAllHistoriesOfCustomers.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chbIsShowAllHistoriesOfCustomers.Properties.Appearance.Options.UseFont = true;
            this._chbIsShowAllHistoriesOfCustomers.Properties.Caption = "Hiện tất cả theo KH";
            this._chbIsShowAllHistoriesOfCustomers.Size = new System.Drawing.Size(151, 20);
            this._chbIsShowAllHistoriesOfCustomers.TabIndex = 321;
            this._chbIsShowAllHistoriesOfCustomers.CheckedChanged += new System.EventHandler(this._chbIsShowAll_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._tlbBody);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(954, 729);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lịch sử điều trị / xử lý";
            // 
            // _tlbBody
            // 
            this._tlbBody.ColumnCount = 1;
            this._tlbBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlbBody.Controls.Add(this._tblHistoryFunctions, 0, 1);
            this._tlbBody.Controls.Add(this.panel2, 0, 2);
            this._tlbBody.Controls.Add(this.splitContainer2, 0, 0);
            this._tlbBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tlbBody.Location = new System.Drawing.Point(3, 18);
            this._tlbBody.Margin = new System.Windows.Forms.Padding(2);
            this._tlbBody.Name = "_tlbBody";
            this._tlbBody.RowCount = 3;
            this._tlbBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlbBody.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tlbBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._tlbBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tlbBody.Size = new System.Drawing.Size(948, 708);
            this._tlbBody.TabIndex = 15;
            // 
            // _tblHistoryFunctions
            // 
            this._tblHistoryFunctions.ColumnCount = 9;
            this._tblHistoryFunctions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tblHistoryFunctions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tblHistoryFunctions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tblHistoryFunctions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this._tblHistoryFunctions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tblHistoryFunctions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tblHistoryFunctions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tblHistoryFunctions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tblHistoryFunctions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tblHistoryFunctions.Controls.Add(this._chkIsForOld, 3, 0);
            this._tblHistoryFunctions.Controls.Add(this._btnCancelChanges, 8, 0);
            this._tblHistoryFunctions.Controls.Add(this._chkIsMainProcess, 2, 0);
            this._tblHistoryFunctions.Controls.Add(this._chkIsNoTreatment, 1, 0);
            this._tblHistoryFunctions.Controls.Add(this._btnTransfer, 6, 0);
            this._tblHistoryFunctions.Controls.Add(this._btnSave, 5, 0);
            this._tblHistoryFunctions.Controls.Add(this._chbIsNextContent, 0, 0);
            this._tblHistoryFunctions.Controls.Add(this._btnSaveExtraHistory, 4, 0);
            this._tblHistoryFunctions.Controls.Add(this.panel4, 7, 0);
            this._tblHistoryFunctions.Controls.Add(this.lblPhuTa, 0, 2);
            this._tblHistoryFunctions.Controls.Add(this._cbbSelectAssistant, 1, 2);
            this._tblHistoryFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tblHistoryFunctions.Location = new System.Drawing.Point(0, 633);
            this._tblHistoryFunctions.Margin = new System.Windows.Forms.Padding(0);
            this._tblHistoryFunctions.Name = "_tblHistoryFunctions";
            this._tblHistoryFunctions.RowCount = 3;
            this._tblHistoryFunctions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tblHistoryFunctions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this._tblHistoryFunctions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tblHistoryFunctions.Size = new System.Drawing.Size(948, 50);
            this._tblHistoryFunctions.TabIndex = 11;
            // 
            // _chkIsForOld
            // 
            this._chkIsForOld.Dock = System.Windows.Forms.DockStyle.Fill;
            this._chkIsForOld.Location = new System.Drawing.Point(304, 3);
            this._chkIsForOld.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._chkIsForOld.Name = "_chkIsForOld";
            this._chkIsForOld.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkIsForOld.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this._chkIsForOld.Properties.Appearance.Options.UseFont = true;
            this._chkIsForOld.Properties.Appearance.Options.UseForeColor = true;
            this._chkIsForOld.Properties.Caption = "@ Cũ";
            this._chkIsForOld.Size = new System.Drawing.Size(92, 21);
            this._chkIsForOld.TabIndex = 325;
            // 
            // _btnCancelChanges
            // 
            this._btnCancelChanges.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCancelChanges.Appearance.Options.UseFont = true;
            this._btnCancelChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnCancelChanges.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnCancelChanges.ImageOptions.Image")));
            this._btnCancelChanges.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this._btnCancelChanges.Location = new System.Drawing.Point(888, 0);
            this._btnCancelChanges.Margin = new System.Windows.Forms.Padding(0);
            this._btnCancelChanges.Name = "_btnCancelChanges";
            this._tblHistoryFunctions.SetRowSpan(this._btnCancelChanges, 3);
            this._btnCancelChanges.Size = new System.Drawing.Size(60, 50);
            this._btnCancelChanges.TabIndex = 324;
            this._btnCancelChanges.Click += new System.EventHandler(this._btnCancelChanges_Click);
            // 
            // _chkIsMainProcess
            // 
            this._chkIsMainProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this._chkIsMainProcess.Enabled = false;
            this._chkIsMainProcess.Location = new System.Drawing.Point(200, 0);
            this._chkIsMainProcess.Margin = new System.Windows.Forms.Padding(0);
            this._chkIsMainProcess.Name = "_chkIsMainProcess";
            this._chkIsMainProcess.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkIsMainProcess.Properties.Appearance.Options.UseFont = true;
            this._chkIsMainProcess.Properties.Caption = "Làm chính";
            this._chkIsMainProcess.Size = new System.Drawing.Size(100, 27);
            this._chkIsMainProcess.TabIndex = 137;
            this._chkIsMainProcess.TabStop = false;
            // 
            // _chkIsNoTreatment
            // 
            this._chkIsNoTreatment.Dock = System.Windows.Forms.DockStyle.Fill;
            this._chkIsNoTreatment.Location = new System.Drawing.Point(80, 0);
            this._chkIsNoTreatment.Margin = new System.Windows.Forms.Padding(0);
            this._chkIsNoTreatment.Name = "_chkIsNoTreatment";
            this._chkIsNoTreatment.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkIsNoTreatment.Properties.Appearance.Options.UseFont = true;
            this._chkIsNoTreatment.Properties.Caption = "Không điều trị";
            this._chkIsNoTreatment.Size = new System.Drawing.Size(120, 27);
            this._chkIsNoTreatment.TabIndex = 136;
            this._chkIsNoTreatment.TabStop = false;
            this._chkIsNoTreatment.ToolTip = "Tự động in 2 phiếu khi chi";
            // 
            // _btnTransfer
            // 
            this._btnTransfer.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnTransfer.Appearance.Options.UseFont = true;
            this._btnTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnTransfer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnTransfer.ImageOptions.Image")));
            this._btnTransfer.Location = new System.Drawing.Point(699, 3);
            this._btnTransfer.Name = "_btnTransfer";
            this._tblHistoryFunctions.SetRowSpan(this._btnTransfer, 3);
            this._btnTransfer.Size = new System.Drawing.Size(120, 44);
            this._btnTransfer.TabIndex = 134;
            this._btnTransfer.Text = "Chuyển";
            this._btnTransfer.Click += new System.EventHandler(this._btnTransfer_Click);
            // 
            // _btnSave
            // 
            this._btnSave.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSave.Appearance.Options.UseFont = true;
            this._btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnSave.ImageOptions.Image")));
            this._btnSave.Location = new System.Drawing.Point(573, 3);
            this._btnSave.Name = "_btnSave";
            this._tblHistoryFunctions.SetRowSpan(this._btnSave, 3);
            this._btnSave.Size = new System.Drawing.Size(120, 44);
            this._btnSave.TabIndex = 133;
            this._btnSave.Text = "Lưu";
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _chbIsNextContent
            // 
            this._chbIsNextContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this._chbIsNextContent.Location = new System.Drawing.Point(0, 0);
            this._chbIsNextContent.Margin = new System.Windows.Forms.Padding(0);
            this._chbIsNextContent.Name = "_chbIsNextContent";
            this._chbIsNextContent.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chbIsNextContent.Properties.Appearance.Options.UseFont = true;
            this._chbIsNextContent.Properties.Caption = "Dự kiến";
            this._chbIsNextContent.Size = new System.Drawing.Size(80, 27);
            this._chbIsNextContent.TabIndex = 19;
            this._chbIsNextContent.TabStop = false;
            this._chbIsNextContent.ToolTip = "Tự động in 2 phiếu khi chi";
            // 
            // _btnSaveExtraHistory
            // 
            this._btnSaveExtraHistory.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSaveExtraHistory.Appearance.ForeColor = System.Drawing.Color.Green;
            this._btnSaveExtraHistory.Appearance.Options.UseFont = true;
            this._btnSaveExtraHistory.Appearance.Options.UseForeColor = true;
            this._btnSaveExtraHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnSaveExtraHistory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnSaveExtraHistory.ImageOptions.Image")));
            this._btnSaveExtraHistory.Location = new System.Drawing.Point(403, 3);
            this._btnSaveExtraHistory.Name = "_btnSaveExtraHistory";
            this._tblHistoryFunctions.SetRowSpan(this._btnSaveExtraHistory, 3);
            this._btnSaveExtraHistory.Size = new System.Drawing.Size(164, 44);
            this._btnSaveExtraHistory.TabIndex = 0;
            this._btnSaveExtraHistory.Text = "Thêm nội dung";
            this._btnSaveExtraHistory.Click += new System.EventHandler(this._btnSaveExtraHistory_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this._btnShowExtraNote);
            this.panel4.Controls.Add(this._btnShowHideNotes);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(825, 3);
            this.panel4.Name = "panel4";
            this._tblHistoryFunctions.SetRowSpan(this.panel4, 3);
            this.panel4.Size = new System.Drawing.Size(60, 44);
            this.panel4.TabIndex = 135;
            // 
            // _btnShowExtraNote
            // 
            this._btnShowExtraNote.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnShowExtraNote.Appearance.Options.UseFont = true;
            this._btnShowExtraNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnShowExtraNote.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnShowExtraNote.ImageOptions.Image")));
            this._btnShowExtraNote.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this._btnShowExtraNote.Location = new System.Drawing.Point(0, 0);
            this._btnShowExtraNote.Margin = new System.Windows.Forms.Padding(0);
            this._btnShowExtraNote.Name = "_btnShowExtraNote";
            this._btnShowExtraNote.Size = new System.Drawing.Size(60, 44);
            this._btnShowExtraNote.TabIndex = 323;
            this._btnShowExtraNote.Visible = false;
            this._btnShowExtraNote.Click += new System.EventHandler(this._btnShowExtraNote_Click);
            // 
            // _btnShowHideNotes
            // 
            this._btnShowHideNotes.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnShowHideNotes.Appearance.Options.UseFont = true;
            this._btnShowHideNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnShowHideNotes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnShowHideNotes.ImageOptions.Image")));
            this._btnShowHideNotes.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this._btnShowHideNotes.Location = new System.Drawing.Point(0, 0);
            this._btnShowHideNotes.Margin = new System.Windows.Forms.Padding(0);
            this._btnShowHideNotes.Name = "_btnShowHideNotes";
            this._btnShowHideNotes.Size = new System.Drawing.Size(60, 44);
            this._btnShowHideNotes.TabIndex = 135;
            this._btnShowHideNotes.Click += new System.EventHandler(this._btnShowHideNotes_Click);
            // 
            // lblPhuTa
            // 
            this.lblPhuTa.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblPhuTa.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhuTa.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblPhuTa.Appearance.Options.UseBackColor = true;
            this.lblPhuTa.Appearance.Options.UseFont = true;
            this.lblPhuTa.Appearance.Options.UseForeColor = true;
            this.lblPhuTa.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPhuTa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhuTa.Location = new System.Drawing.Point(0, 30);
            this.lblPhuTa.Margin = new System.Windows.Forms.Padding(0);
            this.lblPhuTa.Name = "lblPhuTa";
            this.lblPhuTa.Size = new System.Drawing.Size(80, 20);
            this.lblPhuTa.TabIndex = 132;
            this.lblPhuTa.Text = "Phụ tá:";
            // 
            // _cbbSelectAssistant
            // 
            this._tblHistoryFunctions.SetColumnSpan(this._cbbSelectAssistant, 3);
            this._cbbSelectAssistant.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cbbSelectAssistant.FilterModelFunc = null;
            this._cbbSelectAssistant.IsAutoLoadData = true;
            this._cbbSelectAssistant.IsHideDeleteButton = false;
            this._cbbSelectAssistant.IsIgnoreAdmin = false;
            this._cbbSelectAssistant.IsUseValueAsDisplayName = false;
            this._cbbSelectAssistant.Location = new System.Drawing.Point(80, 30);
            this._cbbSelectAssistant.Margin = new System.Windows.Forms.Padding(0);
            this._cbbSelectAssistant.Name = "_cbbSelectAssistant";
            this._cbbSelectAssistant.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbbSelectAssistant.Properties.Appearance.Options.UseFont = true;
            this._cbbSelectAssistant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this._cbbSelectAssistant.Properties.DisplayMember = "FullName";
            this._cbbSelectAssistant.Properties.ImmediatePopup = true;
            this._cbbSelectAssistant.Properties.NullText = "--- Chọn ---";
            this._cbbSelectAssistant.SameDataSourceControls = null;
            this._cbbSelectAssistant.Size = new System.Drawing.Size(320, 20);
            this._cbbSelectAssistant.TabIndex = 131;
            this._cbbSelectAssistant.EditValueChanged += new System.EventHandler(this._cbbSelectAssistant_EditValueChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainer2.Horizontal = false;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this._grid);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this._txtExtraContent);
            this.splitContainer2.Size = new System.Drawing.Size(942, 627);
            this.splitContainer2.SplitterPosition = 150;
            this.splitContainer2.TabIndex = 21;
            // 
            // _grid
            // 
            this._grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._grid.Font = new System.Drawing.Font("Verdana", 9F);
            gridLevelNode1.RelationName = "Level1";
            this._grid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this._grid.Location = new System.Drawing.Point(0, 0);
            this._grid.MainView = this._view;
            this._grid.Margin = new System.Windows.Forms.Padding(0);
            this._grid.Name = "_grid";
            this._grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this._riTreatmentContent,
            this._riTreatmentContentEx,
            this.lnkXoa,
            this.r_dtNgayThang,
            this._rChkIsFinishStep,
            this.repositoryItemDateEdit4,
            this.r_lnkInToaThuoc,
            this.r_lnkXemCLS,
            this._riExplanation,
            this._riExplanationEx,
            this._repoSelectAssistant,
            this._rdeFinishedDate,
            this._repoSelectDoctor,
            this._lnkBookLabo,
            this._rChkIsPaidRose,
            this._rDateRosePaidDate,
            this._rChkIsMainAssistant,
            this._rChkIsMainDoctor,
            this._riNote,
            this._riNoteEx});
            this._grid.Size = new System.Drawing.Size(942, 467);
            this._grid.TabIndex = 14;
            this._grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._view});
            this._grid.DataSourceChanged += new System.EventHandler(this._gridOrderItemProcessing_DataSourceChanged);
            this._grid.Click += new System.EventHandler(this._gridOrderItemProcessing_Click);
            // 
            // _view
            // 
            this._view.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this._view.Appearance.HeaderPanel.Options.UseFont = true;
            this._view.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this._view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._view.Appearance.Row.Font = new System.Drawing.Font("Verdana", 9F);
            this._view.Appearance.Row.Options.UseFont = true;
            this._view.ColumnPanelRowHeight = 16;
            this._view.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._gcOrderItemStepOrderItemStepId,
            this._gcOrderItemStepGroupName,
            this._gcOrderItemStepCreatedDate,
            this._gcOrderItemStepTeethName,
            this._gcOrderItemStepContent,
            this._gcOrderItemStepDescription,
            this._gcOrderItemStepNote,
            this._gcOrderItemStepDoctorFullName,
            this._gcOrderItemStepAssistantFullName,
            this._gcOrderItemStepIsNoTreatment,
            this._gcOrderItemStepIsNoCommission,
            this._gcOrderItemStepIsFinishStep,
            this._gcOrderItemStepFinishDate,
            this._gcOrderItemStepIsFinishTreatment,
            this._gcOrderItemStepPrescriptionId,
            this._gcOrderItemStepSubclinicalId,
            this._gcOrderItemStepOrderId,
            this._gcOrderItemStepOrderItemPdsvName,
            this._gcOrderItemStepIsNextContent,
            this._gcOrderItemStepHasPrescription,
            this._gcOrderItemStepHasSubclinicals,
            this._gcOrderItemStepIsDoctorMain,
            this._gcOrderItemStepIsAssistantMain,
            this._gcOrderItemStepBookLabo,
            this._gcIsPaidRose,
            this._gcRosePaidDate,
            this._gcIsForOld,
            this._gcOrderItemStepDelete,
            this._gcId});
            this._view.DetailHeight = 182;
            this._view.FixedLineWidth = 1;
            this._view.GridControl = this._grid;
            this._view.GroupCount = 1;
            this._view.IndicatorWidth = 15;
            this._view.LevelIndent = 0;
            this._view.Name = "_view";
            this._view.OptionsBehavior.AutoExpandAllGroups = true;
            this._view.OptionsPrint.ExpandAllDetails = true;
            this._view.OptionsView.RowAutoHeight = true;
            this._view.OptionsView.ShowAutoFilterRow = true;
            this._view.OptionsView.ShowGroupPanel = false;
            this._view.PreviewIndent = 0;
            this._view.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this._gcOrderItemStepGroupName, DevExpress.Data.ColumnSortOrder.Ascending)});
            this._view.ViewCaptionHeight = 16;
            this._view.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this._viewOrderItemSteps_RowClick);
            this._view.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this._viewOrderItemSteps_CustomRowCellEdit);
            this._view.CustomRowCellEditForEditing += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this._view_CustomRowCellEditForEditing);
            this._view.ShowingEditor += new System.ComponentModel.CancelEventHandler(this._viewOrderItemProcessing_ShowingEditor);
            this._view.HiddenEditor += new System.EventHandler(this._view_HiddenEditor);
            this._view.ShownEditor += new System.EventHandler(this._view_ShownEditor);
            this._view.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this._viewOrderItemSteps_CellValueChanged);
            this._view.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this._viewOrderItemSteps_CellValueChanging);
            this._view.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this._viewOrderItemProcessing_RowUpdated);
            this._view.RowCountChanged += new System.EventHandler(this._viewOrderItemSteps_RowCountChanged);
            // 
            // _gcOrderItemStepOrderItemStepId
            // 
            this._gcOrderItemStepOrderItemStepId.Caption = "STT";
            this._gcOrderItemStepOrderItemStepId.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this._gcOrderItemStepOrderItemStepId.MinWidth = 40;
            this._gcOrderItemStepOrderItemStepId.Name = "_gcOrderItemStepOrderItemStepId";
            this._gcOrderItemStepOrderItemStepId.Tag = "STT";
            this._gcOrderItemStepOrderItemStepId.ToolTip = "Mã xử lý - Mỗi dòng lịch sử điều trị đêu sẽ có 1 mã để sau này dễ tra cứu";
            this._gcOrderItemStepOrderItemStepId.Visible = true;
            this._gcOrderItemStepOrderItemStepId.VisibleIndex = 0;
            this._gcOrderItemStepOrderItemStepId.Width = 40;
            // 
            // _gcOrderItemStepGroupName
            // 
            this._gcOrderItemStepGroupName.Caption = "Nhóm";
            this._gcOrderItemStepGroupName.Name = "_gcOrderItemStepGroupName";
            this._gcOrderItemStepGroupName.Visible = true;
            this._gcOrderItemStepGroupName.VisibleIndex = 0;
            this._gcOrderItemStepGroupName.Width = 80;
            // 
            // _gcOrderItemStepCreatedDate
            // 
            this._gcOrderItemStepCreatedDate.AppearanceCell.Options.UseTextOptions = true;
            this._gcOrderItemStepCreatedDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._gcOrderItemStepCreatedDate.Caption = "Ngày tháng";
            this._gcOrderItemStepCreatedDate.ColumnEdit = this.r_dtNgayThang;
            this._gcOrderItemStepCreatedDate.DisplayFormat.FormatString = "d";
            this._gcOrderItemStepCreatedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._gcOrderItemStepCreatedDate.FieldName = "NGAYTHANG";
            this._gcOrderItemStepCreatedDate.MaxWidth = 90;
            this._gcOrderItemStepCreatedDate.MinWidth = 90;
            this._gcOrderItemStepCreatedDate.Name = "_gcOrderItemStepCreatedDate";
            this._gcOrderItemStepCreatedDate.OptionsColumn.AllowEdit = false;
            this._gcOrderItemStepCreatedDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this._gcOrderItemStepCreatedDate.Visible = true;
            this._gcOrderItemStepCreatedDate.VisibleIndex = 1;
            this._gcOrderItemStepCreatedDate.Width = 90;
            // 
            // r_dtNgayThang
            // 
            this.r_dtNgayThang.AutoHeight = false;
            this.r_dtNgayThang.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.r_dtNgayThang.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.r_dtNgayThang.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.r_dtNgayThang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.r_dtNgayThang.EditFormat.FormatString = "dd/MM/yyyy";
            this.r_dtNgayThang.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.r_dtNgayThang.Mask.EditMask = "dd/MM/yyyy";
            this.r_dtNgayThang.Mask.UseMaskAsDisplayFormat = true;
            this.r_dtNgayThang.Name = "r_dtNgayThang";
            // 
            // _gcOrderItemStepTeethName
            // 
            this._gcOrderItemStepTeethName.Caption = "Răng";
            this._gcOrderItemStepTeethName.FieldName = "TEN_DMRANG";
            this._gcOrderItemStepTeethName.MinWidth = 60;
            this._gcOrderItemStepTeethName.Name = "_gcOrderItemStepTeethName";
            this._gcOrderItemStepTeethName.OptionsColumn.AllowEdit = false;
            this._gcOrderItemStepTeethName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this._gcOrderItemStepTeethName.Visible = true;
            this._gcOrderItemStepTeethName.VisibleIndex = 2;
            this._gcOrderItemStepTeethName.Width = 60;
            // 
            // _gcOrderItemStepContent
            // 
            this._gcOrderItemStepContent.AppearanceCell.Options.UseTextOptions = true;
            this._gcOrderItemStepContent.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this._gcOrderItemStepContent.Caption = "Nội dung điều trị";
            this._gcOrderItemStepContent.ColumnEdit = this._riTreatmentContent;
            this._gcOrderItemStepContent.FieldName = "NOIDUNGDIEUTRI";
            this._gcOrderItemStepContent.MinWidth = 120;
            this._gcOrderItemStepContent.Name = "_gcOrderItemStepContent";
            this._gcOrderItemStepContent.OptionsColumn.AllowEdit = false;
            this._gcOrderItemStepContent.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this._gcOrderItemStepContent.Visible = true;
            this._gcOrderItemStepContent.VisibleIndex = 3;
            this._gcOrderItemStepContent.Width = 120;
            // 
            // _riTreatmentContent
            // 
            this._riTreatmentContent.Name = "_riTreatmentContent";
            // 
            // _gcOrderItemStepDescription
            // 
            this._gcOrderItemStepDescription.AppearanceCell.Options.UseTextOptions = true;
            this._gcOrderItemStepDescription.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this._gcOrderItemStepDescription.Caption = "Diễn giải";
            this._gcOrderItemStepDescription.ColumnEdit = this._riExplanation;
            this._gcOrderItemStepDescription.FieldName = "Note";
            this._gcOrderItemStepDescription.MinWidth = 120;
            this._gcOrderItemStepDescription.Name = "_gcOrderItemStepDescription";
            this._gcOrderItemStepDescription.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this._gcOrderItemStepDescription.Visible = true;
            this._gcOrderItemStepDescription.VisibleIndex = 4;
            this._gcOrderItemStepDescription.Width = 120;
            // 
            // _riExplanation
            // 
            this._riExplanation.Name = "_riExplanation";
            // 
            // _gcOrderItemStepNote
            // 
            this._gcOrderItemStepNote.Caption = "Ghi chú";
            this._gcOrderItemStepNote.ColumnEdit = this._riNote;
            this._gcOrderItemStepNote.MinWidth = 120;
            this._gcOrderItemStepNote.Name = "_gcOrderItemStepNote";
            this._gcOrderItemStepNote.Visible = true;
            this._gcOrderItemStepNote.VisibleIndex = 5;
            this._gcOrderItemStepNote.Width = 120;
            // 
            // _riNote
            // 
            this._riNote.Name = "_riNote";
            // 
            // _gcOrderItemStepDoctorFullName
            // 
            this._gcOrderItemStepDoctorFullName.Caption = "Bác sĩ";
            this._gcOrderItemStepDoctorFullName.ColumnEdit = this._repoSelectDoctor;
            this._gcOrderItemStepDoctorFullName.FieldName = "HOTEN_TAIKHOAN_BSDT";
            this._gcOrderItemStepDoctorFullName.MaxWidth = 200;
            this._gcOrderItemStepDoctorFullName.MinWidth = 120;
            this._gcOrderItemStepDoctorFullName.Name = "_gcOrderItemStepDoctorFullName";
            this._gcOrderItemStepDoctorFullName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this._gcOrderItemStepDoctorFullName.ToolTip = "Bác sĩ điều trị/Ra toa/Chỉ định CLS";
            this._gcOrderItemStepDoctorFullName.Visible = true;
            this._gcOrderItemStepDoctorFullName.VisibleIndex = 6;
            this._gcOrderItemStepDoctorFullName.Width = 120;
            // 
            // _repoSelectDoctor
            // 
            this._repoSelectDoctor.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this._repoSelectDoctor.AutoHeight = false;
            this._repoSelectDoctor.BranchId = null;
            this._repoSelectDoctor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._repoSelectDoctor.DisplayMember = "FullName";
            this._repoSelectDoctor.FilterModelFunc = null;
            this._repoSelectDoctor.IsAutoLoadData = true;
            this._repoSelectDoctor.IsHideDeleteButton = false;
            this._repoSelectDoctor.IsIgnoreAdmin = false;
            this._repoSelectDoctor.Name = "_repoSelectDoctor";
            this._repoSelectDoctor.NullText = "--- Chọn ---";
            this._repoSelectDoctor.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this._repoSelectDoctor.PopupFormSize = new System.Drawing.Size(250, 156);
            this._repoSelectDoctor.SameDataSourceControls = null;
            this._repoSelectDoctor.Scope = VegunSoft.Acc.Data.Enums.EUserAccountScope.Default;
            this._repoSelectDoctor.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.None;
            this._repoSelectDoctor.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this._repoSelectDoctor.ValueMember = "Username";
            this._repoSelectDoctor.EditValueChanged += new System.EventHandler(this._repoSelectDoctor_EditValueChanged);
            // 
            // _gcOrderItemStepAssistantFullName
            // 
            this._gcOrderItemStepAssistantFullName.Caption = "Phụ tá";
            this._gcOrderItemStepAssistantFullName.ColumnEdit = this._repoSelectAssistant;
            this._gcOrderItemStepAssistantFullName.FieldName = "HOTEN_TAIKHOAN_PT";
            this._gcOrderItemStepAssistantFullName.MinWidth = 120;
            this._gcOrderItemStepAssistantFullName.Name = "_gcOrderItemStepAssistantFullName";
            this._gcOrderItemStepAssistantFullName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this._gcOrderItemStepAssistantFullName.Visible = true;
            this._gcOrderItemStepAssistantFullName.VisibleIndex = 7;
            this._gcOrderItemStepAssistantFullName.Width = 120;
            // 
            // _repoSelectAssistant
            // 
            this._repoSelectAssistant.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this._repoSelectAssistant.AutoHeight = false;
            this._repoSelectAssistant.BranchId = null;
            this._repoSelectAssistant.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._repoSelectAssistant.DisplayMember = "FullName";
            this._repoSelectAssistant.FilterModelFunc = null;
            this._repoSelectAssistant.IsAutoLoadData = true;
            this._repoSelectAssistant.IsHideDeleteButton = false;
            this._repoSelectAssistant.IsIgnoreAdmin = false;
            this._repoSelectAssistant.Name = "_repoSelectAssistant";
            this._repoSelectAssistant.NullText = "--- Chọn ---";
            this._repoSelectAssistant.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this._repoSelectAssistant.PopupFormSize = new System.Drawing.Size(250, 156);
            this._repoSelectAssistant.SameDataSourceControls = null;
            this._repoSelectAssistant.Scope = VegunSoft.Acc.Data.Enums.EUserAccountScope.Default;
            this._repoSelectAssistant.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.None;
            this._repoSelectAssistant.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this._repoSelectAssistant.ValueMember = "Username";
            this._repoSelectAssistant.EditValueChanged += new System.EventHandler(this._repoSelectAssistant_EditValueChanged);
            // 
            // _gcOrderItemStepIsNoTreatment
            // 
            this._gcOrderItemStepIsNoTreatment.Caption = "0ĐT";
            this._gcOrderItemStepIsNoTreatment.MaxWidth = 50;
            this._gcOrderItemStepIsNoTreatment.MinWidth = 50;
            this._gcOrderItemStepIsNoTreatment.Name = "_gcOrderItemStepIsNoTreatment";
            this._gcOrderItemStepIsNoTreatment.ToolTip = "Không điều trị";
            this._gcOrderItemStepIsNoTreatment.Visible = true;
            this._gcOrderItemStepIsNoTreatment.VisibleIndex = 11;
            this._gcOrderItemStepIsNoTreatment.Width = 50;
            // 
            // _gcOrderItemStepIsNoCommission
            // 
            this._gcOrderItemStepIsNoCommission.Caption = "0HH";
            this._gcOrderItemStepIsNoCommission.Name = "_gcOrderItemStepIsNoCommission";
            this._gcOrderItemStepIsNoCommission.ToolTip = "Không tính hoa hồng cho dù có cấu hình vì khách không được chuyển theo quy trình";
            this._gcOrderItemStepIsNoCommission.Width = 40;
            // 
            // _gcOrderItemStepIsFinishStep
            // 
            this._gcOrderItemStepIsFinishStep.Caption = "HTB";
            this._gcOrderItemStepIsFinishStep.ColumnEdit = this._rChkIsFinishStep;
            this._gcOrderItemStepIsFinishStep.MaxWidth = 40;
            this._gcOrderItemStepIsFinishStep.MinWidth = 40;
            this._gcOrderItemStepIsFinishStep.Name = "_gcOrderItemStepIsFinishStep";
            this._gcOrderItemStepIsFinishStep.ToolTip = "Hoàn tất bước điều trị";
            this._gcOrderItemStepIsFinishStep.Visible = true;
            this._gcOrderItemStepIsFinishStep.VisibleIndex = 8;
            this._gcOrderItemStepIsFinishStep.Width = 40;
            // 
            // _rChkIsFinishStep
            // 
            this._rChkIsFinishStep.AutoHeight = false;
            this._rChkIsFinishStep.Name = "_rChkIsFinishStep";
            this._rChkIsFinishStep.CheckedChanged += new System.EventHandler(this._rChkIsFinishStep_CheckedChanged);
            this._rChkIsFinishStep.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this._rChkIsFinishStep_EditValueChanging);
            // 
            // _gcOrderItemStepFinishDate
            // 
            this._gcOrderItemStepFinishDate.Caption = "Ngày HT";
            this._gcOrderItemStepFinishDate.ColumnEdit = this._rdeFinishedDate;
            this._gcOrderItemStepFinishDate.DisplayFormat.FormatString = "d";
            this._gcOrderItemStepFinishDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._gcOrderItemStepFinishDate.MaxWidth = 90;
            this._gcOrderItemStepFinishDate.MinWidth = 90;
            this._gcOrderItemStepFinishDate.Name = "_gcOrderItemStepFinishDate";
            this._gcOrderItemStepFinishDate.Visible = true;
            this._gcOrderItemStepFinishDate.VisibleIndex = 9;
            this._gcOrderItemStepFinishDate.Width = 90;
            // 
            // _rdeFinishedDate
            // 
            this._rdeFinishedDate.AutoHeight = false;
            this._rdeFinishedDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._rdeFinishedDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._rdeFinishedDate.Name = "_rdeFinishedDate";
            // 
            // _gcOrderItemStepIsFinishTreatment
            // 
            this._gcOrderItemStepIsFinishTreatment.Caption = "HTDV";
            this._gcOrderItemStepIsFinishTreatment.MaxWidth = 45;
            this._gcOrderItemStepIsFinishTreatment.MinWidth = 45;
            this._gcOrderItemStepIsFinishTreatment.Name = "_gcOrderItemStepIsFinishTreatment";
            this._gcOrderItemStepIsFinishTreatment.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this._gcOrderItemStepIsFinishTreatment.ToolTip = "Hoàn tất điều trị toàn dịch vụ";
            this._gcOrderItemStepIsFinishTreatment.Visible = true;
            this._gcOrderItemStepIsFinishTreatment.VisibleIndex = 10;
            this._gcOrderItemStepIsFinishTreatment.Width = 45;
            // 
            // _gcOrderItemStepPrescriptionId
            // 
            this._gcOrderItemStepPrescriptionId.Caption = "Id toa";
            this._gcOrderItemStepPrescriptionId.Name = "_gcOrderItemStepPrescriptionId";
            this._gcOrderItemStepPrescriptionId.Width = 40;
            // 
            // _gcOrderItemStepSubclinicalId
            // 
            this._gcOrderItemStepSubclinicalId.Caption = "CLS Id";
            this._gcOrderItemStepSubclinicalId.Name = "_gcOrderItemStepSubclinicalId";
            this._gcOrderItemStepSubclinicalId.Width = 40;
            // 
            // _gcOrderItemStepOrderId
            // 
            this._gcOrderItemStepOrderId.Caption = "HSĐT";
            this._gcOrderItemStepOrderId.Name = "_gcOrderItemStepOrderId";
            this._gcOrderItemStepOrderId.Width = 40;
            // 
            // _gcOrderItemStepOrderItemPdsvName
            // 
            this._gcOrderItemStepOrderItemPdsvName.Caption = "SP/DV";
            this._gcOrderItemStepOrderItemPdsvName.Name = "_gcOrderItemStepOrderItemPdsvName";
            this._gcOrderItemStepOrderItemPdsvName.Width = 40;
            // 
            // _gcOrderItemStepIsNextContent
            // 
            this._gcOrderItemStepIsNextContent.Caption = ">";
            this._gcOrderItemStepIsNextContent.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this._gcOrderItemStepIsNextContent.Name = "_gcOrderItemStepIsNextContent";
            this._gcOrderItemStepIsNextContent.ToolTip = "Công việc dự kiến làm";
            this._gcOrderItemStepIsNextContent.Width = 40;
            // 
            // _gcOrderItemStepHasPrescription
            // 
            this._gcOrderItemStepHasPrescription.Caption = "Toa";
            this._gcOrderItemStepHasPrescription.Name = "_gcOrderItemStepHasPrescription";
            this._gcOrderItemStepHasPrescription.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this._gcOrderItemStepHasPrescription.ToolTip = "Có toa thuốc";
            this._gcOrderItemStepHasPrescription.Width = 40;
            // 
            // _gcOrderItemStepHasSubclinicals
            // 
            this._gcOrderItemStepHasSubclinicals.Caption = "CLS";
            this._gcOrderItemStepHasSubclinicals.Name = "_gcOrderItemStepHasSubclinicals";
            this._gcOrderItemStepHasSubclinicals.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this._gcOrderItemStepHasSubclinicals.ToolTip = "Có hình ảnh cận lâm sàng";
            this._gcOrderItemStepHasSubclinicals.Width = 40;
            // 
            // _gcOrderItemStepIsDoctorMain
            // 
            this._gcOrderItemStepIsDoctorMain.Caption = "BSC";
            this._gcOrderItemStepIsDoctorMain.ColumnEdit = this._rChkIsMainDoctor;
            this._gcOrderItemStepIsDoctorMain.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcOrderItemStepIsDoctorMain.MaxWidth = 40;
            this._gcOrderItemStepIsDoctorMain.MinWidth = 40;
            this._gcOrderItemStepIsDoctorMain.Name = "_gcOrderItemStepIsDoctorMain";
            this._gcOrderItemStepIsDoctorMain.ToolTip = "Bác sĩ làm chính?";
            this._gcOrderItemStepIsDoctorMain.Visible = true;
            this._gcOrderItemStepIsDoctorMain.VisibleIndex = 12;
            this._gcOrderItemStepIsDoctorMain.Width = 40;
            // 
            // _rChkIsMainDoctor
            // 
            this._rChkIsMainDoctor.AutoHeight = false;
            this._rChkIsMainDoctor.Name = "_rChkIsMainDoctor";
            this._rChkIsMainDoctor.CheckedChanged += new System.EventHandler(this._rChkIsMainDoctor_CheckedChanged);
            // 
            // _gcOrderItemStepIsAssistantMain
            // 
            this._gcOrderItemStepIsAssistantMain.Caption = "PTC";
            this._gcOrderItemStepIsAssistantMain.ColumnEdit = this._rChkIsMainAssistant;
            this._gcOrderItemStepIsAssistantMain.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcOrderItemStepIsAssistantMain.MaxWidth = 40;
            this._gcOrderItemStepIsAssistantMain.MinWidth = 40;
            this._gcOrderItemStepIsAssistantMain.Name = "_gcOrderItemStepIsAssistantMain";
            this._gcOrderItemStepIsAssistantMain.ToolTip = "Phụ tá làm chính?";
            this._gcOrderItemStepIsAssistantMain.Visible = true;
            this._gcOrderItemStepIsAssistantMain.VisibleIndex = 13;
            this._gcOrderItemStepIsAssistantMain.Width = 40;
            // 
            // _rChkIsMainAssistant
            // 
            this._rChkIsMainAssistant.AutoHeight = false;
            this._rChkIsMainAssistant.Name = "_rChkIsMainAssistant";
            this._rChkIsMainAssistant.CheckedChanged += new System.EventHandler(this._rChkIsMainAssistant_CheckedChanged);
            // 
            // _gcOrderItemStepBookLabo
            // 
            this._gcOrderItemStepBookLabo.Caption = "Labo";
            this._gcOrderItemStepBookLabo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcOrderItemStepBookLabo.Name = "_gcOrderItemStepBookLabo";
            this._gcOrderItemStepBookLabo.Visible = true;
            this._gcOrderItemStepBookLabo.VisibleIndex = 14;
            this._gcOrderItemStepBookLabo.Width = 40;
            // 
            // _gcIsPaidRose
            // 
            this._gcIsPaidRose.Caption = "ĐC";
            this._gcIsPaidRose.ColumnEdit = this._rChkIsPaidRose;
            this._gcIsPaidRose.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcIsPaidRose.MaxWidth = 40;
            this._gcIsPaidRose.MinWidth = 40;
            this._gcIsPaidRose.Name = "_gcIsPaidRose";
            this._gcIsPaidRose.ToolTip = "Đã chi hoa hồng";
            this._gcIsPaidRose.Visible = true;
            this._gcIsPaidRose.VisibleIndex = 15;
            this._gcIsPaidRose.Width = 40;
            // 
            // _rChkIsPaidRose
            // 
            this._rChkIsPaidRose.AutoHeight = false;
            this._rChkIsPaidRose.Name = "_rChkIsPaidRose";
            this._rChkIsPaidRose.CheckedChanged += new System.EventHandler(this._rChkIsPaidRose_CheckedChanged);
            // 
            // _gcRosePaidDate
            // 
            this._gcRosePaidDate.Caption = "Ngày Chi HH";
            this._gcRosePaidDate.ColumnEdit = this._rDateRosePaidDate;
            this._gcRosePaidDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this._gcRosePaidDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._gcRosePaidDate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcRosePaidDate.Name = "_gcRosePaidDate";
            this._gcRosePaidDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this._gcRosePaidDate.ToolTip = "Ngày chi HH";
            this._gcRosePaidDate.Visible = true;
            this._gcRosePaidDate.VisibleIndex = 16;
            this._gcRosePaidDate.Width = 100;
            // 
            // _rDateRosePaidDate
            // 
            this._rDateRosePaidDate.AutoHeight = false;
            this._rDateRosePaidDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._rDateRosePaidDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._rDateRosePaidDate.Name = "_rDateRosePaidDate";
            this._rDateRosePaidDate.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this._rDateRosePaidDate_EditValueChanging);
            // 
            // _gcIsForOld
            // 
            this._gcIsForOld.Caption = "Cũ";
            this._gcIsForOld.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcIsForOld.MaxWidth = 40;
            this._gcIsForOld.MinWidth = 40;
            this._gcIsForOld.Name = "_gcIsForOld";
            this._gcIsForOld.ToolTip = "Dữ liệu cũ";
            this._gcIsForOld.Visible = true;
            this._gcIsForOld.VisibleIndex = 17;
            this._gcIsForOld.Width = 40;
            // 
            // _gcOrderItemStepDelete
            // 
            this._gcOrderItemStepDelete.Caption = "Xóa";
            this._gcOrderItemStepDelete.ColumnEdit = this.lnkXoa;
            this._gcOrderItemStepDelete.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcOrderItemStepDelete.Name = "_gcOrderItemStepDelete";
            this._gcOrderItemStepDelete.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this._gcOrderItemStepDelete.Visible = true;
            this._gcOrderItemStepDelete.VisibleIndex = 18;
            this._gcOrderItemStepDelete.Width = 50;
            // 
            // lnkXoa
            // 
            this.lnkXoa.AutoHeight = false;
            this.lnkXoa.Image = ((System.Drawing.Image)(resources.GetObject("lnkXoa.Image")));
            this.lnkXoa.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lnkXoa.Name = "lnkXoa";
            this.lnkXoa.Click += new System.EventHandler(this.LnkXoa_Click);
            // 
            // _gcId
            // 
            this._gcId.Caption = "Mã ĐT";
            this._gcId.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcId.MinWidth = 40;
            this._gcId.Name = "_gcId";
            this._gcId.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this._gcId.OptionsColumn.ReadOnly = true;
            // 
            // _riTreatmentContentEx
            // 
            this._riTreatmentContentEx.Name = "_riTreatmentContentEx";
            this._riTreatmentContentEx.ShowIcon = false;
            // 
            // repositoryItemDateEdit4
            // 
            this.repositoryItemDateEdit4.AutoHeight = false;
            this.repositoryItemDateEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit4.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit4.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit4.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit4.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit4.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEdit4.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit4.Name = "repositoryItemDateEdit4";
            // 
            // r_lnkInToaThuoc
            // 
            this.r_lnkInToaThuoc.AutoHeight = false;
            this.r_lnkInToaThuoc.Image = ((System.Drawing.Image)(resources.GetObject("r_lnkInToaThuoc.Image")));
            this.r_lnkInToaThuoc.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.r_lnkInToaThuoc.Name = "r_lnkInToaThuoc";
            this.r_lnkInToaThuoc.Click += new System.EventHandler(this.r_lnkInToaThuoc_Click);
            // 
            // r_lnkXemCLS
            // 
            this.r_lnkXemCLS.AutoHeight = false;
            this.r_lnkXemCLS.Image = ((System.Drawing.Image)(resources.GetObject("r_lnkXemCLS.Image")));
            this.r_lnkXemCLS.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.r_lnkXemCLS.Name = "r_lnkXemCLS";
            this.r_lnkXemCLS.Click += new System.EventHandler(this.r_lnkXemCLS_Click);
            // 
            // _riExplanationEx
            // 
            this._riExplanationEx.Name = "_riExplanationEx";
            this._riExplanationEx.ShowIcon = false;
            // 
            // _lnkBookLabo
            // 
            this._lnkBookLabo.AutoHeight = false;
            this._lnkBookLabo.Image = ((System.Drawing.Image)(resources.GetObject("_lnkBookLabo.Image")));
            this._lnkBookLabo.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._lnkBookLabo.Name = "_lnkBookLabo";
            this._lnkBookLabo.Click += new System.EventHandler(this._lnkBookLabo_Click);
            // 
            // _riNoteEx
            // 
            this._riNoteEx.Name = "_riNoteEx";
            this._riNoteEx.ShowIcon = false;
            // 
            // _txtExtraContent
            // 
            this._txtExtraContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtExtraContent.Location = new System.Drawing.Point(0, 0);
            this._txtExtraContent.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._txtExtraContent.Name = "_txtExtraContent";
            this._txtExtraContent.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtExtraContent.Properties.Appearance.Options.UseFont = true;
            this._txtExtraContent.Properties.Appearance.Options.UseTextOptions = true;
            this._txtExtraContent.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this._txtExtraContent.Properties.NullText = "Nội dung điều trị ngoài cấu hình";
            this._txtExtraContent.Size = new System.Drawing.Size(942, 150);
            this._txtExtraContent.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._txtMultiRows);
            this.panel1.Controls.Add(this._chbIsShowAllItems);
            this.panel1.Controls.Add(this._lblShowOrders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 702);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 24);
            this.panel1.TabIndex = 18;
            // 
            // _txtMultiRows
            // 
            this._txtMultiRows.EditValue = true;
            this._txtMultiRows.Location = new System.Drawing.Point(0, 3);
            this._txtMultiRows.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._txtMultiRows.Name = "_txtMultiRows";
            this._txtMultiRows.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtMultiRows.Properties.Appearance.Options.UseFont = true;
            this._txtMultiRows.Properties.Caption = "Nhiều dòng";
            this._txtMultiRows.Size = new System.Drawing.Size(100, 20);
            this._txtMultiRows.TabIndex = 322;
            this._txtMultiRows.ToolTip = "Hiện danh sách hồ sơ";
            this._txtMultiRows.CheckedChanged += new System.EventHandler(this._txtMultiRows_CheckedChanged);
            // 
            // _chbIsShowAllItems
            // 
            this._chbIsShowAllItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._chbIsShowAllItems.EditValue = true;
            this._chbIsShowAllItems.Location = new System.Drawing.Point(288, 3);
            this._chbIsShowAllItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._chbIsShowAllItems.Name = "_chbIsShowAllItems";
            this._chbIsShowAllItems.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chbIsShowAllItems.Properties.Appearance.Options.UseFont = true;
            this._chbIsShowAllItems.Properties.Caption = "Tất cả DV";
            this._chbIsShowAllItems.Size = new System.Drawing.Size(87, 20);
            this._chbIsShowAllItems.TabIndex = 321;
            this._chbIsShowAllItems.ToolTip = "Hiện tất cả dịch vụ";
            this._chbIsShowAllItems.CheckedChanged += new System.EventHandler(this._chbIsShowAllItems_CheckedChanged);
            // 
            // _lblShowOrders
            // 
            this._lblShowOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lblShowOrders.EditValue = true;
            this._lblShowOrders.Location = new System.Drawing.Point(202, 3);
            this._lblShowOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._lblShowOrders.Name = "_lblShowOrders";
            this._lblShowOrders.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblShowOrders.Properties.Appearance.Options.UseFont = true;
            this._lblShowOrders.Properties.Caption = "Hiện HS";
            this._lblShowOrders.Size = new System.Drawing.Size(74, 20);
            this._lblShowOrders.TabIndex = 320;
            this._lblShowOrders.ToolTip = "Hiện danh sách hồ sơ";
            this._lblShowOrders.CheckedChanged += new System.EventHandler(this._lblShowOrders_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this._grbOrders, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this._tabControlProductServicesSteps, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(380, 729);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // _grbOrders
            // 
            this._grbOrders.Controls.Add(this._gridOrders);
            this._grbOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grbOrders.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this._grbOrders.Location = new System.Drawing.Point(3, 471);
            this._grbOrders.Name = "_grbOrders";
            this._grbOrders.Size = new System.Drawing.Size(374, 200);
            this._grbOrders.TabIndex = 16;
            this._grbOrders.TabStop = false;
            this._grbOrders.Text = "Danh sách hồ sơ (HS)";
            // 
            // _gridOrders
            // 
            this._gridOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gridOrders.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._gridOrders.Font = new System.Drawing.Font("Verdana", 9F);
            gridLevelNode2.RelationName = "Level1";
            this._gridOrders.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this._gridOrders.Location = new System.Drawing.Point(3, 18);
            this._gridOrders.MainView = this._viewOrders;
            this._gridOrders.Margin = new System.Windows.Forms.Padding(0);
            this._gridOrders.Name = "_gridOrders";
            this._gridOrders.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemDateEdit2,
            this.repositoryItemHyperLinkEdit2});
            this._gridOrders.Size = new System.Drawing.Size(368, 179);
            this._gridOrders.TabIndex = 13;
            this._gridOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._viewOrders});
            // 
            // _viewOrders
            // 
            this._viewOrders.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this._viewOrders.Appearance.FocusedRow.Options.UseBackColor = true;
            this._viewOrders.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this._viewOrders.Appearance.HeaderPanel.Options.UseFont = true;
            this._viewOrders.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this._viewOrders.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._viewOrders.Appearance.Row.Font = new System.Drawing.Font("Verdana", 9F);
            this._viewOrders.Appearance.Row.Options.UseFont = true;
            this._viewOrders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._gccTreatmentId,
            this._gccTreatmentCreatedDate,
            this._gccTreatmentIsClosed,
            this._gccTreatmentIsCancelled});
            this._viewOrders.DetailHeight = 182;
            this._viewOrders.FixedLineWidth = 1;
            this._viewOrders.GridControl = this._gridOrders;
            this._viewOrders.LevelIndent = 0;
            this._viewOrders.Name = "_viewOrders";
            this._viewOrders.OptionsBehavior.ReadOnly = true;
            this._viewOrders.OptionsView.RowAutoHeight = true;
            this._viewOrders.OptionsView.ShowDetailButtons = false;
            this._viewOrders.OptionsView.ShowGroupPanel = false;
            this._viewOrders.PreviewIndent = 0;
            this._viewOrders.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this._gccTreatmentCreatedDate, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // _gccTreatmentId
            // 
            this._gccTreatmentId.Caption = "ID";
            this._gccTreatmentId.FieldName = "ID";
            this._gccTreatmentId.Name = "_gccTreatmentId";
            this._gccTreatmentId.OptionsColumn.AllowEdit = false;
            this._gccTreatmentId.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this._gccTreatmentId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this._gccTreatmentId.Visible = true;
            this._gccTreatmentId.VisibleIndex = 0;
            this._gccTreatmentId.Width = 40;
            // 
            // _gccTreatmentCreatedDate
            // 
            this._gccTreatmentCreatedDate.Caption = "Ngày tư vấn";
            this._gccTreatmentCreatedDate.ColumnEdit = this.repositoryItemDateEdit2;
            this._gccTreatmentCreatedDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this._gccTreatmentCreatedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._gccTreatmentCreatedDate.FieldName = "NGAYTUVAN";
            this._gccTreatmentCreatedDate.Name = "_gccTreatmentCreatedDate";
            this._gccTreatmentCreatedDate.OptionsColumn.AllowEdit = false;
            this._gccTreatmentCreatedDate.Visible = true;
            this._gccTreatmentCreatedDate.VisibleIndex = 1;
            this._gccTreatmentCreatedDate.Width = 55;
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.repositoryItemDateEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit2.EditFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.repositoryItemDateEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit2.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            this.repositoryItemDateEdit2.NullDate = "";
            // 
            // _gccTreatmentIsClosed
            // 
            this._gccTreatmentIsClosed.Caption = "Đã đóng";
            this._gccTreatmentIsClosed.FieldName = "DADONGHOSO";
            this._gccTreatmentIsClosed.Name = "_gccTreatmentIsClosed";
            this._gccTreatmentIsClosed.Visible = true;
            this._gccTreatmentIsClosed.VisibleIndex = 2;
            this._gccTreatmentIsClosed.Width = 40;
            // 
            // _gccTreatmentIsCancelled
            // 
            this._gccTreatmentIsCancelled.Caption = "Đã hủy";
            this._gccTreatmentIsCancelled.FieldName = "DAHUY";
            this._gccTreatmentIsCancelled.Name = "_gccTreatmentIsCancelled";
            this._gccTreatmentIsCancelled.Visible = true;
            this._gccTreatmentIsCancelled.VisibleIndex = 3;
            this._gccTreatmentIsCancelled.Width = 40;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Image = ((System.Drawing.Image)(resources.GetObject("repositoryItemHyperLinkEdit1.Image")));
            this.repositoryItemHyperLinkEdit1.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // repositoryItemHyperLinkEdit2
            // 
            this.repositoryItemHyperLinkEdit2.AutoHeight = false;
            this.repositoryItemHyperLinkEdit2.Image = ((System.Drawing.Image)(resources.GetObject("repositoryItemHyperLinkEdit2.Image")));
            this.repositoryItemHyperLinkEdit2.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemHyperLinkEdit2.Name = "repositoryItemHyperLinkEdit2";
            // 
            // _tabControlProductServicesSteps
            // 
            this._tabControlProductServicesSteps.Controls.Add(this._tabPageServivces);
            this._tabControlProductServicesSteps.Controls.Add(this._tabPageSteps);
            this._tabControlProductServicesSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tabControlProductServicesSteps.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tabControlProductServicesSteps.Location = new System.Drawing.Point(2, 2);
            this._tabControlProductServicesSteps.Margin = new System.Windows.Forms.Padding(2);
            this._tabControlProductServicesSteps.Name = "_tabControlProductServicesSteps";
            this._tabControlProductServicesSteps.SelectedIndex = 0;
            this._tabControlProductServicesSteps.Size = new System.Drawing.Size(376, 464);
            this._tabControlProductServicesSteps.TabIndex = 17;
            // 
            // _tabPageServivces
            // 
            this._tabPageServivces.Controls.Add(this._gridOrderItems);
            this._tabPageServivces.Location = new System.Drawing.Point(4, 23);
            this._tabPageServivces.Margin = new System.Windows.Forms.Padding(2);
            this._tabPageServivces.Name = "_tabPageServivces";
            this._tabPageServivces.Padding = new System.Windows.Forms.Padding(2);
            this._tabPageServivces.Size = new System.Drawing.Size(368, 437);
            this._tabPageServivces.TabIndex = 0;
            this._tabPageServivces.Text = "Danh sách dịch vụ";
            this._tabPageServivces.UseVisualStyleBackColor = true;
            // 
            // _gridOrderItems
            // 
            this._gridOrderItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gridOrderItems.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._gridOrderItems.Font = new System.Drawing.Font("Verdana", 9F);
            gridLevelNode3.RelationName = "Level1";
            this._gridOrderItems.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3});
            this._gridOrderItems.Location = new System.Drawing.Point(2, 2);
            this._gridOrderItems.MainView = this._vieOrderItems;
            this._gridOrderItems.Margin = new System.Windows.Forms.Padding(0);
            this._gridOrderItems.Name = "_gridOrderItems";
            this._gridOrderItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit3,
            this.repositoryItemDateEdit1,
            this.repositoryItemHyperLinkEdit4,
            this._riProductServiceName});
            this._gridOrderItems.Size = new System.Drawing.Size(364, 433);
            this._gridOrderItems.TabIndex = 14;
            this._gridOrderItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._vieOrderItems});
            this._gridOrderItems.DoubleClick += new System.EventHandler(this._gridProductServices_DoubleClick);
            // 
            // _vieOrderItems
            // 
            this._vieOrderItems.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this._vieOrderItems.Appearance.FocusedRow.Options.UseBackColor = true;
            this._vieOrderItems.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this._vieOrderItems.Appearance.HeaderPanel.Options.UseFont = true;
            this._vieOrderItems.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this._vieOrderItems.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._vieOrderItems.Appearance.Row.Font = new System.Drawing.Font("Verdana", 9F);
            this._vieOrderItems.Appearance.Row.Options.UseFont = true;
            this._vieOrderItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._gcPdsvTargetName,
            this._gcProductServiceName,
            this._gcProductServiceDoctor,
            this._gcProductServiceOrderDisplayName,
            this._gcOrderItemId});
            this._vieOrderItems.DetailHeight = 182;
            this._vieOrderItems.FixedLineWidth = 1;
            this._vieOrderItems.GridControl = this._gridOrderItems;
            this._vieOrderItems.GroupCount = 1;
            this._vieOrderItems.LevelIndent = 0;
            this._vieOrderItems.Name = "_vieOrderItems";
            this._vieOrderItems.OptionsBehavior.AutoExpandAllGroups = true;
            this._vieOrderItems.OptionsBehavior.ReadOnly = true;
            this._vieOrderItems.OptionsView.RowAutoHeight = true;
            this._vieOrderItems.OptionsView.ShowAutoFilterRow = true;
            this._vieOrderItems.OptionsView.ShowDetailButtons = false;
            this._vieOrderItems.OptionsView.ShowGroupPanel = false;
            this._vieOrderItems.PreviewIndent = 0;
            this._vieOrderItems.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this._gcProductServiceOrderDisplayName, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this._gcProductServiceName, DevExpress.Data.ColumnSortOrder.Descending)});
            this._vieOrderItems.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this._viewProductServices_FocusedRowChanged);
            // 
            // _gcPdsvTargetName
            // 
            this._gcPdsvTargetName.Caption = "Răng";
            this._gcPdsvTargetName.FieldName = "ToothId";
            this._gcPdsvTargetName.Name = "_gcPdsvTargetName";
            this._gcPdsvTargetName.OptionsColumn.AllowEdit = false;
            this._gcPdsvTargetName.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this._gcPdsvTargetName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this._gcPdsvTargetName.Visible = true;
            this._gcPdsvTargetName.VisibleIndex = 0;
            this._gcPdsvTargetName.Width = 40;
            // 
            // _gcProductServiceName
            // 
            this._gcProductServiceName.Caption = "Dịch vụ";
            this._gcProductServiceName.ColumnEdit = this._riProductServiceName;
            this._gcProductServiceName.DisplayFormat.FormatString = "dd/MM/yyyy";
            this._gcProductServiceName.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._gcProductServiceName.FieldName = "NGAYTUVAN";
            this._gcProductServiceName.Name = "_gcProductServiceName";
            this._gcProductServiceName.OptionsColumn.AllowEdit = false;
            this._gcProductServiceName.Visible = true;
            this._gcProductServiceName.VisibleIndex = 1;
            this._gcProductServiceName.Width = 82;
            // 
            // _riProductServiceName
            // 
            this._riProductServiceName.Name = "_riProductServiceName";
            // 
            // _gcProductServiceDoctor
            // 
            this._gcProductServiceDoctor.Caption = "Bác sĩ";
            this._gcProductServiceDoctor.Name = "_gcProductServiceDoctor";
            this._gcProductServiceDoctor.Visible = true;
            this._gcProductServiceDoctor.VisibleIndex = 2;
            this._gcProductServiceDoctor.Width = 79;
            // 
            // _gcProductServiceOrderDisplayName
            // 
            this._gcProductServiceOrderDisplayName.Caption = "Hồ sơ";
            this._gcProductServiceOrderDisplayName.Name = "_gcProductServiceOrderDisplayName";
            this._gcProductServiceOrderDisplayName.Visible = true;
            this._gcProductServiceOrderDisplayName.VisibleIndex = 2;
            this._gcProductServiceOrderDisplayName.Width = 35;
            // 
            // _gcOrderItemId
            // 
            this._gcOrderItemId.Caption = "Mã";
            this._gcOrderItemId.Name = "_gcOrderItemId";
            // 
            // repositoryItemHyperLinkEdit3
            // 
            this.repositoryItemHyperLinkEdit3.AutoHeight = false;
            this.repositoryItemHyperLinkEdit3.Image = ((System.Drawing.Image)(resources.GetObject("repositoryItemHyperLinkEdit3.Image")));
            this.repositoryItemHyperLinkEdit3.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemHyperLinkEdit3.Name = "repositoryItemHyperLinkEdit3";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.NullDate = "";
            // 
            // repositoryItemHyperLinkEdit4
            // 
            this.repositoryItemHyperLinkEdit4.AutoHeight = false;
            this.repositoryItemHyperLinkEdit4.Image = ((System.Drawing.Image)(resources.GetObject("repositoryItemHyperLinkEdit4.Image")));
            this.repositoryItemHyperLinkEdit4.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemHyperLinkEdit4.Name = "repositoryItemHyperLinkEdit4";
            // 
            // _tabPageSteps
            // 
            this._tabPageSteps.Controls.Add(this._ucProductServiceSteps);
            this._tabPageSteps.Location = new System.Drawing.Point(4, 23);
            this._tabPageSteps.Margin = new System.Windows.Forms.Padding(2);
            this._tabPageSteps.Name = "_tabPageSteps";
            this._tabPageSteps.Padding = new System.Windows.Forms.Padding(2);
            this._tabPageSteps.Size = new System.Drawing.Size(368, 437);
            this._tabPageSteps.TabIndex = 1;
            this._tabPageSteps.Text = "Bước điều trị";
            this._tabPageSteps.UseVisualStyleBackColor = true;
            // 
            // _ucProductServiceSteps
            // 
            this._ucProductServiceSteps.AddAction = null;
            this._ucProductServiceSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucProductServiceSteps.Location = new System.Drawing.Point(2, 2);
            this._ucProductServiceSteps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._ucProductServiceSteps.Name = "_ucProductServiceSteps";
            this._ucProductServiceSteps.RightsCode = null;
            this._ucProductServiceSteps.Size = new System.Drawing.Size(364, 433);
            this._ucProductServiceSteps.TabIndex = 135;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this._chkIsDoctor);
            this.panel3.Controls.Add(this._cbbSelectDoctor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 674);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 25);
            this.panel3.TabIndex = 19;
            // 
            // _chkIsDoctor
            // 
            this._chkIsDoctor.Dock = System.Windows.Forms.DockStyle.Left;
            this._chkIsDoctor.EditValue = true;
            this._chkIsDoctor.Location = new System.Drawing.Point(0, 0);
            this._chkIsDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._chkIsDoctor.Name = "_chkIsDoctor";
            this._chkIsDoctor.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkIsDoctor.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this._chkIsDoctor.Properties.Appearance.Options.UseFont = true;
            this._chkIsDoctor.Properties.Appearance.Options.UseForeColor = true;
            this._chkIsDoctor.Properties.Caption = "Bác sĩ:";
            this._chkIsDoctor.Size = new System.Drawing.Size(68, 25);
            this._chkIsDoctor.TabIndex = 325;
            this._chkIsDoctor.CheckedChanged += new System.EventHandler(this._chkIsDoctor_CheckedChanged);
            // 
            // _cbbSelectDoctor
            // 
            this._cbbSelectDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbbSelectDoctor.FilterModelFunc = null;
            this._cbbSelectDoctor.IsAutoLoadData = true;
            this._cbbSelectDoctor.IsHideDeleteButton = false;
            this._cbbSelectDoctor.IsIgnoreAdmin = false;
            this._cbbSelectDoctor.IsUseValueAsDisplayName = false;
            this._cbbSelectDoctor.Location = new System.Drawing.Point(71, 2);
            this._cbbSelectDoctor.Margin = new System.Windows.Forms.Padding(0);
            this._cbbSelectDoctor.Name = "_cbbSelectDoctor";
            this._cbbSelectDoctor.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbbSelectDoctor.Properties.Appearance.Options.UseFont = true;
            this._cbbSelectDoctor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this._cbbSelectDoctor.Properties.DisplayMember = "FullName";
            this._cbbSelectDoctor.Properties.ImmediatePopup = true;
            this._cbbSelectDoctor.Properties.NullText = "--- Chọn ---";
            this._cbbSelectDoctor.SameDataSourceControls = null;
            this._cbbSelectDoctor.Size = new System.Drawing.Size(306, 20);
            this._cbbSelectDoctor.TabIndex = 134;
            this._cbbSelectDoctor.EditValueChanged += new System.EventHandler(this._cbbSelectDoctor_EditValueChanged);
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(1344, 729);
            this.splitContainer1.SplitterPosition = 380;
            this.splitContainer1.TabIndex = 1;
            // 
            // UcOrderItemTracks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UcOrderItemTracks";
            this.Size = new System.Drawing.Size(1344, 729);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._chkIsHideList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkIsMinColumn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkIsGroupByOrderItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkIsGroupByOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkReduce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._chbIsShowAllHistoriesOfOrders.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._chbIsShowAllHistoriesOfCustomers.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this._tlbBody.ResumeLayout(false);
            this._tblHistoryFunctions.ResumeLayout(false);
            this._tblHistoryFunctions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._chkIsForOld.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkIsMainProcess.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkIsNoTreatment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._chbIsNextContent.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._cbbSelectAssistant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2.Panel1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2.Panel2)).EndInit();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_dtNgayThang.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_dtNgayThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._riTreatmentContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._riExplanation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._riNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._repoSelectDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._repoSelectAssistant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._rChkIsFinishStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._rdeFinishedDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._rdeFinishedDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._rChkIsMainDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._rChkIsMainAssistant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._rChkIsPaidRose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._rDateRosePaidDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._rDateRosePaidDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._riTreatmentContentEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_lnkInToaThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_lnkXemCLS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._riExplanationEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lnkBookLabo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._riNoteEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtExtraContent.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._txtMultiRows.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._chbIsShowAllItems.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lblShowOrders.Properties)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this._grbOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._viewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).EndInit();
            this._tabControlProductServicesSteps.ResumeLayout(false);
            this._tabPageServivces.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gridOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._vieOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._riProductServiceName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit4)).EndInit();
            this._tabPageSteps.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._chkIsDoctor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbSelectDoctor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1.Panel1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1.Panel2)).EndInit();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

       



        #endregion
        private DevExpress.XtraGrid.GridControl _gridOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView _viewOrders;
        private DevExpress.XtraGrid.Columns.GridColumn _gccTreatmentId;
        private DevExpress.XtraGrid.Columns.GridColumn _gccTreatmentCreatedDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn _gccTreatmentIsClosed;
        private DevExpress.XtraGrid.Columns.GridColumn _gccTreatmentIsCancelled;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit2;
        private DevExpress.XtraGrid.GridControl _grid;
        private DevExpress.XtraGrid.Views.Grid.GridView _view;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderItemStepContent;
       
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderItemStepCreatedDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit r_dtNgayThang;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderItemStepDoctorFullName;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderItemStepHasPrescription;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderItemStepHasSubclinicals;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderItemStepTeethName;
        //private DevExpress.XtraGrid.Columns.GridColumn _gccHistoryAssistantUsername;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderItemStepDescription;
       
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit lnkXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit _rChkIsFinishStep;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit r_lnkInToaThuoc;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit r_lnkXemCLS;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderItemStepPrescriptionId;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderItemStepSubclinicalId;
        private System.Windows.Forms.GroupBox _grbOrders;
        private DevExpress.XtraGrid.GridControl _gridOrderItems;
        private DevExpress.XtraGrid.Views.Grid.GridView _vieOrderItems;
        private DevExpress.XtraGrid.Columns.GridColumn _gcPdsvTargetName;
        private DevExpress.XtraGrid.Columns.GridColumn _gcProductServiceName;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn _gcProductServiceOrderDisplayName;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit4;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.Columns.GridColumn _gcProductServiceDoctor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.CheckEdit _lblShowOrders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.CheckEdit _chbIsShowAllHistoriesOfCustomers;
        private DevExpress.XtraEditors.CheckEdit _chbIsShowAllHistoriesOfOrders;
        private DevExpress.XtraEditors.CheckEdit _chbIsShowAllItems;
        private System.Windows.Forms.TableLayoutPanel _tlbBody;
        private System.Windows.Forms.TableLayoutPanel _tblHistoryFunctions;
        private DevExpress.XtraEditors.CheckEdit _chbIsNextContent;
        private DevExpress.XtraEditors.SimpleButton _btnSaveExtraHistory;
        private DevExpress.XtraEditors.MemoEdit _txtExtraContent;
        private SBoxUserAccount _cbbSelectAssistant;
        private DevExpress.XtraEditors.LabelControl lblPhuTa;
        private System.Windows.Forms.TabControl _tabControlProductServicesSteps;
        private System.Windows.Forms.TabPage _tabPageServivces;
        private System.Windows.Forms.TabPage _tabPageSteps;
        private UcOrderItemSteps _ucProductServiceSteps;
        private SRepUserAccount _repoSelectAssistant;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderItemStepDelete;
        private DevExpress.XtraEditors.SimpleButton _btnSave;
        private DevExpress.XtraEditors.SimpleButton _btnTransfer;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderItemStepIsFinishTreatment;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderItemStepIsNextContent;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderItemStepGroupName;
        private DevExpress.XtraEditors.CheckEdit _chkReduce;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton _btnShowExtraNote;
        private DevExpress.XtraEditors.SimpleButton _btnShowHideNotes;
        private DevExpress.XtraEditors.CheckEdit _chkIsNoTreatment;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderItemStepIsNoTreatment;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderItemStepIsFinishStep;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderItemStepFinishDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit _rdeFinishedDate;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderItemStepAssistantFullName;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderItemStepIsNoCommission;
        private DevExpress.XtraEditors.CheckEdit _chkIsGroupByOrderItem;
        private DevExpress.XtraEditors.CheckEdit _chkIsGroupByOrder;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderItemStepOrderId;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderItemStepOrderItemPdsvName;
        private DevExpress.XtraGrid.Columns.GridColumn _gcOrderItemStepOrderItemStepId;
        private DevExpress.XtraEditors.CheckEdit _chkIsMainProcess;
        private SRepUserAccount _repoSelectDoctor;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private GridColumn _gcOrderItemStepIsAssistantMain;
        private GridColumn _gcOrderItemStepBookLabo;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit _lnkBookLabo;
        private DevExpress.XtraEditors.SimpleButton _btnCancelChanges;
        private DevExpress.XtraEditors.SimpleButton _btnWidthRight;
        private DevExpress.XtraEditors.SimpleButton _btnWidthLeft;
        private DevExpress.XtraEditors.SplitContainerControl splitContainer1;
        private GridColumn _gcIsPaidRose;
        private GridColumn _gcRosePaidDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit _rChkIsPaidRose;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit _rDateRosePaidDate;
        private GridColumn _gcOrderItemStepIsDoctorMain;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit _rChkIsMainDoctor;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit _rChkIsMainAssistant;
        private GridColumn _gcId;
        private GridColumn _gcOrderItemId;
        private DevExpress.XtraEditors.CheckEdit _chkIsForOld;
        private GridColumn _gcIsForOld;
        private DevExpress.XtraEditors.SplitContainerControl splitContainer2;
        private DevExpress.XtraEditors.CheckEdit _chkIsMinColumn;
        private DevExpress.XtraEditors.CheckEdit _chkIsHideList;
        private GridColumn _gcOrderItemStepNote;
        
        private System.Windows.Forms.Panel panel3;
        private SBoxUserAccount _cbbSelectDoctor;
        private DevExpress.XtraEditors.CheckEdit _chkIsDoctor;
      
        private DevExpress.XtraEditors.CheckEdit _txtMultiRows;

        private RepositoryEditorMemo _riProductServiceName;

        private RepositoryEditorMemo _riNote;
        private RepositoryEditorMemoEx _riNoteEx;

        private RepositoryEditorMemo _riTreatmentContent;
        private RepositoryEditorMemoEx _riTreatmentContentEx;

        private RepositoryEditorMemo _riExplanation;
        private RepositoryEditorMemoEx _riExplanationEx;
    }
}