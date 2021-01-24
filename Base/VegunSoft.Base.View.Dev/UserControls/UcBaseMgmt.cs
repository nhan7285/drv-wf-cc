using System.ComponentModel;
using VegunSoft.Base.View.Service.Services;
using VegunSoft.Base.View.UserControls;

namespace VegunSoft.Base.View.Dev.UserControls
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
