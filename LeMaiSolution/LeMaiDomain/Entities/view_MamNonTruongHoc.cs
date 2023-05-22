using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_MamNonTruongHoc
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Code { get; set; }
		public System.String TenTruong { get; set; }
		public System.String EnglishName { get; set; }
		public System.String Phone { get; set; }
		public System.String DiaChi { get; set; }
		public System.String Email { get; set; }
		public System.String HieuTruong { get; set; }
		public System.String SoDienThoaiHieuTruong { get; set; }
		public System.String DauMoiLienHe { get; set; }
		public System.String SoDienThoai { get; set; }
		public System.String HieuPho1 { get; set; }
		public System.String SoDienThoaiHP1 { get; set; }
		public System.String HieuPho2 { get; set; }
		public System.String SoDienThoaiHP2 { get; set; }
		public System.String FK_NhanVien { get; set; }
		public System.String FK_PhongGiaoDuc { get; set; }
		public System.String FK_TrungTam { get; set; }
		public System.String FK_CapBac { get; set; }
		public System.String CreateBy { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String GoogleMap { get; set; }
		public System.String GoogleMap1 { get; set; }
		public System.String GoogleMap2 { get; set; }
		public System.String GoogleMap3 { get; set; }
		public System.String GoogleMap4 { get; set; }
		public System.String NhanVienFullName { get; set; }
		public System.String TenPhong { get; set; }
		public System.String TrungTam { get; set; }
		public System.String CapBac { get; set; }
		public System.String CreateName { get; set; }
		public view_MamNonTruongHoc(){}
	}
}
