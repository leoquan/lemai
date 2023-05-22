using System;
using System.Collections.Generic;

namespace LeMai.Efs;

public partial class ViewGexpProblem
{
    public string Id { get; set; }

    public string BillCode { get; set; }

    public DateTime RegisterDate { get; set; }

    public string Note { get; set; }

    public string UserId { get; set; }

    public string FullName { get; set; }

    public string AcceptMan { get; set; }

    public string AcceptManPhone { get; set; }

    public string AcceptProvince { get; set; }

    public string GoodsName { get; set; }

    public string FkCustomer { get; set; }

    public int BillStatus { get; set; }

    public string RegisterSiteCode { get; set; }

    public decimal BillWeight { get; set; }

    public decimal FeeWeight { get; set; }

    public string StatusName { get; set; }

    public string StatusBackgroundColor { get; set; }

    public string StatusTextColor { get; set; }
}
