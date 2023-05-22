using Common;
using LeMaiDomain;
using LeMaiDomain.Models;
using LeMaiLogic;
using LeMaiLogic.Logic;
using System;
using System.Data;
using System.Windows.Forms;

namespace LeMaiDesktop
{
    public partial class frmQuanLyTaiKhoan : frmBase
    {
        private QuanLyTaiKhoanLogic _logic = new QuanLyTaiKhoanLogic(PBean.ConnectionBase);
        private enumAction status = enumAction.NONE;
        private view_AccountObject Gitem;

        public frmQuanLyTaiKhoan() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            gridMain.AutoGenerateColumns = false;
            this.gridMain.RowTemplate.MinimumHeight = 22;
            Separator();
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData(true);
            EnableButton(status);
            ChangeLanguageUI(PBean.MAKE_LANG);
            if (PBean.USER.AccountType <= 1)
            {
                menuPermission.Visible = true;
                menuReset.Visible = true;
            }
            else
            {
                menuPermission.Visible = false;
                menuReset.Visible = false;
            }
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
                txtFullName.Enabled = false;
                txtUserName.Enabled = false;
                txtPassWord.Enabled = false;
                txtPhone.Enabled = false;
                txtEmail.Enabled = false;
                cmbAccountType.Enabled = false;
                cmbCardId.Enabled = false;
                txtAddress.Enabled = false;
                txtNote.Enabled = false;
            }
            if (stus == enumAction.NEW)
            {
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                txtFullName.Enabled = true;
                txtUserName.Enabled = true;
                txtPassWord.Enabled = true;
                txtPhone.Enabled = true;
                txtEmail.Enabled = true;
                cmbAccountType.Enabled = true;
                cmbCardId.Enabled = true;
                txtAddress.Enabled = true;
                txtNote.Enabled = true;
            }
            if (stus == enumAction.UPDATE)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                txtFullName.Enabled = true;
                txtUserName.Enabled = true;
                txtPassWord.Enabled = true;
                txtPhone.Enabled = true;
                txtEmail.Enabled = true;
                cmbAccountType.Enabled = true;
                cmbCardId.Enabled = true;
                txtAddress.Enabled = true;
                txtNote.Enabled = true;
            }
        }
        // Xóa trắng tất cả các textbox.
        private void ClearText()
        {
            txtFullName.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassWord.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtNote.Text = string.Empty;
            txtFullName.Focus();
        }

        // Fill dữ liệu vào các control.
        private void FillData(view_AccountObject item, bool copy)
        {
            if (!copy)
            {
            }
            txtFullName.Text = item.FullName;
            txtUserName.Text = item.UserName;
            txtPassWord.Text = item.PassWord;
            txtPhone.Text = item.Phone;
            txtEmail.Text = item.Email;
            cmbAccountType.SelectedValue = item.AccountType;
            if (item.CardId != null)
            {
                cmbCardId.SelectedValue = item.CardId;
            }
            txtAddress.Text = item.Address;
            txtNote.Text = item.Note;
        }

        #region Xử lý TextBox tìm kiếm dữ liệu trên form
        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var result = await _logic.GetList(txtSearch.Text, PBean.USER);
            gridMain.DataSource = result;
        }
        #endregion

        #endregion

        #region Xử lý sự kiện cho các button - GridControl
        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtAtRowStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtAtRowStatus_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtIdAccountIntro_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtcap_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtcap_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtcompanyid_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtFK_Leader_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }

        // Load data từ database lên lưới
        private async void LoadData(bool reload = false)
        {
            var result = await _logic.GetList(string.Empty, PBean.USER);
            gridMain.DataSource = result;
            if (reload)
            {
                // AccountObjectType
                cmbAccountType.DataSource = await _logic.GetMasterAccountTypeList(PBean.USER.AccountType);
                cmbAccountType.DisplayMember = "AccountTypeName";
                cmbAccountType.ValueMember = "Id";
                // ExpPost
                cmbCardId.DataSource = await _logic.GetMasterCardIdList(PBean.USER);
                cmbCardId.DisplayMember = "TenDaiLy";
                cmbCardId.ValueMember = "Id";
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
            if (String.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Tên nhân viên không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Tên đăng nhập không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtPassWord.Text))
            {
                MessageBox.Show("Mật khẩu không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassWord.Focus();
                return;
            }
            if (cmbAccountType.SelectedValue == null)
            {
                MessageBox.Show("Loại tài khoản không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbAccountType.Focus();
                return;
            }
            QuanLyTaiKhoanLogicInputDto item = new QuanLyTaiKhoanLogicInputDto();
            item.FullName = txtFullName.Text;
            item.UserName = txtUserName.Text;
            item.PassWord = Security.GetMD5(txtPassWord.Text.Trim());
            item.Phone = txtPhone.Text;
            item.Email = txtEmail.Text;
            item.AtCreatedBy = PBean.USER.Id;
            item.AtLastModifiedBy = PBean.USER.Id;
            item.AtRowStatus = 0;
            item.AccountType = Int32.Parse(cmbAccountType.SelectedValue.ToString());
            item.CardId = cmbCardId.SelectedValue.ToString();
            item.Address = txtAddress.Text;
            item.FK_BranchOwner = cmbCardId.SelectedValue.ToString();
            item.Note = txtNote.Text;
            item.cap = Int32.Parse(cmbAccountType.SelectedValue.ToString());
            item.companyid = "companyid";
            item.FK_Leader = "Leader";
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
                string reportFile = "AccountObject.rpt";
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

        private async void menuReset_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gridMain.SelectedRows[0].Index;
                Gitem = await _logic.GetDetails(Convert.ToString(gridMain.Rows[index].Cells["col_Id"].Value));
                if (null != Gitem)
                {
                    bool rs = await _logic.ResetPassword(Gitem.Id, Security.GetMD5("123456"));
                    if (rs == true)
                    {
                        MessageBox.Show("Mật khẩu mới của tài khoản là: 123456", PBean.MESSAGE_TITLE);
                    }

                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private async void menuPermission_Click(object sender, EventArgs e)
        {
            try
            {

                int index = gridMain.SelectedRows[0].Index;
                Gitem = await _logic.GetDetails(Convert.ToString(gridMain.Rows[index].Cells["col_Id"].Value));
                if (null != Gitem)
                {
                    frmAccountPermission frm = new frmAccountPermission();
                    frm.AccountObjectId = Gitem.Id;
                    frm.ShowDialog();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }
        private string GetUserName(string FullName)
        {
            string temp = PCommon.ConvertToUnSign(FullName).ToLower().Trim();
            string[] array = temp.Split(' ');
            temp = array[array.Length - 1];
            if (array.Length > 1)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (!string.IsNullOrEmpty(array[i]))
                    {
                        temp += array[i].ToCharArray()[0];
                    }
                }
            }
            return temp;
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            if (status == enumAction.NEW)
            {
                txtUserName.Text = GetUserName(txtFullName.Text.Trim());
            }
            if (!string.IsNullOrEmpty(txtFullName.Text))
            {
                txtFullName.Text = PCommon.UppercaseWords(txtFullName.Text.Trim());
            }
        }
    }
}
