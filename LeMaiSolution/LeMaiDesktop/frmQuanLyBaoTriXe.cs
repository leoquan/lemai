using Common;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LeMaiDomain;
using LeMaiDomain.Models;
using LeMaiLogic;
using LeMaiLogic.Logic;

namespace LeMaiDesktop
{
    public partial class frmQuanLyBaoTriXe : frmBase
    {
        private enumAction status = enumAction.NONE;
        private enumEdit edited = enumEdit.NONE;
        private view_VihcleCoupon Gitem;
        private view_VihcleCoupon GCopyParrent;
        private List<view_VihcleCouponDetail> GListITem = new List<view_VihcleCouponDetail>();
        private view_VihcleCouponDetail GitemChild;
        private view_VihcleCouponDetail GCopyChild;
        private QuanLyBaoTriXeLogic _logic = new QuanLyBaoTriXeLogic(PBean.ConnectionBase);
        public frmQuanLyBaoTriXe() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            gridChild.AutoGenerateColumns = false;
            this.gridChild.RowTemplate.MinimumHeight = 22;
            Separator();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Print
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                DataTable data = dc.GetData("select * from " + PBean.SCHEMA + ".VihcleCoupon");

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gridParrent.SelectedRows[0].Index;
                string Id = Convert.ToString(gridParrent.Rows[index].Cells["col_Id"].Value);
                DeleteItem(Id);
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }
        private async void DeleteItem(String Id)
        {
            var check = await _logic.GetDetails(Id);
            if (check != null)
            {
                if (MessageBox.Show("Bạn có muốn xóa [" + check.ToString() + "] không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool result = await _logic.Delete(Id);
                    if (result)
                    {
                        Gitem = null;
                        status = enumAction.NONE;
                        edited = enumEdit.NONE;
                        EnableButton(status);
                        LoadData();
                    }
                }
            }
        }
        private async void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gridParrent.SelectedRows[0].Index;
                try
                {
                    string Id = Convert.ToString(gridParrent.Rows[index].Cells["col_Id"].Value);
                    Gitem = await _logic.GetDetails(Id);
                    if (null != Gitem)
                    {
                        FillData(Gitem, false);
                        // Fill data to Machine
                        GListITem = await _logic.GetChildList(Id);
                        LoadDataChildItem();
                        status = enumAction.UPDATE;
                        tabControl.SelectedIndex = 1;
                        EnableButton(status);
                    }
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu nhập
            if (String.IsNullOrEmpty(txtTotalKM.Text))
            {
                MessageBox.Show("TotalFee không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotalKM.Focus();
                return;
            }
            if (GListITem.Count() <= 0)
            {
                MessageBox.Show("Chưa nhập danh sách chi tiết đơn hàng?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                QuanLyBaoTriXeLogicInputDto masterItem = new QuanLyBaoTriXeLogicInputDto();
                masterItem.FK_Vihcle = cmbFK_Vihcle.SelectedValue.ToString();
                masterItem.TotalFee = Int32.Parse(txtTotalKM.Text, System.Globalization.NumberStyles.AllowThousands);
                masterItem.Note = txtNote.Text;
                foreach (var item in GListITem)
                {
                    childQuanLyBaoTriXeLogicInputDto childItem = new childQuanLyBaoTriXeLogicInputDto();
                    childItem.FK_Service = item.FK_Service;
                    childItem.FK_VihcleCoupon = item.FK_VihcleCoupon;
                    childItem.CurrentValue = item.CurrentValue;
                    masterItem.lsVihcleCouponDetail.Add(childItem);
                }
                if (status == enumAction.NEW)
                {
                    await _logic.Create(masterItem);
                }
                else if (status == enumAction.UPDATE)
                {
                    await _logic.Update(Gitem.Id, masterItem);
                }
                status = enumAction.NONE;
                edited = enumEdit.NONE;
                EnableButton(status);
                LoadData();
                tabControl.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
            }
        }

        private async void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gridChild.SelectedRows[0].Index;
                string Id = Convert.ToString(gridChild.Rows[index].Cells["col_SubId"].Value);
                view_VihcleCouponDetail childItem = await _logic.GetChildDetails(Id);
                if (null != childItem)
                {
                    if (MessageBox.Show("Bạn có muốn xóa chi tiết [" + childItem.ToString() + "] không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        await _logic.DeleteChild(Id);
                        GListITem.Remove(childItem);
                        LoadDataChildItem();
                        ClearTextSubItem();
                    }
                }

            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItem();
            //Focus Next Control;
            //txtSubmaterialname.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            if (status != enumAction.NONE)
            {
                if (edited != enumEdit.NONE)
                {
                    DialogResult dialogResult = MessageBox.Show(PBean.SERVER_OPTION.CanhBaoBoQua, PBean.SERVER_OPTION.CanhBaoBoQuaTitle, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
                GCopyChild = null;
                GCopyParrent = null;
                Gitem = null;
                GitemChild = null;

                status = enumAction.NONE;
                edited = enumEdit.NONE;
                EnableButton(status);
                tabControl.SelectedIndex = 0;
            }
            else
            {
                GCopyChild = null;
                GCopyParrent = null;
                Gitem = null;
                GitemChild = null;

                status = enumAction.NEW;
                EnableButton(status);
                ClearText();
                GListITem = new List<view_VihcleCouponDetail>();
                LoadDataChildItem();
                tabControl.SelectedIndex = 1;
            }
        }
        private void AddItem()
        {
            //Add sub item
            if (cmbSubFK_Service.SelectedValue == null)
            {
                MessageBox.Show("FK_Service không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSubFK_Service.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubCurrentValue.Text))
            {
                MessageBox.Show("CurrentValue không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubCurrentValue.Focus();
                return;
            }

            view_VihcleCouponDetail childItem = new view_VihcleCouponDetail();
            childItem.FK_Service = cmbSubFK_Service.SelectedValue.ToString();
            childItem.CurrentValue = Int32.Parse(txtSubCurrentValue.Text, System.Globalization.NumberStyles.AllowThousands);
            GListITem.Add(childItem);
            edited = enumEdit.EDIT;
            LoadDataChildItem();
            ClearTextSubItem();
        }
        private void LoadDataChildItem()
        {
            ClearTextSubItem();
            gridChild.DataSource = GListITem.ToList();
        }
        private void frmQuanLyBaoTriXe_Load(object sender, EventArgs e)
        {
            LoadData();
            EnableButton(status);
        }

        private async void LoadData(string searchText = "")
        {
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                gridParrent.AutoGenerateColumns = false;
                if (string.IsNullOrEmpty(searchText))
                {
                    gridParrent.DataSource = dc.GetData("SELECT * FROM " + PBean.SCHEMA + ".view_VihcleCoupon order by Date asc");
                }
                else
                {
                    gridParrent.DataSource = dc.GetData("select * from " + PBean.SCHEMA + ".[view_VihcleCoupon] where BienSo like N'%" + searchText + "%' or TenXe like N'%" + searchText + "%' order by Date asc");
                }
                cmbFK_Vihcle.DataSource = await _logic.GetMasterFK_VihcleList();
                cmbFK_Vihcle.DisplayMember = "BienSo";
                cmbFK_Vihcle.ValueMember = "BienSo";
                cmbSubFK_Service.DataSource = await _logic.GetChildFK_ServiceList();
                cmbSubFK_Service.DisplayMember = "ServiceName";
                cmbSubFK_Service.ValueMember = "Id";
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
        private void txtSearchForm_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtSearchForm.Text);
        }
        private void EnableButton(enumAction stus)
        {
            //Enable tất cả các button
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            // Child
            btnNewChild.Enabled = true;
            btnAdd.Enabled = true;
            btnRemove.Enabled = true;
            btnSave.Enabled = true;
            btnEditChild.Enabled = true;
            btnDeleteChild.Enabled = true;
            if (stus == enumAction.NONE)
            {
                btnNew.Text = "Mới";
                btnNewChild.Text = "Mới";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iNew;
                btnNewChild.Image = global::LeMaiDesktop.Properties.Resources.iNew;
                cmbFK_Vihcle.Enabled = false;
                txtTotalKM.Enabled = false;
                txtNote.Enabled = false;
                cmbSubFK_Service.Enabled = false;
                txtSubCurrentValue.Enabled = false;
            }
            if (stus == enumAction.NEW)
            {
                btnNew.Enabled = true;
                btnNew.Text = "Bỏ qua";
                btnNewChild.Text = "Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                btnNewChild.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                cmbFK_Vihcle.Enabled = true;
                txtTotalKM.Enabled = true;
                txtNote.Enabled = true;
                cmbSubFK_Service.Enabled = true;
                txtSubCurrentValue.Enabled = true;
            }
            if (stus == enumAction.UPDATE)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnNew.Enabled = true;
                btnNew.Text = "Bỏ qua";
                btnNewChild.Text = "Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                btnNewChild.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                cmbFK_Vihcle.Enabled = true;
                txtTotalKM.Enabled = true;
                txtNote.Enabled = true;
                cmbSubFK_Service.Enabled = true;
                txtSubCurrentValue.Enabled = true;
            }
        }
        // Xóa trắng tất cả các textbox.
        private void ClearText()
        {
            cmbFK_Vihcle.SelectedValue = string.Empty;
            txtTotalKM.Text = "0";
            txtNote.Text = string.Empty;
        }
        private void ClearTextSubItem()
        {
            cmbSubFK_Service.SelectedValue = string.Empty;
            txtSubCurrentValue.Text = "0";
        }
        private void FillDataChildItem(view_VihcleCouponDetail item, bool copy)
        {
            cmbSubFK_Service.SelectedValue = item.FK_Service;
            txtSubCurrentValue.Text = item.CurrentValue.ToString();

        }
        private void FillData(view_VihcleCoupon item, bool copy)
        {
            cmbFK_Vihcle.SelectedValue = item.FK_Vihcle;
            txtTotalKM.Text = item.SoKM.ToString();
            txtNote.Text = item.Note;
        }
        private void gridParrent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(null, null);
        }

        private async void gridMain_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Edit child item
            try
            {
                int index = gridChild.SelectedRows[0].Index;
                string Id = Convert.ToString(gridChild.Rows[index].Cells["col_SubId"].Value);
                GitemChild = await _logic.GetChildDetails(Id);
                if (null != GitemChild)
                {
                    FillDataChildItem(GitemChild, false);
                    btnEditChild.Enabled = true;
                    btnAdd.Enabled = false;
                    btnRemove.Enabled = false;
                    btnSave.Enabled = false;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }

        }

        private void gridMain_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private async void btnEditChild_Click(object sender, EventArgs e)
        {
            if (cmbSubFK_Service.SelectedValue == null)
            {
                MessageBox.Show("Dịch không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSubFK_Service.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubCurrentValue.Text))
            {
                MessageBox.Show("Giá trị KM không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubCurrentValue.Focus();
                return;
            }
            // Edit child
            if (GitemChild != null)
            {

                childQuanLyBaoTriXeLogicInputDto childItem = new childQuanLyBaoTriXeLogicInputDto();
                childItem.FK_Service = cmbSubFK_Service.SelectedValue.ToString();
                childItem.CurrentValue = Int32.Parse(txtSubCurrentValue.Text, System.Globalization.NumberStyles.AllowThousands);
                await _logic.CreateOrUpdateChildOnly(GitemChild.Id, childItem);
            }
            GitemChild = null;
            //
            ClearTextSubItem();
            LoadDataChildItem();
            btnEditChild.Enabled = false;
            btnAdd.Enabled = true;
            btnRemove.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnDeleteChild_Click(object sender, EventArgs e)
        {
            DeleteItem(Gitem.Id);
        }

        private void btnPrintChild_Click(object sender, EventArgs e)
        {
            // Print
        }

        private void menuCopyChild_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gridChild.SelectedRows[0].Index;
                string Id = Convert.ToString(gridChild.Rows[index].Cells["col_SubId"].Value);
                GCopyChild = GListITem.FirstOrDefault(u => u.Id == Id);
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private async void menuPasteChild_Click(object sender, EventArgs e)
        {
            if (GCopyChild != null)
            {
                childQuanLyBaoTriXeLogicInputDto childItem = new childQuanLyBaoTriXeLogicInputDto();
                childItem.FK_Service = GCopyChild.FK_Service;
                childItem.FK_VihcleCoupon = GCopyChild.FK_VihcleCoupon;
                childItem.CurrentValue = GCopyChild.CurrentValue;
                view_VihcleCouponDetail copyNew = await _logic.CreateOrUpdateChildOnly(GCopyChild.Id, childItem);
                GListITem.Add(copyNew);
                LoadDataChildItem();
            }
        }

        private async void menuCopyParrent_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gridParrent.SelectedRows[0].Index;
                string Id = Convert.ToString(gridParrent.Rows[index].Cells["col_Id"].Value);
                GCopyParrent = await _logic.GetDetails(Id);
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private async void menuPasteParrent_Click(object sender, EventArgs e)
        {
            try
            {
                if (GCopyParrent != null)
                {
                    QuanLyBaoTriXeLogicInputDto parrentCopy = new QuanLyBaoTriXeLogicInputDto();
                    parrentCopy.FK_Vihcle = GCopyParrent.FK_Vihcle;
                    parrentCopy.TotalFee = GCopyParrent.TotalFee;
                    parrentCopy.Note = GCopyParrent.Note;
                    parrentCopy.lsVihcleCouponDetail = new List<childQuanLyBaoTriXeLogicInputDto>();
                    List<view_VihcleCouponDetail> lsChild = await _logic.GetChildList(GCopyParrent.Id);
                    foreach (var item in lsChild)
                    {
                        childQuanLyBaoTriXeLogicInputDto child = new childQuanLyBaoTriXeLogicInputDto();
                        child.FK_Service = item.FK_Service;
                        child.FK_VihcleCoupon = item.FK_VihcleCoupon;
                        child.CurrentValue = item.CurrentValue;
                        parrentCopy.lsVihcleCouponDetail.Add(child);
                    }
                    await _logic.Create(parrentCopy);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.C))
            {
                menuCopyChild_Click(null, null);
                return true;
            }
            if (keyData == (Keys.Control | Keys.V))
            {
                if (GCopyChild != null)
                {
                    FillDataChildItem(GCopyChild, false);
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void frmQuanLyBaoTriXe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (edited != enumEdit.NONE)
            {
                DialogResult dialogResult = MessageBox.Show("", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo);
                e.Cancel = (dialogResult == DialogResult.No);
            }
        }
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtFK_Vihcle_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtTotalFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtTotalFee_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void dtpDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSubId_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSubFK_Service_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSubFK_VihcleCoupon_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSubCurrentValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSubCurrentValue_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void dtpSubServiceDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }

    }
}
