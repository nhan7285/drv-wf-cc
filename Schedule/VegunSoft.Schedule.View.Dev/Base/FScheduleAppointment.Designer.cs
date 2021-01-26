
using VegunSoft.Company.Editor.Provider.Structure;

namespace VegunSoft.Schedule.View.Dev.Base
{
    partial class FScheduleAppointment
    {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FScheduleAppointment));
            this._lblSubject = new DevExpress.XtraEditors.LabelControl();
            this._lblLocation = new DevExpress.XtraEditors.LabelControl();
            this.tbSubject = new DevExpress.XtraEditors.TextEdit();
            this._lblStartTime = new DevExpress.XtraEditors.LabelControl();
            this._lblEndTime = new DevExpress.XtraEditors.LabelControl();
            this._chkAllDay = new DevExpress.XtraEditors.CheckEdit();
            this._lblBookingType = new DevExpress.XtraEditors.LabelControl();
            this._btnOk = new DevExpress.XtraEditors.SimpleButton();
            this._btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this._btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this._btnRecurrence = new DevExpress.XtraEditors.SimpleButton();
            this.edtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.edtEndDate = new DevExpress.XtraEditors.DateEdit();
            this.tbDescription = new DevExpress.XtraEditors.MemoEdit();
            this._lblResource = new DevExpress.XtraEditors.LabelControl();
            this.edtStartTime = new DevExpress.XtraEditors.TimeEdit();
            this.edtEndTime = new DevExpress.XtraEditors.TimeEdit();
            this.edtShowTimeAs = new DevExpress.XtraScheduler.UI.AppointmentStatusEdit();
            this._cbbBranch = new VegunSoft.Company.Editor.Provider.Structure.SBoxBranch();
            this.edtResource = new DevExpress.XtraScheduler.UI.AppointmentResourceEdit();
            this.edtResources = new DevExpress.XtraScheduler.UI.AppointmentResourcesEdit();
            this._chkIsActive = new DevExpress.XtraEditors.CheckEdit();
            this._lblLabel = new DevExpress.XtraEditors.LabelControl();
            this.edtLabel = new DevExpress.XtraScheduler.UI.AppointmentLabelEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkAllDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtShowTimeAs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.ResourcesCheckedListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkIsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblSubject
            // 
            resources.ApplyResources(this._lblSubject, "_lblSubject");
            this._lblSubject.Name = "_lblSubject";
            // 
            // _lblLocation
            // 
            resources.ApplyResources(this._lblLocation, "_lblLocation");
            this._lblLocation.Name = "_lblLocation";
            // 
            // tbSubject
            // 
            resources.ApplyResources(this.tbSubject, "tbSubject");
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Properties.AccessibleName = resources.GetString("tbSubject.Properties.AccessibleName");
            // 
            // _lblStartTime
            // 
            resources.ApplyResources(this._lblStartTime, "_lblStartTime");
            this._lblStartTime.Name = "_lblStartTime";
            // 
            // _lblEndTime
            // 
            resources.ApplyResources(this._lblEndTime, "_lblEndTime");
            this._lblEndTime.Name = "_lblEndTime";
            // 
            // _chkAllDay
            // 
            resources.ApplyResources(this._chkAllDay, "_chkAllDay");
            this._chkAllDay.Name = "_chkAllDay";
            this._chkAllDay.Properties.AccessibleName = resources.GetString("_chkAllDay.Properties.AccessibleName");
            this._chkAllDay.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this._chkAllDay.Properties.AutoWidth = true;
            this._chkAllDay.Properties.Caption = resources.GetString("_chkAllDay.Properties.Caption");
            // 
            // _lblBookingType
            // 
            resources.ApplyResources(this._lblBookingType, "_lblBookingType");
            this._lblBookingType.Name = "_lblBookingType";
            // 
            // _btnOk
            // 
            resources.ApplyResources(this._btnOk, "_btnOk");
            this._btnOk.Name = "_btnOk";
            this._btnOk.Click += new System.EventHandler(this.OnBtnOkClick);
            // 
            // _btnCancel
            // 
            resources.ApplyResources(this._btnCancel, "_btnCancel");
            this._btnCancel.CausesValidation = false;
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Name = "_btnCancel";
            // 
            // _btnDelete
            // 
            resources.ApplyResources(this._btnDelete, "_btnDelete");
            this._btnDelete.CausesValidation = false;
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Click += new System.EventHandler(this.OnBtnDeleteClick);
            // 
            // _btnRecurrence
            // 
            resources.ApplyResources(this._btnRecurrence, "_btnRecurrence");
            this._btnRecurrence.Name = "_btnRecurrence";
            this._btnRecurrence.Click += new System.EventHandler(this.OnBtnRecurrenceClick);
            // 
            // edtStartDate
            // 
            resources.ApplyResources(this.edtStartDate, "edtStartDate");
            this.edtStartDate.Name = "edtStartDate";
            this.edtStartDate.Properties.AccessibleName = resources.GetString("edtStartDate.Properties.AccessibleName");
            this.edtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("edtStartDate.Properties.Buttons"))))});
            this.edtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtStartDate.Properties.MaxValue = new System.DateTime(4000, 1, 1, 0, 0, 0, 0);
            // 
            // edtEndDate
            // 
            resources.ApplyResources(this.edtEndDate, "edtEndDate");
            this.edtEndDate.Name = "edtEndDate";
            this.edtEndDate.Properties.AccessibleName = resources.GetString("edtEndDate.Properties.AccessibleName");
            this.edtEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("edtEndDate.Properties.Buttons"))))});
            this.edtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtEndDate.Properties.MaxValue = new System.DateTime(4000, 1, 1, 0, 0, 0, 0);
            // 
            // tbDescription
            // 
            resources.ApplyResources(this.tbDescription, "tbDescription");
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Properties.AccessibleName = resources.GetString("tbDescription.Properties.AccessibleName");
            this.tbDescription.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            // 
            // _lblResource
            // 
            resources.ApplyResources(this._lblResource, "_lblResource");
            this._lblResource.Name = "_lblResource";
            // 
            // edtStartTime
            // 
            resources.ApplyResources(this.edtStartTime, "edtStartTime");
            this.edtStartTime.Name = "edtStartTime";
            this.edtStartTime.Properties.AccessibleName = resources.GetString("edtStartTime.Properties.AccessibleName");
            this.edtStartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // edtEndTime
            // 
            resources.ApplyResources(this.edtEndTime, "edtEndTime");
            this.edtEndTime.Name = "edtEndTime";
            this.edtEndTime.Properties.AccessibleName = resources.GetString("edtEndTime.Properties.AccessibleName");
            this.edtEndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // edtShowTimeAs
            // 
            resources.ApplyResources(this.edtShowTimeAs, "edtShowTimeAs");
            this.edtShowTimeAs.Name = "edtShowTimeAs";
            this.edtShowTimeAs.Properties.AccessibleName = resources.GetString("edtShowTimeAs.Properties.AccessibleName");
            this.edtShowTimeAs.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.edtShowTimeAs.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("edtShowTimeAs.Properties.Buttons"))))});
            // 
            // _cbbBranch
            // 
            resources.ApplyResources(this._cbbBranch, "_cbbBranch");
            this._cbbBranch.IsAutoLoadData = false;
            this._cbbBranch.IsInited = false;
            this._cbbBranch.Name = "_cbbBranch";
            this._cbbBranch.Properties.AccessibleName = resources.GetString("_cbbBranch.Properties.AccessibleName");
            this._cbbBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("_cbbBranch.Properties.Buttons"))))});
            // 
            // edtResource
            // 
            resources.ApplyResources(this.edtResource, "edtResource");
            this.edtResource.Name = "edtResource";
            this.edtResource.Properties.AccessibleName = resources.GetString("edtResource.Properties.AccessibleName");
            this.edtResource.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.edtResource.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.edtResource.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("edtResource.Properties.Buttons"))))});
            // 
            // edtResources
            // 
            resources.ApplyResources(this.edtResources, "edtResources");
            this.edtResources.Name = "edtResources";
            this.edtResources.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("edtResources.Properties.Buttons"))))});
            // 
            // 
            // 
            this.edtResources.ResourcesCheckedListBoxControl.CheckOnClick = true;
            this.edtResources.ResourcesCheckedListBoxControl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("edtResources.ResourcesCheckedListBoxControl.Dock")));
            this.edtResources.ResourcesCheckedListBoxControl.Location = ((System.Drawing.Point)(resources.GetObject("edtResources.ResourcesCheckedListBoxControl.Location")));
            this.edtResources.ResourcesCheckedListBoxControl.Name = "";
            this.edtResources.ResourcesCheckedListBoxControl.Size = ((System.Drawing.Size)(resources.GetObject("edtResources.ResourcesCheckedListBoxControl.Size")));
            this.edtResources.ResourcesCheckedListBoxControl.TabIndex = ((int)(resources.GetObject("edtResources.ResourcesCheckedListBoxControl.TabIndex")));
            // 
            // _chkIsActive
            // 
            resources.ApplyResources(this._chkIsActive, "_chkIsActive");
            this._chkIsActive.Name = "_chkIsActive";
            this._chkIsActive.Properties.AccessibleName = resources.GetString("_chkIsActive.Properties.AccessibleName");
            this._chkIsActive.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this._chkIsActive.Properties.AutoWidth = true;
            this._chkIsActive.Properties.Caption = resources.GetString("_chkIsActive.Properties.Caption");
            // 
            // _lblLabel
            // 
            resources.ApplyResources(this._lblLabel, "_lblLabel");
            this._lblLabel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._lblLabel.Appearance.Options.UseBackColor = true;
            this._lblLabel.Name = "_lblLabel";
            // 
            // edtLabel
            // 
            resources.ApplyResources(this.edtLabel, "edtLabel");
            this.edtLabel.Name = "edtLabel";
            this.edtLabel.Properties.AccessibleName = resources.GetString("edtLabel.Properties.AccessibleName");
            this.edtLabel.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.edtLabel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("edtLabel.Properties.Buttons"))))});
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // radioGroup1
            // 
            resources.ApplyResources(this.radioGroup1, "radioGroup1");
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup1.Properties.ItemHorzAlignment = DevExpress.XtraEditors.RadioItemHorzAlignment.Far;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((object)(resources.GetObject("radioGroup1.Properties.Items"))), resources.GetString("radioGroup1.Properties.Items1")),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((object)(resources.GetObject("radioGroup1.Properties.Items2"))), resources.GetString("radioGroup1.Properties.Items3")),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((object)(resources.GetObject("radioGroup1.Properties.Items4"))), resources.GetString("radioGroup1.Properties.Items5"))});
            this.radioGroup1.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow;
            // 
            // FScheduleAppointment
            // 
            this.AcceptButton = this._btnOk;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.Controls.Add(this.radioGroup1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this._lblLabel);
            this.Controls.Add(this.edtLabel);
            this.Controls.Add(this._chkIsActive);
            this.Controls.Add(this.edtResource);
            this.Controls.Add(this.edtResources);
            this.Controls.Add(this._chkAllDay);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this._lblResource);
            this.Controls.Add(this._cbbBranch);
            this.Controls.Add(this._lblLocation);
            this.Controls.Add(this.edtStartTime);
            this.Controls.Add(this.edtStartDate);
            this.Controls.Add(this._btnOk);
            this.Controls.Add(this._lblStartTime);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this._lblSubject);
            this.Controls.Add(this._lblEndTime);
            this.Controls.Add(this._lblBookingType);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnDelete);
            this.Controls.Add(this._btnRecurrence);
            this.Controls.Add(this.edtEndDate);
            this.Controls.Add(this.edtEndTime);
            this.Controls.Add(this.edtShowTimeAs);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FScheduleAppointment.IconOptions.Image")));
            this.Name = "FScheduleAppointment";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkAllDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtShowTimeAs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbbBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.ResourcesCheckedListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkIsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        protected DevExpress.XtraEditors.LabelControl _lblSubject;
        protected DevExpress.XtraEditors.LabelControl _lblLocation;
        protected DevExpress.XtraEditors.LabelControl _lblStartTime;
        protected DevExpress.XtraEditors.LabelControl _lblEndTime;
        protected DevExpress.XtraEditors.LabelControl _lblBookingType;
        protected DevExpress.XtraEditors.CheckEdit _chkAllDay;
        protected DevExpress.XtraEditors.SimpleButton _btnOk;
        protected DevExpress.XtraEditors.SimpleButton _btnCancel;
        protected DevExpress.XtraEditors.SimpleButton _btnDelete;
        protected DevExpress.XtraEditors.SimpleButton _btnRecurrence;
        protected DevExpress.XtraEditors.DateEdit edtStartDate;
        protected DevExpress.XtraEditors.DateEdit edtEndDate;
        protected DevExpress.XtraEditors.TimeEdit edtStartTime;
        protected DevExpress.XtraEditors.TimeEdit edtEndTime;
        protected DevExpress.XtraEditors.TextEdit tbSubject;
        protected DevExpress.XtraEditors.LabelControl _lblResource;
        protected DevExpress.XtraEditors.MemoEdit tbDescription;
        private System.ComponentModel.IContainer components = null;
        protected DevExpress.XtraScheduler.UI.AppointmentStatusEdit edtShowTimeAs;
        private SBoxBranch _cbbBranch;
        protected DevExpress.XtraScheduler.UI.AppointmentResourceEdit edtResource;
        protected DevExpress.XtraScheduler.UI.AppointmentResourcesEdit edtResources;
        protected DevExpress.XtraEditors.CheckEdit _chkIsActive;
        protected DevExpress.XtraEditors.LabelControl _lblLabel;
        protected DevExpress.XtraScheduler.UI.AppointmentLabelEdit edtLabel;
        protected DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
    }
}