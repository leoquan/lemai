using System;
using System.Collections.Generic;

namespace LeMai.Efs;

public partial class GexpProblem
{
    public string Id { get; set; }

    public string BillCode { get; set; }

    public DateTime RegisterDate { get; set; }

    public string Note { get; set; }

    public string UserId { get; set; }

    public string FullName { get; set; }
}
