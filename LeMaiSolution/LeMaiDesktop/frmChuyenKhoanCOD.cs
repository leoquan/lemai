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
    public partial class frmChuyenKhoanCOD : frmBase
    {
        private ChuyenKhoanCODLogic _logic = new ChuyenKhoanCODLogic(PBean.ConnectionBase);
        private enumAction status = enumAction.NONE;
        private view_ExpCODCK Gitem;

        public frmChuyenKhoanCOD() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            gridMain.AutoGenerateColumns = false;
            this.gridMain.RowTemplate.MinimumHeight = 22;
            Separator();
        }

        private void frmChuyenKhoanCOD_Load(object sender, EventArgs e)
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
            if (stus == enumAction.NONE)
            {
                btnSave.Enabled = false;
                btnNew.Text = "&Mới";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iNew;
                txtBILL_CODE.Enabled = false;
                txtSoTienCKCOD.Enabled = false;
            }
            if (stus == enumAction.NEW)
            {
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                btnEdit.Enabled = false;
                txtBILL_CODE.Enabled = true;
                txtSoTienCKCOD.Enabled = true;
            }
            if (stus == enumAction.UPDATE)
            {
                btnEdit.Enabled = false;
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                txtBILL_CODE.Enabled = true;
                txtSoTienCKCOD.Enabled = true;
            }
        }
        // Xóa trắng tất cả các textbox.
        private void ClearText()
        {
            txtBILL_CODE.Text = string.Empty;
            txtSoTienCKCOD.Text = string.Empty;
        }

        // Fill dữ liệu vào các control.
        private void FillData(view_ExpCODCK item, bool copy)
        {
            if (!copy)
            {
                txtBILL_CODE.Text = item.BILL_CODE;
            }
            txtSoTienCKCOD.Text = item.SoTienCKCOD.ToString();
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
        private void txtBILL_CODE_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSoTienCKCOD_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSoTienCKCOD_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }

        // Load data từ database lên lưới
        private async void LoadData(bool reload = false)
        {
            var result = await _logic.GetList(string.Empty, PBean.USER.CardId);
            gridMain.DataSource = result;
            if (reload)
            {
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
                    Gitem = await _logic.GetDetails(Convert.ToString(gridMain.Rows[index].Cells["col_BILL_CODE"].Value));
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
                txtBILL_CODE.Focus();
            }
        }

        //Chỉnh sửa
        private async void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                int index = gridMain.SelectedRows[0].Index;
                Gitem = await _logic.GetDetails(Convert.ToString(gridMain.Rows[index].Cells["col_BILL_CODE"].Value));
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
            if (String.IsNullOrEmpty(txtBILL_CODE.Text))
            {
                MessageBox.Show("Mã vận đơn không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBILL_CODE.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSoTienCKCOD.Text))
            {
                MessageBox.Show("Số tiền CK không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTienCKCOD.Focus();
                return;
            }
            ChuyenKhoanCODLogicInputDto item = new ChuyenKhoanCODLogicInputDto();
            item.BILL_CODE = txtBILL_CODE.Text;
            item.SoTienCKCOD = Int32.Parse(txtSoTienCKCOD.Text, System.Globalization.NumberStyles.AllowThousands);
            item.FK_Post = PBean.USER.CardId;
            item.FK_Account = PBean.USER.Id;
            if (status == enumAction.NEW)
            {
                var result = await _logic.Create(item);
                if (result == null)
                {
                    MessageBox.Show("Mã vận đơn không đúng hoặc đã có lệnh chuyển COD, vui lòng kiểm tra lại!", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBILL_CODE.Focus();
                    return;
                }
            }
            else if (status == enumAction.UPDATE)
            {
                //Cập nhật dữ liệu
                await _logic.Update(Gitem.BILL_CODE, item).ConfigureAwait(true);
            }
            status = 0;
            EnableButton(status);
            LoadData();
        }


        //Kết thúc
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
		#endregion

		private async void btnExcel_Click(object sender, EventArgs e)
		{
			var result = await _logic.GetList(string.Empty, PBean.USER.CardId);
			if (result.Count > 0)
			{
				SaveFileDialog save = new SaveFileDialog();
				save.FileName = "COD_CK" + string.Format("{0:dd_MM_yyyy_(HH_mm)}", DateTime.Now);
				save.Filter = "Excel Files | *.xlsx";
				if (save.ShowDialog() == DialogResult.OK)
				{
					string templateFileName = AppDomain.CurrentDomain.BaseDirectory + "Templates\\LM_CODCK.xlsx";
					Dictionary<string, string> lsReplace = new Dictionary<string, string>();
					Dictionary<string, string> lsTitile = new Dictionary<string, string>();
					List<string> lsKeyString = new List<string>();
					lsKeyString.Add("BILL_CODE");
					lsKeyString.Add("CreateDate");
					DataTable data = MapperExtensionClass.ToDataTable<view_ExpCODCK>(result);
					ExportDataToExcelTemplate.Export(templateFileName, save.FileName, 1, data, lsTitile, lsReplace, true, lsKeyString);
					MessageBox.Show("Xuất file excel thành công!", PBean.MESSAGE_TITLE);
				}
			}
			else
			{
				MessageBox.Show("Chưa có dữ liệu vui lòng thực hiện truy vấn dữ liệu trước khi xuất Excel", PBean.MESSAGE_TITLE);
			}
		}
	}
}
