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
    public partial class frmUngCODKH : frmBase
    {
        private UngCODKHLogic _logic = new UngCODKHLogic(PBean.ConnectionBase);
        private enumAction status = enumAction.NONE;
        private view_ExpLoanCod Gitem;

        public frmUngCODKH() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            gridMain.AutoGenerateColumns = false;
            this.gridMain.RowTemplate.MinimumHeight = 22;
            Separator();
        }

        private void frmUngCODKH_Load(object sender, EventArgs e)
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
                txtBillCode.Enabled = false;
                txtValue.Enabled = false;
                chbBoiThuong.Enabled = false;
            }
            if (stus == enumAction.NEW)
            {
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                txtBillCode.Enabled = true;
                txtValue.Enabled = chbBoiThuong.Checked;
                chbBoiThuong.Enabled = true;
            }
            if (stus == enumAction.UPDATE)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                txtBillCode.Enabled = true;
                txtValue.Enabled = chbBoiThuong.Checked;
                chbBoiThuong.Enabled = true;

            }
        }
        // Xóa trắng tất cả các textbox.
        private void ClearText()
        {
            txtBillCode.Text = string.Empty;
            txtValue.Text = string.Empty;
        }

        // Fill dữ liệu vào các control.
        private void FillData(view_ExpLoanCod item, bool copy)
        {
            if (!copy)
            {
                txtBillCode.Text = item.BillCode;
            }
            txtValue.Text = item.Value.ToString();
            chbBoiThuong.Checked = item.IsBoiThuong;
            txtValue.Enabled = item.IsBoiThuong;
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
        private void txtBillCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (chbBoiThuong.Checked)
            {
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ',')
                {
                    e.Handled = true;
                }
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }
        private void txtValue_KeyUp(object sender, KeyEventArgs e)
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
                    Gitem = await _logic.GetDetails(Convert.ToString(gridMain.Rows[index].Cells["col_BillCode"].Value));
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
                txtBillCode.Focus();
            }
        }

        //Chỉnh sửa
        private async void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                int index = gridMain.SelectedRows[0].Index;
                Gitem = await _logic.GetDetails(Convert.ToString(gridMain.Rows[index].Cells["col_BillCode"].Value));
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
            if (String.IsNullOrEmpty(txtBillCode.Text))
            {
                MessageBox.Show("Mã vận đơn không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBillCode.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtValue.Text) && chbBoiThuong.Checked)
            {
                MessageBox.Show("Số tiền không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValue.Focus();
                return;
            }
            UngCODKHLogicInputDto item = new UngCODKHLogicInputDto();
            foreach (var bill in txtBillCode.Lines)
            {
                if (!string.IsNullOrEmpty(bill.Trim()))
                {
                    item.BillCode += bill.Trim() + ",";
                }
            }
            item.BillCode = item.BillCode.TrimEnd(',');
            item.FK_Account = PBean.USER.Id;
            item.CreateBy = PBean.USER.FullName;
            item.IsGiaoHangThanhCong = chbBoiThuong.Checked;
            if (item.IsGiaoHangThanhCong == true)
            {
                item.Value = decimal.Parse(txtValue.Text, CultureInfo.CurrentCulture);
            }
            else
            {
                item.Value = 0;
            }

            if (status == enumAction.NEW)
            {
                await _logic.Create(item);
            }
            else if (status == enumAction.UPDATE)
            {
                //Cập nhật dữ liệu
                await _logic.Update(Gitem.BillCode, item).ConfigureAwait(true);
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
                Gitem = await _logic.GetDetails(Convert.ToString(gridMain.Rows[index].Cells["col_BillCode"].Value)).ConfigureAwait(false);
                if (null != Gitem)
                {
                    if (MessageBox.Show("Bạn có muốn xóa không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        await _logic.Delete(Gitem.BillCode);
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
                string reportFile = "ExpLoanCod.rpt";
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

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl == txtValue)
            {
                lblBangChu.Text = "(Bằng chữ: " + PCommon.ChuyenSoThanhChu(txtValue.Text.Replace(",", "").Replace(".", "")) + ")";
            }
        }

        private void chbBoiThuong_CheckedChanged(object sender, EventArgs e)
        {
            txtValue.Enabled = chbBoiThuong.Checked;
            txtBillCode.Multiline = !chbBoiThuong.Checked;
            
        }
    }
}
