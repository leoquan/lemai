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
    public partial class frmQuanLyBangGia : frmBase
    {
        private enumAction status = enumAction.NONE;
        private enumEdit edited = enumEdit.NONE;
        private view_GExpFee Gitem;
        private view_GExpFee GCopyParrent;
        private List<view_GExpFeeDetails> GListITem = new List<view_GExpFeeDetails>();
        private view_GExpFeeDetails GitemChild;
        private view_GExpFeeDetails GCopyChild;
        private QuanLyBangGiaLogic _logic = new QuanLyBangGiaLogic(PBean.ConnectionBase);
        private GExpBillLogic _logicbill = new GExpBillLogic(PBean.ConnectionBase);
        public frmQuanLyBangGia() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
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
                DataTable data = dc.GetData("select * from " + PBean.SCHEMA + ".GExpFee");

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
                if (MessageBox.Show("Bạn có muốn xóa bảng giá [" + check.FeeName + "] không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            if (String.IsNullOrEmpty(txtFeeName.Text))
            {
                MessageBox.Show("Tên giá không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFeeName.Focus();
                return;
            }
            if (GListITem.Count() <= 0)
            {
                MessageBox.Show("Chưa nhập danh sách chi tiết bảng giá?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                QuanLyBangGiaLogicInputDto masterItem = new QuanLyBangGiaLogicInputDto();
                masterItem.FK_Post = PBean.USER.CardId;
                masterItem.FeeName = txtFeeName.Text;
                masterItem.DefaultFee = chbDefaultFee.Checked;
                foreach (var item in GListITem)
                {
                    childQuanLyBangGiaLogicInputDto childItem = new childQuanLyBangGiaLogicInputDto();
                    childItem.MinWeightMN = item.MinWeightMN;
                    childItem.MinWeightMT = item.MinWeightMT;
                    childItem.MinWeightMB = item.MinWeightMB;
                    childItem.MinFeeMN = item.MinFeeMN;
                    childItem.MinFeeMT = item.MinFeeMT;
                    childItem.MinFeeMB = item.MinFeeMB;
                    childItem.StepWeight = item.StepWeight;
                    childItem.NextFeeMN = item.NextFeeMN;
                    childItem.NextFeeMT = item.NextFeeMT;
                    childItem.NextFeeMB = item.NextFeeMB;
                    childItem.MinWeightInt = item.MinWeightInt;
                    childItem.MinFeeInt = item.MinFeeInt;
                    childItem.NextFeeInt = item.NextFeeInt;
                    childItem.StepWeightInt = item.StepWeightInt;
                    childItem.StepWeightMB = item.StepWeightMB;
                    childItem.StepWeightMT = item.StepWeightMT;
                    childItem.StepWeightMN = item.StepWeightMN;
                    masterItem.lsGExpFeeDetail.Add(childItem);
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
                view_GExpFeeDetails childItem = await _logic.GetChildDetails(Id);
                if (null != childItem)
                {
                    if (MessageBox.Show("Bạn có muốn xóa chi tiết không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            txtSubMinWeightInt.Focus();
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
                GListITem = new List<view_GExpFeeDetails>();
                LoadDataChildItem();
                tabControl.SelectedIndex = 1;
            }
        }
        private void AddItem()
        {
            //Add sub item
            if (String.IsNullOrEmpty(txtSubMinWeightMN.Text))
            {
                MessageBox.Show("MinWeightMN không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubMinWeightMN.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubMinWeightMT.Text))
            {
                MessageBox.Show("MinWeightMT không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubMinWeightMT.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubMinWeightMB.Text))
            {
                MessageBox.Show("MinWeightMB không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubMinWeightMB.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubMinFeeMN.Text))
            {
                MessageBox.Show("MinFeeMN không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubMinFeeMN.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubMinFeeMT.Text))
            {
                MessageBox.Show("MinFeeMT không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubMinFeeMT.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubMinFeeMB.Text))
            {
                MessageBox.Show("MinFeeMB không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubMinFeeMB.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtSubNextFeeMN.Text))
            {
                MessageBox.Show("NextFeeMN không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubNextFeeMN.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubNextFeeMT.Text))
            {
                MessageBox.Show("NextFeeMT không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubNextFeeMT.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubNextFeeMB.Text))
            {
                MessageBox.Show("NextFeeMB không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubNextFeeMB.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubMinWeightInt.Text))
            {
                MessageBox.Show("MinWeightInt không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubMinWeightInt.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubMinFeeInt.Text))
            {
                MessageBox.Show("MinFeeInt không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubMinFeeInt.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubNextFeeInt.Text))
            {
                MessageBox.Show("NextFeeInt không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubNextFeeInt.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubStepWeightInt.Text))
            {
                MessageBox.Show("StepWeightInt không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubStepWeightInt.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubStepWeightMB.Text))
            {
                MessageBox.Show("StepWeightMB không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubStepWeightMB.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubStepWeightMT.Text))
            {
                MessageBox.Show("StepWeightMT không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubStepWeightMT.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubStepWeightMN.Text))
            {
                MessageBox.Show("StepWeightMN không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubStepWeightMN.Focus();
                return;
            }

            view_GExpFeeDetails childItem = new view_GExpFeeDetails();
            childItem.MinWeightMN = Int32.Parse(txtSubMinWeightMN.Text, System.Globalization.NumberStyles.AllowThousands);
            childItem.MinWeightMT = Int32.Parse(txtSubMinWeightMT.Text, System.Globalization.NumberStyles.AllowThousands);
            childItem.MinWeightMB = Int32.Parse(txtSubMinWeightMB.Text, System.Globalization.NumberStyles.AllowThousands);
            childItem.MinFeeMN = Int32.Parse(txtSubMinFeeMN.Text, System.Globalization.NumberStyles.AllowThousands);
            childItem.MinFeeMT = Int32.Parse(txtSubMinFeeMT.Text, System.Globalization.NumberStyles.AllowThousands);
            childItem.MinFeeMB = Int32.Parse(txtSubMinFeeMB.Text, System.Globalization.NumberStyles.AllowThousands);
            childItem.StepWeight = 1000;
            childItem.NextFeeMN = Int32.Parse(txtSubNextFeeMN.Text, System.Globalization.NumberStyles.AllowThousands);
            childItem.NextFeeMT = Int32.Parse(txtSubNextFeeMT.Text, System.Globalization.NumberStyles.AllowThousands);
            childItem.NextFeeMB = Int32.Parse(txtSubNextFeeMB.Text, System.Globalization.NumberStyles.AllowThousands);
            childItem.MinWeightInt = Int32.Parse(txtSubMinWeightInt.Text, System.Globalization.NumberStyles.AllowThousands);
            childItem.MinFeeInt = Int32.Parse(txtSubMinFeeInt.Text, System.Globalization.NumberStyles.AllowThousands);
            childItem.NextFeeInt = Int32.Parse(txtSubNextFeeInt.Text, System.Globalization.NumberStyles.AllowThousands);
            childItem.StepWeightInt = Int32.Parse(txtSubStepWeightInt.Text, System.Globalization.NumberStyles.AllowThousands);
            childItem.StepWeightMB = Int32.Parse(txtSubStepWeightMB.Text, System.Globalization.NumberStyles.AllowThousands);
            childItem.StepWeightMT = Int32.Parse(txtSubStepWeightMT.Text, System.Globalization.NumberStyles.AllowThousands);
            childItem.StepWeightMN = Int32.Parse(txtSubStepWeightMN.Text, System.Globalization.NumberStyles.AllowThousands);

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
        private void frmQuanLyBangGia_Load(object sender, EventArgs e)
        {
            LoadData();
            EnableButton(status);
            LoadConfig();
        }
        private async void LoadConfig()
        {
            cmbBangGia.DataSource =await _logic.GetFeeList(PBean.USER.CardId);
            cmbBangGia.DisplayMember = "FeeName";
            cmbBangGia.ValueMember = "Id";

            cmbTinh.DataSource =await _logicbill.GetDanhSachTinh();
            cmbTinh.DisplayMember = "ProvinceName";
            cmbTinh.ValueMember = "ProvinceID";

            cmbHuyen.DataSource = await _logicbill.GetDanhSachHuyen(cmbTinh.SelectedValue.ToString());
            cmbHuyen.DisplayMember = "DistrictName";
            cmbHuyen.ValueMember = "DistrictID";

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
                    gridParrent.DataSource = dc.GetData("SELECT * FROM " + PBean.SCHEMA + ".view_GExpFee WHERE FK_Post='" + PBean.USER.CardId + "' order by DefaultFee desc, FeeName asc");
                }
                else
                {
                    gridParrent.DataSource = dc.GetData("select * FROM " + PBean.SCHEMA + ".[view_GExpFee] WHERE FK_Post='" + PBean.USER.CardId + "' AND FeeName like N'%" + searchText + "%' order by DefaultFee desc, FeeName asc");
                }
                cmbBangGia.DataSource = await _logic.GetFeeList(PBean.USER.CardId);
                cmbBangGia.DisplayMember = "FeeName";
                cmbBangGia.ValueMember = "Id";
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
                txtFeeName.Enabled = false;
                chbDefaultFee.Enabled = false;
                txtSubMinWeightMN.Enabled = false;
                txtSubMinWeightMT.Enabled = false;
                txtSubMinWeightMB.Enabled = false;
                txtSubMinFeeMN.Enabled = false;
                txtSubMinFeeMT.Enabled = false;
                txtSubMinFeeMB.Enabled = false;
                txtSubNextFeeMN.Enabled = false;
                txtSubNextFeeMT.Enabled = false;
                txtSubNextFeeMB.Enabled = false;
                txtSubMinWeightInt.Enabled = false;
                txtSubMinFeeInt.Enabled = false;
                txtSubNextFeeInt.Enabled = false;
                txtSubStepWeightInt.Enabled = false;
                txtSubStepWeightMB.Enabled = false;
                txtSubStepWeightMT.Enabled = false;
                txtSubStepWeightMN.Enabled = false;
            }
            if (stus == enumAction.NEW)
            {
                btnNew.Enabled = true;
                btnNew.Text = "Bỏ qua";
                btnNewChild.Text = "Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                btnNewChild.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                txtFeeName.Enabled = true;
                chbDefaultFee.Enabled = true;
                txtSubMinWeightMN.Enabled = true;
                txtSubMinWeightMT.Enabled = true;
                txtSubMinWeightMB.Enabled = true;
                txtSubMinFeeMN.Enabled = true;
                txtSubMinFeeMT.Enabled = true;
                txtSubMinFeeMB.Enabled = true;
                txtSubNextFeeMN.Enabled = true;
                txtSubNextFeeMT.Enabled = true;
                txtSubNextFeeMB.Enabled = true;
                txtSubMinWeightInt.Enabled = true;
                txtSubMinFeeInt.Enabled = true;
                txtSubNextFeeInt.Enabled = true;
                txtSubStepWeightInt.Enabled = true;
                txtSubStepWeightMB.Enabled = true;
                txtSubStepWeightMT.Enabled = true;
                txtSubStepWeightMN.Enabled = true;
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
                txtFeeName.Enabled = true;
                chbDefaultFee.Enabled = true;
                txtSubMinWeightMN.Enabled = true;
                txtSubMinWeightMT.Enabled = true;
                txtSubMinWeightMB.Enabled = true;
                txtSubMinFeeMN.Enabled = true;
                txtSubMinFeeMT.Enabled = true;
                txtSubMinFeeMB.Enabled = true;
                txtSubNextFeeMN.Enabled = true;
                txtSubNextFeeMT.Enabled = true;
                txtSubNextFeeMB.Enabled = true;
                txtSubMinWeightInt.Enabled = true;
                txtSubMinFeeInt.Enabled = true;
                txtSubNextFeeInt.Enabled = true;
                txtSubStepWeightInt.Enabled = true;
                txtSubStepWeightMB.Enabled = true;
                txtSubStepWeightMT.Enabled = true;
                txtSubStepWeightMN.Enabled = true;
            }
        }
        // Xóa trắng tất cả các textbox.
        private void ClearText()
        {
            txtFeeName.Text = string.Empty;
            chbDefaultFee.Checked = false;
        }
        private void ClearTextSubItem()
        {
            txtSubMinWeightMN.Text = "0";
            txtSubMinWeightMT.Text = "0";
            txtSubMinWeightMB.Text = "0";
            txtSubMinWeightInt.Text = "0";

            txtSubMinFeeMN.Text = "0";
            txtSubMinFeeMT.Text = "0";
            txtSubMinFeeMB.Text = "0";
            txtSubMinFeeInt.Text = "0";

            txtSubNextFeeMN.Text = "0";
            txtSubNextFeeMT.Text = "0";
            txtSubNextFeeMB.Text = "0";
            txtSubNextFeeInt.Text = "0";

            txtSubStepWeightInt.Text = "0";
            txtSubStepWeightMB.Text = "0";
            txtSubStepWeightMT.Text = "0";
            txtSubStepWeightMN.Text = "0";
        }
        private void FillDataChildItem(view_GExpFeeDetails item, bool copy)
        {
            txtSubMinWeightMN.Text = item.MinWeightMN.ToString();
            txtSubMinWeightMT.Text = item.MinWeightMT.ToString();
            txtSubMinWeightMB.Text = item.MinWeightMB.ToString();
            txtSubMinFeeMN.Text = item.MinFeeMN.ToString();
            txtSubMinFeeMT.Text = item.MinFeeMT.ToString();
            txtSubMinFeeMB.Text = item.MinFeeMB.ToString();
            txtSubNextFeeMN.Text = item.NextFeeMN.ToString();
            txtSubNextFeeMT.Text = item.NextFeeMT.ToString();
            txtSubNextFeeMB.Text = item.NextFeeMB.ToString();
            txtSubMinWeightInt.Text = item.MinWeightInt.ToString();
            txtSubMinFeeInt.Text = item.MinFeeInt.ToString();
            txtSubNextFeeInt.Text = item.NextFeeInt.ToString();
            txtSubStepWeightInt.Text = item.StepWeightInt.ToString();
            txtSubStepWeightMB.Text = item.StepWeightMB.ToString();
            txtSubStepWeightMT.Text = item.StepWeightMT.ToString();
            txtSubStepWeightMN.Text = item.StepWeightMN.ToString();

        }
        private void FillData(view_GExpFee item, bool copy)
        {

            txtFeeName.Text = item.FeeName;
            chbDefaultFee.Checked = item.DefaultFee;
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
            if (String.IsNullOrEmpty(txtSubMinWeightMN.Text))
            {
                MessageBox.Show("MinWeightMN không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubMinWeightMN.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubMinWeightMT.Text))
            {
                MessageBox.Show("MinWeightMT không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubMinWeightMT.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubMinWeightMB.Text))
            {
                MessageBox.Show("MinWeightMB không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubMinWeightMB.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubMinFeeMN.Text))
            {
                MessageBox.Show("MinFeeMN không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubMinFeeMN.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubMinFeeMT.Text))
            {
                MessageBox.Show("MinFeeMT không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubMinFeeMT.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubMinFeeMB.Text))
            {
                MessageBox.Show("MinFeeMB không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubMinFeeMB.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubNextFeeMN.Text))
            {
                MessageBox.Show("NextFeeMN không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubNextFeeMN.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubNextFeeMT.Text))
            {
                MessageBox.Show("NextFeeMT không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubNextFeeMT.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubNextFeeMB.Text))
            {
                MessageBox.Show("NextFeeMB không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubNextFeeMB.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubMinWeightInt.Text))
            {
                MessageBox.Show("MinWeightInt không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubMinWeightInt.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubMinFeeInt.Text))
            {
                MessageBox.Show("MinFeeInt không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubMinFeeInt.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubNextFeeInt.Text))
            {
                MessageBox.Show("NextFeeInt không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubNextFeeInt.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubStepWeightInt.Text))
            {
                MessageBox.Show("StepWeightInt không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubStepWeightInt.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubStepWeightMB.Text))
            {
                MessageBox.Show("StepWeightMB không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubStepWeightMB.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubStepWeightMT.Text))
            {
                MessageBox.Show("StepWeightMT không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubStepWeightMT.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubStepWeightMN.Text))
            {
                MessageBox.Show("StepWeightMN không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubStepWeightMN.Focus();
                return;
            }
            // Edit child
            if (GitemChild != null)
            {
                childQuanLyBangGiaLogicInputDto childItem = new childQuanLyBangGiaLogicInputDto();
                childItem.MinWeightMN = Int32.Parse(txtSubMinWeightMN.Text, System.Globalization.NumberStyles.AllowThousands);
                childItem.MinWeightMT = Int32.Parse(txtSubMinWeightMT.Text, System.Globalization.NumberStyles.AllowThousands);
                childItem.MinWeightMB = Int32.Parse(txtSubMinWeightMB.Text, System.Globalization.NumberStyles.AllowThousands);
                childItem.MinFeeMN = Int32.Parse(txtSubMinFeeMN.Text, System.Globalization.NumberStyles.AllowThousands);
                childItem.MinFeeMT = Int32.Parse(txtSubMinFeeMT.Text, System.Globalization.NumberStyles.AllowThousands);
                childItem.MinFeeMB = Int32.Parse(txtSubMinFeeMB.Text, System.Globalization.NumberStyles.AllowThousands);
                childItem.NextFeeMN = Int32.Parse(txtSubNextFeeMN.Text, System.Globalization.NumberStyles.AllowThousands);
                childItem.NextFeeMT = Int32.Parse(txtSubNextFeeMT.Text, System.Globalization.NumberStyles.AllowThousands);
                childItem.NextFeeMB = Int32.Parse(txtSubNextFeeMB.Text, System.Globalization.NumberStyles.AllowThousands);
                childItem.MinWeightInt = Int32.Parse(txtSubMinWeightInt.Text, System.Globalization.NumberStyles.AllowThousands);
                childItem.MinFeeInt = Int32.Parse(txtSubMinFeeInt.Text, System.Globalization.NumberStyles.AllowThousands);
                childItem.NextFeeInt = Int32.Parse(txtSubNextFeeInt.Text, System.Globalization.NumberStyles.AllowThousands);
                childItem.StepWeightInt = Int32.Parse(txtSubStepWeightInt.Text, System.Globalization.NumberStyles.AllowThousands);
                childItem.StepWeightMB = Int32.Parse(txtSubStepWeightMB.Text, System.Globalization.NumberStyles.AllowThousands);
                childItem.StepWeightMT = Int32.Parse(txtSubStepWeightMT.Text, System.Globalization.NumberStyles.AllowThousands);
                childItem.StepWeightMN = Int32.Parse(txtSubStepWeightMN.Text, System.Globalization.NumberStyles.AllowThousands);
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
                childQuanLyBangGiaLogicInputDto childItem = new childQuanLyBangGiaLogicInputDto();
                childItem.FK_GExpFee = GCopyChild.FK_GExpFee;
                childItem.MinWeightMN = GCopyChild.MinWeightMN;
                childItem.MinWeightMT = GCopyChild.MinWeightMT;
                childItem.MinWeightMB = GCopyChild.MinWeightMB;
                childItem.MinFeeMN = GCopyChild.MinFeeMN;
                childItem.MinFeeMT = GCopyChild.MinFeeMT;
                childItem.MinFeeMB = GCopyChild.MinFeeMB;
                childItem.StepWeight = GCopyChild.StepWeight;
                childItem.NextFeeMN = GCopyChild.NextFeeMN;
                childItem.NextFeeMT = GCopyChild.NextFeeMT;
                childItem.NextFeeMB = GCopyChild.NextFeeMB;
                childItem.MinWeightInt = GCopyChild.MinWeightInt;
                childItem.MinFeeInt = GCopyChild.MinFeeInt;
                childItem.NextFeeInt = GCopyChild.NextFeeInt;
                childItem.StepWeightInt = GCopyChild.StepWeightInt;
                childItem.StepWeightMB = GCopyChild.StepWeightMB;
                childItem.StepWeightMT = GCopyChild.StepWeightMT;
                childItem.StepWeightMN = GCopyChild.StepWeightMN;
                view_GExpFeeDetails copyNew = await _logic.CreateOrUpdateChildOnly(GCopyChild.Id, childItem);
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
                    QuanLyBangGiaLogicInputDto parrentCopy = new QuanLyBangGiaLogicInputDto();
                    parrentCopy.FK_Post = GCopyParrent.FK_Post;
                    parrentCopy.FeeName = GCopyParrent.FeeName;
                    parrentCopy.DefaultFee = GCopyParrent.DefaultFee;
                    parrentCopy.lsGExpFeeDetail = new List<childQuanLyBangGiaLogicInputDto>();
                    List<view_GExpFeeDetails> lsChild = await _logic.GetChildList(GCopyParrent.Id);
                    foreach (var item in lsChild)
                    {
                        childQuanLyBangGiaLogicInputDto child = new childQuanLyBangGiaLogicInputDto();
                        child.MinWeightMN = item.MinWeightMN;
                        child.MinWeightMT = item.MinWeightMT;
                        child.MinWeightMB = item.MinWeightMB;
                        child.MinFeeMN = item.MinFeeMN;
                        child.MinFeeMT = item.MinFeeMT;
                        child.MinFeeMB = item.MinFeeMB;
                        child.StepWeight = item.StepWeight;
                        child.NextFeeMN = item.NextFeeMN;
                        child.NextFeeMT = item.NextFeeMT;
                        child.NextFeeMB = item.NextFeeMB;
                        child.MinWeightInt = item.MinWeightInt;
                        child.MinFeeInt = item.MinFeeInt;
                        child.NextFeeInt = item.NextFeeInt;
                        child.StepWeightInt = item.StepWeightInt;
                        child.StepWeightMB = item.StepWeightMB;
                        child.StepWeightMT = item.StepWeightMT;
                        child.StepWeightMN = item.StepWeightMN;
                        parrentCopy.lsGExpFeeDetail.Add(child);
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
        private void frmQuanLyBangGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (edited != enumEdit.NONE)
            {
                DialogResult dialogResult = MessageBox.Show("Dữ liệu có sự thay đổi, bạn có chắc muốn thoát?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo);
                e.Cancel = (dialogResult == DialogResult.No);
            }
        }
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtFK_Post_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtFeeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSubId_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSubFK_GExpFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSubMinWeightMN_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSubMinWeightMN_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtSubMinWeightMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSubMinWeightMT_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtSubMinWeightMB_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSubMinWeightMB_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtSubMinFeeMN_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSubMinFeeMN_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtSubMinFeeMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSubMinFeeMT_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtSubMinFeeMB_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSubMinFeeMB_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtSubStepWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSubStepWeight_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtSubNextFeeMN_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSubNextFeeMN_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtSubNextFeeMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSubNextFeeMT_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtSubNextFeeMB_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSubNextFeeMB_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtSubMinWeightInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSubMinWeightInt_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtSubMinFeeInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSubMinFeeInt_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtSubNextFeeInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSubNextFeeInt_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtSubStepWeightInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSubStepWeightInt_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtSubStepWeightMB_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSubStepWeightMB_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtSubStepWeightMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSubStepWeightMT_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtSubStepWeightMN_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSubStepWeightMN_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }

        private void btnGiaKV_Click(object sender, EventArgs e)
        {
            if (Gitem != null && string.IsNullOrEmpty(Gitem.Id) != true)
            {
                frmQuanLyBangGiaKV frm = new frmQuanLyBangGiaKV();
                frm.FeeId = Gitem.Id;
                frm.FeeName = Gitem.FeeName;
                frm.ShowDialog();
            }

        }

        private async void btnKiemTra_Click(object sender, EventArgs e)
        {
            // Kiểm tra
            lblCheckGia.Text = await _logicbill.GetCalculatorFee(txtCanNang.Text,cmbBangGia.SelectedValue.ToString(), cmbTinh.SelectedValue.ToString(), PBean.USER.CardId, cmbHuyen.SelectedValue.ToString());
        }

        private async void cmbTinh_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                cmbHuyen.DataSource = await _logicbill.GetDanhSachHuyen(cmbTinh.SelectedValue.ToString());
                cmbHuyen.DisplayMember = "DistrictName";
                cmbHuyen.ValueMember = "DistrictID";
            }
        }

        private void txtCanNang_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }

        private void txtCanNang_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }

        private void txtSubMinWeightInt_TextChanged(object sender, EventArgs e)
        {
            if(ActiveControl==sender)
            {
                txtSubMinWeightMN.Text = txtSubMinWeightInt.Text;
                txtSubMinWeightMT.Text = txtSubMinWeightInt.Text;
                txtSubMinWeightMB.Text = txtSubMinWeightInt.Text;
            }    
        }

        private void txtSubMinFeeInt_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                txtSubMinFeeMN.Text = txtSubMinFeeInt.Text;
                txtSubMinFeeMT.Text = txtSubMinFeeInt.Text;
                txtSubMinFeeMB.Text = txtSubMinFeeInt.Text;
            }    
        }

        private void txtSubStepWeightInt_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                txtSubStepWeightMN.Text = txtSubStepWeightInt.Text;
                txtSubStepWeightMT.Text = txtSubStepWeightInt.Text;
                txtSubStepWeightMB.Text = txtSubStepWeightInt.Text;
            }    
                
        }

        private void txtSubNextFeeInt_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                txtSubNextFeeMN.Text = txtSubNextFeeInt.Text;
                txtSubNextFeeMT.Text = txtSubNextFeeInt.Text;
                txtSubNextFeeMB.Text = txtSubNextFeeInt.Text;
            }
                
        }
    }
}
