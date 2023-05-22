using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class ExpDoiSoatLogic : BaseLogic
    {
        public ExpDoiSoatLogic(BaseLogicConnectionData data) : base(data)
        {

        }
        public List<ExpPost> GetListPost(string idParrent)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpPost> items = dc.EXppost.GetListObjectCon(base.ConnectionData.Schema, "WHERE ParrentPost=@ParrentPost", "@ParrentPost", idParrent);
                ExpPost selectAll = new ExpPost();
                selectAll.Id = "0000";
                selectAll.Code = "0000";
                selectAll.TenDaiLy = "Tất cả";
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
        public async Task<string> ThanhToanTheoFile(string IdDoiSoat, Dictionary<string, decimal> lsThanhToan, string post, string userId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = DateTime.Now;
                decimal TongThanhToan = 0;
                ExpDoiSoat doiSoat = dc.EXpdoisoat.GetObject(base.ConnectionData.Schema, IdDoiSoat);
                foreach (var item in lsThanhToan)
                {
                    ExpDoiSoatChiTiet chiTiet = dc.EXpdoisoatchitiet.GetObject(base.ConnectionData.Schema, item.Key);
                    if (chiTiet != null)
                    {
                        if (chiTiet.DaThanhToanKH < item.Value)
                        {
                            TongThanhToan = TongThanhToan + item.Value - chiTiet.DaThanhToanKH;
                            chiTiet.DaThanhToanKH = item.Value;
                            chiTiet.NgayThanhToan = currentDate;
                            chiTiet.IsHoanThanh = true;
                            dc.EXpdoisoatchitiet.Update(base.ConnectionData.Schema, chiTiet);
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
                dc.EXpdoisoat.Update(base.ConnectionData.Schema, doiSoat);

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
        public async Task<string> ThanhToanTheoChiTiet(Dictionary<string, decimal> lsThanhToan, string post, string userId, string tenKhachHang, string SoDienThoai)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = DateTime.Now;

                foreach (var item in lsThanhToan)
                {
                    ExpDoiSoatChiTiet chiTiet = dc.EXpdoisoatchitiet.GetObject(base.ConnectionData.Schema, item.Key);
                    if (chiTiet != null)
                    {
                        int SoTienThanhToan = (int)(item.Value - chiTiet.DaThanhToanKH);

                        chiTiet.DaThanhToanKH = item.Value;
                        chiTiet.NgayThanhToan = currentDate;
                        chiTiet.IsHoanThanh = true;
                        dc.EXpdoisoatchitiet.Update(base.ConnectionData.Schema, chiTiet);

                        ExpDoiSoat doiSoat = dc.EXpdoisoat.GetObject(base.ConnectionData.Schema, chiTiet.FK_DoiSoat);
                        doiSoat.DaThanhToanKH = doiSoat.DaThanhToanKH + SoTienThanhToan;
                        dc.EXpdoisoat.Update(base.ConnectionData.Schema, doiSoat);
                        // Tạo phiếu chi tiền
                        SoQuyChiTienLogicInputDto payItem = new SoQuyChiTienLogicInputDto();
                        payItem.FK_ExtPost = post;
                        payItem.IsPay = true;
                        payItem.MaNguoiNopNhan = userId;
                        payItem.TenNguoiNopNhan = tenKhachHang;
                        payItem.DiaChi = "XXXX";
                        payItem.SoDienThoai = SoDienThoai;
                        payItem.Value = SoTienThanhToan;
                        payItem.CreateBy = userId;
                        payItem.SoChungTu = doiSoat.Id;
                        payItem.Type = "PAY_COD";
                        payItem.Note = "Thanh toán tiền COD theo kỳ đối soát ngày " + string.Format("{0:dd/MM/yyyy}", doiSoat.NgayDoiSoat) + " cho khách hàng " + tenKhachHang + " - SĐT:" + SoDienThoai;
                        payItem.IsDelete = false;
                        SoQuyChiTienLogic _logic = new SoQuyChiTienLogic(base.ConnectionData);
                        await _logic.Create(payItem);

                    }
                }
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
        public List<ExpDoiSoat> GetDoiSoat(string post, DateTime from, DateTime to)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string codition = "WHERE NgayDoiSoat >='" + string.Format("{0:yyyy-MM-dd}", from) + " 00:00:00' AND NgayDoiSoat <='" + string.Format("{0:yyyy-MM-dd}", to) + " 23:59:59' AND Post='" + post + "'";
                if (post == "0000")
                {
                    codition = "WHERE NgayDoiSoat >='" + string.Format("{0:yyyy-MM-dd}", from) + " 00:00:00' AND NgayDoiSoat <='" + string.Format("{0:yyyy-MM-dd}", to) + " 23:59:59'";
                }
                return dc.EXpdoisoat.GetListObjectCon(base.ConnectionData.Schema, codition);
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
        public List<ExpDoiSoatChiTiet> GetDoiSoatChiTiet(string IdDoiSoat, out ExpDoiSoat doisoat)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                doisoat = dc.EXpdoisoat.GetObject(base.ConnectionData.Schema, IdDoiSoat);
                if (doisoat == null)
                {
                    doisoat = new ExpDoiSoat();
                    return new List<ExpDoiSoatChiTiet>();
                }
                return dc.EXpdoisoatchitiet.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_DoiSoat=@FK_DoiSoat", "@FK_DoiSoat", IdDoiSoat);
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
        public List<ExpDoiSoatChiTietCt> GetDoiSoatChiTietCt(string IdChiTiet, out ExpDoiSoatChiTiet chitiet)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                chitiet = dc.EXpdoisoatchitiet.GetObject(base.ConnectionData.Schema, IdChiTiet);
                if (chitiet == null)
                {
                    chitiet = new ExpDoiSoatChiTiet();
                    return new List<ExpDoiSoatChiTietCt>();
                }
                return dc.EXpdoisoatchitietct.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_DoiSoatChiTiet=@FK_DoiSoatChiTiet", "@FK_DoiSoatChiTiet", IdChiTiet);
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
        public List<ExpDoiSoatChiTietCt> GetDoiSoatChiTietCt(string IdChiTiet)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpdoisoatchitietct.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_DoiSoatChiTiet=@FK_DoiSoatChiTiet", "@FK_DoiSoatChiTiet", IdChiTiet);
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
        public List<view_DoiSoatChiTiet> GetDoiSoatChiTietKL(string customerPhone)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewdoisoatchitiet.GetListObjectCon(base.ConnectionData.Schema, "WHERE SoDienThoai=@SoDienThoai AND (IsHoanThanh IS NULL OR IsHoanThanh=0)", "@SoDienThoai", customerPhone);
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
        public List<view_DoiSoatChiTiet> GetDoiSoatChiTietById(string IdDoiSoat)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewdoisoatchitiet.GetListObjectCon(base.ConnectionData.Schema, "WHERE Id IN(" + IdDoiSoat + ")");
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

