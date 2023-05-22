using Common;
using LeMaiDomain;
using LeMaiLogic.Logic;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace LeMaiDesktop
{
    public partial class frmNewWithdrawMoney : frmBase
    {
        QuanLyRutTienLogic _logic = new QuanLyRutTienLogic(PBean.ConnectionBase);
        GExpBillLogic _logicbill = new GExpBillLogic(PBean.ConnectionBase);
        public string FK_PostTo { get; set; }
        public frmNewWithdrawMoney() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            int SoTien = 0;
            if (Int32.TryParse(txtMoney.Text, System.Globalization.NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out SoTien))
            {
                string note = PBean.USER.FullName + " đã tạo yêu cầu rút tiền với mã giao dịch:{0}. Số tiền {1}";

                ExpPost postFrom = _logicbill.GetPostDetail(PBean.USER.CardId);
                var result = _logic.AddRequestMoney(postFrom.Id, FK_PostTo, PBean.USER.Id, SoTien, note, postFrom.SoTaiKhoan, postFrom.QuanLy, postFrom.NganHang);
                if (!result.Contains("[E]"))
                {
                    Clipboard.SetText(result);
                    txtRequestCode.Text = result;
                    MessageBox.Show("Đã thêm yêu cầu rút tiền thành công, mã giao dịch [" + result + "]", PBean.MESSAGE_TITLE);
                }
                else
                {
                    MessageBox.Show(result, PBean.MESSAGE_TITLE);
                }
            }

        }

        private void frmNewRequestMoney_Load(object sender, EventArgs e)
        {
            ExpPost postFrom = _logicbill.GetPostDetail(PBean.USER.CardId);
            lblTotal.Text = PCommon.FormatNumber(postFrom.ValueBlance.ToString()) + " VNĐ";
            lblSoTK.Text = postFrom.SoTaiKhoan;
            lblChuTaiKhoan.Text = postFrom.QuanLy;
            lblNganHang.Text = postFrom.NganHang;
            if (postFrom.ValueBlance <= 0)
            {
                txtMoney.Text = "0";
                lblBangChu.Text = "Số dư không đủ để rút tiền!";
                btnAddRequest.Enabled = false;
            }
            else
            {
                int value = Math.Abs(postFrom.ValueBlance);
                txtMoney.Text = PCommon.FormatNumber(value.ToString());
                lblBangChu.Text = PCommon.ChuyenSoThanhChu(value.ToString());
                btnAddRequest.Enabled = true;
            }
        }

        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }

        private void txtMoney_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender,e);
        }
    }
}
