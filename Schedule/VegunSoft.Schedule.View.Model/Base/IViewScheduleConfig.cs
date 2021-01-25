using System;
using System.Collections.Generic;
using System.Text;
using VegunSoft.Framework.Gui.Enums.Schedule;

namespace VegunSoft.Schedule.View.Model.Base
{
    public interface IViewScheduleConfig
    {
        bool InitDate { get; set; }

        bool ShowMailPanel { get; set; }      

        DateTime? StartDate { get; set; }

        ESchedulerViewType ViewType { get; set; }

        string Caption { get; set; }

        #region Menu

        bool ShowmMenuFile { get; set; } 

        bool ShowmHelpFile { get; set; } 

        #endregion
    }
}
