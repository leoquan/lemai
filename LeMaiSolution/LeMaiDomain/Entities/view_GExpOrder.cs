using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_GExpOrder
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String OrderCode { get; set; }
		public System.String AcceptName { get; set; }
		public System.String AcceptPhone { get; set; }
		public System.String AcceptAddress { get; set; }
		public System.String GoodsName { get; set; }
		public System.Decimal COD { get; set; }
		public System.Int32 Weight { get; set; }
		public System.Boolean IsShopPay { get; set; }
		public System.String Note { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String FK_CustomerId { get; set; }
		public System.Int32 StatusOrder { get; set; }
		public System.String PickupUser { get; set; }
		public System.DateTime? PickupDate { get; set; }
		public System.String TransferCode { get; set; }
		public System.String StatusName { get; set; }
		public System.String StatusTextColor { get; set; }
		public System.String StatusBackgroundColor { get; set; }
		public System.String CustomerCode { get; set; }
		public System.String CustomerName { get; set; }
		public System.String CustomerPhone { get; set; }
		public System.String FK_Post { get; set; }
		public System.Int32? ProvinceCode { get; set; }
		public System.Int32? DistrictCode { get; set; }
		public System.String DistrictWard { get; set; }
		public System.Int32? Freight { get; set; }
		public view_GExpOrder(){}
	}
}
