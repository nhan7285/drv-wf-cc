using VegunSoft.Company.Editor.Provider.Structure;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Editors;

namespace VegunSoft.Layer.UcControl.Provider.App
{
    partial class UcConfigFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcConfigFilter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._btnSave = new DevExpress.XtraEditors.SimpleButton();
            this._btnSaveToExcel = new DevExpress.XtraEditors.SimpleButton();
            this._cbbListBranches = new SBoxBranch();
            this._lblBranch = new DevExpress.XtraEditors.CheckEdit();
            this._btnGoLast = new DevExpress.XtraEditors.SimpleButton();
            this._btnGoNext = new DevExpress.XtraEditors.SimpleButton();
            this._btnGoFirst = new DevExpress.XtraEditors.SimpleButton();
            this._btnGoBack = new DevExpress.XtraEditors.SimpleButton();
            this._btnReload = new DevExpress.XtraEditors.SimpleButton();
            this._rdgDateTime = new DevExpress.XtraEditors.RadioGroup();
            this._txtDateRange = new DevExpress.XtraEditors.CalcEdit();
            this._lblDateRange = new DevExpress.XtraEditors.CheckEdit();
            this._txtFromDate = new VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Editors.VegunDateEdit();
            this._checkBoxLabelFromDate = new DevExpress.XtraEditors.CheckEdit();
            this._txtToDate = new VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Editors.VegunDateEdit();
            this._checkBoxLabelToDate = new DevExpress.XtraEditors.CheckEdit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cbbListBranches.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lblBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._rdgDateTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtDateRange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lblDateRange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._checkBoxLabelFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._checkBoxLabelToDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this._cbbListBranches);
            this.panel1.Controls.Add(this._lblBranch);
            this.panel1.Controls.Add(this._btnGoLast);
            this.panel1.Controls.Add(this._btnGoNext);
            this.panel1.Controls.Add(this._btnGoFirst);
            this.panel1.Controls.Add(this._btnGoBack);
            this.panel1.Controls.Add(this._btnReload);
            this.panel1.Controls.Add(this._rdgDateTime);
            this.panel1.Controls.Add(this._txtDateRange);
            this.panel1.Controls.Add(this._lblDateRange);
            this.panel1.Controls.Add(this._txtFromDate);
            this.panel1.Controls.Add(this._checkBoxLabelFromDate);
            this.panel1.Controls.Add(this._txtToDate);
            this.panel1.Controls.Add(this._checkBoxLabelToDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 65);
            this.panel1.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._btnSave, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._btnSaveToExcel, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(802, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(142, 57);
            this.tableLayoutPanel1.TabIndex = 316;
            // 
            // _btnSave
            // 
            this._btnSave.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnSave.Appearance.Options.UseFont = true;
            this._btnSave.Appearance.Options.UseTextOptions = true;
            this._btnSave.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this._btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnSave.ImageOptions.Image")));
            this._btnSave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this._btnSave.Location = new System.Drawing.Point(3, 0);
            this._btnSave.Margin = new System.Windows.Forms.Padding(0);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(60, 57);
            this._btnSave.TabIndex = 315;
            this._btnSave.Text = "Lưu";
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnSaveToExcel
            // 
            this._btnSaveToExcel.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnSaveToExcel.Appearance.Options.UseFont = true;
            this._btnSaveToExcel.Appearance.Options.UseTextOptions = true;
            this._btnSaveToExcel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this._btnSaveToExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnSaveToExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnSaveToExcel.ImageOptions.Image")));
            this._btnSaveToExcel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this._btnSaveToExcel.Location = new System.Drawing.Point(66, 0);
            this._btnSaveToExcel.Margin = new System.Windows.Forms.Padding(0);
            this._btnSaveToExcel.Name = "_btnSaveToExcel";
            this._btnSaveToExcel.Size = new System.Drawing.Size(60, 57);
            this._btnSaveToExcel.TabIndex = 314;
            this._btnSaveToExcel.Text = "Excel";
            this._btnSaveToExcel.Click += new System.EventHandler(this._btnSaveToExcel_Click);
            // 
            // _cbbListBranches
            // 
            this._cbbListBranches.Enabled = false;
            this._cbbListBranches.IsAutoLoadData = false;
            this._cbbListBranches.IsInited = true;
            this._cbbListBranches.Location = new System.Drawing.Point(636, 7);
            this._cbbListBranches.Name = "_cbbListBranches";
            this._cbbListBranches.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbbListBranches.Properties.Appearance.Options.UseFont = true;
            this._cbbListBranches.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this._cbbListBranches.Properties.NullText = "--- Chọn ---";
            this._cbbListBranches.Size = new System.Drawing.Size(165, 20);
            this._cbbListBranches.TabIndex = 313;
            // 
            // _lblBranch
            // 
            this._lblBranch.EditValue = true;
            this._lblBranch.Enabled = false;
            this._lblBranch.Location = new System.Drawing.Point(553, 8);
            this._lblBranch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._lblBranch.Name = "_lblBranch";
            this._lblBranch.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblBranch.Properties.Appearance.Options.UseFont = true;
            this._lblBranch.Properties.Caption = "Cơ sở:";
            this._lblBranch.Size = new System.Drawing.Size(66, 20);
            this._lblBranch.TabIndex = 312;
            // 
            // _btnGoLast
            // 
            this._btnGoLast.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnGoLast.Appearance.Options.UseFont = true;
            this._btnGoLast.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnGoLast.ImageOptions.Image")));
            this._btnGoLast.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this._btnGoLast.Location = new System.Drawing.Point(774, 34);
            this._btnGoLast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnGoLast.Name = "_btnGoLast";
            this._btnGoLast.Size = new System.Drawing.Size(27, 25);
            this._btnGoLast.TabIndex = 311;
            // 
            // _btnGoNext
            // 
            this._btnGoNext.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnGoNext.Appearance.Options.UseFont = true;
            this._btnGoNext.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnGoNext.ImageOptions.Image")));
            this._btnGoNext.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this._btnGoNext.Location = new System.Drawing.Point(746, 34);
            this._btnGoNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnGoNext.Name = "_btnGoNext";
            this._btnGoNext.Size = new System.Drawing.Size(27, 25);
            this._btnGoNext.TabIndex = 310;
            // 
            // _btnGoFirst
            // 
            this._btnGoFirst.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnGoFirst.Appearance.Options.UseFont = true;
            this._btnGoFirst.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnGoFirst.ImageOptions.Image")));
            this._btnGoFirst.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this._btnGoFirst.Location = new System.Drawing.Point(547, 34);
            this._btnGoFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnGoFirst.Name = "_btnGoFirst";
            this._btnGoFirst.Size = new System.Drawing.Size(27, 25);
            this._btnGoFirst.TabIndex = 309;
            // 
            // _btnGoBack
            // 
            this._btnGoBack.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnGoBack.Appearance.Options.UseFont = true;
            this._btnGoBack.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnGoBack.ImageOptions.Image")));
            this._btnGoBack.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this._btnGoBack.Location = new System.Drawing.Point(575, 34);
            this._btnGoBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnGoBack.Name = "_btnGoBack";
            this._btnGoBack.Size = new System.Drawing.Size(27, 25);
            this._btnGoBack.TabIndex = 308;
            // 
            // _btnReload
            // 
            this._btnReload.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._btnReload.Appearance.ForeColor = System.Drawing.Color.Black;
            this._btnReload.Appearance.Options.UseFont = true;
            this._btnReload.Appearance.Options.UseForeColor = true;
            this._btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnReload.ImageOptions.Image")));
            this._btnReload.Location = new System.Drawing.Point(603, 33);
            this._btnReload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._btnReload.Name = "_btnReload";
            this._btnReload.Size = new System.Drawing.Size(142, 27);
            this._btnReload.TabIndex = 307;
            this._btnReload.Text = "Xem / Làm mới";
            this._btnReload.Click += new System.EventHandler(this._btnReload_Click);
            // 
            // _rdgDateTime
            // 
            this._rdgDateTime.Location = new System.Drawing.Point(3, 6);
            this._rdgDateTime.Name = "_rdgDateTime";
            this._rdgDateTime.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._rdgDateTime.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._rdgDateTime.Properties.Appearance.Options.UseBackColor = true;
            this._rdgDateTime.Properties.Appearance.Options.UseFont = true;
            this._rdgDateTime.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._rdgDateTime.Properties.Columns = 2;
            this._rdgDateTime.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._rdgDateTime.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Ngày"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tháng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Năm"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Khoảng")});
            this._rdgDateTime.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow;
            this._rdgDateTime.Size = new System.Drawing.Size(259, 25);
            this._rdgDateTime.TabIndex = 301;
            // 
            // _txtDateRange
            // 
            this._txtDateRange.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this._txtDateRange.Location = new System.Drawing.Point(376, 8);
            this._txtDateRange.Margin = new System.Windows.Forms.Padding(1);
            this._txtDateRange.Name = "_txtDateRange";
            this._txtDateRange.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtDateRange.Properties.Appearance.ForeColor = System.Drawing.Color.Green;
            this._txtDateRange.Properties.Appearance.Options.UseFont = true;
            this._txtDateRange.Properties.Appearance.Options.UseForeColor = true;
            this._txtDateRange.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._txtDateRange.Properties.DisplayFormat.FormatString = "n0";
            this._txtDateRange.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._txtDateRange.Properties.EditFormat.FormatString = "n0";
            this._txtDateRange.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._txtDateRange.Properties.Mask.EditMask = "n0";
            this._txtDateRange.Size = new System.Drawing.Size(168, 20);
            this._txtDateRange.TabIndex = 303;
            // 
            // _lblDateRange
            // 
            this._lblDateRange.EditValue = true;
            this._lblDateRange.Location = new System.Drawing.Point(263, 9);
            this._lblDateRange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._lblDateRange.Name = "_lblDateRange";
            this._lblDateRange.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblDateRange.Properties.Appearance.Options.UseFont = true;
            this._lblDateRange.Properties.Caption = "Khoảng ngày:";
            this._lblDateRange.Size = new System.Drawing.Size(110, 20);
            this._lblDateRange.TabIndex = 304;
            // 
            // _txtFromDate
            // 
            this._txtFromDate.EditValue = "";
            
            this._txtFromDate.Location = new System.Drawing.Point(86, 36);
            this._txtFromDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._txtFromDate.Name = "_txtFromDate";
            this._txtFromDate.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._txtFromDate.Properties.Appearance.Options.UseFont = true;
            this._txtFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this._txtFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._txtFromDate.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this._txtFromDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this._txtFromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._txtFromDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this._txtFromDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._txtFromDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this._txtFromDate.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this._txtFromDate.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.MonthView;
            this._txtFromDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this._txtFromDate.Size = new System.Drawing.Size(165, 20);
            this._txtFromDate.TabIndex = 300;
            // 
            // _checkBoxLabelFromDate
            // 
            this._checkBoxLabelFromDate.EditValue = true;
            this._checkBoxLabelFromDate.Location = new System.Drawing.Point(3, 37);
            this._checkBoxLabelFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._checkBoxLabelFromDate.Name = "_checkBoxLabelFromDate";
            this._checkBoxLabelFromDate.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._checkBoxLabelFromDate.Properties.Appearance.Options.UseFont = true;
            this._checkBoxLabelFromDate.Properties.Caption = "Từ ngày:";
            this._checkBoxLabelFromDate.Size = new System.Drawing.Size(80, 20);
            this._checkBoxLabelFromDate.TabIndex = 305;
            // 
            // _txtToDate
            // 
            this._txtToDate.EditValue = null;
            
            this._txtToDate.Location = new System.Drawing.Point(376, 36);
            this._txtToDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._txtToDate.Name = "_txtToDate";
            this._txtToDate.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this._txtToDate.Properties.Appearance.Options.UseFont = true;
            this._txtToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this._txtToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._txtToDate.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this._txtToDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this._txtToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._txtToDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this._txtToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._txtToDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this._txtToDate.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.MonthView;
            this._txtToDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this._txtToDate.Size = new System.Drawing.Size(168, 20);
            this._txtToDate.TabIndex = 302;
            // 
            // _checkBoxLabelToDate
            // 
            this._checkBoxLabelToDate.EditValue = true;
            this._checkBoxLabelToDate.Location = new System.Drawing.Point(263, 37);
            this._checkBoxLabelToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._checkBoxLabelToDate.Name = "_checkBoxLabelToDate";
            this._checkBoxLabelToDate.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._checkBoxLabelToDate.Properties.Appearance.Options.UseFont = true;
            this._checkBoxLabelToDate.Properties.Caption = "Đến ngày:";
            this._checkBoxLabelToDate.Size = new System.Drawing.Size(100, 20);
            this._checkBoxLabelToDate.TabIndex = 306;
            // 
            // UcConfigFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcConfigFilter";
            this.Size = new System.Drawing.Size(944, 65);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._cbbListBranches.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lblBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._rdgDateTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtDateRange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lblDateRange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._checkBoxLabelFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._checkBoxLabelToDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton _btnSaveToExcel;
        private SBoxBranch _cbbListBranches;
        private DevExpress.XtraEditors.CheckEdit _lblBranch;
        private DevExpress.XtraEditors.SimpleButton _btnGoLast;
        private DevExpress.XtraEditors.SimpleButton _btnGoNext;
        private DevExpress.XtraEditors.SimpleButton _btnGoFirst;
        private DevExpress.XtraEditors.SimpleButton _btnGoBack;
        private DevExpress.XtraEditors.SimpleButton _btnReload;
        private DevExpress.XtraEditors.RadioGroup _rdgDateTime;
        private DevExpress.XtraEditors.CalcEdit _txtDateRange;
        private DevExpress.XtraEditors.CheckEdit _lblDateRange;
        private VegunDateEdit _txtFromDate;
        private DevExpress.XtraEditors.CheckEdit _checkBoxLabelFromDate;
        private VegunDateEdit _txtToDate;
        private DevExpress.XtraEditors.CheckEdit _checkBoxLabelToDate;
        private DevExpress.XtraEditors.SimpleButton _btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
