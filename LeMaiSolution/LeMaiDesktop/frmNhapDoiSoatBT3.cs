using Common;
using LeMaiDesktop.EnumDefined;
using LeMaiDomain;
using LeMaiLogic;
using LeMaiLogic.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        List<DebitComprisonExcel> _dataDoiSoat = new List<DebitComprisonExcel>();
        private string _Note = string.Empty;
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

        GExpProvider _provider = new GExpProvider();

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
                            _dataDoiSoat = new List<DebitComprisonExcel>();
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
                _provider = _logic.GetProviderDetail(cmbSubTaiKhoan.SelectedValue.ToString());
                _dataDoiSoat = new List<DebitComprisonExcel>();
                switch (_provider.ProviderTypeCode)
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
                        _dataDoiSoat = new List<DebitComprisonExcel>();
                        break;
                }
                // ReFillDataTable(_dataDoiSoat);

                gridChild.DataSource = _dataDoiSoat;
                lblSubCount.Text = PCommon.FormatNumber(_dataDoiSoat.Count.ToString());
                btnSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
                btnSave.Enabled = false;
            }

        }
        void ReFillDataTable(List<DebitComprisonExcel> data)
        {
            IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
            try
            {
                dc.Open();
                foreach (var item in data)
                {
                    GExpBill bill = dc.GExpbill.GetObjectCon(PBean.SCHEMA, "WHERE BT3Code=@BT3Code", "@BT3Code", item.BT3Code);
                    if (bill != null)
                    {
                        item.BillCode = bill.BillCode;
                        item.SendMan = bill.SendMan;
                        item.SendManPhone = bill.SendManPhone;
                        item.AcceptMan = bill.AcceptMan;
                        item.AcceptManPhone = bill.AcceptManPhone;
                        item.AcceptProvince = bill.AcceptProvince;
                        item.COD = bill.COD;
                        item.Freight = bill.Freight;
                        item.FeeWeight = bill.FeeWeight;
                        item.BillWeight = bill.BillWeight;
                        item.PayType = bill.PayType;
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
        List<DebitComprisonExcel> ReadVNPOST(string filename)
        {
            try
            {
                DataSet ds = NPOIHelper.GetDataSetFromXls(filename);
                DataTable data = ds.Tables[0];
                List<DebitComprisonExcel> result = new List<DebitComprisonExcel>();
                int STT = 0;
                foreach (DataRow item in data.Rows)
                {
                    // Hiển thị data
                    if (!string.IsNullOrEmpty(item["Số hiệu bưu gửi"].ToString()))
                    {
                        STT++;
                        DebitComprisonExcel dr = new DebitComprisonExcel();
                        dr.Stt = STT;
                        dr.BT3Code = item["Số hiệu bưu gửi"].ToString();
                        dr.Status = 1;

                        dr.MoneyReturnStatusName = "";
                        DateTime date = DateTime.ParseExact(item["Ngày thu tiền"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        dr.DateDeliveryReturn = date;
                        dr.BT3COD = decimal.Parse(item["Số tiền"].ToString());

                        dr.BT3Paid = 0;
                        dr.Discount = 0;
                        dr.BT3TotalFee = 0;

                        dr.ReturnCOD = decimal.Parse(item["Số tiền"].ToString());

                        result.Add(dr);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
                return new List<DebitComprisonExcel>();
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
            if (_dataDoiSoat.Count > 0)
            {
                count = 0;
                lsMoneyReturn = new List<GExpMoneyReturn>();
                lsMoneyReturnError = new List<GExpMoneyReturn>();
                lsMoneyReturnExist = new List<GExpMoneyReturn>();
                _errorMessage = string.Empty;
                _Note = txtNote.Text.Trim();

                progressBarLuuDoiSoat.Visible = true;
                progressBarLuuDoiSoat.Value = 0;
                progressBarLuuDoiSoat.Maximum = _dataDoiSoat.Count;
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
                if (_provider.IsOwner == (int)enumProviderOwner.Master)
                {
                    // Tài khoản master
                    GExpDebitComparison debit = new GExpDebitComparison();
                    debit.Id = Guid.NewGuid().ToString();
                    if (_dataDoiSoat.Count > 0)
                    {
                        debit.DebitComparisonCode = _dataDoiSoat[0].Session;
                        var checkDebit = dc.GExpdebitcomparison.GetObjectCon(PBean.SCHEMA, "WHERE DebitComparisonCode=@DebitComparisonCode", "@DebitComparisonCode", debit.DebitComparisonCode);
                        if (checkDebit != null)
                        {
                            _errorMessage = "Đã nhập file đối soát cho đợt đối soát: " + debit.DebitComparisonCode;
                            return;
                        }
                    }

                    debit.DebitComparisonDate = currentDate;
                    debit.SuccessCount = 0;
                    debit.ReturnCount = 0;
                    debit.PendingCount = 0;
                    debit.FeeCost = 0;
                    debit.COD = 0;
                    debit.ReturnCOD = 0;
                    debit.FK_Provider = _provider.Id;
                    debit.FK_AccountRefer = PBean.USER.Id;
                    debit.FK_Post = PBean.USER.CardId;


                    foreach (var item in _dataDoiSoat)
                    {
                        GExpDebitComparisonDetail mItem = new GExpDebitComparisonDetail();

                        GExpBill bill = dc.GExpbill.GetObjectCon(PBean.SCHEMA, "WHERE BT3Code=@BT3Code", "@BT3Code", item.BT3Code);
                        if (bill != null)
                        {
                            item.BillCode = bill.BillCode;
                            item.SendMan = bill.SendMan;
                            item.SendManPhone = bill.SendManPhone;
                            item.AcceptMan = bill.AcceptMan;
                            item.AcceptManPhone = bill.AcceptManPhone;
                            item.AcceptProvince = bill.AcceptProvince;
                            item.COD = bill.COD;
                            item.Freight = bill.Freight;
                            item.FeeWeight = bill.FeeWeight;
                            item.BillWeight = bill.BillWeight;
                            item.PayType = bill.PayType;
                        }

                        mItem.Id = Guid.NewGuid().ToString();
                        mItem.FK_DebitComparison = debit.Id;
                        mItem.BT3Code = item.BT3Code;
                        mItem.AcceptMan = item.AcceptMan;
                        mItem.AcceptAddress = item.AcceptProvince;
                        mItem.AcceptManPhone = item.AcceptManPhone;
                        mItem.Status = item.Status;
                        mItem.COD = item.BT3COD;
                        mItem.Fee = item.BT3TotalFee;
                        mItem.IsPayCustomer = false;
                        mItem.DebitComparisonCode = item.Session;
                        mItem.FK_Post = PBean.USER.CardId;
                        mItem.BillCode = item.BillCode;
                        mItem.MoneyReturn = item.ReturnCOD;

                        dc.GExpdebitcomparisondetail.InsertOnSubmit(PBean.SCHEMA, mItem);

                        if (mItem.Status == 1)
                        {
                            debit.SuccessCount++;
                        }
                        else if (mItem.Status == 2)
                        {
                            debit.ReturnCount++;
                        }
                        else if (mItem.Status == 0)
                        {
                            debit.PendingCount++;
                        }
                        debit.FeeCost += mItem.Fee;
                        debit.COD += mItem.COD;
                        debit.ReturnCOD += item.ReturnCOD;

                        backgroundWorkerLuu.ReportProgress(0);
                    }
                    dc.GExpdebitcomparison.InsertOnSubmit(PBean.SCHEMA, debit);
                    dc.SubmitChanges();
                }
                else if (_provider.IsOwner == (int)enumProviderOwner.Single)
                {
                    // Tài khoản của chính bưu cục ký hợp đồng.
                    GExpMoneyReturnSession moneySession = new GExpMoneyReturnSession();
                    moneySession.Id = Guid.NewGuid().ToString();
                    moneySession.Note = _Note;
                    moneySession.FK_ProviderAccount = _provider.Id;
                    moneySession.FK_AccountRefer = PBean.USER.Id;
                    moneySession.DateReturn = currentDate;
                    moneySession.IsPayCustomer = false;

                    if (_dataDoiSoat.Count > 0)
                    {
                        moneySession.SessionCode = _dataDoiSoat[0].Session;
                        var checkSession = dc.GExpmoneyreturnsession.GetObjectCon(PBean.SCHEMA, "WHERE SessionCode=@SessionCode", "@SessionCode", moneySession.SessionCode);
                        if (checkSession != null)
                        {
                            _errorMessage = "Đã nhập file đối soát cho đợt đối soát: " + moneySession.SessionCode;
                            return;
                        }
                    }
                    foreach (var item in _dataDoiSoat)
                    {
                        GExpMoneyReturn mItem = new GExpMoneyReturn();
                        mItem.Id = Guid.NewGuid().ToString();
                        mItem.BT3Code = item.BT3Code;
                        mItem.Status = item.Status;
                        mItem.BT3COD = item.BT3COD;
                        mItem.BT3TotalPaid = item.BT3Paid;
                        mItem.BT3TotalDiscount = item.Discount;
                        mItem.BT3TotalFee = item.BT3TotalFee;
                        mItem.MoneyReturn = item.ReturnCOD;
                        mItem.SessionCode = item.Session;
                        if (item.DateDeliveryReturn.HasValue)
                        {
                            mItem.DateReturn = item.DateDeliveryReturn;
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
                        // Kiểm tra kỳ đối soát 
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
    }
}
