using System;
using System.Collections.Generic;

namespace LeMai.Efs;

public partial class GexpOrder
{
    public string Id { get; set; }

    public string OrderCode { get; set; }

    public string AcceptName { get; set; }

    public string AcceptPhone { get; set; }

    public string AcceptAddress { get; set; }

    public string GoodsName { get; set; }

    public decimal Cod { get; set; }

    public int Weight { get; set; }

    public bool IsShopPay { get; set; }

    public string Note { get; set; }

    public DateTime CreateDate { get; set; }

    public string FkCustomerId { get; set; }

    public int StatusOrder { get; set; }

    public string PickupUser { get; set; }

    public DateTime? PickupDate { get; set; }

    public string TransferCode { get; set; }

    public int? ProvinceCode { get; set; }

    public int? DistrictCode { get; set; }

    public string DistrictWard { get; set; }

    public int? Freight { get; set; }

    public string FkShipperNot { get; set; }
}
