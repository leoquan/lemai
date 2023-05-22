using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class VCKetToan
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_BillCode { get; set; }
		public System.String FK_KhachHang { get; set; }
		public System.String MaChiPhi { get; set; }
		public System.Decimal SoDuTruoc { get; set; }
		public System.Decimal SoTien { get; set; }
		public System.Decimal SoDuSau { get; set; }
		public System.DateTime NgayKetToan { get; set; }
		public System.String FK_Account { get; set; }
		public VCKetToan(){}
	}
}
