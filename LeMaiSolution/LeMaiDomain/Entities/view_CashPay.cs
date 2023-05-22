using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_CashPay
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_Branch { get; set; }
		public System.Boolean IsWithDraw { get; set; }
		public System.Int32 Value { get; set; }
		public System.DateTime AcctionDate { get; set; }
		public System.String FK_Cashier { get; set; }
		public System.String BillNumber { get; set; }
		public System.Int32 Type { get; set; }
		public System.Int32 MoneyType { get; set; }
		public System.String DescriptionMoney { get; set; }
		public System.String FK_AccountObject { get; set; }
		public System.String Note { get; set; }
		public System.Boolean IsDelete { get; set; }
		public System.String FK_AccountDelete { get; set; }
		public System.DateTime? CreateDelete { get; set; }
		public System.String Reason { get; set; }
		public System.Int32 PrintCopied { get; set; }
		public System.String TypeCashName { get; set; }
		public System.String PayForName { get; set; }
		public System.String CashierName { get; set; }
		public System.String BranchName { get; set; }
		public System.String TypeName { get; set; }
		public System.String MoneyTypeName { get; set; }
		public System.String InvoiceCode { get; set; }
		public System.String DeleteName { get; set; }
		public view_CashPay(){}
	}
}
