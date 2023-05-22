using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpCheckBalanceDetail
	{
		//Khai bao các biến
		public System.String BalanceType { get; set; }
		public System.String FK_CheckBalance { get; set; }
		public System.String BalanceTypeName { get; set; }
		public System.Decimal MoneyValue { get; set; }
		public System.DateTime CheckDate { get; set; }
		public ExpCheckBalanceDetail(){}
	}
}
