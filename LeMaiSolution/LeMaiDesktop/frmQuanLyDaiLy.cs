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
    public partial class frmQuanLyDaiLy : frmBase
    {
        private QuanLyDaiLyLogic _logic = new QuanLyDaiLyLogic(PBean.ConnectionBase);
        private enumAction status = enumAction.NONE;
        private view_ExpPost Gitem;

        public frmQuanLyDaiLy() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            gridMain.AutoGenerateColumns = false;
            this.gridMain.RowTemplate.MinimumHeight = 22;
            Separator();
        }

        private void frmQuanLyDaiLy_Load(object sender, EventArgs e)
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
                txtId.Enabled = false;
                txtTenDaiLy.Enabled = false;
                txtPhone.Enabled = false;
                txtDiaChi.Enabled = false;
                txtEmail.Enabled = false;
                txtQuanLy.Enabled = false;
                txtSoDienThoai.Enabled = false;
                txtMaBuuCuc.Enabled = false;
                txtDieuPhoi.Enabled = false;
                txtCMND.Enabled = false;
                dtpNgayCap.Enabled = false;
                txtSDTCaNhan.Enabled = false;
                txtSoTaiKhoan.Enabled = false;
                txtNganHang.Enabled = false;
                txtThuongTru.Enabled = false;
                cmbFK_DVHC.Enabled = false;
                txtGoogleMap.Enabled = false;
                cmbParrentPost.Enabled = false;
                txtDeliveryFee.Enabled = false;
                txtSytemFee.Enabled = false;
                txtCodeFee.Enabled = false;
                txtCODFee.Enabled = false;
                txtInternalDeliveryFee.Enabled = false;
                txtShipperFee.Enabled = false;
            }
            if (stus == enumAction.NEW)
            {
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                txtId.Enabled = true;
                txtTenDaiLy.Enabled = true;
                txtPhone.Enabled = true;
                txtDiaChi.Enabled = true;
                txtEmail.Enabled = true;
                txtQuanLy.Enabled = true;
                txtSoDienThoai.Enabled = true;
                txtMaBuuCuc.Enabled = true;
                txtDieuPhoi.Enabled = true;
                txtCMND.Enabled = true;
                dtpNgayCap.Enabled = true;
                txtSDTCaNhan.Enabled = true;
                txtSoTaiKhoan.Enabled = true;
                txtNganHang.Enabled = true;
                txtThuongTru.Enabled = true;
                cmbFK_DVHC.Enabled = true;
                txtGoogleMap.Enabled = true;
                cmbParrentPost.Enabled = true;
                txtDeliveryFee.Enabled = true;
                txtSytemFee.Enabled = true;
                txtCodeFee.Enabled = true;
                txtCODFee.Enabled = true;
                txtInternalDeliveryFee.Enabled = true;
                txtShipperFee.Enabled = true;
            }
            if (stus == enumAction.UPDATE)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                txtId.Enabled = true;
                txtTenDaiLy.Enabled = true;
                txtPhone.Enabled = true;
                txtDiaChi.Enabled = true;
                txtEmail.Enabled = true;
                txtQuanLy.Enabled = true;
                txtSoDienThoai.Enabled = true;
                txtMaBuuCuc.Enabled = true;
                txtDieuPhoi.Enabled = true;
                txtCMND.Enabled = true;
                dtpNgayCap.Enabled = true;
                txtSDTCaNhan.Enabled = true;
                txtSoTaiKhoan.Enabled = true;
                txtNganHang.Enabled = true;
                txtThuongTru.Enabled = true;
                cmbFK_DVHC.Enabled = true;
                txtGoogleMap.Enabled = true;
                cmbParrentPost.Enabled = true;
                txtDeliveryFee.Enabled = true;
                txtSytemFee.Enabled = true;
                txtCodeFee.Enabled = true;
                txtCODFee.Enabled = true;
                txtInternalDeliveryFee.Enabled = true;
                txtShipperFee.Enabled = true;
            }
        }
        // Xóa trắng tất cả các textbox.
        private void ClearText()
        {
            txtId.Text = string.Empty;
            txtTenDaiLy.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtQuanLy.Text = string.Empty;
            txtSoDienThoai.Text = string.Empty;
            txtMaBuuCuc.Text = string.Empty;
            txtDieuPhoi.Text = string.Empty;
            txtCMND.Text = string.Empty;
            txtSDTCaNhan.Text = string.Empty;
            txtSoTaiKhoan.Text = string.Empty;
            txtNganHang.Text = string.Empty;
            txtThuongTru.Text = string.Empty;
            txtGoogleMap.Text = string.Empty;
            txtDeliveryFee.Text = string.Empty;
            txtSytemFee.Text = string.Empty;
            txtCodeFee.Text = string.Empty;
            txtCODFee.Text = string.Empty;
            txtInternalDeliveryFee.Text = string.Empty;
            txtShipperFee.Text = string.Empty;
        }

        // Fill dữ liệu vào các control.
        private void FillData(view_ExpPost item, bool copy)
        {
            if (!copy)
            {
                txtId.Text = item.Id;
            }
            txtTenDaiLy.Text = item.TenDaiLy;
            txtPhone.Text = item.Phone;
            txtDiaChi.Text = item.DiaChi;
            txtEmail.Text = item.Email;
            txtQuanLy.Text = item.QuanLy;
            txtSoDienThoai.Text = item.SoDienThoai;
            txtMaBuuCuc.Text = item.MaBuuCuc;
            txtDieuPhoi.Text = item.DieuPhoi;
            txtCMND.Text = item.CMND;
            if (item.NgayCap != null)
            {
                dtpNgayCap.Value = (DateTime)item.NgayCap;
            }
            txtSDTCaNhan.Text = item.SDTCaNhan;
            txtSoTaiKhoan.Text = item.SoTaiKhoan;
            txtNganHang.Text = item.NganHang;
            txtThuongTru.Text = item.ThuongTru;
            cmbFK_DVHC.SelectedValue = item.FK_DVHC;
            txtGoogleMap.Text = item.GoogleMap;
            if (item.ParrentPost != null)
            {
                cmbParrentPost.SelectedValue = item.ParrentPost;
            }
            txtDeliveryFee.Text = item.DeliveryFee.ToString();
            txtSytemFee.Text = item.SytemFee.ToString();
            txtCodeFee.Text = item.CodeFee.ToString();
            txtCODFee.Text = item.CODFee.ToString();
            txtInternalDeliveryFee.Text = item.InternalDeliveryFee.ToString();
            txtShipperFee.Text = item.ShipperFee.ToString();
        }

        #region Xử lý TextBox tìm kiếm dữ liệu trên form
        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var result = await _logic.GetList(txtSearch.Text, PBean.USER);
            gridMain.DataSource = result;
        }
        #endregion

        #endregion

        #region Xử lý sự kiện cho các button - GridControl
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtTenDaiLy_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtQuanLy_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtMaBuuCuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtIDLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtDieuPhoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtNamSinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtNamSinh_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void dtpNgayCap_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSDTCaNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSoTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtNganHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtThuongTru_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtGoogleMap_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtDeliveryFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtDeliveryFee_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtSytemFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSytemFee_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtCodeFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtCodeFee_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtCODFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtCODFee_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtInternalDeliveryFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtInternalDeliveryFee_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtShipperFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtShipperFee_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtZoneCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }

        // Load data từ database lên lưới
        private async void LoadData(bool reload = false)
        {
            var result = await _logic.GetList(string.Empty, PBean.USER);
            gridMain.DataSource = result;
            if (reload)
            {
                // GExpProvince
                cmbFK_DVHC.DataSource = await _logic.GetMasterFK_DVHCList();
                cmbFK_DVHC.DisplayMember = "ProvinceName";
                cmbFK_DVHC.ValueMember = "ProvinceID";
                // ExpPost
                cmbParrentPost.DataSource = await _logic.GetMasterParrentPostList(PBean.USER);
                cmbParrentPost.DisplayMember = "TenDaiLy";
                cmbParrentPost.ValueMember = "Id";
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
            if (String.IsNullOrEmpty(txtTenDaiLy.Text))
            {
                MessageBox.Show("Tên đại lý không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDaiLy.Focus();
                return;
            }
            if (cmbFK_DVHC.SelectedValue == null)
            {
                MessageBox.Show("Tỉnh không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbFK_DVHC.Focus();
                return;
            }
            QuanLyDaiLyLogicInputDto item = new QuanLyDaiLyLogicInputDto();
            item.Id = txtId.Text;
            item.Code = txtId.Text;
            item.TenDaiLy = txtTenDaiLy.Text;
            item.Phone = txtPhone.Text;
            item.DiaChi = txtDiaChi.Text;
            item.Email = txtEmail.Text;
            item.QuanLy = txtQuanLy.Text;
            item.SoDienThoai = txtSoDienThoai.Text;
            item.MaBuuCuc = txtMaBuuCuc.Text;
            item.DieuPhoi = txtDieuPhoi.Text;
            item.NamSinh = 0;
            item.CMND = txtCMND.Text;
            item.NgayCap = dtpNgayCap.Value;
            item.SDTCaNhan = txtSDTCaNhan.Text;
            item.SoTaiKhoan = txtSoTaiKhoan.Text;
            item.NganHang = txtNganHang.Text;
            item.ThuongTru = txtThuongTru.Text;
            item.FK_DVHC = Int32.Parse(cmbFK_DVHC.SelectedValue.ToString());
            item.CreateBy = PBean.USER.Id;
            item.GoogleMap = txtGoogleMap.Text;
            if(cmbParrentPost.SelectedValue!=null)
            {
                item.ParrentPost = cmbParrentPost.SelectedValue.ToString();
            }     
            item.DeliveryFee = Int32.Parse(txtDeliveryFee.Text == string.Empty ? "0" : txtDeliveryFee.Text, System.Globalization.NumberStyles.AllowThousands);
            item.SytemFee = Int32.Parse(txtSytemFee.Text == string.Empty ? "0" : txtSytemFee.Text, System.Globalization.NumberStyles.AllowThousands);
            item.CodeFee = Int32.Parse(txtCodeFee.Text == string.Empty ? "0" : txtCodeFee.Text, System.Globalization.NumberStyles.AllowThousands);
            item.CODFee = Int32.Parse(txtCODFee.Text == string.Empty ? "0" : txtCODFee.Text, System.Globalization.NumberStyles.AllowThousands);
            item.InternalDeliveryFee = Int32.Parse(txtInternalDeliveryFee.Text == string.Empty ? "0" : txtInternalDeliveryFee.Text, System.Globalization.NumberStyles.AllowThousands);
            item.ShipperFee = Int32.Parse(txtShipperFee.Text == string.Empty ? "0" : txtShipperFee.Text, System.Globalization.NumberStyles.AllowThousands);
            item.ZoneCode = "1";

            if (status == enumAction.NEW)
            {
                await _logic.Create(item);
            }
            else if (status == enumAction.UPDATE)
            {
                //Cập nhật dữ liệu
                await _logic.Update(Gitem.Id, item).ConfigureAwait(true);
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
                int index = gridMain.SelectedRows[0].Index;
                Gitem = await _logic.GetDetails(Convert.ToString(gridMain.Rows[index].Cells["col_Id"].Value)).ConfigureAwait(false);
                if (null != Gitem)
                {
                    if (MessageBox.Show("Bạn có muốn xóa không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //await _logic.Delete(Gitem.Id);
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
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                DataTable data;
                string reportFile = "ExpPost.rpt";
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
            }
            finally
            {
                dc.Close();

            }
        }
        //Kết thúc
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
