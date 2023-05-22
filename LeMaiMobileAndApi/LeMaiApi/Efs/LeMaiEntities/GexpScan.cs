using System;
using System.Collections.Generic;

namespace LeMai.Efs;

public partial class GexpScan
{
    public string Id { get; set; }

    public string Post { get; set; }

    public DateTime CreateDate { get; set; }

    public string Note { get; set; }

    public string TypeScan { get; set; }

    public string BillCode { get; set; }

    public string KeyDate { get; set; }

    public string UserCreate { get; set; }

    public string NameCreate { get; set; }

    public int? ProblemType { get; set; }

    public bool IsRead { get; set; }
}
