using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeMaiDto
{
    public class KienVanDeDanhSachOutput
    {
        public string BillCode { get; set; }
        public string AcceptMan { get; set; }
        public string AcceptManPhone { get; set; }
        public string AcceptProvince { get; set; }
        public DateTime RegisterDate { get; set; }
        public string GoodsName { get; set; }
        public string StatusName { get; set; }
        public string StatusBackgroundColor { get; set; }
        public string StatusTextColor { get; set; }

        public string Note { get; set; }

        [JsonIgnore]
        public string AcceptManUpper { get; set; }
        [JsonIgnore]
        public string AcceptManNonUnicodeUpper { get; set; }
    }
}
