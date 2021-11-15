namespace VegunSoft.Customer.View.Dev.UserControls
{
    partial class SFilterCustomer
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.rdgTimKiem = new DevExpress.XtraEditors.RadioGroup();
            this._cbbCustomers = new DevExpress.XtraEditors.GridLookUpEdit();
            this._viewCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gcSearchCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcSearchCustomerFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcSearchCustomerPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcSearchContent = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcSearchCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcSearchKeyword = new DevExpress.XtraGrid.Columns.GridColumn();
            this._gcSearchUnsignKeyword = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rdgTimKiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbCustomers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._viewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // rdgTimKiem
            // 
            this.rdgTimKiem.Location = new System.Drawing.Point(0, 0);
            this.rdgTimKiem.Margin = new System.Windows.Forms.Padding(0);
            this.rdgTimKiem.Name = "rdgTimKiem";
            this.rdgTimKiem.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rdgTimKiem.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgTimKiem.Properties.Appearance.Options.UseBackColor = true;
            this.rdgTimKiem.Properties.Appearance.Options.UseFont = true;
            this.rdgTimKiem.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rdgTimKiem.Properties.Columns = 2;
            this.rdgTimKiem.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.rdgTimKiem.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tất cả"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "ID"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tên"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Điện thoại")});
            this.rdgTimKiem.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow;
            this.rdgTimKiem.Size = new System.Drawing.Size(254, 25);
            this.rdgTimKiem.TabIndex = 255;
            // 
            // _cbbCustomers
            // 
            this._cbbCustomers.Location = new System.Drawing.Point(0, 34);
            this._cbbCustomers.Margin = new System.Windows.Forms.Padding(0);
            this._cbbCustomers.Name = "_cbbCustomers";
            this._cbbCustomers.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbbCustomers.Properties.Appearance.Options.UseFont = true;
            this._cbbCustomers.Properties.AutoComplete = false;
            this._cbbCustomers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Tìm khách hàng theo tất cả chi nhánh", null, null, true)});
            this._cbbCustomers.Properties.DisplayMember = "DisplayName";
            this._cbbCustomers.Properties.NullText = "Tìm khách hàng";
            this._cbbCustomers.Properties.PopupFormMinSize = new System.Drawing.Size(800, 300);
            this._cbbCustomers.Properties.PopupFormSize = new System.Drawing.Size(800, 300);
            this._cbbCustomers.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this._cbbCustomers.Properties.ValueMember = "Id";
            this._cbbCustomers.Properties.View = this._viewCustomers;
            this._cbbCustomers.Size = new System.Drawing.Size(256, 20);
            this._cbbCustomers.TabIndex = 257;
            this._cbbCustomers.QueryPopUp += new System.ComponentModel.CancelEventHandler(this._cbbCustomers_QueryPopUp);
            this._cbbCustomers.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this._cbbCustomers_ButtonClick);
            this._cbbCustomers.Click += new System.EventHandler(this._cbbCustomers_Click_1);
            this._cbbCustomers.KeyDown += new System.Windows.Forms.KeyEventHandler(this._cbbCustomers_KeyDown);
            this._cbbCustomers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._cbbCustomers_KeyPress);
            // 
            // _viewCustomers
            // 
            this._viewCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._gcSearchCustomerId,
            this._gcSearchCustomerFullName,
            this._gcSearchCustomerPhone,
            this._gcSearchContent,
            this._gcSearchCreatedDate,
            this._gcSearchKeyword,
            this._gcSearchUnsignKeyword});
            this._viewCustomers.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this._viewCustomers.Name = "_viewCustomers";
            this._viewCustomers.OptionsBehavior.AutoExpandAllGroups = true;
            this._viewCustomers.OptionsSelection.EnableAppearanceFocusedCell = false;
            this._viewCustomers.OptionsView.ShowAutoFilterRow = true;
            this._viewCustomers.OptionsView.ShowGroupPanel = false;
            this._viewCustomers.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this._gcSearchCreatedDate, DevExpress.Data.ColumnSortOrder.Descending)});
            this._viewCustomers.ColumnFilterChanged += new System.EventHandler(this.glkView_ColumnFilterChanged);
            // 
            // _gcSearchCustomerId
            // 
            this._gcSearchCustomerId.Caption = "Mã KH";
            this._gcSearchCustomerId.FieldName = "CustomerId";
            this._gcSearchCustomerId.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this._gcSearchCustomerId.MinWidth = 80;
            this._gcSearchCustomerId.Name = "_gcSearchCustomerId";
            this._gcSearchCustomerId.Visible = true;
            this._gcSearchCustomerId.VisibleIndex = 0;
            this._gcSearchCustomerId.Width = 80;
            // 
            // _gcSearchCustomerFullName
            // 
            this._gcSearchCustomerFullName.AppearanceCell.Font = new System.Drawing.Font("Verdana", 9F);
            this._gcSearchCustomerFullName.AppearanceCell.Options.UseFont = true;
            this._gcSearchCustomerFullName.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 9F);
            this._gcSearchCustomerFullName.AppearanceHeader.Options.UseFont = true;
            this._gcSearchCustomerFullName.Caption = "Họ tên";
            this._gcSearchCustomerFullName.FieldName = "CustomerFullName";
            this._gcSearchCustomerFullName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this._gcSearchCustomerFullName.MinWidth = 160;
            this._gcSearchCustomerFullName.Name = "_gcSearchCustomerFullName";
            this._gcSearchCustomerFullName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this._gcSearchCustomerFullName.Visible = true;
            this._gcSearchCustomerFullName.VisibleIndex = 1;
            this._gcSearchCustomerFullName.Width = 160;
            // 
            // _gcSearchCustomerPhone
            // 
            this._gcSearchCustomerPhone.AppearanceCell.Font = new System.Drawing.Font("Verdana", 9F);
            this._gcSearchCustomerPhone.AppearanceCell.Options.UseFont = true;
            this._gcSearchCustomerPhone.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 9F);
            this._gcSearchCustomerPhone.AppearanceHeader.Options.UseFont = true;
            this._gcSearchCustomerPhone.Caption = "SĐT";
            this._gcSearchCustomerPhone.FieldName = "CustomerPhoneNumber";
            this._gcSearchCustomerPhone.Name = "_gcSearchCustomerPhone";
            this._gcSearchCustomerPhone.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this._gcSearchCustomerPhone.Visible = true;
            this._gcSearchCustomerPhone.VisibleIndex = 2;
            this._gcSearchCustomerPhone.Width = 120;
            // 
            // _gcSearchContent
            // 
            this._gcSearchContent.AppearanceCell.Font = new System.Drawing.Font("Verdana", 9F);
            this._gcSearchContent.AppearanceCell.Options.UseFont = true;
            this._gcSearchContent.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 9F);
            this._gcSearchContent.AppearanceHeader.Options.UseFont = true;
            this._gcSearchContent.Caption = "Địa chỉ";
            this._gcSearchContent.FieldName = "Address";
            this._gcSearchContent.Name = "_gcSearchContent";
            this._gcSearchContent.Visible = true;
            this._gcSearchContent.VisibleIndex = 3;
            this._gcSearchContent.Width = 160;
            // 
            // _gcSearchCreatedDate
            // 
            this._gcSearchCreatedDate.Caption = "Ngày tạo";
            this._gcSearchCreatedDate.FieldName = "CreatedDate";
            this._gcSearchCreatedDate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this._gcSearchCreatedDate.MinWidth = 70;
            this._gcSearchCreatedDate.Name = "_gcSearchCreatedDate";
            this._gcSearchCreatedDate.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this._gcSearchCreatedDate.Visible = true;
            this._gcSearchCreatedDate.VisibleIndex = 4;
            this._gcSearchCreatedDate.Width = 70;
            // 
            // _gcSearchKeyword
            // 
            this._gcSearchKeyword.Caption = "Keyword";
            this._gcSearchKeyword.Name = "_gcSearchKeyword";
            // 
            // _gcSearchUnsignKeyword
            // 
            this._gcSearchUnsignKeyword.Caption = "UnsignKeyword";
            this._gcSearchUnsignKeyword.Name = "_gcSearchUnsignKeyword";
            // 
            // BcSearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._cbbCustomers);
            this.Controls.Add(this.rdgTimKiem);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BcSearchCustomer";
            this.Size = new System.Drawing.Size(256, 54);
            ((System.ComponentModel.ISupportInitialize)(this.rdgTimKiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbCustomers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._viewCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private global::DevExpress.XtraEditors.RadioGroup rdgTimKiem;
        private global::DevExpress.XtraEditors.GridLookUpEdit _cbbCustomers;
        private global::DevExpress.XtraGrid.Views.Grid.GridView _viewCustomers;
        private global::DevExpress.XtraGrid.Columns.GridColumn _gcSearchCustomerId;
        private global::DevExpress.XtraGrid.Columns.GridColumn _gcSearchCustomerFullName;
        private global::DevExpress.XtraGrid.Columns.GridColumn _gcSearchCustomerPhone;
        private global::DevExpress.XtraGrid.Columns.GridColumn _gcSearchContent;
        private global::DevExpress.XtraGrid.Columns.GridColumn _gcSearchCreatedDate;
        //private DevExpress.XtraGrid.Columns.GridColumn _gcSearchCompactKeywords;
        private DevExpress.XtraGrid.Columns.GridColumn _gcSearchUnsignKeyword;
        private DevExpress.XtraGrid.Columns.GridColumn _gcSearchKeyword;
    }
}
