using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class ExpConsignmentV2Logic : BaseLogic
    {
        public ExpConsignmentV2Logic(BaseLogicConnectionData data) : base(data)
        {
        }
        
        public async Task<view_ExpConsignmentObject> GetExpConsignmentObject(string Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpconsignmentobject.GetObjectCon(base.ConnectionData.Schema, "WHERE Id=@Id", "@Id", Id);
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
        public void InserDataBalance(ExpCheckBalance balance, List<ExpCheckBalanceDetail> lsDetail)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                dc.EXpcheckbalance.InsertOnSubmit(base.ConnectionData.Schema, balance);
                dc.EXpcheckbalancedetail.InsertAllSubmit(base.ConnectionData.Schema, lsDetail);
                dc.SubmitChanges();
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
        /// Get all view_ExpConsignment List
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_ExpConsignment>> GetList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpconsignment.GetListObject(base.ConnectionData.Schema);
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
        /// Danh sách view_ExpConsignment theo giới hạn keyword và page
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="page">Số trang hiển thị</param>
        /// <returns></returns>
        public async Task<List<view_ExpConsignment>> GetPage(string keyword, int? page)
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
        /// Danh sách view_ExpConsignment theo giới hạn keyword, Take, Skip
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<List<view_ExpConsignment>> GetPage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE MaDonHang like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY MaDonHang asc";
                return dc.VIewexpconsignment.GetListObjectLimitCon(base.ConnectionData.Schema, "*", condition, Take, Skip);
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
        /// Tuple Danh sách view_ExpConsignment theo giới hạn keyword, Take, Skip và số dòng dữ liệu
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<Tuple<List<view_ExpConsignment>, int>> GetTuplePage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                var list = dc.VIewexpconsignment.GetListObject(base.ConnectionData.Schema);
                var data = await GetPage(keyword, Take, Skip);
                return new Tuple<List<view_ExpConsignment>, int>(data, list.Count);
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
        /// Get List of SameExpConsignmentV2Logic
        /// </summary>
        /// <param name="Id">Id Of ExpConsignment</param>
        /// <returns></returns>
        public async Task<List<view_ExpConsignment>> GetSameList(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int take = 10;
                return dc.VIewexpconsignment.GetListObjectLimitCon(base.ConnectionData.Schema, "*", "WHERE Id<>@Id  ", take, 0, "@Id", Id);
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
        /// Get view_ExpConsignment Object
        /// </summary>
        /// <param name="Id">Id Of ExpConsignment</param>
        /// <returns></returns>
        public async Task<view_ExpConsignment> GetDetails(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpconsignment.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", Id);
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
        /// Create a ExpConsignment Object into Database
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ExpConsignment> Create(ExpConsignmentV2LogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpConsignment item = new ExpConsignment();

                // Mapping Prop
                item.Id = Guid.NewGuid().ToString();
                item.MaDonHang = input.FK_ExpPostFrom + ExpGetCode(input.FK_ExpPostFrom, "EXPCode").ToString().PadLeft(6, '0'); ;
                item.TenHang = input.TenHang;
                item.SoLuong = input.SoLuong;
                item.TrongLuongGram = input.TrongLuongGram;
                item.GiaTriTienHang = input.GiaTriTienHang;
                item.FK_YeuCauKhiGiao = input.FK_YeuCauKhiGiao;
                item.YeuCauKhac = input.YeuCauKhac;
                if (string.IsNullOrEmpty(input.FK_NguoiGui))
                {
                    if (input.SoDienThoaiNguoiGui != input.SoDienThoaiNguoiNhan)
                    {
                        // Thêm người gửi
                        item.FK_NguoiGui = Guid.NewGuid().ToString();
                        ExpConsignmentObject objExp = new ExpConsignmentObject();
                        objExp.Id = item.FK_NguoiGui;
                        objExp.FullName = input.NguoiGui;
                        objExp.DiaChi = input.DiaChiNguoiGui;
                        objExp.FK_DonViHC = input.FK_DVHCNguoiGui;
                        objExp.IsProvider = false;
                        objExp.SoDienThoai = input.SoDienThoaiNguoiGui;
                        objExp.SoNha = input.SoNhaNguoiGui;
                        dc.EXpconsignmentobject.InsertOnSubmit(ConnectionData.Schema, objExp);
                    }
                    else
                    {
                        item.FK_NguoiGui = item.FK_NguoiNhan;
                    }
                }
                else
                {
                    item.FK_NguoiGui = input.FK_NguoiGui;
                    // Update lại thông tin người gửi
                    ExpConsignmentObject objExp = dc.EXpconsignmentobject.GetObject(ConnectionData.Schema, item.FK_NguoiGui);
                    objExp.FullName = input.NguoiGui;
                    objExp.DiaChi = input.DiaChiNguoiGui;
                    objExp.FK_DonViHC = input.FK_DVHCNguoiGui;
                    objExp.IsProvider = false;
                    objExp.SoDienThoai = input.SoDienThoaiNguoiGui;
                    objExp.SoNha = input.SoNhaNguoiGui;
                    dc.EXpconsignmentobject.Update(ConnectionData.Schema, objExp);

                }
                if (string.IsNullOrEmpty(input.FK_NguoiNhan))
                {
                    // Thêm người nhận
                    item.FK_NguoiNhan = Guid.NewGuid().ToString();
                    ExpConsignmentObject objExp = new ExpConsignmentObject();
                    objExp.Id = item.FK_NguoiNhan;
                    objExp.FullName = input.NguoiNhan;
                    objExp.DiaChi = input.DiaChiNguoiNhan;
                    objExp.FK_DonViHC = input.FK_DVHCNguoiNhan;
                    objExp.IsProvider = false;
                    objExp.SoDienThoai = input.SoDienThoaiNguoiNhan;
                    objExp.SoNha = input.SoNhaNguoiNhan;
                    dc.EXpconsignmentobject.InsertOnSubmit(ConnectionData.Schema, objExp);
                }
                else
                {
                    item.FK_NguoiNhan = input.FK_NguoiNhan;
                    // Update lại thông tin người nhận
                    ExpConsignmentObject objExp = dc.EXpconsignmentobject.GetObject(ConnectionData.Schema, item.FK_NguoiNhan);
                    objExp.FullName = input.NguoiNhan;
                    objExp.DiaChi = input.DiaChiNguoiNhan;
                    objExp.FK_DonViHC = input.FK_DVHCNguoiNhan;
                    objExp.IsProvider = false;
                    objExp.SoDienThoai = input.SoDienThoaiNguoiNhan;
                    objExp.SoNha = input.SoNhaNguoiNhan;
                    dc.EXpconsignmentobject.Update(ConnectionData.Schema, objExp);

                }
                item.FK_LoaiMatHang = input.FK_LoaiMatHang;
                item.FK_ExpProvider = input.FK_ExpProvider;
                item.FK_CachVanChuyen = input.FK_CachVanChuyen;
                item.FK_CachGiaoHang = input.FK_CachGiaoHang;
                item.FK_CachThanhToan = input.FK_CachThanhToan;
                item.FK_CaLamViec = input.FK_CaLamViec;
                item.FK_NguoiThuHang = input.FK_NguoiThuHang;
                item.FK_ExpPostFrom = input.FK_ExpPostFrom;
                item.FK_ExpPostTo = input.FK_ExpPostTo;
                item.CreateDate = DateTime.Now;
                item.CreateBy = input.CreateBy;
                item.CuocPhiChinh = input.CuocPhiChinh;
                item.CuocCongThem = input.CuocCongThem;
                item.PhuPhi = input.PhuPhi;
                item.ThuHo = input.ThuHo;
                item.TongCuoc = input.TongCuoc;
                item.FK_NhanVienPhat = input.FK_NhanVienPhat;
                item.HoTenNguoiKyNhan = input.HoTenNguoiKyNhan;
                item.NguoiGui = input.NguoiGui;
                item.SoDienThoaiNguoiGui = input.SoDienThoaiNguoiGui;
                item.FK_DVHCNguoiGui = input.FK_DVHCNguoiGui;
                item.SoNhaNguoiGui = input.SoNhaNguoiGui;
                item.DiaChiNguoiGui = input.DiaChiNguoiGui;
                item.NguoiNhan = input.NguoiNhan;
                item.SoDienThoaiNguoiNhan = input.SoDienThoaiNguoiNhan;
                item.FK_DVHCNguoiNhan = input.FK_DVHCNguoiNhan;
                item.SoNhaNguoiNhan = input.SoNhaNguoiNhan;
                item.DiaChiNguoiNhan = input.DiaChiNguoiNhan;
                item.PrintNumber = 0;
                item.FK_ExpStatus = "NEW";
                // History
                ExpConsignmentHistory history = new ExpConsignmentHistory();
                history.CreateDate = item.CreateDate;
                history.FK_ExpConsignment = item.Id;
                history.FK_ExpStatus = item.FK_ExpStatus;
                history.FK_ExpPost = item.FK_ExpPostFrom;
                history.Id = Guid.NewGuid().ToString();
                history.Note = "Tiếp nhận đơn hàng từ khách hàng";
                history.CreateBy = item.CreateBy;
                // Insert History
                dc.EXpconsignmenthistory.InsertOnSubmit(ConnectionData.Schema, history);
                // CashPay
                if (item.FK_CachThanhToan == "01")
                {
                    ExpCashPay cashPay = new ExpCashPay();
                    cashPay.Id = Guid.NewGuid().ToString();
                    cashPay.CreateBy = item.CreateBy;
                    cashPay.CreateDate = item.CreateDate;
                    cashPay.SoChungTu = item.MaDonHang;
                    cashPay.FK_ExtPost = item.FK_ExpPostFrom;
                    cashPay.MaNguoiNopNhan = item.FK_NguoiGui;
                    cashPay.TenNguoiNopNhan = item.NguoiGui;
                    cashPay.DiaChi = item.DiaChiNguoiGui;
                    cashPay.SoDienThoai = item.SoDienThoaiNguoiGui;
                    cashPay.IsPay = false;
                    cashPay.IsDelete = false;
                    cashPay.Note = "Thu cước phí của người gửi mã " + item.MaDonHang;
                    cashPay.Value = item.CuocPhiChinh + item.CuocCongThem + item.PhuPhi;
                    cashPay.Type = "CASH_SHIP";
                    cashPay.PrintCopied = 0;
                    dc.EXpcashpay.InsertOnSubmit(base.ConnectionData.Schema, cashPay);
                    // Update ExpPost
                    ExpPost post = dc.EXppost.GetObject(base.ConnectionData.Schema, cashPay.FK_ExtPost);
                    post.ValueBlanceMoney = post.ValueBlanceMoney + cashPay.Value;
                    dc.EXppost.Update(base.ConnectionData.Schema, post);
                }

                dc.EXpconsignment.InsertOnSubmit(base.ConnectionData.Schema, item);
                //Change Database
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
        /// Update ExpConsignment 
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Update(String Id, ExpConsignmentV2LogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpConsignment item = dc.EXpconsignment.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    // Mapping Prop
                    item.TenHang = input.TenHang;
                    item.SoLuong = input.SoLuong;
                    item.TrongLuongGram = input.TrongLuongGram;
                    item.GiaTriTienHang = input.GiaTriTienHang;
                    item.FK_YeuCauKhiGiao = input.FK_YeuCauKhiGiao;
                    item.YeuCauKhac = input.YeuCauKhac;
                    if (string.IsNullOrEmpty(input.FK_NguoiGui))
                    {
                        if (input.SoDienThoaiNguoiGui != input.SoDienThoaiNguoiNhan)
                        {
                            // Thêm người gửi
                            item.FK_NguoiGui = Guid.NewGuid().ToString();
                            ExpConsignmentObject objExp = new ExpConsignmentObject();
                            objExp.Id = item.FK_NguoiGui;
                            objExp.FullName = input.NguoiGui;
                            objExp.DiaChi = input.DiaChiNguoiGui;
                            objExp.FK_DonViHC = input.FK_DVHCNguoiGui;
                            objExp.IsProvider = false;
                            objExp.SoDienThoai = input.SoDienThoaiNguoiGui;
                            objExp.SoNha = input.SoNhaNguoiGui;
                            dc.EXpconsignmentobject.InsertOnSubmit(ConnectionData.Schema, objExp);
                        }
                        else
                        {
                            item.FK_NguoiGui = item.FK_NguoiGui;
                        }
                    }
                    else
                    {
                        item.FK_NguoiGui = input.FK_NguoiGui;
                        // Update thông tin người gửi
                        ExpConsignmentObject objExp = dc.EXpconsignmentobject.GetObject(ConnectionData.Schema, item.FK_NguoiGui);
                        objExp.FullName = input.NguoiGui;
                        objExp.DiaChi = input.DiaChiNguoiGui;
                        objExp.FK_DonViHC = input.FK_DVHCNguoiGui;
                        objExp.IsProvider = false;
                        objExp.SoDienThoai = input.SoDienThoaiNguoiGui;
                        objExp.SoNha = input.SoNhaNguoiGui;
                        dc.EXpconsignmentobject.Update(ConnectionData.Schema, objExp);

                    }
                    if (string.IsNullOrEmpty(input.FK_NguoiNhan))
                    {
                        // Thêm người nhận
                        item.FK_NguoiNhan = Guid.NewGuid().ToString();
                        ExpConsignmentObject objExp = new ExpConsignmentObject();
                        objExp.Id = item.FK_NguoiNhan;
                        objExp.FullName = input.NguoiNhan;
                        objExp.DiaChi = input.DiaChiNguoiNhan;
                        objExp.FK_DonViHC = input.FK_DVHCNguoiNhan;
                        objExp.IsProvider = false;
                        objExp.SoDienThoai = input.SoDienThoaiNguoiNhan;
                        objExp.SoNha = input.SoNhaNguoiNhan;
                        dc.EXpconsignmentobject.InsertOnSubmit(ConnectionData.Schema, objExp);
                    }
                    else
                    {
                        item.FK_NguoiNhan = input.FK_NguoiNhan;
                        // Update lại thông tin người nhận
                        ExpConsignmentObject objExp = dc.EXpconsignmentobject.GetObject(ConnectionData.Schema, item.FK_NguoiNhan);
                        objExp.FullName = input.NguoiNhan;
                        objExp.DiaChi = input.DiaChiNguoiNhan;
                        objExp.FK_DonViHC = input.FK_DVHCNguoiNhan;
                        objExp.IsProvider = false;
                        objExp.SoDienThoai = input.SoDienThoaiNguoiNhan;
                        objExp.SoNha = input.SoNhaNguoiNhan;
                        dc.EXpconsignmentobject.Update(ConnectionData.Schema, objExp);
                    }
                    item.FK_LoaiMatHang = input.FK_LoaiMatHang;
                    item.FK_ExpProvider = input.FK_ExpProvider;
                    item.FK_CachVanChuyen = input.FK_CachVanChuyen;
                    item.FK_CachGiaoHang = input.FK_CachGiaoHang;
                    item.FK_CachThanhToan = input.FK_CachThanhToan;
                    item.FK_CaLamViec = input.FK_CaLamViec;
                    item.FK_NguoiThuHang = input.FK_NguoiThuHang;
                    item.FK_ExpPostFrom = input.FK_ExpPostFrom;
                    item.FK_ExpPostTo = input.FK_ExpPostTo;
                    item.CuocPhiChinh = input.CuocPhiChinh;
                    item.CuocCongThem = input.CuocCongThem;
                    item.PhuPhi = input.PhuPhi;
                    item.ThuHo = input.ThuHo;
                    item.TongCuoc = input.TongCuoc;
                    item.FK_NhanVienPhat = input.FK_NhanVienPhat;
                    item.HoTenNguoiKyNhan = input.HoTenNguoiKyNhan;
                    item.NguoiGui = input.NguoiGui;
                    item.SoDienThoaiNguoiGui = input.SoDienThoaiNguoiGui;
                    item.FK_DVHCNguoiGui = input.FK_DVHCNguoiGui;
                    item.SoNhaNguoiGui = input.SoNhaNguoiGui;
                    item.DiaChiNguoiGui = input.DiaChiNguoiGui;
                    item.NguoiNhan = input.NguoiNhan;
                    item.SoDienThoaiNguoiNhan = input.SoDienThoaiNguoiNhan;
                    item.FK_DVHCNguoiNhan = input.FK_DVHCNguoiNhan;
                    item.SoNhaNguoiNhan = input.SoNhaNguoiNhan;
                    item.DiaChiNguoiNhan = input.DiaChiNguoiNhan;
                    // History
                    ExpConsignmentHistory history = new ExpConsignmentHistory();
                    history.CreateDate = item.CreateDate;
                    history.FK_ExpConsignment = item.Id;
                    history.FK_ExpStatus = item.FK_ExpStatus;
                    history.FK_ExpPost = item.FK_ExpPostFrom;
                    history.Id = Guid.NewGuid().ToString();
                    history.Note = "Cập nhật nội dung đơn hàng từ khách hàng";
                    history.CreateBy = item.CreateBy;
                    // Insert History
                    dc.EXpconsignmenthistory.InsertOnSubmit(ConnectionData.Schema, history);
                    // Xóa CashPay cũ
                    ExpCashPay old = dc.EXpcashpay.GetObjectCon(ConnectionData.Schema, "WHERE SoChungTu=@SoChungTu AND Type=@Type",
                        "@SoChungTu", item.MaDonHang,
                        "@Type", "CASH_SHIP");
                    if (old != null)
                    {
                        //old.IsDelete = true;
                        //old.FK_AccountDelete = item.CreateBy;
                        //old.CreateDelete = dc.CurrentTime();
                        //old.Reason = "Xóa phiếu thu do thay đổi đơn hàng";
                        dc.EXpcashpay.DeleteOnSubmit(ConnectionData.Schema, old);
                        // Update ExpPost
                        ExpPost post = dc.EXppost.GetObject(base.ConnectionData.Schema, old.FK_ExtPost);
                        post.ValueBlanceMoney = post.ValueBlanceMoney - old.Value;
                        dc.EXppost.Update(base.ConnectionData.Schema, post);
                    }
                    // CashPay
                    if (item.FK_CachThanhToan == "01")
                    {
                        ExpCashPay cashPay = new ExpCashPay();
                        cashPay.Id = Guid.NewGuid().ToString();
                        cashPay.CreateBy = item.CreateBy;
                        cashPay.CreateDate = item.CreateDate;
                        cashPay.SoChungTu = item.MaDonHang;
                        cashPay.FK_ExtPost = item.FK_ExpPostFrom;
                        cashPay.MaNguoiNopNhan = item.FK_NguoiGui;
                        cashPay.TenNguoiNopNhan = item.NguoiGui;
                        cashPay.DiaChi = item.DiaChiNguoiGui;
                        cashPay.SoDienThoai = item.SoDienThoaiNguoiGui;
                        cashPay.IsPay = false;
                        cashPay.IsDelete = false;
                        cashPay.Note = "Thu cước phí của khách hàng";
                        cashPay.Value = item.CuocPhiChinh + item.CuocCongThem + item.PhuPhi;
                        cashPay.Type = "CASH_SHIP";
                        cashPay.PrintCopied = 0;
                        dc.EXpcashpay.InsertOnSubmit(base.ConnectionData.Schema, cashPay);
                        // Update ExpPost
                        ExpPost post = dc.EXppost.GetObject(base.ConnectionData.Schema, cashPay.FK_ExtPost);
                        post.ValueBlanceMoney = post.ValueBlanceMoney + cashPay.Value;
                        dc.EXppost.Update(base.ConnectionData.Schema, post);
                    }
                    //Change Database
                    dc.EXpconsignment.Update(base.ConnectionData.Schema, item);
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
        /// Delete ExpConsignment
        /// </summary>
        public async Task<bool> Delete(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpConsignment item = dc.EXpconsignment.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    // History
                    ExpConsignmentHistory history = new ExpConsignmentHistory();
                    history.CreateDate = item.CreateDate;
                    history.FK_ExpConsignment = item.Id;
                    history.FK_ExpStatus = item.FK_ExpStatus;
                    history.FK_ExpPost = item.FK_ExpPostFrom;
                    history.Id = Guid.NewGuid().ToString();
                    history.Note = "Xóa đơn hàng từ khách hàng";
                    history.CreateBy = item.CreateBy;
                    // Insert History
                    dc.EXpconsignmenthistory.InsertOnSubmit(ConnectionData.Schema, history);
                    // Xóa CashPay cũ
                    ExpCashPay old = dc.EXpcashpay.GetObjectCon(ConnectionData.Schema, "WHERE SoChungTu=@SoChungTu AND Type=@Type",
                        "@SoChungTu", item.MaDonHang,
                        "@Type", "CASH_SHIP");
                    if (old != null)
                    {
                        //old.IsDelete = true;
                        //old.FK_AccountDelete = item.CreateBy;
                        //old.CreateDelete = dc.CurrentTime();
                        //old.Reason = "Xóa phiếu thu do xóa bỏ đơn hàng";
                        dc.EXpcashpay.DeleteOnSubmit(ConnectionData.Schema, old);
                        // Update ExpPost
                        ExpPost post = dc.EXppost.GetObject(base.ConnectionData.Schema, old.FK_ExtPost);
                        post.ValueBlanceMoney = post.ValueBlance - old.Value;
                        dc.EXppost.Update(base.ConnectionData.Schema, post);
                    }
                    //Delete master
                    dc.EXpconsignment.DeleteOnSubmit(base.ConnectionData.Schema, Id);
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
        /// <returns>view_ExpConsignment</returns>
        public async Task<view_ExpConsignment> CreateOrUpdateMasterOnly(String Id, ExpConsignmentV2LogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                ExpConsignment item = dc.EXpconsignment.GetObject(base.ConnectionData.Schema, Id);
                if (item == null)
                {
                    insert = true;
                    item = new ExpConsignment();
                    item.Id = Guid.NewGuid().ToString();
                    item.CreateDate = DateTime.Now;
                }
                // Update Value
                item.MaDonHang = input.MaDonHang;
                item.TenHang = input.TenHang;
                item.SoLuong = input.SoLuong;
                item.TrongLuongGram = input.TrongLuongGram;
                item.GiaTriTienHang = input.GiaTriTienHang;
                item.FK_YeuCauKhiGiao = input.FK_YeuCauKhiGiao;
                item.YeuCauKhac = input.YeuCauKhac;
                item.FK_NguoiGui = input.FK_NguoiGui;
                item.FK_NguoiNhan = input.FK_NguoiNhan;
                item.FK_LoaiMatHang = input.FK_LoaiMatHang;
                item.FK_ExpProvider = input.FK_ExpProvider;
                item.FK_CachVanChuyen = input.FK_CachVanChuyen;
                item.FK_CachGiaoHang = input.FK_CachGiaoHang;
                item.FK_CachThanhToan = input.FK_CachThanhToan;
                item.FK_CaLamViec = input.FK_CaLamViec;
                item.FK_NguoiThuHang = input.FK_NguoiThuHang;
                item.FK_ExpPostFrom = input.FK_ExpPostFrom;
                item.FK_ExpPostTo = input.FK_ExpPostTo;
                item.CreateBy = input.CreateBy;
                item.CuocPhiChinh = input.CuocPhiChinh;
                item.CuocCongThem = input.CuocCongThem;
                item.PhuPhi = input.PhuPhi;
                item.ThuHo = input.ThuHo;
                item.TongCuoc = input.TongCuoc;
                item.FK_NhanVienPhat = input.FK_NhanVienPhat;
                item.HoTenNguoiKyNhan = input.HoTenNguoiKyNhan;
                item.NguoiGui = input.NguoiGui;
                item.SoDienThoaiNguoiGui = input.SoDienThoaiNguoiGui;
                item.FK_DVHCNguoiGui = input.FK_DVHCNguoiGui;
                item.SoNhaNguoiGui = input.SoNhaNguoiGui;
                item.DiaChiNguoiGui = input.DiaChiNguoiGui;
                item.NguoiNhan = input.NguoiNhan;
                item.SoDienThoaiNguoiNhan = input.SoDienThoaiNguoiNhan;
                item.FK_DVHCNguoiNhan = input.FK_DVHCNguoiNhan;
                item.SoNhaNguoiNhan = input.SoNhaNguoiNhan;
                item.DiaChiNguoiNhan = input.DiaChiNguoiNhan;
                item.PrintNumber = input.PrintNumber;
                if (insert)
                {
                    dc.EXpconsignment.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.EXpconsignment.Update(base.ConnectionData.Schema, item);
                }

                // Get lại giá trị của Master
                view_ExpConsignment returnItem = dc.VIewexpconsignment.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", item.Id);
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
        /// Get data refer Master ExpConsignmentOnDelivery
        /// </summary>
        /// <returns>ExpConsignmentOnDelivery</returns>
        public async Task<List<ExpConsignmentOnDelivery>> GetMasterFK_YeuCauKhiGiaoList()
        {
            List<ExpConsignmentOnDelivery> ls = new List<ExpConsignmentOnDelivery>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.EXpconsignmentondelivery.GetListObject(ConnectionData.Schema);
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
        /// Get data refer Master ExpConsignmentObject
        /// </summary>
        /// <returns>ExpConsignmentObject</returns>
        public async Task<List<ExpConsignmentObject>> GetMasterFK_NguoiGuiList()
        {
            List<ExpConsignmentObject> ls = new List<ExpConsignmentObject>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.EXpconsignmentobject.GetListObject(ConnectionData.Schema);
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
        /// Get data refer Master ExpConsignmentObject
        /// </summary>
        /// <returns>ExpConsignmentObject</returns>
        public async Task<List<ExpConsignmentObject>> GetMasterFK_NguoiNhanList()
        {
            List<ExpConsignmentObject> ls = new List<ExpConsignmentObject>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.EXpconsignmentobject.GetListObject(ConnectionData.Schema);
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
        /// Get data refer Master ExpLoaiMatHang
        /// </summary>
        /// <returns>ExpLoaiMatHang</returns>
        public async Task<List<ExpLoaiMatHang>> GetMasterFK_LoaiMatHangList()
        {
            List<ExpLoaiMatHang> ls = new List<ExpLoaiMatHang>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.EXploaimathang.GetListObject(ConnectionData.Schema);
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
        /// Get data refer Master ExpProvider
        /// </summary>
        /// <returns>ExpProvider</returns>
        public async Task<List<ExpProvider>> GetMasterFK_ExpProviderList()
        {
            List<ExpProvider> ls = new List<ExpProvider>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.EXpprovider.GetListObject(ConnectionData.Schema);
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
        /// Get data refer Master ExpType
        /// </summary>
        /// <returns>ExpType</returns>
        public async Task<List<ExpType>> GetMasterFK_CachVanChuyenList()
        {
            List<ExpType> ls = new List<ExpType>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.EXptype.GetListObject(ConnectionData.Schema);
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
        /// Get data refer Master ExpCachGiao
        /// </summary>
        /// <returns>ExpCachGiao</returns>
        public async Task<List<ExpCachGiao>> GetMasterFK_CachGiaoHangList()
        {
            List<ExpCachGiao> ls = new List<ExpCachGiao>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.EXpcachgiao.GetListObjectCon(ConnectionData.Schema, "ORDER BY Id Desc");
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
        /// Get data refer Master ExpCachThanhToan
        /// </summary>
        /// <returns>ExpCachThanhToan</returns>
        public async Task<List<ExpCachThanhToan>> GetMasterFK_CachThanhToanList()
        {
            List<ExpCachThanhToan> ls = new List<ExpCachThanhToan>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.EXpcachthanhtoan.GetListObject(ConnectionData.Schema);
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
        /// Get data refer Master ExpCaLamViec
        /// </summary>
        /// <returns>ExpCaLamViec</returns>
        public async Task<List<ExpCaLamViec>> GetMasterFK_CaLamViecList()
        {
            List<ExpCaLamViec> ls = new List<ExpCaLamViec>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.EXpcalamviec.GetListObject(ConnectionData.Schema);
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
        /// Get data refer Master AccountObject
        /// </summary>
        /// <returns>AccountObject</returns>
        public async Task<List<AccountObject>> GetMasterFK_NguoiThuHangList()
        {
            List<AccountObject> ls = new List<AccountObject>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.ACcountobject.GetListObject(ConnectionData.Schema);
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
        /// Get data refer Master ExpPost
        /// </summary>
        /// <returns>ExpPost</returns>
        public async Task<List<ExpPost>> GetMasterFK_ExpPostFromList(string accountId)
        {
            List<ExpPost> ls = new List<ExpPost>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.EXppost.GetListObjectCon(ConnectionData.Schema, "WHERE Id IN(SELECT FK_ExpPost FROM ExpPostAccount WHERE FK_AccountId='" + accountId + "') AND (ParrentPost IS NOT NULL OR ParrentPost <>'')");
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
        /// Get data refer Master ExpPost
        /// </summary>
        /// <returns>ExpPost</returns>
        public async Task<List<ExpPost>> GetMasterFK_ExpPostToList()
        {
            List<ExpPost> ls = new List<ExpPost>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.EXppost.GetListObjectCon(ConnectionData.Schema, "WHERE ParrentPost IS NOT NULL OR ParrentPost <>''");
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

        public async Task<List<ExpPost>> GetExptListFilter()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpPost> items = dc.EXppost.GetListObject(base.ConnectionData.Schema);
                ExpPost selectAll = new ExpPost();
                selectAll.Id = "0000";
                selectAll.TenDaiLy = "ALL";
                List<ExpPost> result = new List<ExpPost>();
                result.Add(selectAll);
                result.AddRange(items);
                return result;
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
        /// Get data refer Master ExpDonViHanhChinh
        /// </summary>
        /// <returns>ExpDonViHanhChinh</returns>
        public async Task<List<ExpDonViHanhChinh>> GetMasterFK_DVHCNguoiGuiList()
        {
            List<ExpDonViHanhChinh> ls = new List<ExpDonViHanhChinh>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.EXpdonvihanhchinh.GetListObject(ConnectionData.Schema);
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
        /// Get data refer Master ExpDonViHanhChinh
        /// </summary>
        /// <returns>ExpDonViHanhChinh</returns>
        public async Task<List<ExpDonViHanhChinh>> GetMasterFK_DVHCNguoiNhanList()
        {
            List<ExpDonViHanhChinh> ls = new List<ExpDonViHanhChinh>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.EXpdonvihanhchinh.GetListObject(ConnectionData.Schema);
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

