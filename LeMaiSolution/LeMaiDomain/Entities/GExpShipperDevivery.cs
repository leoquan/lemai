using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpShipperDevivery
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String ShipperId { get; set; }
		public System.String BillCode { get; set; }
		public System.DateTime SignDate { get; set; }
		public System.Decimal TotalCOD { get; set; }
		public System.Boolean IsCash { get; set; }
		public System.DateTime? CashTime { get; set; }
		public System.String FK_AccountCash { get; set; }
		public System.String Note { get; set; }
		public System.String FK_CashId { get; set; }
		public System.String FK_Post { get; set; }
		public System.Boolean IsSign { get; set; }
		public GExpShipperDevivery(){}
	}
}
