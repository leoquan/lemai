using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpNhapKhoCt
	{
		//Khai bao các biến
		public System.String FK_NhapKho { get; set; }
		public System.String FK_VatTu { get; set; }
		public System.Decimal SoLuong { get; set; }
		public System.Decimal DonGia { get; set; }
		public System.Decimal ThanhTien { get; set; }
		public ExpNhapKhoCt(){}
	}
}
