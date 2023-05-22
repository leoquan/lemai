using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_InvoiceList
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.Int32 SortIndex { get; set; }
		public System.String FK_Invoice { get; set; }
		public System.String FK_Service { get; set; }
		public System.Int32 Quantity { get; set; }
		public System.Int32 Price { get; set; }
		public System.Int32 TotalPrice { get; set; }
		public System.String ServiceName { get; set; }
		public System.String UnitName { get; set; }
		public System.DateTime CreateDate { get; set; }
		public view_InvoiceList(){}
	}
}
