using DevExpress.XtraScheduler;
using System.Collections.Generic;
using VegunSoft.Schedule.View.Model.Enums;

namespace VegunSoft.Schedule.View.Model.Dicts
{
    public class DScheduleStructure
    {
        private static IDictionary<EScheduleCustomFields, FieldValueType> _appointmentCustomFields;
        public static IDictionary<EScheduleCustomFields, FieldValueType> AppointmentCustomFields => _appointmentCustomFields ?? (_appointmentCustomFields = new Dictionary<EScheduleCustomFields, FieldValueType>()
        {
            {EScheduleCustomFields.ApproverId,  FieldValueType.String},
            {EScheduleCustomFields.ApproverName,  FieldValueType.String},
        });
    }
}
