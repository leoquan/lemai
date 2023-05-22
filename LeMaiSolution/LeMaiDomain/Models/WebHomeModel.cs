using System;
using System.Collections.Generic;
using System.Text;

namespace LeMaiDomain.Models
{
    public class WebHomeIndexModel
    {
        public List<view_GExpScan> listTracking { get; set; } = new List<view_GExpScan>();
        public string billCode { get; set; }
        public string message { get; set; }
        public string display { get; set; }
        public string displayInfo { get; set; }
        public string AcceptMan { get; set; }
        public string AcceptManPhone { get; set; }
        public string GoodsName { get; set; }
        public decimal BillWeight { get; set; }
        public decimal Total { get; set; }
        public decimal COD { get; set; }
        public decimal Freight { get; set; }
    }
    public class WebOption
    {
        public string COMPANY_EMAIL { get; set; }
        public string COMPANY_ADDRESS { get; set; }
        public string COMPANY_HOTLINE { get; set; }
        public string COMPANY_NAME { get; set; }
        public string COMPANY_FOOTER_ADDRESS { get; set; }
        public string COMPANY_FOOTER_PHONE { get; set; }
        public string COMPANY_MAP { get; set; }
        public string PAGE_TITLE { get; set; }
        public string PAGE_DESCRIPTION { get; set; }
        public string PAGE_KEYWORD { get; set; }
        public string PAGE_AUTHOR { get; set; }
        public string PAGE_PRIVACY { get; set; }
    }
}
