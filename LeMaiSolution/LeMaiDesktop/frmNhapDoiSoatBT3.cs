using Common;
using LeMaiDomain;
using LeMaiLogic;
using LeMaiLogic.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LeMaiDesktop
{
    public partial class frmNhapDoiSoatBT3 : frmBase
    {
        DoiSoatKhachHangLogic _logic = new DoiSoatKhachHangLogic(PBean.ConnectionBase);
        DataTable _dataDoiSoat = new DataTable();
        private string _Note = string.Empty;
        private string _providerId = string.Empty;
        string _errorMessage = string.Empty;

        decimal TongTienXacNhan = 0;
        int CountTienXacNhan = 0;
        string _errorMessageXNTP = string.Empty;
        bool isBusy = false;

        List<string> selectFiles = new List<string>();

        List<GExpMoneyReturn> lsMoneyReturn = new List<GExpMoneyReturn>();
        List<GExpMoneyReturn> lsMoneyReturnError = new List<GExpMoneyReturn>();
        List<GExpMoneyReturn> lsMoneyReturnExist = new List<GExpMoneyReturn>();

        bool isNew = false;
        int count = 0;

        public frmNhapDoiSoatBT3() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            try
            {
                GExpProvider provider = _logic.GetProviderDetail(cmbSubTaiKhoan.SelectedValue.ToString());
                if (provider != null)
                {
                    switch (provider.ProviderTypeCode)
                    {
                        case "GHN":
                            {
                                open.Filter = "Excel Files 2007 |*.xlsx";
                            }
                            break;
                        case "VNPOST":
                            {
                                open.Filter = "Excel Files 97-2003 |*.xls";
                            }
                            break;
                        default:
                            _dataDoiSoat = new DataTable();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Chưa chọn loại tài khoản BT3", PBean.MESSAGE_TITLE);
                    cmbSubTaiKhoan.Focus();
                    return;
                }

            }
            catch
            {
            }

            if (open.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = open.FileName;
                btnReadData.Enabled = true;
            }
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmbSubTaiKhoan.SelectedValue.ToString() == "9999")
                {
                    MessageBox.Show("Chưa chọn loại tài khoản BT3", PBean.MESSAGE_TITLE);
                    cmbSubTaiKhoan.Focus();
                    return;
                }
                GExpProvider provider = _logic.GetProviderDetail(cmbSubTaiKhoan.SelectedValue.ToString());
                _dataDoiSoat = new DataTable();
                switch (provider.ProviderTypeCode)
                {
                    case "GHN":
                        {
                            _dataDoiSoat = ReadDebitComparison.ReadGHN(txtFilePath.Text.Trim());

                        }
                        break;
                    case "VNPOST":
                        {
                            _dataDoiSoat = ReadVNPOST(txtFilePath.Text.Trim());
                        }
                        break;
                    case "GHSV":
                        {
                            _dataDoiSoat = ReadDebitComparison.ReadGHSV(txtFilePath.Text.Trim());
                        }
                        break;
                    case "BEST":
                        {
                            _dataDoiSoat = ReadDebitComparison.ReadBEST(txtFilePath.Text.Trim());
                        }
                        break;
                    case "JNT":
                        {
                            _dataDoiSoat = ReadDebitComparison.ReadJNT(txtFilePath.Text.Trim());
                        }
                        break;
                    case "NINJA":
                        {
                            _dataDoiSoat = ReadDebitComparison.ReadNINJA(txtFilePath.Text.Trim());
                        }
                        break;
                    default:
                        _dataDoiSoat = new DataTable();
                        break;
                }
                ReFillDataTable(_dataDoiSoat);

                gridChild.DataSource = _dataDoiSoat;
                lblSubCount.Text = PCommon.FormatNumber(_dataDoiSoat.Rows.Count.ToString());
                btnSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
                btnSave.Enabled = false;
            }

        }
        void ReFillDataTable(DataTable data)
        {
            IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
            try
            {
                dc.Open();
                foreach (DataRow item in data.Rows)
                {
                    view_GExpBill bill = dc.VIewgexpbill.GetObjectCon(PBean.SCHEMA, "WHERE BT3Code=@BT3Code", "@BT3Code", item["BT3Code"].ToString());
                    if (bill != null)
                    {
                        item["BillCode"] = bill.BillCode;
                        item["SendMan"] = bill.SendMan;
                        item["SendManPhone"] = bill.SendManPhone;
                        item["AcceptMan"] = bill.AcceptMan;
                        item["AcceptManPhone"] = bill.AcceptManPhone;
                        item["AcceptProvince"] = bill.AcceptProvince;
                        item["COD"] = bill.COD;
                        item["Freight"] = bill.Freight;
                        item["FeeWeight"] = bill.FeeWeight;
                        item["BillWeight"] = bill.BillWeight;
                        item["PayType"] = bill.PayType;
                    }
                }
            }
            catch (Exception ex)
            {
                _errorMessage = ex.ToString();
            }
            finally
            {
                dc.Close();

            }

        }
        DataTable ReadVNPOST(string filename)
        {
            try
            {
                DataSet ds = NPOIHelper.GetDataSetFromXls(filename);
                DataTable data = ds.Tables[0];
                DataTable result = ReadDebitComparison.MakeDataTable();
                int STT = 0;
                foreach (DataRow item in data.Rows)
                {
                    // Hiển thị data
                    if (!string.IsNullOrEmpty(item["Số hiệu bưu gửi"].ToString()))
                    {
                        STT++;
                        DataRow dr = result.NewRow();
                        dr["Id"] = STT;
                        dr["BT3Code"] = item["Số hiệu bưu gửi"].ToString();
                        dr["Status"] = 1;

                        dr["MoneyReturnStatusName"] = "";
                        DateTime date = DateTime.ParseExact(item["Ngày thu tiền"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        dr["DateReturn"] = string.Format("{0:yyyy-MM-dd}", date);
                        dr["BT3COD"] = item["Số tiền"];

                        dr["BT3TotalPaid"] = 0;
                        dr["BT3TotalDiscount"] = 0;
                        dr["BT3TotalFee"] = 0;

                        dr["MoneyReturn"] = item["Số tiền"];

                        result.Rows.Add(dr);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
                return ReadDebitComparison.MakeDataTable();
            }
        }

        private void frmNhapDoiSoatBT3_Load(object sender, EventArgs e)
        {
            dateFrom.Value = DateTime.Now.AddDays(-7);

            cmbTaiKhoan.DataSource = _logic.GetProviderListAndAll(PBean.USER.CardId);
            cmbTaiKhoan.DisplayMember = "ProviderName";
            cmbTaiKhoan.ValueMember = "Id";

            cmbSubTaiKhoan.DataSource = _logic.GetProviderList(PBean.USER.CardId);
            cmbSubTaiKhoan.DisplayMember = "ProviderName";
            cmbSubTaiKhoan.ValueMember = "Id";
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Lưu danh sách đối soát
            if (_dataDoiSoat.Rows.Count > 0)
            {
                count = 0;
                lsMoneyReturn = new List<GExpMoneyReturn>();
                lsMoneyReturnError = new List<GExpMoneyReturn>();
                lsMoneyReturnExist = new List<GExpMoneyReturn>();
                _errorMessage = string.Empty;
                _providerId = cmbSubTaiKhoan.SelectedValue.ToString();
                _Note = txtNote.Text.Trim();

                progressBarLuuDoiSoat.Visible = true;
                progressBarLuuDoiSoat.Value = 0;
                progressBarLuuDoiSoat.Maximum = _dataDoiSoat.Rows.Count;

                backgroundWorkerLuu.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Chưa nạp dữ liệu data đối soát của BT3", PBean.MESSAGE_TITLE);
            }

        }

        private void backgroundWorkerLuu_DoWork(object sender, DoWorkEventArgs e)
        {
            IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();
                GExpMoneyReturnSession moneySession = new GExpMoneyReturnSession();
                moneySession.Id = Guid.NewGuid().ToString();
                moneySession.Note = _Note;
                moneySession.FK_ProviderAccount = _providerId;
                moneySession.FK_AccountRefer = PBean.USER.Id;
                moneySession.DateReturn = currentDate;
                moneySession.IsPayCustomer = false;

                foreach (DataRow item in _dataDoiSoat.Rows)
                {
                    GExpMoneyReturn mItem = new GExpMoneyReturn();
                    mItem.Id = Guid.NewGuid().ToString();
                    mItem.BT3Code = item["BT3Code"].ToString();
                    mItem.Status = Int32.Parse(item["Status"].ToString());

                    mItem.BT3COD = decimal.Parse(item["BT3COD"].ToString());
                    mItem.BT3TotalPaid = decimal.Parse(item["BT3TotalPaid"].ToString());
                    mItem.BT3TotalDiscount = decimal.Parse(item["BT3TotalDiscount"].ToString());
                    mItem.BT3TotalFee = decimal.Parse(item["BT3TotalFee"].ToString());
                    mItem.MoneyReturn = decimal.Parse(item["MoneyReturn"].ToString());
                    DateTime date;
                    if (DateTime.TryParse(item["DateReturn"].ToString(), out date))
                    {
                        mItem.DateReturn = date;
                    }
                    mItem.FK_MoneyReturnSession = moneySession.Id;
                    mItem.IsPayCustomer = false;

                    GExpBill bill = dc.GExpbill.GetObjectCon(PBean.SCHEMA, "WHERE BT3Code=@BT3Code", "@BT3Code", mItem.BT3Code);
                    if (bill != null)
                    {
                        mItem.BillCode = bill.BillCode;
                    }
                    else
                    {
                        mItem.BillCode = string.Empty;
                        lsMoneyReturnError.Add(mItem);
                    }
                    GExpMoneyReturn check = dc.GExpmoneyreturn.GetObjectCon(PBean.SCHEMA, "WHERE BT3Code=@BT3Code AND Status=@Status",
                        "@BT3Code", mItem.BT3Code,
                        "@Status", mItem.Status);
                    if (check != null)
                    {
                        lsMoneyReturnExist.Add(mItem);
                    }
                    else
                    {
                        lsMoneyReturn.Add(mItem);

                        dc.GExpmoneyreturn.InsertOnSubmit(PBean.SCHEMA, mItem);
                    }
                    backgroundWorkerLuu.ReportProgress(0);
                }
                moneySession.BT3COD = lsMoneyReturn.Sum(s => s.BT3COD);
                moneySession.BT3TotalPaid = lsMoneyReturn.Sum(s => s.BT3TotalPaid);
                moneySession.BT3TotalDiscount = lsMoneyReturn.Sum(s => s.BT3TotalDiscount);
                moneySession.BT3TotalFee = lsMoneyReturn.Sum(s => s.BT3TotalFee);
                moneySession.MoneyReturn = lsMoneyReturn.Sum(s => s.MoneyReturn);
                moneySession.Post = PBean.USER.CardId;
                count = lsMoneyReturn.Count;
                if (lsMoneyReturn.Count > 0)
                {
                    dc.GExpmoneyreturnsession.InsertOnSubmit(PBean.SCHEMA, moneySession);
                }

                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                _errorMessage = ex.ToString();
            }
            finally
            {
                dc.Close();

            }

        }

        private void backgroundWorkerLuu_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarLuuDoiSoat.PerformStep();
        }

        private void backgroundWorkerLuu_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarLuuDoiSoat.Visible = false;
            if (string.IsNullOrEmpty(_errorMessage))
            {
                MessageBox.Show("Đã nạp kỳ đối soát thành công! [" + lsMoneyReturn.Count + "] ", PBean.MESSAGE_TITLE);
                MessageBox.Show("Không tìm thấy vận đơn tương ứng với BT3 Code đối soát [" + lsMoneyReturnError.Count + "] ", PBean.MESSAGE_TITLE);
                MessageBox.Show("Dữ liệu đối soát đã tồn tại! [" + lsMoneyReturnExist.Count + "] ", PBean.MESSAGE_TITLE);
                btnSave.Enabled = false;
                txtFilePath.Text = string.Empty;
                txtNote.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(_errorMessage, PBean.MESSAGE_TITLE);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            tabControl.SelectedTab = tab02;
            btnBrowser.Enabled = true;
            gridChild.DataSource = null;
            txtNote.Text = string.Empty;
            txtFilePath.Text = string.Empty;
            lblSubCount.Text = "0";
            lblSubHoanTien.Text = "0";
            lblSubPhi.Text = "0";
            lblSubThuHo.Text = "0";
            cmbSubTaiKhoan.SelectedValue = "9999";
        }

        private void btnTruyVanDonChuaPhatHanh_Click(object sender, EventArgs e)
        {
            // Load danh sách Session
            var ls = _logic.GetMoneyReturnSessionList(cmbTaiKhoan.SelectedValue.ToString(), dateFrom.Value, dateTo.Value, PBean.USER.CardId);
            gridParrent.AutoGenerateColumns = false;
            gridParrent.DataSource = ls;
            lblCountChild.Text = ls.Count.ToString();
            lblHoanTra.Text = PCommon.FormatNumber(ls.Sum(s => s.MoneyReturn).ToString());
            lblThuHo.Text = PCommon.FormatNumber(ls.Sum(s => s.BT3COD).ToString());
            lblPhi.Text = PCommon.FormatNumber(ls.Sum(s => s.BT3TotalFee).ToString());

        }

        private void gridParrent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = gridParrent.SelectedRows[0].Index;
                view_GExpMoneyReturnSession session = _logic.GetMoneyReturnSessionDetail(Convert.ToString(gridParrent.Rows[index].Cells["col_ParrentId"].Value));
                if (null != session)
                {
                    isNew = false;
                    tabControl.SelectedTab = tab02;
                    txtNote.Text = session.Note;
                    cmbSubTaiKhoan.SelectedValue = session.FK_ProviderAccount;
                    // Fill các giá trị
                    lblSubHoanTien.Text = PCommon.FormatNumber(session.MoneyReturn.ToString());
                    lblSubPhi.Text = PCommon.FormatNumber(session.BT3TotalFee.ToString());
                    lblSubThuHo.Text = PCommon.FormatNumber(session.BT3COD.ToString());
                    var ls = _logic.GetMoneyReturnList(session.Id);
                    gridChild.AutoGenerateColumns = false;
                    gridChild.DataSource = ls;
                    lblSubCount.Text = ls.Count.ToString();
                    btnReadData.Enabled = false;
                    btnBrowser.Enabled = false;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gridParrent.SelectedRows[0].Index;
                if (MessageBox.Show("Bạn có muốn xóa dữ liệu của đợt đối soát dữ liệu đang chọn không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string message = _logic.DeleteMoneyReturnSession(Convert.ToString(gridParrent.Rows[index].Cells["col_ParrentId"].Value));
                    MessageBox.Show(message, PBean.MESSAGE_TITLE);
                    btnTruyVanDonChuaPhatHanh_Click(sender, e);
                }

            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private void btnNhapXacNhanThuPhi_Click(object sender, EventArgs e)
        {
            if (isBusy == true)
            {
                MessageBox.Show("Đang nhập xác nhận thu phí, vui lòng chờ!", PBean.MESSAGE_TITLE);
                return;
            }
            // Nhập thư mục đối soát
            OpenFileDialog openFiles = new OpenFileDialog();
            openFiles.Filter = "Excel xác nhận thu phí|*.xls";
            openFiles.Multiselect = true;
            if (openFiles.ShowDialog() == DialogResult.OK)
            {
                selectFiles = openFiles.FileNames.ToList();
                progressBar.Visible = true;
                isBusy = true;
                backgroundWorkerNhapXNTP.RunWorkerAsync();
            }
        }
        DataTable GetXacNhanThuPhi(string fileName)
        {
            DataSet ds = NPOIHelper.GetDataSetFromXls(fileName);
            DataTable data = ds.Tables[0];
            return data;
        }

        private void backgroundWorkerNhapXNTP_DoWork(object sender, DoWorkEventArgs e)
        {

            foreach (var item in selectFiles)
            {
                try
                {
                    List<GExpProfit> list = new List<GExpProfit>();
                    DataTable data = GetXacNhanThuPhi(item);
                    foreach (DataRow row in data.Rows)
                    {
                        GExpProfit profit = new GExpProfit();
                        profit.Id = Guid.NewGuid().ToString();
                        string dateString = row["Thời gian xác nhận"].ToString();
                        profit.DateComfirm = DateTime.ParseExact(dateString, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                        profit.BT3Code = row["Mã đơn"].ToString().Trim();
                        profit.StatusName = row["Trạng thái"].ToString().Trim();
                        decimal feeConfirm = 0;
                        if (!decimal.TryParse(row["Phí xác nhận"].ToString().Trim(), out feeConfirm))
                        {
                            feeConfirm = 0;
                        }
                        profit.FeeConfirm = feeConfirm;

                        decimal feeTotal = 0;
                        if (!decimal.TryParse(row["Tổng phí"].ToString().Trim(), out feeTotal))
                        {
                            feeTotal = 0;
                        }
                        profit.FeeTotal = feeTotal;

                        decimal feeProfit = 0;
                        if (!decimal.TryParse(row["Doanh thu âm"].ToString().Trim(), out feeProfit))
                        {
                            feeProfit = 0;
                        }
                        profit.Profit = feeProfit;
                        list.Add(profit);
                    }
                    int count = 0;
                    decimal fee = _logic.InsertProfit(list, out count);
                    TongTienXacNhan = TongTienXacNhan + fee;
                    CountTienXacNhan = CountTienXacNhan + count;
                }
                catch (Exception ex)
                {
                    _errorMessageXNTP += "[" + item + "] " + ex.ToString() + System.Environment.NewLine;
                }
            }

        }

        private void backgroundWorkerNhapXNTP_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            isBusy = false;
            progressBar.Visible = false;

            if (!string.IsNullOrEmpty(_errorMessageXNTP))
            {
                MessageBox.Show(_errorMessageXNTP, PBean.MESSAGE_TITLE);
            }
            MessageBox.Show("Đã nhập xác nhận thu phí với [" + PCommon.FormatNumber(count.ToString()) + "] đơn hàng - Tổng tiền: " + PCommon.FormatNumber(TongTienXacNhan.ToString()), PBean.MESSAGE_TITLE);
        }
    }
}
