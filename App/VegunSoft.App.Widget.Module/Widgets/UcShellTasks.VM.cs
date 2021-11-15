using System.Collections.Generic;
using VegunSoft.App.Model.Provider.Business;

namespace VegunSoft.Layer.UcControl.Provider.App
{
    public partial class UcShellTasks
    {
        protected List<MShellTask> _dS;
        protected List<MShellTask> DS => _dS ?? (_dS = new List<MShellTask>());

        public string DisplaySummary
        {
            get
            {
                return DS.Count.ToString();
            }
        }
    }
}
