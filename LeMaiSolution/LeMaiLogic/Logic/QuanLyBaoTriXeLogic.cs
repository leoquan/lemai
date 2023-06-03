using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class QuanLyBaoTriXeLogic : BaseLogic
    {
        public QuanLyBaoTriXeLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        /// <summary>
        /// Get all view_VihcleCoupon List
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_VihcleCoupon>> GetList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewvihclecoupon.GetListObject(base.ConnectionData.Schema);
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
        /// Tìm view_VihcleCoupon theo keyword
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_VihcleCoupon>> GetList(string keyword)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE BienSo like N'%" + keyword + "%' | TenXe like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY Date asc";
                return dc.VIewvihclecoupon.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        /// Danh sách view_VihcleCoupon theo giới hạn keyword và page
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="page">Số trang hiển thị</param>
        /// <returns></returns>
        public async Task<List<view_VihcleCoupon>> GetPage(string keyword, int? page)
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
        /// Danh sách view_VihcleCoupon theo giới hạn keyword, Take, Skip
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<List<view_VihcleCoupon>> GetPage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE BienSo like N'%" + keyword + "%' | TenXe like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY Date asc";
                return dc.VIewvihclecoupon.GetListObjectLimitCon(base.ConnectionData.Schema, "*", condition, Take, Skip);
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
        /// Tuple Danh sách view_VihcleCoupon theo giới hạn keyword, Take, Skip và số dòng dữ liệu
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<Tuple<List<view_VihcleCoupon>, int>> GetTuplePage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                var list = dc.VIewvihclecoupon.GetListObject(base.ConnectionData.Schema);
                var data = await GetPage(keyword, Take, Skip);
                return new Tuple<List<view_VihcleCoupon>, int>(data, list.Count);
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
        /// Get List of SameQuanLyBaoTriXeLogic
        /// </summary>
        /// <param name="Id">Id Of VihcleCoupon</param>
        /// <returns></returns>
        public async Task<List<view_VihcleCoupon>> GetSameList(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int take = 10;
                return dc.VIewvihclecoupon.GetListObjectLimitCon(base.ConnectionData.Schema, "*", "WHERE Id<>@Id  ", take, 0, "@Id", Id);
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
        /// Get view_VihcleCoupon Object
        /// </summary>
        /// <param name="Id">Id Of VihcleCoupon</param>
        /// <returns></returns>
        public async Task<view_VihcleCoupon> GetDetails(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewvihclecoupon.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", Id);
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
        /// Get view_VihcleCouponDetail List Object
        /// </summary>
        /// <param name="Id">Id Of VihcleCoupon</param>
        /// <returns></returns>
        public async Task<List<view_VihcleCouponDetail>> GetChildList(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewvihclecoupondetail.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_VihcleCoupon=@FK_VihcleCoupon", "@FK_VihcleCoupon", Id);
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
        /// Get view_VihcleCouponDetail Object
        /// </summary>
        /// <param name="Id">Id Of VihcleCouponDetail</param>
        /// <returns></returns>
        public async Task<view_VihcleCouponDetail> GetChildDetails(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewvihclecoupondetail.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", Id);
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
        /// Create a VihcleCoupon Object into Database
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<VihcleCoupon> Create(QuanLyBaoTriXeLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                VihcleCoupon item = new VihcleCoupon();

                // Mapping Prop
                item.Id = Guid.NewGuid().ToString();
                item.FK_Vihcle = input.FK_Vihcle;
                item.SoKM = input.TotalFee;
                item.TotalFee = 0;
                item.Date = DateTime.Now;
                item.Note = input.Note;
                foreach (var child in input.lsVihcleCouponDetail)
                {
                    VihcleCouponDetail childInsert = new VihcleCouponDetail();
                    childInsert.Id = Guid.NewGuid().ToString();
                    childInsert.FK_Service = child.FK_Service;
                    childInsert.FK_VihcleCoupon = item.Id;
                    childInsert.CurrentValue = child.CurrentValue;
                    childInsert.ServiceDate = DateTime.Now;
                    dc.VIhclecoupondetail.InsertOnSubmit(base.ConnectionData.Schema, childInsert);

                    item.TotalFee = item.TotalFee + childInsert.CurrentValue;
                }

                dc.VIhclecoupon.InsertOnSubmit(base.ConnectionData.Schema, item);
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
        /// Update VihcleCoupon 
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Update(String Id, QuanLyBaoTriXeLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                VihcleCoupon item = dc.VIhclecoupon.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    item.FK_Vihcle = input.FK_Vihcle;
                    item.SoKM = input.TotalFee;
                    item.TotalFee = 0;
                    item.Date = DateTime.Now;
                    item.Note = input.Note;
                    //Change Database
                    dc.VIhclecoupondetail.DeleteOnSubmitCon(base.ConnectionData.Schema, "WHERE FK_VihcleCoupon=@FK_VihcleCoupon", "@FK_VihcleCoupon", item.Id);
                    foreach (var child in input.lsVihcleCouponDetail)
                    {
                        VihcleCouponDetail childInsert = new VihcleCouponDetail();
                        childInsert.Id = Guid.NewGuid().ToString();
                        childInsert.FK_Service = child.FK_Service;
                        childInsert.FK_VihcleCoupon = item.Id;
                        childInsert.CurrentValue = child.CurrentValue;
                        childInsert.ServiceDate = DateTime.Now;
                        dc.VIhclecoupondetail.InsertOnSubmit(base.ConnectionData.Schema, childInsert);

                        item.TotalFee = item.TotalFee + childInsert.CurrentValue;
                    }
                    dc.VIhclecoupon.Update(base.ConnectionData.Schema, item);
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
        /// Delete VihcleCoupon
        /// </summary>
        public async Task<bool> Delete(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                VihcleCoupon item = dc.VIhclecoupon.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    //Delete Child
                    dc.VIhclecoupondetail.DeleteOnSubmitCon(base.ConnectionData.Schema, "WHERE FK_VihcleCoupon=@FK_VihcleCoupon", "@FK_VihcleCoupon", item.Id);
                    dc.VIhclecoupon.DeleteOnSubmit(base.ConnectionData.Schema, Id);
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
        /// Delete VihcleCoupon
        /// </summary>
        public async Task<bool> DeleteChild(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                VihcleCouponDetail item = dc.VIhclecoupondetail.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    //Delete Child
                    dc.VIhclecoupondetail.DeleteOnSubmit(base.ConnectionData.Schema, Id);
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
        /// <returns>view_VihcleCoupon</returns>
        public async Task<view_VihcleCoupon> CreateOrUpdateMasterOnly(String Id, QuanLyBaoTriXeLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                VihcleCoupon item = dc.VIhclecoupon.GetObject(base.ConnectionData.Schema, Id);
                if (item == null)
                {
                    insert = true;
                    item = new VihcleCoupon();
                    item.Id = Guid.NewGuid().ToString();
                    item.Date = DateTime.Now;
                }
                // Update Value
                item.FK_Vihcle = input.FK_Vihcle;
                item.TotalFee = input.TotalFee;
                item.Note = input.Note;
                if (insert)
                {
                    dc.VIhclecoupon.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.VIhclecoupon.Update(base.ConnectionData.Schema, item);
                }

                // Get lại giá trị của Master
                view_VihcleCoupon returnItem = dc.VIewvihclecoupon.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", item.Id);
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
        /// <returns>view_VihcleCouponDetail</returns>
        public async Task<view_VihcleCouponDetail> CreateOrUpdateChildOnly(String Id, childQuanLyBaoTriXeLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                VihcleCouponDetail item = dc.VIhclecoupondetail.GetObject(base.ConnectionData.Schema, Id);
                if (item == null)
                {
                    insert = true;
                    item = new VihcleCouponDetail();
                    item.Id = Guid.NewGuid().ToString();
                    item.ServiceDate = DateTime.Now;
                    item.FK_VihcleCoupon = input.FK_VihcleCoupon;
                }
                item.FK_Service = input.FK_Service;
                item.CurrentValue = input.CurrentValue;
                item.ServiceDate = DateTime.Now;
                if (insert)
                {
                    dc.VIhclecoupondetail.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.VIhclecoupondetail.Update(base.ConnectionData.Schema, item);
                }
                // Get lại giá trị của Child
                view_VihcleCouponDetail returnItem = dc.VIewvihclecoupondetail.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", item.Id);
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
        /// Get data refer Master Vihcle
        /// </summary>
        /// <returns>Vihcle</returns>
        public async Task<List<Vihcle>> GetMasterFK_VihcleList()
        {
            List<Vihcle> ls = new List<Vihcle>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.VIhcle.GetListObject(ConnectionData.Schema);
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
        /// <summary>
        /// Get data refer Child VihcleService
        /// </summary>
        /// <returns>VihcleService</returns>
        public async Task<List<VihcleService>> GetChildFK_ServiceList()
        {
            List<VihcleService> ls = new List<VihcleService>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.VIhcleservice.GetListObject(ConnectionData.Schema);
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

