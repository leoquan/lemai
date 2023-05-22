using Common;
using LeMaiDomain;
using LeMaiLogic;
using LeMaiLogic.Logic;
using PresentationControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace LeMaiDesktop
{
    public partial class frmTruyVanVanDon : frmBase
    {
        SoundPlayer SoundSuccess = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "success.wav");
        List<view_GExpBillCus> lsDataHangGui = new List<view_GExpBillCus>();
        List<GExpProvince> lsProvinces = new List<GExpProvince>();
        List<string> lsLowProcess = new List<string>();
        List<string> lsContact = new List<string>();
        bool isBusyHangDi = false;
        int DiKhuVucCham = 0;
        int DiChamThaoTac = 0;
        int DiKTThatLac = 0;

        private GExpBillLogic _logic = new GExpBillLogic(PBean.ConnectionBase);
        public frmTruyVanVanDon() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.F4))
            {
                if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                return true;
            }
            if (keyData == (Keys.Control | Keys.Q))
            {
                btnClose_Click(null, null);
                return true;
            }

            if (keyData == (Keys.Control | Keys.C))
            {
                if (ActiveControl.GetType() == typeof(TextBox))
                {
                    Clipboard.SetText(ActiveControl.Text);
                }
                else
                {
                    if (ActiveControl == dataGridViewDi)
                    {
                        try
                        {
                            // Copy mã BT3
                            string lsMavanDon = string.Empty;
                            foreach (DataGridViewRow item in dataGridViewDi.SelectedRows)
                            {
                                if (item.Cells["col_BT3Code"].Value != null)
                                {
                                    lsMavanDon += item.Cells["col_BT3Code"].Value.ToString() + "@";
                                }
                            }
                            lsMavanDon = lsMavanDon.TrimEnd('@');
                            lsMavanDon = lsMavanDon.Replace("@", System.Environment.NewLine);
                            Clipboard.SetText(lsMavanDon);
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
                return true;

            }
            if (keyData == (Keys.Control | Keys.X))
            {
                if (ActiveControl == dataGridViewDi)
                {
                    try
                    {
                        // Copy mã BillCode
                        string lsMavanDon = string.Empty;
                        foreach (DataGridViewRow item in dataGridViewDi.SelectedRows)
                        {
                            if (item.Cells["col_BillCode"].Value != null)
                            {
                                lsMavanDon += item.Cells["col_BillCode"].Value.ToString() + "@";
                            }

                        }
                        lsMavanDon = lsMavanDon.TrimEnd('@');
                        lsMavanDon = lsMavanDon.Replace("@", System.Environment.NewLine);
                        Clipboard.SetText(lsMavanDon);
                    }
                    catch (Exception)
                    {
                    }
                }

                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private async void LoadData(bool reload = true)
        {
            if (reload)
            {
                // Load danh sách khách hàng
                cmbKhachHangFilter.DataSource = _logic.GetCustomerListFilter(PBean.USER.CardId, txtKhachHangFilter.Text.Trim());
                cmbKhachHangFilter.DisplayMember = "CustomerName";
                cmbKhachHangFilter.ValueMember = "Id";

                // Loại kiện filter 
                var _lsProviderAll = await _logic.GetDanhSachProvider(PBean.USER.CardId);
                List<GExpProvider> listAndAll = new List<GExpProvider>();
                listAndAll.Add(new GExpProvider { Id = "9999", ProviderName = "Tất cả" });
                listAndAll.AddRange(_lsProviderAll);
                cmbLoaiKienFilter.DataSource = listAndAll;
                cmbLoaiKienFilter.DisplayMember = "ProviderName";
                cmbLoaiKienFilter.ValueMember = "Id";

                DataTable dataListStatus = MapperExtensionClass.ToDataTable(await _logic.GetGExpBillStatus());
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
                    cmbProcessTypeMulti.CheckBoxItems["Chấp nhận gửi"].Checked = true;
                    cmbProcessTypeMulti.CheckBoxItems["Đến trung tâm"].Checked = true;
                    cmbProcessTypeMulti.CheckBoxItems["Đang trung chuyển"].Checked = true;
                    cmbProcessTypeMulti.CheckBoxItems["Đang phát"].Checked = true;
                    cmbProcessTypeMulti.CheckBoxItems["Mới tạo"].Checked = true;
                }
                catch
                {
                }

            }

        }
        private async void btnTruyVan_Click(object sender, EventArgs e)
        {
            if (isBusyHangDi)
            {
                MessageBox.Show("Có một tác vụ đang xử lý chưa kết thúc, vui lòng đợi!", PBean.MESSAGE_TITLE);
                return;
            }
            lsContact = new List<string>();
            lsLowProcess = new List<string>();
            string statusSelect = GetMultiStatus();

            lsDataHangGui = await _logic.GetListCus(PBean.USER.CardId, cmbKhachHangFilter.SelectedValue.ToString(), cmbLoaiKienFilter.SelectedValue.ToString(), statusSelect);
            lsProvinces = await _logic.GetDanhSachTinh();
            btnTruyVan.Enabled = false;
            btnExport.Enabled = false;
            lblWaitCount.Text = lsDataHangGui.Count.ToString();
            progressBarSend.Minimum = 0;
            progressBarSend.Maximum = lsDataHangGui.Count;
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
        private void btnExport_Click(object sender, EventArgs e)
        {
            // Xuất excel
            if (lsDataHangGui.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "CS_" + string.Format("{0:dd_MM_yyyy_(HH_mm)}", DateTime.Now);
                save.Filter = "Excel Files | *.xlsx";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string templateFileName = AppDomain.CurrentDomain.BaseDirectory + "Templates\\MAU_XUAT_DON_CARE.xlsx";
                    Dictionary<string, string> lsReplace = new Dictionary<string, string>();
                    Dictionary<string, string> lsTitile = new Dictionary<string, string>();
                    List<string> lsKeyString = new List<string>();
                    lsKeyString.Add("SendManPhone");
                    lsKeyString.Add("RegisterDate");
                    lsKeyString.Add("AcceptManPhone");

                    DataTable data = MapperExtensionClass.ToDataTable(lsDataHangGui);
                    ExportDataToExcelTemplate.Export(templateFileName, save.FileName, 1, data, lsTitile, lsReplace, false, lsKeyString);
                    MessageBox.Show("Xuất file excel thành công!", PBean.MESSAGE_TITLE);
                }
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu vui lòng thực hiện truy vấn dữ liệu trước khi xuất Excel", PBean.MESSAGE_TITLE);
            }
        }

        private void frmTruyVanVanDon_Load(object sender, EventArgs e)
        {
            LoadData(true);
        }

        private void txtKhachHangFilter_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                cmbKhachHangFilter.DataSource = _logic.GetCustomerListFilter(PBean.USER.CardId, txtKhachHangFilter.Text.Trim());
                cmbKhachHangFilter.DisplayMember = "CustomerName";
                cmbKhachHangFilter.ValueMember = "Id";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void dataGridViewDi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Hiển thị process
            try
            {
                int index = dataGridViewDi.SelectedRows[0].Index;
                string billCode = Convert.ToString(dataGridViewDi.Rows[index].Cells["col_BillCode"].Value);
                view_GExpBill bill = await _logic.GetDetails(billCode);
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

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            //Xuất báo cáo
            MessageBox.Show(_logic.GetQuickReport(), PBean.MESSAGE_TITLE);
        }

        private void backgroundWorkerDi_DoWork(object sender, DoWorkEventArgs e)
        {
            DiKhuVucCham = 0;
            DiChamThaoTac = 0;
            DiKTThatLac = 0;

            int count = 0;
            foreach (var item in lsDataHangGui)
            {
                //1. Đơn hàng chưa ký, thì tổng thời gian từ lúc tạo đơn đến hiện tại là bao nhiêu lâu? Trường hợp đã ký, thì tổng thời gian từ lúc tạo đến thời điểm ký là bao lâu?
                TimeSpan spanProcess;
                if (item.IsSigned == false)
                {
                    // Đơn hàng chưa ký thì ta so sánh thời gian hiện tại đến lúc tạo đơn
                    spanProcess = DateTime.Now.Subtract(item.RegisterDate);
                }
                else
                {
                    // Đơn hàng đã ký, ta so sánh thời gian ký đến lúc tạo đơn
                    spanProcess = ((DateTime)item.SignedDate).Subtract(item.RegisterDate);
                }
                //DAY_LATE
                item.KetQuaInt1 = (int)spanProcess.TotalDays;
                item.KetQua1 = ((int)(spanProcess.TotalHours / 24)).ToString().PadLeft(2, '0') + "d" + ((int)(spanProcess.TotalHours % 24)).ToString().PadLeft(2, '0') + "h";
                GExpProvince pro = lsProvinces.FirstOrDefault(u => u.ProvinceID == item.AcceptProvinceCode);
                if (pro != null)
                {
                    // Check thời gian delay theo zone
                    if (pro.ZoneCode == "N")
                    {
                        // Miền nam
                        item.KetQuaInt1 = item.KetQuaInt1 + 3;
                    }
                    else if (pro.ZoneCode == "T")
                    {
                        // Miền Trung
                        item.KetQuaInt1 = item.KetQuaInt1 + 2;
                    }
                    else if (pro.ZoneCode == "B")
                    {
                        // Miền Bắc
                        item.KetQuaInt1 = item.KetQuaInt1 + 1;
                    }
                    //2. Cảnh báo các tỉnh thuộc tình trạng giao hàng chậm
                    if (pro.Delay == true)
                    {
                        item.KetQua2 = "KV chậm";
                        DiKhuVucCham++;
                    }
                    else
                    {
                        item.KetQua2 = string.Empty;
                    }
                }


                //3. Không có quét TTKT thì cảnh báo hàng thất lạc
                if (_logic.CheckTTKTScanBillCode(item.BillCode) == false)
                {
                    item.KetQua3 = "KT Thất lạc";
                    DiKTThatLac++;
                }

                if (item.IsSigned == false) // Không phải đơn ảo, không phải đơn tải.
                {
                    //3. Cảnh báo nếu trong vòng 24 giờ không có bất kỳ cập nhật nào bao gồm, quét hàng, kiện vấn đề, cuộc gọi, kiện nội bộ, comment của nhân viên. Và hiểu là xử lý chậm. Trường hợp xử lý chậm quá 3 ngày thì tăng mức độ.
                    GExpScan lastScan = _logic.GetLastScanBillCode(item.BillCode);
                    GExpProblem lastProblem = _logic.GetLastKVDBillCode(item.BillCode);
                    ExpComment lastComment = _logic.GetLastCommentBillCode(item.BillCode);

                    DateTime thoiGianCheck = DateTime.Now.AddDays(-10);
                    if (lastScan != null)
                    {
                        if (lastScan.CreateDate > thoiGianCheck)
                        {
                            thoiGianCheck = lastScan.CreateDate;
                        }
                    }
                    if (lastProblem != null)
                    {
                        // Có thể đưa thêm cái kiện vấn đề cuối cùng
                        if (lastProblem.RegisterDate > thoiGianCheck)
                        {
                            thoiGianCheck = lastProblem.RegisterDate;
                        }
                    }

                    if (lastComment != null)
                    {
                        item.KetQua5 = lastComment.Author + ":" + lastComment.Comment;
                        if (lastComment.UpdateDate > thoiGianCheck)
                        {
                            thoiGianCheck = lastComment.UpdateDate;
                        }
                    }
                    TimeSpan spanCheck = DateTime.Now.Subtract(thoiGianCheck);
                    if (thoiGianCheck.Date != DateTime.Now.Date)
                    {
                        item.KetQua4 = "Chậm xử lý";
                        DiChamThaoTac++;
                    }
                }


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
            dataGridViewDi.DataSource = lsDataHangGui;
            FormatRowDonHang();

            lblDiKhuVucCham.Text = PCommon.FormatNumber(DiKhuVucCham.ToString());
            lblDiChamThaoTac.Text = PCommon.FormatNumber(DiChamThaoTac.ToString());
            lblKTThatLac.Text = PCommon.FormatNumber(DiKTThatLac.ToString());

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
                if (!int.TryParse(dataGridViewDi.Rows[i].Cells["col_NgayTreInt"].Value.ToString(), out ngaytre))
                {
                    ngaytre = 0;
                }
                if (ngaytre >= 7)
                {
                    dataGridViewDi.Rows[i].Cells["col_NgayTre"].Style.ForeColor = Color.Red;
                }
                else if (ngaytre >= 5)
                {
                    dataGridViewDi.Rows[i].Cells["col_NgayTre"].Style.ForeColor = Color.Orange;
                }
                // Check khu vực chậm
                if (!string.IsNullOrEmpty(dataGridViewDi.Rows[i].Cells["col_TinhCham"].Value.ToString()))
                {
                    dataGridViewDi.Rows[i].Cells["col_TinhCham"].Style.ForeColor = Color.Red;
                }

                // Hàng thất lạc
                if (!string.IsNullOrEmpty(dataGridViewDi.Rows[i].Cells["Col_HangThatLac"].Value.ToString()))
                {
                    dataGridViewDi.Rows[i].Cells["Col_HangThatLac"].Style.ForeColor = Color.Red;
                }
                // Chậm thao tác
                if (!string.IsNullOrEmpty(dataGridViewDi.Rows[i].Cells["col_Care"].Value.ToString()))
                {
                    dataGridViewDi.Rows[i].Cells["col_Care"].Style.ForeColor = Color.Red;
                }
            }
        }
    }
}
