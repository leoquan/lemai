using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class WebShopingDetail
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.Int32 SortIndex { get; set; }
		public System.String FK_Shoping { get; set; }
		public System.String FK_Service { get; set; }
		public System.Int32 Quantity { get; set; }
		public System.Int32 Price { get; set; }
		public System.Int32 TotalPrice { get; set; }
		public System.Int32 Status { get; set; }
		public System.String BranchCode { get; set; }
		public WebShopingDetail(){}
	}
}
