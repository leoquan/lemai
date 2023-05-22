using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class SoQuyChiTienLogic : BaseLogic
    {
        public SoQuyChiTienLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        /// <summary>
        /// Get all view_ExpCashPay List
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_ExpCashPay>> GetList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpcashpay.GetListObject(base.ConnectionData.Schema);
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
        /// Tìm view_ExpCashPay theo keyword
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_ExpCashPay>> GetList(string keyword, string accountId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = " WHERE IsPay=1 AND FK_ExtPost IN(SELECT FK_ExpPost FROM ExpPostAccount WHERE FK_AccountId='" + accountId + "') ";
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " AND TenNguoiNopNhan like N'%" + keyword + "%' | NguoiThu like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY CreateDate asc";
                return dc.VIewexpcashpay.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        public async Task<List<view_ExpCashPay>> GetListCash(string keyword, string accountId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = " WHERE IsPay=0 AND FK_ExtPost IN(SELECT FK_ExpPost FROM ExpPostAccount WHERE FK_AccountId='" + accountId + "') ";
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " AND TenNguoiNopNhan like N'%" + keyword + "%' | NguoiThu like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY CreateDate asc";
                return dc.VIewexpcashpay.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        /// Danh sách view_ExpCashPay theo giới hạn keyword và page
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="page">Số trang hiển thị</param>
        /// <returns></returns>
        public async Task<List<view_ExpCashPay>> GetPage(string keyword, int? page)
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
        /// Danh sách view_ExpCashPay theo giới hạn keyword, Take, Skip
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<List<view_ExpCashPay>> GetPage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE TenNguoiNopNhan like N'%" + keyword + "%' | NguoiThu like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY CreateDate asc";
                return dc.VIewexpcashpay.GetListObjectLimitCon(base.ConnectionData.Schema, "*", condition, Take, Skip);
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
        /// Tuple Danh sách view_ExpCashPay theo giới hạn keyword, Take, Skip và số dòng dữ liệu
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<Tuple<List<view_ExpCashPay>, int>> GetTuplePage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                var list = dc.VIewexpcashpay.GetListObject(base.ConnectionData.Schema);
                var data = await GetPage(keyword, Take, Skip);
                return new Tuple<List<view_ExpCashPay>, int>(data, list.Count);
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
        /// Get List of SameSoQuyChiTienLogic
        /// </summary>
        /// <param name="Id">Id Of ExpCashPay</param>
        /// <returns></returns>
        public async Task<List<view_ExpCashPay>> GetSameList(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int take = 10;
                return dc.VIewexpcashpay.GetListObjectLimitCon(base.ConnectionData.Schema, "*", "WHERE Id<>@Id  ", take, 0, "@Id", Id);
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
        /// Get view_ExpCashPay Object
        /// </summary>
        /// <param name="Id">Id Of ExpCashPay</param>
        /// <returns></returns>
        public async Task<view_ExpCashPay> GetDetails(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpcashpay.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", Id);
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
        /// Create a ExpCashPay Object into Database
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ExpCashPay> Create(SoQuyChiTienLogicInputDto input, bool ChuyenKhoan = false)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpCashPay item = new ExpCashPay();

                // Mapping Prop
                item.Id = Guid.NewGuid().ToString();
                item.FK_ExtPost = input.FK_ExtPost;
                item.IsPay = input.IsPay;
                item.MaNguoiNopNhan = input.MaNguoiNopNhan;
                item.TenNguoiNopNhan = input.TenNguoiNopNhan;
                item.DiaChi = input.DiaChi;
                item.SoDienThoai = input.SoDienThoai;
                item.Value = -input.Value;
                item.CreateDate = dc.CurrentTime();
                item.CreateBy = input.CreateBy;
                item.SoChungTu = input.SoChungTu;
                item.Type = input.Type;
                item.Note = input.Note;
                item.IsDelete = input.IsDelete;
                item.PrintCopied = 0;

                // Update ExpPost
                ExpPost post = dc.EXppost.GetObject(base.ConnectionData.Schema, item.FK_ExtPost);
                if (ChuyenKhoan == false)
                {
                    post.ValueBlanceMoney = post.ValueBlanceMoney - input.Value;
                    dc.EXppost.Update(base.ConnectionData.Schema, post);
                }
                item.AfterTotalValue = post.ValueBlanceMoney;
                // Update value
                dc.EXpcashpay.InsertOnSubmit(base.ConnectionData.Schema, item);

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
        public async Task<string> CreateChiThongThuong(SoQuyChiTienLogicInputDto input, bool ChuyenKhoan = false)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpCashPay item = new ExpCashPay();

                // Mapping Prop
                item.Id = Guid.NewGuid().ToString();
                item.FK_ExtPost = input.FK_ExtPost;
                item.IsPay = input.IsPay;
                item.MaNguoiNopNhan = input.MaNguoiNopNhan;
                item.TenNguoiNopNhan = input.TenNguoiNopNhan;
                item.DiaChi = input.DiaChi;
                item.SoDienThoai = input.SoDienThoai;
                item.Value = -input.Value;
                item.CreateDate = dc.CurrentTime();
                item.CreateBy = input.CreateBy;
                item.SoChungTu = input.SoChungTu;
                item.Type = input.Type;
                item.Note = input.Note;
                item.IsDelete = input.IsDelete;
                item.PrintCopied = 0;

                // Update ExpPost
                ExpPost post = dc.EXppost.GetObject(base.ConnectionData.Schema, item.FK_ExtPost);
                if (ChuyenKhoan == false)
                {
                    post.ValueBlanceMoney = post.ValueBlanceMoney - input.Value;
                    dc.EXppost.Update(base.ConnectionData.Schema, post);
                }
                item.AfterTotalValue = post.ValueBlanceMoney;
                // Update value
                dc.EXpcashpay.InsertOnSubmit(base.ConnectionData.Schema, item);
                // Update ExpDoiSoat
                if (item.Type == "PAY_COD")
                {
                    ExpDoiSoatChiTietCt chiTietct = dc.EXpdoisoatchitietct.GetObject(base.ConnectionData.Schema, item.SoChungTu);
                    if (chiTietct != null)
                    {
                        ExpDoiSoatChiTiet chiTiet = dc.EXpdoisoatchitiet.GetObject(base.ConnectionData.Schema, chiTietct.FK_DoiSoatChiTiet);
                        if (chiTiet != null)
                        {
                            ExpDoiSoat doiSoat = dc.EXpdoisoat.GetObject(base.ConnectionData.Schema, chiTiet.FK_DoiSoat);
                            if (doiSoat != null)
                            {
                                // Check nếu đã được thanh toán rồi thì không cho phép lưu.
                                if (chiTiet.IsHoanThanh == true)
                                {
                                    return "Mã vận đơn [" + item.SoChungTu + "] đã được thanh toán trong kỳ đối soát ngày " + string.Format("{0:dd/MM/yyyy HH:mm}", doiSoat.NgayDoiSoat);
                                }
                                else
                                {
                                    // Update chi tiết ct
                                    chiTietct.IsHoanThanh = true;
                                    dc.EXpdoisoatchitietct.Update(base.ConnectionData.Schema, chiTietct);
                                    // Update chi tiết
                                    List<ExpDoiSoatChiTietCt> lsCheck = dc.EXpdoisoatchitietct.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_DoiSoatChiTiet=@FK_DoiSoatChiTiet AND (IsHoanThanh IS NULL OR IsHoanThanh=0)", "@FK_DoiSoatChiTiet", chiTiet.Id);
                                    if (lsCheck.Count <= 0)
                                    {
                                        //Đã thanh toán hết
                                        chiTiet.IsHoanThanh = true;
                                    }
                                    chiTiet.DaThanhToanKH = chiTiet.DaThanhToanKH + item.Value;
                                    dc.EXpdoisoatchitiet.Update(base.ConnectionData.Schema, chiTiet);
                                    // Update đối soát
                                    doiSoat.DaThanhToanKH = doiSoat.DaThanhToanKH + item.Value;
                                    dc.EXpdoisoat.Update(base.ConnectionData.Schema, doiSoat);
                                }
                            }
                        }
                    }
                }
                //Change Database
                dc.SubmitChanges();
                return string.Empty;
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
        public async Task<ExpCashPay> CreateCash(SoQuyChiTienLogicInputDto input, bool ChuyenKhoan = false)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpCashPay item = new ExpCashPay();

                // Mapping Prop
                item.Id = Guid.NewGuid().ToString();
                item.FK_ExtPost = input.FK_ExtPost;
                item.IsPay = input.IsPay;
                item.MaNguoiNopNhan = input.MaNguoiNopNhan;
                item.TenNguoiNopNhan = input.TenNguoiNopNhan;
                item.DiaChi = input.DiaChi;
                item.SoDienThoai = input.SoDienThoai;
                item.Value = input.Value;
                item.CreateDate = dc.CurrentTime();
                item.CreateBy = input.CreateBy;
                item.SoChungTu = input.SoChungTu;
                item.Type = input.Type;
                item.Note = input.Note;
                item.IsDelete = input.IsDelete;
                item.PrintCopied = 0;
                // Update ExpPost
                ExpPost post = dc.EXppost.GetObject(base.ConnectionData.Schema, item.FK_ExtPost);
                if (ChuyenKhoan == false)
                {
                    post.ValueBlanceMoney = post.ValueBlanceMoney + input.Value;
                    dc.EXppost.Update(base.ConnectionData.Schema, post);
                }
                item.AfterTotalValue = post.ValueBlanceMoney;
                // Update value
                dc.EXpcashpay.InsertOnSubmit(base.ConnectionData.Schema, item);
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
        
        public ExpBILL GetBillByCode(string mavandon)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpbill.GetObject(base.ConnectionData.Schema, mavandon);
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
        public async Task<string> CheckDuplicate(SoQuyChiTienLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpCashPay item = dc.EXpcashpay.GetObjectCon(base.ConnectionData.Schema, "WHERE SoChungTu LIKE '%" + input.SoChungTu + "%' AND Type=@Type", "@Type", input.Type);
                if (item != null)
                {
                    return item.TenNguoiNopNhan + " - " + item.Value + " Người thực hiện: " + item.MaNguoiNopNhan;
                }
                else
                {
                    return string.Empty;
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
        /// Update ExpCashPay 
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Update(String Id, SoQuyChiTienLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpCashPay item = dc.EXpcashpay.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    // Mapping Prop
                    item.FK_ExtPost = input.FK_ExtPost;
                    item.IsPay = input.IsPay;
                    item.MaNguoiNopNhan = input.MaNguoiNopNhan;
                    item.TenNguoiNopNhan = input.TenNguoiNopNhan;
                    item.DiaChi = input.DiaChi;
                    item.SoDienThoai = input.SoDienThoai;
                    item.Value = input.Value;
                    item.CreateBy = input.CreateBy;
                    item.SoChungTu = input.SoChungTu;
                    item.Type = input.Type;
                    item.Note = input.Note;
                    item.IsDelete = input.IsDelete;
                    //Change Database
                    dc.EXpcashpay.Update(base.ConnectionData.Schema, item);
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
        /// Delete ExpCashPay
        /// </summary>
        public async Task<bool> Delete(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpCashPay item = dc.EXpcashpay.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    //Delete master
                    dc.EXpcashpay.DeleteOnSubmit(base.ConnectionData.Schema, Id);
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
        /// <returns>view_ExpCashPay</returns>
        public async Task<view_ExpCashPay> CreateOrUpdateMasterOnly(String Id, SoQuyChiTienLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                ExpCashPay item = dc.EXpcashpay.GetObject(base.ConnectionData.Schema, Id);
                if (item == null)
                {
                    insert = true;
                    item = new ExpCashPay();
                    item.Id = Guid.NewGuid().ToString();
                    item.CreateDate = DateTime.Now;
                }
                // Update Value
                item.FK_ExtPost = input.FK_ExtPost;
                item.IsPay = input.IsPay;
                item.MaNguoiNopNhan = input.MaNguoiNopNhan;
                item.TenNguoiNopNhan = input.TenNguoiNopNhan;
                item.DiaChi = input.DiaChi;
                item.SoDienThoai = input.SoDienThoai;
                item.Value = input.Value;
                item.CreateBy = input.CreateBy;
                item.SoChungTu = input.SoChungTu;
                item.Type = input.Type;
                item.Note = input.Note;
                item.IsDelete = input.IsDelete;
                item.FK_AccountDelete = input.FK_AccountDelete;
                item.CreateDelete = input.CreateDelete;
                item.Reason = input.Reason;
                item.PrintCopied = input.PrintCopied;
                if (insert)
                {
                    dc.EXpcashpay.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.EXpcashpay.Update(base.ConnectionData.Schema, item);
                }

                // Get lại giá trị của Master
                view_ExpCashPay returnItem = dc.VIewexpcashpay.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", item.Id);
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
        /// Get data refer Master ExpPost
        /// </summary>
        /// <returns>ExpPost</returns>
        public async Task<List<ExpPost>> GetMasterFK_ExtPostList(string accountId)
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

        public async Task<ExpPost> GetExpPostDetail(String expId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXppost.GetObject(base.ConnectionData.Schema, expId);
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
        public async Task<ExpConsignment> GetExpConsignmentDetail(String expId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpconsignment.GetObject(base.ConnectionData.Schema, expId);
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
        public async Task<ExpConsignmentCashPayType> GetDetailCashPayType(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpconsignmentcashpaytype.GetObject(base.ConnectionData.Schema, Id);
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
        public async Task<List<ExpConsignmentCashPayType>> GetMasterCashPayTypeList()
        {

            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpconsignmentcashpaytype.GetListObjectCon(ConnectionData.Schema, "WHERE UsingCashPay=1 AND IsPay=1");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<List<ExpConsignmentCashPayType>> GetMasterCashTypeList()
        {

            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpconsignmentcashpaytype.GetListObjectCon(ConnectionData.Schema, "WHERE UsingCashPay=1 AND IsPay=0");
            }
            catch (Exception)
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

