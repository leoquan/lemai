using LeMaiDomain;
using LeMaiDomain.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiDesktop
{
    public class ApiBAMBOO : IConnectApi
    {
        //https://{partner-code}-gateway.bambooship.vn
        private const string url = "https://stg-{partner-code}-gateway.bambooship.vn";

        public OutResultGHN CancelOrder(view_GExpBillGHNApi bill)
        {
            OutResultGHN rs = new OutResultGHN();
            var client = new RestClient(url.Replace("{partner-code}", bill.ShopId) + "/api/packages-cancel/" + bill.BT3Code);
            var request = new RestRequest();
            request.Method = Method.PATCH;
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", "Bearer " + bill.Token);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                JsonBambooCancelOrderOutput result = JsonConvert.DeserializeObject<JsonBambooCancelOrderOutput>(response.Content);
                if (result != null)
                {
                    if (result.success == true)
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

        public OutResultGHN CreateOrder(view_GExpBillGHNApi bill)
        {
            OutResultGHN rs = new OutResultGHN();
            if (bill.Freight < 0)
            {
                rs.IsSuccess = false;
                rs.Message = "Phí vận chuyển không đúng!";
                return rs;
            }
            var client = new RestClient(url.Replace("{partner-code}", bill.ShopId) + "/api/packages/");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + bill.Token);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            JsonBambooCreateOrderInput jsonObject = new JsonBambooCreateOrderInput();
            jsonObject.code = "BBS" + bill.BillCode;
            int COD = (int)bill.COD;
            if (bill.FK_PaymentType == "NTT")
            {
                COD = (int)bill.COD + (int)bill.Freight;
            }
            jsonObject.cod = COD;
            jsonObject.weight = (int)bill.BillWeight;
            jsonObject.size_h = bill.GoodsH;
            jsonObject.size_l = bill.GoodsL;
            jsonObject.size_w = bill.GoodsW;
            jsonObject.product = bill.GoodsName;
            jsonObject.insurance_fee = 0;

            if (COD > bill.InsuranceValue || COD == 0)
            {
                jsonObject.product_value = bill.InsuranceValue;
                jsonObject.is_insurance_fee = true;
            }
            else
            {
                jsonObject.product_value = COD;
                jsonObject.is_insurance_fee = true;
            }

            jsonObject.sender_port_code = bill.WardCode;
            jsonObject.sender_address = bill.Address;
            jsonObject.receiver_address = bill.AcceptManAddress;
            jsonObject.receiver_name = bill.AcceptMan;
            jsonObject.receiver_port_code = bill.AcceptWardCodeS;
            jsonObject.receiver_phone = bill.AcceptManPhone;
            jsonObject.quantity = 1;
            jsonObject.notes = "(" + bill.ShipNoteType + ") " + bill.Note;


            var bodyjson = JsonConvert.SerializeObject(jsonObject);
            request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                JsonBambooCreateOrderOutput result = JsonConvert.DeserializeObject<JsonBambooCreateOrderOutput>(response.Content);
                if (result != null && string.IsNullOrEmpty(result.tracking_code) == false)
                {
                    rs.IsSuccess = true;
                    rs.OrderCode = result.tracking_code;
                    rs.Message = "Nạp đơn thành công";
                }
                else
                {
                    JsonBambooErrorOutput error = JsonConvert.DeserializeObject<JsonBambooErrorOutput>(response.Content);
                    if (error != null)
                    {
                        rs.IsSuccess = false;
                        rs.Message = error.message;
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
            var client = new RestClient(url.Replace("{partner-code}", bill.ShopId) + "/api/packages/" + bill.BT3Code + "/history");
            var request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Content-Type", "application/json");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                JsonBambooTrackingOutput result = JsonConvert.DeserializeObject<JsonBambooTrackingOutput>(response.Content);
                if (result != null)
                {
                    rs.IsSuccess = true;
                    rs.Message = result.status;
                    string nearstatus = string.Empty;
                    foreach (var item in result.audits)
                    {
                        OutTrackingLogGHN log = new OutTrackingLogGHN();
                        DateTime tempDate = item.updated_at.AddHours(7);
                        log.ActionDateTime = new DateTime(tempDate.Year, tempDate.Month, tempDate.Day, tempDate.Hour, tempDate.Minute, 0, 0);
                        log.ActionDate = log.ActionDateTime.ToString();
                        log.StatusCode = item.status;
                        log.Note = "[" + item.status + "] " + GetErrorDesc(log.StatusCode);
                        log.ProviderName = "BAMBOO";
                        rs.outTrackingLogs.Add(log);
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
            rs.IsSuccess = false;
            rs.Message = "Đăng nhập tài khoản bên thứ 3 để sửa COD";
            return rs;
        }

        public OutResultGHN UpdateOrder(view_GExpBillGHNApi bill)
        {
            OutResultGHN rs = new OutResultGHN();
            rs.IsSuccess = false;
            rs.Message = "Đăng nhập tài khoản bên thứ 3 để sửa thông tin đơn hàng";
            return rs;
        }
        private string GetErrorDesc(string code)
        {
            string result = code;

            string path = AppDomain.CurrentDomain.BaseDirectory + "apidata/bamboo.json";
            if (File.Exists(path))
            {
                using (StreamReader st = new StreamReader(path))
                {
                    string json = st.ReadToEnd();
                    List<BambooStatusJson> lsError = JsonConvert.DeserializeObject<List<BambooStatusJson>>(json);
                    BambooStatusJson err = lsError.FirstOrDefault(u => u.code == code);
                    if (err != null)
                    {
                        return err.name;
                    }

                }
            }
            return result;
        }
        public class BambooStatusJson
        {
            public string code { get; set; }
            public string name { get; set; }
        }
        public class BambooToken
        {
            public bool success { get; set; }
            public string access_token { get; set; }
        }
        public class BambooError
        {
            public string cod { get; set; }
            public string weight { get; set; }
            public string size_l { get; set; }
            public string size_h { get; set; }
            public string size_w { get; set; }
            public string receiver_name { get; set; }
            public string receiver_phone { get; set; }
            public string receiver_address { get; set; }
            public string sender_name { get; set; }
            public string sender_phone { get; set; }
            public string sender_email { get; set; }
            public string sender_address { get; set; }
            public string product { get; set; }
            public string notes { get; set; }
        }

        public class JsonBambooErrorOutput
        {
            public BambooError error { get; set; }
            public string message { get; set; }
        }
        public class JsonBambooCreateOrderOutput
        {
            public string package_code { get; set; }
            public string tracking_code { get; set; }
            public int cod { get; set; }
            public int weight { get; set; }
            public string size_l { get; set; }
            public string size_h { get; set; }
            public string size_w { get; set; }
            public string product { get; set; }
            public int product_value { get; set; }
            public int insurance_fee { get; set; }
            public bool is_insurance_fee { get; set; }
            public string receiver_name { get; set; }
            public string receiver_phone { get; set; }
            public string receiver_address { get; set; }
            public string receiver_port_code { get; set; }
            public string receiver_address_level_1 { get; set; }
            public string receiver_address_level_2 { get; set; }
            public string receiver_address_level_3 { get; set; }
            public string sender_phone { get; set; }
            public string sender_email { get; set; }
            public string sender_name { get; set; }
            public string sender_address { get; set; }
            public string sender_port_code { get; set; }
            public string sender_address_level_1 { get; set; }
            public string sender_address_level_2 { get; set; }
            public string sender_address_level_3 { get; set; }
            public string status { get; set; }
            public string notes { get; set; }
        }
        public class JsonBambooCreateOrderInput
        {
            public string code { get; set; }
            public int cod { get; set; }
            public int weight { get; set; }
            public int size_l { get; set; }
            public int size_h { get; set; }
            public int size_w { get; set; }
            public string product { get; set; }
            public int product_value { get; set; }
            public int insurance_fee { get; set; }
            public bool is_insurance_fee { get; set; }
            public string receiver_name { get; set; }
            public string receiver_phone { get; set; }
            public string receiver_address { get; set; }
            public string receiver_port_code { get; set; }
            public string sender_address { get; set; }
            public string sender_port_code { get; set; }
            public string notes { get; set; }
            public int quantity { get; set; }
        }

        public class JsonBambooCancelOrderOutput
        {
            public bool success { get; set; }
            public string message { get; set; }
        }

        public class BambooAudit
        {
            public string status { get; set; }
            public DateTime updated_at { get; set; }
            public string current_hub { get; set; }
            public string courier { get; set; }
        }

        public class JsonBambooTrackingOutput
        {
            public string receiver_name { get; set; }
            public string receiver_phone { get; set; }
            public string receiver_address { get; set; }
            public string receiver_address_level_1 { get; set; }
            public string receiver_address_level_2 { get; set; }
            public string receiver_address_level_3 { get; set; }
            public string sender_address_level_1 { get; set; }
            public string sender_name { get; set; }
            public string sender_phone { get; set; }
            public string sender_address { get; set; }
            public string sender_address_level_2 { get; set; }
            public string sender_address_level_3 { get; set; }
            public string status { get; set; }
            public int cod { get; set; }
            public List<BambooAudit> audits { get; set; }
        }

    }
}
