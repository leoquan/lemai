using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MACcountobject:IACcountobject
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MACcountobject(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable AccountObject từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObject]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable AccountObject từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObject] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách AccountObject từ Database
		/// </summary>
		public List<AccountObject> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObject]");
				List<AccountObject> items = new List<AccountObject>();
				AccountObject item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new AccountObject();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
					}
					if (dr["UserName"] != null && dr["UserName"] != DBNull.Value)
					{
						item.UserName = Convert.ToString(dr["UserName"]);
					}
					if (dr["PassWord"] != null && dr["PassWord"] != DBNull.Value)
					{
						item.PassWord = Convert.ToString(dr["PassWord"]);
					}
					if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
					{
						item.Phone = Convert.ToString(dr["Phone"]);
					}
					if (dr["Email"] != null && dr["Email"] != DBNull.Value)
					{
						item.Email = Convert.ToString(dr["Email"]);
					}
					if (dr["AtCreatedDate"] != null && dr["AtCreatedDate"] != DBNull.Value)
					{
						item.AtCreatedDate = Convert.ToDateTime(dr["AtCreatedDate"]);
					}
					if (dr["AtCreatedBy"] != null && dr["AtCreatedBy"] != DBNull.Value)
					{
						item.AtCreatedBy = Convert.ToString(dr["AtCreatedBy"]);
					}
					if (dr["AtLastModifiedDate"] != null && dr["AtLastModifiedDate"] != DBNull.Value)
					{
						item.AtLastModifiedDate = Convert.ToDateTime(dr["AtLastModifiedDate"]);
					}
					if (dr["AtLastModifiedBy"] != null && dr["AtLastModifiedBy"] != DBNull.Value)
					{
						item.AtLastModifiedBy = Convert.ToString(dr["AtLastModifiedBy"]);
					}
					if (dr["AtRowStatus"] != null && dr["AtRowStatus"] != DBNull.Value)
					{
						item.AtRowStatus = Convert.ToInt32(dr["AtRowStatus"]);
					}
					if (dr["AccountType"] != null && dr["AccountType"] != DBNull.Value)
					{
						item.AccountType = Convert.ToInt32(dr["AccountType"]);
					}
					if (dr["LastLogin"] != null && dr["LastLogin"] != DBNull.Value)
					{
						item.LastLogin = Convert.ToDateTime(dr["LastLogin"]);
					}
					if (dr["CardId"] != null && dr["CardId"] != DBNull.Value)
					{
						item.CardId = Convert.ToString(dr["CardId"]);
					}
					if (dr["BirthDay"] != null && dr["BirthDay"] != DBNull.Value)
					{
						item.BirthDay = Convert.ToDateTime(dr["BirthDay"]);
					}
					if (dr["Address"] != null && dr["Address"] != DBNull.Value)
					{
						item.Address = Convert.ToString(dr["Address"]);
					}
					if (dr["IdAccountIntro"] != null && dr["IdAccountIntro"] != DBNull.Value)
					{
						item.IdAccountIntro = Convert.ToString(dr["IdAccountIntro"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["FK_BranchOwner"] != null && dr["FK_BranchOwner"] != DBNull.Value)
					{
						item.FK_BranchOwner = Convert.ToString(dr["FK_BranchOwner"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["Balance"] != null && dr["Balance"] != DBNull.Value)
					{
						item.Balance = Convert.ToInt32(dr["Balance"]);
					}
					if (dr["RewardPoint"] != null && dr["RewardPoint"] != DBNull.Value)
					{
						item.RewardPoint = Convert.ToInt32(dr["RewardPoint"]);
					}
					if (dr["TaxCode"] != null && dr["TaxCode"] != DBNull.Value)
					{
						item.TaxCode = Convert.ToString(dr["TaxCode"]);
					}
					if (dr["K9Code"] != null && dr["K9Code"] != DBNull.Value)
					{
						item.K9Code = Convert.ToString(dr["K9Code"]);
					}
					if (dr["cap"] != null && dr["cap"] != DBNull.Value)
					{
						item.cap = Convert.ToInt32(dr["cap"]);
					}
					if (dr["companyid"] != null && dr["companyid"] != DBNull.Value)
					{
						item.companyid = Convert.ToString(dr["companyid"]);
					}
					if (dr["FK_Leader"] != null && dr["FK_Leader"] != DBNull.Value)
					{
						item.FK_Leader = Convert.ToString(dr["FK_Leader"]);
					}
					items.Add(item);
				}
				return items;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách AccountObject từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<AccountObject> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[AccountObject] A "+ condition,  parameters);
				List<AccountObject> items = new List<AccountObject>();
				AccountObject item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new AccountObject();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
					}
					if (dr["UserName"] != null && dr["UserName"] != DBNull.Value)
					{
						item.UserName = Convert.ToString(dr["UserName"]);
					}
					if (dr["PassWord"] != null && dr["PassWord"] != DBNull.Value)
					{
						item.PassWord = Convert.ToString(dr["PassWord"]);
					}
					if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
					{
						item.Phone = Convert.ToString(dr["Phone"]);
					}
					if (dr["Email"] != null && dr["Email"] != DBNull.Value)
					{
						item.Email = Convert.ToString(dr["Email"]);
					}
					if (dr["AtCreatedDate"] != null && dr["AtCreatedDate"] != DBNull.Value)
					{
						item.AtCreatedDate = Convert.ToDateTime(dr["AtCreatedDate"]);
					}
					if (dr["AtCreatedBy"] != null && dr["AtCreatedBy"] != DBNull.Value)
					{
						item.AtCreatedBy = Convert.ToString(dr["AtCreatedBy"]);
					}
					if (dr["AtLastModifiedDate"] != null && dr["AtLastModifiedDate"] != DBNull.Value)
					{
						item.AtLastModifiedDate = Convert.ToDateTime(dr["AtLastModifiedDate"]);
					}
					if (dr["AtLastModifiedBy"] != null && dr["AtLastModifiedBy"] != DBNull.Value)
					{
						item.AtLastModifiedBy = Convert.ToString(dr["AtLastModifiedBy"]);
					}
					if (dr["AtRowStatus"] != null && dr["AtRowStatus"] != DBNull.Value)
					{
						item.AtRowStatus = Convert.ToInt32(dr["AtRowStatus"]);
					}
					if (dr["AccountType"] != null && dr["AccountType"] != DBNull.Value)
					{
						item.AccountType = Convert.ToInt32(dr["AccountType"]);
					}
					if (dr["LastLogin"] != null && dr["LastLogin"] != DBNull.Value)
					{
						item.LastLogin = Convert.ToDateTime(dr["LastLogin"]);
					}
					if (dr["CardId"] != null && dr["CardId"] != DBNull.Value)
					{
						item.CardId = Convert.ToString(dr["CardId"]);
					}
					if (dr["BirthDay"] != null && dr["BirthDay"] != DBNull.Value)
					{
						item.BirthDay = Convert.ToDateTime(dr["BirthDay"]);
					}
					if (dr["Address"] != null && dr["Address"] != DBNull.Value)
					{
						item.Address = Convert.ToString(dr["Address"]);
					}
					if (dr["IdAccountIntro"] != null && dr["IdAccountIntro"] != DBNull.Value)
					{
						item.IdAccountIntro = Convert.ToString(dr["IdAccountIntro"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["FK_BranchOwner"] != null && dr["FK_BranchOwner"] != DBNull.Value)
					{
						item.FK_BranchOwner = Convert.ToString(dr["FK_BranchOwner"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["Balance"] != null && dr["Balance"] != DBNull.Value)
					{
						item.Balance = Convert.ToInt32(dr["Balance"]);
					}
					if (dr["RewardPoint"] != null && dr["RewardPoint"] != DBNull.Value)
					{
						item.RewardPoint = Convert.ToInt32(dr["RewardPoint"]);
					}
					if (dr["TaxCode"] != null && dr["TaxCode"] != DBNull.Value)
					{
						item.TaxCode = Convert.ToString(dr["TaxCode"]);
					}
					if (dr["K9Code"] != null && dr["K9Code"] != DBNull.Value)
					{
						item.K9Code = Convert.ToString(dr["K9Code"]);
					}
					if (dr["cap"] != null && dr["cap"] != DBNull.Value)
					{
						item.cap = Convert.ToInt32(dr["cap"]);
					}
					if (dr["companyid"] != null && dr["companyid"] != DBNull.Value)
					{
						item.companyid = Convert.ToString(dr["companyid"]);
					}
					if (dr["FK_Leader"] != null && dr["FK_Leader"] != DBNull.Value)
					{
						item.FK_Leader = Convert.ToString(dr["FK_Leader"]);
					}
					items.Add(item);
				}
				return items;
			}
			catch
			{
				throw;
			}
		}

		public List<AccountObject> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[AccountObject] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[AccountObject] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<AccountObject>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một AccountObject từ Database
		/// </summary>
		public AccountObject GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObject] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					AccountObject item=new AccountObject();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
						{
							item.FullName = Convert.ToString(dr["FullName"]);
						}
						if (dr["UserName"] != null && dr["UserName"] != DBNull.Value)
						{
							item.UserName = Convert.ToString(dr["UserName"]);
						}
						if (dr["PassWord"] != null && dr["PassWord"] != DBNull.Value)
						{
							item.PassWord = Convert.ToString(dr["PassWord"]);
						}
						if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
						{
							item.Phone = Convert.ToString(dr["Phone"]);
						}
						if (dr["Email"] != null && dr["Email"] != DBNull.Value)
						{
							item.Email = Convert.ToString(dr["Email"]);
						}
						if (dr["AtCreatedDate"] != null && dr["AtCreatedDate"] != DBNull.Value)
						{
							item.AtCreatedDate = Convert.ToDateTime(dr["AtCreatedDate"]);
						}
						if (dr["AtCreatedBy"] != null && dr["AtCreatedBy"] != DBNull.Value)
						{
							item.AtCreatedBy = Convert.ToString(dr["AtCreatedBy"]);
						}
						if (dr["AtLastModifiedDate"] != null && dr["AtLastModifiedDate"] != DBNull.Value)
						{
							item.AtLastModifiedDate = Convert.ToDateTime(dr["AtLastModifiedDate"]);
						}
						if (dr["AtLastModifiedBy"] != null && dr["AtLastModifiedBy"] != DBNull.Value)
						{
							item.AtLastModifiedBy = Convert.ToString(dr["AtLastModifiedBy"]);
						}
						if (dr["AtRowStatus"] != null && dr["AtRowStatus"] != DBNull.Value)
						{
							item.AtRowStatus = Convert.ToInt32(dr["AtRowStatus"]);
						}
						if (dr["AccountType"] != null && dr["AccountType"] != DBNull.Value)
						{
							item.AccountType = Convert.ToInt32(dr["AccountType"]);
						}
						if (dr["LastLogin"] != null && dr["LastLogin"] != DBNull.Value)
						{
							item.LastLogin = Convert.ToDateTime(dr["LastLogin"]);
						}
						if (dr["CardId"] != null && dr["CardId"] != DBNull.Value)
						{
							item.CardId = Convert.ToString(dr["CardId"]);
						}
						if (dr["BirthDay"] != null && dr["BirthDay"] != DBNull.Value)
						{
							item.BirthDay = Convert.ToDateTime(dr["BirthDay"]);
						}
						if (dr["Address"] != null && dr["Address"] != DBNull.Value)
						{
							item.Address = Convert.ToString(dr["Address"]);
						}
						if (dr["IdAccountIntro"] != null && dr["IdAccountIntro"] != DBNull.Value)
						{
							item.IdAccountIntro = Convert.ToString(dr["IdAccountIntro"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["FK_BranchOwner"] != null && dr["FK_BranchOwner"] != DBNull.Value)
						{
							item.FK_BranchOwner = Convert.ToString(dr["FK_BranchOwner"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["Balance"] != null && dr["Balance"] != DBNull.Value)
						{
							item.Balance = Convert.ToInt32(dr["Balance"]);
						}
						if (dr["RewardPoint"] != null && dr["RewardPoint"] != DBNull.Value)
						{
							item.RewardPoint = Convert.ToInt32(dr["RewardPoint"]);
						}
						if (dr["TaxCode"] != null && dr["TaxCode"] != DBNull.Value)
						{
							item.TaxCode = Convert.ToString(dr["TaxCode"]);
						}
						if (dr["K9Code"] != null && dr["K9Code"] != DBNull.Value)
						{
							item.K9Code = Convert.ToString(dr["K9Code"]);
						}
						if (dr["cap"] != null && dr["cap"] != DBNull.Value)
						{
							item.cap = Convert.ToInt32(dr["cap"]);
						}
						if (dr["companyid"] != null && dr["companyid"] != DBNull.Value)
						{
							item.companyid = Convert.ToString(dr["companyid"]);
						}
						if (dr["FK_Leader"] != null && dr["FK_Leader"] != DBNull.Value)
						{
							item.FK_Leader = Convert.ToString(dr["FK_Leader"]);
						}

						break;
					}
					return item;
				}
				else
				{
					return null;
				}
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một AccountObject đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public AccountObject GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[AccountObject] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					AccountObject item=new AccountObject();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
						{
							item.FullName = Convert.ToString(dr["FullName"]);
						}
						if (dr["UserName"] != null && dr["UserName"] != DBNull.Value)
						{
							item.UserName = Convert.ToString(dr["UserName"]);
						}
						if (dr["PassWord"] != null && dr["PassWord"] != DBNull.Value)
						{
							item.PassWord = Convert.ToString(dr["PassWord"]);
						}
						if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
						{
							item.Phone = Convert.ToString(dr["Phone"]);
						}
						if (dr["Email"] != null && dr["Email"] != DBNull.Value)
						{
							item.Email = Convert.ToString(dr["Email"]);
						}
						if (dr["AtCreatedDate"] != null && dr["AtCreatedDate"] != DBNull.Value)
						{
							item.AtCreatedDate = Convert.ToDateTime(dr["AtCreatedDate"]);
						}
						if (dr["AtCreatedBy"] != null && dr["AtCreatedBy"] != DBNull.Value)
						{
							item.AtCreatedBy = Convert.ToString(dr["AtCreatedBy"]);
						}
						if (dr["AtLastModifiedDate"] != null && dr["AtLastModifiedDate"] != DBNull.Value)
						{
							item.AtLastModifiedDate = Convert.ToDateTime(dr["AtLastModifiedDate"]);
						}
						if (dr["AtLastModifiedBy"] != null && dr["AtLastModifiedBy"] != DBNull.Value)
						{
							item.AtLastModifiedBy = Convert.ToString(dr["AtLastModifiedBy"]);
						}
						if (dr["AtRowStatus"] != null && dr["AtRowStatus"] != DBNull.Value)
						{
							item.AtRowStatus = Convert.ToInt32(dr["AtRowStatus"]);
						}
						if (dr["AccountType"] != null && dr["AccountType"] != DBNull.Value)
						{
							item.AccountType = Convert.ToInt32(dr["AccountType"]);
						}
						if (dr["LastLogin"] != null && dr["LastLogin"] != DBNull.Value)
						{
							item.LastLogin = Convert.ToDateTime(dr["LastLogin"]);
						}
						if (dr["CardId"] != null && dr["CardId"] != DBNull.Value)
						{
							item.CardId = Convert.ToString(dr["CardId"]);
						}
						if (dr["BirthDay"] != null && dr["BirthDay"] != DBNull.Value)
						{
							item.BirthDay = Convert.ToDateTime(dr["BirthDay"]);
						}
						if (dr["Address"] != null && dr["Address"] != DBNull.Value)
						{
							item.Address = Convert.ToString(dr["Address"]);
						}
						if (dr["IdAccountIntro"] != null && dr["IdAccountIntro"] != DBNull.Value)
						{
							item.IdAccountIntro = Convert.ToString(dr["IdAccountIntro"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["FK_BranchOwner"] != null && dr["FK_BranchOwner"] != DBNull.Value)
						{
							item.FK_BranchOwner = Convert.ToString(dr["FK_BranchOwner"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["Balance"] != null && dr["Balance"] != DBNull.Value)
						{
							item.Balance = Convert.ToInt32(dr["Balance"]);
						}
						if (dr["RewardPoint"] != null && dr["RewardPoint"] != DBNull.Value)
						{
							item.RewardPoint = Convert.ToInt32(dr["RewardPoint"]);
						}
						if (dr["TaxCode"] != null && dr["TaxCode"] != DBNull.Value)
						{
							item.TaxCode = Convert.ToString(dr["TaxCode"]);
						}
						if (dr["K9Code"] != null && dr["K9Code"] != DBNull.Value)
						{
							item.K9Code = Convert.ToString(dr["K9Code"]);
						}
						if (dr["cap"] != null && dr["cap"] != DBNull.Value)
						{
							item.cap = Convert.ToInt32(dr["cap"]);
						}
						if (dr["companyid"] != null && dr["companyid"] != DBNull.Value)
						{
							item.companyid = Convert.ToString(dr["companyid"]);
						}
						if (dr["FK_Leader"] != null && dr["FK_Leader"] != DBNull.Value)
						{
							item.FK_Leader = Convert.ToString(dr["FK_Leader"]);
						}

						break;
					}
					return item;
				}
				else
				{
					return null;
				}
			}
			catch
			{
				throw;
			}
		}

		public AccountObject GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[AccountObject] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<AccountObject>(ds);
				}
				else
				{
					return null;
				}
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Thêm mới AccountObject vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, AccountObject _AccountObject)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[AccountObject](Id, Code, FullName, UserName, PassWord, Phone, Email, AtCreatedDate, AtCreatedBy, AtLastModifiedDate, AtLastModifiedBy, AtRowStatus, AccountType, LastLogin, CardId, BirthDay, Address, IdAccountIntro, ImagePath, FK_BranchOwner, Note, IsDelete, Balance, RewardPoint, TaxCode, K9Code, cap, companyid, FK_Leader) VALUES(@Id, @Code, @FullName, @UserName, @PassWord, @Phone, @Email, @AtCreatedDate, @AtCreatedBy, @AtLastModifiedDate, @AtLastModifiedBy, @AtRowStatus, @AccountType, @LastLogin, @CardId, @BirthDay, @Address, @IdAccountIntro, @ImagePath, @FK_BranchOwner, @Note, @IsDelete, @Balance, @RewardPoint, @TaxCode, @K9Code, @cap, @companyid, @FK_Leader)", 
					"@Id",  _AccountObject.Id, 
					"@Code",  _AccountObject.Code, 
					"@FullName",  _AccountObject.FullName, 
					"@UserName",  _AccountObject.UserName, 
					"@PassWord",  _AccountObject.PassWord, 
					"@Phone",  _AccountObject.Phone, 
					"@Email",  _AccountObject.Email, 
					"@AtCreatedDate", this._dataContext.ConvertDateString( _AccountObject.AtCreatedDate), 
					"@AtCreatedBy",  _AccountObject.AtCreatedBy, 
					"@AtLastModifiedDate", this._dataContext.ConvertDateString( _AccountObject.AtLastModifiedDate), 
					"@AtLastModifiedBy",  _AccountObject.AtLastModifiedBy, 
					"@AtRowStatus",  _AccountObject.AtRowStatus, 
					"@AccountType",  _AccountObject.AccountType, 
					"@LastLogin", this._dataContext.ConvertDateString( _AccountObject.LastLogin), 
					"@CardId",  _AccountObject.CardId, 
					"@BirthDay", this._dataContext.ConvertDateString( _AccountObject.BirthDay), 
					"@Address",  _AccountObject.Address, 
					"@IdAccountIntro",  _AccountObject.IdAccountIntro, 
					"@ImagePath",  _AccountObject.ImagePath, 
					"@FK_BranchOwner",  _AccountObject.FK_BranchOwner, 
					"@Note",  _AccountObject.Note, 
					"@IsDelete",  _AccountObject.IsDelete, 
					"@Balance",  _AccountObject.Balance, 
					"@RewardPoint",  _AccountObject.RewardPoint, 
					"@TaxCode",  _AccountObject.TaxCode, 
					"@K9Code",  _AccountObject.K9Code, 
					"@cap",  _AccountObject.cap, 
					"@companyid",  _AccountObject.companyid, 
					"@FK_Leader",  _AccountObject.FK_Leader);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng AccountObject vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<AccountObject> _AccountObjects)
		{
			foreach (AccountObject item in _AccountObjects)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật AccountObject vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, AccountObject _AccountObject, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[AccountObject] SET Id=@Id, Code=@Code, FullName=@FullName, UserName=@UserName, PassWord=@PassWord, Phone=@Phone, Email=@Email, AtCreatedDate=@AtCreatedDate, AtCreatedBy=@AtCreatedBy, AtLastModifiedDate=@AtLastModifiedDate, AtLastModifiedBy=@AtLastModifiedBy, AtRowStatus=@AtRowStatus, AccountType=@AccountType, LastLogin=@LastLogin, CardId=@CardId, BirthDay=@BirthDay, Address=@Address, IdAccountIntro=@IdAccountIntro, ImagePath=@ImagePath, FK_BranchOwner=@FK_BranchOwner, Note=@Note, IsDelete=@IsDelete, Balance=@Balance, RewardPoint=@RewardPoint, TaxCode=@TaxCode, K9Code=@K9Code, cap=@cap, companyid=@companyid, FK_Leader=@FK_Leader WHERE Id=@Id", 
					"@Id",  _AccountObject.Id, 
					"@Code",  _AccountObject.Code, 
					"@FullName",  _AccountObject.FullName, 
					"@UserName",  _AccountObject.UserName, 
					"@PassWord",  _AccountObject.PassWord, 
					"@Phone",  _AccountObject.Phone, 
					"@Email",  _AccountObject.Email, 
					"@AtCreatedDate", this._dataContext.ConvertDateString( _AccountObject.AtCreatedDate), 
					"@AtCreatedBy",  _AccountObject.AtCreatedBy, 
					"@AtLastModifiedDate", this._dataContext.ConvertDateString( _AccountObject.AtLastModifiedDate), 
					"@AtLastModifiedBy",  _AccountObject.AtLastModifiedBy, 
					"@AtRowStatus",  _AccountObject.AtRowStatus, 
					"@AccountType",  _AccountObject.AccountType, 
					"@LastLogin", this._dataContext.ConvertDateString( _AccountObject.LastLogin), 
					"@CardId",  _AccountObject.CardId, 
					"@BirthDay", this._dataContext.ConvertDateString( _AccountObject.BirthDay), 
					"@Address",  _AccountObject.Address, 
					"@IdAccountIntro",  _AccountObject.IdAccountIntro, 
					"@ImagePath",  _AccountObject.ImagePath, 
					"@FK_BranchOwner",  _AccountObject.FK_BranchOwner, 
					"@Note",  _AccountObject.Note, 
					"@IsDelete",  _AccountObject.IsDelete, 
					"@Balance",  _AccountObject.Balance, 
					"@RewardPoint",  _AccountObject.RewardPoint, 
					"@TaxCode",  _AccountObject.TaxCode, 
					"@K9Code",  _AccountObject.K9Code, 
					"@cap",  _AccountObject.cap, 
					"@companyid",  _AccountObject.companyid, 
					"@FK_Leader",  _AccountObject.FK_Leader, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật AccountObject vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, AccountObject _AccountObject)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[AccountObject] SET Code=@Code, FullName=@FullName, UserName=@UserName, PassWord=@PassWord, Phone=@Phone, Email=@Email, AtCreatedDate=@AtCreatedDate, AtCreatedBy=@AtCreatedBy, AtLastModifiedDate=@AtLastModifiedDate, AtLastModifiedBy=@AtLastModifiedBy, AtRowStatus=@AtRowStatus, AccountType=@AccountType, LastLogin=@LastLogin, CardId=@CardId, BirthDay=@BirthDay, Address=@Address, IdAccountIntro=@IdAccountIntro, ImagePath=@ImagePath, FK_BranchOwner=@FK_BranchOwner, Note=@Note, IsDelete=@IsDelete, Balance=@Balance, RewardPoint=@RewardPoint, TaxCode=@TaxCode, K9Code=@K9Code, cap=@cap, companyid=@companyid, FK_Leader=@FK_Leader WHERE Id=@Id", 
					"@Code",  _AccountObject.Code, 
					"@FullName",  _AccountObject.FullName, 
					"@UserName",  _AccountObject.UserName, 
					"@PassWord",  _AccountObject.PassWord, 
					"@Phone",  _AccountObject.Phone, 
					"@Email",  _AccountObject.Email, 
					"@AtCreatedDate", this._dataContext.ConvertDateString( _AccountObject.AtCreatedDate), 
					"@AtCreatedBy",  _AccountObject.AtCreatedBy, 
					"@AtLastModifiedDate", this._dataContext.ConvertDateString( _AccountObject.AtLastModifiedDate), 
					"@AtLastModifiedBy",  _AccountObject.AtLastModifiedBy, 
					"@AtRowStatus",  _AccountObject.AtRowStatus, 
					"@AccountType",  _AccountObject.AccountType, 
					"@LastLogin", this._dataContext.ConvertDateString( _AccountObject.LastLogin), 
					"@CardId",  _AccountObject.CardId, 
					"@BirthDay", this._dataContext.ConvertDateString( _AccountObject.BirthDay), 
					"@Address",  _AccountObject.Address, 
					"@IdAccountIntro",  _AccountObject.IdAccountIntro, 
					"@ImagePath",  _AccountObject.ImagePath, 
					"@FK_BranchOwner",  _AccountObject.FK_BranchOwner, 
					"@Note",  _AccountObject.Note, 
					"@IsDelete",  _AccountObject.IsDelete, 
					"@Balance",  _AccountObject.Balance, 
					"@RewardPoint",  _AccountObject.RewardPoint, 
					"@TaxCode",  _AccountObject.TaxCode, 
					"@K9Code",  _AccountObject.K9Code, 
					"@cap",  _AccountObject.cap, 
					"@companyid",  _AccountObject.companyid, 
					"@FK_Leader",  _AccountObject.FK_Leader, 
					"@Id", _AccountObject.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách AccountObject vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<AccountObject> _AccountObjects)
		{
			foreach (AccountObject item in _AccountObjects)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật AccountObject vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, AccountObject _AccountObject, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[AccountObject] SET Id=@Id, Code=@Code, FullName=@FullName, UserName=@UserName, PassWord=@PassWord, Phone=@Phone, Email=@Email, AtCreatedDate=@AtCreatedDate, AtCreatedBy=@AtCreatedBy, AtLastModifiedDate=@AtLastModifiedDate, AtLastModifiedBy=@AtLastModifiedBy, AtRowStatus=@AtRowStatus, AccountType=@AccountType, LastLogin=@LastLogin, CardId=@CardId, BirthDay=@BirthDay, Address=@Address, IdAccountIntro=@IdAccountIntro, ImagePath=@ImagePath, FK_BranchOwner=@FK_BranchOwner, Note=@Note, IsDelete=@IsDelete, Balance=@Balance, RewardPoint=@RewardPoint, TaxCode=@TaxCode, K9Code=@K9Code, cap=@cap, companyid=@companyid, FK_Leader=@FK_Leader "+ condition, 
					"@Id",  _AccountObject.Id, 
					"@Code",  _AccountObject.Code, 
					"@FullName",  _AccountObject.FullName, 
					"@UserName",  _AccountObject.UserName, 
					"@PassWord",  _AccountObject.PassWord, 
					"@Phone",  _AccountObject.Phone, 
					"@Email",  _AccountObject.Email, 
					"@AtCreatedDate", this._dataContext.ConvertDateString( _AccountObject.AtCreatedDate), 
					"@AtCreatedBy",  _AccountObject.AtCreatedBy, 
					"@AtLastModifiedDate", this._dataContext.ConvertDateString( _AccountObject.AtLastModifiedDate), 
					"@AtLastModifiedBy",  _AccountObject.AtLastModifiedBy, 
					"@AtRowStatus",  _AccountObject.AtRowStatus, 
					"@AccountType",  _AccountObject.AccountType, 
					"@LastLogin", this._dataContext.ConvertDateString( _AccountObject.LastLogin), 
					"@CardId",  _AccountObject.CardId, 
					"@BirthDay", this._dataContext.ConvertDateString( _AccountObject.BirthDay), 
					"@Address",  _AccountObject.Address, 
					"@IdAccountIntro",  _AccountObject.IdAccountIntro, 
					"@ImagePath",  _AccountObject.ImagePath, 
					"@FK_BranchOwner",  _AccountObject.FK_BranchOwner, 
					"@Note",  _AccountObject.Note, 
					"@IsDelete",  _AccountObject.IsDelete, 
					"@Balance",  _AccountObject.Balance, 
					"@RewardPoint",  _AccountObject.RewardPoint, 
					"@TaxCode",  _AccountObject.TaxCode, 
					"@K9Code",  _AccountObject.K9Code, 
					"@cap",  _AccountObject.cap, 
					"@companyid",  _AccountObject.companyid, 
					"@FK_Leader",  _AccountObject.FK_Leader);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa AccountObject trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[AccountObject] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa AccountObject trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, AccountObject _AccountObject)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[AccountObject] WHERE Id=@Id",
					"@Id", _AccountObject.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa AccountObject trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[AccountObject] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa AccountObject trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<AccountObject> _AccountObjects)
		{
			foreach (AccountObject item in _AccountObjects)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
