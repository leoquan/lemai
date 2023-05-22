using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class SchoolGiaoTrinh
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String MaGiaoTrinh { get; set; }
		public System.String TenGiaoTrinh { get; set; }
		public System.Int32 DonGia { get; set; }
		public System.Int32 GiaBan { get; set; }
		public System.Int32 HoaHongPercent { get; set; }
		public System.String FK_HocPhan { get; set; }
		public System.String CreateBy { get; set; }
		public System.DateTime CreateDate { get; set; }
		public SchoolGiaoTrinh(){}
	}
}
