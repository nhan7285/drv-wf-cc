using System;
using System.Drawing;
using DevExpress.Utils;
using VegunSoft.Any.MService.Provider.Methods;
using VegunSoft.Base.Entity.Provider.Format;

namespace VegunSoft.Any.View.Service.Dev.Methods
{
    public static class AppearanceObjectMethods
    {
        public static void ApplyStyle(this AppearanceObject o, MEntityFormatFontColor model)
        {
            if (model == null) return;

            if (model is MEntityFormatFontColorCustomable modelCustomable)
            {
                ApplyStyle(o, modelCustomable);
                return;
            }

            model.ApplyColor(model.TextColorRed, model.TextColorGreen, model.TextColorBlue, (c) => { o.ForeColor = c; });

            model.ApplyColor(model.BackgroundColorRed, model.BackgroundColorGreen, model.BackgroundColorBlue, (c) => { o.BackColor = c; });

            var defaultAppFont = o.Font;
            var isAppliedFont = model?.ApplyFont(defaultAppFont.FontFamily, defaultAppFont.Size, (ff, fs, stl) =>
            {
                o.Font = new Font(ff, Convert.ToSingle(fs), stl);
            }) ?? false;

        }

        private static void ApplyStyle(AppearanceObject o, MEntityFormatFontColorCustomable model)
        {
            if (model == null) return;
            var isAppliedForceColors = model.ApplyColor(model.CustomTextColorRed, model.CustomTextColorGreen, model.CustomTextColorBlue,
                (c) => { o.ForeColor = c; });
            if (!isAppliedForceColors)
            {
                model.ApplyColor(model.TextColorRed, model.TextColorGreen, model.TextColorBlue, (c) => { o.ForeColor = c; });
            }

            var isAppliedBackColors = model.ApplyColor(model.CustomBackgroundColorRed, model.CustomBackgroundColorGreen, model.CustomBackgroundColorBlue,
                (c) => { o.BackColor = c; });
            if (!isAppliedForceColors)
            {
                model.ApplyColor(model.BackgroundColorRed, model.BackgroundColorGreen, model.BackgroundColorBlue, (c) => { o.BackColor = c; });
            }

            var defaultAppFont = o.Font;
            var isAppliedFont = model?.ApplyFont(defaultAppFont.FontFamily, defaultAppFont.Size, (ff, fs, stl) =>
            {
                o.Font = new Font(ff, Convert.ToSingle(fs), stl);
            }) ?? false;

        }

    }
}
