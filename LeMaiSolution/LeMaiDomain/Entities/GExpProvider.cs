using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpProvider
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String ProviderName { get; set; }
		public System.String Token { get; set; }
		public System.String UserApi { get; set; }
		public System.String PassApi { get; set; }
		public System.String ShopId { get; set; }
		public System.String ClientId { get; set; }
		public System.String Post { get; set; }
		public System.String Address { get; set; }
		public System.String Email { get; set; }
		public System.String ShopName { get; set; }
		public System.String ShopPhone { get; set; }
		public System.String ProviderTypeCode { get; set; }
		public System.Boolean IsDelete { get; set; }
		public System.Boolean AutoSelect { get; set; }
		public System.Int32 InitWeightSelect { get; set; }
		public System.Int32 InitWeightSelectMax { get; set; }
		public System.Int32 SelectIndex { get; set; }
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
		public System.String ServiceId { get; set; }
		public System.String PostBT3Id { get; set; }
		public System.Int32 RunMode { get; set; }
		public System.String TrackLink { get; set; }
		public System.String WhiteListProvince { get; set; }
		public System.String BlackListProvince { get; set; }
		public System.String GroupProvider { get; set; }
		public System.Int32 InsuranceValue { get; set; }
		public System.DateTime? ExpiresDate { get; set; }
		public System.String ClientSecrect { get; set; }
		public System.String PrintLable { get; set; }
		public System.Int32 DeliveryInitPrice { get; set; }
		public System.Int32 DeliveryInitWeight { get; set; }
		public System.Int32 DeliveryStepWeight { get; set; }
		public System.Int32 DeliveryStepPrice { get; set; }
		public System.Int32 SysInitPrice { get; set; }
		public System.Int32 SysInitWeight { get; set; }
		public System.Int32 SysStepWeight { get; set; }
		public System.Int32 SysStepPrice { get; set; }
		public System.Int32 TranInitPrice { get; set; }
		public System.Int32 TranInitWeight { get; set; }
		public System.Int32 TranStepWeight { get; set; }
		public System.Int32 TranStepPrice { get; set; }
		public System.String DistrictWhiteList { get; set; }
		public System.Boolean ManualSign { get; set; }
		public System.Boolean IsPickup { get; set; }
		public System.String LinkCustomerLogin { get; set; }
		public System.Int32 IsOwner { get; set; }
		public System.Int32 PercentConfig { get; set; }
		public System.Boolean AlwayReceivePay { get; set; }
		public System.Int32? ConvertWeight { get; set; }
		public GExpProvider(){}
	}
}
