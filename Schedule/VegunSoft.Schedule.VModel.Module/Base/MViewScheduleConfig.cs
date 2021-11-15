using System;
using VegunSoft.Framework.Gui.Enums.Schedule;
using VegunSoft.Schedule.View.Model.Models;

namespace VegunSoft.Schedule.View.Model.Provider.Base
{
    public class MViewScheduleConfig: IViewScheduleConfig
    {
        #region Basic

        public string Caption { get; set; }

        public bool InitDate { get; set; }

        public DateTime? StartDate { get; set; }

        public ESchedulerViewType ViewType { get; set; }
       
        #endregion



        #region Panels

        public bool ShowMailPanel { get; set; }

        #endregion

        #region Menu

        public bool ShowmMenuFile { get; set; } 

        public bool ShowmHelpFile { get; set; } 

        #endregion


    }
}
