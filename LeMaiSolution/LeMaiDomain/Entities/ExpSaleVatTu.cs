using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpSaleVatTu
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String TenVatTu { get; set; }
		public System.String DVT { get; set; }
		public System.String QuyCach { get; set; }
		public System.Decimal QuyCachDVT { get; set; }
		public System.Decimal DonGia { get; set; }
		public System.Decimal? SoLuongTonKho { get; set; }
		public ExpSaleVatTu(){}
	}
}
