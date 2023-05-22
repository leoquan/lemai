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
    public partial class frmViewNotify : frmBase
    {
        public view_GExpNotification notify = new view_GExpNotification();
        private GExpBillLogic _logic = new GExpBillLogic(PBean.ConnectionBase);
        public frmViewNotify() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }
        void LoadData()
        {
            ucBill.SetView(notify.BillCode);
            txtNgay.Text = string.Format("{0:dd/MM/yyyy HH:mm}", notify.CreateDate);
            txtNoiDung.Text = notify.Note;
            if (string.IsNullOrEmpty(notify.FK_AccountRead))
            {
                btnRead.Visible = true;
            }
            else
            {
                btnRead.Visible = false;
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            await _logic.UpdateNotify(notify.Id, PBean.USER.Id);
            this.DialogResult = DialogResult.OK;
        }

        private void frmViewNotify_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
