using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpDebitComparisonDetail
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_DebitComparison { get; set; }
		public System.String BT3Code { get; set; }
		public System.String AcceptMan { get; set; }
		public System.String AcceptAddress { get; set; }
		public System.String AcceptManPhone { get; set; }
		public System.Int32 Status { get; set; }
		public System.Decimal COD { get; set; }
		public System.Decimal Fee { get; set; }
		public System.Boolean IsPayCustomer { get; set; }
		public System.DateTime? PayDate { get; set; }
		public System.String FK_KyDoiSoat { get; set; }
		public System.String FK_Post { get; set; }
		public System.String DebitComparisonCode { get; set; }
		public System.String BillCode { get; set; }
		public System.Decimal MoneyReturn { get; set; }
		public GExpDebitComparisonDetail(){}
	}
}
