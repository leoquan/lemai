using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiDesktop
{
    public class PickupAddressItem
    {
        public bool IsUpdate { get; set; } = false;
        public string Address { get; set; }
        public string ProvincePickup { get; set; }
        public string DistrictPickup { get; set; }
        public string WardPickup { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
