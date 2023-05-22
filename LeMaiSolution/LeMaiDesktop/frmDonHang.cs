using LeMaiDomain;
using LeMaiLogic;
using LeMaiLogic.Logic;
using Common;
using DevComponents.DotNetBar.SuperGrid;
using PresentationControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace LeMaiDesktop
{
    public partial class frmDonHang : frmBase
    {
        SoundPlayer SoundSuccess = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "success.wav");
        SoundPlayer SoundFailure = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "error.wav");
        SoundPlayer SoundExist = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "ding.wav");

        DataTable dataHangGui = new DataTable();
        DataTable dataKhachLe = new DataTable();
        DataTable dataKhachLeResult = new DataTable();
        DataTable dataLoiNhuan = new DataTable();
        DataTable dataDoiSoat = new DataTable();
        DataTable dataDoiSoatTemp = new DataTable();
        DataTable dataNinja = new DataTable();
        DataTable dataNinjaTemp = new DataTable();
        decimal TongCODNinJa = 0;
        DataTable dataHangTrongLuong = new DataTable();
        DataTable dataKQTrongLuong = new DataTable();
        List<view_ExpCashPay> dataQuanLyThuChi = new List<view_ExpCashPay>();

        List<ExpBalanceDetail> lsInputCheckErrorBalanceDetail = new List<ExpBalanceDetail>();
        List<ExpBalanceDetail> lsError = new List<ExpBalanceDetail>();

        decimal TongCODKL = 0;
        decimal TongPhiNhanTraKL = 0;
        decimal TongPhiGuiTraKL = 0;


        int ThamSoChenhLech = 0;
        int weightSoDonLech = 0;
        double weightTongChenhLech = 0;

        string manhanvienShipper = string.Empty;


        DataSet datasetBill = new DataSet();

        List<string> DiDonHangS = new List<string>();
        List<string> DiDonHangT = new List<string>();
        List<string> DiDonHangI = new List<string>();

        string maBuuCucGui = string.Empty;

        decimal TongTienCOD = 0;
        decimal TongTienSHIP = 0;
        decimal TongTienPHI = 0;
        double TongDon = 0;
        double TongKyNhan = 0;
        double TongHoanTra = 0;
        decimal TongTienHoanTra = 0;
        bool MienPhiHoan100 = false;

        decimal TongCODDoiSoat = 0;
        decimal TongCODDoiSoatKT = 0;
        decimal TongPhiVanChuyenDoiSoatKT = 0;
        decimal TongPhiVanChuyenDoiSoat = 0;
        decimal TongPhiVanChuyenDoiSoatGuiTra = 0;
        decimal TongTienDoiSoat = 0;
        decimal TongTienTamUng = 0;
        int TongSoLuongDoiSoat = 0;
        int TongKyNhanDoiSoat = 0;
        int TongHoanDoiSoat = 0;
        int TongDaDoiSoat = 0;
        int TongTamUngDoiSoat = 0;
        int TongChuaDoiSoat = 0;

        List<ExpCustomer> lsMaKhachHang = new List<ExpCustomer>();

        List<string> lsLowProcess = new List<string>();
        List<string> lsContact = new List<string>();

        DataTable dtReportAllData = new DataTable();
        DataTable dtReportDetailData = new DataTable();

        DataTable dtQuanLyDonHang = new DataTable();

        bool isBusyHangDi = false;
        bool isBusyDoiSoat = false;
        bool isBusyLoiNhuan = false;
        bool isBusyKhachLe = false;
        bool isBusyCheckKT = false;

        int DiTreoDon = 0;
        int DiHoanTra = 0;
        int DiKhuVucCham = 0;
        int DiChamThaoTac = 0;
        int DiSaiLechKg = 0;
        int DiGiaoChuaKy = 0;

        List<ExpBalanceDetailTypeExt> lsTypeCodeExt = new List<ExpBalanceDetailTypeExt>();

        List<ExpBalanceDetail> lsChiTietKetToan = new List<ExpBalanceDetail>();


        private ExpConsignmentV2Logic _logic = new ExpConsignmentV2Logic(PBean.ConnectionBase);
        private ExpBillCodeK11 _logicBill = new ExpBillCodeK11(PBean.ConnectionBase);
        private ExpChungTuLogic _logicChungTu = new ExpChungTuLogic(PBean.ConnectionBase);

        string _IdDoiSoat = string.Empty;
        string _IdChiTiet = string.Empty;
        private ExpDoiSoatLogic _logicDoiSoat = new ExpDoiSoatLogic(PBean.ConnectionBase);

        public frmDonHang() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            CreateColumn();
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
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == (Keys.Control | Keys.C))
            {
                try
                {

                    if (ActiveControl == dataGridViewDi)
                    {
                        string lsMavanDon = string.Empty;
                        foreach (DataGridViewRow item in dataGridViewDi.SelectedRows)
                        {
                            lsMavanDon += item.Cells["col_MaVanDon"].Value.ToString() + System.Environment.NewLine;
                        }
                        Clipboard.SetText(lsMavanDon);
                    }
                    else if (ActiveControl == dataGridTime)
                    {
                        string lsMavanDon = string.Empty;
                        foreach (DataGridViewRow item in dataGridTime.SelectedRows)
                        {
                            string mvd = item.Cells["col_BillCode"].Value.ToString();
                            if (!lsMavanDon.Contains(mvd))
                            {
                                lsMavanDon += mvd + System.Environment.NewLine;
                            }
                        }
                        Clipboard.SetText(lsMavanDon);
                    }
                    else if (ActiveControl == dataGridChiTietCt)
                    {
                        string lsMavanDon = string.Empty;
                        foreach (DataGridViewRow item in dataGridChiTietCt.SelectedRows)
                        {
                            lsMavanDon += item.Cells["col_BILL_CODE"].Value.ToString() + System.Environment.NewLine;
                        }
                        Clipboard.SetText(lsMavanDon);
                    }
                }
                catch (Exception ex)
                {
                    log.Error(ex.ToString());
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private async void frmDonHangK9_Load(object sender, EventArgs e)
        {
            this.Text = "ĐƠN HÀNG K10 - " + PBean.USER.FullName;
            // Load Customer
            cmbCustomer.DataSource = _logic.GetCustomerList(PBean.USER.CardId);
            cmbCustomer.DisplayMember = "CustomerName";
            cmbCustomer.ValueMember = "CustomerPhone";

            DataTable dataListLoaiChiPhi = MapperExtensionClass.ToDataTable(_logic.GetBalanceTypeList());

            cmbMultiLoaiChiPhi.DataSource =
                new ListSelectionWrapper<DataRow>(
                    dataListLoaiChiPhi.Rows,
                    "BalanceTypeName"
                    );
            cmbMultiLoaiChiPhi.DisplayMemberSingleItem = "Name";
            cmbMultiLoaiChiPhi.DisplayMember = "NameConcatenated";
            cmbMultiLoaiChiPhi.ValueMember = "Selected";

            DataTable dataListStatus = MapperExtensionClass.ToDataTable(_logic.GetBillStatusNotAll());

            cmbProcessTypeMulti.DataSource =
                new ListSelectionWrapper<DataRow>(
                    dataListStatus.Rows,
                    "StatusName"
                    );
            cmbProcessTypeMulti.DisplayMemberSingleItem = "Name";
            cmbProcessTypeMulti.DisplayMember = "NameConcatenated";
            cmbProcessTypeMulti.ValueMember = "Selected";
            try
            {
                cmbProcessTypeMulti.CheckBoxItems["-"].Checked = true;
                cmbProcessTypeMulti.CheckBoxItems["Đơn ảo"].Checked = true;
                cmbProcessTypeMulti.CheckBoxItems["Đang trung chuyển"].Checked = true;
                cmbProcessTypeMulti.CheckBoxItems["Đang giao"].Checked = true;
                cmbProcessTypeMulti.CheckBoxItems["Có kiện vấn đề"].Checked = true;
                cmbProcessTypeMulti.CheckBoxItems["Đang hoàn"].Checked = true;
            }
            catch
            {
            }
            


            DataTable dataListKH = MapperExtensionClass.ToDataTable(_logic.GetCustomerListNotAll(PBean.USER.CardId));

            cmbMultiKhachHang.DataSource =
                new ListSelectionWrapper<DataRow>(
                    dataListKH.Rows,
                    "CustomerName"
                    );
            cmbMultiKhachHang.DisplayMemberSingleItem = "Name";
            cmbMultiKhachHang.DisplayMember = "NameConcatenated";
            cmbMultiKhachHang.ValueMember = "Selected";

            // SELECT POPULAR

            cmbTinh.DataSource = _logic.GetListProvinceFee(); ;
            cmbTinh.ValueMember = "FeeID";
            cmbTinh.DisplayMember = "ProvineName";


            cmbGiaCuoc.DataSource = _logic.GetListProvinceFeeCustomer(); ;
            cmbGiaCuoc.ValueMember = "Id";
            cmbGiaCuoc.DisplayMember = "Name";

            cmbCustomerDi.DataSource = _logic.GetCustomerListSend(PBean.USER.CardId);
            cmbCustomerDi.DisplayMember = "CustomerName";
            cmbCustomerDi.ValueMember = "Id";

            if (!string.IsNullOrEmpty(PBean.USER.companyid))
            {
                LoadCashList();
                cmbQLTCLoai.DataSource = await _logic.GetMasterCashPayTypeList();
                cmbQLTCLoai.DisplayMember = "TenLoai";
                cmbQLTCLoai.ValueMember = "Id";
            }
            dateQLTCFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            dateQLTCTo.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);

            cmbKyChungTu.DataSource = _logicChungTu.GetKyKetToan();
            cmbKyChungTu.DisplayMember = "TenKy";
            cmbKyChungTu.ValueMember = "Id";

            cmbKyKetToanPhatHanh.DataSource = _logicChungTu.GetKyKetToanAndAll();
            cmbKyKetToanPhatHanh.DisplayMember = "TenKy";
            cmbKyKetToanPhatHanh.ValueMember = "Id";

            cmbKyKetToanKL.DataSource = _logicChungTu.GetKyKetToan();
            cmbKyKetToanKL.DisplayMember = "TenKy";
            cmbKyKetToanKL.ValueMember = "Id";

            cmbTaiKhoan.DataSource = await _logic.GetListExpPost(PBean.USER.IdAccountIntro);
            cmbTaiKhoan.DisplayMember = "TenDaiLy";
            cmbTaiKhoan.ValueMember = "Id";
            cmbTaiKhoan.SelectedValue = PBean.USER.CardId;

            cmbKyRutTienFrom.DataSource = await _logic.GetListBalanceRutCOD(cmbTaiKhoan.SelectedValue.ToString());
            cmbKyRutTienFrom.ValueMember = "ThoiGianKetToan";
            cmbKyRutTienFrom.DisplayMember = "KeyThoiGianKetToan";

            cmbKyRutTienTo.DataSource = await _logic.GetListBalanceRutCOD(cmbTaiKhoan.SelectedValue.ToString());
            cmbKyRutTienTo.ValueMember = "ThoiGianKetToan";
            cmbKyRutTienTo.DisplayMember = "KeyThoiGianKetToan";

            LoadDataDoiSoat();

            LoadDataBangKeo();
        }
        private void txtFilterHangGuiDi_TextChanged(object sender, EventArgs e)
        {
            if (dataHangGui.Rows.Count > 0)
            {
                if (string.IsNullOrEmpty(txtFilterHangGuiDi.Text.Trim()))
                {
                    lblWaitCount.Text = dataHangGui.Rows.Count.ToString();
                    dataGridViewDi.AutoGenerateColumns = false;
                    dataGridViewDi.DataSource = dataHangGui;
                    FormatRowDonHang();
                }
                else
                {
                    // Filter
                    string keyFilter = txtFilterHangGuiDi.Text.Trim();
                    DataRow[] drRow = dataHangGui.Select("BILL_CODE='" + keyFilter + "' OR ACCEPT_MAN LIKE '%" + keyFilter + "%' OR ACCEPT_MAN_PHONE LIKE '%" + keyFilter + "%' OR ACCEPT_PROVINCE_CODE LIKE '%" + keyFilter + "%'");
                    if (drRow.Length > 0)
                    {
                        DataTable dataDetailBill = drRow.CopyToDataTable();
                        lblWaitCount.Text = dataDetailBill.Rows.Count.ToString();
                        dataGridViewDi.AutoGenerateColumns = false;
                        dataGridViewDi.DataSource = dataDetailBill;
                        FormatRowDonHang();
                    }
                    else
                    {
                        lblWaitCount.Text = "0";
                        dataGridViewDi.AutoGenerateColumns = false;
                        dataGridViewDi.DataSource = null;
                    }


                }
            }
        }
        private void btnTruyVan_Click(object sender, EventArgs e)
        {
            if (isBusyHangDi)
            {
                MessageBox.Show("Có một tác vụ đang xử lý chưa kết thúc, vui lòng đợi!", PBean.MESSAGE_TITLE);
                return;
            }
            lsContact = new List<string>();
            lsLowProcess = new List<string>();
            string statusSelect = GetMultiStatus();
            dataHangGui = _logic.GetListBill(cmbCustomerDi.SelectedValue.ToString(), statusSelect, PBean.USER.Id, "");
            btnTruyVan.Enabled = false;
            btnExport.Enabled = false;
            lblWaitCount.Text = dataHangGui.Rows.Count.ToString();
            progressBarSend.Minimum = 0;
            progressBarSend.Maximum = dataHangGui.Rows.Count;
            progressBarSend.Value = 0;
            progressBarSend.Visible = true;
            isBusyHangDi = true;
            backgroundWorkerDi.RunWorkerAsync();
        }
        string GetMultiStatus()
        {
            string contentStatus = string.Empty;
            foreach (var item in cmbProcessTypeMulti.CheckBoxItems)
            {
                if (item.Checked)
                {
                    contentStatus += (item.ComboBoxItem as PresentationControls.ObjectSelectionWrapper<System.Data.DataRow>).Item.ItemArray[0].ToString() + ",";
                }
            }
            contentStatus = contentStatus.TrimEnd(',');
            contentStatus = contentStatus.Trim();
            return contentStatus;
        }
        private void backgroundWorkerDi_DoWork(object sender, DoWorkEventArgs e)
        {
            DiTreoDon = 0;
            DiHoanTra = 0;
            DiKhuVucCham = 0;
            DiChamThaoTac = 0;
            DiSaiLechKg = 0;
            DiGiaoChuaKy = 0;

            int count = 0;
            foreach (DataRow item in dataHangGui.Rows)
            {
                string mavandon = item["BILL_CODE"].ToString();
                //1. Đơn hàng chưa ký, thì tổng thời gian từ lúc tạo đơn đến hiện tại là bao nhiêu lâu? Trường hợp đã ký, thì tổng thời gian từ lúc tạo đến thời điểm ký là bao lâu?
                DateTime ngayTaoDon = Convert.ToDateTime(item["REGISTER_DATE"].ToString());
                TimeSpan spanProcess;
                if (string.IsNullOrEmpty(item["SIGNED_DATE"].ToString()))
                {
                    // Đơn hàng chưa ký thì ta so sánh thời gian hiện tại đến lúc tạo đơn
                    spanProcess = DateTime.Now.Subtract(ngayTaoDon);
                }
                else
                {
                    // Đơn hàng đã ký, ta so sánh thời gian ký đến lúc tạo đơn
                    DateTime ngayKyDon = Convert.ToDateTime(item["SIGNED_DATE"].ToString());
                    spanProcess = ngayKyDon.Subtract(ngayTaoDon);
                }
                // Người phụ trách đơn EMPLOYEE_AD
                item["EMPLOYEE_AD"] = _logic.GetEmployee(item["FK_Customer"].ToString());
                //DAY_LATE
                item["DAY_LATE"] = (int)spanProcess.TotalDays;
                string ketQua1 = ((int)(spanProcess.TotalHours / 24)).ToString().PadLeft(2, '0') + "d" + (int)(spanProcess.TotalHours % 24) + "h";
                //2. Cảnh báo các tỉnh thuộc tình trạng giao hàng chậm
                string ketQua2 = string.Empty;
                if (_logic.CheckProvinceProblem(item["ACCEPT_PROVINCE_CODE"].ToString()))
                {
                    ketQua2 = "Khu vực giao chậm";
                    DiKhuVucCham++;
                }
                string ketQua3 = string.Empty;
                int loaiXuLy = int.Parse(item["BILL_PROCESS_STATUS"].ToString());
                if (loaiXuLy == 20)
                {
                    DiGiaoChuaKy++;
                }
                if (loaiXuLy == 1)
                {
                    DiTreoDon++;
                }
                if (string.IsNullOrEmpty(item["SIGNED_DATE"].ToString()) && loaiXuLy < 20 && loaiXuLy != 1 && loaiXuLy != 6) // Không phải đơn ảo, không phải đơn tải.
                {
                    //3. Cảnh báo nếu trong vòng 24 giờ không có bất kỳ cập nhật nào bao gồm, quét hàng, kiện vấn đề, cuộc gọi, kiện nội bộ, comment của nhân viên. Và hiểu là xử lý chậm. Trường hợp xử lý chậm quá 3 ngày thì tăng mức độ.
                    ExpScan lastScan = _logic.GetLastScanBillCode(mavandon);
                    ExpProblem lastProblem = _logic.GetLastKVDBillCode(mavandon);
                    ExpInternal lastInternal = _logic.GetLastIntenalBillCode(mavandon);
                    ExpComment lastComment = _logic.GetLastCommentBillCode(mavandon);
                    DateTime thoiGianCheck = DateTime.Now.AddDays(-10);
                    if (lastScan != null)
                    {
                        item["LAST_POST_CUR"] = lastScan.Post;
                        if (lastScan.CreateDate > thoiGianCheck)
                        {
                            thoiGianCheck = lastScan.CreateDate;
                        }
                    }

                    if (lastProblem != null)
                    {
                        item["LAST_KVD"] = lastProblem.Note;
                        if (lastProblem.CreateDate > thoiGianCheck)
                        {
                            thoiGianCheck = lastProblem.CreateDate;
                        }
                    }

                    if (lastInternal != null)
                    {
                        item["LAST_INTERNAL"] = lastInternal.Note;
                        if (lastInternal.CreateDate > thoiGianCheck)
                        {
                            thoiGianCheck = lastInternal.CreateDate;
                        }
                    }

                    if (lastComment != null)
                    {
                        item["LAST_COMMENT"] = lastComment.Author + ":" + lastComment.Comment;
                        if (lastComment.UpdateDate > thoiGianCheck)
                        {
                            thoiGianCheck = lastComment.UpdateDate;
                        }
                    }
                    TimeSpan spanCheck = DateTime.Now.Subtract(thoiGianCheck);
                    if (thoiGianCheck.Date != DateTime.Now.Date)
                    {
                        ketQua3 = "Chậm xử lý";
                        DiChamThaoTac++;
                    }
                }
                //4. Kiểm tra sai lệch số KG của đơn hàng.
                string ketQua4 = _logic.CheckTTKTWeightScanBillCode(mavandon, item["BILL_WEIGHT"].ToString());
                if (!string.IsNullOrEmpty(ketQua4))
                {
                    DiSaiLechKg++;
                }
                //5. Không có quét TTKT thì cảnh báo hàng thất lạc
                string ketQua5 = _logic.CheckTTKTScanBillCode(mavandon);
                if (!string.IsNullOrEmpty(ketQua5) && loaiXuLy == 1)
                {
                    // Nếu hàng thất lạc mà là đơn ảo thì không cảnh báo
                    ketQua5 = string.Empty;
                }
                item["KQ1"] = ketQua1;
                item["KQ2"] = ketQua2;
                item["KQ3"] = ketQua3;
                item["KQ4"] = ketQua4;
                item["KQ5"] = ketQua5;
                count++;
                item["STT"] = count;
                item["SUM_ADDRESS"] = item["ACCEPT_MAN_ADDRESS"].ToString() + ", " + item["ACCEPT_COUNTY_CODE"].ToString() + ", " + item["ACCEPT_CITY_CODE"].ToString() + ", " + item["ACCEPT_PROVINCE_CODE"].ToString();
                backgroundWorkerDi.ReportProgress(count);
            }

        }

        private void backgroundWorkerDi_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarSend.PerformStep();
        }

        private void backgroundWorkerDi_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            isBusyHangDi = false;
            // Hiển thị lên lưới dữ liệu
            dataGridViewDi.AutoGenerateColumns = false;
            dataGridViewDi.DataSource = dataHangGui;
            FormatRowDonHang();
            lblDiTreoDon.Text = PCommon.FormatNumber(DiTreoDon.ToString());
            lblDiBiHoanTra.Text = PCommon.FormatNumber(DiHoanTra.ToString());
            lblDiKhuVucCham.Text = PCommon.FormatNumber(DiKhuVucCham.ToString());
            lblDiChamThaoTac.Text = PCommon.FormatNumber(DiChamThaoTac.ToString());
            lblDiDangXuLy.Text = PCommon.FormatNumber(DiSaiLechKg.ToString());
            lblGiaoChuaKy.Text = PCommon.FormatNumber(DiGiaoChuaKy.ToString());

            // Play Sound
            SoundSuccess.Play();
            progressBarSend.Visible = false;
            btnTruyVan.Enabled = true;
            btnExport.Enabled = true;

        }
        private void FormatRowDonHang()
        {
            for (int i = 0; i < dataGridViewDi.Rows.Count; i++)
            {
                // Check màu cho ngày trễ hẹn
                int ngaytre;
                if (!int.TryParse(dataGridViewDi.Rows[i].Cells["col_DAY_LATE"].Value.ToString(), out ngaytre))
                {
                    ngaytre = 0;
                }
                if (ngaytre > 7)
                {
                    dataGridViewDi.Rows[i].Cells["col_ThoiGianVD"].Style.ForeColor = Color.Red;
                }
                else if (ngaytre >= 5)
                {
                    dataGridViewDi.Rows[i].Cells["col_ThoiGianVD"].Style.ForeColor = Color.Orange;
                }
                // Check khu vực chậm
                if (!string.IsNullOrEmpty(dataGridViewDi.Rows[i].Cells["col_CanhBao"].Value.ToString()))
                {
                    dataGridViewDi.Rows[i].Cells["col_CanhBao"].Style.ForeColor = Color.Red;
                }
                // Sai lệch KG
                if (!string.IsNullOrEmpty(dataGridViewDi.Rows[i].Cells["col_SaiLechKg"].Value.ToString()))
                {
                    dataGridViewDi.Rows[i].Cells["col_SaiLechKg"].Style.ForeColor = Color.Red;
                }
                // Hàng thất lạc
                if (!string.IsNullOrEmpty(dataGridViewDi.Rows[i].Cells["col_HangThatLac"].Value.ToString()))
                {
                    dataGridViewDi.Rows[i].Cells["col_HangThatLac"].Style.ForeColor = Color.Red;
                }
                // Chậm thao tác
                if (!string.IsNullOrEmpty(dataGridViewDi.Rows[i].Cells["col_ThoiGianXuLy"].Value.ToString()))
                {
                    dataGridViewDi.Rows[i].Cells["col_ThoiGianXuLy"].Style.ForeColor = Color.Red;
                }
                // Tình trạng đơn hàng
                if (dataGridViewDi.Rows[i].Cells["col_StatusNameCC"].Value.ToString().Contains("Đã giao chưa ký"))
                {
                    dataGridViewDi.Rows[i].Cells["col_StatusNameCC"].Style.ForeColor = Color.Green;
                }
                else if (dataGridViewDi.Rows[i].Cells["col_StatusNameCC"].Value.ToString().Contains("kiện vấn đề"))
                {
                    dataGridViewDi.Rows[i].Cells["col_StatusNameCC"].Style.ForeColor = Color.Red;
                }
            }
        }
        DataTable GetDanhSachHangGuiExcelK10(string fileName, string selectKhachHang)
        {
            string[] froms = { "Số vận đơn", "Ngày giao hàng", "Ngày kí nhận", "Loại kiện", "Trọng lượng nhập đơn", "cân kho", "phương thức thanh toán", "Phí vận chuyển", "COD", "Số tiền người nhận thanh toán", "Bưu cục gửi", "Bưu cục gửi cấp 1", "người gửi", "Tỉnh gửi hàng", "Thành phố/Quận/Huyện gửi hàng", "Xã/Phường/Thị trấn gửi hàng",
            "Địa chỉ người gửi", "Điện thoại người gửi", "Người nhận", "Xã/Phường/Thị trấn nhận hàng", "Thành phố/Quận/Huyện nhận hàng", "Tỉnh nhận", "địa chỉ người nhận", "Điện thoại của người nhận", "Đã kết toán trả tiền hay chưa", "Có phải hàng hoàn", "Điểm đến"};
            string[] tos = { "BILL_CODE", "REGISTER_DATE", "SIGN_DATE", "LOAI_KIEN", "BILL_WEIGHT", "FEE_WEIGHT", "PAYMENT_TYPE_CODE", "FREIGHT", "GOODS_PAYMENT", "TOPAYMENT", "REGISTER_SITE_CODE", "SEND_SITE_CODE", "SEND_MAN", "SEND_PROVINCE_CODE", "SEND_CITY_CODE", "SEND_COUNTY_CODE",
            "SEND_MAN_ADDRESS", "SEND_MAN_PHONE", "ACCEPT_MAN", "ACCEPT_COUNTY_CODE", "ACCEPT_CITY_CODE", "ACCEPT_PROVINCE_CODE", "ACCEPT_MAN_ADDRESS", "ACCEPT_MAN_PHONE", "DONE_ACCOUNT_CODE", "IS_RETURN", "DES_SITE_NAME_LANG"};
            DataSet ds = NPOIHelper.GetDataSetFromXls(fileName);
            DataTable data = ds.Tables[0];

            for (int i = 0; i < froms.Count(); i++)
            {
                data.Columns[froms[i]].ColumnName = tos[i];
            }
            // Lọc theo khách

            if (!string.IsNullOrEmpty(selectKhachHang))
            {
                DataRow[] drs = data.Select("SEND_MAN_PHONE IN (" + selectKhachHang + ")");
                if (drs.Length > 0)
                {
                    data = drs.CopyToDataTable();
                }
                else
                {
                    data.Rows.Clear();
                }
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
            data.Columns.Add("SUM_ADDRESS", Type.GetType("System.String"));
            data.Columns.Add("VUNG_MIEN", Type.GetType("System.String"));
            data.Columns.Add("AUTO_FREIGHT", Type.GetType("System.String"));
            data.Columns.Add("COD_CK", Type.GetType("System.Int32"));
            return data;
        }
        private string GetMultiCombox()
        {
            string phones = string.Empty;
            string temp = cmbMultiKhachHang.Text;
            temp = temp.Replace("\"", "");
            temp = temp.Trim();
            if (string.IsNullOrEmpty(temp))
            {
                return string.Empty;
            }
            string[] split = temp.Split('&');
            foreach (var item in split.ToList())
            {
                string[] s = item.Split('-');
                phones += "'" + s[1] + "',";
            }
            phones = phones.TrimEnd(',');
            return phones;
        }
        private string GetMultiComboxLoiNhuan()
        {
            string phones = cmbCustomer.SelectedValue.ToString();
            if (phones == "0000")
            {
                return string.Empty;
            }
            return phones;
        }
        DataTable GetFullChiTietKetToanExcelK10(string fileName)
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

        DataTable GetChiTietKetToanExcelK10(string filename)
        {
            string[] froms = { "Mã đơn đặt", "Mã chi phí", "Thời gian kết toán", "Mã đại lí", "Số tiền" };
            string[] tos = { "BILL_CODE", "BALANCE_TYPE_CODE", "BALANCE_DATE", "SITE_CODE", "MONEY" };
            DataTable data = ExportDataToExcelTemplate.ReadAsDataTable(filename);
            for (int i = 0; i < froms.Count(); i++)
            {
                data.Columns[froms[i]].ColumnName = tos[i];
            }
            DataRow[] drs = data.Select("BALANCE_TYPE_CODE='SDSHK-F'");
            if (drs.Length > 0)
            {
                return drs.CopyToDataTable();
            }
            else
            {
                return new DataTable();
            }
        }
        private DataTable GetListHangDenExcelK10()
        {
            string[] froms = { "Quét số đơn đặt hàng", "Mô tả loại quét", "Thời gian quét", "Quét cửa hàng", "Trang trước/sau" };
            string[] tos = { "BILL_CODE", "LOAI_QUET", "THOI_GIAN_QUET", "DAI_LY", "FROM" };
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Excel Files |*.xls";
            if (open.ShowDialog() == DialogResult.OK)
            {
                DataSet ds = NPOIHelper.GetDataSetFromXls(open.FileName);
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
                return data;
            }
            return new DataTable();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dataHangGui.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "BAO_CAO_HANG_GUI";
                save.Filter = "Excel Files | *.xlsx";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string templateFileName = AppDomain.CurrentDomain.BaseDirectory + "Templates\\DON_HANG_DI.xlsx";
                    Dictionary<string, string> lsReplace = new Dictionary<string, string>();
                    lsReplace.Add("NGAY_DS", string.Format("{0:dd/MM/yyyy}", DateTime.Now));
                    Dictionary<string, string> lsTitile = new Dictionary<string, string>();
                    ExportDataToExcelTemplate.Export(templateFileName, save.FileName, 1, dataHangGui, lsTitile, lsReplace);
                    MessageBox.Show("Xuất file excel thành công!", PBean.MESSAGE_TITLE);
                }
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu vui lòng thực hiện truy vấn dữ liệu trước khi xuất Excel", PBean.MESSAGE_TITLE);
            }

        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            if (isBusyLoiNhuan)
            {
                MessageBox.Show("Có một tác vụ đang xử lý chưa kết thúc, vui lòng đợi!", PBean.MESSAGE_TITLE);
                return;
            }
            try
            {
                string selectKhachHang = GetMultiComboxLoiNhuan();
                dataLoiNhuan = GetDanhSachHangGuiExcelK10(txtHangGui.Text, selectKhachHang);


            }
            catch
            {
                MessageBox.Show("Vui lòng đóng file excel đang mở và thử lại!", PBean.MESSAGE_TITLE);
                return;
            }

            lblWaitBill.Text = dataLoiNhuan.Rows.Count.ToString();
            progressBarBill.Minimum = 0;
            progressBarBill.Maximum = dataLoiNhuan.Rows.Count;
            progressBarBill.Value = 0;
            progressBarBill.Visible = true;
            TongTienPHI = 0;
            TongTienSHIP = 0;
            TongTienCOD = 0;
            TongDon = 0;
            TongKyNhan = 0;
            TongHoanTra = 0;
            TongTienHoanTra = 0;
            MienPhiHoan100 = chbMienHoan.Checked;
            lblBillTyLeKyNhan.Text = "0%";
            isBusyLoiNhuan = true;
            btnBill.Enabled = false;
            btnExportBill.Enabled = false;
            backgroundWorkerLoiNhuan.RunWorkerAsync();

        }
        private void backgroundWorkerLoiNhuan_DoWork(object sender, DoWorkEventArgs e)
        {
            //Init memory
            datasetBill = new DataSet();
            // Process Data
            dataLoiNhuan.Columns.Add("LOI_NHUAN", Type.GetType("System.String"));
            DataTable masterData = dataLoiNhuan.Clone();
            masterData.TableName = "KetQua";
            int row = 1;
            DataTable dataDetail = _logic.GetStrucFeeBalanceDetail();
            dataDetail.TableName = "KetQuaDetail";

            foreach (DataRow item in dataLoiNhuan.Rows)
            {
                TongDon++;
                if (!string.IsNullOrEmpty(item["SIGN_DATE"].ToString()))
                {
                    TongKyNhan++;

                    item["SUM_ADDRESS"] = item["ACCEPT_MAN_ADDRESS"].ToString() + ", " + item["ACCEPT_COUNTY_CODE"].ToString() + ", " + item["ACCEPT_CITY_CODE"].ToString() + ", " + item["ACCEPT_PROVINCE_CODE"].ToString();

                    if (item["PAYMENT_TYPE_CODE"].ToString() == "Nhận thanh toán")
                    {
                        item["LOAI_TT"] = "Nhận thanh toán";
                    }
                    else
                    {
                        item["LOAI_TT"] = "Gửi thanh toán";
                    }
                    item["STT"] = row.ToString();

                    row++;
                    // Tính toán chi phí
                    string mavd = item["BILL_CODE"].ToString();
                    decimal chiPhi = _logic.GetFeeBalanceDetail(mavd, PBean.USER.CardId, dataDetail);

                    TongTienPHI = TongTienPHI + chiPhi;
                    //ChiPhi
                    item["CHI_PHI"] = PCommon.FormatNumber(chiPhi.ToString(), 1);

                    decimal thuHo = decimal.Parse(item["GOODS_PAYMENT"].ToString());
                    TongTienCOD = TongTienCOD + thuHo;

                    decimal phiShip = decimal.Parse(item["FREIGHT"].ToString());

                    item["FREIGHT"] = PCommon.FormatNumber(item["FREIGHT"].ToString());
                    item["GOODS_PAYMENT"] = PCommon.FormatNumber(item["GOODS_PAYMENT"].ToString());
                    TongTienSHIP = TongTienSHIP + phiShip;
                    item["LOI_NHUAN"] = PCommon.FormatNumber((phiShip - chiPhi).ToString(), 1);
                    if (item["IS_RETURN"].ToString() != "Không")
                    {
                        TongHoanTra++;
                        TongTienHoanTra += phiShip;
                        if (MienPhiHoan100 == true)
                        {
                            TongTienSHIP = TongTienSHIP - phiShip;
                        }
                    }
                    masterData.ImportRow(item);
                }

                backgroundWorkerLoiNhuan.ReportProgress(row);
            }
            datasetBill.Tables.Add(masterData);
            // Change column name
            dataDetail.Columns["MaChiPhi"].ColumnName = "Mã chi phí";
            dataDetail.Columns["TenChiPhi"].ColumnName = "Tên chi phí";
            dataDetail.Columns["SoTien"].ColumnName = "Số tiền";
            dataDetail.Columns["LoaiThu"].ColumnName = "Loại thu";
            dataDetail.Columns["ThoiGianKetToan"].ColumnName = "Thời gian";
            datasetBill.Tables.Add(dataDetail);
            // Thêm RelationShip
            datasetBill.Relations.Add("1", datasetBill.Tables["KetQua"].Columns["BILL_CODE"],
                                           datasetBill.Tables["KetQuaDetail"].Columns["BILL_CODE"], false);
        }

        private void backgroundWorkerLoiNhuan_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarBill.PerformStep();
        }

        private void backgroundWorkerLoiNhuan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            isBusyLoiNhuan = false;
            // Hiển thị lên lưới dữ liệu
            gridBill.PrimaryGrid.DataSource = datasetBill;
            gridBill.PrimaryGrid.DataMember = "KetQua";

            lblBillPhiVC.Text = PCommon.FormatNumber(TongTienPHI.ToString());
            lblBillCuocVC.Text = PCommon.FormatNumber(TongTienSHIP.ToString());
            lblBillLoiNhuan.Text = PCommon.FormatNumber((TongTienSHIP - TongTienPHI).ToString());
            lblBillTongCod.Text = PCommon.FormatNumber(TongTienCOD.ToString());
            lblBillTongDon.Text = PCommon.FormatNumber(TongDon.ToString());
            lblBillKyNhan.Text = PCommon.FormatNumber(TongKyNhan.ToString());
            lblBillTyLeKyNhan.Text = PCommon.FormatNumber((((TongKyNhan - TongHoanTra) / TongDon) * 100).ToString(), 2) + "%";
            lblBillHoanTra.Text = PCommon.FormatNumber(TongHoanTra.ToString()) + "(" + PCommon.FormatNumber(TongTienHoanTra.ToString()) + ")";
            // Play Sound
            SoundSuccess.Play();
            progressBarBill.Visible = false;
            btnBill.Enabled = true;
            btnExportBill.Enabled = true;
        }
        private void gridBill_GetCellStyle(object sender, GridGetCellStyleEventArgs e)
        {
            GridPanel panel = e.GridPanel;
            if (e.GridCell.GridColumn.Name.Equals("col_LoiNhuan") == true)
            {
                // Check màu
                string value = (string)e.GridCell.Value;
                if (value.Contains("-"))
                {
                    e.Style.TextColor = Color.Red;
                }
            }
        }
        private void btnExportBill_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Files | *.xlsx";
            if (save.ShowDialog() == DialogResult.OK)
            {
                string templateFileName = AppDomain.CurrentDomain.BaseDirectory + "Templates\\DOI_SOAT_TEMPLATE.xlsx";
                Dictionary<string, string> lsReplace = new Dictionary<string, string>();
                if (cmbCustomer.SelectedValue.ToString() != "0000")
                {
                    ExpCustomer cusData = _logic.GetCustomerDetail(cmbCustomer.SelectedValue.ToString(), PBean.USER.CardId);
                    if (cusData != null)
                    {
                        lsReplace.Add("MAKH", cusData.Id);
                        lsReplace.Add("TEN_KH", cusData.CustomerName);
                        lsReplace.Add("SĐT_KH", cusData.CustomerPhone);
                    }

                }
                else
                {
                    lsReplace.Add("MAKH", "");
                    lsReplace.Add("TEN_KH", "TẤT CẢ KHÁCH HÀNG");
                    lsReplace.Add("SĐT_KH", "");
                }

                Dictionary<string, string> lsTitile = new Dictionary<string, string>();
                ExportDataToExcelTemplate.Export(templateFileName, save.FileName, 1, datasetBill.Tables["KetQua"], lsTitile, lsReplace);
                MessageBox.Show("Xuất file excel thành công!", PBean.MESSAGE_TITLE);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CreateColumn()
        {
            dtQuanLyDonHang.Columns.Add("BILL_CODE");
            dtQuanLyDonHang.Columns.Add("ACCEPT_MAN");
            dtQuanLyDonHang.Columns.Add("ACCEPT_MAN_PHONE");
            dtQuanLyDonHang.Columns.Add("SUM_ADDRESS");
            dtQuanLyDonHang.Columns.Add("TOTAL_MONEY");
        }
        private void btnTruyVanDoiSoat_Click(object sender, EventArgs e)
        {
            //TAB_CUS_ACCOUNT_INFO
            if (isBusyDoiSoat)
            {
                MessageBox.Show("Có một tác vụ đang xử lý chưa kết thúc, vui lòng đợi!", PBean.MESSAGE_TITLE);
                return;
            }
            btnExcelDoiSoat.Enabled = false;
            btnTruyVanDoiSoat.Enabled = false;
            btnDoiSoatHoaDon.Enabled = false;

            lsMaKhachHang = new List<ExpCustomer>();
            TongTienDoiSoat = 0;
            TongSoLuongDoiSoat = 0;
            TongPhiVanChuyenDoiSoat = 0;
            TongPhiVanChuyenDoiSoatGuiTra = 0;
            TongCODDoiSoat = 0;
            TongKyNhanDoiSoat = 0;
            TongHoanDoiSoat = 0;
            TongDaDoiSoat = 0;
            TongChuaDoiSoat = 0;
            TongTamUngDoiSoat = 0;
            TongTienTamUng = 0;
            TongCODDoiSoatKT = 0;
            TongPhiVanChuyenDoiSoatKT = 0;
            MessageBox.Show("Lựa chọn file vận đơn. [Quản lý vận đơn > Truy vấn vận đơn]", PBean.MESSAGE_TITLE);

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Excel Files |*.xls";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string selectKhachHang = GetMultiCombox();
                dataDoiSoatTemp = GetDanhSachHangGuiExcelK10(open.FileName, selectKhachHang);
            }
            else
            {
                return;
            }

            dataDoiSoat = new DataTable();
            progressBarDoiSoat.Minimum = 0;
            progressBarDoiSoat.Maximum = dataDoiSoatTemp.Rows.Count;
            progressBarDoiSoat.Value = 0;
            progressBarDoiSoat.Visible = true;
            isBusyDoiSoat = true;
            lblSoDonDoiSoat.Text = PCommon.FormatNumber(dataDoiSoatTemp.Rows.Count.ToString());
            backgroundWorkerDoiSoat.RunWorkerAsync();
        }

        private void btnExcelDoiSoat_Click(object sender, EventArgs e)
        {
            string flag = string.Empty;
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    DateTime date = DateTime.Now;
                    string nameFolder = "NGAY " + string.Format("{0:dd.MM.yy (HH.mm)}", date);

                    string rootFolder = folder.SelectedPath;
                    string finaceFolder = rootFolder.TrimEnd('\\') + "\\" + nameFolder + "\\" + "KHACH_HANG";
                    string invoiceFolder = rootFolder.TrimEnd('\\') + "\\" + nameFolder + "\\" + "HOA_DON";
                    if (!Directory.Exists(finaceFolder))
                    {
                        Directory.CreateDirectory(finaceFolder);
                    }
                    if (!Directory.Exists(invoiceFolder))
                    {
                        Directory.CreateDirectory(invoiceFolder);
                    }
                    string templateKhachHang = AppDomain.CurrentDomain.BaseDirectory + "Templates\\DOI_SOAT_TEMPLATE.xlsx";
                    string templateHoaDon = AppDomain.CurrentDomain.BaseDirectory + "Templates\\Mau_K9.xlsx";
                    string templateTongHop = AppDomain.CurrentDomain.BaseDirectory + "Templates\\DOI_SOAT_SUM.xlsx";
                    string templateTongHopKH = AppDomain.CurrentDomain.BaseDirectory + "Templates\\DOI_SOAT_SUM_KH.xlsx";
                    List<string> lsKeyString = new List<string>();
                    lsKeyString.Add("BILL_CODE");
                    lsKeyString.Add("ACCEPT_MAN_PHONE");
                    lsKeyString.Add("SEND_MAN_PHONE");

                    DataTable dataTongDoiSoat = new DataTable();
                    //Init Table
                    dataTongDoiSoat.Columns.Add("MA_KH");
                    dataTongDoiSoat.Columns.Add("TEN_KH");
                    dataTongDoiSoat.Columns.Add("SDT_KH");
                    dataTongDoiSoat.Columns.Add("SO_DON_GIAO");
                    dataTongDoiSoat.Columns.Add("SO_DON_HOAN");
                    dataTongDoiSoat.Columns.Add("TONG_COD");
                    dataTongDoiSoat.Columns.Add("TONG_CUOC");
                    dataTongDoiSoat.Columns.Add("THANH_TOAN");
                    dataTongDoiSoat.Columns.Add("LOAI_KH");
                    dataTongDoiSoat.Columns.Add("TONG_COD_KT");
                    dataTongDoiSoat.Columns.Add("SAI_LECH");
                    dataTongDoiSoat.Columns.Add("GHI_CHU");
                    dataTongDoiSoat.Columns.Add("CHI_PHI_KT");
                    dataTongDoiSoat.Columns.Add("LOI_NHUAN_KT");
                    dataTongDoiSoat.Columns.Add("TONG_CUOC_NHAN");
                    dataTongDoiSoat.Columns.Add("DA_THANH_TOAN");
                    dataTongDoiSoat.Columns.Add("NO_BANG_KEO");
                    dataTongDoiSoat.Columns.Add("CODE");
                    // Total

                    decimal totalSUM_COUNT = 0;
                    decimal totalSUM_COD = 0;
                    decimal totalSUM_COD_KT = 0;
                    decimal totalSUM_SAI_LECH = 0;
                    decimal totalSUM_CUOC_GUI = 0;
                    decimal totalSUM_CUOC_NHAN = 0;
                    decimal totalSUM_CHI_PHI = 0;
                    decimal totalSUM_LOI_NHUAN = 0;
                    decimal totalSUM_THANH_TOAN = 0;
                    ExpDoiSoat doiSoat = new ExpDoiSoat();
                    doiSoat.Id = Guid.NewGuid().ToString();
                    doiSoat.NgayDoiSoat = date;
                    doiSoat.NguoiDoiSoat = PBean.USER.FullName;
                    doiSoat.Post = PBean.USER.CardId;

                    List<ExpDoiSoatChiTiet> lsChiTiet = new List<ExpDoiSoatChiTiet>();
                    List<ExpDoiSoatChiTietCt> lsChiTietCt = new List<ExpDoiSoatChiTietCt>();

                    foreach (var item in lsMaKhachHang)
                    {
                        string phone = item.CustomerPhone;
                        DataRow[] drRow = dataDoiSoat.Select("SEND_MAN_PHONE='" + item.CustomerPhone + "' AND EXPORT='1'");
                        if (drRow.Length > 0)
                        {
                            DataTable dataDetailBill = drRow.CopyToDataTable();

                            string maKH = string.Empty;
                            string tenKH = string.Empty;
                            string sdtKH = string.Empty;

                            string soTK = string.Empty;
                            string chuTK = string.Empty;
                            string nhTK = string.Empty;

                            DataRow dr = dataTongDoiSoat.NewRow();

                            Dictionary<string, string> lsReplace = new Dictionary<string, string>();
                            Dictionary<string, string> lsTitile = new Dictionary<string, string>();

                            string fileName = PCommon.UnSigns(dataDetailBill.Rows[0]["SEND_MAN"].ToString().Replace(" ", "_").Replace(":", "").Replace(",", "").Replace("'", "")).ToUpper() + "_" + dataDetailBill.Rows[0]["SEND_MAN_PHONE"].ToString().Replace(" ", "");
                            maKH = dataDetailBill.Rows[0]["CUSTOMER_CODE"].ToString();
                            tenKH = dataDetailBill.Rows[0]["SEND_MAN"].ToString();
                            sdtKH = dataDetailBill.Rows[0]["SEND_MAN_PHONE"].ToString();

                            soTK = dataDetailBill.Rows[0]["BANK_CODE"].ToString();
                            chuTK = dataDetailBill.Rows[0]["CHU_THE"].ToString();
                            nhTK = dataDetailBill.Rows[0]["BANK_NAME"].ToString();

                            lsReplace.Add("MA_KH", "'" + maKH);
                            lsReplace.Add("TEN_KH", tenKH);
                            lsReplace.Add("SDT_KH", "'" + sdtKH);

                            lsReplace.Add("SO_TK", "'" + soTK);
                            lsReplace.Add("CHU_TK", chuTK);
                            lsReplace.Add("NGAN_HANG", "'" + nhTK);

                            if (item.ContractCustomer == false)
                            {
                                dr["LOAI_KH"] = "Khách lẻ";
                            }
                            else
                            {
                                dr["LOAI_KH"] = "Khách HĐ";
                            }
                            lsReplace.Add("NGAY_DS", "ĐƠN HÀNG ĐÃ KÝ NHẬN ĐẾN NGÀY " + String.Format("{0:dd/MM/yyyy}", DateTime.Now));

                            decimal sumCOD = 0;
                            decimal sumCODKT = 0;
                            decimal summFeeGuiTra = 0;
                            decimal summFeeNhanTra = 0;
                            decimal sumPay = 0;
                            decimal summChiPhi = 0;
                            decimal summLoiNhuan = 0;

                            ExpDoiSoatChiTiet doiSoatChiTiet = new ExpDoiSoatChiTiet();
                            doiSoatChiTiet.Id = Guid.NewGuid().ToString();
                            doiSoatChiTiet.FK_DoiSoat = doiSoat.Id;

                            foreach (DataRow subItem in dataDetailBill.Rows)
                            {
                                ExpDoiSoatChiTietCt doiSoatChiTietCt = new ExpDoiSoatChiTietCt();
                                doiSoatChiTietCt.FK_DoiSoatChiTiet = doiSoatChiTiet.Id;
                                doiSoatChiTietCt.NguoiGui = subItem["SEND_MAN"].ToString();
                                doiSoatChiTietCt.NguoiNhan = subItem["ACCEPT_MAN"].ToString();
                                doiSoatChiTietCt.NoiDen = subItem["ACCEPT_PROVINCE_CODE"].ToString();
                                doiSoatChiTietCt.SoDienThoai = subItem["ACCEPT_MAN_PHONE"].ToString();
                                doiSoatChiTietCt.NgayGuiHang = subItem["REGISTER_DATE"].ToString();
                                doiSoatChiTietCt.NgayKyNhan = subItem["SIGN_DATE"].ToString();
                                string mavandon = subItem["BILL_CODE"].ToString();
                                string chiddd = subItem["CHI_PHI"].ToString();
                                string payCod = subItem["PAYMENT_TYPE_CODE"].ToString();
                                decimal thuHo = decimal.Parse(subItem["GOODS_PAYMENT"].ToString());

                                //int SoTienCK = Int32.Parse(subItem["COD_CK"].ToString());
                                //thuHo = thuHo - SoTienCK;
                                //subItem["GOODS_PAYMENT"] = thuHo;

                                decimal thanhToan = decimal.Parse(subItem["CHI_PHI"].ToString());
                                decimal phiVanChuyen = decimal.Parse(subItem["FREIGHT"].ToString());
                                decimal TrongLuong = decimal.Parse(subItem["BILL_WEIGHT"].ToString());
                                doiSoatChiTietCt.TrongLuong = TrongLuong;
                                decimal chiPhi = _logic.GetFeeBalanceDetail(mavandon, PBean.USER.CardId);
                                summChiPhi = summChiPhi + chiPhi;
                                summLoiNhuan = summLoiNhuan + (phiVanChuyen - chiPhi);
                                sumCOD = sumCOD + thuHo;
                                sumPay = sumPay + thanhToan;
                                sumCODKT = sumCODKT + _logic.GetCODBalance(mavandon, PBean.USER.CardId);
                                if (payCod == "Nhận thanh toán")
                                {
                                    // Nhận thanh toán
                                    if (subItem["GIAO_HANG_TC"].ToString() == "0")
                                    {
                                        summFeeGuiTra = summFeeGuiTra + phiVanChuyen;
                                    }
                                    else
                                    {
                                        summFeeNhanTra = summFeeNhanTra + phiVanChuyen;
                                    }
                                }
                                else
                                {
                                    // Gửi thanh toán
                                    summFeeGuiTra = summFeeGuiTra + phiVanChuyen;
                                }

                                if (subItem["VUNG_MIEN"].ToString().Contains("SAI CƯỚC PHÍ"))
                                {
                                    dr["GHI_CHU"] = "SAI CƯỚC PHÍ";

                                }
                                doiSoatChiTietCt.BILL_CODE = mavandon;
                                doiSoatChiTietCt.CuocVanChuyen = phiVanChuyen;
                                doiSoatChiTietCt.GhiChu = subItem["STATUS_NAME"].ToString();
                                doiSoatChiTietCt.LoaiKien = subItem["LOAI_KIEN"].ToString();
                                doiSoatChiTietCt.LoaiThanhToan = subItem["LOAI_TT"].ToString();
                                doiSoatChiTietCt.SoTienThanhToan = thanhToan;
                                doiSoatChiTietCt.ThuHo = thuHo;

                                lsChiTietCt.Add(doiSoatChiTietCt);
                            }

                            lsReplace.Add("SUM_COD", PCommon.FormatNumber(sumCOD.ToString()));
                            lsReplace.Add("SUM_FEE", PCommon.FormatNumber(summFeeGuiTra.ToString()));
                            lsReplace.Add("SUM_PAY", PCommon.FormatNumber(sumPay.ToString()));
                            // Xuất file khách hàng
                            fileName = RemoveSpecialCharacters(fileName);
                            flag = fileName;
                            ExportDataToExcelTemplate.Export(templateKhachHang, finaceFolder + "\\" + fileName + ".xlsx", 1, dataDetailBill, lsTitile, lsReplace, true, lsKeyString);
                            // Xuất file hóa đơn

                            string fileNameHd = "HD_" + PCommon.UnSigns(dataDetailBill.Rows[0]["SEND_MAN"].ToString().Replace(" ", "_").Replace(":", "").Replace(",", "").Replace("'", "")).ToUpper() + "_" + dataDetailBill.Rows[0]["SEND_MAN_PHONE"].ToString().Replace(" ", "");
                            fileNameHd = RemoveSpecialCharacters(fileNameHd);
                            ExportDataToExcelTemplate.Export(templateHoaDon, invoiceFolder + "\\" + fileNameHd + ".xlsx", 1, dataDetailBill, lsTitile, lsReplace, false, lsKeyString);
                            // Tính toán cho file tổng hợp
                            dr["DA_THANH_TOAN"] = "0";
                            // Kiểm tra tiền nợ băng keo
                            dr["NO_BANG_KEO"] = _logic.GetTienNoBangKeo(sdtKH, PBean.USER.CardId);
                            dr["CODE"] = doiSoatChiTiet.Id;
                            dr["MA_KH"] = maKH;
                            dr["TEN_KH"] = tenKH;
                            dr["SDT_KH"] = sdtKH;
                            dr["SO_DON_GIAO"] = dataDetailBill.Rows.Count.ToString();
                            dr["TONG_COD"] = sumCOD.ToString();
                            dr["TONG_CUOC"] = summFeeGuiTra.ToString();
                            dr["TONG_CUOC_NHAN"] = summFeeNhanTra.ToString();
                            dr["THANH_TOAN"] = sumPay.ToString();
                            dr["TONG_COD_KT"] = sumCODKT.ToString();
                            dr["SAI_LECH"] = (sumCODKT - sumCOD).ToString();

                            dr["CHI_PHI_KT"] = summChiPhi.ToString();
                            dr["LOI_NHUAN_KT"] = summLoiNhuan.ToString();
                            // Total
                            totalSUM_COUNT = totalSUM_COUNT + dataDetailBill.Rows.Count;
                            totalSUM_COD = totalSUM_COD + sumCOD;
                            totalSUM_COD_KT = totalSUM_COD_KT + sumCODKT;
                            totalSUM_SAI_LECH = totalSUM_SAI_LECH + (sumCOD - sumCODKT);
                            totalSUM_CUOC_GUI = totalSUM_CUOC_GUI + summFeeGuiTra;
                            totalSUM_CUOC_NHAN = totalSUM_CUOC_NHAN + summFeeNhanTra;
                            totalSUM_CHI_PHI = totalSUM_CHI_PHI + summChiPhi;
                            totalSUM_LOI_NHUAN = totalSUM_LOI_NHUAN + summLoiNhuan;
                            totalSUM_THANH_TOAN = totalSUM_THANH_TOAN + sumPay;

                            doiSoatChiTiet.ChiPhi = summChiPhi;
                            doiSoatChiTiet.CuocGuiTra = summFeeGuiTra;
                            doiSoatChiTiet.CuocNhanTra = summFeeNhanTra;
                            doiSoatChiTiet.DaThanhToanKH = 0;
                            doiSoatChiTiet.GhiChu = dr["GHI_CHU"].ToString();
                            doiSoatChiTiet.LoiNhuan = summLoiNhuan;
                            //doiSoatChiTiet.NgayThanhToan
                            //doiSoatChiTiet.PhuongThucThanhToan
                            doiSoatChiTiet.SaiLech = sumCOD - sumCODKT;
                            doiSoatChiTiet.SoDienThoai = sdtKH;
                            doiSoatChiTiet.SoLuongDon = dataDetailBill.Rows.Count;
                            doiSoatChiTiet.TenKhachHang = tenKH;
                            doiSoatChiTiet.ThanhToanKH = sumPay;
                            doiSoatChiTiet.ThuHo = sumCOD;
                            doiSoatChiTiet.ThuHoKT = sumCODKT;
                            lsChiTiet.Add(doiSoatChiTiet);
                            dataTongDoiSoat.Rows.Add(dr);
                        }
                    }
                    dataTongDoiSoat.DefaultView.Sort = "LOAI_KH asc, TEN_KH asc";
                    DataTable dataSort = dataTongDoiSoat.DefaultView.ToTable();

                    Dictionary<string, string> lsRe = new Dictionary<string, string>();
                    Dictionary<string, string> lsTi = new Dictionary<string, string>();

                    lsRe.Add("SUM_COUNT", totalSUM_COUNT.ToString());
                    lsRe.Add("SUM_COD", totalSUM_COD.ToString());
                    lsRe.Add("SUM_COD_KT", totalSUM_COD_KT.ToString());
                    lsRe.Add("SUM_SAI_LECH", totalSUM_SAI_LECH.ToString());
                    lsRe.Add("SUM_CUOC_GUI", totalSUM_CUOC_GUI.ToString());
                    lsRe.Add("SUM_CUOC_NHAN", totalSUM_CUOC_NHAN.ToString());
                    lsRe.Add("SUM_CHI_PHI", totalSUM_CHI_PHI.ToString());
                    lsRe.Add("SUM_LOI_NHUAN", totalSUM_LOI_NHUAN.ToString());
                    lsRe.Add("SUM_THANH_TOAN", totalSUM_THANH_TOAN.ToString());
                    lsRe.Add("NGAY_BC", "ĐẾN NGÀY " + string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now));
                    doiSoat.ChiPhi = totalSUM_CHI_PHI;
                    doiSoat.CuocGuiTra = totalSUM_CUOC_GUI;
                    doiSoat.CuocNhanTra = totalSUM_CUOC_NHAN;
                    doiSoat.DaThanhToanKH = 0;
                    doiSoat.GhiChu = "";
                    doiSoat.LoiNhuan = totalSUM_LOI_NHUAN;
                    doiSoat.SaiLech = totalSUM_SAI_LECH;
                    doiSoat.SoLuongDon = (int)totalSUM_COUNT;
                    doiSoat.ThanhToanKH = totalSUM_THANH_TOAN;
                    doiSoat.ThuHo = totalSUM_COD;
                    doiSoat.ThuHoKT = totalSUM_COD_KT;
                    // XUẤT FILE TỔNG HỢP
                    ExportDataToExcelTemplate.Export(templateTongHop, rootFolder.TrimEnd('\\') + "\\" + nameFolder + "\\00.TONG_HOP_" + string.Format("{0:dd.MM.yy}", date) + ".xlsx", 1, dataSort, lsTi, lsRe, true, lsKeyString);

                    // XUẤT FILE TỔNG HỢP KHÁCH HÀNG
                    //ExportDataToExcelTemplate.Export(templateTongHopKH, rootFolder.TrimEnd('\\') + "\\" + nameFolder + "\\01.TONG_HOP_KH.xlsx", 1, dataSort, lsTi, lsRe, true, lsKeyString);

                    // Xuất file Reset tổng
                    lsRe = new Dictionary<string, string>();
                    lsTi = new Dictionary<string, string>();
                    DataRow[] drRowT = dataDoiSoat.Select("EXPORT='1'");
                    if (drRowT.Length > 0)
                    {
                        DataTable dataHoaDon = drRowT.CopyToDataTable();
                        ExportDataToExcelTemplate.Export(templateHoaDon, rootFolder.TrimEnd('\\') + "\\" + nameFolder + "\\00.HOA_DON_TONG_HOP" + string.Format("{0:dd.MM.yy}", date) + ".xlsx", 1, dataHoaDon, lsTi, lsRe, false, lsKeyString);
                    }
                    // Insert dữ liệu database
                    string mess = _logic.InsetDoiSoat(doiSoat, lsChiTiet, lsChiTietCt);
                    if (string.IsNullOrEmpty(mess) == false)
                    {
                        MessageBox.Show("Vui lòng kiểm tra các mã đơn trùng đợt đối soát trước: " + System.Environment.NewLine + mess, PBean.MESSAGE_TITLE);
                    }
                    MessageBox.Show("Kết xuất dữ liệu khách hàng hoàn tất", PBean.MESSAGE_TITLE);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show(flag);
            }
        }
        public string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
        private void FormatRowKetQua()
        {
            for (int i = 0; i < dataGridDoiSoat.Rows.Count; i++)
            {
                if (dataGridDoiSoat.Rows[i].Cells["col_DoiSoatHT"].Value.ToString() != "Không")
                {
                    dataGridDoiSoat.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }


        private void backgroundWorkerDoiSoat_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                int row = 1;
                dataDoiSoat = dataDoiSoatTemp.Clone();
                foreach (DataRow item in dataDoiSoatTemp.Rows)
                {
                    // Xử lý số liệu trước
                    string mavandon = item["BILL_CODE"].ToString();
                    bool GiaoThanhCong = false;
                    bool addRowOnGrid = false;
                    bool ChuaDoiSoat = true;
                    string NoiDungTamUng = string.Empty;
                    item["CHI_PHI"] = "0";
                    item["EXPORT"] = "0";
                    item["GIAO_HANG_TC"] = "0";
                    if (item["DONE_ACCOUNT_CODE"].ToString() == "Không")
                    {
                        if (_logic.CheckHoaDonDoiSoat(mavandon) == false)
                        {
                            // Hệ thống bên mình vẫn chưa đối soát
                            ChuaDoiSoat = true;
                            NoiDungTamUng = _logic.CheckLoanCOD(mavandon);
                        }
                        else
                        {
                            // Hệ thống bên mình báo đã đối soát rồi
                            item["DONE_ACCOUNT_CODE"] = "TT Chưa nhập HĐ";
                            TongDaDoiSoat++;
                            ChuaDoiSoat = false;
                        }
                    }
                    else
                    {
                        TongDaDoiSoat++;
                        ChuaDoiSoat = false;
                    }

                    if (item["LOAI_KIEN"].ToString() == "Kiện nội tỉnh")
                    {
                        // Nội tỉnh
                        item["LOAI_KIEN"] = "Nội tỉnh";
                    }
                    else
                    {
                        // Ngoại tỉnh
                        item["LOAI_KIEN"] = "Ngoại tỉnh";
                    }

                    // Kiểm tra loại thanh toán
                    string payCod = item["PAYMENT_TYPE_CODE"].ToString();
                    if (payCod == "Nhận thanh toán")
                    {
                        item["LOAI_TT"] = "Nhận thanh toán";
                    }
                    else
                    {
                        item["LOAI_TT"] = "Gửi thanh toán";
                    }

                    // Kiểm tra đơn hoàn trả
                    if (item["IS_RETURN"].ToString() != "Không")
                    {
                        // Xét là đơn hoàn
                        item["STATUS_NAME"] = "Hoàn trả";
                        TongHoanDoiSoat++;
                        GiaoThanhCong = false;
                        addRowOnGrid = true;
                    }
                    else if (!string.IsNullOrEmpty(item["SIGN_DATE"].ToString()))
                    {
                        // Đã ký nhận
                        item["STATUS_NAME"] = "Giao thành công";
                        GiaoThanhCong = true;
                        TongKyNhanDoiSoat++;
                        addRowOnGrid = true;
                    }
                    else if (!string.IsNullOrEmpty(NoiDungTamUng))
                    {
                        if (NoiDungTamUng.Contains("tạm ứng"))
                        {
                            item["STATUS_NAME"] = "Tạm ứng";
                        }
                        else
                        {
                            item["STATUS_NAME"] = "Bồi thường";
                        }

                        GiaoThanhCong = true;
                        TongKyNhanDoiSoat++;
                        addRowOnGrid = true;
                    }
                    // Chưa đối soát
                    string idKhachHang = string.Empty;
                    if (ChuaDoiSoat == true)
                    {
                        if (lsMaKhachHang.FirstOrDefault(u => u.CustomerPhone == item["SEND_MAN_PHONE"].ToString().Trim()) == null)
                        {
                            ExpCustomer cusDataBase = _logic.GetCustomerDetail(item["SEND_MAN_PHONE"].ToString(), PBean.USER.CardId);
                            if (cusDataBase == null)
                            {
                                cusDataBase = new ExpCustomer();
                                cusDataBase.Id = Guid.NewGuid().ToString();
                                cusDataBase.ContractCustomer = false;
                                cusDataBase.CustomerName = item["SEND_MAN"].ToString().Trim();
                                cusDataBase.CustomerPhone = item["SEND_MAN_PHONE"].ToString().Trim();
                                cusDataBase.BankName = "NGÂN HÀNG ";
                                cusDataBase.AccountCode = "SỐ TK";
                                cusDataBase.UnsigName = PCommon.UnSigns(item["SEND_MAN"].ToString().Trim());
                                cusDataBase.AccountName = item["SEND_MAN"].ToString().Trim();
                                cusDataBase.GoogleMap = "Link Google Map";
                                cusDataBase.FK_Post = PBean.USER.CardId;
                                cusDataBase.CustomerCode = item["Mã số khách hàng"].ToString();
                                if (cusDataBase.CustomerCode != "20000")
                                {
                                    cusDataBase.ContractCustomer = true;
                                    cusDataBase.TenHopDong = item["SEND_MAN"].ToString().Trim();
                                    cusDataBase.NgayHopDong = DateTime.Now.AddDays(-3);
                                    cusDataBase.SoHopDong = cusDataBase.CustomerCode;
                                    cusDataBase.DiaChi = item["SEND_MAN_ADDRESS"].ToString().Trim();
                                }
                                cusDataBase.FK_GiaCuoc = "0000";

                                _logic.CreateCustomer(cusDataBase);

                            }

                            item["CUSTOMER_CODE"] = cusDataBase.CustomerCode;
                            item["BANK_CODE"] = cusDataBase.AccountCode;
                            item["CHU_THE"] = cusDataBase.AccountName;
                            item["BANK_NAME"] = cusDataBase.BankName;

                            idKhachHang = cusDataBase.Id;

                            // Thêm vào bộ nhớ
                            lsMaKhachHang.Add(cusDataBase);
                        }
                        if (addRowOnGrid == true)
                        {
                            TongChuaDoiSoat++;
                            item["EXPORT"] = "1";
                            decimal phiVC = decimal.Parse(item["FREIGHT"].ToString());
                            decimal thuHo = decimal.Parse(item["GOODS_PAYMENT"].ToString());
                            decimal dieuChinhCK = _logic.GetCKCODBalance(mavandon);
                            thuHo = thuHo - dieuChinhCK;
                            item["COD_CK"] = dieuChinhCK;
                            if (GiaoThanhCong == true)
                            {
                                // Giao thành công bao gồm cả tạm ứng
                                item["GIAO_HANG_TC"] = 1;
                                item["FREIGHT"] = PCommon.FormatNumber(phiVC.ToString());
                                item["GOODS_PAYMENT"] = PCommon.FormatNumber(thuHo.ToString());
                                TongPhiVanChuyenDoiSoat = TongPhiVanChuyenDoiSoat + phiVC;
                                TongCODDoiSoat = TongCODDoiSoat + thuHo;
                                if (payCod == "Nhận thanh toán")
                                {
                                    //Nhận thanh toán
                                    TongTienDoiSoat = TongTienDoiSoat + thuHo;
                                    item["CHI_PHI"] = PCommon.FormatNumber(thuHo.ToString());
                                }
                                else
                                {
                                    //Gửi thanh toán
                                    TongPhiVanChuyenDoiSoatGuiTra = TongPhiVanChuyenDoiSoatGuiTra + phiVC;
                                    TongTienDoiSoat = TongTienDoiSoat + thuHo - phiVC;
                                    item["CHI_PHI"] = PCommon.FormatNumber((thuHo - phiVC).ToString());

                                }
                                string BalanceMess = string.Empty;
                                // Kiểm tra tiền có vào K9 hay không?
                                if (thuHo == 0)
                                {
                                    item["K9_BALANCE"] = "0 đồng";
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(NoiDungTamUng))
                                    {
                                        //SDSHK-F
                                        decimal outCOD;

                                        BalanceMess += _logic.CheckCODBalance(mavandon, PBean.USER.CardId, thuHo, out outCOD);
                                        if (payCod == "Nhận thanh toán")
                                        {
                                            decimal outPhiVC;
                                            BalanceMess += _logic.CheckFeeBalance(mavandon, PBean.USER.CardId, phiVC, out outPhiVC);
                                            TongPhiVanChuyenDoiSoatKT = TongPhiVanChuyenDoiSoatKT + outPhiVC;
                                        }
                                        TongCODDoiSoatKT = TongCODDoiSoatKT + outCOD;
                                    }
                                    else
                                    {
                                        BalanceMess = NoiDungTamUng;
                                    }

                                }
                                item["K9_BALANCE"] = BalanceMess;
                            }
                            else
                            {
                                // Hoàn trả
                                // Giao hàng thất bại thì mình trừ phí vận chuyển
                                TongTienDoiSoat = TongTienDoiSoat - phiVC;
                                TongPhiVanChuyenDoiSoatGuiTra = TongPhiVanChuyenDoiSoatGuiTra + phiVC;
                                item["CHI_PHI"] = "-" + PCommon.FormatNumber(phiVC.ToString());
                                item["GOODS_PAYMENT"] = 0;
                            }
                            // Kiểm tra cước phí
                            decimal phiVanChuyenTinhToan = _logic.GetFeeCalculator(item["ACCEPT_PROVINCE_CODE"].ToString(), item["BILL_WEIGHT"].ToString(), idKhachHang);
                            if (Math.Abs(phiVC - phiVanChuyenTinhToan) > 1000)
                            {
                                item["VUNG_MIEN"] = "SAI CƯỚC PHÍ";
                            }
                            item["AUTO_FREIGHT"] = PCommon.FormatNumber(phiVanChuyenTinhToan.ToString());
                        }
                    }
                    else
                    {
                        // Đã được đối soát
                    }
                    if (addRowOnGrid == true)
                    {
                        item["STT"] = row.ToString();
                        row++;
                        dataDoiSoat.ImportRow(item);
                    }
                    backgroundWorkerDoiSoat.ReportProgress(row);
                }
                TongSoLuongDoiSoat = dataDoiSoat.Rows.Count;
            }
            catch (Exception ex)
            {

            }

        }

        private void backgroundWorkerDoiSoat_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarDoiSoat.PerformStep();
        }

        private void backgroundWorkerDoiSoat_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            isBusyDoiSoat = false;
            // Hiển thị lên lưới dữ liệu
            dataGridDoiSoat.AutoGenerateColumns = false;
            dataGridDoiSoat.DataSource = dataDoiSoat;

            lblSoDonDoiSoat.Text = PCommon.FormatNumber(TongSoLuongDoiSoat.ToString());

            lblPhiVanChuyenDoiSoat.Text = PCommon.FormatNumber(TongPhiVanChuyenDoiSoat.ToString());
            lblDoiSoatCuocGuiTra.Text = PCommon.FormatNumber(TongPhiVanChuyenDoiSoatGuiTra.ToString());
            lblTongCodDoiSoat.Text = PCommon.FormatNumber(TongCODDoiSoat.ToString());

            lblTongCodDoiSoatKT.Text = PCommon.FormatNumber(TongCODDoiSoatKT.ToString());
            lblPhiVanChuyenDoiSoatKT.Text = PCommon.FormatNumber(TongPhiVanChuyenDoiSoatKT.ToString());

            lblDaKyNhanDoiSoat.Text = PCommon.FormatNumber(TongKyNhanDoiSoat.ToString());
            lblHoanDoiSoat.Text = PCommon.FormatNumber(TongHoanDoiSoat.ToString());

            lblDaDoiSoat.Text = PCommon.FormatNumber(TongDaDoiSoat.ToString());
            lblChuaDoiSoat.Text = PCommon.FormatNumber(TongChuaDoiSoat.ToString());

            lblTongTienDoiSoat.Text = PCommon.FormatNumber(TongTienDoiSoat.ToString());

            // Play Sound
            SoundSuccess.Play();
            progressBarDoiSoat.Visible = false;
            FormatRowKetQua();
            // Hiển thị cho phép xuất excel 
            btnExcelDoiSoat.Enabled = true;
            btnTruyVanDoiSoat.Enabled = true;
            btnDoiSoatHoaDon.Enabled = true;
        }

        private void btnDoiSoatExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnQLTCTruyVan_Click(object sender, EventArgs e)
        {
            LoadCashList();
            FormatRowCash();
        }
        private async void menuTraTien_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thu hồi tiền đã cho mượn/tạm ứng không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int index = dataQLTCGrid.SelectedRows[0].Index;
                    string idQlTC = Convert.ToString(dataQLTCGrid.Rows[index].Cells["col_idqltc"].Value);
                    string mess = await _logic.ThuTienMuonTamUng(idQlTC, PBean.USER.Id);
                    if (string.IsNullOrEmpty(mess))
                    {
                        LoadCashList();
                        FormatRowCash();
                    }
                    else
                    {
                        MessageBox.Show(mess, PBean.MESSAGE_TITLE);
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    return;
                }
            }
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


        private void btnQLTCUngKN_Click(object sender, EventArgs e)
        {
            frmUngCODKH frm = new frmUngCODKH();
            frm.ShowDialog();
        }

        private void btnDoiSoatHoaDon_Click(object sender, EventArgs e)
        {
            string filename = string.Empty;
            try
            {

                FolderBrowserDialog folder = new FolderBrowserDialog();
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    DirectoryInfo directory = new DirectoryInfo(folder.SelectedPath);
                    FileInfo[] files = directory.GetFiles("*.xlsx");
                    List<ExpHoaDonDoiSoat> lsHd = new List<ExpHoaDonDoiSoat>();
                    foreach (FileInfo item in files)
                    {
                        filename = item.FullName;
                        DataTable data = ExportDataToExcelTemplate.ReadAsDataTable(item.FullName);
                        if (data.Rows.Count > 0)
                        {

                            foreach (DataRow row in data.Rows)
                            {
                                ExpHoaDonDoiSoat hd = new ExpHoaDonDoiSoat();
                                hd.Id = row["Mã vận đơn"].ToString();
                                hd.CreateHd = DateTime.Now;
                                hd.FK_Account = PBean.USER.Id;
                                hd.HoaDon = row["Mã hóa đơn"].ToString();
                                hd.FK_Post = PBean.USER.CardId;
                                decimal soTienDoiSoat;
                                if (!decimal.TryParse(row["Số tiền hoàn trả"].ToString().Replace(",", ""), out soTienDoiSoat))
                                {
                                    soTienDoiSoat = 0;
                                }
                                hd.SoTienDoiSoat = soTienDoiSoat;
                                hd.GiaoThanhCong = row["Ghi chú"].ToString();
                                if (string.IsNullOrEmpty(hd.GiaoThanhCong.Trim()))
                                {
                                    hd.GiaoThanhCong = "1";
                                }
                                hd.AccountName = PBean.USER.FullName;
                                lsHd.Add(hd);
                            }
                        }
                    }
                    // Thêm vào dữ liệu
                    int count = _logic.InsertHoaDon(lsHd);
                    MessageBox.Show("Nhập hóa đơn thành công. Số đơn hàng thanh toán là: " + count.ToString(), PBean.MESSAGE_TITLE);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
                MessageBox.Show("File Name: " + filename, PBean.MESSAGE_TITLE);
            }


        }

        private void btnCustomerManager_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.ShowDialog();
        }

        private void lblSetKhacHang_DoubleClick(object sender, EventArgs e)
        {
            frmPhanCongKhachHang frm = new frmPhanCongKhachHang();
            frm.ShowDialog();
        }

        private void dataGridViewDi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //lấy index của dòng đầu tiên được chọn
                int index = dataGridViewDi.SelectedRows[0].Index;
                string mavandon = Convert.ToString(dataGridViewDi.Rows[index].Cells["col_MaVanDon"].Value);
                frmXuLyDonHang frm = new frmXuLyDonHang(mavandon);
                DialogResult dialog = frm.ShowDialog();
                if (frm.processBill == true)
                {
                    // Cập nhật lại nội dung xử lý chậm, nếu dòng đó là xử lý chậm
                    // Chậm thao tác
                    if (!string.IsNullOrEmpty(dataGridViewDi.Rows[index].Cells["col_ThoiGianXuLy"].Value.ToString()))
                    {
                        dataGridViewDi.Rows[index].Cells["col_ThoiGianXuLy"].Value = string.Empty;
                        DiChamThaoTac--;
                        lblDiChamThaoTac.Text = PCommon.FormatNumber(DiChamThaoTac.ToString());
                    }
                    if (frm.updateStatus == true)
                    {
                        dataGridViewDi.Rows[index].Cells["col_StatusNameCC"].Value = frm.updateStatusName;
                    }
                    dataGridViewDi.Rows[index].Cells["col_XuLyCC"].Value = frm.commentContent;
                    FormatRowDonHang();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {
            frmProvineProblem frm = new frmProvineProblem();
            frm.ShowDialog();
        }

        private void dataGridViewDi_SelectionChanged(object sender, EventArgs e)
        {
            lblSelect.Text = dataGridViewDi.SelectedRows.Count.ToString();
        }

        private void dataGridViewDi_Sorted(object sender, EventArgs e)
        {
            FormatRowDonHang();
        }

        private void txtTimKhach_TextChanged(object sender, EventArgs e)
        {
            cmbCustomerDi.DataSource = _logic.GetCustomerListSend(PBean.USER.CardId, txtTimKhach.Text);
            cmbCustomerDi.DisplayMember = "CustomerName";
            cmbCustomerDi.ValueMember = "Id";
        }

        private void btnBrowseDonHangGui_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Excel Files |*.xls";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtHangGui.Text = open.FileName;
            }
        }

        private void label49_Click(object sender, EventArgs e)
        {
            frmSelectCustomer frm = new frmSelectCustomer();
            DialogResult dialog = frm.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                cmbMultiKhachHang.Text = frm.SelectCustomer;
            }
        }
        private void btnTruyVanKT_Click(object sender, EventArgs e)
        {
            string loaiChiPhi = GetMultiLoaiChiPhi();
            string mavandon = GetMultiBillCode();
            GetDetailBalance(loaiChiPhi, mavandon);
        }
        void GetDetailBalance(string loaiChiPhi, string mavandon)
        {
            DateTime dateFrom = dateFromKT.Value;
            DateTime dateTo = dateToKT.Value;

            DateTime? dateFromCod = null;
            DateTime? dateToCod = null;
            DateTime tempDate;
            if (DateTime.TryParse(cmbKyRutTienFrom.SelectedValue.ToString(), out tempDate))
            {
                if (tempDate.Year > 2020)
                    dateFromCod = tempDate;


            }
            if (DateTime.TryParse(cmbKyRutTienTo.SelectedValue.ToString(), out tempDate))
            {
                if (tempDate.Year > 2020)
                    dateToCod = tempDate;
            }
            string maDaiLy = cmbTaiKhoan.SelectedValue.ToString();
            bool isTaiKhoanChung = chbTaiKhoanChung.Checked;
            bool isTaiKhoanCOD = chbTaiKhoanCod.Checked;
            lsTypeCodeExt = new List<ExpBalanceDetailTypeExt>();
            lsChiTietKetToan = _logic.GetBalanceDetailList(mavandon, loaiChiPhi, maDaiLy, dateFrom, dateTo, isTaiKhoanChung, isTaiKhoanCOD, dateFromCod, dateToCod);
            foreach (var item in lsChiTietKetToan)
            {
                ExpBalanceDetailTypeExt typeCode = lsTypeCodeExt.FirstOrDefault(u => u.Id == item.MaChiPhi);
                if (typeCode == null)
                {
                    string balanceName = item.TenChiPhi;
                    if (item.LoaiThu == "Thu")
                    {
                        balanceName += " (-)";
                    }
                    else
                    {
                        balanceName += " (+)";
                    }

                    typeCode = new ExpBalanceDetailTypeExt();
                    typeCode.Id = item.MaChiPhi;
                    typeCode.BalanceTypeName = balanceName;
                    typeCode.ThayDoiSoDu = 0;
                    lsTypeCodeExt.Add(typeCode);
                }
                if (item.LoaiThu == "Thu")
                {
                    typeCode.ThayDoiSoDu = typeCode.ThayDoiSoDu - item.SoTien;
                }
                else
                {
                    typeCode.ThayDoiSoDu = typeCode.ThayDoiSoDu + item.SoTien;
                }
            }
            // Tính toán số tổng
            dataGridViewTong.DataSource = lsTypeCodeExt.OrderBy(u => u.Id).ToList();
            FormatRowKetQuaTongHop();
            // Hiển thị chi tiết
            dataGridTime.AutoGenerateColumns = false;
            dataGridTime.DataSource = lsChiTietKetToan.OrderBy(u => u.ThoiGianKetToan).ToList();
            FormatRowKetQuaChiTiet();
            if (lsChiTietKetToan.Count > 0)
                btnXuatExcelKT.Enabled = true;
            else
                btnXuatExcelKT.Enabled = false;
        }
        private void FormatRowKetQuaChiTiet()
        {
            for (int i = 0; i < dataGridTime.Rows.Count; i++)
            {
                if (dataGridTime.Rows[i].Cells["col_LoaiThu"].Value.ToString() == "Thu" && !dataGridTime.Rows[i].Cells["col_SoTien"].Value.ToString().Contains("-"))
                {
                    dataGridTime.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }
        private void FormatRowKetQuaTongHop()
        {
            for (int i = 0; i < dataGridViewTong.Rows.Count; i++)
            {
                if (dataGridViewTong.Rows[i].Cells["col_ThayDoiSoDu"].Value.ToString().Contains("-"))
                {
                    dataGridViewTong.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
            dataGridViewTong.Refresh();
        }
        string GetMultiBillCode()
        {
            string bills = string.Empty;
            foreach (var item in txtBillCode.Lines)
            {
                if (!string.IsNullOrEmpty(item.Trim()))
                {
                    bills += "'" + item.Trim() + "',";
                }
            }
            bills = bills.TrimEnd(',');
            return bills;
        }
        string GetMultiLoaiChiPhi()
        {
            string contentStatus = string.Empty;
            foreach (var item in cmbMultiLoaiChiPhi.CheckBoxItems)
            {
                if (item.Checked)
                {
                    contentStatus += "'" + (item.ComboBoxItem as PresentationControls.ObjectSelectionWrapper<System.Data.DataRow>).Item.ItemArray[0].ToString() + "',";
                }
            }
            contentStatus = contentStatus.TrimEnd(',');
            contentStatus = contentStatus.Trim();
            return contentStatus;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            // Hiển thị báo cáo 1 tuần
            MessageBox.Show(_logic.GetQuickReport(), PBean.MESSAGE_TITLE);
        }

        private void lblLoaiChiPhi_Click(object sender, EventArgs e)
        {
            // _logic.InitProvinceFee(txtBillCode.Lines.ToList());
        }

        private void btnTinhToanCuoc_Click(object sender, EventArgs e)
        {
            // 
            decimal TongChiPhi = 3200;
            if (string.IsNullOrEmpty(txtChildTrongLuong.Text))
            {
                txtChildTrongLuong.Focus();
                return;
            }
            decimal phiGiaoHang = _logic.GetPhiGiaoHang(txtChildTrongLuong.Text);
            decimal phiTrungChuyen = _logic.GetPhiTrungChuyen(txtChildTrongLuong.Text, cmbTinh.SelectedValue.ToString());
            lblChildPhiGiaoHang.Text = PCommon.FormatNumber(phiGiaoHang.ToString(), 1);
            lblChildPhiTrungChuyen.Text = PCommon.FormatNumber(phiTrungChuyen.ToString(), 1);
            decimal weight;
            if (decimal.TryParse(txtChildTrongLuong.Text, out weight))
            {
                if (weight > 30)
                {
                    TongChiPhi = TongChiPhi + 70000;
                    lblChildPhiThaoTac.Text = "70,000";
                }
                else
                {
                    TongChiPhi = TongChiPhi + 700;
                    lblChildPhiThaoTac.Text = "700";
                }
            }
            TongChiPhi = TongChiPhi + phiGiaoHang + phiTrungChuyen;
            decimal giaCuoc = _logic.GetFeeCalculatorByGiaCuoc(cmbTinh.SelectedValue.ToString(), txtChildTrongLuong.Text, cmbGiaCuoc.SelectedValue.ToString());
            lblChildGiaCuoc.Text = PCommon.FormatNumber(giaCuoc.ToString());
            lblChildLoiNhuan.Text = PCommon.FormatNumber((giaCuoc - TongChiPhi).ToString(), 1);
            lblChildTong.Text = PCommon.FormatNumber(TongChiPhi.ToString(), 1);
        }

        private void txtChildTrongLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }

        private void txtChildTrongLuong_KeyUp(object sender, KeyEventArgs e)
        {
            base.Curency_KeyUp(sender, e);
        }

        private void btnXuatPhiTrungChuyen_Click(object sender, EventArgs e)
        {
            // Xuất phí trung chuyển
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Excel Files |*.xls";
            if (open.ShowDialog() == DialogResult.OK)
            {
                DataTable data = GetDanhSachHangGuiExcelK10(open.FileName, string.Empty);
                foreach (DataRow item in data.Rows)
                {
                    decimal weightKT = 0;
                    item["CHI_PHI"] = _logic.GetPhiTrungChuyenBalanceDetail(item["BILL_CODE"].ToString(), PBean.USER.CardId, out weightKT);
                    item["AUTO_FREIGHT"] = weightKT;
                    item["SUM_ADDRESS"] = "'" + item["REGISTER_DATE"].ToString();
                }
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "BAO_CAO_PHI_TRUNG_CHUYEN";
                save.Filter = "Excel Files | *.xlsx";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string templateFileName = AppDomain.CurrentDomain.BaseDirectory + "Templates\\BASIC_TEMPLATE.xlsx";
                    Dictionary<string, string> lsReplace = new Dictionary<string, string>();
                    Dictionary<string, string> lsTitile = new Dictionary<string, string>();
                    ExportDataToExcelTemplate.Export(templateFileName, save.FileName, 1, data, lsTitile, lsReplace);
                    MessageBox.Show("Xuất file excel thành công!", PBean.MESSAGE_TITLE);
                }
            }
            else
            {
                return;
            }
        }

        private void btnTruyVanDonChuaPhatHanh_Click(object sender, EventArgs e)
        {
            DataTable data = _logicChungTu.GetDanhSachHoaDonChuaPhatHanh(PBean.USER.CardId, dateFromChuaPH.Value, dateToChuaPH.Value);
            decimal totalCODHD = 0;
            decimal totalPhiHD = 0;
            decimal totalCODKL = 0;
            decimal totalPhiKL = 0;
            int row = 1;
            foreach (DataRow item in data.Rows)
            {
                item["STT"] = row;
                bool isKhachHd = bool.Parse(item["ContractCustomer"].ToString());
                decimal COD = decimal.Parse(item["GOODS_PAYMENT"].ToString());
                decimal Phi = decimal.Parse(item["FREIGHT"].ToString());
                if (isKhachHd)
                {
                    totalCODHD = totalCODHD + COD;
                    totalPhiHD = totalPhiHD + Phi;
                }
                else
                {
                    totalCODKL = totalCODKL + COD;
                    totalPhiKL = totalPhiKL + Phi;
                }
                row++;
            }
            lblCODChuaPHHD.Text = PCommon.FormatNumber(totalCODHD.ToString());
            lblCODChuaPHKL.Text = PCommon.FormatNumber(totalCODKL.ToString());
            lblPhiShipChuaPHHD.Text = PCommon.FormatNumber(totalPhiHD.ToString());
            lblPhiShipChuaPHKL.Text = PCommon.FormatNumber(totalPhiKL.ToString());

            dataGridChuaPhatHanh.AutoGenerateColumns = false;
            dataGridChuaPhatHanh.DataSource = data;
        }

        private void btnQuanLyKy_Click(object sender, EventArgs e)
        {
            frmKyKetToan frm = new frmKyKetToan();
            frm.ShowDialog();
            // Load lại
            cmbKyChungTu.DataSource = _logicChungTu.GetKyKetToan();
            cmbKyChungTu.DisplayMember = "TenKy";
            cmbKyChungTu.ValueMember = "Id";
        }

        private void btnLapChungTuChuaPhatHanh_Click(object sender, EventArgs e)
        {
            // Lập chứng từ phát hành
            if (MessageBox.Show("Thực hiện tạo chứng từ", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool checkTonTai = _logicChungTu.CheckKyKetToan(cmbKyChungTu.SelectedValue.ToString());
                if (checkTonTai == false)
                {
                    int count = _logicChungTu.CreateChungTu(PBean.USER.CardId, dateFromChuaPH.Value, dateToChuaPH.Value, cmbKyChungTu.SelectedValue.ToString(), PBean.USER.Id);
                    MessageBox.Show("Số chứng từ được tạo thành công:" + count.ToString(), PBean.MESSAGE_TITLE);
                }
                else
                {
                    MessageBox.Show("Kỳ kết toán đã có số liệu!", PBean.MESSAGE_TITLE);
                }
            }

        }

        private void btnChuyenKhoanChinhCOD_Click(object sender, EventArgs e)
        {
            frmChuyenKhoanCOD frm = new frmChuyenKhoanCOD();
            frm.ShowDialog();
        }

        private void btnPhatHanhChungTu_Click(object sender, EventArgs e)
        {
            frmPhatHanhChungTu frm = new frmPhatHanhChungTu();
            frm.ShowDialog();
        }

        private void btnTruyVanDaPhatHanh_Click(object sender, EventArgs e)
        {
            List<view_ExpChungTu> lsChungTu = _logicChungTu.GetDanhSachChungDaPhatHanh(dateFromPhatHanh.Value, dateToPhatHanh.Value, cmbKyKetToanPhatHanh.SelectedValue.ToString());
            lblCODDaPHHD.Text = PCommon.FormatNumber(lsChungTu.Where(w => w.FK_Customer != "0000").Sum(u => u.SoTienChi).ToString());
            lblPhiShipDaPHHD.Text = PCommon.FormatNumber(lsChungTu.Where(w => w.FK_Customer != "0000").Sum(u => u.SoTienThu).ToString());

            lblCODDaPHKL.Text = PCommon.FormatNumber(lsChungTu.Where(w => w.FK_Customer == "0000").Sum(u => u.SoTienChi).ToString());
            lblPhiShipDaPHKL.Text = PCommon.FormatNumber(lsChungTu.Where(w => w.FK_Customer == "0000").Sum(u => u.SoTienThu).ToString());

            dataGridDaPhatHanh.DataSource = lsChungTu;
        }

        private void dataGridDaPhatHanh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dataGridDaPhatHanh.SelectedRows[0].Index;
                string id = Convert.ToString(dataGridDaPhatHanh.Rows[index].Cells["col_IdDaPhatHanh"].Value);
                btnInBangKeHoaDon.Tag = id;
                List<view_ExpChungTuCt> ls = _logicChungTu.GetChiTietChungTu(id);
                gridChildDaPhatHanh.DataSource = ls;
                tabControlHoaDonChungTu.SelectedTab = tabChiTietDaPhatHanh;
                decimal TongCOD = ls.Sum(u => u.SoTienThuHo);
                decimal TongPhiVanChuyen = ls.Sum(u => u.CuocPhiVanChuyen);
                decimal TongPhiGuiTra = ls.Where(o => o.LoaiThanhToan == "Gửi thanh toán").Sum(u => u.CuocPhiVanChuyen);
                decimal CanTruCongNo = TongCOD - TongPhiGuiTra;
                lblChildThuHo.Text = PCommon.FormatNumber(TongCOD.ToString());
                lblChildPhiNhanTra.Text = PCommon.FormatNumber((TongPhiVanChuyen - TongPhiGuiTra).ToString());
                lblChildPhiGuiTra.Text = PCommon.FormatNumber(TongPhiGuiTra.ToString());
                lblChildSoTienCanTru.Text = PCommon.FormatNumber(CanTruCongNo.ToString());
                lblChildCountDaPhatHanh.Text = PCommon.FormatNumber(ls.Count.ToString());
            }
            catch
            {
            }
        }
        private void btnChildSoChiKhachLe_Click(object sender, EventArgs e)
        {
            if (btnInBangKeHoaDon.Tag != null)
            {
                // Phiếu chi COD
                DataTable printKetQua = _logicChungTu.GetChiTietBangKe(btnInBangKeHoaDon.Tag.ToString());
                Common.Report.LVReport report = new Common.Report.LVReport();
                string reportFile = AppDomain.CurrentDomain.BaseDirectory + PConstants.FOLDER_REPORT.TrimEnd('\\') + "\\SoChiTien.rpt";
                report.ShowReport(reportFile, "A4", true, "Sổ chi tiền thu hộ", PBean.MESSAGE_TITLE, printKetQua, true, false);
            }

        }
        private void btnInBangKeHoaDon_Click(object sender, EventArgs e)
        {
            if (btnInBangKeHoaDon.Tag != null)
            {
                DataTable printKetQua = _logicChungTu.GetChiTietBangKe(btnInBangKeHoaDon.Tag.ToString());
                Common.Report.LVReport report = new Common.Report.LVReport();
                string reportFile = AppDomain.CurrentDomain.BaseDirectory + PConstants.FOLDER_REPORT.TrimEnd('\\') + "\\BangKeHoaDon.rpt";
                report.ShowReport(reportFile, "A4", false, "Bảng kê hóa đơn", PBean.MESSAGE_TITLE, printKetQua, true, false);
            }
        }

        private void btnInPhieuChi_Click(object sender, EventArgs e)
        {
            if (btnInBangKeHoaDon.Tag != null)
            {
                // Phiếu chi COD
                DataTable printKetQua = _logicChungTu.GetPhieuChi(btnInBangKeHoaDon.Tag.ToString());
                Common.Report.LVReport report = new Common.Report.LVReport();
                string bangchu = PCommon.ChuyenSoThanhChu(printKetQua.Rows[0]["SoTienChi"].ToString());
                string reportFile = AppDomain.CurrentDomain.BaseDirectory + PConstants.FOLDER_REPORT.TrimEnd('\\') + "\\PhieuChi.rpt";
                report.ShowReport(reportFile, "A5", true, "Phiếu chi tiền thu hộ", PBean.MESSAGE_TITLE, printKetQua, true, false, "bangchu", bangchu);
            }

        }

        private void btnInBBCanTru_Click(object sender, EventArgs e)
        {
            if (btnInBangKeHoaDon.Tag != null)
            {
                DataTable printKetQua = _logicChungTu.GetPhieuChi(btnInBangKeHoaDon.Tag.ToString());
                Common.Report.LVReport report = new Common.Report.LVReport();
                string bangchuphiVC = PCommon.ChuyenSoThanhChu(printKetQua.Rows[0]["TongPhiGuiTra"].ToString());
                string bangchuThuHo = PCommon.ChuyenSoThanhChu(printKetQua.Rows[0]["TongThuHo"].ToString());
                string bangchuConLai = PCommon.ChuyenSoThanhChu(printKetQua.Rows[0]["SoTienChi"].ToString());
                string SoTienConLai = "";
                string benconno = "";
                decimal SoTienThu = decimal.Parse(printKetQua.Rows[0]["SoTienThu"].ToString());
                decimal SoTienChi = decimal.Parse(printKetQua.Rows[0]["SoTienChi"].ToString());
                if (SoTienChi > SoTienThu)
                {
                    SoTienConLai = PCommon.FormatNumber(SoTienChi.ToString());
                    benconno = "bên B còn nợ bên A ";
                }
                else
                {
                    SoTienConLai = PCommon.FormatNumber(SoTienThu.ToString());
                    benconno = "bên A còn nợ bên B ";
                }

                string reportFile = AppDomain.CurrentDomain.BaseDirectory + PConstants.FOLDER_REPORT.TrimEnd('\\') + "\\BienBanCanTruCongNo.rpt";
                report.ShowReport(reportFile, "A4", false, "Biên bản cấn trừ công nợ", PBean.MESSAGE_TITLE, printKetQua, true, false,
                    "bangchuphiVC", bangchuphiVC,
                    "bangchuThuHo", bangchuThuHo,
                    "bangchuConLai", bangchuConLai,
                    "SoTienConLai", SoTienConLai,
                    "benconno", benconno);
            }

        }

        private void btnBrowseSoChi_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Excel Files |*.xls";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtHangGuiSoChi.Text = open.FileName;
            }
        }

        private void btnTruyVanSoChi_Click(object sender, EventArgs e)
        {
            // Truy vấn dữ liệu sổ chi
            if (isBusyKhachLe)
            {
                MessageBox.Show("Có một tác vụ đang xử lý chưa kết thúc, vui lòng đợi!", PBean.MESSAGE_TITLE);
                return;
            }
            if (string.IsNullOrEmpty(txtHangGuiSoChi.Text))
            {
                MessageBox.Show("Vui lòng chọn file hàng gửi!", PBean.MESSAGE_TITLE);
                return;
            }
            dataKhachLeResult = new DataTable();

            btnLapChungTuKL.Enabled = false;
            dataKhachLe = GetDanhSachHangGuiExcelK10(txtHangGuiSoChi.Text, string.Empty);
            lblCountKhachLe.Text = PCommon.FormatNumber(dataKhachLe.Rows.Count.ToString());
            progressBarKhachLe.Value = 0;
            progressBarKhachLe.Maximum = dataKhachLe.Rows.Count;
            progressBarKhachLe.Minimum = 0;
            progressBarKhachLe.Visible = true;
            TongCODKL = 0;
            TongPhiNhanTraKL = 0;
            TongPhiGuiTraKL = 0;
            backgroundWorkerSoChi.RunWorkerAsync();

        }

        private void backgroundWorkerSoChi_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                int row = 1;
                dataKhachLeResult = dataKhachLe.Clone();
                foreach (DataRow item in dataKhachLe.Rows)
                {
                    // Kiểm tra là khách lẻ trước
                    string makhachang = item["Mã số khách hàng"].ToString();
                    if (makhachang == "20000")
                    {
                        item["SUM_ADDRESS"] = item["ACCEPT_MAN_ADDRESS"].ToString() + "," + item["ACCEPT_COUNTY_CODE"].ToString() + "," + item["ACCEPT_CITY_CODE"].ToString() + "," + item["ACCEPT_PROVINCE_CODE"].ToString();
                        // Xử lý số liệu trước
                        string mavandon = item["BILL_CODE"].ToString();
                        bool GiaoThanhCong = false;
                        bool addRowOnGrid = false;
                        bool ChuaDoiSoat = true;
                        string NoiDungTamUng = string.Empty;
                        item["CHI_PHI"] = "0";
                        item["EXPORT"] = "0";
                        item["GIAO_HANG_TC"] = "0";
                        if (item["DONE_ACCOUNT_CODE"].ToString() == "Không")
                        {
                            if (_logic.CheckHoaDonDoiSoatKL(mavandon) == false)
                            {
                                // Hệ thống bên mình vẫn chưa đối soát
                                ChuaDoiSoat = true;
                                NoiDungTamUng = _logic.CheckLoanCOD(mavandon);
                            }
                            else
                            {
                                // Hệ thống bên mình báo đã đối soát rồi
                                item["DONE_ACCOUNT_CODE"] = "TT Chưa nhập HĐ";
                                ChuaDoiSoat = false;
                            }
                        }
                        else
                        {
                            ChuaDoiSoat = false;
                        }

                        if (item["LOAI_KIEN"].ToString() == "Kiện nội tỉnh")
                        {
                            // Nội tỉnh
                            item["LOAI_KIEN"] = "Nội tỉnh";
                        }
                        else
                        {
                            // Ngoại tỉnh
                            item["LOAI_KIEN"] = "Ngoại tỉnh";
                        }

                        // Kiểm tra loại thanh toán
                        string payCod = item["PAYMENT_TYPE_CODE"].ToString();
                        if (payCod == "Nhận thanh toán")
                        {
                            item["LOAI_TT"] = "Nhận thanh toán";
                        }
                        else
                        {
                            item["LOAI_TT"] = "Gửi thanh toán";
                        }

                        // Kiểm tra đơn hoàn trả
                        if (item["IS_RETURN"].ToString() != "Không")
                        {
                            // Xét là đơn hoàn
                            item["STATUS_NAME"] = "Hoàn trả";
                            GiaoThanhCong = false;
                            addRowOnGrid = true;
                        }
                        else if (!string.IsNullOrEmpty(item["SIGN_DATE"].ToString()))
                        {
                            // Đã ký nhận
                            item["STATUS_NAME"] = "Giao thành công";
                            GiaoThanhCong = true;
                            addRowOnGrid = true;
                        }
                        else if (!string.IsNullOrEmpty(NoiDungTamUng))
                        {
                            if (NoiDungTamUng.Contains("tạm ứng"))
                            {
                                item["STATUS_NAME"] = "Tạm ứng";
                            }
                            else
                            {
                                item["STATUS_NAME"] = "Bồi thường";
                            }

                            GiaoThanhCong = true;
                            addRowOnGrid = true;
                        }
                        // Chưa đối soát
                        string idKhachHang = string.Empty;
                        if (ChuaDoiSoat == true)
                        {
                            if (lsMaKhachHang.FirstOrDefault(u => u.CustomerPhone == item["SEND_MAN_PHONE"].ToString().Trim()) == null)
                            {
                                ExpCustomer cusDataBase = _logic.GetCustomerDetail(item["SEND_MAN_PHONE"].ToString(), PBean.USER.CardId);
                                if (cusDataBase == null)
                                {
                                    cusDataBase = new ExpCustomer();
                                    cusDataBase.Id = Guid.NewGuid().ToString();
                                    cusDataBase.ContractCustomer = false;
                                    cusDataBase.CustomerName = item["SEND_MAN"].ToString().Trim();
                                    cusDataBase.CustomerPhone = item["SEND_MAN_PHONE"].ToString().Trim();
                                    cusDataBase.BankName = "NGÂN HÀNG ";
                                    cusDataBase.AccountCode = "SỐ TK";
                                    cusDataBase.UnsigName = PCommon.UnSigns(item["SEND_MAN"].ToString().Trim());
                                    cusDataBase.AccountName = item["SEND_MAN"].ToString().Trim();
                                    cusDataBase.GoogleMap = "Link Google Map";
                                    cusDataBase.FK_Post = PBean.USER.CardId;
                                    cusDataBase.CustomerCode = item["Mã số khách hàng"].ToString();
                                    if (cusDataBase.CustomerCode != "20000")
                                    {
                                        cusDataBase.ContractCustomer = true;
                                        cusDataBase.TenHopDong = item["SEND_MAN"].ToString().Trim();
                                        cusDataBase.NgayHopDong = DateTime.Now.AddDays(-3);
                                        cusDataBase.SoHopDong = cusDataBase.CustomerCode;
                                        cusDataBase.DiaChi = item["SEND_MAN_ADDRESS"].ToString().Trim();
                                    }
                                    cusDataBase.FK_GiaCuoc = "0000";

                                    _logic.CreateCustomer(cusDataBase);

                                }

                                item["CUSTOMER_CODE"] = cusDataBase.CustomerCode;
                                item["BANK_CODE"] = cusDataBase.AccountCode;
                                item["CHU_THE"] = cusDataBase.AccountName;
                                item["BANK_NAME"] = cusDataBase.BankName;

                                idKhachHang = cusDataBase.Id;

                                // Thêm vào bộ nhớ
                                lsMaKhachHang.Add(cusDataBase);
                            }
                            if (addRowOnGrid == true)
                            {
                                item["EXPORT"] = "1";
                                decimal phiVC = decimal.Parse(item["FREIGHT"].ToString());
                                decimal thuHo = decimal.Parse(item["GOODS_PAYMENT"].ToString());
                                decimal dieuChinhCK = _logic.GetCKCODBalance(mavandon);
                                item["COD_CK"] = dieuChinhCK;
                                thuHo = thuHo - dieuChinhCK;

                                if (GiaoThanhCong == true)
                                {
                                    TongCODKL = TongCODKL + thuHo;
                                    // Giao thành công bao gồm cả tạm ứng
                                    item["GIAO_HANG_TC"] = 1;
                                    item["FREIGHT"] = PCommon.FormatNumber(phiVC.ToString());
                                    item["GOODS_PAYMENT"] = PCommon.FormatNumber(thuHo.ToString());
                                    if (payCod == "Nhận thanh toán")
                                    {
                                        //Nhận thanh toán
                                        item["CHI_PHI"] = PCommon.FormatNumber(thuHo.ToString());
                                        TongPhiNhanTraKL = TongPhiNhanTraKL + phiVC;
                                    }
                                    else
                                    {
                                        //Gửi thanh toán
                                        item["CHI_PHI"] = PCommon.FormatNumber((thuHo - phiVC).ToString());
                                        TongPhiGuiTraKL = TongPhiGuiTraKL + phiVC;
                                    }
                                    string BalanceMess = string.Empty;
                                    // Kiểm tra tiền có vào K9 hay không?
                                    if (thuHo == 0)
                                    {
                                        item["K9_BALANCE"] = "0 đồng";
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(NoiDungTamUng))
                                        {
                                            //SDSHK-F
                                            decimal outCOD;

                                            BalanceMess += _logic.CheckCODBalance(mavandon, PBean.USER.CardId, thuHo, out outCOD);
                                            if (payCod == "Nhận thanh toán")
                                            {
                                                decimal outPhiVC;
                                                BalanceMess += _logic.CheckFeeBalance(mavandon, PBean.USER.CardId, phiVC, out outPhiVC);
                                            }
                                        }
                                        else
                                        {
                                            BalanceMess = NoiDungTamUng;
                                        }

                                    }
                                    item["K9_BALANCE"] = BalanceMess;
                                }
                                else
                                {
                                    // Hoàn trả
                                    // Giao hàng thất bại thì mình trừ phí vận chuyển
                                    item["CHI_PHI"] = "-" + PCommon.FormatNumber(phiVC.ToString());
                                    item["GOODS_PAYMENT"] = 0;
                                }

                                //// Kiểm tra cước phí
                                //decimal phiVanChuyenTinhToan = _logic.GetFeeCalculator(item["ACCEPT_PROVINCE_CODE"].ToString(), item["BILL_WEIGHT"].ToString(), idKhachHang);
                                //if (Math.Abs(phiVC - phiVanChuyenTinhToan) > 1000)
                                //{
                                //    item["VUNG_MIEN"] = "SAI CƯỚC PHÍ";
                                //}
                                //item["AUTO_FREIGHT"] = PCommon.FormatNumber(phiVanChuyenTinhToan.ToString());

                                item["STT"] = row.ToString();
                                row++;
                                dataKhachLeResult.ImportRow(item);
                            }
                        }
                        else
                        {
                            // Đã được đối soát
                        }

                        backgroundWorkerSoChi.ReportProgress(row);
                    }
                    else
                    {
                        backgroundWorkerSoChi.ReportProgress(row);
                    }
                }
            }
            catch
            {
            }
        }

        private void backgroundWorkerSoChi_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarKhachLe.PerformStep();
        }

        private void backgroundWorkerSoChi_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblCODKL.Text = PCommon.FormatNumber(TongCODKL.ToString());
            lblPhiNhanTraKL.Text = PCommon.FormatNumber(TongPhiNhanTraKL.ToString());
            lblPhiGuiTraKL.Text = PCommon.FormatNumber(TongPhiGuiTraKL.ToString());
            btnLapChungTuKL.Enabled = true;
            progressBarKhachLe.Visible = false;
            lblCountKhachLe.Text = PCommon.FormatNumber(dataKhachLeResult.Rows.Count.ToString());
            dataGridKhachLe.AutoGenerateColumns = false;
            dataGridKhachLe.DataSource = dataKhachLeResult;
            isBusyKhachLe = false;
        }

        private void btnLapChungTuKL_Click(object sender, EventArgs e)
        {
            // Lập chứng từ
            // Lập chứng từ phát hành
            if (MessageBox.Show("Thực hiện tạo chứng từ", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                int count = _logicChungTu.CreateChungTu(dataKhachLeResult, PBean.USER.CardId, cmbKyChungTu.SelectedValue.ToString(), PBean.USER.Id);
                MessageBox.Show("Số chứng từ được tạo thành công:" + count.ToString(), PBean.MESSAGE_TITLE);
            }
        }

        private void btnNhapDonHang_Click(object sender, EventArgs e)
        {
            frmNhapDonHang frm = new frmNhapDonHang();
            frm.ShowDialog();
        }

        private void btnNhapChiTietKetToan_Click(object sender, EventArgs e)
        {
            frmNhapKetToan frm = new frmNhapKetToan();
            frm.ShowDialog();
        }

        private void btnBrowserNinja_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Excel Files |*.xls";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtHangGuiNinja.Text = open.FileName;
                btnTruyVanNinja.Enabled = true;
            }
            else
            {
                btnTruyVanNinja.Enabled = false;
            }
        }

        private void btnTruyVanNinja_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtHangGuiNinja.Text.Trim()))
            {
                TongCODNinJa = 0;
                dataNinjaTemp = GetDanhSachHangGuiExcelK10(txtHangGuiNinja.Text, string.Empty);
                dataNinja = dataNinjaTemp.Clone();
                int row = 1;
                foreach (DataRow item in dataNinjaTemp.Rows)
                {
                    int soKien = Int32.Parse(item["Số kiện"].ToString());
                    string maVanDon = item["BILL_CODE"].ToString();

                    string payCod = item["PAYMENT_TYPE_CODE"].ToString();
                    decimal phiVC = decimal.Parse(item["FREIGHT"].ToString());
                    decimal thuHo = decimal.Parse(item["GOODS_PAYMENT"].ToString());
                    decimal canNang = decimal.Parse(item["BILL_WEIGHT"].ToString());
                    if (soKien > 1)
                    {
                        thuHo = Math.Round(thuHo / soKien);
                        phiVC = Math.Round(phiVC / soKien);
                        canNang = Math.Round(canNang / soKien, 1);
                        item["BILL_CODE"] = "'" + maVanDon + "D00";
                    }
                    else
                    {
                        item["BILL_CODE"] = "'" + item["BILL_CODE"].ToString();
                    }
                    item["BILL_WEIGHT"] = canNang.ToString();
                    item["SUM_ADDRESS"] = item["ACCEPT_MAN_ADDRESS"].ToString() + "," + item["ACCEPT_COUNTY_CODE"].ToString() + "," + item["ACCEPT_CITY_CODE"].ToString() + "," + item["ACCEPT_PROVINCE_CODE"].ToString();

                    if (payCod == "Nhận thanh toán")
                    {
                        item["LOAI_TT"] = "Nhận thanh toán";
                        item["GOODS_PAYMENT"] = thuHo + phiVC;
                    }
                    else
                    {
                        item["LOAI_TT"] = "Gửi thanh toán";
                        item["GOODS_PAYMENT"] = thuHo;
                    }

                    if (canNang <= 4)
                    {
                        item["LOAI_KH"] = "S";
                    }
                    else if (canNang <= 10)
                    {
                        item["LOAI_KH"] = "M";
                    }
                    else if (canNang <= 20)
                    {
                        item["LOAI_KH"] = "L";
                    }
                    else if (canNang <= 30)
                    {
                        item["LOAI_KH"] = "XL";
                    }
                    else
                    {
                        item["LOAI_KH"] = "XXL";
                    }
                    //Qui tắc kiểm tra hàng
                    item["VUNG_MIEN"] = item["Loại mặt hàng"].ToString() + " - Người gửi: " + item["SEND_MAN"] + " - ĐC:" + item["SEND_MAN_ADDRESS"].ToString() + " (" + canNang.ToString() + " Kg)";
                    item["COD_CK"] = 0;
                    string ghiChu = item["Ghi chú"].ToString().Trim();
                    if (string.IsNullOrEmpty(ghiChu))
                    {
                        item["AUTO_FREIGHT"] = item["Qui tắc kiểm tra hàng"].ToString() + ". Đơn hàng có vấn đề vui lòng liên hệ số điện thoại 0888.859.256. Không tự ý hoàn hàng, xin cảm ơn!";
                    }
                    else
                    {
                        item["AUTO_FREIGHT"] = item["Qui tắc kiểm tra hàng"].ToString() + ". " + item["Ghi chú"].ToString();
                    }
                    item["STT"] = row;
                    row++;
                    TongCODNinJa += thuHo;
                    dataNinja.ImportRow(item);

                    for (int i = 1; i < soKien; i++)
                    {
                        DataRow subItem = dataNinja.NewRow();
                        subItem.ItemArray = item.ItemArray as object[];
                        subItem["BILL_CODE"] = "'" + maVanDon + "D" + i.ToString().PadLeft(2, '0');
                        subItem["STT"] = row;
                        TongCODNinJa += thuHo;
                        row++;
                        dataNinja.Rows.Add(subItem);
                    }
                }
                dataGridNinja.AutoGenerateColumns = false;
                dataGridNinja.DataSource = dataNinja;
                lblCountNinja.Text = dataNinja.Rows.Count.ToString();
                lblTongCodNinja.Text = PCommon.FormatNumber(TongCODNinJa.ToString());
                if (dataNinja.Rows.Count > 0)
                {
                    btnExcelNija.Enabled = true;
                }
                else
                {
                    btnExcelNija.Enabled = false;
                }
            }
        }

        private void btnExcelNija_Click(object sender, EventArgs e)
        {
            if (dataNinja.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "HANG_GUI_NINJA_" + string.Format("{0:dd_MM_yyyy_(HH_mm)}", DateTime.Now);
                save.Filter = "Excel Files | *.xlsx";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string templateFileName = AppDomain.CurrentDomain.BaseDirectory + "Templates\\NINJA_TEMPLATE.xlsx";
                    Dictionary<string, string> lsReplace = new Dictionary<string, string>();
                    Dictionary<string, string> lsTitile = new Dictionary<string, string>();
                    ExportDataToExcelTemplate.Export(templateFileName, save.FileName, 1, dataNinja, lsTitile, lsReplace, false);
                    MessageBox.Show("Xuất file excel thành công!", PBean.MESSAGE_TITLE);
                }
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu vui lòng thực hiện truy vấn dữ liệu trước khi xuất Excel", PBean.MESSAGE_TITLE);
            }
        }

        private void btnExitNinja_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewTong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //lấy index của dòng đầu tiên được chọn
                int index = dataGridViewTong.SelectedRows[0].Index;
                string loaiChiPhi = Convert.ToString(dataGridViewTong.Rows[index].Cells["colGridTongChiPhi"].Value);
                loaiChiPhi = "'" + loaiChiPhi + "'";
                string mavandon = GetMultiBillCode();
                GetDetailBalance(loaiChiPhi, mavandon);
                tabChiTietKetToan.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private void btnXuatExcelKT_Click(object sender, EventArgs e)
        {
            // Xuất excel
            if (lsChiTietKetToan.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "KetToanChiTiet";
                save.Filter = "Excel Files | *.xlsx";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string templateFileName = AppDomain.CurrentDomain.BaseDirectory + "Templates\\BASIC_TEMPLATE.xlsx";
                    Dictionary<string, string> lsReplace = new Dictionary<string, string>();
                    Dictionary<string, string> lsTitile = new Dictionary<string, string>();
                    DataTable data = MapperExtensionClass.ToDataTable<ExpBalanceDetail>(lsChiTietKetToan);
                    ExportDataToExcelTemplate.Export(templateFileName, save.FileName, 1, data, lsTitile, lsReplace);
                    MessageBox.Show("Xuất file excel thành công!", PBean.MESSAGE_TITLE);
                }
            }
        }

        private void btnReportTotalRutCod_Click(object sender, EventArgs e)
        {
            // Report
            DateTime? dateFromCod = null;
            DateTime? dateToCod = null;
            DateTime tempDate;
            if (DateTime.TryParse(cmbKyRutTienFrom.SelectedValue.ToString(), out tempDate))
            {
                if (tempDate.Year > 2020)
                    dateFromCod = tempDate;


            }
            if (DateTime.TryParse(cmbKyRutTienTo.SelectedValue.ToString(), out tempDate))
            {
                if (tempDate.Year > 2020)
                    dateToCod = tempDate;
            }
            if (dateFromCod == null && dateToCod == null)
            {
                dateFromCod = dateFromKT.Value;
                dateToCod = dateToKT.Value;
            }
            string TieuDeBaoCao = "";
            if (dateFromCod != null)
            {
                TieuDeBaoCao = "TỪ NGÀY " + string.Format("{0:dd/MM/yyyy HH:mm:ss}", dateFromCod);
            }
            if (dateToCod != null)
            {
                TieuDeBaoCao += " ĐẾN NGÀY " + string.Format("{0:dd/MM/yyyy HH:mm:ss}", dateToCod);
            }
            TieuDeBaoCao = TieuDeBaoCao.Trim();
            List<view_BaoCaoTaiChinh> lsBaoCaoTaiChinh = new List<view_BaoCaoTaiChinh>();
            List<ExpBalanceDetail> expBalanceDetails = _logic.GetBalanceDetailList(dateFromCod, dateToCod, out lsBaoCaoTaiChinh);
            if (expBalanceDetails.Count <= 0)
            {
                MessageBox.Show("Không thấy dữ liệu cần hiển thị báo cáo", PBean.MESSAGE_TITLE);
                return;
            }
            // Lấy dữ liệu xử lý
            // where LoaiTaiKhoan<>N'Tài khoản chung' AND LoaiTaiKhoan<>N'普通账户' AND LoaiTaiKhoan<>N'Tài khoản COD' AND LoaiTaiKhoan<>N'代收货款账户' 
            ExpBalanceDetail taiKhoanThuongDau = expBalanceDetails.FirstOrDefault(u => (u.LoaiTaiKhoan == "Tài khoản chung" || u.LoaiTaiKhoan == "普通账户") && u.MaDaiLy == PBean.USER.IdAccountIntro);
            ExpBalanceDetail taiKhoanThuongCuoi = expBalanceDetails.LastOrDefault(u => (u.LoaiTaiKhoan == "Tài khoản chung" || u.LoaiTaiKhoan == "普通账户") && u.MaDaiLy == PBean.USER.IdAccountIntro);

            ExpBalanceDetail taiKhoanCODDau = expBalanceDetails.FirstOrDefault(u => (u.LoaiTaiKhoan == "Tài khoản COD" || u.LoaiTaiKhoan == "代收货款账户") && u.MaDaiLy == PBean.USER.IdAccountIntro);
            ExpBalanceDetail taiKhoanCODCuoi = expBalanceDetails.LastOrDefault(u => (u.LoaiTaiKhoan == "Tài khoản COD" || u.LoaiTaiKhoan == "代收货款账户") && u.MaDaiLy == PBean.USER.IdAccountIntro);

            string TKTDauKy = PCommon.FormatNumber(taiKhoanThuongDau.SoDuTruoc.ToString());
            string TKTCuoiKy = PCommon.FormatNumber(taiKhoanThuongCuoi.SoDuSau.ToString());
            var sumTKTTang = expBalanceDetails.Where(u => (u.LoaiTaiKhoan == "Tài khoản chung" || u.LoaiTaiKhoan == "普通账户") && u.MaDaiLy == PBean.USER.IdAccountIntro && u.MaChiPhi.Contains("-F")).Sum(s => s.SoTien);
            var sumTKTGiam = expBalanceDetails.Where(u => (u.LoaiTaiKhoan == "Tài khoản chung" || u.LoaiTaiKhoan == "普通账户") && u.MaDaiLy == PBean.USER.IdAccountIntro && u.MaChiPhi.Contains("-S")).Sum(s => s.SoTien);
            string TKTThayDoi = PCommon.FormatNumber((sumTKTTang - sumTKTGiam).ToString());
            string TKTTang = PCommon.FormatNumber(sumTKTTang.ToString());
            string TKTGiam = PCommon.FormatNumber(sumTKTGiam.ToString());

            string CODDauKy = PCommon.FormatNumber(taiKhoanCODDau.SoDuTruoc.ToString());
            string CODCuoiKy = PCommon.FormatNumber(taiKhoanCODCuoi.SoDuSau.ToString());
            var sumCODTang = expBalanceDetails.Where(u => (u.LoaiTaiKhoan == "Tài khoản COD" || u.LoaiTaiKhoan == "代收货款账户") && u.MaDaiLy == PBean.USER.IdAccountIntro && u.MaChiPhi.Contains("-F")).Sum(s => s.SoTien);
            var sumCODGiam = expBalanceDetails.Where(u => (u.LoaiTaiKhoan == "Tài khoản COD" || u.LoaiTaiKhoan == "代收货款账户") && u.MaDaiLy == PBean.USER.IdAccountIntro && u.MaChiPhi.Contains("-S")).Sum(s => s.SoTien);
            string CODThayDoi = PCommon.FormatNumber((sumCODTang - sumCODGiam).ToString());
            string CODTang = PCommon.FormatNumber(sumCODTang.ToString());
            string CODGiam = PCommon.FormatNumber(sumCODGiam.ToString());

            string DSCODTong = PCommon.FormatNumber(expBalanceDetails.Where(u => u.MaChiPhi == "SDSHK-F" && u.MaDaiLy == PBean.USER.IdAccountIntro).Sum(s => s.SoTien).ToString());
            string DSPhiNhanTra = PCommon.FormatNumber(expBalanceDetails.Where(u => u.MaChiPhi == "PDFK-F" && u.MaDaiLy == PBean.USER.IdAccountIntro).Sum(s => s.SoTien).ToString());

            var dDSCODKL = lsBaoCaoTaiChinh.Where(u => u.MaDaiLy == PBean.USER.IdAccountIntro && u.ContractCustomer == false).Sum(s => s.GOODS_PAYMENT);
            var dDSPNTKL = lsBaoCaoTaiChinh.Where(u => u.MaDaiLy == PBean.USER.IdAccountIntro && u.PAY_TYPE == "Nhận thanh toán" && u.ContractCustomer == false).Sum(s => s.FREIGHT);
            var dDSPGTKL = lsBaoCaoTaiChinh.Where(u => u.MaDaiLy == PBean.USER.IdAccountIntro && u.PAY_TYPE == "Gửi thanh toán" && u.ContractCustomer == false).Sum(s => s.FREIGHT);
            string DSCODKL = PCommon.FormatNumber(dDSCODKL.ToString());
            string DSPNTKL = PCommon.FormatNumber(dDSPNTKL.ToString());
            string DSPGTKL = PCommon.FormatNumber(dDSPGTKL.ToString());
            string DSChiTienKL = PCommon.FormatNumber((dDSCODKL - dDSPGTKL).ToString());

            var dDSCODHD = lsBaoCaoTaiChinh.Where(u => u.MaDaiLy == PBean.USER.IdAccountIntro && u.ContractCustomer == true).Sum(s => s.GOODS_PAYMENT);
            var dDSPNTHD = lsBaoCaoTaiChinh.Where(u => u.MaDaiLy == PBean.USER.IdAccountIntro && u.PAY_TYPE == "Nhận thanh toán" && u.ContractCustomer == true).Sum(s => s.FREIGHT);
            var dDSPGTHD = lsBaoCaoTaiChinh.Where(u => u.MaDaiLy == PBean.USER.IdAccountIntro && u.PAY_TYPE == "Gửi thanh toán" && u.ContractCustomer == true).Sum(s => s.FREIGHT);
            string DSCODHD = PCommon.FormatNumber(dDSCODHD.ToString());
            string DSPNTHD = PCommon.FormatNumber(dDSPNTHD.ToString());
            string DSPGTHD = PCommon.FormatNumber(dDSPGTHD.ToString());
            string DSChiTienHD = PCommon.FormatNumber((dDSCODHD - dDSPGTHD).ToString());

            var dDSTCODHD = lsBaoCaoTaiChinh.Where(u => u.MaDaiLy == PBean.USER.IdAccountIntro).Sum(s => s.GOODS_PAYMENT);
            var dDSTPNTHD = lsBaoCaoTaiChinh.Where(u => u.MaDaiLy == PBean.USER.IdAccountIntro && u.PAY_TYPE == "Nhận thanh toán").Sum(s => s.FREIGHT);
            var dDSTPGTHD = lsBaoCaoTaiChinh.Where(u => u.MaDaiLy == PBean.USER.IdAccountIntro && u.PAY_TYPE == "Gửi thanh toán").Sum(s => s.FREIGHT);
            string DSTCODHD = PCommon.FormatNumber(dDSTCODHD.ToString());
            string DSTPNTHD = PCommon.FormatNumber(dDSTPNTHD.ToString());
            string DSTPGTHD = PCommon.FormatNumber(dDSTPGTHD.ToString());
            string DSTChiTienHD = PCommon.FormatNumber((dDSTCODHD - dDSTPGTHD).ToString());

            var ChiPhi = lsBaoCaoTaiChinh.Where(u => u.MaDaiLy == PBean.USER.IdAccountIntro).Sum(s => s.SUM_CHIPHI);
            var CuocPhi = lsBaoCaoTaiChinh.Where(u => u.MaDaiLy == PBean.USER.IdAccountIntro).Sum(s => s.FREIGHT);
            string DSChiPhi = PCommon.FormatNumber(ChiPhi.ToString());
            string DSCuocPhi = PCommon.FormatNumber(CuocPhi.ToString());
            string DSLoiNhuan = PCommon.FormatNumber((CuocPhi - ChiPhi).ToString());

            List<ExpCODCK> lsChuyenKhoan = _logic.GetCODCKList(dateFromCod, dateToCod);

            List<ExpLoanCod> lsTamUng = _logic.GetLoanCODList(dateFromCod, dateToCod);

            string SUMBT = PCommon.FormatNumber(lsTamUng.Where(u => u.IsBoiThuong == true).Sum(s => s.Value).ToString());
            string COUNTBT = PCommon.FormatNumber(lsTamUng.Where(u => u.IsBoiThuong == true).Count().ToString());

            string SUMTU = PCommon.FormatNumber(lsTamUng.Where(u => u.IsBoiThuong == false).Sum(s => s.Value).ToString());
            string COUNTTU = PCommon.FormatNumber(lsTamUng.Where(u => u.IsBoiThuong == false).Count().ToString());

            string SUMCK = PCommon.FormatNumber(lsChuyenKhoan.Sum(s => s.SoTienCKCOD).ToString());
            string COUNTCK = PCommon.FormatNumber(lsChuyenKhoan.Count().ToString());
            // Lấy các số liệu tổng hợp
            //DataTable printKetQua = new DataTable();
            Common.Report.LVReport report = new Common.Report.LVReport();
            string reportFile = AppDomain.CurrentDomain.BaseDirectory + PConstants.FOLDER_REPORT.TrimEnd('\\') + "\\BaoCaoTaiChinh.rpt";
            report.ShowReport(reportFile, "A4", true, "Báo cáo số liệu tài chính giữa kỳ rút tiền", PBean.MESSAGE_TITLE, expBalanceDetails, true, false,
                "TieuDeBaoCao", TieuDeBaoCao,
                "TKTDauKy", TKTDauKy,
                "TKTCuoiKy", TKTCuoiKy,
                "TKTThayDoi", TKTThayDoi,
                "TKTTang", TKTTang,
                "TKTGiam", TKTGiam,
                "CODDauKy", CODDauKy,
                "CODCuoiKy", CODCuoiKy,
                "CODThayDoi", CODThayDoi,
                "CODTang", CODTang,
                "CODGiam", CODGiam,
                "DSCODTong", DSCODTong,
                "DSPhiNhanTra", DSPhiNhanTra,
                "DSCODKL", DSCODKL,
                "DSPNTKL", DSPNTKL,
                "DSPGTKL", DSPGTKL,
                "DSChiTienKL", DSChiTienKL,
                "DSCODHD", DSCODHD,
                "DSPNTHD", DSPNTHD,
                "DSPGTHD", DSPGTHD,
                "DSChiTienHD", DSChiTienHD,
                "DSTCODHD", DSTCODHD,
                "DSTPNTHD", DSTPNTHD,
                "DSTPGTHD", DSTPGTHD,
                "DSTChiTienHD", DSTChiTienHD,
                "DSChiPhi", DSChiPhi,
                "DSCuocPhi", DSCuocPhi,
                "DSLoiNhuan", DSLoiNhuan,
                "SUMBT", SUMBT,
                "COUNTBT", COUNTBT,
                "SUMTU", SUMTU,
                "COUNTTU", COUNTTU,
                "SUMCK", SUMCK,
                "COUNTCK", COUNTCK);
        }

        private void btnKiemTraLoiTaiChinh_Click(object sender, EventArgs e)
        {
            if (isBusyCheckKT)
            {
                MessageBox.Show("Có một tác vụ đang xử lý chưa kết thúc, vui lòng đợi!", PBean.MESSAGE_TITLE);
                return;
            }
            // Report
            DateTime? dateFromCod = null;
            DateTime? dateToCod = null;
            DateTime tempDate;
            if (DateTime.TryParse(cmbKyRutTienFrom.SelectedValue.ToString(), out tempDate))
            {
                if (tempDate.Year > 2020)
                    dateFromCod = tempDate;
            }
            if (DateTime.TryParse(cmbKyRutTienTo.SelectedValue.ToString(), out tempDate))
            {
                if (tempDate.Year > 2020)
                    dateToCod = tempDate;
            }
            if (dateFromCod == null && dateToCod == null)
            {
                dateFromCod = dateFromKT.Value;
                dateToCod = dateToKT.Value;
            }
            string TieuDeBaoCao = "";
            if (dateFromCod != null)
            {
                TieuDeBaoCao = "TỪ NGÀY " + string.Format("{0:dd/MM/yyyy HH:mm:ss}", dateFromCod);
            }
            if (dateToCod != null)
            {
                TieuDeBaoCao += " ĐẾN NGÀY " + string.Format("{0:dd/MM/yyyy HH:mm:ss}", dateToCod);
            }
            TieuDeBaoCao = TieuDeBaoCao.Trim();
            lsInputCheckErrorBalanceDetail = _logic.GetBalanceDetailListC2(dateFromCod, dateToCod, PBean.USER.IdAccountIntro);
            lsError = new List<ExpBalanceDetail>();
            if (lsInputCheckErrorBalanceDetail.Count <= 0)
            {
                MessageBox.Show("Không thấy dữ liệu cần kiểm tra", PBean.MESSAGE_TITLE);
                return;
            }
            var checkList = lsInputCheckErrorBalanceDetail.Select(m => new { m.BILL_CODE, m.MaDaiLy }).Distinct().ToList();
            progressBarCheckLoiKT.Value = 0;
            progressBarCheckLoiKT.Maximum = checkList.Count;
            lblCheckLoiKT.Text = checkList.Count.ToString();
            progressBarCheckLoiKT.Visible = true;
            isBusyCheckKT = true;
            backgroundWorkerCheckLoiKT.RunWorkerAsync();
        }

        private void backgroundWorkerCheckLoiKT_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                List<ExpBalanceDetailType> lsType = _logic.GetBalanceTypeList();
                var checkList = lsInputCheckErrorBalanceDetail.Select(m => new { m.BILL_CODE, m.MaDaiLy }).Distinct().ToList();
                foreach (var detailC2 in checkList)
                {
                    foreach (var maChiPhi in lsType)
                    {
                        int countC1;
                        decimal sumC1 = _logic.CheckSumAndCountBalanceDetail(detailC2.BILL_CODE, maChiPhi.Id, PBean.USER.IdAccountIntro, out countC1);
                        int countC2;
                        decimal sumC2 = _logic.CheckSumAndCountBalanceDetail(detailC2.BILL_CODE, maChiPhi.Id, detailC2.MaDaiLy, out countC2);
                        if (sumC1 != sumC2 || countC1 != countC2)
                        {
                            // Kiểm tra thấy sai thì chơi như vầy.
                            ExpBalanceDetail error = new ExpBalanceDetail();
                            error.BILL_CODE = "'" + detailC2.BILL_CODE;
                            error.MaDaiLy = detailC2.MaDaiLy;
                            error.MaChiPhi = maChiPhi.Id;
                            error.TenChiPhi = maChiPhi.BalanceTypeName;
                            error.SoDuTruoc = sumC1; // C1 SUM
                            error.SoTien = countC1; // C1 Count
                            error.SoDuSau = sumC2; // C2 SUM
                            error.TrongLuongThanhToan = countC2; // C2 Count
                            lsError.Add(error);
                        }
                    }
                    backgroundWorkerCheckLoiKT.ReportProgress(0);
                }
            }
            catch
            {
            }
        }

        private void backgroundWorkerCheckLoiKT_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarCheckLoiKT.PerformStep();
        }
        private void backgroundWorkerCheckLoiKT_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarCheckLoiKT.Visible = false;
            isBusyCheckKT = false;
            if (lsError.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "Error_KTCT_" + string.Format("{0:yyyy_MM_dd.hh.mm}", DateTime.Now);
                save.Filter = "Excel Files | *.xlsx";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string templateFileName = AppDomain.CurrentDomain.BaseDirectory + "Templates\\BAO_CAO_LOI_KT.xlsx";
                    Dictionary<string, string> lsReplace = new Dictionary<string, string>();
                    Dictionary<string, string> lsTitile = new Dictionary<string, string>();
                    DataTable data = MapperExtensionClass.ToDataTable<ExpBalanceDetail>(lsError);
                    ExportDataToExcelTemplate.Export(templateFileName, save.FileName, 1, data, lsTitile, lsReplace);
                    MessageBox.Show("Xuất file excel thành công!", PBean.MESSAGE_TITLE);
                }
            }
        }

        private void btnCheckTaiChinhDoiSoat_Click(object sender, EventArgs e)
        {
            // Kiểm tra phần đối soát khách hàng của báo cáo tài chính và phần đối soát khách hàng có hóa đơn.
            string filename = string.Empty;
            try
            {

                FolderBrowserDialog folder = new FolderBrowserDialog();
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    DirectoryInfo directory = new DirectoryInfo(folder.SelectedPath);
                    FileInfo[] files = directory.GetFiles("*.xlsx");
                    List<BaoCaoKTDS> lsBaoCao = new List<BaoCaoKTDS>();
                    int soDoiSoat = 0;
                    int soCOD = 0;
                    int soGH = 0;
                    foreach (FileInfo item in files)
                    {
                        filename = item.FullName;
                        DataTable data = ExportDataToExcelTemplate.ReadAsDataTable(item.FullName);
                        if (data.Rows.Count > 0)
                        {

                            foreach (DataRow row in data.Rows)
                            {
                                BaoCaoKTDS baocao = new BaoCaoKTDS();
                                baocao.BILL_CODE = row["Mã vận đơn"].ToString().Trim();
                                if (!string.IsNullOrEmpty(baocao.BILL_CODE))
                                {
                                    baocao.BILL_CODE = baocao.BILL_CODE;
                                    baocao.GIAO_TC = row["Ghi chú"].ToString();
                                    baocao.MA_DAI_LY = "_";
                                    baocao.CHECK_DS = "V";
                                    baocao.CHECK_COD = "X";
                                    baocao.CHECK_GH = "X";
                                    baocao.COD_DATE = "_";
                                    baocao.COD_DATE_TIME = "_";
                                    baocao.COD_DATE_TIME_OUT = "_";
                                    string sotien = row["Số tiền thu hộ"].ToString().Replace(",", "");
                                    decimal dTemp;
                                    if (!decimal.TryParse(sotien, out dTemp))
                                    {
                                        dTemp = -1;
                                    }
                                    baocao.COD_DOI_SOAT = dTemp;
                                    baocao.COD_KT = 0;
                                    baocao.NOTE = "_";
                                    baocao.PHI_GUI_TRA = 0;
                                    baocao.PHI_NHAN_TRA = 0;
                                    if (!decimal.TryParse(row["Phí vận chuyển"].ToString().Replace(",", ""), out dTemp))
                                    {
                                        dTemp = -1;
                                    }
                                    baocao.PHI_VC = dTemp;

                                    if (!decimal.TryParse(row["Số tiền hoàn trả"].ToString().Replace(",", ""), out dTemp))
                                    {
                                        dTemp = -1;
                                    }
                                    decimal hoanTra = dTemp;
                                    if (hoanTra == baocao.COD_DOI_SOAT)
                                    {
                                        baocao.PHI_NHAN_TRA = baocao.PHI_VC;
                                    }
                                    else
                                    {
                                        baocao.PHI_GUI_TRA = baocao.PHI_VC;
                                    }
                                    lsBaoCao.Add(baocao);
                                }

                            }
                        }
                    }
                    soDoiSoat = lsBaoCao.Count;
                    // Báo cáo tài chính
                    DateTime? dateFromCod = null;
                    DateTime? dateToCod = null;
                    DateTime tempDate;
                    if (DateTime.TryParse(cmbKyRutTienFrom.SelectedValue.ToString(), out tempDate))
                    {
                        if (tempDate.Year > 2020)
                            dateFromCod = tempDate;
                    }
                    if (DateTime.TryParse(cmbKyRutTienTo.SelectedValue.ToString(), out tempDate))
                    {
                        if (tempDate.Year > 2020)
                            dateToCod = tempDate;
                    }
                    if (dateFromCod == null && dateToCod == null)
                    {
                        dateFromCod = dateFromKT.Value;
                        dateToCod = dateToKT.Value;
                    }
                    string TieuDeBaoCao = "";
                    if (dateFromCod != null)
                    {
                        TieuDeBaoCao = "TỪ NGÀY " + string.Format("{0:dd/MM/yyyy HH:mm:ss}", dateFromCod);
                    }
                    if (dateToCod != null)
                    {
                        TieuDeBaoCao += " ĐẾN NGÀY " + string.Format("{0:dd/MM/yyyy HH:mm:ss}", dateToCod);
                    }
                    TieuDeBaoCao = TieuDeBaoCao.Trim();
                    List<view_BaoCaoTaiChinh> lsBaoCaoTaiChinh = new List<view_BaoCaoTaiChinh>();
                    List<ExpBalanceDetail> expBalanceDetails = _logic.GetBalanceDetailList(dateFromCod, dateToCod, out lsBaoCaoTaiChinh); //SDSHK-F  PDFK-F  PJF-S
                    if (expBalanceDetails.Count <= 0)
                    {
                        MessageBox.Show("Không thấy dữ liệu cần đối chiếu", PBean.MESSAGE_TITLE);
                        return;
                    }
                    // Kiểm tra dữ liệu có nằm trong khoảng data của kết toán
                    List<ExpBalanceDetail> lsDetailFilter = expBalanceDetails.Where(u => u.MaChiPhi == "PJF-S" && u.MaDaiLy == PBean.USER.IdAccountIntro).ToList();
                    soGH = lsDetailFilter.Count;
                    foreach (var item in lsDetailFilter)
                    {
                        BaoCaoKTDS baocao = lsBaoCao.FirstOrDefault(u => u.BILL_CODE == item.BILL_CODE);
                        if (baocao == null)
                        {
                            baocao = new BaoCaoKTDS();
                            baocao.BILL_CODE = item.BILL_CODE;
                            baocao.GIAO_TC = "1";
                            baocao.MA_DAI_LY = item.MaDaiLy;
                            ExpBalanceDetail checkDaiLy = expBalanceDetails.FirstOrDefault(u => u.BILL_CODE == item.BILL_CODE && u.MaChiPhi == "PJF-S" && u.MaDaiLy != PBean.USER.IdAccountIntro);
                            if (checkDaiLy != null)
                            {
                                baocao.MA_DAI_LY = checkDaiLy.MaDaiLy;
                            }
                            baocao.CHECK_DS = "X";
                            baocao.CHECK_COD = "X";
                            baocao.CHECK_GH = "V";
                            baocao.COD_DOI_SOAT = 0;
                            baocao.COD_KT = 0;
                            baocao.COD_DATE = "_";
                            baocao.COD_DATE_TIME = "_";
                            baocao.COD_DATE_TIME_OUT = "_";
                            baocao.NOTE = "_";
                            baocao.PHI_GUI_TRA = 0;
                            baocao.PHI_NHAN_TRA = 0;
                            baocao.PHI_VC = 0;
                            baocao.PHI_NHAN_TRA = 0;
                            baocao.PHI_GUI_TRA = 0;
                            lsBaoCao.Add(baocao);
                        }
                        else
                        {
                            baocao.CHECK_GH = "V";
                        }
                    }
                    // Check COD
                    lsDetailFilter = expBalanceDetails.Where(u => u.MaChiPhi == "SDSHK-F" && u.MaDaiLy == PBean.USER.IdAccountIntro).ToList();
                    soCOD = lsDetailFilter.Count;
                    foreach (var item in lsDetailFilter)
                    {
                        BaoCaoKTDS baocao = lsBaoCao.FirstOrDefault(u => u.BILL_CODE == item.BILL_CODE);
                        if (baocao == null)
                        {
                            baocao = new BaoCaoKTDS();
                            baocao.BILL_CODE = "'" + item.BILL_CODE;
                            baocao.GIAO_TC = "1";
                            baocao.MA_DAI_LY = item.MaDaiLy;
                            ExpBalanceDetail checkDaiLy = expBalanceDetails.FirstOrDefault(u => u.BILL_CODE == item.BILL_CODE && u.MaChiPhi == "SDSHK-F" && u.MaDaiLy != PBean.USER.IdAccountIntro);
                            if (checkDaiLy != null)
                            {
                                baocao.MA_DAI_LY = checkDaiLy.MaDaiLy;
                            }
                            baocao.CHECK_DS = "X";
                            baocao.CHECK_COD = "V";
                            baocao.CHECK_GH = "X";
                            baocao.COD_DOI_SOAT = 0;
                            baocao.COD_KT = item.SoTien;
                            baocao.COD_DATE = string.Format("{0:dd/MM/yyyy}", item.ThoiGianKetToan);
                            baocao.COD_DATE_TIME = string.Format("{0:dd/MM/yyyy HH:mm:ss}", item.ThoiGianKetToan);
                            baocao.COD_DATE_TIME_OUT = "_";
                            baocao.NOTE = "_";
                            baocao.PHI_GUI_TRA = 0;
                            baocao.PHI_NHAN_TRA = 0;
                            baocao.PHI_VC = 0;
                            baocao.PHI_NHAN_TRA = 0;
                            baocao.PHI_GUI_TRA = 0;
                            lsBaoCao.Add(baocao);
                        }
                        else
                        {
                            baocao.CHECK_COD = "V";
                            baocao.COD_KT = item.SoTien;
                            baocao.COD_DATE = string.Format("{0:dd/MM/yyyy}", item.ThoiGianKetToan);
                            baocao.COD_DATE_TIME = string.Format("{0:dd/MM/yyyy HH:mm:ss}", item.ThoiGianKetToan);
                        }
                    }
                    // CHECK OUT DATE
                    foreach (var item in lsBaoCao)
                    {
                        if (item.COD_DATE == "_")
                        {
                            ExpBalanceDetail checkOutCOD = _logic.GetCODDetail(item.BILL_CODE, PBean.USER.IdAccountIntro);
                            if (checkOutCOD != null)
                            {
                                item.COD_DATE_TIME_OUT = string.Format("{0:dd/MM/yyyy HH:mm:ss}", checkOutCOD.ThoiGianKetToan);
                            }
                        }

                        item.BILL_CODE = "'" + item.BILL_CODE;
                    }
                    if (lsBaoCao.Count > 0)
                    {
                        SaveFileDialog save = new SaveFileDialog();
                        save.FileName = "DOI_SOAT_KT_" + string.Format("{0:dd.MM.yyyy_(HH.mm.ss)}", DateTime.Now);
                        save.Filter = "Excel Files | *.xlsx";
                        if (save.ShowDialog() == DialogResult.OK)
                        {
                            string templateFileName = AppDomain.CurrentDomain.BaseDirectory + "Templates\\BAO_CAO_KT_DOI_SOAT.xlsx";
                            Dictionary<string, string> lsReplace = new Dictionary<string, string>();
                            lsReplace.Add("SUM_DS", PCommon.FormatNumber(soDoiSoat.ToString()));
                            lsReplace.Add("SUM_COD", PCommon.FormatNumber(soCOD.ToString()));
                            lsReplace.Add("SUM_GH", PCommon.FormatNumber(soGH.ToString()));
                            lsReplace.Add("NGAY_KT", TieuDeBaoCao);
                            Dictionary<string, string> lsTitile = new Dictionary<string, string>();
                            DataTable data = MapperExtensionClass.ToDataTable<BaoCaoKTDS>(lsBaoCao);
                            ExportDataToExcelTemplate.Export(templateFileName, save.FileName, 1, data, lsTitile, lsReplace);
                            MessageBox.Show("Xuất file excel thành công!", PBean.MESSAGE_TITLE);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
                MessageBox.Show("File Name: " + filename, PBean.MESSAGE_TITLE);
            }

        }

        private void btnCheckCODPNT_Click(object sender, EventArgs e)
        {

            //DateTime? dateFromCod = null;
            //DateTime? dateToCod = null;
            //DateTime tempDate;
            //if (DateTime.TryParse(cmbKyRutTienFrom.SelectedValue.ToString(), out tempDate))
            //{
            //    if (tempDate.Year > 2020)
            //        dateFromCod = tempDate;
            //}
            //if (DateTime.TryParse(cmbKyRutTienTo.SelectedValue.ToString(), out tempDate))
            //{
            //    if (tempDate.Year > 2020)
            //        dateToCod = tempDate;
            //}
            //if (dateFromCod == null && dateToCod == null)
            //{
            //    dateFromCod = dateFromKT.Value;
            //    dateToCod = dateToKT.Value;
            //}
            //string TieuDeBaoCao = "";
            //if (dateFromCod != null)
            //{
            //    TieuDeBaoCao = "TỪ NGÀY " + string.Format("{0:dd/MM/yyyy HH:mm}", dateFromCod);
            //}
            //if (dateToCod != null)
            //{
            //    TieuDeBaoCao += " ĐẾN NGÀY " + string.Format("{0:dd/MM/yyyy HH:mm}", dateToCod);
            //}
            //TieuDeBaoCao = TieuDeBaoCao.Trim();
            DataTable data = ExportDataToExcelTemplate.ReadAsDataTable("E:\\00.TONG_HOP.xlsx");

        }
        //====================================================== CHI TIỀN ĐỐI SOÁT ==================================



        private void btnTruyVanKyDoiSoat_Click(object sender, EventArgs e)
        {
            LoadDoiSoat(cmbPost.SelectedValue.ToString(), dateFrom.Value, dateTo.Value);
        }

        private void btnHuyKyDoiSoat_Click(object sender, EventArgs e)
        {

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
                string message = await _logicDoiSoat.ThanhToanTheoFile(_IdDoiSoat, lsThanhToan, PBean.USER.CardId, PBean.USER.Id);
                if (string.IsNullOrEmpty(message) == false)
                {
                    MessageBox.Show(message, PBean.MESSAGE_TITLE);
                }
                else
                {
                    MessageBox.Show("Hoàn thành chi tiền đối soát cho khách", PBean.MESSAGE_TITLE);
                    LoadDoiSoat(cmbPost.SelectedValue.ToString(), dateFrom.Value, dateTo.Value);
                }
            }
            else
            {
                return;
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
                    LoadDoiSoat(cmbPost.SelectedValue.ToString(), dateFrom.Value, dateTo.Value);
                }
            }
        }

        private void btnChiTienKhachHang_Click(object sender, EventArgs e)
        {
            frmChiDoiSoat frm = new frmChiDoiSoat();
            frm.IdDoiSoatChiTiet = _IdChiTiet;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDoiSoat(cmbPost.SelectedValue.ToString(), dateFrom.Value, dateTo.Value);
            }
        }

        private void btnLoadChiTietKL_Click(object sender, EventArgs e)
        {
            if (cmbCustomerKl.SelectedValue != null)
            {
                List<view_DoiSoatChiTiet> ls = _logicDoiSoat.GetDoiSoatChiTietKL(cmbCustomerKl.SelectedValue.ToString());
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

        void LoadDataDoiSoat()
        {
            dateFrom.Value = DateTime.Now.AddDays(-30);
            dateTo.Value = DateTime.Now;
            cmbPost.DataSource = _logicDoiSoat.GetListPost(PBean.USER.IdAccountIntro);
            cmbPost.DisplayMember = "TenDaiLy";
            cmbPost.ValueMember = "Id";
            cmbPost.SelectedValue = PBean.USER.CardId;

            cmbCustomerKl.DataSource = _logic.GetCustomerListKL(PBean.USER.CardId);
            cmbCustomerKl.DisplayMember = "CustomerName";
            cmbCustomerKl.ValueMember = "CustomerPhone";

        }
        void LoadDoiSoat(string post, DateTime from, DateTime to)
        {
            List<ExpDoiSoat> ls = _logicDoiSoat.GetDoiSoat(post, from, to);
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
        void LoadDataChiTiet(string IdDoiSoat)
        {
            _IdDoiSoat = IdDoiSoat;
            ExpDoiSoat doisoat = new ExpDoiSoat();
            dataGridChiTiet.AutoGenerateColumns = false;
            dataGridChiTiet.DataSource = _logicDoiSoat.GetDoiSoatChiTiet(IdDoiSoat, out doisoat);
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
            ExpDoiSoatChiTiet chitiet = new ExpDoiSoatChiTiet();
            dataGridChiTietCt.AutoGenerateColumns = false;
            dataGridChiTietCt.DataSource = _logicDoiSoat.GetDoiSoatChiTietCt(IdChiTiet, out chitiet);

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

        private void dataGridChiTietCt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Chưa biết xử lý cái gì ở đây
        }

        private void dataGridChiTietKL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dataGridChiTietKL.SelectedRows[0].Index;
                string IdChiTiet = Convert.ToString(dataGridChiTietKL.Rows[index].Cells["col_IdChiTietKL"].Value);
                LoadDataChiTietCt(IdChiTiet);

            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private void txtTimKhachHangDoiSoat_TextChanged(object sender, EventArgs e)
        {
            cmbCustomerKl.DataSource = _logic.GetCustomerListKL(PBean.USER.CardId, txtTimKhachHangDoiSoat.Text);
            cmbCustomerKl.DisplayMember = "CustomerName";
            cmbCustomerKl.ValueMember = "CustomerPhone";
        }

        private void btnExcelDoiSoatKH_Click(object sender, EventArgs e)
        {
            // Xuất file đối soát khách hàng
            string id = "'" + _IdChiTiet.Trim('\'') + "'";
            List<view_DoiSoatChiTiet> ls = _logicDoiSoat.GetDoiSoatChiTietById(id);
            if (ls.Count > 0)
            {
                ls = ls.OrderBy(u => u.NgayDoiSoat).ToList();
                DateTime ngayDoiSoat = ls[0].NgayDoiSoat;
                string tenKH = ls[0].TenKhachHang;
                string soDT = ls[0].SoDienThoai;
                XuatFileDoiSoat(ls, ngayDoiSoat, tenKH, soDT);
            }
        }

        private void btnExcelDoiSoatKL_Click(object sender, EventArgs e)
        {
            // Xuất file
            List<view_DoiSoatChiTiet> ls = _logicDoiSoat.GetDoiSoatChiTietKL(cmbCustomerKl.SelectedValue.ToString());
            if (ls.Count > 0)
            {
                ls = ls.OrderBy(u => u.NgayDoiSoat).ToList();
                DateTime ngayDoiSoat = ls[0].NgayDoiSoat;
                string tenKH = ls[0].TenKhachHang;
                string soDT = ls[0].SoDienThoai;
                XuatFileDoiSoat(ls, ngayDoiSoat, tenKH, soDT);
            }

        }
        void XuatFileDoiSoat(List<view_DoiSoatChiTiet> lsDoiSoatChiTiet, DateTime lastDate, string tenKH, string sdtKH)
        {
            try
            {
                string templateKhachHang = AppDomain.CurrentDomain.BaseDirectory + "Templates\\DOI_SOAT_TEMPLATE_LE.xlsx";
                //List<string> lsKeyString = new List<string>();
                //lsKeyString.Add("BILL_CODE");
                //lsKeyString.Add("ACCEPT_MAN_PHONE");
                //lsKeyString.Add("SEND_MAN_PHONE");

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
                    List<ExpDoiSoatChiTietCt> lsDoiSoatCt = _logicDoiSoat.GetDoiSoatChiTietCt(chiTiet.Id);
                    foreach (var item in lsDoiSoatCt)
                    {
                        DataRow dr = data.NewRow();
                        dr["BILL_CODE"] = item.BILL_CODE;
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
                save.FileName = RemoveSpecialCharacters(PCommon.UnSigns(tenKH));
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


        //====================================================== KẾT THÚC CHI TIỀN ĐỐI SOÁT =========================

        //=================================== QUẢN LÝ BĂNG KEO ===================================================
        void LoadDataBangKeo()
        {
            dateTimeFromBK.Value = DateTime.Now.AddDays(-15);
            dateTimeToBK.Value = DateTime.Now;
            // Load danh sách khách hàng
            cmbKhachHangBK.DataSource = _logic.GetCustomerListKL(PBean.USER.CardId, "0000");
            cmbKhachHangBK.DisplayMember = "CustomerName";
            cmbKhachHangBK.ValueMember = "Id";
            // Load sản phẩm
            cmbSanPhamBK.DataSource = _logic.GetProductBK();
            cmbSanPhamBK.ValueMember = "Id";
            cmbSanPhamBK.DisplayMember = "TenSanPham";

            // Load phương thức thanh toán
            cmbLoaiThanhToanBK.DataSource = _logic.GetLoaiThanhToanBK();
            cmbLoaiThanhToanBK.DisplayMember = "TenLoai";
            cmbLoaiThanhToanBK.ValueMember = "Id";

            LoadDanhSachXuatBan();
        }
        void LoadDanhSachXuatBan()
        {
            dataGridViewBangKeo.AutoGenerateColumns = false;
            List<view_ExpSaleXuatKho> ls = _logic.GetDanhSachXuatBan(dateTimeFromBK.Value, dateTimeToBK.Value);
            dataGridViewBangKeo.DataSource = ls;
            if (ls.Count > 0)
            {
                lblTongTienBK.Text = PCommon.FormatNumber(ls.Sum(s => s.ThanhTien).ToString());
                lblTongChuaTTBK.Text = PCommon.FormatNumber(ls.Where(u => u.IsThanhToan == false).Sum(s => s.ThanhTien).ToString());
            }
            else
            {
                lblTongTienBK.Text = "0";
                lblTongChuaTTBK.Text = "0";
            }


            // Load sản phẩm
            cmbSanPhamBK.DataSource = _logic.GetProductBK();
            cmbSanPhamBK.ValueMember = "Id";
            cmbSanPhamBK.DisplayMember = "TenSanPham";
        }
        private async void btnXuatBanBK_Click(object sender, EventArgs e)
        {
            // Check
            if (cmbKhachHangBK.SelectedValue == null)
            {
                MessageBox.Show("Lựa chọn khách hàng, nếu khách lẻ chọn mã 0000", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbKhachHangBK.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSoLuongBK.Text))
            {
                MessageBox.Show("Số lượng xuất bán không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuongBK.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtDonGiaBK.Text))
            {
                MessageBox.Show("Đơn giá xuất bán không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGiaBK.Focus();
                return;
            }
            decimal SoLuong;
            int DonGia;
            TinhToanThanhTien(out SoLuong, out DonGia);
            string mess = await _logic.XuatBanHang(cmbKhachHangBK.SelectedValue.ToString(), cmbSanPhamBK.SelectedValue.ToString(), SoLuong, DonGia, cmbLoaiThanhToanBK.SelectedValue.ToString(), PBean.USER.Id, PBean.USER.CardId);
            if (string.IsNullOrEmpty(mess))
            {
                LoadDanhSachXuatBan();
            }
            else
            {
                MessageBox.Show(mess, PBean.MESSAGE_TITLE);
            }
        }

        private void txtTimKhachBK_TextChanged(object sender, EventArgs e)
        {
            cmbKhachHangBK.DataSource = _logic.GetCustomerListKL(PBean.USER.CardId, txtTimKhachBK.Text);
            cmbKhachHangBK.DisplayMember = "CustomerName";
            cmbKhachHangBK.ValueMember = "Id";
        }

        private void txtSoLuongBK_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }

        private void txtDonGiaBK_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }

        private void txtDonGiaBK_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        void TinhToanThanhTien(out decimal SoLuong, out int DonGia)
        {
            if (string.IsNullOrEmpty(txtSoLuongBK.Text.Trim()) == false && string.IsNullOrEmpty(txtDonGiaBK.Text.Trim()) == false)
            {
                //decimal soLuong;
                //int DonGia;
                if (!decimal.TryParse(txtSoLuongBK.Text, out SoLuong))
                {
                    SoLuong = 0;
                }
                if (!int.TryParse(txtDonGiaBK.Text.Replace(",", "").Trim(), out DonGia))
                {
                    DonGia = 0;
                }
                decimal ThanhTien = SoLuong * DonGia;
                lblThanhTienBK.Text = PCommon.FormatNumber(ThanhTien.ToString());
                lblBangChuBK.Text = PCommon.ChuyenSoThanhChu(ThanhTien.ToString());
            }
            else
            {
                lblBangChuBK.Text = string.Empty;
                lblThanhTienBK.Text = string.Empty;
                SoLuong = 0;
                DonGia = 0;
            }
        }

        private void txtSoLuongBK_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl == txtSoLuongBK)
            {
                decimal SoLuong;
                int DonGia;
                TinhToanThanhTien(out SoLuong, out DonGia);
            }
        }

        private void txtDonGiaBK_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl == txtDonGiaBK)
            {
                decimal SoLuong;
                int DonGia;
                TinhToanThanhTien(out SoLuong, out DonGia);
            }
        }

        private void btnSanXuatBK_Click(object sender, EventArgs e)
        {
            frmNhapKho frm = new frmNhapKho();
            frm.ShowDialog();
            LoadDanhSachXuatBan();
        }

        private async void menuXoaBK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa xuất kho băng keo không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int index = dataGridViewBangKeo.SelectedRows[0].Index;
                    string IdXuatKho = Convert.ToString(dataGridViewBangKeo.Rows[index].Cells["col_Id"].Value);
                    string mess = await _logic.XoaXuatKho(IdXuatKho, PBean.USER.Id, PBean.USER.CardId);
                    if (string.IsNullOrEmpty(mess))
                    {
                        LoadDanhSachXuatBan();
                    }
                    else
                    {
                        MessageBox.Show(mess, PBean.MESSAGE_TITLE);
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    return;
                }
            }
        }

        private async void menuThuTienBK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thu tiền bán băng keo?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int index = dataGridViewBangKeo.SelectedRows[0].Index;
                    string IdXuatKho = Convert.ToString(dataGridViewBangKeo.Rows[index].Cells["col_Id"].Value);
                    string mess = await _logic.ThuTienXuatKho(IdXuatKho, PBean.USER.Id, PBean.USER.CardId);
                    if (string.IsNullOrEmpty(mess))
                    {
                        LoadDanhSachXuatBan();
                    }
                    else
                    {
                        MessageBox.Show(mess, PBean.MESSAGE_TITLE);
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    return;
                }
            }
        }

        private void btnXuatExcelBK_Click(object sender, EventArgs e)
        {
            // Xuất file đối soát khách hàng
            List<view_ExpSaleXuatKho> ls = _logic.GetDanhSachXuatBan(dateTimeFromBK.Value, dateTimeToBK.Value);
            if (ls.Count > 0)
            {
                string TongTien = ls.Sum(s => s.ThanhTien).ToString();
                string TongTienChuaTT = ls.Where(u => u.IsThanhToan == false).Sum(s => s.ThanhTien).ToString();
                SaveFileDialog save = new SaveFileDialog();
                string title = "TỪ NGÀY " + string.Format("{0:dd.MM.yyyy}", dateTimeFromBK.Value) + " ĐẾN " + string.Format("{0:dd.MM.yyyy}", dateTimeToBK.Value);
                save.FileName = "XUAT_BAN_" + string.Format("{0:dd.MM.yyyy}", dateTimeFromBK.Value) + "_" + string.Format("{0:dd.MM.yyyy}", dateTimeToBK.Value);
                save.Filter = "Excel Files | *.xlsx";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string templateFileName = AppDomain.CurrentDomain.BaseDirectory + "Templates\\XUAT_BAN.xlsx";
                    Dictionary<string, string> lsReplace = new Dictionary<string, string>();
                    lsReplace.Add("TONG_TIEN", TongTien);
                    lsReplace.Add("CHUA_TT", TongTienChuaTT);
                    lsReplace.Add("NGAY", title);
                    Dictionary<string, string> lsTitile = new Dictionary<string, string>();
                    DataTable data = MapperExtensionClass.ToDataTable<view_ExpSaleXuatKho>(ls);
                    ExportDataToExcelTemplate.Export(templateFileName, save.FileName, 1, data, lsTitile, lsReplace);
                    MessageBox.Show("Xuất file excel thành công!", PBean.MESSAGE_TITLE);
                }
            }
        }

        private void btnTruyVanBangKeo_Click(object sender, EventArgs e)
        {
            LoadDanhSachXuatBan();
        }

        //============================ KẾT THÚC QUẢN LÝ BĂNG KEO =================================================
    }
}
