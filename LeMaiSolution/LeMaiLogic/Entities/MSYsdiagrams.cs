using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSYsdiagrams:ISYsdiagrams
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSYsdiagrams(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable sysdiagrams từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[sysdiagrams]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable sysdiagrams từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[sysdiagrams] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách sysdiagrams từ Database
		/// </summary>
		public List<sysdiagrams> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[sysdiagrams]");
				List<sysdiagrams> items = new List<sysdiagrams>();
				sysdiagrams item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new sysdiagrams();
					if (dr["name"] != null && dr["name"] != DBNull.Value)
					{
						item.name = Convert.ToString(dr["name"]);
					}
					if (dr["principal_id"] != null && dr["principal_id"] != DBNull.Value)
					{
						item.principal_id = Convert.ToInt32(dr["principal_id"]);
					}
					if (dr["diagram_id"] != null && dr["diagram_id"] != DBNull.Value)
					{
						item.diagram_id = Convert.ToInt32(dr["diagram_id"]);
					}
					if (dr["version"] != null && dr["version"] != DBNull.Value)
					{
						item.version = Convert.ToInt32(dr["version"]);
					}
					if (dr["definition"] != null && dr["definition"] != DBNull.Value)
					{
						item.definition = (System.Byte[])dr["definition"];
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
		/// Lấy danh sách sysdiagrams từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<sysdiagrams> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[sysdiagrams] A "+ condition,  parameters);
				List<sysdiagrams> items = new List<sysdiagrams>();
				sysdiagrams item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new sysdiagrams();
					if (dr["name"] != null && dr["name"] != DBNull.Value)
					{
						item.name = Convert.ToString(dr["name"]);
					}
					if (dr["principal_id"] != null && dr["principal_id"] != DBNull.Value)
					{
						item.principal_id = Convert.ToInt32(dr["principal_id"]);
					}
					if (dr["diagram_id"] != null && dr["diagram_id"] != DBNull.Value)
					{
						item.diagram_id = Convert.ToInt32(dr["diagram_id"]);
					}
					if (dr["version"] != null && dr["version"] != DBNull.Value)
					{
						item.version = Convert.ToInt32(dr["version"]);
					}
					if (dr["definition"] != null && dr["definition"] != DBNull.Value)
					{
						item.definition = (System.Byte[])dr["definition"];
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

		public List<sysdiagrams> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[sysdiagrams] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[sysdiagrams] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<sysdiagrams>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một sysdiagrams từ Database
		/// </summary>
		public sysdiagrams GetObject(string schema, Int32 diagram_id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[sysdiagrams] where diagram_id=@diagram_id",
					"@diagram_id", diagram_id);
				if (ds.Rows.Count > 0)
				{
					sysdiagrams item=new sysdiagrams();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["name"] != null && dr["name"] != DBNull.Value)
						{
							item.name = Convert.ToString(dr["name"]);
						}
						if (dr["principal_id"] != null && dr["principal_id"] != DBNull.Value)
						{
							item.principal_id = Convert.ToInt32(dr["principal_id"]);
						}
						if (dr["diagram_id"] != null && dr["diagram_id"] != DBNull.Value)
						{
							item.diagram_id = Convert.ToInt32(dr["diagram_id"]);
						}
						if (dr["version"] != null && dr["version"] != DBNull.Value)
						{
							item.version = Convert.ToInt32(dr["version"]);
						}
						if (dr["definition"] != null && dr["definition"] != DBNull.Value)
						{
							item.definition = (System.Byte[])dr["definition"];
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
		/// Lấy một sysdiagrams đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public sysdiagrams GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[sysdiagrams] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					sysdiagrams item=new sysdiagrams();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["name"] != null && dr["name"] != DBNull.Value)
						{
							item.name = Convert.ToString(dr["name"]);
						}
						if (dr["principal_id"] != null && dr["principal_id"] != DBNull.Value)
						{
							item.principal_id = Convert.ToInt32(dr["principal_id"]);
						}
						if (dr["diagram_id"] != null && dr["diagram_id"] != DBNull.Value)
						{
							item.diagram_id = Convert.ToInt32(dr["diagram_id"]);
						}
						if (dr["version"] != null && dr["version"] != DBNull.Value)
						{
							item.version = Convert.ToInt32(dr["version"]);
						}
						if (dr["definition"] != null && dr["definition"] != DBNull.Value)
						{
							item.definition = (System.Byte[])dr["definition"];
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

		public sysdiagrams GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[sysdiagrams] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<sysdiagrams>(ds);
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
		/// Thêm mới sysdiagrams vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, sysdiagrams _sysdiagrams)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[sysdiagrams](name, principal_id, diagram_id, version) VALUES(@name, @principal_id, @diagram_id, @version)", 
					"@name",  _sysdiagrams.name, 
					"@principal_id",  _sysdiagrams.principal_id, 
					"@diagram_id",  _sysdiagrams.diagram_id, 
					"@version",  _sysdiagrams.version);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng sysdiagrams vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<sysdiagrams> _sysdiagramss)
		{
			foreach (sysdiagrams item in _sysdiagramss)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Thêm mới sysdiagrams vào Database kết quả trả về là giá trị của cột tự động tăng
		/// </summary>
		public int InsertReturnAutonumber(string schema, sysdiagrams _sysdiagrams)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("INSERT INTO " + schema + ".[sysdiagrams](name, principal_id, diagram_id, version) VALUES(@name, @principal_id, @diagram_id, @version)  returning definition", 
					"@name",  _sysdiagrams.name, 
					"@principal_id",  _sysdiagrams.principal_id, 
					"@diagram_id",  _sysdiagrams.diagram_id, 
					"@version",  _sysdiagrams.version);
				return Int32.Parse(ds.Rows[0][0].ToString());
			}
			catch
			{
				return -1;
			}
		}
		/// <summary>
		/// Cập nhật sysdiagrams vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, sysdiagrams _sysdiagrams, Int32 diagram_id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[sysdiagrams] SET name=@name, principal_id=@principal_id, diagram_id=@diagram_id, version=@version WHERE diagram_id=@diagram_id", 
					"@name",  _sysdiagrams.name, 
					"@principal_id",  _sysdiagrams.principal_id, 
					"@diagram_id",  _sysdiagrams.diagram_id, 
					"@version",  _sysdiagrams.version, 
					"@diagram_id", diagram_id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật sysdiagrams vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, sysdiagrams _sysdiagrams)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[sysdiagrams] SET name=@name, principal_id=@principal_id, version=@version WHERE diagram_id=@diagram_id", 
					"@name",  _sysdiagrams.name, 
					"@principal_id",  _sysdiagrams.principal_id, 
					"@version",  _sysdiagrams.version, 
					"@diagram_id", _sysdiagrams.diagram_id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách sysdiagrams vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<sysdiagrams> _sysdiagramss)
		{
			foreach (sysdiagrams item in _sysdiagramss)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật sysdiagrams vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, sysdiagrams _sysdiagrams, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[sysdiagrams] SET name=@name, principal_id=@principal_id, diagram_id=@diagram_id, version=@version "+ condition, 
					"@name",  _sysdiagrams.name, 
					"@principal_id",  _sysdiagrams.principal_id, 
					"@diagram_id",  _sysdiagrams.diagram_id, 
					"@version",  _sysdiagrams.version);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa sysdiagrams trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 diagram_id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[sysdiagrams] WHERE diagram_id=@diagram_id",
					"@diagram_id", diagram_id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa sysdiagrams trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, sysdiagrams _sysdiagrams)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[sysdiagrams] WHERE diagram_id=@diagram_id",
					"@diagram_id", _sysdiagrams.diagram_id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa sysdiagrams trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[sysdiagrams] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa sysdiagrams trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<sysdiagrams> _sysdiagramss)
		{
			foreach (sysdiagrams item in _sysdiagramss)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
