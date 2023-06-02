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
    public partial class frmQuanLyNhanHang : frmBase
    {
        private QuanLyNhanHangLogic _logic = new QuanLyNhanHangLogic(PBean.ConnectionBase);
        private enumAction status = enumAction.NONE;
        private view_GExpReceiveTask Gitem;

        public frmQuanLyNhanHang() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            gridMain.AutoGenerateColumns = false;
            this.gridMain.RowTemplate.MinimumHeight = 22;
            Separator();
        }

        private void frmQuanLyNhanHang_Load(object sender, EventArgs e)
        {
            datePickup.Value = DateTime.Now.Date;
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
                cmbFK_CustomerId.Enabled = false;
                cmbFK_ShipperId.Enabled = false;
                txtGoodsNumber.Enabled = false;
                chbHaveReturn.Enabled = false;
                txtNote.Enabled = false;
                txtKHFilter.Enabled = false;
                txtShipperFilter.Enabled = false;
            }
            if (stus == enumAction.NEW)
            {
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                cmbFK_CustomerId.Enabled = true;
                cmbFK_ShipperId.Enabled = true;
                txtGoodsNumber.Enabled = true;
                chbHaveReturn.Enabled = true;
                txtNote.Enabled = true;
                txtKHFilter.Enabled = true;
                txtShipperFilter.Enabled = true;
            }
            if (stus == enumAction.UPDATE)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                cmbFK_CustomerId.Enabled = true;
                cmbFK_ShipperId.Enabled = true;
                txtGoodsNumber.Enabled = true;
                chbHaveReturn.Enabled = true;
                txtNote.Enabled = true;
                txtKHFilter.Enabled = true;
                txtShipperFilter.Enabled = true;
            }
        }
        // Xóa trắng tất cả các textbox.
        private void ClearText()
        {
            txtGoodsNumber.Text = "1";
            txtNote.Text = string.Empty;
        }

        // Fill dữ liệu vào các control.
        private void FillData(view_GExpReceiveTask item, bool copy)
        {
            if (!copy)
            {
            }
            cmbFK_CustomerId.SelectedValue = item.FK_CustomerId;
            cmbFK_ShipperId.SelectedValue = item.FK_ShipperId;
            txtGoodsNumber.Text = item.GoodsNumber.ToString();
            chbHaveReturn.Checked = item.HaveReturn;
            txtNote.Text = item.Note;
        }

        #region Xử lý TextBox tìm kiếm dữ liệu trên form
        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var result = await _logic.GetList(txtSearch.Text, datePickup.Value.Date, PBean.USER.CardId);
            gridMain.DataSource = result;
        }
        #endregion

        #endregion

        #region Xử lý sự kiện cho các button - GridControl
        private void txtGoodsNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtGoodsNumber_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }

        // Load data từ database lên lưới
        private async void LoadData(bool reload = false)
        {
            var result = await _logic.GetList(string.Empty, datePickup.Value.Date, PBean.USER.CardId);
            gridMain.DataSource = result;
            if (reload)
            {
                // ExpCustomer
                cmbFK_CustomerId.DataSource = await _logic.GetMasterFK_CustomerIdList(PBean.USER.CardId, string.Empty);
                cmbFK_CustomerId.DisplayMember = "CustomerName";
                cmbFK_CustomerId.ValueMember = "Id";
                // GExpShipper
                cmbFK_ShipperId.DataSource = await _logic.GetMasterFK_ShipperIdList(PBean.USER.CardId, string.Empty);
                cmbFK_ShipperId.DisplayMember = "ShipperName";
                cmbFK_ShipperId.ValueMember = "Id";
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
                txtKHFilter.Focus();

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
            if (cmbFK_CustomerId.SelectedValue == null)
            {
                MessageBox.Show("Khách hàng không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbFK_CustomerId.Focus();
                return;
            }
            if (cmbFK_ShipperId.SelectedValue == null)
            {
                MessageBox.Show("Nhân viên nhận hàng không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbFK_ShipperId.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtGoodsNumber.Text))
            {
                MessageBox.Show("Số lượng kiện không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGoodsNumber.Focus();
                return;
            }
            QuanLyNhanHangLogicInputDto item = new QuanLyNhanHangLogicInputDto();
            item.FK_CustomerId = cmbFK_CustomerId.SelectedValue.ToString();
            item.FK_ShipperId = cmbFK_ShipperId.SelectedValue.ToString();
            item.FK_Post = PBean.USER.CardId;
            item.FK_Account = PBean.USER.Id;
            item.GoodsNumber = Int32.Parse(txtGoodsNumber.Text, System.Globalization.NumberStyles.AllowThousands);
            item.HaveReturn = chbHaveReturn.Checked;
            item.Note = txtNote.Text;
            item.Date = datePickup.Value;
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

        //Kết thúc
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void datePickup_ValueChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
                LoadData();
        }

        private async void timerFilterKH_Tick(object sender, EventArgs e)
        {
            cmbFK_CustomerId.DataSource = await _logic.GetMasterFK_CustomerIdList(PBean.USER.CardId, txtKHFilter.Text);
            cmbFK_CustomerId.DisplayMember = "CustomerName";
            cmbFK_CustomerId.ValueMember = "Id";
            timerFilterKH.Stop();
        }

        private void txtKHFilter_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                timerFilterKH.Stop();
                timerFilterKH.Start();
            }
        }

        private async void txtShipperFilter_TextChanged(object sender, EventArgs e)
        {
            cmbFK_ShipperId.DataSource = await _logic.GetMasterFK_ShipperIdList(PBean.USER.CardId, string.Empty);
            cmbFK_ShipperId.DisplayMember = "ShipperName";
            cmbFK_ShipperId.ValueMember = "Id";
        }
    }
}
