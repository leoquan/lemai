using System;
using System.Collections.Generic;

namespace LeMai.Efs;

public partial class ViewGexpFeeDetail
{
    public string Id { get; set; }

    public string FkGexpFee { get; set; }

    public int MinWeightMn { get; set; }

    public int MinWeightMt { get; set; }

    public int MinWeightMb { get; set; }

    public int MinFeeMn { get; set; }

    public int MinFeeMt { get; set; }

    public int MinFeeMb { get; set; }

    public int StepWeight { get; set; }

    public int NextFeeMn { get; set; }

    public int NextFeeMt { get; set; }

    public int NextFeeMb { get; set; }

    public int MinWeightInt { get; set; }

    public int MinFeeInt { get; set; }

    public int NextFeeInt { get; set; }

    public int StepWeightInt { get; set; }

    public int StepWeightMb { get; set; }

    public int StepWeightMt { get; set; }

    public int StepWeightMn { get; set; }

    public string FkPost { get; set; }

    public bool DefaultFee { get; set; }

    public string FeeName { get; set; }
}
