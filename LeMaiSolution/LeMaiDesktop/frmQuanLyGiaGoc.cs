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
    public partial class frmQuanLyGiaGoc : frmBase
    {
        private QuanLyGiaGocLogic _logic = new QuanLyGiaGocLogic(PBean.ConnectionBase);
        private enumAction status = enumAction.NONE;
        private view_GExpFeeDebitSession Gitem;

        public frmQuanLyGiaGoc() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            gridMain.AutoGenerateColumns = false;
            this.gridMain.RowTemplate.MinimumHeight = 22;
            Separator();
        }

        private void frmQuanLyGiaGoc_Load(object sender, EventArgs e)
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
                cmbFK_Post.Enabled = false;
                txtMinWeightMN.Enabled = false;
                txtMinWeightMT.Enabled = false;
                txtMinWeightMB.Enabled = false;
                txtMinFeeMN.Enabled = false;
                txtMinFeeMT.Enabled = false;
                txtMinFeeMB.Enabled = false;
                txtNextFeeMN.Enabled = false;
                txtNextFeeMT.Enabled = false;
                txtNextFeeMB.Enabled = false;
                txtMinWeightInt.Enabled = false;
                txtMinFeeInt.Enabled = false;
                txtNextFeeInt.Enabled = false;
                txtStepWeightInt.Enabled = false;
                txtStepWeightMB.Enabled = false;
                txtStepWeightMT.Enabled = false;
                txtStepWeightMN.Enabled = false;
                chbReturnFee.Enabled = false;
                txtInsurance.Enabled = false;
                txtCODFee.Enabled = false;
            }
            if (stus == enumAction.NEW)
            {
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                cmbFK_Post.Enabled = true;
                txtMinWeightMN.Enabled = true;
                txtMinWeightMT.Enabled = true;
                txtMinWeightMB.Enabled = true;
                txtMinFeeMN.Enabled = true;
                txtMinFeeMT.Enabled = true;
                txtMinFeeMB.Enabled = true;
                txtNextFeeMN.Enabled = true;
                txtNextFeeMT.Enabled = true;
                txtNextFeeMB.Enabled = true;
                txtMinWeightInt.Enabled = true;
                txtMinFeeInt.Enabled = true;
                txtNextFeeInt.Enabled = true;
                txtStepWeightInt.Enabled = true;
                txtStepWeightMB.Enabled = true;
                txtStepWeightMT.Enabled = true;
                txtStepWeightMN.Enabled = true;
                chbReturnFee.Enabled = true;
                txtInsurance.Enabled = true;
                txtCODFee.Enabled = true;
            }
            if (stus == enumAction.UPDATE)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                cmbFK_Post.Enabled = true;
                txtMinWeightMN.Enabled = true;
                txtMinWeightMT.Enabled = true;
                txtMinWeightMB.Enabled = true;
                txtMinFeeMN.Enabled = true;
                txtMinFeeMT.Enabled = true;
                txtMinFeeMB.Enabled = true;
                txtNextFeeMN.Enabled = true;
                txtNextFeeMT.Enabled = true;
                txtNextFeeMB.Enabled = true;
                txtMinWeightInt.Enabled = true;
                txtMinFeeInt.Enabled = true;
                txtNextFeeInt.Enabled = true;
                txtStepWeightInt.Enabled = true;
                txtStepWeightMB.Enabled = true;
                txtStepWeightMT.Enabled = true;
                txtStepWeightMN.Enabled = true;
                chbReturnFee.Enabled = true;
                txtInsurance.Enabled = true;
                txtCODFee.Enabled = true;
            }
        }
        // Xóa trắng tất cả các textbox.
        private void ClearText()
        {
            txtMinWeightMN.Text = string.Empty;
            txtMinWeightMT.Text = string.Empty;
            txtMinWeightMB.Text = string.Empty;
            txtMinFeeMN.Text = string.Empty;
            txtMinFeeMT.Text = string.Empty;
            txtMinFeeMB.Text = string.Empty;
            txtNextFeeMN.Text = string.Empty;
            txtNextFeeMT.Text = string.Empty;
            txtNextFeeMB.Text = string.Empty;
            txtMinWeightInt.Text = string.Empty;
            txtMinFeeInt.Text = string.Empty;
            txtNextFeeInt.Text = string.Empty;
            txtStepWeightInt.Text = string.Empty;
            txtStepWeightMB.Text = string.Empty;
            txtStepWeightMT.Text = string.Empty;
            txtStepWeightMN.Text = string.Empty;
            txtInsurance.Text = string.Empty;
            txtCODFee.Text = string.Empty;
        }

        // Fill dữ liệu vào các control.
        private void FillData(view_GExpFeeDebitSession item, bool copy)
        {
            if (!copy)
            {
            }
            if (item.FK_Post != null)
            {
                cmbFK_Post.SelectedValue = item.FK_Post;
            }
            txtMinWeightMN.Text = item.MinWeightMN.ToString();
            txtMinWeightMT.Text = item.MinWeightMT.ToString();
            txtMinWeightMB.Text = item.MinWeightMB.ToString();
            txtMinFeeMN.Text = item.MinFeeMN.ToString();
            txtMinFeeMT.Text = item.MinFeeMT.ToString();
            txtMinFeeMB.Text = item.MinFeeMB.ToString();
            txtNextFeeMN.Text = item.NextFeeMN.ToString();
            txtNextFeeMT.Text = item.NextFeeMT.ToString();
            txtNextFeeMB.Text = item.NextFeeMB.ToString();
            txtMinWeightInt.Text = item.MinWeightInt.ToString();
            txtMinFeeInt.Text = item.MinFeeInt.ToString();
            txtNextFeeInt.Text = item.NextFeeInt.ToString();
            txtStepWeightInt.Text = item.StepWeightInt.ToString();
            txtStepWeightMB.Text = item.StepWeightMB.ToString();
            txtStepWeightMT.Text = item.StepWeightMT.ToString();
            txtStepWeightMN.Text = item.StepWeightMN.ToString();
            chbReturnFee.Checked = item.ReturnFee;
            txtInsurance.Text = item.Insurance.ToString();
            txtCODFee.Text = item.CODFee.ToString();
        }

        #region Xử lý TextBox tìm kiếm dữ liệu trên form
        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var result = await _logic.GetList(txtSearch.Text);
            gridMain.DataSource = result;
        }
        #endregion

        #endregion

        #region Xử lý sự kiện cho các button - GridControl
        private void txtMinWeightMN_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtMinWeightMN_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtMinWeightMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtMinWeightMT_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtMinWeightMB_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtMinWeightMB_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtMinFeeMN_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtMinFeeMN_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtMinFeeMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtMinFeeMT_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtMinFeeMB_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtMinFeeMB_KeyUp(object sender, KeyEventArgs e)
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
        private void txtNextFeeMN_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtNextFeeMN_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtNextFeeMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtNextFeeMT_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtNextFeeMB_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtNextFeeMB_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtMinWeightInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtMinWeightInt_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtMinFeeInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtMinFeeInt_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtNextFeeInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtNextFeeInt_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtStepWeightInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtStepWeightInt_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtStepWeightMB_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtStepWeightMB_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtStepWeightMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtStepWeightMT_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtStepWeightMN_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtStepWeightMN_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtInsurance_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtInsurance_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtCODFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtCODFee_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }

        // Load data từ database lên lưới
        private async void LoadData(bool reload = false)
        {
            var result = await _logic.GetList(string.Empty);
            gridMain.DataSource = result;
            if (reload)
            {
                // ExpPost
                cmbFK_Post.DataSource = await _logic.GetMasterFK_PostList();
                cmbFK_Post.DisplayMember = "TenDaiLy";
                cmbFK_Post.ValueMember = "Id";
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
            if (String.IsNullOrEmpty(txtMinWeightMN.Text))
            {
                MessageBox.Show("MinWeightMN không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMinWeightMN.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtMinWeightMT.Text))
            {
                MessageBox.Show("MinWeightMT không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMinWeightMT.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtMinWeightMB.Text))
            {
                MessageBox.Show("MinWeightMB không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMinWeightMB.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtMinFeeMN.Text))
            {
                MessageBox.Show("MinFeeMN không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMinFeeMN.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtMinFeeMT.Text))
            {
                MessageBox.Show("MinFeeMT không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMinFeeMT.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtMinFeeMB.Text))
            {
                MessageBox.Show("MinFeeMB không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMinFeeMB.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtNextFeeMN.Text))
            {
                MessageBox.Show("NextFeeMN không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNextFeeMN.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtNextFeeMT.Text))
            {
                MessageBox.Show("NextFeeMT không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNextFeeMT.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtNextFeeMB.Text))
            {
                MessageBox.Show("NextFeeMB không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNextFeeMB.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtMinWeightInt.Text))
            {
                MessageBox.Show("MinWeightInt không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMinWeightInt.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtMinFeeInt.Text))
            {
                MessageBox.Show("MinFeeInt không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMinFeeInt.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtNextFeeInt.Text))
            {
                MessageBox.Show("NextFeeInt không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNextFeeInt.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtStepWeightInt.Text))
            {
                MessageBox.Show("StepWeightInt không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStepWeightInt.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtStepWeightMB.Text))
            {
                MessageBox.Show("StepWeightMB không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStepWeightMB.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtStepWeightMT.Text))
            {
                MessageBox.Show("StepWeightMT không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStepWeightMT.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtStepWeightMN.Text))
            {
                MessageBox.Show("StepWeightMN không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStepWeightMN.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtInsurance.Text))
            {
                MessageBox.Show("Insurance không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInsurance.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtCODFee.Text))
            {
                MessageBox.Show("CODFee không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCODFee.Focus();
                return;
            }
            QuanLyGiaGocLogicInputDto item = new QuanLyGiaGocLogicInputDto();
            item.FK_Post = cmbFK_Post.SelectedValue.ToString();
            item.MinWeightMN = Int32.Parse(txtMinWeightMN.Text, System.Globalization.NumberStyles.AllowThousands);
            item.MinWeightMT = Int32.Parse(txtMinWeightMT.Text, System.Globalization.NumberStyles.AllowThousands);
            item.MinWeightMB = Int32.Parse(txtMinWeightMB.Text, System.Globalization.NumberStyles.AllowThousands);
            item.MinFeeMN = Int32.Parse(txtMinFeeMN.Text, System.Globalization.NumberStyles.AllowThousands);
            item.MinFeeMT = Int32.Parse(txtMinFeeMT.Text, System.Globalization.NumberStyles.AllowThousands);
            item.MinFeeMB = Int32.Parse(txtMinFeeMB.Text, System.Globalization.NumberStyles.AllowThousands);
            item.NextFeeMN = Int32.Parse(txtNextFeeMN.Text, System.Globalization.NumberStyles.AllowThousands);
            item.NextFeeMT = Int32.Parse(txtNextFeeMT.Text, System.Globalization.NumberStyles.AllowThousands);
            item.NextFeeMB = Int32.Parse(txtNextFeeMB.Text, System.Globalization.NumberStyles.AllowThousands);
            item.MinWeightInt = Int32.Parse(txtMinWeightInt.Text, System.Globalization.NumberStyles.AllowThousands);
            item.MinFeeInt = Int32.Parse(txtMinFeeInt.Text, System.Globalization.NumberStyles.AllowThousands);
            item.NextFeeInt = Int32.Parse(txtNextFeeInt.Text, System.Globalization.NumberStyles.AllowThousands);
            item.StepWeightInt = Int32.Parse(txtStepWeightInt.Text, System.Globalization.NumberStyles.AllowThousands);
            item.StepWeightMB = Int32.Parse(txtStepWeightMB.Text, System.Globalization.NumberStyles.AllowThousands);
            item.StepWeightMT = Int32.Parse(txtStepWeightMT.Text, System.Globalization.NumberStyles.AllowThousands);
            item.StepWeightMN = Int32.Parse(txtStepWeightMN.Text, System.Globalization.NumberStyles.AllowThousands);
            item.ReturnFee = chbReturnFee.Checked;
            item.Insurance = Int32.Parse(txtInsurance.Text, System.Globalization.NumberStyles.AllowThousands);
            item.CODFee = Int32.Parse(txtCODFee.Text, System.Globalization.NumberStyles.AllowThousands);
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
                string reportFile = "GExpFeeDebitSession.rpt";
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
    }
}
