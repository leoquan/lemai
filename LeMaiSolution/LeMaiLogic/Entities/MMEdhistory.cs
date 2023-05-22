using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdhistory:IMEdhistory
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdhistory(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedHiStory từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedHiStory]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedHiStory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedHiStory] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedHiStory từ Database
		/// </summary>
		public List<MedHiStory> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedHiStory]");
				List<MedHiStory> items = new List<MedHiStory>();
				MedHiStory item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedHiStory();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["id_his_login"] != null && dr["id_his_login"] != DBNull.Value)
					{
						item.id_his_login = Convert.ToString(dr["id_his_login"]);
					}
					if (dr["createuser"] != null && dr["createuser"] != DBNull.Value)
					{
						item.createuser = Convert.ToString(dr["createuser"]);
					}
					if (dr["createdate"] != null && dr["createdate"] != DBNull.Value)
					{
						item.createdate = Convert.ToDateTime(dr["createdate"]);
					}
					if (dr["actions"] != null && dr["actions"] != DBNull.Value)
					{
						item.actions = Convert.ToString(dr["actions"]);
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
		/// Lấy danh sách MedHiStory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedHiStory> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedHiStory] A "+ condition,  parameters);
				List<MedHiStory> items = new List<MedHiStory>();
				MedHiStory item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedHiStory();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["id_his_login"] != null && dr["id_his_login"] != DBNull.Value)
					{
						item.id_his_login = Convert.ToString(dr["id_his_login"]);
					}
					if (dr["createuser"] != null && dr["createuser"] != DBNull.Value)
					{
						item.createuser = Convert.ToString(dr["createuser"]);
					}
					if (dr["createdate"] != null && dr["createdate"] != DBNull.Value)
					{
						item.createdate = Convert.ToDateTime(dr["createdate"]);
					}
					if (dr["actions"] != null && dr["actions"] != DBNull.Value)
					{
						item.actions = Convert.ToString(dr["actions"]);
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

		public List<MedHiStory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedHiStory] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedHiStory] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedHiStory>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedHiStory từ Database
		/// </summary>
		public MedHiStory GetObject(string schema, String id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedHiStory] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedHiStory item=new MedHiStory();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["id_his_login"] != null && dr["id_his_login"] != DBNull.Value)
						{
							item.id_his_login = Convert.ToString(dr["id_his_login"]);
						}
						if (dr["createuser"] != null && dr["createuser"] != DBNull.Value)
						{
							item.createuser = Convert.ToString(dr["createuser"]);
						}
						if (dr["createdate"] != null && dr["createdate"] != DBNull.Value)
						{
							item.createdate = Convert.ToDateTime(dr["createdate"]);
						}
						if (dr["actions"] != null && dr["actions"] != DBNull.Value)
						{
							item.actions = Convert.ToString(dr["actions"]);
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
		/// Lấy một MedHiStory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedHiStory GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedHiStory] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedHiStory item=new MedHiStory();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["id_his_login"] != null && dr["id_his_login"] != DBNull.Value)
						{
							item.id_his_login = Convert.ToString(dr["id_his_login"]);
						}
						if (dr["createuser"] != null && dr["createuser"] != DBNull.Value)
						{
							item.createuser = Convert.ToString(dr["createuser"]);
						}
						if (dr["createdate"] != null && dr["createdate"] != DBNull.Value)
						{
							item.createdate = Convert.ToDateTime(dr["createdate"]);
						}
						if (dr["actions"] != null && dr["actions"] != DBNull.Value)
						{
							item.actions = Convert.ToString(dr["actions"]);
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

		public MedHiStory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedHiStory] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedHiStory>(ds);
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
		/// Thêm mới MedHiStory vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedHiStory _MedHiStory)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedHiStory](id, id_his_login, createuser, createdate, actions) VALUES(@id, @id_his_login, @createuser, @createdate, @actions)", 
					"@id",  _MedHiStory.id, 
					"@id_his_login",  _MedHiStory.id_his_login, 
					"@createuser",  _MedHiStory.createuser, 
					"@createdate", this._dataContext.ConvertDateString( _MedHiStory.createdate), 
					"@actions",  _MedHiStory.actions);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedHiStory vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedHiStory> _MedHiStorys)
		{
			foreach (MedHiStory item in _MedHiStorys)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedHiStory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedHiStory _MedHiStory, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedHiStory] SET id=@id, id_his_login=@id_his_login, createuser=@createuser, createdate=@createdate, actions=@actions WHERE id=@id", 
					"@id",  _MedHiStory.id, 
					"@id_his_login",  _MedHiStory.id_his_login, 
					"@createuser",  _MedHiStory.createuser, 
					"@createdate", this._dataContext.ConvertDateString( _MedHiStory.createdate), 
					"@actions",  _MedHiStory.actions, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedHiStory vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedHiStory _MedHiStory)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedHiStory] SET id_his_login=@id_his_login, createuser=@createuser, createdate=@createdate, actions=@actions WHERE id=@id", 
					"@id_his_login",  _MedHiStory.id_his_login, 
					"@createuser",  _MedHiStory.createuser, 
					"@createdate", this._dataContext.ConvertDateString( _MedHiStory.createdate), 
					"@actions",  _MedHiStory.actions, 
					"@id", _MedHiStory.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedHiStory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedHiStory> _MedHiStorys)
		{
			foreach (MedHiStory item in _MedHiStorys)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedHiStory vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedHiStory _MedHiStory, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedHiStory] SET id=@id, id_his_login=@id_his_login, createuser=@createuser, createdate=@createdate, actions=@actions "+ condition, 
					"@id",  _MedHiStory.id, 
					"@id_his_login",  _MedHiStory.id_his_login, 
					"@createuser",  _MedHiStory.createuser, 
					"@createdate", this._dataContext.ConvertDateString( _MedHiStory.createdate), 
					"@actions",  _MedHiStory.actions);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedHiStory trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedHiStory] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedHiStory trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedHiStory _MedHiStory)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedHiStory] WHERE id=@id",
					"@id", _MedHiStory.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedHiStory trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedHiStory] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedHiStory trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedHiStory> _MedHiStorys)
		{
			foreach (MedHiStory item in _MedHiStorys)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
