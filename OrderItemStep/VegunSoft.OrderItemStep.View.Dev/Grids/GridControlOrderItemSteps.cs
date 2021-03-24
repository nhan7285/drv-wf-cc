using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegunSoft.OrderItemStep.View.Dev.Grids
{   

    public class GridControlOrderItemSteps: GridControl
    {
        protected GridViewOrderItemSteps _gridView;
        protected GridViewOrderItemSteps GridView
        {
            get
            {
                if(_gridView == null)
                {
                    var gv = new GridViewOrderItemSteps();

                    _gridView = gv;
                }
                return _gridView;
            }
        }

        public GridControlOrderItemSteps()
        {
            MainView = GridView;
        }
    }
}
