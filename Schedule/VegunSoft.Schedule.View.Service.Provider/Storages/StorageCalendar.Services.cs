using VegunSoft.Schedule.Entity.Provider.Categories;

namespace VegunSoft.Schedule.View.Service.Provider.Storages
{
    public partial class StorageCalendar
    {
        public object GetStatusKey(string entityId)
        {
            if (entityId == null) return null;
            return DictEntityIdStatus.ContainsKey(entityId) ? DictEntityIdStatus[entityId] : null;
        }

        public object GetLabelKey(string entityId)
        {
            if (entityId == null) return null;
            return DictEntityIdLabel.ContainsKey(entityId) ? DictEntityIdLabel[entityId] : null;
        }

        public MEntityScheduleAccountReason GetEntityStatus(object statusId)
        {
            if (statusId == null) return null;
            return DictStatusEntity.ContainsKey(statusId) ? DictStatusEntity[statusId] : null;
        }

        //MEntityScheduleAccountStatus
        public MEntityScheduleAccountStatus GetEntityLabel(object statusId)
        {
            if (statusId == null) return null;
            return DictLabelEntity.ContainsKey(statusId) ? DictLabelEntity[statusId] : null;
        }
    }
}
