using Common;
using LeMaiDesktop.Models;
using LeMaiDomain;
using LeMaiLogic;
using LeMaiLogic.Logic;
using NPOI.SS.Formula.Functions;
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
    public partial class frmDoiSoatKhachHang : frmBase
    {
        DoiSoatKhachHangLogic _logic = new DoiSoatKhachHangLogic(PBean.ConnectionBase);
        string _IdDoiSoat = string.Empty;
        string _IdChiTiet = string.Empty;
        public frmDoiSoatKhachHang() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }

        private void btnTruyVanKyDoiSoat_Click(object sender, EventArgs e)
        {
            LoadDoiSoat(PBean.USER.CardId, dateFrom.Value, dateTo.Value);
        }
        void LoadDoiSoat(string post, DateTime from, DateTime to)
        {
            List<GExpDoiSoat> ls = _logic.GetDoiSoat(post, from, to);
            dataGridDoiSoatT.AutoGenerateColumns = false;
            dataGridDoiSoatT.DataSource = ls.ToList();
            lblThuHoT.Text = PCommon.FormatNumber(ls.Sum(u => u.ThuHo).ToString());
            lblThuHoKTT.Text = PCommon.FormatNumber(ls.Sum(u => u.ThuHoKT).ToString());
            lblPhiGuiTraT.Text = PCommon.FormatNumber(ls.Sum(u => u.CuocGuiTra).ToString());
            lblPhiNhanTraT.Text = PCommon.FormatNumber(ls.Sum(u => u.CuocNhanTra).ToString());
            lblChiPhiT.Text = PCommon.FormatNumber(ls.Sum(u => u.ChiPhi).ToString());
            lblLoiNhuanT.Text = PCommon.FormatNumber(ls.Sum(u => u.LoiNhuan).ToString());
            lblDoiSoatT.Text = PCommon.FormatNumber(ls.Sum(u => u.ThanhToanKH).ToString());
            lblThanhToanT.Text = PCommon.FormatNumber(ls.Sum(u => u.DaThanhToanKH).ToString());
        }

        private void btnHuyKyDoiSoat_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridDoiSoatT.SelectedRows[0].Index;
                string IdDoiSoat = Convert.ToString(dataGridDoiSoatT.Rows[index].Cells["col_IdDoiSoat"].Value);
                GExpDoiSoat doisoat = _logic.GetDoiSoatDetail(IdDoiSoat);
                if (doisoat != null)
                {
                    // Message box thông báo
                    if (doisoat.DaThanhToanKH > 0)
                    {
                        MessageBox.Show("Đợt đối soát đã chi tiền cho khách, không thể hủy!", PBean.MESSAGE_TITLE);
                    }
                    else
                    {
                        DialogResult res = MessageBox.Show("Bạn có muốn hủy bỏ đợt đối soát ngày [" + string.Format("{0:dd/MM/yyyy HH:mm}", doisoat.NgayDoiSoat) + "] không?!", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                        {
                            // Xóa đợt đối soát
                            _logic.DeleteDotDoiSoat(IdDoiSoat);
                            // Load lại danh sách đợt đối soát
                            LoadDoiSoat(PBean.USER.CardId, dateFrom.Value, dateTo.Value);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đợt đối soát cần hủy!", PBean.MESSAGE_TITLE);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private void dataGridDoiSoatT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dataGridDoiSoatT.SelectedRows[0].Index;
                string IdDoiSoat = Convert.ToString(dataGridDoiSoatT.Rows[index].Cells["col_IdDoiSoat"].Value);
                LoadDataChiTiet(IdDoiSoat);
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }
        void LoadDataChiTiet(string IdDoiSoat)
        {
            _IdDoiSoat = IdDoiSoat;
            GExpDoiSoat doisoat = new GExpDoiSoat();
            dataGridChiTiet.AutoGenerateColumns = false;
            dataGridChiTiet.DataSource = _logic.GetDoiSoatChiTiet(IdDoiSoat, out doisoat);
            if (doisoat.DaThanhToanKH == doisoat.ThanhToanKH)
            {
                btnChiTienTheoDanhSach.Enabled = false;
            }
            else
            {
                btnChiTienTheoDanhSach.Enabled = true;
            }
            lblThuHo.Text = PCommon.FormatNumber(doisoat.ThuHo.ToString());
            lblThuHoKT.Text = PCommon.FormatNumber(doisoat.ThuHoKT.ToString());
            lblPhiGuiTra.Text = PCommon.FormatNumber(doisoat.CuocGuiTra.ToString());
            lblPhiNhanTra.Text = PCommon.FormatNumber(doisoat.CuocNhanTra.ToString());
            lblChiPhi.Text = PCommon.FormatNumber(doisoat.ChiPhi.ToString());
            lblLoiNhuan.Text = PCommon.FormatNumber(doisoat.LoiNhuan.ToString());
            lblDoiSoat.Text = PCommon.FormatNumber(doisoat.ThanhToanKH.ToString());
            lblThanhToan.Text = PCommon.FormatNumber(doisoat.DaThanhToanKH.ToString());

            tabControlChiTienDoiSoatKH.SelectedTab = tabChiTiet;
        }
        void LoadDataChiTietCt(string IdChiTiet)
        {
            _IdChiTiet = IdChiTiet;
            GExpDoiSoatChiTiet chitiet = new GExpDoiSoatChiTiet();
            dataGridChiTietCt.AutoGenerateColumns = false;
            dataGridChiTietCt.DataSource = _logic.GetDoiSoatChiTietCt(IdChiTiet, out chitiet);

            lblThuHoct.Text = PCommon.FormatNumber(chitiet.ThuHo.ToString());
            lblThuHoKTct.Text = PCommon.FormatNumber(chitiet.ThuHoKT.ToString());
            lblPhiGuiTract.Text = PCommon.FormatNumber(chitiet.CuocGuiTra.ToString());
            lblPhiNhanTract.Text = PCommon.FormatNumber(chitiet.CuocNhanTra.ToString());
            lblChiPhict.Text = PCommon.FormatNumber(chitiet.ChiPhi.ToString());
            lblLoiNhuanct.Text = PCommon.FormatNumber(chitiet.LoiNhuan.ToString());
            lblDoiSoatct.Text = PCommon.FormatNumber(chitiet.ThanhToanKH.ToString());
            lblThanhToanct.Text = PCommon.FormatNumber(chitiet.DaThanhToanKH.ToString());
            if (chitiet.DaThanhToanKH > 0)
            {
                btnChiTienKhachHang.Enabled = false;
            }
            else
            {
                btnChiTienKhachHang.Enabled = true;
            }
            tabControlChiTienDoiSoatKH.SelectedTab = tabChiTietCt;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridChiTiet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dataGridChiTiet.SelectedRows[0].Index;
                string IdChiTiet = Convert.ToString(dataGridChiTiet.Rows[index].Cells["col_IdChiTiet"].Value);
                LoadDataChiTietCt(IdChiTiet);

            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private void frmDoiSoatKhachHang_Load(object sender, EventArgs e)
        {
            dateFrom.Value = DateTime.Now.AddDays(-30);
            dateTo.Value = DateTime.Now;

            cmbCustomerKl.DataSource = _logic.GetCustomerListKL(PBean.USER.CardId);
            cmbCustomerKl.DisplayMember = "CustomerName";
            cmbCustomerKl.ValueMember = "CustomerPhone";
            LoadDoiSoat(PBean.USER.CardId, dateFrom.Value, dateTo.Value);
        }

        private void btnLoadChiTietKL_Click(object sender, EventArgs e)
        {
            if (cmbCustomerKl.SelectedValue != null)
            {
                List<view_GExpDoiSoatChiTiet> ls = _logic.GetDoiSoatChiTietKL(cmbCustomerKl.SelectedValue.ToString());
                dataGridChiTietKL.AutoGenerateColumns = false;
                dataGridChiTietKL.DataSource = ls;
                decimal sumDoiSoat = ls.Sum(u => u.ThanhToanKH);
                decimal sumThanhToan = ls.Sum(u => u.DaThanhToanKH);
                lblThuHoKL.Text = PCommon.FormatNumber(ls.Sum(u => u.ThuHo).ToString());
                lblThuHoKTKL.Text = PCommon.FormatNumber(ls.Sum(u => u.ThuHoKT).ToString());
                lblPhiGuiTraKL.Text = PCommon.FormatNumber(ls.Sum(u => u.CuocGuiTra).ToString());
                lblPhiNhanTraKL.Text = PCommon.FormatNumber(ls.Sum(u => u.CuocNhanTra).ToString());
                lblChiPhiKL.Text = PCommon.FormatNumber(ls.Sum(u => u.ChiPhi).ToString());
                lblLoiNhuanKL.Text = PCommon.FormatNumber(ls.Sum(u => u.LoiNhuan).ToString());
                lblDoiSoatKL.Text = PCommon.FormatNumber(sumDoiSoat.ToString());
                lblThanhToanKL.Text = PCommon.FormatNumber(sumThanhToan.ToString());
                if (sumDoiSoat > sumThanhToan)
                {
                    btnChiTienKhachLe.Enabled = true;
                }
                else
                {
                    btnChiTienKhachLe.Enabled = false;
                }
            }
        }

        private void btnChiTienKhachLe_Click(object sender, EventArgs e)
        {
            // Chi tiền khách lẻ
            string id = string.Empty;
            for (int i = 0; i < dataGridChiTietKL.Rows.Count; i++)
            {
                string IdChiTiet = Convert.ToString(dataGridChiTietKL.Rows[i].Cells["col_IdChiTietKL"].Value);
                id = id + IdChiTiet + ";";
                id = id.TrimEnd(';');
                id = id.Trim();
                frmChiDoiSoat frm = new frmChiDoiSoat();
                frm.IdDoiSoatChiTiet = id;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadDoiSoat(PBean.USER.CardId, dateFrom.Value, dateTo.Value);
                }
            }
        }

        private void btnExcelDoiSoatKL_Click(object sender, EventArgs e)
        {
            // Xuất file
            List<view_GExpDoiSoatChiTiet> ls = _logic.GetDoiSoatChiTietKL(cmbCustomerKl.SelectedValue.ToString());
            if (ls.Count > 0)
            {
                ls = ls.OrderBy(u => u.NgayDoiSoat).ToList();
                DateTime ngayDoiSoat = ls[0].NgayDoiSoat;
                string tenKH = ls[0].TenKhachHang;
                string soDT = ls[0].SoDienThoai;
                XuatFileDoiSoat(ls, ngayDoiSoat, tenKH, soDT);
            }
        }
        void XuatFileDoiSoat(List<view_GExpDoiSoatChiTiet> lsDoiSoatChiTiet, DateTime lastDate, string tenKH, string sdtKH)
        {
            try
            {
                string templateKhachHang = AppDomain.CurrentDomain.BaseDirectory + "Templates\\MAU_DOI_SOAT.xlsx";
                List<string> lsKeyString = new List<string>();

                DataTable data = new DataTable();
                //Init Table
                data.Columns.Add("BILL_CODE");
                data.Columns.Add("SEND_MAN");
                data.Columns.Add("ACCEPT_MAN");
                data.Columns.Add("ACCEPT_MAN_PHONE");
                data.Columns.Add("REGISTER_DATE");
                data.Columns.Add("SIGN_DATE");
                data.Columns.Add("ACCEPT_PROVINCE_CODE");
                data.Columns.Add("BILL_WEIGHT");
                data.Columns.Add("GOODS_PAYMENT");
                data.Columns.Add("FREIGHT");
                data.Columns.Add("LOAI_TT");
                data.Columns.Add("LOAI_KIEN");
                data.Columns.Add("CHI_PHI");
                data.Columns.Add("STATUS_NAME");
                foreach (var chiTiet in lsDoiSoatChiTiet)
                {
                    List<GExpDoiSoatChiTietCt> lsDoiSoatCt = _logic.GetDoiSoatChiTietCt(chiTiet.Id);
                    foreach (var item in lsDoiSoatCt)
                    {
                        DataRow dr = data.NewRow();
                        dr["BILL_CODE"] = item.BillCode;
                        dr["SEND_MAN"] = item.NguoiGui;
                        dr["ACCEPT_MAN"] = item.NguoiNhan;
                        dr["ACCEPT_MAN_PHONE"] = item.SoDienThoai;
                        dr["REGISTER_DATE"] = item.NgayGuiHang;
                        dr["SIGN_DATE"] = item.NgayKyNhan;
                        dr["ACCEPT_PROVINCE_CODE"] = item.NoiDen;
                        dr["BILL_WEIGHT"] = item.TrongLuong;
                        dr["GOODS_PAYMENT"] = item.ThuHo;
                        dr["FREIGHT"] = item.CuocVanChuyen;
                        dr["LOAI_TT"] = item.LoaiThanhToan;
                        dr["LOAI_KIEN"] = item.LoaiKien;
                        dr["CHI_PHI"] = item.SoTienThanhToan;
                        dr["STATUS_NAME"] = item.GhiChu;
                        data.Rows.Add(dr);
                    }
                }
                Dictionary<string, string> lsReplace = new Dictionary<string, string>();
                Dictionary<string, string> lsTitile = new Dictionary<string, string>();

                lsReplace.Add("TEN_KH", tenKH);
                lsReplace.Add("SDT_KH", "'" + sdtKH);
                lsReplace.Add("NGAY_DS", "ĐƠN HÀNG ĐÃ KÝ NHẬN ĐẾN NGÀY " + String.Format("{0:dd/MM/yyyy}", lastDate));
                lsReplace.Add("SUM_COD", PCommon.FormatNumber(lsDoiSoatChiTiet.Sum(u => u.ThuHo).ToString()));
                lsReplace.Add("SUM_FEE", PCommon.FormatNumber(lsDoiSoatChiTiet.Sum(u => u.CuocGuiTra).ToString()));
                lsReplace.Add("SUM_PAY", PCommon.FormatNumber(lsDoiSoatChiTiet.Sum(u => u.ThanhToanKH).ToString()));
                // Xuất file khách hàng
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Excel Files |*.xlsx";
                save.FileName = PCommon.RemoveSpecialCharacters(PCommon.UnSigns(tenKH));
                if (save.ShowDialog() == DialogResult.OK)
                {
                    ExportDataToExcelTemplate.Export(templateKhachHang, save.FileName, 1, data, lsTitile, lsReplace, true);
                    MessageBox.Show("Xuất file thành công!", PBean.MESSAGE_TITLE);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
            }
        }

        private async void btnChiTienTheoDanhSach_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Excel Files |00.TONG_HOP*.xlsx";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Dictionary<string, decimal> lsThanhToan = new Dictionary<string, decimal>();
                DataTable data = ExportDataToExcelTemplate.ReadAsDataTableK10(open.FileName);
                // đọc theo Code
                foreach (DataRow item in data.Rows)
                {
                    string Code = item["Code"].ToString();
                    string DaThanhToan = item["Đã thanh toán"].ToString();
                    if (string.IsNullOrEmpty(Code) == false)
                    {
                        decimal soTien;
                        if (!decimal.TryParse(DaThanhToan, out soTien))
                        {
                            soTien = 0;
                        }
                        lsThanhToan.Add(Code, soTien);
                    }
                }
                // 
                string message = await _logic.ThanhToanTheoFile(_IdDoiSoat, lsThanhToan, PBean.USER.CardId, PBean.USER.Id);
                if (string.IsNullOrEmpty(message) == false)
                {
                    MessageBox.Show(message, PBean.MESSAGE_TITLE);
                }
                else
                {
                    MessageBox.Show("Hoàn thành chi tiền đối soát cho khách", PBean.MESSAGE_TITLE);
                    LoadDoiSoat(PBean.USER.CardId, dateFrom.Value, dateTo.Value);
                }
            }
            else
            {
                return;
            }
        }

        private void btnExcelDoiSoatKH_Click(object sender, EventArgs e)
        {
            // Xuất file đối soát khách hàng
            string id = "'" + _IdChiTiet.Trim('\'') + "'";
            List<view_GExpDoiSoatChiTiet> ls = _logic.GetDoiSoatChiTietByIds(id);
            if (ls.Count > 0)
            {
                ls = ls.OrderBy(u => u.NgayDoiSoat).ToList();
                DateTime ngayDoiSoat = ls[0].NgayDoiSoat;
                string tenKH = ls[0].TenKhachHang;
                string soDT = ls[0].SoDienThoai;
                XuatFileDoiSoat(ls, ngayDoiSoat, tenKH, soDT);
            }
        }

        private void btnTaoMoiKyDoiSoat_Click(object sender, EventArgs e)
        {
            DialogResult digrs = MessageBox.Show("Bạn có chắc tạo mới đợt đối soát khách hàng?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo);
            if (digrs == DialogResult.Yes)
            {
                string errorMsg = string.Empty;
                GExpDoiSoat doisoat = _logic.CreateDoiSoat(PBean.USER.CardId, PBean.USER.Id, PBean.USER.FullName, out errorMsg);
                if (doisoat != null)
                {
                    LoadDoiSoat(PBean.USER.CardId, dateFrom.Value, dateTo.Value);
                }
                else
                {
                    MessageBox.Show(errorMsg, PBean.MESSAGE_TITLE);
                }

            }
        }

        private void btnExcelDoiSoat_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridDoiSoatT.SelectedRows[0].Index;
                string IdDoiSoat = Convert.ToString(dataGridDoiSoatT.Rows[index].Cells["col_IdDoiSoat"].Value);
                GExpDoiSoat doisoat = _logic.GetDoiSoatDetail(IdDoiSoat);
                List<view_GExpDoiSoatChiTiet> lsChiTiet = _logic.GetDoiSoatChiTietById(IdDoiSoat);
                if (doisoat != null)
                {
                    try
                    {
                        FolderBrowserDialog folder = new FolderBrowserDialog();
                        if (folder.ShowDialog() == DialogResult.OK)
                        {
                            DateTime date = DateTime.Now;
                            string nameFolder = "NGAY " + string.Format("{0:dd.MM.yy (HH.mm)}", date);

                            string rootFolder = folder.SelectedPath;
                            string finaceFolder = rootFolder.TrimEnd('\\') + "\\" + nameFolder + "\\" + "KHACH_HANG";
                            if (!Directory.Exists(finaceFolder))
                            {
                                Directory.CreateDirectory(finaceFolder);
                            }
                            string templateKhachHang = AppDomain.CurrentDomain.BaseDirectory + "Templates\\LM_DOI_SOAT.xlsx";
                            string templateTongHop = AppDomain.CurrentDomain.BaseDirectory + "Templates\\LM_DOI_SOAT_SUM.xlsx";
                            string templateBank = AppDomain.CurrentDomain.BaseDirectory + "Templates\\LM_BANK.xlsx";
                            string templateReset = AppDomain.CurrentDomain.BaseDirectory + "Templates\\LM_RESET.xlsx";
                            Dictionary<string, string> lsRe = new Dictionary<string, string>();
                            Dictionary<string, string> lsTi = new Dictionary<string, string>();
                            List<string> lsKeys = new List<string>();

                            List<BankItem> bankItems = new List<BankItem>();
                            int rownum = 0;
                            foreach (var chitiet in lsChiTiet)
                            {
                                if (chitiet.ThanhToanKH > 0)
                                {
                                    BankItem bankItem = new BankItem();
                                    rownum++;
                                    bankItem.NumRow = rownum;
                                    bankItem.BankName = chitiet.BankName;
                                    bankItem.AccountName = PCommon.ConvertToUnSign(chitiet.AccountName).ToUpper();
                                    bankItem.AccountCode = chitiet.AccountCode;
                                    bankItem.Amount = (int)chitiet.ThanhToanKH;
                                    bankItem.Remark = "THANH TOAN COD KHACH HANG";
                                    bankItem.BankCode = chitiet.BankId.GetValueOrDefault(0);
                                    bankItems.Add(bankItem);
                                }
                                List<GExpDoiSoatChiTietCt> lsChiTietCt = _logic.GetDoiSoatChiTietCt(chitiet.Id);

                                Dictionary<string, string> lsReplace = new Dictionary<string, string>();
                                lsReplace.Add("CUSTOMER_CODE", "'" + chitiet.CustomerCode);
                                lsReplace.Add("CUSTOMER_NAME", chitiet.TenKhachHang);
                                lsReplace.Add("CUSTOMER_PHONE", "'" + chitiet.SoDienThoai);

                                lsReplace.Add("ACCOUNT_CODE", "'" + chitiet.AccountCode);
                                lsReplace.Add("ACCOUNT_NAME", "'" + chitiet.AccountName);
                                lsReplace.Add("BANK_NAME", "'" + chitiet.BankName);

                                lsReplace.Add("SUM_COD", chitiet.ThuHo.ToString());
                                lsReplace.Add("SUM_FEE", chitiet.CuocGuiTra.ToString());
                                lsReplace.Add("SUM_PAY", chitiet.ThanhToanKH.ToString());


                                Dictionary<string, string> lsTitile = new Dictionary<string, string>();
                                List<string> lsKeyString = new List<string>();
                                lsKeyString.Add("BillCode");
                                lsKeyString.Add("SoDienThoai");
                                lsKeyString.Add("NgayGuiHang");
                                lsKeyString.Add("NgayKyNhan");
                                lsReplace.Add("NGAY_DS", "ĐƠN HÀNG ĐÃ KÝ NHẬN ĐẾN NGÀY " + String.Format("{0:dd/MM/yyyy}", DateTime.Now));

                                string fileName = PCommon.UnSigns(chitiet.TenKhachHang.Replace(" ", "_").Replace(":", "").Replace(",", "").Replace("'", "")).ToUpper() + "_" + chitiet.SoDienThoai.Replace(" ", "");
                                fileName = PCommon.RemoveSpecialCharacters(fileName);
                                ExportDataToExcelTemplate.Export(templateKhachHang, finaceFolder + "\\" + fileName + ".xlsx", 1, MapperExtensionClass.ToDataTable(lsChiTietCt), lsTitile, lsReplace, true, lsKeyString);

                            }
                            // XUẤT FILE TỔNG HỢP
                            lsRe.Add("SUM_COUNT", doisoat.SoLuongDon.ToString());
                            lsRe.Add("SUM_COD", doisoat.ThuHo.ToString());
                            lsRe.Add("SUM_COD_KT", doisoat.ThuHoKT.ToString());
                            lsRe.Add("SUM_SAI_LECH", doisoat.SaiLech.ToString());
                            lsRe.Add("SUM_CUOC_GUI", doisoat.CuocGuiTra.ToString());
                            lsRe.Add("SUM_CUOC_NHAN", doisoat.CuocNhanTra.ToString());
                            lsRe.Add("SUM_CHI_PHI", doisoat.ChiPhi.ToString());
                            lsRe.Add("SUM_LOI_NHUAN", doisoat.LoiNhuan.ToString());
                            lsRe.Add("SUM_THANH_TOAN", doisoat.ThanhToanKH.ToString());
                            // Xuất file Bank
                            ExportDataToExcelTemplate.Export(templateTongHop, rootFolder.TrimEnd('\\') + "\\" + nameFolder + "\\00.TONG_HOP_" + string.Format("{0:dd.MM.yy}", date) + ".xlsx", 1, MapperExtensionClass.ToDataTable(lsChiTiet), lsTi, lsRe, true, lsKeys);
                            List<GExpDoiSoatChiTietCt> list = _logic.GetAllDoiSoatChiTietCt(IdDoiSoat);
                            ExportDataToExcelTemplate.Export(templateReset, rootFolder.TrimEnd('\\') + "\\" + nameFolder + "\\01.RESET_" + string.Format("{0:dd.MM.yy}", date) + ".xlsx", 1, MapperExtensionClass.ToDataTable(list), lsTi, lsRe, true, lsKeys);
                            lsKeys = new List<string>();
                            lsKeys.Add("AccountCode");
                            ExportDataToExcelTemplate.Export(templateBank, rootFolder.TrimEnd('\\') + "\\" + nameFolder + "\\02.BANK_" + string.Format("{0:dd.MM.yy}", date) + ".xlsx", 1, MapperExtensionClass.ToDataTable(bankItems), lsTi, lsRe, false, lsKeys);

                            MessageBox.Show("Kết xuất dữ liệu khách hàng hoàn tất", PBean.MESSAGE_TITLE);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đợt đối soát cần xuất dữ liệu!", PBean.MESSAGE_TITLE);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private void btnChuyenKhoanChinhCOD_Click(object sender, EventArgs e)
        {
            frmChuyenKhoanCOD frm = new frmChuyenKhoanCOD();
            frm.ShowDialog();
        }

        private void btnNhapDonDaDoiSoat_Click(object sender, EventArgs e)
        {
            frmNhapDonDoiSoat frm = new frmNhapDonDoiSoat();
            frm.ShowDialog();
        }
    }
}
