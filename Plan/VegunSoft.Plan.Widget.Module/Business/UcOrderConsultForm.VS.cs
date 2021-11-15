using VegunSoft.Category.Entity.Provider.Category.Body;
using Scope = VegunSoft.Acc.Data.Enums.EUserAccountScope;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Consult
{
    public partial class UcOrderConsultForm
    {
        public void ApplyReadOnly()
        {
            var isReadOnlyUserFields = IsReadOnlyUserFields;

            _btnSelectTeeth.Enabled = !isReadOnlyUserFields;

            IsReadOnlyName = isReadOnlyUserFields;
            _glkTooth.Properties.ReadOnly = isReadOnlyUserFields;
            _glkProductServiceType.Properties.ReadOnly = isReadOnlyUserFields;
            _glkProductServiceGroup.Properties.ReadOnly = isReadOnlyUserFields;
            _glkProductServiceGroupFinal.Properties.ReadOnly = isReadOnlyUserFields;
            _chkIsAutoInsertToContent.Properties.ReadOnly = isReadOnlyUserFields;

            var isReadOnlyCreatedFields = IsReadOnlyCreatedFields;
            IsReadOnlyIsForOld = isReadOnlyCreatedFields;
            IsReadOnlyConsultDate = isReadOnlyCreatedFields;
            IsReadOnlyConsultDoctor = isReadOnlyCreatedFields;
            IsReadOnlyConsultAssistant = isReadOnlyCreatedFields;

            var isReadOnlySystemFields = IsReadOnlySystemFields;
            _cbbCreatedUsername.Properties.ReadOnly = isReadOnlySystemFields;
            _txtUpdatedDate.Properties.ReadOnly = isReadOnlySystemFields;
            _cbbUpdatedUsername.Properties.ReadOnly = isReadOnlySystemFields;
            IsReadOnlyCreatedDate = isReadOnlySystemFields;
           
        }

        private void ConfigControls()
        {
            _gcToothName.FieldName = nameof(MEntityTooth.TEN);
            _glkTooth.Properties.ValueMember = nameof(MEntityTooth.ID);
            _glkTooth.Properties.DisplayMember = nameof(MEntityTooth.TEN);


            //var searchColumnFields = new string[]
            //{
            //    nameof(Entity.Id),
            //    nameof(Entity.Name),
            //    nameof(Entity.DisplayPrice),
            //    nameof(Entity.GroupDisplayName),
            //    nameof(Entity.UnsignKeywords),
            //    nameof(Entity.CompactKeywords)
            //};

            _cbbConsultingDoctor.Scope = CanApprove? Scope.ActiveUsingAll : Scope.ActiveUsing;
            _cbbConsultingAssistant.Scope = CanApprove ? Scope.ActiveUsingAll : Scope.ActiveUsing;
            _cbbCreatedUsername.Scope = CanApprove ? Scope.ActiveUsingAll : Scope.ActiveUsing;
            _cbbUpdatedUsername.Scope = CanApprove ? Scope.ActiveUsingAll : Scope.ActiveUsing;

            IsVisibleIsForOld = CanChangeTime;

        }
    }
}
