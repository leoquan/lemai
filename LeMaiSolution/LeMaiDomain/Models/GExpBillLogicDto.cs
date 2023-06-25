using System;
using System.ComponentModel.DataAnnotations;

namespace LeMaiDomain.Models
{
    //Sample 
    //[MaxLength(100)]
    //[RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")]
    //[Range(1, 10, ErrorMessage = "data must be between 1 and 10")]

    public class GExpBillLogicInputDto
    {
        public Decimal BillWeight { get; set; }
        public Decimal FeeWeight { get; set; }
        [Required(ErrorMessage = "RegisterUser Not Empty")]
        public String RegisterUser { get; set; }
        [Required(ErrorMessage = "RegisterSiteCode Not Empty")]
        public String RegisterSiteCode { get; set; }
        [Required(ErrorMessage = "Freight Not Empty")]
        public Decimal Freight { get; set; }
        [Required(ErrorMessage = "PayType Not Empty")]
        public String PayType { get; set; }
        [Required(ErrorMessage = "COD Not Empty")]
        public Decimal COD { get; set; }
        [Required(ErrorMessage = "SendMan Not Empty")]
        public String SendMan { get; set; }

        [Required(ErrorMessage = "SendManPhone Not Empty")]
        public String SendManPhone { get; set; }
        [Required(ErrorMessage = "SendManAddress Not Empty")]
        public String SendManAddress { get; set; }
        [Required(ErrorMessage = "SendProvince Not Empty")]
        public int AcceptProvinceCode { get; set; }
        [Required(ErrorMessage = "SendDistrict Not Empty")]
        public int AcceptDistrictCode { get; set; }
        [Required(ErrorMessage = "SendWard Not Empty")]
        public string AcceptWardCode { get; set; }
        [Required(ErrorMessage = "AcceptMan Not Empty")]
        public String AcceptMan { get; set; }
        [Required(ErrorMessage = "AcceptManPhone Not Empty")]
        public String AcceptManPhone { get; set; }
        [Required(ErrorMessage = "AcceptManAddress Not Empty")]
        public String AcceptManAddress { get; set; }
        [Required(ErrorMessage = "AcceptProvince Not Empty")]
        public String AcceptProvince { get; set; }
        [Required(ErrorMessage = "AcceptDistrict Not Empty")]
        public String AcceptDistrict { get; set; }
        [Required(ErrorMessage = "AcceptWard Not Empty")]
        public String AcceptWard { get; set; }

        [Required(ErrorMessage = "LastUpdateUser Not Empty")]
        public String LastUpdateUser { get; set; }
        public String Note { get; set; }

        [Required(ErrorMessage = "BT3Type Not Empty")]
        public String BT3Type { get; set; }

        [Required(ErrorMessage = "GoodsName Not Empty")]
        public String GoodsName { get; set; }
        [Required(ErrorMessage = "GoodsNumber Not Empty")]
        public Int32 GoodsNumber { get; set; }
        public String GoodsCode { get; set; }
        [Required(ErrorMessage = "GoodsW Not Empty")]
        public Int32 GoodsW { get; set; }
        [Required(ErrorMessage = "GoodsH Not Empty")]
        public Int32 GoodsH { get; set; }
        [Required(ErrorMessage = "GoodsL Not Empty")]
        public Int32 GoodsL { get; set; }
        [Required(ErrorMessage = "FK_Customer Not Empty")]
        public String FK_Customer { get; set; }
        [Required(ErrorMessage = "FK_ProviderAccount Not Empty")]
        public String FK_ProviderAccount { get; set; }
        [Required(ErrorMessage = "FK_PaymentType Not Empty")]
        public String FK_PaymentType { get; set; }
        [Required(ErrorMessage = "FK_ShipType Not Empty")]
        public String FK_ShipType { get; set; }
        public String FullName { get; set; }
        public String IdOrder { get; set; }
        public bool Pickup { get; set; }
        public string ProvincePickup { get; set; }
        public string DistricPickup { get; set; }
        public string WardPickup { get; set; }
        public string AddressPickup { get; set; }
        public string ShopIdPickup { get; set; }
        public String SiteCode { get; set; }
        public bool IsReceiveBill { get; set; }
        public string NamePickup { get; set; }
        public string PhonePickup { get; set; }
    }
    public class GExpBillLogicOutputDto : view_GExpBill
    {
    }
}

