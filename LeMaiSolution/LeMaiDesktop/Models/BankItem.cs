using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiDesktop.Models
{
    public class BankItem
    {
        public int NumRow { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public int Amount { get; set; }
        public string BankName { get; set; }
        public string Remark { get; set; }
        public int BankCode { get; set; }

    }
}
