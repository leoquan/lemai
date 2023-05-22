using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_GExpBillGHNApi
	{
		//Khai bao các biến
		public System.String BillCode { get; set; }
		public System.Decimal BillWeight { get; set; }
		public System.Decimal Freight { get; set; }
		public System.Decimal COD { get; set; }
		public System.String SendMan { get; set; }
		public System.String SendManPhone { get; set; }
		public System.String SendManAddress { get; set; }
		public System.String AcceptMan { get; set; }
		public System.String AcceptManPhone { get; set; }
		public System.String AcceptManAddress { get; set; }
		public System.String AcceptProvince { get; set; }
		public System.Int32 AcceptProvinceCode { get; set; }
		public System.String AcceptProvinceCodeS { get; set; }
		public System.String AcceptDistrict { get; set; }
		public System.Int32 AcceptDistrictCode { get; set; }
		public System.String AcceptDistrictCodeS { get; set; }
		public System.String AcceptWard { get; set; }
		public System.String AcceptWardCode { get; set; }
		public System.String AcceptWardCodeS { get; set; }
		public System.DateTime RegisterDate { get; set; }
		public System.String Note { get; set; }
		public System.String BT3Code { get; set; }
		public System.String GoodsName { get; set; }
		public System.Int32 GoodsNumber { get; set; }
		public System.String GoodsCode { get; set; }
		public System.Int32 GoodsW { get; set; }
		public System.Int32 GoodsH { get; set; }
		public System.Int32 GoodsL { get; set; }
		public System.String FK_PaymentType { get; set; }
		public System.String FK_ShipType { get; set; }
		public System.DateTime SystemDate { get; set; }
		public System.Int32 BillStatus { get; set; }
		public System.Int32 BillProcessStatus { get; set; }
		public System.String ProviderTypeCode { get; set; }
		public System.String Token { get; set; }
		public System.String ShopId { get; set; }
		public System.Int32 InitPrice { get; set; }
		public System.Int32 InitWeight { get; set; }
		public System.Int32 StepWeight { get; set; }
		public System.Int32 StepPrice { get; set; }
		public System.String WardCode { get; set; }
		public System.String DistrictCode { get; set; }
		public System.String ProvinceCode { get; set; }
		public System.String WardName { get; set; }
		public System.String DistrictName { get; set; }
		public System.String ProvinceName { get; set; }
		public System.String ClientId { get; set; }
		public System.String ServiceId { get; set; }
		public System.String PostBT3Id { get; set; }
		public System.String ShopPhone { get; set; }
		public System.String ShopName { get; set; }
		public System.String Address { get; set; }
		public System.String FK_ProviderAccount { get; set; }
		public System.String PaymentTypeName { get; set; }
		public System.String ShipNoteCodeGHN { get; set; }
		public System.String ShipNoteType { get; set; }
		public System.Int32 InsuranceValue { get; set; }
		public System.Int32 RunMode { get; set; }
		public System.String ProviderName { get; set; }
		public System.String BT3CodeSub { get; set; }
		public System.String ClientSecrect { get; set; }
		public System.DateTime? ExpiresDate { get; set; }
		public System.Boolean IsPickup { get; set; }
		public System.Boolean? Pickup { get; set; }
		public System.String AddressPickup { get; set; }
		public System.String ProvincePickup { get; set; }
		public System.String DistricPickup { get; set; }
		public System.String WardPickup { get; set; }
		public System.String ShopIdPickup { get; set; }
		public System.String UserApi { get; set; }
		public System.String PassApi { get; set; }
		public System.String LinkCustomerLogin { get; set; }
		public System.String PP_LinkCustomerLogin { get; set; }
		public System.String PP_TrackLink { get; set; }
		public System.String TrackLink { get; set; }
		public view_GExpBillGHNApi(){}
	}
}
