using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeMaiDesktop
{
    public class ReadDebitComparison
    {
        public static DataTable ReadGHN(string filename)
        {
            try
            {
                DataTable data = ExcelHelper.Read2007Xlsx(filename, "STT");
                string CodPhien = ExcelHelper.ReadPhienCODGHN(filename);
                DataTable result = MakeDataTable();
                foreach (DataRow item in data.Rows)
                {
                    // Hiển thị data
                    if (!string.IsNullOrEmpty(item["Mã đơn GHN"].ToString()))
                    {
                        DataRow dr = result.NewRow();
                        dr["Session"] = CodPhien;
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
        public static DataTable MakeDataTable()
        {
            DataTable data = new DataTable();
            data.Columns.Add("Session", Type.GetType("System.String"));//Phiên giao dịch
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
        public static DataTable ReadJNT(string filename)
        {
            try
            {
                DataTable data = ExcelHelper.Read2007Xlsx(filename);
                DataTable result = MakeDataTable();
                foreach (DataRow item in data.Rows)
                {
                    // Hiển thị data
                    if (!string.IsNullOrEmpty(item["Mã vận đơn"].ToString()))
                    {
                        DataRow dr = result.NewRow();
                        dr["Session"] = item["Kỳ thanh toán"].ToString();
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
        public static DataTable ReadGHSV(string filename)
        {
            try
            {
                DataTable data = ExcelHelper.Read2007Xlsx(filename);
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

        public static DataTable ReadNINJA(string filename)
        {
            try
            {
                DataTable data = ExcelHelper.Read2007Xlsx(filename);
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

        public static DataTable ReadBEST(string filename)
        {
            try
            {
                DataTable data = ExcelHelper.Read2007Xlsx(filename);
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
    }
}
