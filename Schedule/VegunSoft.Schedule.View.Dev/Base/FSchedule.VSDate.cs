﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegunSoft.Schedule.View.Dev.Base
{
    public partial class FSchedule
    {
        private void ApplyStartDate(DateTime dateTime)
        {
            schedulerControl.Start = dateTime;
        }
    }
}
