using Common;
using LeMaiLogic.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace LeMaiDesktop
{
    public partial class frmCreateSameOrder : frmBase
    {
        public bool UpdateSuccess = false;
        public string BillCode = string.Empty;
        private GExpBillLogic _logic = new GExpBillLogic(PBean.ConnectionBase);
        public frmCreateSameOrder() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            int soDon = 1;
            if (!Int32.TryParse(txtSoDon.Text, NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out soDon))
            {
                soDon = 1;
            }
            for (int i = 0; i < soDon; i++)
            {
                await _logic.CreateDuplicate(BillCode, PBean.USER.Id);
            }
            UpdateSuccess = true;
            this.DialogResult = DialogResult.OK;
        }

        private async void frmUpdateB3CodeManual_Load(object sender, EventArgs e)
        {
            var bill = await _logic.GetDetails(BillCode);
            if (bill == null)
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
                txtSoDienThoaiNguoiGui.Text = bill.SendManPhone;
                txtNguoiGui.Text = bill.SendMan;
                txtSoDienThoaiNguoiNhan.Text = bill.AcceptManPhone;
                txtNguoiNhan.Text = bill.AcceptMan;
                txtCuocPhiChinh.Text = PCommon.FormatNumber(bill.Freight.ToString());
                txtThuHo.Text = PCommon.FormatNumber(bill.COD.ToString());
            }
        }

        private void txtSoDon_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
    }
}
