using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class WebShoping
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Code { get; set; }
		public System.String Tile { get; set; }
		public System.String FK_Customer { get; set; }
		public System.String CusName { get; set; }
		public System.String CusAddress { get; set; }
		public System.String FK_City { get; set; }
		public System.String Email { get; set; }
		public System.String PhoneNumber { get; set; }
		public System.String ReName { get; set; }
		public System.String ReAddress { get; set; }
		public System.String FK_ReCity { get; set; }
		public System.String ReEmail { get; set; }
		public System.String RePhoneNumber { get; set; }
		public System.String ReNote { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.Int32 TotalPrice { get; set; }
		public System.Int32 VoucherPrice { get; set; }
		public System.Int32 TotalItem { get; set; }
		public System.Int32 Status { get; set; }
		public System.Int32 ShipPrice { get; set; }
		public System.String Note { get; set; }
		public System.String FK_DeleteBy { get; set; }
		public System.String DeleteReason { get; set; }
		public System.Boolean IsDelete { get; set; }
		public System.String BranchCode { get; set; }
		public WebShoping(){}
	}
}
