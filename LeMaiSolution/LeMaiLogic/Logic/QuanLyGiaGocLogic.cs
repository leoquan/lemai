using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class QuanLyGiaGocLogic : BaseLogic
    {
        public QuanLyGiaGocLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        /// <summary>
        /// Get all view_GExpFeeDebitSession List
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_GExpFeeDebitSession>> GetList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpfeedebitsession.GetListObject(base.ConnectionData.Schema);
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
        /// Tìm view_GExpFeeDebitSession theo keyword
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_GExpFeeDebitSession>> GetList(string keyword)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE TenDaiLy like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY MinWeightMN asc";
                return dc.VIewgexpfeedebitsession.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        /// Danh sách view_GExpFeeDebitSession theo giới hạn keyword và page
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="page">Số trang hiển thị</param>
        /// <returns></returns>
        public async Task<List<view_GExpFeeDebitSession>> GetPage(string keyword, int? page)
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
        /// Danh sách view_GExpFeeDebitSession theo giới hạn keyword, Take, Skip
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<List<view_GExpFeeDebitSession>> GetPage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE TenDaiLy like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY MinWeightMN asc";
                return dc.VIewgexpfeedebitsession.GetListObjectLimitCon(base.ConnectionData.Schema, "*", condition, Take, Skip);
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
        /// Tuple Danh sách view_GExpFeeDebitSession theo giới hạn keyword, Take, Skip và số dòng dữ liệu
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<Tuple<List<view_GExpFeeDebitSession>, int>> GetTuplePage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                var list = dc.VIewgexpfeedebitsession.GetListObject(base.ConnectionData.Schema);
                var data = await GetPage(keyword, Take, Skip);
                return new Tuple<List<view_GExpFeeDebitSession>, int>(data, list.Count);
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
        /// Get List of SameQuanLyGiaGocLogic
        /// </summary>
        /// <param name="Id">Id Of GExpFeeDebitSession</param>
        /// <returns></returns>
        public async Task<List<view_GExpFeeDebitSession>> GetSameList(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int take = 10;
                return dc.VIewgexpfeedebitsession.GetListObjectLimitCon(base.ConnectionData.Schema, "*", "WHERE Id<>@Id  ", take, 0, "@Id", Id);
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
        /// Get view_GExpFeeDebitSession Object
        /// </summary>
        /// <param name="Id">Id Of GExpFeeDebitSession</param>
        /// <returns></returns>
        public async Task<view_GExpFeeDebitSession> GetDetails(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpfeedebitsession.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", Id);
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
        /// Create a GExpFeeDebitSession Object into Database
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<GExpFeeDebitSession> Create(QuanLyGiaGocLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpFeeDebitSession item = new GExpFeeDebitSession();

                // Mapping Prop
                item.Id = Guid.NewGuid().ToString();
                item.FK_Post = input.FK_Post;
                item.MinWeightMN = input.MinWeightMN;
                item.MinWeightMT = input.MinWeightMT;
                item.MinWeightMB = input.MinWeightMB;
                item.MinFeeMN = input.MinFeeMN;
                item.MinFeeMT = input.MinFeeMT;
                item.MinFeeMB = input.MinFeeMB;
                item.NextFeeMN = input.NextFeeMN;
                item.NextFeeMT = input.NextFeeMT;
                item.NextFeeMB = input.NextFeeMB;
                item.MinWeightInt = input.MinWeightInt;
                item.MinFeeInt = input.MinFeeInt;
                item.NextFeeInt = input.NextFeeInt;
                item.StepWeightInt = input.StepWeightInt;
                item.StepWeightMB = input.StepWeightMB;
                item.StepWeightMT = input.StepWeightMT;
                item.StepWeightMN = input.StepWeightMN;
                item.ReturnFee = input.ReturnFee;
                item.Insurance = input.Insurance;
                item.CODFee = input.CODFee;

                //Change Database
                dc.GExpfeedebitsession.InsertOnSubmit(base.ConnectionData.Schema, item);
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
        /// Update GExpFeeDebitSession 
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Update(String Id, QuanLyGiaGocLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpFeeDebitSession item = dc.GExpfeedebitsession.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    // Mapping Prop
                    item.FK_Post = input.FK_Post;
                    item.MinWeightMN = input.MinWeightMN;
                    item.MinWeightMT = input.MinWeightMT;
                    item.MinWeightMB = input.MinWeightMB;
                    item.MinFeeMN = input.MinFeeMN;
                    item.MinFeeMT = input.MinFeeMT;
                    item.MinFeeMB = input.MinFeeMB;
                    item.NextFeeMN = input.NextFeeMN;
                    item.NextFeeMT = input.NextFeeMT;
                    item.NextFeeMB = input.NextFeeMB;
                    item.MinWeightInt = input.MinWeightInt;
                    item.MinFeeInt = input.MinFeeInt;
                    item.NextFeeInt = input.NextFeeInt;
                    item.StepWeightInt = input.StepWeightInt;
                    item.StepWeightMB = input.StepWeightMB;
                    item.StepWeightMT = input.StepWeightMT;
                    item.StepWeightMN = input.StepWeightMN;
                    item.ReturnFee = input.ReturnFee;
                    item.Insurance = input.Insurance;
                    item.CODFee = input.CODFee;

                    //Change Database
                    dc.GExpfeedebitsession.Update(base.ConnectionData.Schema, item);
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
        /// Delete GExpFeeDebitSession
        /// </summary>
        public async Task<bool> Delete(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpFeeDebitSession item = dc.GExpfeedebitsession.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    //Delete master
                    dc.GExpfeedebitsession.DeleteOnSubmit(base.ConnectionData.Schema, Id);
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
        /// <returns>view_GExpFeeDebitSession</returns>
        public async Task<view_GExpFeeDebitSession> CreateOrUpdateMasterOnly(String Id, QuanLyGiaGocLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                GExpFeeDebitSession item = dc.GExpfeedebitsession.GetObject(base.ConnectionData.Schema, Id);
                if (item == null)
                {
                    insert = true;
                    item = new GExpFeeDebitSession();
                    item.Id = Guid.NewGuid().ToString();
                }
                // Update Value
                item.FK_Post = input.FK_Post;
                item.MinWeightMN = input.MinWeightMN;
                item.MinWeightMT = input.MinWeightMT;
                item.MinWeightMB = input.MinWeightMB;
                item.MinFeeMN = input.MinFeeMN;
                item.MinFeeMT = input.MinFeeMT;
                item.MinFeeMB = input.MinFeeMB;
                item.NextFeeMN = input.NextFeeMN;
                item.NextFeeMT = input.NextFeeMT;
                item.NextFeeMB = input.NextFeeMB;
                item.MinWeightInt = input.MinWeightInt;
                item.MinFeeInt = input.MinFeeInt;
                item.NextFeeInt = input.NextFeeInt;
                item.StepWeightInt = input.StepWeightInt;
                item.StepWeightMB = input.StepWeightMB;
                item.StepWeightMT = input.StepWeightMT;
                item.StepWeightMN = input.StepWeightMN;
                item.ReturnFee = input.ReturnFee;
                item.Insurance = input.Insurance;
                item.CODFee = input.CODFee;
                if (insert)
                {
                    dc.GExpfeedebitsession.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.GExpfeedebitsession.Update(base.ConnectionData.Schema, item);
                }

                // Get lại giá trị của Master
                view_GExpFeeDebitSession returnItem = dc.VIewgexpfeedebitsession.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", item.Id);
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

