using VegunSoft.Framework.Gui.Provider.WindowsForms;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemLabos
    {
        protected bool IsShowPrice { get; set; } = true;

        private void CacheConfigs()
        {

        }

        private void ShowHidePrice()
        {
            IsShowPrice = !IsShowPrice;
            var isAllow = RepositorySession.IsAdmin;
            if (!isAllow)
            {
                IsShowPrice = false;
            }
            var isShow = IsShowPrice;
            _calcUnitPrice.Visible = isShow;
            _lblUnitPrice.Visible = isShow;
            //_lblPrices.Visible = isShow;
            _tblPrices.Visible = isShow;
            _gcLaboRootFee.Visible = isShow;
            _gcLaboFeeFinal.Visible = isShow;
            this.tableLayoutPanel2.SetRowSpan(this._txtNotes, isShow ? 4 : 5);
            _lblPrices.Text = isShow ? "Phí:" : (isAllow?XFromKey.ShowInfoForm.ToString(): string.Empty);
        }
    }
}
