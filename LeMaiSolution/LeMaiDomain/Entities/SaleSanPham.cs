using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class SaleSanPham
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String TenSanPham { get; set; }
		public System.String DonViTinh { get; set; }
		public System.String QuyCach { get; set; }
		public System.Int32 HeSoQuyDoi { get; set; }
		public System.String FK_NhomSanPham { get; set; }
		public SaleSanPham(){}
	}
}
