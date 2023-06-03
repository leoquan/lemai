using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class Vihcle
	{
		//Khai bao các biến
		public System.String BienSo { get; set; }
		public System.String TenXe { get; set; }
		public System.DateTime NgayMua { get; set; }
		public System.String Note { get; set; }
		public System.Decimal SoLuongNhot { get; set; }
		public System.Decimal SoLuongNhotLoc { get; set; }
		public System.String MaLocNhot { get; set; }
		public System.String MaLocDau { get; set; }
		public System.String MaMay { get; set; }
		public System.String FK_Post { get; set; }
		public Vihcle(){}
	}
}
