using DevExpress.XtraGrid.Views.Grid;
using System;
using VegunSoft.Order.Entity.Provider.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    partial class UcOrderItemTracks
    {
        //protected MEntityOrderItemStep EditingStep { get; set; }
        //protected bool LockApplyGridViewCellEditor { get; set; }
        private bool IsMultiLine(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return false;
            return text.Split(Environment.NewLine.ToCharArray()).Length > 1;
        }

        private void ApplyGridViewCellEditor(GridView view, MEntityOrderItemStep row, CustomRowCellEditEventArgs e)
        {
            //if (LockApplyGridViewCellEditor) return;
            var bCoToa = row.HasPrescription;
            var bCoCLS = row.HasSubclinical;
            //var isSaved = row.IsSaved;
            if (e.Column == _gcOrderItemStepHasPrescription)
            {
                if (bCoToa)
                {
                    e.RepositoryItem = r_lnkInToaThuoc;
                }
            }
            if (e.Column == _gcOrderItemStepHasSubclinicals)
            {
                if (bCoCLS)
                    e.RepositoryItem = r_lnkXemCLS;
            }
            if (e.Column == _gcOrderItemStepBookLabo)
            {
                if (row != null && row.IsSaved)
                {
                    e.RepositoryItem = _lnkBookLabo;
                }
                else
                {

                }

            }
          
            if (row != null)
            {
                //var isEditing = EditingStep == row;
                var isExMode = false;
                if (e.Column == _gcOrderItemStepNote)
                {
                    if (IsMultiLine(row.Description))
                    {
                        e.RepositoryItem = _riNote;
                    }
                    else
                    {
                        e.RepositoryItem = _riNoteEx;
                        isExMode = true;
                    }
                }
                if (e.Column == _gcOrderItemStepContent)
                {
                    if (IsMultiLine(row.StepDisplayText))
                    {
                        e.RepositoryItem = _riTreatmentContent;
                    }
                    else
                    {
                        e.RepositoryItem = _riTreatmentContentEx;
                        isExMode = true;
                    }
                }
                if (e.Column == _gcOrderItemStepDescription)
                {
                    if (IsMultiLine(row.Note))
                    {
                        e.RepositoryItem = _riExplanation;
                    }
                    else
                    {
                        e.RepositoryItem = _riExplanationEx;
                        isExMode = true;
                    }
                }

                if ( isExMode && view.FocusedColumn == e.Column)
                {
                    //LockApplyGridViewCellEditor = true;
                    //view.RefreshRowCell(view.FocusedRowHandle, view.FocusedColumn);
                   
                   
                }
            }

        }
    }
}
