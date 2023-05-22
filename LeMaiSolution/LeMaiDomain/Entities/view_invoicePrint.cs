using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_invoicePrint
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.Int32 SortIndex { get; set; }
		public System.String FK_Invoice { get; set; }
		public System.String FK_Service { get; set; }
		public System.Int32 Quantity { get; set; }
		public System.Int32 Price { get; set; }
		public System.Int32 TotalPrice { get; set; }
		public System.String InvoiceId { get; set; }
		public System.String InvoiceNumber { get; set; }
		public System.DateTime InvoiceDate { get; set; }
		public System.Int32 TotalItem { get; set; }
		public System.Int32 ExtraPrice { get; set; }
		public System.Int32 ServicePrice { get; set; }
		public System.Int32 InvoiceTotal { get; set; }
		public System.Int32 VoucherPrice { get; set; }
		public System.String PCode { get; set; }
		public System.String PName { get; set; }
		public System.String UnitName { get; set; }
		public System.String FullName { get; set; }
		public System.String Code { get; set; }
		public System.String BranchName { get; set; }
		public System.String Address { get; set; }
		public System.String Phone { get; set; }
		public System.String TaxCode { get; set; }
		public System.String Email { get; set; }
		public System.String CusName { get; set; }
		public System.String CusCode { get; set; }
		public System.String CusAddress { get; set; }
		public System.String CusPhone { get; set; }
		public System.String CusEmail { get; set; }
		public System.Int32? Balance { get; set; }
		public view_invoicePrint(){}
	}
}
