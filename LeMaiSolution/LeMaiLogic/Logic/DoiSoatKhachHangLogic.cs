using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public class DoiSoatKhachHangLogic : BaseLogic
    {
        public DoiSoatKhachHangLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        public List<GExpProvider> GetProviderList(string post)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<GExpProvider> list = new List<GExpProvider>();
                list.Add(new GExpProvider { Id = "9999", ProviderName = "Vui lòng chọn tài khoản BT3" });
                list.AddRange(dc.GExpprovider.GetListObjectCon(base.ConnectionData.Schema, "WHERE Post=@Post AND IsOwner=@IsOwner ORDER BY SelectIndex", "@Post", post, "@IsOwner", false));
                return list;
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
        public List<GExpProvider> GetProviderListMaster(string post)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<GExpProvider> list = new List<GExpProvider>();
                list.Add(new GExpProvider { Id = "9999", ProviderName = "Vui lòng chọn tài khoản BT3" });
                list.AddRange(dc.GExpprovider.GetListObjectCon(base.ConnectionData.Schema, "WHERE Post=@Post AND IsOwner=@IsOwner ORDER BY SelectIndex", "@Post", post, "@IsOwner", true));
                return list;
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
        public List<GExpProvider> GetProviderListAndAll(string post)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<GExpProvider> list = new List<GExpProvider>();
                list.Add(new GExpProvider { Id = "9999", ProviderName = "Tất cả" });
                list.AddRange(dc.GExpprovider.GetListObjectCon(base.ConnectionData.Schema, "WHERE Post=@Post AND IsOwner=@IsOwner ORDER BY SelectIndex", "@Post", post, "@IsOwner", false));
                return list;
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
        public List<GExpProvider> GetProviderListMasterAndAll(string post)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<GExpProvider> list = new List<GExpProvider>();
                list.Add(new GExpProvider { Id = "9999", ProviderName = "Tất cả" });
                list.AddRange(dc.GExpprovider.GetListObjectCon(base.ConnectionData.Schema, "WHERE Post=@Post AND IsOwner=@IsOwner ORDER BY SelectIndex", "@Post", post, "@IsOwner", true));
                return list;
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
        public GExpProvider GetProviderDetail(string providerId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExpprovider.GetObject(base.ConnectionData.Schema, providerId);
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

        public List<view_GExpMoneyReturnSession> GetMoneyReturnSessionList(string providerId, DateTime from, DateTime to, string post)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string codition = "WHERE Post='" + post + "' AND DateReturn>='" + string.Format("{0:yyyy-MM-dd}", from) + " 00:00:00' AND DateReturn<='" + string.Format("{0:yyyy-MM-dd}", to) + " 23:59:59' ";
                if (providerId != "9999")
                {
                    codition = codition + " AND FK_ProviderAccount='" + providerId + "'";
                }
                return dc.VIewgexpmoneyreturnsession.GetListObjectCon(base.ConnectionData.Schema, codition + " ORDER BY DateReturn desc");
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
        public List<view_GExpMoneyReturn> GetMoneyReturnList(string sessionId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpmoneyreturn.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_MoneyReturnSession='" + sessionId + "'");
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

        public view_GExpMoneyReturnSession GetMoneyReturnSessionDetail(string sessionId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpmoneyreturnsession.GetObjectCon(base.ConnectionData.Schema, "WHERE Id=@Id", "@Id", sessionId);
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
        public string DeleteMoneyReturnSession(string sessionId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpMoneyReturnSession session = dc.GExpmoneyreturnsession.GetObject(base.ConnectionData.Schema, sessionId);
                if (session != null)
                {
                    if (session.IsPayCustomer == true)
                    {
                        return "Kỳ đối soát đã được thanh toán cho khách hàng không thể xóa được! Vui lòng kiểm tra lại.";
                    }
                    else
                    {
                        dc.GExpmoneyreturn.DeleteOnSubmitCon(base.ConnectionData.Schema, "WHERE FK_MoneyReturnSession=@FK_MoneyReturnSession", "@FK_MoneyReturnSession", session.Id);
                        dc.GExpmoneyreturnsession.DeleteOnSubmit(base.ConnectionData.Schema, session);
                        dc.SubmitChanges();
                        return "Xóa dữ liệu kỳ đối soát thành công!";
                    }
                }
                else
                {
                    return "Không tìm thấy dữ liệu cần xóa.";
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
        public List<GExpDoiSoat> GetDoiSoat(string post, DateTime from, DateTime to)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string codition = "WHERE NgayDoiSoat >='" + string.Format("{0:yyyy-MM-dd}", from) + " 00:00:00' AND NgayDoiSoat <='" + string.Format("{0:yyyy-MM-dd}", to) + " 23:59:59' AND Post='" + post + "' ORDER BY NgayDoiSoat desc";
                if (post == "0000")
                {
                    codition = "WHERE NgayDoiSoat >='" + string.Format("{0:yyyy-MM-dd}", from) + " 00:00:00' AND NgayDoiSoat <='" + string.Format("{0:yyyy-MM-dd}", to) + " 23:59:59' AND Post='" + post + "' ORDER BY NgayDoiSoat desc";
                }
                return dc.GExpdoisoat.GetListObjectCon(base.ConnectionData.Schema, codition);
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
        public GExpDoiSoat GetDoiSoatDetail(string IdDoiSoat)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExpdoisoat.GetObject(base.ConnectionData.Schema, IdDoiSoat);
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
        public bool DeleteDotDoiSoat(string IdDoiSoat)
        {
            bool rs = false;
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<GExpMoneyReturnSession> list = dc.GExpmoneyreturnsession.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_DoiSoat=@FK_DoiSoat", "@FK_DoiSoat", IdDoiSoat);
                foreach (var item in list)
                {
                    item.FK_DoiSoat = string.Empty;
                    dc.GExpmoneyreturnsession.Update(base.ConnectionData.Schema, item);
                }
                List<GExpDoiSoatChiTiet> lsChiTiet = dc.GExpdoisoatchitiet.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_DoiSoat=@FK_DoiSoat", "@FK_DoiSoat", IdDoiSoat);
                foreach (var chitiet in lsChiTiet)
                {
                    // Xóa đối soát chi tiết
                    dc.GExpdoisoatchitiet.DeleteOnSubmit(base.ConnectionData.Schema, chitiet);
                    // Xóa đối soát chi tiết ct
                    dc.GExpdoisoatchitietct.DeleteOnSubmitCon(base.ConnectionData.Schema, "WHERE FK_DoiSoatChiTiet=@FK_DoiSoatChiTiet", "@FK_DoiSoatChiTiet", chitiet.Id);
                }
                dc.GExpdoisoat.DeleteOnSubmit(base.ConnectionData.Schema, IdDoiSoat);
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
            return rs;
        }
        public List<GExpDoiSoatChiTiet> GetDoiSoatChiTiet(string IdDoiSoat, out GExpDoiSoat doisoat)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                doisoat = dc.GExpdoisoat.GetObject(base.ConnectionData.Schema, IdDoiSoat);
                if (doisoat == null)
                {
                    doisoat = new GExpDoiSoat();
                    return new List<GExpDoiSoatChiTiet>();
                }
                return dc.GExpdoisoatchitiet.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_DoiSoat=@FK_DoiSoat", "@FK_DoiSoat", IdDoiSoat);
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

        public List<GExpDoiSoatChiTietCt> GetDoiSoatChiTietCt(string IdChiTiet, out GExpDoiSoatChiTiet chitiet)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                chitiet = dc.GExpdoisoatchitiet.GetObject(base.ConnectionData.Schema, IdChiTiet);
                if (chitiet == null)
                {
                    chitiet = new GExpDoiSoatChiTiet();
                    return new List<GExpDoiSoatChiTietCt>();
                }
                return dc.GExpdoisoatchitietct.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_DoiSoatChiTiet=@FK_DoiSoatChiTiet", "@FK_DoiSoatChiTiet", IdChiTiet);
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
        public List<ExpCustomer> GetCustomerListKL(string postID, string keyword = "")
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpCustomer> list = new List<ExpCustomer>();
                // Search
                string searchKey = UnSigns(keyword);
                List<ExpCustomer> temp = dc.EXpcustomer.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post AND (UnsigName LIKE '%" + searchKey + "%' OR CustomerPhone LIKE '%" + searchKey + "%' OR CustomerName LIKE N'%" + searchKey + "%') ORDER BY CustomerName", "@FK_Post", postID);
                foreach (var item in temp)
                {
                    item.CustomerName = item.CustomerName + " - " + item.CustomerPhone;
                    list.Add(item);
                }
                return list;
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
        public List<view_GExpDoiSoatChiTiet> GetDoiSoatChiTietKL(string customerPhone)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpdoisoatchitiet.GetListObjectCon(base.ConnectionData.Schema, "WHERE SoDienThoai=@SoDienThoai AND (IsHoanThanh IS NULL OR IsHoanThanh=0)", "@SoDienThoai", customerPhone);
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
        public List<GExpDoiSoatChiTietCt> GetDoiSoatChiTietCt(string IdChiTiet)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExpdoisoatchitietct.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_DoiSoatChiTiet=@FK_DoiSoatChiTiet ORDER BY BillCode", "@FK_DoiSoatChiTiet", IdChiTiet);
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
        public List<GExpDoiSoatChiTietCt> GetAllDoiSoatChiTietCt(string IdDoiSoat)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExpdoisoatchitietct.GetListObjectCon(base.ConnectionData.Schema, "INNER JOIN GExpDoiSoatChiTiet B ON A.FK_DoiSoatChiTiet = B.Id WHERE B.FK_DoiSoat=@FK_DoiSoat ORDER BY BillCode", "@FK_DoiSoat", IdDoiSoat);
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
        public async Task<string> ThanhToanTheoFile(string IdDoiSoat, Dictionary<string, decimal> lsThanhToan, string post, string userId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = DateTime.Now;
                decimal TongThanhToan = 0;
                GExpDoiSoat doiSoat = dc.GExpdoisoat.GetObject(base.ConnectionData.Schema, IdDoiSoat);
                foreach (var item in lsThanhToan)
                {
                    GExpDoiSoatChiTiet chiTiet = dc.GExpdoisoatchitiet.GetObject(base.ConnectionData.Schema, item.Key);
                    if (chiTiet != null)
                    {
                        if (chiTiet.DaThanhToanKH < item.Value)
                        {
                            TongThanhToan = TongThanhToan + item.Value - chiTiet.DaThanhToanKH;
                            chiTiet.DaThanhToanKH = item.Value;
                            chiTiet.NgayThanhToan = currentDate;
                            chiTiet.IsHoanThanh = true;
                            dc.GExpdoisoatchitiet.Update(base.ConnectionData.Schema, chiTiet);
                            // Update trạng thái thanh toán khách hàng
                            List<GExpDoiSoatChiTietCt> lsChitietct = dc.GExpdoisoatchitietct.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_DoiSoatChiTiet=@FK_DoiSoatChiTiet", "@FK_DoiSoatChiTiet", chiTiet.Id);
                            foreach (var chitietct in lsChitietct)
                            {
                                GExpBill bill = dc.GExpbill.GetObject(base.ConnectionData.Schema, chitietct.BillCode);
                                if (bill != null)
                                {
                                    if (bill.IsPayCustomer == false)
                                    {
                                        bill.IsPayCustomer = true;
                                        bill.PayCustomerDate = currentDate;
                                        dc.GExpbill.Update(base.ConnectionData.Schema, bill);
                                    }
                                }
                            }
                        }
                    }
                }
                if (TongThanhToan > 0)
                {
                    // Tạo phiếu chi tiền thay đổi số dư
                    SoQuyChiTienLogicInputDto payItem = new SoQuyChiTienLogicInputDto();
                    payItem.FK_ExtPost = post;
                    payItem.IsPay = true;
                    payItem.MaNguoiNopNhan = userId;
                    payItem.TenNguoiNopNhan = "Thanh toán COD ngày " + string.Format("{0:dd/MM/yyyy}", doiSoat.NgayDoiSoat);
                    payItem.DiaChi = "XXXX";
                    payItem.SoDienThoai = "XXXX";
                    payItem.Value = (int)TongThanhToan;
                    payItem.CreateBy = userId;
                    payItem.SoChungTu = doiSoat.Id;
                    payItem.Type = "PAY_COD";
                    payItem.Note = "Thanh toán tiền COD theo kỳ đối soát ngày " + string.Format("{0:dd/MM/yyyy}", doiSoat.NgayDoiSoat);
                    payItem.IsDelete = false;
                    SoQuyChiTienLogic _logic = new SoQuyChiTienLogic(base.ConnectionData);
                    await _logic.Create(payItem);
                }

                doiSoat.DaThanhToanKH = doiSoat.DaThanhToanKH + TongThanhToan;
                dc.GExpdoisoat.Update(base.ConnectionData.Schema, doiSoat);

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
            return string.Empty;
        }
        public List<view_GExpDoiSoatChiTiet> GetDoiSoatChiTietByIds(string IdDoiSoat)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpdoisoatchitiet.GetListObjectCon(base.ConnectionData.Schema, "WHERE Id IN(" + IdDoiSoat + ")");
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
        public List<view_GExpDoiSoatChiTiet> GetDoiSoatChiTietById(string IdDoiSoat)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpdoisoatchitiet.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_DoiSoat=@FK_DoiSoat", "@FK_DoiSoat", IdDoiSoat);
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
        public GExpDoiSoat CreateDoiSoat(string post, string userId, string fullName, out string errorMessage)
        {
            errorMessage = string.Empty;
            GExpDoiSoat doisoat = new GExpDoiSoat();
            doisoat.Id = Guid.NewGuid().ToString();
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();
                List<view_GExpBill> billsVanTai = dc.VIewgexpbill.GetListObjectCon(base.ConnectionData.Schema, "WHERE RunMode=@RunMode AND IsSigned=@IsSigned AND IsPayCustomer=@IsPayCustomer AND RegisterSiteCode=@RegisterSiteCode",
                    "@RunMode", 0,
                    "@IsSigned", true,
                    "@IsPayCustomer", false,
                    "@RegisterSiteCode", post);
                List<GExpDoiSoatChiTiet> lsChiTiet = new List<GExpDoiSoatChiTiet>();
                List<GExpMoneyReturnSession> lsSession = dc.GExpmoneyreturnsession.GetListObjectCon(base.ConnectionData.Schema, "WHERE (FK_DoiSoat IS NULL OR FK_DoiSoat='') AND Post=@Post",
                    "@IsPayCustomer", false
                    , "@Post", post);
                if (lsSession.Count == 0 && billsVanTai.Count == 0)
                {
                    errorMessage = "Không tìm thấy dữ liệu đối soát chưa thanh toán cho khách hàng!";
                    return null;
                }
                foreach (var item in lsSession)
                {
                    List<view_GExpMoneyReturn> lsMoney = dc.VIewgexpmoneyreturn.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_MoneyReturnSession=@FK_MoneyReturnSession AND (Status=1 OR Status=2) AND FK_Customer IS NOT NULL", "@FK_MoneyReturnSession", item.Id);
                    foreach (var money in lsMoney)
                    {
                        GExpDoiSoatHistory history = dc.GExpdoisoathistory.GetObject(base.ConnectionData.Schema, money.BillCode);
                        if (history != null)
                        {
                            // Đơn hàng đã nhập đối soát rồi thì thôi bỏ qua
                            continue;
                        }
                        GExpDoiSoatChiTietCt chitietct = new GExpDoiSoatChiTietCt();
                        GExpDoiSoatChiTiet chitiet = lsChiTiet.FirstOrDefault(u => u.FK_Customer == money.FK_Customer);
                        if (chitiet == null)
                        {
                            chitiet = new GExpDoiSoatChiTiet();
                            chitiet.Id = Guid.NewGuid().ToString();
                            chitiet.FK_DoiSoat = doisoat.Id;
                            chitiet.FK_Customer = money.FK_Customer;
                            chitiet.TenKhachHang = money.SendMan;
                            chitiet.SoDienThoai = money.SendManPhone;
                            chitiet.SoLuongDon = 1;
                            chitiet.ThuHo = (decimal)money.COD;
                            chitiet.ThuHoKT = 0;
                            chitiet.SaiLech = 0;

                            chitiet.CuocNhanTra = 0;
                            if (money.FK_PaymentType == "GTT")
                            {
                                chitiet.CuocGuiTra = (decimal)money.Freight;
                                chitiet.ThanhToanKH = chitiet.ThuHo - chitiet.CuocGuiTra;
                            }
                            else
                            {
                                chitiet.CuocNhanTra = (decimal)money.Freight;
                                chitiet.ThanhToanKH = chitiet.ThuHo;
                            }
                            chitiet.ChiPhi = 0;
                            chitiet.LoiNhuan = 0;
                            chitiet.DaThanhToanKH = 0;
                            chitiet.IsHoanThanh = false;
                            // Thêm chi tiết vào trong danh sách
                            lsChiTiet.Add(chitiet);
                        }
                        else
                        {
                            chitiet.SoLuongDon = chitiet.SoLuongDon + 1;
                            chitiet.ThuHo = chitiet.ThuHo + (decimal)money.COD;
                            if (money.FK_PaymentType == "GTT")
                            {
                                chitiet.CuocGuiTra = chitiet.CuocGuiTra + (decimal)money.Freight;
                                chitiet.ThanhToanKH = chitiet.ThanhToanKH + (decimal)money.COD - (decimal)money.Freight;
                            }
                            else
                            {
                                chitiet.CuocNhanTra = chitiet.CuocNhanTra + (decimal)money.Freight;
                                chitiet.ThanhToanKH = chitiet.ThanhToanKH + (decimal)money.COD;
                            }
                        }
                        decimal totalFee = 0;
                        if (!decimal.TryParse(dc.GetData("SELECT COALESCE(SUM(FeeConfirm),0 )as Total FROM GExpProfit WHERE BT3Code='" + money.BT3Code + "'").Rows[0][0].ToString(), out totalFee))
                        {
                            totalFee = 0;
                        }
                        chitiet.ChiPhi = chitiet.ChiPhi + totalFee;
                        chitiet.LoiNhuan = chitiet.LoiNhuan + (decimal)money.Freight - totalFee;
                        // Thêm chitietct
                        chitietct.BillCode = money.BillCode;
                        chitietct.TrongLuongKH = money.FeeWeight;
                        chitietct.FK_DoiSoatChiTiet = chitiet.Id;
                        chitietct.NguoiGui = money.SendMan;
                        chitietct.NguoiNhan = money.AcceptMan;
                        chitietct.SoDienThoai = money.AcceptManPhone;
                        chitietct.NoiDen = money.AcceptProvince;
                        chitietct.ThuHo = (decimal)money.COD;
                        chitietct.TrongLuong = money.BillWeight;
                        chitietct.Status = money.Status;
                        chitietct.NgayGuiHang = string.Format("{0:dd/MM/yyyy HH:mm}", money.RegisterDate);
                        if (money.DateReturn.HasValue)
                        {
                            chitietct.NgayKyNhan = string.Format("{0:dd/MM/yyyy}", (DateTime)money.DateReturn);
                        }
                        else
                        {
                            chitietct.NgayKyNhan = "'";
                        }

                        chitietct.CuocVanChuyen = (decimal)money.Freight;
                        chitietct.LoaiThanhToan = money.PayType;
                        chitietct.LoaiKien = money.ProviderTypeCode;
                        chitietct.PhiVC = totalFee;
                        if (chitietct.Status == 2)
                        {
                            // Đơn hàng hoàn thì tiền thu hộ = 0
                            chitietct.ThuHo = 0;
                        }
                        ExpCODCK codCK = dc.EXpcodck.GetObject(base.ConnectionData.Schema, money.BillCode);
                        if (codCK != null)
                        {
                            chitietct.ThuHo = chitietct.ThuHo - codCK.SoTienCKCOD;
                        }

                        if (money.FK_PaymentType == "GTT")
                        {
                            chitietct.SoTienThanhToan = (decimal)chitietct.ThuHo - (decimal)money.Freight;
                        }
                        else
                        {
                            chitietct.SoTienThanhToan = (decimal)chitietct.ThuHo;
                        }

                        if (chitietct.Status == 1)
                        {
                            chitietct.GhiChu = "Giao thành công";
                        }
                        else if (chitietct.Status == 2)
                        {
                            chitietct.GhiChu = "Hoàn";
                        }
                        chitietct.IsHoanThanh = false;
                        //
                        dc.GExpdoisoatchitietct.InsertOnSubmit(base.ConnectionData.Schema, chitietct);
                    }
                    // Cập nhật lại return money để lần sau xuất đối soát không bị trùng nữa
                    item.FK_DoiSoat = doisoat.Id;
                    dc.GExpmoneyreturnsession.Update(base.ConnectionData.Schema, item);
                }
                // Đối soát đơn vận tải
                foreach (var vantai in billsVanTai)
                {
                    GExpDoiSoatHistory history = dc.GExpdoisoathistory.GetObject(base.ConnectionData.Schema, vantai.BillCode);
                    if (history != null)
                    {
                        // Đơn hàng đã nhập đối soát rồi thì thôi bỏ qua
                        continue;
                    }
                    GExpDoiSoatChiTietCt chitietct = new GExpDoiSoatChiTietCt();
                    GExpDoiSoatChiTiet chitiet = lsChiTiet.FirstOrDefault(u => u.FK_Customer == vantai.FK_Customer);
                    if (chitiet == null)
                    {
                        chitiet = new GExpDoiSoatChiTiet();
                        chitiet.Id = Guid.NewGuid().ToString();
                        chitiet.FK_DoiSoat = doisoat.Id;
                        chitiet.FK_Customer = vantai.FK_Customer;
                        chitiet.TenKhachHang = vantai.SendMan;
                        chitiet.SoDienThoai = vantai.SendManPhone;
                        chitiet.SoLuongDon = 1;
                        chitiet.ThuHo = (decimal)vantai.COD;
                        chitiet.ThuHoKT = 0;
                        chitiet.SaiLech = 0;
                        chitiet.CuocNhanTra = 0;
                        if (vantai.FK_PaymentType == "GTT")
                        {
                            chitiet.CuocGuiTra = (decimal)vantai.Freight;
                            chitiet.ThanhToanKH = chitiet.ThuHo - chitiet.CuocGuiTra;
                        }
                        else
                        {
                            chitiet.CuocNhanTra = (decimal)vantai.Freight;
                            chitiet.ThanhToanKH = chitiet.ThuHo;
                        }
                        chitiet.ChiPhi = 0;
                        chitiet.LoiNhuan = 0;
                        chitiet.DaThanhToanKH = 0;
                        chitiet.IsHoanThanh = false;
                        // Thêm chi tiết vào trong danh sách
                        lsChiTiet.Add(chitiet);
                    }
                    else
                    {
                        chitiet.SoLuongDon = chitiet.SoLuongDon + 1;
                        chitiet.ThuHo = chitiet.ThuHo + (decimal)vantai.COD;
                        if (vantai.FK_PaymentType == "GTT")
                        {
                            chitiet.CuocGuiTra = chitiet.CuocGuiTra + (decimal)vantai.Freight;
                            chitiet.ThanhToanKH = chitiet.ThanhToanKH + (decimal)vantai.COD - (decimal)vantai.Freight;
                        }
                        else
                        {
                            chitiet.CuocNhanTra = chitiet.CuocNhanTra + (decimal)vantai.Freight;
                            chitiet.ThanhToanKH = chitiet.ThanhToanKH + (decimal)vantai.COD;
                        }
                    }
                    // Thêm chitietct
                    chitietct.BillCode = vantai.BillCode;
                    chitietct.TrongLuongKH = vantai.FeeWeight;
                    chitietct.FK_DoiSoatChiTiet = chitiet.Id;
                    chitietct.NguoiGui = vantai.SendMan;
                    chitietct.NguoiNhan = vantai.AcceptMan;
                    chitietct.SoDienThoai = vantai.AcceptManPhone;
                    chitietct.NoiDen = vantai.AcceptProvince;
                    chitietct.ThuHo = (decimal)vantai.COD;
                    chitietct.TrongLuong = vantai.BillWeight;

                    if (vantai.IsReturn == true)
                    {
                        chitietct.Status = 2;
                    }
                    else
                    {
                        chitietct.Status = 1;
                    }

                    chitietct.NgayGuiHang = string.Format("{0:dd/MM/yyyy HH:mm}", vantai.RegisterDate);
                    chitietct.NgayKyNhan = string.Format("{0:dd/MM/yyyy}", (DateTime)vantai.SignedDate);
                    chitietct.CuocVanChuyen = (decimal)vantai.Freight;
                    chitietct.LoaiThanhToan = vantai.PayType;
                    chitietct.LoaiKien = vantai.ProviderTypeCode;

                    if (chitietct.Status == 2)
                    {
                        // Đơn hàng hoàn thì tiền thu hộ =0
                        vantai.COD = 0;
                    }
                    if (vantai.FK_PaymentType == "GTT")
                    {
                        chitietct.SoTienThanhToan = (decimal)vantai.COD - (decimal)vantai.Freight;
                    }
                    else
                    {
                        chitietct.SoTienThanhToan = (decimal)vantai.COD;
                    }
                    ExpCODCK codCK = dc.EXpcodck.GetObject(base.ConnectionData.Schema, vantai.BillCode);
                    if (codCK != null)
                    {
                        chitietct.SoTienThanhToan = chitietct.SoTienThanhToan - codCK.SoTienCKCOD;
                    }
                    if (chitietct.Status == 1)
                    {
                        chitietct.GhiChu = "Giao thành công";
                    }
                    else if (chitietct.Status == 2)
                    {
                        chitietct.GhiChu = "Hoàn";
                    }
                    chitietct.IsHoanThanh = false;
                    //
                    dc.GExpdoisoatchitietct.InsertOnSubmit(base.ConnectionData.Schema, chitietct);
                }
                // Summayry đối soát
                doisoat.Post = post;
                doisoat.NguoiDoiSoat = userId;
                doisoat.NgayDoiSoat = currentDate;
                doisoat.ThuHo = lsChiTiet.Sum(s => s.ThuHo);
                doisoat.ThuHoKT = lsChiTiet.Sum(s => s.ThuHoKT);
                doisoat.SaiLech = lsChiTiet.Sum(s => s.SaiLech);
                doisoat.CuocGuiTra = lsChiTiet.Sum(s => s.CuocGuiTra);
                doisoat.CuocNhanTra = lsChiTiet.Sum(s => s.CuocNhanTra);
                doisoat.ChiPhi = lsChiTiet.Sum(s => s.ChiPhi);
                doisoat.LoiNhuan = lsChiTiet.Sum(s => s.LoiNhuan);
                doisoat.ThanhToanKH = lsChiTiet.Sum(s => s.ThanhToanKH);
                doisoat.DaThanhToanKH = lsChiTiet.Sum(s => s.DaThanhToanKH);
                doisoat.SoLuongDon = lsChiTiet.Sum(s => s.SoLuongDon);
                // Insert chi tiết
                dc.GExpdoisoatchitiet.InsertAllSubmit(base.ConnectionData.Schema, lsChiTiet);
                // Insert đối soát
                dc.GExpdoisoat.InsertOnSubmit(base.ConnectionData.Schema, doisoat);
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
            return doisoat;
        }
        public decimal InsertProfit(List<GExpProfit> profits, out int Count)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                Count = 0;
                decimal total = 0;
                foreach (var item in profits)
                {
                    item.DateComfirm = new DateTime(item.DateComfirm.Year, item.DateComfirm.Month, item.DateComfirm.Day, item.DateComfirm.Hour, item.DateComfirm.Minute, 0, 0);
                    GExpProfit pro = dc.GExpprofit.GetObjectCon(base.ConnectionData.Schema, "WHERE BT3Code=@BT3Code AND DateComfirm='" + string.Format("{0:yyyy-MM-dd HH:mm}", item.DateComfirm) + "'",
                        "@BT3Code", item.BT3Code);
                    if (pro == null)
                    {
                        dc.GExpprofit.InsertOnSubmit(base.ConnectionData.Schema, item);
                        total = total + item.FeeConfirm;
                        Count++;
                    }
                }
                dc.SubmitChanges();
                return total;
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

