using VegunSoft.App.Model.Provider.Business;

namespace VegunSoft.Layer.UcControl.Provider.App
{
    public partial class UcShellEvents
    {
        private void InitColumns()
        {
            _colDate.FieldName = nameof(MShellEvent.Date);
            _colFrom.FieldName = nameof(MShellEvent.From);
            _colSubject.FieldName = nameof(MShellEvent.Subject);
            _colPlainText.FieldName = nameof(MShellEvent.PlainText);
            _colSubjectDisplayText.FieldName = nameof(MShellEvent.SubjectDisplayText);
            _colRead.FieldName = nameof(MShellEvent.Read);
            _colPriority.FieldName = nameof(MShellEvent.Priority);
        }
    }
}
