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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LeMaiDesktop
{
    public partial class frmOrderCustomer : frmBase
    {
        private GExpBillLogic _logic = new GExpBillLogic(PBean.ConnectionBase);
        public ExpCustomer CustomerSelected { get; set; }
        public GExpOrder OrderSelected { get; set; }
        public frmOrderCustomer() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            dateFrom.Value = DateTime.Now.AddDays(-7);
        }

        private void gridMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Chọn
            try
            {
                int index = gridMain.SelectedRows[0].Index;
                string id = Convert.ToString(gridMain.Rows[index].Cells["col_Id"].Value);
                ExpCustomer customer;
                OrderSelected = _logic.GetOrderDetailWithCustomer(id, out customer);
                if (OrderSelected != null)
                {
                    CustomerSelected = customer;
                    this.DialogResult = DialogResult.OK;
                }

            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }

        }
        void Format()
        {
            for (int i = 0; i < gridMain.Rows.Count; i++)
            {
                if (gridMain.Rows[i].Cells["col_StatusOrder"].Value.ToString() == "1")
                {
                    gridMain.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Truy vấn
            LoadData(false);
        }
        private async void LoadData(bool reload)
        {
            if (reload)
            {
                cmbKhachHangFilter.DataSource = _logic.GetCustomerListFilter(PBean.USER.CardId, txtKhachHangFilter.Text.Trim());
                cmbKhachHangFilter.DisplayMember = "CustomerName";
                cmbKhachHangFilter.ValueMember = "Id";
            }
            var result = await _logic.GetOrderList(string.Empty, PBean.USER.CardId, cmbKhachHangFilter.SelectedValue.ToString(), dateFrom.Value, dateTo.Value);
            gridMain.AutoGenerateColumns = false;
            gridMain.DataSource = result;
            gridMain.ClearSelection();
            lblWaitCount.Text = result.Count.ToString();
            Format();
        }
        private void frmOrderCustomer_Load(object sender, EventArgs e)
        {
            LoadData(true);
        }

        private void txtKhachHangFilter_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                cmbKhachHangFilter.DataSource = _logic.GetCustomerListFilter(PBean.USER.CardId, txtKhachHangFilter.Text.Trim());
                cmbKhachHangFilter.DisplayMember = "CustomerName";
                cmbKhachHangFilter.ValueMember = "Id";
            }
        }
    }
}
