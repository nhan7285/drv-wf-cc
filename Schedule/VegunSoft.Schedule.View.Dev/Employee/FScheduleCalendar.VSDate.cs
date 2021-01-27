using System;

namespace VegunSoft.Schedule.View.Dev.Employee
{
    public partial class FScheduleCalendar
    {
        private void ApplyStartDate(DateTime dateTime)
        {
            schedulerControl.Start = dateTime;
        }
    }
}
