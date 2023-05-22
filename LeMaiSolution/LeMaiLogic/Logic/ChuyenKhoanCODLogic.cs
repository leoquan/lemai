using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class ChuyenKhoanCODLogic : BaseLogic
    {
        public ChuyenKhoanCODLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        /// <summary>
        /// Get all view_ExpCODCK List
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_ExpCODCK>> GetList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpcodck.GetListObject(base.ConnectionData.Schema);
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
        /// Tìm view_ExpCODCK theo keyword
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_ExpCODCK>> GetList(string keyword, string post)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = " WHERE FK_Post='" + post + "' AND CreateDate >= '" + string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddMonths(-1)) + "'";
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " AND BILL_CODE like N'%" + keyword + "%'";
                }
                condition = condition + " ORDER BY CreateDate asc";
                return dc.VIewexpcodck.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        /// Danh sách view_ExpCODCK theo giới hạn keyword và page
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="page">Số trang hiển thị</param>
        /// <returns></returns>
        public async Task<List<view_ExpCODCK>> GetPage(string keyword, int? page)
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
        /// Danh sách view_ExpCODCK theo giới hạn keyword, Take, Skip
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<List<view_ExpCODCK>> GetPage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE BILL_CODE like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY CreateDate asc";
                return dc.VIewexpcodck.GetListObjectLimitCon(base.ConnectionData.Schema, "*", condition, Take, Skip);
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
        /// Tuple Danh sách view_ExpCODCK theo giới hạn keyword, Take, Skip và số dòng dữ liệu
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<Tuple<List<view_ExpCODCK>, int>> GetTuplePage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                var list = dc.VIewexpcodck.GetListObject(base.ConnectionData.Schema);
                var data = await GetPage(keyword, Take, Skip);
                return new Tuple<List<view_ExpCODCK>, int>(data, list.Count);
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
        /// Get List of SameChuyenKhoanCODLogic
        /// </summary>
        /// <param name="BILL_CODE">BILL_CODE Of ExpCODCK</param>
        /// <returns></returns>
        public async Task<List<view_ExpCODCK>> GetSameList(String BILL_CODE)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int take = 10;
                return dc.VIewexpcodck.GetListObjectLimitCon(base.ConnectionData.Schema, "*", "WHERE BILL_CODE<>@BILL_CODE  ", take, 0, "@BILL_CODE", BILL_CODE);
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
        /// Get view_ExpCODCK Object
        /// </summary>
        /// <param name="BILL_CODE">BILL_CODE Of ExpCODCK</param>
        /// <returns></returns>
        public async Task<view_ExpCODCK> GetDetails(String BILL_CODE)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpcodck.GetObjectCon(base.ConnectionData.Schema, " WHERE BILL_CODE=@BILL_CODE ", "@BILL_CODE", BILL_CODE);
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
        /// Create a ExpCODCK Object into Database
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ExpCODCK> Create(ChuyenKhoanCODLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpBill bill = dc.GExpbill.GetObject(base.ConnectionData.Schema, input.BILL_CODE);
                if (bill != null)
                {
                    ExpCODCK item = dc.EXpcodck.GetObject(base.ConnectionData.Schema, bill.BillCode);
                    if (item != null)
                    {
                        return null;
                    }
                    else
                    {
                        item = new ExpCODCK();
                        // Mapping Prop
                        item.BILL_CODE = input.BILL_CODE;
                        item.SoTienCKCOD = input.SoTienCKCOD;
                        item.FK_Post = input.FK_Post;
                        item.FK_Account = input.FK_Account;
                        item.CreateDate = DateTime.Now;
                        //Change Database
                        dc.EXpcodck.InsertOnSubmit(base.ConnectionData.Schema, item);
                        dc.SubmitChanges();
                        return item;
                    }
                }
                else
                {
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
        /// <summary>
        /// Update ExpCODCK 
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Update(String BILL_CODE, ChuyenKhoanCODLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpCODCK item = dc.EXpcodck.GetObject(base.ConnectionData.Schema, BILL_CODE);
                if (item != null)
                {
                    // Mapping Prop
                    item.BILL_CODE = input.BILL_CODE;
                    item.SoTienCKCOD = input.SoTienCKCOD;
                    item.FK_Post = input.FK_Post;
                    item.FK_Account = input.FK_Account;
                    item.CreateDate = DateTime.Now;

                    //Change Database
                    dc.EXpcodck.Update(base.ConnectionData.Schema, item);
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
        /// Delete ExpCODCK
        /// </summary>
        public async Task<bool> Delete(String BILL_CODE)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpCODCK item = dc.EXpcodck.GetObject(base.ConnectionData.Schema, BILL_CODE);
                if (item != null)
                {
                    //Delete master
                    dc.EXpcodck.DeleteOnSubmit(base.ConnectionData.Schema, BILL_CODE);
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
        /// <returns>view_ExpCODCK</returns>
        public async Task<view_ExpCODCK> CreateOrUpdateMasterOnly(String BILL_CODE, ChuyenKhoanCODLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                ExpCODCK item = dc.EXpcodck.GetObject(base.ConnectionData.Schema, BILL_CODE);
                if (item == null)
                {
                    insert = true;
                    item = new ExpCODCK();
                    item.CreateDate = DateTime.Now;
                }
                // Update Value
                item.BILL_CODE = input.BILL_CODE;
                item.SoTienCKCOD = input.SoTienCKCOD;
                item.FK_Post = input.FK_Post;
                item.FK_Account = input.FK_Account;
                if (insert)
                {
                    dc.EXpcodck.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.EXpcodck.Update(base.ConnectionData.Schema, item);
                }

                // Get lại giá trị của Master
                view_ExpCODCK returnItem = dc.VIewexpcodck.GetObjectCon(base.ConnectionData.Schema, " WHERE BILL_CODE=@BILL_CODE ", "@BILL_CODE", item.BILL_CODE);
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

