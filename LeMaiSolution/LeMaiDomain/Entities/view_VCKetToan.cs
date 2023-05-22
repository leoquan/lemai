using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_VCKetToan
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
		public System.String FullName { get; set; }
		public System.String TenChiPhi { get; set; }
		public System.Decimal? Rate { get; set; }
		public System.String TenKhachHang { get; set; }
		public System.String MaKhachHang { get; set; }
		public System.Decimal SoNo { get; set; }
		public System.DateTime? Ngay { get; set; }
		public System.DateTime? NgayXuat { get; set; }
		public System.Int32? DonGia { get; set; }
		public System.Decimal? SoLuong { get; set; }
		public System.Decimal? ThanhTien { get; set; }
		public System.Decimal? ThanhToan { get; set; }
		public System.String MaHang { get; set; }
		public System.String TenHang { get; set; }
		public view_VCKetToan(){}
	}
}
