using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class QuanLyNapTienShipperLogic : BaseLogic
    {
        public QuanLyNapTienShipperLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        /// <summary>
        /// Get all view_GExpShipperCash List
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_GExpShipperCash>> GetList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpshippercash.GetListObject(base.ConnectionData.Schema);
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
        /// Tìm view_GExpShipperCash theo keyword
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_GExpShipperCash>> GetList(string keyword)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE ShipperName like N'%" + keyword + "%' | ShipperPhone like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY CreateDate asc";
                return dc.VIewgexpshippercash.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        /// Danh sách view_GExpShipperCash theo giới hạn keyword và page
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="page">Số trang hiển thị</param>
        /// <returns></returns>
        public async Task<List<view_GExpShipperCash>> GetPage(string keyword, int? page)
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
        /// Danh sách view_GExpShipperCash theo giới hạn keyword, Take, Skip
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<List<view_GExpShipperCash>> GetPage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE ShipperName like N'%" + keyword + "%' | ShipperPhone like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY CreateDate asc";
                return dc.VIewgexpshippercash.GetListObjectLimitCon(base.ConnectionData.Schema, "*", condition, Take, Skip);
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
        /// Tuple Danh sách view_GExpShipperCash theo giới hạn keyword, Take, Skip và số dòng dữ liệu
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<Tuple<List<view_GExpShipperCash>, int>> GetTuplePage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                var list = dc.VIewgexpshippercash.GetListObject(base.ConnectionData.Schema);
                var data = await GetPage(keyword, Take, Skip);
                return new Tuple<List<view_GExpShipperCash>, int>(data, list.Count);
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
        /// Get List of SameQuanLyNapTienShipperLogic
        /// </summary>
        /// <param name="Id">Id Of GExpShipperCash</param>
        /// <returns></returns>
        public async Task<List<view_GExpShipperCash>> GetSameList(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int take = 10;
                return dc.VIewgexpshippercash.GetListObjectLimitCon(base.ConnectionData.Schema, "*", "WHERE Id<>@Id  ", take, 0, "@Id", Id);
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
        /// Get view_GExpShipperCash Object
        /// </summary>
        /// <param name="Id">Id Of GExpShipperCash</param>
        /// <returns></returns>
        public async Task<view_GExpShipperCash> GetDetails(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpshippercash.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", Id);
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
        /// Get view_GExpShipperCashDetail List Object
        /// </summary>
        /// <param name="Id">Id Of GExpShipperCash</param>
        /// <returns></returns>
        public async Task<List<view_GExpShipperCashDetail>> GetChildList(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpshippercashdetail.GetListObjectCon(base.ConnectionData.Schema,
                    "WHERE FK_CashShipper=@FK_CashShipper",
                    "@FK_CashShipper", Id);
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
        /// Get view_GExpShipperCashDetail Object
        /// </summary>
        /// <param name="Id">Id Of GExpShipperCashDetail</param>
        /// <returns></returns>
        public async Task<view_GExpShipperCashDetail> GetChildDetails(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpshippercashdetail.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", Id);
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
        /// Create a GExpShipperCash Object into Database
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<GExpShipperCash> Create(QuanLyNapTienShipperLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpShipperCash item = new GExpShipperCash();

                // Mapping Prop
                item.Id = Guid.NewGuid().ToString();
                item.FK_Shipper = input.FK_Shipper;
                item.CreateDate = DateTime.Now;
                item.FK_Account = input.FK_Account;
                item.TotalCash = input.TotalCash;
                item.FK_Post = input.FK_Post;

                //Change Database
                foreach (var child in input.lsGExpShipperCashDetail)
                {
                    GExpShipperCashDetail childInsert = new GExpShipperCashDetail();
                    childInsert.Id = child.Id;
                    childInsert.BillCode = child.BillCode;
                    childInsert.MoneyValue = child.MoneyValue;
                    childInsert.Freight = child.Freight;
                    childInsert.COD = child.COD;
                    childInsert.PayMentType = child.PayMentType;
                    childInsert.FK_CashShipper = item.Id;
                    dc.GExpshippercashdetail.InsertOnSubmit(base.ConnectionData.Schema, childInsert);
                }
                dc.GExpshippercash.InsertOnSubmit(base.ConnectionData.Schema, item);
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
        /// <summary>
        /// Update GExpShipperCash 
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Update(String Id, QuanLyNapTienShipperLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpShipperCash item = dc.GExpshippercash.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    // Mapping Prop
                    item.FK_Shipper = input.FK_Shipper;
                    item.CreateDate = DateTime.Now;
                    item.FK_Account = input.FK_Account;
                    item.TotalCash = input.TotalCash;
                    item.FK_Post = input.FK_Post;

                    //Change Database
                    dc.GExpshippercashdetail.DeleteOnSubmitCon(base.ConnectionData.Schema,
                    "WHERE FK_CashShipper=@FK_CashShipper",
                    "@FK_CashShipper", Id);
                    foreach (var child in input.lsGExpShipperCashDetail)
                    {
                        GExpShipperCashDetail childInsert = new GExpShipperCashDetail();
                        childInsert.Id = child.Id;
                        childInsert.BillCode = child.BillCode;
                        childInsert.MoneyValue = child.MoneyValue;
                        childInsert.Freight = child.Freight;
                        childInsert.COD = child.COD;
                        childInsert.PayMentType = child.PayMentType;
                        childInsert.FK_CashShipper = item.Id;
                        dc.GExpshippercashdetail.InsertOnSubmit(base.ConnectionData.Schema, childInsert);
                    }
                    dc.GExpshippercash.Update(base.ConnectionData.Schema, item);
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
        /// Delete GExpShipperCash
        /// </summary>
        public async Task<bool> Delete(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpShipperCash item = dc.GExpshippercash.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    //Delete Child
                    dc.GExpshippercashdetail.DeleteOnSubmitCon(base.ConnectionData.Schema,
                    "WHERE FK_CashShipper=@FK_CashShipper",
                    "@FK_CashShipper", Id);
                    //Delete master
                    dc.GExpshippercash.DeleteOnSubmit(base.ConnectionData.Schema, Id);
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
        /// Delete GExpShipperCash
        /// </summary>
        public async Task<bool> DeleteChild(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpShipperCashDetail item = dc.GExpshippercashdetail.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    //Delete Child
                    dc.GExpshippercashdetail.DeleteOnSubmit(base.ConnectionData.Schema, Id);
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
        /// Create Or Update Master Only
        /// </summary>
        /// <param name="input"></param>
        /// <returns>view_GExpShipperCash</returns>
        public async Task<view_GExpShipperCash> CreateOrUpdateMasterOnly(String Id, QuanLyNapTienShipperLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                GExpShipperCash item = dc.GExpshippercash.GetObject(base.ConnectionData.Schema, Id);
                if (item == null)
                {
                    insert = true;
                    item = new GExpShipperCash();
                    item.Id = Guid.NewGuid().ToString();
                    item.CreateDate = DateTime.Now;
                }
                // Update Value
                item.FK_Shipper = input.FK_Shipper;
                item.FK_Account = input.FK_Account;
                item.TotalCash = input.TotalCash;
                item.FK_Post = input.FK_Post;
                if (insert)
                {
                    dc.GExpshippercash.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.GExpshippercash.Update(base.ConnectionData.Schema, item);
                }

                // Get lại giá trị của Master
                view_GExpShipperCash returnItem = dc.VIewgexpshippercash.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", item.Id);
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
        /// <summary>
        /// Create Or Update Child Only
        /// </summary>
        /// <param name="input"></param>
        /// <returns>view_GExpShipperCashDetail</returns>
        public async Task<view_GExpShipperCashDetail> CreateOrUpdateChildOnly(String Id, childQuanLyNapTienShipperLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                GExpShipperCashDetail item = dc.GExpshippercashdetail.GetObject(base.ConnectionData.Schema, Id);
                if (item == null)
                {
                    insert = true;
                    item = new GExpShipperCashDetail();
                }
                item.Id = input.Id;
                item.BillCode = input.BillCode;
                item.MoneyValue = input.MoneyValue;
                item.Freight = input.Freight;
                item.COD = input.COD;
                item.PayMentType = input.PayMentType;
                if (insert)
                {
                    dc.GExpshippercashdetail.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.GExpshippercashdetail.Update(base.ConnectionData.Schema, item);
                }
                // Get lại giá trị của Child
                view_GExpShipperCashDetail returnItem = dc.VIewgexpshippercashdetail.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", item.Id);
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
        /// <summary>
        /// Get data refer Master GExpShipper
        /// </summary>
        /// <returns>GExpShipper</returns>
        public async Task<List<GExpShipper>> GetMasterFK_ShipperList()
        {
            List<GExpShipper> ls = new List<GExpShipper>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.GExpshipper.GetListObject(ConnectionData.Schema);
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
    }
}

