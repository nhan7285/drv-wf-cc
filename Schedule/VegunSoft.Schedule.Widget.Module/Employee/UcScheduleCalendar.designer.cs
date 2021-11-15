using VegunSoft.Schedule.Editor.Dev.Configurations;
using VegunSoft.Schedule.View.Service.Provider.Storages;

namespace VegunSoft.Schedule.View.Dev.Employee
{
    partial class UcScheduleCalendar {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcScheduleCalendar));
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.mailGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.inboxItem = new DevExpress.XtraNavBar.NavBarItem();
            this.outboxItem = new DevExpress.XtraNavBar.NavBarItem();
            this.draftsItem = new DevExpress.XtraNavBar.NavBarItem();
            this.trashItem = new DevExpress.XtraNavBar.NavBarItem();
            this.organizerGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.calendarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.tasksItem = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.navbarImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.schedulerSplitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._schedulerControl = new VegunSoft.Schedule.Editor.Dev.Configurations.ScAccountConfig();
            this._schedulerStorage = new VegunSoft.Schedule.View.Service.Provider.Storages.StorageCalendar(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this._btnClearUsers = new DevExpress.XtraEditors.SimpleButton();
            this._txtUsers = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateNavigator = new DevExpress.XtraScheduler.DateNavigator();
            this.buttonEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.someLabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.someLabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ribbonImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl.Panel1)).BeginInit();
            this.splitContainerControl.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl.Panel2)).BeginInit();
            this.splitContainerControl.Panel2.SuspendLayout();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollectionLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerSplitContainerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerSplitContainerControl.Panel1)).BeginInit();
            this.schedulerSplitContainerControl.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerSplitContainerControl.Panel2)).BeginInit();
            this.schedulerSplitContainerControl.Panel2.SuspendLayout();
            this.schedulerSplitContainerControl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._schedulerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._schedulerStorage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtUsers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Padding = new System.Windows.Forms.Padding(3);
            // 
            // splitContainerControl.Panel1
            // 
            this.splitContainerControl.Panel1.Controls.Add(this.navBarControl);
            this.splitContainerControl.Panel1.Text = "Panel1";
            // 
            // splitContainerControl.Panel2
            // 
            this.splitContainerControl.Panel2.Controls.Add(this.schedulerSplitContainerControl);
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2;
            this.splitContainerControl.Size = new System.Drawing.Size(1376, 875);
            this.splitContainerControl.SplitterPosition = 165;
            this.splitContainerControl.TabIndex = 0;
            this.splitContainerControl.Text = "splitContainerControl1";
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.mailGroup;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.mailGroup,
            this.organizerGroup});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.inboxItem,
            this.outboxItem,
            this.draftsItem,
            this.trashItem,
            this.calendarItem,
            this.tasksItem});
            this.navBarControl.LargeImages = this.navbarImageCollectionLarge;
            this.navBarControl.Location = new System.Drawing.Point(0, 0);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 0;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl.Size = new System.Drawing.Size(0, 0);
            this.navBarControl.SmallImages = this.navbarImageCollection;
            this.navBarControl.StoreDefaultPaintStyleName = true;
            this.navBarControl.TabIndex = 1;
            this.navBarControl.Text = "navBarControl1";
            // 
            // mailGroup
            // 
            this.mailGroup.Caption = "Mail";
            this.mailGroup.Expanded = true;
            this.mailGroup.ImageOptions.LargeImageIndex = 0;
            this.mailGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.inboxItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.outboxItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.draftsItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.trashItem)});
            this.mailGroup.Name = "mailGroup";
            // 
            // inboxItem
            // 
            this.inboxItem.Caption = "Inbox";
            this.inboxItem.ImageOptions.SmallImageIndex = 0;
            this.inboxItem.Name = "inboxItem";
            // 
            // outboxItem
            // 
            this.outboxItem.Caption = "Outbox";
            this.outboxItem.ImageOptions.SmallImageIndex = 1;
            this.outboxItem.Name = "outboxItem";
            // 
            // draftsItem
            // 
            this.draftsItem.Caption = "Drafts";
            this.draftsItem.ImageOptions.SmallImageIndex = 2;
            this.draftsItem.Name = "draftsItem";
            // 
            // trashItem
            // 
            this.trashItem.Caption = "Trash";
            this.trashItem.ImageOptions.SmallImageIndex = 3;
            this.trashItem.Name = "trashItem";
            // 
            // organizerGroup
            // 
            this.organizerGroup.Caption = "Organizer";
            this.organizerGroup.ImageOptions.LargeImageIndex = 1;
            this.organizerGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.calendarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.tasksItem)});
            this.organizerGroup.Name = "organizerGroup";
            // 
            // calendarItem
            // 
            this.calendarItem.Caption = "Calendar";
            this.calendarItem.ImageOptions.SmallImageIndex = 4;
            this.calendarItem.Name = "calendarItem";
            // 
            // tasksItem
            // 
            this.tasksItem.Caption = "Tasks";
            this.tasksItem.ImageOptions.SmallImageIndex = 5;
            this.tasksItem.Name = "tasksItem";
            // 
            // navbarImageCollectionLarge
            // 
            this.navbarImageCollectionLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.navbarImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("navbarImageCollectionLarge.ImageStream")));
            this.navbarImageCollectionLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageCollectionLarge.Images.SetKeyName(0, "Mail_32x32.png");
            this.navbarImageCollectionLarge.Images.SetKeyName(1, "Organizer_32x32.png");
            // 
            // navbarImageCollection
            // 
            this.navbarImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("navbarImageCollection.ImageStream")));
            this.navbarImageCollection.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageCollection.Images.SetKeyName(0, "Inbox_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(1, "Outbox_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(2, "Drafts_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(3, "Trash_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(4, "Calendar_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(5, "Tasks_16x16.png");
            // 
            // schedulerSplitContainerControl
            // 
            this.schedulerSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerSplitContainerControl.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.schedulerSplitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.schedulerSplitContainerControl.Name = "schedulerSplitContainerControl";
            // 
            // schedulerSplitContainerControl.Panel1
            // 
            this.schedulerSplitContainerControl.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.schedulerSplitContainerControl.Panel1.Text = "Panel1";
            // 
            // schedulerSplitContainerControl.Panel2
            // 
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.dateNavigator);
            this.schedulerSplitContainerControl.Panel2.Text = "Panel2";
            this.schedulerSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
            this.schedulerSplitContainerControl.Size = new System.Drawing.Size(1370, 869);
            this.schedulerSplitContainerControl.SplitterPosition = 225;
            this.schedulerSplitContainerControl.TabIndex = 2;
            this.schedulerSplitContainerControl.Text = "splitContainerControl1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._schedulerControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 869);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // _schedulerControl
            // 
            this._schedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Year;
            this._schedulerControl.DataStorage = this._schedulerStorage;
            this._schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._schedulerControl.Location = new System.Drawing.Point(0, 0);
            this._schedulerControl.Margin = new System.Windows.Forms.Padding(0);
            this._schedulerControl.Name = "_schedulerControl";
            this._schedulerControl.OptionsBehavior.ShowRemindersForm = false;
            this._schedulerControl.Size = new System.Drawing.Size(1370, 846);
            this._schedulerControl.Start = new System.DateTime(2020, 12, 28, 0, 0, 0, 0);
            this._schedulerControl.TabIndex = 0;
            this._schedulerControl.Text = "schedulerControl1";
            this._schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1);
            this._schedulerControl.Views.FullWeekView.Enabled = true;
            this._schedulerControl.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this._schedulerControl.Views.WeekView.Enabled = false;
            this._schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this._schedulerControl.Views.YearView.UseOptimizedScrolling = false;
            this._schedulerControl.AppointmentViewInfoCustomizing += new DevExpress.XtraScheduler.AppointmentViewInfoCustomizingEventHandler(this._schedulerControl_AppointmentViewInfoCustomizing);
            this._schedulerControl.AllowAppointmentDelete += new DevExpress.XtraScheduler.AppointmentOperationEventHandler(this.schedulerControl_AllowAppointmentDelete);
            this._schedulerControl.CustomizeAppointmentFlyout += new DevExpress.XtraScheduler.CustomizeAppointmentFlyoutEventHandler(this._schedulerControl_CustomizeAppointmentFlyout);
            this._schedulerControl.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(this.schedulerControl_EditAppointmentFormShowing);
            this._schedulerControl.DeleteRecurrentAppointmentFormShowing += new DevExpress.XtraScheduler.DeleteRecurrentAppointmentFormEventHandler(this.schedulerControl_DeleteRecurrentAppointmentFormShowing);
            // 
            // _schedulerStorage
            // 
            this._schedulerStorage.AppointmentChanging += new DevExpress.XtraScheduler.PersistentObjectCancelEventHandler(this.schedulerStorage_AppointmentChanging);
            this._schedulerStorage.AppointmentDeleting += new DevExpress.XtraScheduler.PersistentObjectCancelEventHandler(this.schedulerStorage_AppointmentDeleting);
            this._schedulerStorage.AppointmentCollectionAutoReloading += new DevExpress.XtraScheduler.CancelListChangedEventHandler(this.schedulerStorage_AppointmentCollectionAutoReloading);
            this._schedulerStorage.AppointmentCollectionLoaded += new System.EventHandler(this.schedulerStorage_AppointmentCollectionLoaded);
            this._schedulerStorage.AppointmentCollectionCleared += new System.EventHandler(this.schedulerStorage_AppointmentCollectionCleared);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._btnClearUsers);
            this.panel1.Controls.Add(this._txtUsers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 849);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 20);
            this.panel1.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this._btnClearUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this._btnClearUsers.Location = new System.Drawing.Point(0, 0);
            this._btnClearUsers.Name = "_btnClearUsers";
            this._btnClearUsers.Size = new System.Drawing.Size(20, 20);
            this._btnClearUsers.TabIndex = 1;
            this._btnClearUsers.Text = "x";
            this._btnClearUsers.Click += new System.EventHandler(this._btnClearUsers_Click);
            // 
            // _txtUsers
            // 
            this._txtUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtUsers.Location = new System.Drawing.Point(21, 0);
            this._txtUsers.Name = "_txtUsers";
            this._txtUsers.Properties.ReadOnly = true;
            this._txtUsers.Size = new System.Drawing.Size(1349, 20);
            this._txtUsers.TabIndex = 0;
            // 
            // dateNavigator
            // 
            this.dateNavigator.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNavigator.DateTime = new System.DateTime(2020, 12, 28, 0, 0, 0, 0);
            this.dateNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateNavigator.EditValue = new System.DateTime(2020, 12, 28, 0, 0, 0, 0);
            this.dateNavigator.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateNavigator.Location = new System.Drawing.Point(0, 0);
            this.dateNavigator.Name = "dateNavigator";
            this.dateNavigator.SchedulerControl = this._schedulerControl;
            this.dateNavigator.Size = new System.Drawing.Size(0, 0);
            this.dateNavigator.TabIndex = 1;
            // 
            // buttonEdit
            // 
            this.buttonEdit.EditValue = "Some Text";
            this.buttonEdit.Location = new System.Drawing.Point(4, 7);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit.Size = new System.Drawing.Size(125, 20);
            this.buttonEdit.TabIndex = 0;
            // 
            // someLabelControl2
            // 
            this.someLabelControl2.Location = new System.Drawing.Point(2, 46);
            this.someLabelControl2.Name = "someLabelControl2";
            this.someLabelControl2.Size = new System.Drawing.Size(49, 13);
            this.someLabelControl2.TabIndex = 0;
            this.someLabelControl2.Text = "Some Info";
            // 
            // someLabelControl1
            // 
            this.someLabelControl1.Location = new System.Drawing.Point(2, 2);
            this.someLabelControl1.Name = "someLabelControl1";
            this.someLabelControl1.Size = new System.Drawing.Size(49, 13);
            this.someLabelControl1.TabIndex = 0;
            this.someLabelControl1.Text = "Some Info";
            // 
            // ribbonImageCollection
            // 
            this.ribbonImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollection.ImageStream")));
            this.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_Exit_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Content_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Info_16x16.png");
            // 
            // ribbonImageCollectionLarge
            // 
            this.ribbonImageCollectionLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.ribbonImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollectionLarge.ImageStream")));
            this.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_Exit_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Content_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Info_32x32.png");
            // 
            // UcScheduleCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl);
            this.Name = "UcScheduleCalendar";
            this.Size = new System.Drawing.Size(1376, 875);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl.Panel1)).EndInit();
            this.splitContainerControl.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl.Panel2)).EndInit();
            this.splitContainerControl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollectionLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerSplitContainerControl.Panel1)).EndInit();
            this.schedulerSplitContainerControl.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerSplitContainerControl.Panel2)).EndInit();
            this.schedulerSplitContainerControl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerSplitContainerControl)).EndInit();
            this.schedulerSplitContainerControl.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._schedulerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._schedulerStorage)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._txtUsers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
       

    
      
        private DevExpress.XtraEditors.LabelControl someLabelControl2;
        private DevExpress.XtraEditors.LabelControl someLabelControl1;

        private DevExpress.XtraEditors.ButtonEdit buttonEdit;
       
        private DevExpress.Utils.ImageCollection ribbonImageCollection;
        private DevExpress.Utils.ImageCollection ribbonImageCollectionLarge;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup mailGroup;
        private DevExpress.XtraNavBar.NavBarGroup organizerGroup;
        private DevExpress.XtraNavBar.NavBarItem inboxItem;
        private DevExpress.XtraNavBar.NavBarItem outboxItem;
        private DevExpress.XtraNavBar.NavBarItem draftsItem;
        private DevExpress.XtraNavBar.NavBarItem trashItem;
        private DevExpress.XtraNavBar.NavBarItem calendarItem;
        private DevExpress.XtraNavBar.NavBarItem tasksItem;
        private DevExpress.Utils.ImageCollection navbarImageCollection;
        private DevExpress.Utils.ImageCollection navbarImageCollectionLarge;
        private DevExpress.XtraEditors.SplitContainerControl schedulerSplitContainerControl;
        private ScAccountConfig _schedulerControl;
        private DevExpress.XtraScheduler.DateNavigator dateNavigator;
       

      
        private StorageCalendar _schedulerStorage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.ComboBoxEdit _txtUsers;
        private DevExpress.XtraEditors.SimpleButton _btnClearUsers;
    }
}
