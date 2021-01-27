namespace VegunSoft.Schedule.View.Dev.Employee
{
    public partial class FScheduleCalendarEvent
    {
        private void LoadDatasources()
        {

            _cbbUserAccount.ReloadData();            
            _cbbApprover.ReloadData();
            _sBoxApproveState.ReloadData();

            _cbbBranch.LoadFullDataSource(RepositorySession.BranchId);
        }
    }
}
