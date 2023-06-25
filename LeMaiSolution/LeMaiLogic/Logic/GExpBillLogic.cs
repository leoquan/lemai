using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public enum enumGExpBillStatus
    {
        MOI_TAO_0,
        TIEP_NHAN_1,
        TU_CHOI_2,
        DEN_TRUNG_TAM_3,
        DANG_TRUNG_CHUYEN_4,
        DANG_PHAT_5,
        DA_GIAO_6,
        DUYET_HOAN_7,
        DA_HOAN_8
    }
    public partial class GExpBillLogic : BaseLogic
    {
        public GExpBillLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        public view_AutoSignDelivery GetDetailAutoSignDelivery()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewautosigndelivery.GetObjectCon(base.ConnectionData.Schema, "ORDER BY SignDate");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public List<GExpWebhook> GetListWebhook()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExpwebhook.GetListObjectCon(base.ConnectionData.Schema, "WHERE IsProcess=@IsProcess", "@IsProcess", false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public void DeleteWebhook(string webhookId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpWebhook webhook = dc.GExpwebhook.GetObject(base.ConnectionData.Schema, webhookId);
                if (webhook != null)
                {
                    webhook.IsProcess = true;
                    webhook.ProcessDate = DateTime.Now;
                    dc.GExpwebhook.Update(base.ConnectionData.Schema, webhook);
                    dc.SubmitChanges();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }

        /// <summary>
        /// Get all view_GExpBill List
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_GExpBill>> GetList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpbill.GetListObject(base.ConnectionData.Schema);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }

        /// <summary>
        /// Tìm view_GExpBill theo keyword
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_GExpBill>> GetList(string keyword, string postId, string customerId, DateTime from, DateTime to, string loaiKienId, string status = "")
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = "WHERE RegisterSiteCode='" + postId + "' AND RegisterDate>='" + string.Format("{0:yyyy-MM-dd}", from) + " 00:00:00' AND RegisterDate<='" + string.Format("{0:yyyy-MM-dd}", to) + " 23:59:59' &";
                if (customerId != "9999")
                {
                    condition += " FK_Customer='" + customerId + "' &";
                }
                if (loaiKienId != "9999")
                {
                    condition += " FK_ProviderAccount='" + loaiKienId + "' &";
                }
                if (!string.IsNullOrEmpty(status))
                {
                    condition += " BillStatus IN (" + status + ") &";
                }
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " (BillCode like N'%" + keyword + "%' OR SendMan like N'%" + keyword + "%' OR SendManUs like N'%" + keyword + "%' OR SendManPhone like N'%" + keyword + "%' OR AcceptMan like N'%" + keyword + "%' OR AcceptManUs like N'%" + keyword + "%' OR AcceptManPhone like N'%" + keyword + "%' OR AcceptProvince like N'%" + keyword + "%' OR BT3Code like N'%" + keyword + "%' ) ";
                }

                condition = condition.Trim();
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                condition = condition + " ORDER BY BillCode desc";
                return dc.VIewgexpbill.GetListObjectCon(base.ConnectionData.Schema, condition);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<List<view_GExpOrder>> GetOrderList(string keyword, string postId, string customerId, DateTime from, DateTime to)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = "WHERE FK_Post='" + postId + "' AND CreateDate>='" + string.Format("{0:yyyy-MM-dd}", from) + " 00:00:00' AND CreateDate<='" + string.Format("{0:yyyy-MM-dd}", to) + " 23:59:59' &";
                if (customerId != "9999")
                {
                    condition += " FK_CustomerId='" + customerId + "' &";
                }
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " (OrderCode like N'%" + keyword + "%' OR AcceptName like N'%" + keyword + "%' OR AcceptPhone like N'%" + keyword + "%' OR CustomerName like N'%" + keyword + "%' OR CustomerPhone like N'%" + keyword + "%' OR CustomerCode like N'%" + keyword + "%' ) ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                condition = condition + " ORDER BY OrderCode desc";

                return dc.VIewgexporder.GetListObjectCon(base.ConnectionData.Schema, condition);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public GExpOrder GetOrderDetailWithCustomer(string Id, out ExpCustomer customer)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpOrder order = dc.GExporder.GetObject(base.ConnectionData.Schema, Id);
                if (order != null)
                {
                    customer = dc.EXpcustomer.GetObject(base.ConnectionData.Schema, order.FK_CustomerId);
                    return order;
                }
                else
                {
                    customer = null;
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<List<view_GExpBillGHN>> GetListExportExcel(string postId, string lsProvider, DateTime from, DateTime to)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = "WHERE RegisterSiteCode='" + postId + "' AND RegisterDate>='" + string.Format("{0:yyyy-MM-dd}", from) + " 00:00:00' AND RegisterDate<='" + string.Format("{0:yyyy-MM-dd}", to) + " 23:59:59'";
                condition += " AND FK_ProviderAccount IN (" + lsProvider + ")";
                condition = condition + " ORDER BY BillCode desc";
                return dc.VIewgexpbillghn.GetListObjectCon(base.ConnectionData.Schema, condition);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<List<view_GExpBillGHN>> GetListGHN(string postId, string customerId, DateTime from, DateTime to, string listIds)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = string.Empty;
                if (string.IsNullOrEmpty(listIds))
                {
                    condition = "WHERE RegisterSiteCode='" + postId + "' AND RegisterDate>='" + string.Format("{0:yyyy-MM-dd}", from) + " 00:00:00' AND RegisterDate<='" + string.Format("{0:yyyy-MM-dd}", to) + " 23:59:59' &";
                    if (customerId != "9999")
                    {
                        condition += " FK_Customer='" + customerId + "' &";
                    }
                    condition = condition.Trim();
                    condition = condition.TrimEnd('&');
                    condition = condition.Replace("&", "AND");
                }
                else
                {
                    condition = "WHERE BillCode IN (" + listIds + ")";
                }

                condition = condition + " ORDER BY BillCode desc";
                return dc.VIewgexpbillghn.GetListObjectCon(base.ConnectionData.Schema, condition);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Danh sách view_GExpBill theo giới hạn keyword và page
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="page">Số trang hiển thị</param>
        /// <returns></returns>
        public async Task<List<view_GExpBill>> GetPage(string keyword, int? page)
        {
            try
            {
                int take = 10;
                int skip = 0;
                // Có tham số phân trang
                if (page != null)
                {
                    skip = ((int)page - 1) * take;
                    skip = skip < 0 ? 0 : skip;
                }
                return await GetPage(keyword, take, skip);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Danh sách view_GExpBill theo giới hạn keyword, Take, Skip
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<List<view_GExpBill>> GetPage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE BillCode like N'%" + keyword + "%' | SendMan like N'%" + keyword + "%' | SendManUs like N'%" + keyword + "%' | SendManPhone like N'%" + keyword + "%' | AcceptMan like N'%" + keyword + "%' | AcceptManUs like N'%" + keyword + "%' | AcceptManPhone like N'%" + keyword + "%' | AcceptProvince like N'%" + keyword + "%' | BT3Code like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY BillCode asc";
                return dc.VIewgexpbill.GetListObjectLimitCon(base.ConnectionData.Schema, "*", condition, Take, Skip);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Tuple Danh sách view_GExpBill theo giới hạn keyword, Take, Skip và số dòng dữ liệu
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<Tuple<List<view_GExpBill>, int>> GetTuplePage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                var list = dc.VIewgexpbill.GetListObject(base.ConnectionData.Schema);
                var data = await GetPage(keyword, Take, Skip);
                return new Tuple<List<view_GExpBill>, int>(data, list.Count);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Get List of SameGExpBillLogic
        /// </summary>
        /// <param name="BillCode">BillCode Of GExpBill</param>
        /// <returns></returns>
        public async Task<List<view_GExpBill>> GetSameList(String BillCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int take = 10;
                return dc.VIewgexpbill.GetListObjectLimitCon(base.ConnectionData.Schema, "*", "WHERE BillCode<>@BillCode  ", take, 0, "@BillCode", BillCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Get view_GExpBill Object
        /// </summary>
        /// <param name="BillCode">BillCode Of GExpBill</param>
        /// <returns></returns>
        public async Task<view_GExpBill> GetDetails(String BillCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpbill.GetObjectCon(base.ConnectionData.Schema, " WHERE BillCode=@BillCode ", "@BillCode", BillCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<bool> UpdateNotify(String Id, string userId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpNotification notify = dc.GExpnotification.GetObject(base.ConnectionData.Schema, Id);
                if (notify != null)
                {
                    notify.FK_AccountRead = userId;
                    notify.DateRead = dc.CurrentTime();
                    dc.GExpnotification.Update(base.ConnectionData.Schema, notify);
                    dc.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<bool> UpdatePickupAddress(String customerId, bool ispickup, string province, string district, string ward, string address)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpCustomer customer = dc.EXpcustomer.GetObject(base.ConnectionData.Schema, customerId);
                if (customer != null)
                {
                    customer.IsPickup = ispickup;
                    customer.ProvinceId = Int32.Parse(province);
                    customer.DistrictId = Int32.Parse(district);
                    customer.WardId = ward;

                    dc.EXpcustomer.Update(base.ConnectionData.Schema, customer);
                    dc.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<view_GExpNotification> GetNotifyDetails(String id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpnotification.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<List<view_GExpBill>> GetListByListIds(String ids, bool isBT3Code)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                if (isBT3Code)
                {
                    return dc.VIewgexpbill.GetListObjectCon(base.ConnectionData.Schema, " WHERE BillCode IN (" + ids + ") AND (RunMode=0 OR (BT3Code IS NOT NULL AND BT3Code<>''))");
                }
                else
                {
                    return dc.VIewgexpbill.GetListObjectCon(base.ConnectionData.Schema, " WHERE BillCode IN (" + ids + ")");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Cập nhật trạng thái đơn hàng từ mới tạo -> Tiếp nhận
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public async Task<List<view_GExpBill>> PrintBilltByListIds(String ids, bool isBT3Code, string UserId, string FullName, string post)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<view_GExpBill> list = new List<view_GExpBill>();
                if (isBT3Code)
                {
                    list = dc.VIewgexpbill.GetListObjectCon(base.ConnectionData.Schema, " WHERE BillCode IN (" + ids + ") AND (BT3Code IS NOT NULL OR BT3Code<>'')");
                }
                else
                {
                    list = dc.VIewgexpbill.GetListObjectCon(base.ConnectionData.Schema, " WHERE BillCode IN (" + ids + ")");
                }
                DateTime currentDate = dc.CurrentTime();
                foreach (var item in list)
                {

                    if (item.BillStatus == (int)enumGExpBillStatus.MOI_TAO_0)
                    {
                        GExpScan scan = dc.GExpscan.GetObjectCon(base.ConnectionData.Schema, "WHERE BillCode=@BillCode AND TypeScan=@TypeScan AND Post=@Post"
                            , "@BillCode", item.BillCode
                            , "@Post", post
                            , "@TypeScan", "TRACK1");
                        if (scan == null)
                        {
                            scan = new GExpScan();
                            scan.Id = Guid.NewGuid().ToString();
                            scan.BillCode = item.BillCode;
                            scan.CreateDate = currentDate;
                            scan.IsRead = false;
                            scan.KeyDate = string.Format("{0:yyyyMMddHHmmss.fff}", currentDate);
                            scan.NameCreate = FullName;
                            scan.UserCreate = UserId;
                            scan.Post = post;
                            scan.TypeScan = "TRACK1";
                            scan.ProblemType = 0;
                            scan.Note = MakeNotForScan(scan.TypeScan, scan.BillCode, scan.NameCreate, scan.Post);
                            dc.GExpscan.InsertOnSubmit(base.ConnectionData.Schema, scan);
                        }
                    }
                }
                // Chấp nhận thay đổi dữ liệu
                dc.SubmitChanges();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }


        public async Task<int> ReceptionBilltByListIds(List<view_GExpBill> list, string UserId, string FullName, string post)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int count = 0;
                DateTime currentDate = dc.CurrentTime();
                foreach (var item in list)
                {

                    if (item.BillStatus == (int)enumGExpBillStatus.MOI_TAO_0)
                    {
                        GExpScan scan = dc.GExpscan.GetObjectCon(base.ConnectionData.Schema, "WHERE BillCode=@BillCode AND TypeScan=@TypeScan AND Post=@Post"
                            , "@BillCode", item.BillCode
                            , "@Post", post
                            , "@TypeScan", "TRACK2");
                        if (scan == null)
                        {

                            scan = new GExpScan();
                            scan.Id = Guid.NewGuid().ToString();
                            scan.BillCode = item.BillCode;
                            scan.CreateDate = currentDate;
                            scan.IsRead = false;
                            scan.KeyDate = string.Format("{0:yyyyMMddHHmmss.fff}", currentDate);
                            scan.NameCreate = FullName;
                            scan.UserCreate = UserId;
                            scan.Post = post;
                            scan.TypeScan = "TRACK2";
                            scan.ProblemType = 0;
                            scan.Note = MakeNotForScan(scan.TypeScan, scan.BillCode, scan.NameCreate, scan.Post);
                            dc.GExpscan.InsertOnSubmit(base.ConnectionData.Schema, scan);
                            count++;
                        }
                        // Cập nhật trạng thái đơn hàng
                        GExpBill bill = dc.GExpbill.GetObject(base.ConnectionData.Schema, item.BillCode);
                        if (bill != null)
                        {
                            bill.BillStatus = (int)enumGExpBillStatus.TIEP_NHAN_1;
                            bill.LastUpdateDate = currentDate;
                            bill.LastUpdateUser = UserId;
                            dc.GExpbill.Update(base.ConnectionData.Schema, bill);
                        }
                    }
                }
                // Chấp nhận thay đổi dữ liệu
                dc.SubmitChanges();
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<int> RejectBilltByListIds(List<view_GExpBill> list, string UserId, string FullName, string post)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int count = 0;
                DateTime currentDate = dc.CurrentTime();
                foreach (var item in list)
                {

                    if (item.BillStatus == (int)enumGExpBillStatus.MOI_TAO_0 || item.BillStatus == (int)enumGExpBillStatus.TIEP_NHAN_1)
                    {
                        GExpScan scan = dc.GExpscan.GetObjectCon(base.ConnectionData.Schema, "WHERE BillCode=@BillCode AND TypeScan=@TypeScan AND Post=@Post"
                            , "@BillCode", item.BillCode
                            , "@Post", post
                            , "@TypeScan", "TRACK9");
                        if (scan == null)
                        {

                            scan = new GExpScan();
                            scan.Id = Guid.NewGuid().ToString();
                            scan.BillCode = item.BillCode;
                            scan.CreateDate = currentDate;
                            scan.IsRead = false;
                            scan.KeyDate = string.Format("{0:yyyyMMddHHmmss.fff}", currentDate);
                            scan.NameCreate = FullName;
                            scan.UserCreate = UserId;
                            scan.Post = post;
                            scan.TypeScan = "TRACK9";
                            scan.ProblemType = 0;
                            scan.Note = MakeNotForScan(scan.TypeScan, scan.BillCode, scan.NameCreate, scan.Post);
                            dc.GExpscan.InsertOnSubmit(base.ConnectionData.Schema, scan);
                            count++;
                        }
                        // Cập nhật trạng thái đơn hàng
                        GExpBill bill = dc.GExpbill.GetObject(base.ConnectionData.Schema, item.BillCode);
                        if (bill != null)
                        {
                            bill.BillStatus = (int)enumGExpBillStatus.TU_CHOI_2;
                            bill.LastUpdateDate = currentDate;
                            bill.LastUpdateUser = UserId;
                            dc.GExpbill.Update(base.ConnectionData.Schema, bill);
                        }
                    }
                }
                // Chấp nhận thay đổi dữ liệu
                dc.SubmitChanges();
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<bool> CreateDuplicate(string billCode, string userId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpBill item = dc.GExpbill.GetObject(base.ConnectionData.Schema, billCode);
                if (item != null)
                {
                    DateTime currentDate = dc.CurrentTime();
                    item.BillCode = string.Format("{0:yyMM}", currentDate) + ExpGetCode(item.RegisterSiteCode);
                    item.RegisterUser = userId;
                    item.RegisterDate = currentDate;
                    item.LastUpdateDate = currentDate;
                    item.LastUpdateUser = userId;
                    item.BillStatus = 0;
                    item.IsSigned = false;
                    item.IsReturn = false;
                    item.BillProcessStatus = 0;
                    item.IsPayCustomer = false;
                    item.BT3Code = "";
                    //Change Database
                    dc.GExpbill.InsertOnSubmit(base.ConnectionData.Schema, item);
                    dc.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Create a GExpBill Object into Database
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<GExpBill> Create(GExpBillLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpBill item = new GExpBill();
                DateTime currentDate = dc.CurrentTime();
                // Mapping Prop
                item.BillCode = string.Format("{0:yyMM}", currentDate) + ExpGetCode(input.RegisterSiteCode);
                item.BillWeight = input.BillWeight;
                item.FeeWeight = input.FeeWeight;
                item.RegisterUser = input.RegisterUser;
                item.RegisterSiteCode = input.RegisterSiteCode;
                item.Freight = input.Freight;
                item.PayType = input.PayType;
                item.COD = input.COD;
                item.SendMan = input.SendMan;
                item.SendManUs = UnSigns(item.SendMan);
                item.SendManPhone = input.SendManPhone;
                item.SendManAddress = input.SendManAddress;
                item.AcceptProvinceCode = input.AcceptProvinceCode;
                item.AcceptDistrictCode = input.AcceptDistrictCode;
                item.AcceptWardCode = input.AcceptWardCode;
                item.AcceptMan = input.AcceptMan;
                item.AcceptManUs = UnSigns(item.AcceptMan);
                item.AcceptManPhone = input.AcceptManPhone;
                item.AcceptManAddress = input.AcceptManAddress;
                item.AcceptProvince = input.AcceptProvince;
                item.AcceptDistrict = input.AcceptDistrict;
                item.AcceptWard = input.AcceptWard;
                item.IsSigned = false;
                item.IsReturn = false;
                item.BillProcessStatus = 0;
                item.RegisterDate = currentDate;
                item.LastUpdateDate = currentDate;
                item.LastUpdateUser = input.LastUpdateUser;
                item.Note = input.Note;
                item.SystemDate = currentDate;
                item.BT3Type = input.BT3Type;
                GExpProvider provider = dc.GExpprovider.GetObject(base.ConnectionData.Schema, input.BT3Type);
                if (provider != null)
                {
                    item.BT3Type = provider.ProviderTypeCode;
                }
                item.GoodsName = input.GoodsName;
                item.GoodsNumber = input.GoodsNumber;
                item.GoodsCode = input.GoodsCode;
                item.GoodsW = input.GoodsW;
                item.GoodsH = input.GoodsH;
                item.GoodsL = input.GoodsL;
                item.FK_Customer = input.FK_Customer;
                item.FK_ProviderAccount = input.FK_ProviderAccount;
                item.IsPayCustomer = false;
                item.BillStatus = 0;
                item.FK_PaymentType = input.FK_PaymentType;
                item.FK_ShipType = input.FK_ShipType;
                item.SiteCode = input.SiteCode;
                item.Pickup = input.Pickup;
                item.ProvincePickup = input.ProvincePickup;
                item.DistricPickup = input.DistricPickup;
                item.WardPickup = input.WardPickup;
                item.AddressPickup = input.AddressPickup;
                item.ShopIdPickup = input.ShopIdPickup;
                item.NamePickup = input.NamePickup;
                item.PhonePickup = input.PhonePickup;
                item.IsReceiveBill = input.IsReceiveBill;
                //Change Database
                dc.GExpbill.InsertOnSubmit(base.ConnectionData.Schema, item);
                // Thêm scan
                GExpScan scan = new GExpScan();
                scan.Id = Guid.NewGuid().ToString();
                scan.BillCode = item.BillCode;
                scan.CreateDate = currentDate;
                scan.IsRead = false;
                scan.KeyDate = string.Format("{0:yyyyMMddHHmmss.fff}", currentDate);
                scan.NameCreate = input.FullName;
                scan.UserCreate = input.RegisterUser;
                scan.Post = input.RegisterSiteCode;
                scan.TypeScan = "TRACK0";
                scan.ProblemType = 0;
                scan.Note = MakeNotForScan(scan.TypeScan, scan.BillCode, scan.NameCreate, scan.Post);
                dc.GExpscan.InsertOnSubmit(base.ConnectionData.Schema, scan);
                // Tạo danh bạ
                GExpAccept accept = dc.GExpaccept.GetObjectCon(base.ConnectionData.Schema, "WHERE AcceptPhone=@AcceptPhone", "@AcceptPhone", input.AcceptManPhone.Trim());
                if (accept == null)
                {
                    accept = new GExpAccept();
                    accept.Id = Guid.NewGuid().ToString();
                    accept.AcceptMan = input.AcceptMan;
                    accept.AcceptPhone = input.AcceptManPhone;
                    accept.AcceptAddress = input.AcceptManAddress;
                    accept.AcceptAddressFull = input.AcceptManAddress + "," + input.AcceptWard + "," + input.AcceptDistrict + "," + input.AcceptProvince;
                    accept.AcceptProvince = input.AcceptProvinceCode;
                    accept.AcceptDistrict = input.AcceptDistrictCode;
                    accept.AcceptWard = input.AcceptWardCode;
                    accept.AcceptLevel = 0;
                    dc.GExpaccept.InsertOnSubmit(base.ConnectionData.Schema, accept);
                }
                else
                {
                    accept.AcceptMan = input.AcceptMan;
                    accept.AcceptAddress = input.AcceptManAddress;
                    accept.AcceptAddressFull = input.AcceptManAddress + "," + input.AcceptWard + "," + input.AcceptDistrict + "," + input.AcceptProvince;
                    accept.AcceptProvince = input.AcceptProvinceCode;
                    accept.AcceptDistrict = input.AcceptDistrictCode;
                    accept.AcceptWard = input.AcceptWardCode;
                    if (accept.AcceptMan != input.AcceptMan || accept.AcceptAddress != input.AcceptManAddress ||
                        accept.AcceptProvince != input.AcceptProvinceCode || accept.AcceptDistrict != input.AcceptDistrictCode || accept.AcceptWard != input.AcceptWardCode)
                    {
                        dc.GExpaccept.Update(base.ConnectionData.Schema, accept);
                    }

                }
                if (input.FK_Customer == "0000")
                {
                    // Tạo danh bạ sender
                    GExpSender sender = dc.GExpsender.GetObjectCon(base.ConnectionData.Schema, "WHERE SendManPhone=@SendManPhone", "@SendManPhone", input.SendManPhone.Trim());
                    if (sender == null)
                    {
                        sender = new GExpSender();
                        sender.Id = Guid.NewGuid().ToString();
                        sender.SendMan = input.SendMan;
                        sender.SendManPhone = input.SendManPhone;
                        sender.SendAddress = input.SendManAddress;
                        dc.GExpsender.InsertOnSubmit(base.ConnectionData.Schema, sender);
                    }
                    else
                    {
                        sender.SendMan = input.SendMan;
                        sender.SendManPhone = input.SendManPhone;
                        sender.SendAddress = input.SendManAddress;
                        if (sender.SendMan != input.SendMan || sender.SendManPhone != input.SendManPhone || sender.SendAddress != input.SendManAddress)
                        {
                            dc.GExpsender.Update(base.ConnectionData.Schema, sender);
                        }

                    }
                }

                // If ORDER
                if (!string.IsNullOrEmpty(input.IdOrder))
                {
                    GExpOrder order = dc.GExporder.GetObject(base.ConnectionData.Schema, input.IdOrder);
                    if (order != null)
                    {
                        order.StatusOrder = 1;
                        order.PickupUser = input.RegisterUser;
                        order.PickupDate = currentDate;
                        order.TransferCode = item.BillCode;
                        dc.GExporder.Update(base.ConnectionData.Schema, order);
                    }
                }
                dc.SubmitChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }

        public int CreateWithList(view_GExpBill bill, string userId, string fullName, string post)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();
                GExpBill item = new GExpBill();
                item.BillCode = string.Format("{0:yyMM}", currentDate) + ExpGetCode(post);
                item.RegisterSiteCode = post;
                item.BillProcessStatus = 0;
                item.RegisterDate = currentDate;
                item.LastUpdateDate = currentDate;
                item.BillStatus = 0;
                item.PayType = "Gửi thanh toán";

                var map = GetMappingFromAddress(bill.FullAddress);
                item.AcceptDistrict = map.AcceptDistrict;
                item.AcceptDistrictCode = map.AcceptDistrictCode;
                item.AcceptMan = bill.AcceptMan;
                item.AcceptManAddress = bill.FullAddress;
                item.AcceptManPhone = bill.AcceptManPhone;
                item.AcceptManUs = UnSigns(bill.AcceptMan);
                item.AcceptProvince = map.AcceptProvince;
                item.AcceptProvinceCode = map.AcceptProvinceCode;
                item.AcceptWard = map.AcceptWard;
                item.AcceptWardCode = map.AcceptWardCode;
                item.BillWeight = bill.BillWeight;

                //item.BT3COD = 0;//
                //item.BT3Code = "";//
                //item.BT3CodeSub = "";//
                //item.BT3Freight = 0;//
                //item.BT3LastMess = "";//
                //item.BT3PayType = "";//
                //item.BT3Status = "";//

                item.BT3Type = "NONE";

                item.COD = bill.COD;
                item.FeeWeight = bill.FeeWeight;
                item.FK_Customer = bill.FK_Customer;
                item.GoodsName = bill.GoodsName;

                item.FK_PaymentType = "GTT";
                item.FK_ProviderAccount = "GHSV02";
                item.FK_ShipType = "CXH";
                item.Freight = 0;
                item.GoodsCode = "CODE";
                item.GoodsH = 10;
                item.GoodsL = 10;
                item.GoodsW = 10;
                item.GoodsNumber = 1;
                item.IsPayCustomer = false;
                item.IsReturn = false;
                item.IsSigned = false;
                item.LastUpdateUser = userId;
                item.Note = bill.Note;
                item.RegisterUser = userId;
                item.SendMan = bill.SendMan;
                item.SendManAddress = bill.SendManAddress;
                item.SendManPhone = bill.SendManPhone;
                item.SendManUs = UnSigns(bill.SendMan);
                item.SystemDate = currentDate;

                dc.GExpbill.InsertOnSubmit(base.ConnectionData.Schema, item);
                // Thêm scan
                GExpScan scan = new GExpScan();
                scan.Id = Guid.NewGuid().ToString();
                scan.BillCode = item.BillCode;
                scan.CreateDate = currentDate;
                scan.IsRead = false;
                scan.KeyDate = string.Format("{0:yyyyMMddHHmmss.fff}", currentDate);
                scan.NameCreate = fullName;
                scan.UserCreate = userId;
                scan.Post = post;
                scan.TypeScan = "TRACK0";
                scan.ProblemType = 0;
                scan.Note = MakeNotForScan(scan.TypeScan, scan.BillCode, scan.NameCreate, scan.Post);
                dc.GExpscan.InsertOnSubmit(base.ConnectionData.Schema, scan);

                dc.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                dc.Close();
            }
        }

        /// <summary>
        /// Update GExpBill 
        /// </summary>
        /// <returns></returns>
        public async Task<Tuple<bool, bool, bool>> Update(String BillCode, GExpBillLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool changeCOD = false;
                bool changeTT = false;
                string valueupdates = string.Empty;
                string keyupdates = string.Empty;
                GExpBill item = dc.GExpbill.GetObject(base.ConnectionData.Schema, BillCode);
                if (item != null)
                {
                    DateTime currentDate = dc.CurrentTime();
                    // Mapping Prop
                    if (item.BillWeight != input.BillWeight)
                    {
                        changeTT = true;
                        keyupdates += "Cân nặng BT3;";
                        valueupdates += item.BillWeight.ToString("N0") + " => " + input.BillWeight.ToString("N0") + "|";
                    }
                    item.BillWeight = input.BillWeight;

                    if (item.FeeWeight != input.FeeWeight)
                    {
                        keyupdates += "Cân nặng KH;";
                        valueupdates += item.FeeWeight.ToString("N0") + " => " + input.FeeWeight.ToString("N0") + "|";
                    }
                    item.FeeWeight = input.FeeWeight;

                    if (item.Freight != input.Freight)
                    {
                        changeTT = true;
                        keyupdates += "Phí VC;";
                        valueupdates += item.Freight.ToString("N0") + " => " + input.Freight.ToString("N0") + "|";
                    }
                    item.Freight = input.Freight;

                    if (item.COD != input.COD)
                    {
                        changeCOD = true;
                        keyupdates += "COD;";
                        valueupdates += item.COD.ToString("N0") + " => " + input.COD.ToString("N0") + "|";
                    }
                    item.COD = input.COD;

                    if (item.PayType != input.PayType)
                    {
                        changeTT = true;
                        keyupdates += "Loại TT;";
                        valueupdates += item.PayType + " => " + input.PayType + "|";
                    }
                    item.PayType = input.PayType;

                    if (item.SendMan != input.SendMan)
                    {
                        changeTT = true;
                        keyupdates += "Người gửi;";
                        valueupdates += item.SendMan + " => " + input.SendMan + "|";
                    }
                    item.SendMan = input.SendMan;

                    item.SendManUs = UnSigns(item.SendMan);
                    item.SendManPhone = input.SendManPhone;
                    item.SendManAddress = input.SendManAddress;

                    if (item.AcceptProvinceCode != input.AcceptProvinceCode)
                    {
                        changeTT = true;
                        keyupdates += "Tỉnh nhận;";
                        valueupdates += item.AcceptProvinceCode + " => " + input.AcceptProvinceCode + "|";
                    }
                    item.AcceptProvinceCode = input.AcceptProvinceCode;

                    if (item.AcceptDistrictCode != input.AcceptDistrictCode)
                    {
                        changeTT = true;
                        keyupdates += "Huyện nhận;";
                        valueupdates += item.AcceptDistrictCode + " => " + input.AcceptDistrictCode + "|";
                    }
                    item.AcceptDistrictCode = input.AcceptDistrictCode;

                    if (item.AcceptWardCode != input.AcceptWardCode)
                    {
                        changeTT = true;
                        keyupdates += "Xã nhận;";
                        valueupdates += item.AcceptWardCode + " => " + input.AcceptWardCode + "|";
                    }
                    item.AcceptWardCode = input.AcceptWardCode;

                    if (item.AcceptMan != input.AcceptMan)
                    {
                        changeTT = true;
                        keyupdates += "Người nhận;";
                        valueupdates += item.AcceptMan + " => " + input.AcceptMan + "|";
                    }
                    item.AcceptMan = input.AcceptMan;
                    item.AcceptManUs = UnSigns(item.AcceptMan);

                    if (item.AcceptManPhone != input.AcceptManPhone)
                    {
                        changeTT = true;
                        keyupdates += "SĐT nhận;";
                        valueupdates += item.AcceptManPhone + " => " + input.AcceptManPhone + "|";
                    }
                    item.AcceptManPhone = input.AcceptManPhone;

                    if (item.AcceptManAddress != input.AcceptManAddress)
                    {
                        changeTT = true;
                    }
                    item.AcceptManAddress = input.AcceptManAddress;

                    if (item.AcceptProvince != input.AcceptProvince)
                    {
                        changeTT = true;
                    }
                    item.AcceptProvince = input.AcceptProvince;

                    if (item.AcceptDistrict != input.AcceptDistrict)
                    {
                        changeTT = true;
                    }
                    item.AcceptDistrict = input.AcceptDistrict;

                    if (item.AcceptWard != input.AcceptWard)
                    {
                        changeTT = true;
                    }
                    item.AcceptWard = input.AcceptWard;

                    item.LastUpdateDate = currentDate;
                    item.LastUpdateUser = input.LastUpdateUser;
                    item.IsReceiveBill = input.IsReceiveBill;

                    item.Note = input.Note;
                    item.SystemDate = currentDate;
                    item.BT3Type = input.BT3Type;

                    GExpProvider provider = dc.GExpprovider.GetObject(base.ConnectionData.Schema, input.BT3Type);
                    if (provider != null)
                    {

                        item.BT3Type = provider.ProviderTypeCode;
                    }
                    item.GoodsName = input.GoodsName;

                    if (item.GoodsNumber != input.GoodsNumber)
                    {
                        keyupdates += "Số lượng kiện;";
                        valueupdates += item.GoodsNumber.ToString("N0") + " => " + input.GoodsNumber.ToString("N0") + "|";
                    }
                    item.GoodsNumber = input.GoodsNumber;
                    item.GoodsCode = input.GoodsCode;
                    item.GoodsW = input.GoodsW;
                    item.GoodsH = input.GoodsH;
                    item.GoodsL = input.GoodsL;
                    item.FK_Customer = input.FK_Customer;
                    if (string.IsNullOrEmpty(item.BT3Code))
                    {
                        if (item.FK_ProviderAccount != input.FK_ProviderAccount)
                        {
                            keyupdates += "Nhà VC;";
                            valueupdates += item.FK_ProviderAccount + " => " + input.FK_ProviderAccount + "|";
                        }

                        item.FK_ProviderAccount = input.FK_ProviderAccount;
                    }

                    item.FK_PaymentType = input.FK_PaymentType;

                    if (item.FK_ShipType != input.FK_ShipType)
                    {
                        changeTT = true;
                        keyupdates += "Loại;";
                        valueupdates += item.FK_ShipType + " => " + input.FK_ShipType + "|";
                    }
                    item.FK_ShipType = input.FK_ShipType;

                    item.Pickup = input.Pickup;
                    item.ProvincePickup = input.ProvincePickup;
                    item.DistricPickup = input.DistricPickup;
                    item.WardPickup = input.WardPickup;
                    item.AddressPickup = input.AddressPickup;
                    item.ShopIdPickup = input.ShopIdPickup;
                    item.IsReceiveBill = input.IsReceiveBill;
                    item.NamePickup= input.NamePickup;
                    item.PhonePickup = input.PhonePickup;
                    //Change Database
                    dc.GExpbill.Update(base.ConnectionData.Schema, item);

                    // Thêm dòng history
                    if (!string.IsNullOrEmpty(keyupdates))
                    {
                        GExpBillHistory history = new GExpBillHistory();
                        history.Id = Guid.NewGuid().ToString();
                        history.UpdateDate = currentDate;
                        history.BillCode = item.BillCode;
                        history.FK_Post = input.RegisterSiteCode;
                        history.FK_Account = input.LastUpdateUser;
                        history.BeforeUpdate = keyupdates.TrimEnd(';');
                        history.AfterUpdate = valueupdates.TrimEnd('|');
                        dc.GExpbillhistory.InsertOnSubmit(base.ConnectionData.Schema, history);
                    }

                    GExpAccept accept = dc.GExpaccept.GetObjectCon(base.ConnectionData.Schema, "WHERE AcceptPhone=@AcceptPhone", "@AcceptPhone", input.AcceptManPhone.Trim());
                    if (accept == null)
                    {
                        accept = new GExpAccept();
                        accept.Id = Guid.NewGuid().ToString();
                        accept.AcceptMan = input.AcceptMan;
                        accept.AcceptPhone = input.AcceptManPhone;
                        accept.AcceptAddress = input.AcceptManAddress;
                        accept.AcceptAddressFull = input.AcceptManAddress + "," + input.AcceptWard + "," + input.AcceptDistrict + "," + input.AcceptProvince;
                        accept.AcceptProvince = input.AcceptProvinceCode;
                        accept.AcceptDistrict = input.AcceptDistrictCode;
                        accept.AcceptWard = input.AcceptWardCode;
                        accept.AcceptLevel = 0;
                        dc.GExpaccept.InsertOnSubmit(base.ConnectionData.Schema, accept);
                    }
                    else
                    {
                        accept.AcceptMan = input.AcceptMan;
                        accept.AcceptAddress = input.AcceptManAddress;
                        accept.AcceptAddressFull = input.AcceptManAddress + "," + input.AcceptWard + "," + input.AcceptDistrict + "," + input.AcceptProvince;
                        accept.AcceptProvince = input.AcceptProvinceCode;
                        accept.AcceptDistrict = input.AcceptDistrictCode;
                        accept.AcceptWard = input.AcceptWardCode;
                        dc.GExpaccept.Update(base.ConnectionData.Schema, accept);
                    }
                    if (input.FK_Customer == "0000")
                    {
                        // Tạo danh bạ sender
                        GExpSender sender = dc.GExpsender.GetObjectCon(base.ConnectionData.Schema, "WHERE SendManPhone=@SendManPhone", "@SendManPhone", input.SendManPhone.Trim());
                        if (sender == null)
                        {
                            sender = new GExpSender();
                            sender.Id = Guid.NewGuid().ToString();
                            sender.SendMan = input.SendMan;
                            sender.SendManPhone = input.SendManPhone;
                            sender.SendAddress = input.SendManAddress;
                            dc.GExpsender.InsertOnSubmit(base.ConnectionData.Schema, sender);
                        }
                        else
                        {
                            sender.SendMan = input.SendMan;
                            sender.SendManPhone = input.SendManPhone;
                            sender.SendAddress = input.SendManAddress;
                            if (sender.SendMan != input.SendMan || sender.SendManPhone != input.SendManPhone || sender.SendAddress != input.SendManAddress)
                            {
                                dc.GExpsender.Update(base.ConnectionData.Schema, sender);
                            }

                        }
                    }

                    dc.SubmitChanges();
                    return Tuple.Create(true, changeCOD, changeTT);
                }
                else
                {
                    return Tuple.Create(false, false, false);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Delete GExpBill
        /// </summary>
        public async Task<bool> Delete(String BillCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpBill item = dc.GExpbill.GetObject(base.ConnectionData.Schema, BillCode);
                if (item != null)
                {
                    // Xóa các hành trình
                    dc.GExpscan.DeleteOnSubmitCon(base.ConnectionData.Schema, "WHERE BillCode=@BillCode", "@BillCode", BillCode);
                    dc.GExpproblem.DeleteOnSubmitCon(base.ConnectionData.Schema, "WHERE BillCode=@BillCode", "@BillCode", BillCode);
                    //Delete master
                    dc.GExpbill.DeleteOnSubmit(base.ConnectionData.Schema, BillCode);
                    dc.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Tạo mã đơn hàng
        /// </summary>
        /// <param name="ExpPostId">Trạm tạo đơn</param>
        /// <returns></returns>
        public string ExpGetCode(string ExpPostId)
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpCode queueNumber = dc.GExpcode.GetObjectCon(ConnectionData.Schema, "WHERE Id=@Id",
                    "@Id", ExpPostId);
                if (queueNumber == null)
                {
                    queueNumber = new GExpCode();
                    queueNumber.Id = ExpPostId;
                    queueNumber.CurrentValue = 1;
                    queueNumber.Post = "A";
                    dc.GExpcode.InsertOnSubmit(ConnectionData.Schema, queueNumber);
                }
                else
                {
                    queueNumber.CurrentValue = queueNumber.CurrentValue + 1;
                    dc.GExpcode.Update(ConnectionData.Schema, queueNumber);
                }
                dc.SubmitChanges();
                return queueNumber.Post + queueNumber.CurrentValue.ToString().PadLeft(6, '0');
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }

        }

        public async Task<List<GExpBillStatus>> GetGExpBillStatus()
        {
            List<GExpBillStatus> ls = new List<GExpBillStatus>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.GExpbillstatus.GetListObjectCon(ConnectionData.Schema, "ORDER BY Id");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
            return ls;
        }
        public async Task<List<GExpProvince>> GetDanhSachTinh()
        {
            List<GExpProvince> ls = new List<GExpProvince>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.GExpprovince.GetListObjectCon(ConnectionData.Schema, "ORDER BY ProvinceName");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
            return ls;
        }
        public async Task<GExpProvince> GetDanhTinhById(int TinhId)
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExpprovince.GetObject(ConnectionData.Schema, TinhId);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<List<GExpDistrict>> GetDanhSachHuyen(string idTinh)
        {
            List<GExpDistrict> ls = new List<GExpDistrict>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.GExpdistrict.GetListObjectCon(ConnectionData.Schema, "WHERE ProvinceID=@ProvinceID ORDER BY DistrictName", "@ProvinceID", idTinh);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
            return ls;
        }
        public async Task<List<GExpWard>> GetDanhSachXa(string idHuyen)
        {
            List<GExpWard> ls = new List<GExpWard>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.GExpward.GetListObjectCon(ConnectionData.Schema, "WHERE DistrictID=@DistrictID ORDER BY WardName", "@DistrictID", idHuyen);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
            return ls;
        }
        public async Task<List<GExpShipNoteType>> GetDanhSachGiaoHang()
        {
            List<GExpShipNoteType> ls = new List<GExpShipNoteType>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.GExpshipnotetype.GetListObject(ConnectionData.Schema);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
            return ls;
        }
        public async Task<List<GExpProvider>> GetDanhSachProvider(string post)
        {
            List<GExpProvider> ls = new List<GExpProvider>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.GExpprovider.GetListObjectCon(ConnectionData.Schema, "WHERE Post=@Post AND IsDelete=@IsDelete ORDER BY SelectIndex", "@Post", post, "@IsDelete", false);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
            return ls;
        }
        public async Task<List<GExpPaymentType>> GetDanhSachThanhToan()
        {
            List<GExpPaymentType> ls = new List<GExpPaymentType>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.GExppaymenttype.GetListObject(ConnectionData.Schema);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
            return ls;
        }
        public async Task<view_ExpConsignmentObject> GetExpConsignmentObject(string Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpconsignmentobject.GetObjectCon(base.ConnectionData.Schema, "WHERE Id=@Id", "@Id", Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public GExpAccept GetThongTinNguoiNhan(string SoDienThoai)
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExpaccept.GetObjectCon(ConnectionData.Schema, "WHERE AcceptPhone=@AcceptPhone", "@AcceptPhone", SoDienThoai);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }
        public ExpCustomer GetThongTinKhachHang(string SoDienThoai, string post)
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpcustomer.GetObjectCon(ConnectionData.Schema, "WHERE CustomerPhone=@CustomerPhone AND FK_Post=@FK_Post", "@CustomerPhone", SoDienThoai, "@FK_Post", post);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }
        public GExpSender GetThongTinKhachHangLe(string SoDienThoai, string post)
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExpsender.GetObjectCon(ConnectionData.Schema, "WHERE SendManPhone=@SendManPhone", "@SendManPhone", SoDienThoai);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }
        public ExpCustomer GetThongTinKhachHangById(string Id)
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpcustomer.GetObject(ConnectionData.Schema, Id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }
        public List<ExpCustomer> GetCustomerListFilter(string postID, string keyword = "")
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpCustomer> list = new List<ExpCustomer>();
                if (string.IsNullOrEmpty(keyword))
                {
                    ExpCustomer cus = new ExpCustomer();
                    cus.Id = "9999";
                    cus.CustomerName = "Tất cả";
                    list.Add(cus);
                    cus = new ExpCustomer();
                    cus.Id = "0000";
                    cus.CustomerName = "Khách lẻ";
                    list.Add(cus);
                }
                // Search
                string searchKey = UnSigns(keyword);
                List<ExpCustomer> temp = dc.EXpcustomer.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post AND (UnsigName LIKE '%" + searchKey + "%' OR CustomerPhone LIKE '%" + searchKey + "%' OR CustomerName LIKE N'%" + keyword + "%') ORDER BY CustomerName", "@FK_Post", postID);
                foreach (var item in temp)
                {
                    item.CustomerName = item.CustomerName + " - " + item.CustomerPhone;
                    list.Add(item);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }

        public List<view_GExpFeeDetails> GetFeeDetails(string post, string FeeId = "")
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                if (string.IsNullOrEmpty(FeeId))
                {
                    return dc.VIewgexpfeedetails.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post AND DefaultFee=@DefaultFee",
                        "@FK_Post", post,
                        "@DefaultFee", true);
                }
                else
                {
                    return dc.VIewgexpfeedetails.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post AND FK_GExpFee=@FK_GExpFee",
                        "@FK_Post", post,
                        "@FK_GExpFee", FeeId);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public List<view_GExpFeeDetailsPro> GetProvinceFeeDetails(string post, int ProvineId, string district, string FeeId = "")
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                if (string.IsNullOrEmpty(FeeId))
                {
                    return dc.VIewgexpfeedetailspro.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post AND DefaultFee=@DefaultFee AND ProvineId=@ProvineId AND District LIKE '%" + district + "%'",
                        "@FK_Post", post,
                        "@DefaultFee", true,
                        "@ProvineId", ProvineId);
                }
                else
                {
                    return dc.VIewgexpfeedetailspro.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post AND FK_GExpFee=@FK_GExpFee AND ProvineId=@ProvineId AND District LIKE '%" + district + "%'",
                        "@FK_Post", post,
                        "@FK_GExpFee", FeeId,
                        "@ProvineId", ProvineId);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public List<view_GExpNotification> GetNotifyListUnProcess(string post, string loaiKien, string khachHang)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = string.Empty;
                if (loaiKien != "9999")
                {
                    condition += " AND FK_ProviderAccount='" + loaiKien + "'";
                }
                if (khachHang != "9999")
                {
                    condition += " AND FK_Customer='" + khachHang + "'";
                }
                return dc.VIewgexpnotification.GetListObjectCon(base.ConnectionData.Schema, "WHERE RegisterSiteCode=@RegisterSiteCode AND (FK_AccountRead IS NULL OR FK_AccountRead='') " + condition + " ORDER BY CreateDate", "@RegisterSiteCode", post);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public List<view_GExpNotification> GetNotifyListProcessed(string post, string khachHang, DateTime from, DateTime to)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = string.Empty;

                if (khachHang != "9999")
                {
                    condition += " AND FK_Customer='" + khachHang + "'";
                }
                condition += " AND DateRead>='" + string.Format("{0:yyyy-MM-dd}", from) + " 00:00:00' AND DateRead<='" + string.Format("{0:yyyy-MM-dd}", to) + " 23:59:59'";
                return dc.VIewgexpnotification.GetListObjectCon(base.ConnectionData.Schema, "WHERE RegisterSiteCode=@RegisterSiteCode AND (FK_AccountRead IS NOT NULL OR FK_AccountRead<>'') " + condition + " ORDER BY CreateDate", "@RegisterSiteCode", post);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public List<GExpScanType> GetTrackTypeFilter()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();

                return dc.GExpscantype.GetListObject(base.ConnectionData.Schema);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public List<view_GExpNotification> GetNotificationList(string postID)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpnotification.GetListObjectCon(base.ConnectionData.Schema, "WHERE RegisterSiteCode=@RegisterSiteCode AND (FK_AccountRead IS NULL OR FK_AccountRead='') ORDER BY KeyDate",
                    "@RegisterSiteCode", postID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public void UpdateBT3Code(string billCode, string BT3Code)
        {
            if (string.IsNullOrEmpty(billCode))
            {
                return;
            }
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpBill bill = dc.GExpbill.GetObject(base.ConnectionData.Schema, billCode);
                if (bill != null)
                {

                    bill.BT3Code = BT3Code;

                    dc.GExpbill.Update(base.ConnectionData.Schema, bill);
                    dc.SubmitChanges();
                }
            }
            finally
            {
                dc.Close();
            }
        }
        public void ClearDataProviderAccount(string billCode, string newProviderId)
        {
            if (string.IsNullOrEmpty(billCode))
            {
                return;
            }
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpBill bill = dc.GExpbill.GetObject(base.ConnectionData.Schema, billCode);
                if (bill != null)
                {
                    bill.BT3Code = string.Empty;
                    bill.PrintData = string.Empty;
                    bill.FK_ProviderAccount = newProviderId;
                    dc.GExpbill.Update(base.ConnectionData.Schema, bill);
                    dc.SubmitChanges();
                }
            }
            finally
            {
                dc.Close();
            }
        }
        public void UpdateBT3Code(string billCode, string BT3Code, decimal BT3COD, decimal BT3Frieght, string BT3SubCode, string printData)
        {
            if (string.IsNullOrEmpty(billCode) || string.IsNullOrEmpty(BT3Code))
            {
                return;
            }
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpBill bill = dc.GExpbill.GetObject(base.ConnectionData.Schema, billCode);
                if (bill != null)
                {
                    bill.BT3Code = BT3Code;
                    bill.BT3Freight = BT3Frieght;
                    bill.BT3CodeSub = BT3SubCode;
                    bill.BT3COD = BT3COD;
                    bill.PrintData = printData;
                    dc.GExpbill.Update(base.ConnectionData.Schema, bill);
                    dc.SubmitChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }
        public void UpdateShopId(string billCode, string shopId)
        {

            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpBill bill = dc.GExpbill.GetObject(base.ConnectionData.Schema, billCode);
                if (bill != null)
                {
                    bill.ShopIdPickup = shopId;
                    dc.GExpbill.Update(base.ConnectionData.Schema, bill);
                    // Customer
                    ExpCustomer customer = dc.EXpcustomer.GetObject(base.ConnectionData.Schema, bill.FK_Customer);
                    if (customer != null && customer.Id != "0000")
                    {
                        customer.ShopIDPickup = shopId;
                        customer.IsPickup = true;
                        customer.ProvinceId = Int32.Parse(bill.ProvincePickup);
                        customer.DistrictId = Int32.Parse(bill.DistricPickup);
                        customer.WardId = bill.WardPickup;

                        dc.EXpcustomer.Update(base.ConnectionData.Schema, customer);
                    }
                    dc.SubmitChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }
        public void UpdateBT3LastMess(string billCode, string message)
        {
            if (string.IsNullOrEmpty(billCode) || string.IsNullOrEmpty(message))
            {
                return;
            }
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpBill bill = dc.GExpbill.GetObject(base.ConnectionData.Schema, billCode);
                if (bill != null)
                {
                    bill.BT3LastMess = message;
                    dc.GExpbill.Update(base.ConnectionData.Schema, bill);
                    dc.SubmitChanges();
                }
            }
            finally
            {
                dc.Close();
            }
        }
        public void UpdateBT3Freight(string billCode, decimal Freight)
        {
            if (string.IsNullOrEmpty(billCode))
            {
                return;
            }
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpBill bill = dc.GExpbill.GetObject(base.ConnectionData.Schema, billCode);
                if (bill != null)
                {
                    bill.BT3Freight = Freight;
                    dc.GExpbill.Update(base.ConnectionData.Schema, bill);
                    dc.SubmitChanges();
                }
            }
            finally
            {
                dc.Close();
            }
        }
        private string ProcessStatusCode(string statusCode, out bool notify)
        {
            notify = false;
            string codeCheck = statusCode;
            if (codeCheck.Contains("Được gửi đến"))
            {
                codeCheck = "Được gửi đến";
            }
            else if (codeCheck.Contains("Đến nơi"))
            {
                codeCheck = "Đến nơi";
            }
            else if (codeCheck.Contains("Đang giao hàng"))
            {
                codeCheck = "Đang giao hàng";
            }
            else if (codeCheck.Contains("Ký nhận"))
            {
                codeCheck = "Ký nhận";
            }
            else if (codeCheck.Contains("Giao hàng không thành công"))
            {
                notify = true;
                codeCheck = "Giao hàng không thành công";
            }
            else if (codeCheck.Contains("kiện vấn đề"))
            {
                notify = true;
                codeCheck = "kiện vấn đề";
            }
            else if (codeCheck.Contains("delivery_fail"))
            {
                notify = true;
            }
            else if (codeCheck.Contains("B604"))
            {
                notify = true;
            }
            return codeCheck;
        }
        public void UpdateTracking(string billCode, OutTrackingResultGHN trackingLogs, List<GExpBillStatusName> lsStatus)
        {

            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpBill bill = dc.GExpbill.GetObject(base.ConnectionData.Schema, billCode);
                if (bill == null)
                {
                    // Thử lấy mã BT3
                    bill = dc.GExpbill.GetObjectCon(base.ConnectionData.Schema, "WHERE BT3Code=@BT3Code", "@BT3Code", billCode);
                }
                if (bill != null)
                {
                    billCode = bill.BillCode;
                    // Update status
                    OutTrackingLogGHN lastTracking = null;
                    foreach (var item in trackingLogs.outTrackingLogs.OrderBy(o => o.ActionDateTime))
                    {
                        bool isNotify = false;
                        string codeCheck = ProcessStatusCode(item.StatusCode, out isNotify);

                        GExpBillStatusName statusName = lsStatus.FirstOrDefault(u => u.StatusName.Contains(codeCheck));
                        if (statusName == null)
                        {
                            GExpError error = dc.GExperror.GetObjectCon(base.ConnectionData.Schema, "WHERE ErrorName=@ErrorName", "@ErrorName", item.StatusCode);
                            if (error == null)
                            {
                                error = new GExpError();
                                error.Id = Guid.NewGuid().ToString();
                                error.ErrorName = item.StatusCode;
                                error.Provider = item.ProviderName;
                                error.BillCode = billCode;
                                error.BT3Code = bill.BT3Code;
                                error.Note = item.Note;
                                dc.GExperror.InsertOnSubmit(base.ConnectionData.Schema, error);
                            }

                        }
                        if (statusName != null && statusName.Id != "00")
                        {
                            // chỉ những trạng thái nó nằm trong list mới được tính là lastracking
                            lastTracking = item;
                            GExpScan scan = dc.GExpscan.GetObjectCon(base.ConnectionData.Schema, "WHERE BillCode=@BillCode AND TypeScan=@TypeScan AND CreateDate='" + string.Format("{0:yyyy-MM-dd HH:mm}", item.ActionDateTime) + "'",
                                "@BillCode", bill.BillCode,
                                "@TypeScan", statusName.Id);
                            if (scan == null)
                            {
                                scan = new GExpScan();
                                scan.Id = Guid.NewGuid().ToString();
                                scan.Post = "Hệ thống";
                                scan.CreateDate = item.ActionDateTime;
                                scan.KeyDate = item.ActionDate;
                                scan.IsRead = false;
                                scan.TypeScan = statusName.ScanType;
                                scan.BillCode = bill.BillCode;
                                scan.UserCreate = "admin";
                                scan.NameCreate = item.ProviderName;
                                scan.ProblemType = 0;
                                scan.Note = item.Note.Replace("177 Nguyễn Văn Phát", "");
                                dc.GExpscan.InsertOnSubmit(base.ConnectionData.Schema, scan);

                                // Insert kiện vấn đề hay cảnh báo cho người chăm sóc đơn
                                if (isNotify || statusName.ScanType.Equals("PROB"))
                                {
                                    GExpNotification notify = dc.GExpnotification.GetObjectCon(base.ConnectionData.Schema, "WHERE KeyDate=@KeyDate AND BillCode=@BillCode",
                                        "@KeyDate", string.Format("{0:yyyy-MM-dd HH:mm}", item.ActionDateTime),
                                        "@BillCode", bill.BillCode);
                                    if (notify == null)
                                    {
                                        notify = new GExpNotification();
                                        notify.Id = Guid.NewGuid().ToString();
                                        notify.BillCode = bill.BillCode;
                                        notify.KeyDate = string.Format("{0:yyyy-MM-dd HH:mm}", item.ActionDateTime);
                                        notify.CreateDate = item.ActionDateTime;
                                        notify.Note = item.Note;
                                        dc.GExpnotification.InsertOnSubmit(base.ConnectionData.Schema, notify);
                                    }
                                    GExpProblem problem = dc.GExpproblem.GetObjectCon(base.ConnectionData.Schema, "WHERE RegisterDate=@RegisterDate AND BillCode=@BillCode",
                                        "@RegisterDate", string.Format("{0:yyyy-MM-dd HH:mm}", item.ActionDateTime),
                                        "@BillCode", bill.BillCode);
                                    if (problem == null)
                                    {
                                        problem = new GExpProblem();
                                        problem.Id = Guid.NewGuid().ToString();
                                        problem.BillCode = bill.BillCode;
                                        problem.RegisterDate = item.ActionDateTime;
                                        problem.Note = item.Note;
                                        problem.UserId = "System";
                                        problem.FullName = "Lê Mai System";
                                        dc.GExpproblem.InsertOnSubmit(base.ConnectionData.Schema, problem);
                                    }
                                }
                            }
                        }
                    }
                    // update trạng thái theo last tracking
                    if (lastTracking != null)
                    {
                        // Chưa có đổi mã lastracking nên bị lỗi không cập nhật
                        bool isNotify = false;
                        string codeCheck = ProcessStatusCode(lastTracking.StatusCode, out isNotify);
                        GExpBillStatusName lastST = lsStatus.FirstOrDefault(u => u.StatusName.Contains(codeCheck));
                        if (lastST != null && lastST.UpdateStatus == true)
                        {
                            bill = dc.GExpbill.GetObject(base.ConnectionData.Schema, billCode);
                            if (bill != null)
                            {
                                if (lastST.BillStatus > bill.BillStatus)
                                {
                                    bill.BillStatus = lastST.BillStatus;
                                    if (bill.BillStatus == 6)
                                    {
                                        bill.IsSigned = true;
                                        bill.SignedDate = lastTracking.ActionDateTime;
                                    }
                                    else if (bill.BillStatus == 8)
                                    {
                                        bill.IsSigned = true;
                                        bill.SignedDate = lastTracking.ActionDateTime;
                                        bill.IsReturn = true;
                                    }
                                    dc.GExpbill.Update(base.ConnectionData.Schema, bill);
                                }
                            }
                        }
                    }
                    dc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public view_GExpBillGHNApi GetDetailGHNApi(String BillCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpbillghnapi.GetObjectCon(base.ConnectionData.Schema, " WHERE BillCode=@BillCode ", "@BillCode", BillCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public view_GExpBillGHNApi GetDetailTrackingGHNApi()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpbillghnapi.GetObjectCon(base.ConnectionData.Schema, " WHERE RunMode=1 AND (BT3Code IS NOT NULL OR BT3Code<>'') AND BillStatus NOT IN (2,6,8) AND RegisterDate>'" + string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddMonths(-2)) + " 00:00:00' AND RegisterDate<'" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now.AddHours(-4)) + "' ORDER BY SystemDate");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public view_GExpBillGHNApi GetDetailTrackingGHNNoneApi()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpbillghnapi.GetObjectCon(base.ConnectionData.Schema, " WHERE RunMode=2 AND (BT3Code IS NOT NULL OR BT3Code<>'') AND BillStatus NOT IN (0,2,6,8) ORDER BY SystemDate");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public void UpdateSystemDateTracking(string billCode, string message)
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpBill bill = dc.GExpbill.GetObject(base.ConnectionData.Schema, billCode);
                if (bill != null)
                {
                    bill.SystemDate = dc.CurrentTime();
                    bill.BT3LastMess = message;
                    dc.GExpbill.Update(base.ConnectionData.Schema, bill);
                    dc.SubmitChanges();
                }
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Lấy đường dẫn check đơn hàng
        /// </summary>
        /// <param name="providerId"></param>
        /// <returns></returns>
        public string GetLinkCheckBT3(string providerId)
        {
            string link = "{0}";
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpProvider provider = dc.GExpprovider.GetObject(base.ConnectionData.Schema, providerId);
                if (provider != null)
                {
                    link = provider.TrackLink;
                }
            }
            finally
            {
                dc.Close();
            }
            return link;
        }
        public async Task<int> AddTrack(string BillCode, string note, string TrackType, string UserId, string FullName, string post, DateTime currentDate)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Thêm vào hành trình
                GExpScan scan = new GExpScan();
                scan.Id = Guid.NewGuid().ToString();
                scan.BillCode = BillCode;
                scan.CreateDate = currentDate;
                scan.IsRead = false;
                scan.KeyDate = string.Format("{0:yyyy-MM-dd HH:mm:ss}", currentDate);
                scan.NameCreate = FullName;
                scan.UserCreate = UserId;
                scan.Post = post;
                scan.TypeScan = TrackType;
                scan.ProblemType = 0;
                scan.Note = note;
                dc.GExpscan.InsertOnSubmit(base.ConnectionData.Schema, scan);
                List<GExpScan> ls = dc.GExpscan.GetListObjectCon(base.ConnectionData.Schema, "WHERE BillCode=@BillCode", "@BillCode", BillCode);
                dc.SubmitChanges();

                return ls.Count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        
        /// <summary>
        /// Thêm kiện vấn đề cho đơn hàng
        /// </summary>
        /// <param name="BillCode"></param>
        /// <param name="note"></param>
        /// <param name="UserId"></param>
        /// <param name="FullName"></param>
        /// <returns>Tổng số lượng kiện vấn đề của đơn hàng</returns>
        public async Task<int> AddProblem(string BillCode, string note, string UserId, string FullName, string post, DateTime currentDate)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpProblem problem = new GExpProblem();
                problem.Id = Guid.NewGuid().ToString();
                problem.BillCode = BillCode;
                problem.RegisterDate = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, currentDate.Hour, currentDate.Minute, 0, 0);
                problem.Note = note;
                problem.UserId = UserId;
                problem.FullName = FullName;
                dc.GExpproblem.InsertOnSubmit(base.ConnectionData.Schema, problem);
                // Thêm vào hành trình
                GExpScan scan = new GExpScan();
                scan.Id = Guid.NewGuid().ToString();
                scan.BillCode = BillCode;
                scan.CreateDate = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, currentDate.Hour, currentDate.Minute, 0, 0);
                scan.IsRead = false;
                scan.KeyDate = problem.Id;
                scan.NameCreate = FullName;
                scan.UserCreate = UserId;
                scan.Post = post;
                scan.TypeScan = "PROB";
                scan.ProblemType = 1;
                scan.Note = MakeNotForScan(scan.TypeScan, scan.BillCode, scan.NameCreate, note);
                dc.GExpscan.InsertOnSubmit(base.ConnectionData.Schema, scan);
                List<GExpProblem> ls = dc.GExpproblem.GetListObjectCon(base.ConnectionData.Schema, "WHERE BillCode=@BillCode", "@BillCode", BillCode);
                dc.SubmitChanges();

                return ls.Count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<List<view_GExpProblem>> GetListProblem(String billCode, string customerId, string postId, DateTime from, DateTime to)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = "WHERE RegisterSiteCode='" + postId + "' AND RegisterDate>='" + string.Format("{0:yyyy-MM-dd}", from) + " 00:00:00' AND RegisterDate<='" + string.Format("{0:yyyy-MM-dd}", to) + " 23:59:59' &";
                if (customerId != "9999")
                {
                    condition += " FK_Customer='" + customerId + "' &";
                }
                if (!string.IsNullOrEmpty(billCode))
                {
                    condition += " BillCode='" + billCode + "' &";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                condition = condition + " ORDER BY RegisterDate desc";
                return dc.VIewgexpproblem.GetListObjectCon(base.ConnectionData.Schema, condition);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<List<view_GExpProblem>> GetListProblem(String billCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpproblem.GetListObjectCon(base.ConnectionData.Schema, "WHERE BillCode='" + billCode + "' ORDER BY RegisterDate desc");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<List<view_ExpComment>> GetListComment(String billCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpcomment.GetListObjectCon(base.ConnectionData.Schema, "WHERE BillCode='" + billCode + "' ORDER BY UpdateDate desc");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<List<view_GExpBillHistory>> GetListHistory(String billCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpbillhistory.GetListObjectCon(base.ConnectionData.Schema, "WHERE BillCode='" + billCode + "' ORDER BY UpdateDate asc");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<List<view_GExpScan>> GetListTrack(String billCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpscan.GetListObjectCon(base.ConnectionData.Schema, "WHERE BillCode='" + billCode + "' ORDER BY CreateDate desc");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<List<view_GExpScan>> GetListTrack(String billCode, string customerId, string postId, DateTime from, DateTime to)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = "WHERE RegisterSiteCode='" + postId + "' AND CreateDate>='" + string.Format("{0:yyyy-MM-dd}", from) + " 00:00:00' AND CreateDate<='" + string.Format("{0:yyyy-MM-dd}", to) + " 23:59:59' &";
                if (customerId != "9999")
                {
                    condition += " FK_Customer='" + customerId + "' &";
                }
                if (!string.IsNullOrEmpty(billCode))
                {
                    condition += " BillCode='" + billCode + "' &";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                condition = condition + " ORDER BY CreateDate desc";
                return dc.VIewgexpscan.GetListObjectCon(base.ConnectionData.Schema, condition);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<List<view_GExpScan>> GetListSigned(String billCode, string customerId, string postId, DateTime from, DateTime to)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = "WHERE TypeScan ='TRACK8' AND FK_ProviderAccount LIKE 'LM%' AND RegisterSiteCode='" + postId + "' AND CreateDate>='" + string.Format("{0:yyyy-MM-dd}", from) + " 00:00:00' AND CreateDate<='" + string.Format("{0:yyyy-MM-dd}", to) + " 23:59:59' &";
                if (customerId != "9999")
                {
                    condition += " FK_Customer='" + customerId + "' &";
                }
                if (!string.IsNullOrEmpty(billCode))
                {
                    condition += " BillCode='" + customerId + "' &";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                condition = condition + " ORDER BY CreateDate desc";
                return dc.VIewgexpscan.GetListObjectCon(base.ConnectionData.Schema, condition);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<int> DeleteSigned(string Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();
                GExpScan scan = dc.GExpscan.GetObject(base.ConnectionData.Schema, Id);
                if (scan != null)
                {
                    GExpBill bill = dc.GExpbill.GetObject(base.ConnectionData.Schema, scan.BillCode);
                    if (bill != null)
                    {
                        bill.BillStatus = 5;// Đang vận chuyển vậy
                        dc.GExpbill.Update(base.ConnectionData.Schema, bill);
                    }
                    dc.GExpscan.DeleteOnSubmit(base.ConnectionData.Schema, scan);
                    List<GExpScan> ls = dc.GExpscan.GetListObjectCon(base.ConnectionData.Schema, "WHERE BillCode=@BillCode", "@BillCode", scan.BillCode);
                    dc.SubmitChanges();
                    return ls.Count;
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<int> DeleteTrack(string Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();
                GExpScan scan = dc.GExpscan.GetObject(base.ConnectionData.Schema, Id);
                if (scan != null)
                {
                    dc.GExpscan.DeleteOnSubmit(base.ConnectionData.Schema, scan);
                    List<GExpScan> ls = dc.GExpscan.GetListObjectCon(base.ConnectionData.Schema, "WHERE BillCode=@BillCode", "@BillCode", scan.BillCode);
                    dc.SubmitChanges();
                    return ls.Count;
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }

        public async Task<int> DeleteProblem(string Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();
                GExpProblem problem = dc.GExpproblem.GetObject(base.ConnectionData.Schema, Id);
                if (problem != null)
                {
                    GExpScan scan = dc.GExpscan.GetObjectCon(base.ConnectionData.Schema, "WHERE KeyDate=@KeyDate", "@KeyDate", problem.Id);
                    if (scan != null)
                    {
                        dc.GExpscan.DeleteOnSubmit(base.ConnectionData.Schema, scan);
                    }
                    dc.GExpproblem.DeleteOnSubmit(base.ConnectionData.Schema, problem);
                }
                List<GExpProblem> ls = dc.GExpproblem.GetListObjectCon(base.ConnectionData.Schema, "WHERE BillCode=@BillCode", "@BillCode", problem.BillCode);
                dc.SubmitChanges();

                return ls.Count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }

        public List<view_GExpBill> GetThongKeCOD(string customerId, DateTime from, DateTime to)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = "WHERE FK_Customer='" + customerId + "' AND RegisterDate>='" + string.Format("{0:yyyy-MM-dd}", from) + " 00:00:00' AND RegisterDate<='" + string.Format("{0:yyyy-MM-dd}", to) + " 23:59:59'";
                return dc.VIewgexpbill.GetListObjectCon(base.ConnectionData.Schema, condition);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public List<GExpScan> GetScanExp(string BillCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = "WHERE BillCode='" + BillCode + "'";
                return dc.GExpscan.GetListObjectCon(base.ConnectionData.Schema, condition);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }

        public List<GExpBillStatus> GetColortChartPieThongKe()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExpbillstatus.GetListObject(base.ConnectionData.Schema);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }


        public List<view_GExpBill> GetListCOD(string customerId, bool isTabSiged)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = string.Empty;
                if (isTabSiged)
                {
                    condition = "WHERE FK_Customer='" + customerId + "'" + "  AND IsSigned = 1 AND  IsPayCustomer = 1";
                }
                else
                {
                    condition = "WHERE FK_Customer='" + customerId + "'" + "  AND IsSigned = 1 AND  IsPayCustomer = 0";
                }

                return dc.VIewgexpbill.GetListObjectCon(base.ConnectionData.Schema, condition);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }

        public List<view_GExpBill> GetListVanDon(string customerId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = "WHERE FK_Customer='" + customerId + "'";
                return dc.VIewgexpbill.GetListObjectCon(base.ConnectionData.Schema, condition);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public List<view_GExpBillGHNApi> GetListBillApiByListIds(String ids)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpbillghnapi.GetListObjectCon(base.ConnectionData.Schema, " WHERE BillCode IN (" + ids + ")");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public AddressOutMapping GetMappingFromAddress(string address)
        {
            AddressOutMapping map = new AddressOutMapping();
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<GExpProvince> ls = dc.GExpprovince.GetListObject(base.ConnectionData.Schema);
                foreach (var item in ls)
                {
                    if (address.Contains(item.ProvinceName))
                    {
                        map.AcceptProvince = item.ProvinceName;
                        map.AcceptProvinceCode = item.ProvinceID;
                        break;
                    }
                }
                if (!string.IsNullOrEmpty(map.AcceptProvince))
                {
                    List<GExpDistrict> lsDist = dc.GExpdistrict.GetListObjectCon(base.ConnectionData.Schema, "WHERE ProvinceID=@ProvinceID", "@ProvinceID", map.AcceptProvinceCode);
                    foreach (var disc in lsDist)
                    {
                        if (address.Contains(disc.DistrictName))
                        {
                            map.AcceptDistrictCode = disc.DistrictID;
                            map.AcceptDistrict = disc.DistrictName;
                            break;
                        }
                    }
                    if (!string.IsNullOrEmpty(map.AcceptDistrict))
                    {
                        List<GExpWard> lsWard = dc.GExpward.GetListObjectCon(base.ConnectionData.Schema, "WHERE DistrictID=@DistrictID", "@DistrictID", map.AcceptDistrictCode);
                        foreach (var ward in lsWard)
                        {
                            if (address.Contains(ward.WardName))
                            {
                                map.AcceptWard = ward.WardName;
                                map.AcceptWardCode = ward.WardId;
                                break;
                            }
                        }
                        if (string.IsNullOrEmpty(map.AcceptWard))
                        {
                            map.AcceptWard = "X. Tân Quy Tây";
                            map.AcceptWardCode = "81812";
                        }
                    }
                    else
                    {
                        map.AcceptDistrictCode = 8180;
                        map.AcceptDistrict = "TP. Sa Đéc";
                    }
                }
                else
                {
                    map.AcceptProvince = "Tỉnh Đồng Tháp";
                    map.AcceptProvinceCode = 81;

                    map.AcceptDistrictCode = 8180;
                    map.AcceptDistrict = "TP. Sa Đéc";

                    map.AcceptWard = "X. Tân Quy Tây";
                    map.AcceptWardCode = "81812";
                }
                // Init Map nếu không tìm được data

                return map;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<view_SumGExpBill> GetAllTotalReport(string customerId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewsumgexpbill.GetObjectCon(base.ConnectionData.Schema, " WHERE FK_Customer='" + customerId + "'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<List<view_SumGExpBillStatus>> GetListTotalStatus(string customerId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewsumgexpbillstatus.GetListObjectCon(base.ConnectionData.Schema, " WHERE FK_Customer='" + customerId + "'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<List<view_SumGExpBillSanLuong>> GetListTotalSanLuong(string customerId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewsumgexpbillsanluong.GetListObjectCon(base.ConnectionData.Schema, " WHERE FK_Customer='" + customerId + "'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<List<view_SumGExpBillKyNhan>> GetListTotalKyNhan(string customerId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewsumgexpbillkynhan.GetListObjectCon(base.ConnectionData.Schema, " WHERE FK_Customer='" + customerId + "'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<List<view_GExpBillCus>> GetListCus(string postId, string customerId, string loaiKienId, string statusId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = "WHERE RegisterSiteCode='" + postId + "' AND BillStatus IN (" + statusId + ") &";
                if (customerId != "9999")
                {
                    condition += " FK_Customer='" + customerId + "' &";
                }
                if (loaiKienId != "9999")
                {
                    condition += " FK_ProviderAccount='" + loaiKienId + "' &";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                return dc.VIewgexpbillcus.GetListObjectCon(base.ConnectionData.Schema, condition);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        //
        public bool CheckTTKTScanBillCode(String billCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpScan scan = dc.GExpscan.GetObjectCon(base.ConnectionData.Schema, "WHERE TypeScan IN ('TRACK3','TRACK4','TRACK5') AND BillCode=@BillCode", "@BillCode", billCode);
                if (scan == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public GExpScan GetLastScanBillCode(String billCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExpscan.GetObjectCon(base.ConnectionData.Schema, "WHERE BillCode=@BillCode ORDER BY CreateDate desc", "@BillCode", billCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public GExpProblem GetLastKVDBillCode(String billCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExpproblem.GetObjectCon(base.ConnectionData.Schema, "WHERE BillCode=@BillCode ORDER BY RegisterDate desc", "@BillCode", billCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public ExpComment GetLastCommentBillCode(string BillCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpcomment.GetObjectCon(base.ConnectionData.Schema, "WHERE BillCode=@BillCode ORDER BY UpdateDate desc", "@BillCode", BillCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public string GetQuickReport()
        {
            string report = string.Empty;
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();

                List<ExpComment> lsComment = dc.EXpcomment.GetListObjectCon(base.ConnectionData.Schema, "WHERE UpdateDate between '" + string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(-7)) + " 00:00:00' and '" + string.Format("{0:yyyy-MM-dd}", DateTime.Now) + "  23:59:59'");
                for (int i = 0; i < 7; i++)
                {
                    DateTime dateTime = DateTime.Now.AddDays(-i);
                    List<ExpComment> subLit = lsComment.Where(u => u.UpdateDate.Date == dateTime.Date).ToList();
                    report += dateTime.Date.ToString("dd/MM/yyyy") + " (" + subLit.Count.ToString() + ")" + Environment.NewLine;
                    var q = from c in subLit
                            group c by c.Author into g
                            select new { g.Key, Count = g.Count() };
                    foreach (var item in q)
                    {
                        report += item.Key + " : " + item.Count + Environment.NewLine;
                    }
                    report += "---------------------" + Environment.NewLine;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
            return report;
        }
        public async Task<List<ExpCommentType>> GetListCommentType()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpcommenttype.GetListObject(base.ConnectionData.Schema);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<List<GExpBillStatus>> GetListBillStatusType()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExpbillstatus.GetListObjectCon(base.ConnectionData.Schema, "WHERE SelectNV=1 ORDER BY Id");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public string CommentOnBill(string billCode, string commentTypeId, string Content, string accountId)
        {
            string result = string.Empty;
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpBill bill = dc.GExpbill.GetObject(base.ConnectionData.Schema, billCode);
                if (bill != null)
                {
                    ExpComment comment = new ExpComment();
                    comment.Id = Guid.NewGuid().ToString();
                    comment.BillCode = billCode;
                    comment.Author = accountId;
                    comment.Comment = Content;
                    comment.CommentType = commentTypeId;
                    comment.UpdateDate = dc.CurrentTime();
                    dc.EXpcomment.InsertOnSubmit(base.ConnectionData.Schema, comment);
                    dc.SubmitChanges();
                    result = string.Empty;
                }
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            finally
            {
                dc.Close();
            }
            return result;
        }
        public string ChangeStausBill(string billCode, int newstatus, string accountId, string post)
        {
            string result = string.Empty;
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpBill bill = dc.GExpbill.GetObject(base.ConnectionData.Schema, billCode);
                if (bill != null)
                {
                    if (bill.BillStatus != newstatus)
                    {
                        GExpBillHistory history = new GExpBillHistory();
                        history.Id = Guid.NewGuid().ToString();
                        history.UpdateDate = dc.CurrentTime();
                        history.BillCode = bill.BillCode;
                        history.FK_Post = post;
                        history.FK_Account = accountId;
                        history.BeforeUpdate = "TT đơn hàng";
                        history.AfterUpdate = bill.BillStatus + " => " + newstatus;
                        dc.GExpbillhistory.InsertOnSubmit(base.ConnectionData.Schema, history);

                        bill.BillStatus = newstatus;
                        dc.GExpbill.Update(base.ConnectionData.Schema, bill);
                        dc.SubmitChanges();
                    }
                    result = string.Empty;
                }
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            finally
            {
                dc.Close();
            }
            return result;
        }
        public List<GExpWard> SearchWard(string key)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExpward.GetListObjectLimitCon(base.ConnectionData.Schema, "*", "WHERE SearchKey LIKE '%" + key + "%'", 20, 0);
            }
            finally
            {
                dc.Close();
            }
        }
        public GExpWard GetXaDetail(string idXa)
        {

            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExpward.GetObjectCon(ConnectionData.Schema, "WHERE WardId=@WardId", "@WardId", idXa);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<string> GetCalculatorFee(string TrongLuong, string FeeId, string TinhNhan, string post, string HuyenNhan)
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int IdTinhNhan = Int32.Parse(TinhNhan);
                int TLKhachHang = 0;
                if (!Int32.TryParse(TrongLuong, NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out TLKhachHang))
                {
                    TLKhachHang = 0;
                }

                List<view_GExpFeeDetailsPro> lsProFeeDetail = new List<view_GExpFeeDetailsPro>();

                List<view_GExpFeeDetails> lsSubFeeDetail = new List<view_GExpFeeDetails>();
                if (string.IsNullOrEmpty(FeeId) == false)
                {
                    // Khách hàng sỉ
                    lsSubFeeDetail = GetFeeDetails(post, FeeId);
                    lsProFeeDetail = GetProvinceFeeDetails(post, IdTinhNhan, HuyenNhan, FeeId);
                }
                else
                {
                    lsSubFeeDetail = GetFeeDetails(post);
                    lsProFeeDetail = GetProvinceFeeDetails(post, IdTinhNhan, HuyenNhan);
                }

                if (lsProFeeDetail.Count > 0)
                {
                    // Ưu tiên Provine
                    int MinWeight = 0;
                    int MinFee = 0;
                    int StepWeight = 0;
                    int NextFee = 0;
                    foreach (var item in lsProFeeDetail.OrderBy(u => u.MinWeight))
                    {
                        MinWeight = item.MinWeight;
                        MinFee = item.MinFee;
                        StepWeight = item.StepWeight;
                        NextFee = item.NextFee;
                        if (TLKhachHang <= MinWeight)
                        {
                            break;
                        }
                    }
                    if (TLKhachHang <= MinWeight)
                    {
                        return MinFee.ToString("N0");
                    }
                    else
                    {
                        decimal fee = ((decimal)(TLKhachHang - MinWeight) / StepWeight) * NextFee;
                        return (fee + MinFee).ToString("N0");
                    }
                }
                else if (lsSubFeeDetail.Count > 0)
                {
                    ExpPost postObject = dc.EXppost.GetObject(base.ConnectionData.Schema, post);

                    GExpProvince province = await GetDanhTinhById(IdTinhNhan);
                    if (province != null)
                    {
                        int MinWeight = 0;
                        int MinFee = 0;
                        int StepWeight = 0;
                        int NextFee = 0;
                        foreach (var item in lsSubFeeDetail.OrderBy(u => u.MinWeightInt))
                        {
                            if (province.ProvinceID == postObject.FK_DVHC)
                            {
                                // Nội tỉnh
                                MinWeight = item.MinWeightInt;
                                MinFee = item.MinFeeInt;
                                StepWeight = item.StepWeightInt;
                                NextFee = item.NextFeeInt;
                            }
                            else if (province.ZoneCode == postObject.ZoneCode)
                            {
                                // Nội miền
                                MinWeight = item.MinWeightMN;
                                MinFee = item.MinFeeMN;
                                StepWeight = item.StepWeightMN;
                                NextFee = item.NextFeeMN;
                            }
                            else
                            {
                                int zoneNhan = Int32.Parse(province.ZoneCode);
                                int zonePost = Int32.Parse(postObject.ZoneCode);
                                int zonediff = Math.Abs(zonePost - zoneNhan);
                                if (zonediff == 1)
                                {
                                    // Cận miền
                                    MinWeight = item.MinWeightMT;
                                    MinFee = item.MinFeeMT;
                                    StepWeight = item.StepWeightMT;
                                    NextFee = item.NextFeeMT;
                                }
                                else
                                {
                                    // Liên miền
                                    MinWeight = item.MinWeightMB;
                                    MinFee = item.MinFeeMB;
                                    StepWeight = item.StepWeightMB;
                                    NextFee = item.NextFeeMB;
                                }
                            }
                            // Tìm điều kiện phù hợp
                            if (TLKhachHang <= MinWeight)
                            {
                                break;
                            }
                        }
                        if (TLKhachHang <= MinWeight)
                        {
                            return MinFee.ToString("N0");
                        }
                        else
                        {
                            decimal fee = ((decimal)(TLKhachHang - MinWeight) / StepWeight) * NextFee;
                            return (fee + MinFee).ToString("N0");
                        }
                    }
                    else
                    {
                        return "0";
                    }

                }
                else
                {
                    return "0";
                }
            }
            catch (Exception)
            {
                return "0";
            }
            finally
            {
                dc.Close();
            }


        }

        public ExpPost GetPostDetail(string idPost)
        {

            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXppost.GetObject(ConnectionData.Schema, idPost);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }
    }
}

