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
                            _dataDoiSoat = ReadGHN(txtFilePath.Text.Trim());

                        }
                        break;
                    case "VNPOST":
                        {
                            _dataDoiSoat = ReadVNPOST(txtFilePath.Text.Trim());
                        }
                        break;
                    case "GHSV":
                        {
                            _dataDoiSoat = ReadGHSV(txtFilePath.Text.Trim());
                        }
                        break;
                    case "BEST":
                        {
                            _dataDoiSoat = ReadBEST(txtFilePath.Text.Trim());
                        }
                        break;
                    case "JNT":
                        {
                            _dataDoiSoat = ReadJNT(txtFilePath.Text.Trim());
                        }
                        break;
                    case "NINJA":
                        {
                            _dataDoiSoat = ReadNINJA(txtFilePath.Text.Trim());
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
                DataTable result = MakeDataTable();
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
                return MakeDataTable();
            }
        }
        DataTable ReadBEST(string filename)
        {
            try
            {
                DataTable data = ExcelHelper.Read2007Xlsx(txtFilePath.Text.Trim());
                DataTable result = MakeDataTable();
                int i = 0;
                foreach (DataRow item in data.Rows)
                {
                    // Hiển thị data
                    if (!string.IsNullOrEmpty(item["Mã vận đơn"].ToString()))
                    {
                        DataRow dr = result.NewRow();
                        i++;
                        // Định dạng cũ
                        //Trả về hay không Có là hoàn, Không là giao thành công Không Có
                        dr["Id"] = i.ToString();
                        dr["BT3Code"] = item["Mã vận đơn"].ToString().Trim();
                        dr["BillCode"] = item["mã đối tác"].ToString();
                        dr["Status"] = 0;
                        string statusName = item["Trả về hay không"].ToString();
                        if (statusName == "Không")
                        {
                            dr["Status"] = 1;
                            dr["MoneyReturnStatusName"] = "Giao hàng thành công";
                        }
                        else
                        {
                            dr["Status"] = 2;
                            dr["MoneyReturnStatusName"] = "Giao hàng thất bại";
                        }
                        string ngay = item["Thời gian ký nhận"].ToString();
                        if (!string.IsNullOrEmpty(ngay))
                        {
                            DateTime date = DateTime.ParseExact(ngay, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                            dr["DateReturn"] = string.Format("{0:yyyy-MM-dd}", date);
                        }
                        else
                        {
                            dr["DateReturn"] = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
                        }
                        dr["BT3COD"] = item["Số tiền COD trên phiếu thanh toán"].ToString();
                        dr["BT3TotalPaid"] = 0;
                        dr["BT3TotalDiscount"] = 0;
                        dr["BT3TotalFee"] = item["Tổng cước vận chuyển"].ToString();
                        string DoiSoat = item["Khách hàng nhận COD"].ToString();
                        if (string.IsNullOrEmpty(DoiSoat))
                        {
                            dr["MoneyReturn"] = "0";
                        }
                        else
                        {
                            dr["MoneyReturn"] = DoiSoat;
                        }

                        result.Rows.Add(dr);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
                return MakeDataTable();
            }

        }
        DataTable ReadNINJA(string filename)
        {
            try
            {
                DataTable data = ExcelHelper.Read2007Xlsx(txtFilePath.Text.Trim());
                DataTable result = MakeDataTable();
                int i = 0;
                foreach (DataRow item in data.Rows)
                {
                    // Hiển thị data
                    if (!string.IsNullOrEmpty(item["Mã đơn hàng"].ToString()))
                    {
                        i++;
                        DataRow dr = result.NewRow();
                        // Định dạng cũ
                        dr["Id"] = i.ToString();
                        string BT3CodeTemp = item["Mã đơn hàng"].ToString().Trim();

                        dr["BT3Code"] = BT3CodeTemp;

                        dr["BillCode"] = "";
                        dr["Status"] = 0;
                        string statusName = item["Trạng thái đơn hàng"].ToString();
                        if (statusName == "Completed")
                        {
                            dr["Status"] = 1;
                            dr["MoneyReturnStatusName"] = "Giao hàng thành công";
                        }
                        else
                        {
                            dr["Status"] = 2;
                            dr["MoneyReturnStatusName"] = "Giao hàng thất bại";
                        }
                        dr["DateReturn"] = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
                        dr["BT3COD"] = item["Thu hộ"].ToString();
                        dr["BT3TotalPaid"] = 0;
                        dr["BT3TotalDiscount"] = 0;
                        dr["BT3TotalFee"] = item["Tổng phí vận chuyển"].ToString();
                        string DoiSoat = item["Thu hộ"].ToString();
                        if (string.IsNullOrEmpty(DoiSoat))
                        {
                            dr["MoneyReturn"] = "0";
                        }
                        else
                        {
                            dr["MoneyReturn"] = DoiSoat;
                        }

                        result.Rows.Add(dr);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
                return MakeDataTable();
            }

        }
        DataTable ReadJNT(string filename)
        {
            try
            {
                DataTable data = ExcelHelper.Read2007Xlsx(txtFilePath.Text.Trim());
                DataTable result = MakeDataTable();
                foreach (DataRow item in data.Rows)
                {
                    // Hiển thị data
                    if (!string.IsNullOrEmpty(item["Mã vận đơn"].ToString()))
                    {
                        DataRow dr = result.NewRow();
                        dr["Id"] = 0;
                        dr["BT3Code"] = item["Mã vận đơn"].ToString().Trim();
                        dr["BillCode"] = item["Mã đơn KH"].ToString();
                        dr["Status"] = 0;
                        string statusName = item["Ghi chú"].ToString();
                        if (statusName != "Đã hoàn hàng")
                        {
                            dr["Status"] = 1;
                            dr["MoneyReturnStatusName"] = "Giao hàng thành công";
                        }
                        else
                        {
                            dr["Status"] = 2;
                            dr["MoneyReturnStatusName"] = "Giao hàng thất bại";
                        }
                        string ngay = item["Kỳ thanh toán"].ToString();
                        if (!string.IsNullOrEmpty(ngay))
                        {
                            string temp = ngay.Split('_')[1];
                            temp = temp.Split('.')[0];
                            DateTime date = DateTime.ParseExact(temp, "yyyyMMdd", CultureInfo.InvariantCulture);
                            dr["DateReturn"] = string.Format("{0:yyyy-MM-dd}", date);
                        }
                        else
                        {
                            dr["DateReturn"] = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
                        }
                        dr["BT3COD"] = item["Tiền COD"].ToString();
                        dr["BT3TotalPaid"] = 0;
                        dr["BT3TotalDiscount"] = 0;

                        dr["BT3TotalFee"] = item["Vận phí"].ToString();
                        string DoiSoat = item["Tiền thực nhận"].ToString();
                        if (string.IsNullOrEmpty(DoiSoat))
                        {
                            dr["MoneyReturn"] = "0";
                        }
                        else
                        {
                            dr["MoneyReturn"] = DoiSoat;
                        }

                        result.Rows.Add(dr);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
                return MakeDataTable();
            }

        }
        DataTable ReadGHSV(string filename)
        {
            try
            {
                DataTable data = ExcelHelper.Read2007Xlsx(txtFilePath.Text.Trim());
                DataTable result = MakeDataTable();
                foreach (DataRow item in data.Rows)
                {
                    // Hiển thị data
                    if (!string.IsNullOrEmpty(item["Mã Đơn Hàng"].ToString()))
                    {
                        DataRow dr = result.NewRow();
                        // Định dạng cũ
                        dr["Id"] = item["STT"].ToString();
                        string BT3CodeTemp = item["Mã Đơn Hàng"].ToString().Trim();

                        dr["BT3Code"] = BT3CodeTemp.Split('.')[1];
                        dr["BillCode"] = item["Mã Đơn Khách Hàng"].ToString();
                        dr["Status"] = 0;
                        string statusName = item["Trạng Thái Đơn Hàng"].ToString();
                        if (statusName == "Đã Đối Soát Giao Hàng")
                        {
                            dr["Status"] = 1;
                            dr["MoneyReturnStatusName"] = "Giao hàng thành công";
                        }
                        else
                        {
                            dr["Status"] = 2;
                            dr["MoneyReturnStatusName"] = "Giao hàng thất bại";
                        }
                        string ngay = item["Ngày Đối Soát"].ToString();
                        if (!string.IsNullOrEmpty(ngay))
                        {
                            DateTime date = DateTime.ParseExact(ngay, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            dr["DateReturn"] = string.Format("{0:yyyy-MM-dd}", date);
                        }
                        else
                        {
                            dr["DateReturn"] = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
                        }
                        dr["BT3COD"] = item["Thu Hộ"].ToString();
                        dr["BT3TotalPaid"] = 0;
                        dr["BT3TotalDiscount"] = 0;
                        dr["BT3TotalFee"] = item["Phí Ship"].ToString();
                        string DoiSoat = item["Trả Shop"].ToString();
                        if (string.IsNullOrEmpty(DoiSoat))
                        {
                            dr["MoneyReturn"] = "0";
                        }
                        else
                        {
                            dr["MoneyReturn"] = DoiSoat;
                        }

                        result.Rows.Add(dr);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
                return MakeDataTable();
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        DataTable ReadGHN(string filename)
        {
            try
            {
                DataTable data = ExcelHelper.Read2007Xlsx(txtFilePath.Text.Trim());
                DataTable result = MakeDataTable();
                foreach (DataRow item in data.Rows)
                {
                    // Hiển thị data
                    if (!string.IsNullOrEmpty(item["Mã đơn GHN"].ToString()))
                    {
                        DataRow dr = result.NewRow();
                        // Check 2 cái format của GHN
                        if (data.Columns.Contains("(1) + (2) + (3) + (4)"))
                        {
                            // Định dạng cũ
                            dr["Id"] = item["STT"].ToString();
                            dr["BT3Code"] = item["Mã đơn GHN"].ToString();
                            dr["BillCode"] = item["Mã đơn khách hàng"].ToString();
                            dr["Status"] = 0;
                            string statusName = item["Trạng thái"].ToString();
                            if (statusName == "Giao hàng thành công")
                            {
                                dr["Status"] = 1;
                            }
                            else if (statusName == "0")
                            {
                                dr["Status"] = 0;
                            }
                            else if (statusName == "Chuyển hoàn")
                            {
                                dr["Status"] = 2;
                            }
                            dr["MoneyReturnStatusName"] = item["Trạng thái"].ToString();
                            string ngay = item["Ngày giao/trả"].ToString();
                            if (!string.IsNullOrEmpty(ngay))
                            {
                                DateTime date = DateTime.ParseExact(ngay, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                                dr["DateReturn"] = string.Format("{0:yyyy-MM-dd}", date);
                            }
                            else
                            {
                                dr["DateReturn"] = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
                            }

                            dr["BT3COD"] = item["(1)"].ToString();
                            dr["BT3TotalPaid"] = item["(2)"].ToString();
                            dr["BT3TotalDiscount"] = item["(3)"].ToString();
                            dr["BT3TotalFee"] = item["(4)"].ToString();
                            string DoiSoat = item["(1) + (2) + (3) + (4)"].ToString();
                            if (string.IsNullOrEmpty(DoiSoat))
                            {
                                dr["MoneyReturn"] = "0";
                            }
                            else
                            {
                                dr["MoneyReturn"] = DoiSoat;
                            }
                        }
                        else if (data.Columns.Contains("(1) + (2) + (3) + (4) + (5)"))
                        {
                            // Định dạng mới
                            dr["Id"] = item["STT"].ToString();
                            dr["BT3Code"] = item["Mã đơn GHN"].ToString();
                            dr["BillCode"] = item["Mã đơn khách hàng"].ToString();
                            dr["Status"] = 0;
                            string statusName = item["Trạng thái"].ToString();
                            if (statusName == "Giao hàng thành công")
                            {
                                dr["Status"] = 1;
                            }
                            else if (statusName == "0")
                            {
                                dr["Status"] = 0;
                            }
                            else if (statusName == "Chuyển hoàn")
                            {
                                dr["Status"] = 2;
                            }
                            dr["MoneyReturnStatusName"] = item["Trạng thái"].ToString();

                            string ngay = item["Ngày giao/trả"].ToString();
                            if (!string.IsNullOrEmpty(ngay))
                            {
                                DateTime date;
                                if (!DateTime.TryParseExact(ngay, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                                {
                                    date = DateTime.Now;
                                }
                                dr["DateReturn"] = string.Format("{0:yyyy-MM-dd}", date);
                            }
                            else
                            {
                                dr["DateReturn"] = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
                            }
                            dr["BT3COD"] = item["(1)"].ToString();
                            dr["BT3TotalPaid"] = item["(3)"].ToString();
                            dr["BT3TotalDiscount"] = item["(4)"].ToString();
                            dr["BT3TotalFee"] = item["(5)"].ToString();
                            string DoiSoat = item["(1) + (2) + (3) + (4) + (5)"].ToString();
                            if (string.IsNullOrEmpty(DoiSoat))
                            {
                                dr["MoneyReturn"] = "0";
                            }
                            else
                            {
                                dr["MoneyReturn"] = DoiSoat;
                            }
                        }
                        result.Rows.Add(dr);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
                return MakeDataTable();
            }

        }
        public DataTable MakeDataTable()
        {
            DataTable data = new DataTable();
            data.Columns.Add("Id", Type.GetType("System.String"));//STT
            data.Columns.Add("BT3Code", Type.GetType("System.String")); //Mã đơn GHN
            data.Columns.Add("BillCode", Type.GetType("System.String"));//Mã đơn khách hàng
            data.Columns.Add("MoneyReturnStatusName", Type.GetType("System.String")); //Trạng thái
            data.Columns.Add("DateReturn", Type.GetType("System.String"));//Ngày giao/trả

            data.Columns.Add("BT3COD", Type.GetType("System.Decimal"));//(1)
            data.Columns.Add("Status", Type.GetType("System.Int32"));
            data.Columns.Add("BT3TotalPaid", Type.GetType("System.Decimal"));//(2)
            data.Columns.Add("BT3TotalDiscount", Type.GetType("System.Decimal"));//(3)
            data.Columns.Add("BT3TotalFee", Type.GetType("System.Decimal"));// (4)
            data.Columns.Add("MoneyReturn", Type.GetType("System.Decimal")); // "(1) + (2) + (3) + (4)"

            // fill data extend
            data.Columns.Add("SendMan", Type.GetType("System.String"));
            data.Columns.Add("SendManPhone", Type.GetType("System.String"));
            data.Columns.Add("AcceptMan", Type.GetType("System.String"));
            data.Columns.Add("AcceptManPhone", Type.GetType("System.String"));
            data.Columns.Add("AcceptProvince", Type.GetType("System.String"));

            data.Columns.Add("COD", Type.GetType("System.Decimal"));
            data.Columns.Add("Freight", Type.GetType("System.Decimal"));
            data.Columns.Add("FeeWeight", Type.GetType("System.Decimal"));
            data.Columns.Add("BillWeight", Type.GetType("System.Decimal"));

            data.Columns.Add("PayType", Type.GetType("System.String"));


            return data;
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
                        #region Chưa implement
                        // ========== Tạm thời phần scan này chưa thực hiện kiểm tra cho ổn thỏa mới cho chạy ===========
                        //// Thêm Scan đơn hàng
                        //GExpScan scan = dc.GExpscan.GetObjectCon(PBean.SCHEMA, "WHERE TypeScan=@TypeScan AND BillCode=@BillCode",
                        //    "@TypeScan", "TRACK6",
                        //    "@BillCode", bill.BillCode);
                        //if (scan == null)
                        //{
                        //    if (mItem.Status == 1)
                        //    {
                        //        scan = new GExpScan();
                        //        scan.Id = Guid.NewGuid().ToString();
                        //        scan.BillCode = bill.BillCode;
                        //        scan.CreateDate = currentDate;
                        //        scan.IsRead = false;
                        //        scan.KeyDate = mItem.Id;
                        //        scan.NameCreate = PBean.USER.FullName;
                        //        scan.UserCreate = PBean.USER.Id;
                        //        scan.Post = PBean.USER.CardId;
                        //        scan.TypeScan = "TRACK6";
                        //        scan.ProblemType = 0;
                        //        scan.Note = _logic.MakeNotForScan(scan.TypeScan, scan.BillCode, bill.AcceptMan, bill.AcceptManPhone);
                        //        dc.GExpscan.InsertOnSubmit(PBean.SCHEMA, scan);
                        //        // Cập nhật trạng thái đơn hàng
                        //        if (bill.BillStatus < 6)
                        //        {
                        //            bill.BillStatus = 6;
                        //            bill.SignedDate = currentDate;
                        //            bill.IsSigned = true;
                        //            dc.GExpbill.Update(PBean.SCHEMA, bill);
                        //        }
                        //    }
                        //    else if (mItem.Status == 2)
                        //    {
                        //        scan = new GExpScan();
                        //        scan.Id = Guid.NewGuid().ToString();
                        //        scan.BillCode = bill.BillCode;
                        //        scan.CreateDate = currentDate;
                        //        scan.IsRead = false;
                        //        scan.KeyDate = mItem.Id;
                        //        scan.NameCreate = PBean.USER.FullName;
                        //        scan.UserCreate = PBean.USER.Id;
                        //        scan.Post = PBean.USER.CardId;
                        //        scan.TypeScan = "TRACK8";
                        //        scan.ProblemType = 0;
                        //        scan.Note = _logic.MakeNotForScan(scan.TypeScan, scan.BillCode, bill.AcceptMan, bill.AcceptManPhone);
                        //        dc.GExpscan.InsertOnSubmit(PBean.SCHEMA, scan);
                        //        // Cập nhật trạng thái đơn hàng
                        //        if (bill.BillStatus < 8)
                        //        {
                        //            bill.BillStatus = 8;
                        //            bill.SignedDate = currentDate;
                        //            bill.IsSigned = true;
                        //            bill.IsReturn = true;
                        //            dc.GExpbill.Update(PBean.SCHEMA, bill);
                        //        }
                        //    }
                        //}
                        #endregion
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
