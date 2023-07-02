using System;
using System.Collections.Generic;
using System.Text;

namespace LeMaiDomain.Models
{
    public class OutResultGHN
    {
        public string OrderCode { get; set; }
        public string BT3SubCode { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public decimal BT3COD { get; set; }
        public decimal BT3Freight { get; set; }
        public string BT3Status { get; set; }
        public string BT3PayType { get; set; }
        public string ShopId { get; set; }
        public bool IsUpdateShope { get; set; } = false;
        public string Province { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public string Address { get; set; }
        public string PrintData { get; set; }

    }
    public class OutTrackingResultGHN
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public decimal BT3Freight { get; set; }
        public bool UpdateFee { get; set; } = false;
        public List<OutTrackingLogGHN> outTrackingLogs { get; set; } = new List<OutTrackingLogGHN>();
    }
    public class OutTrackingLogGHN
    {
        public string ActionDate { get; set; }
        public DateTime ActionDateTime { get; set; }
        public string StatusCode { get; set; }
        public string Note { get; set; }
        public string ProviderName { get; set; }
    }
}
