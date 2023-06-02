using System;
using System.Collections.Generic;

namespace LeMai.Efs;

public partial class GexpReceiveTask
{
    public string Id { get; set; }

    public string FkCustomerId { get; set; }

    public string FkShipperId { get; set; }

    public DateTime CreateDate { get; set; }

    public string FkPost { get; set; }

    public string FkAccount { get; set; }

    public int GoodsNumber { get; set; }

    public bool HaveReturn { get; set; }

    public string Note { get; set; }

    public int ReceiveStatus { get; set; }

    public string FkPickupShipper { get; set; }

    public DateTime? PickupDate { get; set; }
}
