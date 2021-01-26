using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegunSoft.Layer.Entity.Provider.User;

namespace VegunSoft.Schedule.View.Dev.Base
{
    public partial class FScheduleAppointment
    {
        public MEntityUserAccountMin ValApprover => _cbbApprover.SelectedUserAccount;
    }
}
