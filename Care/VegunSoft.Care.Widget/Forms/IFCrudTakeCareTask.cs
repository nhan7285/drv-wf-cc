using System;
using System.Collections.Generic;
using VegunSoft.Any.Widget.Forms;
using VegunSoft.Care.Data.Business;
using VegunSoft.Care.Entity.Provider.Business;

namespace VegunSoft.Care.Widget.Forms
{
    public interface IFCrudTakeCareTask : ITaskForm
    {
        bool IsSaved { get; }

        bool IsSelectingHistoryItems { get; set; }

        MEntityCustomerCare Model { get; }

        void OpenLogTab();

        void UpdateRelatedItemsForDeleteTask(string taskId, DateTime dateTime);

        void StartUpdate(MEntityCustomerCare task);

        void StartCreateNewLog(string taskId);

        void StartCreate(MEntityCustomerCareLog log, bool isApplyDefaultValues = true);

        void StartCreate(MEntityCustomerCare task, Dictionary<ECustomerTakeCareItem, List<string>> itemIds);

        void OpenMainTab();

        void ApplyStatus(string statusId);

        void ShowNote(string text);

        void CheckAndShow();
    }
}
