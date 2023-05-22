using Common;
using System;

namespace LeMaiDesktop
{
    public partial class frmSuperAdmin : frmBase
    {
        public frmSuperAdmin()
        {
            InitializeComponent();
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            if (txtKey.Text == "1@qweQAZ")
            {
                btnParrent.Enabled = true;
                btnSubParrent.Enabled = true;
                btnMenuFunc.Enabled = true;
                btnPermission.Enabled = true;
                btnRole.Enabled = true;
                btnAccount.Enabled = true;
                txtKey.Clear();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnParrent_Click(object sender, EventArgs e)
        {
            frmMenuFuntionGroup frm = new frmMenuFuntionGroup(true);
            frm.ShowDialog();
        }

        private void btnSubParrent_Click(object sender, EventArgs e)
        {
            frmMenuFuntionGroup frm = new frmMenuFuntionGroup(false);
            frm.ShowDialog();
        }

        private void btnMenuFunc_Click(object sender, EventArgs e)
        {
            frmMenuFunction frm = new frmMenuFunction();
            frm.ShowDialog();
        }

        private void btnPermission_Click(object sender, EventArgs e)
        {
            frmGrantPermission frm = new frmGrantPermission();
            frm.ShowDialog();
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            frmMenuRole frm = new frmMenuRole();
            frm.ShowDialog();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            frmAccountObject frm = new frmAccountObject();
            frm.ShowDialog();
        }

        private void txtKey_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            btnUnlock_Click(null, null);
        }
    }
}
