using VegunSoft.Base.Model.Business;
using VegunSoft.Framework.Db.Models.Entity;

namespace VegunSoft.Base.View.Service.Services
{
    public interface IMgmtViewService
    {

        string DataName { get; set; }

        bool IsUpdating { get;  }

        IMgmtViewService Init(IMMgmtViewService model);

        IMgmtViewService Prepare();

        IMgmtViewService Reload();

        IMgmtViewService OnClickAddButton(bool isReset = true);

        /// <summary>
        /// Called when [click cancel button].
        /// </summary>
        /// <param name="isReset">if set to <c>true</c> [is reset].</param>
        /// <returns></returns>
        IMgmtViewService OnClickCancelButton(bool isReset = true);

        IMgmtViewService OnClickSaveButton();

        IMgmtViewService OnClickSaveNewButton();

        IMgmtViewService OnClickEditCell();

        IMgmtViewService OnClickDeleteCell();

        IMgmtViewService OnFormClosing();

        /// <summary>
        /// Prepares the before save.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        T PrepareBeforeSave<T>(IEntityBase model) where T : class, IEntityBase;
    }
}
