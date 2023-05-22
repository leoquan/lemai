using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeMaiDto
{
    public class VanDonListMasterOutput
    {
        public List<string> ListStatusName { get; set; }
        public List<string> ListStatusBgColor { get; set; }
        public List<string> ListStatusTextColor { get; set; }
    }

    public class VanDonDanhSachOutput
    {
        public string BillCode { get; set; }
        public string AcceptMan { get; set; }
        public string AcceptManPhone { get; set; }
        public string AcceptProvince { get; set; }
        public DateTime RegisterDate { get; set; }
        public string GoodsName { get; set; }
        public string StatusName { get; set; }
        public string StatusBackgroundColor { get; set; }
        public string StatusTextColor { get; set; }

        public decimal FeeWeight { get; set; }
        public decimal Cod { get; set; }


        [JsonIgnore]
        public string AcceptManUpper { get; set; }
        [JsonIgnore]
        public string AcceptManNonUnicodeUpper { get; set; }
    }

    public class VanDonChiTietOutput
    {
        public VanDonChiTietViewGexpBill ChiTiet { get; set; }
        public List<VanDonChitietGexpScan> ListHanhTrinh { get; set; }
    }

    public class VanDonChiTietViewGexpBill
    {
        public string BillCode { get; set; }
        //public decimal BillWeight { get; set; }
        public decimal FeeWeight { get; set; }
        //public string RegisterUser { get; set; }
        //public string RegisterSiteCode { get; set; }
        public decimal Freight { get; set; }
        //public string PayType { get; set; }
        public decimal Cod { get; set; }
        public string SendMan { get; set; }
        //public string SendManUs { get; set; }
        public string SendManPhone { get; set; }
        public string SendManAddress { get; set; }
        //public int AcceptProvinceCode { get; set; }
        //public int AcceptDistrictCode { get; set; }
        //public string AcceptWardCode { get; set; }
        public string AcceptMan { get; set; }
        //public string AcceptManUs { get; set; }
        public string AcceptManPhone { get; set; }
        public string AcceptManAddress { get; set; }
        public string AcceptProvince { get; set; }
        //public string AcceptDistrict { get; set; }
        //public string AcceptWard { get; set; }
        //public bool IsSigned { get; set; }
        //public bool IsReturn { get; set; }
        //public int BillProcessStatus { get; set; }
        //public DateTime RegisterDate { get; set; }
        //public DateTime? SignedDate { get; set; }
        //public DateTime LastUpdateDate { get; set; }
        //public string LastUpdateUser { get; set; }
        public string Note { get; set; }
        //public DateTime SystemDate { get; set; }
        //public string Bt3type { get; set; }
        //public string Bt3code { get; set; }
        //public string Bt3status { get; set; }
        //public decimal? Bt3freight { get; set; }
        //public decimal? Bt3cod { get; set; }
        //public string Bt3payType { get; set; }
        //public string Bt3lastMess { get; set; }
        public string GoodsName { get; set; }
        //public int GoodsNumber { get; set; }
        //public string GoodsCode { get; set; }
        public int GoodsW { get; set; }
        public int GoodsH { get; set; }
        public int GoodsL { get; set; }
        //public string FkCustomer { get; set; }
        //public string FkProviderAccount { get; set; }
        //public DateTime? PayCustomerDate { get; set; }
        //public bool IsPayCustomer { get; set; }
        public string ShipperPhoneNumber { get; set; }
        //public int BillStatus { get; set; }
        //public string FkPaymentType { get; set; }
        //public string FkShipType { get; set; }
        //public string FullAddress { get; set; }
        //public string ProviderName { get; set; }
        //public string ProviderTypeCode { get; set; }
        //public string CustomerCode { get; set; }
        public string PaymentTypeName { get; set; }
        public string ShipNoteType { get; set; }
        //public string StatusName { get; set; }
        //public string StatusBackgroundColor { get; set; }
        //public string StatusTextColor { get; set; }
    }

    public class VanDonChitietGexpScan
    {
        //public string Id { get; set; }
        //public string Post { get; set; }
        public DateTime CreateDate { get; set; }
        public string Note { get; set; }
        //public string TypeScan { get; set; }
        //public string BillCode { get; set; }
        //public string KeyDate { get; set; }
        //public string UserCreate { get; set; }
        //public string NameCreate { get; set; }
        //public int? ProblemType { get; set; }
        //public bool IsRead { get; set; }

        [JsonIgnore]
        public bool IsFirst { get; set; }
    }


    public class VanDonThongKeOutput
    {
        public int TongDon { get; set; }
        public List<string> ListStatusName { get; set; } = new List<string>();
        public List<int> ListCountStatusName { get; set; } = new List<int>();

        public decimal TongCanNang { get; set; }
        public decimal DaThanhToan { get; set; }
        public decimal ChuaThanhToan { get; set; }
        public decimal TongTien { get; set; }
    }
}
