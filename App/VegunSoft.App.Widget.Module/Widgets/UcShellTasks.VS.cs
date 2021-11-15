using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using VegunSoft.App.Model.Provider.Business;
using VegunSoft.App.Widget.Widgets;
using VegunSoft.Layer.Gui.Any.Forms;

namespace VegunSoft.Layer.UcControl.Provider.App
{
    public partial class UcShellTasks
    {
        protected void InitGrid()
        {
            _grid.DataSource = DS;
            _view.RefreshData();
        }

        protected void RefreshGrid()
        {
            _view.RefreshData();
        }

        protected void ResetGrid()
        {
            DS.Clear();
            _view.RefreshData();
        }

        public IUcShellTasks Add(MShellTask m)
        {          
            DS.Add(m);
            RefreshGrid();
            ItemsChanged?.Invoke();
            return this;
        }

        public IUcShellTasks Remove(MShellTask m)
        {
            if(Msg.IsAgree("Bạn có chắc muốn tạm xóa nhiệm vụ này không?"))
            {
                DS.Remove(m);
                RefreshGrid();
                ItemsChanged?.Invoke();
            }
           
            return this;
        }

        public IUcShellTasks Edit(MShellTask task)
        {
            if (task == null || string.IsNullOrWhiteSpace(task.InputKey)) return this;
            ShowLoading();
            try
            {
                var f = GuiIoc.GetInstance<Form>(task.InputKey);
                if (f != null)
                {

                    var t = new Thread(() =>
                    {
                        Thread.Sleep(500);
                        this.BeginInvoke(new Action(() =>
                        {
                            if (f is ITaskForm taskForm)
                            {
                                taskForm.InitForEdit(task);
                            }
                            f.StartPosition = FormStartPosition.CenterScreen;
                            CloseLoading();
                            f.ShowDialog(ShellForm);
                        }));
                    });
                    t.IsBackground = true;
                    t.Start();
                }
                else
                {
                    CloseLoading();
                }
            }
            catch (Exception ex)
            {
                CloseLoading();
                throw;
            }
            return this;
        }

        public IUcShellTasks Add(List<MShellTask> tasks)
        {
            ResetGrid();
            if (tasks == null || tasks.Count == 0) return this;
            
            foreach (var task in tasks)
            {
                DS.Add(task);               
            }
            RefreshGrid();
            ItemsChanged?.Invoke();
            return this;
        }
    }
}
