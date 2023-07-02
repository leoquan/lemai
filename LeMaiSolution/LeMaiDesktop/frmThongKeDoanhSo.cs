using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeMaiDomain;
using LeMaiLogic;
using LeMaiLogic.Logic;
using Common.Report;
using CrystalDecisions.CrystalReports.Engine;
using DevExpress.XtraReports.UI;
using LeMaiDesktop.Reports;

namespace LeMaiDesktop
{
    public partial class frmThongKeDoanhSo : frmBase
    {
        ThongKeDoanhSoLogic _logic = new ThongKeDoanhSoLogic(PBean.ConnectionBase);
        public frmThongKeDoanhSo()
        {
            InitializeComponent();
        }

        private async void frmThongKeDoanhSo_Load(object sender, EventArgs e)
        {
            try
            {
                // List Combobox
                cmbRegisterUser.DataSource = await _logic.GetListAccountObject();
                cmbRegisterUser.DisplayMember = "FullName";
                cmbRegisterUser.ValueMember = "Id";
                cmbRegisterSiteCode.DataSource = await _logic.GetListExpPost();
                cmbRegisterSiteCode.DisplayMember = "TenDaiLy";
                cmbRegisterSiteCode.ValueMember = "Id";
                cmbAcceptProvinceCode.DataSource = await _logic.GetListGExpProvince();
                cmbAcceptProvinceCode.DisplayMember = "ProvinceName";
                cmbAcceptProvinceCode.ValueMember = "ProvinceID";
                cmbFK_Customer.DataSource = await _logic.GetListExpCustomer();
                cmbFK_Customer.DisplayMember = "CustomerName";
                cmbFK_Customer.ValueMember = "Id";
                cmbFK_ProviderAccount.DataSource = await _logic.GetListExpProvider();
                cmbFK_ProviderAccount.DisplayMember = "ProviderName";
                cmbFK_ProviderAccount.ValueMember = "Id";
                cmbBillStatus.DataSource = await _logic.GetListGExpBillStatus();
                cmbBillStatus.DisplayMember = "StatusName";
                cmbBillStatus.ValueMember = "Id";
                cmbFK_PaymentType.DataSource = await _logic.GetListGExpPaymentType();
                cmbFK_PaymentType.DisplayMember = "PaymentTypeName";
                cmbFK_PaymentType.ValueMember = "Id";
                var result = await _logic.GetList(txtBillCode.Text, cmbRegisterUser.SelectedValue.ToString(), cmbRegisterSiteCode.SelectedValue.ToString(), cmbAcceptProvinceCode.SelectedValue.ToString(), dtpFromRegisterDate.Value, dtpToRegisterDate.Value, cmbFK_Customer.SelectedValue.ToString(), cmbFK_ProviderAccount.SelectedValue.ToString(), cmbBillStatus.SelectedValue.ToString(), cmbFK_PaymentType.SelectedValue.ToString());
                dataGrid.DataSource = result;
                lblCounter.Text = result.Count.ToString();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
            }
        }

        private async void btnFilter_Click(object sender, EventArgs e)
        {
            var result = await _logic.GetList(txtBillCode.Text, cmbRegisterUser.SelectedValue.ToString(), cmbRegisterSiteCode.SelectedValue.ToString(), cmbAcceptProvinceCode.SelectedValue.ToString(), dtpFromRegisterDate.Value, dtpToRegisterDate.Value, cmbFK_Customer.SelectedValue.ToString(), cmbFK_ProviderAccount.SelectedValue.ToString(), cmbBillStatus.SelectedValue.ToString(), cmbFK_PaymentType.SelectedValue.ToString());
            dataGrid.DataSource = result;
            lblCounter.Text = result.Count.ToString();
        }

        private async void btnClear_Click(object sender, EventArgs e)
        {
            txtBillCode.Clear();
            cmbRegisterUser.SelectedIndex = 0;
            cmbRegisterSiteCode.SelectedIndex = 0;
            cmbAcceptProvinceCode.SelectedIndex = 0;
            dtpFromRegisterDate.Value = DateTime.Now;
            dtpToRegisterDate.Value = DateTime.Now;
            cmbFK_Customer.SelectedIndex = 0;
            cmbFK_ProviderAccount.SelectedIndex = 0;
            cmbBillStatus.SelectedIndex = 0;
            cmbFK_PaymentType.SelectedIndex = 0;
            // Load Data
            var result = await _logic.GetList(txtBillCode.Text, cmbRegisterUser.SelectedValue.ToString(), cmbRegisterSiteCode.SelectedValue.ToString(), cmbAcceptProvinceCode.SelectedValue.ToString(), dtpFromRegisterDate.Value, dtpToRegisterDate.Value, cmbFK_Customer.SelectedValue.ToString(), cmbFK_ProviderAccount.SelectedValue.ToString(), cmbBillStatus.SelectedValue.ToString(), cmbFK_PaymentType.SelectedValue.ToString());
            dataGrid.DataSource = result;
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            var result = await _logic.GetList(txtBillCode.Text, cmbRegisterUser.SelectedValue.ToString(), cmbRegisterSiteCode.SelectedValue.ToString(), cmbAcceptProvinceCode.SelectedValue.ToString(), dtpFromRegisterDate.Value, dtpToRegisterDate.Value, cmbFK_Customer.SelectedValue.ToString(), cmbFK_ProviderAccount.SelectedValue.ToString(), cmbBillStatus.SelectedValue.ToString(), cmbFK_PaymentType.SelectedValue.ToString());
            if (PBean.LOCAL_OPTIONS.DevExpressReport == true)
            {
                frmDevExpressReportView frmView = new frmDevExpressReportView();
                xrThongKeDoanhSo rpt = new xrThongKeDoanhSo();
                GExpBill bill = new GExpBill();
                List<ReportUtilFormat> formats = new List<ReportUtilFormat>();
                //formats.Add(new ReportUtilFormat { ControlName = "xrThonXa", Format = "{0} Leo Quân" });
                //formats.Add(new ReportUtilFormat { ControlName = "xrd_NowDa", Format = "{0:dd}" });
                //formats.Add(new ReportUtilFormat { ControlName = "xrm_NowDa", Format = "{0:MM}" });
                //formats.Add(new ReportUtilFormat { ControlName = "xry_NowDa", Format = "{0:yyyy}" });
                ReportUtil.BindingData(rpt, bill, formats);
                frmView.rpt = rpt;
                frmView.Show();
            }
            else
            {
                // Crystal Report
                try
                {
                    DataTable data = MapperExtensionClass.ToDataTable<view_GExpBill>(result);
                    string reportFile = "ThongKeDoanhSo.rpt";
                    LVReport report = new LVReport();
                    report.ShowReport(PConstants.FOLDER_REPORT.TrimEnd('\\') + "\\" + reportFile, "A4", false, "Thống kê đơn hàng", PBean.MESSAGE_TITLE, data, true, true);
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
                }
            }



        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await _logic.GetList(txtBillCode.Text, cmbRegisterUser.SelectedValue.ToString(), cmbRegisterSiteCode.SelectedValue.ToString(), cmbAcceptProvinceCode.SelectedValue.ToString(), dtpFromRegisterDate.Value, dtpToRegisterDate.Value, cmbFK_Customer.SelectedValue.ToString(), cmbFK_ProviderAccount.SelectedValue.ToString(), cmbBillStatus.SelectedValue.ToString(), cmbFK_PaymentType.SelectedValue.ToString());
                DataTable data = MapperExtensionClass.ToDataTable<view_GExpBill>(result);
                string template = "BASIC_TEMPLATE.xlsx";

                Dictionary<string, string> dicTitle = new Dictionary<string, string>();
                Dictionary<string, string> dicReplaceValue = new Dictionary<string, string>();

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Microsoft Excel files(*.xlsx)| *.xlsx";
                saveFileDialog.FileName = "ExportFileName";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportDataToExcelTemplate.Export(template, saveFileDialog.FileName, 0, data, dicTitle, dicReplaceValue);
                    MessageBox.Show("Export Complete!", PBean.MESSAGE_TITLE);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

