using System.Linq;
using System.Windows.Forms;
using VegunSoft.App.Data.Provider.Category;
using VegunSoft.App.Service.Mgmt;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Models;
using VegunSoft.Framework.Gui.Provider.WindowsForms;
using VegunSoft.Framework.Gui.Services.Events;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Layer.UcService.Provider.Services;
using VegunSoft.Message.Service.App;
using VegunSoft.Session.Service.User;

namespace VegunSoft.Layer.UcService.Provider.App
{
    public class ItemClickService: IItemClickService
    {
        private IIocService _guiIoc;
        protected IIocService GuiIoc => _guiIoc ?? (_guiIoc = XIoc.GetService(CGui.IocKey));
        private IAppMessage _msg;
        protected IAppMessage Msg => _msg ?? (_msg = GuiIoc.GetInstance<IAppMessage>());
        private ICheckRightsService _checkRightsService;
        protected ICheckRightsService CheckRightsService => _checkRightsService ?? (_checkRightsService = GuiIoc.GetInstance<ICheckRightsService>());


        public ItemClickService()
        {
        }

        public IItemClickService OnClick(MShowForm[] targetFormKeys, object defaultActiveFormKey)
        {
            if (targetFormKeys == null) return this;
            Msg?.ClearMessages();

            var activeFormKey = string.IsNullOrWhiteSpace(defaultActiveFormKey?.ToString())
                ? targetFormKeys.FirstOrDefault()?.Key
                : defaultActiveFormKey;
            var igIgnore = DForm.ListIgnoreCheckRights.Contains(activeFormKey);
            Form activeForm = null;
            var shell = MasterViewService.Instance;
            foreach (var model in targetFormKeys)
            {
                var key = model.Key;
                var form = GuiIoc.GetInstance<Form>(key);
                var sessionCode = XForm.GetSessionCode(MasterViewService.Instance);
                if (!model.IsCheckRights || igIgnore ||
                    CheckRightsService.CheckCanShow(sessionCode, form.Name, true))
                {

                    var mgmt = XForm.GetInstance<IFormMgmt>(shell);
                    mgmt?.ShowForm<Form>(form, model.ShowMode, model.IsShowLoading);
                   
                    if (key.Equals(activeFormKey)) activeForm = form;
                }
                    


               
            }
            activeForm?.Activate();
            return this;
        }
    }
}
