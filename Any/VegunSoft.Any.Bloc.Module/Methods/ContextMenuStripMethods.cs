using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VegunSoft.Any.Widget.Forms;
using VegunSoft.Base.Entity.Provider.Base;
using VegunSoft.Base.Entity.Provider.Format;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums.Image;
using VegunSoft.Framework.Gui.Services;
using VegunSoft.Framework.Ioc;


namespace VegunSoft.Any.View.Service.Dev.Methods
{
    public static class ContextMenuStripMethods
    {
        public static ToolStripItem AddColorMenuItem(this ContextMenuStrip menu, GridView gridView,
          GridControl gridControl, Form helpForm)
        {
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var iconService = guiIoc.GetInstance<IIconService>();
            var showHelpColorsItem = menu.Items.Add(helpForm.Text);
            showHelpColorsItem.Image = iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.ColorTable16);
            showHelpColorsItem.Click += (sender, args) => { helpForm?.Show(); };
            return showHelpColorsItem;
        }

        public static ToolStripItem AddChangeSelectModeMenuItem(this ContextMenuStrip menu, GridView gridView,
          GridControl gridControl, GridColumn gridColumn)
        {
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var iconService = guiIoc.GetInstance<IIconService>();
            var mniChangeMode = menu.Items.Add("Đổi kiểu chọn");
            mniChangeMode.Image = iconService.GetIcon16<EResourceImage16, Image>(EResourceImage16.Select16);
            mniChangeMode.Click += (sender, args) => { gridView.ChangeMode(gridControl, gridColumn, mniChangeMode); };
            return mniChangeMode;
        }

        public static ToolStripItem AddActionItem<T>(this ContextMenuStrip menu, string title, EResourceImage16 icon, Action act) where T : class
        {
            //var dbIoc = XIoc.GetService(CDb.IocKey);
            var guiIoc = XIoc.GetService(CGui.IocKey);
            //var messageService = guiIoc.GetInstance<IAppMessage>();
            var iconService = guiIoc.GetInstance<IIconService>();
            //var repositoryCustomer = dbIoc.GetInstance<IRepositoryCustomer>();
            var item = menu.Items.Add(title);
            item.Image = iconService.GetIcon16<EResourceImage16, Image>(icon);
            item.Click += (sender, args) =>
            {
                act?.Invoke();
            };
            return item;
        }


        public static ToolStripItem AddShowManageFormMenuItem<T>(this ContextMenuStrip menu, GridView gridView, Func<MEntityDataAdapter> getModelFunc, Func<string> getFormKeyFunc, string title, Action<MEntityDataAdapter, T> afterCloseAction, EResourceImage16 icon = EResourceImage16.Status16) where T : class
        {
            //var dbIoc = XIoc.GetService(CDb.IocKey);
            var guiIoc = XIoc.GetService(CGui.IocKey);
            //var messageService = guiIoc.GetInstance<IAppMessage>();
            var iconService = guiIoc.GetInstance<IIconService>();
            //var repositoryCustomer = dbIoc.GetInstance<IRepositoryCustomer>();
            var item = menu.Items.Add(title);
            item.Image = iconService.GetIcon16<EResourceImage16, Image>(icon);
            item.Click += (sender, args) =>
            {
                var fk = getFormKeyFunc?.Invoke();
                if (!String.IsNullOrWhiteSpace(fk))
                {
                    var row = getModelFunc?.Invoke();
                    ShowManageForm(fk, f => { f.Init(row); }, afterCloseAction, row);
                }
            };
            return item;
        }


        private static void ShowManageForm<T>(string formKey, Action<IMgmtForm> beforeShowAction, Action<MEntityDataAdapter, T> afterCloseAction, MEntityDataAdapter adapterModel) where T : class
        {
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var f = guiIoc.GetInstance<Form>(formKey);
            if (f == null) return;
            if (f.Visible) f.Hide();
            //FHistory.BringToFront();
            beforeShowAction?.Invoke(f as IMgmtForm);
            f.ShowDialog();
            var model = f.Tag as T;
            afterCloseAction?.Invoke(adapterModel, model);
        }



    }
}
