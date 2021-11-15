using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItem : System.Windows.Forms.UserControl
    {
        public UcOrderItem()
        {
            InitializeComponent();
        }

        public void Apply(MEntityOrderItem item)
        {
            _txtId.EditValue = item.Id;
            _txtToothName.EditValue = item.ProductServiceTargetName;
            _txtUnitName.EditValue = item.UnitName;
            _txtServiceName.EditValue = item.ProductServiceName;
            _calcAmount.EditValue = item.DisplayAmount;
            _calcPrice.EditValue = item.DisplayPrice;
            _calcDiccountPercent.EditValue = item.DisplayDiscountRate;
            _calcDiccountValue.EditValue = item.DisplayDiscountValue;
            _calcMoney.EditValue = item.MustPayDisplayMoney;
            _txtDoctorFullName.EditValue = item.WorkerFullName;
            _chkIsTemporary.Checked = item.IsTemporary;
            _chkIsChanged.EditValue = item.IsChanged;
            _chkIsFinished.EditValue = item.IsFinish;
        }
    }
}
