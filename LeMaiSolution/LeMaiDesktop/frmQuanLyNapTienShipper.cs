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
    public partial class frmQuanLyNapTienShipper : frmBase
    {
        private enumAction status = enumAction.NONE;
        private enumEdit edited = enumEdit.NONE;
        private view_GExpShipperCash Gitem;
        private view_GExpShipperCash GCopyParrent;
        private List<view_GExpShipperCashDetail> GListITem = new List<view_GExpShipperCashDetail>();
        private view_GExpShipperCashDetail GitemChild;
        private view_GExpShipperCashDetail GCopyChild;
        private QuanLyNapTienShipperLogic _logic = new QuanLyNapTienShipperLogic(PBean.ConnectionBase);
        public frmQuanLyNapTienShipper() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
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
                DataTable data = dc.GetData("select * from " + PBean.SCHEMA + ".GExpShipperCash");

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
            if (String.IsNullOrEmpty(txtTotalCash.Text))
            {
                MessageBox.Show("TotalCash không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotalCash.Focus();
                return;
            }
            if (txtTotalCash.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("TotalCash không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotalCash.Focus();
                return;
            }
            if (GListITem.Count() <= 0)
            {
                MessageBox.Show("Chưa nhập danh sách chi tiết đơn hàng?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                QuanLyNapTienShipperLogicInputDto masterItem = new QuanLyNapTienShipperLogicInputDto();
                masterItem.FK_Shipper = cmbFK_Shipper.SelectedValue.ToString();
                masterItem.FK_Account = PBean.USER.Id;
                masterItem.TotalCash = decimal.Parse(txtTotalCash.Text, CultureInfo.CurrentCulture);
                masterItem.FK_Post = PBean.USER.Id;
                foreach (var item in GListITem)
                {
                    childQuanLyNapTienShipperLogicInputDto childItem = new childQuanLyNapTienShipperLogicInputDto();
                    childItem.Id = item.Id;
                    childItem.BillCode = item.BillCode;
                    childItem.MoneyValue = item.MoneyValue;
                    childItem.Freight = item.Freight;
                    childItem.COD = item.COD;
                    childItem.PayMentType = item.PayMentType;
                    masterItem.lsGExpShipperCashDetail.Add(childItem);
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
                view_GExpShipperCashDetail childItem = await _logic.GetChildDetails(Id);
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
                GListITem = new List<view_GExpShipperCashDetail>();
                LoadDataChildItem();
                tabControl.SelectedIndex = 1;
            }
        }
        private void AddItem()
        {
            //Add sub item
            if (String.IsNullOrEmpty(txtSubId.Text))
            {
                MessageBox.Show("Id không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubId.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubBillCode.Text))
            {
                MessageBox.Show("BillCode không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubBillCode.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubMoneyValue.Text))
            {
                MessageBox.Show("MoneyValue không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubMoneyValue.Focus();
                return;
            }
            if (txtSubMoneyValue.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("MoneyValue không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubMoneyValue.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubFreight.Text))
            {
                MessageBox.Show("Freight không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubFreight.Focus();
                return;
            }
            if (txtSubFreight.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("Freight không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubFreight.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubCOD.Text))
            {
                MessageBox.Show("COD không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubCOD.Focus();
                return;
            }
            if (txtSubCOD.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("COD không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubCOD.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubPayMentType.Text))
            {
                MessageBox.Show("PayMentType không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubPayMentType.Focus();
                return;
            }

            view_GExpShipperCashDetail childItem = new view_GExpShipperCashDetail();
            childItem.Id = txtSubId.Text;
            childItem.BillCode = txtSubBillCode.Text;
            childItem.MoneyValue = decimal.Parse(txtSubMoneyValue.Text, CultureInfo.CurrentCulture);
            childItem.Freight = decimal.Parse(txtSubFreight.Text, CultureInfo.CurrentCulture);
            childItem.COD = decimal.Parse(txtSubCOD.Text, CultureInfo.CurrentCulture);
            childItem.PayMentType = txtSubPayMentType.Text;

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
        private void frmQuanLyNapTienShipper_Load(object sender, EventArgs e)
        {
            LoadData();
            EnableButton(status);
        }

        private void LoadData(string searchText = "")
        {
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                gridParrent.AutoGenerateColumns = false;
                if (string.IsNullOrEmpty(searchText))
                {
                    gridParrent.DataSource = dc.GetData("SELECT * FROM " + PBean.SCHEMA + ".view_GExpShipperCash order by CreateDate asc");
                }
                else
                {
                    gridParrent.DataSource = dc.GetData("select * from " + PBean.SCHEMA + ".[view_GExpShipperCash] where ShipperName like N'%" + searchText + "%' or ShipperPhone like N'%" + searchText + "%' order by CreateDate asc");
                }
                cmbFK_Shipper.DataSource = _logic.GetMasterFK_ShipperList();
                cmbFK_Shipper.DisplayMember = "ShipperName";
                cmbFK_Shipper.ValueMember = "Id";
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
                cmbFK_Shipper.Enabled = false;
                txtTotalCash.Enabled = false;
                txtSubId.Enabled = false;
                txtSubBillCode.Enabled = false;
                txtSubMoneyValue.Enabled = false;
                txtSubFreight.Enabled = false;
                txtSubCOD.Enabled = false;
                txtSubPayMentType.Enabled = false;
            }
            if (stus == enumAction.NEW)
            {
                btnNew.Enabled = true;
                btnNew.Text = "Bỏ qua";
                btnNewChild.Text = "Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                btnNewChild.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                cmbFK_Shipper.Enabled = true;
                txtTotalCash.Enabled = true;
                txtSubId.Enabled = true;
                txtSubBillCode.Enabled = true;
                txtSubMoneyValue.Enabled = true;
                txtSubFreight.Enabled = true;
                txtSubCOD.Enabled = true;
                txtSubPayMentType.Enabled = true;
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
                cmbFK_Shipper.Enabled = true;
                txtTotalCash.Enabled = true;
                txtSubId.Enabled = true;
                txtSubBillCode.Enabled = true;
                txtSubMoneyValue.Enabled = true;
                txtSubFreight.Enabled = true;
                txtSubCOD.Enabled = true;
                txtSubPayMentType.Enabled = true;
            }
        }
        // Xóa trắng tất cả các textbox.
        private void ClearText()
        {
            cmbFK_Shipper.SelectedValue = string.Empty;
            txtTotalCash.Text = "0";
        }
        private void ClearTextSubItem()
        {
            txtSubId.Text = string.Empty;
            txtSubBillCode.Text = string.Empty;
            txtSubMoneyValue.Text = string.Empty;
            txtSubFreight.Text = string.Empty;
            txtSubCOD.Text = string.Empty;
            txtSubPayMentType.Text = string.Empty;
        }
        private void FillDataChildItem(view_GExpShipperCashDetail item, bool copy)
        {
            txtSubId.Text = item.Id;
            txtSubBillCode.Text = item.BillCode;
            txtSubMoneyValue.Text = item.MoneyValue.ToString();
            txtSubFreight.Text = item.Freight.ToString();
            txtSubCOD.Text = item.COD.ToString();
            txtSubPayMentType.Text = item.PayMentType;

        }
        private void FillData(view_GExpShipperCash item, bool copy)
        {
            cmbFK_Shipper.SelectedValue = item.FK_Shipper;
            txtTotalCash.Text = item.TotalCash.ToString();
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
            if (String.IsNullOrEmpty(txtSubId.Text))
            {
                MessageBox.Show("Id không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubId.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubBillCode.Text))
            {
                MessageBox.Show("BillCode không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubBillCode.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubMoneyValue.Text))
            {
                MessageBox.Show("MoneyValue không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubMoneyValue.Focus();
                return;
            }
            if (txtSubMoneyValue.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("MoneyValue không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubMoneyValue.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubFreight.Text))
            {
                MessageBox.Show("Freight không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubFreight.Focus();
                return;
            }
            if (txtSubFreight.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("Freight không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubFreight.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubCOD.Text))
            {
                MessageBox.Show("COD không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubCOD.Focus();
                return;
            }
            if (txtSubCOD.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("COD không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubCOD.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubPayMentType.Text))
            {
                MessageBox.Show("PayMentType không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubPayMentType.Focus();
                return;
            }
            // Edit child
            if (GitemChild != null)
            {

                childQuanLyNapTienShipperLogicInputDto childItem = new childQuanLyNapTienShipperLogicInputDto();
                childItem.Id = txtSubId.Text;
                childItem.BillCode = txtSubBillCode.Text;
                childItem.MoneyValue = decimal.Parse(txtSubMoneyValue.Text, CultureInfo.CurrentCulture);
                childItem.Freight = decimal.Parse(txtSubFreight.Text, CultureInfo.CurrentCulture);
                childItem.COD = decimal.Parse(txtSubCOD.Text, CultureInfo.CurrentCulture);
                childItem.PayMentType = txtSubPayMentType.Text;
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
                childQuanLyNapTienShipperLogicInputDto childItem = new childQuanLyNapTienShipperLogicInputDto();
                childItem.Id = GCopyChild.Id;
                childItem.BillCode = GCopyChild.BillCode;
                childItem.MoneyValue = GCopyChild.MoneyValue;
                childItem.Freight = GCopyChild.Freight;
                childItem.COD = GCopyChild.COD;
                childItem.PayMentType = GCopyChild.PayMentType;
                childItem.FK_CashShipper = GCopyChild.FK_CashShipper;
                view_GExpShipperCashDetail copyNew = await _logic.CreateOrUpdateChildOnly(GCopyChild.Id, childItem);
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
                    QuanLyNapTienShipperLogicInputDto parrentCopy = new QuanLyNapTienShipperLogicInputDto();
                    parrentCopy.FK_Shipper = GCopyParrent.FK_Shipper;
                    parrentCopy.TotalCash = GCopyParrent.TotalCash;
                    parrentCopy.lsGExpShipperCashDetail = new List<childQuanLyNapTienShipperLogicInputDto>();
                    List<view_GExpShipperCashDetail> lsChild = await _logic.GetChildList(GCopyParrent.Id);
                    foreach (var item in lsChild)
                    {
                        childQuanLyNapTienShipperLogicInputDto child = new childQuanLyNapTienShipperLogicInputDto();
                        child.Id = item.Id;
                        child.BillCode = item.BillCode;
                        child.MoneyValue = item.MoneyValue;
                        child.Freight = item.Freight;
                        child.COD = item.COD;
                        child.PayMentType = item.PayMentType;
                        parrentCopy.lsGExpShipperCashDetail.Add(child);
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
        private void frmQuanLyNapTienShipper_FormClosing(object sender, FormClosingEventArgs e)
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
        private void txtFK_Shipper_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void dtpCreateDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtFK_Account_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtTotalCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }
        private void txtTotalCash_KeyUp(object sender, KeyEventArgs e)
        {
            base.Curency_KeyUp(sender, e);
        }
        private void txtFK_Post_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSubId_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSubBillCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSubMoneyValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }
        private void txtSubMoneyValue_KeyUp(object sender, KeyEventArgs e)
        {
            base.Curency_KeyUp(sender, e);
        }
        private void txtSubFreight_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }
        private void txtSubFreight_KeyUp(object sender, KeyEventArgs e)
        {
            base.Curency_KeyUp(sender, e);
        }
        private void txtSubCOD_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }
        private void txtSubCOD_KeyUp(object sender, KeyEventArgs e)
        {
            base.Curency_KeyUp(sender, e);
        }
        private void txtSubPayMentType_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSubFK_CashShipper_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }

    }
}
