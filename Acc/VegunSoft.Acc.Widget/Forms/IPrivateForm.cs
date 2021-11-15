namespace VegunSoft.Acc.Widget.Forms
{
    public interface IPrivateForm
    {
        void Logout(bool isSkipResult = false);

        string Text { get; }

        bool IsSafe { get; }
    }
}
