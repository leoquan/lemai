using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpCustomerAccount
	{
		//Khai bao các biến
		public System.String FK_CustomerID { get; set; }
		public System.String FK_AccountObject { get; set; }
		public System.String CreateBy { get; set; }
		public System.DateTime CreateDate { get; set; }
		public ExpCustomerAccount(){}
	}
}
