namespace VegunSoft.Schedule.View.Dev.Employee
{
    public partial class FScheduleCalendarEvent
    {
        private string _startUsername;

        public string StartUsername
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_startUsername)) return RepositorySession.Username;
                return _startUsername;
            }
            set => _startUsername = value;
        }

        private string _startUserFullName;

        public string StartUserFullName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_startUserFullName)) return RepositorySession.UserFullName;
                return _startUserFullName;
            }
            set => _startUserFullName = value;
        }

        private string _startBranchId;

        public string StartBranchId
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_startBranchId)) return RepositorySession.Branch?.Id;
                return _startBranchId;
            }
            set => _startBranchId = value;
        }

        private string _startBranchName;

        public string StartBranchName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_startBranchName)) return RepositorySession.Branch?.Name;
                return _startBranchName;
            }
            set => _startBranchName = value;
        }
    }
}
