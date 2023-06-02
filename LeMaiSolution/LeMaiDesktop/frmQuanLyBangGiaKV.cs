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
    public partial class frmQuanLyBangGiaKV : frmBase
    {
        private QuanLyBangGiaLogic _logic = new QuanLyBangGiaLogic(PBean.ConnectionBase);
        private GExpBillLogic _logicbill = new GExpBillLogic(PBean.ConnectionBase);
        private List<GExpFeeProvinceDetail> listFee = new List<GExpFeeProvinceDetail>();
        public string FeeId { get; set; }
        public int ProvineId { get; set; }
        public string FeeName { get; set; }
        public frmQuanLyBangGiaKV() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
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
            txtFeeName.Text = FeeName;
            // Set datagrid
            listFee = await _logic.GetListFeeProvince(FeeId);
            if (listFee.Count > 0)
            {
                cmbTinh.SelectedValue = listFee[0].ProvineId;
                dataQuanHuyen.DataSource = await _logicbill.GetDanhSachHuyen(cmbTinh.SelectedValue.ToString());
                var district = listFee[0].District.Split(';').ToList();
                foreach (DataGridViewRow row in dataQuanHuyen.Rows)
                {
                    string a = Convert.ToString(row.Cells["col_Id"].Value);
                    if (district.Exists(u => u == a))
                    {
                        row.Cells["col_Select"].Value = true;
                    }
                }
                gridChild.AutoGenerateColumns = false;
                gridChild.DataSource = listFee.ToList();

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
        void LoadChild()
        {
            gridChild.AutoGenerateColumns = false;
            gridChild.DataSource = listFee.ToList();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMinWeight.Text))
            {
                MessageBox.Show("Trọng lượng đầu không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMinWeight.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtMinFee.Text))
            {
                MessageBox.Show("Giá cân đầu không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMinFee.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtStepWeight.Text))
            {
                MessageBox.Show("Nấc không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStepWeight.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtNextFee.Text))
            {
                MessageBox.Show("Giá nấc không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNextFee.Focus();
                return;
            }
            GExpFeeProvinceDetail fee = new GExpFeeProvinceDetail();
            fee.Id = Guid.NewGuid().ToString();
            fee.FK_GExpFee = FeeId;
            fee.MinWeight = Int32.Parse(txtMinWeight.Text, System.Globalization.NumberStyles.AllowThousands);
            fee.MinFee = Int32.Parse(txtMinFee.Text, System.Globalization.NumberStyles.AllowThousands);
            fee.StepWeight = Int32.Parse(txtStepWeight.Text, System.Globalization.NumberStyles.AllowThousands);
            fee.NextFee = Int32.Parse(txtNextFee.Text, System.Globalization.NumberStyles.AllowThousands);
            listFee.Add(fee);
            LoadChild();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gridChild.SelectedRows[0].Index;
                string Id = Convert.ToString(gridChild.Rows[index].Cells["col_SubId"].Value);
                var del = listFee.FirstOrDefault(u => u.Id == Id);
                if (del != null)
                {
                    listFee.Remove(del);
                }
            }
            catch
            {
            }

            LoadChild();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Save bảng giá
            try
            {
                string district = GetDistrictId();
                if (string.IsNullOrEmpty(district))
                {
                    MessageBox.Show("Chưa chọn Quận/Huyện áp dụng giá", PBean.MESSAGE_TITLE);
                    return;
                }
                int ProvinceId = Int32.Parse(cmbTinh.SelectedValue.ToString());
                await _logic.AddFeeProvineDetail(listFee, FeeId, ProvinceId, district);
                this.DialogResult = DialogResult.OK;
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
            }

        }

        private void txtMinWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }

        private void txtMinFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }

        private void txtStepWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }

        private void txtNextFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }

        private void txtMinWeight_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }

        private void txtMinFee_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }

        private void txtStepWeight_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }

        private void txtNextFee_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
    }
}
