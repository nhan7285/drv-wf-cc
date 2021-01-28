using System;
using System.Collections.Generic;
using System.Text;
using VegunSoft.Schedule.Entity.Provider.Categories;

namespace VegunSoft.Schedule.View.Service.Storages
{
    public interface IStorageCalendar
    {
        object GetStatusKey(string entityId);

        MEntityScheduleAccountStatus GetEntityStatus(object statusId);
       
    }
}
