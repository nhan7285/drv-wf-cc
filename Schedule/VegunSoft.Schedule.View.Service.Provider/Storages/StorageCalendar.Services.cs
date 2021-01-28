using VegunSoft.Schedule.Entity.Provider.Categories;

namespace VegunSoft.Schedule.View.Service.Provider.Storages
{
    public partial class StorageCalendar
    {
        public object GetStatusKey(string entityId)
        {
            return DictEntityIdStatus.ContainsKey(entityId) ? DictEntityIdStatus[entityId] : null;
        }

        public MEntityScheduleAccountStatus GetEntityStatus(object statusId)
        {
            return DictStatusEntity.ContainsKey(statusId) ? DictStatusEntity[statusId] : null;
        }
    }
}
