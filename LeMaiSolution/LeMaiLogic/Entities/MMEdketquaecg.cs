using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdketquaecg:IMEdketquaecg
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdketquaecg(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedKetQuaEcg từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaEcg]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedKetQuaEcg từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaEcg] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedKetQuaEcg từ Database
		/// </summary>
		public List<MedKetQuaEcg> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaEcg]");
				List<MedKetQuaEcg> items = new List<MedKetQuaEcg>();
				MedKetQuaEcg item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedKetQuaEcg();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["somau"] != null && dr["somau"] != DBNull.Value)
					{
						item.somau = Convert.ToInt32(dr["somau"]);
					}
					if (dr["maql"] != null && dr["maql"] != DBNull.Value)
					{
						item.maql = Convert.ToString(dr["maql"]);
					}
					if (dr["machinename"] != null && dr["machinename"] != DBNull.Value)
					{
						item.machinename = Convert.ToString(dr["machinename"]);
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
					if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
					{
						item.ghichu = Convert.ToString(dr["ghichu"]);
					}
					if (dr["createdate"] != null && dr["createdate"] != DBNull.Value)
					{
						item.createdate = Convert.ToDateTime(dr["createdate"]);
					}
					if (dr["updatedate"] != null && dr["updatedate"] != DBNull.Value)
					{
						item.updatedate = Convert.ToDateTime(dr["updatedate"]);
					}
					if (dr["localcheckfile"] != null && dr["localcheckfile"] != DBNull.Value)
					{
						item.localcheckfile = Convert.ToString(dr["localcheckfile"]);
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
		/// Lấy danh sách MedKetQuaEcg từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedKetQuaEcg> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedKetQuaEcg] A "+ condition,  parameters);
				List<MedKetQuaEcg> items = new List<MedKetQuaEcg>();
				MedKetQuaEcg item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedKetQuaEcg();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["somau"] != null && dr["somau"] != DBNull.Value)
					{
						item.somau = Convert.ToInt32(dr["somau"]);
					}
					if (dr["maql"] != null && dr["maql"] != DBNull.Value)
					{
						item.maql = Convert.ToString(dr["maql"]);
					}
					if (dr["machinename"] != null && dr["machinename"] != DBNull.Value)
					{
						item.machinename = Convert.ToString(dr["machinename"]);
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
					if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
					{
						item.ghichu = Convert.ToString(dr["ghichu"]);
					}
					if (dr["createdate"] != null && dr["createdate"] != DBNull.Value)
					{
						item.createdate = Convert.ToDateTime(dr["createdate"]);
					}
					if (dr["updatedate"] != null && dr["updatedate"] != DBNull.Value)
					{
						item.updatedate = Convert.ToDateTime(dr["updatedate"]);
					}
					if (dr["localcheckfile"] != null && dr["localcheckfile"] != DBNull.Value)
					{
						item.localcheckfile = Convert.ToString(dr["localcheckfile"]);
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

		public List<MedKetQuaEcg> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedKetQuaEcg] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedKetQuaEcg] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedKetQuaEcg>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedKetQuaEcg từ Database
		/// </summary>
		public MedKetQuaEcg GetObject(string schema, String id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaEcg] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedKetQuaEcg item=new MedKetQuaEcg();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["somau"] != null && dr["somau"] != DBNull.Value)
						{
							item.somau = Convert.ToInt32(dr["somau"]);
						}
						if (dr["maql"] != null && dr["maql"] != DBNull.Value)
						{
							item.maql = Convert.ToString(dr["maql"]);
						}
						if (dr["machinename"] != null && dr["machinename"] != DBNull.Value)
						{
							item.machinename = Convert.ToString(dr["machinename"]);
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
						if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
						{
							item.ghichu = Convert.ToString(dr["ghichu"]);
						}
						if (dr["createdate"] != null && dr["createdate"] != DBNull.Value)
						{
							item.createdate = Convert.ToDateTime(dr["createdate"]);
						}
						if (dr["updatedate"] != null && dr["updatedate"] != DBNull.Value)
						{
							item.updatedate = Convert.ToDateTime(dr["updatedate"]);
						}
						if (dr["localcheckfile"] != null && dr["localcheckfile"] != DBNull.Value)
						{
							item.localcheckfile = Convert.ToString(dr["localcheckfile"]);
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
		/// Lấy một MedKetQuaEcg đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedKetQuaEcg GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedKetQuaEcg] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedKetQuaEcg item=new MedKetQuaEcg();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["somau"] != null && dr["somau"] != DBNull.Value)
						{
							item.somau = Convert.ToInt32(dr["somau"]);
						}
						if (dr["maql"] != null && dr["maql"] != DBNull.Value)
						{
							item.maql = Convert.ToString(dr["maql"]);
						}
						if (dr["machinename"] != null && dr["machinename"] != DBNull.Value)
						{
							item.machinename = Convert.ToString(dr["machinename"]);
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
						if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
						{
							item.ghichu = Convert.ToString(dr["ghichu"]);
						}
						if (dr["createdate"] != null && dr["createdate"] != DBNull.Value)
						{
							item.createdate = Convert.ToDateTime(dr["createdate"]);
						}
						if (dr["updatedate"] != null && dr["updatedate"] != DBNull.Value)
						{
							item.updatedate = Convert.ToDateTime(dr["updatedate"]);
						}
						if (dr["localcheckfile"] != null && dr["localcheckfile"] != DBNull.Value)
						{
							item.localcheckfile = Convert.ToString(dr["localcheckfile"]);
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

		public MedKetQuaEcg GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedKetQuaEcg] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedKetQuaEcg>(ds);
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
		/// Thêm mới MedKetQuaEcg vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedKetQuaEcg _MedKetQuaEcg)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedKetQuaEcg](id, somau, maql, machinename, filename, localpath, remotepath, ghichu, createdate, updatedate, localcheckfile) VALUES(@id, @somau, @maql, @machinename, @filename, @localpath, @remotepath, @ghichu, @createdate, @updatedate, @localcheckfile)", 
					"@id",  _MedKetQuaEcg.id, 
					"@somau",  _MedKetQuaEcg.somau, 
					"@maql",  _MedKetQuaEcg.maql, 
					"@machinename",  _MedKetQuaEcg.machinename, 
					"@filename",  _MedKetQuaEcg.filename, 
					"@localpath",  _MedKetQuaEcg.localpath, 
					"@remotepath",  _MedKetQuaEcg.remotepath, 
					"@ghichu",  _MedKetQuaEcg.ghichu, 
					"@createdate", this._dataContext.ConvertDateString( _MedKetQuaEcg.createdate), 
					"@updatedate", this._dataContext.ConvertDateString( _MedKetQuaEcg.updatedate), 
					"@localcheckfile",  _MedKetQuaEcg.localcheckfile);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedKetQuaEcg vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedKetQuaEcg> _MedKetQuaEcgs)
		{
			foreach (MedKetQuaEcg item in _MedKetQuaEcgs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaEcg vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedKetQuaEcg _MedKetQuaEcg, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaEcg] SET id=@id, somau=@somau, maql=@maql, machinename=@machinename, filename=@filename, localpath=@localpath, remotepath=@remotepath, ghichu=@ghichu, createdate=@createdate, updatedate=@updatedate, localcheckfile=@localcheckfile WHERE id=@id", 
					"@id",  _MedKetQuaEcg.id, 
					"@somau",  _MedKetQuaEcg.somau, 
					"@maql",  _MedKetQuaEcg.maql, 
					"@machinename",  _MedKetQuaEcg.machinename, 
					"@filename",  _MedKetQuaEcg.filename, 
					"@localpath",  _MedKetQuaEcg.localpath, 
					"@remotepath",  _MedKetQuaEcg.remotepath, 
					"@ghichu",  _MedKetQuaEcg.ghichu, 
					"@createdate", this._dataContext.ConvertDateString( _MedKetQuaEcg.createdate), 
					"@updatedate", this._dataContext.ConvertDateString( _MedKetQuaEcg.updatedate), 
					"@localcheckfile",  _MedKetQuaEcg.localcheckfile, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaEcg vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedKetQuaEcg _MedKetQuaEcg)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaEcg] SET somau=@somau, maql=@maql, machinename=@machinename, filename=@filename, localpath=@localpath, remotepath=@remotepath, ghichu=@ghichu, createdate=@createdate, updatedate=@updatedate, localcheckfile=@localcheckfile WHERE id=@id", 
					"@somau",  _MedKetQuaEcg.somau, 
					"@maql",  _MedKetQuaEcg.maql, 
					"@machinename",  _MedKetQuaEcg.machinename, 
					"@filename",  _MedKetQuaEcg.filename, 
					"@localpath",  _MedKetQuaEcg.localpath, 
					"@remotepath",  _MedKetQuaEcg.remotepath, 
					"@ghichu",  _MedKetQuaEcg.ghichu, 
					"@createdate", this._dataContext.ConvertDateString( _MedKetQuaEcg.createdate), 
					"@updatedate", this._dataContext.ConvertDateString( _MedKetQuaEcg.updatedate), 
					"@localcheckfile",  _MedKetQuaEcg.localcheckfile, 
					"@id", _MedKetQuaEcg.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedKetQuaEcg vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedKetQuaEcg> _MedKetQuaEcgs)
		{
			foreach (MedKetQuaEcg item in _MedKetQuaEcgs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaEcg vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedKetQuaEcg _MedKetQuaEcg, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaEcg] SET id=@id, somau=@somau, maql=@maql, machinename=@machinename, filename=@filename, localpath=@localpath, remotepath=@remotepath, ghichu=@ghichu, createdate=@createdate, updatedate=@updatedate, localcheckfile=@localcheckfile "+ condition, 
					"@id",  _MedKetQuaEcg.id, 
					"@somau",  _MedKetQuaEcg.somau, 
					"@maql",  _MedKetQuaEcg.maql, 
					"@machinename",  _MedKetQuaEcg.machinename, 
					"@filename",  _MedKetQuaEcg.filename, 
					"@localpath",  _MedKetQuaEcg.localpath, 
					"@remotepath",  _MedKetQuaEcg.remotepath, 
					"@ghichu",  _MedKetQuaEcg.ghichu, 
					"@createdate", this._dataContext.ConvertDateString( _MedKetQuaEcg.createdate), 
					"@updatedate", this._dataContext.ConvertDateString( _MedKetQuaEcg.updatedate), 
					"@localcheckfile",  _MedKetQuaEcg.localcheckfile);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedKetQuaEcg trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaEcg] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaEcg trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedKetQuaEcg _MedKetQuaEcg)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaEcg] WHERE id=@id",
					"@id", _MedKetQuaEcg.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaEcg trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaEcg] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaEcg trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedKetQuaEcg> _MedKetQuaEcgs)
		{
			foreach (MedKetQuaEcg item in _MedKetQuaEcgs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
