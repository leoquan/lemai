using Common;
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
    public partial class frmQuanLyCongNoCap1 : frmBase
    {
        QuanLyNapTienLogic _logic = new QuanLyNapTienLogic(PBean.ConnectionBase);
        public frmQuanLyCongNoCap1() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }

        private void btnXemChiTietCongNo_Click(object sender, EventArgs e)
        {
            frmQuanLyKetToanBuuCuc frm = new frmQuanLyKetToanBuuCuc();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAddRequest_Click(object sender, EventArgs e)
        {
            // Tạo lệnh nạp tiền
            try
            {
                int index = gridMain.SelectedRows[0].Index;
                string post = Convert.ToString(gridMain.Rows[index].Cells["col_idqltc"].Value);
                bool isNapTien = Convert.ToBoolean(gridMain.Rows[index].Cells["col_IsNapTien"].Value);
                if(isNapTien)
                {
                    frmNewRequestMoney frm = new frmNewRequestMoney();
                    frm.FK_PostTo = post;
                    frm.ShowDialog();
                }               
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private void frmQuanLyCongNoCap1_Load(object sender, EventArgs e)
        {
            gridMain.DataSource = _logic.GetDebit(PBean.USER.CardId);
            FormatRowCash();
            gridMain.ClearSelection();
        }
        private void FormatRowCash()
        {
            for (int i = 0; i < gridMain.Rows.Count; i++)
            {
                if (gridMain.Rows[i].Cells["col_IsNapTien"].Value.ToString() == "True")
                {
                    gridMain.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void gridMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddRequest_Click(null, null);
        }
    }
}
