using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class QuanLyBangGiaLogic : BaseLogic
    {
        public QuanLyBangGiaLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        /// <summary>
        /// Get all view_GExpFee List
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_GExpFee>> GetFeeList(string post)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpfee.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post", "@FK_Post", post);
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
        /// Tìm view_GExpFee theo keyword
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_GExpFee>> GetList(string keyword)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE FeeName like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY FeeName asc, DefaultFee asc";
                return dc.VIewgexpfee.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        /// Danh sách view_GExpFee theo giới hạn keyword và page
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="page">Số trang hiển thị</param>
        /// <returns></returns>
        public async Task<List<view_GExpFee>> GetPage(string keyword, int? page)
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
        /// Danh sách view_GExpFee theo giới hạn keyword, Take, Skip
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<List<view_GExpFee>> GetPage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE FeeName like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY FeeName asc, DefaultFee asc";
                return dc.VIewgexpfee.GetListObjectLimitCon(base.ConnectionData.Schema, "*", condition, Take, Skip);
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
        /// Tuple Danh sách view_GExpFee theo giới hạn keyword, Take, Skip và số dòng dữ liệu
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<Tuple<List<view_GExpFee>, int>> GetTuplePage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                var list = dc.VIewgexpfee.GetListObject(base.ConnectionData.Schema);
                var data = await GetPage(keyword, Take, Skip);
                return new Tuple<List<view_GExpFee>, int>(data, list.Count);
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
        /// Get List of SameQuanLyBangGiaLogic
        /// </summary>
        /// <param name="Id">Id Of GExpFee</param>
        /// <returns></returns>
        public async Task<List<view_GExpFee>> GetSameList(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int take = 10;
                return dc.VIewgexpfee.GetListObjectLimitCon(base.ConnectionData.Schema, "*", "WHERE Id<>@Id  ", take, 0, "@Id", Id);
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
        /// Get view_GExpFee Object
        /// </summary>
        /// <param name="Id">Id Of GExpFee</param>
        /// <returns></returns>
        public async Task<view_GExpFee> GetDetails(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpfee.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", Id);
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
        /// Get view_GExpFeeDetails List Object
        /// </summary>
        /// <param name="Id">Id Of GExpFee</param>
        /// <returns></returns>
        public async Task<List<view_GExpFeeDetails>> GetChildList(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpfeedetails.GetListObjectCon(base.ConnectionData.Schema,
                    "WHERE FK_GExpFee=@FK_GExpFee ORDER BY MinWeightInt",
                    "@FK_GExpFee", Id);
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
        /// Get view_GExpFeeDetails Object
        /// </summary>
        /// <param name="Id">Id Of GExpFeeDetail</param>
        /// <returns></returns>
        public async Task<view_GExpFeeDetails> GetChildDetails(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpfeedetails.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", Id);
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
        /// Create a GExpFee Object into Database
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<GExpFee> Create(QuanLyBangGiaLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpFee item = new GExpFee();
                item.Id = Guid.NewGuid().ToString();
                item.FK_Post = input.FK_Post;
                item.FeeName = input.FeeName;
                item.DefaultFee = input.DefaultFee;

                //Change Database
                foreach (var child in input.lsGExpFeeDetail)
                {
                    GExpFeeDetail childInsert = new GExpFeeDetail();
                    childInsert.Id = Guid.NewGuid().ToString();
                    childInsert.FK_GExpFee = item.Id;
                    childInsert.MinWeightMN = child.MinWeightMN;
                    childInsert.MinWeightMT = child.MinWeightMT;
                    childInsert.MinWeightMB = child.MinWeightMB;
                    childInsert.MinFeeMN = child.MinFeeMN;
                    childInsert.MinFeeMT = child.MinFeeMT;
                    childInsert.MinFeeMB = child.MinFeeMB;
                    childInsert.StepWeight = child.StepWeight;
                    childInsert.NextFeeMN = child.NextFeeMN;
                    childInsert.NextFeeMT = child.NextFeeMT;
                    childInsert.NextFeeMB = child.NextFeeMB;
                    childInsert.MinWeightInt = child.MinWeightInt;
                    childInsert.MinFeeInt = child.MinFeeInt;
                    childInsert.NextFeeInt = child.NextFeeInt;
                    childInsert.StepWeightInt = child.StepWeightInt;
                    childInsert.StepWeightMB = child.StepWeightMB;
                    childInsert.StepWeightMT = child.StepWeightMT;
                    childInsert.StepWeightMN = child.StepWeightMN;
                    dc.GExpfeedetail.InsertOnSubmit(base.ConnectionData.Schema, childInsert);
                }
                dc.GExpfee.InsertOnSubmit(base.ConnectionData.Schema, item);
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
        /// Update GExpFee 
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Update(String Id, QuanLyBangGiaLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpFee item = dc.GExpfee.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    // Mapping Prop
                    item.FK_Post = input.FK_Post;
                    item.FeeName = input.FeeName;
                    item.DefaultFee = input.DefaultFee;
                    //Change Database
                    dc.GExpfeedetail.DeleteOnSubmitCon(base.ConnectionData.Schema,
                    "WHERE FK_GExpFee=@FK_GExpFee",
                    "@FK_GExpFee", Id);
                    foreach (var child in input.lsGExpFeeDetail)
                    {
                        GExpFeeDetail childInsert = new GExpFeeDetail();
                        childInsert.Id = Guid.NewGuid().ToString();
                        childInsert.FK_GExpFee = item.Id;
                        childInsert.MinWeightMN = child.MinWeightMN;
                        childInsert.MinWeightMT = child.MinWeightMT;
                        childInsert.MinWeightMB = child.MinWeightMB;
                        childInsert.MinFeeMN = child.MinFeeMN;
                        childInsert.MinFeeMT = child.MinFeeMT;
                        childInsert.MinFeeMB = child.MinFeeMB;
                        childInsert.StepWeight = child.StepWeight;
                        childInsert.NextFeeMN = child.NextFeeMN;
                        childInsert.NextFeeMT = child.NextFeeMT;
                        childInsert.NextFeeMB = child.NextFeeMB;
                        childInsert.MinWeightInt = child.MinWeightInt;
                        childInsert.MinFeeInt = child.MinFeeInt;
                        childInsert.NextFeeInt = child.NextFeeInt;
                        childInsert.StepWeightInt = child.StepWeightInt;
                        childInsert.StepWeightMB = child.StepWeightMB;
                        childInsert.StepWeightMT = child.StepWeightMT;
                        childInsert.StepWeightMN = child.StepWeightMN;
                        dc.GExpfeedetail.InsertOnSubmit(base.ConnectionData.Schema, childInsert);
                    }
                    dc.GExpfee.Update(base.ConnectionData.Schema, item);
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
        /// Delete GExpFee
        /// </summary>
        public async Task<bool> Delete(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpFee item = dc.GExpfee.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    //Delete Child
                    dc.GExpfeedetail.DeleteOnSubmitCon(base.ConnectionData.Schema,
                    "WHERE FK_GExpFee=@FK_GExpFee",
                    "@FK_GExpFee", Id);
                    //Delete master
                    dc.GExpfee.DeleteOnSubmit(base.ConnectionData.Schema, Id);
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
        /// Delete GExpFee
        /// </summary>
        public async Task<bool> DeleteChild(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpFeeDetail item = dc.GExpfeedetail.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    //Delete Child
                    dc.GExpfeedetail.DeleteOnSubmit(base.ConnectionData.Schema, Id);
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
        /// <returns>view_GExpFee</returns>
        public async Task<view_GExpFee> CreateOrUpdateMasterOnly(String Id, QuanLyBangGiaLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                GExpFee item = dc.GExpfee.GetObject(base.ConnectionData.Schema, Id);
                if (item == null)
                {
                    insert = true;
                    item = new GExpFee();
                    item.Id = Guid.NewGuid().ToString();
                }
                // Update Value
                item.FK_Post = input.FK_Post;
                item.FeeName = input.FeeName;
                item.DefaultFee = input.DefaultFee;
                if (insert)
                {
                    dc.GExpfee.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.GExpfee.Update(base.ConnectionData.Schema, item);
                }

                // Get lại giá trị của Master
                view_GExpFee returnItem = dc.VIewgexpfee.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", item.Id);
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
        /// <returns>view_GExpFeeDetails</returns>
        public async Task<view_GExpFeeDetails> CreateOrUpdateChildOnly(String Id, childQuanLyBangGiaLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                GExpFeeDetail item = dc.GExpfeedetail.GetObject(base.ConnectionData.Schema, Id);
                if (item == null)
                {
                    insert = true;
                    item = new GExpFeeDetail();
                    item.Id = Guid.NewGuid().ToString();
                }
                item.MinWeightMN = input.MinWeightMN;
                item.MinWeightMT = input.MinWeightMT;
                item.MinWeightMB = input.MinWeightMB;
                item.MinFeeMN = input.MinFeeMN;
                item.MinFeeMT = input.MinFeeMT;
                item.MinFeeMB = input.MinFeeMB;
                item.StepWeight = input.StepWeight;
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
                if (insert)
                {
                    dc.GExpfeedetail.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.GExpfeedetail.Update(base.ConnectionData.Schema, item);
                }
                // Get lại giá trị của Child
                view_GExpFeeDetails returnItem = dc.VIewgexpfeedetails.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", item.Id);
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
        public async Task<List<GExpFeeProvinceDetail>> GetListFeeProvince(string FeeId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExpfeeprovincedetail.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_GExpFee=@FK_GExpFee ORDER BY MinWeight", "@FK_GExpFee", FeeId);
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
        public async Task<bool> AddFeeProvineDetail(List<GExpFeeProvinceDetail> list, string FeeId, int ProvineId, string district)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                dc.GExpfeeprovincedetail.DeleteOnSubmitCon(base.ConnectionData.Schema, "WHERE FK_GExpFee=@FK_GExpFee", "@FK_GExpFee", FeeId);
                foreach (var item in list)
                {
                    item.FK_GExpFee = FeeId;
                    item.ProvineId = ProvineId;
                    item.District = district;
                    dc.GExpfeeprovincedetail.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
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

