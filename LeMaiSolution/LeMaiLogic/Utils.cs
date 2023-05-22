using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace LeMaiLogic
{
	public class Utils
	{
		/// <summary>
		/// GET QUEUE NUMBER
		/// </summary>
		/// <param name="connection"></param>
		/// <param name="KeyName"></param>
		/// <param name="BranchId"></param>
		/// <returns></returns>
		public static int GetQueueNumber(BaseLogicConnectionData connection ,string KeyName, string BranchId)
		{
			IDataContext dc = new dcDataContextM(connection.ConnectionString);
			try
			{
				dc.Open();
				QueueNumber queueNumber = dc.QUeuenumber.GetObjectCon(connection.Schema, "WHERE KeyValue=@KeyValue AND FK_Branch=@FK_Branch",
					"@KeyValue", KeyName,
					"@FK_Branch", BranchId);
				if (queueNumber == null)
				{
					queueNumber = new QueueNumber();
					queueNumber.Id = Guid.NewGuid().ToString();
					queueNumber.Value = 1;
					queueNumber.KeyValue = KeyName;
					queueNumber.FK_Branch = BranchId;
					dc.QUeuenumber.InsertOnSubmit(connection.Schema, queueNumber);
				}
				else
				{
					queueNumber.Value = queueNumber.Value + 1;
					dc.QUeuenumber.Update(connection.Schema, queueNumber);
				}
				dc.SubmitChanges();
				return queueNumber.Value;
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				dc.Close();
			}

		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="textofNumber"></param>
		/// <param name="precision"></param>
		/// <returns></returns>
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
		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		/// <returns></returns>
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
		/// Đọc số thành chữ, thường dùng để đọc số tiền thành chữ
		/// </summary>
		/// <param name="number">Chuỗi số</param>
		/// <returns>Chuỗi chữ</returns>
		public static string ChuyenSoThanhChu(string number)
		{
			string[] strTachPhanSauDauPhay;
			if (number.Contains(".") || number.Contains(","))
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


	}
}
