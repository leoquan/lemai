using Common;
using LeMaiDomain;
using LeMaiLogic.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeMaiDesktop
{
    public partial class frmKienVanDe : frmBase
    {
        private GExpBillLogic _logic = new GExpBillLogic(PBean.ConnectionBase);
        public frmKienVanDe() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            dateFrom.Value = DateTime.Now.AddDays(-30);
        }

        private void frmKienVanDe_Load(object sender, EventArgs e)
        {
            LoadData(true);
        }

        private async void txtMaDonHang_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaDonHang.Text))
            {
                view_GExpBill bill = await _logic.GetDetails(txtMaDonHang.Text.Trim());
                if (bill != null)
                {
                    ucBillMain.SetView(bill);
                    btnAddProblem.Enabled = true;
                }
                else
                {
                    ucBillMain.Clear();
                    btnAddProblem.Enabled = false;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            // Xóa kiện vấn đề
            if (MessageBox.Show("Bạn có muốn xóa kiện vấn đề này không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int index = gridKienVanDe.SelectedRows[0].Index;
                    string IdProblem = Convert.ToString(gridKienVanDe.Rows[index].Cells["col_Id"].Value);
                    await _logic.DeleteProblem(IdProblem);
                    LoadData();
                }
                catch (ArgumentOutOfRangeException)
                {
                    return;
                }
            }

        }

        private void txtMaDonHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }

        private void txtNoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }

        private async void btnAddProblem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNoiDung.Text.Trim()))
            {
                txtNoiDung.Focus();
                return;
            }
            int count = await _logic.AddProblem(txtMaDonHang.Text.Trim(), txtNoiDung.Text, PBean.USER.Id, PBean.USER.FullName, PBean.USER.CardId, dateCurrentDate.Value);
            MessageBox.Show("Đăng ký kiện vấn đề thành công. Đơn hàng [" + txtMaDonHang.Text + "] có tất cả [" + count.ToString() + "] kiện vấn đề.");
            txtMaDonHang.Text = string.Empty;
            txtNoiDung.Text = string.Empty;
            ucBillMain.Clear();
            LoadData();

        }
        public async void LoadData(bool reload = false)
        {
            dateCurrentDate.Value = DateTime.Now;
            if (reload)
            {
                // Load danh sách khách hàng
                cmbKhachHangFilter.DataSource = _logic.GetCustomerListFilter(PBean.USER.CardId, txtKhachHangFilter.Text.Trim());
                cmbKhachHangFilter.DisplayMember = "CustomerName";
                cmbKhachHangFilter.ValueMember = "Id";
            }
            var list = await _logic.GetListProblem(txtBillCode.Text.Trim(), cmbKhachHangFilter.SelectedValue.ToString(), PBean.USER.CardId, dateFrom.Value, dateTo.Value);
            gridKienVanDe.AutoGenerateColumns = false;
            gridKienVanDe.DataSource = list;
            lblSoLuong.Text = PCommon.FormatNumber(list.Count.ToString());
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadData();
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
    }
}
