using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpConsignment
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String MaDonHang { get; set; }
		public System.String TenHang { get; set; }
		public System.Int32 SoLuong { get; set; }
		public System.Int32 TrongLuongGram { get; set; }
		public System.Int32? GiaTriTienHang { get; set; }
		public System.String FK_YeuCauKhiGiao { get; set; }
		public System.String YeuCauKhac { get; set; }
		public System.String FK_NguoiGui { get; set; }
		public System.String FK_NguoiNhan { get; set; }
		public System.String FK_LoaiMatHang { get; set; }
		public System.String FK_ExpProvider { get; set; }
		public System.String FK_CachVanChuyen { get; set; }
		public System.String FK_CachGiaoHang { get; set; }
		public System.String FK_CachThanhToan { get; set; }
		public System.String FK_CaLamViec { get; set; }
		public System.String FK_NguoiThuHang { get; set; }
		public System.String FK_ExpPostFrom { get; set; }
		public System.String FK_ExpPostTo { get; set; }
		public System.String FK_ExpStatus { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String CreateBy { get; set; }
		public System.Int32 CuocPhiChinh { get; set; }
		public System.Int32 CuocCongThem { get; set; }
		public System.Int32 PhuPhi { get; set; }
		public System.Int32 ThuHo { get; set; }
		public System.Int32 TongCuoc { get; set; }
		public System.String FK_NhanVienPhat { get; set; }
		public System.String HoTenNguoiKyNhan { get; set; }
		public System.String NguoiGui { get; set; }
		public System.String SoDienThoaiNguoiGui { get; set; }
		public System.String FK_DVHCNguoiGui { get; set; }
		public System.String SoNhaNguoiGui { get; set; }
		public System.String DiaChiNguoiGui { get; set; }
		public System.String NguoiNhan { get; set; }
		public System.String SoDienThoaiNguoiNhan { get; set; }
		public System.String FK_DVHCNguoiNhan { get; set; }
		public System.String SoNhaNguoiNhan { get; set; }
		public System.String DiaChiNguoiNhan { get; set; }
		public System.Int32 PrintNumber { get; set; }
		public ExpConsignment(){}
	}
}
