using DevExpress.XtraScheduler;
using System.Collections.Generic;
using System.Linq;
using VegunSoft.Framework.Enums;
using VegunSoft.Schedule.Data.Enums.Categories;
using VegunSoft.Schedule.Entity.Provider.Calendar;
using VegunSoft.Schedule.MQuery.Provider.Cards;
using VegunSoft.Schedule.View.Service.Provider.Methods;
using VegunSoft.Schedule.View.Service.Provider.Storages;
using IEntity = VegunSoft.Schedule.Entity.Calendar.IEntityCalendarEvent;
namespace VegunSoft.Schedule.View.Dev.Employee
{
    public partial class UcScheduleCalendar
    {
      

        private void LoadData()
        {
            Appointments.Clear();
            var q = new MQueryCalendarEvent()
            {
                DateTimeType = EDateTimeRange.Year,
                FromDate = StateStart,
                ToDate = StateEnd,

               
                DateTimeFields = new List<ECalendarEventDateTime>() { ECalendarEventDateTime.BeginDateTime },

                BranchId = StateBranchId,
                Username = State_Username,
                UserFields = new List<ECalendarEventUserContext>() { ECalendarEventUserContext.Appointee },

                IsCheckDeleted = StateIsUseIsDeleted,
                IsDeletedValue = StateDeletedValue,

                //StatusIds = StatusIds
            };
            var ds = RepositoryCalendarEvent.GetRows<MEntityCalendarEvent>(q).ToList();
            var users = ds?.Select(x => x.Code).Distinct().Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            IsSingleUser = (users?.Count ?? 0) == 1;
            var appointments = Appointments;
            foreach (var entity in ds)
            {
                var a = Storage.CreateAppointment(AppointmentType.Normal);
                if (entity != null) a?.UpdateFromEntity(entity, Storage);
                //a.ResourceId = entity?.Code;
                //a.ResourceIds.AddRange(users);
                a.Subject = IsSingleUser? entity?.StatusName: $"{entity?.Caption} - {entity?.StatusName}";
                appointments.Add(a);
            }
        }
    }
}
