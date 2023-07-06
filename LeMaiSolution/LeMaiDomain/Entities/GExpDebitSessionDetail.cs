using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpDebitSessionDetail
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_DebitSession { get; set; }
		public System.Decimal TotalCost { get; set; }
		public System.Decimal TotalFee { get; set; }
		public System.Decimal COD { get; set; }
		public System.Decimal ReturnCODMaster { get; set; }
		public System.Decimal ReturnCODSlave { get; set; }
		public System.String BillCode { get; set; }
		public System.String BT3Code { get; set; }
		public System.String FK_DebitComparisonDetail { get; set; }
		public GExpDebitSessionDetail(){}
	}
}
