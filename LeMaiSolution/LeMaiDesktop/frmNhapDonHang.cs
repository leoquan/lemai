using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeMaiDomain;
using LeMaiLogic.Logic;
using Common;

namespace LeMaiDesktop
{
    public partial class frmNhapDonHang : Form
    {
        private bool isBusyNapDanhSach = false;
        private int count = 0;
        DataTable dataNapDanhSach = new DataTable();
        ExpBillCodeK11 _logic = new ExpBillCodeK11(PBean.ConnectionBase);
        private string MessageNapDanhSach = string.Empty;
        public frmNhapDonHang()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isBusyNapDanhSach)
            {
                MessageBox.Show("Có một tác vụ đang xử lý chưa kết thúc, vui lòng đợi!", PBean.MESSAGE_TITLE);
                return;
            }
            count = 0;
            dataNapDanhSach = GetBillDoiSoatExcelK10(txtFileName.Text);
            lblWaitCount.Text = dataNapDanhSach.Rows.Count.ToString();
            progressBar.Minimum = 0;
            progressBar.Maximum = dataNapDanhSach.Rows.Count;
            progressBar.Value = 0;
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Visible = true;
            isBusyNapDanhSach = true;
            backgroundWorker.RunWorkerAsync();
        }

        private void btnKetToanC1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Excel Files |*.xls";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = open.FileName;
                btnSave.Enabled = true;
            }
        }
        DataTable GetBillDoiSoatExcelK10(string fileName)
        {
            string[] froms = { "Số vận đơn", "Ngày giao hàng", "Ngày kí nhận", "Loại kiện", "Trọng lượng nhập đơn", "cân kho", "phương thức thanh toán", "Phí vận chuyển", "COD", "Số tiền người nhận thanh toán", "Bưu cục gửi", "Bưu cục gửi cấp 1", "người gửi", "Tỉnh gửi hàng", "Thành phố/Quận/Huyện gửi hàng", "Xã/Phường/Thị trấn gửi hàng",
            "Địa chỉ người gửi", "Điện thoại người gửi", "Người nhận", "Xã/Phường/Thị trấn nhận hàng", "Thành phố/Quận/Huyện nhận hàng", "Tỉnh nhận", "địa chỉ người nhận", "Điện thoại của người nhận", "Đã kết toán trả tiền hay chưa", "Có phải hàng hoàn", "Điểm đến"};
            string[] tos = { "BILL_CODE", "REGISTER_DATE", "SIGN_DATE", "LOAI_KIEN", "BILL_WEIGHT", "FEE_WEIGHT", "PAYMENT_TYPE_CODE", "FREIGHT", "GOODS_PAYMENT", "TOPAYMENT", "REGISTER_SITE_CODE", "SEND_SITE_CODE", "SEND_MAN", "SEND_PROVINCE_CODE", "SEND_CITY_CODE", "SEND_COUNTY_CODE",
            "SEND_MAN_ADDRESS", "SEND_MAN_PHONE", "ACCEPT_MAN", "ACCEPT_COUNTY_CODE", "ACCEPT_CITY_CODE", "ACCEPT_PROVINCE_CODE", "ACCEPT_MAN_ADDRESS", "ACCEPT_MAN_PHONE", "DONE_ACCOUNT_CODE", "IS_RETURN", "DES_SITE_NAME_LANG"};
            if (File.Exists(fileName))
            {
                DataSet ds = NPOIHelper.GetDataSetFromXls(fileName);
                DataTable data = ds.Tables[0];

                for (int i = 0; i < froms.Count(); i++)
                {
                    data.Columns[froms[i]].ColumnName = tos[i];
                }
                // Thêm column
                data.Columns.Add("STT", Type.GetType("System.String"));
                data.Columns.Add("LOAI_TT", Type.GetType("System.String"));
                data.Columns.Add("STATUS_NAME", Type.GetType("System.String"));
                data.Columns.Add("GIAO_HANG_TC", Type.GetType("System.String"));
                data.Columns.Add("K9_BALANCE", Type.GetType("System.String"));

                data.Columns.Add("CUSTOMER_CODE", Type.GetType("System.String"));
                data.Columns.Add("BANK_CODE", Type.GetType("System.String"));
                data.Columns.Add("CHU_THE", Type.GetType("System.String"));
                data.Columns.Add("BANK_NAME", Type.GetType("System.String"));
                data.Columns.Add("CHI_PHI", Type.GetType("System.String"));
                data.Columns.Add("EXPORT", Type.GetType("System.String"));
                data.Columns.Add("LOAI_KH", Type.GetType("System.String"));
                return data;
            }
            return new DataTable();
        }
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                int prioty = 0;
                foreach (DataRow item in dataNapDanhSach.Rows)
                {
                    ExpBILL bill = new ExpBILL();
                    bill.BILL_CODE = item["BILL_CODE"].ToString();
                    bill.SEND_SITE_CODE = item["SEND_SITE_CODE"].ToString();
                    bill.REGISTER_SITE_CODE = item["REGISTER_SITE_CODE"].ToString();
                    bill.SEND_MAN = item["SEND_MAN"].ToString();
                    bill.SEND_MAN_PHONE = item["SEND_MAN_PHONE"].ToString();
                    bill.SEND_MAN_ADDRESS = item["SEND_MAN_ADDRESS"].ToString();
                    bill.ACCEPT_MAN = item["ACCEPT_MAN"].ToString();
                    bill.ACCEPT_MAN_PHONE = item["ACCEPT_MAN_PHONE"].ToString();
                    bill.ACCEPT_MAN_ADDRESS = item["ACCEPT_MAN_ADDRESS"].ToString();
                    bill.ACCEPT_PROVINCE_CODE = item["ACCEPT_PROVINCE_CODE"].ToString();
                    bill.ACCEPT_CITY_CODE = item["ACCEPT_CITY_CODE"].ToString();
                    bill.ACCEPT_COUNTY_CODE = item["ACCEPT_COUNTY_CODE"].ToString();
                    bill.PAY_TYPE = item["PAYMENT_TYPE_CODE"].ToString();
                    bill.LAST_UPDATE_USER = item["Mã số khách hàng"].ToString();
                    bill.DES_SITE = item["DES_SITE_NAME_LANG"].ToString();
                    bill.Note = item["Ghi chú"].ToString();
                    // Convert number
                    decimal billWeght;
                    if (!decimal.TryParse(item["BILL_WEIGHT"].ToString(), out billWeght))
                    {
                        billWeght = 0;
                    }
                    bill.BILL_WEIGHT = billWeght;

                    decimal feeWeight;
                    if (!decimal.TryParse(item["FEE_WEIGHT"].ToString(), out feeWeight))
                    {
                        feeWeight = 0;
                    }
                    bill.FEE_WEIGHT = feeWeight;

                    decimal freight;
                    if (!decimal.TryParse(item["FREIGHT"].ToString(), out freight))
                    {
                        freight = 0;
                    }
                    bill.FREIGHT = freight;

                    decimal goodsPayment;
                    if (!decimal.TryParse(item["GOODS_PAYMENT"].ToString(), out goodsPayment))
                    {
                        goodsPayment = 0;
                    }
                    bill.GOODS_PAYMENT = goodsPayment;

                    if (string.IsNullOrEmpty(item["SIGN_DATE"].ToString()))
                    {
                        bill.IS_SIGNED = false;
                    }
                    else
                    {
                        bill.IS_SIGNED = true;
                        bill.SIGNED_DATE = Convert.ToDateTime(item["SIGN_DATE"].ToString());
                    }

                    if (item["IS_RETURN"].ToString() == "Không")
                    {
                        bill.IS_RETURN = false;
                    }
                    else
                    {
                        bill.IS_RETURN = true;
                    }
                    bill.REGISTER_DATE = Convert.ToDateTime(item["REGISTER_DATE"].ToString());
                    bill.WORKING_PRIOTY = prioty % 10;
                    prioty++;
                    _logic.InsertBill(bill, PBean.USER.CardId);
                    count++;
                    backgroundWorker.ReportProgress(0);
                }
            }
            catch (Exception ex)
            {
                MessageNapDanhSach = ex.ToString();
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.PerformStep();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Visible = false;
            isBusyNapDanhSach = false;
            if (string.IsNullOrEmpty(MessageNapDanhSach))
            {
                MessageBox.Show("Nạp mới danh sách thành công! Số đơn: " + count.ToString(), PBean.MESSAGE_TITLE);
            }
            else
            {
                MessageBox.Show(MessageNapDanhSach, PBean.MESSAGE_TITLE);
            }
        }
    }
}
