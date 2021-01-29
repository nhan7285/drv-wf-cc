namespace VegunSoft.Schedule.View.Dev.Employee
{
    public partial class UcScheduleCalendar
    {
        protected bool IsLoaded { get; set; }

        private void LoadOne()
        {
            if (IsLoaded) return;

            this._schedulerControl.VisibleIntervalChanged += new System.EventHandler(this.schedulerControl_VisibleIntervalChanged);

            ApplyConfig();
            IsLoaded = true;
        }

        private void UpdateUIState()
        {
            _txtUsers.Text = UsernamesText;
            _btnClearUsers.Enabled = StateUsers?.Count > 0;
        }
    }
}
