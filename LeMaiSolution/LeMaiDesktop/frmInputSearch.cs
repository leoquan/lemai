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
    public partial class frmInputSearch : Form
    {
        public string lsMaVanDon = string.Empty;
        public frmInputSearch()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lsMaVanDon = string.Empty;
            foreach (string item in txtList.Lines)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    lsMaVanDon = lsMaVanDon + "'" + item + "',";
                }
            }
            lsMaVanDon = lsMaVanDon.TrimEnd(',');
            this.DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
