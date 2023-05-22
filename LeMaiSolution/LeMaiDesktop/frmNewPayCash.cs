using LeMaiDomain;
using LeMaiDomain.Models;
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

namespace LeMaiDesktop
{
    public partial class frmNewPayCash : frmBase
    {
        public bool IsPay = false;
        private SoQuyChiTienLogic _logic = new SoQuyChiTienLogic(PBean.ConnectionBase);
        private ExpConsignmentCashPayType cashType = null;
        public frmNewPayCash() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            Separator();
        }

        private async void frmNewPayCash_Load(object sender, EventArgs e)
        {
            ExpPost post = await _logic.GetExpPostDetail(PBean.USER.companyid);
            if (post != null)
            {
                lblTotal.Text = PCommon.FormatNumber(post.ValueBlanceMoney.ToString()) + " VNĐ";
            }
            else
            {
                MessageBox.Show("Tài khoản không có quyền sử dụng chức năng thu chi?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.Cancel;
            }
            if (IsPay == true)
            {
                // Chi tiền
                lblTitle.Text = "CHI TIỀN";
                cmbLoai.DataSource = await _logic.GetMasterCashPayTypeList();
                cmbLoai.DisplayMember = "TenLoai";
                cmbLoai.ValueMember = "Id";
                this.cmbLoai.SelectedValueChanged += new System.EventHandler(this.cmbLoai_SelectedValueChanged);
                cmbLoai_SelectedValueChanged(null, null);

            }
            else
            {
                // Thu tiền
                lblTitle.Text = "THU TIỀN";
                cmbLoai.DataSource = await _logic.GetMasterCashTypeList();
                cmbLoai.DisplayMember = "TenLoai";
                cmbLoai.ValueMember = "Id";
                this.cmbLoai.SelectedValueChanged += new System.EventHandler(this.cmbLoai_SelectedValueChanged);
                cmbLoai_SelectedValueChanged(null, null);
            }

        }
        private async void cmbLoai_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string id = cmbLoai.SelectedValue.ToString();
                cashType = await _logic.GetDetailCashPayType(id);
                if (cashType != null)
                {
                    if (cashType.RequireBill == false)
                    {
                        txtSoChungTu.Text = string.Format("{0:yyMMddHHmmssfff}", DateTime.Now);
                        txtTenNguoiNopNhan.Focus();
                    }
                    else
                    {
                        txtSoChungTu.Focus();
                        txtSoChungTu.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu nhập
            if (String.IsNullOrEmpty(txtTenNguoiNopNhan.Text))
            {
                MessageBox.Show("Tên người nhận/nộp tiền không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNguoiNopNhan.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtValue.Text))
            {
                MessageBox.Show("Số tiền không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValue.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSoChungTu.Text))
            {
                MessageBox.Show("Số chứng từ không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoChungTu.Focus();
                return;
            }

            SoQuyChiTienLogicInputDto item = new SoQuyChiTienLogicInputDto();
            item.FK_ExtPost = PBean.USER.companyid;
            item.IsPay = IsPay;
            item.MaNguoiNopNhan = PBean.USER.FullName;
            item.TenNguoiNopNhan = txtTenNguoiNopNhan.Text;
            item.DiaChi = txtDiaChi.Text;
            item.SoDienThoai = txtSoDienThoai.Text;
            item.Value = Int32.Parse(txtValue.Text, System.Globalization.NumberStyles.AllowThousands);
            item.CreateBy = PBean.USER.Id;
            item.SoChungTu = txtSoChungTu.Text.Trim();
            item.Type = cmbLoai.SelectedValue.ToString();
            item.Note = txtNote.Text;
            item.IsDelete = false;
            // Kiểm tra có bị trùng mã chứng từ không?
            string result = await _logic.CheckDuplicate(item);
            if (!string.IsNullOrEmpty(result))
            {
                if (MessageBox.Show("Cảnh báo: " + result, PBean.MESSAGE_TITLE + " Bấm YES để tiếp tục thực hiện!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            if (IsPay)
            {
                string message = await _logic.CreateChiThongThuong(item, chbChuyenKhoan.Checked);
                if (string.IsNullOrEmpty(message) == false)
                {
                    MessageBox.Show(message, PBean.MESSAGE_TITLE);
                }
            }
            else
            {
                await _logic.CreateCash(item, chbChuyenKhoan.Checked);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void txtSoChungTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string mavandon = txtSoChungTu.Text.Trim();
                if (!string.IsNullOrEmpty(mavandon))
                {
                    // Tìm dữ liệu đơn hàng
                    ExpBILL bill = _logic.GetBillByCode(mavandon);
                    if (bill != null)
                    {
                        if (bill.PAY_TYPE == "Nhận thanh toán")
                        {
                            txtValue.Text = PCommon.FormatNumber(bill.GOODS_PAYMENT.ToString());
                        }
                        else
                        {
                            txtValue.Text = PCommon.FormatNumber((bill.GOODS_PAYMENT - bill.FREIGHT).ToString());
                        }
                        txtTenNguoiNopNhan.Text = bill.SEND_MAN;
                        txtSoDienThoai.Text = bill.SEND_MAN_PHONE;
                        txtDiaChi.Text = bill.SEND_MAN_ADDRESS;
                        lblBangChu.Text = "(Bằng chữ: " + PCommon.ChuyenSoThanhChu(txtValue.Text.Replace(",", "").Replace(".", "")) + ")";
                    }
                }

            }
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl == txtValue)
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
