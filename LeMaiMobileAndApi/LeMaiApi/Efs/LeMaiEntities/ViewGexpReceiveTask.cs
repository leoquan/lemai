using System;
using System.Collections.Generic;

namespace LeMai.Efs;

public partial class ViewGexpReceiveTask
{
    public string Id { get; set; }

    public string FkCustomerId { get; set; }

    public string FkShipperId { get; set; }

    public DateTime CreateDate { get; set; }

    public string FkPost { get; set; }

    public string FkAccount { get; set; }

    public string Note { get; set; }

    public string ShipperName { get; set; }

    public string ShipperPhone { get; set; }

    public string TenDaiLy { get; set; }

    public string CustomerName { get; set; }

    public string CustomerPhone { get; set; }

    public string GoogleMap { get; set; }

    public string DiaChi { get; set; }

    public string Nvgiao { get; set; }

    public string StatusReceiveName { get; set; }

    public string CustomerCode { get; set; }

    public string FkPickupShipper { get; set; }

    public DateTime? PickupDate { get; set; }
}
