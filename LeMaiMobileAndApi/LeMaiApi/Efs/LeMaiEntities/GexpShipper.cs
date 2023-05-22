using System;
using System.Collections.Generic;

namespace LeMai.Efs;

public partial class GexpShipper
{
    public string Id { get; set; }

    public string ShipperName { get; set; }

    public string ShipperPhone { get; set; }

    public string FkPost { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public int BalanceValue { get; set; }

    public bool IsDelete { get; set; }
}
