using System;

namespace VegunSoft.Schedule.View.Dev.Employee
{
    public partial class FScheduleCalendar
    {
        public bool ShowMailPanel
        {
            get => splitContainerControl.PanelVisibility == DevExpress.XtraEditors.SplitPanelVisibility.Both;
            set => splitContainerControl.PanelVisibility = value ? DevExpress.XtraEditors.SplitPanelVisibility.Both : DevExpress.XtraEditors.SplitPanelVisibility.Panel2;
        }

        public string Caption
        {
            get => this.Text;
            set => this.Text = value;
        }

        #region Menu

        public bool ShowmMenuFile
        {
            get => this.fileRibbonPage1.Visible;
            set => this.fileRibbonPage1.Visible = value;
        }

        public bool ShowmHelpFile
        {
            get => this.helpRibbonPage.Visible;
            set => this.helpRibbonPage.Visible = value;
        }

        #endregion


        protected DateTime StateStart => _schedulerControl.Start;

        protected DateTime StateEnd => _schedulerControl.Start.Date.AddYears(1);

        protected string StateBranchId => string.Empty;

        protected string State_Username => string.Empty;

        protected bool IsSingleUser { get; set; }

        protected bool StateIsUseIsDeleted => false;

        protected bool StateDeletedValue => false;
    }
}
