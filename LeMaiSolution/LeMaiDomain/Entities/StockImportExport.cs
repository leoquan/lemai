using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class StockImportExport
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.Boolean IsImport { get; set; }
		public System.String FK_ProviderOrCustomer { get; set; }
		public System.String FK_Stock { get; set; }
		public System.String Code { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String FK_CreateUser { get; set; }
		public System.Decimal TotalAmountWithOutTax { get; set; }
		public System.Decimal TotalAmountTax { get; set; }
		public System.Decimal TotalTaxAmount { get; set; }
		public System.String Note { get; set; }
		public System.Boolean IsDelete { get; set; }
		public StockImportExport(){}
	}
}
