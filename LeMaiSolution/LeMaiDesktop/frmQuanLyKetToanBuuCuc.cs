using Common;
using LeMaiDomain;
using LeMaiLogic;
using LeMaiLogic.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeMaiDesktop
{
    public partial class frmQuanLyKetToanBuuCuc : frmBase
    {
        BalanceDetailLogic _logic = new BalanceDetailLogic(PBean.ConnectionBase);
        private GExpBillLogic _logicbill = new GExpBillLogic(PBean.ConnectionBase);
        public frmQuanLyKetToanBuuCuc() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            dateFrom.Value = DateTime.Now.AddDays(-3);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.C))
            {
                try
                {
                    // Copy mã vận đơn
                    string lsMavanDon = string.Empty;
                    foreach (DataGridViewRow item in dataQLTCGrid.SelectedRows)
                    {
                        if (item.Cells["col_billCode"].Value != null)
                        {
                            lsMavanDon += item.Cells["col_billCode"].Value.ToString() + "@";
                        }
                    }
                    lsMavanDon = lsMavanDon.TrimEnd('@');
                    lsMavanDon = lsMavanDon.Replace("@", System.Environment.NewLine);
                    Clipboard.SetText(lsMavanDon);
                }
                catch (Exception)
                {
                }
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void LoadData(bool reload = false)
        {
            if (reload == true)
            {
                cmbLoaiKetToan.DataSource = await _logic.GetBalanceTypeList();
                cmbLoaiKetToan.DisplayMember = "TenLoai";
                cmbLoaiKetToan.ValueMember = "Id";
            }
        }
        private void frmQuanLyKetToan_Load(object sender, EventArgs e)
        {
            LoadData(true);
        }
        public async void LoadCashList()
        {
            dataQLTCGrid.AutoGenerateColumns = false;
            var list = await _logic.GetBalanDetailList(PBean.USER.CardId, txtFilter.Text.Trim(), cmbLoaiKetToan.SelectedValue.ToString(), dateFrom.Value, dateTo.Value);
            dataQLTCGrid.DataSource = list;
            dataQLTCGrid.ClearSelection();
            lblSoLuong.Text = list.Count.ToString();

            if (list.Count > 0)
            {
                btnExcel.Enabled = true;
            }
            else
            {
                btnExcel.Enabled = false;
            }
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
        private void btnTruyVan_Click(object sender, EventArgs e)
        {
            // Tuy vấn dữ liệu
            LoadCashList();
            FormatRowCash();
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            // Xuất file excel
            var list = await _logic.GetBalanDetailList(PBean.USER.CardId, txtFilter.Text.Trim(), cmbLoaiKetToan.SelectedValue.ToString(), dateFrom.Value, dateTo.Value);
            if (list.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "BCTC_" + string.Format("{0:dd_MM}", dateFrom.Value) + "_DEN_" + string.Format("{0:dd_MM}", dateTo.Value);
                string NgayBaoCao = "Từ " + string.Format("{0:HH:mm:ss dd/MM/yyyy}", dateFrom.Value) + " đến " + string.Format("{0:HH:mm:ss dd/MM/yyyy}", dateTo.Value);
                save.Filter = "Excel Files | *.xlsx";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string templateFileName = AppDomain.CurrentDomain.BaseDirectory + "Templates\\BAO_CAO_THU_CHI_KT.xlsx";
                    Dictionary<string, string> lsReplace = new Dictionary<string, string>();
                    Dictionary<string, string> lsTitile = new Dictionary<string, string>();
                    List<string> lsKeyString = new List<string>();
                    lsKeyString.Add("NgayS");
                    lsKeyString.Add("GioS");
                    lsReplace.Add("NGAY_BAO_CAO", NgayBaoCao);
                    DataTable data = MapperExtensionClass.ToDataTable(list);
                    ExportDataToExcelTemplate.Export(templateFileName, save.FileName, 1, data, lsTitile, lsReplace, true, lsKeyString);
                    MessageBox.Show("Xuất file excel thành công!", PBean.MESSAGE_TITLE);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu kết toán!", PBean.MESSAGE_TITLE);
            }
        }

        private async void dataQLTCGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tìm bill col_billCode
            // Tra cứu đơn hàng trên trang thứ 3
            try
            {
                int index = dataQLTCGrid.SelectedRows[0].Index;
                string billCode = Convert.ToString(dataQLTCGrid.Rows[index].Cells["col_billCode"].Value);
                view_GExpBill bill = await _logicbill.GetDetails(billCode);
                if (bill != null)
                {
                    frmTrackingAndProcess frm = PCommon.GetFormIsOpened("frmTrackingAndProcess") as frmTrackingAndProcess;
                    if (frm == null)
                    {
                        frm = new frmTrackingAndProcess();
                        frm.StartView(bill);
                        frm.Show();
                    }
                    else
                    {
                        frm.WindowState = FormWindowState.Maximized;
                        frm.StartView(bill);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
            }
        }
    }
}
