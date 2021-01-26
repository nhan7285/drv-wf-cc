using DevExpress.XtraScheduler.UI;
using System;
using System.Collections.Generic;
using VegunSoft.Framework.Gui.Enums.Schedule;
using VegunSoft.Schedule.View.Model.Models;

namespace VegunSoft.Schedule.View.Dev.Base
{
    public partial class FSchedule
    {
        protected IViewScheduleConfig Config { get; set; }

        private IDictionary<ESchedulerViewType, SchedulerControlCommandBarCheckItem> _switchItem;
        protected IDictionary<ESchedulerViewType, SchedulerControlCommandBarCheckItem> SwitchItem => _switchItem ?? (_switchItem = new Dictionary<ESchedulerViewType, SchedulerControlCommandBarCheckItem>()
        {
            {ESchedulerViewType.Day, switchToDayViewItem1 },
            {ESchedulerViewType.Week, switchToWeekViewItem1 },
            {ESchedulerViewType.Month, switchToMonthViewItem1 },
            {ESchedulerViewType.WorkWeek, switchToWorkWeekViewItem1 },
            {ESchedulerViewType.Timeline, switchToTimelineViewItem1 },
            {ESchedulerViewType.Gantt, switchToGanttViewItem1 },
            {ESchedulerViewType.FullWeek, switchToFullWeekViewItem1 },
            {ESchedulerViewType.Agenda, switchToAgendaViewItem1 },
            {ESchedulerViewType.Year, switchToYearViewItem1 },
        });

        public void Init(IViewScheduleConfig config)
        {
            Config = config;
        }

        private void ApplyConfig()
        {
            var cfg = Config;
            var key = cfg.ViewType;

            var dict = SwitchItem;
            var isValidType = dict.ContainsKey(key);
            if (isValidType) ApplyViewType(dict[key]);

            var isInitDate = cfg?.InitDate ?? false;
            var startDate = cfg?.StartDate ?? DateTime.Now;
            if (isInitDate) ApplyStartDate(startDate);

            ShowMailPanel = Config?.ShowMailPanel ?? false;
          
            Caption = Config?.Caption ?? "LỊCH";


            #region Menu

            ShowmMenuFile = Config?.ShowmMenuFile ?? false;
            ShowmHelpFile = Config?.ShowmHelpFile ?? false;

            #endregion
        }


    }
}
