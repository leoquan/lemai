using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_GExpBillDelivery
	{
		//Khai bao các biến
		public System.String BillCode { get; set; }
		public System.Decimal BillWeight { get; set; }
		public System.Decimal FeeWeight { get; set; }
		public System.String RegisterUser { get; set; }
		public System.String RegisterSiteCode { get; set; }
		public System.Decimal Freight { get; set; }
		public System.String PayType { get; set; }
		public System.Decimal COD { get; set; }
		public System.String SendMan { get; set; }
		public System.String SendManUs { get; set; }
		public System.String SendManPhone { get; set; }
		public System.String SendManAddress { get; set; }
		public System.Int32 AcceptProvinceCode { get; set; }
		public System.Int32 AcceptDistrictCode { get; set; }
		public System.String AcceptWardCode { get; set; }
		public System.String AcceptMan { get; set; }
		public System.String AcceptManUs { get; set; }
		public System.String AcceptManPhone { get; set; }
		public System.String AcceptManAddress { get; set; }
		public System.String AcceptProvince { get; set; }
		public System.String AcceptDistrict { get; set; }
		public System.String AcceptWard { get; set; }
		public System.Boolean IsSigned { get; set; }
		public System.Boolean IsReturn { get; set; }
		public System.Int32 BillProcessStatus { get; set; }
		public System.DateTime RegisterDate { get; set; }
		public System.DateTime? SignedDate { get; set; }
		public System.DateTime LastUpdateDate { get; set; }
		public System.String LastUpdateUser { get; set; }
		public System.String Note { get; set; }
		public System.DateTime SystemDate { get; set; }
		public System.String BT3Type { get; set; }
		public System.String BT3Code { get; set; }
		public System.String BT3CodeSub { get; set; }
		public System.String BT3Status { get; set; }
		public System.Decimal? BT3Freight { get; set; }
		public System.Decimal? BT3COD { get; set; }
		public System.String BT3PayType { get; set; }
		public System.String BT3LastMess { get; set; }
		public System.String GoodsName { get; set; }
		public System.Int32 GoodsNumber { get; set; }
		public System.String GoodsCode { get; set; }
		public System.Int32 GoodsW { get; set; }
		public System.Int32 GoodsH { get; set; }
		public System.Int32 GoodsL { get; set; }
		public System.String FK_Customer { get; set; }
		public System.String FK_ProviderAccount { get; set; }
		public System.DateTime? PayCustomerDate { get; set; }
		public System.Boolean IsPayCustomer { get; set; }
		public System.String ShipperPhoneNumber { get; set; }
		public System.Int32 BillStatus { get; set; }
		public System.String FK_PaymentType { get; set; }
		public System.String FK_ShipType { get; set; }
		public System.String FullAddress { get; set; }
		public System.String CustomerCode { get; set; }
		public System.String PaymentTypeName { get; set; }
		public System.String ShipNoteType { get; set; }
		public System.String StatusName { get; set; }
		public System.String StatusBackgroundColor { get; set; }
		public System.String StatusTextColor { get; set; }
		public System.String FK_ShipperId { get; set; }
		public System.DateTime DeliveryDate { get; set; }
		public view_GExpBillDelivery(){}
	}
}
