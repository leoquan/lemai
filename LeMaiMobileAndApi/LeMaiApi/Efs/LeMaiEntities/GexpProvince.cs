using System;
using System.Collections.Generic;

namespace LeMai.Efs;

public partial class GexpProvince
{
    public int ProvinceId { get; set; }

    public string ProvinceName { get; set; }

    public string Code { get; set; }

    public string ZoneCode { get; set; }

    public bool Delay { get; set; }

    public string Short { get; set; }
}
