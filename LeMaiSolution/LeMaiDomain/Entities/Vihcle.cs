using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class Vihcle
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String TenXe { get; set; }
		public System.DateTime NgayMua { get; set; }
		public System.String Note { get; set; }
		public System.Int32 SoKMThayNhot { get; set; }
		public System.Int32 SoKMThayLoc { get; set; }
		public System.Int32 SoKMThayLocDau { get; set; }
		public System.Int32 SoKMThayLocGio { get; set; }
		public System.Int32 SoKMThayNhotHS { get; set; }
		public System.Int32 SoKMThayNhotCau { get; set; }
		public System.Int32 SoThangVSCamBien { get; set; }
		public System.Decimal SoLuongNhot { get; set; }
		public System.Decimal SoLuongNhotLoc { get; set; }
		public System.String MaLocNhot { get; set; }
		public System.String MaLocDau { get; set; }
		public Vihcle(){}
	}
}
