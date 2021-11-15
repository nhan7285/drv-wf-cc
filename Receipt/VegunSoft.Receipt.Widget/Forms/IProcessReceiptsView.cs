namespace VegunSoft.Layer.Gui.Custome.Receipt
{
    public interface IProcessReceiptsView
    {
        decimal CalcOrderTotalPrice { get; set; }
        decimal CalcOrderDiscountedMoney { get; set; }
        decimal CalcReceiptDiscountedMoney { get; set; }
        bool EditorReceiptDiscountType { get; set; }
        decimal CalcOrderTotalPaid { get; set; }
        decimal CalcReceiptDiscountPercent { get; set; }
        decimal CalcOrderDebitBeforeReceipt { get; set; }
        decimal CalcReceiptMustPay { get; set; }
        decimal CalcReceiptPayingMoney { get; set; }
        decimal CalcReceiptBankPayMoney { get; set; }
        decimal CalcReceiptCardPayMoney { get; set; }
        decimal CalcReceiptCashPayMoney { get; set; }
        decimal CalcReceiptHomePayMoney { get; set; }
        decimal CalcCustomerDebitBeforeReceipt { get; set; }
        decimal CalcCustomerEndDebit { get; set; }
        decimal CalcOrderEndDebit { get; set; }
        string CbbSelectUserAccountCashier { get; set; }
        string CbbHomeCollectorId { get; set; }
        string CbbCashCollectorId { get; set; }

        //void UpdateUIProcessReceipts(IProcessReceiptsViewModel processReceipts);
        //void UpdateUIProcessReceipts(MEntityReceipt processReceipts);
    }
}
