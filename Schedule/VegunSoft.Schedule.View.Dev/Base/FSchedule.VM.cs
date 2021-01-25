namespace VegunSoft.Schedule.View.Dev.Base
{
    public partial class FSchedule
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
    }
}
