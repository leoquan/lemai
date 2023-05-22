using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpBankEmail
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FromEmail { get; set; }
		public System.DateTime EmailDate { get; set; }
		public System.String EmailId { get; set; }
		public System.String TransactionId { get; set; }
		public System.Decimal MoneyValue { get; set; }
		public System.String ContentBodyCode { get; set; }
		public GExpBankEmail(){}
	}
}
