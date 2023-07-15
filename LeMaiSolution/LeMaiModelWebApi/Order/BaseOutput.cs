using System;
using System.Collections.Generic;
using System.Text;

namespace LeMaiModelWebApi.Order
{
    public class BaseOutput
    {
        public int Code { get; set; } = 200;
        public string? ResultString { get; set; }
        public string? Error { get; set; }
        public object? Data { get; set; }
    }
}
