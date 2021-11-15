using System.Collections.Generic;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Product.Entity.Provider.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Order
{
    public partial class UcOrderItemSteps
    {

        protected bool CanShowRose => CheckRightsService.CheckCanApprove(SessionCode, RightsCode);

        public List<MEntityPdsvStep> DataSource => _grid.DataSource as List<MEntityPdsvStep>;

        private MEntityOrderItemStep GetNewOrderItemStep(MEntityPdsvStep config, bool isFinish)
        {
            var step = new MEntityOrderItemStep
            {

                #region Common Properties

                DisplayPriority = config.SequenceNumber,
                RawStepName = config.RawStepName,
                IsFinishProcess = config.IsFinishProcess,
                IsOutOfConfigReExamination = false,

                #endregion
                //Special Vaues

                #region Special Properties

                IsFinishStage = isFinish,
                RawStepId = config.RawStepId,
                FeeRate = config.FeeRate,
                PdsvStepId = config.Id,
                PdsvStepParentId = config.ParentId,
                IsDoctorMain = true,

                HasRose = isFinish? config.HasRose: false

                #endregion
            };
            return step;
        }

        internal void UpdateRowAutoHeight(bool isMulti)
        {
            _view.OptionsView.RowAutoHeight = isMulti;
        }
    }
}
