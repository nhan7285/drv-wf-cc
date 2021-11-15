using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VegunSoft.App.Data.Business;
using VegunSoft.Category.Entity.Provider.Category.Body;
using VegunSoft.Framework.Db.Enums.Data;
using VegunSoft.Layer.UcControl.Customer.Forms;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;
using VegunSoft.Order.Func.Provider.Methods.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItems
    {
        private void ApplyToothValues(MEntityOrderItem item, MEntityTooth tooth)
        {
            if (tooth.ID.Contains(","))
            {
                item.ProductServiceTargetIds = tooth.ID;
            }
            else
            {
                item.ProductServiceTargetId = tooth.ID;
            }
          
            item.ProductServiceTargetName = tooth.TEN;
        }

        private MEntityTooth GetToothFromTeeth(List<MEntityTooth> teeth)
        {
            teeth = teeth.Where(x => !string.IsNullOrWhiteSpace(x.ID) && !string.IsNullOrWhiteSpace(x.Name)).ToList();
            return new MEntityTooth()
            {
                ID = string.Join(",", teeth.Select(x => x.Id).ToList()),
                Name = string.Join(",", teeth.Select(x => x.Name).ToList()),
                IsActive = true
            };
        }

        private void ShowTeethForm(List<MEntityTooth> teeth, Action<List<MEntityTooth>> act)
        {
            var oTeeth = GuiIoc.GetInstance<Form>(EFormMgmt.FShowTeeth.ToString());
            var iTeeth = oTeeth as IFShowTeeth;
            if (iTeeth != null)
            {
                iTeeth.SelectedTeeth = teeth;
                oTeeth.ShowDialog();
                act?.Invoke(iTeeth.SelectedTeeth);
            }
        }

        private void OnSelectTeeth()
        {
            ShowTeethForm(SelectedTeeth, (rs) => {
                SelectTeeth(rs);
            });
        }

      

        private void OnReselectTeeth(MEntityOrderItem item)
        {
            ShowTeethForm(item.GetTeeth(ListTeeth), (rs) => {
                var tooth = GetToothFromTeeth(rs);
                ApplyToothValues(item, tooth);
                if (item.Action != EMgmtCase.Insert && item.Action != EMgmtCase.Delete)
                {
                    item.Action = EMgmtCase.Update;
                }

                _viewOrderItems.RefreshData();
            });
        }

        private void SelectTeeth(List<MEntityTooth> teeth)
        {
            lblListRangChon.Text = string.Empty;
            txtIdRang.EditValue = 0;
            _glkTooth.EditValue = 0;
            SelectedTeeth = teeth;
            foreach (var ob in SelectedTeeth)
            {
                lblListRangChon.Text += ob.TEN + "; ";
            }
        }
    }
}
