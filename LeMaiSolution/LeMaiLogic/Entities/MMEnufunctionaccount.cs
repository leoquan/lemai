using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEnufunctionaccount:IMEnufunctionaccount
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEnufunctionaccount(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MenuFunction_Account từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuFunction_Account]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MenuFunction_Account từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuFunction_Account] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MenuFunction_Account từ Database
		/// </summary>
		public List<MenuFunction_Account> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuFunction_Account]");
				List<MenuFunction_Account> items = new List<MenuFunction_Account>();
				MenuFunction_Account item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MenuFunction_Account();
					if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
					{
						item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
					}
					if (dr["FK_MenuFunction"] != null && dr["FK_MenuFunction"] != DBNull.Value)
					{
						item.FK_MenuFunction = Convert.ToString(dr["FK_MenuFunction"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateUser"] != null && dr["CreateUser"] != DBNull.Value)
					{
						item.CreateUser = Convert.ToString(dr["CreateUser"]);
					}
					if (dr["PermissionValue"] != null && dr["PermissionValue"] != DBNull.Value)
					{
						item.PermissionValue = Convert.ToInt32(dr["PermissionValue"]);
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
		/// Lấy danh sách MenuFunction_Account từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MenuFunction_Account> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MenuFunction_Account] A "+ condition,  parameters);
				List<MenuFunction_Account> items = new List<MenuFunction_Account>();
				MenuFunction_Account item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MenuFunction_Account();
					if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
					{
						item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
					}
					if (dr["FK_MenuFunction"] != null && dr["FK_MenuFunction"] != DBNull.Value)
					{
						item.FK_MenuFunction = Convert.ToString(dr["FK_MenuFunction"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateUser"] != null && dr["CreateUser"] != DBNull.Value)
					{
						item.CreateUser = Convert.ToString(dr["CreateUser"]);
					}
					if (dr["PermissionValue"] != null && dr["PermissionValue"] != DBNull.Value)
					{
						item.PermissionValue = Convert.ToInt32(dr["PermissionValue"]);
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

		public List<MenuFunction_Account> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MenuFunction_Account] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MenuFunction_Account] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MenuFunction_Account>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MenuFunction_Account từ Database
		/// </summary>
		public MenuFunction_Account GetObject(string schema, String FK_AccountObject, String FK_MenuFunction)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuFunction_Account] where FK_AccountObject=@FK_AccountObject and FK_MenuFunction=@FK_MenuFunction",
					"@FK_AccountObject", FK_AccountObject, 
					"@FK_MenuFunction", FK_MenuFunction);
				if (ds.Rows.Count > 0)
				{
					MenuFunction_Account item=new MenuFunction_Account();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
						{
							item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
						}
						if (dr["FK_MenuFunction"] != null && dr["FK_MenuFunction"] != DBNull.Value)
						{
							item.FK_MenuFunction = Convert.ToString(dr["FK_MenuFunction"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateUser"] != null && dr["CreateUser"] != DBNull.Value)
						{
							item.CreateUser = Convert.ToString(dr["CreateUser"]);
						}
						if (dr["PermissionValue"] != null && dr["PermissionValue"] != DBNull.Value)
						{
							item.PermissionValue = Convert.ToInt32(dr["PermissionValue"]);
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
		/// Lấy một MenuFunction_Account đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MenuFunction_Account GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MenuFunction_Account] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MenuFunction_Account item=new MenuFunction_Account();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
						{
							item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
						}
						if (dr["FK_MenuFunction"] != null && dr["FK_MenuFunction"] != DBNull.Value)
						{
							item.FK_MenuFunction = Convert.ToString(dr["FK_MenuFunction"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateUser"] != null && dr["CreateUser"] != DBNull.Value)
						{
							item.CreateUser = Convert.ToString(dr["CreateUser"]);
						}
						if (dr["PermissionValue"] != null && dr["PermissionValue"] != DBNull.Value)
						{
							item.PermissionValue = Convert.ToInt32(dr["PermissionValue"]);
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

		public MenuFunction_Account GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MenuFunction_Account] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MenuFunction_Account>(ds);
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
		/// Thêm mới MenuFunction_Account vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MenuFunction_Account _MenuFunction_Account)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MenuFunction_Account](FK_AccountObject, FK_MenuFunction, CreateDate, CreateUser, PermissionValue) VALUES(@FK_AccountObject, @FK_MenuFunction, @CreateDate, @CreateUser, @PermissionValue)", 
					"@FK_AccountObject",  _MenuFunction_Account.FK_AccountObject, 
					"@FK_MenuFunction",  _MenuFunction_Account.FK_MenuFunction, 
					"@CreateDate", this._dataContext.ConvertDateString( _MenuFunction_Account.CreateDate), 
					"@CreateUser",  _MenuFunction_Account.CreateUser, 
					"@PermissionValue",  _MenuFunction_Account.PermissionValue);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MenuFunction_Account vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MenuFunction_Account> _MenuFunction_Accounts)
		{
			foreach (MenuFunction_Account item in _MenuFunction_Accounts)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MenuFunction_Account vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MenuFunction_Account _MenuFunction_Account, String FK_AccountObject, String FK_MenuFunction)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MenuFunction_Account] SET FK_AccountObject=@FK_AccountObject, FK_MenuFunction=@FK_MenuFunction, CreateDate=@CreateDate, CreateUser=@CreateUser, PermissionValue=@PermissionValue WHERE FK_AccountObject=@FK_AccountObject and FK_MenuFunction=@FK_MenuFunction", 
					"@FK_AccountObject",  _MenuFunction_Account.FK_AccountObject, 
					"@FK_MenuFunction",  _MenuFunction_Account.FK_MenuFunction, 
					"@CreateDate", this._dataContext.ConvertDateString( _MenuFunction_Account.CreateDate), 
					"@CreateUser",  _MenuFunction_Account.CreateUser, 
					"@PermissionValue",  _MenuFunction_Account.PermissionValue, 
					"@FK_AccountObject", FK_AccountObject, 
					"@FK_MenuFunction", FK_MenuFunction);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MenuFunction_Account vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MenuFunction_Account _MenuFunction_Account)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MenuFunction_Account] SET CreateDate=@CreateDate, CreateUser=@CreateUser, PermissionValue=@PermissionValue WHERE FK_AccountObject=@FK_AccountObject and FK_MenuFunction=@FK_MenuFunction", 
					"@CreateDate", this._dataContext.ConvertDateString( _MenuFunction_Account.CreateDate), 
					"@CreateUser",  _MenuFunction_Account.CreateUser, 
					"@PermissionValue",  _MenuFunction_Account.PermissionValue, 
					"@FK_AccountObject", _MenuFunction_Account.FK_AccountObject, 
					"@FK_MenuFunction", _MenuFunction_Account.FK_MenuFunction);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MenuFunction_Account vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MenuFunction_Account> _MenuFunction_Accounts)
		{
			foreach (MenuFunction_Account item in _MenuFunction_Accounts)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MenuFunction_Account vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MenuFunction_Account _MenuFunction_Account, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MenuFunction_Account] SET FK_AccountObject=@FK_AccountObject, FK_MenuFunction=@FK_MenuFunction, CreateDate=@CreateDate, CreateUser=@CreateUser, PermissionValue=@PermissionValue "+ condition, 
					"@FK_AccountObject",  _MenuFunction_Account.FK_AccountObject, 
					"@FK_MenuFunction",  _MenuFunction_Account.FK_MenuFunction, 
					"@CreateDate", this._dataContext.ConvertDateString( _MenuFunction_Account.CreateDate), 
					"@CreateUser",  _MenuFunction_Account.CreateUser, 
					"@PermissionValue",  _MenuFunction_Account.PermissionValue);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MenuFunction_Account trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String FK_AccountObject, String FK_MenuFunction)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MenuFunction_Account] WHERE FK_AccountObject=@FK_AccountObject and FK_MenuFunction=@FK_MenuFunction",
					"@FK_AccountObject", FK_AccountObject, 
					"@FK_MenuFunction", FK_MenuFunction);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MenuFunction_Account trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MenuFunction_Account _MenuFunction_Account)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MenuFunction_Account] WHERE FK_AccountObject=@FK_AccountObject and FK_MenuFunction=@FK_MenuFunction",
					"@FK_AccountObject", _MenuFunction_Account.FK_AccountObject, 
					"@FK_MenuFunction", _MenuFunction_Account.FK_MenuFunction);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MenuFunction_Account trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MenuFunction_Account] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MenuFunction_Account trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MenuFunction_Account> _MenuFunction_Accounts)
		{
			foreach (MenuFunction_Account item in _MenuFunction_Accounts)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
