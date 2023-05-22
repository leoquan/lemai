using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class UngCODKHLogic : BaseLogic
    {
        public UngCODKHLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        /// <summary>
        /// Get all view_ExpLoanCod List
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_ExpLoanCod>> GetList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexploancod.GetListObject(base.ConnectionData.Schema);
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
        /// Tìm view_ExpLoanCod theo keyword
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_ExpLoanCod>> GetList(string keyword)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE BillCode like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY BillCode asc";
                return dc.VIewexploancod.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        public async Task<List<GExpDoiSoatHistory>> GetListHistory(string keyword)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE BillCode like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY BillCode asc";
                return dc.GExpdoisoathistory.GetListObjectLimitCon(base.ConnectionData.Schema, "*", condition, 100, 0);
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
        /// Danh sách view_ExpLoanCod theo giới hạn keyword và page
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="page">Số trang hiển thị</param>
        /// <returns></returns>
        public async Task<List<view_ExpLoanCod>> GetPage(string keyword, int? page)
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
        /// Danh sách view_ExpLoanCod theo giới hạn keyword, Take, Skip
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<List<view_ExpLoanCod>> GetPage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE BillCode like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY BillCode asc";
                return dc.VIewexploancod.GetListObjectLimitCon(base.ConnectionData.Schema, "*", condition, Take, Skip);
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
        /// Tuple Danh sách view_ExpLoanCod theo giới hạn keyword, Take, Skip và số dòng dữ liệu
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<Tuple<List<view_ExpLoanCod>, int>> GetTuplePage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                var list = dc.VIewexploancod.GetListObject(base.ConnectionData.Schema);
                var data = await GetPage(keyword, Take, Skip);
                return new Tuple<List<view_ExpLoanCod>, int>(data, list.Count);
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
        /// Get List of SameUngCODKHLogic
        /// </summary>
        /// <param name="BillCode">BillCode Of ExpLoanCod</param>
        /// <returns></returns>
        public async Task<List<view_ExpLoanCod>> GetSameList(String BillCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int take = 10;
                return dc.VIewexploancod.GetListObjectLimitCon(base.ConnectionData.Schema, "*", "WHERE BillCode<>@BillCode  ", take, 0, "@BillCode", BillCode);
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
        /// Get view_ExpLoanCod Object
        /// </summary>
        /// <param name="BillCode">BillCode Of ExpLoanCod</param>
        /// <returns></returns>
        public async Task<view_ExpLoanCod> GetDetails(String BillCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexploancod.GetObjectCon(base.ConnectionData.Schema, " WHERE BillCode=@BillCode ", "@BillCode", BillCode);
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
        public async Task<GExpDoiSoatHistory> GetDetailsHistory(String BillCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExpdoisoathistory.GetObjectCon(base.ConnectionData.Schema, " WHERE BillCode=@BillCode ", "@BillCode", BillCode);
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
        /// Create a ExpLoanCod Object into Database
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ExpLoanCod> Create(UngCODKHLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                if (input.IsGiaoHangThanhCong == true)
                {

                    ExpLoanCod item = dc.EXploancod.GetObject(base.ConnectionData.Schema, input.BillCode);
                    if (item == null)
                    {
                        // Mapping Prop
                        item.BillCode = input.BillCode;
                        item.FK_Account = input.FK_Account;
                        item.CreateBy = input.CreateBy;
                        item.CreateDate = DateTime.Now;
                        item.Value = input.Value;
                        item.IsBoiThuong = input.IsGiaoHangThanhCong;
                        //Change Database
                        dc.EXploancod.InsertOnSubmit(base.ConnectionData.Schema, item);
                        dc.SubmitChanges();
                    }
                    else
                    {
                        item = new ExpLoanCod();
                    }
                    return item;
                }
                else
                {
                    string[] bills = input.BillCode.Trim().TrimEnd(',').Split(',');
                    ExpLoanCod item = new ExpLoanCod();
                    foreach (var bill in bills)
                    {
                        item = dc.EXploancod.GetObject(base.ConnectionData.Schema, bill);
                        if (item == null)
                        {
                            item = new ExpLoanCod();
                            item.BillCode = bill;
                            item.FK_Account = input.FK_Account;
                            item.CreateBy = input.CreateBy;
                            item.CreateDate = DateTime.Now;
                            item.Value = input.Value;
                            item.IsBoiThuong = input.IsGiaoHangThanhCong;
                            dc.EXploancod.InsertOnSubmit(base.ConnectionData.Schema, item);
                        }
                    }
                    //Change Database
                    dc.SubmitChanges();
                    return item;
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
        public async Task<int> CreateHistory(UngCODKHLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int count = 0;
                string[] bills = input.BillCode.Trim().TrimEnd(',').Split(',');
                DateTime current = dc.CurrentTime();
                foreach (var billId in bills)
                {
                    GExpDoiSoatHistory item = dc.GExpdoisoathistory.GetObject(base.ConnectionData.Schema, billId);
                    GExpBill billItem = dc.GExpbill.GetObject(base.ConnectionData.Schema, billId);
                    if (item == null && billItem != null)
                    {
                        count++;
                        item = new GExpDoiSoatHistory();
                        item.BillCode = billId;
                        item.FK_Account = input.FK_Account;
                        item.CreateDate = current;
                        dc.GExpdoisoathistory.InsertOnSubmit(base.ConnectionData.Schema, item);
                        // Update bill status
                        billItem.IsPayCustomer = true;
                        billItem.PayCustomerDate = current;
                        if (input.IsGiaoHangThanhCong)
                        {
                            // Giao thành công
                            billItem.BillStatus = 6;
                        }
                        else
                        {
                            // Hoàn
                            billItem.BillStatus = 8;
                        }

                        if (billItem.IsSigned == false)
                        {
                            billItem.IsSigned = true;
                            billItem.SignedDate = current;
                        }
                        dc.GExpbill.Update(base.ConnectionData.Schema, billItem);
                    }
                }
                dc.SubmitChanges();
                return count;

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
        /// Update ExpLoanCod 
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Update(String BillCode, UngCODKHLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpLoanCod item = dc.EXploancod.GetObject(base.ConnectionData.Schema, BillCode);
                if (item != null)
                {
                    // Mapping Prop
                    item.BillCode = input.BillCode;
                    item.FK_Account = input.FK_Account;
                    item.CreateBy = input.CreateBy;
                    item.CreateDate = DateTime.Now;
                    item.Value = input.Value;
                    item.IsBoiThuong = input.IsGiaoHangThanhCong;
                    //Change Database
                    dc.EXploancod.Update(base.ConnectionData.Schema, item);
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
        /// Delete ExpLoanCod
        /// </summary>
        public async Task<bool> Delete(String BillCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpLoanCod item = dc.EXploancod.GetObject(base.ConnectionData.Schema, BillCode);
                if (item != null)
                {
                    //Delete master
                    dc.EXploancod.DeleteOnSubmit(base.ConnectionData.Schema, BillCode);
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
        public async Task<bool> DeleteHistory(String BillCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpDoiSoatHistory item = dc.GExpdoisoathistory.GetObject(base.ConnectionData.Schema, BillCode);
                if (item != null)
                {
                    //Delete master
                    dc.GExpdoisoathistory.DeleteOnSubmit(base.ConnectionData.Schema, BillCode);
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
        /// <returns>view_ExpLoanCod</returns>
        public async Task<view_ExpLoanCod> CreateOrUpdateMasterOnly(String BillCode, UngCODKHLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                ExpLoanCod item = dc.EXploancod.GetObject(base.ConnectionData.Schema, BillCode);
                if (item == null)
                {
                    insert = true;
                    item = new ExpLoanCod();
                    item.CreateDate = DateTime.Now;
                }
                // Update Value
                item.BillCode = input.BillCode;
                item.FK_Account = input.FK_Account;
                item.CreateBy = input.CreateBy;
                item.Value = input.Value;
                if (insert)
                {
                    dc.EXploancod.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.EXploancod.Update(base.ConnectionData.Schema, item);
                }

                // Get lại giá trị của Master
                view_ExpLoanCod returnItem = dc.VIewexploancod.GetObjectCon(base.ConnectionData.Schema, " WHERE BillCode=@BillCode ", "@BillCode", item.BillCode);
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

