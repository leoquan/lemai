using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_GExpMoneyReturn
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String BT3Code { get; set; }
		public System.String BillCode { get; set; }
		public System.Int32 Status { get; set; }
		public System.Decimal BT3COD { get; set; }
		public System.Decimal BT3TotalPaid { get; set; }
		public System.Decimal BT3TotalDiscount { get; set; }
		public System.Decimal BT3TotalFee { get; set; }
		public System.Decimal MoneyReturn { get; set; }
		public System.DateTime? DateReturn { get; set; }
		public System.Boolean IsPayCustomer { get; set; }
		public System.String FK_MoneyReturnSession { get; set; }
		public System.String ShopName { get; set; }
		public System.String UserApi { get; set; }
		public System.String ProviderName { get; set; }
		public System.String ProviderTypeCode { get; set; }
		public System.String MoneyReturnStatusName { get; set; }
		public System.String SendMan { get; set; }
		public System.String SendManPhone { get; set; }
		public System.String AcceptMan { get; set; }
		public System.String AcceptManPhone { get; set; }
		public System.String AcceptProvince { get; set; }
		public System.Decimal? COD { get; set; }
		public System.Decimal? Freight { get; set; }
		public System.Decimal? FeeWeight { get; set; }
		public System.Decimal? BillWeight { get; set; }
		public System.String PayType { get; set; }
		public System.String FK_Customer { get; set; }
		public System.DateTime? RegisterDate { get; set; }
		public System.String RegisterSiteCode { get; set; }
		public System.String FK_PaymentType { get; set; }
		public System.Decimal? BT3COD_B { get; set; }
		public System.Decimal? BT3Freight_B { get; set; }
		public view_GExpMoneyReturn(){}
	}
}
