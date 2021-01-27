using System;
using VegunSoft.Framework.Gui.Enums.Schedule;
using VegunSoft.Schedule.View.Model.Provider.Base;

namespace VegunSoft.Schedule.View.Model.Provider.Employee
{
    public class MViewSchedulePersonel : MViewScheduleConfig
    {
        public MViewSchedulePersonel()
        {
            Caption = "LỊCH LÀM VIỆC";
            InitDate = true;
            StartDate = DateTime.Now;
            ViewType = ESchedulerViewType.Year;

            ShowMailPanel = false;
            ShowmMenuFile = false;
            ShowmHelpFile = false;
        }
    }
}
