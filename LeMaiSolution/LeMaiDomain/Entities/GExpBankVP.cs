using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpBankVP
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String BankName { get; set; }
		public System.String BankCode { get; set; }
		public System.Int32 BankId { get; set; }
		public GExpBankVP(){}
	}
}
