using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegunSoft.Schedule.View.Dev.Base
{
    public partial class FScheduleAppointment
    {
        private void LoadDatasources()
        {
            _cbbApprover.IsUseValueAsDisplayName = false;
            //_cbbUserAccount.IsUseValueAsDisplayName = false;

            _cbbUserAccount.ReloadData();
            _cbbApprover.ReloadData();

            _cbbBranch.LoadFullDataSource(RepositorySession.BranchId);
        }
    }
}
