using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class SaleBangGiaChiTiet
	{
		//Khai bao các biến
		public System.String FK_BangGia { get; set; }
		public System.String FK_SanPham { get; set; }
		public System.Int32 GiaBan { get; set; }
		public SaleBangGiaChiTiet(){}
	}
}
