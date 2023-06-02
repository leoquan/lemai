using System;
using System.Collections.Generic;

namespace LeMai.Efs;

public partial class GexpShipperBillStatus
{
    public int Id { get; set; }

    public string StatusName { get; set; }

    public bool IsShowMobile { get; set; }

    public string StatusBackgroundColor { get; set; }

    public string StatusTextColor { get; set; }
}
