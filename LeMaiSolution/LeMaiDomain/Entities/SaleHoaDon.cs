using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class SaleHoaDon
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String SoHoaDon { get; set; }
		public System.DateTime NgayBan { get; set; }
		public System.String Note { get; set; }
		public System.String FK_KhachHang { get; set; }
		public System.Int32 TongTien { get; set; }
		public System.Int32 ThanhToan { get; set; }
		public System.Int32 CongNo { get; set; }
		public SaleHoaDon(){}
	}
}
