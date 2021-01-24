using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraScheduler;


namespace VegunSoft.Schedule.View.Dev
{
    public partial class UcSchedulePersonnel : RibbonForm
    {
        public UcSchedulePersonnel()
        {
            InitializeComponent();
            schedulerControl.Start = System.DateTime.Now;
        }

    }
}