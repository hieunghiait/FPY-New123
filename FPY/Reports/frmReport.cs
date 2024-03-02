using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPY.Reports
{
    public partial class frmReport : Form
    {

        public frmReport()
        {
            InitializeComponent();
        }

        public ReportViewer ReportViewer { get; set; } 

        private void frmReport_Load(object sender, EventArgs e)
        {

            this.reportViewer2.RefreshReport();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {
            ReportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            ReportViewer.ZoomMode = ZoomMode.Percent;
            ReportViewer.ZoomPercent = 100;
            this.reportViewer2.RefreshReport();
        }
    }
}
