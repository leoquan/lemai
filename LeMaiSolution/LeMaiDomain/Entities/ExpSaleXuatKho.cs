using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpSaleXuatKho
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_Product { get; set; }
		public System.String FK_KhachHang { get; set; }
		public System.Decimal SoLuong { get; set; }
		public System.Decimal DonGia { get; set; }
		public System.Decimal ThanhTien { get; set; }
		public System.Boolean IsThanhToan { get; set; }
		public System.String FK_LoaiThanhToan { get; set; }
		public System.DateTime? NgayThanhToan { get; set; }
		public System.DateTime NgayXuat { get; set; }
		public System.String FK_NguoiXuat { get; set; }
		public ExpSaleXuatKho(){}
	}
}
