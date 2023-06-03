using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_GExpShipperDevivery
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
		public System.String ShipperName { get; set; }
		public System.String ShipperPhone { get; set; }
		public System.String TenDaiLy { get; set; }
		public System.String AcceptMan { get; set; }
		public System.String AcceptManPhone { get; set; }
		public System.String AcceptProvince { get; set; }
		public System.Decimal BillWeight { get; set; }
		public System.String SendMan { get; set; }
		public System.String SendManPhone { get; set; }
		public view_GExpShipperDevivery(){}
	}
}
