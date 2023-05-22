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
    public partial class frmMenuFuntionGroup : frmBase
    {
        private int status = 0;//0: Không làm gì cả, 1: Chế độ thêm mới, 2: Chế độ chỉnh sửa
        private MenuFunctionGroup Gitem;
        private bool isParrentGroup = true;

        public frmMenuFuntionGroup(bool isParrent = false) : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            isParrentGroup = isParrent;
            gridMain.AutoGenerateColumns = false;
            this.gridMain.RowTemplate.MinimumHeight = 22;
            Separator();
        }

        private void frmMenuFuntionGroup_Load(object sender, EventArgs e)
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
                txtGroupName.Enabled = false;
                txtSortIndex.Enabled = false;
                txtIcon.Enabled = false;
                txtCssClass.Enabled = false;
                cmbParrentMenuGroup.Enabled = false;
                cmbProjectUsed.Enabled = false;
            }
            if (stus == 1)
            {
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                txtGroupName.Enabled = true;
                txtSortIndex.Enabled = true;
                txtIcon.Enabled = true;
                txtCssClass.Enabled = true;
                cmbParrentMenuGroup.Enabled = true;
                cmbProjectUsed.Enabled = true;
            }
            if (stus == 2)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                txtGroupName.Enabled = true;
                txtSortIndex.Enabled = true;
                txtIcon.Enabled = true;
                txtCssClass.Enabled = true;
                cmbParrentMenuGroup.Enabled = true;
                cmbProjectUsed.Enabled = true;
            }
            if (isParrentGroup == true)
            {
                cmbParrentMenuGroup.Enabled = false;
                lblFK_MenuGroup.Enabled = false;
            }
        }
        // Xóa trắng tất cả các textbox.
        private void ClearText()
        {
            txtGroupName.Text = string.Empty;
            txtSortIndex.Text = string.Empty;
            txtIcon.Text = string.Empty;
            txtCssClass.Text = string.Empty;
            cmbParrentMenuGroup.Text = string.Empty;
            cmbProjectUsed.Text = string.Empty;
        }

        // Fill dữ liệu vào các control.
        private void FillData(MenuFunctionGroup item, bool copy)
        {
            txtGroupName.Text = item.GroupName;
            txtSortIndex.Text = item.SortIndex.ToString();
            txtIcon.Text = item.Icon;
            txtCssClass.Text = item.CssClass;
            if (isParrentGroup == false)
            {
                cmbParrentMenuGroup.SelectedValue = item.FK_MenuGroup;
            }
            else
            {
                cmbParrentMenuGroup.SelectedValue = null;
            }
            cmbProjectUsed.SelectedIndex = item.ProjectUsed;
            txtProgramUse.Text = item.ProgramGroup;
        }

        #region Xử lý TextBox tìm kiếm dữ liệu trên form
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                if (isParrentGroup)
                {
                    gridMain.DataSource = dc.GetData("select * from " + PBean.SCHEMA + ".[MenuFunctionGroup] where (FK_MenuGroup IS NULL OR FK_MenuGroup='') AND GroupName like '%" + txtSearch.Text + "%'");
                }
                else
                {
                    gridMain.DataSource = dc.GetData("select * from " + PBean.SCHEMA + ".[view_SubMenuGroup] where GroupName like '%" + txtSearch.Text + "%'");
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
        #endregion

        #endregion

        #region Xử lý sự kiện cho các button - GridControl
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtGroupName_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSortIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSortIndex_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtIcon_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtCssClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void dtpCreateDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtStatus_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtFK_MenuGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtProjectUsed_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtProjectUsed_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }

        // Load data từ database lên lưới
        private void LoadData()
        {
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                if (isParrentGroup)
                {
                    gridMain.DataSource = dc.GetData("select * from " + PBean.SCHEMA + ".[MenuFunctionGroup] WHERE FK_MenuGroup IS NULL OR FK_MenuGroup='' order by SortIndex asc");
                }
                else
                {
                    gridMain.DataSource = dc.GetData("select * from " + PBean.SCHEMA + ".[view_SubMenuGroup] order by SortIndex asc");
                }
                if (isParrentGroup == false)
                {
                    cmbParrentMenuGroup.DataSource = dc.MEnufunctiongroup.GetListObjectCon(PBean.SCHEMA, "WHERE FK_MenuGroup ='' OR FK_MenuGroup IS NULL");
                    cmbParrentMenuGroup.DisplayMember = "GroupName";
                    cmbParrentMenuGroup.ValueMember = "Id";
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
                        Gitem = dc.MEnufunctiongroup.GetObject(PBean.SCHEMA, Convert.ToString(gridMain.Rows[index].Cells["col_Id"].Value));
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
                txtGroupName.Focus();
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
                    Gitem = dc.MEnufunctiongroup.GetObject(PBean.SCHEMA, Convert.ToString(gridMain.Rows[index].Cells["col_Id"].Value));
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
            if (String.IsNullOrEmpty(txtGroupName.Text))
            {
                MessageBox.Show("GroupName không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGroupName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSortIndex.Text))
            {
                MessageBox.Show("SortIndex không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSortIndex.Focus();
                return;
            }
            if (status == 1)
            {
                IDataContext dc = PCommon.getDataContext();
                try
                {
                    //Thêm mới dữ liệu
                    dc.Open();
                    Gitem = new MenuFunctionGroup();
                    Gitem.Id = Guid.NewGuid().ToString();
                    Gitem.GroupName = txtGroupName.Text;
                    Gitem.SortIndex = Int32.Parse(txtSortIndex.Text, System.Globalization.NumberStyles.AllowThousands);
                    Gitem.Icon = txtIcon.Text;
                    Gitem.CssClass = txtCssClass.Text;
                    Gitem.CreateDate = DateTime.Now;
                    Gitem.Status = 0;
                    Gitem.ProgramGroup = txtProgramUse.Text.Trim();
                    if (cmbParrentMenuGroup.SelectedValue != null)
                    {
                        Gitem.FK_MenuGroup = cmbParrentMenuGroup.SelectedValue.ToString();
                    }
                    Gitem.ProjectUsed = cmbProjectUsed.SelectedIndex;
                    dc.MEnufunctiongroup.InsertOnSubmit(PBean.SCHEMA, Gitem);
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
                        Gitem.GroupName = txtGroupName.Text;
                        Gitem.SortIndex = Int32.Parse(txtSortIndex.Text, System.Globalization.NumberStyles.AllowThousands);
                        Gitem.Icon = txtIcon.Text;
                        Gitem.CssClass = txtCssClass.Text;
                        if (cmbParrentMenuGroup.SelectedValue != null)
                        {
                            Gitem.FK_MenuGroup = cmbParrentMenuGroup.SelectedValue.ToString();
                        }
                        Gitem.ProjectUsed = cmbProjectUsed.SelectedIndex;
                        Gitem.ProgramGroup = txtProgramUse.Text.Trim();
                        dc.MEnufunctiongroup.Update(PBean.SCHEMA, Gitem);
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
                    Gitem = dc.MEnufunctiongroup.GetObject(PBean.SCHEMA, Convert.ToString(gridMain.Rows[index].Cells["col_Id"].Value));
                    if (null != Gitem)
                    {
                        if (MessageBox.Show("Bạn có muốn xóa không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            dc.MEnufunctiongroup.DeleteOnSubmit(PBean.SCHEMA, Gitem);
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
