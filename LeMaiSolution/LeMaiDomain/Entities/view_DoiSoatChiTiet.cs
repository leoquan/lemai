using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_DoiSoatChiTiet
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_DoiSoat { get; set; }
		public System.String TenKhachHang { get; set; }
		public System.String SoDienThoai { get; set; }
		public System.Int32 SoLuongDon { get; set; }
		public System.Decimal ThuHo { get; set; }
		public System.Decimal ThuHoKT { get; set; }
		public System.Decimal SaiLech { get; set; }
		public System.Decimal CuocGuiTra { get; set; }
		public System.Decimal CuocNhanTra { get; set; }
		public System.Decimal ChiPhi { get; set; }
		public System.Decimal LoiNhuan { get; set; }
		public System.Decimal ThanhToanKH { get; set; }
		public System.Decimal DaThanhToanKH { get; set; }
		public System.String PhuongThucThanhToan { get; set; }
		public System.DateTime? NgayThanhToan { get; set; }
		public System.String GhiChu { get; set; }
		public System.Boolean? IsHoanThanh { get; set; }
		public System.DateTime NgayDoiSoat { get; set; }
		public view_DoiSoatChiTiet(){}
	}
}
