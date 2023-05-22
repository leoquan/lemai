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
using System.Web.UI;

namespace LeMaiDesktop
{
    public class ApiVNPOST : IConnectApi
    {
        public OutResultGHN CancelOrder(view_GExpBillGHNApi bill)
        {
            OutResultGHN rs = new OutResultGHN();
			var client = new RestClient("https://connect-my.vnpost.vn/customer-partner/orderCancel");
			var request = new RestRequest();
			request.Method = Method.POST;
			request.AddHeader("token", bill.Token);
			request.AddHeader("Content-Type", "application/json");
			string bodyjson = JsonConvert.SerializeObject(new { OriginalId = bill.BT3CodeSub});
			request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			var response = client.Execute(request);
			try
			{
				var list = JsonConvert.DeserializeObject<List<JsonVNPOSTCancelOutput>>(response.Content);
                if (list.Count > 0)
                {

                }
			}
			catch (Exception ex)
			{
				rs.Message = ex.ToString();
				rs.IsSuccess = false;
				ApiConnectUlti.LogFileApi(response.Content, bill.BillCode, bill.FK_ProviderAccount);
			}
			rs.IsSuccess = false;
            rs.Message = "Chưa thực hiện hủy đơn hàng của VNPOST từ API.";
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
            var client = new RestClient("https://connect-my.vnpost.vn/customer-partner/CreateOrder");
            var request = new RestRequest();
            request.Method = Method.POST;
            request.AddHeader("token", bill.Token);
            request.AddHeader("Content-Type", "application/json");

            JsonVNPOSTInput input = new JsonVNPOSTInput();
            input.orderCreationStatus = 1;
            input.type = "GUI";
            input.customerCode = bill.ShopId;
            input.contractCode = bill.ClientId;
            input.informationOrder = new InformationOrderInput();
            input.informationOrder.additionRequest = new List<AdditionRequestInput>();
            input.informationOrder.addonService = new List<AddonServiceInput>();

            input.informationOrder.senderName = bill.SendMan;
            input.informationOrder.senderPhone = bill.SendManPhone;
            input.informationOrder.senderAddress = bill.SendManAddress;
            input.informationOrder.senderProvinceCode = bill.ProvinceCode;
            input.informationOrder.senderProvinceName = bill.ProvinceName;
            input.informationOrder.senderDistrictCode = bill.DistrictCode;
            input.informationOrder.senderDistrictName = bill.DistrictName;
            input.informationOrder.senderCommuneCode = bill.WardCode;
            input.informationOrder.senderCommuneName = bill.WardName;

            input.informationOrder.receiverName = bill.AcceptMan;
            input.informationOrder.receiverAddress = bill.AcceptManAddress;
            input.informationOrder.receiverPhone = bill.AcceptManPhone;
            input.informationOrder.receiverProvinceCode = bill.AcceptProvinceCodeS;
            input.informationOrder.receiverProvinceName = bill.AcceptProvince;

            input.informationOrder.receiverDistrictCode = bill.AcceptDistrictCodeS;
            input.informationOrder.receiverDistrictName = bill.AcceptDistrict;

            input.informationOrder.receiverCommuneCode = bill.AcceptWardCodeS;
            input.informationOrder.receiverCommuneName = bill.AcceptWard;
            input.informationOrder.serviceCode = bill.ServiceId;

            input.informationOrder.saleOrderCode = bill.BillCode;
            input.informationOrder.contentNote = bill.GoodsName;
            input.informationOrder.weight = bill.BillWeight.ToString();
            if (bill.GoodsW > 50 || bill.GoodsH > 50 || bill.GoodsL > 50)
            {
                input.informationOrder.width = bill.GoodsW;
                input.informationOrder.height = bill.GoodsH;
                input.informationOrder.length = bill.GoodsL;
            }
            input.informationOrder.orgCodeCollect = Int32.Parse(bill.PostBT3Id);
            input.informationOrder.orgCodeAccept = Int32.Parse(bill.PostBT3Id);

            input.informationOrder.vehicle = "BO"; // Giao bằng đường bộ
            input.informationOrder.sendType = "2"; // Gửi hàng tại bưu cục

            input.informationOrder.isBroken = "1"; // Hàng dễ vỡ
            input.informationOrder.deliveryTime = "N"; // Thời gian nhận hàng cả Ngày, (S: Sáng, C: Chiều).
            input.informationOrder.deliveryInstruction = bill.Note;


            rs.BT3COD = bill.COD;
            rs.BT3Freight = bill.InitPrice;

            if (bill.FK_PaymentType == "GTT")
            {
                rs.BT3COD = bill.COD;
            }
            else
            {

                rs.BT3COD = bill.COD + bill.Freight;
            }
            if (rs.BT3COD > 0)
            {
                AddonServiceInput addS = new AddonServiceInput();
                addS.code = "GTG021";
                addS.propValue = "PROP0018:" + rs.BT3COD;
                input.informationOrder.addonService.Add(addS);
            }

            if (bill.FK_ShipType == "CXH")
            {
                input.informationOrder.deliveryRequire = "2"; // VNPOST: 1. Không cho xem hàng, 2. Cho xem hàng
            }
            else
            {
                input.informationOrder.deliveryRequire = "1";
            }

            input.informationOrder.deliveryInstruction = bill.Note;

            string bodyjson = JsonConvert.SerializeObject(input);
            request.AddParameter("application/json", bodyjson, ParameterType.RequestBody);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                JsonVNPOSTOutput result = JsonConvert.DeserializeObject<JsonVNPOSTOutput>(response.Content);
                if (result != null)
                {
                    if (!string.IsNullOrEmpty(result.itemCode))
                    {
                        // Thành công
                        rs.OrderCode = result.itemCode;
                        rs.BT3Freight = result.totalFee;
                        rs.BT3SubCode = result.originalID;
                        rs.IsSuccess = true;
                    }
                    else
                    {
                        // Thất bại
                        JsonVNPOSTErrorOutput error = JsonConvert.DeserializeObject<JsonVNPOSTErrorOutput>(response.Content);
                        rs.Message = error.message;
                        rs.IsSuccess = false;
                    }
                }
                else
                {
                    // Thất bại
                    JsonVNPOSTErrorOutput error = JsonConvert.DeserializeObject<JsonVNPOSTErrorOutput>(response.Content);
                    rs.Message = error.message;
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
            var client = new RestClient("https://connect-my.vnpost.vn/customer-partner/GetStatusHistoryOrder?type=2&code=" + bill.BillCode);
            var request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("token", bill.Token);
            request.AddHeader("Content-Type", "application/json");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Execute(request);
            try
            {
                JSONTrackingVNPOST result = JsonConvert.DeserializeObject<JSONTrackingVNPOST>(response.Content);
                if (result != null)
                {
                    if (result.data != null && result.data.Count > 0)
                    {
                        foreach (var item in result.data)
                        {
                            foreach (var subItem in item.statusHistory)
                            {
                                OutTrackingLogGHN log = new OutTrackingLogGHN();
                                log.StatusCode = subItem.statusCode.ToString();
                                log.Note = subItem.statusName;
                                log.ActionDate = subItem.createdDate + " " + subItem.createHour;
                                DateTime date = DateTime.Now;
                                if (!DateTime.TryParseExact(log.ActionDate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                                {
                                    date = DateTime.Now;
                                }
                                log.ProviderName = "VNPOST";
                                log.ActionDateTime = new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, 0, 0);
                                rs.outTrackingLogs.Add(log);
                            }
                        }
                        if (rs.outTrackingLogs.Count > 0)
                        {
                            rs.IsSuccess = true;
                        }
                        else
                        {
                            rs.IsSuccess = false;
                        }
                    }
                    else
                    {
                        rs.IsSuccess = false;
                        rs.Message = "Không tìm thấy dữ liệu lịch sử đơn hàng";
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
            rs.Message = "Chưa hỗ trợ cập nhật COD của nhà vận chuyển này từ API.";
            return rs;
        }

        public OutResultGHN UpdateOrder(view_GExpBillGHNApi bill)
        {
            OutResultGHN rs = new OutResultGHN();
            rs.IsSuccess = false;
            rs.Message = "Chưa hỗ trợ cập nhật thông tin đơn hàng của nhà vận chuyển này từ API.";
            return rs;
        }
    }
    //================== API INPUT ==========================
    public class AdditionRequestInput
    {
        public string code { get; set; }
        public string propValue { get; set; }
    }

    public class AddonServiceInput
    {
        public string code { get; set; }
        public string propValue { get; set; }
    }

    public class InformationOrderInput
    {
        public string senderName { get; set; }
        public string senderPhone { get; set; }
        public string senderMail { get; set; }
        public string senderAddress { get; set; }
        public string senderProvinceCode { get; set; }
        public string senderProvinceName { get; set; }
        public string senderDistrictCode { get; set; }
        public string senderDistrictName { get; set; }
        public string senderCommuneCode { get; set; }
        public string senderCommuneName { get; set; }
        public string receiverName { get; set; }
        public string receiverAddress { get; set; }
        public string receiverProvinceCode { get; set; }
        public string receiverProvinceName { get; set; }
        public string receiverDistrictCode { get; set; }
        public string receiverDistrictName { get; set; }
        public string receiverCommuneCode { get; set; }
        public string receiverCommuneName { get; set; }
        public string receiverPhone { get; set; }
        public object receiverEmail { get; set; }
        public string serviceCode { get; set; }
        public List<AddonServiceInput> addonService { get; set; }
        public List<AdditionRequestInput> additionRequest { get; set; }
        public object orgCodeCollect { get; set; }
        public int orgCodeAccept { get; set; }
        public string saleOrderCode { get; set; }
        public string contentNote { get; set; }
        public string weight { get; set; }
        public object width { get; set; }
        public object length { get; set; }
        public object height { get; set; }
        public string vehicle { get; set; }
        public string sendType { get; set; }
        public string isBroken { get; set; }
        public string deliveryTime { get; set; }
        public string deliveryRequire { get; set; }
        public string deliveryInstruction { get; set; }
    }

    public class JsonVNPOSTInput
    {
        public int orderCreationStatus { get; set; }
        public string type { get; set; }
        public string customerCode { get; set; }
        public string contractCode { get; set; }
        public InformationOrderInput informationOrder { get; set; }
    }
	// =================== API OUTPUT ======================
	public class JsonVNPOSTCancelOutput
	{
		public string type { get; set; }
		public string note { get; set; }
		public string message { get; set; }
		public string originalId { get; set; }
		public int caseId { get; set; }
	}
	public class AdditionRequestOutput
    {
        public string code { get; set; }
        public int fee { get; set; }
        public int feeBeforeTax { get; set; }
        public int tax { get; set; }
        public int taxRate { get; set; }
        public List<PropList> propList { get; set; }
    }

    public class AddonServiceOutput
    {
        public string code { get; set; }
        public int fee { get; set; }
        public int feeBeforeTax { get; set; }
        public int tax { get; set; }
        public decimal taxRate { get; set; }
        public List<PropList> propList { get; set; }
    }

    public class PropList
    {
        public string propCode { get; set; }
        public string propValue { get; set; }
        public object propValueActual { get; set; }
    }
    public class JsonVNPOSTErrorOutput
    {
        public int status { get; set; }
        public string timestamp { get; set; }
        public string error { get; set; }
        public string message { get; set; }
        public string description { get; set; }
        public string path { get; set; }
    }
    public class JsonVNPOSTOutput
    {
        public string orderHdrID { get; set; }
        public string originalID { get; set; }
        public string itemCode { get; set; }
        public string originalItemCode { get; set; }
        public int status { get; set; }
        public string saleOrderCode { get; set; }
        public string senderCode { get; set; }
        public string senderContractNumber { get; set; }
        public string senderName { get; set; }
        public string senderPhone { get; set; }
        public object senderEmail { get; set; }
        public string senderAddress { get; set; }
        public string senderProvinceCode { get; set; }
        public string senderProvinceName { get; set; }
        public string senderDistrictCode { get; set; }
        public string senderDistrictName { get; set; }
        public string senderCommuneCode { get; set; }
        public string senderCommuneName { get; set; }
        public string senderPostcode { get; set; }
        public object receiverCode { get; set; }
        public string receiverName { get; set; }
        public object receiverContractNumber { get; set; }
        public string receiverAddress { get; set; }
        public string receiverProvinceCode { get; set; }
        public string receiverProvinceName { get; set; }
        public string receiverDistrictCode { get; set; }
        public string receiverDistrictName { get; set; }
        public string receiverCommCode { get; set; }
        public string receiverCommName { get; set; }
        public string receiverPostcode { get; set; }
        public string receiverPhone { get; set; }
        public object receiverEmail { get; set; }
        public string serviceCode { get; set; }
        public int totalFee { get; set; }
        public int mainFee { get; set; }
        public int mainFeeBeforeTax { get; set; }
        public int mainTax { get; set; }
        public int vasFee { get; set; }
        public int? codAmount { get; set; }
        public List<AddonServiceOutput> addonService { get; set; }
        public List<AdditionRequestOutput> additionRequest { get; set; }
        public int weight { get; set; }
        public object length { get; set; }
        public object width { get; set; }
        public object height { get; set; }
        public int dimWeight { get; set; }
        public int priceWeight { get; set; }
        public string deliveryInstruction { get; set; }
        public int quantity { get; set; }
        public string contentNote { get; set; }
        public List<object> contentDetail { get; set; }
        public string sendType { get; set; }
        public string isBroken { get; set; }
        public string deliveryTime { get; set; }
        public string deliveryRequire { get; set; }
        public string vehicle { get; set; }
        public object awbNumber { get; set; }
        public object voucher { get; set; }
        public object orgCodeCollect { get; set; }
        public string orgCodeAccept { get; set; }
        public string createdBy { get; set; }
        public string createdDate { get; set; }
        public string updatedBy { get; set; }
        public string updatedDate { get; set; }
        public object acceptedDate { get; set; }
        public object sortingCode { get; set; }
        public string paymentStatus { get; set; }
        public object caseTypeName { get; set; }
        public object caseStatus { get; set; }
        public string source { get; set; }
        public string inputType { get; set; }
        public string inputMethod { get; set; }
        public List<object> documents { get; set; }
        public List<object> packageInfo { get; set; }
    }
    //  =========== TRACKING ========
    public class VNPOSTDataSum
    {
        public string itemCode { get; set; }
        public List<StatusHistory> statusHistory { get; set; }
    }

    public class JSONTrackingVNPOST
    {
        public List<VNPOSTDataSum> data { get; set; }
    }

    public class StatusHistory
    {
        public string createdDate { get; set; }
        public string createHour { get; set; }
        public int statusCode { get; set; }
        public string statusName { get; set; }
    }
}
