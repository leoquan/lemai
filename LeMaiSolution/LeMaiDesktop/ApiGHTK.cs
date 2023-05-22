using Common;
using LeMaiDomain;
using LeMaiDomain.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiDesktop
{
    public class ApiGHTK : IConnectApi
    {
        public OutResultGHN CancelOrder(view_GExpBillGHNApi bill)
        {
            OutResultGHN rs = new OutResultGHN();
            var client = new RestClient("https://services.giaohangtietkiem.vn/services/shipment/cancel/" + bill.BT3Code);
            var request = new RestRequest();
            request.Method = Method.POST;
            request.AddHeader("Token", bill.Token);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                JsonGHTKBaseOutput result = JsonConvert.DeserializeObject<JsonGHTKBaseOutput>(response.Content);
                if (result != null)
                {
                    if (result.success == true)
                    {
                        rs.IsSuccess = true;
                        rs.Message = "Hủy đơn hàng GHTK thành công của tài khoản: " + bill.ProviderName;
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
            var client = new RestClient("https://services.giaohangtietkiem.vn/services/shipment/order/?ver=1.5");
            var request = new RestRequest();
            request.Method = Method.POST;
            request.AddHeader("Token", bill.Token);
            request.AddHeader("Content-Type", "application/json");

            JsonGHTKCreateInput jsonObject = new JsonGHTKCreateInput();
            jsonObject.products = new List<GHTKProduct>();
            //product
            GHTKProduct product = new GHTKProduct();
            product.name = bill.GoodsName;
            product.weight = (double)(bill.BillWeight / 1000);
            product.quantity = bill.GoodsNumber;
            jsonObject.products.Add(product);
            if (bill.FK_PaymentType == "NTT")
            {
                bill.COD = bill.COD + bill.Freight;
            }
            // Order
            jsonObject.order = new GHTKOrder();
            if (bill.Pickup.GetValueOrDefault(false))
            {
                // Nhờ bên thứ 3 pickup
                jsonObject.order.pick_option = "cod"; // Lấy hàng
                jsonObject.order.id = bill.BillCode;
                jsonObject.order.pick_name = bill.SendMan;
                jsonObject.order.pick_money = (int)bill.COD;
                jsonObject.order.pick_address = bill.AddressPickup;
                jsonObject.order.pick_province = bill.ProvincePickup;
                jsonObject.order.pick_district = bill.DistricPickup;
                jsonObject.order.pick_ward = bill.WardPickup;
                jsonObject.order.pick_tel = bill.SendManPhone;
                // Địa chỉ trả hàng
                jsonObject.order.return_name = bill.SendMan;
                jsonObject.order.return_address = bill.AddressPickup;
                jsonObject.order.return_province = bill.ProvincePickup;
                jsonObject.order.return_district = bill.DistricPickup;
                jsonObject.order.return_ward = bill.WardPickup;
                jsonObject.order.return_tel = bill.SendManPhone;
                jsonObject.order.return_street = bill.Address;
                jsonObject.order.return_email = PCommon.ConvertToUnSign(bill.ShopName).Replace(" ", "").ToLower() + "@gmail.com";

            }
            else
            {
                jsonObject.order.pick_option = "post"; // Gửi hàng tại bưu cục
                // Tự mình pickup
                jsonObject.order.id = bill.BillCode;
                jsonObject.order.pick_name = bill.ShopName;
                jsonObject.order.pick_money = (int)bill.COD;
                jsonObject.order.pick_address = bill.Address;
                jsonObject.order.pick_province = bill.ProvinceName;
                jsonObject.order.pick_district = bill.DistrictName;
                jsonObject.order.pick_ward = bill.WardName;
                jsonObject.order.pick_tel = bill.ShopPhone;
                // Địa chỉ trả hàng
                jsonObject.order.return_name = bill.ShopName;
                jsonObject.order.return_address = bill.Address;
                jsonObject.order.return_province = bill.ProvinceName;
                jsonObject.order.return_district = bill.DistrictName;
                jsonObject.order.return_ward = bill.WardName;
                jsonObject.order.return_tel = bill.ShopPhone;
                jsonObject.order.return_street = bill.Address;
                jsonObject.order.return_email = PCommon.ConvertToUnSign(bill.ShopName).Replace(" ", "").ToLower() + "@gmail.com";
            }    
            // Điểm giao hàng
            jsonObject.order.name = bill.AcceptMan;
            jsonObject.order.address = bill.AcceptManAddress;
            jsonObject.order.province = bill.AcceptProvince;
            jsonObject.order.district = bill.AcceptDistrict;
            jsonObject.order.ward = bill.AcceptWard;
            jsonObject.order.street = bill.AcceptWard;
            jsonObject.order.hamlet = "Khác";
            jsonObject.order.tel = bill.AcceptManPhone;
            jsonObject.order.note = bill.Note;
            jsonObject.order.email = PCommon.ConvertToUnSign(bill.AcceptMan).Replace(" ", "").ToLower() + "@gmail.com";
            jsonObject.order.use_return_address = 0;

            jsonObject.order.transport = "road";
            if (bill.COD <= bill.InsuranceValue)
            {
                jsonObject.order.value = (int)bill.COD;
            }
            else
            {
                jsonObject.order.value = (int)bill.InsuranceValue;
            }

            jsonObject.order.is_freeship = 1;

            jsonObject.order.tags = new List<int>();
            jsonObject.order.tags.Add(1);// Hàng dễ vỡ
            jsonObject.order.tags.Add(10);// Cho xem hàng
            jsonObject.order.tags.Add(13);// Gọi shop khi không nhận hàng, có vấn đề

            string bodyjson = JsonConvert.SerializeObject(jsonObject);
            request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                JsonGHTKCreateOutput result = JsonConvert.DeserializeObject<JsonGHTKCreateOutput>(response.Content);
                if (result != null)
                {
                    if (result.success == true)
                    {
                        rs.OrderCode = result.order.label;
                        rs.BT3Freight = decimal.Parse(result.order.fee) + decimal.Parse(result.order.insurance_fee);
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
            throw new NotImplementedException();
        }

        public OutResultGHN UpdateCOD(view_GExpBillGHNApi bill)
        {
            OutResultGHN rs = new OutResultGHN();
            rs.IsSuccess = false;
            rs.Message = "Chưa hỗ trợ cập nhật COD của GHTK từ API.";
            return rs;
        }

        public OutResultGHN UpdateOrder(view_GExpBillGHNApi bill)
        {
            OutResultGHN rs = new OutResultGHN();
            rs.IsSuccess = false;
            rs.Message = "Chưa hỗ trợ cập nhật thông tin đơn hàng của GHTK từ API.";
            return rs;
        }
    }
    public class GHTKOrderTrackingOutput
    {
        public string label_id { get; set; }
        public string partner_id { get; set; }
        public string status { get; set; }
        public string status_text { get; set; }
        public string created { get; set; }
        public string modified { get; set; }
        public string message { get; set; }
        public string pick_date { get; set; }
        public string deliver_date { get; set; }
        public string customer_fullname { get; set; }
        public string customer_tel { get; set; }
        public string address { get; set; }
        public string storage_day { get; set; }
        public string ship_money { get; set; }
        public string insurance { get; set; }
        public string value { get; set; }
        public string weight { get; set; }
        public int pick_money { get; set; }
        public string is_freeship { get; set; }
    }

    public class GHTKTrackingOutput
    {
        public bool success { get; set; }
        public string message { get; set; }
        public GHTKOrderTrackingOutput order { get; set; }
    }
    public class GHTKOrderOut
    {
        public string partner_id { get; set; }
        public string label { get; set; }
        public string area { get; set; }
        public string fee { get; set; }
        public string insurance_fee { get; set; }
        public string estimated_pick_time { get; set; }
        public string estimated_deliver_time { get; set; }
        public int status_id { get; set; }
    }
    public class JsonGHTKBaseOutput
    {
        public bool success { get; set; }
        public string message { get; set; }
    }
    public class JsonGHTKCreateOutput : JsonGHTKBaseOutput
    {
        public GHTKOrderOut order { get; set; }
    }
    public class GHTKOrder
    {
        public string id { get; set; }
        public string pick_name { get; set; }
        public string pick_address { get; set; }
        public string pick_province { get; set; }
        public string pick_district { get; set; }
        public string pick_ward { get; set; }
        public string pick_tel { get; set; }

        public string return_name { get; set; }
        public string return_address { get; set; }
        public string return_province { get; set; }
        public string return_district { get; set; }
        public string return_ward { get; set; }
        public string return_tel { get; set; }
        public string return_street { get; set; }
        public string return_email { get; set; }

        public string tel { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string province { get; set; }
        public string district { get; set; }
        public string ward { get; set; }
        public string street { get; set; }
        public string hamlet { get; set; }
        public int is_freeship { get; set; }
        public string pick_date { get; set; }
        public int pick_money { get; set; }
        public string note { get; set; }
        public string email { get; set; }
        public int use_return_address { get; set; }
        public int value { get; set; }
        public string transport { get; set; }
        public string pick_option { get; set; }
        public string deliver_option { get; set; }
        public int pick_session { get; set; }
        public List<int> tags { get; set; }
    }

    public class GHTKProduct
    {
        public string name { get; set; }
        public double weight { get; set; }
        public int quantity { get; set; }
        public int product_code { get; set; }
    }

    public class JsonGHTKCreateInput
    {
        public List<GHTKProduct> products { get; set; }
        public GHTKOrder order { get; set; }
    }
}
