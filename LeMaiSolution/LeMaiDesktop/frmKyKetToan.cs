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
    public partial class frmKyKetToan : frmBase
    {
        private KyKetToanLogic _logic = new KyKetToanLogic(PBean.ConnectionBase);
        private enumAction status = enumAction.NONE;
        private view_ExpKyKetToan Gitem;

        public frmKyKetToan() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            gridMain.AutoGenerateColumns = false;
            this.gridMain.RowTemplate.MinimumHeight = 22;
            Separator();
        }

        private void frmKyKetToan_Load(object sender, EventArgs e)
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
            if (stus == enumAction.NONE)
            {
                btnSave.Enabled = false;
                btnNew.Text = "&Mới";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iNew;
                txtTenKy.Enabled = false;
                txtSoBangKe.Enabled = false;
                txtQuyenSoChi.Enabled = false;
                txtQuyenSoThu.Enabled = false;
                txtQuyenSoTongChi.Enabled = false;
            }
            if (stus == enumAction.NEW)
            {
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                btnEdit.Enabled = false;
                txtTenKy.Enabled = true;
                txtSoBangKe.Enabled = true;
                txtQuyenSoChi.Enabled = true;
                txtQuyenSoThu.Enabled = true;
                txtQuyenSoTongChi.Enabled = true;
            }
            if (stus == enumAction.UPDATE)
            {
                btnEdit.Enabled = false;
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                txtTenKy.Enabled = true;
                txtSoBangKe.Enabled = true;
                txtQuyenSoChi.Enabled = true;
                txtQuyenSoThu.Enabled = true;
                txtQuyenSoTongChi.Enabled = true;
            }
        }
        // Xóa trắng tất cả các textbox.
        private void ClearText()
        {
            txtTenKy.Text = string.Empty;
            txtSoBangKe.Text = string.Empty;

            txtQuyenSoChi.Text = string.Empty;
            txtQuyenSoThu.Text = string.Empty;
            txtQuyenSoTongChi.Text = string.Empty;
            txtTenKy.Focus();
        }

        // Fill dữ liệu vào các control.
        private void FillData(view_ExpKyKetToan item, bool copy)
        {
            if (!copy)
            {
            }
            txtTenKy.Text = item.TenKy;
            txtSoBangKe.Text = item.SoBangKe.ToString();
            txtQuyenSoChi.Text = item.QuyenSoChi;
            txtQuyenSoThu.Text = item.QuyenSoThu;
            txtQuyenSoTongChi.Text = item.QuyenSoTongChi;
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
        private void txtTenKy_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSoBangKe_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSoBangKe_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }

        // Load data từ database lên lưới
        private async void LoadData(bool reload = false)
        {
            var result = await _logic.GetList(string.Empty);
            gridMain.DataSource = result;
            if (reload)
            {
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
            if (String.IsNullOrEmpty(txtTenKy.Text))
            {
                MessageBox.Show("Tên kỳ kết toán không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKy.Focus();
                return;
            }
            KyKetToanLogicInputDto item = new KyKetToanLogicInputDto();
            item.TenKy = txtTenKy.Text;
            item.QuyenSoChi = txtQuyenSoChi.Text;
            item.QuyenSoThu = txtQuyenSoThu.Text;
            item.QuyenSoTongChi = txtQuyenSoTongChi.Text;
            int SoBangKe = 0;
            if(!Int32.TryParse(txtSoBangKe.Text, System.Globalization.NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out SoBangKe))
            {
                SoBangKe = 0;
            }
            item.SoBangKe = SoBangKe;

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

        
        //Kết thúc
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
