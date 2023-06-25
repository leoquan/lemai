using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpDebitComparison
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String DebitComparisonCode { get; set; }
		public System.DateTime DebitComparisonDate { get; set; }
		public System.Int32 SuccessCount { get; set; }
		public System.Int32 ReturnCount { get; set; }
		public System.Int32 PendingCount { get; set; }
		public System.Decimal FeeCost { get; set; }
		public System.Decimal COD { get; set; }
		public System.Decimal ReturnCOD { get; set; }
		public System.String FK_Provider { get; set; }
		public GExpDebitComparison(){}
	}
}
