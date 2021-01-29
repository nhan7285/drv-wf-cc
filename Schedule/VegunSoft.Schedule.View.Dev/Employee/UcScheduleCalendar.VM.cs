using System;
using System.Collections.Generic;
using System.Linq;
using VegunSoft.Layer.Entity.User;

namespace VegunSoft.Schedule.View.Dev.Employee
{
    public partial class UcScheduleCalendar
    {
        //public bool ShowMailPanel
        //{
        //    get => splitContainerControl.PanelVisibility == DevExpress.XtraEditors.SplitPanelVisibility.Both;
        //    set => splitContainerControl.PanelVisibility = value ? DevExpress.XtraEditors.SplitPanelVisibility.Both : DevExpress.XtraEditors.SplitPanelVisibility.Panel2;
        //}

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

        protected IEnumerable<string> StateUsernames => StateUsers.Select(x => x.Username);

        protected List<IEntityUserAccountMin> StateUsers { get; } = new List<IEntityUserAccountMin>();

        protected bool IsSingleUser { get; set; }

        protected bool StateIsUseIsDeleted => false;

        protected bool StateDeletedValue => false;

        protected string UsernamesText
        {
            get
            {
                var list = StateUsernames;
                return list.Count() > 0 ? string.Join(" / ", list) : string.Empty;
            }
        }
    }
}
