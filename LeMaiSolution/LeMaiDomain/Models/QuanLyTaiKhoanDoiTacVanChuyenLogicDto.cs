using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LeMaiDomain.Models
{
		//Sample 
		//[MaxLength(100)]
		//[RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")]
		//[Range(1, 10, ErrorMessage = "data must be between 1 and 10")]

	public class QuanLyTaiKhoanDoiTacVanChuyenLogicInputDto
	{
		[Required(ErrorMessage = "ProviderName Not Empty")]
		public String ProviderName { get; set; }
		[Required(ErrorMessage = "Token Not Empty")]
		public String Token { get; set; }
		[Required(ErrorMessage = "UserApi Not Empty")]
		public String UserApi { get; set; }
		[Required(ErrorMessage = "PassApi Not Empty")]
		public String PassApi { get; set; }
		[Required(ErrorMessage = "ShopId Not Empty")]
		public String ShopId { get; set; }
		[Required(ErrorMessage = "ClientId Not Empty")]
		public String ClientId { get; set; }
		[Required(ErrorMessage = "Post Not Empty")]
		public String Post { get; set; }
		[Required(ErrorMessage = "Address Not Empty")]
		public String Address { get; set; }
		[Required(ErrorMessage = "Email Not Empty")]
		public String Email { get; set; }
		[Required(ErrorMessage = "ShopName Not Empty")]
		public String ShopName { get; set; }
		public String ShopPhone { get; set; }
		[Required(ErrorMessage = "ProviderTypeCode Not Empty")]
		public String ProviderTypeCode { get; set; }
		[Required(ErrorMessage = "IsDelete Not Empty")]
		public Boolean IsDelete { get; set; }
		[Required(ErrorMessage = "AutoSelect Not Empty")]
		public Boolean AutoSelect { get; set; }
		[Required(ErrorMessage = "InitWeightSelect Not Empty")]
		public Int32 InitWeightSelect { get; set; }
		[Required(ErrorMessage = "InitWeightSelectMax Not Empty")]
		public Int32 InitWeightSelectMax { get; set; }
		[Required(ErrorMessage = "SelectIndex Not Empty")]
		public Int32 SelectIndex { get; set; }
		[Required(ErrorMessage = "InitPrice Not Empty")]
		public Int32 InitPrice { get; set; }
		[Required(ErrorMessage = "InitWeight Not Empty")]
		public Int32 InitWeight { get; set; }
		[Required(ErrorMessage = "StepWeight Not Empty")]
		public Int32 StepWeight { get; set; }
		[Required(ErrorMessage = "StepPrice Not Empty")]
		public Int32 StepPrice { get; set; }
		public String WardCode { get; set; }
		public String DistrictCode { get; set; }
		public String ProvinceCode { get; set; }
		public String WardName { get; set; }
		public String DistrictName { get; set; }
		public String ProvinceName { get; set; }
		public String ServiceId { get; set; }
		public String PostBT3Id { get; set; }
		[Required(ErrorMessage = "RunMode Not Empty")]
		public Int32 RunMode { get; set; }
		[Required(ErrorMessage = "GroupProvider Not Empty")]
		public String GroupProvider { get; set; }
		[Required(ErrorMessage = "InsuranceValue Not Empty")]
		public Int32 InsuranceValue { get; set; }
		public String ClientSecrect { get; set; }
		public String PrintLable { get; set; }
		[Required(ErrorMessage = "DeliveryInitPrice Not Empty")]
		public Int32 DeliveryInitPrice { get; set; }
		[Required(ErrorMessage = "DeliveryInitWeight Not Empty")]
		public Int32 DeliveryInitWeight { get; set; }
		[Required(ErrorMessage = "DeliveryStepWeight Not Empty")]
		public Int32 DeliveryStepWeight { get; set; }
		[Required(ErrorMessage = "DeliveryStepPrice Not Empty")]
		public Int32 DeliveryStepPrice { get; set; }
		[Required(ErrorMessage = "SysInitPrice Not Empty")]
		public Int32 SysInitPrice { get; set; }
		[Required(ErrorMessage = "SysInitWeight Not Empty")]
		public Int32 SysInitWeight { get; set; }
		[Required(ErrorMessage = "SysStepWeight Not Empty")]
		public Int32 SysStepWeight { get; set; }
		[Required(ErrorMessage = "SysStepPrice Not Empty")]
		public Int32 SysStepPrice { get; set; }
		[Required(ErrorMessage = "TranInitPrice Not Empty")]
		public Int32 TranInitPrice { get; set; }
		[Required(ErrorMessage = "TranInitWeight Not Empty")]
		public Int32 TranInitWeight { get; set; }
		[Required(ErrorMessage = "TranStepWeight Not Empty")]
		public Int32 TranStepWeight { get; set; }
		[Required(ErrorMessage = "TranStepPrice Not Empty")]
		public Int32 TranStepPrice { get; set; }
		[Required(ErrorMessage = "ManualSign Not Empty")]
		public Boolean ManualSign { get; set; }
		[Required(ErrorMessage = "IsPickup Not Empty")]
		public Boolean IsPickup { get; set; }
		public String LinkCustomerLogin { get; set; }
        public Boolean IsAlwayReceive { get; set; }
    }
	public class QuanLyTaiKhoanDoiTacVanChuyenLogicOutputDto:view_GExpProvider
	{
	}
}

