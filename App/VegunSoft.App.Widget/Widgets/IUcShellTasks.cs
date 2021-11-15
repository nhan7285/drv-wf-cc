using System;
using VegunSoft.App.Model.Provider.Business;

namespace VegunSoft.App.Widget.Widgets
{
    public interface IUcShellTasks
    {
        Action ItemsChanged { get; set; }

        IUcShellTasks Init(object shellForm);

        string DisplaySummary { get; }

        IUcShellTasks Add(MShellTask cmd);

    }
}
