using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Linq;
using Common;
using LeMaiDomain;
using LeMaiDomain.Models;
using LeMaiLogic;
using LeMaiLogic.Logic;

namespace LeMaiDesktop
{
    public partial class frmCustomer : frmBase
    {
        private CustomerLogic _logic = new CustomerLogic(PBean.ConnectionBase);
        private GExpBillLogic _logicbill = new GExpBillLogic(PBean.ConnectionBase);
        private enumAction status = enumAction.NONE;
        private view_ExpCustomer Gitem;

        public frmCustomer() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            gridMain.AutoGenerateColumns = false;
            this.gridMain.RowTemplate.MinimumHeight = 22;
            Separator();
        }

        private void frmfrmCustomer_Load(object sender, EventArgs e)
        {
            LoadData(true);
            EnableButton(status);
            ChangeLanguageUI(PBean.MAKE_LANG);

        }

        #region Xử lý phím tắt

        // Xử lý phím tắt trên form
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
                btnNew.Text = "&Mới";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iNew;
                txtCustomerName.Enabled = false;
                txtCustomerPhone.Enabled = false;
                cmbNganHang.Enabled = false;
                txtSanPham.Enabled = false;
                txtAccountName.Enabled = false;
                txtAccountCode.Enabled = false;
                txtGoogleMap.Enabled = false;
                txtCustomerCode.Enabled = false;
                chbContractCustomer.Enabled = false;
                cmbGroup.Enabled = false;
                txtTenHD.Enabled = false;
                txtDiaChi.Enabled = false;
                dateNgayKyHD.Enabled = false;
                txtSoHD.Enabled = false;
                cmbBangGia.Enabled = false;
                txtMaSoThue.Enabled = false;
                txtCongTy.Enabled = false;

            }
            if (stus == enumAction.NEW)
            {
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                txtCustomerName.Enabled = true;
                txtCustomerPhone.Enabled = true;
                cmbNganHang.Enabled = true;
                txtSanPham.Enabled = true;
                txtAccountName.Enabled = true;
                txtAccountCode.Enabled = true;
                txtGoogleMap.Enabled = true;
                txtCustomerCode.Enabled = true;
                chbContractCustomer.Enabled = true;
                cmbGroup.Enabled = true;
                txtTenHD.Enabled = true;
                txtDiaChi.Enabled = true;
                dateNgayKyHD.Enabled = true;
                txtSoHD.Enabled = true;
                cmbBangGia.Enabled = true;
                txtMaSoThue.Enabled = true;
                txtCongTy.Enabled = true;
            }
            if (stus == enumAction.UPDATE)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                txtCustomerName.Enabled = true;
                txtCustomerPhone.Enabled = true;
                cmbNganHang.Enabled = true;
                txtSanPham.Enabled = true;
                txtAccountName.Enabled = true;
                txtAccountCode.Enabled = true;
                txtGoogleMap.Enabled = true;
                txtCustomerCode.Enabled = true;
                chbContractCustomer.Enabled = true;
                cmbGroup.Enabled = true;
                txtTenHD.Enabled = true;
                txtDiaChi.Enabled = true;
                dateNgayKyHD.Enabled = true;
                txtSoHD.Enabled = true;
                cmbBangGia.Enabled = true;
                txtMaSoThue.Enabled = true;
                txtCongTy.Enabled = true;
            }
        }
        // Xóa trắng tất cả các textbox.
        private void ClearText()
        {
            txtCustomerName.Text = string.Empty;
            txtCustomerPhone.Text = string.Empty;
            txtSanPham.Text = string.Empty;
            txtAccountName.Text = string.Empty;
            txtAccountCode.Text = string.Empty;
            txtGoogleMap.Text = string.Empty;
            txtCustomerCode.Text = string.Empty;
            txtTenHD.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            dateNgayKyHD.Value = DateTime.Now;
            txtMaSoThue.Text = string.Empty;
            txtCongTy.Text = string.Empty;
            txtCustomerName.Focus();
        }

        // Fill dữ liệu vào các control.
        private async void FillData(view_ExpCustomer item, bool copy)
        {
            if (!copy)
            {
            }
            txtCustomerName.Text = item.CustomerName;
            txtCustomerPhone.Text = item.CustomerPhone;
            try
            {
                cmbNganHang.SelectedValue = item.BankName;
            }
            catch
            {
            }
            txtSanPham.Text = item.TenSanPham;
            txtAccountName.Text = item.AccountName;
            txtAccountCode.Text = item.AccountCode;
            txtGoogleMap.Text = item.GoogleMap;
            txtCustomerCode.Text = item.CustomerCode;
            chbContractCustomer.Checked = item.ContractCustomer;
            txtTenHD.Text = item.TenHopDong;
            txtDiaChi.Text = item.DiaChi;
            txtSoHD.Text = item.SoHopDong;
            txtCongTy.Text = item.DonVi;
            txtMaSoThue.Text = item.MaSoThue;
            if (item.NgayHopDong != null)
            {
                dateNgayKyHD.Value = (DateTime)item.NgayHopDong;
            }
            else
            {
                dateNgayKyHD.Value = DateTime.Now;
            }
            if (!string.IsNullOrEmpty(item.FK_Group))
            {
                cmbGroup.SelectedValue = item.FK_Group;
            }
            if (!string.IsNullOrEmpty(item.FK_GiaCuoc))
            {
                cmbBangGia.SelectedValue = item.FK_GiaCuoc;
            }
            // Load Address Nhận
            cmbTinhNhan.DataSource = await _logicbill.GetDanhSachTinh();
            cmbTinhNhan.DisplayMember = "ProvinceName";
            cmbTinhNhan.ValueMember = "ProvinceID";
            if(item.ProvinceId!=null)
            {
                cmbTinhNhan.SelectedValue = item.ProvinceId;
                cmbHuyenNhan.DataSource = await _logicbill.GetDanhSachHuyen(item.ProvinceId.ToString());
                cmbHuyenNhan.DisplayMember = "DistrictName";
                cmbHuyenNhan.ValueMember = "DistrictID";
                cmbHuyenNhan.SelectedValue = item.DistrictId;

                cmbXaNhan.DataSource = await _logicbill.GetDanhSachXa(item.DistrictId.ToString());
                cmbXaNhan.DisplayMember = "WardName";
                cmbXaNhan.ValueMember = "WardId";
                cmbXaNhan.SelectedValue = item.WardId;
            }
        }

        #region Xử lý TextBox tìm kiếm dữ liệu trên form
        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var result = await _logic.GetList(txtSearch.Text, PBean.USER.CardId);
            gridMain.DataSource = result;
        }
        #endregion

        #endregion

        #region Xử lý sự kiện cho các button - GridControl
        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtCustomerPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtBankName_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtAccountName_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtAccountCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtGoogleMap_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtCustomerCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }

        // Load data từ database lên lưới
        private async void LoadData(bool reload = false)
        {
            var result = await _logic.GetList(string.Empty, PBean.USER.CardId);
            gridMain.DataSource = result;
            if (reload)
            {
                cmbGroup.DataSource = _logic.GetListCustomer(PBean.USER.CardId);
                cmbGroup.DisplayMember = "TenNhom";
                cmbGroup.ValueMember = "Id";

                cmbBangGia.DataSource = _logic.GetListFee(PBean.USER.CardId);
                cmbBangGia.DisplayMember = "FeeName";
                cmbBangGia.ValueMember = "Id";

                cmbNganHang.DataSource = _logic.GetListBank();
                cmbNganHang.DisplayMember = "BankName";
                cmbNganHang.ValueMember = "BankCode";

                // Load tỉnh huyện xã
                var listTinh = await _logicbill.GetDanhSachTinh();
                cmbTinhNhan.DataSource = listTinh;
                cmbTinhNhan.DisplayMember = "ProvinceName";
                cmbTinhNhan.ValueMember = "ProvinceID";
                if (listTinh.Count > 0)
                {
                    cmbTinhNhan.SelectedValue = listTinh[0].ProvinceID;
                    var listHuyen = await _logicbill.GetDanhSachHuyen(cmbTinhNhan.SelectedValue.ToString());
                    cmbHuyenNhan.DataSource = listHuyen;
                    cmbHuyenNhan.DisplayMember = "DistrictName";
                    cmbHuyenNhan.ValueMember = "DistrictID";
                    if (listHuyen.Count > 0)
                    {
                        cmbHuyenNhan.SelectedValue = listHuyen[0].DistrictID;
                        cmbXaNhan.DataSource = await _logicbill.GetDanhSachXa(cmbHuyenNhan.SelectedValue.ToString());
                        cmbXaNhan.DisplayMember = "WardName";
                        cmbXaNhan.ValueMember = "WardId";
                    }
                }
            }

        }

        private async void gridMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (status != enumAction.NEW)
            {
                btnEdit_Click(null, null);
            }
            else
            {
                try
                {
                    int index = gridMain.SelectedRows[0].Index;
                    Gitem = await _logic.GetDetails(Convert.ToString(gridMain.Rows[index].Cells["col_Id"].Value));
                    if (null != Gitem)
                    {
                        FillData(Gitem, true);
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    return;
                }
            }
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
                LoadData();
                status = enumAction.NEW;
                EnableButton(status);
                ClearText();
            }
        }

        //Chỉnh sửa
        private async void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                int index = gridMain.SelectedRows[0].Index;
                Gitem = await _logic.GetDetails(Convert.ToString(gridMain.Rows[index].Cells["col_Id"].Value));
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
            if (String.IsNullOrEmpty(txtCustomerName.Text))
            {
                MessageBox.Show("Tên không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtCustomerPhone.Text))
            {
                MessageBox.Show("Số điện thoại không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerPhone.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtCustomerCode.Text))
            {
                MessageBox.Show("Mã khách hàng không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerCode.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Địa chỉ khách hàng không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            CustomerLogicInputDto item = new CustomerLogicInputDto();
            item.CustomerName = txtCustomerName.Text;
            item.CustomerPhone = txtCustomerPhone.Text;
            if(cmbNganHang.SelectedValue!=null)
            {
                item.BankName = cmbNganHang.SelectedValue.ToString();
            }
            item.TenSanPham = txtSanPham.Text;
            item.AccountName = txtAccountName.Text;
            item.AccountCode = txtAccountCode.Text;
            item.GoogleMap = txtGoogleMap.Text;
            item.CustomerCode = txtCustomerCode.Text;
            item.ContractCustomer = chbContractCustomer.Checked;
            item.FK_Group = cmbGroup.SelectedValue.ToString();
            item.NgayHopDong = dateNgayKyHD.Value;
            item.TenHopDong = txtTenHD.Text.Trim();
            item.DiaChi = txtDiaChi.Text.Trim();
            item.SoHopDong = txtSoHD.Text.Trim();
            item.FK_BangGia = cmbBangGia.SelectedValue.ToString();
            item.TenCongTy = txtCongTy.Text.Trim();
            item.MaSoThue = txtMaSoThue.Text.Trim();
            item.IsPickup = chbPickup.Checked;
            item.WardId = cmbXaNhan.SelectedValue.ToString();
            item.ProvinceId = Int32.Parse(cmbTinhNhan.SelectedValue.ToString());
            item.DistrictId = Int32.Parse(cmbHuyenNhan.SelectedValue.ToString());

            if (status == enumAction.NEW)
            {
                item.FK_Post = PBean.USER.CardId;
                string message = await _logic.Create(item);
                if (!string.IsNullOrEmpty(message))
                {
                    MessageBox.Show(message, PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCustomerCode.Focus();
                }
                else
                {
                    LoadData();
                    status = 0;
                    EnableButton(status);
                }

            }
            else if (status == enumAction.UPDATE)
            {
                //Cập nhật dữ liệu
                string message = await _logic.Update(Gitem.Id, item).ConfigureAwait(true);
                if (!string.IsNullOrEmpty(message))
                {
                    MessageBox.Show(message, PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCustomerCode.Focus();
                }
                else
                {
                    LoadData();
                    status = 0;
                    EnableButton(status);
                }
            }


        }

        //Xóa
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gridMain.SelectedRows[0].Index;
                Gitem = await _logic.GetDetails(Convert.ToString(gridMain.Rows[index].Cells["col_Id"].Value)).ConfigureAwait(false);
                if (null != Gitem)
                {
                    if (MessageBox.Show("Bạn có muốn xóa khách hàng [" + Gitem.CustomerName + "] không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool resutl = await _logic.Delete(Gitem.Id);
                        if (resutl == true)
                        {
                            Gitem = null;
                            status = 0;
                            EnableButton(status);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Khách hàng đã phát sinh dữ liệu đơn hàng, không thể xóa!", PBean.MESSAGE_TITLE);
                        }
                    }

                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }
        //In
        private async void btnPrint_Click(object sender, EventArgs e)
        {
            if (Gitem == null)
            {
                try
                {
                    int index = gridMain.SelectedRows[0].Index;
                    Gitem = await _logic.GetDetails(Convert.ToString(gridMain.Rows[index].Cells["col_Id"].Value));
                }
                catch
                {
                }
            }
            if (Gitem != null)
            {
                DataTable printKetQua = _logic.GetCustomer(Gitem.Id);
                Common.Report.LVReport report = new Common.Report.LVReport();
                string reportFile = AppDomain.CurrentDomain.BaseDirectory + PConstants.FOLDER_REPORT.TrimEnd('\\') + "\\HopDongKhachHang.rpt";
                if (!string.IsNullOrEmpty(Gitem.DonVi))
                {
                    //Mẫu công ty
                    reportFile = AppDomain.CurrentDomain.BaseDirectory + PConstants.FOLDER_REPORT.TrimEnd('\\') + "\\HopDongKhachHangCTY.rpt";
                }

                report.ShowReport(reportFile, "A4", false, "Hợp đồng khách hàng", PBean.MESSAGE_TITLE, printKetQua, true, false);
            }
        }
        //Kết thúc
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void txtCustomerCode_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl == txtCustomerCode)
            {
                txtSoHD.Text = txtCustomerCode.Text.Replace("VN80826", "");
            }
        }

        private void btnTaoMaKH_Click(object sender, EventArgs e)
        {
            txtCustomerCode.Text = _logic.GetCustomerCode(PBean.USER.CardId);
        }

        private void txtCustomerPhone_Leave(object sender, EventArgs e)
        {
            if (txtCustomerPhone.Text.Length >= 6)
            {
                txtCustomerCode.Text = txtCustomerPhone.Text.Substring(txtCustomerPhone.Text.Length - 6);
            }
        }

        private void btnThemNhom_Click(object sender, EventArgs e)
        {
            frmQuanLyNhomKhachHang frm = new frmQuanLyNhomKhachHang();
            frm.ShowDialog();
            LoadData(true);
        }

        private async void cmbTinhNhan_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ActiveControl == cmbTinhNhan)
            {
                if (cmbTinhNhan.SelectedValue != null)
                {
                    cmbHuyenNhan.DataSource = await _logicbill.GetDanhSachHuyen(cmbTinhNhan.SelectedValue.ToString());
                    cmbHuyenNhan.DisplayMember = "DistrictName";
                    cmbHuyenNhan.ValueMember = "DistrictID";
                }
            }
        }

        private async void cmbHuyenNhan_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ActiveControl == cmbHuyenNhan)
            {
                if (cmbHuyenNhan.SelectedValue != null)
                {
                    cmbXaNhan.DataSource = await _logicbill.GetDanhSachXa(cmbHuyenNhan.SelectedValue.ToString());
                    cmbXaNhan.DisplayMember = "WardName";
                    cmbXaNhan.ValueMember = "WardId";
                }
            }
        }
    }
}
