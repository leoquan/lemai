using LeMaiLogic.Logic;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeMaiDomain;

namespace LeMaiDesktop
{
    public partial class frmChiDoiSoat : frmBase
    {
        private ExpDoiSoatLogic _logicDoiSoat = new ExpDoiSoatLogic(PBean.ConnectionBase);
        public string IdDoiSoatChiTiet { get; set; }
        List<view_DoiSoatChiTiet> ls = new List<view_DoiSoatChiTiet>();
        public frmChiDoiSoat() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnChiTien_Click(object sender, EventArgs e)
        {
            // Thực hiện chi tiền
            if (String.IsNullOrEmpty(txtValue.Text))
            {
                MessageBox.Show("Số tiền đối soát COD không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValue.Focus();
                return;
            }
            Dictionary<string, decimal> lsThanhToan = new Dictionary<string, decimal>();
            foreach (var item in ls)
            {
                lsThanhToan.Add(item.Id, item.ThanhToanKH);
            }
            string message = await _logicDoiSoat.ThanhToanTheoChiTiet(lsThanhToan, PBean.USER.CardId, PBean.USER.Id, lblTenKhachHang.Text, lblSoDienThoai.Text);
            if (string.IsNullOrEmpty(message) == false)
            {
                MessageBox.Show(message, PBean.MESSAGE_TITLE);
            }
            else
            {
                MessageBox.Show("Hoàn thành chi tiền đối soát cho khách", PBean.MESSAGE_TITLE);
                this.DialogResult = DialogResult.OK;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void frmChiDoiSoat_Load(object sender, EventArgs e)
        {
            string Ids = string.Empty;
            string[] split = IdDoiSoatChiTiet.Split(';');
            foreach (var item in split)
            {
                Ids = Ids + "'" + item + "',";
            }
            Ids = Ids.TrimEnd(',');
            ls = _logicDoiSoat.GetDoiSoatChiTietById(Ids);

            lblThuHo.Text = PCommon.FormatNumber(ls.Sum(u => u.ThuHo).ToString());
            lblThuHoKT.Text = PCommon.FormatNumber(ls.Sum(u => u.ThuHoKT).ToString());
            lblPhiGuiTra.Text = PCommon.FormatNumber(ls.Sum(u => u.CuocGuiTra).ToString());
            lblPhiNhanTra.Text = PCommon.FormatNumber(ls.Sum(u => u.CuocNhanTra).ToString());
            lblChiPhi.Text = PCommon.FormatNumber(ls.Sum(u => u.ChiPhi).ToString());
            lblLoiNhuan.Text = PCommon.FormatNumber(ls.Sum(u => u.LoiNhuan).ToString());
            lblDoiSoat.Text = PCommon.FormatNumber(ls.Sum(u => u.ThanhToanKH).ToString());
            lblThanhToan.Text = PCommon.FormatNumber(ls.Sum(u => u.DaThanhToanKH).ToString());
            txtValue.Text = PCommon.FormatNumber(ls.Sum(u => u.ThanhToanKH).ToString());
            if (txtValue.Text.Contains("-"))
            {
                lblBangChu.Text = "Nợ " + PCommon.ChuyenSoThanhChu(txtValue.Text.Replace(",", "").Replace("-", ""));
            }
            else
            {
                lblBangChu.Text = PCommon.ChuyenSoThanhChu(txtValue.Text.Replace(",", ""));
            }

            lblTenKhachHang.Text = ls[0].TenKhachHang;
            lblSoDienThoai.Text = ls[0].SoDienThoai;
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl == txtValue)
            {
                if (txtValue.Text.Contains("-"))
                {
                    lblBangChu.Text = "Nợ " + PCommon.ChuyenSoThanhChu(txtValue.Text.Replace(",", "").Replace("-", ""));
                }
                else
                {
                    lblBangChu.Text = PCommon.ChuyenSoThanhChu(txtValue.Text.Replace(",", ""));
                }
            }
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }

        private void txtValue_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
    }
}
