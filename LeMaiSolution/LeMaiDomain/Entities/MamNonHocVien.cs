using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MamNonHocVien
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String MaHocVien { get; set; }
		public System.String TenHocVien { get; set; }
		public System.DateTime NgaySinh { get; set; }
		public System.String TenLopTruong { get; set; }
		public System.String TenTiengAnh { get; set; }
		public System.Boolean isGioiTinhNam { get; set; }
		public System.Int32? DoiTuong { get; set; }
		public System.Int32? Speaking1 { get; set; }
		public System.Int32? Listerning1 { get; set; }
		public System.Int32? Total1 { get; set; }
		public System.Int32? Speaking2 { get; set; }
		public System.Int32? Listerning2 { get; set; }
		public System.Int32? Total2 { get; set; }
		public System.Int32? Total { get; set; }
		public MamNonHocVien(){}
	}
}
