using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiDesktop
{
    public class DebitComprisonExcel
    {
        public string Session { get; set; }
        public int Stt { get; set; }
        public string BT3Code { get; set; }
        public string StatusName { get; set; }
        public int Status { get; set; }
        public DateTime? DateDeliveryReturn { get; set; }
        public decimal BT3COD { get; set; }
        public decimal Fee { get; set; }
        public decimal ReturnFee { get; set; }
        public decimal InsuranceFee { get; set; }
        public decimal OtherFee { get; set; }
        public decimal BT3TotalFee { get; set; }
        public decimal BT3Paid { get; set; }
        public decimal Discount { get; set; }
        public decimal ReturnCOD { get; set; }
        //---

        public string eBillCode { get; set; }
        public string eSendMan { get; set; }
        public string eSendAddress { get; set; }
        public string eSendPhone { get; set; }
        public string eAcceptMan { get; set; }
        public string eAcceptPhone { get; set; }
        public string eAcceptProvince { get; set; }
        public decimal eCOD { get; set; }
        public decimal eFreight { get; set; }
        public decimal eBillWeight { get; set; }
        public decimal eFeeWeight { get; set; }
        public string ePayType { get; set; }
    }
}
