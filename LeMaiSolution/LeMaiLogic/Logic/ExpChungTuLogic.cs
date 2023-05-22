using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;

namespace LeMaiLogic.Logic
{
    public class ExpChungTuLogic : BaseLogic
    {
        public ExpChungTuLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        public DataTable GetDanhSachHoaDonChuaPhatHanh(string post, DateTime fromDate, DateTime toDate)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GetData(@"SELECT B.*, C.CustomerCode, C.CustomerName, C.NgayHopDong, C.TenHopDong, C.ContractCustomer, CAST(0 AS int) STT, CONCAT( B.ACCEPT_MAN_ADDRESS, ', ', B.ACCEPT_COUNTY_CODE, ', ', B.ACCEPT_CITY_CODE, ', ', b.ACCEPT_PROVINCE_CODE) SUM_ADDRESS
                                      FROM ExpHoaDonDoiSoat A
                                      INNER JOIN ExpBILL B ON A.Id = B.BILL_CODE
                                      INNER JOIN ExpCustomer C ON C.Id = B.FK_Customer
                                      WHERE A.FK_Post=@FK_Post AND A.HoaDon='' AND A.CreateHd >='" + string.Format("{0:yyyy-MM-dd}", fromDate) + " 00:00:00' AND A.CreateHd <='" + string.Format("{0:yyyy-MM-dd}", toDate) + " 23:59:59' ", "@FK_Post", post);
            }
            catch
            {
                return null;
            }
            finally
            {
                dc.Close();
            }
        }
        public List<view_ExpChungTu> GetDanhSachChungDaPhatHanh(DateTime fromDate, DateTime toDate, string kyKetToan)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                if (kyKetToan == "0000")
                {
                    return dc.VIewexpchungtu.GetListObjectCon(base.ConnectionData.Schema, "WHERE NgayChungTu >='" + string.Format("{0:yyyy-MM-dd}", fromDate) + " 00:00:00' AND NgayChungTu <='" + string.Format("{0:yyyy-MM-dd}", toDate) + " 23:59:59'");
                }
                else
                {
                    return dc.VIewexpchungtu.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_KyKetToan='" + kyKetToan + "' AND NgayChungTu >='" + string.Format("{0:yyyy-MM-dd}", fromDate) + " 00:00:00' AND NgayChungTu <='" + string.Format("{0:yyyy-MM-dd}", toDate) + " 23:59:59'");
                }

            }
            catch
            {
                return null;
            }
            finally
            {
                dc.Close();
            }
        }
        public List<view_ExpChungTuCt> GetChiTietChungTu(string Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpchungtuct.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_ExpChungTu=@FK_ExpChungTu", "@FK_ExpChungTu", Id);
            }
            catch
            {
                return null;
            }
            finally
            {
                dc.Close();
            }
        }
        public DataTable GetChiTietBangKe(string idChungTu)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpchungtuctreport.GetDataTable(base.ConnectionData.Schema, "WHERE FK_ExpChungTu=@FK_ExpChungTu ORDER BY NgayGuiHang", "@FK_ExpChungTu", idChungTu);
            }
            catch
            {
                return null;
            }
            finally
            {
                dc.Close();
            }
        }
        public DataTable GetPhieuChi(string idChungTu)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpchungtuphieuchi.GetDataTable(base.ConnectionData.Schema, "WHERE Id=@Id", "@Id", idChungTu);
            }
            catch
            {
                return null;
            }
            finally
            {
                dc.Close();
            }
        }

        public List<ExpKyKetToan> GetKyKetToan()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpkykettoan.GetListObjectCon(base.ConnectionData.Schema, "ORDER BY NgayTao");
            }
            catch
            {
                return null;
            }
            finally
            {
                dc.Close();
            }
        }
        public List<ExpKyKetToan> GetKyKetToanAndAll()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpKyKetToan> ls = new List<ExpKyKetToan>();
                ls.Add(new ExpKyKetToan { Id = "0000", TenKy = "Tất cả" });
                ls.AddRange(dc.EXpkykettoan.GetListObjectCon(base.ConnectionData.Schema, "ORDER BY NgayTao"));
                return ls;
            }
            catch
            {
                return null;
            }
            finally
            {
                dc.Close();
            }
        }
        public bool CheckKyKetToan(string kyKetToan)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpChungTu chungTu = dc.EXpchungtu.GetObjectCon(base.ConnectionData.Schema, "WHERE FK_KyKetToan=@FK_KyKetToan", "@FK_KyKetToan", kyKetToan);
                if (chungTu != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }
        public bool UpdateHoaDonDienTu(string idChungTu, string soHoaDon, DateTime ngayHoaDon)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpChungTu chungTu = dc.EXpchungtu.GetObject(base.ConnectionData.Schema, idChungTu);
                if (chungTu != null)
                {
                    chungTu.SoHoaDon = soHoaDon;
                    chungTu.NgayHoaDon = ngayHoaDon;
                    dc.EXpchungtu.Update(base.ConnectionData.Schema, chungTu);
                    dc.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                dc.Close();
            }
        }
        public string PhatHanhChungTu(string chungTuId, string post, string fk_account, string accountName)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();
                ExpChungTu chungtu = dc.EXpchungtu.GetObject(base.ConnectionData.Schema, chungTuId);
                if (chungtu != null)
                {
                    if (chungtu.IsPhatHanh)
                    {
                        return "Chứng từ đã được phát hành!";
                    }
                    List<ExpChungTuCt> lsChild = dc.EXpchungtuct.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_ExpChungTu=@FK_ExpChungTu", "@FK_ExpChungTu", chungtu.Id);
                    foreach (var item in lsChild)
                    {
                        item.IsPhatHanh = true;
                        // Cập nhật hóa đơn
                        ExpPhatHanhChungTu phatHanh = dc.EXpphathanhchungtu.GetObject(base.ConnectionData.Schema, item.BILL_CODE);
                        if (phatHanh == null)
                        {
                            phatHanh = new ExpPhatHanhChungTu();
                            phatHanh.BILL_CODE = item.BILL_CODE;
                            phatHanh.CreateDate = currentDate;
                            phatHanh.FK_ChungTuCT = item.FK_ExpChungTu;
                            phatHanh.FK_CreateBy = fk_account;
                            dc.EXpphathanhchungtu.InsertOnSubmit(base.ConnectionData.Schema, phatHanh);
                        }
                        dc.EXpchungtuct.Update(base.ConnectionData.Schema, item);
                    }
                    chungtu.IsPhatHanh = true;
                    dc.EXpchungtu.Update(base.ConnectionData.Schema, chungtu);

                    dc.SubmitChanges();
                    return string.Empty;
                }
                else
                {
                    return "Mã chứng từ không tìm thấy!";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                dc.Close();
            }
        }
        public string HuyPhatHanhChungTu(string chungTuId, string post, string fk_account, string accountName)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();
                ExpChungTu chungtu = dc.EXpchungtu.GetObject(base.ConnectionData.Schema, chungTuId);
                if (chungtu != null)
                {
                    if (chungtu.IsPhatHanh == false)
                    {
                        return "Chứng từ chưa đã được phát hành!";
                    }
                    List<ExpChungTuCt> lsChild = dc.EXpchungtuct.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_ExpChungTu=@FK_ExpChungTu", "@FK_ExpChungTu", chungtu.Id);
                    foreach (var item in lsChild)
                    {
                        item.IsPhatHanh = false;
                        // Cập nhật hóa đơn
                        ExpPhatHanhChungTu phatHanh = dc.EXpphathanhchungtu.GetObject(base.ConnectionData.Schema, item.BILL_CODE);
                        if (phatHanh != null)
                        {
                            dc.EXpphathanhchungtu.DeleteOnSubmit(base.ConnectionData.Schema, phatHanh);
                        }
                        dc.EXpchungtuct.Update(base.ConnectionData.Schema, item);
                    }
                    chungtu.IsPhatHanh = false;
                    dc.EXpchungtu.Update(base.ConnectionData.Schema, chungtu);
                    dc.SubmitChanges();
                    return string.Empty;
                }
                else
                {
                    return "Mã chứng từ không tìm thấy!";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                dc.Close();
            }
        }
        public void TotalCalculatorChungTu(string chungTuId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpChungTu chungtu = dc.EXpchungtu.GetObject(base.ConnectionData.Schema, chungTuId);
                if (chungtu != null)
                {
                    if (chungtu.IsPhatHanh == false)
                    {
                        chungtu.SoTienChi = 0;
                        chungtu.SoTienThu = 0;
                        chungtu.ThueVAT = 0;
                        chungtu.TongPhiChuaVAT = 0;

                        chungtu.TongPhiGuiTra = 0;
                        chungtu.TongPhiNhanTra = 0;
                        chungtu.TongPhiVanChuyen = 0;
                        chungtu.TongThuHo = 0;
                        List<ExpChungTuCt> lsChild = dc.EXpchungtuct.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_ExpChungTu=@FK_ExpChungTu", "@FK_ExpChungTu", chungtu.Id);
                        foreach (var item in lsChild)
                        {
                            chungtu.TongThuHo += item.SoTienThuHo;
                            chungtu.TongPhiVanChuyen += item.CuocPhiVanChuyen;

                            decimal cuocNhanTra = 0;
                            decimal cuocGuiTra = 0;
                            if (item.LoaiThanhToan == "Gửi thanh toán")
                            {
                                cuocGuiTra = item.CuocPhiVanChuyen;
                            }
                            else
                            {
                                cuocNhanTra = item.CuocPhiVanChuyen;
                            }
                            chungtu.TongPhiNhanTra += cuocNhanTra;
                            chungtu.TongPhiGuiTra += cuocGuiTra;
                        }
                        // Tính toán 4 giá trị thuế.
                        chungtu.TongPhiChuaVAT = Math.Round(chungtu.TongPhiVanChuyen / 1.1m);
                        chungtu.ThueVAT = chungtu.TongPhiVanChuyen - chungtu.TongPhiChuaVAT;

                        if (chungtu.TongThuHo - chungtu.TongPhiGuiTra > 0)
                        {
                            chungtu.SoTienChi = chungtu.TongThuHo - chungtu.TongPhiGuiTra;
                        }
                        else
                        {
                            chungtu.SoTienThu = chungtu.TongPhiGuiTra - chungtu.TongThuHo;
                        }

                        dc.EXpchungtu.Update(base.ConnectionData.Schema, chungtu);
                        dc.SubmitChanges();
                    }
                }
            }
            finally
            {
                dc.Close();
            }
        }
        public int CreateChungTu(DataTable data, string post, string kyKetToanId, string fk_account)
        {
            int count = 0;
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();

                ExpKyKetToan kyKetToan = dc.EXpkykettoan.GetObject(base.ConnectionData.Schema, kyKetToanId);
                if (kyKetToan == null)
                {
                    return 0;
                }
                int SoBangKe = kyKetToan.SoBangKe;

                ExpChungTu chungtukl = new ExpChungTu();
                chungtukl.Id = Guid.NewGuid().ToString();
                SoBangKe = SoBangKe + 1;
                chungtukl.SoChungTuThu = SoBangKe.ToString() + "/" + kyKetToan.TenKy;
                chungtukl.IsPhatHanh = false;
                chungtukl.DiaChi = "";
                chungtukl.FK_Account = fk_account;
                chungtukl.FK_Customer = "0000";
                chungtukl.FK_KyKetToan = kyKetToanId;
                chungtukl.LyDoChi = "Chi tiền theo danh sách chi tiền thu hộ cho khách lẻ số " + SoBangKe + "/SCT-LM ngày " + string.Format("{0:dd/MM/yyyy}", currentDate);
                chungtukl.LyDoThu = "Thu tiền phí cước dịch vụ chuyển phát nhanh";
                chungtukl.MaSoThue = "";
                chungtukl.NgayChungTu = currentDate;
                chungtukl.NgayHoaDon = currentDate;
                chungtukl.NguoiMuaHang = "Người mua không lấy hóa đơn";
                chungtukl.SoChungTuChi = SoBangKe + "/PC-LM";
                chungtukl.SoChungTuThu = SoBangKe + "/BK-LM";
                chungtukl.SoHoaDon = "0";
                chungtukl.SoTienChi = 0;
                chungtukl.SoTienThu = 0;
                chungtukl.ThangKT = kyKetToan.NgayTao;
                // =====
                chungtukl.SoChungTu = SoBangKe;
                chungtukl.TongThuHo = 0;
                chungtukl.TongPhiNhanTra = 0;
                chungtukl.TongPhiGuiTra = 0;
                chungtukl.TongPhiChuaVAT = 0;
                chungtukl.ThueVAT = 0;
                chungtukl.TongPhiVanChuyen = 0;

                foreach (DataRow item in data.Rows)
                {
                    ExpChungTuCt chungtuct = new ExpChungTuCt();
                    chungtuct.FK_ExpChungTu = chungtukl.Id;
                    chungtuct.BILL_CODE = item["BILL_CODE"].ToString();
                    chungtuct.CuocPhiVanChuyen = decimal.Parse(item["FREIGHT"].ToString());
                    chungtuct.CuocPhiChuaGTGT = Math.Round(chungtuct.CuocPhiVanChuyen / 1.1m);
                    chungtuct.DiaChiNhan = item["SUM_ADDRESS"].ToString().Trim().TrimStart(',');
                    chungtuct.IsPhatHanh = false;
                    chungtuct.SoDienThoaiNhan = item["ACCEPT_MAN_PHONE"].ToString();
                    chungtuct.SoTienThuHo = decimal.Parse(item["GOODS_PAYMENT"].ToString());

                    bool GiaoHangThanhCong;
                    if (string.IsNullOrEmpty(item["GIAO_HANG_TC"].ToString()))
                    {
                        GiaoHangThanhCong = true;
                    }
                    else
                    {
                        int gc = 0;
                        if (!Int32.TryParse(item["GIAO_HANG_TC"].ToString(), out gc))
                        {
                            gc = 1;
                        }
                        if (gc == 1)
                        {
                            GiaoHangThanhCong = true;
                        }
                        else
                        {
                            GiaoHangThanhCong = false;
                        }
                    }
                    chungtuct.GiaoHangThanhCong = GiaoHangThanhCong;
                    chungtuct.TenHang = item["Loại mặt hàng"].ToString();
                    chungtuct.TenNguoiNhan = item["ACCEPT_MAN"].ToString();
                    chungtuct.ThueGTGT = chungtuct.CuocPhiVanChuyen - chungtuct.CuocPhiChuaGTGT;
                    chungtuct.TrongLuong = decimal.Parse(item["BILL_WEIGHT"].ToString());
                    chungtuct.NgayGuiHang = Convert.ToDateTime(item["REGISTER_DATE"].ToString());
                    chungtuct.LoaiThanhToan = item["PAYMENT_TYPE_CODE"].ToString();
                    chungtukl.SoTienChi = chungtukl.SoTienChi + chungtuct.SoTienThuHo;
                    chungtuct.SoTienPhaiChi = decimal.Parse(item["GOODS_PAYMENT"].ToString());
                    if (chungtuct.LoaiThanhToan == "Nhận thanh toán")
                    {
                        chungtukl.TongPhiNhanTra = chungtukl.TongPhiNhanTra + chungtuct.CuocPhiVanChuyen;
                        chungtuct.SoTienPhaiThu = 0;
                    }
                    else
                    {
                        chungtukl.TongPhiGuiTra = chungtukl.TongPhiGuiTra + chungtuct.CuocPhiVanChuyen;
                        chungtuct.SoTienPhaiThu = chungtuct.CuocPhiVanChuyen;
                    }
                    chungtuct.SoTienPhaiChi = chungtuct.SoTienThuHo - chungtuct.SoTienPhaiThu;

                    chungtukl.TongPhiVanChuyen = chungtukl.TongPhiVanChuyen + chungtuct.CuocPhiVanChuyen;

                    chungtukl.TongThuHo = chungtukl.TongThuHo + chungtuct.SoTienThuHo;

                    dc.EXpchungtuct.InsertOnSubmit(base.ConnectionData.Schema, chungtuct);
                    count++;
                }
                // Cập nhật số tiền thu chi thực tế
                chungtukl.TongPhiChuaVAT = Math.Round(chungtukl.TongPhiVanChuyen / 1.1m);
                chungtukl.ThueVAT = chungtukl.TongPhiVanChuyen - chungtukl.TongPhiChuaVAT;

                chungtukl.SoTienChi = 0;
                chungtukl.SoTienThu = 0;
                if (chungtukl.TongThuHo - chungtukl.TongPhiGuiTra > 0)
                {
                    chungtukl.SoTienChi = chungtukl.TongThuHo - chungtukl.TongPhiGuiTra;
                }
                else
                {
                    chungtukl.SoTienThu = chungtukl.TongPhiGuiTra - chungtukl.TongThuHo;
                }
                dc.EXpchungtu.InsertOnSubmit(base.ConnectionData.Schema, chungtukl);

                kyKetToan.SoBangKe = SoBangKe;
                dc.EXpkykettoan.Update(base.ConnectionData.Schema, kyKetToan);
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
            return count;
        }
        public int CreateChungTu(string post, DateTime fromDate, DateTime toDate, string kyKetToanId, string fk_account)
        {
            int count = 0;
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();
                List<view_ExpBillHoaDonDoiSoat> lsChiTiet = dc.VIewexpbillhoadondoisoat.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post AND HoaDon='' AND CreateHd >='" + string.Format("{0:yyyy-MM-dd}", fromDate) + " 00:00:00' AND CreateHd <='" + string.Format("{0:yyyy-MM-dd}", toDate) + " 23:59:59' ",
                    "@FK_Post", post);

                ExpKyKetToan kyKetToan = dc.EXpkykettoan.GetObject(base.ConnectionData.Schema, kyKetToanId);
                if (kyKetToan == null)
                {
                    return 0;
                }
                int SoBangKe = kyKetToan.SoBangKe;
                // Chứng từ khách lẻ
                List<view_ExpBillHoaDonDoiSoat> lsChiTietKL = lsChiTiet.Where(u => u.ContractCustomer == false).ToList();
                ExpChungTu chungtukl = new ExpChungTu();
                chungtukl.Id = Guid.NewGuid().ToString();
                SoBangKe = SoBangKe + 1;
                chungtukl.SoChungTuThu = SoBangKe.ToString() + "/" + kyKetToan.TenKy;
                chungtukl.IsPhatHanh = false;
                chungtukl.DiaChi = "";
                chungtukl.FK_Account = fk_account;
                chungtukl.FK_Customer = "0000";
                chungtukl.FK_KyKetToan = kyKetToanId;
                chungtukl.LyDoChi = "Chi tiền theo danh sách chi tiền thu hộ cho khách lẻ số " + SoBangKe + "/SCT-LM ngày " + string.Format("{0:dd/MM/yyyy}", currentDate);
                chungtukl.LyDoThu = "Thu tiền phí cước dịch vụ chuyển phát nhanh";
                chungtukl.MaSoThue = "";
                chungtukl.NgayChungTu = currentDate;
                chungtukl.NgayHoaDon = currentDate;
                chungtukl.NguoiMuaHang = "Người mua không lấy hóa đơn";
                chungtukl.SoChungTuChi = SoBangKe + "/PC-LM";
                chungtukl.SoChungTuThu = SoBangKe + "/BK-LM";
                chungtukl.SoHoaDon = "0";
                chungtukl.SoTienChi = 0;
                chungtukl.SoTienThu = 0;
                chungtukl.ThangKT = kyKetToan.NgayTao;
                // =====
                chungtukl.SoChungTu = SoBangKe;
                chungtukl.TongThuHo = 0;
                chungtukl.TongPhiNhanTra = 0;
                chungtukl.TongPhiGuiTra = 0;
                chungtukl.TongPhiChuaVAT = 0;
                chungtukl.ThueVAT = 0;
                chungtukl.TongPhiVanChuyen = 0;

                foreach (var item in lsChiTietKL)
                {
                    ExpChungTuCt chungtuct = new ExpChungTuCt();
                    chungtuct.FK_ExpChungTu = chungtukl.Id;
                    chungtuct.BILL_CODE = item.BILL_CODE;
                    chungtuct.CuocPhiChuaGTGT = Math.Round(item.FREIGHT / 1.1m);
                    chungtuct.CuocPhiVanChuyen = item.FREIGHT;
                    chungtuct.DiaChiNhan = item.SUM_ADDRESS.Trim().TrimStart(',');
                    chungtuct.IsPhatHanh = false;
                    chungtuct.SoDienThoaiNhan = item.ACCEPT_MAN_PHONE;
                    chungtuct.SoTienThuHo = item.GOODS_PAYMENT;

                    bool GiaoHangThanhCong;
                    if (string.IsNullOrEmpty(item.GiaoThanhCong))
                    {
                        GiaoHangThanhCong = true;
                    }
                    else
                    {
                        int gc = 0;
                        if (!Int32.TryParse(item.GiaoThanhCong, out gc))
                        {
                            gc = 1;
                        }
                        if (gc == 1)
                        {
                            GiaoHangThanhCong = true;
                        }
                        else
                        {
                            GiaoHangThanhCong = false;
                        }
                    }
                    chungtuct.GiaoHangThanhCong = GiaoHangThanhCong;
                    chungtuct.TenHang = "Hoa kiểng";
                    chungtuct.TenNguoiNhan = item.ACCEPT_MAN;
                    chungtuct.ThueGTGT = item.FREIGHT - chungtuct.CuocPhiChuaGTGT;
                    chungtuct.TrongLuong = (decimal)item.BILL_WEIGHT;
                    chungtuct.NgayGuiHang = item.REGISTER_DATE;
                    chungtuct.LoaiThanhToan = item.PAY_TYPE;
                    chungtukl.SoTienChi = chungtukl.SoTienChi + chungtuct.SoTienThuHo;
                    chungtuct.SoTienPhaiChi = item.GOODS_PAYMENT;
                    if (item.PAY_TYPE == "Nhận thanh toán")
                    {
                        chungtukl.TongPhiNhanTra = chungtukl.TongPhiNhanTra + chungtuct.CuocPhiVanChuyen;
                        chungtuct.SoTienPhaiThu = 0;
                    }
                    else
                    {
                        chungtukl.TongPhiGuiTra = chungtukl.TongPhiGuiTra + chungtuct.CuocPhiVanChuyen;
                        chungtuct.SoTienPhaiThu = chungtuct.CuocPhiVanChuyen;
                    }
                    chungtuct.SoTienPhaiChi = chungtuct.SoTienThuHo - chungtuct.SoTienPhaiThu;

                    chungtukl.TongPhiVanChuyen = chungtukl.TongPhiVanChuyen + chungtuct.CuocPhiVanChuyen;

                    chungtukl.TongThuHo = chungtukl.TongThuHo + chungtuct.SoTienThuHo;

                    dc.EXpchungtuct.InsertOnSubmit(base.ConnectionData.Schema, chungtuct);
                    // Cập nhật hóa đơn
                    ExpHoaDonDoiSoat hoadon = dc.EXphoadondoisoat.GetObject(base.ConnectionData.Schema, chungtuct.BILL_CODE);
                    if (hoadon != null)
                    {
                        hoadon.HoaDon = chungtuct.FK_ExpChungTu;
                        dc.EXphoadondoisoat.Update(base.ConnectionData.Schema, hoadon);
                    }
                    count++;
                }
                // Cập nhật số tiền thu chi thực tế
                chungtukl.TongPhiChuaVAT = Math.Round(chungtukl.TongPhiVanChuyen / 1.1m);
                chungtukl.ThueVAT = chungtukl.TongPhiVanChuyen - chungtukl.TongPhiChuaVAT;

                chungtukl.SoTienChi = 0;
                chungtukl.SoTienThu = 0;
                if (chungtukl.TongThuHo - chungtukl.TongPhiGuiTra > 0)
                {
                    chungtukl.SoTienChi = chungtukl.TongThuHo - chungtukl.TongPhiGuiTra;
                }
                else
                {
                    chungtukl.SoTienThu = chungtukl.TongPhiGuiTra - chungtukl.TongThuHo;
                }
                dc.EXpchungtu.InsertOnSubmit(base.ConnectionData.Schema, chungtukl);
                // Chứng từ khách hợp đồng
                List<view_ExpBillHoaDonDoiSoat> lsChiTietHD = lsChiTiet.Where(u => u.ContractCustomer == true).ToList();
                var q = from c in lsChiTietHD
                        group c by c.FK_Customer into g
                        select new { g.Key, Count = g.Count() };


                foreach (var group in q)
                {
                    ExpCustomer khachHang = dc.EXpcustomer.GetObject(base.ConnectionData.Schema, group.Key);
                    List<view_ExpBillHoaDonDoiSoat> subList = lsChiTietHD.Where(u => u.FK_Customer == group.Key).ToList();
                    ExpChungTu chungtu = new ExpChungTu();
                    chungtu.Id = Guid.NewGuid().ToString();
                    SoBangKe = SoBangKe + 1;
                    chungtu.SoChungTuThu = SoBangKe.ToString() + "/" + kyKetToan.TenKy;
                    chungtu.IsPhatHanh = false;
                    chungtu.DiaChi = khachHang.DiaChi;
                    chungtu.FK_Account = fk_account;
                    chungtu.FK_Customer = khachHang.Id;
                    chungtu.FK_KyKetToan = kyKetToanId;
                    chungtu.LyDoChi = "Chi tiền theo biên bản cấn trừ công nợ số " + SoBangKe + "/BBCTCN-LM";
                    chungtu.LyDoThu = "Thu tiền cước dịch vụ chuyển phát nhanh theo bảng kê " + SoBangKe + "/BK-LM";
                    chungtu.MaSoThue = "";
                    chungtu.NgayChungTu = currentDate;
                    chungtu.NgayHoaDon = currentDate;
                    if (string.IsNullOrEmpty(khachHang.TenHopDong))
                    {
                        khachHang.TenHopDong = khachHang.CustomerName;
                    }
                    chungtu.NguoiMuaHang = khachHang.TenHopDong;
                    chungtu.SoChungTuChi = SoBangKe + "/PC-LM";
                    chungtu.SoChungTuThu = SoBangKe + "/BK-LM";
                    chungtu.SoHoaDon = "0";
                    chungtu.SoTienChi = 0;
                    chungtu.SoTienThu = 0;
                    chungtu.ThangKT = kyKetToan.NgayTao;

                    chungtu.SoChungTu = SoBangKe;
                    chungtu.TongThuHo = 0;
                    chungtu.TongPhiNhanTra = 0;
                    chungtu.TongPhiGuiTra = 0;

                    chungtu.TongPhiChuaVAT = 0;
                    chungtu.ThueVAT = 0;
                    chungtu.TongPhiVanChuyen = 0;

                    foreach (var item in subList)
                    {
                        ExpChungTuCt chungtuct = new ExpChungTuCt();
                        chungtuct.FK_ExpChungTu = chungtu.Id;
                        chungtuct.BILL_CODE = item.BILL_CODE;
                        chungtuct.CuocPhiChuaGTGT = Math.Round(item.FREIGHT / 1.1m);
                        chungtuct.CuocPhiVanChuyen = item.FREIGHT;
                        chungtuct.DiaChiNhan = item.SUM_ADDRESS.Trim().TrimStart(',');
                        chungtuct.IsPhatHanh = false;
                        chungtuct.SoDienThoaiNhan = item.ACCEPT_MAN_PHONE;
                        chungtuct.SoTienThuHo = item.GOODS_PAYMENT;
                        bool GiaoHangThanhCong;
                        if (string.IsNullOrEmpty(item.GiaoThanhCong))
                        {
                            GiaoHangThanhCong = true;
                        }
                        else
                        {
                            if (!bool.TryParse(item.GiaoThanhCong, out GiaoHangThanhCong))
                            {
                                GiaoHangThanhCong = true;
                            }
                        }
                        chungtuct.GiaoHangThanhCong = GiaoHangThanhCong;
                        chungtuct.TenHang = "Hoa kiểng";
                        chungtuct.TenNguoiNhan = item.ACCEPT_MAN;
                        chungtuct.ThueGTGT = item.FREIGHT - chungtuct.CuocPhiChuaGTGT;
                        chungtuct.TrongLuong = (decimal)item.BILL_WEIGHT;
                        chungtuct.NgayGuiHang = item.REGISTER_DATE;
                        chungtuct.LoaiThanhToan = item.PAY_TYPE;
                        if (item.PAY_TYPE == "Nhận thanh toán")
                        {
                            chungtu.TongPhiNhanTra = chungtu.TongPhiNhanTra + chungtuct.CuocPhiVanChuyen;
                            chungtuct.SoTienPhaiThu = 0;

                        }
                        else
                        {
                            chungtu.TongPhiGuiTra = chungtu.TongPhiGuiTra + chungtuct.CuocPhiVanChuyen;
                            chungtuct.SoTienPhaiThu = chungtuct.CuocPhiVanChuyen;
                        }
                        chungtuct.SoTienPhaiChi = chungtuct.SoTienThuHo - chungtuct.SoTienPhaiThu;

                        chungtu.TongPhiVanChuyen = chungtu.TongPhiVanChuyen + chungtuct.CuocPhiVanChuyen;
                        chungtu.TongPhiChuaVAT = chungtu.TongPhiChuaVAT + chungtuct.CuocPhiChuaGTGT;
                        chungtu.ThueVAT = chungtu.ThueVAT + chungtuct.ThueGTGT;
                        chungtu.TongThuHo = chungtu.TongThuHo + chungtuct.SoTienThuHo;

                        dc.EXpchungtuct.InsertOnSubmit(base.ConnectionData.Schema, chungtuct);
                        // Cập nhật hóa đơn
                        ExpHoaDonDoiSoat hoadon = dc.EXphoadondoisoat.GetObject(base.ConnectionData.Schema, chungtuct.BILL_CODE);
                        if (hoadon != null)
                        {
                            hoadon.HoaDon = chungtuct.FK_ExpChungTu;
                            dc.EXphoadondoisoat.Update(base.ConnectionData.Schema, hoadon);
                        }

                        count++;
                    }
                    // Cập nhật số tiền thu chi thực tế

                    chungtu.TongPhiChuaVAT = Math.Round(chungtu.TongPhiVanChuyen / 1.1m);
                    chungtu.ThueVAT = chungtu.TongPhiVanChuyen - chungtu.TongPhiChuaVAT;

                    chungtu.SoTienChi = 0;
                    chungtu.SoTienThu = 0;
                    if (chungtu.TongThuHo - chungtu.TongPhiGuiTra > 0)
                    {
                        chungtu.SoTienChi = chungtu.TongThuHo - chungtu.TongPhiGuiTra;
                    }
                    else
                    {
                        chungtu.SoTienThu = chungtu.TongPhiGuiTra - chungtu.TongThuHo;
                    }
                    dc.EXpchungtu.InsertOnSubmit(base.ConnectionData.Schema, chungtu);
                }
                kyKetToan.SoBangKe = SoBangKe;
                dc.EXpkykettoan.Update(base.ConnectionData.Schema, kyKetToan);
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
            return count;
        }

        public view_ExpChungTu GetChungTu(string Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpchungtu.GetObjectCon(base.ConnectionData.Schema, "WHERE Id=@Id", "@Id", Id);
            }
            catch
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }
        public List<view_ExpChungTuCt> GetChungTuChiTiet(string Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpchungtuct.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_ExpChungTu=@FK_ExpChungTu", "@FK_ExpChungTu", Id);
            }
            catch
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }
    }
}
