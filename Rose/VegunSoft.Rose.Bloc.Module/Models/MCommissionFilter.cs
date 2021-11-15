using System;
using VegunSoft.Framework.Gui.Models.Export;

namespace VegunSoft.Layer.UcService.Models.Base
{
    public class MCommissionFilter
    {
        public string RightsCode { get; set; }

        public Func<bool> CheckCanSaveFunc { get; set; }

        public Func<bool> CheckCanCancelDeleteFunc { get; set; }

        public Action CancelDeleteAction { get; set; }

        public Action<bool> OnLoadDataAction { get; set; }

        public Action<bool> IsTempDeleteChangedAction { get; set; }

        public Action<object> OnSaveAllAction { get; set; }

        public Func<MResultExport> OnExportToExcelAction { get; set; }

        public Action<DateTime?> ApplyFromDateAction { get; set; }

        public Action<DateTime?> ApplyToDateAction { get; set; }

        public Action<bool> ApplyReduceAction { get; set; }

        public Action<DateTime?, DateTime?> ApplyCreateNewRangeAction { get; set; }
    }
}
