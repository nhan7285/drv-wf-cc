using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VegunSoft.Any.View.Forms;
using VegunSoft.Any.View.Service.Dev.Methods;
using VegunSoft.App.Entity.Provider.Business.Gui;
using VegunSoft.Base.Entity.Provider.Base;
using VegunSoft.Base.Entity.Provider.Format;
using VegunSoft.Customer.Data.Enums.Views;
using VegunSoft.Customer.Entity.Profile;
using VegunSoft.Customer.Entity.Provider.Categories;
using VegunSoft.Customer.View.Forms;
using VegunSoft.Customer.View.Service.Methods;
using VegunSoft.Framework.Gui.Enums.Image;
using VegunSoft.Framework.Gui.Provider.WindowsForms.Methods;
using VegunSoft.Framework.Methods;
using VegunSoft.Layer.UcService.Provider.Methods;
using VegunSoft.Order.View.Service.Dev.Methods;

namespace VegunSoft.Layer.UcControl.Customer.Provider.UserControls.Customer
{
    public partial class UcGridCustomers
    {
        private ContextMenuStrip _mainGridMenu;
        private ToolStripItem _mniAddNote;
        private List<ToolStripItem> _customerStatusGlobalItems;
        private ToolStripItem _customerHasNeedStatusItem;
        private ToolStripItem _customerNoNeedStatusItem;
        private ToolStripItem _showHistoriesItem;
        private ToolStripItem _mniChangeMode;
        private ToolStripItem _showHelpGlobalStatusColorsItem;

        private IEnumerable<MEntityCustomerStatusGlobal> _allCustomerStatus;
        private List<MEntityCustomerStatusGlobal> _listActiveCustomerStatusGlobal;

        private MEntityDataRowFormat _hasNeedProductServiceStatus;
        private MEntityDataRowFormat _noNeedProductServiceStatus;
      
       
        private Form _helpGlobalStatusForm;

        private Form InitHelpGlobalForm()
        {
            var helpForm = GuiIoc.GetInstance<IDisplayHelpColorsForm>();
           
            var models = _repositoryCustomerStatusGlobal.All().Where(x => x.IsActive && !x.IsDeleted).ToList();
            helpForm?.Apply(ECustomerMenuItem.CustomerStatusColorTable.GetText(), models);

            var f = helpForm as Form;
            if (f != null) f.TopMost = true;
            return f;
        }

        private void SetContextMenus()
        {
            var form = this.ParentForm;

            _mainGridMenu = new ContextMenuStrip();

            _mniAddNote = _mainGridMenu.Items.Add("Viết ghi chú khách hàng");
            _mniAddNote.Image = IconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Add16);
            _mniAddNote.Click += (s, e) => GuiIoc.GetInstance<IFCustomerNote>()?.ShowDialog(SelectedRow, OnManageNotesDone);
            
            _mainGridMenu.Items.Add(new ToolStripSeparator());

            _mniChangeMode = _mainGridMenu.AddChangeSelectModeMenuItem(_viewCustomers, _gridCustomers, _gcCustomerFullName);
            _showHistoriesItem = this.AddCustomerShowHistoryMenuItem(_mainGridMenu, GetAdapterModelFunc);

            _mainGridMenu.Items.Add(new ToolStripSeparator());
            _customerStatusGlobalItems = _mainGridMenu.AddStatusMenuItems(_viewCustomers, GetAdapterModelFunc, form, _listActiveCustomerStatusGlobal, OnSetFromOrdersStatus, OnGetCustomerGlobalStatusNote, OnSetCustomerGlobalStatusNote);

            _mainGridMenu.Items.Add(new ToolStripSeparator());

            _mainGridMenu.Items.Add(new ToolStripSeparator());
            _customerHasNeedStatusItem = _mainGridMenu.AddHasNeedStatusMenuItem(_viewCustomers, GetAdapterModelFunc, form, _hasNeedProductServiceStatus, OnSetHasNeedStatus, _formName);
            _customerNoNeedStatusItem = _mainGridMenu.AddNoNeedStatusMenuItem(_viewCustomers, GetAdapterModelFunc, form, _noNeedProductServiceStatus, OnSetNoNeedStatus);
            _mainGridMenu.Items.Add(new ToolStripSeparator());
            _showHelpGlobalStatusColorsItem = _mainGridMenu.AddColorMenuItem(_viewCustomers, _gridCustomers, _helpGlobalStatusForm);
           
            _gridCustomers.ContextMenuStrip = _mainGridMenu;
        }

        private void OnManageNotesDone(string obj)
        {
            //TODO
        }

        private void OnSetHasNeedStatus(ICustomerItem c, MEntityFormatFontColor s)
        {
            if (!(c is ICustomerItem customer) || s == null) return;
            customer.HasNeed = true;
        }

        private void OnSetNoNeedStatus(ICustomerItem c, MEntityFormatFontColor s)
        {
            if (!(c is ICustomerItem customer) || s == null) return;
            customer.HasNeed = false;
        }

        private string OnGetCustomerGlobalStatusNote(ICustomerItem c)
        {
            return c.CustomerStatusNote;
        }

        private void OnSetCustomerGlobalStatusNote(ICustomerItem c, string note)
        {
            c.CustomerStatusNote = note;
        }

        private MEntityDataAdapter GetAdapterModelFunc()
        {
            var row = SelectedRow;
            if (row == null) return null;
            return new MEntityDataAdapter()
            {
                Id = row.Id,
                DisplayKey = row.DisplayCode,
                FromModel = row
            };
        }

        private void OnSetFromOrdersStatus(ICustomerItem c, MEntityFormatFontColor s)
        {
            if (!(c is ICustomerItem customer) || s == null) return;
            customer.CustomerStatusId = s.Id;
            customer.CustomerStatusName = s.Caption;
        }

        private void ShowContextMenu()
        {
            var row = SelectedRow;
            var hasCustomer = !string.IsNullOrWhiteSpace(row?.Id);

          
            _customerStatusGlobalItems?.CheckShowCustomerGlobalStatusItems(hasCustomer, row?.CustomerStatusId);
           

            _customerHasNeedStatusItem.Visible = hasCustomer;
            _customerNoNeedStatusItem.Visible = hasCustomer;

            _customerHasNeedStatusItem.Font = new Font(_customerHasNeedStatusItem.Font, row != null && row.HasNeed ? FontStyle.Underline : FontStyle.Regular);
            _customerNoNeedStatusItem.Font = new Font(_customerNoNeedStatusItem.Font, row == null || !row.HasNeed ? FontStyle.Underline : FontStyle.Regular);

            _showHistoriesItem.Visible = hasCustomer;
            _mniAddNote.Visible = hasCustomer;
            _mainGridMenu.DisplayAtCursor();
        }
    }
}
