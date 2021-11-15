using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums;
using VegunSoft.Framework.Gui.Services.Mgmt;
using VegunSoft.Framework.Ioc;

namespace VegunSoft.Layer.UcService.Provider.Methods
{
    public static class Xuly
    {
        

        public static List<string> GetThoiGian(RadioGroup rdgThoiGian, DateEdit dtTuNgay, DateEdit dtDenNgay)
        {
            string vThoiGian, vTuNgay, vDenNgay;
            List<string> listString = new List<string>();
            if (rdgThoiGian.SelectedIndex == 0)
            {
                vTuNgay = dtTuNgay.DateTime.Date.ToString("MM/dd/yyyy HH:mm:ss");
                vDenNgay = dtTuNgay.DateTime.Date.AddDays(1).AddSeconds(-1).ToString("MM/dd/yyyy HH:mm:ss");

                vThoiGian = "ngày " + dtTuNgay.DateTime.Date.ToString("dd-MM-yyyy");
            }
            else if (rdgThoiGian.SelectedIndex == 1)
            {
                vTuNgay = new DateTime(dtTuNgay.DateTime.Year, dtTuNgay.DateTime.Month, 1).ToString("MM/dd/yyyy HH:mm:ss");
                vDenNgay = new DateTime(dtTuNgay.DateTime.Year, dtTuNgay.DateTime.Month, 1).AddMonths(1).AddSeconds(-1).ToString("MM/dd/yyyy HH:mm:ss");

                vThoiGian = "tháng " + dtTuNgay.DateTime.Date.ToString("MM-yyyy");
            }
            else if (rdgThoiGian.SelectedIndex == 2)
            {
                vTuNgay = new DateTime(dtTuNgay.DateTime.Year, 1, 1).ToString("MM/dd/yyyy HH:mm:ss");
                vDenNgay = new DateTime(dtTuNgay.DateTime.Year, 12, 31).AddDays(1).AddSeconds(-1).ToString("MM/dd/yyyy HH:mm:ss");

                vThoiGian = "năm " + dtTuNgay.DateTime.Date.ToString("yyyy");
            }
            else
            {
                vTuNgay = dtTuNgay.DateTime.Date.ToString("MM/dd/yyyy HH:mm:ss");
                vDenNgay = dtDenNgay.DateTime.Date.AddDays(1).AddSeconds(-1).ToString("MM/dd/yyyy HH:mm:ss");

                vThoiGian = "từ ngày " + dtTuNgay.DateTime.Date.ToString("dd-MM-yyyy") + " đến ngày " + dtDenNgay.DateTime.Date.ToString("dd-MM-yyyy");
            }

            listString.Add(vTuNgay);
            listString.Add(vDenNgay);
            listString.Add(vThoiGian);
            return listString;
        }

        public static void rdgThoiGian_Change(RadioGroup rdgThoiGian, LabelControl lblThoiGian, DateEdit dtTuNgay, DateEdit dtDenNgay, LabelControl lblDenNgay)
        {
            var guiIoc = XIoc.GetService(CGui.IocKey);
            var svc = guiIoc.GetInstance<IFilterControlService>(EGui.WindowsFormsDevExpress);
            svc.ChangeDateTime(rdgThoiGian, lblThoiGian, dtTuNgay, lblDenNgay, dtDenNgay);
        }
    }
}
