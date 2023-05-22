using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpSaleNhapVatTu
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_VatTu { get; set; }
		public System.DateTime NgayNhap { get; set; }
		public System.String NguoiNhap { get; set; }
		public System.Decimal SoLuong { get; set; }
		public System.Decimal DonGia { get; set; }
		public System.Decimal ThanhTien { get; set; }
		public ExpSaleNhapVatTu(){}
	}
}
