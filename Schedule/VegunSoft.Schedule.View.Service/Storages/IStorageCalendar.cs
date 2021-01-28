using System;
using System.Collections.Generic;
using System.Text;
using VegunSoft.Schedule.Entity.Provider.Categories;

namespace VegunSoft.Schedule.View.Service.Storages
{
    public interface IStorageCalendar
    {
        object GetStatusKey(string entityId);

        object GetLabelKey(string entityId);

        MEntityScheduleAccountReason GetEntityStatus(object statusId);

        MEntityScheduleAccountStatus GetEntityLabel(object statusId);
       
    }
}
