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

namespace pricingCDR.Formularios
{
    public partial class FrmReport : Form
    {
        
        public FrmReport(string pathReport)
        {
            InitializeComponent();
            this.reportViewerVisor.LocalReport.ReportEmbeddedResource = pathReport;
        }

        public FrmReport(string pathReport, string nameDataSource, object dataSource)
        {
            InitializeComponent();
            this.reportViewerVisor.LocalReport.ReportEmbeddedResource = pathReport;
            ReportDataSource rptdata = new ReportDataSource(nameDataSource, dataSource);
            reportViewerVisor.LocalReport.DataSources.Add(rptdata);
        }

        public void AddDataSource(string nameDataSource, object dataSource)
        {
            ReportDataSource rptdata = new ReportDataSource(nameDataSource, dataSource);
            reportViewerVisor.LocalReport.DataSources.Add(rptdata);
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {

            this.reportViewerVisor.RefreshReport();
        }
    }
}
