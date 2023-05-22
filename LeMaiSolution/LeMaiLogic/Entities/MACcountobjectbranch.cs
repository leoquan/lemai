using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MACcountobjectbranch:IACcountobjectbranch
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MACcountobjectbranch(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable AccountObjectBranch từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectBranch]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable AccountObjectBranch từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectBranch] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách AccountObjectBranch từ Database
		/// </summary>
		public List<AccountObjectBranch> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectBranch]");
				List<AccountObjectBranch> items = new List<AccountObjectBranch>();
				AccountObjectBranch item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new AccountObjectBranch();
					if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
					{
						item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
					}
					if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
					{
						item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
					}
					if (dr["FK_Role"] != null && dr["FK_Role"] != DBNull.Value)
					{
						item.FK_Role = Convert.ToString(dr["FK_Role"]);
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
		/// Lấy danh sách AccountObjectBranch từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<AccountObjectBranch> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[AccountObjectBranch] A "+ condition,  parameters);
				List<AccountObjectBranch> items = new List<AccountObjectBranch>();
				AccountObjectBranch item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new AccountObjectBranch();
					if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
					{
						item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
					}
					if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
					{
						item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
					}
					if (dr["FK_Role"] != null && dr["FK_Role"] != DBNull.Value)
					{
						item.FK_Role = Convert.ToString(dr["FK_Role"]);
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

		public List<AccountObjectBranch> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[AccountObjectBranch] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[AccountObjectBranch] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<AccountObjectBranch>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một AccountObjectBranch từ Database
		/// </summary>
		public AccountObjectBranch GetObject(string schema, String FK_Branch, String FK_AccountObject)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectBranch] where FK_Branch=@FK_Branch and FK_AccountObject=@FK_AccountObject",
					"@FK_Branch", FK_Branch, 
					"@FK_AccountObject", FK_AccountObject);
				if (ds.Rows.Count > 0)
				{
					AccountObjectBranch item=new AccountObjectBranch();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
						{
							item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
						}
						if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
						{
							item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
						}
						if (dr["FK_Role"] != null && dr["FK_Role"] != DBNull.Value)
						{
							item.FK_Role = Convert.ToString(dr["FK_Role"]);
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
		/// Lấy một AccountObjectBranch đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public AccountObjectBranch GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[AccountObjectBranch] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					AccountObjectBranch item=new AccountObjectBranch();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
						{
							item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
						}
						if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
						{
							item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
						}
						if (dr["FK_Role"] != null && dr["FK_Role"] != DBNull.Value)
						{
							item.FK_Role = Convert.ToString(dr["FK_Role"]);
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

		public AccountObjectBranch GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[AccountObjectBranch] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<AccountObjectBranch>(ds);
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
		/// Thêm mới AccountObjectBranch vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, AccountObjectBranch _AccountObjectBranch)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[AccountObjectBranch](FK_Branch, FK_AccountObject, FK_Role) VALUES(@FK_Branch, @FK_AccountObject, @FK_Role)", 
					"@FK_Branch",  _AccountObjectBranch.FK_Branch, 
					"@FK_AccountObject",  _AccountObjectBranch.FK_AccountObject, 
					"@FK_Role",  _AccountObjectBranch.FK_Role);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng AccountObjectBranch vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<AccountObjectBranch> _AccountObjectBranchs)
		{
			foreach (AccountObjectBranch item in _AccountObjectBranchs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật AccountObjectBranch vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, AccountObjectBranch _AccountObjectBranch, String FK_Branch, String FK_AccountObject)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[AccountObjectBranch] SET FK_Branch=@FK_Branch, FK_AccountObject=@FK_AccountObject, FK_Role=@FK_Role WHERE FK_Branch=@FK_Branch and FK_AccountObject=@FK_AccountObject", 
					"@FK_Branch",  _AccountObjectBranch.FK_Branch, 
					"@FK_AccountObject",  _AccountObjectBranch.FK_AccountObject, 
					"@FK_Role",  _AccountObjectBranch.FK_Role, 
					"@FK_Branch", FK_Branch, 
					"@FK_AccountObject", FK_AccountObject);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật AccountObjectBranch vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, AccountObjectBranch _AccountObjectBranch)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[AccountObjectBranch] SET FK_Role=@FK_Role WHERE FK_Branch=@FK_Branch and FK_AccountObject=@FK_AccountObject", 
					"@FK_Role",  _AccountObjectBranch.FK_Role, 
					"@FK_Branch", _AccountObjectBranch.FK_Branch, 
					"@FK_AccountObject", _AccountObjectBranch.FK_AccountObject);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách AccountObjectBranch vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<AccountObjectBranch> _AccountObjectBranchs)
		{
			foreach (AccountObjectBranch item in _AccountObjectBranchs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật AccountObjectBranch vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, AccountObjectBranch _AccountObjectBranch, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[AccountObjectBranch] SET FK_Branch=@FK_Branch, FK_AccountObject=@FK_AccountObject, FK_Role=@FK_Role "+ condition, 
					"@FK_Branch",  _AccountObjectBranch.FK_Branch, 
					"@FK_AccountObject",  _AccountObjectBranch.FK_AccountObject, 
					"@FK_Role",  _AccountObjectBranch.FK_Role);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa AccountObjectBranch trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String FK_Branch, String FK_AccountObject)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[AccountObjectBranch] WHERE FK_Branch=@FK_Branch and FK_AccountObject=@FK_AccountObject",
					"@FK_Branch", FK_Branch, 
					"@FK_AccountObject", FK_AccountObject);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa AccountObjectBranch trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, AccountObjectBranch _AccountObjectBranch)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[AccountObjectBranch] WHERE FK_Branch=@FK_Branch and FK_AccountObject=@FK_AccountObject",
					"@FK_Branch", _AccountObjectBranch.FK_Branch, 
					"@FK_AccountObject", _AccountObjectBranch.FK_AccountObject);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa AccountObjectBranch trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[AccountObjectBranch] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa AccountObjectBranch trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<AccountObjectBranch> _AccountObjectBranchs)
		{
			foreach (AccountObjectBranch item in _AccountObjectBranchs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
