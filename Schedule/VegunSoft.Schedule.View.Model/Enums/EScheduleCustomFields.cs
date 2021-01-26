﻿using System;
using System.Collections.Generic;
using System.Text;
using VegunSoft.Framework.Models;

namespace VegunSoft.Schedule.View.Model.Enums
{
    public enum EScheduleCustomFields
    {
        [MDisplay(Code = "Name")]
        Name,

        [MDisplay(Code = "Code")]
        Code,

        [MDisplay(Code = "StatusId")]
        StatusId,

        [MDisplay(Code = "StatusName")]
        StatusName,

        [MDisplay(Code = "ReasonId")]
        ReasonId,

        [MDisplay(Code = "ReasonName")]
        ReasonName,

        [MDisplay(Code = "BranchId")]
        BranchId,

        [MDisplay(Code = "BranchName")]
        BranchName,

        [MDisplay(Code = "ApproverId")]
        ApproverId,

        [MDisplay(Code = "ApproverName")]
        ApproverName,

        [MDisplay(Code = "IsActive")]
        IsActive,

        [MDisplay(Code = "ApproveStateId")]
        ApproveStateId,

        [MDisplay(Code = "ApproveStateName")]
        ApproveStateName,
    }
}
