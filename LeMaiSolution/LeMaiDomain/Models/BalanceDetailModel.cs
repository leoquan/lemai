using System;
using System.Collections.Generic;
using System.Text;

namespace LeMaiDomain.Models
{
    public class BalanceDetailModel
    {
        public string Id { get; set; }
        public DateTime Ngay { get; set; }
        public string BuuCuc { get; set; }
        public string NguoiThucHien { get; set; }
        public string BillCode { get; set; }
        public string GhiChu { get; set; }
        public string TenLoaiThanhToan { get; set; }
        public bool IsPay { get; set; }
        public int BeforeValue { get; set; }
        public int Value { get; set; }
        public int AffterValue { get; set; }
        public string NgayS { get; set; }
        public string GioS { get; set; }
        public int SoThu { get; set; }
        public int SoChi { get; set; }

    }
}
