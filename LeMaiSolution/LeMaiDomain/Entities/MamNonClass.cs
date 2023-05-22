using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MamNonClass
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String MaLop { get; set; }
		public System.String TenLop { get; set; }
		public System.String FK_MNTruong { get; set; }
		public System.String NamHoc { get; set; }
		public System.String FK_GiaoTrinh { get; set; }
		public System.String GiaoVienChuNhiem { get; set; }
		public System.String SoDienThoai { get; set; }
		public System.Int32 HocPhi { get; set; }
		public System.Int32 HoaHongTruongPercent { get; set; }
		public MamNonClass(){}
	}
}
