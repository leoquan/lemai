using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class StockImportExportDetail
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_Service { get; set; }
		public System.String FK_StockImporOrExporttId { get; set; }
		public System.Int32 SortIndex { get; set; }
		public System.Decimal Quantity { get; set; }
		public System.Decimal TotalAmountWithOutTax { get; set; }
		public System.Decimal TotalDiscount { get; set; }
		public System.Decimal TaxAmount { get; set; }
		public System.String Lot { get; set; }
		public System.DateTime ExpirationDate { get; set; }
		public System.String FK_Inventory { get; set; }
		public StockImportExportDetail(){}
	}
}
