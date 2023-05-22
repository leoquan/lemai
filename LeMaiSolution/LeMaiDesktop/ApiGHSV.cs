using LeMaiDomain;
using LeMaiDomain.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;

namespace LeMaiDesktop
{
    public class ApiGHSV : IConnectApi
    {
        private int GetShopId(view_GExpBillGHNApi bill)
        {
            if (bill.Pickup.GetValueOrDefault(false))
            {
                var client = new RestClient("https://api.ghsv.vn/v1/shop/create");
                var request = new RestRequest();
                request.Method = Method.POST;
                request.AddHeader("token", bill.Token);
                request.AddHeader("Content-Type", "application/json");
                JsonGHSVShopCreateInput input = new JsonGHSVShopCreateInput();

                input.name = bill.SendMan;
                input.phone = bill.SendManPhone;
                input.province = bill.ProvincePickup;
                input.district = bill.DistricPickup;
                input.ward = bill.WardPickup;
                input.address = bill.AddressPickup;

                string bodyjson = JsonConvert.SerializeObject(input);
                request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var response = client.Execute(request);
                try
                {
                    JsonGHSVShopCreateOutput result = JsonConvert.DeserializeObject<JsonGHSVShopCreateOutput>(response.Content);
                    if (result != null)
                    {
                        if (result.success == true)
                        {
                            return result.shop.id;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }
                catch
                {
                    return 0;
                }
            }
            else
            {
                return int.Parse(bill.ShopId);
            }
        }
        public OutResultGHN CancelOrder(view_GExpBillGHNApi bill)
        {
            OutResultGHN rs = new OutResultGHN();
            var client = new RestClient("https://api.ghsv.vn/v1/order/cancel");
            var request = new RestRequest();
            request.Method = Method.POST;
            request.AddHeader("token", bill.Token);
            request.AddHeader("Content-Type", "application/json");
            string bodyjson = JsonConvert.SerializeObject(new { client_code = bill.BillCode });
            request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                JsonGHSVOutput result = JsonConvert.DeserializeObject<JsonGHSVOutput>(response.Content);
                if (result != null)
                {
                    if (result.success == true)
                    {
                        // Thành công
                        rs.IsSuccess = true;
                        rs.Message = "Hủy đơn hàng GHSV thành công của tài khoản: " + bill.ProviderName;
                    }
                    else
                    {
                        rs.IsSuccess = false;
                        rs.Message = result.msg;
                    }
                }
                else
                {
                    // Thất bại
                    JsonGHSVErrorOutput error = JsonConvert.DeserializeObject<JsonGHSVErrorOutput>(response.Content);
                    if (error != null)
                    {
                        rs.Message = error.msg;
                        rs.IsSuccess = false;
                    }
                    else
                    {
                        rs.IsSuccess = false;
                        rs.Message = "Lỗi không xác định";
                    }

                }
            }
            catch (Exception ex)
            {
                rs.Message = ex.ToString();
                rs.IsSuccess = false;
                ApiConnectUlti.LogFileApi(response.Content, bill.BillCode, bill.FK_ProviderAccount);
            }
            return rs;
        }

        public OutResultGHN CreateOrder(view_GExpBillGHNApi bill)
        {
            OutResultGHN rs = new OutResultGHN();
            if (bill.Freight < 100)
            {
                rs.IsSuccess = false;
                rs.Message = "Phí vận chuyển không đúng!";
                return rs;
            }
            var client = new RestClient("https://api.ghsv.vn/v1/order/create");
            var request = new RestRequest();
            request.Method = Method.POST;
            request.AddHeader("token", bill.Token);
            request.AddHeader("Content-Type", "application/json");

            JsonGHSVInput input = new JsonGHSVInput();
            input.shop_id = GetShopId(bill);
            input.product = bill.GoodsName;
            input.weight = (int)bill.BillWeight;
            input.length = bill.GoodsL;
            input.width = bill.GoodsW;
            input.height = bill.GoodsH;
            input.price = (int)bill.COD;

            if (bill.FK_ShipType == "CXH")
            {
                input.config_delivery = 1;
            }
            else
            {
                input.config_delivery = 3;
            }
            input.config_collect = 1;// Thu hộ = Tiền hàng
            if (bill.FK_PaymentType == "GTT")
            {
                input.price = (int)bill.COD;
            }
            else
            {
                input.price = (int)bill.COD + (int)bill.Freight;
            }

            rs.BT3COD = input.price;
            if (input.price > bill.InsuranceValue || input.price == 0)
            {
                input.value = bill.InsuranceValue;
            }
            else
            {
                input.value = input.price;
            }

            input.is_return = false;
            input.client_code = bill.BillCode;
            input.note = bill.Note;

            input.to_name = bill.AcceptMan;
            input.to_phone = bill.AcceptManPhone;
            input.to_address = bill.AcceptManAddress;
            input.to_ward = bill.AcceptWard;
            input.to_district = bill.AcceptDistrict;
            input.to_province = bill.AcceptProvince;
            //input.source = string.Empty;

            string bodyjson = JsonConvert.SerializeObject(input);
            request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                JsonGHSVOutput result = JsonConvert.DeserializeObject<JsonGHSVOutput>(response.Content);
                if (result != null)
                {
                    if (result.success == true)
                    {
                        // Thành công
                        rs.OrderCode = result.order.required_code;
                        rs.BT3Freight = result.order.fee;
                        rs.IsSuccess = true;
                    }
                    else
                    {
                        rs.IsSuccess = false;
                        rs.Message = result.msg;
                    }
                }
                else
                {
                    // Thất bại
                    JsonGHSVErrorOutput error = JsonConvert.DeserializeObject<JsonGHSVErrorOutput>(response.Content);
                    rs.Message = error.msg;
                    rs.IsSuccess = false;
                }
            }
            catch (Exception ex)
            {
                rs.Message = ex.ToString();
                rs.IsSuccess = false;
                ApiConnectUlti.LogFileApi(response.Content, bill.BillCode, bill.FK_ProviderAccount);
            }

            return rs;
        }

        public OutTrackingResultGHN Tracking(view_GExpBillGHNApi bill)
        {
            OutTrackingResultGHN rs = new OutTrackingResultGHN();
            var client = new RestClient("https://api.ghsv.vn/v1/order/tracking");
            var request = new RestRequest();
            request.Method = Method.POST;
            request.AddHeader("token", bill.Token);
            request.AddHeader("Content-Type", "application/json");
            string bodyjson = JsonConvert.SerializeObject(new { client_code = bill.BillCode });
            request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                JsonGHSVTrackingOutput result = JsonConvert.DeserializeObject<JsonGHSVTrackingOutput>(response.Content);
                if (result != null)
                {
                    if (result.success == true)
                    {
                        // Thành công
                        rs.IsSuccess = true;
                        rs.Message = result.msg;
                        foreach (var item in result.tracking)
                        {
                            OutTrackingLogGHN log = new OutTrackingLogGHN();
                            log.ActionDate = item.time;
                            log.ActionDateTime = DateTime.ParseExact(item.time, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture);
                            log.StatusCode = item.status;
                            log.ProviderName = "GHSV";
                            if (string.IsNullOrEmpty(item.note) && string.IsNullOrEmpty(item.address))
                            {
                                log.Note = item.status;
                            }
                            else
                            {
                                log.Note = item.address + " | " + item.note;
                            }
                            rs.outTrackingLogs.Add(log);
                        }
                    }
                    else
                    {
                        rs.IsSuccess = false;
                        rs.Message = result.msg;
                    }
                }
                else
                {
                    // Thất bại
                    JsonGHSVErrorOutput error = JsonConvert.DeserializeObject<JsonGHSVErrorOutput>(response.Content);
                    if (error != null)
                    {
                        rs.Message = error.msg;
                        rs.IsSuccess = false;
                    }
                    else
                    {
                        rs.IsSuccess = false;
                        rs.Message = "Lỗi không xác định";
                    }

                }
            }
            catch (Exception ex)
            {
                rs.Message = ex.ToString();
                rs.IsSuccess = false;
                ApiConnectUlti.LogFileApi(response.Content, bill.BillCode, bill.FK_ProviderAccount);
            }

            return rs;
        }

        public OutResultGHN UpdateCOD(view_GExpBillGHNApi bill)
        {
            OutResultGHN rs = new OutResultGHN();
            rs.IsSuccess = false;
            rs.Message = "Đăng nhập tài khoản bên thứ 3 để sửa COD";
            return rs;
        }

        public OutResultGHN UpdateOrder(view_GExpBillGHNApi bill)
        {
            OutResultGHN rs = new OutResultGHN();
            rs.IsSuccess = false;
            rs.Message = "Chưa hỗ trợ cập nhật thông tin đơn hàng GHSV từ API.";
            return rs;
        }
    }
    public class JsonGHSVInput
    {
        public int shop_id { get; set; }
        public string product { get; set; }
        public int weight { get; set; }
        public int length { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int price { get; set; }
        public int value { get; set; }
        public int config_delivery { get; set; }
        public int config_collect { get; set; }
        public bool is_return { get; set; }
        public string client_code { get; set; }
        public string note { get; set; }
        public string to_name { get; set; }
        public string to_phone { get; set; }
        public string to_address { get; set; }
        public string to_province { get; set; }
        public string to_district { get; set; }
        public string to_ward { get; set; }
        public string source { get; set; }
    }
    public class OrderGHSV
    {
        public string client_code { get; set; }
        public string required_code { get; set; }
        public string sorting_code { get; set; }
        public string product { get; set; }
        public int weight { get; set; }
        public int value { get; set; }
        public int cod { get; set; }
        public string note { get; set; }
        public int config_collect { get; set; }
        public bool is_return { get; set; }
        public int shop_id { get; set; }
        public int fee { get; set; }
        public string to_name { get; set; }
        public string to_phone { get; set; }
        public string to_address { get; set; }
        public string to_province { get; set; }
        public string to_district { get; set; }
        public string to_ward { get; set; }
    }

    public class JsonGHSVOutput
    {
        public bool success { get; set; }
        public string msg { get; set; }
        public OrderGHSV order { get; set; }
    }

    public class JsonGHSVErrorOutput
    {
        public bool success { get; set; }
        public string msg { get; set; }
    }

    public class JsonGHSVTrackingOutput
    {
        public bool success { get; set; }
        public string msg { get; set; }
        public List<Tracking> tracking { get; set; }
    }

    public class Tracking
    {
        public string time { get; set; }
        public string status { get; set; }
        public string address { get; set; }
        public string note { get; set; }
    }

    public class JsonGHSVShopCreateInput
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string province { get; set; }
        public string district { get; set; }
        public string ward { get; set; }
        public string address { get; set; }
    }
    public class JsonGHSVShopCreateOutput
    {
        public bool success { get; set; }
        public string msg { get; set; }
        public JsonGHSVShop shop { get; set; }
    }

    public class JsonGHSVShop
    {
        public int id { get; set; }
    }
}
