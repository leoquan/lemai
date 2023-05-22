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
    public partial class frmNhanVienGiaoHang : frmBase
    {
        private NhanVienGiaoHangLogic _logic = new NhanVienGiaoHangLogic(PBean.ConnectionBase);
        private enumAction status = enumAction.NONE;
        private view_GexpShipper Gitem;

        public frmNhanVienGiaoHang() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            gridMain.AutoGenerateColumns = false;
            this.gridMain.RowTemplate.MinimumHeight = 22;
            Separator();
        }

        private void frmNhanVienGiaoHang_Load(object sender, EventArgs e)
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
                txtShipperName.Enabled = false;
                txtShipperPhone.Enabled = false;
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
            }
            if (stus == enumAction.NEW)
            {
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                txtShipperName.Enabled = true;
                txtShipperPhone.Enabled = true;
                txtUserName.Enabled = true;
                txtPassword.Enabled = true;
            }
            if (stus == enumAction.UPDATE)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                txtShipperName.Enabled = true;
                txtShipperPhone.Enabled = true;
                txtUserName.Enabled = true;
                txtPassword.Enabled = true;
            }
        }
        // Xóa trắng tất cả các textbox.
        private void ClearText()
        {
            txtShipperName.Text = string.Empty;
            txtShipperPhone.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        // Fill dữ liệu vào các control.
        private void FillData(view_GexpShipper item, bool copy)
        {
            if (!copy)
            {
            }
            txtShipperName.Text = item.ShipperName;
            txtShipperPhone.Text = item.ShipperPhone;
            txtUserName.Text = item.UserName;
            txtPassword.Text = item.Password;
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
        private void txtShipperName_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtShipperPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
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
                txtShipperName.Focus();
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
            if (String.IsNullOrEmpty(txtShipperName.Text))
            {
                MessageBox.Show("Tên người giao không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShipperName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtShipperPhone.Text))
            {
                MessageBox.Show("Số điện thoại không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShipperPhone.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("UserName không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            NhanVienGiaoHangLogicInputDto item = new NhanVienGiaoHangLogicInputDto();
            item.ShipperName = txtShipperName.Text;
            item.ShipperPhone = txtShipperPhone.Text;
            item.FK_Post = PBean.USER.CardId;
            item.UserName = txtUserName.Text;
            item.Password = txtPassword.Text;
            if (status == enumAction.NEW)
            {
                await _logic.Create(item);
            }
            else if (status == enumAction.UPDATE)
            {
                await _logic.Update(Gitem.Id, item).ConfigureAwait(true);
            }
            status = 0;
            EnableButton(status);
            LoadData();
        }

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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
