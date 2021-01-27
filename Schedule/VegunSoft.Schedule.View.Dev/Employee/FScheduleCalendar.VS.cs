namespace VegunSoft.Schedule.View.Dev.Employee
{
    public partial class FScheduleCalendar
    {
        protected bool IsLoaded { get; set; }

        private void LoadOne()
        {
            if (IsLoaded) return;
            ApplyConfig();
            IsLoaded = true;
        }
    }
}
