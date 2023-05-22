using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_GExpReceiveTask
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_CustomerId { get; set; }
		public System.String FK_ShipperId { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String FK_Post { get; set; }
		public System.String FK_Account { get; set; }
		public System.String Note { get; set; }
		public System.String ShipperName { get; set; }
		public System.String ShipperPhone { get; set; }
		public System.String TenDaiLy { get; set; }
		public System.String CustomerName { get; set; }
		public System.String CustomerPhone { get; set; }
		public System.String GoogleMap { get; set; }
		public System.String DiaChi { get; set; }
		public System.String NVGiao { get; set; }
		public System.String StatusReceiveName { get; set; }
		public System.String CustomerCode { get; set; }
		public System.String FK_PickupShipper { get; set; }
		public System.DateTime? PickupDate { get; set; }
		public view_GExpReceiveTask(){}
	}
}
