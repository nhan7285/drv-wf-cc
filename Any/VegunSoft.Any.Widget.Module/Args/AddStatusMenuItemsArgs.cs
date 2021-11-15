using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using VegunSoft.Base.Entity.Provider.Base;
using VegunSoft.Base.Entity.Provider.Format;
using VegunSoft.Framework.Db.Services;

namespace VegunSoft.Layer.UcService.Provider.Any
{

    public class AddStatusMenuItemsArgs<TStatusEntity, TTargetEntity> where TStatusEntity : MEntityFormatFontColor where TTargetEntity : class, new()
    {
        public string Caption { get; set; }

        public string Name { get; set; }

        public string Label { get; set; }

        public Image Icon { get; set; }

        public ITableRepository<TTargetEntity> Repository { get; set; }

        public GridView GridView { get; set; }

        public Func<MEntityDataAdapter> GetDataAdapterFunc { get; set; }

        public Form Owner { get; set; }

        public bool IsResetNotes { get; set; }

        public List<TStatusEntity> Categories { get; set; }

        public Action<TTargetEntity, MEntityFormatFontColor> SaveSuccessAction { get; set; }

        public Action<TTargetEntity, MEntityFormatFontColor> SaveFailAction { get; set; }
       
    }
}
