using VegunSoft.App.Model.Provider.Business;

namespace VegunSoft.Layer.UcControl.Provider.App
{
    public partial class UcShellTasks
    {
        private void InitColumns()
        {
            _colDate.FieldName = nameof(MShellTask.Date);
            _colHeader.FieldName = nameof(MShellTask.Header);
            _colSubject.FieldName = nameof(MShellTask.Subject);
            _colPlainText.FieldName = nameof(MShellTask.PlainText);
            _colSubjectDisplayText.FieldName = nameof(MShellTask.SubjectDisplayText);
            _colRead.FieldName = nameof(MShellTask.Read);
            _colPriority.FieldName = nameof(MShellTask.Priority);
        }
    }
}
