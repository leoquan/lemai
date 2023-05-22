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
    public partial class frmQuanLyRutTien : frmBase
    {
        private QuanLyRutTienLogic _logic = new QuanLyRutTienLogic(PBean.ConnectionBase);
        private enumAction status = enumAction.NONE;

        public frmQuanLyRutTien() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            gridMain.AutoGenerateColumns = false;
            this.gridMain.RowTemplate.MinimumHeight = 22;
            Separator();
            cmbLoai.SelectedIndex = 0;
        }

        private void frmQuanLyNapTien_Load(object sender, EventArgs e)
        {
            LoadData(true);
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
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        #region Xử lý sự kiện cho các button - GridControl


        // Load data từ database lên lưới
        private async void LoadData(bool reload = false)
        {
            var result = await _logic.GetList(txtFilter.Text.Trim(), dateFrom.Value, dateTo.Value, cmbLoai.SelectedIndex, PBean.USER.CardId);
            gridMain.DataSource = result;
            if (result.Count > 0)
            {
                btnExcel.Enabled = true;
            }
            else
            {
                btnExcel.Enabled = false;
            }
        }

        private async void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gridMain.SelectedRows[0].Index;
                var item = await _logic.GetDetails(Convert.ToString(gridMain.Rows[index].Cells["col_Id"].Value));
                if (null != item && item.IsConfirm == false)
                {
                    //Hiển thị form duyệt hoặc từ chối

                }
                else
                {
                    MessageBox.Show("Yêu cầu nạp tiền không tồn tại hoặc đã được phê duyệt", PBean.MESSAGE_TITLE);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void btnTruyVan_Click(object sender, EventArgs e)
        {
            LoadData(false);
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            var list = await _logic.GetList(txtFilter.Text.Trim(), dateFrom.Value, dateTo.Value, cmbLoai.SelectedIndex, PBean.USER.CardId);
            if (list.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "QLRT" + string.Format("{0:dd_MM}", dateFrom.Value) + "_DEN_" + string.Format("{0:dd_MM}", dateTo.Value);
                string NgayBaoCao = "Từ " + string.Format("{0:HH:mm:ss dd/MM/yyyy}", dateFrom.Value) + " đến " + string.Format("{0:HH:mm:ss dd/MM/yyyy}", dateTo.Value);
                save.Filter = "Excel Files | *.xlsx";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string templateFileName = AppDomain.CurrentDomain.BaseDirectory + "Templates\\BAO_CAO_RUT_TIEN.xlsx";
                    Dictionary<string, string> lsReplace = new Dictionary<string, string>();
                    Dictionary<string, string> lsTitile = new Dictionary<string, string>();
                    List<string> lsKeyString = new List<string>();
                    lsReplace.Add("NGAY_BAO_CAO", NgayBaoCao);
                    lsKeyString.Add("CreateDate");
                    DataTable data = MapperExtensionClass.ToDataTable(list);
                    ExportDataToExcelTemplate.Export(templateFileName, save.FileName, 1, data, lsTitile, lsReplace, true, lsKeyString);
                    MessageBox.Show("Xuất file excel thành công!", PBean.MESSAGE_TITLE);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu kết toán!", PBean.MESSAGE_TITLE);
            }

        }

        private void gridMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXacNhan_Click(null, null);
        }
    }
}
