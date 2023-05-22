using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class QuanLyNhomKhachHangLogic : BaseLogic
    {
        public QuanLyNhomKhachHangLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        /// <summary>
        /// Get all view_ExpCustomerGroup List
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_ExpCustomerGroup>> GetList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpcustomergroup.GetListObject(base.ConnectionData.Schema);
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
        /// Tìm view_ExpCustomerGroup theo keyword
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_ExpCustomerGroup>> GetList(string keyword, string post)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = "WHERE FK_Post='" + post + "' &";
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += "Code like N'%" + keyword + "%' | TenNhom like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                condition = condition + " ORDER BY MacDinh desc, TenNhom asc";
                return dc.VIewexpcustomergroup.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        /// Danh sách view_ExpCustomerGroup theo giới hạn keyword và page
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="page">Số trang hiển thị</param>
        /// <returns></returns>
        public async Task<List<view_ExpCustomerGroup>> GetPage(string keyword, int? page)
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
        /// Danh sách view_ExpCustomerGroup theo giới hạn keyword, Take, Skip
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<List<view_ExpCustomerGroup>> GetPage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE Code like N'%" + keyword + "%' | TenNhom like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY TenNhom asc";
                return dc.VIewexpcustomergroup.GetListObjectLimitCon(base.ConnectionData.Schema, "*", condition, Take, Skip);
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
        /// Tuple Danh sách view_ExpCustomerGroup theo giới hạn keyword, Take, Skip và số dòng dữ liệu
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<Tuple<List<view_ExpCustomerGroup>, int>> GetTuplePage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                var list = dc.VIewexpcustomergroup.GetListObject(base.ConnectionData.Schema);
                var data = await GetPage(keyword, Take, Skip);
                return new Tuple<List<view_ExpCustomerGroup>, int>(data, list.Count);
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
        /// Get List of SameQuanLyNhomKhachHangLogic
        /// </summary>
        /// <param name="Id">Id Of ExpCustomerGroup</param>
        /// <returns></returns>
        public async Task<List<view_ExpCustomerGroup>> GetSameList(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int take = 10;
                return dc.VIewexpcustomergroup.GetListObjectLimitCon(base.ConnectionData.Schema, "*", "WHERE Id<>@Id  ", take, 0, "@Id", Id);
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
        /// Get view_ExpCustomerGroup Object
        /// </summary>
        /// <param name="Id">Id Of ExpCustomerGroup</param>
        /// <returns></returns>
        public async Task<view_ExpCustomerGroup> GetDetails(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpcustomergroup.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", Id);
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
        /// Create a ExpCustomerGroup Object into Database
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ExpCustomerGroup> Create(QuanLyNhomKhachHangLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpCustomerGroup item = new ExpCustomerGroup();

                // Mapping Prop
                item.Id = Guid.NewGuid().ToString();
                item.Code = input.Code;
                item.TenNhom = input.TenNhom;
                item.MacDinh = input.MacDinh;
                item.FK_Post = input.FK_Post;
                if (item.MacDinh == true)
                {
                    List<ExpCustomerGroup> lsGroup = dc.EXpcustomergroup.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post AND MacDinh=1", "@FK_Post", item.FK_Post);
                    foreach (var group in lsGroup)
                    {
                        group.MacDinh = false;
                        dc.EXpcustomergroup.Update(base.ConnectionData.Schema, group);
                    }
                }
                //Change Database
                dc.EXpcustomergroup.InsertOnSubmit(base.ConnectionData.Schema, item);
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
        /// Update ExpCustomerGroup 
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Update(String Id, QuanLyNhomKhachHangLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpCustomerGroup item = dc.EXpcustomergroup.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    // Mapping Prop
                    item.Code = input.Code;
                    item.TenNhom = input.TenNhom;
                    item.FK_Post = input.FK_Post;
                    if (input.MacDinh == true && input.MacDinh != item.MacDinh)
                    {
                        List<ExpCustomerGroup> lsGroup = dc.EXpcustomergroup.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post AND MacDinh=1", "@FK_Post", item.FK_Post);
                        foreach (var group in lsGroup)
                        {
                            group.MacDinh = false;
                            dc.EXpcustomergroup.Update(base.ConnectionData.Schema, group);
                        }
                    }

                    item.MacDinh = input.MacDinh;

                    //Change Database
                    dc.EXpcustomergroup.Update(base.ConnectionData.Schema, item);
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
        /// Delete ExpCustomerGroup
        /// </summary>
        public async Task<bool> Delete(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpCustomerGroup item = dc.EXpcustomergroup.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    List<ExpCustomer> lsCustomer = dc.EXpcustomer.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Group=@FK_Group", "@FK_Group", item.Id);
                    if (lsCustomer.Count == 0)
                    {
                        dc.EXpcustomergroup.DeleteOnSubmit(base.ConnectionData.Schema, Id);
                        dc.SubmitChanges();
                        return true;
                    }
                    return false;
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
        /// <returns>view_ExpCustomerGroup</returns>
        public async Task<view_ExpCustomerGroup> CreateOrUpdateMasterOnly(String Id, QuanLyNhomKhachHangLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                ExpCustomerGroup item = dc.EXpcustomergroup.GetObject(base.ConnectionData.Schema, Id);
                if (item == null)
                {
                    insert = true;
                    item = new ExpCustomerGroup();
                    item.Id = Guid.NewGuid().ToString();
                }
                // Update Value
                item.Code = input.Code;
                item.TenNhom = input.TenNhom;
                item.MacDinh = input.MacDinh;
                item.FK_Post = input.FK_Post;
                if (insert)
                {
                    dc.EXpcustomergroup.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.EXpcustomergroup.Update(base.ConnectionData.Schema, item);
                }

                // Get lại giá trị của Master
                view_ExpCustomerGroup returnItem = dc.VIewexpcustomergroup.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", item.Id);
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
        /// Get data refer Master ExpPost
        /// </summary>
        /// <returns>ExpPost</returns>
        public async Task<List<ExpPost>> GetMasterFK_PostList()
        {
            List<ExpPost> ls = new List<ExpPost>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.EXppost.GetListObject(ConnectionData.Schema);
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

