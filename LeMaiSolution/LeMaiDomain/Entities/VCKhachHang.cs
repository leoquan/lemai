using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class VCKhachHang
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String MaKhachHang { get; set; }
		public System.String TenKhachHang { get; set; }
		public System.String TenKhachHangKD { get; set; }
		public System.Decimal SoNo { get; set; }
		public VCKhachHang(){}
	}
}
