using Common;
using LeMaiDomain;
using LeMaiLogic.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeMaiDesktop
{
    public partial class frmImportOrderExcel : frmBase
    {
        private GExpBillLogic _logic = new GExpBillLogic(PBean.ConnectionBase);
        private List<view_GExpBill> _list = new List<view_GExpBill>();
        bool isBusy = false;
        private string message = string.Empty;

        public frmImportOrderExcel() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();

        }

        private void btnKetToanC1_Click(object sender, EventArgs e)
        {
            if (cmbKhachHangFilter.SelectedValue == null || cmbKhachHangFilter.SelectedValue.ToString() == "9999")
            {
                MessageBox.Show("Chưa chọn thông tin người gửi", PBean.MESSAGE_TITLE);
                return;
            }
            ExpCustomer customer = _logic.GetThongTinKhachHangById(cmbKhachHangFilter.SelectedValue.ToString());
            if (customer == null)
            {
                MessageBox.Show("Chưa chọn thông tin người gửi", PBean.MESSAGE_TITLE);
                return;
            }

            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Excel file |*.xlsx";
            if (file.ShowDialog() == DialogResult.OK)
            {

                txtFileName.Text = file.FileName;
                btnSave.Enabled = true;
                DataTable dtTemp = ExportDataToExcelTemplate.ReadAsDataTableK10(txtFileName.Text.Trim());
                foreach (DataColumn item in dtTemp.Columns)
                {
                    if (item.ColumnName.Contains("TÊN KH"))
                    {
                        item.ColumnName = "TEN_KH";
                    }
                    else if (item.ColumnName.Contains("SDT"))
                    {
                        item.ColumnName = "SDT";
                    }
                    else if (item.ColumnName.Contains("ĐỊA CHỈ"))
                    {
                        item.ColumnName = "DIA_CHI";
                    }
                    else if (item.ColumnName.Contains("TÊN SP"))
                    {
                        item.ColumnName = "TEN_SP";
                    }
                    else if (item.ColumnName.Contains("KHỐI LƯỢNG"))
                    {
                        item.ColumnName = "KHOI_LUONG";
                    }
                    else if (item.ColumnName.Contains("TIỀN COD"))
                    {
                        item.ColumnName = "COD";
                    }
                    else if (item.ColumnName.Contains("GHI CHÚ"))
                    {
                        item.ColumnName = "GHI_CHU";
                    }
                }
                _list = new List<view_GExpBill>();
                foreach (DataRow item in dtTemp.Rows)
                {
                    if (!string.IsNullOrEmpty(item["TEN_KH"].ToString()))
                    {
                        view_GExpBill bill = new view_GExpBill();

                        bill.AcceptMan = item["TEN_KH"].ToString();
                        bill.AcceptManPhone = item["SDT"].ToString();
                        bill.GoodsName = item["TEN_SP"].ToString();
                        decimal cod = 0;
                        if (!decimal.TryParse(item["COD"].ToString(), out cod))
                        {
                            cod = 0;
                        }
                        bill.COD = cod;
                        bill.SendMan = customer.CustomerName;
                        bill.SendManPhone = customer.CustomerPhone;
                        bill.FK_Customer = customer.Id;
                        bill.RegisterDate = DateTime.Now;
                        bill.BillStatus = 0;
                        decimal weight = 0;
                        if (!decimal.TryParse(item["KHOI_LUONG"].ToString(), out weight))
                        {
                            weight = 0;
                        }
                        weight = weight * 1000;

                        bill.CustomerCode = customer.CustomerCode;
                        bill.SendManAddress = customer.DiaChi;
                        bill.FeeWeight = weight;
                        bill.BillWeight = weight;
                        bill.FullAddress = item["DIA_CHI"].ToString();

                        bill.Note = item["GHI_CHU"].ToString();
                        _list.Add(bill);
                    }
                }
                gridBills.DataSource = _list;
            }
            else
            {
                txtFileName.Text = string.Empty;
                btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isBusy == true)
            {
                MessageBox.Show("Đang xử lý vui lòng chờ", PBean.MESSAGE_TITLE);
                return;
            }
            progressBar.Visible = true;
            progressBar.Value = 0;
            progressBar.Maximum = _list.Count;
            progressBar.Minimum = 0;
            isBusy = true;
            backgroundWorker.RunWorkerAsync();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (var item in _list)
            {
                _logic.CreateWithList(item, PBean.USER.Id, PBean.USER.FullName, PBean.USER.CardId);
                backgroundWorker.ReportProgress(0);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.PerformStep();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            isBusy = false;
            progressBar.Visible = false;
            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message, PBean.MESSAGE_TITLE);
            }
            else
            {
                MessageBox.Show("Nạp đơn thành công!", PBean.MESSAGE_TITLE);
            }

        }
        private void LoadData(bool reload = false)
        {
            if (reload)
            {
                // Load danh sách khách hàng
                cmbKhachHangFilter.DataSource = _logic.GetCustomerListFilter(PBean.USER.CardId, txtKhachHangFilter.Text.Trim());
                cmbKhachHangFilter.DisplayMember = "CustomerName";
                cmbKhachHangFilter.ValueMember = "Id";
            }
        }
        private void frmImportOrderExcel_Load(object sender, EventArgs e)
        {
            LoadData(true);
        }

        private void txtKhachHangFilter_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                cmbKhachHangFilter.DataSource = _logic.GetCustomerListFilter(PBean.USER.CardId, txtKhachHangFilter.Text.Trim());
                cmbKhachHangFilter.DisplayMember = "CustomerName";
                cmbKhachHangFilter.ValueMember = "Id";
            }
        }
    }
}
