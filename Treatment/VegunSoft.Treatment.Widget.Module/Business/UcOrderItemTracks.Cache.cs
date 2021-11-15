using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraGrid.Columns;
using VegunSoft.App.Data.Business;
using VegunSoft.Framework.Methods;
using VegunSoft.Layer.UcControl.Models;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Entity.Provider.Business.EntityOrderItem;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemTracks
    {


        protected MDoctorInputState State { get; set; }

        public DateTime BeginCustomerDateTime { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FormName { get; set; }

        protected string FormRoleName { get; private set; } = EFormMgmt.FWorkflowTreatment.GetFinalName();

        protected bool IsLoadingHistories { get; private set; }

        protected bool CanEdit => CheckRightsService.CheckCanEdit(SessionCode, FormRoleName) && !IsAnyReadOnly;

        protected bool CanAdd => CheckRightsService.CheckCanAdd(SessionCode, FormRoleName) && !IsAnyReadOnly;

        protected bool AllowAdd => CheckRightsService.CheckCanAdd(SessionCode, FormRoleName);

        protected bool CanDelete => CheckRightsService.CheckCanDelete(SessionCode, FormRoleName) && !IsAnyReadOnly;

        protected bool CanApprove => CheckRightsService.CheckCanApprove(SessionCode, FormRoleName) && !IsAnyReadOnly;

        protected bool CanShowRose => CheckRightsService.CheckCanApprove(SessionCode, FormRoleName);

        //TODO: FMainTreatmentServiceHistories => IsReadOnly

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsReadOnly { get; set; }

        public bool IsReadOnlyByTemporary => XOrderItem?.IsTemporary ?? false;

        public bool IsAnyReadOnly => IsReadOnly;

        public bool AllowSave => CanEdit || CanAdd || CanDelete;

        private GridColumn[] _allowEditIfNullTextColumns { get; set; }
        protected GridColumn[] AllowEditIfNullTextColumns => _allowEditIfNullTextColumns ?? (_allowEditIfNullTextColumns = new GridColumn[] {
            _gcOrderItemStepContent,
            _gcOrderItemStepDescription,
            _gcOrderItemStepNote,
            _gcOrderItemStepDoctorFullName,
            _gcOrderItemStepAssistantFullName,
        });

        private Dictionary<GridColumn, bool> _allowEditIfNullCheckColumns { get; set; }
        protected Dictionary<GridColumn,bool> AllowEditIfNullCheckColumns => _allowEditIfNullCheckColumns ?? (_allowEditIfNullCheckColumns = new Dictionary<GridColumn, bool>() {
            { _gcOrderItemStepIsNoTreatment, false },
            { _gcOrderItemStepIsFinishStep, false },
            //{ _gcOrderItemStepIsFinishTreatment, false },
            { _gcOrderItemStepIsNextContent, false },
            { _gcOrderItemStepIsAssistantMain, false },
            { _gcOrderItemStepIsDoctorMain, false },
            { _gcIsForOld, false },
        });

        /// <summary>
        /// OK
        /// </summary>
       
       

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        protected MEntityOrderItem WorkingOrderItem { get; set; }

       

        protected List<string> OrderIds { get; private set; }

        protected List<string> OrderItemIds { get; private set; }

        protected List<MEntityOrderItemBusiness> OrderItems { get; private set; }

        protected List<MEntityOrderItemBusiness> WorkingOrderItems
        {
            get
            {
                var items = OrderItems;
                if (items != null)
                {
                    items = items.Where(x => x.OrderId == XOrderId).ToList();
                }
                return items;
            }
        }
        protected List<MEntityOrderItemStep> WorkingOrderItemSteps
        {
            get
            {
                var items = OrderItemSteps;
                if (items != null)
                {
                    items = items.Where(x => x.OrderId == XOrderId).ToList();
                }
                return items;
            }
        }
    }
}
