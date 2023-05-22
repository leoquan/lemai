using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewaccountobject:IVIewaccountobject
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewaccountobject(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_AccountObject từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_AccountObject]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_AccountObject từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_AccountObject] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_AccountObject từ Database
		/// </summary>
		public List<view_AccountObject> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_AccountObject]");
				List<view_AccountObject> items = new List<view_AccountObject>();
				view_AccountObject item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_AccountObject();
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
					if (dr["CreateByName"] != null && dr["CreateByName"] != DBNull.Value)
					{
						item.CreateByName = Convert.ToString(dr["CreateByName"]);
					}
					if (dr["ModifyByName"] != null && dr["ModifyByName"] != DBNull.Value)
					{
						item.ModifyByName = Convert.ToString(dr["ModifyByName"]);
					}
					if (dr["BranchName"] != null && dr["BranchName"] != DBNull.Value)
					{
						item.BranchName = Convert.ToString(dr["BranchName"]);
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
		/// Lấy danh sách view_AccountObject từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_AccountObject> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_AccountObject] A "+ condition,  parameters);
				List<view_AccountObject> items = new List<view_AccountObject>();
				view_AccountObject item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_AccountObject();
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
					if (dr["CreateByName"] != null && dr["CreateByName"] != DBNull.Value)
					{
						item.CreateByName = Convert.ToString(dr["CreateByName"]);
					}
					if (dr["ModifyByName"] != null && dr["ModifyByName"] != DBNull.Value)
					{
						item.ModifyByName = Convert.ToString(dr["ModifyByName"]);
					}
					if (dr["BranchName"] != null && dr["BranchName"] != DBNull.Value)
					{
						item.BranchName = Convert.ToString(dr["BranchName"]);
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

		public List<view_AccountObject> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_AccountObject] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_AccountObject] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_AccountObject>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_AccountObject đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_AccountObject GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_AccountObject] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_AccountObject item=new view_AccountObject();
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
						if (dr["CreateByName"] != null && dr["CreateByName"] != DBNull.Value)
						{
							item.CreateByName = Convert.ToString(dr["CreateByName"]);
						}
						if (dr["ModifyByName"] != null && dr["ModifyByName"] != DBNull.Value)
						{
							item.ModifyByName = Convert.ToString(dr["ModifyByName"]);
						}
						if (dr["BranchName"] != null && dr["BranchName"] != DBNull.Value)
						{
							item.BranchName = Convert.ToString(dr["BranchName"]);
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

		public view_AccountObject GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_AccountObject] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_AccountObject>(ds);
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
	}
}
