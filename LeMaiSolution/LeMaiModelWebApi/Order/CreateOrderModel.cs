using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace LeMaiModelWebApi.Order
{
    public class CreateOrderModel: CreateOrderModelInput
    {

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public List<GExpProvince> PickupProvinceList { get; set; } = new List<GExpProvince>();
        public List<GExpDistrict> PickupDistrictList { get; set; } = new List<GExpDistrict>();
        public List<GExpWard> PickupWardList { get; set; } = new List<GExpWard>();
        public List<GExpProvince> AcceptProvinceList { get; set; } = new List<GExpProvince>();
        public List<GExpDistrict> AcceptDistrictList { get; set; } = new List<GExpDistrict>();
        public List<GExpWard> AcceptWardList { get; set; } = new List<GExpWard>();
        public List<GExpProvider> ProviderList { get; set; } = new List<GExpProvider>();
        public List<GExpPaymentType> PayTypeList { get; set; } = new List<GExpPaymentType>();
        public List<GExpShipNoteType> ShipTypeList { get; set; } = new List<GExpShipNoteType>();
    }
    public class CreateOrderModelInput
    {

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string SendManPhone { get; set; }
        public string SendMan { get; set; }
        public string SendAddress { get; set; }
        public bool IsPickup { get; set; }
        public string PickupManPhone { get; set; }
        public string PickupMan { get; set; }
        public string PickupProvinceSelected { get; set; }
        public string PickupDistrictSelected { get; set; }
        public string PickupWardSelected { get; set; }
        public string PickupAddress { get; set; }
        public string AcceptManPhone { get; set; }
        public string AcceptMan { get; set; }
        public string AcceptProvinceSelected { get; set; }
        public string AcceptDistrictSelected { get; set; }
        public string AcceptWardSelected { get; set; }

        public string AcceptProvinceName { get; set; }
        public string AcceptDistrictName { get; set; }
        public string AcceptWardName { get; set; }

        public string AcceptAddress { get; set; }
        public string GoodName { get; set; }
        public int FeeWeight { get; set; }
        public int BillWeigt { get; set; }
        public string ProviderSelected { get; set; }
        public int DIM_L { get; set; }
        public int DIM_W { get; set; }
        public int DIM_H { get; set; }
        public decimal DIM { get; set; }
        public decimal Freight { get; set; }
        public decimal COD { get; set; }
        public string PayTypeSelected { get; set; }
        public string ShipTypeSelected { get; set; }
        public string Note { get; set; }
        public string UserId { get; set; }
        public string PostId { get; set; }
        public string SiteCode { get; set; }
        public string CustomerId { get; set; }
        public bool SaveAndSend { get; set; }
    }
}
