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
    public partial class frmQuanLyVungPhat : frmBase
    {
        private QuanLyBangGiaLogic _logic = new QuanLyBangGiaLogic(PBean.ConnectionBase);
        private GExpBillLogic _logicbill = new GExpBillLogic(PBean.ConnectionBase);
        public string provinceId { get; set; }
        public string DistrictIds { get; set; }
        public frmQuanLyVungPhat() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }

        private void frmQuanLyBangGiaKV_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private async void LoadData()
        {
            cmbTinh.DataSource = await _logicbill.GetDanhSachTinh();
            cmbTinh.DisplayMember = "ProvinceName";
            cmbTinh.ValueMember = "ProvinceID";
            // Load Huyện
            dataQuanHuyen.AutoGenerateColumns = false;
            if (string.IsNullOrEmpty(provinceId) == false)
            {
                string[] spro = provinceId.Split(';');
                cmbTinh.SelectedValue = Int32.Parse(spro[0]);
                dataQuanHuyen.DataSource = await _logicbill.GetDanhSachHuyen(cmbTinh.SelectedValue.ToString());
                var district = DistrictIds.Split(';').ToList();
                foreach (DataGridViewRow row in dataQuanHuyen.Rows)
                {
                    string a = Convert.ToString(row.Cells["col_Id"].Value);
                    if (district.Exists(u => u == a))
                    {
                        row.Cells["col_Select"].Value = true;
                    }
                }
            }
            else
            {
                dataQuanHuyen.DataSource = await _logicbill.GetDanhSachHuyen(cmbTinh.SelectedValue.ToString());
            }

        }
        private string GetDistrictId()
        {
            string id = string.Empty;
            foreach (DataGridViewRow row in dataQuanHuyen.Rows)
            {
                if (Convert.ToBoolean(row.Cells["col_Select"].Value) == true)
                {
                    string a = Convert.ToString(row.Cells["col_Id"].Value);
                    id += a + ";";
                }
            }
            return id.TrimEnd(';');
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DistrictIds = DistrictIds.TrimEnd(',');
                provinceId = provinceId.TrimEnd(',');
                if (!string.IsNullOrEmpty(provinceId) && !string.IsNullOrEmpty(DistrictIds))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Chưa chọn vùng phát", PBean.MESSAGE_TITLE);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
            }
        }

        private async void cmbTinh_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                dataQuanHuyen.AutoGenerateColumns = false;
                dataQuanHuyen.DataSource = await _logicbill.GetDanhSachHuyen(cmbTinh.SelectedValue.ToString());
                // Load huyện 
                string tempHuyen = GetDistrictId();
                if (!string.IsNullOrEmpty(tempHuyen))
                {
                    DistrictIds = DistrictIds + tempHuyen + ";";
                    provinceId = provinceId + cmbTinh.SelectedValue.ToString() + ";";
                }
            }
        }

        private void btnChuyenTinh_Click(object sender, EventArgs e)
        {
            // Chuyển tỉnh gộp
            DistrictIds = string.Empty;
            provinceId = string.Empty;
        }
    }
}
