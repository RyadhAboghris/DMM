using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMM.Pages
{
    public partial class ReportPage : DevExpress.XtraEditors.XtraUserControl
    {
        public ReportPage()
        {
            InitializeComponent();
        }

        private void btn_suplierReport_Click(object sender, EventArgs e)
        {
            DMM.Report.SupplierReport report = new Report.SupplierReport();
            ReportPrintTool reportPrint = new ReportPrintTool(report);
            reportPrint.ShowPreview();
        }

        private void btn_customerReport_Click(object sender, EventArgs e)
        {
            DMM.Report.CustomerReport report = new Report.CustomerReport();
            ReportPrintTool reportPrint = new ReportPrintTool(report);
            reportPrint.ShowPreview();
        }
    }
}
