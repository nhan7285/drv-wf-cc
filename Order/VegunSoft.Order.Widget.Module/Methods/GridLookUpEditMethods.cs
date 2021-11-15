using DevExpress.XtraEditors;
using VegunSoft.Product.Entity.Provider.Business;

namespace VegunSoft.Layer.UcService.Provider.Methods
{
    public static class GridLookUpEditMethods
    {
        

        public static void ShowMinMaxPrice(this GridLookUpEdit editor, LabelControl lblDynamicPrice,
            CalcEdit txtDynamicPrice, LabelControl lblMinPrice, CalcEdit txtMinPrice, LabelControl lblMaxPrice,
            CalcEdit txtMaxPrice, bool isReset = false)
        {
            MEntityPdsv model = null;
            if (!isReset && editor.GetSelectedDataRow() is MEntityPdsv m && !string.IsNullOrWhiteSpace(m.Id))
            {
                if (m.IsApplyMinMaxPrice) model = m;
                lblDynamicPrice.Visible = true;
                txtDynamicPrice.Visible = true;
                txtDynamicPrice.EditValue = m.Price;
            }
            else
            {
                lblDynamicPrice.Visible = false;
                txtDynamicPrice.Visible = false;
                txtDynamicPrice.EditValue = 0;
            }
           
            var isVisible = model != null;
            if (lblMinPrice != null)
            {
                lblMinPrice.Visible = isVisible;
            }
            if (lblMaxPrice != null)
            {
                lblMaxPrice.Visible = isVisible;
            }
           
            txtMinPrice.Visible = isVisible;
            txtMaxPrice.Visible = isVisible;
           
            if (isVisible)
            {
                txtMinPrice.EditValue = model.MinPrice;
                txtMaxPrice.EditValue = model.MaxPrice;

                var minPrice = model.MinPrice;
                var maxPrice = model.MaxPrice;
                if (minPrice > maxPrice && maxPrice == 0)
                {
                    if (lblMaxPrice != null)
                    {
                        lblMaxPrice.Visible = false;
                    }
                       
                    txtMaxPrice.Visible = false;
                }
            }
            else
            {
               
                txtMinPrice.EditValue = 0;
                txtMaxPrice.EditValue = 0;
            }
        }
    }
}
