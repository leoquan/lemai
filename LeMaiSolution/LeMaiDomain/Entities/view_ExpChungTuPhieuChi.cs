using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_ExpChungTuPhieuChi
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_Customer { get; set; }
		public System.DateTime NgayChungTu { get; set; }
		public System.String SoHoaDon { get; set; }
		public System.DateTime NgayHoaDon { get; set; }
		public System.Decimal SoTienThu { get; set; }
		public System.Decimal SoTienChi { get; set; }
		public System.String LyDoChi { get; set; }
		public System.String LyDoThu { get; set; }
		public System.String SoChungTuThu { get; set; }
		public System.String SoChungTuChi { get; set; }
		public System.String FK_Account { get; set; }
		public System.DateTime ThangKT { get; set; }
		public System.String FK_KyKetToan { get; set; }
		public System.String NguoiMuaHang { get; set; }
		public System.String DonViMuaHang { get; set; }
		public System.String MaSoThue { get; set; }
		public System.String DiaChi { get; set; }
		public System.Boolean IsPhatHanh { get; set; }
		public System.Decimal TongThuHo { get; set; }
		public System.Decimal TongPhiNhanTra { get; set; }
		public System.Decimal TongPhiGuiTra { get; set; }
		public System.Decimal TongPhiChuaVAT { get; set; }
		public System.Decimal ThueVAT { get; set; }
		public System.Decimal TongPhiVanChuyen { get; set; }
		public System.Int32 SoChungTu { get; set; }
		public System.String CustomerCode { get; set; }
		public System.String CustomerName { get; set; }
		public System.String CustomerPhone { get; set; }
		public System.String TenKy { get; set; }
		public System.String QuyenSoChi { get; set; }
		public System.String QuyenSoThu { get; set; }
		public System.String QuyenSoTongChi { get; set; }
		public view_ExpChungTuPhieuChi(){}
	}
}
