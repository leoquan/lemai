using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpSaleProduct
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String TenSanPham { get; set; }
		public System.String DonViTinh { get; set; }
		public System.Int32 SoLuongGiaSi { get; set; }
		public System.Int32 GiaLe { get; set; }
		public System.Int32 GiaSi { get; set; }
		public System.Decimal SoLuongTon { get; set; }
		public ExpSaleProduct(){}
	}
}
