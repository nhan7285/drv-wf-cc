using VegunSoft.Receipt.Entity.Business;

namespace VegunSoft.Layer.Gui.Customer.Receipt
{
    public interface IFReceiptsReport
    {
        IFReceiptsReport Focus(IEntityReceiptItemMin orderItem);
        IFReceiptsReport LockChangeCustomer(bool isLock);
    }
}
