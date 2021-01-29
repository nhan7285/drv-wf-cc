﻿using System;
using System.Collections.Generic;

namespace VegunSoft.Schedule.View.Dev.Employee
{
    public partial class UcScheduleCalendar
    {
        public bool ShowMailPanel
        {
            get => splitContainerControl.PanelVisibility == DevExpress.XtraEditors.SplitPanelVisibility.Both;
            set => splitContainerControl.PanelVisibility = value ? DevExpress.XtraEditors.SplitPanelVisibility.Both : DevExpress.XtraEditors.SplitPanelVisibility.Panel2;
        }

        public string Caption
        {
            get => this.Text;
            set => this.Text = value;
        }

        #region Menu

       

        #endregion


        protected DateTime StateStart => _schedulerControl.Start;

        protected DateTime StateEnd => _schedulerControl.Start.Date.AddYears(1);

        protected string StateBranchId => string.Empty;

        protected List<string> StateUsernames { get; } = new List<string>();

        protected bool IsSingleUser { get; set; }

        protected bool StateIsUseIsDeleted => false;

        protected bool StateDeletedValue => false;

        protected string UsernamesText => StateUsernames.Count > 0 ? string.Join(",", StateUsernames): string.Empty;
    }
}
