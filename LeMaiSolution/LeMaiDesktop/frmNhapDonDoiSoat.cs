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
    public partial class frmNhapDonDoiSoat : frmBase
    {
        private UngCODKHLogic _logic = new UngCODKHLogic(PBean.ConnectionBase);
        private enumAction status = enumAction.NONE;
        private GExpDoiSoatHistory Gitem;

        public frmNhapDonDoiSoat() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
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
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            if (stus == enumAction.NONE)
            {
                btnSave.Enabled = false;
                btnNew.Text = "&Mới";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iNew;
                txtBillCode.Enabled = false;
            }
            if (stus == enumAction.NEW)
            {
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                btnDelete.Enabled = false;
                txtBillCode.Enabled = true;
            }
            if (stus == enumAction.UPDATE)
            {
                btnDelete.Enabled = false;
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                txtBillCode.Enabled = true;

            }
        }
        // Xóa trắng tất cả các textbox.
        private void ClearText()
        {
            txtBillCode.Text = string.Empty;
        }

        // Fill dữ liệu vào các control.
        private void FillData(GExpDoiSoatHistory item, bool copy)
        {
            if (!copy)
            {
                txtBillCode.Text = item.BillCode;
            }
        }

        #region Xử lý TextBox tìm kiếm dữ liệu trên form
        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var result = await _logic.GetListHistory(txtSearch.Text);
            gridMain.DataSource = result;
        }
        #endregion

        #endregion

        #region Xử lý sự kiện cho các button - GridControl

        // Load data từ database lên lưới
        private async void LoadData(bool reload = false)
        {
            var result = await _logic.GetListHistory(string.Empty);
            gridMain.DataSource = result;
            if (reload)
            {
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
            item.IsGiaoHangThanhCong = chbGiaoHangThanhCong.Checked;

            if (status == enumAction.NEW)
            {
                int count = await _logic.CreateHistory(item);
                MessageBox.Show("Số đơn đối soát [" + count.ToString() + "]", PBean.MESSAGE_TITLE);
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
                Gitem = await _logic.GetDetailsHistory(Convert.ToString(gridMain.Rows[index].Cells["col_BillCode"].Value)).ConfigureAwait(false);
                if (null != Gitem)
                {
                    if (MessageBox.Show("Bạn có muốn xóa không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        await _logic.DeleteHistory(Gitem.BillCode);
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
    }
}
