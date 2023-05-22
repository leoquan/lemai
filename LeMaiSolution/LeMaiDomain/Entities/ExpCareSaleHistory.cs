using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpCareSaleHistory
	{
		//Khai bao các biến
		public System.String BillCode { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String SaleId { get; set; }
		public System.String CareId { get; set; }
		public System.String CollectId { get; set; }
		public System.Int32 SaleValue { get; set; }
		public System.Int32 CareValue { get; set; }
		public System.Int32 CollectValue { get; set; }
		public ExpCareSaleHistory(){}
	}
}
