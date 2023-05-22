using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class QuanLyTaiKhoanLogic : BaseLogic
    {
        public QuanLyTaiKhoanLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        /// <summary>
        /// Get all view_AccountObject List
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_AccountObject>> GetList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewaccountobject.GetListObject(base.ConnectionData.Schema);
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
        /// Tìm view_AccountObject theo keyword
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_AccountObject>> GetList(string keyword, AccountObject user)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (user.AccountType <= 1)
                {
                    condition += "WHERE CardId IN (SELECT FK_ExpPost FROM ExpPostAccount WHERE FK_AccountId='" + user.Id + "') OR IdAccountIntro='" + user.CardId + "'";
                }
                else
                {
                    condition = "WHERE CardId IN (SELECT FK_ExpPost FROM ExpPostAccount WHERE FK_AccountId='" + user.Id + "')";
                }


                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += "FullName like N'%" + keyword + "%' | Code like N'%" + keyword + "%' | Phone like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                condition = condition + " ORDER BY Id asc";
                return dc.VIewaccountobject.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        /// Danh sách view_AccountObject theo giới hạn keyword và page
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="page">Số trang hiển thị</param>
        /// <returns></returns>
        public async Task<List<view_AccountObject>> GetPage(string keyword, int? page)
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
        /// Danh sách view_AccountObject theo giới hạn keyword, Take, Skip
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<List<view_AccountObject>> GetPage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE FullName like N'%" + keyword + "%' | Code like N'%" + keyword + "%' | Phone like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY FullName asc";
                return dc.VIewaccountobject.GetListObjectLimitCon(base.ConnectionData.Schema, "*", condition, Take, Skip);
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
        /// Tuple Danh sách view_AccountObject theo giới hạn keyword, Take, Skip và số dòng dữ liệu
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<Tuple<List<view_AccountObject>, int>> GetTuplePage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                var list = dc.VIewaccountobject.GetListObject(base.ConnectionData.Schema);
                var data = await GetPage(keyword, Take, Skip);
                return new Tuple<List<view_AccountObject>, int>(data, list.Count);
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
        /// Get List of SameQuanLyTaiKhoanLogic
        /// </summary>
        /// <param name="Id">Id Of AccountObject</param>
        /// <returns></returns>
        public async Task<List<view_AccountObject>> GetSameList(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int take = 10;
                return dc.VIewaccountobject.GetListObjectLimitCon(base.ConnectionData.Schema, "*", "WHERE Id<>@Id  ", take, 0, "@Id", Id);
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
        /// Get view_AccountObject Object
        /// </summary>
        /// <param name="Id">Id Of AccountObject</param>
        /// <returns></returns>
        public async Task<view_AccountObject> GetDetails(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewaccountobject.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", Id);
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
        public string AccountGetCode()
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpCode queueNumber = dc.GExpcode.GetObjectCon(ConnectionData.Schema, "WHERE Id=@Id",
                    "@Id", "ACCOUNT");
                if (queueNumber == null)
                {
                    queueNumber = new GExpCode();
                    queueNumber.Id = "ACCOUNT";
                    queueNumber.CurrentValue = 1;
                    queueNumber.Post = "NV";
                    dc.GExpcode.InsertOnSubmit(ConnectionData.Schema, queueNumber);
                }
                else
                {
                    queueNumber.CurrentValue = queueNumber.CurrentValue + 1;
                    dc.GExpcode.Update(ConnectionData.Schema, queueNumber);
                }
                dc.SubmitChanges();
                return queueNumber.Post + queueNumber.CurrentValue.ToString().PadLeft(4, '0');
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
        /// Create a AccountObject Object into Database
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<AccountObject> Create(QuanLyTaiKhoanLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                AccountObject item = new AccountObject();
                item.Id = AccountGetCode();
                item.Code = item.Id;
                item.FullName = input.FullName;
                item.UserName = input.UserName;
                item.PassWord = input.PassWord;
                item.Phone = input.Phone;
                item.Email = input.Email;
                item.AtCreatedDate = DateTime.Now;
                item.AtCreatedBy = input.AtCreatedBy;
                item.AtLastModifiedDate = DateTime.Now;
                item.AtLastModifiedBy = input.AtLastModifiedBy;
                item.AtRowStatus = input.AtRowStatus;
                item.AccountType = input.AccountType;
                item.CardId = input.CardId;
                item.Address = input.Address;
                ExpPost post = dc.EXppost.GetObject(base.ConnectionData.Schema, item.CardId);
                if (post.ParrentPost == "0000")
                {
                    item.IdAccountIntro = input.FK_BranchOwner;
                }
                else
                {
                    item.IdAccountIntro = post.ParrentPost;
                }

                item.FK_BranchOwner = input.FK_BranchOwner;
                item.Note = input.Note;
                item.cap = input.cap;
                item.companyid = input.companyid;
                item.FK_Leader = input.FK_Leader;
                // Add account 
                if (item.AccountType <= 1)
                {
                    ExpPostAccount postAccount = new ExpPostAccount();
                    postAccount.FK_ExpPost = item.CardId;
                    postAccount.FK_AccountId = item.Id;
                    postAccount.Position = 0;
                    postAccount.CreateDate = DateTime.Now;
                    dc.EXppostaccount.InsertOnSubmit(base.ConnectionData.Schema, postAccount);
                }
                dc.ACcountobject.InsertOnSubmit(base.ConnectionData.Schema, item);
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
        /// Update AccountObject 
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Update(String Id, QuanLyTaiKhoanLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                AccountObject item = dc.ACcountobject.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    item.FullName = input.FullName;
                    item.UserName = input.UserName;
                    item.Phone = input.Phone;
                    item.Email = input.Email;
                    item.AtCreatedDate = DateTime.Now;
                    item.AtCreatedBy = input.AtCreatedBy;
                    item.AtLastModifiedDate = DateTime.Now;
                    item.AtLastModifiedBy = input.AtLastModifiedBy;
                    item.AtRowStatus = input.AtRowStatus;
                    item.AccountType = input.AccountType;
                    item.CardId = input.CardId;
                    item.Address = input.Address;
                    ExpPost post = dc.EXppost.GetObject(base.ConnectionData.Schema, item.CardId);
                    if (post.ParrentPost == "0000")
                    {
                        item.IdAccountIntro = input.FK_BranchOwner;
                    }
                    else
                    {
                        item.IdAccountIntro = post.ParrentPost;
                    }
                    item.FK_BranchOwner = input.FK_BranchOwner;
                    item.Note = input.Note;
                    item.cap = input.cap;
                    item.companyid = input.companyid;
                    item.FK_Leader = input.FK_Leader;
                    if (item.AccountType <= 1)
                    {
                        ExpPostAccount postAccount = dc.EXppostaccount.GetObjectCon(base.ConnectionData.Schema, "WHERE FK_AccountId=@FK_AccountId AND FK_ExpPost=@FK_ExpPost",
                            "@FK_AccountId", item.Id,
                            "@FK_ExpPost", item.CardId);
                        if (postAccount == null)
                        {
                            postAccount = new ExpPostAccount();
                            postAccount.FK_ExpPost = item.CardId;
                            postAccount.FK_AccountId = item.Id;
                            postAccount.Position = 0;
                            postAccount.CreateDate = DateTime.Now;
                            dc.EXppostaccount.InsertOnSubmit(base.ConnectionData.Schema, postAccount);
                        }

                    }
                    else
                    {
                        dc.EXppostaccount.DeleteOnSubmitCon(base.ConnectionData.Schema, "WHERE FK_AccountId=@FK_AccountId", item.Id);
                    }

                    dc.ACcountobject.Update(base.ConnectionData.Schema, item);
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
        public async Task<bool> ResetPassword(String Id, string md5Pass)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                AccountObject item = dc.ACcountobject.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    item.PassWord = md5Pass;
                    dc.ACcountobject.Update(base.ConnectionData.Schema, item);
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
        /// Delete AccountObject
        /// </summary>
        public async Task<bool> Delete(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                AccountObject item = dc.ACcountobject.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    //Delete master
                    dc.ACcountobject.DeleteOnSubmit(base.ConnectionData.Schema, Id);
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
        /// <returns>view_AccountObject</returns>
        public async Task<view_AccountObject> CreateOrUpdateMasterOnly(String Id, QuanLyTaiKhoanLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                AccountObject item = dc.ACcountobject.GetObject(base.ConnectionData.Schema, Id);
                if (item == null)
                {
                    insert = true;
                    item = new AccountObject();
                    item.Id = Guid.NewGuid().ToString();
                    item.AtCreatedDate = DateTime.Now;
                    item.AtLastModifiedDate = DateTime.Now;
                }
                // Update Value
                item.FullName = input.FullName;
                item.UserName = input.UserName;
                item.PassWord = input.PassWord;
                item.Phone = input.Phone;
                item.Email = input.Email;
                item.AtCreatedBy = input.AtCreatedBy;
                item.AtLastModifiedBy = input.AtLastModifiedBy;
                item.AtRowStatus = input.AtRowStatus;
                item.AccountType = input.AccountType;
                item.CardId = input.CardId;
                item.Address = input.Address;
                item.IdAccountIntro = input.IdAccountIntro;
                item.FK_BranchOwner = input.FK_BranchOwner;
                item.Note = input.Note;
                item.cap = input.cap;
                item.companyid = input.companyid;
                item.FK_Leader = input.FK_Leader;
                if (insert)
                {
                    dc.ACcountobject.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.ACcountobject.Update(base.ConnectionData.Schema, item);
                }

                // Get lại giá trị của Master
                view_AccountObject returnItem = dc.VIewaccountobject.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", item.Id);
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
        /// Get data refer Master AccountObjectType
        /// </summary>
        /// <returns>AccountObjectType</returns>
        public async Task<List<AccountObjectType>> GetMasterAccountTypeList(int type)
        {
            List<AccountObjectType> ls = new List<AccountObjectType>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.ACcountobjecttype.GetListObjectCon(ConnectionData.Schema, "WHERE Id>=" + type);
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
        public async Task<List<ExpPost>> GetMasterCardIdList(AccountObject user)
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
        /// <summary>
        /// Get data refer Master Branch
        /// </summary>
        /// <returns>Branch</returns>
        public async Task<List<Branch>> GetMasterFK_BranchOwnerList()
        {
            List<Branch> ls = new List<Branch>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.BRanch.GetListObject(ConnectionData.Schema);
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

