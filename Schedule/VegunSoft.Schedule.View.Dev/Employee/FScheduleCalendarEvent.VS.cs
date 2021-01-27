using VegunSoft.Framework.Method.Person;

namespace VegunSoft.Schedule.View.Dev.Employee
{
    public partial class FScheduleCalendarEvent
    {
        private void SyncFullNameToSubject()
        {
            @Subject = @FullName.GetNameFromFullName();
        }
    }
}
