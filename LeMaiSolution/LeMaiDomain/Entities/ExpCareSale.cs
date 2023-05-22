using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpCareSale
	{
		//Khai bao các biến
		public System.String CustomerId { get; set; }
		public System.String SaleId { get; set; }
		public System.String SaleName { get; set; }
		public System.Int32 SaleValue { get; set; }
		public System.String CareId { get; set; }
		public System.String CareName { get; set; }
		public System.Int32 CareValue { get; set; }
		public System.String CollectId { get; set; }
		public System.String CollectName { get; set; }
		public System.Int32 CollectValue { get; set; }
		public System.Int32 DiffValue { get; set; }
		public ExpCareSale(){}
	}
}
