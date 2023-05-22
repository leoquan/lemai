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
    public class ApiViettel : IConnectApi
    {
        private const string url = "https://partner.viettelpost.vn";//Product
        private string GetToken(string UserName, string PassWord, string Token, string IdProvider, DateTime? expires)
        {
            string token = Token;
            if (expires.HasValue == false || expires <= DateTime.Now)
            {
                var client = new RestClient(url + "/v2/user/Login");
                var request = new RestRequest(Method.POST);
                string bodyjson = JsonConvert.SerializeObject(new { USERNAME = UserName, PASSWORD = PassWord });
                request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var response = client.Execute(request);
                try
                {
                    ViettelTokenOutput result = JsonConvert.DeserializeObject<ViettelTokenOutput>(response.Content);
                    if (result != null)
                    {
                        // Xử lý update Provider
                        DateTime expiresDate = epoch2DateTime(result.data.expired).AddHours(7);
                        ApiConnectUlti.UpdateToken(IdProvider, result.data.token, expiresDate.AddMinutes(-10));
                        return result.data.token;
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
        private string GetService(string token, view_GExpBillGHNApi bill)
        {
            var client = new RestClient(url + "/v2/order/getPriceAll");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Token", token);
            request.AddHeader("Content-Type", "application/json");

            ViettelCheckPriceInput jsonObject = new ViettelCheckPriceInput();
            jsonObject.PRODUCT_TYPE = "HH";
            jsonObject.PRODUCT_WEIGHT = (int)bill.BillWeight;
            jsonObject.PRODUCT_PRICE = 0;
            jsonObject.MONEY_COLLECTION = ((int)bill.COD).ToString();
            jsonObject.TYPE = 1;
            jsonObject.SENDER_DISTRICT = Int32.Parse(bill.DistrictCode);
            jsonObject.SENDER_PROVINCE = Int32.Parse(bill.ProvinceCode);
            jsonObject.RECEIVER_PROVINCE = Int32.Parse(bill.AcceptProvinceCodeS);
            jsonObject.RECEIVER_DISTRICT = Int32.Parse(bill.AcceptDistrictCodeS);

            var bodyjson = JsonConvert.SerializeObject(jsonObject);
            request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                List<ViettelCheckPriceOutput> result = JsonConvert.DeserializeObject<List<ViettelCheckPriceOutput>>(response.Content);
                if (result != null)
                {
                    if (result.Count > 0)
                    {
                        return result.OrderBy(u => u.GIA_CUOC).ToList()[0].MA_DV_CHINH;
                    }
                    return string.Empty;
                }
                else
                {
                    return string.Empty;
                }
            }
            catch
            {
                return string.Empty;
            }
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
            var client = new RestClient(url + "/v2/order/UpdateOrder");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Token", token);
            request.AddHeader("Content-Type", "application/json");
            ViettelCancelOrderInput jsonObject = new ViettelCancelOrderInput();
            jsonObject.TYPE = 4;
            jsonObject.ORDER_NUMBER = bill.BT3Code;
            jsonObject.NOTE = "Hủy đơn hàng";
            var bodyjson = JsonConvert.SerializeObject(jsonObject);
            request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                ViettelCancelOrderOutput result = JsonConvert.DeserializeObject<ViettelCancelOrderOutput>(response.Content);
                if (result != null && result.error == false)
                {
                    rs.IsSuccess = true;
                    rs.Message = "Hủy đơn hàng thành công";
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
            string token = GetToken(bill.ClientId, bill.ClientSecrect, bill.Token, bill.FK_ProviderAccount, bill.ExpiresDate);
            if (token.Contains("[E]"))
            {
                rs.IsSuccess = false;
                rs.Message = token;
                return rs;
            }
            string madichvu = GetService(token, bill);
            if (string.IsNullOrEmpty(madichvu))
            {
                rs.IsSuccess = false;
                rs.Message = "Dịch vụ không tồn tại trong khu vực!";
                return rs;
            }
            var client = new RestClient(url + "/v2/order/createOrder");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Token", token);
            request.AddHeader("Content-Type", "application/json");
            ViettelCreateOrderInput jsonObject = new ViettelCreateOrderInput();
            jsonObject.CHECK_UNIQUE = true;
            // Người gửi
            jsonObject.ORDER_NUMBER = bill.BillCode;
            jsonObject.SENDER_FULLNAME = bill.SendMan;
            jsonObject.SENDER_PHONE = bill.SendManPhone;
            jsonObject.SENDER_ADDRESS = bill.SendManAddress;
            jsonObject.SENDER_PROVINCE = Int32.Parse(bill.ProvinceCode);
            jsonObject.SENDER_DISTRICT = Int32.Parse(bill.DistrictCode);
            jsonObject.SENDER_WARD = Int32.Parse(bill.WardCode);
            // Người nhận
            jsonObject.RECEIVER_FULLNAME = bill.AcceptMan;
            jsonObject.RECEIVER_PHONE = bill.AcceptManPhone;
            jsonObject.RECEIVER_ADDRESS = bill.AcceptManAddress;
            jsonObject.RECEIVER_PROVINCE = Int32.Parse(bill.AcceptProvinceCodeS);
            jsonObject.RECEIVER_DISTRICT = Int32.Parse(bill.AcceptDistrictCodeS);
            jsonObject.RECEIVER_WARD = Int32.Parse(bill.AcceptWardCodeS);

            jsonObject.PRODUCT_NAME = bill.GoodsName;
            jsonObject.PRODUCT_DESCRIPTION = bill.GoodsName;
            jsonObject.PRODUCT_QUANTITY = bill.GoodsNumber;
            jsonObject.PRODUCT_TYPE = "HH";
            jsonObject.PRODUCT_HEIGHT = bill.GoodsH;
            jsonObject.PRODUCT_LENGTH = bill.GoodsL;
            jsonObject.PRODUCT_WIDTH = bill.GoodsW;

            jsonObject.ORDER_SERVICE = madichvu;
            jsonObject.ORDER_SERVICE_ADD = ""; // Dịch vụ tăng thêm

            int productPrice = (int)bill.COD;
            jsonObject.MONEY_COLLECTION = (int)bill.COD;
            if (bill.FK_PaymentType == "NTT")
            {
                jsonObject.MONEY_COLLECTION = jsonObject.MONEY_COLLECTION + (int)bill.Freight;
            }
            if (jsonObject.MONEY_COLLECTION == 0)
            {
                jsonObject.ORDER_PAYMENT = 1;
            }
            else
            {
                jsonObject.ORDER_PAYMENT = 3;
            }
            //1. Không thu hộ  2.Thu hộ tiền hàng và tiền cước   3.Thu hộ tiền hàng  4.Thu hộ tiền cước

            if (productPrice > bill.InsuranceValue)
            {
                jsonObject.PRODUCT_PRICE = bill.InsuranceValue;
            }
            else
            {
                jsonObject.PRODUCT_PRICE = productPrice;

            }
            jsonObject.PRODUCT_WEIGHT = (int)bill.BillWeight;

            jsonObject.ORDER_NOTE = "(" + bill.ShipNoteType + ") " + bill.Note;

            jsonObject.LIST_ITEM = new List<ViettelItem>();
            ViettelItem item = new ViettelItem();
            item.PRODUCT_NAME = bill.GoodsName;
            item.PRODUCT_QUANTITY = bill.GoodsNumber;
            item.PRODUCT_WEIGHT = (int)bill.BillWeight;

            if (productPrice > bill.InsuranceValue)
            {
                item.PRODUCT_PRICE = bill.InsuranceValue;
            }
            else
            {
                item.PRODUCT_PRICE = productPrice;

            }

            jsonObject.LIST_ITEM.Add(item);

            jsonObject.GROUPADDRESS_ID = 0;

            var bodyjson = JsonConvert.SerializeObject(jsonObject);
            request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                ViettelCreateOrderOutput result = JsonConvert.DeserializeObject<ViettelCreateOrderOutput>(response.Content);
                if (result != null)
                {
                    if (result.error == false)
                    {
                        rs.IsSuccess = true;
                        rs.OrderCode = result.data.ORDER_NUMBER;
                        rs.BT3Freight = result.data.MONEY_TOTAL;
                        rs.Message = "Nạp đơn thành công";
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

        public OutTrackingResultGHN Tracking(view_GExpBillGHNApi bill)
        {
            OutTrackingResultGHN rs = new OutTrackingResultGHN();
            rs.IsSuccess = false;
            rs.Message = "API nhận trạng thái đơn hàng từ webhook";
            return rs;
        }

        public OutResultGHN UpdateCOD(view_GExpBillGHNApi bill)
        {
            return updateOrder(bill);
        }

        public OutResultGHN UpdateOrder(view_GExpBillGHNApi bill)
        {
            return updateOrder(bill);
        }
        OutResultGHN updateOrder(view_GExpBillGHNApi bill)
        {
            OutResultGHN rs = new OutResultGHN();
            string token = GetToken(bill.ClientId, bill.ClientSecrect, bill.Token, bill.FK_ProviderAccount, bill.ExpiresDate);
            if (token.Contains("[E]"))
            {
                rs.IsSuccess = false;
                rs.Message = token;
                return rs;
            }
            string madichvu = GetService(token, bill);
            if (string.IsNullOrEmpty(madichvu))
            {
                rs.IsSuccess = false;
                rs.Message = "Dịch vụ không tồn tại trong khu vực!";
                return rs;
            }
            var client = new RestClient(url + "/v2/order/edit");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Token", token);
            request.AddHeader("Content-Type", "application/json");

            return rs;
        }
        private DateTime epoch2DateTime(long epoch)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(epoch);
        }
    }

    public class ViettelTokenDataOutput
    {
        public int userId { get; set; }
        public string token { get; set; }
        public int partner { get; set; }
        public string phone { get; set; }
        public object postcode { get; set; }
        public long expired { get; set; }
        public object encrypted { get; set; }
        public int source { get; set; }
        public bool infoUpdated { get; set; }
    }

    public class ViettelTokenOutput
    {
        public int status { get; set; }
        public bool error { get; set; }
        public string message { get; set; }
        public ViettelTokenDataOutput data { get; set; }
    }

    public class ViettelItem
    {
        public string PRODUCT_NAME { get; set; }
        public int PRODUCT_PRICE { get; set; }
        public int PRODUCT_WEIGHT { get; set; }
        public int PRODUCT_QUANTITY { get; set; }
    }

    public class ViettelCreateOrderInput
    {
        public string ORDER_NUMBER { get; set; }
        public int GROUPADDRESS_ID { get; set; }
        public int CUS_ID { get; set; }
        public string DELIVERY_DATE { get; set; }
        public string SENDER_FULLNAME { get; set; }
        public string SENDER_ADDRESS { get; set; }
        public string SENDER_PHONE { get; set; }
        public string SENDER_EMAIL { get; set; }
        public int SENDER_WARD { get; set; }
        public int SENDER_DISTRICT { get; set; }
        public int SENDER_PROVINCE { get; set; }
        public int SENDER_LATITUDE { get; set; }
        public int SENDER_LONGITUDE { get; set; }
        public string RECEIVER_FULLNAME { get; set; }
        public string RECEIVER_ADDRESS { get; set; }
        public string RECEIVER_PHONE { get; set; }
        public string RECEIVER_EMAIL { get; set; }
        public int RECEIVER_WARD { get; set; }
        public int RECEIVER_DISTRICT { get; set; }
        public int RECEIVER_PROVINCE { get; set; }
        public int RECEIVER_LATITUDE { get; set; }
        public int RECEIVER_LONGITUDE { get; set; }
        public string PRODUCT_NAME { get; set; }
        public string PRODUCT_DESCRIPTION { get; set; }
        public int PRODUCT_QUANTITY { get; set; }
        public int PRODUCT_PRICE { get; set; }
        public int PRODUCT_WEIGHT { get; set; }
        public int PRODUCT_LENGTH { get; set; }
        public int PRODUCT_WIDTH { get; set; }
        public int PRODUCT_HEIGHT { get; set; }
        public string PRODUCT_TYPE { get; set; }
        public int ORDER_PAYMENT { get; set; }
        public string ORDER_SERVICE { get; set; }
        public string ORDER_SERVICE_ADD { get; set; }
        public string ORDER_VOUCHER { get; set; }
        public string ORDER_NOTE { get; set; }
        public int MONEY_COLLECTION { get; set; }
        public int MONEY_TOTALFEE { get; set; }
        public int MONEY_FEECOD { get; set; }
        public int MONEY_FEEVAS { get; set; }
        public int MONEY_FEEINSURRANCE { get; set; }
        public int MONEY_FEE { get; set; }
        public int MONEY_FEEOTHER { get; set; }
        public int MONEY_TOTALVAT { get; set; }
        public int MONEY_TOTAL { get; set; }
        public bool CHECK_UNIQUE { get; set; }
        public List<ViettelItem> LIST_ITEM { get; set; }
    }

    public class ViettelOrderData
    {
        public string ORDER_NUMBER { get; set; }
        public int MONEY_COLLECTION { get; set; }
        public int EXCHANGE_WEIGHT { get; set; }
        public int MONEY_TOTAL { get; set; }
        public int MONEY_TOTAL_FEE { get; set; }
        public int MONEY_FEE { get; set; }
        public int MONEY_COLLECTION_FEE { get; set; }
        public int MONEY_OTHER_FEE { get; set; }
        public int MONEY_VAS { get; set; }
        public int MONEY_VAT { get; set; }
        public double KPI_HT { get; set; }
        public int RECEIVER_PROVINCE { get; set; }
        public int RECEIVER_DISTRICT { get; set; }
        public int RECEIVER_WARDS { get; set; }
    }

    public class ViettelCreateOrderOutput
    {
        public int status { get; set; }
        public bool error { get; set; }
        public string message { get; set; }
        public ViettelOrderData data { get; set; }
    }

    public class ViettelEXTRASERVICE
    {
        public string SERVICE_CODE { get; set; }
        public string SERVICE_NAME { get; set; }
        public string DESCRIPTION { get; set; }
    }

    public class ViettelCheckPriceOutput
    {
        public string MA_DV_CHINH { get; set; }
        public string TEN_DICHVU { get; set; }
        public int GIA_CUOC { get; set; }
        public string THOI_GIAN { get; set; }
        public int EXCHANGE_WEIGHT { get; set; }
        public List<ViettelEXTRASERVICE> EXTRA_SERVICE { get; set; }
    }
    public class ViettelCheckPriceInput
    {
        public int SENDER_DISTRICT { get; set; }
        public int SENDER_PROVINCE { get; set; }
        public int RECEIVER_DISTRICT { get; set; }
        public int RECEIVER_PROVINCE { get; set; }
        public string PRODUCT_TYPE { get; set; }
        public int PRODUCT_WEIGHT { get; set; }
        public int PRODUCT_PRICE { get; set; }
        public string MONEY_COLLECTION { get; set; }
        public int TYPE { get; set; }
    }

    public class ViettelCancelOrderInput
    {
        public int TYPE { get; set; }
        public string ORDER_NUMBER { get; set; }
        public string NOTE { get; set; }
    }
    public class ViettelCancelOrderOutput
    {
        public int status { get; set; }
        public bool error { get; set; }
        public string message { get; set; }
    }

}
