using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_ExpSaleXuatKho
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
		public System.String TenLoai { get; set; }
		public System.String TenSanPham { get; set; }
		public System.String DonViTinh { get; set; }
		public System.Int32 GiaLe { get; set; }
		public System.Int32 GiaSi { get; set; }
		public System.Int32 SoLuongGiaSi { get; set; }
		public System.Decimal SoLuongTon { get; set; }
		public System.String CustomerName { get; set; }
		public System.String CustomerPhone { get; set; }
		public System.String CustomerCode { get; set; }
		public System.String FullName { get; set; }
		public System.String STHANHTOAN { get; set; }
		public System.String SNGAYTHANHTOAN { get; set; }
		public view_ExpSaleXuatKho(){}
	}
}
