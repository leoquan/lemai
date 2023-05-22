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
    public partial class frmNhapVatTu : frmBase
    {
        private NhapVatTuLogic _logic = new NhapVatTuLogic(PBean.ConnectionBase);
        private enumAction status = enumAction.NONE;
        private view_ExpSaleNhapVatTu Gitem;

        public frmNhapVatTu() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            gridMain.AutoGenerateColumns = false;
            this.gridMain.RowTemplate.MinimumHeight = 22;
            Separator();
        }

        private void frmNhapVatTu_Load(object sender, EventArgs e)
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
                cmbFK_VatTu.Enabled = false;
                txtSoLuong.Enabled = false;
                txtDonGia.Enabled = false;
                txtThanhTien.Enabled = false;
            }
            if (stus == enumAction.NEW)
            {
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                cmbFK_VatTu.Enabled = true;
                txtSoLuong.Enabled = true;
                txtDonGia.Enabled = true;
                txtThanhTien.Enabled = true;
            }
            if (stus == enumAction.UPDATE)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                cmbFK_VatTu.Enabled = true;
                txtSoLuong.Enabled = true;
                txtDonGia.Enabled = true;
                txtThanhTien.Enabled = true;
            }
        }
        // Xóa trắng tất cả các textbox.
        private void ClearText()
        {
            txtSoLuong.Text = string.Empty;
            txtDonGia.Text = string.Empty;
            txtThanhTien.Text = string.Empty;
        }

        // Fill dữ liệu vào các control.
        private void FillData(view_ExpSaleNhapVatTu item, bool copy)
        {
            if (!copy)
            {
            }
            cmbFK_VatTu.SelectedValue = item.FK_VatTu;
            txtSoLuong.Text = item.SoLuong.ToString();
            txtDonGia.Text = item.DonGia.ToString();
            txtThanhTien.Text = item.ThanhTien.ToString();
        }

        #region Xử lý TextBox tìm kiếm dữ liệu trên form
        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var result = await _logic.GetList(txtSearch.Text);
            gridMain.DataSource = result;
        }
        #endregion

        #endregion

        #region Xử lý sự kiện cho các button - GridControl
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }
        private void txtSoLuong_KeyUp(object sender, KeyEventArgs e)
        {
            base.Curency_KeyUp(sender, e);
        }
        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }
        private void txtDonGia_KeyUp(object sender, KeyEventArgs e)
        {
            base.Curency_KeyUp(sender, e);
        }
        private void txtThanhTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }
        private void txtThanhTien_KeyUp(object sender, KeyEventArgs e)
        {
            base.Curency_KeyUp(sender, e);
        }

        // Load data từ database lên lưới
        private async void LoadData(bool reload = false)
        {
            var result = await _logic.GetList(string.Empty);
            gridMain.DataSource = result;
            if (reload)
            {
                // ExpSaleVatTu
                cmbFK_VatTu.DataSource = await _logic.GetMasterFK_VatTuList();
                cmbFK_VatTu.DisplayMember = "TenVatTu";
                cmbFK_VatTu.ValueMember = "Id";
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
            if (cmbFK_VatTu.SelectedValue == null)
            {
                MessageBox.Show("Vật tư không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbFK_VatTu.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Số lượng không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }
            if (txtSoLuong.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("Số lượng không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtDonGia.Text))
            {
                MessageBox.Show("Đơn giá không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }
            if (txtDonGia.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("Đơn giá không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtThanhTien.Text))
            {
                MessageBox.Show("Thành tiền không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThanhTien.Focus();
                return;
            }
            if (txtThanhTien.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("Thành tiền không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThanhTien.Focus();
                return;
            }
            NhapVatTuLogicInputDto item = new NhapVatTuLogicInputDto();
            item.FK_VatTu = cmbFK_VatTu.SelectedValue.ToString();
            item.NguoiNhap = PBean.USER.Id;
            item.SoLuong = decimal.Parse(txtSoLuong.Text, CultureInfo.CurrentCulture);
            item.DonGia = decimal.Parse(txtDonGia.Text, CultureInfo.CurrentCulture);
            item.ThanhTien = decimal.Parse(txtThanhTien.Text, CultureInfo.CurrentCulture);
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
                        await _logic.Delete(Gitem.Id);
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
                string reportFile = "ExpSaleNhapVatTu.rpt";
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

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            decimal SoLuong;
            decimal DonGia;
            TinhToanThanhTien(out SoLuong, out DonGia);
        }
        void TinhToanThanhTien(out decimal SoLuong, out decimal DonGia)
        {
            if (string.IsNullOrEmpty(txtSoLuong.Text.Trim()) == false && string.IsNullOrEmpty(txtDonGia.Text.Trim()) == false)
            {
                //decimal soLuong;
                //int DonGia;
                if (!decimal.TryParse(txtSoLuong.Text, out SoLuong))
                {
                    SoLuong = 0;
                }
                if (!decimal.TryParse(txtDonGia.Text.Replace(",", "").Trim(), out DonGia))
                {
                    DonGia = 0;
                }
                decimal ThanhTien = SoLuong * DonGia;
                txtThanhTien.Text = PCommon.FormatNumber(ThanhTien.ToString());
            }
            else
            {
                txtThanhTien.Text = "0";
                SoLuong = 0;
                DonGia = 0;
            }
        }
    }
}
