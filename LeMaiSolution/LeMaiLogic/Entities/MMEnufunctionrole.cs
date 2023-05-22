using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEnufunctionrole:IMEnufunctionrole
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEnufunctionrole(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MenuFunction_Role từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuFunction_Role]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MenuFunction_Role từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuFunction_Role] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MenuFunction_Role từ Database
		/// </summary>
		public List<MenuFunction_Role> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuFunction_Role]");
				List<MenuFunction_Role> items = new List<MenuFunction_Role>();
				MenuFunction_Role item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MenuFunction_Role();
					if (dr["FK_Role"] != null && dr["FK_Role"] != DBNull.Value)
					{
						item.FK_Role = Convert.ToString(dr["FK_Role"]);
					}
					if (dr["FK_MenuFunction"] != null && dr["FK_MenuFunction"] != DBNull.Value)
					{
						item.FK_MenuFunction = Convert.ToString(dr["FK_MenuFunction"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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
		/// Lấy danh sách MenuFunction_Role từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MenuFunction_Role> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MenuFunction_Role] A "+ condition,  parameters);
				List<MenuFunction_Role> items = new List<MenuFunction_Role>();
				MenuFunction_Role item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MenuFunction_Role();
					if (dr["FK_Role"] != null && dr["FK_Role"] != DBNull.Value)
					{
						item.FK_Role = Convert.ToString(dr["FK_Role"]);
					}
					if (dr["FK_MenuFunction"] != null && dr["FK_MenuFunction"] != DBNull.Value)
					{
						item.FK_MenuFunction = Convert.ToString(dr["FK_MenuFunction"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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

		public List<MenuFunction_Role> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MenuFunction_Role] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MenuFunction_Role] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MenuFunction_Role>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MenuFunction_Role từ Database
		/// </summary>
		public MenuFunction_Role GetObject(string schema, String FK_Role, String FK_MenuFunction)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuFunction_Role] where FK_Role=@FK_Role and FK_MenuFunction=@FK_MenuFunction",
					"@FK_Role", FK_Role, 
					"@FK_MenuFunction", FK_MenuFunction);
				if (ds.Rows.Count > 0)
				{
					MenuFunction_Role item=new MenuFunction_Role();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_Role"] != null && dr["FK_Role"] != DBNull.Value)
						{
							item.FK_Role = Convert.ToString(dr["FK_Role"]);
						}
						if (dr["FK_MenuFunction"] != null && dr["FK_MenuFunction"] != DBNull.Value)
						{
							item.FK_MenuFunction = Convert.ToString(dr["FK_MenuFunction"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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
		/// Lấy một MenuFunction_Role đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MenuFunction_Role GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MenuFunction_Role] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MenuFunction_Role item=new MenuFunction_Role();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_Role"] != null && dr["FK_Role"] != DBNull.Value)
						{
							item.FK_Role = Convert.ToString(dr["FK_Role"]);
						}
						if (dr["FK_MenuFunction"] != null && dr["FK_MenuFunction"] != DBNull.Value)
						{
							item.FK_MenuFunction = Convert.ToString(dr["FK_MenuFunction"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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

		public MenuFunction_Role GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MenuFunction_Role] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MenuFunction_Role>(ds);
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
		/// Thêm mới MenuFunction_Role vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MenuFunction_Role _MenuFunction_Role)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MenuFunction_Role](FK_Role, FK_MenuFunction, CreateDate) VALUES(@FK_Role, @FK_MenuFunction, @CreateDate)", 
					"@FK_Role",  _MenuFunction_Role.FK_Role, 
					"@FK_MenuFunction",  _MenuFunction_Role.FK_MenuFunction, 
					"@CreateDate", this._dataContext.ConvertDateString( _MenuFunction_Role.CreateDate));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MenuFunction_Role vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MenuFunction_Role> _MenuFunction_Roles)
		{
			foreach (MenuFunction_Role item in _MenuFunction_Roles)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MenuFunction_Role vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MenuFunction_Role _MenuFunction_Role, String FK_Role, String FK_MenuFunction)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MenuFunction_Role] SET FK_Role=@FK_Role, FK_MenuFunction=@FK_MenuFunction, CreateDate=@CreateDate WHERE FK_Role=@FK_Role and FK_MenuFunction=@FK_MenuFunction", 
					"@FK_Role",  _MenuFunction_Role.FK_Role, 
					"@FK_MenuFunction",  _MenuFunction_Role.FK_MenuFunction, 
					"@CreateDate", this._dataContext.ConvertDateString( _MenuFunction_Role.CreateDate), 
					"@FK_Role", FK_Role, 
					"@FK_MenuFunction", FK_MenuFunction);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MenuFunction_Role vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MenuFunction_Role _MenuFunction_Role)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MenuFunction_Role] SET CreateDate=@CreateDate WHERE FK_Role=@FK_Role and FK_MenuFunction=@FK_MenuFunction", 
					"@CreateDate", this._dataContext.ConvertDateString( _MenuFunction_Role.CreateDate), 
					"@FK_Role", _MenuFunction_Role.FK_Role, 
					"@FK_MenuFunction", _MenuFunction_Role.FK_MenuFunction);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MenuFunction_Role vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MenuFunction_Role> _MenuFunction_Roles)
		{
			foreach (MenuFunction_Role item in _MenuFunction_Roles)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MenuFunction_Role vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MenuFunction_Role _MenuFunction_Role, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MenuFunction_Role] SET FK_Role=@FK_Role, FK_MenuFunction=@FK_MenuFunction, CreateDate=@CreateDate "+ condition, 
					"@FK_Role",  _MenuFunction_Role.FK_Role, 
					"@FK_MenuFunction",  _MenuFunction_Role.FK_MenuFunction, 
					"@CreateDate", this._dataContext.ConvertDateString( _MenuFunction_Role.CreateDate));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MenuFunction_Role trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String FK_Role, String FK_MenuFunction)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MenuFunction_Role] WHERE FK_Role=@FK_Role and FK_MenuFunction=@FK_MenuFunction",
					"@FK_Role", FK_Role, 
					"@FK_MenuFunction", FK_MenuFunction);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MenuFunction_Role trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MenuFunction_Role _MenuFunction_Role)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MenuFunction_Role] WHERE FK_Role=@FK_Role and FK_MenuFunction=@FK_MenuFunction",
					"@FK_Role", _MenuFunction_Role.FK_Role, 
					"@FK_MenuFunction", _MenuFunction_Role.FK_MenuFunction);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MenuFunction_Role trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MenuFunction_Role] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MenuFunction_Role trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MenuFunction_Role> _MenuFunction_Roles)
		{
			foreach (MenuFunction_Role item in _MenuFunction_Roles)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
