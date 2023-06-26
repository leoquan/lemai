using Common;
using LeMaiDomain;
using LeMaiDomain.Models;
using log4net.Util;
using Newtonsoft.Json;
using Org.BouncyCastle.Bcpg.OpenPgp;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiDesktop
{
    public class ApiJNT : IConnectApi
    {
        //private const string url = "??"; // Product
        //private const string url = "https://test.jtexpress.vn/yuenan-interface-web"; // Sanbox - Test
        private const string url = "http://sellapp.jtexpress.vn:22220/yuenan-interface-web"; // Sanbox - Test
        public OutResultGHN CancelOrder(view_GExpBillGHNApi bill)
        {
            OutResultGHN rs = new OutResultGHN();
            var client = new RestClient(url + "/order/orderAction!createOrder.action");
            var request = new RestRequest();
            request.Method = Method.POST;
            request.AlwaysMultipartFormData = true;
            JsonJNTCancelOrderInput jsonObject = new JsonJNTCancelOrderInput();

            jsonObject.eccompanyid = bill.Token;
            jsonObject.customerid = bill.ShopId;
            jsonObject.logisticproviderid = "JNT";
            jsonObject.txlogisticid = bill.BillCode;
            jsonObject.fieldlist = new List<JNTFieldlist>();
            JNTFieldlist field = new JNTFieldlist();
            field.txlogisticid = bill.BillCode;
            field.fieldname = "status";
            field.fieldvalue = "WITHDRAW";
            field.remark = "Cancel Order";
            jsonObject.fieldlist.Add(field);

            string bodyjson = JsonConvert.SerializeObject(jsonObject);
            request.AddParameter("logistics_interface", bodyjson);
            string stringToEncode = bodyjson + bill.ClientSecrect;
            string md5Encode = Security.GetBase64Md5(stringToEncode);
            request.AddParameter("data_digest", md5Encode);
            request.AddParameter("msg_type", "UPDATE");
            request.AddParameter("eccompanyid", bill.Token);

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                JsonJNTCancelOrderOutput result = JsonConvert.DeserializeObject<JsonJNTCancelOrderOutput>(response.Content);
                if (result != null)
                {
                    if (result.responseitems.Count > 0)
                    {
                        if (result.responseitems[0].success == "true")
                        {
                            rs.IsSuccess = true;
                            rs.Message = "Hủy đơn hàng bên hệ thống của J&T thành công. Tài khoản: " + bill.ProviderName;
                        }
                        else
                        {
                            rs.IsSuccess = false;
                            rs.Message = result.responseitems[0].reason;
                        }
                    }
                    else
                    {
                        rs.IsSuccess = false;
                        rs.Message = "Lỗi API, không thể hủy đơn hàng bên hệ thống của J&T";
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
            if (bill.Freight < 100)
            {
                rs.IsSuccess = false;
                rs.Message = "Phí vận chuyển không đúng!";
                return rs;
            }
            //
            var client = new RestClient(url + "/order/orderAction!createOrder.action");
            var request = new RestRequest();
            request.Method = Method.POST;
            request.AlwaysMultipartFormData = true;

            JsonJNTCreateOrderInput jsonObject = new JsonJNTCreateOrderInput();
            // Gen json
            jsonObject.eccompanyid = bill.Token; // Mặc định CUSMODEL
            jsonObject.customerid = bill.ShopId;

            jsonObject.txlogisticid = bill.BillCode; // Mã đơn hàng

            jsonObject.ordertype = 1; //Mặc định là 1 (nếu có phí COD: itemsvalue ) 
            //Sender
            jsonObject.sender = new JNTSender();

            if (bill.Pickup.GetValueOrDefault(false))
            {
                jsonObject.servicetype = 1;// Lấy hàng
                jsonObject.sender.name = bill.SendMan;
                jsonObject.sender.phone = bill.SendManPhone;
                jsonObject.sender.mobile = bill.SendManPhone;
                jsonObject.sender.prov = bill.ProvincePickup;
                jsonObject.sender.city = bill.DistricPickup;
                jsonObject.sender.area = bill.DistrictName;
                jsonObject.sender.address = bill.AddressPickup;

            }
            else
            {
                jsonObject.servicetype = 6;// Tự mang hàng đến
                jsonObject.sender.name = bill.ShopName;
                jsonObject.sender.phone = bill.ShopPhone;
                jsonObject.sender.mobile = bill.ShopPhone;
                jsonObject.sender.prov = bill.ProvinceName;
                jsonObject.sender.city = bill.DistrictName;
                jsonObject.sender.area = bill.WardName;
                jsonObject.sender.address = bill.SendManAddress;
            }


            jsonObject.selfAddress = 0; //  0: Địa chỉ trong table JNT, 1: Địa chỉ trong table VN
            jsonObject.partsign = "0";
            jsonObject.special = bill.ServiceId; // Dịch vụ Express, Fast, SUPER

            //Receiver
            jsonObject.receiver = new JNTReceiver();
            jsonObject.receiver.name = bill.AcceptMan;
            jsonObject.receiver.phone = bill.AcceptManPhone;
            jsonObject.receiver.mobile = bill.AcceptManPhone;
            jsonObject.receiver.prov = bill.AcceptProvince;
            jsonObject.receiver.city = bill.AcceptDistrict;
            jsonObject.receiver.area = bill.AcceptWard;
            jsonObject.receiver.address = bill.AcceptManAddress;

            //Item
            jsonObject.createordertime = string.Format("{0:yyyy-MM-dd HH:mm:ss}", bill.RegisterDate);
            jsonObject.sendstarttime = string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
            jsonObject.sendendtime = string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now.AddDays(1));

            jsonObject.paytype = "PP_PM";

            if (bill.FK_PaymentType == "NTT")
            {
                // Nhận thanh toán
                bill.COD = bill.COD + bill.Freight;
            }

            jsonObject.itemsvalue = (bill.COD).ToString();

            if (bill.COD > bill.InsuranceValue || bill.COD == 0)
            {
                jsonObject.goodsvalue = bill.InsuranceValue.ToString();// Sử dụng bảo hiểm miễn phí tối đa. Nếu đơn hàng 0 đồng/COD>Max bảo hiểm. thì bảo hiểm = max bảo hiểm.
            }
            else
            {
                jsonObject.goodsvalue = bill.COD.ToString();// Bảo hiểm = COD
            }

            jsonObject.isInsured = "1";

            jsonObject.weight = (bill.BillWeight / 1000).ToString();
            jsonObject.volume = (bill.BillWeight / 1000).ToString();

            jsonObject.remark = "(" + bill.ShipNoteType + ") " + bill.Note;
            // Items
            jsonObject.items = new List<JNTItem>();
            JNTItem item = new JNTItem();
            item.itemname = bill.GoodsName;
            item.englishName = PCommon.ConvertToUnSign(bill.GoodsName);
            item.number = "1";
            item.itemvalue = bill.COD.ToString();
            item.desc = bill.GoodsName;
            jsonObject.items.Add(item);

            string bodyjson = JsonConvert.SerializeObject(jsonObject);
            request.AddParameter("logistics_interface", bodyjson);
            string stringToEncode = bodyjson + bill.ClientSecrect;
            string md5Encode = Security.GetBase64Md5(stringToEncode);
            request.AddParameter("data_digest", md5Encode);
            request.AddParameter("msg_type", "ORDERCREATE");
            request.AddParameter("eccompanyid", bill.Token);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                JSonJNTCreateOderOutput result = JsonConvert.DeserializeObject<JSonJNTCreateOderOutput>(response.Content);
                if (result != null)
                {
                    if (result.responseitems.Count > 0)
                    {
                        if (result.responseitems[0].success == "true")
                        {
                            // Thành công
                            rs.OrderCode = result.responseitems[0].billcode;
                            int totalFee = 0;
                            try
                            {
                                int codFee = Int32.Parse(result.responseitems[0].codFee);
                                int inquiryFee = Int32.Parse(result.responseitems[0].inquiryFee);
                                int insurancefee = Int32.Parse(result.responseitems[0].insurancefee);
                                totalFee = codFee + inquiryFee + insurancefee;
                            }
                            catch
                            {
                            }
                            rs.PrintData = result.responseitems[0].code + ";" + result.responseitems[0].dispatchSite + ";" + result.responseitems[0].transport;
                            rs.BT3Freight = totalFee;
                            rs.IsSuccess = true;
                        }
                        else
                        {
                            rs.IsSuccess = false;
                            rs.Message = GetErrorDesc(result.responseitems[0].reason);
                        }
                    }
                    else
                    {
                        rs.IsSuccess = false;
                        rs.Message = "Lỗi kết nối!";
                    }
                }
                else
                {
                    // Thất bại
                    JSonJNTErrorOutput error = JsonConvert.DeserializeObject<JSonJNTErrorOutput>(response.Content);
                    rs.Message = error.desc;
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
            var client = new RestClient(url + "/standart/trackAction!trackForJson.action");
            var request = new RestRequest();
            request.Method = Method.POST;
            request.AlwaysMultipartFormData = true;

            JsonJNTTrackingInput jsonObject = new JsonJNTTrackingInput();

            jsonObject.billcode = bill.BT3Code;
            jsonObject.lang = "vn";

            string bodyjson = JsonConvert.SerializeObject(jsonObject);
            request.AddParameter("logistics_interface", bodyjson);
            string stringToEncode = bodyjson + bill.ClientSecrect;
            string md5Encode = Security.GetBase64Md5(stringToEncode);
            request.AddParameter("data_digest", md5Encode);
            request.AddParameter("msg_type", "TRACKQUERY");
            request.AddParameter("eccompanyid", bill.Token);

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                JsonJNTTrackingOutput result = JsonConvert.DeserializeObject<JsonJNTTrackingOutput>(response.Content);
                if (result != null)
                {
                    if (result.responseitems.Count > 0)
                    {
                        if (result.responseitems[0].success == "true")
                        {
                            rs.IsSuccess = true;
                            rs.Message = "Kiểm tra hành trình đơn hàng bên hệ thống của J&T thành công.";
                            if (result.responseitems[0].tracesList.Count > 0)
                            {
                                foreach (var item in result.responseitems[0].tracesList[0].details)
                                {
                                    OutTrackingLogGHN log = new OutTrackingLogGHN();
                                    DateTime tempDate = DateTime.ParseExact(item.scantime, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                                    log.ActionDateTime = new DateTime(tempDate.Year, tempDate.Month, tempDate.Day, tempDate.Hour, tempDate.Minute, 0, 0);
                                    log.ActionDate = log.ActionDateTime.ToString();
                                    log.StatusCode = "J." + PCommon.ConvertToUnSign(item.scantype).Replace(" ", "");
                                    log.Note = item.desc;
                                    log.ProviderName = "JNT";
                                    rs.outTrackingLogs.Add(log);
                                }
                            }
                        }
                        else
                        {
                            rs.IsSuccess = false;
                            rs.Message = result.responseitems[0].reason;
                        }
                    }
                    else
                    {
                        rs.IsSuccess = false;
                        rs.Message = "Lỗi API, không thể kiểm tra hành trình đơn hàng bên hệ thống của J&T";
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
            rs.Message = "Chưa hỗ trợ cập nhật COD của J&T từ API.";
            return rs;
        }

        public OutResultGHN UpdateOrder(view_GExpBillGHNApi bill)
        {
            OutResultGHN rs = new OutResultGHN();
            rs.IsSuccess = false;
            rs.Message = "Chưa hỗ trợ cập nhật thông tin đơn hàng J&T từ API.";
            return rs;
        }

        private string GetErrorDesc(string code)
        {
            string result = code;

            string path = AppDomain.CurrentDomain.BaseDirectory + "apidata/jntError.json";
            if (File.Exists(path))
            {
                using (StreamReader st = new StreamReader(path))
                {
                    string json = st.ReadToEnd();
                    JNTErrorApiList lsError = JsonConvert.DeserializeObject<JNTErrorApiList>(json);
                    JNTErrorConstant err = lsError.JNTErrors.FirstOrDefault(u => u.id == code);
                    if (err != null)
                    {
                        return err.description;
                    }

                }
            }
            return result;
        }
    }
    public class JNTTrackingDetail
    {
        public string scantime { get; set; }
        public string scantype { get; set; }
        public string desc { get; set; }
    }

    public class JNTTrackingResponseitem
    {
        public string success { get; set; }
        public string reason { get; set; }
        public List<JNTTrackingTracesList> tracesList { get; set; }
    }
    public class JNTTrackingTracesList
    {
        public string billcode { get; set; }
        public List<JNTTrackingDetail> details { get; set; }
    }

    public class JsonJNTTrackingOutput
    {
        public string logisticproviderid { get; set; }
        public List<JNTTrackingResponseitem> responseitems { get; set; }
    }



    public class JsonJNTTrackingInput
    {
        public string billcode { get; set; }
        public string lang { get; set; } = "vn";
    }
    public class JNTErrorConstant
    {
        public string id { get; set; }
        public string description { get; set; }
    }

    public class JNTErrorApiList
    {
        public List<JNTErrorConstant> JNTErrors { get; set; }
    }

    public class JNTResponseitemCancel
    {
        public string success { get; set; }
        public string reason { get; set; }
    }

    public class JsonJNTCancelOrderOutput
    {
        public string logisticproviderid { get; set; }
        public List<JNTResponseitemCancel> responseitems { get; set; }
    }
    public class JNTFieldlist
    {
        public string txlogisticid { get; set; }
        public string fieldname { get; set; }
        public string fieldvalue { get; set; }
        public string remark { get; set; }
    }

    public class JsonJNTCancelOrderInput
    {
        public string eccompanyid { get; set; }
        public string customerid { get; set; }
        public string logisticproviderid { get; set; }
        public string txlogisticid { get; set; }
        public List<JNTFieldlist> fieldlist { get; set; }
    }
    public class JNTItem
    {
        public string itemname { get; set; }
        public string englishName { get; set; }
        public string number { get; set; }
        public string itemvalue { get; set; }
        public string desc { get; set; }
    }

    public class JNTReceiver
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string mobile { get; set; }
        public string prov { get; set; }
        public string city { get; set; }
        public string area { get; set; }
        public string address { get; set; }
    }

    public class JsonJNTCreateOrderInput
    {
        public string eccompanyid { get; set; }
        public string customerid { get; set; }
        public string txlogisticid { get; set; }
        public int ordertype { get; set; }
        public int servicetype { get; set; }
        public int selfAddress { get; set; }
        public string special { get; set; }
        public string partsign { get; set; }
        public JNTSender sender { get; set; }
        public JNTReceiver receiver { get; set; }
        public string createordertime { get; set; }
        public string sendstarttime { get; set; }
        public string sendendtime { get; set; }
        public string paytype { get; set; }
        public string itemsvalue { get; set; }
        public string goodsvalue { get; set; }
        public string isInsured { get; set; }
        public List<JNTItem> items { get; set; }
        public string weight { get; set; }
        public string volume { get; set; }
        public string remark { get; set; }
    }

    public class JNTSender
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string mobile { get; set; }
        public string prov { get; set; }
        public string city { get; set; }
        public string area { get; set; }
        public string address { get; set; }
    }
    public class JNTResponseitem
    {
        public string billcode { get; set; }
        public string codFee { get; set; }
        public string code { get; set; }
        public string dispatchSite { get; set; }
        public string inquiryFee { get; set; }
        public string insurancefee { get; set; }
        public string reason { get; set; }
        public string success { get; set; }
        public string txlogisticid { get; set; }
        public string transport { get; set; }


    }

    public class JSonJNTCreateOderOutput
    {
        public string logisticproviderid { get; set; }
        public List<JNTResponseitem> responseitems { get; set; }
    }
    public class JSonJNTErrorOutput
    {
        public int code { get; set; }
        public string desc { get; set; }
        public bool success { get; set; }
    }
    public class WHJNTResponseitem
    {
        public string status_code { get; set; }
        public string status_name { get; set; }
        public string fee { get; set; }
        public string weight { get; set; }
        public string source { get; set; }
        public string signpart { get; set; }
        public string txlogisticid { get; set; }
        public string insurancefee { get; set; }
        public string scantime { get; set; }
        public string statuscode { get; set; }
        public string codfee { get; set; }
        public string totalfee { get; set; }
        public string commissionfee { get; set; }
        public string pretaxfee { get; set; }
        public string fuelsurcharge { get; set; }
        public string billcode { get; set; }
        public string cod { get; set; }
        public string id { get; set; }
        public string codaftersignpart { get; set; }
    }

    public class WHJNTInput
    {
        public List<WHJNTResponseitem> responseitems { get; set; }
    }
}
