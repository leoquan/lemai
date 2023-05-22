using CrystalDecisions.Shared.Json;
using LeMaiDomain;
using LeMaiDomain.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;

namespace LeMaiDesktop
{
    public class ApiNinja : IConnectApi
    {
        private const string url = "https://api.ninjavan.co/VN"; // Product
        //private const string url = "https://api-sandbox.ninjavan.co/sg";//Sandbox
        private string GetToken(string clientId, string clientSecrect, string Token, string IdProvider, DateTime? expires)
        {
            string token = Token;
            if (expires.HasValue == false || expires <= DateTime.Now)
            {
                var client = new RestClient(url + "/2.0/oauth/access_token");
                var request = new RestRequest(Method.POST);
                string bodyjson = JsonConvert.SerializeObject(new { client_id = clientId, client_secret = clientSecrect, grant_type = "client_credentials" });
                request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var response = client.Execute(request);
                try
                {
                    NinjaToken result = JsonConvert.DeserializeObject<NinjaToken>(response.Content);
                    if (result != null)
                    {
                        // Xử lý update Provider
                        ApiConnectUlti.UpdateToken(IdProvider, result.access_token, DateTime.Now.AddSeconds(result.expires_in - 60));
                        return result.access_token;
                    }
                    else
                    {
                        return "[E] Lỗi xác thực tài khoản";
                    }
                }
                catch
                {
                    return "[E] Lỗi xác thực tài khoản";
                }
            }
            return token;
        }
        public OutResultGHN CreateOrder(view_GExpBillGHNApi bill)
        {
            OutResultGHN rs = new OutResultGHN();
            if (bill.Freight < 0)
            {
                rs.IsSuccess = false;
                rs.Message = "Phí vận chuyển không đúng!";
                return rs;
            }
            string token = GetToken(bill.ClientId, bill.ClientSecrect, bill.Token, bill.FK_ProviderAccount, bill.ExpiresDate);
            if (token.Contains("[E]"))
            {
                rs.IsSuccess = false;
                rs.Message = token;
                return rs;
            }

            var client = new RestClient(url + "/4.1/orders");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + token);
            request.AddHeader("Content-Type", "application/json");
            JsonNinjaCreateOrderInput jsonObject = new JsonNinjaCreateOrderInput();
            //
            jsonObject.from = new NinjaFrom();
            jsonObject.to = new NinjaTo();
            jsonObject.parcel_job = new NinjaParcelJob();
            jsonObject.reference = new NinjaReference();
            jsonObject.requested_tracking_number = bill.BillCode;
            jsonObject.service_type = "Parcel";
            jsonObject.service_level = "Standard";
            // from
            if (bill.Pickup.GetValueOrDefault(false))
            {
                // Nhờ bên thứ 3 Pickup
                jsonObject.from.name = bill.SendMan;
                jsonObject.from.phone_number = bill.SendManPhone;
                jsonObject.from.address = new NinjaAddress();
                jsonObject.from.address.address1 = bill.AddressPickup;
                jsonObject.from.address.country = "VN";
                jsonObject.from.address.address_type = "home";

                jsonObject.from.address.city = bill.ProvincePickup;
                jsonObject.from.address.district = bill.DistricPickup;
                jsonObject.from.address.ward = bill.WardPickup;
            }
            else
            {
                // Gửi hàng tại shop
                jsonObject.from.name = bill.ShopName;
                jsonObject.from.phone_number = bill.ShopPhone;
                jsonObject.from.address = new NinjaAddress();
                jsonObject.from.address.address1 = bill.Address;
                jsonObject.from.address.country = "VN";
                jsonObject.from.address.address_type = "home";

                jsonObject.from.address.city = bill.ProvinceName;
                jsonObject.from.address.district = bill.DistrictName;
                jsonObject.from.address.ward = bill.WardName;
            }


            // to
            jsonObject.to.name = bill.AcceptMan;
            jsonObject.to.phone_number = bill.AcceptManPhone;
            jsonObject.to.address = new NinjaAddress();
            jsonObject.to.address.address1 = bill.AcceptManAddress;
            jsonObject.to.address.country = "VN";
            jsonObject.to.address.address_type = "home";
            jsonObject.to.address.city = bill.AcceptProvince;
            jsonObject.to.address.district = bill.AcceptDistrict;
            jsonObject.to.address.ward = bill.AcceptWard;

            // reference
            jsonObject.reference.merchant_order_number = bill.BillCode;

            // jsonObject.parcel_job
            jsonObject.parcel_job.delivery_instructions = "(" + bill.ShipNoteType + ") " + bill.Note;
            jsonObject.parcel_job.delivery_start_date = string.Format("{0:yyyy-MM-dd}", bill.RegisterDate.AddDays(1));
            jsonObject.parcel_job.delivery_timeslot = new NinjaDeliveryTimeslot();
            jsonObject.parcel_job.delivery_timeslot.start_time = "09:00";
            jsonObject.parcel_job.delivery_timeslot.end_time = "18:00";
            jsonObject.parcel_job.delivery_timeslot.timezone = "Asia/Ho_Chi_Minh";
            
            jsonObject.parcel_job.items = new List<NinjaItem>();
            jsonObject.parcel_job.items.Add(new NinjaItem { is_dangerous_good = false, item_description = bill.GoodsName, quantity = 1 });
            jsonObject.parcel_job.dimensions = new NinjaDimensions();
            jsonObject.parcel_job.dimensions.weight = (double)(bill.BillWeight / 1000);

            if (bill.FK_PaymentType == "GTT")
            {
                jsonObject.parcel_job.cash_on_delivery = (double)bill.COD;
            }
            else
            {
                jsonObject.parcel_job.cash_on_delivery = (double)(bill.COD + bill.Freight);
            }
            // Pickup
            if(bill.Pickup.GetValueOrDefault(false))
            {
                // Nhận hàng BT3
                jsonObject.parcel_job.is_pickup_required = true;
                jsonObject.parcel_job.pickup_service_type = "Scheduled";
                jsonObject.parcel_job.pickup_service_level = "Standard";
                jsonObject.parcel_job.pickup_date = String.Format("{0:yyyy-MM-dd}", DateTime.Now);
                
                jsonObject.parcel_job.pickup_address = new NinjaPickupAddress();
                jsonObject.parcel_job.pickup_address.name = bill.SendMan;
                jsonObject.parcel_job.pickup_address.phone_number = bill.SendManPhone;
                jsonObject.parcel_job.pickup_address.address = new NinjaAddress();
                jsonObject.parcel_job.pickup_address.address.address1 = bill.AddressPickup;
                jsonObject.parcel_job.pickup_address.address.country = "VN";
                jsonObject.parcel_job.pickup_address.address.address_type = "home";
                jsonObject.parcel_job.pickup_address.address.city = bill.ProvincePickup;
                jsonObject.parcel_job.pickup_address.address.district = bill.DistricPickup;
                jsonObject.parcel_job.pickup_address.address.ward = bill.WardPickup;

                jsonObject.parcel_job.pickup_timeslot = new NinjaPickupTimeslot();
                jsonObject.parcel_job.pickup_timeslot.start_time = "09:00";
                jsonObject.parcel_job.pickup_timeslot.end_time = "18:00";
                jsonObject.parcel_job.pickup_timeslot.timezone = "Asia/Ho_Chi_Minh";

                jsonObject.parcel_job.pickup_instructions = "Vui lòng nhận hàng sớm xin cảm ơn";

            }    
            var bodyjson = JsonConvert.SerializeObject(jsonObject);
            request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                JsonNinjaCreateOrderOutput result = JsonConvert.DeserializeObject<JsonNinjaCreateOrderOutput>(response.Content);
                if (result != null && string.IsNullOrEmpty(result.tracking_number) == false)
                {
                    rs.IsSuccess = true;
                    rs.OrderCode = result.tracking_number;
                    rs.Message = "Nạp đơn thành công";
                }
                else
                {
                    NinjaErrorOutput error = JsonConvert.DeserializeObject<NinjaErrorOutput>(response.Content);
                    if (error != null)
                    {
                        rs.IsSuccess = false;
                        rs.Message = error.error.message;
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

        public OutTrackingResultGHN Tracking(view_GExpBillGHNApi bill)
        {
            OutTrackingResultGHN rs = new OutTrackingResultGHN();
            rs.IsSuccess = false;
            rs.Message = "Đã cập nhật dữ liệu hành trình";
            return rs;
        }
        private string Tranlate(string code)
        {
            string res = string.Empty;
            switch (code)
            {
                case "Pending Pickup":
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
                case "Delivered":
                    res = "Giao hàng thành công";
                    break;
                default:
                    res = code;
                    break;
            }
            return res;
        }

        public OutResultGHN UpdateCOD(view_GExpBillGHNApi bill)
        {
            OutResultGHN rs = new OutResultGHN();
            rs.IsSuccess = false;
            rs.Message = "Chưa hỗ trợ cập nhật COD của NINJA từ API.";
            return rs;
        }

        public OutResultGHN UpdateOrder(view_GExpBillGHNApi bill)
        {
            OutResultGHN rs = new OutResultGHN();
            rs.IsSuccess = false;
            rs.Message = "Chưa hỗ trợ cập nhật thông tin đơn hàng NINJA từ API.";
            return rs;
        }
        public OutResultGHN CancelOrder(view_GExpBillGHNApi bill)
        {
            OutResultGHN rs = new OutResultGHN();
            string token = GetToken(bill.ClientId, bill.ClientSecrect, bill.Token, bill.FK_ProviderAccount, bill.ExpiresDate);
            if (token.Contains("[E]"))
            {
                rs.IsSuccess = false;
                rs.Message = token;
                return rs;
            }
            var client = new RestClient(url + "/2.2/orders/" + bill.BT3Code);
            var request = new RestRequest();
            request.Method = Method.DELETE;
            request.AddHeader("Authorization", "Bearer " + token);

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                NinjaCancelOutput result = JsonConvert.DeserializeObject<NinjaCancelOutput>(response.Content);
                if (result != null)
                {
                    // Thành công
                    rs.IsSuccess = true;
                    rs.Message = "Hủy đơn hàng NINJA thành công của tài khoản: " + bill.ProviderName;
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
    public class NinjaCancelOutput
    {
        public string trackingId { get; set; }
        public string status { get; set; }
        public string updatedAt { get; set; }
        public NinjaError error { get; set; }
    }
    public class NinjaEvent
    {
        public int shipper_id { get; set; }
        public string tracking_number { get; set; }
        public string shipper_order_ref_no { get; set; }
        public DateTime timestamp { get; set; }
        public string status { get; set; }
        public bool is_parcel_on_rts_leg { get; set; }
        public string comments { get; set; }
    }

    public class JsonNinjaTrackingOutput
    {
        public NinjaError error { get; set; }
        public string tracking_number { get; set; }
        public bool is_full_history_available { get; set; }
        public List<NinjaEvent> events { get; set; }
    }

    public class NinjaToken
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires { get; set; }
        public int expires_in { get; set; }
    }
    public class NinjaAddress
    {
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string ward { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string address_type { get; set; }
        public string country { get; set; }
        public string postcode { get; set; }
    }

    public class NinjaDeliveryTimeslot
    {
        public string start_time { get; set; }
        public string end_time { get; set; }
        public string timezone { get; set; }
    }

    public class NinjaDimensions
    {
        public double weight { get; set; }
    }
    public class NinjaFrom
    {
        public string name { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public NinjaAddress address { get; set; }
    }
    public class NinjaPickupAddress
    {
        public string name { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public NinjaAddress address { get; set; }
    }
    public class NinjaItem
    {
        public string item_description { get; set; }
        public int quantity { get; set; }
        public bool is_dangerous_good { get; set; }
    }

    public class NinjaParcelJob
    {
        public bool is_pickup_required { get; set; }
        public string pickup_address_id { get; set; }
        public string pickup_service_type { get; set; }
        public string pickup_service_level { get; set; }
        public string pickup_date { get; set; }
        public double cash_on_delivery { get; set; }
        public NinjaPickupTimeslot pickup_timeslot { get; set; }
        public string pickup_instructions { get; set; }
        public string delivery_instructions { get; set; }
        public string delivery_start_date { get; set; }
        public NinjaDeliveryTimeslot delivery_timeslot { get; set; }
        public NinjaDimensions dimensions { get; set; }
        public List<NinjaItem> items { get; set; }
        public NinjaPickupAddress pickup_address { get; set; }
    }


    public class NinjaPickupTimeslot
    {
        public string start_time { get; set; }
        public string end_time { get; set; }
        public string timezone { get; set; }
    }

    public class NinjaReference
    {
        public string merchant_order_number { get; set; }
    }

    public class JsonNinjaCreateOrderInput
    {
        public string service_type { get; set; }
        public string service_level { get; set; }
        public string requested_tracking_number { get; set; }
        public NinjaReference reference { get; set; }
        public NinjaFrom from { get; set; }
        public NinjaTo to { get; set; }
        public NinjaParcelJob parcel_job { get; set; }
    }
    public class NinjaTo
    {
        public string name { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public NinjaAddress address { get; set; }
    }

    public class JsonNinjaCreateOrderOutput
    {
        public string requested_tracking_number { get; set; }
        public string tracking_number { get; set; }
        public string service_type { get; set; }
        public string service_level { get; set; }
        public NinjaReference reference { get; set; }
        public NinjaFrom from { get; set; }
        public NinjaTo to { get; set; }
        public NinjaParcelJob parcel_job { get; set; }
    }
    public class NinjaDetail
    {
        public string reason { get; set; }
        public string message { get; set; }
    }

    public class NinjaError
    {
        public string request_id { get; set; }
        public string title { get; set; }
        public string message { get; set; }
        public List<NinjaDetail> details { get; set; }
    }

    public class NinjaErrorOutput
    {
        public NinjaError error { get; set; }
    }
    #region Webhook
    public class NinjaNewMeasurements
    {
        public double width { get; set; }
        public double height { get; set; }
        public double length { get; set; }
        public string size { get; set; }
        public double volumetric_weight { get; set; }
        public double measured_weight { get; set; }
    }

    public class NinjaPod
    {
        public string type { get; set; }
        public string name { get; set; }
        public string identity_number { get; set; }
        public string contact { get; set; }
        public string uri { get; set; }
        public bool left_in_safe_place { get; set; }
    }

    public class NinjaPreviousMeasurements
    {
        public double width { get; set; }
        public double height { get; set; }
        public double length { get; set; }
        public string size { get; set; }
        public double volumetric_weight { get; set; }
        public double measured_weight { get; set; }
    }

    public class WHNinjaInput
    {
        public int shipper_id { get; set; }
        public string status { get; set; }
        public string shipper_ref_no { get; set; }
        public string tracking_ref_no { get; set; }
        public string shipper_order_ref_no { get; set; }
        public DateTime timestamp { get; set; }
        public string id { get; set; }
        public string previous_status { get; set; }
        public string tracking_id { get; set; }
        public string comments { get; set; }
        public string previous_size { get; set; }
        public string new_size { get; set; }
        public string previous_weight { get; set; }
        public string new_weight { get; set; }
        public NinjaPreviousMeasurements previous_measurements { get; set; }
        public NinjaNewMeasurements new_measurements { get; set; }
        public NinjaPod pod { get; set; }
    }
    public class NinjaStatus
    {
        public string id { get; set; }
        public string description { get; set; }
    }

    public class NinjaStatusDiction
    {
        public List<NinjaStatus> NinjaEvent { get; set; }
    }
    #endregion
}
