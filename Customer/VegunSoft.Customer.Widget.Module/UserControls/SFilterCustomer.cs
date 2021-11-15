using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using VegunSoft.Customer.Data.Enums.Search;
using VegunSoft.Customer.Entity.Provider.Profile;
using VegunSoft.Customer.View.Filters;
using VegunSoft.Framework.Gui.Provider.WindowsForms.DevExp.Methods;

namespace VegunSoft.Customer.View.Dev.UserControls
{
    public partial class SFilterCustomer : UcBaseCustomer, IFilterCustomer
    {
        public GridLookUpEdit Editor => _cbbCustomers;

        private bool _isSearchAllBranches = false;
        public SFilterCustomer()
        {
            InitializeComponent();
            ConfigViewColumns();
            ApplyEvents();
        }



        private void ApplyEvents()
        {
            rdgTimKiem.EditValueChanged += rdgTimKiem_EditValueChanged;
            _viewCustomers.ApplyContainsSearch();
            _cbbCustomers.ApplyCustomDisplayText();
        }

       
        private void TxtKeywordOnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Search();
        }

        private void Search(bool isExact = false)
        {
            var val = _cbbCustomers.Text?.Trim();
            _currentKeyword = val;
            var branchId = RepositorySession.Branch?.Id;
            List<MEntityCustomerMin> list;
            var type = GetSearchType();
            list = RepositoryCustomer.SearchByKeyword<MEntityCustomerMin>(val, type, isExact).ToList();
            if (!_isSearchAllBranches && !string.IsNullOrWhiteSpace(branchId))
                list = list.Where(x => x.BranchId == branchId).ToList();
            _cbbCustomers.Properties.DataSource = list.OrderByDescending(x => x.CreatedDate).ToList();
            _isAllowShowPopup = true;

            _cbbCustomers.ShowPopup();
        }

        public IFilterCustomer SelectCustomer(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                _cbbCustomers.Properties.DataSource = RepositoryCustomer.GetCustomers<MEntityCustomerMin>(new List<string>() { id });
                _cbbCustomers.EditValue = id;
            }
           
            return this;
        }

        public void RefrershData()
        {
            var ds = _cbbCustomers.Properties.DataSource as List<MEntityCustomerMin>;
            if (ds != null)
            {
                var customerIds = ds.Select(x => x.Id).ToArray();
                _cbbCustomers.Properties.DataSource = RepositoryCustomer.GetCustomers(customerIds);
            }
        }

        private void ConfigViewColumns()
        {
            _cbbCustomers.Properties.DisplayMember = nameof(MEntityCustomerMin.FullName);
            _cbbCustomers.Properties.ValueMember = nameof(MEntityCustomerMin.Id);

            _gcSearchCustomerId.FieldName = nameof(MEntityCustomerMin.DisplayCode);
            _gcSearchCustomerFullName.FieldName = nameof(MEntityCustomerMin.FullName);
            _gcSearchCustomerPhone.FieldName = nameof(MEntityCustomerMin.PhoneNumber);
            _gcSearchCreatedDate.FieldName = nameof(MEntityCustomerMin.CreatedDate);
            _gcSearchContent.FieldName = nameof(MEntityCustomerMin.FullAddress);
            _gcSearchKeyword.FieldName = nameof(MEntityCustomerMin.CompactKeywords);
            _gcSearchUnsignKeyword.FieldName = nameof(MEntityCustomerMin.UnsignKeywords);

            var searchColumnFields = new string[]
            {
                nameof(MEntityCustomerMin.Id),
                nameof(MEntityCustomerMin.DisplayCode),
                nameof(MEntityCustomerMin.FullName),
                nameof(MEntityCustomerMin.PhoneNumber),
                nameof(MEntityCustomerMin.CreatedDate),
                nameof(MEntityCustomerMin.FullAddress),
                nameof(MEntityCustomerMin.UnsignKeywords),
                nameof(MEntityCustomerMin.CompactKeywords)
            };
            _viewCustomers.ApplyContainsSearch(searchColumnFields);
        }

        private ESearchCustomerData GetSearchType()
        {
            if (rdgTimKiem.SelectedIndex == 0) return ESearchCustomerData.All;
            if (rdgTimKiem.SelectedIndex == 1) return ESearchCustomerData.CustomerCode;
            if (rdgTimKiem.SelectedIndex == 2) return ESearchCustomerData.CustomerFullName;
            if (rdgTimKiem.SelectedIndex == 3) return ESearchCustomerData.CustomerPhoneNumber;
            return ESearchCustomerData.EntityId;
        }


        public void StartSearch()
        {
            _cbbCustomers.EditValue = _currentKeyword;
            _cbbCustomers.Focus();
            //_txtKeyword.BringToFront();
            _cbbCustomers.SelectAll();
        }

    

        private void rdgTimKiem_EditValueChanged(object sender, EventArgs e)
        {
           // StartSearch();
        }

        private void _cbbCustomers_Click(object sender, EventArgs e)
        {
           // StartSearch();
        }

        public string SelectedCustomerId
        {
            get
            {
                return _cbbCustomers.EditValue?.ToString();
            }
        }

        public MEntityCustomerMin SelectedCustomer => _cbbCustomers.GetSelectedDataRow() as MEntityCustomerMin;

        public void DoSearch()
        {

        }

        private void _cbbCustomers_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
           
            if (e.Button.Kind == ButtonPredefines.Delete)
            {
                //_txtKeyword.EditValue = null;
                _cbbCustomers.EditValue = null;
                _currentKeyword = null;
                _cbbCustomers.Properties.DataSource = null;
                
            } else if (e.Button.Kind == ButtonPredefines.OK)
            {
               
                _isSearchAllBranches = true;
                e.Button.Kind = ButtonPredefines.Search;
                e.Button.ToolTip = "Tìm khách hàng theo tất cả chi nhánh";
                Search();
            }
            else if (e.Button.Kind == ButtonPredefines.Search)
            {
                _isSearchAllBranches = false;
                e.Button.Kind = ButtonPredefines.OK;
                e.Button.ToolTip = "Tìm khách hàng theo chi nhánh hiện tại";
                Search();
            }
        }

        private void _cbbCustomers_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    Search();
            //}
        }

        private void _cbbCustomers_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)13)
            {
                Search();
            }
            else
            {
                _isAllowShowPopup = false;
            }
        }

        private void _cbbCustomers_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = !_isAllowShowPopup;
        }

        private bool _isAllowShowPopup;
        private string _currentKeyword;


        private void _cbbCustomers_Click_1(object sender, EventArgs e)
        {
            StartSearch();
        }

        private void glkView_ColumnFilterChanged(object sender, EventArgs e)
        {
            var searchColumnFields = new string[]
            {
                nameof(MEntityCustomerMin.Id),
                nameof(MEntityCustomerMin.DisplayCode),
                nameof(MEntityCustomerMin.FullName),
                nameof(MEntityCustomerMin.PhoneNumber),
                nameof(MEntityCustomerMin.FullAddress),
                nameof(MEntityCustomerMin.UnsignKeywords),
                nameof(MEntityCustomerMin.CompactKeywords)
            };
            if (searchColumnFields.Length == 0) return;
            var list = searchColumnFields.ToList();
            var functionOperator = _viewCustomers.DataController.FilterCriteria as FunctionOperator;
            if (!ReferenceEquals(functionOperator, null))
            {
                var groupOperator = new GroupOperator
                {
                    OperatorType = GroupOperatorType.Or
                };

                foreach (GridColumn col in _viewCustomers.Columns)
                {
                    if (list.Contains(col.FieldName))
                    {
                        var fOperator = new FunctionOperator
                        {
                            OperatorType = FunctionOperatorType.Contains
                        };
                        fOperator.Operands.Add(new OperandProperty(col.FieldName));
                        var c = functionOperator.Operands[1] as ConstantValue;
                        var cv = c?.Value;
                        if (cv != null)
                        {
                            fOperator.Operands.Add(new ConstantValue(cv));
                            groupOperator.Operands.Add(fOperator);
                        }
                    }
                }
                _viewCustomers.DataController.FilterCriteria = groupOperator;
            }
        }

        public object DataSource => _cbbCustomers.Properties.DataSource as List<MEntityCustomerMin>;
    }
}
