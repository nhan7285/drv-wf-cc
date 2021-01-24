using VegunSoft.Base.View.Service.Services;

namespace VegunSoft.Base.View.UserControls
{
    public interface IUcBaseMgmt
    {
        string RightsCode { get; }


        IUiServiceMgmt UiService { get; }
    }
}
