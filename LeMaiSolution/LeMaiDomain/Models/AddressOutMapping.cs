using System;
using System.Collections.Generic;
using System.Text;

namespace LeMaiDomain.Models
{
    public class AddressOutMapping
    {
        public int AcceptProvinceCode { get; set; }
        public string AcceptProvince { get; set; }
        public int AcceptDistrictCode { get; set; }
        public string AcceptDistrict { get; set; }
        public string AcceptWardCode { get; set; }
        public string AcceptWard { get; set; }
    }
}
