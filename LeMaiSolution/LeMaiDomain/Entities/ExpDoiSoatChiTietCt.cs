using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpDoiSoatChiTietCt
	{
		//Khai bao các biến
		public System.String BILL_CODE { get; set; }
		public System.String FK_DoiSoatChiTiet { get; set; }
		public System.String NguoiGui { get; set; }
		public System.String NguoiNhan { get; set; }
		public System.String SoDienThoai { get; set; }
		public System.String NoiDen { get; set; }
		public System.Decimal ThuHo { get; set; }
		public System.Decimal? TrongLuong { get; set; }
		public System.String NgayGuiHang { get; set; }
		public System.String NgayKyNhan { get; set; }
		public System.Decimal CuocVanChuyen { get; set; }
		public System.String LoaiThanhToan { get; set; }
		public System.String LoaiKien { get; set; }
		public System.Decimal SoTienThanhToan { get; set; }
		public System.String GhiChu { get; set; }
		public System.Boolean? IsHoanThanh { get; set; }
		public ExpDoiSoatChiTietCt(){}
	}
}
