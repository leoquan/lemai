using LeMaiDomain;
using LeMaiDomain.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static LeMaiDesktop.ApiBEST;

namespace LeMaiDesktop
{
    public class ApiGHN : IConnectApi
    {
        public OutResultGHN CreateOrder(view_GExpBillGHNApi bill)
        {
            OutResultGHN rs = new OutResultGHN();
            if (bill.Freight < 0)
            {
                rs.IsSuccess = false;
                rs.Message = "Phí vận chuyển không đúng!";
                return rs;
            }
            var client = new RestClient("https://online-gateway.ghn.vn/shiip/public-api/v2/shipping-order/create");
            var request = new RestRequest();
            request.Method = Method.POST;
            request.AddHeader("Token", bill.Token);
            request.AddHeader("ShopId", bill.ShopId);
            request.AddHeader("Content-Type", "application/json");
            JsonGHNInput jsonObject = new JsonGHNInput();
            jsonObject.client_order_code = bill.BillCode;
            jsonObject.required_note = bill.ShipNoteCodeGHN;
            jsonObject.note = bill.Note;
            jsonObject.service_type_id = 2;
            jsonObject.service_id = 0;
            if (bill.Pickup.GetValueOrDefault(false))
            {
                // Nhờ bên thứ 3 nhận hàng giùm
                jsonObject.from_name = bill.NamePickup;
                jsonObject.from_phone = bill.PhonePickup;

                jsonObject.from_address = bill.AddressPickup;
                jsonObject.from_ward_name = bill.WardPickup;
                jsonObject.from_district_name = bill.DistricPickup;
                jsonObject.from_province_name = bill.ProvincePickup;

                jsonObject.return_name = bill.SendMan;
                jsonObject.return_phone = bill.SendManPhone;

                jsonObject.return_address = bill.AddressPickup;
                jsonObject.return_ward_name = bill.WardPickup;
                jsonObject.return_district_name = bill.DistricPickup;
                jsonObject.return_province_name = bill.ProvincePickup;

            }
            else
            {
                jsonObject.from_name = bill.ShopName;
                jsonObject.from_phone = bill.ShopPhone;

                jsonObject.from_address = bill.Address;
                jsonObject.from_ward_name = bill.WardName;
                jsonObject.from_district_name = bill.DistrictName;
                jsonObject.from_province_name = bill.ProvinceName;

                jsonObject.return_name = bill.ShopName;
                jsonObject.return_phone = bill.ShopPhone;

                jsonObject.return_address = bill.Address;
                jsonObject.return_ward_name = bill.WardName;
                jsonObject.return_district_name = bill.DistrictName;
                jsonObject.return_province_name = bill.ProvinceName;

            }

            jsonObject.to_name = bill.AcceptMan;
            jsonObject.to_phone = bill.AcceptManPhone;
            jsonObject.to_address = bill.AcceptManAddress;

            jsonObject.to_ward_name = bill.AcceptWard;
            jsonObject.to_district_name = bill.AcceptDistrict;
            jsonObject.to_province_name = bill.AcceptProvince;

            jsonObject.weight = (int)bill.BillWeight;
            jsonObject.length = bill.GoodsL;
            jsonObject.height = bill.GoodsH;
            jsonObject.width = bill.GoodsW;

            if (bill.COD > bill.InsuranceValue || bill.COD == 0)
            {
                jsonObject.insurance_value = bill.InsuranceValue;
            }
            else
            {
                jsonObject.insurance_value = (int)bill.COD;
            }

            rs.BT3COD = bill.COD;

            // Chuyển đổi cân nặng
            int convertWeight = bill.ConvertWeight.GetValueOrDefault(0);
            if (convertWeight > 0)
            {
                jsonObject.weight = convertWeight;
                int x = 10;
                if (convertWeight > 1000)
                {
                    x = (int)Math.Pow(((convertWeight / 1000) * 5000), (1.0 / 3.0));
                }
                jsonObject.length = x;
                jsonObject.height = x;
                jsonObject.width = x;
            }

            if (bill.FK_PaymentType == "NTT")
            {
                // Nhận thanh toán thì thu hộ = thu hộ + phí vận chuyển
                rs.BT3COD = bill.COD + bill.Freight;
            }
            rs.BT3PayType = "GTT";
            jsonObject.payment_type_id = 1; // Gửi thanh toán hết khỏi lăn tăn
            if (bill.AlwayReceivePay)
            {
                // Tính phí dịch vụ thay đổi COD
                var clientCheck = new RestClient("https://online-gateway.ghn.vn/shiip/public-api/v2/shipping-order/fee");
                var requestCheck = new RestRequest();
                requestCheck.Method = Method.POST;
                requestCheck.AddHeader("Token", bill.Token);
                requestCheck.AddHeader("ShopId", bill.ShopId);
                requestCheck.AddHeader("Content-Type", "application/json");
                JsonGHNCalFeeInput calJson = new JsonGHNCalFeeInput();
                // Thêm data cho json ở đây
                calJson.weight = jsonObject.weight;
                calJson.cod_value = (int)rs.BT3COD;
                calJson.cod_failed_amount = 0;
                calJson.service_id = jsonObject.service_id;
                calJson.service_type_id = jsonObject.service_type_id;
                // From
                calJson.from_district_id = Int32.Parse(bill.DistrictCode);
                calJson.from_ward_code = bill.WardCode;
                // To
                calJson.to_district_id = bill.AcceptDistrictCode;
                calJson.to_ward_code = bill.AcceptWardCode;
                calJson.height = jsonObject.height;
                calJson.width = jsonObject.width;
                calJson.length = jsonObject.length;
                calJson.insurance_value = jsonObject.insurance_value;
                calJson.cod_value = (int)rs.BT3COD;
                string bodyFee = JsonConvert.SerializeObject(calJson);
                requestCheck.AddParameter("application/json", bodyFee, ParameterType.RequestBody);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var responseCheck = clientCheck.Execute(requestCheck);
                try
                {
                    JsonGHNCalFeeOutput rsFee = JsonConvert.DeserializeObject<JsonGHNCalFeeOutput>(responseCheck.Content);
                    if (rsFee != null)
                    {
                        if (rsFee.data != null)
                        {
                            jsonObject.payment_type_id = 2; // Nhận thanh toán
                            rs.BT3PayType = "NTT";
                            rs.BT3COD = rs.BT3COD - rsFee.data.total;// Tính toán lại số tiền thu hộ = số tiền tổng - tổng phí
                        }
                    }
                }
                catch
                {
                }
            }
            jsonObject.cod_amount = (int)rs.BT3COD;
            jsonObject.items = new List<Item>();
            Item it = new Item();
            it.quantity = bill.GoodsNumber;
            it.name = bill.GoodsName;
            it.category = new Category();
            it.category.level1 = "XXX";
            jsonObject.items.Add(it);

            string bodyjson = JsonConvert.SerializeObject(jsonObject);
            request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                JsonGHNOutput result = JsonConvert.DeserializeObject<JsonGHNOutput>(response.Content);
                if (result != null)
                {
                    if (result.data != null)
                    {
                        rs.OrderCode = result.data.order_code;
                        rs.BT3Freight = decimal.Parse(result.data.total_fee);
                        rs.IsSuccess = true;
                    }
                    else
                    {
                        rs.Message = result.message;
                        rs.IsSuccess = false;
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

        public OutTrackingResultGHN Tracking(view_GExpBillGHNApi bill)
        {
            OutTrackingResultGHN rs = new OutTrackingResultGHN();
            var client = new RestClient("https://fe-online-gateway.ghn.vn/order-tracking/public-api/client/tracking-logs");
            var request = new RestRequest();
            request.Method = Method.POST;
            request.AddHeader("Content-Type", "application/json");
            string bodyjson = JsonConvert.SerializeObject(new { order_code = bill.BT3Code });
            request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                GHNV2TrackingOutput result = JsonConvert.DeserializeObject<GHNV2TrackingOutput>(response.Content);
                if (result != null)
                {
                    if (result.code == 200)
                    {
                        // Thành công
                        rs.IsSuccess = true;
                        rs.Message = result.message;
                        string nearstatus = string.Empty;
                        foreach (var item in result.data.tracking_logs)
                        {
                            OutTrackingLogGHN log = new OutTrackingLogGHN();
                            DateTime tempDate = item.action_at.AddHours(7);
                            log.ActionDateTime = new DateTime(tempDate.Year, tempDate.Month, tempDate.Day, tempDate.Hour, tempDate.Minute, 0, 0);
                            log.ActionDate = log.ActionDateTime.ToString();
                            log.StatusCode = item.status;
                            if (nearstatus == "picked" && item.status == "storing")
                            {
                                log.StatusCode = "storing_tt";
                            }
                            nearstatus = item.status;
                            log.Note = "[" + item.status_name + "] " + item.location.address + " - NV: " + item.executor.name + " SĐT:" + item.executor.phone;
                            log.ProviderName = "GHN";

                            rs.outTrackingLogs.Add(log);


                        }
                    }
                    else
                    {
                        rs.IsSuccess = false;
                        rs.Message = result.message;
                    }
                }
                else
                {
                    rs.IsSuccess = false;
                    rs.Message = "Lỗi không xác định";
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
            var client = new RestClient("https://online-gateway.ghn.vn/shiip/public-api/v2/shipping-order/updateCOD");
            var request = new RestRequest();
            request.Method = Method.POST;
            request.AddHeader("Token", bill.Token);
            request.AddHeader("Content-Type", "application/json");
            if (bill.FK_PaymentType == "NTT")
            {
                bill.COD = bill.COD + bill.Freight;
            }
            string bodyjson = JsonConvert.SerializeObject(new { order_code = bill.BT3Code, cod_amount = (int)bill.COD });
            request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                JsonGHNOutput result = JsonConvert.DeserializeObject<JsonGHNOutput>(response.Content);
                if (result != null)
                {
                    if (result.code == 200)
                    {
                        rs.IsSuccess = true;
                        rs.Message = "Cập nhật COD thành công";
                    }
                    else
                    {
                        rs.IsSuccess = false;
                        rs.Message = result.message;
                    }
                }
                else
                {
                    rs.IsSuccess = false;
                    rs.Message = "Lỗi không xác định";
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

        public OutResultGHN UpdateOrder(view_GExpBillGHNApi bill)
        {
            OutResultGHN rs = new OutResultGHN();
            var client = new RestClient("https://online-gateway.ghn.vn/shiip/public-api/v2/shipping-order/update");
            var request = new RestRequest();
            request.Method = Method.POST;
            request.AddHeader("Token", bill.Token);
            request.AddHeader("ShopId", bill.ShopId);
            request.AddHeader("Content-Type", "application/json");
            JsonGHNUpdateOrderInput jsonObject = new JsonGHNUpdateOrderInput();

            jsonObject.order_code = bill.BT3Code;
            jsonObject.to_name = bill.AcceptMan;
            jsonObject.to_phone = bill.AcceptManPhone;
            jsonObject.to_address = bill.AcceptManAddress;
            jsonObject.to_ward_name = bill.AcceptWard;
            jsonObject.to_district_name = bill.AcceptDistrict;
            jsonObject.to_province_name = bill.AcceptProvince;
            jsonObject.note = bill.Note;
            jsonObject.required_note = bill.ShipNoteCodeGHN;
            jsonObject.weight = (int)bill.BillWeight;
            jsonObject.length = bill.GoodsL;
            jsonObject.height = bill.GoodsH;
            jsonObject.width = bill.GoodsW;
            //if (bill.COD > bill.InsuranceValue || bill.COD == 0)
            //{
            //    jsonObject.insurance_value = bill.InsuranceValue - 1000;
            //}
            //else
            //{
            //    jsonObject.insurance_value = (int)bill.COD;
            //}
            //rs.BT3COD = bill.COD;
            //if (bill.FK_PaymentType == "NTT")
            //{
            //    // Nhận thanh toán thì thu hộ = thu hộ + phí vận chuyển
            //    rs.BT3COD = bill.COD + bill.Freight;
            //}
            //jsonObject.cod_amount = (int)rs.BT3COD;

            string bodyjson = JsonConvert.SerializeObject(jsonObject);
            request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                JsonGHNOutput result = JsonConvert.DeserializeObject<JsonGHNOutput>(response.Content);
                if (result != null)
                {
                    if (result.code == 200)
                    {
                        rs.IsSuccess = true;
                        rs.Message = "Cập nhật thông tin đơn hàng thành công";
                    }
                    else
                    {
                        rs.IsSuccess = false;
                        rs.Message = result.message;
                    }
                }
                else
                {
                    rs.IsSuccess = false;
                    rs.Message = "Lỗi không xác định";
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
        private string Tranlate(string code)
        {
            string res = string.Empty;
            switch (code)
            {
                case "picking":
                    res = "Chờ nhận hàng";
                    break;
                case "money_collect_picking":
                    res = "";
                    break;
                case "picked":
                    res = "Đã nhận hàng";
                    break;
                case "storing":
                    res = "Lưu kho";
                    break;
                case "storing_tt":
                    res = "Lưu kho TT";
                    break;
                case "transporting":
                    res = "Trung chuyển";
                    break;
                case "delivering":
                    res = "Đang giao hàng";
                    break;
                case "delivery_fail":
                    res = "Giao hàng thất bại";
                    break;
                case "money_collect_delivering":
                    res = "";
                    break;
                case "delivered":
                    res = "Giao hàng thành công";
                    break;
                default:
                    res = code;
                    break;
            }
            return res;
        }

        public OutResultGHN CancelOrder(view_GExpBillGHNApi bill)
        {
            OutResultGHN rs = new OutResultGHN();
            var client = new RestClient("https://online-gateway.ghn.vn/shiip/public-api/v2/switch-status/cancel");
            var request = new RestRequest();
            request.Method = Method.POST;
            request.AddHeader("Token", bill.Token);
            request.AddHeader("ShopId", bill.ShopId);
            request.AddHeader("Content-Type", "application/json");
            JsonGHNCancelOrderInput jsonObject = new JsonGHNCancelOrderInput();
            jsonObject.order_codes = new List<string>();
            jsonObject.order_codes.Add(bill.BT3Code);
            string bodyjson = JsonConvert.SerializeObject(jsonObject);
            request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                JsonGHNCancelOutput result = JsonConvert.DeserializeObject<JsonGHNCancelOutput>(response.Content);
                if (result != null)
                {
                    if (result.code == 200)
                    {
                        rs.IsSuccess = true;
                        rs.Message = "Hủy đơn hàng GHN thành công của tài khoản: " + bill.ProviderName;
                    }
                    else
                    {
                        rs.IsSuccess = false;
                        rs.Message = result.message;
                    }
                }
                else
                {
                    rs.IsSuccess = false;
                    rs.Message = "Lỗi không xác định";
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
    }
    public class JsonGHNCancelOrderInput
    {
        public List<string> order_codes { get; set; }
    }
    public class Category
    {
        public string level1 { get; set; }
    }

    public class Item
    {
        public string name { get; set; }
        public string code { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public int length { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public Category category { get; set; }
    }
    public class JsonGHNUpdateOrderInput
    {
        public string order_code { get; set; }
        public string note { get; set; }
        public string required_note { get; set; }
        public string to_name { get; set; }
        public string to_phone { get; set; }
        public string to_address { get; set; }
        public string to_ward_name { get; set; }
        public string to_district_name { get; set; }
        public string to_province_name { get; set; }
        public string content { get; set; }
        public int weight { get; set; }
        public int length { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        //public int cod_amount { get; set; }
        //public int insurance_value { get; set; }
    }
    public class JsonGHNInput
    {
        public int payment_type_id { get; set; }
        public string note { get; set; }
        public string from_name { get; set; }
        public string from_phone { get; set; }
        public string from_address { get; set; }
        public string from_ward_name { get; set; }
        public string from_district_name { get; set; }
        public string from_province_name { get; set; }
        public string required_note { get; set; }
        public string return_name { get; set; }
        public string return_phone { get; set; }
        public string return_address { get; set; }
        public string return_ward_name { get; set; }
        public string return_district_name { get; set; }
        public string return_province_name { get; set; }
        public string client_order_code { get; set; }
        public string to_name { get; set; }
        public string to_phone { get; set; }
        public string to_address { get; set; }
        public string to_ward_name { get; set; }
        public string to_district_name { get; set; }
        public string to_province_name { get; set; }
        public int cod_amount { get; set; }
        public string content { get; set; }
        public int weight { get; set; }
        public int length { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int pick_station_id { get; set; }
        public object deliver_station_id { get; set; }
        public int insurance_value { get; set; }
        public int service_id { get; set; }
        public int service_type_id { get; set; }
        public object coupon { get; set; }
        public object pick_shift { get; set; }
        public int pickup_time { get; set; }
        public List<Item> items { get; set; }
    }

    public class JsonGHNCalFeeInput
    {
        public int from_district_id { get; set; }
        public string from_ward_code { get; set; }
        public int service_id { get; set; }
        public int service_type_id { get; set; }
        public int to_district_id { get; set; }
        public string to_ward_code { get; set; }
        public int height { get; set; }
        public int length { get; set; }
        public int weight { get; set; }
        public int width { get; set; }
        public int cod_failed_amount { get; set; }
        public int insurance_value { get; set; }
        public int cod_value { get; set; }
    }
    // ================== OUT PUT ==========================
    public class JsonGHNCalFeeOut
    {
        public int total { get; set; }
        public int service_fee { get; set; }
        public int insurance_fee { get; set; }
        public int pick_station_fee { get; set; }
        public int coupon_value { get; set; }
        public int r2s_fee { get; set; }
        public int document_return { get; set; }
        public int double_check { get; set; }
        public int cod_fee { get; set; }
        public int pick_remote_areas_fee { get; set; }
        public int deliver_remote_areas_fee { get; set; }
        public int cod_failed_fee { get; set; }
    }

    public class JsonGHNCalFeeOutput
    {
        public int code { get; set; }
        public string message { get; set; }
        public JsonGHNCalFeeOut data { get; set; }
    }
    public class OrderData
    {
        public string order_code { get; set; }
        public string sort_code { get; set; }
        public string trans_type { get; set; }
        public string ward_encode { get; set; }
        public string district_encode { get; set; }
        public Fee fee { get; set; }
        public string total_fee { get; set; }
        public DateTime expected_delivery_time { get; set; }
    }

    public class Fee
    {
        public int main_service { get; set; }
        public int insurance { get; set; }
        public int station_do { get; set; }
        public int station_pu { get; set; }
        public int @return { get; set; }
        public int r2s { get; set; }
        public int coupon { get; set; }
    }

    public class JsonGHNOutput
    {
        public int code { get; set; }
        public string message { get; set; }
        public OrderData data { get; set; }
        public string message_display { get; set; }
    }
    public class JsonGHNCancelOutput
    {
        public int code { get; set; }
        public string message { get; set; }
    }
    // ============= TRACKING OUTPUT ===========
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class ItemTracking
    {
        public string name { get; set; }
        public int quantity { get; set; }
        public Category category { get; set; }
    }
    public class CodTransferredHistory
    {
        public string cod_transaction_id { get; set; }
        public int amount { get; set; }
        public int? cod_transferred { get; set; }
    }

    public class GHNData
    {
        //public int shop_id { get; set; }
        //public int client_id { get; set; }
        //public string return_name { get; set; }
        //public string return_phone { get; set; }
        //public string return_address { get; set; }
        //public string return_ward_code { get; set; }
        //public int return_district_id { get; set; }
        //public ReturnLocation return_location { get; set; }
        //public string from_name { get; set; }
        //public string from_phone { get; set; }
        //public string from_address { get; set; }
        //public string from_ward_code { get; set; }
        //public int from_district_id { get; set; }
        //public FromLocation from_location { get; set; }
        //public int deliver_station_id { get; set; }
        //public string to_name { get; set; }
        //public string to_phone { get; set; }
        //public string to_address { get; set; }
        //public string to_ward_code { get; set; }
        //public int to_district_id { get; set; }
        //public ToLocation to_location { get; set; }
        //public int weight { get; set; }
        //public int length { get; set; }
        //public int width { get; set; }
        //public int height { get; set; }
        //public int converted_weight { get; set; }
        //public object image_ids { get; set; }
        //public int service_type_id { get; set; }
        //public int service_id { get; set; }
        //public int payment_type_id { get; set; }
        //public List<int> payment_type_ids { get; set; }
        //public int custom_service_fee { get; set; }
        //public string sort_code { get; set; }
        //public int cod_amount { get; set; }
        //public DateTime? cod_collect_date { get; set; }
        //public DateTime? cod_transfer_date { get; set; }
        //public bool is_cod_transferred { get; set; }
        //public bool is_cod_collected { get; set; }
        //public int insurance_value { get; set; }
        //public int order_value { get; set; }
        //public int pick_station_id { get; set; }
        //public string client_order_code { get; set; }
        //public int cod_failed_amount { get; set; }
        //public object cod_failed_collect_date { get; set; }
        //public string required_note { get; set; }
        //public string content { get; set; }
        //public string note { get; set; }
        //public string employee_note { get; set; }
        //public string seal_code { get; set; }
        //public DateTime? pickup_time { get; set; }
        //public List<ItemTracking> items { get; set; }
        //public string coupon { get; set; }
        //public int coupon_campaign_id { get; set; }
        //public string _id { get; set; }
        //public string order_code { get; set; }
        //public string version_no { get; set; }
        //public string updated_ip { get; set; }
        //public int updated_employee { get; set; }
        //public int updated_client { get; set; }
        //public string updated_source { get; set; }
        //public DateTime? updated_date { get; set; }
        //public int updated_warehouse { get; set; }
        //public string created_ip { get; set; }
        //public int created_employee { get; set; }
        //public int created_client { get; set; }
        //public string created_source { get; set; }
        //public DateTime? created_date { get; set; }
        //public string status { get; set; }
        //public InternalProcess internal_process { get; set; }
        //public int pick_warehouse_id { get; set; }
        //public int deliver_warehouse_id { get; set; }
        //public int current_warehouse_id { get; set; }
        //public int return_warehouse_id { get; set; }
        //public int next_warehouse_id { get; set; }
        //public int current_transport_warehouse_id { get; set; }
        //public DateTime? leadtime { get; set; }
        //public DateTime? order_date { get; set; }
        ////public Data data { get; set; }
        //public string action { get; set; }
        //public string soc_id { get; set; }
        //public DateTime? finish_date { get; set; }
        //public List<string> tag { get; set; }
        public List<GHNLog> log { get; set; }
        //public List<WarehouseLog> warehouse_log { get; set; }
        //public bool is_partial_return { get; set; }
        //public bool is_document_return { get; set; }
        //public PickupShift pickup_shift { get; set; }
        //public List<CodTransferredHistory> cod_transferred_histories { get; set; }
        //public string transportation_status { get; set; }
        //public string transportation_phase { get; set; }
        //public ExtraService extra_service { get; set; }
        //public string last_sort_code_print { get; set; }
        //public int print_by_user_id { get; set; }
        //public string print_by_user_name { get; set; }
        //public DateTime? print_time { get; set; }
    }

    public class DocumentReturn
    {
        public bool flag { get; set; }
    }

    public class ExtraService
    {
        public DocumentReturn document_return { get; set; }
        public bool double_check { get; set; }
    }

    public class FromLocation
    {
        public double lat { get; set; }
        public double @long { get; set; }
        public string cell_code { get; set; }
        public int trust_level { get; set; }
        public string wardcode { get; set; }
    }

    public class InternalProcess
    {
        public string status { get; set; }
        public string type { get; set; }
    }



    public class GHNLog
    {
        public string status { get; set; }
        public int driver_id { get; set; }
        public string driver_name { get; set; }
        public string driver_phone { get; set; }
        public int payment_type_id { get; set; }
        public string trip_code { get; set; }
        public DateTime updated_date { get; set; }
        public string reason_code { get; set; }
        public string reason { get; set; }
    }

    public class PickupShift
    {
    }

    public class ReturnLocation
    {
        public double lat { get; set; }
        public double @long { get; set; }
        public string cell_code { get; set; }
        public int trust_level { get; set; }
        public string wardcode { get; set; }
    }

    public class JsonGHNTrackingOutput
    {
        public int code { get; set; }
        public string message { get; set; }
        public GHNData data { get; set; }
    }

    public class ToLocation
    {
        public double lat { get; set; }
        public double @long { get; set; }
        public string cell_code { get; set; }
        public string place_id { get; set; }
        public int trust_level { get; set; }
        public string wardcode { get; set; }
    }

    public class WarehouseLog
    {
        public int current_warehouse_id { get; set; }
        public int pick_warehouse_id { get; set; }
        public int deliver_warehouse_id { get; set; }
        public int return_warehouse_id { get; set; }
        public DateTime updated_date { get; set; }
        public int? next_warehouse_id { get; set; }
    }

    #region Tracking Log
    public class GHNV2Data
    {
        public GHNV2OrderInfo order_info { get; set; }
        public List<GHNV2TrackingLog> tracking_logs { get; set; }
        public bool is_sender { get; set; }
    }

    public class GHNV2Executor
    {
        public int client_id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public int? employee_id { get; set; }
    }

    public class GHNV2Location
    {
        public string address { get; set; }
        public string ward_code { get; set; }
        public int district_id { get; set; }
        public int warehouse_id { get; set; }
        public int? next_warehouse_id { get; set; }
    }

    public class GHNV2OrderInfo
    {
        public string order_code { get; set; }
        public string client_order_code { get; set; }
        public int shop_id { get; set; }
        public string status { get; set; }
        public string action { get; set; }
        public string status_name { get; set; }
        public DateTime picktime { get; set; }
        public DateTime leadtime { get; set; }
        public DateTime finish_date { get; set; }
        public string to_name { get; set; }
        public string to_phone { get; set; }
        public string to_address { get; set; }
        public string from_name { get; set; }
        public string from_phone { get; set; }
        public string from_address { get; set; }
        public string return_name { get; set; }
        public string return_phone { get; set; }
        public string return_address { get; set; }
        public int main_service_fee { get; set; }
        public int total_fee { get; set; }
        public int payment_type_id { get; set; }
        public int insurance_value { get; set; }
        public string order_version { get; set; }
        public bool is_partial_return { get; set; }
        public bool danger_zone_sender { get; set; }
        public bool danger_zone_deliver { get; set; }
        public int sub { get; set; }
    }

    public class GHNV2TrackingOutput
    {
        public int code { get; set; }
        public string message { get; set; }
        public GHNV2Data data { get; set; }
    }

    public class GHNV2TrackingLog
    {
        public string order_code { get; set; }
        public string status { get; set; }
        public string status_name { get; set; }
        public GHNV2Location location { get; set; }
        public GHNV2Executor executor { get; set; }
        public DateTime action_at { get; set; }
        public object sync_data_at { get; set; }
        public string action_code { get; set; }
    }
    #endregion
}
