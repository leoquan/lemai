namespace LeMaiApi.Models
{
    public class WHBestInput
    {
        public string code_best { get; set; }
        public string merchant_order_code { get; set; }
        public string status { get; set; }
        public double cod { get; set; }
        public double product_price { get; set; }
        public string status_content { get; set; }
        public long modified_at { get; set; }
        public double discount { get; set; }
        public double return_fee { get; set; }
        public double freight_fee { get; set; }
        public double cod_fee { get; set; }
        public double insurance_fee { get; set; }
        public double total_fee { get; set; }
        public double vat_fee { get; set; }
        public int weight { get; set; }
        public int length { get; set; }
        public int width { get; set; }
        public int height { get; set; }

    }
}
