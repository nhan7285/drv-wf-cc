namespace VegunSoft.Schedule.View.Dev.Base
{
    public partial class FSchedule
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
