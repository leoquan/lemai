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
using LeMaiLogic;

namespace LeMaiDesktop
{
    public partial class frmAccountObject : frmBase
    {
        private int status = 0;//0: Không làm gì cả, 1: Chế độ thêm mới, 2: Chế độ chỉnh sửa
        private AccountObject Gitem;

        public frmAccountObject() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            gridMain.AutoGenerateColumns = false;
            this.gridMain.RowTemplate.MinimumHeight = 22;
            Separator();
        }

        private void frmAccountObject_Load(object sender, EventArgs e)
        {
            LoadData();
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
        private void EnableButton(int stus)
        {
            //Enable tất cả các button
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            if (stus == 0)
            {
                btnSave.Enabled = false;
                btnNew.Text = "&Mới";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iNew;
                txtCode.Enabled = false;
                txtFullName.Enabled = false;
                txtUserName.Enabled = false;
                txtPassWord.Enabled = false;
                txtPhone.Enabled = false;
                txtEmail.Enabled = false;
                cmbAccountType.Enabled = false;
                txtCardId.Enabled = false;
            }
            if (stus == 1)
            {
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                txtCode.Enabled = true;
                txtFullName.Enabled = true;
                txtUserName.Enabled = true;
                txtPassWord.Enabled = true;
                txtPhone.Enabled = true;
                txtEmail.Enabled = true;
                cmbAccountType.Enabled = true;
                txtCardId.Enabled = true;
            }
            if (stus == 2)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                txtCode.Enabled = true;
                txtFullName.Enabled = true;
                txtUserName.Enabled = true;
                txtPassWord.Enabled = true;
                txtPhone.Enabled = true;
                txtEmail.Enabled = true;
                cmbAccountType.Enabled = true;
                txtCardId.Enabled = true;
            }
        }
        // Xóa trắng tất cả các textbox.
        private void ClearText()
        {
            txtCode.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassWord.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cmbAccountType.Text = string.Empty;
            txtCardId.Text = string.Empty;
        }

        // Fill dữ liệu vào các control.
        private void FillData(AccountObject item, bool copy)
        {
            txtCode.Text = item.Code;
            txtFullName.Text = item.FullName;
            txtUserName.Text = item.UserName;
            txtPassWord.Text = item.PassWord;
            txtPhone.Text = item.Phone;
            txtEmail.Text = item.Email;
            cmbAccountType.SelectedIndex = item.AccountType;
            txtCardId.Text = item.CardId;
        }

        #region Xử lý TextBox tìm kiếm dữ liệu trên form
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                gridMain.DataSource = dc.GetData("select * from " + PBean.SCHEMA + ".[view_AccountObject] where Code like '%" + txtSearch.Text + "%' or FullName like '%" + txtSearch.Text + "%' or UserName like '%" + txtSearch.Text + "%'");
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
        #endregion

        #endregion

        #region Xử lý sự kiện cho các button - GridControl
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
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
        private void dtpAtCreatedDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtAtCreatedBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void dtpAtLastModifiedDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtAtLastModifiedBy_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtAccountType_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtAccountType_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void dtpLastLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtCardId_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }

        // Load data từ database lên lưới
        private void LoadData()
        {
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                gridMain.DataSource = dc.GetData("select * from " + PBean.SCHEMA + ".[view_AccountObject] order by Code asc");
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

        private void gridMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (status != 1)
            {
                btnEdit_Click(null, null);
            }
            else
            {
                try
                {
                    int index = gridMain.SelectedRows[0].Index;
                    IDataContext dc = PCommon.getDataContext();
                    try
                    {
                        dc.Open();
                        Gitem = dc.ACcountobject.GetObject(PBean.SCHEMA, Convert.ToString(gridMain.Rows[index].Cells["col_Id"].Value));
                        if (null != Gitem)
                        {
                            FillData(Gitem, true);
                        }
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
                catch (ArgumentOutOfRangeException)
                {
                    return;
                }
            }
        }
        //Thêm mới
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (status != 0)
            {
                status = 0;
                EnableButton(status);
            }
            else
            {
                status = 1;
                EnableButton(status);
                ClearText();
            }
        }

        //Chỉnh sửa
        private void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                int index = gridMain.SelectedRows[0].Index;
                IDataContext dc = PCommon.getDataContext();
                try
                {
                    dc.Open();
                    Gitem = dc.ACcountobject.GetObject(PBean.SCHEMA, Convert.ToString(gridMain.Rows[index].Cells["col_Id"].Value));
                    if (null != Gitem)
                    {
                        FillData(Gitem, false);
                        status = 2;
                        EnableButton(status);
                    }
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
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }
        //Lưu
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu nhập
            if (String.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("Code không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCode.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("FullName không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("UserName không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtPassWord.Text))
            {
                MessageBox.Show("PassWord không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassWord.Focus();
                return;
            }
            if (cmbAccountType.SelectedIndex < 0)
            {
                MessageBox.Show("AccountType không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbAccountType.Focus();
                return;
            }
            if (status == 1)
            {
                IDataContext dc = PCommon.getDataContext();
                try
                {
                    //Thêm mới dữ liệu
                    dc.Open();
                    Gitem = new AccountObject();
                    Gitem.Id = Guid.NewGuid().ToString();
                    Gitem.Code = txtCode.Text;
                    Gitem.FullName = txtFullName.Text;
                    Gitem.UserName = txtUserName.Text;
                    Gitem.PassWord = txtPassWord.Text;
                    Gitem.Phone = txtPhone.Text;
                    Gitem.Email = txtEmail.Text;
                    Gitem.AtRowStatus = 0;
                    Gitem.AccountType = cmbAccountType.SelectedIndex;
                    Gitem.CardId = txtCardId.Text;
                    dc.ACcountobject.InsertOnSubmit(PBean.SCHEMA, Gitem);
                    dc.SubmitChanges();
                    status = 0;
                    EnableButton(status);
                    LoadData();

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
            else
            {
                if (status == 2)
                {
                    //Cập nhật dữ liệu
                    IDataContext dc = PCommon.getDataContext();
                    try
                    {
                        dc.Open();
                        Gitem.Code = txtCode.Text;
                        Gitem.FullName = txtFullName.Text;
                        Gitem.UserName = txtUserName.Text;
                        Gitem.PassWord = txtPassWord.Text;
                        Gitem.Phone = txtPhone.Text;
                        Gitem.Email = txtEmail.Text;
                        Gitem.AccountType = cmbAccountType.SelectedIndex;
                        Gitem.CardId = txtCardId.Text;
                        dc.ACcountobject.Update(PBean.SCHEMA, Gitem);
                        dc.SubmitChanges();
                        status = 0;
                        EnableButton(status);
                        LoadData();

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
            }
        }

        //Xóa
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gridMain.SelectedRows[0].Index;
                IDataContext dc = PCommon.getDataContext();
                try
                {
                    dc.Open();
                    Gitem = dc.ACcountobject.GetObject(PBean.SCHEMA, Convert.ToString(gridMain.Rows[index].Cells["col_Id"].Value));
                    if (null != Gitem)
                    {
                        if (MessageBox.Show("Bạn có muốn xóa không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Gitem.AtRowStatus = 1;
                            dc.ACcountobject.Update(PBean.SCHEMA, Gitem);
                            dc.SubmitChanges();
                        }
                        Gitem = null;
                        status = 0;
                        EnableButton(status);
                        LoadData();
                    }
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
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }
        //Kết thúc
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
