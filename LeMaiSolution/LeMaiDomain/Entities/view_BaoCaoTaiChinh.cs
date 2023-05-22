using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_BaoCaoTaiChinh
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String BILL_CODE { get; set; }
		public System.String CapDoDaiLy { get; set; }
		public System.String TrucThuocDaiLy { get; set; }
		public System.DateTime? ThoiGianDatHang { get; set; }
		public System.DateTime ThoiGianKetToan { get; set; }
		public System.String KeyThoiGianKetToan { get; set; }
		public System.String MaDaiLy { get; set; }
		public System.String TenDaiLy { get; set; }
		public System.String MaChiPhi { get; set; }
		public System.String TenChiPhi { get; set; }
		public System.String LoaiThu { get; set; }
		public System.Decimal SoDuTruoc { get; set; }
		public System.Decimal SoTien { get; set; }
		public System.Decimal SoDuSau { get; set; }
		public System.String LoaiTaiKhoan { get; set; }
		public System.Decimal? TrongLuongThanhToan { get; set; }
		public System.DateTime SyncDate { get; set; }
		public System.String PAY_TYPE { get; set; }
		public System.Decimal GOODS_PAYMENT { get; set; }
		public System.Decimal FREIGHT { get; set; }
		public System.Boolean ContractCustomer { get; set; }
		public System.Decimal? SUM_CHIPHI { get; set; }
		public view_BaoCaoTaiChinh(){}
	}
}
