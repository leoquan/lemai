using LeMaiDomain;
using LeMaiLogic;
using Common;
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

namespace LeMaiDesktop
{
    public partial class frmNhapKetToan : Form
    {
        bool isBusy = false;
        DataTable dataChiTietNap = new DataTable();
        string message = string.Empty;
        string messageDup = string.Empty;
        public frmNhapKetToan()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataTable GetKTExcelK10(string fileName)
        {
            string[] froms = { "Mã đơn đặt", "Mã chi phí", "Thời gian kết toán", "Mã đại lí", "Số tiền" };
            string[] tos = { "BILL_CODE", "BALANCE_TYPE_CODE", "BALANCE_DATE", "SITE_CODE", "MONEY" };
            if (File.Exists(fileName))
            {
                DataTable data = ExportDataToExcelTemplate.ReadAsDataTableK10(fileName);
                for (int i = 0; i < froms.Count(); i++)
                {
                    data.Columns[froms[i]].ColumnName = tos[i];
                }
                return data;
            }
            return new DataTable();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isBusy)
            {
                MessageBox.Show("Đang nạp dữ liệu vui lòng đợi!", PBean.MESSAGE_TITLE);
                return;
            }
            if (MessageBox.Show("Kéo rộng cột mã đơn đặt sau đó lưu file lại trước khi chạy chương trình để được số liệu đúng", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                dataChiTietNap = GetKTExcelK10(txtFileChiTietKetToanC1.Text);
                progressBar.Maximum = dataChiTietNap.Rows.Count;
                lblWaitCount.Text = dataChiTietNap.Rows.Count.ToString();
                progressBar.Visible = true;
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void btnKetToanC1_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Excel Files |*.xlsx";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtFileChiTietKetToanC1.Text = open.FileName;
                btnSave.Enabled = true;
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            isBusy = true;
            IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
            try
            {
                dc.Open();
                int count = 0;
                int countNew = 0;
                DateTime curDate = dc.CurrentTime();
                foreach (DataRow item in dataChiTietNap.Rows)
                {
                    string mavandon = item["BILL_CODE"].ToString();
                    string MaDaiLy = item["SITE_CODE"].ToString();
                    string MaChiPhi = item["BALANCE_TYPE_CODE"].ToString();
                    string KeyThoiGianKetToan = item["BALANCE_DATE"].ToString();
                    string TenChiPhi = item["Tên chi phí"].ToString();
                    ExpBalanceDetailType typeDetail = dc.EXpbalancedetailtype.GetObjectCon(PBean.SCHEMA, "WHERE Id=@Id", "@Id", MaChiPhi);
                    if (typeDetail == null)
                    {
                        typeDetail = new ExpBalanceDetailType();
                        typeDetail.Id = MaChiPhi;
                        if (typeDetail.Id.Contains("-S"))
                        {
                            typeDetail.BalanceTypeName = TenChiPhi + "(-)";
                        }
                        else
                        {
                            typeDetail.BalanceTypeName = TenChiPhi + "(+)";
                        }

                        dc.EXpbalancedetailtype.InsertOnSubmit(PBean.SCHEMA, typeDetail);
                    }
                    decimal soDuTruoc;
                    if (!decimal.TryParse(item["Số dư trước"].ToString(), out soDuTruoc))
                    {
                        soDuTruoc = 0;
                    }
                    soDuTruoc = Math.Round(soDuTruoc, 1);
                    decimal soTien;
                    if (!decimal.TryParse(item["MONEY"].ToString(), out soTien))
                    {
                        soTien = 0;
                    }
                    decimal soDuSau;
                    if (!decimal.TryParse(item["Số dư sau"].ToString(), out soDuSau))
                    {
                        soDuSau = 0;
                    }
                    soDuSau = Math.Round(soDuSau, 1);
                    ExpBalanceDetail detail = dc.EXpbalancedetail.GetObjectCon(PBean.SCHEMA, "WHERE BILL_CODE=@BILL_CODE AND MaDaiLy=@MaDaiLy AND MaChiPhi=@MaChiPhi AND KeyThoiGianKetToan=@KeyThoiGianKetToan AND SoDuTruoc=@SoDuTruoc AND SoDuSau=@SoDuSau",
                        "@BILL_CODE", mavandon,
                        "@MaDaiLy", MaDaiLy,
                        "@MaChiPhi", MaChiPhi,
                        "@KeyThoiGianKetToan", KeyThoiGianKetToan,
                        "@SoDuTruoc", soDuTruoc,
                        "@SoDuSau", soDuSau);
                    if (detail == null)
                    {
                        detail = new ExpBalanceDetail();
                        detail.Id = Guid.NewGuid().ToString();
                        detail.BILL_CODE = mavandon;
                        detail.CapDoDaiLy = item["Cấp độ đại lý"].ToString();
                        detail.TrucThuocDaiLy = item["Trực thuộc đại lý"].ToString();
                        detail.ThoiGianDatHang = Convert.ToDateTime(item["Thời gian đặt hàng"].ToString());
                        detail.ThoiGianKetToan = Convert.ToDateTime(item["BALANCE_DATE"].ToString());
                        detail.KeyThoiGianKetToan = KeyThoiGianKetToan;
                        detail.MaDaiLy = MaDaiLy;
                        detail.TenDaiLy = item["Tên đại lý"].ToString();
                        detail.MaChiPhi = MaChiPhi;
                        detail.TenChiPhi = TenChiPhi;
                        detail.LoaiThu = item["Loại thu chi"].ToString();
                        detail.SoDuTruoc = soDuTruoc;
                        detail.SoTien = soTien;
                        detail.SoDuSau = soDuSau;
                        detail.LoaiTaiKhoan = item["Loại tài khoản"].ToString();

                        decimal trongLuong;
                        if (!decimal.TryParse(item["Trọng lượng thực tế"].ToString(), out trongLuong))
                        {
                            trongLuong = 0;
                        }
                        detail.TrongLuongThanhToan = trongLuong;
                        detail.SyncDate = curDate;
                        dc.EXpbalancedetail.InsertOnSubmit(PBean.SCHEMA, detail);
                        countNew++;
                    }
                    else
                    {
                        count++;
                    }
                    backgroundWorker.ReportProgress(0);
                }
                messageDup = "Đã tồn tại: " + count.ToString() + " - Dữ liệu mới: " + countNew.ToString();
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                message = ex.ToString();
            }
            finally
            {
                dc.Close();
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.PerformStep();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Visible = false;
            isBusy = false;
            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Nạp dữ liệu thành công", PBean.MESSAGE_TITLE);
            }
            else
            {
                MessageBox.Show(message, PBean.MESSAGE_TITLE);
            }
            MessageBox.Show(messageDup, PBean.MESSAGE_TITLE);
        }
    }
}
