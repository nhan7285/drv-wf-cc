using System.Collections.Generic;
using System.Windows.Forms;
using VegunSoft.Any.View.Dev.Forms;
using VegunSoft.Category.Entity.Provider.Category.Body;
using VegunSoft.Framework.Gui.Enums;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemTracks
    {
        private List<MEntityTooth> _listTeeth;
        public List<MEntityTooth> ListTeeth
        {
            get
            {
                if (_listTeeth == null)
                {
                    _listTeeth = RepositoryTooth.GetActiveTeeth();
                }
                return _listTeeth;
            }
        }

        private void StartBookLabo(EFormDisplayType type = EFormDisplayType.Dialog)
        {
            var step = SelectedOrderItemStep;
            var f = new FAny();
            var uc = new UcOrderItemLabos()
            {
                Text = "Đặt Labo"
            };
            var assistant = SelectedAssistant?.Username;
            if (string.IsNullOrWhiteSpace(assistant))
            {
                assistant = step?.AssistantUsername;
            }
            var isSuccess = uc.CheckAndInit(FormRoleName, step, IsAnyReadOnly, assistant);
            if (isSuccess)
            {
                f.Init(uc, true);
                FormMgmt.ShowForm<Form>(f, type, false);
            }
                
       
        }
    }
}
