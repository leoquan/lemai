using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class VCNhapHang
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.DateTime Ngay { get; set; }
		public System.String FK_NhaCungCap { get; set; }
		public System.String FK_MatHang { get; set; }
		public System.Int32 LanThu { get; set; }
		public System.Decimal SoLuong { get; set; }
		public System.String FK_Account { get; set; }
		public System.DateTime NgayNhap { get; set; }
		public System.Decimal Xuat { get; set; }
		public VCNhapHang(){}
	}
}
