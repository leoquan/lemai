using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class VCXuatHang
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.DateTime Ngay { get; set; }
		public System.String FK_KhachHang { get; set; }
		public System.String FK_MatHang { get; set; }
		public System.String FK_NhapHang { get; set; }
		public System.Decimal SoLuong { get; set; }
		public System.Int32 DonGia { get; set; }
		public System.Decimal ThanhTien { get; set; }
		public System.Decimal ThanhToan { get; set; }
		public System.String FK_Account { get; set; }
		public System.DateTime NgayXuat { get; set; }
		public VCXuatHang(){}
	}
}
