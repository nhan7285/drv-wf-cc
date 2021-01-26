using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegunSoft.Framework.Method.Person;

namespace VegunSoft.Schedule.View.Dev.Base
{
    public partial class FScheduleAppointment
    {
        private void SyncFullNameToSubject()
        {
            @Subject = @FullName.GetNameFromFullName();
        }
    }
}
