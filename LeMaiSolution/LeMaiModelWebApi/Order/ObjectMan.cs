using System;
using System.Collections.Generic;
using System.Text;

namespace LeMaiModelWebApi.Order
{
    public class ObjectMan
    {
        public bool Found { get; set; }
        public string CustomerId { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<DictionInt> ProvinceList { get; set; }
        public int SelectProvince { get; set; }
        public List<DictionInt> DistrictList { get; set; }
        public int SelectDistrict { get; set; }
        public List<DictionString> WardList { get; set; }
        public string SelectWard { get; set; }
    }
    public class DictionString
    {
        public string Key { get; set; }
        public string Name { get; set; }
    }
    public class DictionInt
    {
        public int Key { get; set; }
        public string Name { get; set; }
    }
}
