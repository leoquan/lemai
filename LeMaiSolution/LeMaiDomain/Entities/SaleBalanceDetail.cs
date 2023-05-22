using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class SaleBalanceDetail
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String MaHoaDon { get; set; }
		public System.Int32 SoTien { get; set; }
		public System.Int32 GiaTriTruoc { get; set; }
		public System.Int32 GiaTriSau { get; set; }
		public System.String GhiChu { get; set; }
		public SaleBalanceDetail(){}
	}
}
