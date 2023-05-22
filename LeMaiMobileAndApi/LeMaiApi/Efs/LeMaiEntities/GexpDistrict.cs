using System;
using System.Collections.Generic;

namespace LeMai.Efs;

public partial class GexpDistrict
{
    public int DistrictId { get; set; }

    public int ProvinceId { get; set; }

    public string DistrictName { get; set; }

    public string Code { get; set; }

    public int Type { get; set; }

    public int SupportType { get; set; }
}
