using System;
using DevExpress.XtraGrid.Views.Base;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrder;

namespace VegunSoft.Layer.UcService.Provider.Models
{
    public class MUcTreatmentTurns
    {
        private bool isShowIsForOldColumn = false;

        public bool IsShowNameColumn { get; set; }
        public bool IsShowTreatmentColumn { get; set; }

        public bool IsShowDescriptionColumn { get; set; }

        public bool IsShowIsForOldColumn
        {
            get => isShowIsForOldColumn;
            set
            {
                isShowIsForOldColumn = value;
            }
        }
        public bool IsShowConsultingDateColumn { get; set; } = true;

        public Action<object, FocusedRowChangedEventArgs, MEntityOrder> FocusedRowChangedAction { get; set; }

        public Action<object, EventArgs, MEntityOrder> MainClickEditAction { get; set; }
        public Action<object, EventArgs, MEntityOrder> TreatAction { get; set; }

        public Action<MEntityOrder> SelectedOrderChanged { get; set; }

        public bool AllowConsult { get; set; }
    }
}
