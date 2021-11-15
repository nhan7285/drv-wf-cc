using System;

namespace VegunSoft.Base.View.Service.Services
{
    public interface IUiServiceMgmt
    {
        #region Init

        void Init(object uc, string rightsCode, string sessionCode);

        string RightsCode { get; set; }

        string SessionCode { get; set; }

        object Uc { get; set; }

        #endregion

        #region Check

        bool CanOpen(string rightsCode = null);

        bool CanExport(string rightsCode = null);

        bool CanPrint(string rightsCode = null);

        #endregion

        #region Click

        void ClickExport(Func<bool> func, string rightsCode = null);

        void ClickPrint(Func<bool> func, string rightsCode = null);

        #endregion

        #region Loading

        T GetLoadingControl<T>(T uc = null) where T: class;

        void ShowLoading<T>(T uc = null) where T : class;

        void CloseLoading<T>(T uc = null) where T : class;

        #endregion
    }
}
