using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdketquadcm:IMEdketquadcm
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdketquadcm(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedKetQuaDcm từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaDcm]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedKetQuaDcm từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaDcm] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedKetQuaDcm từ Database
		/// </summary>
		public List<MedKetQuaDcm> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaDcm]");
				List<MedKetQuaDcm> items = new List<MedKetQuaDcm>();
				MedKetQuaDcm item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedKetQuaDcm();
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
					if (dr["imagefile"] != null && dr["imagefile"] != DBNull.Value)
					{
						item.imagefile = Convert.ToString(dr["imagefile"]);
					}
					if (dr["dcmfile"] != null && dr["dcmfile"] != DBNull.Value)
					{
						item.dcmfile = Convert.ToString(dr["dcmfile"]);
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
		/// Lấy danh sách MedKetQuaDcm từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedKetQuaDcm> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedKetQuaDcm] A "+ condition,  parameters);
				List<MedKetQuaDcm> items = new List<MedKetQuaDcm>();
				MedKetQuaDcm item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedKetQuaDcm();
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
					if (dr["imagefile"] != null && dr["imagefile"] != DBNull.Value)
					{
						item.imagefile = Convert.ToString(dr["imagefile"]);
					}
					if (dr["dcmfile"] != null && dr["dcmfile"] != DBNull.Value)
					{
						item.dcmfile = Convert.ToString(dr["dcmfile"]);
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
					items.Add(item);
				}
				return items;
			}
			catch
			{
				throw;
			}
		}

		public List<MedKetQuaDcm> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedKetQuaDcm] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedKetQuaDcm] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedKetQuaDcm>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedKetQuaDcm từ Database
		/// </summary>
		public MedKetQuaDcm GetObject(string schema, String id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaDcm] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedKetQuaDcm item=new MedKetQuaDcm();
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
						if (dr["imagefile"] != null && dr["imagefile"] != DBNull.Value)
						{
							item.imagefile = Convert.ToString(dr["imagefile"]);
						}
						if (dr["dcmfile"] != null && dr["dcmfile"] != DBNull.Value)
						{
							item.dcmfile = Convert.ToString(dr["dcmfile"]);
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
		/// Lấy một MedKetQuaDcm đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedKetQuaDcm GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedKetQuaDcm] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedKetQuaDcm item=new MedKetQuaDcm();
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
						if (dr["imagefile"] != null && dr["imagefile"] != DBNull.Value)
						{
							item.imagefile = Convert.ToString(dr["imagefile"]);
						}
						if (dr["dcmfile"] != null && dr["dcmfile"] != DBNull.Value)
						{
							item.dcmfile = Convert.ToString(dr["dcmfile"]);
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

		public MedKetQuaDcm GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedKetQuaDcm] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedKetQuaDcm>(ds);
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
		/// Thêm mới MedKetQuaDcm vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedKetQuaDcm _MedKetQuaDcm)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedKetQuaDcm](id, somau, maql, imagefile, dcmfile, localpath, remotepath, ghichu, createdate, updatedate) VALUES(@id, @somau, @maql, @imagefile, @dcmfile, @localpath, @remotepath, @ghichu, @createdate, @updatedate)", 
					"@id",  _MedKetQuaDcm.id, 
					"@somau",  _MedKetQuaDcm.somau, 
					"@maql",  _MedKetQuaDcm.maql, 
					"@imagefile",  _MedKetQuaDcm.imagefile, 
					"@dcmfile",  _MedKetQuaDcm.dcmfile, 
					"@localpath",  _MedKetQuaDcm.localpath, 
					"@remotepath",  _MedKetQuaDcm.remotepath, 
					"@ghichu",  _MedKetQuaDcm.ghichu, 
					"@createdate", this._dataContext.ConvertDateString( _MedKetQuaDcm.createdate), 
					"@updatedate", this._dataContext.ConvertDateString( _MedKetQuaDcm.updatedate));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedKetQuaDcm vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedKetQuaDcm> _MedKetQuaDcms)
		{
			foreach (MedKetQuaDcm item in _MedKetQuaDcms)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaDcm vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedKetQuaDcm _MedKetQuaDcm, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaDcm] SET id=@id, somau=@somau, maql=@maql, imagefile=@imagefile, dcmfile=@dcmfile, localpath=@localpath, remotepath=@remotepath, ghichu=@ghichu, createdate=@createdate, updatedate=@updatedate WHERE id=@id", 
					"@id",  _MedKetQuaDcm.id, 
					"@somau",  _MedKetQuaDcm.somau, 
					"@maql",  _MedKetQuaDcm.maql, 
					"@imagefile",  _MedKetQuaDcm.imagefile, 
					"@dcmfile",  _MedKetQuaDcm.dcmfile, 
					"@localpath",  _MedKetQuaDcm.localpath, 
					"@remotepath",  _MedKetQuaDcm.remotepath, 
					"@ghichu",  _MedKetQuaDcm.ghichu, 
					"@createdate", this._dataContext.ConvertDateString( _MedKetQuaDcm.createdate), 
					"@updatedate", this._dataContext.ConvertDateString( _MedKetQuaDcm.updatedate), 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaDcm vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedKetQuaDcm _MedKetQuaDcm)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaDcm] SET somau=@somau, maql=@maql, imagefile=@imagefile, dcmfile=@dcmfile, localpath=@localpath, remotepath=@remotepath, ghichu=@ghichu, createdate=@createdate, updatedate=@updatedate WHERE id=@id", 
					"@somau",  _MedKetQuaDcm.somau, 
					"@maql",  _MedKetQuaDcm.maql, 
					"@imagefile",  _MedKetQuaDcm.imagefile, 
					"@dcmfile",  _MedKetQuaDcm.dcmfile, 
					"@localpath",  _MedKetQuaDcm.localpath, 
					"@remotepath",  _MedKetQuaDcm.remotepath, 
					"@ghichu",  _MedKetQuaDcm.ghichu, 
					"@createdate", this._dataContext.ConvertDateString( _MedKetQuaDcm.createdate), 
					"@updatedate", this._dataContext.ConvertDateString( _MedKetQuaDcm.updatedate), 
					"@id", _MedKetQuaDcm.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedKetQuaDcm vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedKetQuaDcm> _MedKetQuaDcms)
		{
			foreach (MedKetQuaDcm item in _MedKetQuaDcms)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaDcm vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedKetQuaDcm _MedKetQuaDcm, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaDcm] SET id=@id, somau=@somau, maql=@maql, imagefile=@imagefile, dcmfile=@dcmfile, localpath=@localpath, remotepath=@remotepath, ghichu=@ghichu, createdate=@createdate, updatedate=@updatedate "+ condition, 
					"@id",  _MedKetQuaDcm.id, 
					"@somau",  _MedKetQuaDcm.somau, 
					"@maql",  _MedKetQuaDcm.maql, 
					"@imagefile",  _MedKetQuaDcm.imagefile, 
					"@dcmfile",  _MedKetQuaDcm.dcmfile, 
					"@localpath",  _MedKetQuaDcm.localpath, 
					"@remotepath",  _MedKetQuaDcm.remotepath, 
					"@ghichu",  _MedKetQuaDcm.ghichu, 
					"@createdate", this._dataContext.ConvertDateString( _MedKetQuaDcm.createdate), 
					"@updatedate", this._dataContext.ConvertDateString( _MedKetQuaDcm.updatedate));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedKetQuaDcm trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaDcm] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaDcm trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedKetQuaDcm _MedKetQuaDcm)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaDcm] WHERE id=@id",
					"@id", _MedKetQuaDcm.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaDcm trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaDcm] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaDcm trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedKetQuaDcm> _MedKetQuaDcms)
		{
			foreach (MedKetQuaDcm item in _MedKetQuaDcms)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
