using System.Collections.Generic;

namespace LeMaiApi.Models
{
    public class Responseitem
    {
        public string status_code { get; set; }
        public string status_name { get; set; }
        public string fee { get; set; }
        public string weight { get; set; }
        public string source { get; set; }
        public string signpart { get; set; }
        public string txlogisticid { get; set; }
        public string insurancefee { get; set; }
        public string scantime { get; set; }
        public string statuscode { get; set; }
        public string codfee { get; set; }
        public string totalfee { get; set; }
        public string commissionfee { get; set; }
        public string pretaxfee { get; set; }
        public string fuelsurcharge { get; set; }
        public string billcode { get; set; }
        public string cod { get; set; }
        public string id { get; set; }
        public string codaftersignpart { get; set; }
    }

    public class WHJNTInput
    {
        public List<Responseitem> responseitems { get; set; }
    }
    public class WHJNTOutput
    {
        public bool status { get; set; }
    }
}
