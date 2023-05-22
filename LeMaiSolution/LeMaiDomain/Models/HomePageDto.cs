using System.Collections.Generic;

namespace LeMaiWebApp.Models
{
    public class HomePageDto
    {
        public class HomeInput
        {
            public string StartDate { get; set; }
            public string EndDate { get; set; }
        }
        public class HomeOutput
        {
            public decimal TotalWeight { get; set; }
            public string TotalBill { get; set; }
            public string DaThanhToan { get; set; }
            public string ChuaThanhToan { get; set; }
            public string TongTien { get; set; }
            public List<TrangThaiChart> ListTrangThaiChart { get; set; }
        }
        public class TrangThaiChart
        {
            public string NameStatus { get; set; }
            public string ColorStatus { get; set; }
            public int SoLuong { get; set; }
        }
    }
}
