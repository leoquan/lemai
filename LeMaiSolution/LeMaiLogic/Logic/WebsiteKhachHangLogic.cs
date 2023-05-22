using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class WebsiteKhachHangLogic : BaseLogic
    {
        public WebsiteKhachHangLogic(BaseLogicConnectionData data) : base(data)
        {

        }
        public async Task<ExpCustomer> LoginCustomer(string customerCode, string passcode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpcustomer.GetObjectCon(base.ConnectionData.Schema, "WHERE CustomerCode=@CustomerCode AND CustomerCodePass=@CustomerCodePass",
                    "@CustomerCode", customerCode,
                    "@CustomerCodePass", passcode);
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

        public async Task<string> ChangePassCustomer(string oldPass, string newPass, string Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpCustomer customer = dc.EXpcustomer.GetObject(base.ConnectionData.Schema, Id);
                if (customer != null)
                {
                    if (customer.CustomerCodePass != oldPass)
                    {
                        return "Mật khẩu hiện tại không đúng!";
                    }
                    customer.CustomerCodePass = newPass.Trim();
                    dc.EXpcustomer.Update(base.ConnectionData.Schema, customer);
                    dc.SubmitChanges();
                    return string.Empty;
                }
                else
                {
                    return "Lỗi đăng nhập";
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
        public async Task<List<view_GExpBill>> GetBillList(string customerId, string dateFrom, string dateTo, int status)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = " WHERE FK_Customer=@FK_Customer AND RegisterDate>='" + dateFrom + " 00:00:00' AND RegisterDate<='" + dateTo + " 23:59:59'";
                if (status != -1)
                {
                    condition = condition + " AND BillStatus=" + status;
                }
                condition = condition + " ORDER BY BillCode";
                return dc.VIewgexpbill.GetListObjectCon(base.ConnectionData.Schema, condition, "@FK_Customer", customerId);
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
        public async Task<List<view_GExpBill>> GetPaidBillList(string customerId, string dateFrom, string dateTo)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = " WHERE FK_Customer=@FK_Customer AND PayCustomerDate>='" + dateFrom + " 00:00:00' AND PayCustomerDate<='" + dateTo + " 23:59:59' AND IsPayCustomer=1";
                condition = condition + " ORDER BY PayCustomerDate";
                return dc.VIewgexpbill.GetListObjectCon(base.ConnectionData.Schema, condition, "@FK_Customer", customerId);
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
        public async Task<List<view_GExpBill>> GetUnPaidBillList(string customerId, string dateFrom, string dateTo)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = " WHERE FK_Customer=@FK_Customer AND RegisterDate>='" + dateFrom + " 00:00:00' AND RegisterDate<='" + dateTo + " 23:59:59' AND IsPayCustomer=0 AND IsSigned=1";
                condition = condition + " ORDER BY RegisterDate";
                return dc.VIewgexpbill.GetListObjectCon(base.ConnectionData.Schema, condition, "@FK_Customer", customerId);
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
        public async Task<List<view_GExpProblem>> GetProblemList(string customerId, string dateFrom, string dateTo)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = " WHERE FK_Customer=@FK_Customer AND RegisterDate>='" + dateFrom + " 00:00:00' AND RegisterDate<='" + dateTo + " 23:59:59'";
                condition = condition + " ORDER BY RegisterDate desc";
                return dc.VIewgexpproblem.GetListObjectCon(base.ConnectionData.Schema, condition, "@FK_Customer", customerId);
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
        public async Task<List<view_GExpOrder>> GetOrderList(string customerId, string dateFrom, string dateTo, int status)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = " WHERE FK_CustomerId=@FK_CustomerId AND CreateDate>='" + dateFrom + " 00:00:00' AND CreateDate<='" + dateTo + " 23:59:59'";
                if (status != -1)
                {
                    condition = condition + " AND StatusOrder=" + status;
                }
                condition = condition + " ORDER BY CreateDate";
                return dc.VIewgexporder.GetListObjectCon(base.ConnectionData.Schema, condition, "@FK_CustomerId", customerId);
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
        public async Task<List<GExpBillStatus>> GetBillStatusList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<GExpBillStatus> list = new List<GExpBillStatus>();
                list.Add(new GExpBillStatus { Id = -1, StatusName = "Tất cả" });
                list.AddRange(dc.GExpbillstatus.GetListObject(base.ConnectionData.Schema));
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
        public async Task<List<GExpOrderStatus>> GetOrderStatusList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<GExpOrderStatus> list = new List<GExpOrderStatus>();
                list.Add(new GExpOrderStatus { Id = -1, StatusName = "Tất cả" });
                list.AddRange(dc.GExporderstatus.GetListObject(base.ConnectionData.Schema));
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
        public async Task<view_GExpOrder> GetOrderDetail(string customerId, string orderCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = " WHERE FK_CustomerId=@FK_CustomerId AND OrderCode=@OrderCode";
                return dc.VIewgexporder.GetObjectCon(base.ConnectionData.Schema, condition,
                    "@FK_CustomerId", customerId,
                    "@OrderCode", orderCode);
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
        public async Task<string> CreateOrUpDateOrder(string customerId, string OrderCode, string AcceptName, string AcceptPhone, string AcceptAddress,
            string GoodsName, decimal COD, int Weight, bool IsShopPay, string Note, string Province, string District, string Ward)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();

                GExpOrder order = dc.GExporder.GetObjectCon(base.ConnectionData.Schema, "WHERE OrderCode=@OrderCode AND FK_CustomerId=@FK_CustomerId",
                    "@OrderCode", OrderCode,
                    "@FK_CustomerId", customerId);
                if (order == null)
                {
                    // Tạo mới
                    order = new GExpOrder();
                    order.Id = Guid.NewGuid().ToString();
                    order.OrderCode = OrderCode;
                    order.AcceptName = AcceptName;
                    order.AcceptPhone = AcceptPhone;
                    order.AcceptAddress = AcceptAddress;
                    order.GoodsName = GoodsName;
                    order.COD = COD;
                    order.Weight = Weight;
                    order.IsShopPay = IsShopPay;
                    order.Note = Note;
                    order.StatusOrder = 0;
                    order.FK_CustomerId = customerId;
                    order.CreateDate = dc.CurrentTime();

                    if (string.IsNullOrEmpty(Ward))
                    {
                        // Check address
                        string address = Utils.ConvertToUnSign(AcceptAddress).ToLower();
                        address = address.Replace("thanh pho", " ");
                        address = address.Replace("tp ", "");
                        address = address.Replace("xa ", "");
                        address = address.Replace("huyen ", "");
                        address = address.Replace("thi xa ", "");
                        address = address.Replace("tx ", "");
                        address = address.Replace("thi tran ", "");
                        address = address.Replace("tt ", "");
                        address = address.Replace("quan ", "");
                        address = address.Replace("q ", "");
                        string[] separatingStrings = { " ", "," };
                        string[] temp = address.Split(separatingStrings, StringSplitOptions.RemoveEmptyEntries);
                        if (temp.Length >= 6)
                        {
                            string key = "";
                            for (int i = temp.Length - 6; i < temp.Length; i++)
                            {
                                key += temp[i] + " ";
                            }
                            key = key.Trim();
                            var list = dc.GExpward.GetListObjectLimitCon(base.ConnectionData.Schema, "*", "WHERE SearchKey LIKE '%" + key + "%'", 20, 0);
                            if (list.Count > 0)
                            {
                                order.ProvinceCode = list[0].ProvinceID;
                                order.DistrictCode = list[0].DistrictID;
                                order.DistrictWard = list[0].WardId;
                            }
                        }


                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(Province))
                        {
                            order.ProvinceCode = Int32.Parse(Province);
                            order.DistrictCode = Int32.Parse(District);
                            order.DistrictWard = Ward;
                        }
                    }


                    dc.GExporder.InsertOnSubmit(base.ConnectionData.Schema, order);
                }
                else
                {
                    // Update
                    order.AcceptName = AcceptName;
                    order.AcceptPhone = AcceptPhone;
                    order.AcceptAddress = AcceptAddress;
                    order.GoodsName = GoodsName;
                    order.COD = COD;
                    order.Weight = (int)Weight;
                    order.IsShopPay = IsShopPay;
                    order.Note = Note;
                    order.ProvinceCode = Int32.Parse(Province);
                    order.DistrictCode = Int32.Parse(District);
                    order.DistrictWard = Ward;
                    dc.GExporder.Update(base.ConnectionData.Schema, order);
                }
                dc.SubmitChanges();
                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                dc.Close();
            }
        }
        // Tỉnh huyện xã
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
        public List<view_GExpFeeDetails> GetFeeDetails(string customerId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpCustomer customer = dc.EXpcustomer.GetObject(base.ConnectionData.Schema, customerId);
                return dc.VIewgexpfeedetails.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_GExpFee=@FK_GExpFee", "@FK_GExpFee", customer.FK_GiaCuoc);
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
        public GExpProvince GetDanhSachTinhDetail(string provineId)
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExpprovince.GetObject(ConnectionData.Schema, Int32.Parse(provineId));
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
        public async Task<bool> DeleteOrder(string orderId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                dc.GExporder.DeleteOnSubmit(base.ConnectionData.Schema, orderId);
                dc.SubmitChanges();
                return true;
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
    }
}
