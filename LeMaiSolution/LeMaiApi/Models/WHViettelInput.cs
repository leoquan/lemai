using System.Collections.Generic;

namespace LeMaiApi.Models
{
    public class ViettelDATA
    {
        public string ORDER_NUMBER { get; set; }
        public string ORDER_REFERENCE { get; set; }
        public string ORDER_STATUSDATE { get; set; }
        public int ORDER_STATUS { get; set; }
        public string STATUS_NAME { get; set; }
        public string LOCALION_CURRENTLY { get; set; }
        public string NOTE { get; set; }
        public int MONEY_COLLECTION { get; set; }
        public int MONEY_FEECOD { get; set; }
        public int MONEY_TOTALFEE { get; set; }
        public int MONEY_TOTAL { get; set; }
        public string EXPECTED_DELIVERY { get; set; }
        public int PRODUCT_WEIGHT { get; set; }
        public string ORDER_SERVICE { get; set; }
        public int ORDER_PAYMENT { get; set; }
        public string EXPECTED_DELIVERY_DATE { get; set; }
        public List<ViettelDETAIL> DETAIL { get; set; }
        public int VOUCHER_VALUE { get; set; }
        public int MONEY_COLLECTION_ORIGIN { get; set; }
        public string EMPLOYEE_NAME { get; set; }
        public string EMPLOYEE_PHONE { get; set; }
    }

    public class ViettelDETAIL
    {
        public string CODE { get; set; }
        public int VALUE { get; set; }
    }

    public class WHViettelInput
    {
        public ViettelDATA DATA { get; set; }
        public string TOKEN { get; set; }
    }
}
