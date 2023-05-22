using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class QuanLyDaiLyLogic : BaseLogic
    {
        public QuanLyDaiLyLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        /// <summary>
        /// Get all view_ExpPost List
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_ExpPost>> GetList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexppost.GetListObject(base.ConnectionData.Schema);
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
        /// Tìm view_ExpPost theo keyword
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_ExpPost>> GetList(string keyword, AccountObject user)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (user.AccountType <= 1)
                {
                    condition += "WHERE Id IN (SELECT FK_ExpPost FROM ExpPostAccount WHERE FK_AccountId='" + user.Id + "') OR ParrentPost='" + user.CardId + "' &";
                }
                else
                {
                    condition = "WHERE Id IN (SELECT FK_ExpPost FROM ExpPostAccount WHERE FK_AccountId='" + user.Id + "') &";
                }
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " (TenDaiLy like N'%" + keyword + "%' OR Phone like N'%" + keyword + "%' OR Code like N'%" + keyword + "%')";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                condition = condition + " ORDER BY Id asc";
                return dc.VIewexppost.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        /// Danh sách view_ExpPost theo giới hạn keyword và page
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="page">Số trang hiển thị</param>
        /// <returns></returns>
        public async Task<List<view_ExpPost>> GetPage(string keyword, int? page)
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
        /// Danh sách view_ExpPost theo giới hạn keyword, Take, Skip
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<List<view_ExpPost>> GetPage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE TenDaiLy like N'%" + keyword + "%' | Phone like N'%" + keyword + "%' | Code like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY Id asc";
                return dc.VIewexppost.GetListObjectLimitCon(base.ConnectionData.Schema, "*", condition, Take, Skip);
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
        /// Tuple Danh sách view_ExpPost theo giới hạn keyword, Take, Skip và số dòng dữ liệu
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<Tuple<List<view_ExpPost>, int>> GetTuplePage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                var list = dc.VIewexppost.GetListObject(base.ConnectionData.Schema);
                var data = await GetPage(keyword, Take, Skip);
                return new Tuple<List<view_ExpPost>, int>(data, list.Count);
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
        /// Get List of SameQuanLyDaiLyLogic
        /// </summary>
        /// <param name="Id">Id Of ExpPost</param>
        /// <returns></returns>
        public async Task<List<view_ExpPost>> GetSameList(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int take = 10;
                return dc.VIewexppost.GetListObjectLimitCon(base.ConnectionData.Schema, "*", "WHERE Id<>@Id  ", take, 0, "@Id", Id);
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
        /// Get view_ExpPost Object
        /// </summary>
        /// <param name="Id">Id Of ExpPost</param>
        /// <returns></returns>
        public async Task<view_ExpPost> GetDetails(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexppost.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", Id);
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
        /// Create a ExpPost Object into Database
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ExpPost> Create(QuanLyDaiLyLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpPost item = new ExpPost();
                var codeItem = PostGetCode();
                // Mapping Prop
                item.Id = codeItem.Item1;
                item.Code = codeItem.Item1;
                item.TenDaiLy = input.TenDaiLy;
                item.Phone = input.Phone;
                item.DiaChi = input.DiaChi;
                item.Email = input.Email;
                item.QuanLy = input.QuanLy;
                item.SoDienThoai = input.SoDienThoai;
                item.MaBuuCuc = input.MaBuuCuc;
                item.IDLogin = input.IDLogin;
                item.Pass = input.Pass;
                item.DieuPhoi = input.DieuPhoi;
                switch (item.MaBuuCuc)
                {
                    case "S":
                        item.NamSinh = 0;
                        break;
                    case "M":
                        item.NamSinh = 1;
                        break;
                    default:
                        item.NamSinh = 2;
                        break;
                }
                item.CMND = input.CMND;
                item.NgayCap = input.NgayCap;
                item.SDTCaNhan = input.SDTCaNhan;
                item.SoTaiKhoan = input.SoTaiKhoan;
                item.NganHang = input.NganHang;
                item.ThuongTru = input.ThuongTru;
                item.FK_DVHC = input.FK_DVHC;
                item.CreateBy = input.CreateBy;
                item.CreateDate = DateTime.Now;
                item.GoogleMap = input.GoogleMap;
                item.ParrentPost = input.ParrentPost;
                item.DeliveryFee = input.DeliveryFee;
                item.SytemFee = input.SytemFee;
                item.CodeFee = input.CodeFee;
                item.CODFee = input.CODFee;
                item.InternalDeliveryFee = input.InternalDeliveryFee;
                item.ShipperFee = input.ShipperFee;
                GExpProvince province = dc.GExpprovince.GetObject(base.ConnectionData.Schema, item.FK_DVHC);
                if (province != null)
                {
                    item.ZoneCode = province.ZoneCode;
                }
                // Thêm cái GSEXpCode
                GExpCode code = new GExpCode();
                code.Id = codeItem.Item1;
                code.CurrentValue = 0;
                code.Post = codeItem.Item2.ToString();
                dc.GExpcode.InsertOnSubmit(base.ConnectionData.Schema, code);

                code = new GExpCode();
                code.Id = codeItem.Item1 + "CUS";
                code.CurrentValue = 0;
                code.Post = codeItem.Item2.ToString();
                dc.GExpcode.InsertOnSubmit(base.ConnectionData.Schema, code);
                // Account Post
                ExpPostAccount postAccount = new ExpPostAccount();
                postAccount.FK_ExpPost = codeItem.Item1;
                postAccount.FK_AccountId = "admin";
                postAccount.Position = 0;
                postAccount.CreateDate = DateTime.Now;
                dc.EXppostaccount.InsertOnSubmit(base.ConnectionData.Schema, postAccount);

                //Change Database
                dc.EXppost.InsertOnSubmit(base.ConnectionData.Schema, item);
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
        public Tuple<string, int> PostGetCode()
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpCode queueNumber = dc.GExpcode.GetObjectCon(ConnectionData.Schema, "WHERE Id=@Id",
                    "@Id", "POST");
                if (queueNumber == null)
                {
                    queueNumber = new GExpCode();
                    queueNumber.Id = "POST";
                    queueNumber.CurrentValue = 1;
                    queueNumber.Post = "VN9";
                    dc.GExpcode.InsertOnSubmit(ConnectionData.Schema, queueNumber);
                }
                else
                {
                    queueNumber.CurrentValue = queueNumber.CurrentValue + 1;
                    dc.GExpcode.Update(ConnectionData.Schema, queueNumber);
                }
                dc.SubmitChanges();
                Tuple<string, int> result = Tuple.Create(queueNumber.Post + queueNumber.CurrentValue.ToString().PadLeft(4, '0'), queueNumber.CurrentValue);
                return result;
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
        /// <summary>
        /// Update ExpPost 
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Update(String Id, QuanLyDaiLyLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpPost item = dc.EXppost.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    // Mapping Prop
                    item.TenDaiLy = input.TenDaiLy;
                    item.Phone = input.Phone;
                    item.DiaChi = input.DiaChi;
                    item.Email = input.Email;
                    item.QuanLy = input.QuanLy;
                    item.SoDienThoai = input.SoDienThoai;
                    item.MaBuuCuc = input.MaBuuCuc;
                    item.IDLogin = input.IDLogin;
                    item.Pass = input.Pass;
                    item.DieuPhoi = input.DieuPhoi;
                    switch (item.MaBuuCuc)
                    {
                        case "S":
                            item.NamSinh = 0;
                            break;
                        case "M":
                            item.NamSinh = 1;
                            break;
                        default:
                            item.NamSinh = 2;
                            break;
                    }

                    item.CMND = input.CMND;
                    item.NgayCap = input.NgayCap;
                    item.SDTCaNhan = input.SDTCaNhan;
                    item.SoTaiKhoan = input.SoTaiKhoan;
                    item.NganHang = input.NganHang;
                    item.ThuongTru = input.ThuongTru;
                    item.FK_DVHC = input.FK_DVHC;
                    item.CreateBy = input.CreateBy;
                    item.CreateDate = DateTime.Now;
                    item.GoogleMap = input.GoogleMap;
                    if (!string.IsNullOrEmpty(input.ParrentPost))
                    {
                        item.ParrentPost = input.ParrentPost;
                    }
                    item.DeliveryFee = input.DeliveryFee;
                    item.SytemFee = input.SytemFee;
                    item.CodeFee = input.CodeFee;
                    item.CODFee = input.CODFee;
                    item.InternalDeliveryFee = input.InternalDeliveryFee;
                    item.ShipperFee = input.ShipperFee;
                    GExpProvince province = dc.GExpprovince.GetObject(base.ConnectionData.Schema, item.FK_DVHC);
                    if (province != null)
                    {
                        item.ZoneCode = province.ZoneCode;
                    }
                    //Change Database
                    dc.EXppost.Update(base.ConnectionData.Schema, item);
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
        /// Delete ExpPost
        /// </summary>
        public async Task<bool> Delete(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpPost item = dc.EXppost.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    //Delete master
                    dc.EXppost.DeleteOnSubmit(base.ConnectionData.Schema, Id);
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
        /// <returns>view_ExpPost</returns>
        public async Task<view_ExpPost> CreateOrUpdateMasterOnly(String Id, QuanLyDaiLyLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                ExpPost item = dc.EXppost.GetObject(base.ConnectionData.Schema, Id);
                if (item == null)
                {
                    insert = true;
                    item = new ExpPost();
                    item.CreateDate = DateTime.Now;
                }
                // Update Value
                item.Id = input.Id;
                item.Code = input.Code;
                item.TenDaiLy = input.TenDaiLy;
                item.Phone = input.Phone;
                item.DiaChi = input.DiaChi;
                item.Email = input.Email;
                item.QuanLy = input.QuanLy;
                item.SoDienThoai = input.SoDienThoai;
                item.MaBuuCuc = input.MaBuuCuc;
                item.IDLogin = input.IDLogin;
                item.Pass = input.Pass;
                item.DieuPhoi = input.DieuPhoi;
                item.NamSinh = input.NamSinh;
                item.CMND = input.CMND;
                item.NgayCap = input.NgayCap;
                item.SDTCaNhan = input.SDTCaNhan;
                item.SoTaiKhoan = input.SoTaiKhoan;
                item.NganHang = input.NganHang;
                item.ThuongTru = input.ThuongTru;
                item.FK_DVHC = input.FK_DVHC;
                item.CreateBy = input.CreateBy;
                item.GoogleMap = input.GoogleMap;
                item.ParrentPost = input.ParrentPost;
                item.DeliveryFee = input.DeliveryFee;
                item.SytemFee = input.SytemFee;
                item.CodeFee = input.CodeFee;
                item.CODFee = input.CODFee;
                item.InternalDeliveryFee = input.InternalDeliveryFee;
                item.ShipperFee = input.ShipperFee;
                item.ZoneCode = input.ZoneCode;
                if (insert)
                {
                    dc.EXppost.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.EXppost.Update(base.ConnectionData.Schema, item);
                }

                // Get lại giá trị của Master
                view_ExpPost returnItem = dc.VIewexppost.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", item.Id);
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
        /// Get data refer Master GExpProvince
        /// </summary>
        /// <returns>GExpProvince</returns>
        public async Task<List<GExpProvince>> GetMasterFK_DVHCList()
        {
            List<GExpProvince> ls = new List<GExpProvince>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.GExpprovince.GetListObject(ConnectionData.Schema);
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
        public async Task<List<ExpPost>> GetMasterParrentPostList(AccountObject user)
        {
            List<ExpPost> ls = new List<ExpPost>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = string.Empty;
                if (user.AccountType <= 1)
                {
                    condition += "WHERE Id IN (SELECT FK_ExpPost FROM ExpPostAccount WHERE FK_AccountId='" + user.Id + "') OR ParrentPost='" + user.CardId + "'";
                }
                else
                {
                    condition = "WHERE Id IN (SELECT FK_ExpPost FROM ExpPostAccount WHERE FK_AccountId='" + user.Id + "')";
                }
                ls = dc.EXppost.GetListObjectCon(ConnectionData.Schema, condition);
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

