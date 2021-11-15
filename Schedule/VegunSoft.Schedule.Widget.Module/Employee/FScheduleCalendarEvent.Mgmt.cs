using MEntity = VegunSoft.Schedule.Entity.Provider.Calendar.MEntityCalendarEvent;

namespace VegunSoft.Schedule.View.Dev.Employee
{
    public partial class FScheduleCalendarEvent
    {
        private MEntity Save(MEntity entity)
        {
            string id = string.Empty;
            if (entity.IsSaved)
            {
                RepositorySession.ApplyUpdatedValues(entity);
                RepositoryCalendarEvent.Update(entity);
                id = entity.Id;
            }
            else
            {
                RepositorySession.ApplyCreatedValues(entity);
                id = RepositoryCalendarEvent.InsertGetGuid(entity);
            }
            return RepositoryCalendarEvent.Find(id);
        }
    }
}
