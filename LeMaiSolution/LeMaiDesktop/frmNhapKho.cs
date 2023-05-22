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
    public partial class frmNhapKho : frmBase
    {
        private enumAction status = enumAction.NONE;
        private enumEdit edited = enumEdit.NONE;
        private view_ExpNhapKho Gitem;
        private view_ExpNhapKho GCopyParrent;
        private List<view_ExpNhapKhoCt> GListITem = new List<view_ExpNhapKhoCt>();
        private view_ExpNhapKhoCt GitemChild;
        private view_ExpNhapKhoCt GCopyChild;
        private NhapKhoLogic _logic = new NhapKhoLogic(PBean.ConnectionBase);
        public frmNhapKho() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
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
                DataTable data = dc.GetData("select * from " + PBean.SCHEMA + ".ExpNhapKho");

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
            if (String.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Số lượng không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }
            if (txtSoLuong.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("Số lượng không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtDonGia.Text))
            {
                MessageBox.Show("Đơn giá không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }
            if (txtDonGia.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("Đơn giá không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtThanhTien.Text))
            {
                MessageBox.Show("Thành tiền không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThanhTien.Focus();
                return;
            }
            if (txtThanhTien.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("Thành tiền không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThanhTien.Focus();
                return;
            }
            try
            {
                NhapKhoLogicInputDto masterItem = new NhapKhoLogicInputDto();
                masterItem.FK_NguoiNhapKho = PBean.USER.Id;
                masterItem.FK_SanPham = cmbFK_SanPham.SelectedValue.ToString();
                masterItem.SoLuong = decimal.Parse(txtSoLuong.Text, CultureInfo.CurrentCulture);
                masterItem.DonGia = decimal.Parse(txtDonGia.Text, CultureInfo.CurrentCulture);
                masterItem.ThanhTien = decimal.Parse(txtThanhTien.Text, CultureInfo.CurrentCulture);
                masterItem.GhiChu = txtGhiChu.Text;
                foreach (var item in GListITem)
                {
                    childNhapKhoLogicInputDto childItem = new childNhapKhoLogicInputDto();
                    childItem.FK_NhapKho = item.FK_NhapKho;
                    childItem.FK_VatTu = item.FK_VatTu;
                    childItem.SoLuong = item.SoLuong;
                    childItem.DonGia = item.DonGia;
                    childItem.ThanhTien = item.ThanhTien;
                    masterItem.lsExpNhapKhoCt.Add(childItem);
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
                string FK_NhapKho = Convert.ToString(gridChild.Rows[index].Cells["col_SubFK_NhapKho"].Value);
                string FK_VatTu = Convert.ToString(gridChild.Rows[index].Cells["col_SubFK_VatTu"].Value);
                view_ExpNhapKhoCt childItem = await _logic.GetChildDetails(FK_NhapKho, FK_VatTu);
                if (null != childItem)
                {
                    if (MessageBox.Show("Bạn có muốn xóa chi tiết [" + childItem.ToString() + "] không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        await _logic.DeleteChild(FK_NhapKho, FK_VatTu);
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
                    DialogResult dialogResult = MessageBox.Show("", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo);
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
                GListITem = new List<view_ExpNhapKhoCt>();
                LoadDataChildItem();
                tabControl.SelectedIndex = 1;
            }
        }
        private void AddItem()
        {
            //Add sub item
            if (cmbSubFK_VatTu.SelectedValue == null)
            {
                MessageBox.Show("Vật tư không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSubFK_VatTu.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubSoLuong.Text))
            {
                MessageBox.Show("Số lượng không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubSoLuong.Focus();
                return;
            }
            if (txtSubSoLuong.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("Số lượng không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubSoLuong.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubDonGia.Text))
            {
                MessageBox.Show("Đơn giá không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubDonGia.Focus();
                return;
            }
            if (txtSubDonGia.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("Đơn giá không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubDonGia.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubThanhTien.Text))
            {
                MessageBox.Show("Thành tiền không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubThanhTien.Focus();
                return;
            }
            if (txtSubThanhTien.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("Thành tiền không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubThanhTien.Focus();
                return;
            }

            view_ExpNhapKhoCt childItem = new view_ExpNhapKhoCt();
            childItem.FK_VatTu = cmbSubFK_VatTu.SelectedValue.ToString();
            childItem.SoLuong = decimal.Parse(txtSubSoLuong.Text, CultureInfo.CurrentCulture);
            childItem.DonGia = decimal.Parse(txtSubDonGia.Text, CultureInfo.CurrentCulture);
            childItem.ThanhTien = decimal.Parse(txtSubThanhTien.Text, CultureInfo.CurrentCulture);

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
        private void frmNhapKho_Load(object sender, EventArgs e)
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
                    gridParrent.DataSource = dc.GetData("SELECT * FROM " + PBean.SCHEMA + ".view_ExpNhapKho order by NgayNhapKho asc");
                }
                else
                {
                    gridParrent.DataSource = dc.GetData("select * from " + PBean.SCHEMA + ".[view_ExpNhapKho] where TenSanPham like N'%" + searchText + "%' order by NgayNhapKho asc");
                }
                cmbFK_SanPham.DataSource = await _logic.GetMasterFK_SanPhamList();
                cmbFK_SanPham.DisplayMember = "TenSanPham";
                cmbFK_SanPham.ValueMember = "Id";
                cmbSubFK_VatTu.DataSource = await _logic.GetChildFK_VatTuList();
                cmbSubFK_VatTu.DisplayMember = "TenVatTu";
                cmbSubFK_VatTu.ValueMember = "Id";
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
                cmbFK_SanPham.Enabled = false;
                txtSoLuong.Enabled = false;
                txtDonGia.Enabled = false;
                txtThanhTien.Enabled = false;
                txtGhiChu.Enabled = false;
                cmbSubFK_VatTu.Enabled = false;
                txtSubSoLuong.Enabled = false;
                txtSubDonGia.Enabled = false;
                txtSubThanhTien.Enabled = false;
            }
            if (stus == enumAction.NEW)
            {
                btnNew.Enabled = true;
                btnNew.Text = "Bỏ qua";
                btnNewChild.Text = "Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                btnNewChild.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                cmbFK_SanPham.Enabled = true;
                txtSoLuong.Enabled = true;
                txtDonGia.Enabled = true;
                txtThanhTien.Enabled = true;
                txtGhiChu.Enabled = true;
                cmbSubFK_VatTu.Enabled = true;
                txtSubSoLuong.Enabled = true;
                txtSubDonGia.Enabled = true;
                txtSubThanhTien.Enabled = true;
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
                cmbFK_SanPham.Enabled = true;
                txtSoLuong.Enabled = true;
                txtDonGia.Enabled = true;
                txtThanhTien.Enabled = true;
                txtGhiChu.Enabled = true;
                cmbSubFK_VatTu.Enabled = true;
                txtSubSoLuong.Enabled = true;
                txtSubDonGia.Enabled = true;
                txtSubThanhTien.Enabled = true;
            }
        }
        // Xóa trắng tất cả các textbox.
        private void ClearText()
        {
            cmbFK_SanPham.SelectedValue = string.Empty;
            txtSoLuong.Text = "0";
            txtDonGia.Text = "0";
            txtThanhTien.Text = "0";
            txtGhiChu.Text = string.Empty;
        }
        private void ClearTextSubItem()
        {
            cmbSubFK_VatTu.SelectedValue = string.Empty;
            txtSubSoLuong.Text = string.Empty;
            txtSubDonGia.Text = string.Empty;
            txtSubThanhTien.Text = string.Empty;
        }
        private void FillDataChildItem(view_ExpNhapKhoCt item, bool copy)
        {
            cmbSubFK_VatTu.SelectedValue = item.FK_VatTu;
            txtSubSoLuong.Text = item.SoLuong.ToString();
            txtSubDonGia.Text = item.DonGia.ToString();
            txtSubThanhTien.Text = item.ThanhTien.ToString();

        }
        private void FillData(view_ExpNhapKho item, bool copy)
        {
            cmbFK_SanPham.SelectedValue = item.FK_SanPham;
            txtSoLuong.Text = item.SoLuong.ToString();
            txtDonGia.Text = item.DonGia.ToString();
            txtThanhTien.Text = item.ThanhTien.ToString();
            txtGhiChu.Text = item.GhiChu;
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
                string FK_NhapKho = Convert.ToString(gridChild.Rows[index].Cells["col_SubFK_NhapKho"].Value);
                string FK_VatTu = Convert.ToString(gridChild.Rows[index].Cells["col_SubFK_VatTu"].Value);
                GitemChild = await _logic.GetChildDetails(FK_NhapKho, FK_VatTu);
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
            if (cmbSubFK_VatTu.SelectedValue == null)
            {
                MessageBox.Show("FK_VatTu không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSubFK_VatTu.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubSoLuong.Text))
            {
                MessageBox.Show("SoLuong không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubSoLuong.Focus();
                return;
            }
            if (txtSubSoLuong.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("SoLuong không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubSoLuong.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubDonGia.Text))
            {
                MessageBox.Show("DonGia không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubDonGia.Focus();
                return;
            }
            if (txtSubDonGia.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("DonGia không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubDonGia.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubThanhTien.Text))
            {
                MessageBox.Show("ThanhTien không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubThanhTien.Focus();
                return;
            }
            if (txtSubThanhTien.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("ThanhTien không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubThanhTien.Focus();
                return;
            }
            // Edit child
            if (GitemChild != null)
            {

                childNhapKhoLogicInputDto childItem = new childNhapKhoLogicInputDto();
                childItem.FK_VatTu = cmbSubFK_VatTu.SelectedValue.ToString();
                childItem.SoLuong = decimal.Parse(txtSubSoLuong.Text, CultureInfo.CurrentCulture);
                childItem.DonGia = decimal.Parse(txtSubDonGia.Text, CultureInfo.CurrentCulture);
                childItem.ThanhTien = decimal.Parse(txtSubThanhTien.Text, CultureInfo.CurrentCulture);
                await _logic.CreateOrUpdateChildOnly(GitemChild.FK_NhapKho, GitemChild.FK_VatTu, childItem);
            }
            GitemChild = null;
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
                string FK_NhapKho = Convert.ToString(gridChild.Rows[index].Cells["col_SubFK_NhapKho"].Value);
                string FK_VatTu = Convert.ToString(gridChild.Rows[index].Cells["col_SubFK_VatTu"].Value);
                GCopyChild = GListITem.FirstOrDefault(u => u.FK_VatTu == FK_VatTu);
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private async void menuPasteChild_Click(object sender, EventArgs e)
        {
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
                    NhapKhoLogicInputDto parrentCopy = new NhapKhoLogicInputDto();
                    parrentCopy.FK_SanPham = GCopyParrent.FK_SanPham;
                    parrentCopy.SoLuong = GCopyParrent.SoLuong;
                    parrentCopy.DonGia = GCopyParrent.DonGia;
                    parrentCopy.ThanhTien = GCopyParrent.ThanhTien;
                    parrentCopy.GhiChu = GCopyParrent.GhiChu;
                    parrentCopy.lsExpNhapKhoCt = new List<childNhapKhoLogicInputDto>();
                    List<view_ExpNhapKhoCt> lsChild = await _logic.GetChildList(GCopyParrent.Id);
                    foreach (var item in lsChild)
                    {
                        childNhapKhoLogicInputDto child = new childNhapKhoLogicInputDto();
                        child.FK_NhapKho = item.FK_NhapKho;
                        child.FK_VatTu = item.FK_VatTu;
                        child.SoLuong = item.SoLuong;
                        child.DonGia = item.DonGia;
                        child.ThanhTien = item.ThanhTien;
                        parrentCopy.lsExpNhapKhoCt.Add(child);
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
        private void frmNhapKho_FormClosing(object sender, FormClosingEventArgs e)
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
        private void dtpNgayNhapKho_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtFK_NguoiNhapKho_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtFK_SanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }
        private void txtSoLuong_KeyUp(object sender, KeyEventArgs e)
        {
            base.Curency_KeyUp(sender, e);
        }
        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }
        private void txtDonGia_KeyUp(object sender, KeyEventArgs e)
        {
            base.Curency_KeyUp(sender, e);
        }
        private void txtThanhTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }
        private void txtThanhTien_KeyUp(object sender, KeyEventArgs e)
        {
            base.Curency_KeyUp(sender, e);
        }
        private void txtGhiChu_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSubFK_NhapKho_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSubFK_VatTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSubSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }
        private void txtSubSoLuong_KeyUp(object sender, KeyEventArgs e)
        {
            base.Curency_KeyUp(sender, e);
        }
        private void txtSubDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }
        private void txtSubDonGia_KeyUp(object sender, KeyEventArgs e)
        {
            base.Curency_KeyUp(sender, e);
        }
        private void txtSubThanhTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }
        private void txtSubThanhTien_KeyUp(object sender, KeyEventArgs e)
        {
            base.Curency_KeyUp(sender, e);
        }
        void TinhToanMaster(out decimal SoLuong, out decimal DonGia)
        {
            if (string.IsNullOrEmpty(txtSoLuong.Text.Trim()) == false && string.IsNullOrEmpty(txtDonGia.Text.Trim()) == false)
            {
                //decimal soLuong;
                //int DonGia;
                if (!decimal.TryParse(txtSoLuong.Text, out SoLuong))
                {
                    SoLuong = 0;
                }
                if (!decimal.TryParse(txtDonGia.Text.Replace(",", "").Trim(), out DonGia))
                {
                    DonGia = 0;
                }
                decimal ThanhTien = SoLuong * DonGia;
                txtThanhTien.Text = PCommon.FormatNumber(ThanhTien.ToString());
            }
            else
            {
                SoLuong = 0;
                DonGia = 0;
            }
        }

        void TinhToanChild(out decimal SoLuong, out decimal DonGia)
        {
            if (string.IsNullOrEmpty(txtSubSoLuong.Text.Trim()) == false && string.IsNullOrEmpty(txtSubDonGia.Text.Trim()) == false)
            {
                //decimal soLuong;
                //int DonGia;
                if (!decimal.TryParse(txtSubSoLuong.Text, out SoLuong))
                {
                    SoLuong = 0;
                }
                if (!decimal.TryParse(txtSubDonGia.Text.Replace(",", "").Trim(), out DonGia))
                {
                    DonGia = 0;
                }
                decimal ThanhTien = SoLuong * DonGia;
                txtSubThanhTien.Text = PCommon.FormatNumber(ThanhTien.ToString());
            }
            else
            {
                SoLuong = 0;
                DonGia = 0;
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            decimal SoLuong;
            decimal DonGia;
            TinhToanMaster(out SoLuong, out DonGia);
        }

        private void txtSubSoLuong_TextChanged(object sender, EventArgs e)
        {
            decimal SoLuong;
            decimal DonGia;
            TinhToanChild(out SoLuong, out DonGia);
        }

        private void btnNhapVatTu_Click(object sender, EventArgs e)
        {
            frmNhapVatTu frm = new frmNhapVatTu();
            frm.ShowDialog();
            LoadData();
        }
    }
}
