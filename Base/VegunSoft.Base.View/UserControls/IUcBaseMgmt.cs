using VegunSoft.Layer.UcService.Base.Mgmt;

namespace VegunSoft.Layer.UcControl.Base.Mgmt
{
    public interface IUcBaseMgmt
    {
        string RightsCode { get; }


        IUiServiceMgmt UiService { get; }
    }
}
