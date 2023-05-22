using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiDesktop
{
    public class Datum
    {
        public string WardCode { get; set; }
        public int DistrictID { get; set; }
        public string WardName { get; set; }
        public List<string> NameExtension { get; set; }
        public int IsEnable { get; set; }
        public bool CanUpdateCOD { get; set; }
        public int UpdatedBy { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public int SupportType { get; set; }
        public WhiteListClient WhiteListClient { get; set; }
        public WhiteListWard WhiteListWard { get; set; }
        public int Status { get; set; }
        public string ReasonCode { get; set; }
        public string ReasonMessage { get; set; }
        public object OnDates { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }

    public class JSonRootWardGHN
    {
        public int code { get; set; }
        public string message { get; set; }
        public List<Datum> data { get; set; }
    }

    public class WhiteListClient
    {
        public object From { get; set; }
        public object To { get; set; }
        public object Return { get; set; }
    }

    public class WhiteListWard
    {
        public object From { get; set; }
        public object To { get; set; }
    }
    public class VNPOSTProvince
    {
        public string provinceName { get; set; }
        public string provinceCode { get; set; }
    }
    public class VNPOSTDistrict
    {
        public string districtCode { get; set; }
        public string districtName { get; set; }
        public string provinceCode { get; set; }
    }
    public class VNPOSTWard
    {
        public string districtCode { get; set; }
        public string communeName { get; set; }
        public string communeCode { get; set; }
    }
}
