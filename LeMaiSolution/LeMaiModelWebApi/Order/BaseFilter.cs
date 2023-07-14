using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeMaiModelWebApi.Order
{
    public class BaseFilter
    {
        public string UserId { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Status { get; set; }
        public string KeySearch { get; set; }
        public List<BaseStatusFilter> ListStatus { get; set; }

    }
    public class BaseStatusFilter
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
    public class BaseBillFilter : BaseFilter
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public List<view_GExpBill> ListBill { get; set; }
    }
    public class BaseCustomerFilter : BaseFilter
    {
        public List<view_ExpCustomer> ListCustomer { get; set; }
    }
}
