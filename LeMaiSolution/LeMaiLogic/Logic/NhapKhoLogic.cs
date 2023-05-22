using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class NhapKhoLogic : BaseLogic
    {
        public NhapKhoLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        /// <summary>
        /// Get all view_ExpNhapKho List
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_ExpNhapKho>> GetList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpnhapkho.GetListObject(base.ConnectionData.Schema);
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
        /// Tìm view_ExpNhapKho theo keyword
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_ExpNhapKho>> GetList(string keyword)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE TenSanPham like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY NgayNhapKho asc";
                return dc.VIewexpnhapkho.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        /// Danh sách view_ExpNhapKho theo giới hạn keyword và page
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="page">Số trang hiển thị</param>
        /// <returns></returns>
        public async Task<List<view_ExpNhapKho>> GetPage(string keyword, int? page)
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
        /// Danh sách view_ExpNhapKho theo giới hạn keyword, Take, Skip
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<List<view_ExpNhapKho>> GetPage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE TenSanPham like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY NgayNhapKho asc";
                return dc.VIewexpnhapkho.GetListObjectLimitCon(base.ConnectionData.Schema, "*", condition, Take, Skip);
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
        /// Tuple Danh sách view_ExpNhapKho theo giới hạn keyword, Take, Skip và số dòng dữ liệu
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<Tuple<List<view_ExpNhapKho>, int>> GetTuplePage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                var list = dc.VIewexpnhapkho.GetListObject(base.ConnectionData.Schema);
                var data = await GetPage(keyword, Take, Skip);
                return new Tuple<List<view_ExpNhapKho>, int>(data, list.Count);
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
        /// Get List of SameNhapKhoLogic
        /// </summary>
        /// <param name="Id">Id Of ExpNhapKho</param>
        /// <returns></returns>
        public async Task<List<view_ExpNhapKho>> GetSameList(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int take = 10;
                return dc.VIewexpnhapkho.GetListObjectLimitCon(base.ConnectionData.Schema, "*", "WHERE Id<>@Id  ", take, 0, "@Id", Id);
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
        /// Get view_ExpNhapKho Object
        /// </summary>
        /// <param name="Id">Id Of ExpNhapKho</param>
        /// <returns></returns>
        public async Task<view_ExpNhapKho> GetDetails(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpnhapkho.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", Id);
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
        /// Get view_ExpNhapKhoCt List Object
        /// </summary>
        /// <param name="Id">Id Of ExpNhapKho</param>
        /// <returns></returns>
        public async Task<List<view_ExpNhapKhoCt>> GetChildList(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpnhapkhoct.GetListObjectCon(base.ConnectionData.Schema,
                    "WHERE FK_NhapKho=@FK_NhapKho", "@FK_NhapKho", Id);

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
        /// Get view_ExpNhapKhoCt Object
        /// </summary>
        /// <param name="FK_NhapKho">FK_NhapKho Of ExpNhapKhoCt</param>
        /// <param name="FK_VatTu">FK_VatTu Of ExpNhapKhoCt</param>
        /// <returns></returns>
        public async Task<view_ExpNhapKhoCt> GetChildDetails(String FK_NhapKho, String FK_VatTu)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpnhapkhoct.GetObjectCon(base.ConnectionData.Schema, " WHERE FK_NhapKho=@FK_NhapKho ", "@FK_NhapKho", FK_NhapKho);
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
        /// Create a ExpNhapKho Object into Database
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ExpNhapKho> Create(NhapKhoLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpNhapKho item = new ExpNhapKho();
                // Mapping Prop
                item.Id = Guid.NewGuid().ToString();
                item.NgayNhapKho = DateTime.Now;
                item.FK_NguoiNhapKho = input.FK_NguoiNhapKho;
                item.FK_SanPham = input.FK_SanPham;
                item.SoLuong = input.SoLuong;
                item.DonGia = input.DonGia;
                item.ThanhTien = input.ThanhTien;
                item.GhiChu = input.GhiChu;
                //Change Database
                foreach (var child in input.lsExpNhapKhoCt)
                {
                    ExpNhapKhoCt childInsert = new ExpNhapKhoCt();
                    childInsert.FK_NhapKho = item.Id;
                    childInsert.FK_VatTu = child.FK_VatTu;
                    childInsert.SoLuong = child.SoLuong;
                    childInsert.DonGia = child.DonGia;
                    childInsert.ThanhTien = child.ThanhTien;
                    dc.EXpnhapkhoct.InsertOnSubmit(base.ConnectionData.Schema, childInsert);

                    ExpSaleVatTu vatTu = dc.EXpsalevattu.GetObject(base.ConnectionData.Schema, childInsert.FK_VatTu);
                    if (vatTu != null)
                    {
                        vatTu.SoLuongTonKho = vatTu.SoLuongTonKho + childInsert.SoLuong;
                        dc.EXpsalevattu.Update(base.ConnectionData.Schema, vatTu);
                    }

                }
                // Cập nhật sản phẩm
                ExpSaleProduct product = dc.EXpsaleproduct.GetObject(base.ConnectionData.Schema, item.FK_SanPham);
                if (product != null)
                {
                    product.SoLuongTon = product.SoLuongTon + item.SoLuong;
                    dc.EXpsaleproduct.Update(base.ConnectionData.Schema, product);
                }
                dc.EXpnhapkho.InsertOnSubmit(base.ConnectionData.Schema, item);
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
        /// Update ExpNhapKho 
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Update(String Id, NhapKhoLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpNhapKho item = dc.EXpnhapkho.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    decimal oldSoLuong = item.SoLuong;
                    // Mapping Prop
                    item.NgayNhapKho = DateTime.Now;
                    item.FK_NguoiNhapKho = input.FK_NguoiNhapKho;
                    item.FK_SanPham = input.FK_SanPham;
                    item.SoLuong = input.SoLuong;
                    item.DonGia = input.DonGia;
                    item.ThanhTien = input.ThanhTien;
                    item.GhiChu = input.GhiChu;

                    //Change Database
                    List<ExpNhapKhoCt> lsChild = dc.EXpnhapkhoct.GetListObjectCon(base.ConnectionData.Schema,
                    "WHERE FK_NhapKho=@FK_NhapKho", "@FK_NhapKho", item.Id);
                    foreach (var child in lsChild)
                    {
                        ExpSaleVatTu vatTu = dc.EXpsalevattu.GetObject(base.ConnectionData.Schema, child.FK_VatTu);
                        if (vatTu != null)
                        {
                            vatTu.SoLuongTonKho = vatTu.SoLuongTonKho - child.SoLuong;
                            dc.EXpsalevattu.Update(base.ConnectionData.Schema, vatTu);
                        }
                        dc.EXpnhapkhoct.DeleteOnSubmit(base.ConnectionData.Schema, child);
                    }

                    foreach (var child in input.lsExpNhapKhoCt)
                    {
                        ExpNhapKhoCt childInsert = new ExpNhapKhoCt();
                        childInsert.FK_NhapKho = item.Id;
                        childInsert.FK_VatTu = child.FK_VatTu;
                        childInsert.SoLuong = child.SoLuong;
                        childInsert.DonGia = child.DonGia;
                        childInsert.ThanhTien = child.ThanhTien;
                        dc.EXpnhapkhoct.InsertOnSubmit(base.ConnectionData.Schema, childInsert);

                        ExpSaleVatTu vatTu = dc.EXpsalevattu.GetObject(base.ConnectionData.Schema, childInsert.FK_VatTu);
                        if (vatTu != null)
                        {
                            vatTu.SoLuongTonKho = vatTu.SoLuongTonKho + childInsert.SoLuong;
                            dc.EXpsalevattu.Update(base.ConnectionData.Schema, vatTu);
                        }

                    }
                    // Cập nhật sản phẩm
                    ExpSaleProduct product = dc.EXpsaleproduct.GetObject(base.ConnectionData.Schema, item.FK_SanPham);
                    if (product != null)
                    {
                        product.SoLuongTon = product.SoLuongTon + item.SoLuong - oldSoLuong;
                        dc.EXpsaleproduct.Update(base.ConnectionData.Schema, product);
                    }

                    dc.EXpnhapkho.Update(base.ConnectionData.Schema, item);
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
        /// Delete ExpNhapKho
        /// </summary>
        public async Task<bool> Delete(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpNhapKho item = dc.EXpnhapkho.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    //Delete Child
                    List<ExpNhapKhoCt> lsChild = dc.EXpnhapkhoct.GetListObjectCon(base.ConnectionData.Schema,
                    "WHERE FK_NhapKho=@FK_NhapKho", "@FK_NhapKho", Id);
                    foreach (var child in lsChild)
                    {
                        ExpSaleVatTu vatTu = dc.EXpsalevattu.GetObject(base.ConnectionData.Schema, child.FK_VatTu);
                        if (vatTu != null)
                        {
                            vatTu.SoLuongTonKho = vatTu.SoLuongTonKho - child.SoLuong;
                            dc.EXpsalevattu.Update(base.ConnectionData.Schema, vatTu);
                        }
                        dc.EXpnhapkhoct.DeleteOnSubmit(base.ConnectionData.Schema, child);
                    }
                    //Delete master
                    ExpSaleProduct product = dc.EXpsaleproduct.GetObject(base.ConnectionData.Schema, item.FK_SanPham);
                    if (product != null)
                    {
                        product.SoLuongTon = product.SoLuongTon - item.SoLuong;
                        dc.EXpsaleproduct.Update(base.ConnectionData.Schema, product);
                    }
                    dc.EXpnhapkho.DeleteOnSubmit(base.ConnectionData.Schema, Id);

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
        /// Delete ExpNhapKho
        /// </summary>
        public async Task<bool> DeleteChild(String FK_NhapKho, String FK_VatTu)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpNhapKhoCt item = dc.EXpnhapkhoct.GetObject(base.ConnectionData.Schema, FK_NhapKho, FK_VatTu);
                if (item != null)
                {
                    //Delete Child
                    ExpSaleVatTu vatTu = dc.EXpsalevattu.GetObject(base.ConnectionData.Schema, item.FK_VatTu);
                    if (vatTu != null)
                    {
                        vatTu.SoLuongTonKho = vatTu.SoLuongTonKho - item.SoLuong;
                        dc.EXpsalevattu.Update(base.ConnectionData.Schema, vatTu);
                    }
                    dc.EXpnhapkhoct.DeleteOnSubmit(base.ConnectionData.Schema, FK_NhapKho, FK_VatTu);
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
        /// <returns>view_ExpNhapKho</returns>
        public async Task<view_ExpNhapKho> CreateOrUpdateMasterOnly(String Id, NhapKhoLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                ExpNhapKho item = dc.EXpnhapkho.GetObject(base.ConnectionData.Schema, Id);
                if (item == null)
                {
                    insert = true;
                    item = new ExpNhapKho();
                    item.Id = Guid.NewGuid().ToString();
                    item.NgayNhapKho = DateTime.Now;
                }
                // Update Value
                item.FK_NguoiNhapKho = input.FK_NguoiNhapKho;
                item.FK_SanPham = input.FK_SanPham;
                item.SoLuong = input.SoLuong;
                item.DonGia = input.DonGia;
                item.ThanhTien = input.ThanhTien;
                item.GhiChu = input.GhiChu;
                if (insert)
                {
                    dc.EXpnhapkho.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.EXpnhapkho.Update(base.ConnectionData.Schema, item);
                }

                // Get lại giá trị của Master
                view_ExpNhapKho returnItem = dc.VIewexpnhapkho.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", item.Id);
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
        /// <returns>view_ExpNhapKhoCt</returns>
        public async Task<view_ExpNhapKhoCt> CreateOrUpdateChildOnly(String FK_NhapKho, String FK_VatTu, childNhapKhoLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                ExpNhapKhoCt item = dc.EXpnhapkhoct.GetObject(base.ConnectionData.Schema, FK_NhapKho, FK_VatTu);
                if (item == null)
                {
                    insert = true;
                    item = new ExpNhapKhoCt();
                }
                item.FK_NhapKho = input.FK_NhapKho;
                item.FK_VatTu = input.FK_VatTu;
                item.SoLuong = input.SoLuong;
                item.DonGia = input.DonGia;
                item.ThanhTien = input.ThanhTien;
                if (insert)
                {
                    dc.EXpnhapkhoct.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.EXpnhapkhoct.Update(base.ConnectionData.Schema, item);
                }
                // Get lại giá trị của Child
                view_ExpNhapKhoCt returnItem = dc.VIewexpnhapkhoct.GetObjectCon(base.ConnectionData.Schema, " WHERE FK_NhapKho=@FK_NhapKho AND FK_VatTu=@FK_VatTu ", "@FK_NhapKho", FK_NhapKho, "@FK_VatTu", FK_VatTu);
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
        /// Get data refer Master ExpSaleProduct
        /// </summary>
        /// <returns>ExpSaleProduct</returns>
        public async Task<List<ExpSaleProduct>> GetMasterFK_SanPhamList()
        {
            List<ExpSaleProduct> ls = new List<ExpSaleProduct>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.EXpsaleproduct.GetListObject(ConnectionData.Schema);
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
        /// Get data refer Child ExpSaleVatTu
        /// </summary>
        /// <returns>ExpSaleVatTu</returns>
        public async Task<List<ExpSaleVatTu>> GetChildFK_VatTuList()
        {
            List<ExpSaleVatTu> ls = new List<ExpSaleVatTu>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();

                ls = dc.EXpsalevattu.GetListObject(ConnectionData.Schema);
                foreach (var item in ls)
                {
                    item.TenVatTu = item.TenVatTu + " (" + item.SoLuongTonKho.ToString() + ")";
                }
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

