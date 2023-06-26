using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpMoneyReturnSession
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_ProviderAccount { get; set; }
		public System.String Post { get; set; }
		public System.String Note { get; set; }
		public System.Decimal BT3COD { get; set; }
		public System.Decimal BT3TotalPaid { get; set; }
		public System.Decimal BT3TotalDiscount { get; set; }
		public System.Decimal BT3TotalFee { get; set; }
		public System.Decimal MoneyReturn { get; set; }
		public System.String FK_AccountRefer { get; set; }
		public System.DateTime DateReturn { get; set; }
		public System.Boolean IsPayCustomer { get; set; }
		public System.String FK_DoiSoat { get; set; }
		public System.String SessionCode { get; set; }
		public GExpMoneyReturnSession(){}
	}
}
