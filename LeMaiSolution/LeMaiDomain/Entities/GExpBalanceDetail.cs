using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpBalanceDetail
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_ExtPostFrom { get; set; }
		public System.Int32 CurrentExtPostFrom { get; set; }
		public System.Int32 AfterPostFrom { get; set; }
		public System.String FK_ExtPostTo { get; set; }
		public System.Int32 CurrentExtPostTo { get; set; }
		public System.Int32 AfterPostTo { get; set; }
		public System.Int32 Value { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String CreateBy { get; set; }
		public System.String BillCode { get; set; }
		public System.String Type { get; set; }
		public System.String Note { get; set; }
		public System.Boolean IsDelete { get; set; }
		public System.String FK_AccountDelete { get; set; }
		public System.DateTime? CreateDelete { get; set; }
		public System.String Reason { get; set; }
		public System.String RequestId { get; set; }
		public GExpBalanceDetail(){}
	}
}
