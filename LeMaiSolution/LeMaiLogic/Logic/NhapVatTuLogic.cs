using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class NhapVatTuLogic : BaseLogic
    {
        public NhapVatTuLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        /// <summary>
        /// Get all view_ExpSaleNhapVatTu List
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_ExpSaleNhapVatTu>> GetList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpsalenhapvattu.GetListObject(base.ConnectionData.Schema);
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
        /// Tìm view_ExpSaleNhapVatTu theo keyword
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_ExpSaleNhapVatTu>> GetList(string keyword)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE TenVatTu like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY NgayNhap asc";
                return dc.VIewexpsalenhapvattu.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        /// Danh sách view_ExpSaleNhapVatTu theo giới hạn keyword và page
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="page">Số trang hiển thị</param>
        /// <returns></returns>
        public async Task<List<view_ExpSaleNhapVatTu>> GetPage(string keyword, int? page)
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
        /// Danh sách view_ExpSaleNhapVatTu theo giới hạn keyword, Take, Skip
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<List<view_ExpSaleNhapVatTu>> GetPage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE TenVatTu like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY NgayNhap asc";
                return dc.VIewexpsalenhapvattu.GetListObjectLimitCon(base.ConnectionData.Schema, "*", condition, Take, Skip);
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
        /// Tuple Danh sách view_ExpSaleNhapVatTu theo giới hạn keyword, Take, Skip và số dòng dữ liệu
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<Tuple<List<view_ExpSaleNhapVatTu>, int>> GetTuplePage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                var list = dc.VIewexpsalenhapvattu.GetListObject(base.ConnectionData.Schema);
                var data = await GetPage(keyword, Take, Skip);
                return new Tuple<List<view_ExpSaleNhapVatTu>, int>(data, list.Count);
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
        /// Get List of SameNhapVatTuLogic
        /// </summary>
        /// <param name="Id">Id Of ExpSaleNhapVatTu</param>
        /// <returns></returns>
        public async Task<List<view_ExpSaleNhapVatTu>> GetSameList(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int take = 10;
                return dc.VIewexpsalenhapvattu.GetListObjectLimitCon(base.ConnectionData.Schema, "*", "WHERE Id<>@Id  ", take, 0, "@Id", Id);
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
        /// Get view_ExpSaleNhapVatTu Object
        /// </summary>
        /// <param name="Id">Id Of ExpSaleNhapVatTu</param>
        /// <returns></returns>
        public async Task<view_ExpSaleNhapVatTu> GetDetails(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpsalenhapvattu.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", Id);
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
        /// Create a ExpSaleNhapVatTu Object into Database
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ExpSaleNhapVatTu> Create(NhapVatTuLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpSaleNhapVatTu item = new ExpSaleNhapVatTu();

                // Mapping Prop
                item.Id = Guid.NewGuid().ToString();
                item.FK_VatTu = input.FK_VatTu;
                item.NgayNhap = DateTime.Now;
                item.NguoiNhap = input.NguoiNhap;
                item.SoLuong = input.SoLuong;
                item.DonGia = input.DonGia;
                item.ThanhTien = input.ThanhTien;
                // Cập nhật số lượng tồn vật tư
                ExpSaleVatTu vatTu = dc.EXpsalevattu.GetObject(base.ConnectionData.Schema, item.FK_VatTu);
                if (vatTu != null)
                {
                    vatTu.SoLuongTonKho = vatTu.SoLuongTonKho + item.SoLuong;
                    dc.EXpsalevattu.Update(base.ConnectionData.Schema, vatTu);
                }
                //Change Database
                dc.EXpsalenhapvattu.InsertOnSubmit(base.ConnectionData.Schema, item);
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
        /// Update ExpSaleNhapVatTu 
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Update(String Id, NhapVatTuLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpSaleNhapVatTu item = dc.EXpsalenhapvattu.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    decimal oldSoluong = item.SoLuong;
                    // Mapping Prop
                    item.FK_VatTu = input.FK_VatTu;
                    item.NgayNhap = DateTime.Now;
                    item.NguoiNhap = input.NguoiNhap;
                    item.SoLuong = input.SoLuong;
                    item.DonGia = input.DonGia;
                    item.ThanhTien = input.ThanhTien;
                    // Cập nhật số lượng tồn vật tư
                    ExpSaleVatTu vatTu = dc.EXpsalevattu.GetObject(base.ConnectionData.Schema, item.FK_VatTu);
                    if (vatTu != null)
                    {
                        vatTu.SoLuongTonKho = vatTu.SoLuongTonKho + item.SoLuong - oldSoluong;
                        dc.EXpsalevattu.Update(base.ConnectionData.Schema, vatTu);
                    }
                    //Change Database
                    dc.EXpsalenhapvattu.Update(base.ConnectionData.Schema, item);
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
        /// Delete ExpSaleNhapVatTu
        /// </summary>
        public async Task<bool> Delete(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpSaleNhapVatTu item = dc.EXpsalenhapvattu.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    ExpSaleVatTu vatTu = dc.EXpsalevattu.GetObject(base.ConnectionData.Schema, item.FK_VatTu);
                    if (vatTu != null)
                    {
                        vatTu.SoLuongTonKho = vatTu.SoLuongTonKho - item.SoLuong;
                        dc.EXpsalevattu.Update(base.ConnectionData.Schema, vatTu);
                    }
                    //Delete master
                    dc.EXpsalenhapvattu.DeleteOnSubmit(base.ConnectionData.Schema, Id);
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
        /// <returns>view_ExpSaleNhapVatTu</returns>
        public async Task<view_ExpSaleNhapVatTu> CreateOrUpdateMasterOnly(String Id, NhapVatTuLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                ExpSaleNhapVatTu item = dc.EXpsalenhapvattu.GetObject(base.ConnectionData.Schema, Id);
                if (item == null)
                {
                    insert = true;
                    item = new ExpSaleNhapVatTu();
                    item.Id = Guid.NewGuid().ToString();
                    item.NgayNhap = DateTime.Now;
                }
                // Update Value
                item.FK_VatTu = input.FK_VatTu;
                item.NguoiNhap = input.NguoiNhap;
                item.SoLuong = input.SoLuong;
                item.DonGia = input.DonGia;
                item.ThanhTien = input.ThanhTien;
                if (insert)
                {
                    dc.EXpsalenhapvattu.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.EXpsalenhapvattu.Update(base.ConnectionData.Schema, item);
                }

                // Get lại giá trị của Master
                view_ExpSaleNhapVatTu returnItem = dc.VIewexpsalenhapvattu.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", item.Id);
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
        /// Get data refer Master ExpSaleVatTu
        /// </summary>
        /// <returns>ExpSaleVatTu</returns>
        public async Task<List<ExpSaleVatTu>> GetMasterFK_VatTuList()
        {
            List<ExpSaleVatTu> ls = new List<ExpSaleVatTu>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.EXpsalevattu.GetListObject(ConnectionData.Schema);
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

