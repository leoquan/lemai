using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_ExpChungTuCtReport
	{
		//Khai bao các biến
		public System.String FK_ExpChungTu { get; set; }
		public System.String BILL_CODE { get; set; }
		public System.Decimal SoTienPhaiThu { get; set; }
		public System.Decimal SoTienPhaiChi { get; set; }
		public System.String TenNguoiNhan { get; set; }
		public System.String SoDienThoaiNhan { get; set; }
		public System.String DiaChiNhan { get; set; }
		public System.Decimal SoTienThuHo { get; set; }
		public System.Decimal CuocPhiVanChuyen { get; set; }
		public System.String TenHang { get; set; }
		public System.Decimal TrongLuong { get; set; }
		public System.Boolean IsPhatHanh { get; set; }
		public System.Decimal CuocPhiChuaGTGT { get; set; }
		public System.Decimal ThueGTGT { get; set; }
		public System.DateTime NgayGuiHang { get; set; }
		public System.String LoaiThanhToan { get; set; }
		public System.String DiaChi { get; set; }
		public System.String DonViMuaHang { get; set; }
		public System.String MaSoThue { get; set; }
		public System.String NguoiMuaHang { get; set; }
		public System.String SoHoaDon { get; set; }
		public System.DateTime NgayHoaDon { get; set; }
		public System.DateTime NgayChungTu { get; set; }
		public System.String SoChungTuThu { get; set; }
		public System.String SoChungTuChi { get; set; }
		public System.DateTime ThangKT { get; set; }
		public System.Decimal ThueVAT { get; set; }
		public System.Decimal TongPhiVanChuyen { get; set; }
		public System.Decimal TongPhiChuaVAT { get; set; }
		public System.Int32 SoChungTu { get; set; }
		public System.String TenKy { get; set; }
		public System.String QuyenSoChi { get; set; }
		public System.String QuyenSoThu { get; set; }
		public System.String QuyenSoTongChi { get; set; }
		public System.String CustomerCode { get; set; }
		public System.String CustomerName { get; set; }
		public System.String CustomerPhone { get; set; }
		public System.String DiaChiGui { get; set; }
		public System.String TenNguoiGui { get; set; }
		public System.String SoDienThoaiGui { get; set; }
		public view_ExpChungTuCtReport(){}
	}
}
