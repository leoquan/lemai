using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class QuanLyNhanHangLogic : BaseLogic
    {
        public QuanLyNhanHangLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        /// <summary>
        /// Get all view_GExpReceiveTask List
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_GExpReceiveTask>> GetList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpreceivetask.GetListObject(base.ConnectionData.Schema);
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
        /// Tìm view_GExpReceiveTask theo keyword
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_GExpReceiveTask>> GetList(string keyword, DateTime date, string post)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = " WHERE FK_Post='" + post + "' AND CreateDate >= '" + string.Format("{0:yyyy-MM-dd}", date) + " 00:00:00' AND CreateDate<='" + string.Format("{0:yyyy-MM-dd}", date) + " 23:59:59' &";
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " CustomerName like N'%" + keyword + "%' OR CustomerPhone like N'%" + keyword + "%' OR CustomerCode like N'%" + keyword + "%'";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                condition = condition + " ORDER BY CreateDate asc";
                return dc.VIewgexpreceivetask.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        /// Danh sách view_GExpReceiveTask theo giới hạn keyword và page
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="page">Số trang hiển thị</param>
        /// <returns></returns>
        public async Task<List<view_GExpReceiveTask>> GetPage(string keyword, int? page)
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
        /// Danh sách view_GExpReceiveTask theo giới hạn keyword, Take, Skip
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<List<view_GExpReceiveTask>> GetPage(string keyword, int Take, int Skip)
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
                condition = condition + " ORDER BY CreateDate asc";
                return dc.VIewgexpreceivetask.GetListObjectLimitCon(base.ConnectionData.Schema, "*", condition, Take, Skip);
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
        /// Tuple Danh sách view_GExpReceiveTask theo giới hạn keyword, Take, Skip và số dòng dữ liệu
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<Tuple<List<view_GExpReceiveTask>, int>> GetTuplePage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                var list = dc.VIewgexpreceivetask.GetListObject(base.ConnectionData.Schema);
                var data = await GetPage(keyword, Take, Skip);
                return new Tuple<List<view_GExpReceiveTask>, int>(data, list.Count);
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
        /// Get List of SameQuanLyNhanHangLogic
        /// </summary>
        /// <param name="Id">Id Of GExpReceiveTask</param>
        /// <returns></returns>
        public async Task<List<view_GExpReceiveTask>> GetSameList(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int take = 10;
                return dc.VIewgexpreceivetask.GetListObjectLimitCon(base.ConnectionData.Schema, "*", "WHERE Id<>@Id  ", take, 0, "@Id", Id);
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
        /// Get view_GExpReceiveTask Object
        /// </summary>
        /// <param name="Id">Id Of GExpReceiveTask</param>
        /// <returns></returns>
        public async Task<view_GExpReceiveTask> GetDetails(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpreceivetask.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", Id);
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
        /// Create a GExpReceiveTask Object into Database
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<GExpReceiveTask> Create(QuanLyNhanHangLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpReceiveTask item = dc.GExpreceivetask.GetObjectCon(base.ConnectionData.Schema, "WHERE FK_CustomerId=@FK_CustomerId AND CreateDate >= '" + string.Format("{0:yyyy-MM-dd}", input.Date) + " 00:00:00' AND CreateDate<='" + string.Format("{0:yyyy-MM-dd}", input.Date) + " 23:59:59' ", "@FK_CustomerId", input.FK_CustomerId);
                if (item != null)
                {
                    return item;
                }
                item = new GExpReceiveTask();
                item.Id = Guid.NewGuid().ToString();
                item.FK_CustomerId = input.FK_CustomerId;
                item.FK_ShipperId = input.FK_ShipperId;
                if (input.Date <= DateTime.Now)
                {
                    item.CreateDate = DateTime.Now;
                }
                else
                {
                    item.CreateDate = input.Date.Date;
                }
                item.FK_Post = input.FK_Post;
                item.FK_Account = input.FK_Account;
                item.GoodsNumber = input.GoodsNumber;
                item.HaveReturn = input.HaveReturn;
                item.Note = input.Note;
                item.ReceiveStatus = 0;
                //Change Database
                dc.GExpreceivetask.InsertOnSubmit(base.ConnectionData.Schema, item);
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
        /// Update GExpReceiveTask 
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Update(String Id, QuanLyNhanHangLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpReceiveTask item = dc.GExpreceivetask.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    if (input.Date >= DateTime.Now.Date && item.ReceiveStatus == 0)
                    {
                        // Mapping Prop
                        item.FK_CustomerId = input.FK_CustomerId;
                        item.FK_ShipperId = input.FK_ShipperId;
                        item.CreateDate = DateTime.Now;
                        item.FK_Post = input.FK_Post;
                        item.FK_Account = input.FK_Account;
                        item.GoodsNumber = input.GoodsNumber;
                        item.HaveReturn = input.HaveReturn;
                        item.Note = input.Note;
                        //Change Database
                        dc.GExpreceivetask.Update(base.ConnectionData.Schema, item);
                        dc.SubmitChanges();
                    }

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
        /// Delete GExpReceiveTask
        /// </summary>
        public async Task<bool> Delete(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpReceiveTask item = dc.GExpreceivetask.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    //Delete master
                    dc.GExpreceivetask.DeleteOnSubmit(base.ConnectionData.Schema, Id);
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
        /// <returns>view_GExpReceiveTask</returns>
        public async Task<view_GExpReceiveTask> CreateOrUpdateMasterOnly(String Id, QuanLyNhanHangLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                GExpReceiveTask item = dc.GExpreceivetask.GetObject(base.ConnectionData.Schema, Id);
                if (item == null)
                {
                    insert = true;
                    item = new GExpReceiveTask();
                    item.Id = Guid.NewGuid().ToString();
                    item.CreateDate = DateTime.Now;
                }
                // Update Value
                item.FK_CustomerId = input.FK_CustomerId;
                item.FK_ShipperId = input.FK_ShipperId;
                item.FK_Post = input.FK_Post;
                item.FK_Account = input.FK_Account;
                item.GoodsNumber = input.GoodsNumber;
                item.HaveReturn = input.HaveReturn;
                item.Note = input.Note;
                if (insert)
                {
                    dc.GExpreceivetask.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.GExpreceivetask.Update(base.ConnectionData.Schema, item);
                }

                // Get lại giá trị của Master
                view_GExpReceiveTask returnItem = dc.VIewgexpreceivetask.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", item.Id);
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
        /// Get data refer Master ExpCustomer
        /// </summary>
        /// <returns>ExpCustomer</returns>
        public async Task<List<ExpCustomer>> GetMasterFK_CustomerIdList(string post, string search)
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpCustomer> list = new List<ExpCustomer>();
                string searchKey = UnSigns(search);
                List<ExpCustomer> temp = dc.EXpcustomer.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post AND (UnsigName LIKE '%" + searchKey + "%' OR CustomerPhone LIKE '%" + searchKey + "%' OR CustomerName LIKE N'%" + search + "%') ORDER BY CustomerName", "@FK_Post", post);
                foreach (var item in temp)
                {
                    item.CustomerName = item.CustomerName + " - " + item.CustomerPhone;
                    list.Add(item);
                }
                return list;
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
        /// <summary>
        /// Get data refer Master GExpShipper
        /// </summary>
        /// <returns>GExpShipper</returns>
        public async Task<List<GExpShipper>> GetMasterFK_ShipperIdList(string post, string search)
        {
            List<GExpShipper> ls = new List<GExpShipper>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string searchKey = UnSigns(search);
                List<GExpShipper> list = new List<GExpShipper>();
                list.Add(new GExpShipper { Id = "0000", ShipperName = "Tất cả" });
                var temps = dc.GExpshipper.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post AND (UserName LIKE '%" + searchKey + "%' OR ShipperPhone LIKE '%" + searchKey + "%' OR ShipperName LIKE N'%" + search + "%') ORDER BY ShipperName", "@FK_Post", post);
                foreach (var item in temps)
                {
                    item.ShipperName = item.ShipperName + " - " + item.ShipperPhone;
                    list.Add(item);
                }
                return list;
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

