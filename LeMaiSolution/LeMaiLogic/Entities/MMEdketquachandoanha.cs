using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdketquachandoanha:IMEdketquachandoanha
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdketquachandoanha(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedKetQuaChanDoanHA từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaChanDoanHA]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedKetQuaChanDoanHA từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaChanDoanHA] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedKetQuaChanDoanHA từ Database
		/// </summary>
		public List<MedKetQuaChanDoanHA> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaChanDoanHA]");
				List<MedKetQuaChanDoanHA> items = new List<MedKetQuaChanDoanHA>();
				MedKetQuaChanDoanHA item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedKetQuaChanDoanHA();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["id_ketquachandoan"] != null && dr["id_ketquachandoan"] != DBNull.Value)
					{
						item.id_ketquachandoan = Convert.ToString(dr["id_ketquachandoan"]);
					}
					if (dr["id_server"] != null && dr["id_server"] != DBNull.Value)
					{
						item.id_server = Convert.ToString(dr["id_server"]);
					}
					if (dr["filename"] != null && dr["filename"] != DBNull.Value)
					{
						item.filename = Convert.ToString(dr["filename"]);
					}
					if (dr["localpath"] != null && dr["localpath"] != DBNull.Value)
					{
						item.localpath = Convert.ToString(dr["localpath"]);
					}
					if (dr["remotepath"] != null && dr["remotepath"] != DBNull.Value)
					{
						item.remotepath = Convert.ToString(dr["remotepath"]);
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
		/// Lấy danh sách MedKetQuaChanDoanHA từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedKetQuaChanDoanHA> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedKetQuaChanDoanHA] A "+ condition,  parameters);
				List<MedKetQuaChanDoanHA> items = new List<MedKetQuaChanDoanHA>();
				MedKetQuaChanDoanHA item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedKetQuaChanDoanHA();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["id_ketquachandoan"] != null && dr["id_ketquachandoan"] != DBNull.Value)
					{
						item.id_ketquachandoan = Convert.ToString(dr["id_ketquachandoan"]);
					}
					if (dr["id_server"] != null && dr["id_server"] != DBNull.Value)
					{
						item.id_server = Convert.ToString(dr["id_server"]);
					}
					if (dr["filename"] != null && dr["filename"] != DBNull.Value)
					{
						item.filename = Convert.ToString(dr["filename"]);
					}
					if (dr["localpath"] != null && dr["localpath"] != DBNull.Value)
					{
						item.localpath = Convert.ToString(dr["localpath"]);
					}
					if (dr["remotepath"] != null && dr["remotepath"] != DBNull.Value)
					{
						item.remotepath = Convert.ToString(dr["remotepath"]);
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

		public List<MedKetQuaChanDoanHA> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedKetQuaChanDoanHA] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedKetQuaChanDoanHA] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedKetQuaChanDoanHA>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedKetQuaChanDoanHA từ Database
		/// </summary>
		public MedKetQuaChanDoanHA GetObject(string schema, String id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaChanDoanHA] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedKetQuaChanDoanHA item=new MedKetQuaChanDoanHA();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["id_ketquachandoan"] != null && dr["id_ketquachandoan"] != DBNull.Value)
						{
							item.id_ketquachandoan = Convert.ToString(dr["id_ketquachandoan"]);
						}
						if (dr["id_server"] != null && dr["id_server"] != DBNull.Value)
						{
							item.id_server = Convert.ToString(dr["id_server"]);
						}
						if (dr["filename"] != null && dr["filename"] != DBNull.Value)
						{
							item.filename = Convert.ToString(dr["filename"]);
						}
						if (dr["localpath"] != null && dr["localpath"] != DBNull.Value)
						{
							item.localpath = Convert.ToString(dr["localpath"]);
						}
						if (dr["remotepath"] != null && dr["remotepath"] != DBNull.Value)
						{
							item.remotepath = Convert.ToString(dr["remotepath"]);
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
		/// Lấy một MedKetQuaChanDoanHA đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedKetQuaChanDoanHA GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedKetQuaChanDoanHA] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedKetQuaChanDoanHA item=new MedKetQuaChanDoanHA();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["id_ketquachandoan"] != null && dr["id_ketquachandoan"] != DBNull.Value)
						{
							item.id_ketquachandoan = Convert.ToString(dr["id_ketquachandoan"]);
						}
						if (dr["id_server"] != null && dr["id_server"] != DBNull.Value)
						{
							item.id_server = Convert.ToString(dr["id_server"]);
						}
						if (dr["filename"] != null && dr["filename"] != DBNull.Value)
						{
							item.filename = Convert.ToString(dr["filename"]);
						}
						if (dr["localpath"] != null && dr["localpath"] != DBNull.Value)
						{
							item.localpath = Convert.ToString(dr["localpath"]);
						}
						if (dr["remotepath"] != null && dr["remotepath"] != DBNull.Value)
						{
							item.remotepath = Convert.ToString(dr["remotepath"]);
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

		public MedKetQuaChanDoanHA GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedKetQuaChanDoanHA] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedKetQuaChanDoanHA>(ds);
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
		/// Thêm mới MedKetQuaChanDoanHA vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedKetQuaChanDoanHA _MedKetQuaChanDoanHA)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedKetQuaChanDoanHA](id, id_ketquachandoan, id_server, filename, localpath, remotepath) VALUES(@id, @id_ketquachandoan, @id_server, @filename, @localpath, @remotepath)", 
					"@id",  _MedKetQuaChanDoanHA.id, 
					"@id_ketquachandoan",  _MedKetQuaChanDoanHA.id_ketquachandoan, 
					"@id_server",  _MedKetQuaChanDoanHA.id_server, 
					"@filename",  _MedKetQuaChanDoanHA.filename, 
					"@localpath",  _MedKetQuaChanDoanHA.localpath, 
					"@remotepath",  _MedKetQuaChanDoanHA.remotepath);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedKetQuaChanDoanHA vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedKetQuaChanDoanHA> _MedKetQuaChanDoanHAs)
		{
			foreach (MedKetQuaChanDoanHA item in _MedKetQuaChanDoanHAs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaChanDoanHA vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedKetQuaChanDoanHA _MedKetQuaChanDoanHA, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaChanDoanHA] SET id=@id, id_ketquachandoan=@id_ketquachandoan, id_server=@id_server, filename=@filename, localpath=@localpath, remotepath=@remotepath WHERE id=@id", 
					"@id",  _MedKetQuaChanDoanHA.id, 
					"@id_ketquachandoan",  _MedKetQuaChanDoanHA.id_ketquachandoan, 
					"@id_server",  _MedKetQuaChanDoanHA.id_server, 
					"@filename",  _MedKetQuaChanDoanHA.filename, 
					"@localpath",  _MedKetQuaChanDoanHA.localpath, 
					"@remotepath",  _MedKetQuaChanDoanHA.remotepath, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaChanDoanHA vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedKetQuaChanDoanHA _MedKetQuaChanDoanHA)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaChanDoanHA] SET id_ketquachandoan=@id_ketquachandoan, id_server=@id_server, filename=@filename, localpath=@localpath, remotepath=@remotepath WHERE id=@id", 
					"@id_ketquachandoan",  _MedKetQuaChanDoanHA.id_ketquachandoan, 
					"@id_server",  _MedKetQuaChanDoanHA.id_server, 
					"@filename",  _MedKetQuaChanDoanHA.filename, 
					"@localpath",  _MedKetQuaChanDoanHA.localpath, 
					"@remotepath",  _MedKetQuaChanDoanHA.remotepath, 
					"@id", _MedKetQuaChanDoanHA.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedKetQuaChanDoanHA vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedKetQuaChanDoanHA> _MedKetQuaChanDoanHAs)
		{
			foreach (MedKetQuaChanDoanHA item in _MedKetQuaChanDoanHAs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaChanDoanHA vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedKetQuaChanDoanHA _MedKetQuaChanDoanHA, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaChanDoanHA] SET id=@id, id_ketquachandoan=@id_ketquachandoan, id_server=@id_server, filename=@filename, localpath=@localpath, remotepath=@remotepath "+ condition, 
					"@id",  _MedKetQuaChanDoanHA.id, 
					"@id_ketquachandoan",  _MedKetQuaChanDoanHA.id_ketquachandoan, 
					"@id_server",  _MedKetQuaChanDoanHA.id_server, 
					"@filename",  _MedKetQuaChanDoanHA.filename, 
					"@localpath",  _MedKetQuaChanDoanHA.localpath, 
					"@remotepath",  _MedKetQuaChanDoanHA.remotepath);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedKetQuaChanDoanHA trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaChanDoanHA] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaChanDoanHA trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedKetQuaChanDoanHA _MedKetQuaChanDoanHA)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaChanDoanHA] WHERE id=@id",
					"@id", _MedKetQuaChanDoanHA.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaChanDoanHA trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaChanDoanHA] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaChanDoanHA trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedKetQuaChanDoanHA> _MedKetQuaChanDoanHAs)
		{
			foreach (MedKetQuaChanDoanHA item in _MedKetQuaChanDoanHAs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
