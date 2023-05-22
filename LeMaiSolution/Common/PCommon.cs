using BarcodeLib.BarcodeReader;
using LeMaiLogic;
using LeMaiDomain;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf.Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Text;

namespace Common
{
    public class PCommon
    {
        public static string CheckSumASTM(string frame)
        {
            const byte ETX = 3;
            const byte ETB = 23;
            const byte STX = 2;

            string checksum = "00";
            int byteVal = 0;
            int sumOfChars = 0;
            bool complete = false;

            //take each byte in the string and add the values
            for (int idx = 0; idx < frame.Length; idx++)
            {
                byteVal = Convert.ToInt32(frame[idx]);

                switch (byteVal)
                {
                    case STX:
                        sumOfChars = 0;
                        break;
                    case ETX:
                    case ETB:
                        sumOfChars += byteVal;
                        complete = true;
                        break;
                    default:
                        sumOfChars += byteVal;
                        break;
                }

                if (complete)
                    break;
            }
            if (sumOfChars > 0)
            {
                //hex value mod 256 is checksum, return as hex value in upper case
                checksum = Convert.ToString(sumOfChars % 256, 16).ToUpper();
            }
            //if checksum is only 1 char then prepend a 0
            return (string)(checksum.Length == 1 ? "0" + checksum : checksum);
        }
        public static string CheckSumHitachi917(string frame)
        {
            const byte ETX = 3;
            const byte ETB = 23;
            const byte STX = 2;

            string checksum = "00";
            int byteVal = 0;
            int sumOfChars = 0;
            bool complete = false;

            //take each byte in the string and add the values
            for (int idx = 0; idx < frame.Length; idx++)
            {
                byteVal = Convert.ToInt32(frame[idx]);

                switch (byteVal)
                {
                    case STX:
                        sumOfChars = 0;
                        break;
                    case ETX:
                    case ETB:
                        //sumOfChars += byteVal;
                        complete = true;
                        break;
                    default:
                        sumOfChars += byteVal;
                        break;
                }

                if (complete)
                    break;
            }
            if (sumOfChars > 0)
            {
                //hex value mod 256 is checksum, return as hex value in upper case
                checksum = Convert.ToString(sumOfChars % 256, 16).ToUpper();
            }
            //if checksum is only 1 char then prepend a 0
            return (string)(checksum.Length == 1 ? "0" + checksum : checksum);
        }

        /// <summary>
        /// Kiểm tra data của excel có đúng định dạng không?
        /// </summary>
        /// <param name="data">Datatable cần check</param>
        /// <param name="checkColum">Cột cần check cách nhau bởi dấu ; VD: colum1;column2....</param>
        /// <returns>Empty nếu data đúng, Error </returns>
        public static string CheckDataTableExcel(DataTable data, string checkColum)
        {
            string errorColumn = string.Empty;
            string[] splitColum = checkColum.Split(';');
            foreach (string columnName in splitColum)
            {
                bool search = false;
                foreach (DataColumn col in data.Columns)
                {
                    if (col.ColumnName.Trim().Equals(columnName.Trim()))
                    {
                        search = true;
                        break;
                    }
                }
                if (!search)
                {
                    errorColumn += columnName + Environment.NewLine;
                }
            }
            return errorColumn;
        }
        public static Dictionary<string, string> MakeReplaceColumnVP(DataTable data)
        {
            Dictionary<string, string> dt = new Dictionary<string, string>();
            foreach (DataRow item in data.Rows)
            {
                if (!dt.ContainsKey(item[0].ToString()))
                {
                    dt.Add(item[0].ToString(), FormatNameVp(item[1].ToString()));
                }

            }
            return dt;
        }
        public static string FormatNameVp(string name)
        {
            string VpName = name.ToString();
            int index = VpName.IndexOf('[');
            if (index != -1)
            {
                VpName = VpName.Substring(0, index);
            }
            VpName = VpName.TrimEnd('[').Trim();
            return VpName;
        }

        public static string[] GetCommonFormulaReport(string reportName)
        {
            List<string> ls = new List<string>();
            // Get Report name
            string[] split = reportName.Trim().Split('\\');
            string fileReportName = split[split.Length - 1];
            // Check report have common Formula
            string reportHasCommon = "b_phieuthungoaihopdong.rpt,";
            reportHasCommon += "bn_hoso14a4.rpt,";
            reportHasCommon += "bn_hoso24a4.rpt,";
            reportHasCommon += "bn_hoso14.rpt,";
            reportHasCommon += "x_ketqua.rpt,";
            reportHasCommon += "c_ketquaxq.rpt,";
            reportHasCommon += "c_ketqua.rpt,";
            reportHasCommon += "c_ketquaxq_a4.rpt,";
            reportHasCommon += "bn_phieuchidinh.rpt,";
            reportHasCommon += "c_ketqua_ecg.rpt,";
            reportHasCommon += "bn_hoso14a4_hsq.rpt,";
            reportHasCommon += "bn_hoso24a4_tocuoi.rpt,";
            reportHasCommon += "bn_hoso14a4_tocuoi.rpt,";
            reportHasCommon += "bn_hoso14a4_sq.rpt,";
            if (!reportHasCommon.Contains(fileReportName.ToLower()))
            {
                return ls.ToArray();
            }
            DateTime date = DateTime.Now;
            ls.Add("h_day");
            ls.Add(date.Day.ToString().Replace("'", "''"));
            ls.Add("h_month");
            ls.Add(date.Month.ToString().Replace("'", "''"));
            ls.Add("h_year");
            ls.Add(date.Year.ToString().Replace("'", "''"));
            //ls.Add("h_user");
            //ls.Add(PBean.USER.hovaten.ToString().Replace("'", "''"));
            //ls.Add("h_ten");
            //ls.Add(PBean.SERVER_OPTION.HOSPITAL_NAME.Replace("'", "''"));
            //ls.Add("h_diachi");
            //ls.Add(PBean.SERVER_OPTION.HOSPITAL_ADDRESS.Replace("'", "''"));
            //ls.Add("h_phone");
            //ls.Add(PBean.SERVER_OPTION.HOSPITAL_PHONE.Replace("'", "''"));
            //ls.Add("h_slogan");
            //ls.Add(PBean.SERVER_OPTION.HOSPITAL_SLOGAN.Replace("'", "''"));

            //if (!string.IsNullOrEmpty(PBean.SERVER_OPTION.LOGO_REPORT))
            //{
            //	ls.Add("h_imagelogo");
            //	ls.Add(AppDomain.CurrentDomain.BaseDirectory + "\\Logo\\" + PBean.SERVER_OPTION.LOGO_REPORT.Replace("'", "''"));
            //}
            //else
            //{
            //	ls.Add("h_imagelogo");
            //	ls.Add(AppDomain.CurrentDomain.BaseDirectory + "\\Logo\\logo.jpg");
            //}
            return ls.ToArray();
        }
        /// <summary>
        /// Lấy file report nếu mà có mẫu khác theo từng công ty
        /// </summary>
        /// <param name="inputReportFile"></param>
        /// <returns></returns>
        public static string GetReportByCompany(string inputReportFile)
        {
            if (string.IsNullOrEmpty(PBean.COMPANY_REPORT_CODE))
            {
                return inputReportFile;
            }
            string returnPath = inputReportFile;
            string tempPath = Path.Combine(Path.GetDirectoryName(inputReportFile), Path.GetFileNameWithoutExtension(inputReportFile));
            string checkPath = tempPath + "_" + PBean.COMPANY_REPORT_CODE.Trim() + ".rpt";
            if (File.Exists(checkPath))
            {
                returnPath = checkPath;
            }
            else
            {
                returnPath = inputReportFile;
            }
            return returnPath;
        }


        /// <summary>
        /// Kiểm tra kết quả bình thường hoặc bất thường của xét nghiệm
        /// </summary>
        /// <param name="ketqua"></param>
        /// <param name="ketquamin"></param>
        /// <param name="ketquamax"></param>
        /// <returns></returns>
        public static bool CheckResultWithExpression(string ketqua, string ketquamin, string ketquamax)
        {
            int checkV2 = CheckResultWithExpressionV2(ketqua, ketquamin, ketquamax);
            if (checkV2 == 1)
                return true;
            else
                return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ketqua"></param>
        /// <param name="ketquamin"></param>
        /// <param name="ketquamax"></param>
        /// <returns>1: Bình thường, 2: Cao, -1: Thấp; 0: Không bằng</returns>
        public static int CheckResultWithExpressionV2(string ketqua, string ketquamin, string ketquamax)
        {
            if (string.IsNullOrEmpty(ketqua.Trim()))
            {
                return 1;
            }
            int result = 1;
            if (ketquamin.Trim().ToUpper() != "X")
            {
                switch (ketquamin.Trim())
                {
                    case "<=":
                        if (PCommon.IsDigit(ketqua) && PCommon.IsDigit(ketquamax))
                        {
                            if (decimal.Parse(ketqua) > decimal.Parse(ketquamax))
                            {
                                result = 2;
                            }
                        }
                        break;
                    case "<":
                        if (PCommon.IsDigit(ketqua) && PCommon.IsDigit(ketquamax))
                        {
                            if (decimal.Parse(ketqua) >= decimal.Parse(ketquamax))
                            {
                                result = 2;
                            }
                        }
                        break;
                    case ">":
                        if (PCommon.IsDigit(ketqua) && PCommon.IsDigit(ketquamax))
                        {
                            if (decimal.Parse(ketqua) <= decimal.Parse(ketquamax))
                            {
                                result = -1;
                            }
                        }
                        break;
                    case ">=":
                        if (PCommon.IsDigit(ketqua) && PCommon.IsDigit(ketquamax))
                        {
                            if (decimal.Parse(ketqua) < decimal.Parse(ketquamax))
                            {
                                result = -1;
                            }
                        }
                        break;
                    case "=":
                        if (PCommon.IsDigit(ketqua) && PCommon.IsDigit(ketquamax))
                        {
                            if (decimal.Parse(ketqua) != decimal.Parse(ketquamax))
                            {
                                result = 0;
                            }
                        }
                        else
                        {
                            if (!ketqua.Trim().ToUpper().Equals(ketquamax.Trim().ToUpper()))
                            {
                                if (ketqua.Trim().ToUpper().Contains("NEG") && ketquamax.Trim().ToUpper().Contains("ÂM"))
                                {
                                    return 1;
                                }
                                if (ketqua.Trim().ToUpper().Contains("POS") && ketquamax.Trim().ToUpper().Contains("DƯƠNG"))
                                {
                                    return 1;
                                }
                                result = 0;
                            }

                            if (!ketqua.Trim().ToUpper().Equals(ketquamax.Trim().ToUpper()))
                            {
                                result = 0;
                            }
                        }
                        break;
                    default:
                        //Kiểm tra xem có phải là số hay không? Tức là giới hạn trong khoảng min - max
                        if (PCommon.IsDigit(ketquamin) && PCommon.IsDigit(ketquamax) && PCommon.IsDigit(ketqua))
                        {
                            if (decimal.Parse(ketqua) < decimal.Parse(ketquamin))
                            {
                                result = -1;
                            }
                            else
                            {
                                if (decimal.Parse(ketqua) > decimal.Parse(ketquamax))
                                {
                                    result = 2;
                                }
                                else
                                {
                                    // Bình thường
                                    result = 1;
                                }
                            }
                        }
                        break;
                }
            }
            return result;
        }
        public static bool IsDigit(string value)
        {
            if (string.IsNullOrEmpty(value.Trim()))
            {
                return false;
            }
            bool result = true;
            char[] items = value.Replace(",", "").ToCharArray();
            bool haveDecimal = false;
            foreach (char c in items)
            {
                if (c != 46)
                {
                    if (c < 48 || c > 57)
                    {
                        return false;
                    }

                }
                else
                {
                    if (haveDecimal)
                    {
                        return false;
                    }
                    else
                    {
                        haveDecimal = true;
                    }
                }
            }
            return result;
        }
        public static IDataContext getDataContext()
        {
            return new dcDataContextM(PBean.CONNECTION_STRING);
        }
        public static IDataContext getDataContext(string connection)
        {
            return new dcDataContextM(connection);
        }
        /// <summary>
        /// Hiển thị chuỗi dữ liệu theo định dạng của hệ thống.
        /// </summary>
        /// <param name="textofNumber">Chỗi số cần định dạng. VD: 100000.50923. Text thường được lấy từ hàm convert số sang chuỗi.</param>
        /// <param name="precision">Số ký tự thập phân cần lấy</param>
        /// <returns>Chuỗi kết quả sau khi format</returns>
        public static string FormatNumber(string textofNumber, int precision = 0)
        {
            try
            {
                string thousandString;
                string decimalString = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                if (decimalString.Equals("."))
                {
                    thousandString = ",";
                }
                else
                {
                    thousandString = ".";
                }

                string soam = string.Empty;
                string result = string.Empty;
                string temp = string.Empty;
                if (textofNumber.IndexOf('-') != -1)
                {
                    soam = "-";
                    textofNumber = textofNumber.Replace("-", string.Empty);
                }
                string[] s = textofNumber.Split(Convert.ToChar(decimalString));
                if (s.Length == 1)//Không có dấu phân cách phần thập phân
                {
                    result = s[0].Replace(thousandString, string.Empty);

                    if (result.Length > 3)
                    {
                        char[] r = result.ToCharArray();
                        result = string.Empty;
                        for (int i = 1; i <= r.Length; i++)
                        {
                            if (i % 3 == 0 && i > 0 && i != r.Length)
                            {
                                result = thousandString + r[r.Length - i] + result;
                            }
                            else
                            {
                                result = r[r.Length - i] + result;
                            }
                        }
                    }
                    if (precision > 0)
                    {
                        string pad = string.Empty.PadRight(precision, '0');
                        if (double.Parse(pad) != 0)
                        {
                            result = result + decimalString + pad;

                        }
                    }

                    return soam + result;
                }
                else
                {
                    if (s.Length == 2)
                    {
                        result = s[0].Replace(thousandString, string.Empty);
                        if (result.Length > 3)
                        {
                            char[] r = result.ToCharArray();
                            result = string.Empty;
                            for (int i = 1; i <= r.Length; i++)
                            {
                                if (i % 3 == 0 && i > 0 && i != r.Length)
                                {
                                    result = thousandString + r[r.Length - i] + result;
                                }
                                else
                                {
                                    result = r[r.Length - i] + result;
                                }
                            }
                        }
                        if (precision >= s[1].Length)
                        {
                            s[1] = s[1].PadRight(precision, '0');
                            return soam + result + decimalString + s[1];
                        }
                        else
                        {
                            if (precision > 0)
                            {
                                return soam + result + decimalString + s[1].Substring(0, precision);
                            }
                            else
                            {
                                return soam + result;
                            }

                        }
                    }
                    else
                    {
                        return textofNumber;
                    }
                }

            }
            catch
            {
                return textofNumber;
            }
        }

        /// <summary>
        /// Thêm cột hình ảnh vào trong table
        /// </summary>
        /// <param name="objDataTable">DataTable cần thêm vào</param>
        /// <param name="strFieldName"></param>
        public static void AddImageColumn(DataTable objDataTable, string strFieldName)
        {
            try
            {
                DataColumn objDataColumn = new DataColumn(strFieldName, Type.GetType("System.Byte[]"));
                objDataTable.Columns.Add(objDataColumn);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Đưa thêm image vào DataTable
        /// </summary>
        /// <param name="objDataRow">DataRow cần đưa vào</param>
        /// <param name="strImageField">Tên Cột cần đưa vào</param>
        /// <param name="FilePath">Đường dẫn của file image.</param>
        public static void SetImageToDataTable(DataRow objDataRow, string strImageField, string FilePath)
        {
            try
            {
                FileStream fs = new FileStream(FilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] xByte = new byte[fs.Length];
                fs.Read(xByte, 0, Convert.ToInt32(fs.Length));
                fs.Close();
                objDataRow[strImageField] = xByte;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void SetImageToDataTable(DataRow objDataRow, string strImageField, System.Drawing.Image imgData)
        {
            try
            {
                ImageConverter _imageConverter = new ImageConverter();
                byte[] xByte = (byte[])_imageConverter.ConvertTo(imgData, typeof(byte[]));
                objDataRow[strImageField] = xByte;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Viết hoa chữ cái đầu dòng. VD: nguyễn Văn thành -> Nguyễn Văn thành
        /// </summary>
        /// <param name="s">Chuỗi ký tự đầu vào</param>
        /// <returns></returns>
        public static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
        /// <summary>
        /// Convert những ký tự đầu thành chữ hoa. VD: NGuyễn văn thành -> Nguyễn Văn Thành
        /// </summary>
        /// <param name="value">Chuỗi ký tự đầu vào</param>
        /// <returns>Chuỗi đã được viết hoa chữ đầu dòng</returns>
        public static string UppercaseWords(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }
            else
            {
                value = value.ToLower();
                char[] array = value.ToCharArray();
                // Handle the first letter in the string.
                if (array.Length >= 1)
                {
                    array[0] = char.ToUpper(array[0]);
                }
                // Scan through the letters, checking for spaces.
                // ... Uppercase the lowercase letters following spaces.
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i - 1] == ' ')
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
                return new string(array);
            }
        }

        public static string SortNameWordUpperCase(string value)
        {
            string name = string.Empty;
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }
            else
            {

                value = value.Trim().ToLower();
                char[] array = value.ToCharArray();
                // Handle the first letter in the string.
                if (array.Length >= 1)
                {
                    array[0] = char.ToUpper(array[0]);
                }
                // Scan through the letters, checking for spaces.
                // ... Uppercase the lowercase letters following spaces.
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i - 1] == ' ')
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
                string temp = new string(array);
                temp = temp.Trim();
                string[] split = temp.Split(' ');
                for (int i = 0; i < split.Length; i++)
                {
                    if (split[i].Length > 0)
                    {
                        name += split[i].Substring(0, 1).ToUpper();
                    }
                }
                return name;
            }
        }
        public static string SortNameWords(string value)
        {
            string name = string.Empty;
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }
            else
            {

                value = value.Trim().ToLower();
                char[] array = value.ToCharArray();
                // Handle the first letter in the string.
                if (array.Length >= 1)
                {
                    array[0] = char.ToUpper(array[0]);
                }
                // Scan through the letters, checking for spaces.
                // ... Uppercase the lowercase letters following spaces.
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i - 1] == ' ')
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
                string temp = new string(array);
                string[] split = temp.Split(' ');
                for (int i = 0; i < split.Length - 1; i++)
                {
                    if (split[i].Length > 0)
                    {
                        name += split[i].Substring(0, 1).ToUpper();
                    }
                }
                name += split[split.Length - 1];
                return name;
            }
        }
        public static string SortNameOnly(string value)
        {
            string name = string.Empty;
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }
            else
            {

                value = value.Trim().ToLower();
                string[] split = value.Split(' ');
                name = split[split.Length - 1];
                name = UppercaseFirst(name);
                return name;
            }
        }
        /// <summary>
        /// Chuyển đổi chuỗi thành chữ thường không dấu
        /// </summary>
        /// <param name="text">Chuỗi đầu vào VD: Nguyễn Minh Tiến</param>
        /// <returns>Chuỗi thường không dấu đầu ra => nguyen minh tien</returns>
        public static string UnSigns(string text)
        {
            string result = text.ToLower();
            string sign = "ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý";
            string unsign = "aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyy";
            for (int i = 0; i < sign.Length; i++)
            {
                result = result.Replace(sign.Substring(i, 1), unsign.Substring(i, 1));
            }
            return result;
        }
        public static string ConvertToUnSign(string text)
        {
            for (int i = 33; i < 48; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }

            for (int i = 58; i < 65; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }

            for (int i = 91; i < 97; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }

            for (int i = 123; i < 127; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }

            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");

            string strFormD = text.Normalize(System.Text.NormalizationForm.FormD);

            return regex.Replace(strFormD, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        /// <summary>
        /// Copy tất cả các file và thư mục trong thư mục được chỉ định vào thư mục gốc.
        /// </summary>
        /// <param name="sourcefolder">Thư mục chứa những file cần copy</param>
        /// <param name="desfolder">Thư mục chứa những file sau khi copy</param>
        public static void CopyAllFiles(string sourcefolder, string desfolder)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(sourcefolder + "\\");
                FileInfo[] listfile = di.GetFiles();
                if (!Directory.Exists(desfolder))
                {
                    Directory.CreateDirectory(desfolder);
                }
                foreach (FileInfo file in listfile)
                {

                    File.Copy(sourcefolder + "\\" + file.Name, desfolder + "\\" + file.Name, true);

                }
                DirectoryInfo[] listdirectory = di.GetDirectories();
                foreach (DirectoryInfo directory in listdirectory)
                {
                    CopyAllFiles(directory.FullName, desfolder + "\\" + directory.Name);
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Copy tất cả các file và thư mục trong thư mục được chỉ định vào thư mục gốc. Không copy file có tên là nonecopy
        /// </summary>
        /// <param name="sourcefolder">Thư mục chứa những file cần copy</param>
        /// <param name="desfolder">Thư mục chứa những file sau khi copy</param>
        /// <param name="nonecopy">Tên file không muốn copy</param>
        public static void CopyAllFiles(string sourcefolder, string desfolder, string nonecopy)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(sourcefolder + "\\");
                FileInfo[] listfile = di.GetFiles();
                if (!Directory.Exists(desfolder))
                {
                    Directory.CreateDirectory(desfolder);
                }
                foreach (FileInfo file in listfile)
                {
                    if (file.Name != nonecopy)
                    {
                        File.Copy(sourcefolder + "\\" + file.Name, desfolder + "\\" + file.Name, true);
                    }

                }
                DirectoryInfo[] listdirectory = di.GetDirectories();
                foreach (DirectoryInfo directory in listdirectory)
                {
                    CopyAllFiles(directory.FullName, desfolder + "\\" + directory.Name);
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Đọc số thành chữ, thường dùng để đọc số tiền thành chữ
        /// </summary>
        /// <param name="number">Chuỗi số</param>
        /// <returns>Chuỗi chữ</returns>
        public static string ChuyenSoThanhChu(string number)
        {
            string[] strTachPhanSauDauPhay;
            if (MyContains(number, '.') || MyContains(number, ','))
            {
                strTachPhanSauDauPhay = number.Split(',', '.');
                return (ChuyenSoThanhChu(strTachPhanSauDauPhay[0]) + "phẩy " + ChuyenSoThanhChu(strTachPhanSauDauPhay[1]));
            }

            string[] dv = { "", "mươi", "trăm", "nghìn", "triệu", "tỉ" };
            string[] cs = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string doc;
            int i, j, k, n, len, found, ddv, rd;

            len = number.Length;
            number += "ss";
            doc = "";
            found = 0;
            ddv = 0;
            rd = 0;

            i = 0;
            while (i < len)
            {
                //So chu so o hang dang duyet
                n = (len - i + 2) % 3 + 1;

                //Kiem tra so 0
                found = 0;
                for (j = 0; j < n; j++)
                {
                    if (number[i + j] != '0')
                    {
                        found = 1;
                        break;
                    }
                }

                //Duyet n chu so
                if (found == 1)
                {
                    rd = 1;
                    for (j = 0; j < n; j++)
                    {
                        ddv = 1;
                        switch (number[i + j])
                        {
                            case '0':
                                if (n - j == 3) doc += cs[0] + " ";
                                if (n - j == 2)
                                {
                                    if (number[i + j + 1] != '0') doc += "linh ";
                                    ddv = 0;
                                }
                                break;
                            case '1':
                                if (n - j == 3) doc += cs[1] + " ";
                                if (n - j == 2)
                                {
                                    doc += "mười ";
                                    ddv = 0;
                                }
                                if (n - j == 1)
                                {
                                    if (i + j == 0) k = 0;
                                    else k = i + j - 1;

                                    if (number[k] != '1' && number[k] != '0')
                                        doc += "mốt ";
                                    else
                                        doc += cs[1] + " ";
                                }
                                break;
                            case '5':
                                if ((i + j == len - 1) || (i + j + 3 == len - 1))
                                    doc += "lăm ";
                                else
                                    doc += cs[5] + " ";
                                break;
                            default:
                                doc += cs[(int)number[i + j] - 48] + " ";
                                break;
                        }

                        //Doc don vi nho
                        if (ddv == 1)
                        {
                            doc += ((n - j) != 1) ? dv[n - j - 1] + " " : dv[n - j - 1];
                        }
                    }
                }
                //Doc don vi lon
                if (len - i - n > 0)
                {
                    if ((len - i - n) % 9 == 0)
                    {
                        if (rd == 1)
                            for (k = 0; k < (len - i - n) / 9; k++)
                                doc += "tỉ ";
                        rd = 0;
                    }
                    else
                        if (found != 0) doc += dv[((len - i - n + 1) % 9) / 3 + 2] + " ";
                }

                i += n;
            }

            if (len == 1)
                if (number[0] == '0' || number[0] == '5') return cs[(int)number[0] - 48];
            string[] check = doc.Split(' ');
            return doc;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="contain"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private static bool MyContains(string contain, char key)
        {
            if (String.IsNullOrEmpty(key.ToString()))
            {
                return true;
            }
            else
            {
                if (contain.IndexOf(key) != -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool FormIsOpened(string name)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == name)
                {
                    frm.Select();
                    return true;
                }
            }
            return false;
        }
        public static Form GetFormIsOpened(string name)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == name)
                {
                    frm.Select();
                    return frm;
                }
            }
            return null;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEMTIME
        {
            public ushort wYear;
            public ushort wMonth;
            public ushort wDayOfWeek;
            public ushort wDay;
            public ushort wHour;
            public ushort wMinute;
            public ushort wSecond;
            public ushort wMilliseconds;
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetSystemTime(ref SYSTEMTIME st);

        [DllImport("kernel32.dll")]
        private extern static void GetSystemTime(ref SYSTEMTIME lpSystemTime);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        public static void SetSysTime(DateTime dt)
        {
            SYSTEMTIME st = new SYSTEMTIME();
            st.wYear = (ushort)dt.Year; // must be short
            st.wMonth = (ushort)dt.Month;
            st.wDayOfWeek = (ushort)dt.DayOfWeek;
            st.wDay = (ushort)dt.Day;
            st.wHour = ChangeHour(dt.Hour);
            st.wMinute = (ushort)dt.Minute;
            st.wSecond = (ushort)dt.Second;
            st.wMilliseconds = (ushort)dt.Millisecond;
            SetSystemTime(ref st);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Ho"></param>
        /// <returns></returns>
        private static ushort ChangeHour(int Ho)
        {
            int hour = 0;
            hour = Ho + 17;
            if (hour > 23)
            {
                hour = hour - 24;
            }
            return (ushort)hour;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        public void FTPDownload(string fileName)
        {
            string _address = string.Empty;
            int _port = 21;
            string _aliasString = string.Empty;
            string _username = string.Empty;
            string _password = string.Empty;

            string addressString = String.Format("ftp://{0}:{1}/{2}/{3}", _address, _port, _aliasString, fileName);

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(addressString);
            request.Credentials = new NetworkCredential(_username, _password);
            request.Method = WebRequestMethods.Ftp.GetFileSize;
            request.Proxy = null;
            long fileSize; // this is the key for ReportProgress
                           //Gửi thông tin đến server để lấy thông tin dung lượng file cần download về
            using (WebResponse resp = request.GetResponse())
            {
                fileSize = resp.ContentLength;
            }

            //Tạo lại một Request để bắt đầu tiến trình download file về máy
            request = (FtpWebRequest)WebRequest.Create(addressString);
            request.Credentials = new NetworkCredential(_username, _password);
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            // change file name
            string fileNameSave = "abc.bmp";
            using (FtpWebResponse responseFileDownload = (FtpWebResponse)request.GetResponse())
            using (Stream responseStream = responseFileDownload.GetResponseStream())
            using (FileStream writeStream = new FileStream("C:\\" + fileNameSave, FileMode.Create))
            {
                int Length = 2048;
                Byte[] buffer = new Byte[Length];
                int bytesRead = responseStream.Read(buffer, 0, Length);
                int bytes = 0;
                while (bytesRead > 0)
                {
                    writeStream.Write(buffer, 0, bytesRead);
                    bytesRead = responseStream.Read(buffer, 0, Length);
                    bytes += bytesRead;// don't forget to increment bytesRead !
                    int totalSize = (int)(fileSize) / 1000; // Kbytes  
                }
            }
        }
        /// <summary>
        /// Get image from file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Image ImageFromFile(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    var bytes = File.ReadAllBytes(path);
                    var ms = new MemoryStream(bytes);
                    var img = Image.FromStream(ms);
                    return img;
                }
                else
                {
                    return null;
                }
            }
            catch (IOException)
            {
                return null;
            }

        }
        /// <summary>
        /// Lấy ID cho các bảng có Primarikey là varchar(36)
        /// </summary>
        /// <returns></returns>
        public static string GetID()
        {
            return Guid.NewGuid().ToString();
        }
        /// <summary>
        /// Lấy IPaddress cua máy
        /// </summary>
        /// <returns></returns>
        public static string GetLocalIPAddress()
        {
            try
            {
                string IP = string.Empty;
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        IP = ip.ToString();
                        break;
                    }
                }
                return IP;
            }
            catch
            {
                return "unknow";
            }
        }
        /// <summary>
        /// Convert String to Image
        /// </summary>
        /// <param name="base64String"></param>
        /// <returns></returns>
        public static System.Drawing.Image Base64ToImage(string base64String)
        {
            try
            {
                // Convert Base64 String to byte[]
                byte[] imageBytes = Convert.FromBase64String(base64String);
                MemoryStream ms = new MemoryStream(imageBytes, 0,
                  imageBytes.Length);

                // Convert byte[] to Image
                ms.Write(imageBytes, 0, imageBytes.Length);
                System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
                return image;
            }
            catch
            {
                return null;
            }

        }
        /// <summary>
        /// Convert Image to String
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static string ImageToBase64(System.Drawing.Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
        public static System.Drawing.Imaging.ImageFormat GetImageFormat(string fileName)
        {
            string extension = Path.GetExtension(fileName);
            if (string.IsNullOrEmpty(extension))
            {
                return null;
            }
            switch (extension.ToLower())
            {
                case @".bmp":
                    return System.Drawing.Imaging.ImageFormat.Bmp;

                case @".gif":
                    return System.Drawing.Imaging.ImageFormat.Gif;

                case @".ico":
                    return System.Drawing.Imaging.ImageFormat.Icon;

                case @".jpg":
                case @".jpeg":
                    return System.Drawing.Imaging.ImageFormat.Jpeg;

                case @".png":
                    return System.Drawing.Imaging.ImageFormat.Png;

                case @".tif":
                case @".tiff":
                    return System.Drawing.Imaging.ImageFormat.Tiff;

                case @".wmf":
                    return System.Drawing.Imaging.ImageFormat.Wmf;

                default:
                    return System.Drawing.Imaging.ImageFormat.Bmp;
            }
        }
        public static string CombinePDFs(string finishFile, List<string> inputFiles, string password)
        {
            try
            {
                using (PdfDocument targetDoc = new PdfDocument())
                {
                    foreach (string pdf in inputFiles)
                    {
                        using (PdfDocument pdfDoc = PdfReader.Open(pdf, PdfDocumentOpenMode.Import))
                        {
                            for (int i = 0; i < pdfDoc.PageCount; i++)
                            {
                                targetDoc.AddPage(pdfDoc.Pages[i]);
                            }
                        }
                    }
                    //
                    if (!string.IsNullOrEmpty(password))
                    {
                        PdfSecuritySettings securitySettings = targetDoc.SecuritySettings;
                        // Setting one of the passwords automatically sets the security level to 
                        securitySettings.UserPassword = password;
                        securitySettings.OwnerPassword = password;
                        // Restrict some rights.
                        securitySettings.PermitAccessibilityExtractContent = false;
                        securitySettings.PermitAnnotations = false;
                        securitySettings.PermitAssembleDocument = false;
                        securitySettings.PermitExtractContent = false;
                        securitySettings.PermitFormsFill = true;
                        securitySettings.PermitFullQualityPrint = false;
                        securitySettings.PermitModifyDocument = true;
                        securitySettings.PermitPrint = false;
                    }
                    targetDoc.Save(finishFile);
                }
                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public static string SetPasswordPDFs(string finishFile, string inputFile, string password, bool deleteFile = false)
        {
            try
            {
                PdfDocument document = PdfReader.Open(inputFile, PdfDocumentOpenMode.Import);
                if (!string.IsNullOrEmpty(password))
                {
                    PdfSecuritySettings securitySettings = document.SecuritySettings;
                    // Setting one of the passwords automatically sets the security level to 
                    securitySettings.UserPassword = password;
                    securitySettings.OwnerPassword = password;
                    // Restrict some rights.
                    securitySettings.PermitAccessibilityExtractContent = false;
                    securitySettings.PermitAnnotations = false;
                    securitySettings.PermitAssembleDocument = false;
                    securitySettings.PermitExtractContent = false;
                    securitySettings.PermitFormsFill = true;
                    securitySettings.PermitFullQualityPrint = false;
                    securitySettings.PermitModifyDocument = true;
                    securitySettings.PermitPrint = false;
                }
                document.Save(finishFile);
                document.Close();
                if (deleteFile)
                {
                    File.Delete(inputFile);
                }
                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public static string GetBarCodeFromImage(string ImagePath)
        {
            String[] datas = BarcodeReader.read(ImagePath, BarcodeReader.CODE128);
            if (datas.Length > 0)
            {
                return datas[0];
            }
            return string.Empty;
        }
        public static string GetBarCodeFromImage(Bitmap image)
        {
            if (image == null)
            {
                return string.Empty;
            }
            String[] datas = BarcodeReader.read(image, BarcodeReader.CODE128);
            if (datas != null && datas.Length > 0)
            {
                return datas[0];
            }
            return string.Empty;
        }
        public static string GetBarCodeFromImage2D(Bitmap image)
        {
            if (image == null)
            {
                return string.Empty;
            }
            String[] datas = BarcodeReader.read(image, BarcodeReader.QRCODE);
            if (datas != null && datas.Length > 0)
            {
                return datas[0];
            }

            return string.Empty;
        }

        public static bool Is64BitOperatingSystem()
        {
            if (IntPtr.Size == 8)  // 64-bit programs run only on Win64
            {
                return true;
            }
            else  // 32-bit programs run on both 32-bit and 64-bit Windows
            {
                // Detect whether the current process is a 32-bit process 
                // running on a 64-bit system.
                bool flag;
                return ((DoesWin32MethodExist("kernel32.dll", "IsWow64Process") &&
                    IsWow64Process(GetCurrentProcess(), out flag)) && flag);
            }
        }

        /// <summary>
        /// The function determins whether a method exists in the export 
        /// table of a certain module.
        /// </summary>
        /// <param name="moduleName">The name of the module</param>
        /// <param name="methodName">The name of the method</param>
        /// <returns>
        /// The function returns true if the method specified by methodName 
        /// exists in the export table of the module specified by moduleName.
        /// </returns>
        static bool DoesWin32MethodExist(string moduleName, string methodName)
        {
            IntPtr moduleHandle = GetModuleHandle(moduleName);
            if (moduleHandle == IntPtr.Zero)
            {
                return false;
            }
            return (GetProcAddress(moduleHandle, methodName) != IntPtr.Zero);
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr GetCurrentProcess();

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr GetModuleHandle(string moduleName);

        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        static extern IntPtr GetProcAddress(IntPtr hModule,
            [MarshalAs(UnmanagedType.LPStr)] string procName);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsWow64Process(IntPtr hProcess, out bool wow64Process);


        public static void DeleteAllFiles(string sourcefolder)
        {
            try
            {
                if (Directory.Exists(sourcefolder))
                {
                    DirectoryInfo di = new DirectoryInfo(sourcefolder + "\\");
                    FileInfo[] listfile = di.GetFiles();
                    foreach (FileInfo file in listfile)
                    {

                        File.Delete(sourcefolder + "\\" + file.Name);

                    }
                    DirectoryInfo[] listdirectory = di.GetDirectories();
                    foreach (DirectoryInfo directory in listdirectory)
                    {
                        DeleteAllFiles(directory.FullName);
                    }
                    Directory.Delete(sourcefolder);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public static bool CompareEx(object obj, object another, out string outResult)
        {
            if (ReferenceEquals(obj, another))
            {
                outResult = string.Empty;

                return true;
            }

            if ((obj == null) || (another == null))
            {
                outResult = string.Empty;
                return false;
            }
            if (obj.GetType() != another.GetType())
            {
                outResult = string.Empty;
                return false;
            }
            if (!obj.GetType().IsClass)
            {
                outResult = string.Empty;
                return obj.Equals(another);
            }
            var result = true;
            foreach (var property in obj.GetType().GetProperties())
            {
                var objValue = property.GetValue(obj);
                var anotherValue = property.GetValue(another);
                if (!objValue.Equals(anotherValue))
                {
                    result = false;

                }
            }
            outResult = string.Empty;
            return result;
        }
    }
}
