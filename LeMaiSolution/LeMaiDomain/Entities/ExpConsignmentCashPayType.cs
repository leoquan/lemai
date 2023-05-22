using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpConsignmentCashPayType
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String TenLoai { get; set; }
		public System.Boolean UsingCashPay { get; set; }
		public System.Boolean IsPay { get; set; }
		public System.Boolean Supper { get; set; }
		public System.Boolean RequireBill { get; set; }
		public System.Int32? SortIndex { get; set; }
		public ExpConsignmentCashPayType(){}
	}
}
