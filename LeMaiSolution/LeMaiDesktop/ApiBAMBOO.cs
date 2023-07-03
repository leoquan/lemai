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
    public class ApiBAMBOO : IConnectApi
    {
        //https://{partner-code}-gateway.bambooship.vn
        private const string url = "https://{parter-code}-gateway.bambooship.vn";
        private string GetToken(string clientId, string clientSecrect, string Token, string IdProvider, DateTime? expires)
        {
            string token = Token;
            if (expires.HasValue == false || expires <= DateTime.Now)
            {
                var client = new RestClient(url + "/api/login");
                var request = new RestRequest(Method.POST);
                string bodyjson = JsonConvert.SerializeObject(new { email = clientId, password = clientSecrect });
                request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var response = client.Execute(request);
                try
                {
                    BambooToken result = JsonConvert.DeserializeObject<BambooToken>(response.Content);
                    if (result != null)
                    {
                        // Xử lý update Provider
                        ApiConnectUlti.UpdateToken(IdProvider, result.access_token, DateTime.Now.AddMinutes(60));
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
        public OutResultGHN CancelOrder(view_GExpBillGHNApi bill)
        {
            throw new NotImplementedException();
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
            string token = GetToken(bill.UserApi, bill.PassApi, bill.Token, bill.FK_ProviderAccount, bill.ExpiresDate);
            if (token.Contains("[E]"))
            {
                rs.IsSuccess = false;
                rs.Message = token;
                return rs;
            }
            var client = new RestClient(url + "/api/packages/");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + token);
            request.AddHeader("Content-Type", "application/json");
            JsonBambooCreateOrderInput jsonObject = new JsonBambooCreateOrderInput();
            jsonObject.code = bill.BillCode;

            if (bill.IsPickup)
            {

            }

            var bodyjson = JsonConvert.SerializeObject(jsonObject);
            request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                JsonBambooCreateOrderOutput result = JsonConvert.DeserializeObject<JsonBambooCreateOrderOutput>(response.Content);
                if (result != null && string.IsNullOrEmpty(result.tracking_number) == false)
                {
                    rs.IsSuccess = true;
                    rs.OrderCode = result.tracking_number;
                    rs.Message = "Nạp đơn thành công";
                }
                else
                {
                    JsonBambooErrorOutput error = JsonConvert.DeserializeObject<JsonBambooErrorOutput>(response.Content);
                    if (error != null)
                    {
                        rs.IsSuccess = false;
                        rs.Message = error.error.cod;
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
            throw new NotImplementedException();
        }

        public OutResultGHN UpdateCOD(view_GExpBillGHNApi bill)
        {
            throw new NotImplementedException();
        }

        public OutResultGHN UpdateOrder(view_GExpBillGHNApi bill)
        {
            throw new NotImplementedException();
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
        }
        public class JsonBambooCreateOrderOutput
        {
            public string package_code { get; set; }
            public string tracking_number { get; set; }
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
    }
}
