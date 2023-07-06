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
        public static List<DebitComprisonExcel> ReadGHN(string filename)
        {
            try
            {
                DataTable data = ExcelHelper.Read2007Xlsx(filename, "STT");
                string CodPhien = ExcelHelper.ReadPhienCODGHN(filename);
                var result = new List<DebitComprisonExcel>();
                foreach (DataRow item in data.Rows)
                {
                    // Hiển thị data
                    if (!string.IsNullOrEmpty(item["Mã đơn GHN"].ToString()))
                    {
                        DebitComprisonExcel dr = new DebitComprisonExcel();
                        dr.Session = CodPhien;
                        dr.Stt = Int32.Parse(item["STT"].ToString());
                        dr.BT3Code = item["Mã đơn GHN"].ToString();
                        dr.BillCode = item["Mã đơn khách hàng"].ToString();
                        dr.Status = 0;
                        dr.MoneyReturnStatusName = item["Trạng thái"].ToString();
                        if (dr.MoneyReturnStatusName == "Giao hàng thành công")
                        {
                            dr.Status = 1;
                        }
                        else if (dr.MoneyReturnStatusName == "Chuyển hoàn")
                        {
                            dr.Status = 2;
                        }

                        string ngay = item["Ngày giao/trả"].ToString();
                        if (!string.IsNullOrEmpty(ngay))
                        {
                            DateTime date;
                            if (!DateTime.TryParseExact(ngay, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                            {
                                date = DateTime.Now;
                            }
                            dr.DateDeliveryReturn = date;
                        }
                        dr.BT3COD = decimal.Parse(item["(1)"].ToString());
                        dr.BT3Paid = decimal.Parse(item["(3)"].ToString());
                        dr.Discount = decimal.Parse(item["(4)"].ToString());
                        dr.BT3TotalFee = decimal.Parse(item["(5)"].ToString());
                        dr.Fee = decimal.Parse(item["(5.1)"].ToString());
                        dr.ReturnFee = decimal.Parse(item["(5.4)"].ToString());
                        dr.OtherFee = decimal.Parse(item["(5.2)"].ToString());
                        dr.InsuranceFee = decimal.Parse(item["(5.3)"].ToString());
                        // Lấy trị tuyệt đối
                        dr.Fee = Math.Abs(dr.Fee);
                        dr.ReturnFee = Math.Abs(dr.ReturnFee);
                        dr.OtherFee = Math.Abs(dr.OtherFee);
                        dr.InsuranceFee = Math.Abs(dr.InsuranceFee);
                        dr.BT3TotalFee = Math.Abs(dr.BT3TotalFee);

                        string DoiSoat = item["(1) + (2) + (3) + (4) + (5)"].ToString();
                        if (string.IsNullOrEmpty(DoiSoat))
                        {
                            dr.ReturnCOD = 0;
                        }
                        else
                        {
                            dr.ReturnCOD = decimal.Parse(DoiSoat);
                        }
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
        public static List<DebitComprisonExcel> ReadJNT(string filename)
        {
            try
            {
                DataTable data = ExcelHelper.Read2007Xlsx(filename);
                var result = new List<DebitComprisonExcel>();
                int stt = 0;
                foreach (DataRow item in data.Rows)
                {
                    // Hiển thị data
                    if (!string.IsNullOrEmpty(item["Mã vận đơn"].ToString()))
                    {
                        DebitComprisonExcel dr = new DebitComprisonExcel();
                        dr.Session = item["Kỳ thanh toán"].ToString();
                        stt++;
                        dr.Stt = stt;
                        dr.BT3Code = item["Mã vận đơn"].ToString().Trim();
                        dr.BillCode = item["Mã đơn KH"].ToString();
                        dr.Status = 0;
                        string statusName = item["Ghi chú"].ToString();
                        if (statusName == "Chưa thanh toán COD")
                        {
                            dr.Status = 0;
                            dr.MoneyReturnStatusName = "Đang trung chuyển";
                        }
                        else if (statusName.ToLower().Contains("hoàn"))
                        {
                            dr.Status = 2;
                            dr.MoneyReturnStatusName = "Giao hàng thất bại";
                        }
                        else if (String.IsNullOrEmpty(statusName.Trim()))
                        {
                            dr.Status = 1;
                            dr.MoneyReturnStatusName = "Giao hàng thành công";
                        }
                        dr.DateDeliveryReturn = DateTime.Now;
                        dr.BT3COD = decimal.Parse(item["Tiền COD"].ToString());
                        dr.BT3Paid = 0;
                        dr.Discount = decimal.Parse(item["Chiết khấu"].ToString());

                        dr.Fee = decimal.Parse(item["Vận phí"].ToString());
                        dr.ReturnFee = decimal.Parse(item["Phí chuyển hoàn"].ToString());
                        dr.OtherFee = decimal.Parse(item["Phí khác"].ToString());
                        dr.InsuranceFee = decimal.Parse(item["Phí COD"].ToString());

                        dr.BT3TotalFee = dr.Fee + dr.ReturnFee + dr.InsuranceFee + dr.OtherFee;

                        string DoiSoat = item["Tiền thực nhận"].ToString();
                        if (string.IsNullOrEmpty(DoiSoat))
                        {
                            dr.ReturnCOD = 0;
                        }
                        else
                        {
                            dr.ReturnCOD = decimal.Parse(DoiSoat);
                        }

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
        public static List<DebitComprisonExcel> ReadGHSV(string filename)
        {
            try
            {
                DataTable data = ExcelHelper.Read2007Xlsx(filename);
                var result = new List<DebitComprisonExcel>();
                foreach (DataRow item in data.Rows)
                {
                    // Hiển thị data
                    if (!string.IsNullOrEmpty(item["Mã Đơn Hàng"].ToString()))
                    {
                        DebitComprisonExcel dr = new DebitComprisonExcel();
                        // Định dạng cũ
                        dr.Stt = Int32.Parse(item["STT"].ToString());
                        string BT3CodeTemp = item["Mã Đơn Hàng"].ToString().Trim();

                        dr.BT3Code = BT3CodeTemp.Split('.')[1];
                        dr.BillCode = item["Mã Đơn Khách Hàng"].ToString();
                        dr.Status = 0;
                        string statusName = item["Trạng Thái Đơn Hàng"].ToString();
                        if (statusName == "Đã Đối Soát Giao Hàng")
                        {
                            dr.Status = 1;
                            dr.MoneyReturnStatusName = "Giao hàng thành công";
                        }
                        else
                        {
                            dr.Status = 2;
                            dr.MoneyReturnStatusName = "Giao hàng thất bại";
                        }
                        string ngay = item["Ngày Đối Soát"].ToString();
                        if (!string.IsNullOrEmpty(ngay))
                        {
                            DateTime date = DateTime.ParseExact(ngay, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            dr.DateDeliveryReturn = date;
                        }
                        dr.BT3COD = decimal.Parse(item["Thu Hộ"].ToString());
                        dr.BT3Paid = 0;
                        dr.Discount = 0;
                        dr.BT3TotalFee = decimal.Parse(item["Phí Ship"].ToString());
                        string DoiSoat = item["Trả Shop"].ToString();
                        if (string.IsNullOrEmpty(DoiSoat))
                        {
                            dr.ReturnCOD = 0;
                        }
                        else
                        {
                            dr.ReturnCOD = decimal.Parse(DoiSoat);
                        }

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
        public static List<DebitComprisonExcel> ReadNINJA(string filename)
        {
            try
            {
                DataTable data = ExcelHelper.Read2007Xlsx(filename);
                var result = new List<DebitComprisonExcel>();
                int i = 0;
                foreach (DataRow item in data.Rows)
                {
                    // Hiển thị data
                    if (!string.IsNullOrEmpty(item["Mã đơn hàng"].ToString()))
                    {
                        i++;
                        DebitComprisonExcel dr = new DebitComprisonExcel();
                        dr.Stt = i;
                        string BT3CodeTemp = item["Mã đơn hàng"].ToString().Trim();

                        dr.BT3Code = BT3CodeTemp;

                        dr.BillCode = "";
                        dr.Status = 0;
                        string statusName = item["Trạng thái đơn hàng"].ToString();
                        if (statusName == "Completed")
                        {
                            dr.Status = 1;
                            dr.MoneyReturnStatusName = "Giao hàng thành công";
                        }
                        else
                        {
                            dr.Status = 2;
                            dr.MoneyReturnStatusName = "Giao hàng thất bại";
                        }
                        dr.DateDeliveryReturn = DateTime.Now;
                        dr.BT3COD = decimal.Parse(item["Thu hộ"].ToString());
                        dr.BT3Paid = 0;
                        dr.Discount = 0;
                        dr.BT3TotalFee = decimal.Parse(item["Tổng phí vận chuyển"].ToString());
                        string DoiSoat = item["Thu hộ"].ToString();
                        if (string.IsNullOrEmpty(DoiSoat))
                        {
                            dr.ReturnCOD = 0;
                        }
                        else
                        {
                            dr.ReturnCOD = decimal.Parse(DoiSoat);
                        }

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
        public static List<DebitComprisonExcel> ReadBEST(string filename)
        {
            try
            {
                DataTable data = ExcelHelper.Read2007Xlsx(filename);
                var result = new List<DebitComprisonExcel>();
                int i = 0;
                foreach (DataRow item in data.Rows)
                {
                    // Hiển thị data
                    if (!string.IsNullOrEmpty(item["Mã vận đơn"].ToString()))
                    {
                        DebitComprisonExcel dr = new DebitComprisonExcel();
                        i++;
                        //Trả về hay không Có là hoàn, Không là giao thành công Không Có
                        dr.Stt = i;
                        dr.BT3Code = item["Mã vận đơn"].ToString().Trim();
                        dr.BillCode = item["mã đối tác"].ToString();
                        dr.Status = 0;
                        string statusName = item["Trả về hay không"].ToString();
                        if (statusName == "Không")
                        {
                            dr.Status = 1;
                            dr.MoneyReturnStatusName = "Giao hàng thành công";
                        }
                        else
                        {
                            dr.Status = 2;
                            dr.MoneyReturnStatusName = "Giao hàng thất bại";
                        }
                        string ngay = item["Thời gian ký nhận"].ToString();
                        if (!string.IsNullOrEmpty(ngay))
                        {
                            DateTime date = DateTime.ParseExact(ngay, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                            dr.DateDeliveryReturn = date;
                        }
                        dr.BT3COD = decimal.Parse(item["Số tiền COD trên phiếu thanh toán"].ToString());
                        dr.BT3Paid = 0;
                        dr.Discount = 0;
                        dr.BT3TotalFee = decimal.Parse(item["Tổng cước vận chuyển"].ToString());
                        string DoiSoat = item["Khách hàng nhận COD"].ToString();
                        if (string.IsNullOrEmpty(DoiSoat))
                        {
                            dr.ReturnCOD = 0;
                        }
                        else
                        {
                            dr.ReturnCOD = decimal.Parse(DoiSoat);
                        }

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
    }
}
