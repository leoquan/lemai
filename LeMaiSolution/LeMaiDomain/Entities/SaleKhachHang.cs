using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class SaleKhachHang
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String TenKhachHang { get; set; }
		public System.String SoDienThoai { get; set; }
		public System.Int32 SoTienCongNo { get; set; }
		public System.String FK_BangGia { get; set; }
		public SaleKhachHang(){}
	}
}
