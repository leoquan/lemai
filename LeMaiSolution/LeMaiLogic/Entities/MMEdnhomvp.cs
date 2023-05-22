using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdnhomvp:IMEdnhomvp
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdnhomvp(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedNhomVp từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedNhomVp]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedNhomVp từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedNhomVp] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedNhomVp từ Database
		/// </summary>
		public List<MedNhomVp> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedNhomVp]");
				List<MedNhomVp> items = new List<MedNhomVp>();
				MedNhomVp item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedNhomVp();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["ma"] != null && dr["ma"] != DBNull.Value)
					{
						item.ma = Convert.ToString(dr["ma"]);
					}
					if (dr["ten"] != null && dr["ten"] != DBNull.Value)
					{
						item.ten = Convert.ToString(dr["ten"]);
					}
					if (dr["userid"] != null && dr["userid"] != DBNull.Value)
					{
						item.userid = Convert.ToString(dr["userid"]);
					}
					if (dr["id_nhombhyt"] != null && dr["id_nhombhyt"] != DBNull.Value)
					{
						item.id_nhombhyt = Convert.ToInt32(dr["id_nhombhyt"]);
					}
					if (dr["kyhieu"] != null && dr["kyhieu"] != DBNull.Value)
					{
						item.kyhieu = Convert.ToString(dr["kyhieu"]);
					}
					if (dr["report"] != null && dr["report"] != DBNull.Value)
					{
						item.report = Convert.ToString(dr["report"]);
					}
					if (dr["lydo"] != null && dr["lydo"] != DBNull.Value)
					{
						item.lydo = Convert.ToString(dr["lydo"]);
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
		/// Lấy danh sách MedNhomVp từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedNhomVp> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedNhomVp] A "+ condition,  parameters);
				List<MedNhomVp> items = new List<MedNhomVp>();
				MedNhomVp item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedNhomVp();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["ma"] != null && dr["ma"] != DBNull.Value)
					{
						item.ma = Convert.ToString(dr["ma"]);
					}
					if (dr["ten"] != null && dr["ten"] != DBNull.Value)
					{
						item.ten = Convert.ToString(dr["ten"]);
					}
					if (dr["userid"] != null && dr["userid"] != DBNull.Value)
					{
						item.userid = Convert.ToString(dr["userid"]);
					}
					if (dr["id_nhombhyt"] != null && dr["id_nhombhyt"] != DBNull.Value)
					{
						item.id_nhombhyt = Convert.ToInt32(dr["id_nhombhyt"]);
					}
					if (dr["kyhieu"] != null && dr["kyhieu"] != DBNull.Value)
					{
						item.kyhieu = Convert.ToString(dr["kyhieu"]);
					}
					if (dr["report"] != null && dr["report"] != DBNull.Value)
					{
						item.report = Convert.ToString(dr["report"]);
					}
					if (dr["lydo"] != null && dr["lydo"] != DBNull.Value)
					{
						item.lydo = Convert.ToString(dr["lydo"]);
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

		public List<MedNhomVp> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedNhomVp] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedNhomVp] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedNhomVp>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedNhomVp từ Database
		/// </summary>
		public MedNhomVp GetObject(string schema, Int32 id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedNhomVp] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedNhomVp item=new MedNhomVp();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["ma"] != null && dr["ma"] != DBNull.Value)
						{
							item.ma = Convert.ToString(dr["ma"]);
						}
						if (dr["ten"] != null && dr["ten"] != DBNull.Value)
						{
							item.ten = Convert.ToString(dr["ten"]);
						}
						if (dr["userid"] != null && dr["userid"] != DBNull.Value)
						{
							item.userid = Convert.ToString(dr["userid"]);
						}
						if (dr["id_nhombhyt"] != null && dr["id_nhombhyt"] != DBNull.Value)
						{
							item.id_nhombhyt = Convert.ToInt32(dr["id_nhombhyt"]);
						}
						if (dr["kyhieu"] != null && dr["kyhieu"] != DBNull.Value)
						{
							item.kyhieu = Convert.ToString(dr["kyhieu"]);
						}
						if (dr["report"] != null && dr["report"] != DBNull.Value)
						{
							item.report = Convert.ToString(dr["report"]);
						}
						if (dr["lydo"] != null && dr["lydo"] != DBNull.Value)
						{
							item.lydo = Convert.ToString(dr["lydo"]);
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
		/// Lấy một MedNhomVp đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedNhomVp GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedNhomVp] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedNhomVp item=new MedNhomVp();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["ma"] != null && dr["ma"] != DBNull.Value)
						{
							item.ma = Convert.ToString(dr["ma"]);
						}
						if (dr["ten"] != null && dr["ten"] != DBNull.Value)
						{
							item.ten = Convert.ToString(dr["ten"]);
						}
						if (dr["userid"] != null && dr["userid"] != DBNull.Value)
						{
							item.userid = Convert.ToString(dr["userid"]);
						}
						if (dr["id_nhombhyt"] != null && dr["id_nhombhyt"] != DBNull.Value)
						{
							item.id_nhombhyt = Convert.ToInt32(dr["id_nhombhyt"]);
						}
						if (dr["kyhieu"] != null && dr["kyhieu"] != DBNull.Value)
						{
							item.kyhieu = Convert.ToString(dr["kyhieu"]);
						}
						if (dr["report"] != null && dr["report"] != DBNull.Value)
						{
							item.report = Convert.ToString(dr["report"]);
						}
						if (dr["lydo"] != null && dr["lydo"] != DBNull.Value)
						{
							item.lydo = Convert.ToString(dr["lydo"]);
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

		public MedNhomVp GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedNhomVp] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedNhomVp>(ds);
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
		/// Thêm mới MedNhomVp vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedNhomVp _MedNhomVp)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedNhomVp](id, ma, ten, userid, id_nhombhyt, kyhieu, report, lydo) VALUES(@id, @ma, @ten, @userid, @id_nhombhyt, @kyhieu, @report, @lydo)", 
					"@id",  _MedNhomVp.id, 
					"@ma",  _MedNhomVp.ma, 
					"@ten",  _MedNhomVp.ten, 
					"@userid",  _MedNhomVp.userid, 
					"@id_nhombhyt",  _MedNhomVp.id_nhombhyt, 
					"@kyhieu",  _MedNhomVp.kyhieu, 
					"@report",  _MedNhomVp.report, 
					"@lydo",  _MedNhomVp.lydo);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedNhomVp vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedNhomVp> _MedNhomVps)
		{
			foreach (MedNhomVp item in _MedNhomVps)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedNhomVp vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedNhomVp _MedNhomVp, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedNhomVp] SET id=@id, ma=@ma, ten=@ten, userid=@userid, id_nhombhyt=@id_nhombhyt, kyhieu=@kyhieu, report=@report, lydo=@lydo WHERE id=@id", 
					"@id",  _MedNhomVp.id, 
					"@ma",  _MedNhomVp.ma, 
					"@ten",  _MedNhomVp.ten, 
					"@userid",  _MedNhomVp.userid, 
					"@id_nhombhyt",  _MedNhomVp.id_nhombhyt, 
					"@kyhieu",  _MedNhomVp.kyhieu, 
					"@report",  _MedNhomVp.report, 
					"@lydo",  _MedNhomVp.lydo, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedNhomVp vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedNhomVp _MedNhomVp)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedNhomVp] SET ma=@ma, ten=@ten, userid=@userid, id_nhombhyt=@id_nhombhyt, kyhieu=@kyhieu, report=@report, lydo=@lydo WHERE id=@id", 
					"@ma",  _MedNhomVp.ma, 
					"@ten",  _MedNhomVp.ten, 
					"@userid",  _MedNhomVp.userid, 
					"@id_nhombhyt",  _MedNhomVp.id_nhombhyt, 
					"@kyhieu",  _MedNhomVp.kyhieu, 
					"@report",  _MedNhomVp.report, 
					"@lydo",  _MedNhomVp.lydo, 
					"@id", _MedNhomVp.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedNhomVp vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedNhomVp> _MedNhomVps)
		{
			foreach (MedNhomVp item in _MedNhomVps)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedNhomVp vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedNhomVp _MedNhomVp, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedNhomVp] SET id=@id, ma=@ma, ten=@ten, userid=@userid, id_nhombhyt=@id_nhombhyt, kyhieu=@kyhieu, report=@report, lydo=@lydo "+ condition, 
					"@id",  _MedNhomVp.id, 
					"@ma",  _MedNhomVp.ma, 
					"@ten",  _MedNhomVp.ten, 
					"@userid",  _MedNhomVp.userid, 
					"@id_nhombhyt",  _MedNhomVp.id_nhombhyt, 
					"@kyhieu",  _MedNhomVp.kyhieu, 
					"@report",  _MedNhomVp.report, 
					"@lydo",  _MedNhomVp.lydo);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedNhomVp trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedNhomVp] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedNhomVp trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedNhomVp _MedNhomVp)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedNhomVp] WHERE id=@id",
					"@id", _MedNhomVp.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedNhomVp trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedNhomVp] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedNhomVp trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedNhomVp> _MedNhomVps)
		{
			foreach (MedNhomVp item in _MedNhomVps)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
