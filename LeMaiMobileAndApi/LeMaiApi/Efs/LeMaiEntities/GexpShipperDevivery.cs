using System;
using System.Collections.Generic;

namespace LeMai.Efs;

public partial class GexpShipperDevivery
{
    public string Id { get; set; }

    public string ShipperId { get; set; }

    public string BillCode { get; set; }

    public DateTime SignDate { get; set; }

    public decimal TotalCod { get; set; }

    public bool IsCash { get; set; }

    public DateTime? CashTime { get; set; }

    public string FkAccountCash { get; set; }

    public string Note { get; set; }

    public string FkCashId { get; set; }

    public string FkPost { get; set; }

    public bool IsSign { get; set; }
}
