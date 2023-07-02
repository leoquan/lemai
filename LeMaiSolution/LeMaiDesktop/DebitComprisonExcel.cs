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
        public string MoneyReturnStatusName { get; set; }
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
        public string BillCode { get; set; }
        public string SendMan { get; set; }
        public string SendAddress { get; set; }
        public string SendManPhone { get; set; }
        public string AcceptMan { get; set; }
        public string AcceptManPhone { get; set; }
        public string AcceptProvince { get; set; }
        public decimal COD { get; set; }
        public decimal Freight { get; set; }
        public decimal BillWeight { get; set; }
        public decimal FeeWeight { get; set; }
        public string PayType { get; set; }
    }
}
