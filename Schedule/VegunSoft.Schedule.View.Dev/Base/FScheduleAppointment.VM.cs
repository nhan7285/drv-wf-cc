﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegunSoft.Layer.Entity.Provider.User;
using VegunSoft.Layer.Entity.User;

namespace VegunSoft.Schedule.View.Dev.Base
{
    public partial class FScheduleAppointment
    {
        public MEntityUserAccountMin Approver => _cbbApprover.SelectedUserAccount;

        protected string @Subject
        {
            get => _txtSubject.EditValue?.ToString();
            set => _txtSubject.EditValue = value;
        }
        protected bool @IsSubjectEmpty => string.IsNullOrWhiteSpace(@Subject);

        protected IEntityUserAccountMin @UserAccount
        {
            get => _cbbUserAccount.SelectedUserAccount;
        }

        protected string @Username
        {
            get => _cbbUserAccount.EditValue?.ToString();
            set => _cbbUserAccount.EditValue = value;
        }

        protected string @FullName
        {
            get => _cbbUserAccount.SelectedUserAccount?.FullName;
        }

        protected string @ApproverId
        {
            get => _cbbApprover.EditValue?.ToString();
            set => _cbbApprover.EditValue = value;
        }

        protected string @ApproverName
        {
            get => _cbbApprover.Text;
            set => _cbbApprover.Text = value;
        }

        protected string @StatusId
        {
            get => _cbbStatus.EditValue?.ToString();
            set => _cbbStatus.EditValue = value;
        }

        protected string @StatusName
        {
            get => _cbbStatus.Text;
            set => _cbbStatus.Text = value;
        }

        protected string @BranchId
        {
            get => _cbbBranch.EditValue?.ToString();
            set => _cbbBranch.EditValue = value;
        }

        protected string @BranchName
        {
            get => _cbbBranch.SelectedBranch?.Name;
            set => _cbbBranch.Text = value;
        }

        protected string @ReasonId
        {
            get => _cbbReason.EditValue?.ToString();
            set => _cbbReason.EditValue = value;
        }

        protected string @ReasonName
        {
            get => _cbbReason.Text;
            set => _cbbReason.Text = value;
        }

        protected bool @IsActiveConfig
        {
            get => _chkIsActive.Checked;
            set => _chkIsActive.Checked = value;
        }

        protected string @ApproveStateId
        {
            get => _sBoxApproveState.EditValue?.ToString();
            set => _sBoxApproveState.EditValue = value;
        }

        protected string @ApproveStateName
        {
            get => _sBoxApproveState.Text;
            set => _sBoxApproveState.Text = value;
        }
    }
}
//_cbbBookingScope