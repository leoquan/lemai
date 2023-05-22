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
    public partial class frmUpdateB3CodeManual : frmBase
    {
        public string BillCodeBT3 { get; set; }
        public bool ChangeSuccess { get; set; } = false;
        public frmUpdateB3CodeManual() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            ChangeSuccess = true;
            BillCodeBT3 = txtBT3Code.Text.Trim();
            this.DialogResult = DialogResult.OK;

        }

        private void txtBT3Code_TextChanged(object sender, EventArgs e)
        {
        }

        private void frmUpdateB3CodeManual_Load(object sender, EventArgs e)
        {
            
            txtBT3Code.Text = BillCodeBT3;
            txtBT3Code.Focus();
        }
    }
}
