using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using VegunSoft.Base.View.Dev.UserControls;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Methods;
using VegunSoft.Layer.Gui.Forms;
using VegunSoft.Layer.UcControl.Models;
using VegunSoft.Layer.UcService.Provider.Any;
using VegunSoft.Order.Entity.Provider.Business;
using VegunSoft.Order.Repository.Business;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Consult
{
    public partial class UcOrderConsultGrid : UcBase
    {
        private bool _isLoaded;
        private IRepositoryCustomerConsultancy _repositoryOrderConsult;
        protected IRepositoryCustomerConsultancy RepositoryOrderConsult => _repositoryOrderConsult ?? (_repositoryOrderConsult = DbIoc.GetInstance<IRepositoryCustomerConsultancy>());

        private List<MEntityOrderConsult> _models;
        private string _orderId;
        private string _customerId;

        protected MUcConsultancyGrid Settings { get; private set; }

        public Action<MEntityOrderConsult> StartEditAction => Settings?.StartEditAction;
        
        public UcOrderConsultGrid()
        {
            InitializeComponent();
        }

        public void CheckAndInit(MUcConsultancyGrid settings)
        {
            if (!_isLoaded)
            {
                Settings = settings;
                InitFields();
                SetIcons();
                ConfigControls();
                SetReadOnly(true);
                _isLoaded = true;
            }
        }

        private void InitFields()
        {
                      
        }

        public void SetReadOnly(bool isReadOnly)
        {

        }

        private void SetIcons()
        {

        }

        public List<MEntityOrderConsult> DataSource => _grid.DataSource as List<MEntityOrderConsult>;

        public void SelectCustomer(string customerId)
        {
            _customerId = customerId;
            if (string.IsNullOrWhiteSpace(customerId))
            {
                _models =  new List<MEntityOrderConsult>();
            }
            else
            {
                _models = RepositoryOrderConsult.Where(nameof(MEntityOrderConsult.CustomerId), customerId)?.OrderByDescending(x=>x.CreatedDate).ToList() ?? new List<MEntityOrderConsult>();
            }
            _grid.DataSource = _models;
            _view.RefreshData();
        }

        public void SelectOrder(string orderId)
        {
            //_orderId = orderId;
            //var models = !string.IsNullOrWhiteSpace(_orderId) ?_models.Where(x => x.OrderId == _orderId).ToList(): _models;
            //_grid.DataSource = models;
            //_view.RefreshData();
        }

        public void ReloadData()
        {
            SelectCustomer(_customerId);
            SelectOrder(_orderId);
        }

        private void _lnkDelete_Click(object sender, EventArgs e)
        {
            var model = _view.GetFocusedRow() as MEntityOrderConsult;
            if (Msg.IsAgree(Class_Global._tbXoa))
            {
                var rs = RepositoryOrderConsult.Delete(model);
                if (rs)
                {
                    var text = "Tư Vấn";
                    Msg.ShowDeleteSuccessInfo(text, true);
                    ReloadData();
                }
                else
                {
                    Msg.ShowError(Class_Global.ERROR_DELETE_DATA);
                }
            }
        }

        private void _lnkEdit_Click(object sender, EventArgs e)
        {
            //ShowLoading();
            StartEdit();
            //CloseLoading();
        }

        public void StartEdit()
        {
            var model = _view.GetFocusedRow() as MEntityOrderConsult;
            StartEditAction?.Invoke(model);
            Settings?.ShowConsultAction?.Invoke(model?.Id);
        }

        public void CheckAndSelectFinalItem()
        {
            if (!(_grid.DataSource is List<MEntityOrderConsult> list) || list.Count <= 0) return;
            if(_view.GetRow(0) is MEntityOrderConsult model) StartEditAction?.Invoke(model);
        }

        public void SelectById(string id)
        {
            _view.LocateByValue(nameof(MEntityOrderConsult.Id), id);
            var model = RepositoryOrderConsult?.Find(id);
            StartEditAction?.Invoke(model);
            var item = DataSource?.FirstOrDefault(x => x.Id == id);
            if (item != null && model!=null)
            {
                model.Copy(item);
                item.Content = model.Content;
                var index = DataSource.IndexOf(item);
                FocusRow(index);
            }
        }
        private void FocusRow(int idx)
        {
            _view.SelectRow(idx);
            _view.FocusedRowHandle = idx;
            _view.MakeRowVisible(idx);
        }
        public MEntityOrderConsult SelectedRow => _view.GetFocusedRow() as MEntityOrderConsult;

        private void _lnkView_Click(object sender, EventArgs e)
        {
            XLoading.ShowLoading();
            var model = _view.GetFocusedRow() as MEntityOrderConsult;
            var f = GuiIoc.GetInstance<IFConsultContent>();
            f.Apply(model);
            if (f is Form form)
            {
                form.StartPosition = FormStartPosition.CenterScreen;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
                
            }
            XLoading.CloseLoading();
        }

        private void ConfigControls()
        {
            _gcConsultNo.FieldName = nameof(MEntityOrderConsult.No);
            _gcConsultDate.FieldName = nameof(MEntityOrderConsult.StartDateTime);
            _gcConsultName.FieldName = nameof(MEntityOrderConsult.Name);
            _gcConsultTypeName.FieldName = nameof(MEntityOrderConsult.ProductServiceTypeName);
            _gcConsultGroupName.FieldName = nameof(MEntityOrderConsult.ProductServiceGroupName);
            _gcConsultGroupFinalName.FieldName = nameof(MEntityOrderConsult.ProductServiceGroupFinalName);
            _gcConsultProductServiceName.FieldName = nameof(MEntityOrderConsult.ProductServiceName);
            _gcConsultDoctor.FieldName = nameof(MEntityOrderConsult.ConsultingDoctorFullName);
            _gcConsultAssistant.FieldName = nameof(MEntityOrderConsult.ConsultingAssistantFullName);
            _gcIsForOld.FieldName = nameof(MEntityOrderConsult.IsForOld);

            if (Settings == null) return;
            
            if (Settings.IsHideDeleteColumn) _gcConsultDelete.Visible = false;
            if (Settings.IsHideAssistantColumn) _gcConsultAssistant.Visible = false;
            if (Settings.IsHideStartDateColumn) _gcConsultDate.Visible = false;
            if (Settings.IsHideContractColumn) _gcConsultContract.Visible = false;
            if (Settings.IsHideIsForAllColumn) _gcIsForOld.Visible = false;
        }

        public static List<string> ToolTipFields { get; } = new List<string>()
        {
            nameof(MEntityOrderConsult.No),
            nameof(MEntityOrderConsult.StartDateTime),
            nameof(MEntityOrderConsult.Name),
            nameof(MEntityOrderConsult.ConsultingDoctorFullName),
        };
        private void _tooltipController_GetActiveObjectInfo(object sender, ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            if (e.Info == null && e.SelectedControl == _grid)
            {
                GridView view = _grid.FocusedView as GridView;
                if (view != null)
                {
                    GridHitInfo info = view.CalcHitInfo(e.ControlMousePosition);
                    if (info.InRowCell)
                    {
                        //var obj = e.SelectedObject;
                        var model = view.GetRow(info.RowHandle) as MEntityOrderConsult;
                        if (model != null)
                        {
                            var hasCSContent = !string.IsNullOrWhiteSpace(model.ConsultingAssistantFullName) ||
                                               model.StartDateTime != null;
                            if (ToolTipFields.Contains(info.Column.FieldName) && hasCSContent)
                            {
                                var text = GetToolTipContent(model);
                                string cellKey = info.RowHandle.ToString() + " - " + info.Column.ToString();
                                e.Info = new ToolTipControlInfo(cellKey, text)
                                {
                                    // AllowHtmlText = DefaultBoolean.True
                                };
                                return;

                            }
                        }


                    }
                }
            }
        }

        private string GetToolTipContent(MEntityOrderConsult model)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Ngày: {model.StartDateTime?.ToString("dd/MM/yyyy HH:mm")} ");
            sb.AppendLine($"Lý do: {model.Name}");
            sb.AppendLine($"BSTV: {model.ConsultingDoctorFullName} ");
            sb.AppendLine($"TLTV: {model.ConsultingAssistantFullName} ");
           
            return sb.ToString();
        }

        private void _lnkContract_Click(object sender, EventArgs e)
        {
            var model = _view.GetFocusedRow() as MEntityOrderConsult;
            Settings?.ContractConsultAction?.Invoke(model);
        }

        private void _view_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Settings?.SelectedConsultChanged?.Invoke(SelectedRow);

        }

        private void _view_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (_view.GetRow(e.RowHandle) is MEntityOrderConsult entity)
            {
                if (entity.IsForOld)
                {

                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Italic);
                }

            }
        }
    }
}
