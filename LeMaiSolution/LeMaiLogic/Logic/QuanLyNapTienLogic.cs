using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class QuanLyNapTienLogic : BaseLogic
    {
        public QuanLyNapTienLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        public string NapTien(view_GExpRequestMoney yeuCauNapTien, AccountObject user, int soTien)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();
                ExpPost postFrom = dc.EXppost.GetObject(ConnectionData.Schema, yeuCauNapTien.DaiLyYeuCau);
                ExpPost postTo = dc.EXppost.GetObject(ConnectionData.Schema, yeuCauNapTien.DaiLyXuLy);

                if (postFrom.ParrentPost == "0000" && postTo.ParrentPost == "0000")
                {
                    // Nếu là cấp 1
                    GExpBalanceDetail syscash = new GExpBalanceDetail();
                    syscash.Id = Guid.NewGuid().ToString();
                    syscash.FK_ExtPostFrom = postFrom.Id;
                    syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                    syscash.AfterPostFrom = postFrom.ValueBlance + soTien;
                    syscash.FK_ExtPostTo = postTo.Id;
                    syscash.CurrentExtPostTo = postTo.ValueBlance;
                    syscash.AfterPostTo = postTo.ValueBlance - soTien;
                    syscash.Value = soTien;
                    syscash.CreateDate = currentDate;
                    syscash.CreateBy = user.Id;
                    syscash.BillCode = yeuCauNapTien.RequestCode;
                    syscash.Type = "CASH_MONEY";
                    syscash.Note = yeuCauNapTien.Note;
                    syscash.IsDelete = false;
                    dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                    // Cập nhật số tiền hiện tại
                    postTo.ValueBlance -= syscash.Value;
                    postFrom.ValueBlance += syscash.Value;
                    dc.EXppost.Update(ConnectionData.Schema, postTo);
                    dc.EXppost.Update(ConnectionData.Schema, postFrom);
                    // Update công nợ 2 chiều

                    GExpBalanceDetailPost CongNoCheck = dc.GExpbalancedetailpost.GetObjectCon(base.ConnectionData.Schema,
                        "WHERE (FK_ExtPostFrom='" + postFrom.Id + "' AND FK_ExtPostTo='" + postTo.Id + "') OR (FK_ExtPostFrom='" + postTo.Id + "' AND FK_ExtPostTo='" + postFrom.Id + "') ORDER BY EpochTime DESC");
                    if (CongNoCheck == null)
                    {
                        CongNoCheck = new GExpBalanceDetailPost();
                        CongNoCheck.FK_ExtPostFrom = postFrom.Id;
                        CongNoCheck.AfterPostFrom = 0;
                        CongNoCheck.FK_ExtPostTo = postTo.Id;
                        CongNoCheck.AfterPostTo = 0;
                    }
                    GExpBalanceDetailPost CongNo = new GExpBalanceDetailPost();
                    CongNo.Id = Guid.NewGuid().ToString();
                    CongNo.CreateDate = currentDate;
                    CongNo.BillCode = yeuCauNapTien.RequestCode;
                    CongNo.CreateBy = user.Id;
                    CongNo.EpochTime = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
                    CongNo.FK_ExtPostFrom = postTo.Id;
                    CongNo.FK_ExtPostTo = postFrom.Id;
                    // Check Current Value From
                    if (CongNoCheck.FK_ExtPostFrom == CongNo.FK_ExtPostFrom)
                    {
                        CongNo.CurrentExtPostFrom = CongNoCheck.AfterPostFrom;
                    }
                    else
                    {
                        CongNo.CurrentExtPostFrom = CongNoCheck.AfterPostTo;
                    }
                    // Check Current Value To
                    if (CongNoCheck.FK_ExtPostFrom == CongNo.FK_ExtPostTo)
                    {
                        CongNo.CurrentExtPostTo = CongNoCheck.AfterPostFrom;
                    }
                    else
                    {
                        CongNo.CurrentExtPostTo = CongNoCheck.AfterPostTo;
                    }
                    CongNo.Value = soTien;
                    CongNo.AfterPostFrom = CongNo.CurrentExtPostFrom - CongNo.Value;
                    CongNo.AfterPostTo = CongNo.CurrentExtPostTo + CongNo.Value;
                    CongNo.Type = "CASH_MONEY";
                    CongNo.Note = postTo.TenDaiLy + " TRẢ " + postFrom.TenDaiLy;
                    dc.GExpbalancedetailpost.InsertOnSubmit(base.ConnectionData.Schema, CongNo);

                }
                else if (postFrom.ParrentPost != "0000" && postTo.ParrentPost == "0000")
                {
                    // Nếu là cấp 2
                    GExpBalanceDetail syscash = new GExpBalanceDetail();
                    syscash.Id = Guid.NewGuid().ToString();
                    syscash.FK_ExtPostFrom = postFrom.Id;
                    syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                    syscash.AfterPostFrom = postFrom.ValueBlance + soTien;
                    syscash.FK_ExtPostTo = postTo.Id;
                    syscash.CurrentExtPostTo = postTo.ValueBlance;
                    syscash.AfterPostTo = postTo.ValueBlance;
                    syscash.Value = soTien;
                    syscash.CreateDate = dc.CurrentTime();
                    syscash.CreateBy = user.Id;
                    syscash.BillCode = yeuCauNapTien.RequestCode;
                    syscash.Type = "CASH_MONEY";
                    syscash.Note = yeuCauNapTien.Note;
                    syscash.IsDelete = false;
                    dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                    // Cập nhật số tiền hiện tại
                    postFrom.ValueBlance += syscash.Value;
                    dc.EXppost.Update(ConnectionData.Schema, postFrom);
                }
                GExpRequestMoney naptien = dc.GExprequestmoney.GetObject(base.ConnectionData.Schema, yeuCauNapTien.Id);
                if (naptien != null)
                {
                    naptien.IsConfirm = true;
                    naptien.ReSoTien = soTien;
                    dc.GExprequestmoney.Update(base.ConnectionData.Schema, naptien);
                }
                dc.SubmitChanges();
                return string.Empty;
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
        public List<PostDebit> GetDebit(string post)
        {
            List<PostDebit> list = new List<PostDebit>();
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string sqlPostRefer = @"SELECT * FROM 
                                            (SELECT DISTINCT  FK_ExtPostFrom AS POST
                                            FROM GExpBalanceDetailPost WHERE FK_ExtPostFrom ='" + post + @"' OR FK_ExtPostTo ='" + post + @"'
                                            UNION
                                            SELECT DISTINCT  FK_ExtPostTo AS POST
                                            FROM GExpBalanceDetailPost WHERE FK_ExtPostFrom ='" + post + @"' OR FK_ExtPostTo ='" + post + @"') AS T
                                         WHERE T.POST<>'" + post + @"'";
                DataTable data = dc.GetData(sqlPostRefer);
                foreach (DataRow item in data.Rows)
                {
                    // Check giá trị
                    string postCheck = item["POST"].ToString();
                    view_GExpBalanceDetailPost CongNoCheck = dc.VIewgexpbalancedetailpost.GetObjectCon(base.ConnectionData.Schema, "WHERE (FK_ExtPostFrom='" + post + "' AND FK_ExtPostTo='" + postCheck + "') OR (FK_ExtPostFrom='" + postCheck + "' AND FK_ExtPostTo='" + post + "') ORDER BY EpochTime DESC");
                    if (CongNoCheck != null)
                    {
                        PostDebit debit = new PostDebit();
                        int SoTien = 0;
                        debit.LastDate = CongNoCheck.CreateDate;

                        if (CongNoCheck.FK_ExtPostFrom == post)
                        {
                            SoTien = CongNoCheck.AfterPostFrom;
                            debit.PostReferName = CongNoCheck.TTenDaiLy;
                            debit.PostReferCode = CongNoCheck.FK_ExtPostTo;
                            debit.QuanLy = CongNoCheck.TQuanLy;
                            debit.SoDienThoai = CongNoCheck.TSoDienThoai;
                        }
                        else
                        {
                            SoTien = CongNoCheck.AfterPostTo;
                            debit.PostReferName = CongNoCheck.FTenDaiLy;
                            debit.PostReferCode = CongNoCheck.FK_ExtPostFrom;
                            debit.QuanLy = CongNoCheck.FQuanLy;
                            debit.SoDienThoai = CongNoCheck.FSoDienThoai;
                        }
                        debit.Balance = SoTien;
                        if (debit.Balance > 0)
                        {
                            // Không cần nạp tiền
                            debit.IsNapTien = false;
                        }
                        else
                        {
                            debit.IsNapTien = true;
                        }
                        list.Add(debit);
                    }
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
            return list;
        }
        public string AddRequestMoney(string post, string postTo, string userId, int SoTien, string note, string bankAccount, string bankOwner, string bankName)
        {
            string requestCode = GetRequestCode();
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpRequestMoney naptien = dc.GExprequestmoney.GetObjectCon(base.ConnectionData.Schema,
                    "WHERE FK_Post=@FK_Post AND FK_PostResponse=@FK_PostResponse AND IsConfirm=0",
                    "@FK_Post", post,
                    "@FK_PostResponse", postTo);
                if (naptien == null)
                {
                    naptien = new GExpRequestMoney();
                    naptien.Id = Guid.NewGuid().ToString();
                    naptien.FK_Post = post;
                    naptien.FK_PostResponse = postTo;
                    naptien.FK_RequestAccount = userId;
                    naptien.CreateDate = dc.CurrentTime();
                    naptien.SoTien = SoTien;
                    naptien.RequestCode = requestCode;
                    naptien.Note = string.Format(note, naptien.RequestCode, naptien.SoTien.ToString("N0"));
                    naptien.IsConfirm = false;
                    naptien.BankAccount = bankAccount;
                    naptien.BankOwner = bankOwner;
                    naptien.BankName = bankName;
                    dc.GExprequestmoney.InsertOnSubmit(base.ConnectionData.Schema, naptien);
                    dc.SubmitChanges();
                    return requestCode;
                }
                else
                {
                    return "[E] Đã tồn tại lệnh nạp tiền chưa được phê duyệt.";
                }

            }
            catch (Exception ex)
            {
                return "[E] " + ex.ToString();
            }
            finally
            {
                dc.Close();
            }

        }
        public string GetRequestCode()
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpCode queueNumber = dc.GExpcode.GetObjectCon(ConnectionData.Schema, "WHERE Id=@Id",
                    "@Id", "REQUEST");
                if (queueNumber != null)
                {
                    queueNumber.CurrentValue = queueNumber.CurrentValue + 1;
                    dc.GExpcode.Update(ConnectionData.Schema, queueNumber);
                }
                dc.SubmitChanges();
                return queueNumber.Post + queueNumber.CurrentValue.ToString().PadLeft(7, '0');
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
        /// Get all view_GExpRequestMoney List
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_GExpRequestMoney>> GetList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexprequestmoney.GetListObject(base.ConnectionData.Schema);
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
        /// Tìm view_GExpRequestMoney theo keyword
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_GExpRequestMoney>> GetList(string keyword, DateTime from, DateTime to, int loai, string postResponse)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = "WHERE FK_PostResponse='" + postResponse + "' AND CreateDate >='" + string.Format("{0:yyyy-MM-dd}", from) + " 00:00:00' AND CreateDate<='" + string.Format("{0:yyyy-MM-dd}", to) + " 23:59:59' &";
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " RequestCode='" + keyword + "' &";
                }
                if (loai == 1)
                {
                    // chưa phê dyệt
                    condition += " IsConfirm=0 &";
                }
                else if (loai == 2)
                {
                    //Đã phê duyệt
                    condition += " IsConfirm=1 &";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                condition = condition + " ORDER BY CreateDate asc";
                return dc.VIewgexprequestmoney.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        /// Danh sách view_GExpRequestMoney theo giới hạn keyword và page
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="page">Số trang hiển thị</param>
        /// <returns></returns>
        public async Task<List<view_GExpRequestMoney>> GetPage(string keyword, int? page)
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
        /// Danh sách view_GExpRequestMoney theo giới hạn keyword, Take, Skip
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<List<view_GExpRequestMoney>> GetPage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE DaiLyYeuCau like N'%" + keyword + "%' | RequestCode like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY CreateDate asc";
                return dc.VIewgexprequestmoney.GetListObjectLimitCon(base.ConnectionData.Schema, "*", condition, Take, Skip);
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
        /// Tuple Danh sách view_GExpRequestMoney theo giới hạn keyword, Take, Skip và số dòng dữ liệu
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<Tuple<List<view_GExpRequestMoney>, int>> GetTuplePage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                var list = dc.VIewgexprequestmoney.GetListObject(base.ConnectionData.Schema);
                var data = await GetPage(keyword, Take, Skip);
                return new Tuple<List<view_GExpRequestMoney>, int>(data, list.Count);
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
        /// Get List of SameQuanLyNapTienLogic
        /// </summary>
        /// <param name="Id">Id Of GExpRequestMoney</param>
        /// <returns></returns>
        public async Task<List<view_GExpRequestMoney>> GetSameList(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int take = 10;
                return dc.VIewgexprequestmoney.GetListObjectLimitCon(base.ConnectionData.Schema, "*", "WHERE Id<>@Id  ", take, 0, "@Id", Id);
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
        /// Get view_GExpRequestMoney Object
        /// </summary>
        /// <param name="Id">Id Of GExpRequestMoney</param>
        /// <returns></returns>
        public async Task<view_GExpRequestMoney> GetDetails(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexprequestmoney.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", Id);
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
        /// Create a GExpRequestMoney Object into Database
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<GExpRequestMoney> Create(QuanLyNapTienLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpRequestMoney item = new GExpRequestMoney();

                // Mapping Prop
                item.Id = input.Id;
                item.FK_Post = input.FK_Post;
                item.FK_RequestAccount = input.FK_RequestAccount;
                item.FK_PostResponse = input.FK_PostResponse;
                item.CreateDate = input.CreateDate;
                item.SoTien = input.SoTien;
                item.RequestCode = input.RequestCode;
                item.Note = input.Note;
                item.IsConfirm = input.IsConfirm;
                item.BankAccount = input.BankAccount;
                item.BankOwner = input.BankOwner;
                item.BankName = input.BankName;
                item.ConfirmDate = input.ConfirmDate;
                item.ReSoTien = input.ReSoTien;
                item.FK_Account = input.FK_Account;

                //Change Database
                dc.GExprequestmoney.InsertOnSubmit(base.ConnectionData.Schema, item);
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
        /// Update GExpRequestMoney 
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Update(String Id, QuanLyNapTienLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpRequestMoney item = dc.GExprequestmoney.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    // Mapping Prop
                    item.Id = input.Id;
                    item.FK_Post = input.FK_Post;
                    item.FK_RequestAccount = input.FK_RequestAccount;
                    item.FK_PostResponse = input.FK_PostResponse;
                    item.CreateDate = input.CreateDate;
                    item.SoTien = input.SoTien;
                    item.RequestCode = input.RequestCode;
                    item.Note = input.Note;
                    item.IsConfirm = input.IsConfirm;
                    item.BankAccount = input.BankAccount;
                    item.BankOwner = input.BankOwner;
                    item.BankName = input.BankName;
                    item.ConfirmDate = input.ConfirmDate;
                    item.ReSoTien = input.ReSoTien;
                    item.FK_Account = input.FK_Account;

                    //Change Database
                    dc.GExprequestmoney.Update(base.ConnectionData.Schema, item);
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
        /// Delete GExpRequestMoney
        /// </summary>
        public async Task<bool> Delete(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpRequestMoney item = dc.GExprequestmoney.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    //Delete master
                    dc.GExprequestmoney.DeleteOnSubmit(base.ConnectionData.Schema, Id);
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
        /// <returns>view_GExpRequestMoney</returns>
        public async Task<view_GExpRequestMoney> CreateOrUpdateMasterOnly(String Id, QuanLyNapTienLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                GExpRequestMoney item = dc.GExprequestmoney.GetObject(base.ConnectionData.Schema, Id);
                if (item == null)
                {
                    insert = true;
                    item = new GExpRequestMoney();
                }
                // Update Value
                item.Id = input.Id;
                item.FK_Post = input.FK_Post;
                item.FK_RequestAccount = input.FK_RequestAccount;
                item.FK_PostResponse = input.FK_PostResponse;
                item.CreateDate = input.CreateDate;
                item.SoTien = input.SoTien;
                item.RequestCode = input.RequestCode;
                item.Note = input.Note;
                item.IsConfirm = input.IsConfirm;
                item.BankAccount = input.BankAccount;
                item.BankOwner = input.BankOwner;
                item.BankName = input.BankName;
                item.ConfirmDate = input.ConfirmDate;
                item.ReSoTien = input.ReSoTien;
                item.FK_Account = input.FK_Account;
                if (insert)
                {
                    dc.GExprequestmoney.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.GExprequestmoney.Update(base.ConnectionData.Schema, item);
                }

                // Get lại giá trị của Master
                view_GExpRequestMoney returnItem = dc.VIewgexprequestmoney.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", item.Id);
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

