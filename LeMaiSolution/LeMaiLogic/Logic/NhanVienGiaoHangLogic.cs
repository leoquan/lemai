using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class NhanVienGiaoHangLogic : BaseLogic
    {
        public NhanVienGiaoHangLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        /// <summary>
        /// Get all view_GexpShipper List
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_GexpShipper>> GetList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpshipper.GetListObject(base.ConnectionData.Schema);
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
        /// Tìm view_GexpShipper theo keyword
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_GexpShipper>> GetList(string keyword, string post)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = "WHERE FK_Post='" + post + "' &";
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " ShipperName like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                condition = condition + " ORDER BY ShipperName asc";
                return dc.VIewgexpshipper.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        /// Danh sách view_GexpShipper theo giới hạn keyword và page
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="page">Số trang hiển thị</param>
        /// <returns></returns>
        public async Task<List<view_GexpShipper>> GetPage(string keyword, int? page)
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
        /// Danh sách view_GexpShipper theo giới hạn keyword, Take, Skip
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<List<view_GexpShipper>> GetPage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE ShipperName like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY ShipperName asc";
                return dc.VIewgexpshipper.GetListObjectLimitCon(base.ConnectionData.Schema, "*", condition, Take, Skip);
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
        /// Tuple Danh sách view_GexpShipper theo giới hạn keyword, Take, Skip và số dòng dữ liệu
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<Tuple<List<view_GexpShipper>, int>> GetTuplePage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                var list = dc.VIewgexpshipper.GetListObject(base.ConnectionData.Schema);
                var data = await GetPage(keyword, Take, Skip);
                return new Tuple<List<view_GexpShipper>, int>(data, list.Count);
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
        /// Get List of SameNhanVienGiaoHangLogic
        /// </summary>
        /// <param name="Id">Id Of GExpShipper</param>
        /// <returns></returns>
        public async Task<List<view_GexpShipper>> GetSameList(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int take = 10;
                return dc.VIewgexpshipper.GetListObjectLimitCon(base.ConnectionData.Schema, "*", "WHERE Id<>@Id  ", take, 0, "@Id", Id);
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
        /// Get view_GexpShipper Object
        /// </summary>
        /// <param name="Id">Id Of GExpShipper</param>
        /// <returns></returns>
        public async Task<view_GexpShipper> GetDetails(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpshipper.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", Id);
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
        /// Create a GExpShipper Object into Database
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<GExpShipper> Create(NhanVienGiaoHangLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpShipper item = new GExpShipper();

                // Mapping Prop
                item.Id = Guid.NewGuid().ToString();
                item.ShipperName = input.ShipperName;
                item.ShipperPhone = input.ShipperPhone;
                item.FK_Post = input.FK_Post;
                item.UserName = input.UserName;
                item.Password = input.Password;
                item.BalanceValue = 0;
                item.IsDelete = false;
                //Change Database
                dc.GExpshipper.InsertOnSubmit(base.ConnectionData.Schema, item);
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
        /// Update GExpShipper 
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Update(String Id, NhanVienGiaoHangLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpShipper item = dc.GExpshipper.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    // Mapping Prop
                    item.ShipperName = input.ShipperName;
                    item.ShipperPhone = input.ShipperPhone;
                    item.FK_Post = input.FK_Post;
                    item.UserName = input.UserName;
                    item.Password = input.Password;
                    //Change Database
                    dc.GExpshipper.Update(base.ConnectionData.Schema, item);
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
        /// Delete GExpShipper
        /// </summary>
        public async Task<bool> Delete(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpShipper item = dc.GExpshipper.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    //Delete master
                    item.IsDelete = true;
                    dc.GExpshipper.Update(base.ConnectionData.Schema, item);
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
        /// <returns>view_GexpShipper</returns>
        public async Task<view_GexpShipper> CreateOrUpdateMasterOnly(String Id, NhanVienGiaoHangLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                GExpShipper item = dc.GExpshipper.GetObject(base.ConnectionData.Schema, Id);
                if (item == null)
                {
                    insert = true;
                    item = new GExpShipper();
                    item.Id = Guid.NewGuid().ToString();
                }
                // Update Value
                item.ShipperName = input.ShipperName;
                item.ShipperPhone = input.ShipperPhone;
                item.FK_Post = input.FK_Post;
                item.UserName = input.UserName;
                item.Password = input.Password;
                if (insert)
                {
                    dc.GExpshipper.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.GExpshipper.Update(base.ConnectionData.Schema, item);
                }

                // Get lại giá trị của Master
                view_GexpShipper returnItem = dc.VIewgexpshipper.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", item.Id);
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
    }
}

