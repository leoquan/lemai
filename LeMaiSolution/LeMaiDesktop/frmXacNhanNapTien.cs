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
    public partial class frmXacNhanNapTien : frmBase
    {
        QuanLyNapTienLogic _logic = new QuanLyNapTienLogic(PBean.ConnectionBase);
        public string RequestId { get; set; }
        public frmXacNhanNapTien() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
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
                // Xử lý logic nạp tiền ở đây
                view_GExpRequestMoney naptien = await _logic.GetDetails(RequestId);
                if (naptien != null && naptien.IsConfirm == false)
                {
                    string message = _logic.NapTien(naptien, PBean.USER, SoTien);
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
            view_GExpRequestMoney naptien = await _logic.GetDetails(RequestId);
            if (naptien != null && naptien.IsConfirm == false)
            {
                // Thông tin nạp tiền đến
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
