using Common;
using LeMaiDomain;
using LeMaiDomain.Models;
using LeMaiLogic;
using LeMaiLogic.Logic;
using PresentationControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace LeMaiDesktop
{
    public partial class frmExpConsignmentV2 : frmBase
    {
        SoundPlayer printSound = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "nhacnho.wav");
        SoundPlayer notifySound = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "mixding.wav");
        private GExpBillLogic _logic = new GExpBillLogic(PBean.ConnectionBase);
        private enumAction status = enumAction.NONE;
        private view_GExpBill Gitem;
        private GExpAccept _NguoiNhan = null;
        private ExpCustomer _KhachHangHd = null;
        List<GExpProvider> _lsProvider = new List<GExpProvider>();
        List<GExpProvider> _lsProviderAll = new List<GExpProvider>();
        List<GExpProvider> _lsProviderWhiteBlack = new List<GExpProvider>();
        string _listNhapMa = string.Empty;
        string _IdOrder = string.Empty;

        List<view_GExpBillGHNApi> _lsViewBillApi = new List<view_GExpBillGHNApi>();
        string _errorMessageApi = string.Empty;
        string _ListIdApi = string.Empty;
        bool _isBusyApi = false;
        int _countApiSucces = 0;

        PickupAddressItem _pickupAddress = new PickupAddressItem();

        List<GExpProvince> _listProvince = new List<GExpProvince>();


        public frmExpConsignmentV2() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            gridBills.AutoGenerateColumns = false;
            this.gridBills.RowTemplate.MinimumHeight = 22;
            dateFrom.Value = DateTime.Now;
            dateTo.Value = DateTime.Now;
            Separator();
        }

        private void frmExpConsignmentV2_Load(object sender, EventArgs e)
        {
            LoadData(true);
            EnableButton(status);
            ChangeLanguageUI(PBean.MAKE_LANG);
            // Check Config
            cmbBienNhan.DataSource = DocumentPrintHelper.GetAllType();
            cmbBienNhan.DisplayMember = "Name";
            cmbBienNhan.ValueMember = "Id";
            if (!string.IsNullOrEmpty(PBean.LOCAL_OPTIONS.PrintSizeReceipt))
            {
                cmbBienNhan.SelectedValue = PBean.LOCAL_OPTIONS.PrintSizeReceipt;
            }
            cmbTemDan.DataSource = DocumentPrintHelper.GetAllType();
            cmbTemDan.DisplayMember = "Name";
            cmbTemDan.ValueMember = "Id";
            if (!string.IsNullOrEmpty(PBean.LOCAL_OPTIONS.PrintSize))
            {
                cmbTemDan.SelectedValue = PBean.LOCAL_OPTIONS.PrintSize;
            }
        }

        #region Xử lý phím tắt

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
            if (keyData == (Keys.Control | Keys.S))
            {
                btnSave_Click(null, null);
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
                    try
                    {
                        // Copy mã BT3
                        string lsMavanDon = string.Empty;
                        foreach (DataGridViewRow item in gridBills.SelectedRows)
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
                return true;

            }
            if (keyData == (Keys.Control | Keys.X))
            {
                try
                {
                    // Copy mã BillCode
                    string lsMavanDon = string.Empty;
                    foreach (DataGridViewRow item in gridBills.SelectedRows)
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
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Enable hoặc Disable các button chức năng Trạng thái đang hoạt động 0: Không làm gì cả, 1: Thêm mới, 2: Sửa
        private void EnableButton(enumAction stus)
        {
            //Enable tất cả các button
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            if (stus == enumAction.NONE)
            {
                btnSave.Enabled = false;
                btnNew.Text = "Nhập đơn";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iNew;
                txtMaDonHang.Enabled = false;
                txtTenHang.Enabled = false;
                txtSoLuong.Enabled = false;
                txtTrongLuongBill.Enabled = false;
                txtTrongLuongKH.Enabled = false;
                cmbXemHang.Enabled = false;
                txtYeuCauKhac.Enabled = false;
                cmbLoaiKien.Enabled = false;
                cmbLoaiThanhToan.Enabled = false;
                txtCuocPhiChinh.Enabled = false;
                txtThuHo.Enabled = false;
                txtTongCuoc.Enabled = false;
                txtNguoiGui.Enabled = false;
                txtSoDienThoaiNguoiGui.Enabled = false;
                txtSoNhaNguoiGui.Enabled = false;
                txtNguoiNhan.Enabled = false;
                txtSoDienThoaiNguoiNhan.Enabled = false;
                txtSoNhaNguoiNhan.Enabled = false;
                cmbAutoAddress.Enabled = false;
                txtFilterXa.Enabled = false;
                cmbTinhNhan.Enabled = false;
                cmbHuyenNhan.Enabled = false;
                cmbXaNhan.Enabled = false;
                txtW.Enabled = false;
                txtH.Enabled = false;
                txtL.Enabled = false;
            }
            if (stus == enumAction.NEW)
            {
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                txtMaDonHang.Enabled = true;
                txtTenHang.Enabled = true;
                txtSoLuong.Enabled = true;
                txtTrongLuongBill.Enabled = true;
                txtTrongLuongKH.Enabled = true;
                cmbXemHang.Enabled = true;
                txtYeuCauKhac.Enabled = true;
                cmbLoaiKien.Enabled = true;
                cmbLoaiThanhToan.Enabled = true;
                txtCuocPhiChinh.Enabled = true;
                txtThuHo.Enabled = true;
                txtTongCuoc.Enabled = true;
                txtNguoiGui.Enabled = true;
                txtSoDienThoaiNguoiGui.Enabled = true;
                txtSoNhaNguoiGui.Enabled = true;
                txtNguoiNhan.Enabled = true;
                txtSoDienThoaiNguoiNhan.Enabled = true;
                txtSoNhaNguoiNhan.Enabled = true;
                cmbAutoAddress.Enabled = true;
                txtFilterXa.Enabled = true;
                cmbTinhNhan.Enabled = true;
                cmbHuyenNhan.Enabled = true;
                cmbXaNhan.Enabled = true;
                txtW.Enabled = true;
                txtH.Enabled = true;
                txtL.Enabled = true;
            }
            if (stus == enumAction.UPDATE)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                txtMaDonHang.Enabled = true;
                txtTenHang.Enabled = true;
                txtSoLuong.Enabled = true;
                txtTrongLuongBill.Enabled = true;
                txtTrongLuongKH.Enabled = true;
                cmbXemHang.Enabled = true;
                txtYeuCauKhac.Enabled = true;
                cmbLoaiKien.Enabled = true;
                cmbLoaiThanhToan.Enabled = true;
                txtCuocPhiChinh.Enabled = true;
                txtThuHo.Enabled = true;
                txtTongCuoc.Enabled = true;
                txtNguoiGui.Enabled = true;
                txtSoDienThoaiNguoiGui.Enabled = true;
                txtSoNhaNguoiGui.Enabled = true;
                txtNguoiNhan.Enabled = true;
                txtSoDienThoaiNguoiNhan.Enabled = true;
                txtSoNhaNguoiNhan.Enabled = true;
                cmbAutoAddress.Enabled = true;
                txtFilterXa.Enabled = true;
                cmbTinhNhan.Enabled = true;
                cmbHuyenNhan.Enabled = true;
                cmbXaNhan.Enabled = true;
                txtW.Enabled = true;
                txtH.Enabled = true;
                txtL.Enabled = true;
            }
        }
        // Xóa trắng tất cả các textbox.
        private void ClearText()
        {
            txtMaDonHang.Text = string.Empty;
            txtSoLuong.Text = "1";
            txtTrongLuongBill.Text = "";
            txtTrongLuongKH.Text = "";
            txtCuocPhiChinh.Text = "";
            txtThuHo.Text = "";
            txtTongCuoc.Text = "0";
            txtSoDienThoaiNguoiNhan.Text = string.Empty;
            txtNguoiNhan.Text = string.Empty;
            txtSoNhaNguoiNhan.Text = string.Empty;
            cmbAutoAddress.Text = string.Empty;
            txtFilterXa.Text = string.Empty;

        }
        void SetFocus()
        {
            if (string.IsNullOrEmpty(txtSoDienThoaiNguoiGui.Text.Trim()))
            {
                txtSoDienThoaiNguoiGui.Focus();
            }
            else if (string.IsNullOrEmpty(txtSoDienThoaiNguoiNhan.Text.Trim()))
            {
                txtSoDienThoaiNguoiNhan.Focus();
            }
            else if (string.IsNullOrEmpty(txtTenHang.Text.Trim()))
            {
                txtTenHang.Focus();
            }
            else if (string.IsNullOrEmpty(txtTrongLuongBill.Text.Trim()) || txtTrongLuongBill.Text == "0")
            {
                txtTrongLuongBill.Focus();
            }
        }

        // Fill dữ liệu vào các control.
        private async void FillData(view_GExpBill item, bool copy)
        {
            txtMaDonHang.Text = item.BillCode;
            txtSoDienThoaiNguoiGui.Text = item.SendManPhone;
            txtNguoiGui.Text = item.SendMan;
            txtSoNhaNguoiGui.Text = item.SendManAddress;

            txtSoDienThoaiNguoiNhan.Text = item.AcceptManPhone;
            txtNguoiNhan.Text = item.AcceptMan;
            txtSoNhaNguoiNhan.Text = item.AcceptManAddress;

            txtTenHang.Text = item.GoodsName;
            txtTrongLuongBill.Text = PCommon.FormatNumber(item.BillWeight.ToString());
            txtTrongLuongKH.Text = PCommon.FormatNumber(item.FeeWeight.ToString());
            txtSoLuong.Text = item.GoodsNumber.ToString();
            txtW.Text = item.GoodsW.ToString();
            txtH.Text = item.GoodsH.ToString();
            txtL.Text = item.GoodsL.ToString();
            lblCalWeight.Text = "7.000: " + PCommon.FormatNumber(((double)(item.GoodsW * item.GoodsH * item.GoodsL) / 7000).ToString(), 1) + " Kg      6000: " + PCommon.FormatNumber(((double)(item.GoodsW * item.GoodsH * item.GoodsL) / 6000).ToString(), 1) + " Kg         5000: " + PCommon.FormatNumber(((double)(item.GoodsW * item.GoodsH * item.GoodsL) / 5000).ToString(), 1) + " Kg";
            cmbXemHang.SelectedValue = item.FK_ShipType;
            txtYeuCauKhac.Text = item.Note;
            cmbLoaiKien.SelectedValue = item.FK_ProviderAccount;
            cmbLoaiThanhToan.SelectedValue = item.FK_PaymentType;
            txtCuocPhiChinh.Text = PCommon.FormatNumber(item.Freight.ToString());
            txtThuHo.Text = PCommon.FormatNumber(item.COD.ToString());
            CalculatorPrice();
            // Load Address Nhận
            cmbTinhNhan.DataSource = await _logic.GetDanhSachTinh();
            cmbTinhNhan.DisplayMember = "ProvinceName";
            cmbTinhNhan.ValueMember = "ProvinceID";
            cmbTinhNhan.SelectedValue = item.AcceptProvinceCode;

            cmbHuyenNhan.DataSource = await _logic.GetDanhSachHuyen(item.AcceptProvinceCode.ToString());
            cmbHuyenNhan.DisplayMember = "DistrictName";
            cmbHuyenNhan.ValueMember = "DistrictID";
            cmbHuyenNhan.SelectedValue = item.AcceptDistrictCode;

            cmbXaNhan.DataSource = await _logic.GetDanhSachXa(item.AcceptDistrictCode.ToString());
            cmbXaNhan.DisplayMember = "WardName";
            cmbXaNhan.ValueMember = "WardId";
            cmbXaNhan.SelectedValue = item.AcceptWardCode;


            chbPickup.Checked = item.Pickup == null ? false : (bool)item.Pickup;


            _KhachHangHd = _logic.GetThongTinKhachHangById(item.FK_Customer);

            cmbAutoAddress.Text = txtSoNhaNguoiNhan.Text + ", " + cmbXaNhan.Text + ", " + cmbHuyenNhan.Text + ", " + cmbTinhNhan.Text;
        }

        #region Xử lý TextBox tìm kiếm dữ liệu trên form
        private void txtKhachHangFilter_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                timerFilterKH.Stop();
                timerFilterKH.Start();
            }
        }
        private void timerFilterKH_Tick(object sender, EventArgs e)
        {
            cmbKhachHangFilter.DataSource = _logic.GetCustomerListFilter(PBean.USER.CardId, txtKhachHangFilter.Text.Trim());
            cmbKhachHangFilter.DisplayMember = "CustomerName";
            cmbKhachHangFilter.ValueMember = "Id";

            timerFilterKH.Stop();
        }

        private void timerDelay_Tick(object sender, EventArgs e)
        {
            SearchData();
            timerDelay.Stop();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            timerDelay.Stop();
            timerDelay.Start();
        }
        private void timerFilterXa_Tick(object sender, EventArgs e)
        {
            // Search cái xã khi có khoảng cách
            if (txtFilterXa.Text.Contains(" "))
            {
                string unsign = PCommon.UnSigns(txtFilterXa.Text);
                var list = _logic.SearchWard(unsign);
                cmbAutoAddress.DataSource = list;
                cmbAutoAddress.DisplayMember = "DisplayValue";
                cmbAutoAddress.ValueMember = "WardId";
                if (list.Count > 0)
                {
                    SelectAddress(list[0].WardId);
                }
            }

            //Stop cái timer
            timerFilterXa.Stop();
        }
        private void txtFilterXa_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                timerFilterXa.Stop();
                timerFilterXa.Start();
            }
        }
        private async void SearchData()
        {
            var result = await _logic.GetList(txtSearch.Text, PBean.USER.CardId, cmbKhachHangFilter.SelectedValue.ToString(), dateFrom.Value, dateTo.Value, cmbLoaiKienFilter.SelectedValue.ToString());
            gridBills.DataSource = result;
            lblSoDon.Text = "Số đơn: " + result.Count.ToString();
            FormatRowKetQua();
        }
        #endregion

        #endregion

        #region Xử lý sự kiện cho các button - GridControl
        private void txtMaDonHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtTenHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSoLuong_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtTrongLuongGram_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtTrongLuongGram_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtYeuCauKhac_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtCuocPhiChinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtCuocPhiChinh_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }

        private void txtThuHo_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtThuHo_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtNguoiGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSoNhaNguoiGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtNguoiNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }

        private void txtSoNhaNguoiNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtDiaChiNguoiNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }

        // Load data từ database lên lưới
        private async void LoadData(bool reload = false)
        {
            if (reload)
            {
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
                    cmbProcessTypeMulti.CheckBoxItems["Mới tạo"].Checked = true;
                    cmbProcessTypeMulti.CheckBoxItems["Chấp nhận gửi"].Checked = true;
                    cmbProcessTypeMulti.CheckBoxItems["Từ chối"].Checked = true;
                    cmbProcessTypeMulti.CheckBoxItems["Đến trung tâm"].Checked = true;
                    cmbProcessTypeMulti.CheckBoxItems["Đang trung chuyển"].Checked = true;
                    cmbProcessTypeMulti.CheckBoxItems["Đang phát"].Checked = true;
                    cmbProcessTypeMulti.CheckBoxItems["Đã giao"].Checked = true;
                    cmbProcessTypeMulti.CheckBoxItems["Đang hoàn"].Checked = true;
                    cmbProcessTypeMulti.CheckBoxItems["Đã hoàn"].Checked = true;
                }
                catch
                {
                }

                // Load danh sách khách hàng
                cmbKhachHangFilter.DataSource = _logic.GetCustomerListFilter(PBean.USER.CardId, txtKhachHangFilter.Text.Trim());
                cmbKhachHangFilter.DisplayMember = "CustomerName";
                cmbKhachHangFilter.ValueMember = "Id";


                // ExpConsignmentOnDelivery
                cmbXemHang.DataSource = await _logic.GetDanhSachGiaoHang();
                cmbXemHang.DisplayMember = "ShipNoteType";
                cmbXemHang.ValueMember = "Id";
                // ExpProvider

                _lsProviderAll = await _logic.GetDanhSachProvider(PBean.USER.CardId);
                cmbLoaiKien.DataSource = _lsProviderAll;
                cmbLoaiKien.DisplayMember = "ProviderName";
                cmbLoaiKien.ValueMember = "Id";

                _lsProvider = _lsProviderAll.Where(u => u.AutoSelect == true).OrderBy(o => o.SelectIndex).ToList();
                _lsProviderWhiteBlack = _lsProviderAll.Where(u => !string.IsNullOrEmpty(u.WhiteListProvince) || !string.IsNullOrEmpty(u.BlackListProvince)).ToList();
                // Loại kiện filter 
                List<GExpProvider> listAndAll = new List<GExpProvider>();
                listAndAll.Add(new GExpProvider { Id = "9999", ProviderName = "Tất cả" });
                listAndAll.AddRange(_lsProviderAll);
                cmbLoaiKienFilter.DataSource = listAndAll;
                cmbLoaiKienFilter.DisplayMember = "ProviderName";
                cmbLoaiKienFilter.ValueMember = "Id";

                // ExpCachThanhToan
                cmbLoaiThanhToan.DataSource = await _logic.GetDanhSachThanhToan();
                cmbLoaiThanhToan.DisplayMember = "PaymentTypeName";
                cmbLoaiThanhToan.ValueMember = "Id";

                // ExpDonViHanhChinh
                _listProvince = await _logic.GetDanhSachTinh();
                cmbTinhNhan.DataSource = _listProvince;
                cmbTinhNhan.DisplayMember = "ProvinceName";
                cmbTinhNhan.ValueMember = "ProvinceID";
                if (!string.IsNullOrEmpty(PBean.LOCAL_OPTIONS.SAVE_TINH))
                {
                    cmbTinhNhan.SelectedValue = PBean.LOCAL_OPTIONS.SAVE_TINH;

                    cmbHuyenNhan.DataSource = await _logic.GetDanhSachHuyen(PBean.LOCAL_OPTIONS.SAVE_TINH);
                    cmbHuyenNhan.DisplayMember = "DistrictName";
                    cmbHuyenNhan.ValueMember = "DistrictID";
                    cmbHuyenNhan.SelectedValue = PBean.LOCAL_OPTIONS.SAVE_HUYEN;
                    if (!string.IsNullOrEmpty(PBean.LOCAL_OPTIONS.SAVE_HUYEN))
                    {
                        cmbXaNhan.DataSource = await _logic.GetDanhSachXa(PBean.LOCAL_OPTIONS.SAVE_HUYEN);
                        cmbXaNhan.DisplayMember = "WardName";
                        cmbXaNhan.ValueMember = "WardId";
                        cmbXaNhan.SelectedValue = PBean.LOCAL_OPTIONS.SAVE_XA;
                    }
                }

            }
            var result = await _logic.GetList(string.Empty, PBean.USER.CardId, cmbKhachHangFilter.SelectedValue.ToString(), dateFrom.Value, dateTo.Value, cmbLoaiKienFilter.SelectedValue.ToString());
            gridBills.DataSource = result;
            gridBills.ClearSelection();
            lblSoDon.Text = "Số đơn: " + result.Count.ToString();
            FormatRowKetQua();
        }
        private void FormatRowKetQua()
        {

        }
        //Thêm mới
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (status != enumAction.NONE)
            {
                status = enumAction.NONE;
                EnableButton(status);
            }
            else
            {
                status = enumAction.NEW;
                EnableButton(status);
                ClearText();
                SetFocus();
            }
        }

        //Chỉnh sửa
        private async void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                int index = gridBills.SelectedRows[0].Index;
                Gitem = await _logic.GetDetails(Convert.ToString(gridBills.Rows[index].Cells["col_BillCode"].Value));
                if (null != Gitem)
                {
                    FillData(Gitem, false);
                    status = enumAction.UPDATE;
                    EnableButton(status);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }
        //Lưu
        private async void btnSave_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu nhập
            if (String.IsNullOrEmpty(txtTenHang.Text))
            {
                MessageBox.Show("Tên hàng không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHang.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Số lượng không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }
            else
            {
                int soluong;
                if (Int32.TryParse(txtSoLuong.Text, out soluong))
                {
                    if (soluong <= 0)
                    {
                        MessageBox.Show("Số lượng kiện phải > 0.", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSoLuong.Focus();
                        return;
                    }
                }
            }
            if (String.IsNullOrEmpty(txtTongCuoc.Text))
            {
                MessageBox.Show("Tổng cước phí phải thu không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTongCuoc.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtNguoiGui.Text))
            {
                MessageBox.Show("Người gửi không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNguoiGui.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSoDienThoaiNguoiGui.Text))
            {
                MessageBox.Show("Số điện thoại người gửi không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoaiNguoiGui.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtSoNhaNguoiGui.Text))
            {
                MessageBox.Show("Địa chỉ không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoNhaNguoiGui.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtNguoiNhan.Text))
            {
                MessageBox.Show("Người nhận không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNguoiNhan.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSoDienThoaiNguoiNhan.Text))
            {
                MessageBox.Show("Số điện thoại người nhận không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoaiNguoiNhan.Focus();
                return;
            }
            if (txtSoDienThoaiNguoiNhan.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại không đúng!", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoaiNguoiNhan.Focus();
                return;
            }
            if (cmbTinhNhan.SelectedValue == null)
            {
                MessageBox.Show("Tỉnh nhận không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTinhNhan.Focus();
                return;
            }
            if (cmbHuyenNhan.SelectedValue == null)
            {
                MessageBox.Show("Huyện nhận không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbHuyenNhan.Focus();
                return;
            }
            if (cmbXaNhan.SelectedValue == null)
            {
                MessageBox.Show("Xã nhận không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbXaNhan.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSoNhaNguoiNhan.Text))
            {
                MessageBox.Show("Địa chỉ người nhận không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoNhaNguoiNhan.Focus();
                return;
            }

            if (cmbXemHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn yêu cầu giao hàng", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbXemHang.Focus();
                return;
            }
            if (cmbLoaiThanhToan.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn cách thanh toán", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbLoaiThanhToan.Focus();
                return;
            }
            if (cmbLoaiKien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại kiện", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbLoaiKien.Focus();
                return;
            }
            GExpBillLogicInputDto item = new GExpBillLogicInputDto();
            decimal billWeight = 0;
            if (!decimal.TryParse(txtTrongLuongBill.Text.Trim(), NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out billWeight))
            {
                billWeight = 0;
            }
            item.BillWeight = billWeight;

            decimal khachHangWeight = 0;
            if (!decimal.TryParse(txtTrongLuongKH.Text.Trim(), NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out khachHangWeight))
            {
                khachHangWeight = 0;
            }
            if (khachHangWeight < billWeight)
            {
                DialogResult diglog = MessageBox.Show("Trọng lượng ghi đơn [" + billWeight + "] không được nhỏ hơn trọng lượng thanh toán khách hàng [" + khachHangWeight + "]. Bạn có muốn tiếp tục.", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (diglog == DialogResult.No)
                {
                    txtTrongLuongKH.Focus();
                    return;
                }
            }
            item.FeeWeight = khachHangWeight;
            item.RegisterUser = PBean.USER.Id;
            item.SiteCode = PBean.USER.IdAccountIntro;
            item.RegisterSiteCode = PBean.USER.CardId;
            decimal freight = 0;
            if (!decimal.TryParse(txtCuocPhiChinh.Text.Trim(), NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out freight))
            {
                freight = 0;
            }
            item.Freight = freight;
            item.PayType = cmbLoaiThanhToan.Text;

            decimal cod = 0;
            if (!decimal.TryParse(txtThuHo.Text.Trim(), NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out cod))
            {
                cod = 0;
            }
            item.COD = cod;
            item.SendMan = txtNguoiGui.Text.Trim();
            item.SendManPhone = txtSoDienThoaiNguoiGui.Text.Trim();
            item.SendManAddress = txtSoNhaNguoiGui.Text.Trim();


            item.AcceptProvinceCode = Int32.Parse(cmbTinhNhan.SelectedValue.ToString());
            item.AcceptDistrictCode = Int32.Parse(cmbHuyenNhan.SelectedValue.ToString());
            item.AcceptWardCode = cmbXaNhan.SelectedValue.ToString();
            item.AcceptMan = txtNguoiNhan.Text.Trim();
            item.AcceptManPhone = txtSoDienThoaiNguoiNhan.Text.Trim();
            item.AcceptManAddress = txtSoNhaNguoiNhan.Text.Trim();
            item.AcceptProvince = cmbTinhNhan.Text;
            item.AcceptDistrict = cmbHuyenNhan.Text;
            item.AcceptWard = cmbXaNhan.Text;
            item.LastUpdateUser = PBean.USER.Id;
            item.Note = txtYeuCauKhac.Text.Trim();
            item.BT3Type = cmbLoaiKien.SelectedValue.ToString();
            item.GoodsName = txtTenHang.Text.Trim();
            item.IsReceiveBill = chbNhanHang.Checked;
            int number = 0;
            if (!int.TryParse(txtSoLuong.Text.Trim(), out number))
            {
                number = 1;
            }
            item.GoodsNumber = number;
            item.GoodsCode = "CODE";

            int W = 0;
            if (!int.TryParse(txtW.Text.Trim(), out W))
            {
                W = 10;
            }
            item.GoodsW = W;
            int H = 0;
            if (!int.TryParse(txtH.Text.Trim(), out H))
            {
                H = 10;
            }
            item.GoodsH = H;
            int L = 0;
            if (!int.TryParse(txtL.Text.Trim(), out L))
            {
                L = 10;
            }
            item.GoodsL = L;

            if (_KhachHangHd != null)
            {
                item.FK_Customer = _KhachHangHd.Id;
            }
            else
            {
                item.FK_Customer = "0000";
            }
            item.FK_ProviderAccount = cmbLoaiKien.SelectedValue.ToString();
            item.FK_PaymentType = cmbLoaiThanhToan.SelectedValue.ToString();
            item.FK_ShipType = cmbXemHang.SelectedValue.ToString();
            item.FullName = PBean.USER.FullName;
            // Get pickupAddress
            item.Pickup = chbPickup.Checked;
            item.AddressPickup = _pickupAddress.Address;
            item.ProvincePickup = _pickupAddress.ProvincePickup;
            item.DistricPickup = _pickupAddress.DistrictPickup;
            item.WardPickup = _pickupAddress.WardPickup;
            item.NamePickup = _pickupAddress.Name;
            item.PhonePickup = _pickupAddress.Phone;
            if (status == enumAction.NEW)
            {
                item.IdOrder = _IdOrder;
                GExpBill insert = await _logic.Create(item);
                txtMaDonHang.Text = insert.BillCode;
                Gitem = await _logic.GetDetails(insert.BillCode);
                _IdOrder = string.Empty;
            }
            else if (status == enumAction.UPDATE)
            {
                //Cập nhật dữ liệu
                // Nếu chưa có mã bên thứ 3
                Tuple<bool, bool, bool> updateRs = Tuple.Create(false, false, false);
                if (Gitem.BillStatus == 0)
                {

                    updateRs = await _logic.Update(Gitem.BillCode, item).ConfigureAwait(true);
                    Gitem = await _logic.GetDetails(Gitem.BillCode);
                }
                else
                {
                    DialogResult rs = MessageBox.Show("Bạn đang thay đổi thông tin đơn hàng đã được chuyển đi. Bạn có chắc thực hiện điều này?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        updateRs = await _logic.Update(Gitem.BillCode, item).ConfigureAwait(true);
                        Gitem = await _logic.GetDetails(Gitem.BillCode);
                    }
                }

                // Kiểm tra mã đơn hàng BT3
                if (!string.IsNullOrEmpty(Gitem.BT3Code))
                {
                    if (updateRs.Item1 == true && (updateRs.Item2 == true || updateRs.Item3 == true))
                    {
                        // Thử cập nhật đơn hàng qua bên thứ 3
                        bool updateBT3 = true;
                        view_GExpBillGHNApi bill = _logic.GetDetailGHNApi(Gitem.BillCode);
                        IConnectApi api = ApiConnectUlti.GetApiByName(bill.ProviderTypeCode, bill);
                        if (updateRs.Item2 == true)
                        {
                            var result = api.UpdateCOD(bill);
                            if (result.IsSuccess == false)
                            {
                                updateBT3 = false;
                            }
                        }
                        if (updateRs.Item3 == true)
                        {
                            var result = api.UpdateOrder(bill);
                            if (result.IsSuccess == false)
                            {
                                updateBT3 = false;
                            }
                        }
                        if (updateBT3)
                        {
                            MessageBox.Show("Cập nhật đơn hàng qua API BT3 thành công!", PBean.MESSAGE_TITLE);
                        }
                        else
                        {
                            string link = bill.LinkCustomerLogin;
                            if (string.IsNullOrEmpty(link))
                            {
                                link = bill.PP_LinkCustomerLogin;
                            }
                            MessageBox.Show("Không thể cập nhật đơn hàng qua API BT3. Cập nhật thông tin tại " + link + " với user:" + bill.UserApi + " pass:" + bill.PassApi, PBean.MESSAGE_TITLE);
                        }
                    }
                }
            }
            status = 0;
            EnableButton(status);
            LoadData();
        }

        //Xóa
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gridBills.SelectedRows[0].Index;
                Gitem = await _logic.GetDetails(Convert.ToString(gridBills.Rows[index].Cells["col_BillCode"].Value)).ConfigureAwait(false);
                if (null != Gitem)
                {
                    if (Gitem.BillStatus != 0 && Gitem.BillStatus != 2)
                    {
                        MessageBox.Show("Không thể xóa đơn hàng đã tiếp nhận từ nhà vận chuyển!", PBean.MESSAGE_TITLE);
                        return;
                    }
                    if (!string.IsNullOrEmpty(Gitem.BT3Code))
                    {
                        if (MessageBox.Show("Đơn hàng đã được cấp mã BT3, bạn có chắc xóa đơn hàng này không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            return;
                        }
                    }
                    if (MessageBox.Show("Bạn có muốn xóa đơn hàng có mã vận đơn [" + Gitem.BillCode + "] không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        view_GExpBillGHNApi bill = _logic.GetDetailGHNApi(Gitem.BillCode);

                        bool res = await _logic.Delete(Gitem.BillCode);
                        if (res == true)
                        {
                            try
                            {
                                if (bill == null)
                                {
                                    return;
                                }
                                if (!string.IsNullOrEmpty(bill.BT3Code))
                                {
                                    IConnectApi api = ApiConnectUlti.GetApiByName(bill.ProviderTypeCode, bill);
                                    var result = api.CancelOrder(bill);
                                    if (result.IsSuccess != true)
                                    {
                                        MessageBox.Show(result.Message, PBean.MESSAGE_TITLE);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
                            }

                        }
                    }
                    Gitem = null;
                    status = 0;
                    EnableButton(status);
                    LoadData();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        //In
        private void btnPrint_Click(object sender, EventArgs e)
        {
            string ids = GetListBillsFromGrid();
            if (string.IsNullOrEmpty(ids))
            {
                MessageBox.Show("Chưa chọn dữ liệu cần in", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PrintMaVanDon(ids);
        }
        private async void PrintMaVanDon(string ids)
        {
            List<view_GExpBill> ls = await _logic.GetListByListIds(ids, true);
            if (ls.Count > 0)
            {
                PrintDialog printDialog = new PrintDialog();
                if (!string.IsNullOrEmpty(PBean.LOCAL_OPTIONS.PRINTER_BILL))
                {
                    printDialog.PrinterSettings.PrinterName = PBean.LOCAL_OPTIONS.PRINTER_BILL;
                }
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    PBean.LOCAL_OPTIONS.PRINTER_BILL = printDialog.PrinterSettings.PrinterName;
                    PBean.LOCAL_OPTIONS.Save();
                    // Chấp nhận in là chấp nhận kiện hàng
                    await _logic.PrintBilltByListIds(ids, true, PBean.USER.Id, PBean.USER.FullName, PBean.USER.CardId);
                    IDocumentPrint doc = DocumentPrintHelper.GetDocument(PBean.LOCAL_OPTIONS.ICON_NAME);
                    string printsize = cmbTemDan.SelectedValue.ToString();
                    foreach (var item in ls)
                    {
                        if (printsize == "76x130")
                        {
                            //130
                            doc.Print76x130(item, printDialog.PrinterSettings, false);
                        }
                        else if (printsize == "100x150")
                        {
                            // 150
                            doc.Print100x150(item, printDialog.PrinterSettings, false);
                        }
                        else if (printsize == "100x180")
                        {
                            // 180
                            doc.Print100x180(item, printDialog.PrinterSettings, false);
                        }
                    }
                    // lưu config 
                    PBean.LOCAL_OPTIONS.PrintSize = printsize;
                    PBean.LOCAL_OPTIONS.Save();
                }
            }
        }
        private async void btnInPhieuThu_Click(object sender, EventArgs e)
        {
            string ids = GetListBillsFromGrid();
            if (string.IsNullOrEmpty(ids))
            {
                MessageBox.Show("Chưa chọn dữ liệu cần in", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<view_GExpBill> ls = await _logic.GetListByListIds(ids, false);
            if (ls.Count > 0)
            {

                PrintDialog printDialog = new PrintDialog();
                if (!string.IsNullOrEmpty(PBean.LOCAL_OPTIONS.PRINTER_RECEPT))
                {
                    printDialog.PrinterSettings.PrinterName = PBean.LOCAL_OPTIONS.PRINTER_RECEPT;
                }
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    IDocumentPrint doc = DocumentPrintHelper.GetDocument(PBean.LOCAL_OPTIONS.ICON_NAME);
                    string printsize = cmbBienNhan.SelectedValue.ToString();
                    foreach (var item in ls)
                    {
                        if (printsize == "76x130")
                        {
                            //130
                            doc.Print76x130(item, printDialog.PrinterSettings, true);
                        }
                        else if (printsize == "100x150")
                        {
                            // 150
                            doc.Print100x150(item, printDialog.PrinterSettings, true);
                        }
                        else if (printsize == "100x180")
                        {
                            // 180
                            doc.Print100x180(item, printDialog.PrinterSettings, true);
                        }
                    }
                    // lưu config 
                    if (PBean.LOCAL_OPTIONS.PrintSizeReceipt != printsize || PBean.LOCAL_OPTIONS.PRINTER_RECEPT != printDialog.PrinterSettings.PrinterName)
                    {
                        PBean.LOCAL_OPTIONS.PrintSizeReceipt = printsize;
                        PBean.LOCAL_OPTIONS.PRINTER_RECEPT = printDialog.PrinterSettings.PrinterName;
                        PBean.LOCAL_OPTIONS.Save();
                    }
                    // SOund
                    printSound.Play();
                }
            }
        }
        //Kết thúc
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void cmbTinhNhan_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ActiveControl == cmbTinhNhan)
            {
                if (cmbTinhNhan.SelectedValue != null)
                {
                    cmbHuyenNhan.DataSource = await _logic.GetDanhSachHuyen(cmbTinhNhan.SelectedValue.ToString());
                    cmbHuyenNhan.DisplayMember = "DistrictName";
                    cmbHuyenNhan.ValueMember = "DistrictID";
                    cmbAutoAddress.Text = txtSoNhaNguoiNhan.Text + ", " + cmbXaNhan.Text + ", " + cmbHuyenNhan.Text + ", " + cmbTinhNhan.Text;
                    // Select white list
                    // check white list trước
                    bool selectAddress = SelectProviderWhenChangeAddress(cmbTinhNhan.SelectedValue.ToString(), cmbHuyenNhan.SelectedValue);
                    if (selectAddress == false)
                    {
                        int weight = 0;
                        if (Int32.TryParse(txtTrongLuongBill.Text, NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out weight))
                        {

                            // Select Provider
                            foreach (var item in _lsProvider)
                            {
                                if (weight > item.InitWeightSelect && weight <= item.InitWeightSelectMax)
                                {
                                    cmbLoaiKien.SelectedValue = item.Id;
                                    break;
                                }
                            }
                        }
                    }
                    if (!string.IsNullOrEmpty(txtTrongLuongKH.Text))
                    {
                        if (_KhachHangHd == null)
                        {
                            txtCuocPhiChinh.Text = await _logic.GetCalculatorFee(txtTrongLuongKH.Text, string.Empty, cmbTinhNhan.SelectedValue.ToString(), PBean.USER.CardId, cmbHuyenNhan.SelectedValue.ToString());
                        }
                        else
                        {
                            txtCuocPhiChinh.Text = await _logic.GetCalculatorFee(txtTrongLuongKH.Text, _KhachHangHd.FK_GiaCuoc, cmbTinhNhan.SelectedValue.ToString(), PBean.USER.CardId, cmbHuyenNhan.SelectedValue.ToString());
                        }
                    }
                }
            }
        }
        bool SelectProviderWhenChangeAddress(string province, object district)
        {
            GExpProvider pro = _lsProviderWhiteBlack.FirstOrDefault(u => u.WhiteListProvince.Contains(province));
            if (pro != null)
            {
                if (string.IsNullOrEmpty(pro.DistrictWhiteList))
                {
                    cmbLoaiKien.SelectedValue = pro.Id;
                    return true;
                }
                else
                {
                    if (district != null)
                    {
                        if (pro.DistrictWhiteList.Contains(district.ToString()))
                        {
                            cmbLoaiKien.SelectedValue = pro.Id;
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        private async void cmbHuyenNhan_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ActiveControl == cmbHuyenNhan)
            {
                if (cmbHuyenNhan.SelectedValue != null)
                {
                    cmbXaNhan.DataSource = await _logic.GetDanhSachXa(cmbHuyenNhan.SelectedValue.ToString());
                    cmbXaNhan.DisplayMember = "WardName";
                    cmbXaNhan.ValueMember = "WardId";
                    cmbAutoAddress.Text = txtSoNhaNguoiNhan.Text + ", " + cmbXaNhan.Text + ", " + cmbHuyenNhan.Text + ", " + cmbTinhNhan.Text;
                    // check white list trước
                    bool selectAddress = SelectProviderWhenChangeAddress(cmbTinhNhan.SelectedValue.ToString(), cmbHuyenNhan.SelectedValue);
                    if (selectAddress == false)
                    {
                        int weight = 0;
                        if (Int32.TryParse(txtTrongLuongBill.Text, NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out weight))
                        {
                            // Select Provider theo cân nặng
                            foreach (var item in _lsProvider)
                            {
                                if (weight > item.InitWeightSelect && weight <= item.InitWeightSelectMax)
                                {
                                    cmbLoaiKien.SelectedValue = item.Id;
                                    break;
                                }
                            }
                        }
                    }
                    if (!string.IsNullOrEmpty(txtTrongLuongKH.Text))
                    {
                        if (_KhachHangHd == null)
                        {
                            txtCuocPhiChinh.Text = await _logic.GetCalculatorFee(txtTrongLuongKH.Text, string.Empty, cmbTinhNhan.SelectedValue.ToString(), PBean.USER.CardId, cmbHuyenNhan.SelectedValue.ToString());
                        }
                        else
                        {
                            txtCuocPhiChinh.Text = await _logic.GetCalculatorFee(txtTrongLuongKH.Text, _KhachHangHd.FK_GiaCuoc, cmbTinhNhan.SelectedValue.ToString(), PBean.USER.CardId, cmbHuyenNhan.SelectedValue.ToString());
                        }
                    }
                }
            }
        }
        private async void CalculatorPrice()
        {
            int cuocChinh = 0;
            if (!Int32.TryParse(txtCuocPhiChinh.Text.Replace(",", ""), out cuocChinh))
            {
                cuocChinh = 0;
            }
            int cod = 0;
            if (!Int32.TryParse(txtThuHo.Text.Replace(",", ""), out cod))
            {
                cod = 0;
            }
            if (cmbLoaiThanhToan.SelectedValue.ToString() == "GTT")
            {
                txtTongCuoc.Text = PCommon.FormatNumber((cod).ToString());
                lblGhiChu.Text = string.Format("(Người nhận trả: {0} VNĐ. Người gửi trả: {1} VNĐ)", PCommon.FormatNumber((cod).ToString()), PCommon.FormatNumber((cuocChinh).ToString()));
            }
            else
            {
                txtTongCuoc.Text = PCommon.FormatNumber((cuocChinh + cod).ToString());
                lblGhiChu.Text = string.Format("(Người nhận trả: {0} VNĐ. Người gửi trả 0 VNĐ)", PCommon.FormatNumber((cuocChinh + cod).ToString()));
            }
        }
        #endregion

        private void txtSoNhaNguoiNhan_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                cmbAutoAddress.Text = txtSoNhaNguoiNhan.Text + ", " + cmbXaNhan.Text + ", " + cmbHuyenNhan.Text + ", " + cmbTinhNhan.Text;
            }

        }

        private void txtThuHo_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
                CalculatorPrice();
        }


        private void cmbTinhNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }

        private void cmbHuyenNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }

        private void cmbXaNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }

        private void cmbFK_YeuCauKhiGiao_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }


        private void cmbFK_CachThanhToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }

        private void cmbFK_ExpProvider_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }

        private void cmbFK_CachVanChuyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }

        private void cmbXaNhan_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ActiveControl == cmbXaNhan)
            {
                cmbAutoAddress.Text = txtSoNhaNguoiNhan.Text + ", " + cmbXaNhan.Text + ", " + cmbHuyenNhan.Text + ", " + cmbTinhNhan.Text;
            }
        }

        private void cmbFK_ExpProvider_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCuocPhiChinh_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl == txtCuocPhiChinh)
            {
                CalculatorPrice();
            }
        }

        private async void txtSoDienThoaiNguoiGui_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSoDienThoaiNguoiGui.Text))
            {
                _KhachHangHd = _logic.GetThongTinKhachHang(txtSoDienThoaiNguoiGui.Text.Trim(), PBean.USER.CardId);
                if (_KhachHangHd != null)
                {
                    txtNguoiGui.Text = _KhachHangHd.CustomerName;
                    txtSoNhaNguoiGui.Text = _KhachHangHd.DiaChi;
                    txtTenHang.Text = _KhachHangHd.TenSanPham;
                    txtSoDienThoaiNguoiNhan.Focus();
                }
                else
                {
                    // Tìm Số điện thoại trong Sender
                    var khachLe = _logic.GetThongTinKhachHangLe(txtSoDienThoaiNguoiGui.Text.Trim(), PBean.USER.CardId);
                    if (khachLe != null)
                    {
                        txtNguoiGui.Text = khachLe.SendMan;
                        txtSoNhaNguoiGui.Text = khachLe.SendAddress;
                        txtSoDienThoaiNguoiNhan.Focus();
                    }
                    else
                    {
                        txtNguoiGui.Focus();
                        txtSoNhaNguoiGui.Text = PBean.USER.Address;
                    }
                    if (Gitem != null)
                    {
                        Gitem.FK_Customer = string.Empty;
                    }
                }
                // Cập nhật câu ghi chú thần thánh
                if (string.IsNullOrEmpty(PBean.LOCAL_OPTIONS.CustomerCare))
                {
                    txtYeuCauKhac.Text = "Đơn hàng có vấn đề vui lòng liên hệ số điện thoại " + txtSoDienThoaiNguoiGui.Text + " để được xử lý. Xin cám ơn!";
                }
                else
                {
                    txtYeuCauKhac.Text = PBean.LOCAL_OPTIONS.CustomerCare.Replace("{0}", txtSoDienThoaiNguoiGui.Text);
                }

            }
            else
            {
                _KhachHangHd = null;
                if (Gitem != null)
                {
                    Gitem.FK_Customer = string.Empty;
                }
            }
            _pickupAddress = new PickupAddressItem();
            chbPickup.Checked = false;
        }

        private async void txtSoDienThoaiNguoiNhan_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSoDienThoaiNguoiNhan.Text))
            {
                _NguoiNhan = _logic.GetThongTinNguoiNhan(txtSoDienThoaiNguoiNhan.Text.Trim());
                if (_NguoiNhan != null)
                {
                    txtNguoiNhan.Text = _NguoiNhan.AcceptMan;
                    txtSoNhaNguoiNhan.Text = _NguoiNhan.AcceptAddress;
                    cmbAutoAddress.Text = _NguoiNhan.AcceptAddressFull;
                    cmbTinhNhan.DataSource = await _logic.GetDanhSachTinh();
                    cmbTinhNhan.SelectedValue = _NguoiNhan.AcceptProvince;

                    cmbHuyenNhan.DataSource = await _logic.GetDanhSachHuyen(_NguoiNhan.AcceptProvince.ToString());
                    cmbHuyenNhan.DisplayMember = "DistrictName";
                    cmbHuyenNhan.ValueMember = "DistrictID";
                    cmbHuyenNhan.SelectedValue = _NguoiNhan.AcceptDistrict;

                    cmbXaNhan.DataSource = await _logic.GetDanhSachXa(_NguoiNhan.AcceptDistrict.ToString());
                    cmbXaNhan.DisplayMember = "WardName";
                    cmbXaNhan.ValueMember = "WardId";
                    cmbXaNhan.SelectedValue = _NguoiNhan.AcceptWard;

                    SetFocus();
                }

            }
            else
            {
                _NguoiNhan = null;
            }
        }

        private async void gridBills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(null, null);
        }

        private void lblChonKhachHang_DoubleClick(object sender, EventArgs e)
        {

            // Lựa chọn người gửi
            frmCustomerFilter frm = new frmCustomerFilter();
            frm.ShowDialog();
            _KhachHangHd = frm.CustomerSelected;
            if (_KhachHangHd != null)
            {
                if (!string.IsNullOrEmpty(_KhachHangHd.TenSanPham))
                {
                    txtTenHang.Text = _KhachHangHd.TenSanPham;
                }
                txtSoDienThoaiNguoiGui.Text = _KhachHangHd.CustomerPhone;
                txtNguoiGui.Text = _KhachHangHd.CustomerName;
                txtSoNhaNguoiGui.Text = _KhachHangHd.DiaChi;
                txtSoDienThoaiNguoiNhan.Focus();
                // Cập nhật câu ghi chú thần thánh
                txtYeuCauKhac.Text = "Đơn hàng có vấn đề vui lòng liên hệ số điện thoại " + txtSoDienThoaiNguoiGui.Text + " để được xử lý. Xin cám ơn!";
            }
            _pickupAddress = new PickupAddressItem();
            chbPickup.Checked = false;
        }

        private void cmbLoaiThanhToan_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                CalculatorPrice();
            }
        }

        private void txtTrongLuongKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }

        private void txtTrongLuongKH_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
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
        private async void btnFilter_Click(object sender, EventArgs e)
        {
            string statusSelect = GetMultiStatus();

            var result = await _logic.GetList(txtSearch.Text, PBean.USER.CardId, cmbKhachHangFilter.SelectedValue.ToString(), dateFrom.Value, dateTo.Value, cmbLoaiKienFilter.SelectedValue.ToString(), statusSelect);
            gridBills.DataSource = result;
            gridBills.ClearSelection();
            lblSoDon.Text = "Số đơn: " + result.Count.ToString();
            FormatRowKetQua();
        }

        private void chbChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                foreach (DataGridViewRow row in gridBills.Rows)
                {
                    row.Selected = chbChonTatCa.Checked;
                }
            }
        }
        private string GetListBillsFromGrid()
        {
            string result = string.Empty;
            foreach (DataGridViewRow item in gridBills.SelectedRows)
            {
                string a = Convert.ToString(item.Cells["col_BillCode"].Value);
                result = result + "'" + a + "',";
            }
            result = result.TrimEnd(',');
            return result;
        }

        private async void btnExcelExport_Click(object sender, EventArgs e)
        {
            string statusSelect = GetMultiStatus();

            var result = await _logic.GetList(txtSearch.Text, PBean.USER.CardId, cmbKhachHangFilter.SelectedValue.ToString(), dateFrom.Value, dateTo.Value, cmbLoaiKienFilter.SelectedValue.ToString(), statusSelect);
            //var result = await _logic.GetListGHN(PBean.USER.CardId, cmbKhachHangFilter.SelectedValue.ToString(), dateFrom.Value, dateTo.Value, _listNhapMa);
            if (result.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "HANG_GUI_" + string.Format("{0:dd_MM_yyyy_(HH_mm)}", DateTime.Now);
                save.Filter = "Excel Files | *.xlsx";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string templateFileName = AppDomain.CurrentDomain.BaseDirectory + "Templates\\MAU_XUAT_DON.xlsx";
                    Dictionary<string, string> lsReplace = new Dictionary<string, string>();
                    Dictionary<string, string> lsTitile = new Dictionary<string, string>();
                    List<string> lsKeyString = new List<string>();
                    lsKeyString.Add("SendManPhone");
                    lsKeyString.Add("RegisterDate");
                    lsKeyString.Add("AcceptManPhone");
                    DataTable data = MapperExtensionClass.ToDataTable<view_GExpBill>(result);
                    ExportDataToExcelTemplate.Export(templateFileName, save.FileName, 1, data, lsTitile, lsReplace, true, lsKeyString);
                    MessageBox.Show("Xuất file excel thành công!", PBean.MESSAGE_TITLE);
                }
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu vui lòng thực hiện truy vấn dữ liệu trước khi xuất Excel", PBean.MESSAGE_TITLE);
            }
            _listNhapMa = string.Empty;
        }

        private async void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gridBills.SelectedRows[0].Index;
                string billCode = Convert.ToString(gridBills.Rows[index].Cells["col_BillCode"].Value);
                bool result = await _logic.CreateDuplicate(billCode, PBean.USER.Id);
                if (result == true)
                {
                    LoadData();
                }
            }
            catch
            {
            }
        }
        void CalculatorWeight()
        {
            int W = 0;
            if (!int.TryParse(txtW.Text.Trim(), out W))
            {
                W = 0;
            }
            int H = 0;
            if (!int.TryParse(txtH.Text.Trim(), out H))
            {
                H = 0;
            }
            int L = 0;
            if (!int.TryParse(txtL.Text.Trim(), out L))
            {
                L = 0;
            }
            lblCalWeight.Text = "7.000: " + PCommon.FormatNumber(((double)(W * H * L) / 7000).ToString(), 1) + " Kg      6000: " + PCommon.FormatNumber(((double)(W * H * L) / 6000).ToString(), 1) + " Kg         5000: " + PCommon.FormatNumber(((double)(W * H * L) / 5000).ToString(), 1) + " Kg";
        }
        void ConvertWeightToLenght(int weight)
        {
            int x = 10;
            if (weight < 1000)
            {
                txtW.Text = "10";
                txtH.Text = "10";
                txtL.Text = "10";
            }
            else
            {
                //x = (int)Math.Pow(((weight / 1000) * 5000), (1.0 / 3.0));
                x = (int)Math.Sqrt((5000 * (weight / 1000)) / 60);
                txtW.Text = "60";
                txtH.Text = x.ToString();
                txtL.Text = x.ToString();
            }
            CalculatorWeight();
        }
        void ConvertWeightToLenght(int weight, int w)
        {
            int x = 10;
            if (weight < 1000)
            {
                txtW.Text = "10";
                txtH.Text = "10";
                txtL.Text = "10";
            }
            else
            {
                x = (int)Math.Sqrt((5000 * (weight / 1000)) / w);
                txtH.Text = x.ToString();
                txtL.Text = x.ToString();
            }
            CalculatorWeight();

        }
        private void txtW_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                CalculatorWeight();
            }
        }

        private void txtTrongLuongBill_Leave(object sender, EventArgs e)
        {
            // check white list trước
            bool selectAddress = SelectProviderWhenChangeAddress(cmbTinhNhan.SelectedValue.ToString(), cmbHuyenNhan.SelectedValue);
            if (selectAddress == false)
            {
                int weight = 0;
                if (Int32.TryParse(txtTrongLuongBill.Text, NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out weight))
                {
                    ConvertWeightToLenght(weight);
                    // Select Provider
                    foreach (var item in _lsProvider)
                    {
                        if (weight > item.InitWeightSelect && weight <= item.InitWeightSelectMax)
                        {
                            cmbLoaiKien.SelectedValue = item.Id;
                            break;
                        }
                    }
                }
            }
        }
        private void txtW_Leave(object sender, EventArgs e)
        {
            int weight = 0;
            if (Int32.TryParse(txtTrongLuongBill.Text, NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out weight))
            {
                int w = 0;
                if (Int32.TryParse(txtW.Text, NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out w))
                {
                    ConvertWeightToLenght(weight, w);
                }
            }
        }

        private void nạpGHNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gridBills.SelectedRows[0].Index;
                string billCode = Convert.ToString(gridBills.Rows[index].Cells["col_BillCode"].Value);
                view_GExpBillGHNApi bill = _logic.GetDetailGHNApi(billCode);
                if (string.IsNullOrEmpty(bill.BT3Code))
                {
                    IConnectApi api = ApiConnectUlti.GetApiByName(bill.ProviderTypeCode, bill);
                    var result = api.CreateOrder(bill);
                    if (result.IsSuccess == true)
                    {
                        _logic.UpdateBT3Code(bill.BillCode, result.OrderCode, result.BT3COD, result.BT3Freight, result.BT3SubCode, result.PrintData);
                        if (!string.IsNullOrEmpty(result.ShopId))
                        {
                            _logic.UpdateShopId(bill.BillCode, result.ShopId);
                        }
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show(result.Message, PBean.MESSAGE_TITLE);
                    }

                }
                else
                {
                    MessageBox.Show("Đơn hàng đã có mã hàng của bên thứ 3, không thể nạp đơn!", PBean.MESSAGE_TITLE);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
            }
        }

        private void cậpNhậtBT3CodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cập nhật mã đơn bằng tay
            try
            {
                int index = gridBills.SelectedRows[0].Index;
                string billCode = Convert.ToString(gridBills.Rows[index].Cells["col_BillCode"].Value); //
                string typeCode = Convert.ToString(gridBills.Rows[index].Cells["col_ProviderTypeCode"].Value);
                frmUpdateB3CodeManual frm = new frmUpdateB3CodeManual();
                frm.ShowDialog();
                if (frm.ChangeSuccess)
                {
                    _logic.UpdateBT3Code(billCode, frm.BillCodeBT3);
                }
            }
            catch
            {
            }

        }

        private void btnSetBillCode_Click(object sender, EventArgs e)
        {
            frmInputSearch frm = new frmInputSearch();
            frm.ShowDialog();
            _listNhapMa = frm.lsMaVanDon;
        }

        private async void menuTraCuu_Click(object sender, EventArgs e)
        {
            // Tra cứu đơn hàng trên trang thứ 3
            try
            {
                int index = gridBills.SelectedRows[0].Index;
                string billCode = Convert.ToString(gridBills.Rows[index].Cells["col_BillCode"].Value);
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

        private async void btnTiepNhanHangGui_Click(object sender, EventArgs e)
        {
            // Tiếp nhận dơn hàng
            string ids = GetListBillsFromGrid();
            if (string.IsNullOrEmpty(ids))
            {
                MessageBox.Show("Chưa chọn đơn hàng cần chấp nhận!", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<view_GExpBill> ls = await _logic.GetListByListIds(ids, true);
            if (ls.Count > 0)
            {
                // Chấp nhận in là chấp nhận kiện hàng
                int count = await _logic.ReceptionBilltByListIds(ls, PBean.USER.Id, PBean.USER.FullName, PBean.USER.CardId);
                MessageBox.Show("Đã tiếp nhận [" + count.ToString() + "] đơn hàng.", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Không tìm thấy đơn hàng!", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnTuChoiHangGui_Click(object sender, EventArgs e)
        {
            // Hủy đơn hàng
            string ids = GetListBillsFromGrid();
            if (string.IsNullOrEmpty(ids))
            {
                MessageBox.Show("Chưa chọn đơn hàng cần hủy!", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<view_GExpBill> ls = await _logic.GetListByListIds(ids, false);
            if (ls.Count > 0)
            {
                // Chấp nhận in là chấp nhận kiện hàng
                int count = await _logic.RejectBilltByListIds(ls, PBean.USER.Id, PBean.USER.FullName, PBean.USER.CardId);
                MessageBox.Show("Đã từ chối/hủy nhận [" + count.ToString() + "] đơn hàng.", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Không tìm thấy đơn hàng!", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menuTracking_Click(object sender, EventArgs e)
        {
            // Tracking
            try
            {
                int index = gridBills.SelectedRows[0].Index;
                string billCode = Convert.ToString(gridBills.Rows[index].Cells["col_BillCode"].Value);

                view_GExpBillGHNApi bill = _logic.GetDetailGHNApi(billCode);
                if (!string.IsNullOrEmpty(bill.BT3Code))
                {
                    IConnectApi api = ApiConnectUlti.GetApiByName(bill.ProviderTypeCode, bill);
                    var result = api.Tracking(bill);
                    if (result.IsSuccess == true)
                    {
                        List<GExpBillStatusName> lsStatus = ApiConnectUlti.GetTrackingNameList();
                        _logic.UpdateTracking(bill.BillCode, result, lsStatus);
                        if (result.UpdateFee == true)
                        {
                            _logic.UpdateBT3Freight(bill.BillCode, result.BT3Freight);
                        }
                        MessageBox.Show("Cập nhật trạng thái đơn hàng thành công!", PBean.MESSAGE_TITLE);
                    }
                    else
                    {
                        MessageBox.Show(result.Message, PBean.MESSAGE_TITLE);
                    }


                }
                else
                {
                    MessageBox.Show("Đơn hàng chưa có mã hàng của bên thứ 3, không thể kiểm tra đơn!", PBean.MESSAGE_TITLE);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
            }
        }

        private void btnNapNhieuDongQuaBenThu3_Click(object sender, EventArgs e)
        {
            if (_isBusyApi == true)
            {
                MessageBox.Show("Đang thực hiện dữ liệu với API, vui lòng chờ!", PBean.MESSAGE_TITLE);
                return;
            }
            string ids = GetListBillsFromGrid();
            if (string.IsNullOrEmpty(ids))
            {
                MessageBox.Show("Chưa chọn dữ liệu cần đẩy qua BT3!", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _lsViewBillApi = _logic.GetListBillApiByListIds(ids);
            if (_lsViewBillApi.Count > 0)
            {
                _countApiSucces = 0;
                _errorMessageApi = string.Empty;
                _isBusyApi = true;
                _ListIdApi = string.Empty;

                progressBar.Value = 0;
                progressBar.Minimum = 0;
                progressBar.Maximum = _lsViewBillApi.Count;
                progressBar.Visible = true;

                backgroundWorker.RunWorkerAsync();
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (var item in _lsViewBillApi)
            {
                if (string.IsNullOrEmpty(item.BT3Code))
                {
                    IConnectApi api = ApiConnectUlti.GetApiByName(item.ProviderTypeCode, item);
                    var result = api.CreateOrder(item);
                    if (result.IsSuccess == true)
                    {
                        _countApiSucces++;
                        _ListIdApi += "'" + item.BillCode + "',";
                        _logic.UpdateBT3Code(item.BillCode, result.OrderCode, result.BT3COD, result.BT3Freight, result.BT3SubCode, result.PrintData);
                        if (result.IsUpdateShope)
                        {

                        }
                    }
                    else
                    {
                        _errorMessageApi += "[" + item.BillCode + "] - " + result.Message + System.Environment.NewLine;
                    }
                }
                else
                {
                    _errorMessageApi += "[" + item.BillCode + "] - Đã tồn tại mã BT3." + System.Environment.NewLine;
                }
                backgroundWorker.ReportProgress(0);
                // Tạm dựng 1/10 s
                Thread.Sleep(100);
            }
        }
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.PerformStep();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Visible = false;
            _isBusyApi = false;
            _ListIdApi = _ListIdApi.TrimEnd(',');
            if (!string.IsNullOrEmpty(_errorMessageApi))
            {
                MessageBox.Show(_errorMessageApi, PBean.MESSAGE_TITLE);
            }
            if (!string.IsNullOrEmpty(_ListIdApi))
            {
                if (MessageBox.Show("Bạn có muốn in [" + _countApiSucces.ToString() + "] đơn hàng mới nạp qua BT3 thành công không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PrintMaVanDon(_ListIdApi);
                }
                LoadData(false);
            }
        }
        private void backgroundWorkerTracking_DoWork(object sender, DoWorkEventArgs e)
        {
            List<GExpBillStatusName> lsStatus = ApiConnectUlti.GetTrackingNameList();

            foreach (var item in _lsViewBillApi)
            {
                if (!string.IsNullOrEmpty(item.BT3Code))
                {
                    IConnectApi api = ApiConnectUlti.GetApiByName(item.ProviderTypeCode, item);
                    var result = api.Tracking(item);
                    if (result.IsSuccess == true)
                    {
                        _countApiSucces++;
                        _logic.UpdateTracking(item.BillCode, result, lsStatus);
                        if (result.UpdateFee == true)
                        {
                            _logic.UpdateBT3Freight(item.BillCode, result.BT3Freight);
                        }
                    }
                    else
                    {
                        _errorMessageApi += "[" + item.BillCode + "] - " + result.Message + System.Environment.NewLine;
                    }
                }
                else
                {
                    _errorMessageApi += "[" + item.BillCode + "] - Không có mã BT3." + System.Environment.NewLine;
                }
                backgroundWorkerTracking.ReportProgress(0);
                Thread.Sleep(100);
            }
        }

        private void backgroundWorkerTracking_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.PerformStep();
        }

        private void backgroundWorkerTracking_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Visible = false;
            _isBusyApi = false;
            if (!string.IsNullOrEmpty(_errorMessageApi))
            {
                MessageBox.Show(_errorMessageApi, PBean.MESSAGE_TITLE);
            }
        }

        private void menuThayDoiDVVC_Click(object sender, EventArgs e)
        {
            // Cập nhật mã đơn bằng tay
            try
            {
                int index = gridBills.SelectedRows[0].Index;
                string billCode = Convert.ToString(gridBills.Rows[index].Cells["col_BillCode"].Value); //
                frmThayDoiNhaVanChuyen frm = new frmThayDoiNhaVanChuyen(billCode);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btnFilter_Click(null, null);
                }
            }
            catch
            {
            }

        }

        private async void btnXuatExcelTheoNhaCungCap_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                // Xuất excel theo nhà cung cấp
                Dictionary<string, string> dic = new Dictionary<string, string>();
                foreach (var item in _lsProviderAll)
                {
                    if (dic.ContainsKey(item.GroupProvider))
                    {
                        dic[item.GroupProvider] = dic[item.GroupProvider] + "'" + item.Id + "',";
                    }
                    else
                    {
                        dic.Add(item.GroupProvider, "'" + item.Id + "',");
                    }
                }
                string templateFileName = AppDomain.CurrentDomain.BaseDirectory + "Templates\\MAU_XUAT_DON.xlsx";

                foreach (var item in dic)
                {
                    var result = await _logic.GetListExportExcel(PBean.USER.CardId, item.Value.TrimEnd(','), dateFrom.Value, dateTo.Value);
                    if (result.Count > 0)
                    {
                        Dictionary<string, string> lsReplace = new Dictionary<string, string>();
                        Dictionary<string, string> lsTitile = new Dictionary<string, string>();
                        List<string> lsKeyString = new List<string>();
                        lsKeyString.Add("SendManPhone");
                        lsKeyString.Add("RegisterDate");
                        lsKeyString.Add("BT3Code");
                        lsKeyString.Add("AcceptManPhone");
                        DataTable data = MapperExtensionClass.ToDataTable<view_GExpBillGHN>(result);
                        ExportDataToExcelTemplate.Export(templateFileName, folder.SelectedPath + "\\" + item.Key + "_" + string.Format("{0:dd.MM.yyyy}", dateFrom.Value) + "_" + string.Format("{0:dd.MM.yyyy}", dateTo.Value) + ".xlsx", 1, data, lsTitile, lsReplace, true, lsKeyString);
                    }
                }
                MessageBox.Show("Xuất file excel thành công!", PBean.MESSAGE_TITLE);

            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Check notify
            var list = _logic.GetNotificationList(PBean.USER.CardId);
            if (list.Count > 0)
            {
                notifySound.Play();
                notifyIcon.BalloonTipText = "Có " + list.Count.ToString() + " đơn hàng có vấn đề cần được kiểm tra. Click để xem chi tiết!";
                notifyIcon.BalloonTipTitle = PBean.MESSAGE_TITLE;
                notifyIcon.ShowBalloonTip(1500);
            }
        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            // Hiển thì form
            frmNotifyManager frm = PCommon.GetFormIsOpened(typeof(frmNotifyManager).Name) as frmNotifyManager;
            if (frm == null)
            {
                frm = new frmNotifyManager();
                frm.Show();
            }
            else
            {
                frm.LoadData(false);
            }
        }

        private async void btnDanhSachDatHang_Click(object sender, EventArgs e)
        {
            _IdOrder = string.Empty;
            frmOrderCustomer frm = new frmOrderCustomer();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _KhachHangHd = frm.CustomerSelected;
                GExpOrder order = frm.OrderSelected;
                if (_KhachHangHd != null)
                {
                    _IdOrder = order.Id;
                    // Thêm mới đơn hàng
                    status = enumAction.NEW;
                    EnableButton(status);
                    ClearText();
                    SetFocus();
                    // Điền các thông tin đơn hàng

                    txtSoDienThoaiNguoiGui.Text = _KhachHangHd.CustomerPhone;
                    txtNguoiGui.Text = _KhachHangHd.CustomerName;
                    txtSoNhaNguoiGui.Text = _KhachHangHd.DiaChi;
                    // Try address
                    if (order.ProvinceCode.HasValue)
                    {
                        cmbTinhNhan.SelectedValue = order.ProvinceCode;
                        cmbHuyenNhan.DataSource = await _logic.GetDanhSachHuyen(cmbTinhNhan.SelectedValue.ToString());
                        cmbHuyenNhan.DisplayMember = "DistrictName";
                        cmbHuyenNhan.ValueMember = "DistrictID";

                        if (order.DistrictCode.HasValue)
                        {
                            cmbHuyenNhan.SelectedValue = order.DistrictCode;
                            cmbXaNhan.DataSource = await _logic.GetDanhSachXa(cmbHuyenNhan.SelectedValue.ToString());
                            cmbXaNhan.DisplayMember = "WardName";
                            cmbXaNhan.ValueMember = "WardId";

                        }
                    }
                    txtSoDienThoaiNguoiNhan.Text = order.AcceptPhone;
                    txtNguoiNhan.Text = order.AcceptName;
                    txtSoNhaNguoiNhan.Text = order.AcceptAddress;

                    cmbAutoAddress.Text = txtSoNhaNguoiNhan.Text + ", " + cmbXaNhan.Text + ", " + cmbHuyenNhan.Text + ", " + cmbTinhNhan.Text;
                    txtTenHang.Text = order.GoodsName;
                    txtTrongLuongKH.Text = PCommon.FormatNumber(order.Weight.ToString());
                    txtThuHo.Text = PCommon.FormatNumber(order.COD.ToString());
                    if (order.IsShopPay)
                    {
                        cmbLoaiThanhToan.SelectedValue = "GTT";
                    }
                    else
                    {
                        cmbLoaiThanhToan.SelectedValue = "NTT";
                    }
                }
            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            frmImportOrderExcel frm = new frmImportOrderExcel();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData(false);
            }
        }



        private async void txtTrongLuongKH_Leave(object sender, EventArgs e)
        {
            try
            {
                if (_KhachHangHd == null)
                {
                    txtCuocPhiChinh.Text = await _logic.GetCalculatorFee(txtTrongLuongKH.Text, string.Empty, cmbTinhNhan.SelectedValue.ToString(), PBean.USER.CardId, cmbHuyenNhan.SelectedValue.ToString());
                }
                else
                {
                    txtCuocPhiChinh.Text = await _logic.GetCalculatorFee(txtTrongLuongKH.Text, _KhachHangHd.FK_GiaCuoc, cmbTinhNhan.SelectedValue.ToString(), PBean.USER.CardId, cmbHuyenNhan.SelectedValue.ToString());
                }
                CalculatorPrice();
            }
            catch
            {
            }

        }

        private void gridBills_SelectionChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                if (gridBills.SelectedRows.Count == gridBills.RowCount)
                {
                    chbChonTatCa.Checked = true;
                }
                else
                {
                    chbChonTatCa.Checked = false;
                }
            }

        }

        private void btnDonCoVanDe_Click(object sender, EventArgs e)
        {
            frmNotifyManager frm = new frmNotifyManager();
            frm.Show();
        }

        private void txtTrongLuongBill_Click(object sender, EventArgs e)
        {
            txtTrongLuongBill.SelectAll();
        }

        private void txtTrongLuongKH_Click(object sender, EventArgs e)
        {
            txtTrongLuongKH.SelectAll();
        }

        private void menuCapNhatCOD_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gridBills.SelectedRows[0].Index;
                string billCode = Convert.ToString(gridBills.Rows[index].Cells["col_BillCode"].Value);
                view_GExpBillGHNApi bill = _logic.GetDetailGHNApi(billCode);
                if (!string.IsNullOrEmpty(bill.BT3Code))
                {
                    IConnectApi api = ApiConnectUlti.GetApiByName(bill.ProviderTypeCode, bill);
                    var result = api.UpdateCOD(bill);
                    if (result.IsSuccess == true)
                    {
                        MessageBox.Show("Cập nhật COD thành công", PBean.MESSAGE_TITLE);
                    }
                    else
                    {
                        MessageBox.Show(result.Message, PBean.MESSAGE_TITLE);
                    }
                }
                else
                {
                    MessageBox.Show("Đơn hàng chưa có mã hàng của bên thứ 3, không thể cập nhật COD!", PBean.MESSAGE_TITLE);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
            }
        }

        private void menuCapNhatTT_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gridBills.SelectedRows[0].Index;
                string billCode = Convert.ToString(gridBills.Rows[index].Cells["col_BillCode"].Value);
                view_GExpBillGHNApi bill = _logic.GetDetailGHNApi(billCode);
                if (!string.IsNullOrEmpty(bill.BT3Code))
                {
                    IConnectApi api = ApiConnectUlti.GetApiByName(bill.ProviderTypeCode, bill);
                    var result = api.UpdateOrder(bill);
                    if (result.IsSuccess == true)
                    {
                        MessageBox.Show("Cập nhật thông tin đơn hàng thành công", PBean.MESSAGE_TITLE);
                    }
                    else
                    {
                        MessageBox.Show(result.Message, PBean.MESSAGE_TITLE);
                    }
                }
                else
                {
                    MessageBox.Show("Đơn hàng chưa có mã hàng của bên thứ 3, không thể cập nhật thông tin đơn hàng!", PBean.MESSAGE_TITLE);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
            }
        }

        private void cmbAutoAddress_SelectedValueChanged(object sender, EventArgs e)
        {
            // Select tỉnh huyển xã
            if (ActiveControl == sender && cmbAutoAddress.SelectedValue != null)
            {
                // Lựa chọn các combox tỉnh huyện xã
                SelectAddress(cmbAutoAddress.SelectedValue.ToString());
            }
        }
        private async void SelectAddress(string wardId)
        {
            GExpWard ward = _logic.GetXaDetail(wardId);
            if (ward != null)
            {
                cmbTinhNhan.DataSource = await _logic.GetDanhSachTinh();
                cmbTinhNhan.DisplayMember = "ProvinceName";
                cmbTinhNhan.ValueMember = "ProvinceID";
                cmbTinhNhan.SelectedValue = ward.ProvinceID;

                cmbHuyenNhan.DataSource = await _logic.GetDanhSachHuyen(ward.ProvinceID.ToString());
                cmbHuyenNhan.DisplayMember = "DistrictName";
                cmbHuyenNhan.ValueMember = "DistrictID";
                cmbHuyenNhan.SelectedValue = ward.DistrictID;

                cmbXaNhan.DataSource = await _logic.GetDanhSachXa(ward.DistrictID.ToString());
                cmbXaNhan.DisplayMember = "WardName";
                cmbXaNhan.ValueMember = "WardId";
                cmbXaNhan.SelectedValue = ward.WardId;

                cmbAutoAddress.Text = txtSoNhaNguoiNhan.Text + ", " + cmbXaNhan.Text + ", " + cmbHuyenNhan.Text + ", " + cmbTinhNhan.Text;

                // Kiểm tra loại provider
                bool select = SelectProviderWhenChangeAddress(cmbTinhNhan.SelectedValue.ToString(), cmbHuyenNhan.SelectedValue);
            }
        }

        private void btnTrackingMulti_Click(object sender, EventArgs e)
        {
            if (_isBusyApi == true)
            {
                MessageBox.Show("Đang thực hiện xử lý dữ liệu với API vui lòng chờ!", PBean.MESSAGE_TITLE);
                return;
            }
            string ids = GetListBillsFromGrid();
            if (string.IsNullOrEmpty(ids))
            {
                MessageBox.Show("Chưa chọn dữ liệu cần kiểm tra!", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _lsViewBillApi = _logic.GetListBillApiByListIds(ids);
            if (_lsViewBillApi.Count > 0)
            {
                _countApiSucces = 0;
                _errorMessageApi = string.Empty;
                _isBusyApi = true;
                _ListIdApi = string.Empty;

                progressBar.Value = 0;
                progressBar.Minimum = 0;
                progressBar.Maximum = _lsViewBillApi.Count;
                progressBar.Visible = true;
                backgroundWorkerTracking.RunWorkerAsync();
            }
        }

        private void txtSoDienThoaiNguoiGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }

        private void txtSoDienThoaiNguoiNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }

        private void lblChonKhachHang_MouseEnter(object sender, EventArgs e)
        {
            lblChonKhachHang.ForeColor = Color.OrangeRed;
        }

        private void lblChonKhachHang_MouseLeave(object sender, EventArgs e)
        {
            lblChonKhachHang.ForeColor = Color.Navy;
        }

        private void chbPickup_CheckedChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                if (chbPickup.Checked == true)
                {
                    frmUpdatePickupBT3 frm = new frmUpdatePickupBT3();
                    frm.pickupAddress = _pickupAddress;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        _pickupAddress = frm.pickupAddress;
                        lblPickupAdress.Text = frm.FullAddress;
                    }
                }
                else
                {
                    _pickupAddress = new PickupAddressItem();
                    lblPickupAdress.Text = string.Empty;
                }
            }
        }
    }

}
