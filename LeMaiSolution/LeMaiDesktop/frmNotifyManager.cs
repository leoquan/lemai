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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LeMaiDesktop
{
    public partial class frmNotifyManager : frmBase
    {
        private GExpBillLogic _logic = new GExpBillLogic(PBean.ConnectionBase);
        public frmNotifyManager() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public async void LoadData(bool reload = false)
        {
            if (reload)
            {
                cmbKhachHangFilter.DataSource = _logic.GetCustomerListFilter(PBean.USER.CardId, txtKhachHangFilterDXL.Text.Trim());
                cmbKhachHangFilter.DisplayMember = "CustomerName";
                cmbKhachHangFilter.ValueMember = "Id";

                cmbKhachHangFilterDXL.DataSource = _logic.GetCustomerListFilter(PBean.USER.CardId, txtKhachHangFilterDXL.Text.Trim());
                cmbKhachHangFilterDXL.DisplayMember = "CustomerName";
                cmbKhachHangFilterDXL.ValueMember = "Id";

                var list = await _logic.GetDanhSachProvider(PBean.USER.CardId);
                GExpProvider all = new GExpProvider();
                all.Id = "9999";
                all.ProviderName = "Tất cả";
                var lsSource = new List<GExpProvider>();
                lsSource.Add(all);
                lsSource.AddRange(list);
                cmbLoaiKien.DataSource = lsSource;
                cmbLoaiKien.DisplayMember = "ProviderName";
                cmbLoaiKien.ValueMember = "Id";

            }
            gridChuaXuLy.DataSource = _logic.GetNotifyListUnProcess(PBean.USER.CardId, cmbLoaiKien.SelectedValue.ToString(), cmbKhachHangFilter.SelectedValue.ToString());
            dataGridDaXL.DataSource = _logic.GetNotifyListProcessed(PBean.USER.CardId, cmbKhachHangFilterDXL.SelectedValue.ToString(), dateFrom.Value, dateTo.Value);
        }
        private void frmNotifyManager_Load(object sender, EventArgs e)
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

        private void txtKhachHangFilterDXL_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                cmbKhachHangFilterDXL.DataSource = _logic.GetCustomerListFilter(PBean.USER.CardId, txtKhachHangFilterDXL.Text.Trim());
                cmbKhachHangFilterDXL.DisplayMember = "CustomerName";
                cmbKhachHangFilterDXL.ValueMember = "Id";
            }
        }

        private async void gridChuaXuLy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //
                int index = gridChuaXuLy.SelectedRows[0].Index;
                var item = await _logic.GetNotifyDetails(Convert.ToString(gridChuaXuLy.Rows[index].Cells["col_Id"].Value));
                if (null != item)
                {
                    frmViewNotify frm = new frmViewNotify();
                    frm.notify = item;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadData(false);
                    }
                }
            }
            catch
            {
            }
        }

        private async void dataGridDaXL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //
                int index = dataGridDaXL.SelectedRows[0].Index;
                var item = await _logic.GetNotifyDetails(Convert.ToString(dataGridDaXL.Rows[index].Cells["col_chuaId"].Value));
                if (null != item)
                {
                    frmViewNotify frm = new frmViewNotify();
                    frm.notify = item;
                    frm.ShowDialog();

                }
            }
            catch
            {
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadData(false);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            LoadData(false);
        }
    }
}
