using System;
using VegunSoft.Acc.View.Dev.UserControls;
using VegunSoft.App.Config.Provider;
using VegunSoft.Company.Editor.Provider.Structure;
using VegunSoft.Framework;
using VegunSoft.Framework.Enums;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Methods;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Models;
using VegunSoft.Framework.Models;

using VegunSoft.Layer.UcService.Models.Base;

namespace VegunSoft.Layer.UcControl.Provider.App
{
    public partial class UcConfigFilter : UcBaseAcc
    {
        private bool _isLoaded;
        protected MCommissionFilter Settings { get; private set; }

        public override string RightsCode => Settings?.RightsCode;

        public MDateTimeRange SelectedRange
        {
            get
            {
                return Dc.GetDateTimes();
            }
        }

        public UcConfigFilter()
        {
            InitializeComponent();
        }

        public void CheckAndInit(MCommissionFilter settings)
        {
            if (!_isLoaded)
            {
                Settings = settings;
                OnInitFields();
                ConfigControls();
                OnEndInitFields();
                _isLoaded = true;
            }
              
        }

        private void OnInitFields()
        {
           
        }
       

        public void ConfigControls()
        {
            Dc.Start(new MDateTimeControls()
            {
                RdgDateTime = _rdgDateTime,
                LblFromDate = _checkBoxLabelFromDate,
                TxtFromDate = _txtFromDate,
                LblToDate = _checkBoxLabelToDate,
                TxtToDate = _txtToDate,
                LblDateRange = _lblDateRange,
                TxtDateRange = _txtDateRange,
                FirstButton = _btnGoFirst,
                BackButton = _btnGoBack,
                ReloadButton = _btnReload,
                NextButton = _btnGoNext,
                LastButton = _btnGoLast,
                GetMinDateFunc = () => RangeModel?.FromDate,
                GetMaxDateFunc = () => RangeModel?.ToDate,
                CheckRdgReadOnlyFunc = () => IsReadOnlyMultiDate,
                DefaultType = EDateTimeRange.Day,
                DefaultDeltaDays = XCode.IsDebug ? SApp.DebugDeltaDays : 0,

            });

            _cbbListBranches.EditValueChanged += new System.EventHandler(this._cbbListBranches_EditValueChanged);
            _lblBranch.CheckedChanged += (s, e) =>
            {
                _cbbListBranches.Enabled = _lblBranch.Checked;
                OnLoadData();
            };
           // _rdgDateTime.SelectedIndex = 0;
        }

        protected void _cbbListBranches_EditValueChanged(object sender, EventArgs e)
        {
            OnLoadData();
        }

        protected void OnLoadData()
        {
            Settings?.OnLoadDataAction?.Invoke(_isLoaded);
        }

        protected void OnEndInitFields()
        {
            _txtFromDate.DateTime = _txtToDate.DateTime = RepositoryUserAccount.GetDateTime();
            LoadBranches(_cbbListBranches);
        }

        protected void LoadBranches(SBoxBranch cbb)
        {
            cbb.LoadDataSource();
            cbb.EditValue = RepositorySession.BranchId;
        }

        private void _btnReload_Click(object sender, EventArgs e)
        {
            Settings?.OnLoadDataAction?.Invoke(_isLoaded);
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            Settings?.OnSaveAllAction?.Invoke(sender);
        }

        private void _btnSaveToExcel_Click(object sender, EventArgs e)
        {
            Settings?.OnExportToExcelAction?.Invoke();
        }

        public void UpdateRights(bool isCanAdd, bool isCanUpdate, bool isCanExport)
        {
            _btnSave.Visible = isCanAdd || isCanUpdate;
            _btnSaveToExcel.Visible = isCanExport;
        }
    }
}
