using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpDebitSession
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String SessionCode { get; set; }
		public System.DateTime DebitSessionDate { get; set; }
		public System.Decimal COD { get; set; }
		public System.Decimal TotalFee { get; set; }
		public System.Decimal ReturnFee { get; set; }
		public System.Decimal InsuranceFee { get; set; }
		public System.Decimal ReturnCOD { get; set; }
		public System.String FK_Account { get; set; }
		public System.String FK_DebitComparison { get; set; }
		public GExpDebitSession(){}
	}
}
