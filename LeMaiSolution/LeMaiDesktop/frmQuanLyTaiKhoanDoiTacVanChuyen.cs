using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Linq;
using Common;
using LeMaiDomain;
using LeMaiDomain.Models;
using LeMaiLogic;
using LeMaiLogic.Logic;

namespace LeMaiDesktop
{
    public partial class frmQuanLyTaiKhoanDoiTacVanChuyen : frmBase
    {
        private QuanLyTaiKhoanDoiTacVanChuyenLogic _logic = new QuanLyTaiKhoanDoiTacVanChuyenLogic(PBean.ConnectionBase);
        private GExpBillLogic _logicBill = new GExpBillLogic(PBean.ConnectionBase);
        private enumAction status = enumAction.NONE;
        private view_GExpProvider Gitem;

        public frmQuanLyTaiKhoanDoiTacVanChuyen() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            gridMain.AutoGenerateColumns = false;
            this.gridMain.RowTemplate.MinimumHeight = 22;
            Separator();
        }

        private void frmQuanLyTaiKhoanDoiTacVanChuyen_Load(object sender, EventArgs e)
        {
            LoadData(true);
            EnableButton(status);
            ChangeLanguageUI(PBean.MAKE_LANG);

        }

        #region Xử lý phím tắt

        // Xử lý phím tắt trên form
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.F4))
            {
                if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                return true;
            }
            if (keyData == (Keys.Control | Keys.Q))
            {
                btnClose_Click(null, null);
                return true;
            }
            if (keyData == (Keys.Control | Keys.S))
            {
                btnSave_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Enable hoặc Disable các button chức năng Trạng thái đang hoạt động 0: Không làm gì cả, 1: Thêm mới, 2: Sửa
        private void EnableButton(enumAction stus)
        {
            //Enable tất cả các button
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            if (stus == enumAction.NONE)
            {
                btnSave.Enabled = false;
                btnNew.Text = "&Mới";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iNew;
                txtProviderName.Enabled = false;
                txtToken.Enabled = false;
                txtUserApi.Enabled = false;
                txtPassApi.Enabled = false;
                txtShopId.Enabled = false;
                txtClientId.Enabled = false;
                txtAddress.Enabled = false;
                txtEmail.Enabled = false;
                txtShopName.Enabled = false;
                txtShopPhone.Enabled = false;
                cmbProviderTypeCode.Enabled = false;
                chbAutoSelect.Enabled = false;
                txtInitWeightSelect.Enabled = false;
                txtInitWeightSelectMax.Enabled = false;
                txtSelectIndex.Enabled = false;
                cmbWardCode.Enabled = false;
                cmbDistrictCode.Enabled = false;
                cmbProvinceCode.Enabled = false;
                txtServiceId.Enabled = false;
                txtPostBT3Id.Enabled = false;
                cmbGroupProvider.Enabled = false;
                txtInsuranceValue.Enabled = false;
                txtClientSecrect.Enabled = false;
                txtPrintLable.Enabled = false;
                txtDeliveryInitPrice.Enabled = false;
                txtDeliveryInitWeight.Enabled = false;
                txtDeliveryStepWeight.Enabled = false;
                txtDeliveryStepPrice.Enabled = false;
                chbManualSign.Enabled = false;
                chbIsPickup.Enabled = false;
                cmbRunMode.Enabled = false;
                txtLinkCustomerLogin.Enabled = false;
            }
            if (stus == enumAction.NEW)
            {
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                txtProviderName.Enabled = true;
                txtToken.Enabled = true;
                txtUserApi.Enabled = true;
                txtPassApi.Enabled = true;
                txtShopId.Enabled = true;
                txtClientId.Enabled = true;
                txtAddress.Enabled = true;
                txtEmail.Enabled = true;
                txtShopName.Enabled = true;
                txtShopPhone.Enabled = true;
                cmbProviderTypeCode.Enabled = true;
                chbAutoSelect.Enabled = true;
                txtInitWeightSelect.Enabled = true;
                txtInitWeightSelectMax.Enabled = true;
                txtSelectIndex.Enabled = true;
                cmbWardCode.Enabled = true;
                cmbDistrictCode.Enabled = true;
                cmbProvinceCode.Enabled = true;
                txtServiceId.Enabled = true;
                txtPostBT3Id.Enabled = true;
                cmbGroupProvider.Enabled = true;
                txtInsuranceValue.Enabled = true;
                txtClientSecrect.Enabled = true;
                txtPrintLable.Enabled = true;
                txtDeliveryInitPrice.Enabled = true;
                txtDeliveryInitWeight.Enabled = true;
                txtDeliveryStepWeight.Enabled = true;
                txtDeliveryStepPrice.Enabled = true;
                cmbRunMode.Enabled = true;
                chbManualSign.Enabled = true;
                chbIsPickup.Enabled = true;
                txtLinkCustomerLogin.Enabled = true;
            }
            if (stus == enumAction.UPDATE)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                txtProviderName.Enabled = true;
                txtToken.Enabled = true;
                txtUserApi.Enabled = true;
                txtPassApi.Enabled = true;
                txtShopId.Enabled = true;
                txtClientId.Enabled = true;
                txtAddress.Enabled = true;
                txtEmail.Enabled = true;
                txtShopName.Enabled = true;
                txtShopPhone.Enabled = true;
                cmbProviderTypeCode.Enabled = true;
                chbAutoSelect.Enabled = true;
                txtInitWeightSelect.Enabled = true;
                txtInitWeightSelectMax.Enabled = true;
                txtSelectIndex.Enabled = true;
                cmbWardCode.Enabled = true;
                cmbDistrictCode.Enabled = true;
                cmbProvinceCode.Enabled = true;
                txtServiceId.Enabled = true;
                txtPostBT3Id.Enabled = true;
                cmbGroupProvider.Enabled = true;
                txtInsuranceValue.Enabled = true;
                txtClientSecrect.Enabled = true;
                txtPrintLable.Enabled = true;
                txtDeliveryInitPrice.Enabled = true;
                txtDeliveryInitWeight.Enabled = true;
                txtDeliveryStepWeight.Enabled = true;
                txtDeliveryStepPrice.Enabled = true;
                chbManualSign.Enabled = true;
                cmbRunMode.Enabled = true;
                chbIsPickup.Enabled = true;
                txtLinkCustomerLogin.Enabled = true;
            }
        }
        // Xóa trắng tất cả các textbox.
        private void ClearText()
        {
            txtProviderName.Text = string.Empty;
            txtToken.Text = string.Empty;
            txtUserApi.Text = string.Empty;
            txtPassApi.Text = string.Empty;
            txtShopId.Text = string.Empty;
            txtClientId.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtShopName.Text = string.Empty;
            txtShopPhone.Text = string.Empty;
            txtInitWeightSelect.Text = string.Empty;
            txtInitWeightSelectMax.Text = string.Empty;
            txtSelectIndex.Text = string.Empty;
            txtServiceId.Text = string.Empty;
            txtPostBT3Id.Text = string.Empty;
            txtInsuranceValue.Text = string.Empty;
            txtClientSecrect.Text = string.Empty;
            txtPrintLable.Text = string.Empty;
            txtDeliveryInitPrice.Text = string.Empty;
            txtDeliveryInitWeight.Text = string.Empty;
            txtDeliveryStepWeight.Text = string.Empty;
            txtDeliveryStepPrice.Text = string.Empty;
            txtLinkCustomerLogin.Text = string.Empty;
            txtProviderName.Focus();
        }

        // Fill dữ liệu vào các control.
        private async void FillData(view_GExpProvider item, bool copy)
        {
            if (!copy)
            {
            }
            txtProviderName.Text = item.ProviderName;
            txtToken.Text = item.Token;
            txtUserApi.Text = item.UserApi;
            txtPassApi.Text = item.PassApi;
            txtShopId.Text = item.ShopId;
            txtClientId.Text = item.ClientId;
            txtAddress.Text = item.Address;
            txtEmail.Text = item.Email;
            txtShopName.Text = item.ShopName;
            txtShopPhone.Text = item.ShopPhone;
            cmbProviderTypeCode.SelectedValue = item.ProviderTypeCode;
            chbAutoSelect.Checked = item.AutoSelect;
            txtInitWeightSelect.Text = item.InitWeightSelect.ToString();
            txtInitWeightSelectMax.Text = item.InitWeightSelectMax.ToString();
            txtSelectIndex.Text = item.SelectIndex.ToString();
            if (item.WardCode != null)
            {
                cmbWardCode.SelectedValue = item.WardCode;
            }
            if (item.DistrictCode != null)
            {
                cmbDistrictCode.SelectedValue = item.DistrictCode;
            }
            if (item.ProvinceCode != null)
            {
                cmbProvinceCode.SelectedValue = item.ProvinceCode;
            }
            txtServiceId.Text = item.ServiceId;
            txtPostBT3Id.Text = item.PostBT3Id;
            cmbRunMode.SelectedIndex = item.RunMode;
            cmbGroupProvider.SelectedValue = item.GroupProvider;
            txtInsuranceValue.Text = item.InsuranceValue.ToString();
            txtClientSecrect.Text = item.ClientSecrect;
            txtPrintLable.Text = item.PrintLable;
            txtDeliveryInitPrice.Text = item.DeliveryInitPrice.ToString();
            txtDeliveryInitWeight.Text = item.DeliveryInitWeight.ToString();
            txtDeliveryStepWeight.Text = item.DeliveryStepWeight.ToString();
            txtDeliveryStepPrice.Text = item.DeliveryStepPrice.ToString();
            chbManualSign.Checked = item.ManualSign;
            chbIsPickup.Checked = item.IsPickup;
            txtLinkCustomerLogin.Text = item.LinkCustomerLogin;

            // Load Address Nhận
            cmbProvinceCode.DataSource = await _logicBill.GetDanhSachTinh();
            cmbProvinceCode.DisplayMember = "ProvinceName";
            cmbProvinceCode.ValueMember = "ProvinceID";
            cmbProvinceCode.SelectedValue = Int32.Parse(item.ProvinceCode);

            cmbDistrictCode.DataSource = await _logicBill.GetDanhSachHuyen(item.ProvinceCode);
            cmbDistrictCode.DisplayMember = "DistrictName";
            cmbDistrictCode.ValueMember = "DistrictID";
            cmbDistrictCode.SelectedValue = Int32.Parse(item.DistrictCode);

            cmbWardCode.DataSource = await _logicBill.GetDanhSachXa(item.DistrictCode);
            cmbWardCode.DisplayMember = "WardName";
            cmbWardCode.ValueMember = "WardId";
            cmbWardCode.SelectedValue = item.WardCode;
        }

        #region Xử lý TextBox tìm kiếm dữ liệu trên form
        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var result = await _logic.GetList(txtSearch.Text, PBean.USER.CardId);
            gridMain.DataSource = result;
        }
        #endregion

        #endregion

        #region Xử lý sự kiện cho các button - GridControl
        private void txtProviderName_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtToken_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtUserApi_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtPassApi_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtShopId_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtClientId_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtShopName_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtShopPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtInitWeightSelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtInitWeightSelect_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtInitWeightSelectMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtInitWeightSelectMax_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtSelectIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSelectIndex_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtInitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtInitPrice_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtInitWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtInitWeight_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtStepWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtStepWeight_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtStepPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtStepPrice_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtWardName_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtDistrictName_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtProvinceName_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtServiceId_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtPostBT3Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtRunMode_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtRunMode_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtInsuranceValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtInsuranceValue_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtClientSecrect_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtPrintLable_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtDeliveryInitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtDeliveryInitPrice_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtDeliveryInitWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtDeliveryInitWeight_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtDeliveryStepWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtDeliveryStepWeight_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtDeliveryStepPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtDeliveryStepPrice_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtSysInitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSysInitPrice_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtSysInitWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSysInitWeight_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtSysStepWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSysStepWeight_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtSysStepPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSysStepPrice_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtTranInitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtTranInitPrice_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtTranInitWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtTranInitWeight_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtTranStepWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtTranStepWeight_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtTranStepPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtTranStepPrice_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtLinkCustomerLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }

        // Load data từ database lên lưới
        private async void LoadData(bool reload = false)
        {
            var result = await _logic.GetList(string.Empty, PBean.USER.CardId);
            gridMain.DataSource = result;
            if (reload)
            {
                // GExpProviderType
                cmbProviderTypeCode.DataSource = await _logic.GetMasterProviderTypeCodeList();
                cmbProviderTypeCode.DisplayMember = "ProviderName";
                cmbProviderTypeCode.ValueMember = "Id";
                // Group
                cmbGroupProvider.DataSource = await _logic.GetMasterGroupProviderList();
                cmbGroupProvider.DisplayMember = "ProviderName";
                cmbGroupProvider.ValueMember = "Id";


                // GExpProvince
                cmbProvinceCode.DataSource = await _logicBill.GetDanhSachTinh();
                cmbProvinceCode.DisplayMember = "ProvinceName";
                cmbProvinceCode.ValueMember = "ProvinceID";

                // GExpDistrict
                cmbDistrictCode.DataSource = await _logicBill.GetDanhSachHuyen(cmbProvinceCode.SelectedValue.ToString());
                cmbDistrictCode.DisplayMember = "DistrictName";
                cmbDistrictCode.ValueMember = "DistrictID";

                // GExpWard
                cmbWardCode.DataSource = await _logicBill.GetDanhSachXa(cmbDistrictCode.SelectedValue.ToString());
                cmbWardCode.DisplayMember = "WardName";
                cmbWardCode.ValueMember = "WardId";
            }
        }

        private async void gridMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (status != enumAction.NEW)
            {
                btnEdit_Click(null, null);
            }
            else
            {
                try
                {
                    int index = gridMain.SelectedRows[0].Index;
                    Gitem = await _logic.GetDetails(Convert.ToString(gridMain.Rows[index].Cells["col_Id"].Value));
                    if (null != Gitem)
                    {
                        FillData(Gitem, true);
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    return;
                }
            }
        }
        //Thêm mới
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (status != enumAction.NONE)
            {
                status = enumAction.NONE;
                EnableButton(status);
            }
            else
            {
                status = enumAction.NEW;
                EnableButton(status);
                ClearText();
            }
        }

        //Chỉnh sửa
        private async void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                int index = gridMain.SelectedRows[0].Index;
                Gitem = await _logic.GetDetails(Convert.ToString(gridMain.Rows[index].Cells["col_Id"].Value));
                if (null != Gitem)
                {
                    FillData(Gitem, false);
                    status = enumAction.UPDATE;
                    EnableButton(status);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }
        //Lưu
        private async void btnSave_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu nhập
            if (String.IsNullOrEmpty(txtProviderName.Text))
            {
                MessageBox.Show("Tên đối tác không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProviderName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtToken.Text))
            {
                MessageBox.Show("Token không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtToken.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtUserApi.Text))
            {
                MessageBox.Show("User Api không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserApi.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtPassApi.Text))
            {
                MessageBox.Show("Pass Api không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassApi.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtShopId.Text))
            {
                MessageBox.Show("Shop Id không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShopId.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtClientId.Text))
            {
                MessageBox.Show("Client Id không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClientId.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Địa chỉ không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtShopName.Text))
            {
                MessageBox.Show("Tên shop không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShopName.Focus();
                return;
            }
            if (cmbProviderTypeCode.SelectedValue == null)
            {
                MessageBox.Show("Loại tài khoản không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProviderTypeCode.Focus();
                return;
            }
            if (cmbGroupProvider.SelectedValue == null)
            {
                MessageBox.Show("Nhóm tài khoản không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGroupProvider.Focus();
                return;
            }

            QuanLyTaiKhoanDoiTacVanChuyenLogicInputDto item = new QuanLyTaiKhoanDoiTacVanChuyenLogicInputDto();
            item.ProviderName = txtProviderName.Text;
            item.Token = txtToken.Text;
            item.UserApi = txtUserApi.Text;
            item.PassApi = txtPassApi.Text;
            item.ShopId = txtShopId.Text;
            item.ClientId = txtClientId.Text;
            item.Post = PBean.USER.CardId;
            item.Address = txtAddress.Text;
            item.Email = txtEmail.Text;
            item.ShopName = txtShopName.Text;
            item.ShopPhone = txtShopPhone.Text;
            item.ProviderTypeCode = cmbProviderTypeCode.SelectedValue.ToString();
            item.IsDelete = false;
            item.AutoSelect = chbAutoSelect.Checked;
            item.InitWeightSelect = Int32.Parse(txtInitWeightSelect.Text == string.Empty ? "0" : txtInitWeightSelect.Text, System.Globalization.NumberStyles.AllowThousands);
            item.InitWeightSelectMax = Int32.Parse(txtInitWeightSelectMax.Text == string.Empty ? "0" : txtInitWeightSelectMax.Text, System.Globalization.NumberStyles.AllowThousands);
            item.SelectIndex = Int32.Parse(txtSelectIndex.Text == string.Empty ? "0" : txtSelectIndex.Text, System.Globalization.NumberStyles.AllowThousands);
            item.InitPrice = 0;
            item.InitWeight = 0;
            item.StepWeight = 0;
            item.StepPrice = 0;
            item.WardCode = cmbWardCode.SelectedValue.ToString();
            item.DistrictCode = cmbDistrictCode.SelectedValue.ToString();
            item.ProvinceCode = cmbProvinceCode.SelectedValue.ToString();
            item.WardName = cmbWardCode.Text;
            item.DistrictName = cmbDistrictCode.Text;
            item.ProvinceName = cmbProvinceCode.Text;
            item.ServiceId = txtServiceId.Text;
            item.PostBT3Id = txtPostBT3Id.Text;
            item.RunMode = cmbRunMode.SelectedIndex;
            item.GroupProvider = cmbGroupProvider.SelectedValue.ToString();
            item.InsuranceValue = Int32.Parse(txtInsuranceValue.Text == string.Empty ? "0" : txtInsuranceValue.Text, System.Globalization.NumberStyles.AllowThousands);
            item.ClientSecrect = txtClientSecrect.Text;
            item.PrintLable = txtPrintLable.Text;
            item.DeliveryInitPrice = Int32.Parse(txtDeliveryInitPrice.Text == string.Empty ? "0" : txtDeliveryInitPrice.Text, System.Globalization.NumberStyles.AllowThousands);
            item.DeliveryInitWeight = Int32.Parse(txtDeliveryInitWeight.Text == string.Empty ? "0" : txtDeliveryInitWeight.Text, System.Globalization.NumberStyles.AllowThousands);
            item.DeliveryStepWeight = Int32.Parse(txtDeliveryStepWeight.Text == string.Empty ? "0" : txtDeliveryStepWeight.Text, System.Globalization.NumberStyles.AllowThousands);
            item.DeliveryStepPrice = Int32.Parse(txtDeliveryStepPrice.Text == string.Empty ? "0" : txtDeliveryStepPrice.Text, System.Globalization.NumberStyles.AllowThousands);
            item.SysInitPrice = 0;
            item.SysInitWeight = 0;
            item.SysStepWeight = 0;
            item.SysStepPrice = 0;
            item.TranInitPrice = 0;
            item.TranInitWeight = 0;
            item.TranStepWeight = 0;
            item.TranStepPrice = 0;
            item.ManualSign = chbManualSign.Checked;
            item.IsPickup = chbIsPickup.Checked;
            item.LinkCustomerLogin = txtLinkCustomerLogin.Text;
            if (status == enumAction.NEW)
            {
                await _logic.Create(item);
            }
            else if (status == enumAction.UPDATE)
            {
                //Cập nhật dữ liệu
                await _logic.Update(Gitem.Id, item).ConfigureAwait(true);
            }
            status = 0;
            EnableButton(status);
            LoadData();
        }

        //Xóa
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gridMain.SelectedRows[0].Index;
                Gitem = await _logic.GetDetails(Convert.ToString(gridMain.Rows[index].Cells["col_Id"].Value)).ConfigureAwait(false);
                if (null != Gitem)
                {
                    if (MessageBox.Show("Bạn có muốn xóa không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        await _logic.Delete(Gitem.Id);
                    }
                    Gitem = null;
                    status = 0;
                    EnableButton(status);
                    LoadData();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }
        //In
        private void btnPrint_Click(object sender, EventArgs e)
        {
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                DataTable data;
                string reportFile = "GExpProvider.rpt";
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
            }
            finally
            {
                dc.Close();

            }
        }
        //Kết thúc
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private async void cmbProvinceCode_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                if (cmbProvinceCode.SelectedValue != null)
                {
                    cmbDistrictCode.DataSource = await _logicBill.GetDanhSachHuyen(cmbProvinceCode.SelectedValue.ToString());
                    cmbDistrictCode.DisplayMember = "DistrictName";
                    cmbDistrictCode.ValueMember = "DistrictID";
                }
            }
        }

        private async void cmbDistrictCode_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                if (cmbDistrictCode.SelectedValue != null)
                {
                    cmbWardCode.DataSource = await _logicBill.GetDanhSachXa(cmbDistrictCode.SelectedValue.ToString());
                    cmbWardCode.DisplayMember = "WardName";
                    cmbWardCode.ValueMember = "WardId";
                }
            }
        }

        private async void cmbProviderTypeCode_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                GExpProviderType proType = await _logic.GetTypeDetails(cmbProviderTypeCode.SelectedValue.ToString());
                if (proType != null)
                {
                    if (string.IsNullOrEmpty(proType.ConfigRequest) == false)
                    {
                        string[] split = proType.ConfigRequest.Split('|');
                        if (split.Length > 0)
                        {
                            lblToken.ForeColor = Color.Black;
                            lblClientSecrect.ForeColor = Color.Black;
                            lblShopId.ForeColor = Color.Black;
                            lblClientId.ForeColor = Color.Black;
                            lblServiceId.ForeColor = Color.Black;
                            lblPostBT3Id.ForeColor = Color.Black;

                            foreach (var item in split.ToList())
                            {
                                string[] temp = item.Split(';');
                                if (temp.Length < 2)
                                {
                                    continue;
                                }
                                switch (temp[0])
                                {
                                    case "token":
                                        {
                                            lblToken.ForeColor = Color.Red;
                                            txtToken.Text = temp[1];
                                        }
                                        break;
                                    case "clientsecrect":
                                        {
                                            lblClientSecrect.ForeColor = Color.Red;
                                            txtClientSecrect.Text = temp[1];
                                        }
                                        break;
                                    case "shopid":
                                        {
                                            lblShopId.ForeColor = Color.Red;
                                            txtShopId.Text = temp[1];
                                        }
                                        break;
                                    case "clientid":
                                        {
                                            lblClientId.ForeColor = Color.Red;
                                            txtClientId.Text = temp[1];
                                        }
                                        break;
                                    case "serviceid":
                                        {
                                            lblServiceId.ForeColor = Color.Red;
                                            txtServiceId.Text = temp[1];
                                        }
                                        break;
                                    case "pickupid":
                                        {
                                            lblPostBT3Id.ForeColor = Color.Red;
                                            txtPostBT3Id.Text = temp[1];
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                }
            }
        }

        private async void vùngVậnChuyểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gridMain.SelectedRows[0].Index;
                var providerItem = await _logic.GetDetails(Convert.ToString(gridMain.Rows[index].Cells["col_Id"].Value)).ConfigureAwait(false);
                if (null != providerItem)
                {
                    frmQuanLyVungPhat frm = new frmQuanLyVungPhat();
                    frm.provinceId = providerItem.WhiteListProvince;
                    frm.DistrictIds = providerItem.DistrictWhiteList;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        _logic.UpdateVungVanChuyen(providerItem.Id, frm.provinceId, frm.DistrictIds);
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }

        }
    }
}
