using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_ExpNhapKho
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.DateTime NgayNhapKho { get; set; }
		public System.String FK_NguoiNhapKho { get; set; }
		public System.String FK_SanPham { get; set; }
		public System.Decimal SoLuong { get; set; }
		public System.Decimal DonGia { get; set; }
		public System.Decimal ThanhTien { get; set; }
		public System.String GhiChu { get; set; }
		public System.String TenSanPham { get; set; }
		public System.String DonViTinh { get; set; }
		public System.String FullName { get; set; }
		public view_ExpNhapKho(){}
	}
}
