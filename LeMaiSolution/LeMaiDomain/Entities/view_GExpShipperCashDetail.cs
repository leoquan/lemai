using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_GExpShipperCashDetail
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String BillCode { get; set; }
		public System.Decimal MoneyValue { get; set; }
		public System.Decimal Freight { get; set; }
		public System.Decimal COD { get; set; }
		public System.String PayMentType { get; set; }
		public System.String FK_CashShipper { get; set; }
		public System.String SendMan { get; set; }
		public System.String AcceptMan { get; set; }
		public System.String SendManPhone { get; set; }
		public System.String AcceptManPhone { get; set; }
		public System.String AcceptManAddress { get; set; }
		public view_GExpShipperCashDetail(){}
	}
}
