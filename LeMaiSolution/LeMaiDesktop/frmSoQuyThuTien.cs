using Common;
using LeMaiDomain;
using LeMaiLogic.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace LeMaiDesktop
{
    public partial class frmSoQuyThuTien : frmBase
    {
        List<view_ExpCashPay> dataQuanLyThuChi = new List<view_ExpCashPay>();
        ExpConsignmentV2Logic _logic = new ExpConsignmentV2Logic(PBean.ConnectionBase);
        public frmSoQuyThuTien() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmSoQuyThuTien_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PBean.USER.companyid))
            {
                LoadCashList();
                cmbQLTCLoai.DataSource = await _logic.GetMasterCashPayTypeList();
                cmbQLTCLoai.DisplayMember = "TenLoai";
                cmbQLTCLoai.ValueMember = "Id";
            }
        }
        public async void LoadCashList()
        {
            dataQuanLyThuChi = new List<view_ExpCashPay>();
            dataQLTCGrid.AutoGenerateColumns = false;
            if (cmbQLTCLoai.SelectedValue != null)
            {
                dataQuanLyThuChi = await _logic.GetListCash(PBean.USER.companyid, cmbQLTCLoai.SelectedValue.ToString(), dateQLTCFrom.Value, dateQLTCTo.Value, true);
                dataQLTCGrid.DataSource = dataQuanLyThuChi;
            }
            if (dataQuanLyThuChi.Count > 0)
            {
                btnQLTCExcel.Enabled = true;
                btnInThuChi.Enabled = true;
            }
            else
            {
                btnQLTCExcel.Enabled = false;
                btnInThuChi.Enabled = false;
            }
        }

        private void btnQLTCTruyVan_Click(object sender, EventArgs e)
        {
            LoadCashList();
            FormatRowCash();
        }
        private void FormatRowCash()
        {
            for (int i = 0; i < dataQLTCGrid.Rows.Count; i++)
            {
                if (dataQLTCGrid.Rows[i].Cells["col_IsPay"].Value.ToString() == "True")
                {
                    dataQLTCGrid.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void btnInThuChi_Click(object sender, EventArgs e)
        {
            int TonDau;
            int TonCuoi;
            int Thu;
            int Chi;
            string NgayBaoCao = "Từ " + string.Format("{0:HH:mm:ss dd/MM/yyyy}", dateQLTCFrom.Value) + " đến " + string.Format("{0:HH:mm:ss dd/MM/yyyy}", dateQLTCTo.Value);
            DataTable data = MakeDataQLTC(dataQuanLyThuChi, out TonDau, out TonCuoi, out Thu, out Chi, false);
            Common.Report.LVReport report = new Common.Report.LVReport();
            string reportFile = AppDomain.CurrentDomain.BaseDirectory + PConstants.FOLDER_REPORT.TrimEnd('\\') + "\\BaoCaoThuChi.rpt";
            report.ShowReport(reportFile, "A4", true, "Báo cáo Thu Chi", PBean.MESSAGE_TITLE, data, true, false,
                "TonDau", PCommon.FormatNumber(TonDau.ToString()),
                "TonCuoi", PCommon.FormatNumber(TonCuoi.ToString()),
                "Thu", PCommon.FormatNumber(Thu.ToString()),
                "Chi", PCommon.FormatNumber(Chi.ToString()),
                "NgayBaoCao", NgayBaoCao);
        }
        DataTable MakeDataQLTC(List<view_ExpCashPay> ls, out int TonDau, out int TonCuoi, out int Thu, out int Chi, bool exportExcel)
        {
            if (ls.Count <= 0)
            {
                TonDau = 0;
                TonCuoi = 0;
                Thu = 0;
                Chi = 0;
                return new DataTable();
            }
            DataTable data = new DataTable();
            string refix = string.Empty;
            string empty = string.Empty;
            if (exportExcel == true)
            {
                refix = "'";
                empty = "'";
            }
            // Init dataTable
            data.Columns.Add("NGAY");
            data.Columns.Add("GIO");
            data.Columns.Add("LOAI");
            data.Columns.Add("NOI_DUNG");
            data.Columns.Add("SO_THU");
            data.Columns.Add("SO_CHI");
            data.Columns.Add("TON_QUY");
            data.Columns.Add("GHI_CHU");
            List<string> lsNgay = new List<string>();
            foreach (var item in ls)
            {
                DataRow dr = data.NewRow();
                string ngay = string.Format("{0:dd/MM/yyyy}", item.CreateDate);
                if (lsNgay.Exists(u => u == ngay))
                {
                    dr["NGAY"] = empty;
                }
                else
                {
                    dr["NGAY"] = refix + ngay;
                    lsNgay.Add(ngay);
                }

                dr["GIO"] = refix + string.Format("{0:HH:mm:ss}", item.CreateDate);
                dr["LOAI"] = item.TenLoai;

                dr["NOI_DUNG"] = item.Note;
                if (string.IsNullOrEmpty(item.Note))
                {
                    dr["NOI_DUNG"] = item.TenLoai + " " + item.TenNguoiNopNhan;
                }
                if (item.IsPay)
                {
                    // Chi tiền
                    if (item.Value <= 0)
                    {
                        dr["SO_THU"] = empty;
                        dr["SO_CHI"] = Math.Abs(item.Value).ToString();
                        if (exportExcel == false)
                        {
                            dr["SO_CHI"] = PCommon.FormatNumber(Math.Abs(item.Value).ToString());
                        }
                    }
                    else
                    {
                        dr["SO_CHI"] = empty;
                        dr["SO_THU"] = Math.Abs(item.Value).ToString();
                        if (exportExcel == false)
                        {
                            dr["SO_THU"] = PCommon.FormatNumber(Math.Abs(item.Value).ToString());
                        }
                    }

                }
                else
                {
                    // Thu tiền
                    if (item.Value >= 0)
                    {
                        dr["SO_THU"] = Math.Abs(item.Value).ToString();
                        dr["SO_CHI"] = empty;
                        if (exportExcel == false)
                        {
                            dr["SO_THU"] = PCommon.FormatNumber(Math.Abs(item.Value).ToString());
                        }
                    }
                    else
                    {
                        dr["SO_CHI"] = Math.Abs(item.Value).ToString();
                        dr["SO_THU"] = empty;
                        if (exportExcel == false)
                        {
                            dr["SO_CHI"] = PCommon.FormatNumber(Math.Abs(item.Value).ToString());
                        }
                    }
                }
                dr["TON_QUY"] = item.AfterTotalValue.ToString();
                if (exportExcel == false)
                {
                    dr["TON_QUY"] = PCommon.FormatNumber(item.AfterTotalValue.ToString());
                }
                dr["GHI_CHU"] = empty;
                data.Rows.Add(dr);
            }
            TonDau = ls[0].AfterTotalValue - ls[0].Value;
            TonCuoi = ls[ls.Count - 1].AfterTotalValue;
            Thu = ls.Where(u => u.IsPay == false && u.IsDelete == false).Sum(s => s.Value);
            Chi = ls.Where(u => u.IsPay == true && u.IsDelete == false).Sum(s => s.Value);
            return data;
        }

        private void btnQLTCExcel_Click(object sender, EventArgs e)
        {
            if (dataQuanLyThuChi.Count > 0)
            {

                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "BAO_CAO_THU_CHI_" + string.Format("{0:dd_MM}", dateQLTCFrom.Value) + "_DEN_" + string.Format("{0:dd_MM}", dateQLTCTo.Value);
                string NgayBaoCao = "Từ " + string.Format("{0:HH:mm:ss dd/MM/yyyy}", dateQLTCFrom.Value) + " đến " + string.Format("{0:HH:mm:ss dd/MM/yyyy}", dateQLTCTo.Value);
                save.Filter = "Excel Files | *.xlsx";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string templateFileName = AppDomain.CurrentDomain.BaseDirectory + "Templates\\BAO_CAO_THU_CHI.xlsx";
                    Dictionary<string, string> lsReplace = new Dictionary<string, string>();
                    Dictionary<string, string> lsTitile = new Dictionary<string, string>();
                    int TonDau;
                    int TonCuoi;
                    int Thu;
                    int Chi;
                    DataTable data = MakeDataQLTC(dataQuanLyThuChi, out TonDau, out TonCuoi, out Thu, out Chi, true);
                    lsReplace.Add("TON_DAU", TonDau.ToString());
                    lsReplace.Add("TON_CUOI", TonCuoi.ToString());
                    lsReplace.Add("THU", Thu.ToString());
                    lsReplace.Add("CHI", Chi.ToString());
                    lsReplace.Add("NGAY_BAO_CAO", NgayBaoCao);
                    ExportDataToExcelTemplate.Export(templateFileName, save.FileName, 1, data, lsTitile, lsReplace);
                    MessageBox.Show("Xuất file excel thành công!", PBean.MESSAGE_TITLE);
                }
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu vui lòng thực hiện truy vấn dữ liệu trước khi xuất Excel", PBean.MESSAGE_TITLE);
            }
        }

        private void btnThuTien_Click(object sender, EventArgs e)
        {
            frmNewPayCash frm = new frmNewPayCash();
            frm.IsPay = false;
            frm.ShowDialog();
            LoadCashList();
            FormatRowCash();
        }

        private void btnChiTien_Click(object sender, EventArgs e)
        {
            frmNewPayCash frm = new frmNewPayCash();
            frm.IsPay = true;
            frm.ShowDialog();
            LoadCashList();
            FormatRowCash();
        }
    }
}
