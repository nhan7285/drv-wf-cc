using System.ComponentModel;
using VegunSoft.Layer.UcControl.Base.Mgmt;
using VegunSoft.Layer.UcService.Base.Mgmt;

namespace VegunSoft.Layer.UcControl.Any.Provider.UserControls
{
    public class UcBaseMgmt: UcBase, IUcBaseMgmt
    {
        private IUiServiceMgmt _uiService;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IUiServiceMgmt UiService => _uiService ?? (_uiService = ViewService);

        protected IUiServiceMgmt ViewService
        {
            get
            {
                var service = GuiIoc.GetInstance<IUiServiceMgmt>();
                service.Uc = this;
                service.RightsCode = RightsCode;
                service.SessionCode = SessionCode;
                return service;
            }
        }

    }
}
