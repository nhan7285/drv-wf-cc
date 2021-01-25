using VegunSoft.Schedule.View.Dev.Base;
using VegunSoft.Schedule.View.Model.Provider.Personnel;

namespace VegunSoft.Schedule.View.Dev.Personnel
{
    public class FSchedulePersonel: FSchedule
    {
        public FSchedulePersonel()
        {
            Init(new MViewSchedulePersonel());
        }
    }
}
