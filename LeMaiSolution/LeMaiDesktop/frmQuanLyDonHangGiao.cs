using Common;
using LeMaiDomain;
using LeMaiLogic.Logic;
using NPOI.HSSF.Record.Chart;
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
    public partial class frmQuanLyDonHangGiao : frmBase
    {
        public view_GExpShipperDevivery delivery = null;
        private GExpBillLogic _logic = new GExpBillLogic(PBean.ConnectionBase);
        private GExpScanLogic _logicScan = new GExpScanLogic(PBean.ConnectionBase);
        public frmQuanLyDonHangGiao() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }

        private void frmQuanLyDonHangGiao_Load(object sender, EventArgs e)
        {
            LoadData(true);
        }
        private async void LoadData(bool init)
        {
            if (init)
            {
                // Load Combobox
                cmbNV.DataSource = await _logicScan.GetListShipperAll(PBean.USER.CardId, string.Empty);
                cmbNV.DisplayMember = "ShipperName";
                cmbNV.ValueMember = "Id";
            }
            // Load grid select from view
            gridBills.AutoGenerateColumns = false;
            var list = await _logicScan.GetShipperDelivery(PBean.USER.CardId, cmbNV.SelectedValue.ToString());
            gridBills.DataSource = list;

        }
        private void btnTruyVan_Click(object sender, EventArgs e)
        {
            LoadData(false);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridBills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = gridBills.SelectedRows[0].Index;
                string Id = Convert.ToString(gridBills.Rows[index].Cells["col_Id"].Value);
                delivery = _logicScan.GetShipperDelivery(Id);
                if (delivery != null)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
            }

        }
    }
}
