using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpMoneyReturn
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String BT3Code { get; set; }
		public System.String BillCode { get; set; }
		public System.Int32 Status { get; set; }
		public System.Decimal BT3COD { get; set; }
		public System.Decimal BT3TotalPaid { get; set; }
		public System.Decimal BT3TotalDiscount { get; set; }
		public System.Decimal BT3TotalFee { get; set; }
		public System.Decimal MoneyReturn { get; set; }
		public System.DateTime? DateReturn { get; set; }
		public System.String FK_MoneyReturnSession { get; set; }
		public System.Boolean IsPayCustomer { get; set; }
		public System.DateTime? CustomerPayDate { get; set; }
		public System.String SessionCode { get; set; }
		public GExpMoneyReturn(){}
	}
}
