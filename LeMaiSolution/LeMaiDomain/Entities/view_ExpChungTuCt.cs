using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_ExpChungTuCt
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
		public view_ExpChungTuCt(){}
	}
}
