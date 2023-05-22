using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class SchoolSoGiaoDuc
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String TenSo { get; set; }
		public System.String EnglishName { get; set; }
		public System.String Phone { get; set; }
		public System.String DiaChi { get; set; }
		public System.String Email { get; set; }
		public System.String GiamDoc { get; set; }
		public System.String DauMoiLienHe { get; set; }
		public System.String SoDienThoai { get; set; }
		public System.String FK_NhanVien { get; set; }
		public System.String CreateBy { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String GoogleMap { get; set; }
		public SchoolSoGiaoDuc(){}
	}
}
