using System;
using System.Collections.Generic;

namespace LeMai.Efs;

public partial class ViewGexpFeeDetailsPro
{
    public string Id { get; set; }

    public string FkGexpFee { get; set; }

    public int MinWeight { get; set; }

    public int MinFee { get; set; }

    public int StepWeight { get; set; }

    public int NextFee { get; set; }

    public int ProvineId { get; set; }

    public string District { get; set; }

    public string FkPost { get; set; }

    public bool DefaultFee { get; set; }

    public string FeeName { get; set; }
}
