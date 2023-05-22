using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_GExpBillGHN
	{
		//Khai bao các biến
		public System.String BillCode { get; set; }
		public System.String RegisterSiteCode { get; set; }
		public System.String SendMan { get; set; }
		public System.String SendManPhone { get; set; }
		public System.DateTime RegisterDate { get; set; }
		public System.String FK_Customer { get; set; }
		public System.String PayType { get; set; }
		public System.Decimal BillWeight { get; set; }
		public System.Decimal FeeWeight { get; set; }
		public System.String AcceptProvince { get; set; }
		public System.Decimal Freight { get; set; }
		public System.Decimal COD { get; set; }
		public System.Decimal? TOCOD { get; set; }
		public System.String BT3Code { get; set; }
		public System.Decimal? BT3Freight { get; set; }
		public System.String AcceptMan { get; set; }
		public System.String AcceptManPhone { get; set; }
		public System.String Note { get; set; }
		public System.String GoodsName { get; set; }
		public System.Int32 GoodsNumber { get; set; }
		public System.Int32 GoodsW { get; set; }
		public System.Int32 GoodsH { get; set; }
		public System.Int32 GoodsL { get; set; }
		public System.String FK_PaymentType { get; set; }
		public System.String FK_ProviderAccount { get; set; }
		public System.String ProviderTypeCode { get; set; }
		public System.String ProviderName { get; set; }
		public System.String FullAddress { get; set; }
		public System.String ShipNoteType { get; set; }
		public view_GExpBillGHN(){}
	}
}
