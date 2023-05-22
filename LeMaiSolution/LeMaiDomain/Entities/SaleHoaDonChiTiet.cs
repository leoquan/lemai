using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class SaleHoaDonChiTiet
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_SanPham { get; set; }
		public SaleHoaDonChiTiet(){}
	}
}
