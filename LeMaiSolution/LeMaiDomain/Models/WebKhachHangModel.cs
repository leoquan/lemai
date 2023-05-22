using System;
using System.Collections.Generic;
using System.Text;

namespace LeMaiDomain.Models
{
    public class TemplateKey
    {
        public const string KEY_HEADER = "#header";
        public const string KEY_ROW = "#row";
        public const string KEY_COLUMN = "#column";
        public const string KEY_COLUMN_TITLE = "#columntitle";
        public const string KEY_COLUMN_NAME = "#columname";
        public const string KEY_END_COLUMN_NAME = "#endcolumname";

    }
    public class WebKhachHangIndexModel
    {
        public int SoDon { get; set; } = 0;
        public decimal TongTien { get; set; } = 0;
        public decimal DaThanhToan { get; set; } = 0;
        public decimal ChuaThanhToan { get; set; } = 0;
        public List<DataChart> ChartBill { get; set; } = new List<DataChart>();
        public List<DataChart> ChartCOD { get; set; } = new List<DataChart>();
        public List<DataChart> ChartSanLuong { get; set; } = new List<DataChart>();
        public List<DataChart> ChartGiaoThanhCong { get; set; } = new List<DataChart>();
        public int MaxGiaoThanhCong { get; set; } = 0;
        public int MaxSanLuong { get; set; } = 0;

    }
    public class WebKhachHangBillDetailModel
    {
        public string backAction { get; set; }
        public view_GExpBill Bill { get; set; }
        public List<view_GExpScan> scanList { get; set; } = new List<view_GExpScan>();

    }
    public class HuyenXaModel
    {
        public List<GExpDistrict> dist { get; set; }
        public List<GExpWard> ward { get; set; }

    }
    public class JsonFilterInput
    {
        public string datefrom { get; set; }
        public string dateto { get; set; }
        public int status { get; set; }
    }
    public class DataChart
    {
        public string NameStatus { get; set; }
        public string ColorStatus { get; set; }
        public int SoLuong { get; set; }
    }
    public class WebKhachHangBillModel
    {
        public string customerId { get; set; }
        public string dateFrom { get; set; }
        public string dateTo { get; set; }
        public int status { get; set; }
        public List<GExpBillStatus> listBillStatus { get; set; }
        public List<GExpOrderStatus> listOrderStatus { get; set; }
        public List<view_GExpBill> ListBill { get; set; }
        public List<view_GExpOrder> ListOrder { get; set; }
        public List<view_GExpProblem> ListProblem { get; set; }
    }
    public class WebKhachHangOrderModel
    {
        public string ErrorMessage { get; set; }
        public view_GExpOrder OrderDetail { get; set; }
        public List<GExpProvince> ProvinderList { get; set; } = new List<GExpProvince>();
        public List<GExpDistrict> DistrictList { get; set; } = new List<GExpDistrict>();
        public List<GExpWard> WardList { get; set; } = new List<GExpWard>();
        public string WardCodeSelect { get; set; }
        public int DistrictCodeSelect { get; set; }
        public int ProvinceCodeSelect { get; set; }
    }
}
