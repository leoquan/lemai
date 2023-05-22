using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class PhatHanhChungTuLogic : BaseLogic
    {
        public PhatHanhChungTuLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        /// <summary>
        /// Get all view_ExpChungTu List
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_ExpChungTu>> GetList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpchungtu.GetListObject(base.ConnectionData.Schema);
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
        /// Tìm view_ExpChungTu theo keyword
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_ExpChungTu>> GetList(string keyword)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE SoHoaDon like N'%" + keyword + "%' | NguoiMuaHang like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY NgayChungTu asc";
                return dc.VIewexpchungtu.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        /// Danh sách view_ExpChungTu theo giới hạn keyword và page
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="page">Số trang hiển thị</param>
        /// <returns></returns>
        public async Task<List<view_ExpChungTu>> GetPage(string keyword, int? page)
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
        /// Danh sách view_ExpChungTu theo giới hạn keyword, Take, Skip
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<List<view_ExpChungTu>> GetPage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE SoHoaDon like N'%" + keyword + "%' | NguoiMuaHang like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY NgayChungTu asc";
                return dc.VIewexpchungtu.GetListObjectLimitCon(base.ConnectionData.Schema, "*", condition, Take, Skip);
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
        /// Tuple Danh sách view_ExpChungTu theo giới hạn keyword, Take, Skip và số dòng dữ liệu
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<Tuple<List<view_ExpChungTu>, int>> GetTuplePage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                var list = dc.VIewexpchungtu.GetListObject(base.ConnectionData.Schema);
                var data = await GetPage(keyword, Take, Skip);
                return new Tuple<List<view_ExpChungTu>, int>(data, list.Count);
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
        /// Get List of SamePhatHanhChungTuLogic
        /// </summary>
        /// <param name="Id">Id Of ExpChungTu</param>
        /// <returns></returns>
        public async Task<List<view_ExpChungTu>> GetSameList(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int take = 10;
                return dc.VIewexpchungtu.GetListObjectLimitCon(base.ConnectionData.Schema, "*", "WHERE Id<>@Id  ", take, 0, "@Id", Id);
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
        /// Get view_ExpChungTu Object
        /// </summary>
        /// <param name="Id">Id Of ExpChungTu</param>
        /// <returns></returns>
        public async Task<view_ExpChungTu> GetDetails(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpchungtu.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", Id);
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
        /// Get view_ExpChungTuCt List Object
        /// </summary>
        /// <param name="Id">Id Of ExpChungTu</param>
        /// <returns></returns>
        public async Task<List<view_ExpChungTuCt>> GetChildList(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpchungtuct.GetListObjectCon(base.ConnectionData.Schema,
                    "WHERE FK_ExpChungTu=@FK_ExpChungTu", "@FK_ExpChungTu", Id);

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
        /// Get view_ExpChungTuCt Object
        /// </summary>
        /// <param name="FK_ExpChungTu">FK_ExpChungTu Of ExpChungTuCt</param>
        /// <param name="BILL_CODE">BILL_CODE Of ExpChungTuCt</param>
        /// <returns></returns>
        public async Task<view_ExpChungTuCt> GetChildDetails(String FK_ExpChungTu, String BILL_CODE)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpchungtuct.GetObjectCon(base.ConnectionData.Schema, " WHERE FK_ExpChungTu=@FK_ExpChungTu ", "@FK_ExpChungTu", FK_ExpChungTu, "@BILL_CODE", BILL_CODE);
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
        /// Create a ExpChungTu Object into Database
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ExpChungTu> Create(PhatHanhChungTuLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpChungTu item = new ExpChungTu();

                // Mapping Prop
                item.Id = Guid.NewGuid().ToString();
                item.NgayChungTu = DateTime.Now;
                item.SoHoaDon = input.SoHoaDon;
                item.NgayHoaDon = input.NgayHoaDon;
                item.SoTienThu = input.SoTienThu;
                item.SoTienChi = input.SoTienChi;
                item.LyDoChi = input.LyDoChi;
                item.LyDoThu = input.LyDoThu;
                item.SoChungTuThu = input.SoChungTuThu;
                item.SoChungTuChi = input.SoChungTuChi;
                item.FK_Account = input.FK_Account;
                item.ThangKT = input.ThangKT;
                item.FK_KyKetToan = input.FK_KyKetToan;
                item.NguoiMuaHang = input.NguoiMuaHang;
                item.DonViMuaHang = input.DonViMuaHang;
                item.MaSoThue = input.MaSoThue;
                item.DiaChi = input.DiaChi;

                //Change Database
                foreach (var child in input.lsExpChungTuCt)
                {
                    ExpChungTuCt childInsert = new ExpChungTuCt();
                    childInsert.FK_ExpChungTu = item.Id;
                    childInsert.BILL_CODE = child.BILL_CODE;
                    childInsert.SoTienPhaiThu = child.SoTienPhaiThu;
                    childInsert.SoTienPhaiChi = child.SoTienPhaiChi;
                    childInsert.TenNguoiNhan = child.TenNguoiNhan;
                    childInsert.SoDienThoaiNhan = child.SoDienThoaiNhan;
                    childInsert.DiaChiNhan = child.DiaChiNhan;
                    childInsert.SoTienThuHo = child.SoTienThuHo;
                    childInsert.CuocPhiVanChuyen = child.CuocPhiVanChuyen;
                    childInsert.TenHang = child.TenHang;
                    childInsert.TrongLuong = child.TrongLuong;
                    childInsert.IsPhatHanh = child.IsPhatHanh;
                    childInsert.CuocPhiChuaGTGT = child.CuocPhiChuaGTGT;
                    childInsert.ThueGTGT = child.ThueGTGT;
                    childInsert.NgayGuiHang = child.NgayGuiHang;
                    dc.EXpchungtuct.InsertOnSubmit(base.ConnectionData.Schema, childInsert);
                }
                dc.EXpchungtu.InsertOnSubmit(base.ConnectionData.Schema, item);
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
        /// Update ExpChungTu 
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Update(String Id, PhatHanhChungTuLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpChungTu item = dc.EXpchungtu.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    // Mapping Prop
                    item.SoHoaDon = input.SoHoaDon;
                    item.NgayHoaDon = input.NgayHoaDon;
                    item.SoTienThu = input.SoTienThu;
                    item.SoTienChi = input.SoTienChi;
                    item.LyDoChi = input.LyDoChi;
                    item.LyDoThu = input.LyDoThu;
                    item.SoChungTuThu = input.SoChungTuThu;
                    item.SoChungTuChi = input.SoChungTuChi;
                    item.FK_Account = input.FK_Account;
                    item.ThangKT = input.ThangKT;
                    item.FK_KyKetToan = input.FK_KyKetToan;
                    item.NguoiMuaHang = input.NguoiMuaHang;
                    item.DonViMuaHang = input.DonViMuaHang;
                    item.MaSoThue = input.MaSoThue;
                    item.DiaChi = input.DiaChi;
                    item.NgayChungTu = input.NgayCT;
                    ////Change Database
                    //dc.EXpchungtuct.DeleteOnSubmitCon(base.ConnectionData.Schema, "WHERE FK_ExpChungTu=@FK_ExpChungTu", "@FK_ExpChungTu", item.Id);
                    //foreach (var child in input.lsExpChungTuCt)
                    //{
                    //    ExpChungTuCt childInsert = new ExpChungTuCt();
                    //    childInsert.FK_ExpChungTu = child.FK_ExpChungTu;
                    //    childInsert.BILL_CODE = child.BILL_CODE;
                    //    childInsert.SoTienPhaiThu = child.SoTienPhaiThu;
                    //    childInsert.SoTienPhaiChi = child.SoTienPhaiChi;
                    //    childInsert.TenNguoiNhan = child.TenNguoiNhan;
                    //    childInsert.SoDienThoaiNhan = child.SoDienThoaiNhan;
                    //    childInsert.DiaChiNhan = child.DiaChiNhan;
                    //    childInsert.SoTienThuHo = child.SoTienThuHo;
                    //    childInsert.CuocPhiVanChuyen = child.CuocPhiVanChuyen;
                    //    childInsert.TenHang = child.TenHang;
                    //    childInsert.TrongLuong = child.TrongLuong;
                    //    childInsert.IsPhatHanh = child.IsPhatHanh;
                    //    childInsert.CuocPhiChuaGTGT = child.CuocPhiChuaGTGT;
                    //    childInsert.ThueGTGT = child.ThueGTGT;
                    //    childInsert.NgayGuiHang = child.NgayGuiHang;
                    //    childInsert.LoaiThanhToan = child.LoaiThanhToan;
                    //    dc.EXpchungtuct.InsertOnSubmit(base.ConnectionData.Schema, childInsert);
                    //}

                    dc.EXpchungtu.Update(base.ConnectionData.Schema, item);
                    // Update Customer
                    ExpCustomer customer = dc.EXpcustomer.GetObject(base.ConnectionData.Schema, item.FK_Customer);
                    if (customer != null)
                    {
                        customer.TenHopDong = item.NguoiMuaHang;
                        customer.DiaChi = item.DiaChi;
                        customer.DonVi = item.DonViMuaHang;
                        customer.MaSoThue = item.MaSoThue;
                        dc.EXpcustomer.Update(base.ConnectionData.Schema, customer);
                    }
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
        /// Delete ExpChungTu
        /// </summary>
        public async Task<bool> Delete(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpChungTu item = dc.EXpchungtu.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    //Delete Child
                    dc.EXpchungtuct.DeleteOnSubmitCon(base.ConnectionData.Schema,
                    "WHERE FK_ExpChungTu=@FK_ExpChungTu", "@FK_ExpChungTu", item.Id);
                    //Delete master
                    dc.EXpchungtu.DeleteOnSubmit(base.ConnectionData.Schema, Id);
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

        public string DeleteAllChungTu(String IdKyKetToan)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpChungTu> lsChungTu = dc.EXpchungtu.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_KyKetToan=@FK_KyKetToan", "@FK_KyKetToan", IdKyKetToan);
                if (lsChungTu.Exists(u => u.IsPhatHanh == true))
                {
                    return "Tồn tại chứng từ đã được phát hành!";
                }
                else
                {
                    foreach (var item in lsChungTu)
                    {
                        //Delete Child
                        List<ExpChungTuCt> lsChungTuChiTiet = dc.EXpchungtuct.GetListObjectCon(base.ConnectionData.Schema,
                        "WHERE FK_ExpChungTu=@FK_ExpChungTu", "@FK_ExpChungTu", item.Id);
                        foreach (var chitiet in lsChungTuChiTiet)
                        {
                            // Cập nhật hóa đơn
                            ExpHoaDonDoiSoat hoadon = dc.EXphoadondoisoat.GetObject(base.ConnectionData.Schema, chitiet.BILL_CODE);
                            if (hoadon != null)
                            {
                                hoadon.HoaDon = string.Empty;
                                dc.EXphoadondoisoat.Update(base.ConnectionData.Schema, hoadon);
                            }
                            // Xóa chi tiết
                            dc.EXpchungtuct.DeleteOnSubmit(base.ConnectionData.Schema, chitiet);
                        }

                        dc.EXpchungtu.DeleteOnSubmit(base.ConnectionData.Schema, item.Id);
                    }
                    dc.SubmitChanges();
                    return "Xóa chứng từ thành công!";
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
        /// Delete ExpChungTu
        /// </summary>
        public async Task<bool> DeleteChild(String FK_ExpChungTu, String BILL_CODE)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpChungTuCt item = dc.EXpchungtuct.GetObject(base.ConnectionData.Schema, FK_ExpChungTu, BILL_CODE);
                if (item != null)
                {
                    //Delete Child
                    dc.EXpchungtuct.DeleteOnSubmit(base.ConnectionData.Schema, FK_ExpChungTu, BILL_CODE);
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
        /// <returns>view_ExpChungTu</returns>
        public async Task<view_ExpChungTu> CreateOrUpdateMasterOnly(String Id, PhatHanhChungTuLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                ExpChungTu item = dc.EXpchungtu.GetObject(base.ConnectionData.Schema, Id);
                if (item == null)
                {
                    insert = true;
                    item = new ExpChungTu();
                    item.Id = Guid.NewGuid().ToString();
                    item.NgayChungTu = DateTime.Now;
                }
                // Update Value
                item.SoHoaDon = input.SoHoaDon;
                item.NgayHoaDon = input.NgayHoaDon;
                item.SoTienThu = input.SoTienThu;
                item.SoTienChi = input.SoTienChi;
                item.LyDoChi = input.LyDoChi;
                item.LyDoThu = input.LyDoThu;
                item.SoChungTuThu = input.SoChungTuThu;
                item.SoChungTuChi = input.SoChungTuChi;
                item.FK_Account = input.FK_Account;
                item.ThangKT = input.ThangKT;
                item.FK_KyKetToan = input.FK_KyKetToan;
                item.NguoiMuaHang = input.NguoiMuaHang;
                item.DonViMuaHang = input.DonViMuaHang;
                item.MaSoThue = input.MaSoThue;
                item.DiaChi = input.DiaChi;
                if (insert)
                {
                    dc.EXpchungtu.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.EXpchungtu.Update(base.ConnectionData.Schema, item);
                }

                // Get lại giá trị của Master
                view_ExpChungTu returnItem = dc.VIewexpchungtu.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", item.Id);
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
        /// <returns>view_ExpChungTuCt</returns>
        public async Task<view_ExpChungTuCt> CreateOrUpdateChildOnly(String FK_ExpChungTu, String BILL_CODE, childPhatHanhChungTuLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                ExpChungTuCt item = dc.EXpchungtuct.GetObject(base.ConnectionData.Schema, FK_ExpChungTu, BILL_CODE);
                if (item == null)
                {
                    insert = true;
                    item = new ExpChungTuCt();
                }
                item.FK_ExpChungTu = input.FK_ExpChungTu;
                item.BILL_CODE = input.BILL_CODE;
                item.SoTienPhaiThu = input.SoTienPhaiThu;
                item.SoTienPhaiChi = input.SoTienPhaiChi;
                item.TenNguoiNhan = input.TenNguoiNhan;
                item.SoDienThoaiNhan = input.SoDienThoaiNhan;
                item.DiaChiNhan = input.DiaChiNhan;
                item.SoTienThuHo = input.SoTienThuHo;
                item.CuocPhiVanChuyen = input.CuocPhiVanChuyen;
                item.TenHang = input.TenHang;
                item.TrongLuong = input.TrongLuong;
                item.IsPhatHanh = input.IsPhatHanh;
                item.CuocPhiChuaGTGT = input.CuocPhiChuaGTGT;
                item.ThueGTGT = input.ThueGTGT;
                item.NgayGuiHang = input.NgayGuiHang;
                if (insert)
                {
                    dc.EXpchungtuct.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.EXpchungtuct.Update(base.ConnectionData.Schema, item);
                }
                // Get lại giá trị của Child
                view_ExpChungTuCt returnItem = dc.VIewexpchungtuct.GetObjectCon(base.ConnectionData.Schema, " WHERE BILL_CODE=@BILL_CODE AND FK_ExpChungTu=@FK_ExpChungTu ", "@FK_ExpChungTu", item.FK_ExpChungTu, "@BILL_CODE", item.BILL_CODE);
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
        public string ChuyenDoiKyKetToan(string IdChungTu, String IdKyKetToan)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpChungTu chungtu = dc.EXpchungtu.GetObject(base.ConnectionData.Schema, IdChungTu);
                if (chungtu == null)
                {
                    return "Mã chứng từ không đúng!";
                }
                if (chungtu.IsPhatHanh == true)
                {
                    return "Không thể chuyển kỳ kết toán cho chứng từ đã phát hành!";
                }
                ExpKyKetToan kyKetToan = dc.EXpkykettoan.GetObject(base.ConnectionData.Schema, IdKyKetToan);
                if (kyKetToan == null)
                {
                    return "Chọn kỳ kết toán không đúng!";
                }
                if (kyKetToan.Id == chungtu.FK_KyKetToan)
                {
                    return "Kỳ kết toán chuyển đến giống kỳ kết toán hiện tại!";
                }
                // Update giá trị của kỳ kết toán
                kyKetToan.SoBangKe = kyKetToan.SoBangKe + 1;
                dc.EXpkykettoan.Update(base.ConnectionData.Schema, kyKetToan);
                //Update chứng từ
                chungtu.SoChungTu = kyKetToan.SoBangKe;
                chungtu.SoChungTuChi = kyKetToan.SoBangKe + "/PC-LM";
                chungtu.SoChungTuThu = kyKetToan.SoBangKe + "/PT-LM";
                chungtu.FK_KyKetToan = kyKetToan.Id;
                chungtu.LyDoChi = "Chi tiền theo biên bản cấn trừ công nợ số " + kyKetToan.SoBangKe + "/BBCTCN-LM";
                chungtu.LyDoThu = "Thu tiền cước dịch vụ chuyển phát nhanh theo bảng kê " + kyKetToan.SoBangKe + "/BK-LM";
                dc.EXpchungtu.Update(base.ConnectionData.Schema, chungtu);

                dc.SubmitChanges();

                return "Chuyển đổi kỳ kết toán thành công!";
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
        public string GopChiTietChungTu(string IdChungTuFrom, String IdChungTuTo)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpChungTu chungtuFrom = dc.EXpchungtu.GetObject(base.ConnectionData.Schema, IdChungTuFrom);
                if (chungtuFrom == null)
                {
                    return "Mã chứng từ From không đúng!";
                }
                ExpChungTu chungtuTo = dc.EXpchungtu.GetObject(base.ConnectionData.Schema, IdChungTuTo);
                if (chungtuTo == null)
                {
                    return "Mã chứng từ To không đúng!";
                }

                if (chungtuTo.Id == chungtuFrom.Id)
                {
                    return "Chứng từ From và chứng từ To giống nhau!";
                }
                if (chungtuFrom.IsPhatHanh == true || chungtuTo.IsPhatHanh == true)
                {
                    return "Chứng từ đã được phát hành không thể gộp!";
                }
                List<ExpChungTuCt> lsChiTiet = dc.EXpchungtuct.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_ExpChungTu=@FK_ExpChungTu", "@FK_ExpChungTu", IdChungTuFrom);
                foreach (var item in lsChiTiet)
                {
                    item.FK_ExpChungTu = IdChungTuTo;
                    chungtuTo.TongPhiVanChuyen += item.CuocPhiVanChuyen;
                    chungtuTo.TongThuHo += +item.SoTienThuHo;
                    if (item.LoaiThanhToan == "Nhận thanh toán")
                    {
                        chungtuTo.TongPhiNhanTra += item.CuocPhiVanChuyen;
                    }
                    else
                    {
                        chungtuTo.TongPhiGuiTra += item.CuocPhiVanChuyen;
                    }
                    dc.EXpchungtuct.UpdateCon(base.ConnectionData.Schema, item, "WHERE FK_ExpChungTu='" + IdChungTuFrom + "'");
                }

                chungtuTo.TongPhiChuaVAT = Math.Round(chungtuTo.TongPhiVanChuyen / 1.1m);
                chungtuTo.ThueVAT = chungtuTo.TongPhiVanChuyen - chungtuTo.TongPhiChuaVAT;

                chungtuTo.SoTienChi = 0;
                chungtuTo.SoTienThu = 0;
                if (chungtuTo.TongThuHo - chungtuTo.TongPhiGuiTra > 0)
                {
                    chungtuTo.SoTienChi = chungtuTo.TongThuHo - chungtuTo.TongPhiGuiTra;
                }
                else
                {
                    chungtuTo.SoTienThu = chungtuTo.TongPhiGuiTra - chungtuTo.TongThuHo;
                }
                dc.EXpchungtu.Update(base.ConnectionData.Schema, chungtuTo);

                chungtuFrom.SoTienChi = 0;
                chungtuFrom.SoTienThu = 0;
                chungtuFrom.TongPhiChuaVAT = 0;
                chungtuFrom.TongPhiGuiTra = 0;
                chungtuFrom.TongPhiNhanTra = 0;
                chungtuFrom.TongPhiVanChuyen = 0;
                chungtuFrom.TongThuHo = 0;
                dc.EXpchungtu.Update(base.ConnectionData.Schema, chungtuFrom);

                dc.SubmitChanges();
                // Chuyển đi
                return "Gộp chứng từ thành công!";
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
        public string GopCODChungTu(string IdChungTuFrom, String IdChungTuTo)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpChungTu chungtuFrom = dc.EXpchungtu.GetObject(base.ConnectionData.Schema, IdChungTuFrom);
                if (chungtuFrom == null)
                {
                    return "Mã chứng từ From không đúng!";
                }
                ExpChungTu chungtuTo = dc.EXpchungtu.GetObject(base.ConnectionData.Schema, IdChungTuTo);
                if (chungtuTo == null)
                {
                    return "Mã chứng từ B không đúng!";
                }
                if (chungtuTo.Id == chungtuFrom.Id)
                {
                    return "Chứng từ A và chứng từ B giống nhau!";
                }
                
                List<ExpChungTuCt> lsChiTietA = dc.EXpchungtuct.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_ExpChungTu=@FK_ExpChungTu", "@FK_ExpChungTu", IdChungTuFrom);
                List<ExpChungTuCt> lsChiTietB = dc.EXpchungtuct.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_ExpChungTu=@FK_ExpChungTu ORDER BY SoTienThuHo", "@FK_ExpChungTu", IdChungTuTo);
                if (lsChiTietB.Count < lsChiTietA.Count)
                {
                    return "Chi tiết chứng từ A nhiều hơn chi tiết chứng từ B không thể gộp COD!";
                }
                for (int i = 0; i < lsChiTietA.Count; i++)
                {
                    lsChiTietB[i].SoTienThuHo += lsChiTietA[i].SoTienThuHo;
                    dc.EXpchungtuct.Update(base.ConnectionData.Schema, lsChiTietB[i]);
                    chungtuTo.TongThuHo += lsChiTietA[i].SoTienThuHo;
                }

                chungtuTo.SoTienChi = 0;
                chungtuTo.SoTienThu = 0;
                if (chungtuTo.TongThuHo - chungtuTo.TongPhiGuiTra > 0)
                {
                    chungtuTo.SoTienChi = chungtuTo.TongThuHo - chungtuTo.TongPhiGuiTra;
                }
                else
                {
                    chungtuTo.SoTienThu = chungtuTo.TongPhiGuiTra - chungtuTo.TongThuHo;
                }
                dc.EXpchungtu.Update(base.ConnectionData.Schema, chungtuTo);
                dc.SubmitChanges();
                if (chungtuTo.IsPhatHanh == true)
                {
                    return "Gộp COD thành công, cần in lại phiếu chi, biên bản cấn trừ công nợ để lưu trữ do chứng từ đã phát sinh.";
                }
                else
                {
                    return "Gộp COD thành công!";
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
        public string RemoveChungTu(string IdChungTuA)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpChungTu chungtuA = dc.EXpchungtu.GetObject(base.ConnectionData.Schema, IdChungTuA);
                if (chungtuA == null)
                {
                    return "Mã chứng từ không đúng!";
                }
                if(chungtuA.IsPhatHanh==true)
                {
                    return "Chứng từ đã được phát hành không thể xóa!";
                }    
                List<ExpChungTuCt> lsChiTietA = dc.EXpchungtuct.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_ExpChungTu=@FK_ExpChungTu", "@FK_ExpChungTu", IdChungTuA);
                dc.EXpchungtuct.DeleteAllSubmit(base.ConnectionData.Schema, lsChiTietA);
                dc.EXpchungtu.DeleteOnSubmit(base.ConnectionData.Schema, chungtuA);
                dc.SubmitChanges();
                // Chuyển đi
                return "Xóa chứng từ thành công!";
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
        public string SkipChungTu(string IdChungTuA)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpChungTu chungtuA = dc.EXpchungtu.GetObject(base.ConnectionData.Schema, IdChungTuA);
                if (chungtuA == null)
                {
                    return "Mã chứng từ không đúng!";
                }
                List<ExpChungTuCt> lsChiTietA = dc.EXpchungtuct.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_ExpChungTu=@FK_ExpChungTu", "@FK_ExpChungTu", IdChungTuA);

                // Chuyển đi
                return "Bỏ qua chứng từ thành công!";
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

