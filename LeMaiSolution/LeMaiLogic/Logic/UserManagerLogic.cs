using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public class UserManagerLogic : BaseLogic
    {
        public UserManagerLogic(BaseLogicConnectionData data) : base(data)
        {
        }

        public async Task<string> LoginAsync(string Username, string Password, string Device)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();

                var data = dc.ExecuteNonQueryStoreReturnValue("sp_LoginUser", "@Username", Username, "@Password", Password);
                if (data.Rows.Count > 0)
                {
                    return data.Rows[0][0].ToString();
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
        public async Task<AccountObject> GetAccountObject(string AccountObjectId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.ACcountobject.GetObject(base.ConnectionData.Schema, AccountObjectId);
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
        public async Task<Branch> GetAccountObjectBranch(string BranchId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.BRanch.GetObject(base.ConnectionData.Schema, BranchId);
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
        public async Task<int> UpdateProfileUser(UpdateProfileInput input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                var RowVersion = dc.ACcountobject.GetObject(ConnectionData.Schema, input.Id);

                string sql = @"UPDATE AccountObject 
			                    SET FullName = @FullName, Phone = @Phone, AtLastModifiedBy  = @AtLastModifiedBy ,Email = @Email, AtLastModifiedDate = GETDATE()
			                    WHERE Id = @Id";
                var result = dc.ExecuteNonQuery(sql,
                    "@AtLastModifiedBy", input.AtLastModifiedBy,
                    "@Email", input.Email,
                    "@FullName", input.FullName,
                    "@Phone", input.Phone,
                    "@Id", input.Id);
                dc.SubmitChanges();
                return (int)ErrorCodeEnum.None;

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

