using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_SchoolPhongGiaoDuc
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String TenPhong { get; set; }
		public System.String EnglishName { get; set; }
		public System.String Phone { get; set; }
		public System.String DiaChi { get; set; }
		public System.String Email { get; set; }
		public System.String TruongPhong { get; set; }
		public System.String DauMoiLienHe { get; set; }
		public System.String SoDienThoai { get; set; }
		public System.String FK_NhanVien { get; set; }
		public System.String FK_SoGiaoDuc { get; set; }
		public System.String CreateBy { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String GoogleMap { get; set; }
		public System.String TenSo { get; set; }
		public System.String FullName { get; set; }
		public view_SchoolPhongGiaoDuc(){}
	}
}
