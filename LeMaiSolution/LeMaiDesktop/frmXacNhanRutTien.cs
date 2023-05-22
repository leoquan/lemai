using Common;
using GmailAPI.APIHelper;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using LeMaiDomain;
using LeMaiLogic.Logic;
using NUglify;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace LeMaiDesktop
{
    public partial class frmXacNhanRutTien : frmBase
    {
        QuanLyRutTienLogic _logic = new QuanLyRutTienLogic(PBean.ConnectionBase);
        GExpBillLogic _logicbill = new GExpBillLogic(PBean.ConnectionBase);
        public string RequestId { get; set; }
        public frmXacNhanRutTien() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnXacNhan_Click(object sender, EventArgs e)
        {
            int SoTien = 0;
            if (Int32.TryParse(txtMoney.Text, System.Globalization.NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out SoTien))
            {
                // Xử lý logic rút tiền ở đây
                view_GExpWithdrawMoney ruttien = await _logic.GetDetails(RequestId);
                if (ruttien != null && ruttien.IsConfirm == false)
                {
                    string message = _logic.RutTien(ruttien, PBean.USER, SoTien);
                    if (string.IsNullOrEmpty(message))
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show(message, PBean.MESSAGE_TITLE);
                    }
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private async void frmNewRequestMoney_Load(object sender, EventArgs e)
        {
            view_GExpWithdrawMoney naptien = await _logic.GetDetails(RequestId);
            if (naptien != null && naptien.IsConfirm == false)
            {
                // Thông tin nạp tiền đến
                ExpPost post = _logicbill.GetPostDetail(naptien.FK_Post);
                lblSoDuHienTai.Text = post.ValueBlance.ToString("N0") + " VNĐ";

                lblSoTK.Text = naptien.BankAccount;
                lblChuTaiKhoan.Text = naptien.BankOwner;
                lblNganHang.Text = naptien.BankName;
                lblSoTienCanNap.Text = naptien.SoTien.ToString("N0") + " VNĐ";
                lblTenDaiLy.Text = naptien.DaiLyYeuCau;
                txtRequestCode.Text = naptien.RequestCode;
                txtMoney.Text = naptien.SoTien.ToString("N0");
                lblBangChu.Text = PCommon.ChuyenSoThanhChu(naptien.SoTien.ToString());
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }

        private void txtMoney_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                if (!string.IsNullOrEmpty(txtMoney.Text))
                {
                    lblBangChu.Text = PCommon.ChuyenSoThanhChu(txtMoney.Text.Replace(",", ""));
                }
            }
        }
    }
}
