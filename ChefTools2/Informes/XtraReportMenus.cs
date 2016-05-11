using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ChefTools.Informes
{
    public partial class XtraReportMenus : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportMenus(DataTable tb)
        {
            InitializeComponent();

            if (tb != null) {
                this.DataSource = tb;
            }
                
        }

    }
}
