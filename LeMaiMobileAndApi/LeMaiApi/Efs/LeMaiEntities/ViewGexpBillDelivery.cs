using System;
using System.Collections.Generic;

namespace LeMai.Efs;

public partial class ViewGexpBillDelivery
{
    public string BillCode { get; set; }

    public decimal BillWeight { get; set; }

    public decimal FeeWeight { get; set; }

    public string RegisterUser { get; set; }

    public string RegisterSiteCode { get; set; }

    public decimal Freight { get; set; }

    public string PayType { get; set; }

    public decimal Cod { get; set; }

    public string SendMan { get; set; }

    public string SendManUs { get; set; }

    public string SendManPhone { get; set; }

    public string SendManAddress { get; set; }

    public int AcceptProvinceCode { get; set; }

    public int AcceptDistrictCode { get; set; }

    public string AcceptWardCode { get; set; }

    public string AcceptMan { get; set; }

    public string AcceptManUs { get; set; }

    public string AcceptManPhone { get; set; }

    public string AcceptManAddress { get; set; }

    public string AcceptProvince { get; set; }

    public string AcceptDistrict { get; set; }

    public string AcceptWard { get; set; }

    public bool IsSigned { get; set; }

    public bool IsReturn { get; set; }

    public int BillProcessStatus { get; set; }

    public DateTime RegisterDate { get; set; }

    public DateTime? SignedDate { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateUser { get; set; }

    public string Note { get; set; }

    public DateTime SystemDate { get; set; }

    public string Bt3type { get; set; }

    public string Bt3code { get; set; }

    public string Bt3codeSub { get; set; }

    public string Bt3status { get; set; }

    public decimal? Bt3freight { get; set; }

    public decimal? Bt3cod { get; set; }

    public string Bt3payType { get; set; }

    public string Bt3lastMess { get; set; }

    public string GoodsName { get; set; }

    public int GoodsNumber { get; set; }

    public string GoodsCode { get; set; }

    public int GoodsW { get; set; }

    public int GoodsH { get; set; }

    public int GoodsL { get; set; }

    public string FkCustomer { get; set; }

    public string FkProviderAccount { get; set; }

    public DateTime? PayCustomerDate { get; set; }

    public bool IsPayCustomer { get; set; }

    public string ShipperPhoneNumber { get; set; }

    public int BillStatus { get; set; }

    public string FkPaymentType { get; set; }

    public string FkShipType { get; set; }

    public string FullAddress { get; set; }

    public string ProviderName { get; set; }

    public string ProviderTypeCode { get; set; }

    public string GroupProvider { get; set; }

    public string CustomerCode { get; set; }

    public string PaymentTypeName { get; set; }

    public string ShipNoteType { get; set; }

    public string StatusName { get; set; }

    public string StatusBackgroundColor { get; set; }

    public string StatusTextColor { get; set; }

    public string PrintLable { get; set; }

    public int RunMode { get; set; }

    public string FkShipperId { get; set; }

    public DateTime DeliveryDate { get; set; }
}
