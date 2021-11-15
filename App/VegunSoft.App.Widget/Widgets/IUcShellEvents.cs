using System;
using Vegun.SocketBase.Model;

namespace VegunSoft.App.Widget.Widgets
{
    public interface IUcShellEvents
    {
        Action ItemsChanged { get; set; }

        IUcShellEvents Init(object shellForm);

        IUcShellEvents Add(MSocketCmd cmd);

        string DisplaySummary { get; }

    }
}
