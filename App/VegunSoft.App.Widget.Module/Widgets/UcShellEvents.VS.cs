using Vegun.SocketBase.Model;
using VegunSoft.App.Model.Provider.Business;
using VegunSoft.App.Widget.Widgets;

namespace VegunSoft.Layer.UcControl.Provider.App
{
    public partial class UcShellEvents
    {
        protected void InitGrid()
        {
            _grid.DataSource = DS;
            _view.RefreshData();
        }

        public IUcShellEvents Remove(MShellEvent m)
        {
            if (Msg.IsAgree("Bạn có chắc muốn tạm xóa thông báo này không?"))
            {
                DS.Remove(m);
                RefreshGrid();
                ItemsChanged?.Invoke();
            }
               
            return this;
        }

        protected void RefreshGrid()
        {
            _view.RefreshData();
        }

        public IUcShellEvents Add(MSocketCmd cmd)
        {
            var m = Convert(cmd);
            DS.Add(m);
            RefreshGrid();
            ItemsChanged?.Invoke();
            return this;
        }
    }
}
