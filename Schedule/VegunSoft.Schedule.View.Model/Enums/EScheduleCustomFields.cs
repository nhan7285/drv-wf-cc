using System;
using System.Collections.Generic;
using System.Text;
using VegunSoft.Framework.Models;

namespace VegunSoft.Schedule.View.Model.Enums
{
    public enum EScheduleCustomFields
    {
        [MDisplay(Code = "Name")]
        Name,

        [MDisplay(Code = "ApproverId")]
        ApproverId,

        [MDisplay(Code = "ApproverName")]
        ApproverName,
    }
}
