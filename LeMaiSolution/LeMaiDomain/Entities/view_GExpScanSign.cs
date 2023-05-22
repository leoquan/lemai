using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_GExpScanSign
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String BillCode { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String FK_Post { get; set; }
		public System.String FK_Account { get; set; }
		public System.String Note { get; set; }
		public System.String TenDaiLy { get; set; }
		public System.String ShipperName { get; set; }
		public System.Int32 BalanceValue { get; set; }
		public System.String AcceptMan { get; set; }
		public System.String AcceptManPhone { get; set; }
		public System.String AcceptManAddress { get; set; }
		public System.String AcceptProvince { get; set; }
		public System.Decimal COD { get; set; }
		public System.Decimal Freight { get; set; }
		public System.String PayType { get; set; }
		public System.String SendMan { get; set; }
		public System.String SendManPhone { get; set; }
		public System.Decimal BillWeight { get; set; }
		public System.Decimal FeeWeight { get; set; }
		public view_GExpScanSign(){}
	}
}
