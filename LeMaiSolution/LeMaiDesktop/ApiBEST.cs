using LeMaiDomain;
using LeMaiDomain.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiDesktop
{
    public class ApiBEST : IConnectApi
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
            var client = new RestClient("http://sgp-seaedi.800best.com/VietNamV3/v3/api/process/sears/Order/Add");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + bill.Token);
            request.AddHeader("Content-Type", "application/json");
            JsonBestInput jsonObject = new JsonBestInput();
            jsonObject.Code = bill.BillCode;
            jsonObject.ProductName = bill.GoodsName;
            if (bill.FK_PaymentType == "NTT")
            {
                bill.COD = bill.COD + bill.Freight;
            }
            if (bill.COD > bill.InsuranceValue || bill.COD == 0)
            {
                jsonObject.CollectAmount = (int)bill.COD;
                jsonObject.ProductPrice = bill.InsuranceValue;
            }
            else
            {
                jsonObject.CollectAmount = (int)bill.COD;
                jsonObject.ProductPrice = (int)bill.COD;
            }

            jsonObject.JourneyType = 1;// Order type: 1 - Delivery, 2 - Collection, 3 - Exchange
            jsonObject.ServiceId = Int32.Parse(bill.ServiceId);
            if (bill.Pickup.GetValueOrDefault(false))
            {
                // Nhờ BT3 pickup
                jsonObject.PickupType = 2;// PickupType: 1: DropOff, 2: Postman
            }
            else
            {
                // Không pickup
                jsonObject.PickupType = 1;// PickupType: 1: DropOff, 2: Postman
            }

            jsonObject.Weight = (int)bill.BillWeight;
            jsonObject.Height = 0;
            jsonObject.Length = 0;
            jsonObject.Width = 0;

            if (bill.Pickup.GetValueOrDefault(false))
            {
                // Nhờ bên thứ 3 pickup
                jsonObject.SourceCity = bill.ProvincePickup;
                jsonObject.SourceDistrict = bill.DistricPickup;
                jsonObject.SourceWard = bill.WardPickup;
                jsonObject.SourceAddress = bill.AddressPickup;

                jsonObject.SourceName = bill.SendMan;
                jsonObject.SourcePhoneNumber = bill.SendManPhone;
            }
            else
            {
                // Mình đi pickup
                jsonObject.SourceCity = bill.ProvinceName;
                jsonObject.SourceDistrict = bill.DistrictName;
                jsonObject.SourceWard = bill.WardName;

                jsonObject.SourceAddress = bill.Address;
                jsonObject.SourceName = bill.ShopName;
                jsonObject.SourcePhoneNumber = bill.ShopPhone;

            }

            jsonObject.DestCity = bill.AcceptProvince;
            jsonObject.DestDistrict = bill.AcceptDistrict;
            jsonObject.DestWard = bill.AcceptWard;
            jsonObject.DestAddress = bill.AcceptManAddress;
            jsonObject.DestName = bill.AcceptMan;
            jsonObject.DestPhoneNumber = bill.AcceptManPhone;

            // Hàng trả
            if (bill.Pickup.GetValueOrDefault(false))
            {
                // Nhờ bên thứ 3 nhận hàng
                jsonObject.ReturnCity = bill.ProvincePickup;
                jsonObject.ReturnDistrict = bill.DistricPickup;
                jsonObject.ReturnWard = bill.WardPickup;
                jsonObject.ReturnAddress = bill.AddressPickup;

                jsonObject.ReturnPhoneNumber = bill.SendManPhone;
                jsonObject.ReturnName = bill.SendMan;
            }
            else
            {
                // Mình tự đi lấy hàng
                jsonObject.ReturnCity = bill.ProvinceName;
                jsonObject.ReturnDistrict = bill.DistrictName;
                jsonObject.ReturnWard = bill.WardName;
                jsonObject.ReturnAddress = bill.Address;

                jsonObject.ReturnPhoneNumber = bill.ShopPhone;
                jsonObject.ReturnName = bill.ShopName;
            }

            jsonObject.Note = "(" + bill.ShipNoteType + ") " + bill.Note;

            string bodyjson = JsonConvert.SerializeObject(jsonObject);
            request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                JsonBestOutput result = JsonConvert.DeserializeObject<JsonBestOutput>(response.Content);
                if (result != null)
                {
                    if (result.Result == 1)
                    {
                        rs.OrderCode = result.Code;
                        rs.IsSuccess = true;
                    }
                    else
                    {
                        rs.Message = result.Message;
                        rs.IsSuccess = false;
                    }
                }
                else
                {
                    rs.Message = "Lỗi không xác định";
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
            var client = new RestClient("http://sgp-seaedi.800best.com/VietNamV3/v3/api/process/sears/Order/Query");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + bill.Token);
            request.AddHeader("Content-Type", "application/json");
            JsonBestTrackingInput jsonObject = new JsonBestTrackingInput();
            jsonObject.LangType = "vi-VN";
            jsonObject.Codes = new List<string>();
            jsonObject.Codes.Add(bill.BT3Code);
            string bodyjson = JsonConvert.SerializeObject(jsonObject);
            request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                JsonBestTrackingOutput result = JsonConvert.DeserializeObject<JsonBestTrackingOutput>(response.Content);
                if (result != null)
                {
                    if (result.Result == 1)
                    {
                        // Thành công
                        rs.IsSuccess = true;
                        rs.Message = result.Message;
                        string nearstatus = string.Empty;
                        foreach (var dt in result.data)
                        {
                            foreach (var item in dt.traceLogs)
                            {
                                OutTrackingLogGHN log = new OutTrackingLogGHN();
                                DateTime tempDate = epoch2DateTime(item.modified_at).AddHours(7);
                                log.ActionDateTime = new DateTime(tempDate.Year, tempDate.Month, tempDate.Day, tempDate.Hour, tempDate.Minute, 0, 0);
                                log.ActionDate = log.ActionDateTime.ToString();
                                log.StatusCode = "B" + item.status;
                                if (item.status == "303" && rs.UpdateFee == false)
                                {
                                    rs.UpdateFee = true;
                                    rs.BT3Freight = (decimal)item.total_fee;
                                }
                                string tranName = Tranlate(item.status);
                                if (!string.IsNullOrEmpty(tranName))
                                {
                                    log.Note = tranName;
                                    if (!string.IsNullOrEmpty(item.status_content))
                                    {
                                        log.Note = log.Note + ". " + item.status_content;
                                    }
                                    log.ProviderName = "BEST";
                                    rs.outTrackingLogs.Add(log);
                                }

                            }
                        }
                    }
                    else
                    {
                        rs.IsSuccess = false;
                        rs.Message = result.Message;
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
        public string Tranlate(string code)
        {
            string res = string.Empty;
            switch (code)
            {
                case "211":
                case "203":
                case "202":
                case "777":
                case "1000":
                case "2":
                    res = string.Empty;
                    break;
                case "301":
                    res = "Nhận hàng vào bưu cục Nguồn";
                    break;
                case "302":
                    res = "Xuất hàng đến trung tâm khai thác";
                    break;
                case "303":
                    res = "Nhận hàng vào trung tâm khai thác";
                    break;
                case "304":
                    res = "Xuất hàng khỏi trung tâm khai thác";
                    break;
                case "309":
                    res = "Nhận hàng vào bưu cục phát hàng";
                    break;
                case "601":
                    res = "Xuất hàng để đi giao";
                    break;
                case "604":
                    res = "Giao hàng không thành công";
                    break;
                case "666":
                    res = "Giao hàng thành công";
                    break;
                case "605":
                    res = "Xác nhận chuyển hoàn";
                    break;
                case "701":
                    res = "Xuất hàng khỏi bưu cục phát để trả về";
                    break;
                case "702":
                    res = "Nhận hàng vào trung tâm khai thác";
                    break;
                case "703":
                    res = "Xuất hàng khỏi trung tâm khai thác";
                    break;
                case "704":
                    res = "Nhận hàng vào bưu cục trả hàng";
                    break;
                case "705":
                    res = "Xuất hàng để trả về";
                    break;
                case "707":
                    res = "Trả hàng không thành công";
                    break;
                case "708":
                    res = "Trả hàng thành công";
                    break;
                default:
                    return code;
            }
            return res;
        }
        private DateTime epoch2DateTime(long epoch)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(epoch);
        }
        public OutResultGHN UpdateCOD(view_GExpBillGHNApi bill)
        {
            OutResultGHN rs = new OutResultGHN();
            var client = new RestClient("http://sgp-seaedi.800best.com/VietNamV3/v3/api/process/sears/Order/Update");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + bill.Token);
            request.AddHeader("Content-Type", "application/json");
            JsonBestUpdateCODInput jsonObject = new JsonBestUpdateCODInput();
            // Đưa thông tin vào json gửi đơn lên API
            jsonObject.Code = bill.BillCode;
            jsonObject.ProductName = bill.GoodsName;
            if (bill.FK_PaymentType == "NTT")
            {
                bill.COD = bill.COD + bill.Freight;
            }
            if (bill.COD > bill.InsuranceValue || bill.COD == 0)
            {
                jsonObject.CollectAmount = (int)bill.COD;
                jsonObject.ProductPrice = bill.InsuranceValue;
            }
            else
            {
                jsonObject.CollectAmount = (int)bill.COD;
                jsonObject.ProductPrice = (int)bill.COD;
            }
            jsonObject.ServiceId = Int32.Parse(bill.ServiceId);
            jsonObject.Weight = (int)bill.BillWeight;

            string bodyjson = JsonConvert.SerializeObject(jsonObject);
            request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                JsonBestOutput result = JsonConvert.DeserializeObject<JsonBestOutput>(response.Content);
                if (result != null)
                {
                    if (result.Result == 1)
                    {
                        rs.IsSuccess = true;
                        rs.Message = "Cập nhật COD thành công";
                    }
                    else
                    {
                        rs.IsSuccess = false;
                        rs.Message = result.Message;
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
            var client = new RestClient("http://sgp-seaedi.800best.com/VietNamV3/v3/api/process/sears/Order/UpdateAddress");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + bill.Token);
            request.AddHeader("Content-Type", "application/json");
            JsonBestUpdateOrderInput jsonObject = new JsonBestUpdateOrderInput();
            // Đưa thông tin vào json gửi đơn lên API
            jsonObject.Code = bill.BillCode;
            jsonObject.AddressTypeId = 2;// Chỉnh sửa thông tin người nhận
            jsonObject.CityName = bill.AcceptProvince;
            jsonObject.DistrictName = bill.AcceptDistrict;
            jsonObject.WardName = bill.AcceptWard;
            jsonObject.Address = bill.AcceptManAddress;
            jsonObject.ContactName = bill.AcceptMan;
            jsonObject.PhoneNumber1 = bill.AcceptManPhone;

            string bodyjson = JsonConvert.SerializeObject(jsonObject);
            request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                JsonBestOutput result = JsonConvert.DeserializeObject<JsonBestOutput>(response.Content);
                if (result != null)
                {
                    if (result.Result == 1)
                    {
                        rs.IsSuccess = true;
                        rs.Message = "Cập nhật COD thành công";
                    }
                    else
                    {
                        rs.IsSuccess = false;
                        rs.Message = result.Message;
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

        public OutResultGHN CancelOrder(view_GExpBillGHNApi bill)
        {
            OutResultGHN rs = new OutResultGHN();
            var client = new RestClient("http://sgp-seaedi.800best.com/VietNamV3/v3/api/process/sears/Order/Cancel");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + bill.Token);
            request.AddHeader("Content-Type", "application/json");
            string bodyjson = JsonConvert.SerializeObject(new { Code = bill.BT3Code });
            request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                JsonBestOutput result = JsonConvert.DeserializeObject<JsonBestOutput>(response.Content);
                if (result != null)
                {
                    if (result.Result == 1)
                    {
                        rs.IsSuccess = true;
                        rs.Message = "Hủy đơn hàng BEST thành công từ tài khoản " + bill.ProviderName;
                    }
                    else
                    {
                        rs.IsSuccess = false;
                        rs.Message = result.Message;
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

        public class JsonBestUpdateCODInput
        {
            public string Code { get; set; }
            public string ProductName { get; set; }
            public int CollectAmount { get; set; }
            public int ProductPrice { get; set; }
            public int ServiceId { get; set; }
            public int Weight { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public int Length { get; set; }
        }
        public class JsonBestUpdateOrderInput
        {
            public string Code { get; set; }
            public int AddressTypeId { get; set; }
            public string Address { get; set; }
            public string CityName { get; set; }
            public string DistrictName { get; set; }
            public string WardName { get; set; }
            public string ContactName { get; set; }
            public string PhoneNumber1 { get; set; }
            public string PhoneNumber2 { get; set; }
        }

        public class JsonBestTrackingData
        {
            public List<TraceLog> traceLogs { get; set; }
            public string merchant_order_code { get; set; }
            public string code_best { get; set; }
        }

        public class JsonBestTrackingOutput
        {
            public List<JsonBestTrackingData> data { get; set; }
            public int Result { get; set; }
            public string Message { get; set; }
        }

        public class TraceLog
        {
            public string status { get; set; }
            public long modified_at { get; set; }
            public string status_content { get; set; }
            public int? weight { get; set; }
            public int? length { get; set; }
            public int? width { get; set; }
            public int? height { get; set; }
            public double? freight_fee { get; set; }
            public double? cod_fee { get; set; }
            public double? insurance_fee { get; set; }
            public double? vat_fee { get; set; }
            public double? total_fee { get; set; }
        }


        public class JsonBestOutput
        {
            public int Result { get; set; }
            public string Message { get; set; }
            public string Code { get; set; }
            public string RouteCode { get; set; }
        }
        public class JsonBestTrackingInput
        {
            public string LangType { get; set; }
            public List<string> Codes { get; set; }
        }
        public class JsonBestInput
        {
            public string Code { get; set; }
            public string ProductName { get; set; }
            public int CollectAmount { get; set; }
            public int ProductPrice { get; set; }
            public int JourneyType { get; set; }
            public int ServiceId { get; set; }
            public int PickupType { get; set; }
            public int Weight { get; set; }
            public int Height { get; set; }
            public int Length { get; set; }
            public int Width { get; set; }
            public string SourceCity { get; set; }
            public string SourceDistrict { get; set; }
            public string SourceWard { get; set; }
            public string SourceAddress { get; set; }
            public string SourceName { get; set; }
            public string SourcePhoneNumber { get; set; }
            public string DestCity { get; set; }
            public string DestDistrict { get; set; }
            public string DestWard { get; set; }
            public string DestAddress { get; set; }
            public string DestName { get; set; }
            public string DestPhoneNumber { get; set; }
            public string ReturnCity { get; set; }
            public string ReturnDistrict { get; set; }
            public string ReturnWard { get; set; }
            public string ReturnAddress { get; set; }
            public string ReturnName { get; set; }
            public string ReturnPhoneNumber { get; set; }
            public string Note { get; set; }
        }
    }
}
