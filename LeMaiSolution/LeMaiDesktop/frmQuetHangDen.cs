﻿using Common;
using LeMaiDomain;
using LeMaiLogic;
using LeMaiLogic.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeMaiDesktop
{
    public partial class frmQuetHangDen : frmBase
    {
        SoundPlayer SoundSuccess = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "success.wav");
        SoundPlayer SoundFailure = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "error.wav");
        private GExpBillLogic _logic = new GExpBillLogic(PBean.ConnectionBase);
        private GExpScanLogic _logicScan = new GExpScanLogic(PBean.ConnectionBase);
        public frmQuetHangDen() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            dateFrom.Value = DateTime.Now;
        }

        private void frmQuanLyHanhTrinh_Load(object sender, EventArgs e)
        {
            LoadData(true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Xóa kiện vấn đề
            if (MessageBox.Show("Bạn có muốn xóa quét đến đơn hàng này không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int index = gridBills.SelectedRows[0].Index;
                    string IdTrack = Convert.ToString(gridBills.Rows[index].Cells["col_Id"].Value);
                    _logicScan.DelCome(IdTrack);
                    LoadData();
                }
                catch (ArgumentOutOfRangeException)
                {
                    return;
                }
            }

        }

        private async void txtMaDonHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtMaDonHang.Text))
                {
                    view_GExpBill bill = await _logic.GetDetails(txtMaDonHang.Text.Trim());
                    if (bill != null)
                    {
                        ucBillMain.SetView(bill);
                        string message = _logicScan.AddCome(bill.BillCode, PBean.USER.Id, PBean.USER.FullName, PBean.USER.Phone, PBean.USER.CardId, PBean.USER.Address);
                        if (!string.IsNullOrEmpty(message))
                        {
                            SoundFailure.Play();
                            txtMaDonHang.SelectAll();
                            MessageBox.Show(message, PBean.MESSAGE_TITLE);
                        }
                        else
                        {
                            SoundSuccess.Play();
                            LoadData();
                            txtMaDonHang.Text = string.Empty;
                            txtMaDonHang.Focus();
                        }
                    }
                    else
                    {
                        ucBillMain.Clear();
                    }
                }
            }
        }
        public async void LoadData(bool reload = false)
        {
            if (reload)
            {
                // Load danh sách khách hàng
                cmbFilter.DataSource = _logicScan.GetPostListAllFilter(PBean.USER.CardId, txtFilter.Text.Trim());
                cmbFilter.DisplayMember = "TenDaiLy";
                cmbFilter.ValueMember = "Id";

            }
            var list = _logicScan.GetScanComeListFilter(PBean.USER.CardId, cmbFilter.SelectedValue.ToString(), dateFrom.Value, dateTo.Value, txtBillCode.Text.Trim());
            gridBills.AutoGenerateColumns = false;
            gridBills.DataSource = list;
            lblSoLuong.Text = PCommon.FormatNumber(list.Count.ToString());
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtKhachHangFilter_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                cmbFilter.DataSource = _logicScan.GetPostListAllFilter(PBean.USER.CardId, txtFilter.Text.Trim());
                cmbFilter.DisplayMember = "TenDaiLy";
                cmbFilter.ValueMember = "Id";
            }
        }

        private async void gridBills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tra cứu đơn hàng trên trang thứ 3
            try
            {
                int index = gridBills.SelectedRows[0].Index;
                string billCode = Convert.ToString(gridBills.Rows[index].Cells["col_BillCode"].Value);
                view_GExpBill bill = await _logic.GetDetails(billCode);
                if (bill != null)
                {
                    frmTrackingAndProcess frm = PCommon.GetFormIsOpened("frmTrackingAndProcess") as frmTrackingAndProcess;
                    if (frm == null)
                    {
                        frm = new frmTrackingAndProcess();
                        frm.StartView(bill);
                        frm.Show();
                    }
                    else
                    {
                        frm.WindowState = FormWindowState.Maximized;
                        frm.StartView(bill);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            // Xuất excel
            var list = _logicScan.GetScanComeListFilter(PBean.USER.CardId, cmbFilter.SelectedValue.ToString(), dateFrom.Value, dateTo.Value, txtBillCode.Text.Trim());
            if (list.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "QUET_DEN_" + string.Format("{0:dd_MM_yyyy_(HH_mm)}", DateTime.Now);
                save.Filter = "Excel Files | *.xlsx";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string templateFileName = AppDomain.CurrentDomain.BaseDirectory + "Templates\\MAU_QUET_DEN.xlsx";
                    Dictionary<string, string> lsReplace = new Dictionary<string, string>();
                    Dictionary<string, string> lsTitile = new Dictionary<string, string>();
                    List<string> lsKeyString = new List<string>();
                    lsKeyString.Add("CreateDate");
                    DataTable data = MapperExtensionClass.ToDataTable(list);
                    ExportDataToExcelTemplate.Export(templateFileName, save.FileName, 1, data, lsTitile, lsReplace, true, lsKeyString);
                    MessageBox.Show("Xuất file excel thành công!", PBean.MESSAGE_TITLE);
                }
            }

        }
    }
}
