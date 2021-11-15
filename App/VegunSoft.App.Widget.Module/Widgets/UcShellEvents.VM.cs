using System.Collections.Generic;
using Newtonsoft.Json;
using Vegun.SocketBase.Model;
using VegunSoft.Any.Data.Enums.Socket;
using VegunSoft.Any.Data.Provider.Models.Socket.Customer;
using VegunSoft.App.Model.Provider.Business;
using VegunSoft.Framework.Methods;

namespace VegunSoft.Layer.UcControl.Provider.App
{
    public partial class UcShellEvents
    {
        protected List<MShellEvent> _dS;
        protected List<MShellEvent> DS => _dS ?? (_dS = new List<MShellEvent>());

        private MShellEvent Convert(MSocketCmd cmd)
        {
            var rs = new MShellEvent()
            {
                Date = cmd?.ServerDateTime,
                //From = cmd?.DepartmentName,
                //Subject = cmd?.TargetBranchName,
                //PlainText = cmd?.CustomerFullName,
                //SubjectDisplayText = cmd?.CustomerCode,
                Read = 0,
                Priority = 0,
            };
            if (cmd.CmdKey == ESocketCmd.CustomerStage.GetCode())
            {
                var transferData = !string.IsNullOrWhiteSpace(cmd.Data) ? JsonConvert.DeserializeObject<MSyncMoving>(cmd.Data) : new MSyncMoving();
                rs.From = $"Phòng {cmd?.DepartmentName} - Tài khoản: {cmd?.Username}";
                rs.SubjectDisplayText = $"Chuyển khách {transferData?.CustomerCode} / {transferData?.CustomerFullName}";
                rs.PlainText = $"Đến phòng {transferData?.TargetDepartmentName}";
            }
            else if (cmd.CmdKey == ESocketCmd.SaveApmt.GetCode())
            {
                var apmtData = !string.IsNullOrWhiteSpace(cmd.Data) ? JsonConvert.DeserializeObject<MSyncApmt>(cmd.Data) : new MSyncApmt();
                rs.From = $"Tài khoản: {cmd?.Username}";
                rs.SubjectDisplayText = $"Lịch hẹn {cmd?.TargetCode} / {cmd?.TargetName}";
                rs.PlainText = $"Trạng thái {apmtData?.StatusName}";
            }
            else if (cmd.CmdKey == ESocketEvent.Login.GetCode())
            {
                rs.From = $"Tài khoản: {cmd?.Username} - {cmd?.UserFullName}";
                rs.SubjectDisplayText = $"Đã đăng nhập";
                rs.PlainText = $"Cơ sở {cmd?.BranchId}";
            }
            else if (cmd.CmdKey == ESocketEvent.Logout.GetCode())
            {
                rs.From = $"Tài khoản: {cmd?.Username} - {cmd?.UserFullName}";
                rs.SubjectDisplayText = $"Đã đăng xuất";
                rs.PlainText = $"Cơ sở {cmd?.BranchId}";
            }
            return rs;
        }

        public string DisplaySummary
        {
            get
            {
                return DS.Count.ToString();
            }
        }
    }
}
