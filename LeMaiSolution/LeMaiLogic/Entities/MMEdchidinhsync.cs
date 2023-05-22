using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdchidinhsync:IMEdchidinhsync
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdchidinhsync(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedChiDinhSync từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedChiDinhSync]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedChiDinhSync từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedChiDinhSync] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedChiDinhSync từ Database
		/// </summary>
		public List<MedChiDinhSync> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedChiDinhSync]");
				List<MedChiDinhSync> items = new List<MedChiDinhSync>();
				MedChiDinhSync item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedChiDinhSync();
					if (dr["id_local"] != null && dr["id_local"] != DBNull.Value)
					{
						item.id_local = Convert.ToString(dr["id_local"]);
					}
					if (dr["id_remote"] != null && dr["id_remote"] != DBNull.Value)
					{
						item.id_remote = Convert.ToString(dr["id_remote"]);
					}
					if (dr["maql"] != null && dr["maql"] != DBNull.Value)
					{
						item.maql = Convert.ToString(dr["maql"]);
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
		/// Lấy danh sách MedChiDinhSync từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedChiDinhSync> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedChiDinhSync] A "+ condition,  parameters);
				List<MedChiDinhSync> items = new List<MedChiDinhSync>();
				MedChiDinhSync item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedChiDinhSync();
					if (dr["id_local"] != null && dr["id_local"] != DBNull.Value)
					{
						item.id_local = Convert.ToString(dr["id_local"]);
					}
					if (dr["id_remote"] != null && dr["id_remote"] != DBNull.Value)
					{
						item.id_remote = Convert.ToString(dr["id_remote"]);
					}
					if (dr["maql"] != null && dr["maql"] != DBNull.Value)
					{
						item.maql = Convert.ToString(dr["maql"]);
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

		public List<MedChiDinhSync> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedChiDinhSync] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedChiDinhSync] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedChiDinhSync>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedChiDinhSync từ Database
		/// </summary>
		public MedChiDinhSync GetObject(string schema, String id_local)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedChiDinhSync] where id_local=@id_local",
					"@id_local", id_local);
				if (ds.Rows.Count > 0)
				{
					MedChiDinhSync item=new MedChiDinhSync();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id_local"] != null && dr["id_local"] != DBNull.Value)
						{
							item.id_local = Convert.ToString(dr["id_local"]);
						}
						if (dr["id_remote"] != null && dr["id_remote"] != DBNull.Value)
						{
							item.id_remote = Convert.ToString(dr["id_remote"]);
						}
						if (dr["maql"] != null && dr["maql"] != DBNull.Value)
						{
							item.maql = Convert.ToString(dr["maql"]);
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
		/// Lấy một MedChiDinhSync đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedChiDinhSync GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedChiDinhSync] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedChiDinhSync item=new MedChiDinhSync();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id_local"] != null && dr["id_local"] != DBNull.Value)
						{
							item.id_local = Convert.ToString(dr["id_local"]);
						}
						if (dr["id_remote"] != null && dr["id_remote"] != DBNull.Value)
						{
							item.id_remote = Convert.ToString(dr["id_remote"]);
						}
						if (dr["maql"] != null && dr["maql"] != DBNull.Value)
						{
							item.maql = Convert.ToString(dr["maql"]);
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

		public MedChiDinhSync GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedChiDinhSync] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedChiDinhSync>(ds);
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
		/// Thêm mới MedChiDinhSync vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedChiDinhSync _MedChiDinhSync)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedChiDinhSync](id_local, id_remote, maql) VALUES(@id_local, @id_remote, @maql)", 
					"@id_local",  _MedChiDinhSync.id_local, 
					"@id_remote",  _MedChiDinhSync.id_remote, 
					"@maql",  _MedChiDinhSync.maql);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedChiDinhSync vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedChiDinhSync> _MedChiDinhSyncs)
		{
			foreach (MedChiDinhSync item in _MedChiDinhSyncs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedChiDinhSync vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedChiDinhSync _MedChiDinhSync, String id_local)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedChiDinhSync] SET id_local=@id_local, id_remote=@id_remote, maql=@maql WHERE id_local=@id_local", 
					"@id_local",  _MedChiDinhSync.id_local, 
					"@id_remote",  _MedChiDinhSync.id_remote, 
					"@maql",  _MedChiDinhSync.maql, 
					"@id_local", id_local);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedChiDinhSync vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedChiDinhSync _MedChiDinhSync)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedChiDinhSync] SET id_remote=@id_remote, maql=@maql WHERE id_local=@id_local", 
					"@id_remote",  _MedChiDinhSync.id_remote, 
					"@maql",  _MedChiDinhSync.maql, 
					"@id_local", _MedChiDinhSync.id_local);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedChiDinhSync vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedChiDinhSync> _MedChiDinhSyncs)
		{
			foreach (MedChiDinhSync item in _MedChiDinhSyncs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedChiDinhSync vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedChiDinhSync _MedChiDinhSync, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedChiDinhSync] SET id_local=@id_local, id_remote=@id_remote, maql=@maql "+ condition, 
					"@id_local",  _MedChiDinhSync.id_local, 
					"@id_remote",  _MedChiDinhSync.id_remote, 
					"@maql",  _MedChiDinhSync.maql);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedChiDinhSync trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id_local)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedChiDinhSync] WHERE id_local=@id_local",
					"@id_local", id_local);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedChiDinhSync trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedChiDinhSync _MedChiDinhSync)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedChiDinhSync] WHERE id_local=@id_local",
					"@id_local", _MedChiDinhSync.id_local);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedChiDinhSync trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedChiDinhSync] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedChiDinhSync trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedChiDinhSync> _MedChiDinhSyncs)
		{
			foreach (MedChiDinhSync item in _MedChiDinhSyncs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
