using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class SchoolHocVien
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Code { get; set; }
		public System.String TenHocVien { get; set; }
		public System.String EnglishName { get; set; }
		public System.String NickName { get; set; }
		public System.String DiaChi { get; set; }
		public System.DateTime NamSinh { get; set; }
		public System.Int32 GioiTinh { get; set; }
		public System.String TenPhuHuynh { get; set; }
		public System.String SoDienThoai { get; set; }
		public System.String Zalo { get; set; }
		public System.String Email { get; set; }
		public System.String CreateBy { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String GoogleMap { get; set; }
		public System.String ImageHocVien { get; set; }
		public System.Int32 PercentPrice { get; set; }
		public SchoolHocVien(){}
	}
}
