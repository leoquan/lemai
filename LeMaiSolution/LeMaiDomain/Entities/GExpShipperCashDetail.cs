using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpShipperCashDetail
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String BillCode { get; set; }
		public System.Int32 CashType { get; set; }
		public System.Decimal MoneyValue { get; set; }
		public GExpShipperCashDetail(){}
	}
}
