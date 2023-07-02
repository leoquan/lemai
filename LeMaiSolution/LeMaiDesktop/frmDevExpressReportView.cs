using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using DevExpress.XtraReports.UI;

namespace LeMaiDesktop
{
    public partial class frmDevExpressReportView : frmBase
    {
        public XtraReport rpt;
        public frmDevExpressReportView()
        {
            InitializeComponent();
        }

        private void frmDevExpressReportView_Load(object sender, EventArgs e)
        {
            documentExpressViewer.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
    }
}
