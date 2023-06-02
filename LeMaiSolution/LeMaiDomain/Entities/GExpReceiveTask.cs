using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpReceiveTask
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_CustomerId { get; set; }
		public System.String FK_ShipperId { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String FK_Post { get; set; }
		public System.String FK_Account { get; set; }
		public System.Int32 GoodsNumber { get; set; }
		public System.Boolean HaveReturn { get; set; }
		public System.String Note { get; set; }
		public System.Int32 ReceiveStatus { get; set; }
		public System.String FK_PickupShipper { get; set; }
		public System.DateTime? PickupDate { get; set; }
		public GExpReceiveTask(){}
	}
}
