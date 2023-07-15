using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class CustomerLogic : BaseLogic
    {
        public CustomerLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        /// <summary>
        /// Get all view_ExpCustomer List
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_ExpCustomer>> GetList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpcustomer.GetListObject(base.ConnectionData.Schema);
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
        /// Tìm view_ExpCustomer theo keyword
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_ExpCustomer>> GetList(string keyword, string post)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE FK_Post='" + post + "' AND CustomerName like N'%" + keyword + "%' | CustomerPhone like N'%" + keyword + "%' | CustomerCode like N'%" + keyword + "%' | UnsigName like N'%" + keyword + "%' |";
                }
                else
                {
                    condition += " WHERE FK_Post='" + post + "'";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY CustomerName asc";
                return dc.VIewexpcustomer.GetListObjectCon(base.ConnectionData.Schema, condition);
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

        public List<ExpCustomerGroup> GetListCustomer(string post)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpcustomergroup.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post ORDER BY MacDinh desc", "@FK_Post", post);
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
        public List<ExpProvinceFeeCustomer> GetListBangGia()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpprovincefeecustomer.GetListObject(base.ConnectionData.Schema);
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
        public List<GExpFee> GetListFee(string post)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExpfee.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post", "@FK_Post", post);
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
        public List<GExpBankVP> GetListBank()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExpbankvp.GetListObjectCon(base.ConnectionData.Schema, "ORDER BY BankName");
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
        /// Danh sách view_ExpCustomer theo giới hạn keyword và page
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="page">Số trang hiển thị</param>
        /// <returns></returns>
        public async Task<List<view_ExpCustomer>> GetPage(string keyword, int? page)
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
        /// Danh sách view_ExpCustomer theo giới hạn keyword, Take, Skip
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<List<view_ExpCustomer>> GetPage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE CustomerName like N'%" + keyword + "%' | CustomerPhone like N'%" + keyword + "%' | CustomerCode like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY CustomerCode asc";
                return dc.VIewexpcustomer.GetListObjectLimitCon(base.ConnectionData.Schema, "*", condition, Take, Skip);
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
        /// Tuple Danh sách view_ExpCustomer theo giới hạn keyword, Take, Skip và số dòng dữ liệu
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<Tuple<List<view_ExpCustomer>, int>> GetTuplePage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                var list = dc.VIewexpcustomer.GetListObject(base.ConnectionData.Schema);
                var data = await GetPage(keyword, Take, Skip);
                return new Tuple<List<view_ExpCustomer>, int>(data, list.Count);
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
        /// Get List of SamefrmCustomerLogic
        /// </summary>
        /// <param name="Id">Id Of ExpCustomer</param>
        /// <returns></returns>
        public async Task<List<view_ExpCustomer>> GetSameList(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int take = 10;
                return dc.VIewexpcustomer.GetListObjectLimitCon(base.ConnectionData.Schema, "*", "WHERE Id<>@Id  ", take, 0, "@Id", Id);
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
        /// Get view_ExpCustomer Object
        /// </summary>
        /// <param name="Id">Id Of ExpCustomer</param>
        /// <returns></returns>
        public async Task<view_ExpCustomer> GetDetails(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpcustomer.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", Id);
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
        /// Create a ExpCustomer Object into Database
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<string> Create(CustomerLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpCustomer item = dc.EXpcustomer.GetObjectCon(base.ConnectionData.Schema, "WHERE CustomerCode=@CustomerCode", "@CustomerCode", input.CustomerCode);
                if (item == null)
                {
                    item = new ExpCustomer();
                    // Mapping Prop
                    item.Id = Guid.NewGuid().ToString();
                    item.CustomerName = input.CustomerName;
                    item.CustomerPhone = input.CustomerPhone;
                    item.BankName = input.BankName;
                    item.AccountName = input.AccountName;
                    item.AccountCode = input.AccountCode;
                    item.GoogleMap = input.GoogleMap;
                    item.FK_Post = input.FK_Post;
                    item.CustomerCode = input.CustomerCode;
                    item.ContractCustomer = input.ContractCustomer;
                    item.FK_Group = input.FK_Group;
                    item.SoHopDong = input.SoHopDong;
                    item.NgayHopDong = input.NgayHopDong;
                    item.TenHopDong = input.TenHopDong;
                    item.DiaChi = input.DiaChi;
                    item.FK_GiaCuoc = input.FK_BangGia;
                    item.MaSoThue = input.MaSoThue;
                    item.DonVi = input.TenCongTy;
                    item.TenSanPham = input.TenSanPham;
                    item.CustomerCodePass = "123456";
                    item.ProvinceId= input.ProvinceId;
                    item.DistrictId= input.DistrictId;
                    item.WardId= input.WardId;
                    item.IsPickup= input.IsPickup;
                    //Change Database
                    dc.EXpcustomer.InsertOnSubmit(base.ConnectionData.Schema, item);
                    dc.SubmitChanges();
                    return string.Empty;
                }
                else
                {
                    return "Mã khách hàng đã tồn tại, vui lòng lựa chọn mã khách hàng khác!";
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
        /// Update ExpCustomer 
        /// </summary>
        /// <returns></returns>
        public async Task<string> Update(String Id, CustomerLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpCustomer item = dc.EXpcustomer.GetObjectCon(base.ConnectionData.Schema, "WHERE CustomerCode=@CustomerCode AND Id<>@Id", "@CustomerCode", input.CustomerCode, "@Id", Id);
                if (item == null)
                {
                    item = dc.EXpcustomer.GetObject(base.ConnectionData.Schema, Id);
                    if (item != null)
                    {
                        // Mapping Prop
                        item.CustomerName = input.CustomerName;
                        item.CustomerPhone = input.CustomerPhone;
                        item.BankName = input.BankName;
                        item.AccountName = input.AccountName;
                        item.AccountCode = input.AccountCode;
                        item.GoogleMap = input.GoogleMap;
                        item.CustomerCode = input.CustomerCode;
                        item.ContractCustomer = input.ContractCustomer;
                        item.FK_Group = input.FK_Group;
                        item.SoHopDong = input.SoHopDong;
                        item.NgayHopDong = input.NgayHopDong;
                        item.TenHopDong = input.TenHopDong;
                        item.DiaChi = input.DiaChi;
                        item.FK_GiaCuoc = input.FK_BangGia;
                        item.MaSoThue = input.MaSoThue;
                        item.DonVi = input.TenCongTy;
                        item.TenSanPham = input.TenSanPham;
                        item.ProvinceId = input.ProvinceId;
                        item.DistrictId = input.DistrictId;
                        item.WardId = input.WardId;
                        item.IsPickup = input.IsPickup;
                        //Change Database
                        dc.EXpcustomer.Update(base.ConnectionData.Schema, item);
                        dc.SubmitChanges();
                        return string.Empty;
                    }
                    else
                    {
                        return "Không tìm thấy thông tin khách hàng!";
                    }
                }
                else
                {
                    return "Mã khách hàng đã tồn tại, vui lòng lựa chọn mã khách hàng khác!";
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
        /// Delete ExpCustomer
        /// </summary>
        public async Task<bool> Delete(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpCustomer item = dc.EXpcustomer.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    //Delete master
                    GExpBill bill = dc.GExpbill.GetObjectCon(base.ConnectionData.Schema, "WHERE FK_Customer=@FK_Customer", "@FK_Customer", item.Id);
                    if (bill == null)
                    {
                       
                        dc.SubmitChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }

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
        /// Create Or Update Master Only
        /// </summary>
        /// <param name="input"></param>
        /// <returns>view_ExpCustomer</returns>
        public async Task<view_ExpCustomer> CreateOrUpdateMasterOnly(String Id, CustomerLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                ExpCustomer item = dc.EXpcustomer.GetObject(base.ConnectionData.Schema, Id);
                if (item == null)
                {
                    insert = true;
                    item = new ExpCustomer();
                    item.Id = Guid.NewGuid().ToString();
                }
                // Update Value
                item.CustomerName = input.CustomerName;
                item.CustomerPhone = input.CustomerPhone;
                item.BankName = input.BankName;
                item.AccountName = input.AccountName;
                item.AccountCode = input.AccountCode;
                item.GoogleMap = input.GoogleMap;
                item.FK_Post = input.FK_Post;
                item.CustomerCode = input.CustomerCode;
                item.ContractCustomer = input.ContractCustomer;
                item.MaSoThue = input.MaSoThue;
                item.DonVi = input.TenCongTy;
                if (insert)
                {
                    dc.EXpcustomer.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.EXpcustomer.Update(base.ConnectionData.Schema, item);
                }

                // Get lại giá trị của Master
                view_ExpCustomer returnItem = dc.VIewexpcustomer.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", item.Id);
                // Change database
                dc.SubmitChanges();
                return returnItem;
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

        public string GetCustomerCode(string ExpPostId)
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpCode queueNumber = dc.GExpcode.GetObjectCon(ConnectionData.Schema, "WHERE Id=@Id",
                    "@Id", ExpPostId + "CUS");
                if (queueNumber == null)
                {
                    queueNumber = new GExpCode();
                    queueNumber.Id = ExpPostId + "CUS";
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
                return queueNumber.Post + queueNumber.CurrentValue.ToString().PadLeft(5, '0');
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

        public ExpCustomer LoginCustomer(string userName, string passWord)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = "WHERE CustomerCode='" + userName + "' AND CustomerCodePass = '" + passWord + "'";

                return dc.EXpcustomer.GetObjectCon(base.ConnectionData.Schema, condition);
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

