using System;
using System.Text;
using System.Security.Cryptography;
namespace LeMaiLogic
{
	/// <summary>
	/// 
	/// </summary>
	public static class HasMethod
	{
		/// <summary>
		/// Hàm băm các ký tự thành mã MD5
		/// </summary>
		/// <param name="input">Chuỗi ký tự cần mã hóa</param>
		/// <returns>Chuỗi ký tự sau khi mã hóa (Độ dài 32 ký tự)</returns>
		public static string GetMD5(string input)
		{
			MD5 md5Hasher = MD5.Create();
			byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
			StringBuilder sBuilder = new StringBuilder();
			for (int i = 0; i < data.Length; i++)
			{
				sBuilder.Append(data[i].ToString("x2"));
			}
			return sBuilder.ToString();
		}

		/// <summary>
		/// Mã hóa
		/// </summary>
		/// <param name="toEncrypt">Chuỗi cần mã hóa</param>
		/// <param name="key">Key hay password</param>
		/// <param name="useHashing">Có mã hóa password md5 hay không?</param>
		/// <returns>Chuỗi đã được mã hóa</returns>
		public static string Encrypt(string toEncrypt)
		{
			byte[] keyArray;
			byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);


			MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
			keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes("navisoft@123"));


			TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
			tdes.Key = keyArray;
			tdes.Mode = CipherMode.ECB;
			tdes.Padding = PaddingMode.PKCS7;

			ICryptoTransform cTransform = tdes.CreateEncryptor();
			byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

			return Convert.ToBase64String(resultArray, 0, resultArray.Length);
		}



		/// <summary>
		/// Giải mã
		/// </summary>
		/// <param name="toDecrypt">Chuỗi cần được giải mã</param>
		/// <param name="key">Key hay password để giải mã</param>
		/// <param name="useHashing">Có sử dụng md5 cho password hay không?</param>
		/// <returns>Chuỗi được giải mã</returns>
		public static string Decrypt(string toDecrypt)
		{
			byte[] keyArray;
			byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);


			MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
			keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes("navisoft@123"));


			TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
			tdes.Key = keyArray;
			tdes.Mode = CipherMode.ECB;
			tdes.Padding = PaddingMode.PKCS7;

			ICryptoTransform cTransform = tdes.CreateDecryptor();
			byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

			return UTF8Encoding.UTF8.GetString(resultArray);
		}
	}
}

