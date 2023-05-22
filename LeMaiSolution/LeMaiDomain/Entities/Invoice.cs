using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class Invoice
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Code { get; set; }
		public System.String Tile { get; set; }
		public System.String FK_Customer { get; set; }
		public System.String FK_Branch { get; set; }
		public System.String FK_Cashier { get; set; }
		public System.String FK_Employee { get; set; }
		public System.String FK_Voucher { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.Int32 TotalPrice { get; set; }
		public System.Int32 VoucherPrice { get; set; }
		public System.Int32 TotalItem { get; set; }
		public System.String Note { get; set; }
		public System.Int32 Status { get; set; }
		public System.String FK_DeleteBy { get; set; }
		public System.String Reason { get; set; }
		public System.String FK_Room { get; set; }
		public System.Int32 ExtraPrice { get; set; }
		public System.Int32 ServicePrice { get; set; }
		public System.Boolean IsDelete { get; set; }
		public System.Int32? NumberPrint { get; set; }
		public System.String ModifyBy { get; set; }
		public System.String ModifyDate { get; set; }
		public Invoice(){}
	}
}
