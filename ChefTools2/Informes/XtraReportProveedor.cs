using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ChefTools.Data;
using System.Data;

namespace ChefTools.Informes
{
    public partial class XtraReportProveedores : DevExpress.XtraReports.UI.XtraReport
    {
        
        public XtraReportProveedores(DataTable tb)
        {
            InitializeComponent();
            this.DataSource = tb;
            
        }

    }
}
