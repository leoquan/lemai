using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class KyKetToanLogic : BaseLogic
    {
        public KyKetToanLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        /// <summary>
        /// Get all view_ExpKyKetToan List
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_ExpKyKetToan>> GetList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpkykettoan.GetListObject(base.ConnectionData.Schema);
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
        /// Tìm view_ExpKyKetToan theo keyword
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_ExpKyKetToan>> GetList(string keyword)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE TenKy like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY NgayTao asc";
                return dc.VIewexpkykettoan.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        /// Danh sách view_ExpKyKetToan theo giới hạn keyword và page
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="page">Số trang hiển thị</param>
        /// <returns></returns>
        public async Task<List<view_ExpKyKetToan>> GetPage(string keyword, int? page)
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
        /// Danh sách view_ExpKyKetToan theo giới hạn keyword, Take, Skip
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<List<view_ExpKyKetToan>> GetPage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE TenKy like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY NgayTao asc";
                return dc.VIewexpkykettoan.GetListObjectLimitCon(base.ConnectionData.Schema, "*", condition, Take, Skip);
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
        /// Tuple Danh sách view_ExpKyKetToan theo giới hạn keyword, Take, Skip và số dòng dữ liệu
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<Tuple<List<view_ExpKyKetToan>, int>> GetTuplePage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                var list = dc.VIewexpkykettoan.GetListObject(base.ConnectionData.Schema);
                var data = await GetPage(keyword, Take, Skip);
                return new Tuple<List<view_ExpKyKetToan>, int>(data, list.Count);
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
        /// Get List of SameKyKetToanLogic
        /// </summary>
        /// <param name="Id">Id Of ExpKyKetToan</param>
        /// <returns></returns>
        public async Task<List<view_ExpKyKetToan>> GetSameList(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int take = 10;
                return dc.VIewexpkykettoan.GetListObjectLimitCon(base.ConnectionData.Schema, "*", "WHERE Id<>@Id  ", take, 0, "@Id", Id);
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
        /// Get view_ExpKyKetToan Object
        /// </summary>
        /// <param name="Id">Id Of ExpKyKetToan</param>
        /// <returns></returns>
        public async Task<view_ExpKyKetToan> GetDetails(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpkykettoan.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", Id);
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
        /// Create a ExpKyKetToan Object into Database
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ExpKyKetToan> Create(KyKetToanLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpKyKetToan item = new ExpKyKetToan();

                // Mapping Prop
                item.Id = Guid.NewGuid().ToString();
                item.TenKy = input.TenKy;
                item.SoBangKe = input.SoBangKe;
                item.NgayTao = DateTime.Now;
                item.QuyenSoChi = input.QuyenSoChi;
                item.QuyenSoThu = input.QuyenSoThu;
                item.QuyenSoTongChi = input.QuyenSoTongChi;
                //Change Database
                dc.EXpkykettoan.InsertOnSubmit(base.ConnectionData.Schema, item);
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
        /// Update ExpKyKetToan 
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Update(String Id, KyKetToanLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpKyKetToan item = dc.EXpkykettoan.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    // Mapping Prop
                    item.TenKy = input.TenKy;
                    item.SoBangKe = input.SoBangKe;
                    item.NgayTao = DateTime.Now;
                    item.QuyenSoChi = input.QuyenSoChi;
                    item.QuyenSoThu = input.QuyenSoThu;
                    item.QuyenSoTongChi = input.QuyenSoTongChi;
                    //Change Database
                    dc.EXpkykettoan.Update(base.ConnectionData.Schema, item);
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
        /// Delete ExpKyKetToan
        /// </summary>
        public async Task<bool> Delete(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpKyKetToan item = dc.EXpkykettoan.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    //Delete master
                    dc.EXpkykettoan.DeleteOnSubmit(base.ConnectionData.Schema, Id);
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
        /// <returns>view_ExpKyKetToan</returns>
        public async Task<view_ExpKyKetToan> CreateOrUpdateMasterOnly(String Id, KyKetToanLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                ExpKyKetToan item = dc.EXpkykettoan.GetObject(base.ConnectionData.Schema, Id);
                if (item == null)
                {
                    insert = true;
                    item = new ExpKyKetToan();
                    item.Id = Guid.NewGuid().ToString();
                    item.NgayTao = DateTime.Now;
                    
                }
                // Update Value
                item.TenKy = input.TenKy;
                item.SoBangKe = input.SoBangKe;
                item.QuyenSoChi = input.QuyenSoChi;
                item.QuyenSoThu = input.QuyenSoThu;
                item.QuyenSoTongChi = input.QuyenSoTongChi;
                if (insert)
                {
                    dc.EXpkykettoan.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.EXpkykettoan.Update(base.ConnectionData.Schema, item);
                }

                // Get lại giá trị của Master
                view_ExpKyKetToan returnItem = dc.VIewexpkykettoan.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", item.Id);
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

