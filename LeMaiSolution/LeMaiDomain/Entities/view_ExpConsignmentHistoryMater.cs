using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_ExpConsignmentHistoryMater
	{
		//Khai bao các biến
		public System.String IdHis { get; set; }
		public System.DateTime CreateDateHis { get; set; }
		public System.String CreateByHis { get; set; }
		public System.String ExpPostHis { get; set; }
		public System.String ExpStatusHis { get; set; }
		public System.String PostScanName { get; set; }
		public System.String ScanName { get; set; }
		public System.String ScanStatusName { get; set; }
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
		public System.String YeuCauGiao { get; set; }
		public System.String TenNhaCungCap { get; set; }
		public System.String TenDaiLy { get; set; }
		public System.String ToDaiLy { get; set; }
		public System.String StatusName { get; set; }
		public System.String NguoiTaoDon { get; set; }
		public System.String NguoiPhat { get; set; }
		public System.String NguoiThuHang { get; set; }
		public System.String TenCachGiao { get; set; }
		public System.String CachThanhToan { get; set; }
		public System.String TenCachVanChuyen { get; set; }
		public System.String TenCaLamViec { get; set; }
		public System.String TenLoaiMatHang { get; set; }
		public view_ExpConsignmentHistoryMater(){}
	}
}
