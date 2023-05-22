using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class Voucher
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Code { get; set; }
		public System.String Name { get; set; }
		public System.String Description { get; set; }
		public System.DateTime ValidDate { get; set; }
		public System.DateTime ExperidDate { get; set; }
		public System.Boolean IsUsed { get; set; }
		public System.Int32 Value { get; set; }
		public System.Boolean IsPercentValue { get; set; }
		public System.Boolean? IsOnlyService { get; set; }
		public System.String Fk_ServiceOrGroup { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String CreateBy { get; set; }
		public System.Boolean IsDelete { get; set; }
		public System.Boolean IsVoucher { get; set; }
		public System.Boolean IsTotalBill { get; set; }
		public Voucher(){}
	}
}
