using System;

namespace VegunSoft.Layer.UcService.Provider.Models
{
    public class McChangeItem<T> where T: class
    {

        public T OldModel { get; set; }

        public bool IsChanging { get; private set; }

        public Action<T, T> ApplyChangeAction { get; set; }

        public void Init(Action<T, T> changeAction)
        {
            ApplyChangeAction = changeAction;
        }

        public bool StartChange(T oldModel)
        {
            OldModel = oldModel;
            IsChanging = oldModel != null;
            return CheckIsChanging(oldModel);
        }

        public T EndChange()
        {
            var m = OldModel;
            OldModel = null;
            IsChanging = false;
            return m;
        }

        public bool CheckIsChanging(T oldModel)
        {
            var v = IsChanging && oldModel == OldModel;
            return v;
        }

        public T ApplyChange(T model)
        {
            if (IsChanging)
            {
                ApplyChangeAction?.Invoke(OldModel, model);
                return OldModel;
            }
            return null;
        }

    }
}
